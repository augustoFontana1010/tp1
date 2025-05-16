Imports System.Diagnostics.Eventing.Reader

Public Class Form10
    Public Property FormPadre As Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
        Form1.PictureBox2.Visible = True
        Form1.Login.Visible = True
        Form1.Register.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
    Private Sub ClosePIC_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.FromArgb(30, 30, 30) ' Un gris más oscuro, simula sombra
    End Sub

    Private Sub ClosePIC_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.FromArgb(64, 64, 64) ' O volvés al color que tenías
    End Sub
End Class