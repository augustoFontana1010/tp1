Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub
    Private Sub CargarUsuarios()
        Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=tppro")
        Dim consulta As String = "SELECT nombre, apellido, dni, direccion, telefono, correo, foto,observaciones FROM usuarios"
        Dim adaptador As New MySqlDataAdapter(consulta, conexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()
            adaptador.Fill(tabla)

            ' Crear nueva tabla con imagen
            Dim dtImagen As New DataTable()
            dtImagen.Columns.Add("nombre")
            dtImagen.Columns.Add("apellido")
            dtImagen.Columns.Add("dni")
            dtImagen.Columns.Add("direccion")
            dtImagen.Columns.Add("telefono")
            dtImagen.Columns.Add("correo")
            dtImagen.Columns.Add("foto", GetType(Image))
            dtImagen.Columns.Add("observaciones")

            For Each fila As DataRow In tabla.Rows
                Dim img As Image = Nothing
                If Not IsDBNull(fila("foto")) Then
                    Dim bytes() As Byte = CType(fila("foto"), Byte())
                    Using ms As New IO.MemoryStream(bytes)
                        img = Image.FromStream(ms)
                    End Using
                End If

                dtImagen.Rows.Add(
                fila("nombre"),
                fila("apellido"),
                fila("dni"),
                fila("direccion"),
                fila("telefono"),
                fila("correo"),
                img,
                fila("observaciones")
            )
            Next
             
            DataGridView1.DataSource = dtImagen

            ' Estilos y ajuste visual
            With DataGridView1
                .RowTemplate.Height = 60
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange
                .DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40)
                .DefaultCellStyle.ForeColor = Color.White
                .GridColor = Color.Orange
            End With

            CType(DataGridView1.Columns("foto"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom

        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Property FormPadre As Form1
    Private Sub ClosePIC_Click(sender As Object, e As EventArgs) Handles ClosePIC.Click
        If FormPadre IsNot Nothing Then
            FormPadre.PictureBox2.Visible = True
        End If
        Me.Close()
    End Sub


End Class