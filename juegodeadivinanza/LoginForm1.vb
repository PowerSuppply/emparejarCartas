Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public sentinel As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text <> UsernameTextBox.Tag Then
            sentinel += 1
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            incorrectUser.Text = "El usuario ingresado no existe"

        End If
        If PasswordTextBox.Text <> PasswordTextBox.Tag Then
            sentinel += 1
            PasswordTextBox.Text = ""
            UsernameTextBox.Text = ""
            incorrectPassword.Text = "La contrase—a ingresada es incorrecta"

        End If
        If sentinel <> 0 Then
            sentinel = 0
        ElseIf sentinel = 0 Then
            Me.Hide()
            Form1.Show()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
