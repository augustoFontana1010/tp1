<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 450)
        Panel1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(387, 254)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(108, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(387, 208)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(108, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label3.Location = New Point(295, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 21)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label2.Location = New Point(306, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 21)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(801, 35)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label1.Location = New Point(397, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 37)
        Label1.TabIndex = 41
        Label1.Text = "Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button1.Location = New Point(397, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 36)
        Button1.TabIndex = 10
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(342, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(192, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label4.Location = New Point(271, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 21)
        Label4.TabIndex = 12
        Label4.Text = "Ver contraseña"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Segoe UI", 12F)
        CheckBox1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        CheckBox1.Location = New Point(390, 295)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(12, 11)
        CheckBox1.TabIndex = 13
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form9"
        Text = "Form9"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
End Class
