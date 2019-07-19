Public Class thanks

    Private EndTimer As Integer

    Sub Thanks()
        If EndTimer > 30 Then
            QuitGame = True
            Me.Close()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        EndTimer += 1
        Call Thanks()
    End Sub

    Private Sub thanks_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
End Class