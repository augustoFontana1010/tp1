Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim con As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Private Sub btnSubirFoto_Click(sender As Object, e As EventArgs) Handles subriFOTO.Click
        Dim archivo As New OpenFileDialog()
        archivo.Title = "Seleccionar una imagen"
        archivo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"

        If archivo.ShowDialog() = DialogResult.OK Then
            pbfoto.Image = Image.FromFile(archivo.FileName)
            pbfoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Public Property FormPadre As Form1

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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=tppro")
        Dim consulta As String = "INSERT INTO usuarios (nombre, apellido, dni, direccion, telefono, correo, foto, observaciones) VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @correo, @foto,@observaciones)"
        Dim comando As New MySqlCommand(consulta, conexion)

        ' Unir teléfono
        Dim telefonoCompleto As String = TbAREA.Text & TbNum.Text

        ' Parámetros
        comando.Parameters.AddWithValue("@nombre", TbNom.Text)
        comando.Parameters.AddWithValue("@apellido", TbA.Text)
        comando.Parameters.AddWithValue("@dni", TbDNI.Text)
        comando.Parameters.AddWithValue("@direccion", TbDIR.Text)
        comando.Parameters.AddWithValue("@telefono", telefonoCompleto)
        comando.Parameters.AddWithValue("@correo", TbCR.Text)
        ' Convertir imagen a binario
        If pbfoto.Image IsNot Nothing Then
            Dim ms As New IO.MemoryStream()
            pbfoto.Image.Save(ms, pbfoto.Image.RawFormat)
            Dim imagenEnBytes() As Byte = ms.ToArray()
            comando.Parameters.AddWithValue("@foto", imagenEnBytes)
        Else
            comando.Parameters.AddWithValue("@foto", DBNull.Value)
        End If

        comando.Parameters.AddWithValue("@observaciones", TbOB.Text)
        ' Guardar
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Datos guardados correctamente.")
            conexion.Close()

            ' Limpiar campos
            TbNom.Clear()
            TbA.Clear()
            TbDNI.Clear()
            TbDIR.Clear()
            TbAREA.Clear()
            TbNum.Clear()
            TbCR.Clear()
            TbOB.Clear()
            pbfoto.Image = Nothing

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TbNom.Clear()
        TbA.Clear()
        TbDNI.Clear()
        TbDIR.Clear()
        TbAREA.Clear()
        TbNum.Clear()
        TbCR.Clear()
        TbOB.Clear()
        pbfoto.Image = Nothing
    End Sub
    Public Sub SoloLetras(e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Bloquea el carácter
        End If
    End Sub
    Public Sub SoloNumeros(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Bloquea si no es número ni tecla como Backspace
        End If
    End Sub

    Private Sub TbNom_TextChanged(sender As Object, e As EventArgs) Handles TbNom.TextChanged
        SoloLetras(e)
    End Sub

    Private Sub TbA_TextChanged(sender As Object, e As EventArgs) Handles TbA.TextChanged
        SoloLetras(e)
    End Sub

    Private Sub TbDNI_TextChanged(sender As Object, e As EventArgs) Handles TbDNI.TextChanged
        SoloNumeros(e)
    End Sub

    Private Sub TbAREA_TextChanged(sender As Object, e As EventArgs) Handles TbAREA.TextChanged
        SoloNumeros(e)
    End Sub

    Private Sub TbNum_TextChanged(sender As Object, e As EventArgs) Handles TbNum.TextChanged
        SoloNumeros(e)
    End Sub

End Class
