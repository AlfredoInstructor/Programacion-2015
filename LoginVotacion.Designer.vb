<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginVotacion
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
        Me.btnEntrarELV = New System.Windows.Forms.Button()
        Me.txtCodigoELV = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el código de la Elección:"
        '
        'btnEntrarELV
        '
        Me.btnEntrarELV.Location = New System.Drawing.Point(89, 142)
        Me.btnEntrarELV.Name = "btnEntrarELV"
        Me.btnEntrarELV.Size = New System.Drawing.Size(100, 38)
        Me.btnEntrarELV.TabIndex = 1
        Me.btnEntrarELV.Text = "Entrar"
        Me.btnEntrarELV.UseVisualStyleBackColor = True
        '
        'txtCodigoELV
        '
        Me.txtCodigoELV.Location = New System.Drawing.Point(74, 89)
        Me.txtCodigoELV.Name = "txtCodigoELV"
        Me.txtCodigoELV.Size = New System.Drawing.Size(127, 20)
        Me.txtCodigoELV.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.Button1.Location = New System.Drawing.Point(227, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoginVotacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCodigoELV)
        Me.Controls.Add(Me.btnEntrarELV)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "LoginVotacion"
        Me.Text = "LoginVotación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEntrarELV As System.Windows.Forms.Button
    Friend WithEvents txtCodigoELV As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
