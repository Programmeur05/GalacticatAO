Public Class WinningScreen



    Private Sub PlayAgain_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click
        Me.Hide()
    End Sub

    Private Sub backtomenu_Click(sender As Object, e As EventArgs) Handles backtomenu.Click
        Credit.ShowDialog()
        Me.Close()
    End Sub

End Class