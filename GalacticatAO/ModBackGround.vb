Module ModBackGround
    Structure BackGround
        Dim Picture As Bitmap
        Dim Position As Point
        Dim Width As Integer
        Dim height As Integer

    End Structure

    Structure Floor
        Dim Top As Integer
        Dim Bottom As Integer
        Dim left As Integer
        Dim right As Integer

    End Structure

    Public BackDrop As BackGround
    Public g As Graphics
    Public Offg As Graphics
    Public ImageOffScreen As Image
    Public Const nFloors As Integer = 7
    Public Floors(nFloors) As Floor

    Public Sub FloorSet()
        Floors(0).Top = 718
        Floors(0).Bottom = 766
        Floors(0).left = -10
        Floors(0).right = 1370

        Floors(1).Top = 549
        Floors(1).Bottom = 581
        Floors(1).left = 870
        Floors(1).right = 1370

        Floors(2).Top = 549
        Floors(2).Bottom = 581
        Floors(2).left = -10
        Floors(2).right = 526

        Floors(3).Top = 375
        Floors(3).Bottom = 405
        Floors(3).left = -10
        Floors(3).right = 218

        Floors(4).Top = 375
        Floors(4).Bottom = 405
        Floors(4).left = 1179
        Floors(4).right = 1370

        Floors(5).Top = 348
        Floors(5).Bottom = 381
        Floors(5).left = 356
        Floors(5).right = 1034

        Floors(6).Top = 162
        Floors(6).Bottom = 193
        Floors(6).left = -10
        Floors(6).right = 580

        Floors(7).Top = 162
        Floors(7).Bottom = 193
        Floors(7).left = 815
        Floors(7).right = 1370

    End Sub

    Public Sub LoadBackground()
        BackDrop.Position.X = 0
        BackDrop.Position.Y = 0
        BackDrop.Picture = New Bitmap(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\bckgrnd 1.bmp")
        BackDrop.Width = BackDrop.Picture.Width
        BackDrop.height = BackDrop.Picture.Height
    End Sub

    Sub BackgroundDraw()
        Offg.DrawImage(BackDrop.Picture, 0, 0)
    End Sub


End Module
