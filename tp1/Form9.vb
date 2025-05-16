Public Class Form9
    Public Property FormPadre As Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.cambiarpanel()
        Dispose()
        Form1.Login.Visible = False
        Form1.Register.Visible = False
        Form1.PictureBox2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    ' Mostrar u ocultar la contraseña con el checkbox
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Mostrar texto plano
            TextBox2.PasswordChar = ControlChars.NullChar
        Else
            ' Ocultar con carácter personalizado
            TextBox2.PasswordChar = "■"c
        End If
    End Sub


    ' Establecer estilo de la contraseña al iniciar o cuando cambia el texto
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Solo aplicar PasswordChar si está ocultando la contraseña
        If TextBox2.UseSystemPasswordChar = False Then
            TextBox2.PasswordChar = "■"c ' o cualquier otro
        End If
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