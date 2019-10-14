Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Admin Login
        If TextBox1.Text = "admin" And MaskedTextBox1.Text = "Password" Then
            Home.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid Login Information", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
