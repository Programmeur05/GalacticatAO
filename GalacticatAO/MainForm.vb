Public Class MainForm

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Max.State = normal Or Max.State = revive Then
            Max.State = normal
            If e.KeyCode = Keys.A Then
                Max.Speed.X = -Max.Startspeed.X
                Max.FacingRight = False
            End If
            If e.KeyCode = Keys.D Then
                Max.Speed.X = Max.Startspeed.X
                Max.FacingRight = True
            End If
            If e.KeyCode = Keys.Space And Max.OnFloor = True Then
                Max.Speed.Y = -Max.Startspeed.Y
            End If
        End If

    End Sub


    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.D Then
            Max.Speed.X = 0
        End If
    End Sub




    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call ResetLvl()
        Call LoadBackground()
        Call DrawScreenSet()
        Call FloorSet()
        Timer1.Start()

    End Sub

    Public Sub ResetLvl()
        Sprite.LivesTimer1 = 0
        Sprite.LivesTimer2 = 0
        Sprite.LivesTimer3 = 0
        Life1.Visible = True
        Life2.Visible = True
        Life3.Visible = True
        MilkTimer = 0
        Dim index As Integer
        For index = 0 To nSpawnedBad
            Bad(index).TimeFlipped = 0
        Next index
        Call LoadSprite(Milk, "milkBig.png", 1, 0, 0, 670, 60)
        Call LoadSprite(Max, "galacticatBig.png", 15, 20, 65, 678, 680)
        Lives = 3
        DeadBad = 0
        Max.State = normal
        TimerCounter = 0
        For index = 0 To nBad
            If index Mod 2 = 0 Then
                Call LoadSprite(Bad(index), "gatorpedeBig.png", 10, 10, 10, 0, 0)
                nSpawnedBad += 1
            Else
                Call LoadSprite(Bad(index), "gatorpedeBig.png", 10, -10, 10, 1366, 0)
                nSpawnedBad += 1
            End If
        Next index
        Max.Speed.X = 0
    End Sub

    Public Sub CheckWin()
        If DeadBad = nBad + 1 And Lives > 0 Then
            Max.State = GameOver
            WinningCounter += 1
            If WinningCounter > 25 Then
                Timer1.Stop()
                WinningScreen.ShowDialog()
                If QuitGame = True Then
                    Me.Close()
                End If
                Call ResetLvl()
                Timer1.Start()
                WinningCounter = 0
            End If
        End If
    End Sub

    Sub EndGame()
        If QuitGame = True Then
            Me.Close()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim index As Integer
        If QuitGame = True Then
            Application.Exit()
        End If
        Call MoveSprite(Max)
        TimerCounter += 1
        nSpawnedBad = TimerCounter / 30
        If nSpawnedBad > nBad Then
            nSpawnedBad = nBad
        End If
        For index = 0 To nSpawnedBad
            Call MoveSprite(Bad(index))
        Next index
        Call ScreenDraw()
        Call AnimeMax()
        Call AnimeBad()
        Call CheckMaxDeath()
        Call reviving()
        Call ChecKillBad()
        Call CheckMaxLives()
        Call CheckWin()
        Call MilkPower()
        Call EndGame()
        
    End Sub

    Public Sub DrawScreenSet()
        ImageOffScreen = BackDrop.Picture.Clone
        PicDrawOnScreen.Left = BackDrop.Position.X
        PicDrawOnScreen.Top = BackDrop.Position.Y
        PicDrawOnScreen.Width = BackDrop.Width
        PicDrawOnScreen.Height = BackDrop.height

    End Sub

    Sub ScreenDraw()
        Dim index As Integer
        If QuitGame = False Then
            g = PicDrawOnScreen.CreateGraphics
            Offg = Graphics.FromImage(ImageOffScreen)
            Call BackgroundDraw()
            Call SpriteDraw(Max)
            For index = 0 To nSpawnedBad
                Call SpriteDraw(Bad(index))
            Next index
            If Milk.State = normal Then
                Call SpriteDraw(Milk)
            End If
            g.DrawImage(ImageOffScreen, 0, 0)
            g.Dispose()
            Offg.Dispose()
        End If
    End Sub


    Private Sub PicMax_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lives_Click(sender As Object, e As EventArgs) Handles Life1.Click

    End Sub




End Class
