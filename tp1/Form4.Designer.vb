<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        ClosePIC = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ClosePIC, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(965, 664)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button2.Location = New Point(526, 438)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 36)
        Button2.TabIndex = 10
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button1.Location = New Point(432, 438)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 36)
        Button1.TabIndex = 9
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(480, 324)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(108, 79)
        TextBox4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label5.Location = New Point(362, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 21)
        Label5.TabIndex = 7
        Label5.Text = "Observaciones"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(480, 275)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(108, 23)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label4.Location = New Point(413, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 21)
        Label4.TabIndex = 5
        Label4.Text = "Monto"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(480, 232)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(108, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label3.Location = New Point(410, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 21)
        Label3.TabIndex = 3
        Label3.Text = "Fecha"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(96), CByte(96), CByte(96))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(480, 192)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(108, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label2.Location = New Point(410, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 21)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ClosePIC)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(965, 35)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label1.Location = New Point(401, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 37)
        Label1.TabIndex = 40
        Label1.Text = "Apertura de caja"
        ' 
        ' ClosePIC
        ' 
        ClosePIC.Dock = DockStyle.Right
        ClosePIC.Image = CType(resources.GetObject("ClosePIC.Image"), Image)
        ClosePIC.Location = New Point(931, 0)
        ClosePIC.Name = "ClosePIC"
        ClosePIC.Size = New Size(34, 35)
        ClosePIC.SizeMode = PictureBoxSizeMode.Zoom
        ClosePIC.TabIndex = 39
        ClosePIC.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(965, 664)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(ClosePIC, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClosePIC As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
End Class
