Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomePageToolStripMenuItem.Click

        Form1.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub OriginalItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OriginalItemToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class