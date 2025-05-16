<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Panel1 = New Panel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1154, 722)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Button1.Location = New Point(491, 455)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 59)
        Button1.TabIndex = 2
        Button1.Text = "Subir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(426, 209)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(301, 240)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1154, 35)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1120, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 43
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label3.Location = New Point(468, -2)
        Label3.Name = "Label3"
        Label3.Size = New Size(244, 37)
        Label3.TabIndex = 42
        Label3.Text = "Exportacion a EXEL"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1154, 722)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form7"
        Text = "Form7"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
