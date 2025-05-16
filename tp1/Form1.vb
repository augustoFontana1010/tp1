Public Class Form1

    Public Sub cambiarpanel()
        Dim estado As Boolean = PanelSideMenu.Visible
        PanelSideMenu.Visible = Not estado
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarpanel()
        hideSubmenu()
        Label1.BackColor = Color.DarkOrange
        Label1.Visible = True
        Label1.Text = "Conectado al sistema"
        Timer1.Interval = 2000
        Timer1.Start()
    End Sub

    Private Sub hideSubmenu()
        PanelAdmin.Visible = False
        PanelVenta.Visible = False
        PanelExpo.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub
    Private Sub openform(formhijo As Form)
        PictureBox2.Visible = False
        For Each contr As Control In Panel3.Controls.OfType(Of Form)().ToList()
            Panel3.Controls.Remove(contr)
            contr.Dispose()
        Next
        With formhijo
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel3.Controls.Add(formhijo)
            Panel3.Tag = formhijo
            .Show()
        End With
    End Sub

    Private Sub Administración_Click(sender As Object, e As EventArgs) Handles Administración.Click
        showSubmenu(PanelAdmin)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showSubmenu(PanelVenta)
    End Sub

    Private Sub Expo_Click(sender As Object, e As EventArgs) Handles Expo.Click
        showSubmenu(PanelExpo)
    End Sub

    Private Sub NuevosUsuarios_Click(sender As Object, e As EventArgs) Handles NuevosUsuarios.Click
        Dim f2 As New Form2()
        f2.FormPadre = Me
        openform(f2)
        hideSubmenu()
    End Sub


    Private Sub ListadoDeUsuarios_Click(sender As Object, e As EventArgs) Handles ListadoDeUsuarios.Click
        Dim f3 As New Form3()
        f3.FormPadre = Me
        openform(f3)
        hideSubmenu()
    End Sub

    Private Sub ListCaja_Click(sender As Object, e As EventArgs) Handles ListCaja.Click
        Dim f4 As New Form4()
        f4.FormPadre = Me
        openform(f4)
        hideSubmenu()
    End Sub

    Private Sub LisVentas_Click(sender As Object, e As EventArgs) Handles LisVentas.Click
        Dim f5 As New Form5()
        f5.FormPadre = Me
        openform(f5)
        hideSubmenu()
    End Sub

    Private Sub CloseCaja_Click(sender As Object, e As EventArgs) Handles CloseCaja.Click
        Dim f6 As New Form6()
        f6.FormPadre = Me
        openform(f6)
        hideSubmenu()
    End Sub

    Private Sub Exel_Click(sender As Object, e As EventArgs) Handles Exel.Click
        Dim f7 As New Form7()
        f7.FormPadre = Me
        openform(f7)
        hideSubmenu()
    End Sub

    Private Sub BtnPDFExport_Click(sender As Object, e As EventArgs) Handles BtnPDFExport.Click
        Dim f8 As New Form8()
        f8.FormPadre = Me
        openform(f8)
        hideSubmenu()
    End Sub

    Private Sub CLOSEXIT_Click(sender As Object, e As EventArgs) Handles CLOSEXIT.Click
        Close()
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LabelHora.Text = DateTime.Now.ToShortTimeString()
        LabelFe.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub ClosePIC_Click(sender As Object, e As EventArgs) Handles ClosePIC.Click
        Close()
    End Sub

    Private Sub Minimized_Click(sender As Object, e As EventArgs) Handles mizimizer.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Maximizer_Click(sender As Object, e As EventArgs) Handles maximizer.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ClosePIC_MouseEnter(sender As Object, e As EventArgs) Handles ClosePIC.MouseEnter
        ClosePIC.BackColor = Color.FromArgb(30, 30, 30) ' Un gris más oscuro, simula sombra
    End Sub

    Private Sub ClosePIC_MouseLeave(sender As Object, e As EventArgs) Handles ClosePIC.MouseLeave
        ClosePIC.BackColor = Color.FromArgb(52, 51, 52) ' O volvés al color que tenías
    End Sub

    Private Sub Minimized_MouseEnter(sender As Object, e As EventArgs) Handles mizimizer.MouseEnter
        mizimizer.BackColor = Color.FromArgb(30, 30, 30) ' Un gris más oscuro, simula sombra
    End Sub

    Private Sub Minimized_MouseLeave(sender As Object, e As EventArgs) Handles mizimizer.MouseLeave
        mizimizer.BackColor = Color.FromArgb(52, 51, 52) ' O volvés al color que tenías
    End Sub

    Private Sub Maximizer_MouseEnter(sender As Object, e As EventArgs) Handles maximizer.MouseEnter
        maximizer.BackColor = Color.FromArgb(30, 30, 30) ' Un gris más oscuro, simula sombra
    End Sub

    Private Sub Maximizer_MouseLeave(sender As Object, e As EventArgs) Handles maximizer.MouseLeave
        maximizer.BackColor = Color.FromArgb(52, 51, 52) ' O volvés al color que tenías
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim f9 As New Form9()
        f9.FormPadre = Me
        openform(f9)
        Login.Visible = False
        Register.Visible = False
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim f10 As New Form10()
        f10.FormPadre = Me
        openform(f10)
        Login.Visible = False
        Register.Visible = False
    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        Dim bordeColor As Color = Color.FromArgb(228, 135, 54)
        Dim grosor As Integer = 2
        Dim rect As New Rectangle(0, 0, PictureBox2.Width - 1, PictureBox2.Height - 1)
        Using lapiz As New Pen(bordeColor, grosor)
            e.Graphics.DrawRectangle(lapiz, rect)
        End Using
        GenerarLogoConSombra("Logo").Save("logo.png") ' Guardar el logo generado como archivo
    End Sub

    Private Function GenerarLogoConSombra(texto As String) As Image
        Dim bmp As New Bitmap(300, 100) ' Cambiá tamaño si hace falta
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.FromArgb(64, 64, 64)) ' Fondo gris oscuro

            Dim fuente As New Font("Segoe UI", 24, FontStyle.Bold)
            Dim sombraColor As Color = Color.Black
            Dim textoColor As Color = Color.FromArgb(228, 135, 54)

            ' Sombra (dibujá el texto corrido un poco)
            g.DrawString(texto, fuente, New SolidBrush(sombraColor), 5, 5)

            ' Texto principal encima
            g.DrawString(texto, fuente, New SolidBrush(textoColor), 3, 3)
        End Using
        Return bmp
    End Function

End Class
