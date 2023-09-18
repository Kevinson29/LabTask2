Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomePageToolStripMenuItem.Click

        Form1.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()
    End Sub
End Class