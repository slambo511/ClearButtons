Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnOne.FlatStyle = FlatStyle.Flat
        btnOne.FlatAppearance.BorderSize = 1 ' Change to 0 to hide the border entirely, should you want to.
        btnOne.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnOne.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnOne.BackColor = Color.Transparent

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click

        MessageBox.Show("Day One", "Merry Xmas", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
