<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.btnConsultaP = New System.Windows.Forms.Button()
        Me.btnIngresoVP = New System.Windows.Forms.Button()
        Me.btnMantenimientoP = New System.Windows.Forms.Button()
        Me.btnmanual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsultaP
        '
        Me.btnConsultaP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaP.Location = New System.Drawing.Point(120, 165)
        Me.btnConsultaP.Name = "btnConsultaP"
        Me.btnConsultaP.Size = New System.Drawing.Size(102, 63)
        Me.btnConsultaP.TabIndex = 2
        Me.btnConsultaP.Text = "Consultas"
        Me.btnConsultaP.UseVisualStyleBackColor = True
        '
        'btnIngresoVP
        '
        Me.btnIngresoVP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIngresoVP.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngresoVP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresoVP.Location = New System.Drawing.Point(120, 54)
        Me.btnIngresoVP.Name = "btnIngresoVP"
        Me.btnIngresoVP.Size = New System.Drawing.Size(102, 63)
        Me.btnIngresoVP.TabIndex = 1
        Me.btnIngresoVP.Text = "Ingreso a la Votación"
        Me.btnIngresoVP.UseVisualStyleBackColor = False
        '
        'btnMantenimientoP
        '
        Me.btnMantenimientoP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMantenimientoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimientoP.Location = New System.Drawing.Point(120, 282)
        Me.btnMantenimientoP.Name = "btnMantenimientoP"
        Me.btnMantenimientoP.Size = New System.Drawing.Size(102, 64)
        Me.btnMantenimientoP.TabIndex = 3
        Me.btnMantenimientoP.Text = "Mantenimiento"
        Me.btnMantenimientoP.UseVisualStyleBackColor = True
        '
        'btnmanual
        '
        Me.btnmanual.Image = Global.Proyecto_Final_2015.My.Resources.Resources.help
        Me.btnmanual.Location = New System.Drawing.Point(315, 1)
        Me.btnmanual.Name = "btnmanual"
        Me.btnmanual.Size = New System.Drawing.Size(26, 24)
        Me.btnmanual.TabIndex = 4
        Me.btnmanual.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(342, 375)
        Me.Controls.Add(Me.btnmanual)
        Me.Controls.Add(Me.btnMantenimientoP)
        Me.Controls.Add(Me.btnIngresoVP)
        Me.Controls.Add(Me.btnConsultaP)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsultaP As System.Windows.Forms.Button
    Friend WithEvents btnIngresoVP As System.Windows.Forms.Button
    Friend WithEvents btnMantenimientoP As System.Windows.Forms.Button
    Friend WithEvents btnmanual As System.Windows.Forms.Button
End Class
