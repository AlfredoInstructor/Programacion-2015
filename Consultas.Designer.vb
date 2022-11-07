<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoEC = New System.Windows.Forms.TextBox()
        Me.btnBuscarEC = New System.Windows.Forms.Button()
        Me.tbpVotosblancoEC = New System.Windows.Forms.TabPage()
        Me.Dtvotosblanco = New System.Windows.Forms.DataGridView()
        Me.tbcTotalvotEC = New System.Windows.Forms.TabPage()
        Me.Dtviewtotalvotantes = New System.Windows.Forms.DataGridView()
        Me.tbpMenosVotadosEC = New System.Windows.Forms.TabPage()
        Me.dtviewmenosvotados = New System.Windows.Forms.DataGridView()
        Me.tbcMasVotadosEC = New System.Windows.Forms.TabPage()
        Me.dtviewmasvotados = New System.Windows.Forms.DataGridView()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbpVotosblancoEC.SuspendLayout()
        CType(Me.Dtvotosblanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcTotalvotEC.SuspendLayout()
        CType(Me.Dtviewtotalvotantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpMenosVotadosEC.SuspendLayout()
        CType(Me.dtviewmenosvotados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcMasVotadosEC.SuspendLayout()
        CType(Me.dtviewmasvotados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el código de identificación de la elección:"
        '
        'txtCodigoEC
        '
        Me.txtCodigoEC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoEC.Location = New System.Drawing.Point(310, 15)
        Me.txtCodigoEC.Name = "txtCodigoEC"
        Me.txtCodigoEC.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigoEC.TabIndex = 2
        '
        'btnBuscarEC
        '
        Me.btnBuscarEC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscarEC.Location = New System.Drawing.Point(310, 53)
        Me.btnBuscarEC.Name = "btnBuscarEC"
        Me.btnBuscarEC.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarEC.TabIndex = 3
        Me.btnBuscarEC.Text = "Ver"
        Me.btnBuscarEC.UseVisualStyleBackColor = True
        '
        'tbpVotosblancoEC
        '
        Me.tbpVotosblancoEC.Controls.Add(Me.Dtvotosblanco)
        Me.tbpVotosblancoEC.Location = New System.Drawing.Point(4, 22)
        Me.tbpVotosblancoEC.Name = "tbpVotosblancoEC"
        Me.tbpVotosblancoEC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpVotosblancoEC.Size = New System.Drawing.Size(470, 182)
        Me.tbpVotosblancoEC.TabIndex = 4
        Me.tbpVotosblancoEC.Text = "Votos en blanco"
        Me.tbpVotosblancoEC.UseVisualStyleBackColor = True
        '
        'Dtvotosblanco
        '
        Me.Dtvotosblanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtvotosblanco.Location = New System.Drawing.Point(3, 0)
        Me.Dtvotosblanco.Name = "Dtvotosblanco"
        Me.Dtvotosblanco.Size = New System.Drawing.Size(506, 186)
        Me.Dtvotosblanco.TabIndex = 0
        '
        'tbcTotalvotEC
        '
        Me.tbcTotalvotEC.Controls.Add(Me.Dtviewtotalvotantes)
        Me.tbcTotalvotEC.Location = New System.Drawing.Point(4, 22)
        Me.tbcTotalvotEC.Name = "tbcTotalvotEC"
        Me.tbcTotalvotEC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcTotalvotEC.Size = New System.Drawing.Size(470, 182)
        Me.tbcTotalvotEC.TabIndex = 3
        Me.tbcTotalvotEC.Text = "Total de votantes"
        Me.tbcTotalvotEC.UseVisualStyleBackColor = True
        '
        'Dtviewtotalvotantes
        '
        Me.Dtviewtotalvotantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtviewtotalvotantes.Location = New System.Drawing.Point(3, 0)
        Me.Dtviewtotalvotantes.Name = "Dtviewtotalvotantes"
        Me.Dtviewtotalvotantes.Size = New System.Drawing.Size(506, 182)
        Me.Dtviewtotalvotantes.TabIndex = 0
        '
        'tbpMenosVotadosEC
        '
        Me.tbpMenosVotadosEC.Controls.Add(Me.dtviewmenosvotados)
        Me.tbpMenosVotadosEC.Location = New System.Drawing.Point(4, 22)
        Me.tbpMenosVotadosEC.Name = "tbpMenosVotadosEC"
        Me.tbpMenosVotadosEC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMenosVotadosEC.Size = New System.Drawing.Size(470, 182)
        Me.tbpMenosVotadosEC.TabIndex = 1
        Me.tbpMenosVotadosEC.Text = "Menos votados"
        Me.tbpMenosVotadosEC.UseVisualStyleBackColor = True
        '
        'dtviewmenosvotados
        '
        Me.dtviewmenosvotados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtviewmenosvotados.Location = New System.Drawing.Point(3, -3)
        Me.dtviewmenosvotados.Name = "dtviewmenosvotados"
        Me.dtviewmenosvotados.Size = New System.Drawing.Size(506, 182)
        Me.dtviewmenosvotados.TabIndex = 0
        '
        'tbcMasVotadosEC
        '
        Me.tbcMasVotadosEC.Controls.Add(Me.dtviewmasvotados)
        Me.tbcMasVotadosEC.Location = New System.Drawing.Point(4, 22)
        Me.tbcMasVotadosEC.Name = "tbcMasVotadosEC"
        Me.tbcMasVotadosEC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcMasVotadosEC.Size = New System.Drawing.Size(470, 182)
        Me.tbcMasVotadosEC.TabIndex = 0
        Me.tbcMasVotadosEC.Text = "Más votados"
        Me.tbcMasVotadosEC.UseVisualStyleBackColor = True
        '
        'dtviewmasvotados
        '
        Me.dtviewmasvotados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtviewmasvotados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtviewmasvotados.Location = New System.Drawing.Point(-4, 0)
        Me.dtviewmasvotados.Name = "dtviewmasvotados"
        Me.dtviewmasvotados.Size = New System.Drawing.Size(478, 186)
        Me.dtviewmasvotados.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabControl.Controls.Add(Me.tbcMasVotadosEC)
        Me.TabControl.Controls.Add(Me.tbpMenosVotadosEC)
        Me.TabControl.Controls.Add(Me.tbcTotalvotEC)
        Me.TabControl.Controls.Add(Me.tbpVotosblancoEC)
        Me.TabControl.Location = New System.Drawing.Point(0, 132)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(478, 208)
        Me.TabControl.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.Button1.Location = New System.Drawing.Point(447, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(481, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscarEC)
        Me.Controls.Add(Me.txtCodigoEC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.MaximizeBox = False
        Me.Name = "Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.tbpVotosblancoEC.ResumeLayout(False)
        CType(Me.Dtvotosblanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcTotalvotEC.ResumeLayout(False)
        CType(Me.Dtviewtotalvotantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpMenosVotadosEC.ResumeLayout(False)
        CType(Me.dtviewmenosvotados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcMasVotadosEC.ResumeLayout(False)
        CType(Me.dtviewmasvotados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEC As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarEC As System.Windows.Forms.Button
    Friend WithEvents tbpVotosblancoEC As System.Windows.Forms.TabPage
    Friend WithEvents tbcTotalvotEC As System.Windows.Forms.TabPage
    Friend WithEvents tbpMenosVotadosEC As System.Windows.Forms.TabPage
    Friend WithEvents tbcMasVotadosEC As System.Windows.Forms.TabPage
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents dtviewmasvotados As System.Windows.Forms.DataGridView
    Friend WithEvents dtviewmenosvotados As System.Windows.Forms.DataGridView
    Friend WithEvents Dtviewtotalvotantes As System.Windows.Forms.DataGridView
    Friend WithEvents Dtvotosblanco As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
