Public Class SelectDif

    Public Const Easy As Integer = 5
    Public Const Medium As Integer = 7
    Public Const Hard As Integer = 9
    Public difficulty As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        difficulty = Easy
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        difficulty = Medium



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        difficulty = Hard
       

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
    End Sub

    Sub SelectDifCheckbox()
        If difficulty = Easy Then
            checkbox1.Visible = True
            Checkbox2.Visible = False
            Checkbox3.Visible = False
        ElseIf difficulty = Medium Then
            checkbox1.Visible = False
            Checkbox2.Visible = True
            Checkbox3.Visible = False
        ElseIf difficulty = Hard Then
            checkbox1.Visible = False
            Checkbox2.Visible = False
            Checkbox3.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call SelectDifCheckbox()
    End Sub

    Private Sub SelectDif_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
End Class