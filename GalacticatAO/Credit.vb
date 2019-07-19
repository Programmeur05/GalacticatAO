Public Class Credit



    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        thanks.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        credits.Top -= 7
        If credits.Top < -500 Then
            Timer1.Stop()
            thanks.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub Credit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
End Class