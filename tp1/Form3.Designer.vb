<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel2 = New Panel()
        ClosePIC = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel2.SuspendLayout()
        CType(ClosePIC, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.Controls.Add(ClosePIC)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1122, 35)
        Panel2.TabIndex = 0
        ' 
        ' ClosePIC
        ' 
        ClosePIC.Dock = DockStyle.Right
        ClosePIC.Image = CType(resources.GetObject("ClosePIC.Image"), Image)
        ClosePIC.Location = New Point(1075, 0)
        ClosePIC.Name = "ClosePIC"
        ClosePIC.Size = New Size(47, 35)
        ClosePIC.SizeMode = PictureBoxSizeMode.Zoom
        ClosePIC.TabIndex = 38
        ClosePIC.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.FromArgb(CByte(228), CByte(135), CByte(54))
        Label1.Location = New Point(482, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 37)
        Label1.TabIndex = 0
        Label1.Text = "Lista de Usuarios"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 39)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1122, 645)
        DataGridView1.TabIndex = 1
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1122, 683)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        Panel2.ResumeLayout(False)
        CType(ClosePIC, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ClosePIC As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
