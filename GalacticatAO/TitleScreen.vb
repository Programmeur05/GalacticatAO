Public Class TitleScreen



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SelectDif.difficulty = 0 Then
            SelectDif.difficulty = 5
        End If
        Me.Hide()
        MainForm.ShowDialog()

    End Sub

    Private Sub Options_Click(sender As Object, e As EventArgs) Handles Options.Click
        SelectDif.ShowDialog()
    End Sub

    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
            My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\soundtrack.wav", AudioPlayMode.BackgroundLoop)
    End Sub

End Class