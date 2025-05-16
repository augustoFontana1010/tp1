<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(965, 35)
        Panel1.TabIndex = 41
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(931, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 42
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label3.Location = New Point(433, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(217, 37)
        Label3.TabIndex = 41
        Label3.Text = "Cierre de caja"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1263, -31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Panel1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(965, 664)
        Panel3.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button2.Location = New Point(527, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 33)
        Button2.TabIndex = 47
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button1.Location = New Point(433, 383)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 33)
        Button1.TabIndex = 46
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(476, 298)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(108, 79)
        TextBox4.TabIndex = 45
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label5.Location = New Point(358, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 21)
        Label5.TabIndex = 44
        Label5.Text = "Observaciones"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(476, 249)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(108, 23)
        TextBox3.TabIndex = 43
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label4.Location = New Point(409, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 21)
        Label4.TabIndex = 42
        Label4.Text = "Monto"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(965, 664)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form6"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
End Class
