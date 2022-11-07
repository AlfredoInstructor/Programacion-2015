<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarcandidato
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
        Me.btnCargarCandidatoEM = New System.Windows.Forms.Button()
        Me.ltbxcand = New System.Windows.Forms.ListBox()
        Me.txtcandidato = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnlisto = New System.Windows.Forms.Button()
        Me.pctbximagcand = New System.Windows.Forms.PictureBox()
        Me.btnvercandidato = New System.Windows.Forms.Button()
        Me.lblcandidatodato = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pctbximagcand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargarCandidatoEM
        '
        Me.btnCargarCandidatoEM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCargarCandidatoEM.Location = New System.Drawing.Point(15, 217)
        Me.btnCargarCandidatoEM.Name = "btnCargarCandidatoEM"
        Me.btnCargarCandidatoEM.Size = New System.Drawing.Size(102, 49)
        Me.btnCargarCandidatoEM.TabIndex = 30
        Me.btnCargarCandidatoEM.Text = "Cargar candidato"
        Me.btnCargarCandidatoEM.UseVisualStyleBackColor = True
        '
        'ltbxcand
        '
        Me.ltbxcand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ltbxcand.FormattingEnabled = True
        Me.ltbxcand.Location = New System.Drawing.Point(315, 194)
        Me.ltbxcand.Name = "ltbxcand"
        Me.ltbxcand.Size = New System.Drawing.Size(108, 147)
        Me.ltbxcand.TabIndex = 29
        '
        'txtcandidato
        '
        Me.txtcandidato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcandidato.Location = New System.Drawing.Point(143, 54)
        Me.txtcandidato.Name = "txtcandidato"
        Me.txtcandidato.Size = New System.Drawing.Size(101, 20)
        Me.txtcandidato.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(7, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Candidatos(código):"
        '
        'btnlisto
        '
        Me.btnlisto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlisto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlisto.Location = New System.Drawing.Point(15, 289)
        Me.btnlisto.Name = "btnlisto"
        Me.btnlisto.Size = New System.Drawing.Size(102, 42)
        Me.btnlisto.TabIndex = 31
        Me.btnlisto.Text = "Finalizar"
        Me.btnlisto.UseVisualStyleBackColor = True
        '
        'pctbximagcand
        '
        Me.pctbximagcand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctbximagcand.Location = New System.Drawing.Point(289, 12)
        Me.pctbximagcand.Name = "pctbximagcand"
        Me.pctbximagcand.Size = New System.Drawing.Size(134, 112)
        Me.pctbximagcand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbximagcand.TabIndex = 32
        Me.pctbximagcand.TabStop = False
        '
        'btnvercandidato
        '
        Me.btnvercandidato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnvercandidato.Image = Global.Proyecto_Final_2015.My.Resources.Resources.eye
        Me.btnvercandidato.Location = New System.Drawing.Point(237, 97)
        Me.btnvercandidato.Name = "btnvercandidato"
        Me.btnvercandidato.Size = New System.Drawing.Size(35, 27)
        Me.btnvercandidato.TabIndex = 33
        Me.btnvercandidato.UseVisualStyleBackColor = True
        '
        'lblcandidatodato
        '
        Me.lblcandidatodato.AutoSize = True
        Me.lblcandidatodato.BackColor = System.Drawing.Color.Transparent
        Me.lblcandidatodato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcandidatodato.Location = New System.Drawing.Point(323, 127)
        Me.lblcandidatodato.Name = "lblcandidatodato"
        Me.lblcandidatodato.Size = New System.Drawing.Size(68, 16)
        Me.lblcandidatodato.TabIndex = 34
        Me.lblcandidatodato.Text = "candidato"
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.Button1.Location = New System.Drawing.Point(250, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Código Candidatos Cargados:"
        '
        'agregarcandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(447, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblcandidatodato)
        Me.Controls.Add(Me.btnvercandidato)
        Me.Controls.Add(Me.pctbximagcand)
        Me.Controls.Add(Me.btnlisto)
        Me.Controls.Add(Me.btnCargarCandidatoEM)
        Me.Controls.Add(Me.ltbxcand)
        Me.Controls.Add(Me.txtcandidato)
        Me.Controls.Add(Me.Label15)
        Me.MaximizeBox = False
        Me.Name = "agregarcandidato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Candidatos"
        CType(Me.pctbximagcand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargarCandidatoEM As System.Windows.Forms.Button
    Friend WithEvents ltbxcand As System.Windows.Forms.ListBox
    Friend WithEvents txtcandidato As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnlisto As System.Windows.Forms.Button
    Friend WithEvents pctbximagcand As System.Windows.Forms.PictureBox
    Friend WithEvents btnvercandidato As System.Windows.Forms.Button
    Friend WithEvents lblcandidatodato As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
