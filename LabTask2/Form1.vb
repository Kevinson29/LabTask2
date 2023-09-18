Public Class Form1
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub OriginalItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OriginalItemToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomePageToolStripMenuItem.Click

    End Sub
End Class
