<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Panel1 = New Panel()
        ClosePIC = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(ClosePIC, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(ClosePIC)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1111, 35)
        Panel1.TabIndex = 0
        ' 
        ' ClosePIC
        ' 
        ClosePIC.Image = CType(resources.GetObject("ClosePIC.Image"), Image)
        ClosePIC.Location = New Point(1080, 0)
        ClosePIC.Name = "ClosePIC"
        ClosePIC.Size = New Size(31, 35)
        ClosePIC.SizeMode = PictureBoxSizeMode.Zoom
        ClosePIC.TabIndex = 42
        ClosePIC.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label1.Location = New Point(449, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 37)
        Label1.TabIndex = 41
        Label1.Text = "Listado de caja"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Panel1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1111, 681)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 55)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1052, 570)
        DataGridView1.TabIndex = 0
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1111, 681)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        CType(ClosePIC, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ClosePIC As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
