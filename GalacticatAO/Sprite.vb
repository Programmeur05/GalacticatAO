Module Sprite
    Structure Sprite
        Dim Picture As Bitmap
        Dim Cellwidth As Integer
        Dim Cellheight As Integer
        Dim cellcount As Integer
        Dim CellTop As Integer
        Dim StartPosition As Point
        Dim Position As Point
        Dim Speed As Point
        Dim Startspeed As Point
        Dim MRectangle As Rectangle
        Dim FacingRight As Boolean
        Dim OnFloor As Boolean
        Dim Radius As Integer
        Dim State As Integer
        Dim TimeFlipped As Integer
    End Structure

    Public MilkTimer As Integer
    Public Const normal As Integer = 0
    Public Const dead As Integer = 1
    Public Const revive As Integer = 2
    Public Const flipped As Integer = 3
    Public nBad As Integer = SelectDif.difficulty
    Public Bad(nBad) As Sprite
    Public nSpawnedBad As Integer
    Public TimerCounter As Integer
    Public AnimeCounter As Integer
    Public Const Kicking As Integer = 4
    Public Max As Sprite
    Public Lives As Integer = 3
    Public Const Gravity As Integer = 8
    Public LivesTimer1 As Integer
    Public LivesTimer2 As Integer
    Public LivesTimer3 As Integer
    Public DeadBad As Integer
    Public Const GameOver As Integer = 5
    Public WinningCounter As Integer
    Public Milk As Sprite
    Public QuitGame As Boolean
    Public PlayAgain As Boolean

    Public Sub CheckMaxLives()
        If Lives = 2 Then
            LivesTimer1 += 1
            If LivesTimer1 < 5 Then
                MainForm.Life1.Visible = False
            ElseIf LivesTimer1 < 10 Then
                MainForm.Life1.Visible = True
            ElseIf LivesTimer1 < 15 Then
                MainForm.Life1.Visible = False
            ElseIf LivesTimer1 < 20 Then
                MainForm.Life1.Visible = True
            ElseIf LivesTimer1 <= 25 Then
                MainForm.Life1.Visible = False
            End If

        ElseIf Lives = 1 Then
            LivesTimer2 += 1
            If LivesTimer2 < 5 Then
                MainForm.Life2.Visible = False
            ElseIf LivesTimer2 < 10 Then
                MainForm.Life2.Visible = True
            ElseIf LivesTimer2 < 15 Then
                MainForm.Life2.Visible = False
            ElseIf LivesTimer2 < 20 Then
                MainForm.Life2.Visible = True
            ElseIf LivesTimer2 <= 25 Then
                MainForm.Life2.Visible = False
            End If

        ElseIf Lives = 0 Then
            LivesTimer3 += 1
            If LivesTimer3 < 5 Then
                MainForm.Life3.Visible = False
            ElseIf LivesTimer3 < 10 Then
                MainForm.Life3.Visible = True
            ElseIf LivesTimer3 < 15 Then
                MainForm.Life3.Visible = False
            ElseIf LivesTimer3 < 20 Then
                MainForm.Life3.Visible = True
            ElseIf LivesTimer3 <= 25 Then
                MainForm.Life3.Visible = False
            ElseIf LivesTimer3 > 25 Then
                Max.State = GameOver
                MainForm.Timer1.Stop()
                YouLose.ShowDialog()
            End If
        End If
    End Sub



    Public Sub MoveSprite(ByRef Guy As Sprite)
        Guy.Speed.Y = GetVerticalSpeed(Guy)
        Guy.Position.X += Guy.Speed.X
        Guy.Position.Y += Guy.Speed.Y
        Guy.MRectangle.X = Guy.Position.X
        Guy.MRectangle.Y = Guy.Position.Y
        If Guy.State <> dead Then
            If Guy.Position.X > 1366 And Guy.Position.Y > 570 Then
                Guy.Position.Y = Guy.Position.Y - 556
                Guy.Position.X = (0 - Guy.Cellwidth)
            ElseIf Guy.Position.X > 1366 And Guy.Position.Y < 570 Then
                Guy.Position.X = (0 - Guy.Cellwidth)
            End If
            If Guy.Position.X < (0 - Guy.Cellwidth) And Guy.Position.Y > 570 Then
                Guy.Position.Y = Guy.Position.Y - 556
                Guy.Position.X = 1366
            ElseIf Guy.Position.X < (0 - Guy.Cellwidth) And Guy.Position.Y < 570 Then
                Guy.Position.X = 1366
            End If
        End If

        If Guy.Position.Y > 1200 Then
            Guy.Position.Y = 1200
            Guy.Position.X = BackDrop.Width / 2
            Guy.Speed.Y = 0
            Guy.Speed.X = 0
        End If
    End Sub

    Public Sub LoadSprite(ByRef Guy As Sprite, ByVal picname As String, ByVal nCells As Integer, ByVal xspeed As Integer, ByVal yspeed As Integer, ByVal xpos As Integer, ByVal ypos As Integer)
        Guy.State = normal
        Guy.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\" + picname)
        Guy.cellcount = nCells
        Guy.Cellwidth = Guy.Picture.Width
        Guy.Cellheight = Guy.Picture.Height / nCells
        Guy.StartPosition.X = xpos
        Guy.StartPosition.Y = ypos
        Guy.Position.X = Guy.StartPosition.X
        Guy.Position.Y = Guy.StartPosition.Y
        Guy.Speed.X = xspeed
        Guy.Speed.Y = yspeed
        Guy.Startspeed.X = xspeed
        Guy.Startspeed.Y = yspeed
        Guy.MRectangle.Width = Guy.Cellwidth
        Guy.MRectangle.Height = Guy.Cellheight
        Guy.MRectangle.X = Guy.Position.X
        Guy.MRectangle.Y = Guy.Position.Y
        Guy.Radius = Guy.Cellheight / 2
    End Sub

    Public Sub reviving()
        If Max.Position.Y > 1100 And Lives > 0 Then

            Max.State = revive
            Max.Position.X = Max.StartPosition.X

        End If
        If Max.State = revive Then
            Max.Speed.Y = 0
            Max.Position.Y = Max.StartPosition.Y - 150
        End If

    End Sub

    Public Sub ChecKillBad()
        Dim index As Integer
        Dim MaxClone As Sprite
        MaxClone = Max
        MaxClone.Position.Y -= 50
        For index = 0 To nSpawnedBad
            If Bad(index).OnFloor = True And Bad(index).State <> dead Then
                If Collision(MaxClone, Bad(index)) And Max.State = normal Then
                    Bad(index).State = flipped
                    Bad(index).Speed.X = 0
                    Bad(index).Speed.Y = -30
                End If
            End If

            If Collision(Max, Bad(index)) And Bad(index).State = flipped And Max.State = normal Then
                Max.State = Kicking
                Bad(index).State = dead
                Bad(index).Speed.Y = -30
                DeadBad += 1
                If Max.FacingRight = True Then
                    Bad(index).Speed.X = 25
                Else : Bad(index).Speed.X = -25
                End If
            End If
            If Bad(index).State = flipped Then
                Bad(index).TimeFlipped += 1
                If Bad(index).TimeFlipped > 50 Then
                    Bad(index).State = normal
                    Bad(index).Speed.X = Bad(index).Startspeed.X
                    Bad(index).Speed.Y = -30
                    Bad(index).TimeFlipped = 0
                End If
            End If

        Next index
    End Sub

    Public Sub CheckMaxDeath()
        Dim index As Integer

        For index = 0 To nSpawnedBad
            If Collision(Max, Bad(index)) And Max.State = normal And Bad(index).State = normal Then
                Max.State = dead
                Max.Speed.X = 0
                Max.Speed.Y = -30
                Lives -= 1
            End If
        Next index


    End Sub

    Public Sub AnimeBad()
        Dim index As Integer
        For index = 0 To nSpawnedBad
            Bad(index).CellTop += Bad(index).Cellheight

            If Bad(index).State = normal Then
                If Bad(index).Speed.X > 0 Then
                    If Bad(index).CellTop > Bad(index).Cellheight Then
                        Bad(index).CellTop = 0
                    End If

                ElseIf Bad(index).Speed.X < 0 Then
                    If Bad(index).CellTop > Bad(index).Cellheight * 3 Then
                        Bad(index).CellTop = Bad(index).Cellheight * 2
                    End If
                End If
            ElseIf Bad(index).State = flipped Then
                If Bad(index).CellTop > Bad(index).Cellheight * 7 Or Bad(index).CellTop < Bad(index).Cellheight * 4 Then
                    Bad(index).CellTop = Bad(index).Cellheight * 4
                End If
            ElseIf Bad(index).State = dead Then
                If Bad(index).CellTop > Bad(index).Cellheight * 9 Or Bad(index).CellTop < Bad(index).Cellheight * 8 Then
                    Bad(index).CellTop = Bad(index).Cellheight * 8
                End If
            End If
        Next index
    End Sub

    Public Sub MilkPower()
        Dim index As Integer

        If Collision(Max, Milk) = True And Max.Speed.Y < 0 And Milk.State <> dead Then
            For index = 0 To nSpawnedBad
                Bad(index).State = flipped
                Bad(index).Speed.X = 0
                Max.Speed.Y = Milk.Position.Y + Milk.Cellwidth - Max.Position.Y
            Next index
            Milk.State = dead
        End If

        If Milk.State = dead Then
            MilkTimer += 1
        End If

        If MilkTimer > 250 Then
            Milk.State = normal
            MilkTimer = 0
        End If

    End Sub

    Public Sub AnimeMax()
        Max.CellTop += Max.Cellheight
        Dim Index As Integer
        For Index = 0 To nSpawnedBad
            If Max.State = normal Or Max.State = GameOver Then
                If Max.Speed.X > 0 And Max.OnFloor = True And Collision(Max, Bad(Index)) = False Then

                    If Max.CellTop > Max.Cellheight * 2 Then
                        Max.CellTop = 0
                    End If


                ElseIf Max.Speed.X < 0 And Max.OnFloor = True And Collision(Max, Bad(Index)) = False Then

                    If Max.CellTop < Max.Cellheight * 3 Or Max.CellTop > Max.Cellheight * 5 Then
                        Max.CellTop = Max.Cellheight * 3
                    End If

                ElseIf Max.Speed.X = 0 And Max.OnFloor = True And Collision(Max, Bad(Index)) = False Then
                    If Max.FacingRight = True Then
                        Max.CellTop = Max.Cellheight * 6
                    Else
                        Max.CellTop = Max.Cellheight * 7
                    End If
                ElseIf Max.OnFloor = False And Collision(Max, Bad(Index)) = False Then
                    If Max.FacingRight = True Then
                        Max.CellTop = Max.Cellheight * 8
                    Else
                        Max.CellTop = Max.Cellheight * 9
                    End If
                End If
            ElseIf Max.State = dead Then

                If Max.CellTop > Max.Cellheight * 13 Or Max.CellTop < Max.Cellheight * 12 Then
                    Max.CellTop = Max.Cellheight * 12
                End If

            ElseIf Max.State = revive Then
                AnimeCounter += 1
                Max.CellTop = Max.Cellheight * 14
                If AnimeCounter = 5 Then
                    Max.CellTop = Max.Cellheight * 12
                    AnimeCounter = 0
                End If
            ElseIf Max.State = Kicking Then
                AnimeCounter += 1
                If AnimeCounter < 10 Then
                    If Max.FacingRight = False Then
                        Max.CellTop = Max.Cellheight * 10
                    Else : Max.CellTop = Max.Cellheight * 11
                    End If
                Else
                    Max.State = normal
                    AnimeCounter = 0
                End If

            End If
        Next Index

    End Sub

    Public Sub SpriteDraw(ByVal Guy As Sprite)
        Offg.DrawImage(Guy.Picture, Guy.MRectangle, 0, Guy.CellTop, Guy.Cellwidth, Guy.Cellheight, System.Drawing.GraphicsUnit.Pixel)
    End Sub

    Public Function GetVerticalSpeed(ByRef Guy As Sprite)
        Dim nextverticalstep As Integer

        nextverticalstep = Guy.Speed.Y + Gravity
        Dim index As Integer
        Guy.OnFloor = False
        If Guy.State <> dead Then
            For index = 0 To nFloors
                If Guy.Position.X + Guy.Cellwidth > Floors(index).left And Guy.Position.X < Floors(index).right Then
                    If nextverticalstep > 0 Then
                        If Guy.Position.Y + Guy.Cellheight <= Floors(index).Top Then
                            If Guy.Position.Y + Guy.Cellheight + nextverticalstep > Floors(index).Top Then
                                nextverticalstep = Floors(index).Top - (Guy.Position.Y + Guy.Cellheight)
                                Guy.OnFloor = True
                            End If
                        End If
                    End If

                    If nextverticalstep < 0 Then
                        If Guy.Position.Y >= Floors(index).Bottom Then
                            If Guy.Position.Y + nextverticalstep < Floors(index).Bottom Then
                                nextverticalstep = Floors(index).Bottom - Guy.Position.Y
                            End If
                        End If
                    End If
                End If
            Next index
        End If

        Return nextverticalstep
    End Function

    Public Function Collision(ByVal guy1 As Sprite, ByVal guy2 As Sprite)
        Dim A As Integer
        Dim B As Integer
        Dim H As double
        A = guy1.Position.X - guy2.Position.X
        B = guy1.Position.Y - guy2.Position.Y
        H = Math.Sqrt((A * A) + (B * B))
        If H < guy1.Radius + guy2.Radius Then
            Return True
        End If
        Return False
    End Function
End Module