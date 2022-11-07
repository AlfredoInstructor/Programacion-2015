<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bscar
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
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dtbuscar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltipobuscar = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.buscartxt = New System.Windows.Forms.Label()
        CType(Me.dtbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(137, 67)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(164, 20)
        Me.txtbuscar.TabIndex = 0
        '
        'dtbuscar
        '
        Me.dtbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtbuscar.Location = New System.Drawing.Point(12, 101)
        Me.dtbuscar.Name = "dtbuscar"
        Me.dtbuscar.Size = New System.Drawing.Size(479, 254)
        Me.dtbuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar :"
        '
        'lbltipobuscar
        '
        Me.lbltipobuscar.AutoSize = True
        Me.lbltipobuscar.BackColor = System.Drawing.Color.Transparent
        Me.lbltipobuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipobuscar.Location = New System.Drawing.Point(203, 22)
        Me.lbltipobuscar.Name = "lbltipobuscar"
        Me.lbltipobuscar.Size = New System.Drawing.Size(98, 20)
        Me.lbltipobuscar.TabIndex = 3
        Me.lbltipobuscar.Text = "lbltipobuscar"
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(167, 361)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(145, 38)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Listo"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'buscartxt
        '
        Me.buscartxt.AutoSize = True
        Me.buscartxt.BackColor = System.Drawing.Color.Transparent
        Me.buscartxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscartxt.Location = New System.Drawing.Point(69, 67)
        Me.buscartxt.Name = "buscartxt"
        Me.buscartxt.Size = New System.Drawing.Size(57, 20)
        Me.buscartxt.TabIndex = 5
        Me.buscartxt.Text = "Label2"
        '
        'bscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(503, 411)
        Me.Controls.Add(Me.buscartxt)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lbltipobuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtbuscar)
        Me.Controls.Add(Me.txtbuscar)
        Me.MaximizeBox = False
        Me.Name = "bscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.dtbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents dtbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltipobuscar As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents buscartxt As System.Windows.Forms.Label
End Class
