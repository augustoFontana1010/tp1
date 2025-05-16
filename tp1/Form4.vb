Public Class Form4
    Public Property FormPadre As Form1
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClosePIC_Click(sender As Object, e As EventArgs) Handles ClosePIC.Click
        If FormPadre IsNot Nothing Then
            FormPadre.PictureBox2.Visible = True
        End If
        Me.Close()
    End Sub
    Private Sub ClosePIC_MouseEnter(sender As Object, e As EventArgs) Handles ClosePIC.MouseEnter
        ClosePIC.BackColor = Color.FromArgb(30, 30, 30) ' Un gris más oscuro, simula sombra
    End Sub

    Private Sub ClosePIC_MouseLeave(sender As Object, e As EventArgs) Handles ClosePIC.MouseLeave
        ClosePIC.BackColor = Color.FromArgb(64, 64, 64) ' O volvés al color que tenías
    End Sub
End Class