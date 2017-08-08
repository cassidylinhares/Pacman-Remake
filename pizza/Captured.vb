Public Class Captured

    Private Sub tryAgain_Click(sender As Object, e As EventArgs) Handles tryAgain.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        quitB = True
        Me.Hide()
    End Sub
End Class