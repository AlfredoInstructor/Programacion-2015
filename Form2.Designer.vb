<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btncontrolar = New System.Windows.Forms.Button()
        Me.txtcontrolarvot = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncontrolar
        '
        Me.btncontrolar.Location = New System.Drawing.Point(279, 76)
        Me.btncontrolar.Name = "btncontrolar"
        Me.btncontrolar.Size = New System.Drawing.Size(97, 23)
        Me.btncontrolar.TabIndex = 0
        Me.btncontrolar.Text = "Siguiente"
        Me.btncontrolar.UseVisualStyleBackColor = True
        '
        'txtcontrolarvot
        '
        Me.txtcontrolarvot.Location = New System.Drawing.Point(118, 50)
        Me.txtcontrolarvot.Name = "txtcontrolarvot"
        Me.txtcontrolarvot.Size = New System.Drawing.Size(154, 20)
        Me.txtcontrolarvot.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Digite el código de la elección que se está llevando a cabo:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(388, 111)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcontrolarvot)
        Me.Controls.Add(Me.btncontrolar)
        Me.Name = "Form2"
        Me.Text = "Control de la Votación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncontrolar As System.Windows.Forms.Button
    Friend WithEvents txtcontrolarvot As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
