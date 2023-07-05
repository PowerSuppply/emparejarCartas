Imports System.Diagnostics.Eventing.Reader
Imports System.Threading


Public Class Form1
    Public img1 As Integer
    Public img2 As Integer
    Public sentinel As Integer
    Public carta As PictureBox
    Public card1 As PictureBox
    Public card2 As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sentinel = 0
    End Sub

    Private Sub Card_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim card As PictureBox = CType(sender, PictureBox)

        If img1 = 0 And img2 = 0 Then
            ' Primera tarjeta seleccionada
            img1 = card.Tag
            card1 = card
            card.Visible = False

        ElseIf img1 <> 0 And img2 = 0 Then
            ' Segunda tarjeta seleccionada
            img2 = card.Tag
            card2 = card
            card2.Visible = False
            CompareCards()
        End If
    End Sub

    Private Async Sub CompareCards()
        If img1 = img2 Then
            card1.Enabled = False
            card1 = Nothing
            img1 = 0
            card2.Enabled = False
            card2 = Nothing
            img2 = 0
            sentinel += 1
            If sentinel = 8 Then
                Dialog1.Show()
            End If
        Else
            Await Task.Delay(1000)
            card1.Visible = True
            card1 = Nothing
            img1 = 0
            card2.Visible = True
            card2 = Nothing
            img2 = 0
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        caja1.Visible = True
        caja2.Visible = True
        caja3.Visible = True
        caja4.Visible = True
        caja5.Visible = True
        caja6.Visible = True
        caja7.Visible = True
        caja8.Visible = True
        caja9.Visible = True
        caja10.Visible = True
        caja11.Visible = True
        caja12.Visible = True
        caja13.Visible = True
        caja14.Visible = True
        caja15.Visible = True
        caja16.Visible = True

    End Sub
    Private Sub caja1_Click(sender As Object, e As EventArgs) Handles caja1.Click
        Card_Click(caja1, e)
    End Sub

    Private Sub caja2_Click(sender As Object, e As EventArgs) Handles caja2.Click
        Card_Click(caja2, e)
    End Sub

    Private Sub caja3_Click(sender As Object, e As EventArgs) Handles caja3.Click
        Card_Click(caja3, e)
    End Sub
    Private Sub caja5_Click(sender As Object, e As EventArgs) Handles caja5.Click
        Card_Click(caja5, e)
    End Sub
    Private Sub caja6_Click(sender As Object, e As EventArgs) Handles caja6.Click
        Card_Click(caja6, e)
    End Sub

    Private Sub caja7_Click(sender As Object, e As EventArgs) Handles caja7.Click
        Card_Click(caja7, e)
    End Sub

    Private Sub caja12_Click(sender As Object, e As EventArgs) Handles caja12.Click
        Card_Click(caja12, e)
    End Sub

    Private Sub caja9_Click(sender As Object, e As EventArgs) Handles caja9.Click
        Card_Click(caja9, e)
    End Sub

    Private Sub caja11_Click(sender As Object, e As EventArgs) Handles caja11.Click
        Card_Click(caja11, e)
    End Sub

    Private Sub caja13_Click(sender As Object, e As EventArgs) Handles caja13.Click
        Card_Click(caja13, e)
    End Sub

    Private Sub caja14_Click(sender As Object, e As EventArgs) Handles caja14.Click
        Card_Click(caja14, e)
    End Sub

    Private Sub caja8_Click(sender As Object, e As EventArgs) Handles caja8.Click
        Card_Click(caja8, e)
    End Sub

    Private Sub caja16_Click(sender As Object, e As EventArgs) Handles caja16.Click
        Card_Click(caja16, e)
    End Sub

    Private Sub caja4_Click(sender As Object, e As EventArgs) Handles caja4.Click
        Card_Click(caja4, e)
    End Sub

    Private Sub caja15_Click(sender As Object, e As EventArgs) Handles caja15.Click
        Card_Click(caja15, e)
    End Sub

    Private Sub caja10_Click(sender As Object, e As EventArgs) Handles caja10.Click
        Card_Click(caja10, e)
    End Sub
End Class