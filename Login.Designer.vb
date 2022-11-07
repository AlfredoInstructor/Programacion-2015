<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtUsuarioL = New System.Windows.Forms.TextBox()
        Me.txtPasswordL = New System.Windows.Forms.TextBox()
        Me.btnIngresarL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsuarioL
        '
        Me.txtUsuarioL.Location = New System.Drawing.Point(91, 46)
        Me.txtUsuarioL.Name = "txtUsuarioL"
        Me.txtUsuarioL.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuarioL.TabIndex = 0
        '
        'txtPasswordL
        '
        Me.txtPasswordL.Location = New System.Drawing.Point(91, 94)
        Me.txtPasswordL.Name = "txtPasswordL"
        Me.txtPasswordL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordL.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswordL.TabIndex = 1
        '
        'btnIngresarL
        '
        Me.btnIngresarL.Location = New System.Drawing.Point(65, 165)
        Me.btnIngresarL.Name = "btnIngresarL"
        Me.btnIngresarL.Size = New System.Drawing.Size(148, 41)
        Me.btnIngresarL.TabIndex = 2
        Me.btnIngresarL.Text = "Ingresar"
        Me.btnIngresarL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngresarL)
        Me.Controls.Add(Me.txtPasswordL)
        Me.Controls.Add(Me.txtUsuarioL)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuarioL As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordL As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresarL As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
