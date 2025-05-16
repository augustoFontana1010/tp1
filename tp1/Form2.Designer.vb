<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Panel2 = New Panel()
        ClosePIC = New PictureBox()
        Label9 = New Label()
        subriFOTO = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TbOB = New TextBox()
        Label8 = New Label()
        pbfoto = New PictureBox()
        TbAREA = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        TbCR = New TextBox()
        Label5 = New Label()
        TbNum = New TextBox()
        Label4 = New Label()
        TbDIR = New TextBox()
        Label3 = New Label()
        TbDNI = New TextBox()
        Label2 = New Label()
        TbA = New TextBox()
        Label1 = New Label()
        TbNom = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ClosePIC, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbfoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(subriFOTO)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TbOB)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(pbfoto)
        Panel1.Controls.Add(TbAREA)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TbCR)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TbNum)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TbDIR)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TbDNI)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TbA)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TbNom)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1122, 685)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ClosePIC)
        Panel2.Controls.Add(Label9)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1122, 35)
        Panel2.TabIndex = 36
        ' 
        ' ClosePIC
        ' 
        ClosePIC.Image = CType(resources.GetObject("ClosePIC.Image"), Image)
        ClosePIC.Location = New Point(1088, 0)
        ClosePIC.Name = "ClosePIC"
        ClosePIC.Size = New Size(31, 35)
        ClosePIC.SizeMode = PictureBoxSizeMode.Zoom
        ClosePIC.TabIndex = 37
        ClosePIC.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20F)
        Label9.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label9.Location = New Point(485, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(193, 37)
        Label9.TabIndex = 0
        Label9.Text = "Nuevo Usuario"
        ' 
        ' subriFOTO
        ' 
        subriFOTO.FlatStyle = FlatStyle.Flat
        subriFOTO.Font = New Font("Segoe UI", 12F)
        subriFOTO.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        subriFOTO.Location = New Point(118, 351)
        subriFOTO.Name = "subriFOTO"
        subriFOTO.Size = New Size(97, 37)
        subriFOTO.TabIndex = 1
        subriFOTO.Text = "Subir foto"
        subriFOTO.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button2.Location = New Point(578, 501)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 39)
        Button2.TabIndex = 11
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button1.Location = New Point(448, 501)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 39)
        Button1.TabIndex = 10
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TbOB
        ' 
        TbOB.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbOB.BorderStyle = BorderStyle.FixedSingle
        TbOB.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbOB.Location = New Point(435, 391)
        TbOB.Multiline = True
        TbOB.Name = "TbOB"
        TbOB.Size = New Size(253, 92)
        TbOB.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label8.Location = New Point(501, 367)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 21)
        Label8.TabIndex = 30
        Label8.Text = "Observaciones"
        ' 
        ' pbfoto
        ' 
        pbfoto.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        pbfoto.Location = New Point(86, 179)
        pbfoto.Name = "pbfoto"
        pbfoto.Size = New Size(166, 166)
        pbfoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbfoto.TabIndex = 29
        pbfoto.TabStop = False
        ' 
        ' TbAREA
        ' 
        TbAREA.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbAREA.BorderStyle = BorderStyle.FixedSingle
        TbAREA.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbAREA.Location = New Point(783, 261)
        TbAREA.Name = "TbAREA"
        TbAREA.Size = New Size(55, 23)
        TbAREA.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label7.Location = New Point(144, 145)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 21)
        Label7.TabIndex = 27
        Label7.Text = "Foto"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label6.Location = New Point(639, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 21)
        Label6.TabIndex = 25
        Label6.Text = "Correo electrónico"
        ' 
        ' TbCR
        ' 
        TbCR.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbCR.BorderStyle = BorderStyle.FixedSingle
        TbCR.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbCR.Location = New Point(783, 300)
        TbCR.Name = "TbCR"
        TbCR.Size = New Size(253, 23)
        TbCR.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label5.Location = New Point(707, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 21)
        Label5.TabIndex = 23
        Label5.Text = "Teléfono"
        ' 
        ' TbNum
        ' 
        TbNum.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbNum.BorderStyle = BorderStyle.FixedSingle
        TbNum.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbNum.Location = New Point(844, 261)
        TbNum.Name = "TbNum"
        TbNum.Size = New Size(192, 23)
        TbNum.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label4.Location = New Point(698, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 21
        Label4.Text = "Dirección "
        ' 
        ' TbDIR
        ' 
        TbDIR.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbDIR.BorderStyle = BorderStyle.FixedSingle
        TbDIR.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbDIR.Location = New Point(783, 223)
        TbDIR.Name = "TbDIR"
        TbDIR.Size = New Size(253, 23)
        TbDIR.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label3.Location = New Point(297, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 21)
        Label3.TabIndex = 19
        Label3.Text = "DNI"
        ' 
        ' TbDNI
        ' 
        TbDNI.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbDNI.BorderStyle = BorderStyle.FixedSingle
        TbDNI.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbDNI.Location = New Point(356, 303)
        TbDNI.Name = "TbDNI"
        TbDNI.Size = New Size(253, 23)
        TbDNI.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label2.Location = New Point(281, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 21)
        Label2.TabIndex = 17
        Label2.Text = "Apellido"
        ' 
        ' TbA
        ' 
        TbA.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbA.BorderStyle = BorderStyle.FixedSingle
        TbA.CharacterCasing = CharacterCasing.Upper
        TbA.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbA.Location = New Point(356, 264)
        TbA.Name = "TbA"
        TbA.Size = New Size(253, 23)
        TbA.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label1.Location = New Point(282, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 15
        Label1.Text = "Nombre"
        ' 
        ' TbNom
        ' 
        TbNom.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TbNom.BorderStyle = BorderStyle.FixedSingle
        TbNom.CharacterCasing = CharacterCasing.Upper
        TbNom.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        TbNom.Location = New Point(356, 223)
        TbNom.Name = "TbNom"
        TbNom.Size = New Size(253, 23)
        TbNom.TabIndex = 2
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1122, 684)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ClosePIC, ComponentModel.ISupportInitialize).EndInit()
        CType(pbfoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbCR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbDIR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbDNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNom As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TbAREA As TextBox
    Friend WithEvents TbOB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbfoto As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents subriFOTO As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClosePIC As PictureBox
    Friend WithEvents Label9 As Label
End Class
