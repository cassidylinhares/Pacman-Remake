Public Class characterSelection
    Private Sub characterSelection_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Show()
        Form1.Hide()
    End Sub
    Private Sub SuzzyB_Click(sender As Object, e As EventArgs) Handles SuzzyB.Click
        charc = 1
        Me.Hide()
        'Form1.Show()
    End Sub

    Private Sub ReggieB_Click(sender As Object, e As EventArgs) Handles ReggieB.Click
        charc = 0
        Me.Hide()
        'Form1.Show()
    End Sub


End Class