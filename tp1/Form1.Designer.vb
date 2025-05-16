<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelSideMenu = New Panel()
        Label2 = New Label()
        PanelExpo = New Panel()
        BtnPDFExport = New Button()
        Exel = New Button()
        Expo = New Button()
        PanelVenta = New Panel()
        CloseCaja = New Button()
        LisVentas = New Button()
        ListCaja = New Button()
        Button3 = New Button()
        PanelAdmin = New Panel()
        ListadoDeUsuarios = New Button()
        NuevosUsuarios = New Button()
        Administración = New Button()
        PanelLogo = New Panel()
        PictureBox1 = New PictureBox()
        CLOSEXIT = New Button()
        LabelHora = New Label()
        LabelFe = New Label()
        HoraFecha = New Timer(components)
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Register = New Button()
        Login = New Button()
        maximizer = New PictureBox()
        Panel4 = New Panel()
        Panel5 = New Panel()
        ClosePIC = New PictureBox()
        mizimizer = New PictureBox()
        Timer1 = New Timer(components)
        PanelSideMenu.SuspendLayout()
        PanelExpo.SuspendLayout()
        PanelVenta.SuspendLayout()
        PanelAdmin.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(maximizer, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(ClosePIC, ComponentModel.ISupportInitialize).BeginInit()
        CType(mizimizer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSideMenu
        ' 
        PanelSideMenu.AutoScroll = True
        PanelSideMenu.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        PanelSideMenu.Controls.Add(Label2)
        PanelSideMenu.Controls.Add(PanelExpo)
        PanelSideMenu.Controls.Add(Expo)
        PanelSideMenu.Controls.Add(PanelVenta)
        PanelSideMenu.Controls.Add(Button3)
        PanelSideMenu.Controls.Add(PanelAdmin)
        PanelSideMenu.Controls.Add(Administración)
        PanelSideMenu.Controls.Add(PanelLogo)
        PanelSideMenu.Dock = DockStyle.Left
        PanelSideMenu.Location = New Point(0, 21)
        PanelSideMenu.Name = "PanelSideMenu"
        PanelSideMenu.Size = New Size(250, 599)
        PanelSideMenu.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Bottom
        Label2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label2.Location = New Point(0, 584)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 15)
        Label2.TabIndex = 6
        Label2.Text = "Copyright by Augusto Fontana V 1.0.25"
        ' 
        ' PanelExpo
        ' 
        PanelExpo.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        PanelExpo.Controls.Add(BtnPDFExport)
        PanelExpo.Controls.Add(Exel)
        PanelExpo.Dock = DockStyle.Top
        PanelExpo.Location = New Point(0, 486)
        PanelExpo.Name = "PanelExpo"
        PanelExpo.Size = New Size(250, 85)
        PanelExpo.TabIndex = 4
        ' 
        ' BtnPDFExport
        ' 
        BtnPDFExport.Dock = DockStyle.Top
        BtnPDFExport.FlatAppearance.BorderSize = 0
        BtnPDFExport.FlatStyle = FlatStyle.Flat
        BtnPDFExport.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        BtnPDFExport.Location = New Point(0, 40)
        BtnPDFExport.Name = "BtnPDFExport"
        BtnPDFExport.Padding = New Padding(35, 0, 0, 0)
        BtnPDFExport.Size = New Size(250, 39)
        BtnPDFExport.TabIndex = 2
        BtnPDFExport.Text = "PDF"
        BtnPDFExport.TextAlign = ContentAlignment.MiddleLeft
        BtnPDFExport.UseVisualStyleBackColor = True
        ' 
        ' Exel
        ' 
        Exel.Dock = DockStyle.Top
        Exel.FlatAppearance.BorderSize = 0
        Exel.FlatStyle = FlatStyle.Flat
        Exel.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Exel.Location = New Point(0, 0)
        Exel.Name = "Exel"
        Exel.Padding = New Padding(35, 0, 0, 0)
        Exel.Size = New Size(250, 40)
        Exel.TabIndex = 1
        Exel.Text = "Excel"
        Exel.TextAlign = ContentAlignment.MiddleLeft
        Exel.UseVisualStyleBackColor = True
        ' 
        ' Expo
        ' 
        Expo.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        Expo.Dock = DockStyle.Top
        Expo.FlatStyle = FlatStyle.Flat
        Expo.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Expo.Location = New Point(0, 441)
        Expo.Name = "Expo"
        Expo.Padding = New Padding(10, 0, 0, 0)
        Expo.Size = New Size(250, 45)
        Expo.TabIndex = 5
        Expo.Text = "Exportación"
        Expo.TextAlign = ContentAlignment.MiddleLeft
        Expo.UseVisualStyleBackColor = False
        ' 
        ' PanelVenta
        ' 
        PanelVenta.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        PanelVenta.Controls.Add(CloseCaja)
        PanelVenta.Controls.Add(LisVentas)
        PanelVenta.Controls.Add(ListCaja)
        PanelVenta.Dock = DockStyle.Top
        PanelVenta.Location = New Point(0, 313)
        PanelVenta.Name = "PanelVenta"
        PanelVenta.Size = New Size(250, 128)
        PanelVenta.TabIndex = 2
        ' 
        ' CloseCaja
        ' 
        CloseCaja.Dock = DockStyle.Top
        CloseCaja.FlatAppearance.BorderSize = 0
        CloseCaja.FlatStyle = FlatStyle.Flat
        CloseCaja.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        CloseCaja.Location = New Point(0, 80)
        CloseCaja.Name = "CloseCaja"
        CloseCaja.Padding = New Padding(35, 0, 0, 0)
        CloseCaja.Size = New Size(250, 42)
        CloseCaja.TabIndex = 3
        CloseCaja.Text = "Cierre de caja"
        CloseCaja.TextAlign = ContentAlignment.MiddleLeft
        CloseCaja.UseVisualStyleBackColor = True
        ' 
        ' LisVentas
        ' 
        LisVentas.Dock = DockStyle.Top
        LisVentas.FlatAppearance.BorderSize = 0
        LisVentas.FlatStyle = FlatStyle.Flat
        LisVentas.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        LisVentas.Location = New Point(0, 40)
        LisVentas.Name = "LisVentas"
        LisVentas.Padding = New Padding(35, 0, 0, 0)
        LisVentas.Size = New Size(250, 40)
        LisVentas.TabIndex = 2
        LisVentas.Text = "Listado de ventas"
        LisVentas.TextAlign = ContentAlignment.MiddleLeft
        LisVentas.UseVisualStyleBackColor = True
        ' 
        ' ListCaja
        ' 
        ListCaja.Dock = DockStyle.Top
        ListCaja.FlatAppearance.BorderSize = 0
        ListCaja.FlatStyle = FlatStyle.Flat
        ListCaja.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        ListCaja.Location = New Point(0, 0)
        ListCaja.Name = "ListCaja"
        ListCaja.Padding = New Padding(35, 0, 0, 0)
        ListCaja.Size = New Size(250, 40)
        ListCaja.TabIndex = 1
        ListCaja.Text = "Apertura de caja"
        ListCaja.TextAlign = ContentAlignment.MiddleLeft
        ListCaja.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        Button3.Dock = DockStyle.Top
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button3.Location = New Point(0, 268)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(10, 0, 0, 0)
        Button3.Size = New Size(250, 45)
        Button3.TabIndex = 3
        Button3.Text = "Ventas"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PanelAdmin
        ' 
        PanelAdmin.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        PanelAdmin.Controls.Add(ListadoDeUsuarios)
        PanelAdmin.Controls.Add(NuevosUsuarios)
        PanelAdmin.Dock = DockStyle.Top
        PanelAdmin.Location = New Point(0, 184)
        PanelAdmin.Name = "PanelAdmin"
        PanelAdmin.Size = New Size(250, 84)
        PanelAdmin.TabIndex = 1
        ' 
        ' ListadoDeUsuarios
        ' 
        ListadoDeUsuarios.Dock = DockStyle.Top
        ListadoDeUsuarios.FlatAppearance.BorderSize = 0
        ListadoDeUsuarios.FlatStyle = FlatStyle.Flat
        ListadoDeUsuarios.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        ListadoDeUsuarios.Location = New Point(0, 34)
        ListadoDeUsuarios.Name = "ListadoDeUsuarios"
        ListadoDeUsuarios.Padding = New Padding(35, 0, 0, 0)
        ListadoDeUsuarios.Size = New Size(250, 44)
        ListadoDeUsuarios.TabIndex = 2
        ListadoDeUsuarios.Text = "Listado de usuarios"
        ListadoDeUsuarios.TextAlign = ContentAlignment.MiddleLeft
        ListadoDeUsuarios.UseVisualStyleBackColor = True
        ' 
        ' NuevosUsuarios
        ' 
        NuevosUsuarios.Dock = DockStyle.Top
        NuevosUsuarios.FlatAppearance.BorderSize = 0
        NuevosUsuarios.FlatStyle = FlatStyle.Flat
        NuevosUsuarios.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        NuevosUsuarios.Location = New Point(0, 0)
        NuevosUsuarios.Name = "NuevosUsuarios"
        NuevosUsuarios.Padding = New Padding(35, 0, 0, 0)
        NuevosUsuarios.Size = New Size(250, 34)
        NuevosUsuarios.TabIndex = 1
        NuevosUsuarios.Text = "Nuevos Usuarios"
        NuevosUsuarios.TextAlign = ContentAlignment.MiddleLeft
        NuevosUsuarios.UseVisualStyleBackColor = True
        ' 
        ' Administración
        ' 
        Administración.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        Administración.Dock = DockStyle.Top
        Administración.FlatStyle = FlatStyle.Flat
        Administración.Font = New Font("Segoe UI", 9F)
        Administración.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Administración.Location = New Point(0, 139)
        Administración.Name = "Administración"
        Administración.Padding = New Padding(10, 0, 0, 0)
        Administración.Size = New Size(250, 45)
        Administración.TabIndex = 1
        Administración.Text = "Administración"
        Administración.TextAlign = ContentAlignment.MiddleLeft
        Administración.UseVisualStyleBackColor = False
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(PictureBox1)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(250, 139)
        PanelLogo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-10, -83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(276, 296)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' CLOSEXIT
        ' 
        CLOSEXIT.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        CLOSEXIT.Dock = DockStyle.Left
        CLOSEXIT.FlatStyle = FlatStyle.Flat
        CLOSEXIT.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        CLOSEXIT.Location = New Point(0, 0)
        CLOSEXIT.Name = "CLOSEXIT"
        CLOSEXIT.Padding = New Padding(10, 0, 0, 0)
        CLOSEXIT.Size = New Size(250, 45)
        CLOSEXIT.TabIndex = 6
        CLOSEXIT.Text = "Salir / cerrar sistema"
        CLOSEXIT.TextAlign = ContentAlignment.MiddleLeft
        CLOSEXIT.UseVisualStyleBackColor = False
        ' 
        ' LabelHora
        ' 
        LabelHora.AutoSize = True
        LabelHora.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        LabelHora.Location = New Point(63, 15)
        LabelHora.Name = "LabelHora"
        LabelHora.Size = New Size(41, 15)
        LabelHora.TabIndex = 1
        LabelHora.Text = "Label1"
        LabelHora.TextAlign = ContentAlignment.BottomRight
        ' 
        ' LabelFe
        ' 
        LabelFe.AutoSize = True
        LabelFe.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        LabelFe.Location = New Point(1, 15)
        LabelFe.Name = "LabelFe"
        LabelFe.Size = New Size(41, 15)
        LabelFe.TabIndex = 2
        LabelFe.Text = "Label2"
        LabelFe.TextAlign = ContentAlignment.BottomRight
        ' 
        ' HoraFecha
        ' 
        HoraFecha.Enabled = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LabelFe)
        Panel1.Controls.Add(LabelHora)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(1266, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(104, 45)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(CLOSEXIT)
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 620)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1370, 45)
        Panel2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(256, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 25)
        Label1.TabIndex = 4
        Label1.Text = "Conexion con la Base de Datos Activa"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(410, 141)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(300, 300)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Register)
        Panel3.Controls.Add(Login)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(250, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1120, 599)
        Panel3.TabIndex = 5
        ' 
        ' Register
        ' 
        Register.Anchor = AnchorStyles.None
        Register.FlatStyle = FlatStyle.Flat
        Register.Font = New Font("Segoe UI", 12F)
        Register.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Register.Location = New Point(624, 463)
        Register.Name = "Register"
        Register.Size = New Size(86, 33)
        Register.TabIndex = 7
        Register.Text = "Register"
        Register.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        Login.Anchor = AnchorStyles.None
        Login.FlatStyle = FlatStyle.Flat
        Login.Font = New Font("Segoe UI", 12F)
        Login.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Login.Location = New Point(410, 463)
        Login.Name = "Login"
        Login.Size = New Size(86, 33)
        Login.TabIndex = 6
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' maximizer
        ' 
        maximizer.Image = CType(resources.GetObject("maximizer.Image"), Image)
        maximizer.Location = New Point(35, 0)
        maximizer.Name = "maximizer"
        maximizer.Size = New Size(29, 21)
        maximizer.SizeMode = PictureBoxSizeMode.Zoom
        maximizer.TabIndex = 1
        maximizer.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        Panel4.Controls.Add(Panel5)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1370, 21)
        Panel4.TabIndex = 6
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(ClosePIC)
        Panel5.Controls.Add(maximizer)
        Panel5.Controls.Add(mizimizer)
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1278, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(92, 21)
        Panel5.TabIndex = 3
        ' 
        ' ClosePIC
        ' 
        ClosePIC.Image = CType(resources.GetObject("ClosePIC.Image"), Image)
        ClosePIC.Location = New Point(70, 0)
        ClosePIC.Name = "ClosePIC"
        ClosePIC.Size = New Size(22, 22)
        ClosePIC.SizeMode = PictureBoxSizeMode.Zoom
        ClosePIC.TabIndex = 0
        ClosePIC.TabStop = False
        ' 
        ' mizimizer
        ' 
        mizimizer.BackColor = Color.FromArgb(CByte(52), CByte(51), CByte(52))
        mizimizer.Image = CType(resources.GetObject("mizimizer.Image"), Image)
        mizimizer.Location = New Point(0, 0)
        mizimizer.Name = "mizimizer"
        mizimizer.Size = New Size(29, 22)
        mizimizer.SizeMode = PictureBoxSizeMode.Zoom
        mizimizer.TabIndex = 2
        mizimizer.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1370, 665)
        Controls.Add(Panel3)
        Controls.Add(PanelSideMenu)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        PanelSideMenu.ResumeLayout(False)
        PanelSideMenu.PerformLayout()
        PanelExpo.ResumeLayout(False)
        PanelVenta.ResumeLayout(False)
        PanelAdmin.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(maximizer, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(ClosePIC, ComponentModel.ISupportInitialize).EndInit()
        CType(mizimizer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelVenta As Panel
    Friend WithEvents CloseCaja As Button
    Friend WithEvents LisVentas As Button
    Friend WithEvents ListCaja As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents ListadoDeUsuarios As Button
    Friend WithEvents NuevosUsuarios As Button
    Friend WithEvents Administración As Button
    Friend WithEvents PanelExpo As Panel
    Friend WithEvents Exel As Button
    Friend WithEvents Expo As Button
    Friend WithEvents CLOSEXIT As Button
    Friend WithEvents BtnPDFExport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelFe As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents maximizer As PictureBox
    Friend WithEvents ClosePIC As PictureBox
    Friend WithEvents mizimizer As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Register As Button
    Friend WithEvents Login As Button
End Class
