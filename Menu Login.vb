Public Class Menu_Login
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Menu_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 10
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim username As String
        Dim password As String
        username = "admin"
        password = "admin"
        If TextBox1.Text = username Then
            If TextBox2.Text = password Then
                Form1.Terbuka()
                Me.Close()
            End If
        End If
    End Sub
End Class