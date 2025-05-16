Public Class Form8
    Public Property FormPadre As Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If FormPadre IsNot Nothing Then
            FormPadre.PictureBox2.Visible = True
        End If
        Me.Close()
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.FromArgb(30, 30, 30) ' Un gris más oscuro, simula sombra
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.FromArgb(64, 64, 64) ' O volvés al color que tenías
    End Sub
End Class