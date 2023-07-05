Imports System.Windows.Forms

Public Class Dialog1
    Private Async Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await Task.Delay(5000)
        Me.Hide()
    End Sub
End Class
