<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMantenimiento
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
        Me.tbcMantenimiento = New System.Windows.Forms.TabControl()
        Me.tbpInstitucion = New System.Windows.Forms.TabPage()
        Me.btnConsultarI = New System.Windows.Forms.Button()
        Me.btnGravarI = New System.Windows.Forms.Button()
        Me.btnModificarI = New System.Windows.Forms.Button()
        Me.BtnEliminarI = New System.Windows.Forms.Button()
        Me.btnInsertarI = New System.Windows.Forms.Button()
        Me.txtTelefonoI = New System.Windows.Forms.TextBox()
        Me.txtxDireccionI = New System.Windows.Forms.TextBox()
        Me.txtDescripcionI = New System.Windows.Forms.TextBox()
        Me.txtNombreI = New System.Windows.Forms.TextBox()
        Me.txtCodigoI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpEleccion = New System.Windows.Forms.TabPage()
        Me.dtFechaE = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcionE = New System.Windows.Forms.TextBox()
        Me.txtTipoE = New System.Windows.Forms.TextBox()
        Me.txtCodigoE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConsultarE = New System.Windows.Forms.Button()
        Me.btnGravarE = New System.Windows.Forms.Button()
        Me.btnModificarE = New System.Windows.Forms.Button()
        Me.btnEliminarE = New System.Windows.Forms.Button()
        Me.btnInsertarE = New System.Windows.Forms.Button()
        Me.tbpCandidatos = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtNnombreC = New System.Windows.Forms.TextBox()
        Me.txtCedulaC = New System.Windows.Forms.TextBox()
        Me.tctCodigoC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnConsultarC = New System.Windows.Forms.Button()
        Me.btnGravarC = New System.Windows.Forms.Button()
        Me.btnModificarC = New System.Windows.Forms.Button()
        Me.btnEliminarC = New System.Windows.Forms.Button()
        Me.btnInsertarC = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbcMantenimiento.SuspendLayout()
        Me.tbpInstitucion.SuspendLayout()
        Me.tbpEleccion.SuspendLayout()
        Me.tbpCandidatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcMantenimiento
        '
        Me.tbcMantenimiento.Controls.Add(Me.tbpInstitucion)
        Me.tbcMantenimiento.Controls.Add(Me.tbpEleccion)
        Me.tbcMantenimiento.Controls.Add(Me.tbpCandidatos)
        Me.tbcMantenimiento.Location = New System.Drawing.Point(3, 2)
        Me.tbcMantenimiento.Name = "tbcMantenimiento"
        Me.tbcMantenimiento.SelectedIndex = 0
        Me.tbcMantenimiento.Size = New System.Drawing.Size(412, 357)
        Me.tbcMantenimiento.TabIndex = 0
        '
        'tbpInstitucion
        '
        Me.tbpInstitucion.Controls.Add(Me.Button1)
        Me.tbpInstitucion.Controls.Add(Me.btnConsultarI)
        Me.tbpInstitucion.Controls.Add(Me.btnGravarI)
        Me.tbpInstitucion.Controls.Add(Me.btnModificarI)
        Me.tbpInstitucion.Controls.Add(Me.BtnEliminarI)
        Me.tbpInstitucion.Controls.Add(Me.btnInsertarI)
        Me.tbpInstitucion.Controls.Add(Me.txtTelefonoI)
        Me.tbpInstitucion.Controls.Add(Me.txtxDireccionI)
        Me.tbpInstitucion.Controls.Add(Me.txtDescripcionI)
        Me.tbpInstitucion.Controls.Add(Me.txtNombreI)
        Me.tbpInstitucion.Controls.Add(Me.txtCodigoI)
        Me.tbpInstitucion.Controls.Add(Me.Label5)
        Me.tbpInstitucion.Controls.Add(Me.Label4)
        Me.tbpInstitucion.Controls.Add(Me.Label3)
        Me.tbpInstitucion.Controls.Add(Me.Label2)
        Me.tbpInstitucion.Controls.Add(Me.Label1)
        Me.tbpInstitucion.Location = New System.Drawing.Point(4, 22)
        Me.tbpInstitucion.Name = "tbpInstitucion"
        Me.tbpInstitucion.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInstitucion.Size = New System.Drawing.Size(404, 331)
        Me.tbpInstitucion.TabIndex = 0
        Me.tbpInstitucion.Text = "Institucion"
        Me.tbpInstitucion.UseVisualStyleBackColor = True
        '
        'btnConsultarI
        '
        Me.btnConsultarI.Location = New System.Drawing.Point(308, 201)
        Me.btnConsultarI.Name = "btnConsultarI"
        Me.btnConsultarI.Size = New System.Drawing.Size(75, 20)
        Me.btnConsultarI.TabIndex = 14
        Me.btnConsultarI.Text = "Consultar"
        Me.btnConsultarI.UseVisualStyleBackColor = True
        '
        'btnGravarI
        '
        Me.btnGravarI.Location = New System.Drawing.Point(308, 166)
        Me.btnGravarI.Name = "btnGravarI"
        Me.btnGravarI.Size = New System.Drawing.Size(75, 23)
        Me.btnGravarI.TabIndex = 13
        Me.btnGravarI.Text = "Gravar"
        Me.btnGravarI.UseVisualStyleBackColor = True
        '
        'btnModificarI
        '
        Me.btnModificarI.Location = New System.Drawing.Point(308, 128)
        Me.btnModificarI.Name = "btnModificarI"
        Me.btnModificarI.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarI.TabIndex = 12
        Me.btnModificarI.Text = "Modificar"
        Me.btnModificarI.UseVisualStyleBackColor = True
        '
        'BtnEliminarI
        '
        Me.BtnEliminarI.Location = New System.Drawing.Point(308, 89)
        Me.BtnEliminarI.Name = "BtnEliminarI"
        Me.BtnEliminarI.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarI.TabIndex = 11
        Me.BtnEliminarI.Text = "Eliminar"
        Me.BtnEliminarI.UseVisualStyleBackColor = True
        '
        'btnInsertarI
        '
        Me.btnInsertarI.Location = New System.Drawing.Point(308, 44)
        Me.btnInsertarI.Name = "btnInsertarI"
        Me.btnInsertarI.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarI.TabIndex = 10
        Me.btnInsertarI.Text = "Insertar"
        Me.btnInsertarI.UseVisualStyleBackColor = True
        '
        'txtTelefonoI
        '
        Me.txtTelefonoI.Location = New System.Drawing.Point(86, 194)
        Me.txtTelefonoI.Name = "txtTelefonoI"
        Me.txtTelefonoI.Size = New System.Drawing.Size(124, 20)
        Me.txtTelefonoI.TabIndex = 9
        '
        'txtxDireccionI
        '
        Me.txtxDireccionI.Location = New System.Drawing.Point(86, 164)
        Me.txtxDireccionI.Name = "txtxDireccionI"
        Me.txtxDireccionI.Size = New System.Drawing.Size(124, 20)
        Me.txtxDireccionI.TabIndex = 8
        '
        'txtDescripcionI
        '
        Me.txtDescripcionI.Location = New System.Drawing.Point(86, 126)
        Me.txtDescripcionI.Name = "txtDescripcionI"
        Me.txtDescripcionI.Size = New System.Drawing.Size(124, 20)
        Me.txtDescripcionI.TabIndex = 7
        '
        'txtNombreI
        '
        Me.txtNombreI.Location = New System.Drawing.Point(86, 92)
        Me.txtNombreI.Name = "txtNombreI"
        Me.txtNombreI.Size = New System.Drawing.Size(124, 20)
        Me.txtNombreI.TabIndex = 6
        '
        'txtCodigoI
        '
        Me.txtCodigoI.AcceptsReturn = True
        Me.txtCodigoI.Location = New System.Drawing.Point(86, 47)
        Me.txtCodigoI.Name = "txtCodigoI"
        Me.txtCodigoI.Size = New System.Drawing.Size(124, 20)
        Me.txtCodigoI.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'tbpEleccion
        '
        Me.tbpEleccion.Controls.Add(Me.dtFechaE)
        Me.tbpEleccion.Controls.Add(Me.txtDescripcionE)
        Me.tbpEleccion.Controls.Add(Me.txtTipoE)
        Me.tbpEleccion.Controls.Add(Me.txtCodigoE)
        Me.tbpEleccion.Controls.Add(Me.Label6)
        Me.tbpEleccion.Controls.Add(Me.Label7)
        Me.tbpEleccion.Controls.Add(Me.Label8)
        Me.tbpEleccion.Controls.Add(Me.Label9)
        Me.tbpEleccion.Controls.Add(Me.btnConsultarE)
        Me.tbpEleccion.Controls.Add(Me.btnGravarE)
        Me.tbpEleccion.Controls.Add(Me.btnModificarE)
        Me.tbpEleccion.Controls.Add(Me.btnEliminarE)
        Me.tbpEleccion.Controls.Add(Me.btnInsertarE)
        Me.tbpEleccion.Location = New System.Drawing.Point(4, 22)
        Me.tbpEleccion.Name = "tbpEleccion"
        Me.tbpEleccion.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEleccion.Size = New System.Drawing.Size(404, 331)
        Me.tbpEleccion.TabIndex = 1
        Me.tbpEleccion.Text = "Eleccion"
        Me.tbpEleccion.UseVisualStyleBackColor = True
        '
        'dtFechaE
        '
        Me.dtFechaE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaE.Location = New System.Drawing.Point(87, 211)
        Me.dtFechaE.Name = "dtFechaE"
        Me.dtFechaE.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaE.TabIndex = 27
        '
        'txtDescripcionE
        '
        Me.txtDescripcionE.Location = New System.Drawing.Point(87, 162)
        Me.txtDescripcionE.Name = "txtDescripcionE"
        Me.txtDescripcionE.Size = New System.Drawing.Size(124, 20)
        Me.txtDescripcionE.TabIndex = 26
        '
        'txtTipoE
        '
        Me.txtTipoE.Location = New System.Drawing.Point(87, 118)
        Me.txtTipoE.Name = "txtTipoE"
        Me.txtTipoE.Size = New System.Drawing.Size(124, 20)
        Me.txtTipoE.TabIndex = 25
        '
        'txtCodigoE
        '
        Me.txtCodigoE.Location = New System.Drawing.Point(87, 70)
        Me.txtCodigoE.Name = "txtCodigoE"
        Me.txtCodigoE.Size = New System.Drawing.Size(124, 20)
        Me.txtCodigoE.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Descripcion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Tipo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Codigo:"
        '
        'btnConsultarE
        '
        Me.btnConsultarE.Location = New System.Drawing.Point(300, 231)
        Me.btnConsultarE.Name = "btnConsultarE"
        Me.btnConsultarE.Size = New System.Drawing.Size(75, 20)
        Me.btnConsultarE.TabIndex = 19
        Me.btnConsultarE.Text = "Consultar"
        Me.btnConsultarE.UseVisualStyleBackColor = True
        '
        'btnGravarE
        '
        Me.btnGravarE.Location = New System.Drawing.Point(300, 193)
        Me.btnGravarE.Name = "btnGravarE"
        Me.btnGravarE.Size = New System.Drawing.Size(75, 23)
        Me.btnGravarE.TabIndex = 18
        Me.btnGravarE.Text = "Gravar"
        Me.btnGravarE.UseVisualStyleBackColor = True
        '
        'btnModificarE
        '
        Me.btnModificarE.Location = New System.Drawing.Point(300, 152)
        Me.btnModificarE.Name = "btnModificarE"
        Me.btnModificarE.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarE.TabIndex = 17
        Me.btnModificarE.Text = "Modificar"
        Me.btnModificarE.UseVisualStyleBackColor = True
        '
        'btnEliminarE
        '
        Me.btnEliminarE.Location = New System.Drawing.Point(300, 115)
        Me.btnEliminarE.Name = "btnEliminarE"
        Me.btnEliminarE.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarE.TabIndex = 16
        Me.btnEliminarE.Text = "Eliminar"
        Me.btnEliminarE.UseVisualStyleBackColor = True
        '
        'btnInsertarE
        '
        Me.btnInsertarE.Location = New System.Drawing.Point(300, 67)
        Me.btnInsertarE.Name = "btnInsertarE"
        Me.btnInsertarE.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarE.TabIndex = 15
        Me.btnInsertarE.Text = "Insertar"
        Me.btnInsertarE.UseVisualStyleBackColor = True
        '
        'tbpCandidatos
        '
        Me.tbpCandidatos.Controls.Add(Me.ComboBox1)
        Me.tbpCandidatos.Controls.Add(Me.txtNnombreC)
        Me.tbpCandidatos.Controls.Add(Me.txtCedulaC)
        Me.tbpCandidatos.Controls.Add(Me.tctCodigoC)
        Me.tbpCandidatos.Controls.Add(Me.Label10)
        Me.tbpCandidatos.Controls.Add(Me.Label11)
        Me.tbpCandidatos.Controls.Add(Me.Label12)
        Me.tbpCandidatos.Controls.Add(Me.Label13)
        Me.tbpCandidatos.Controls.Add(Me.btnConsultarC)
        Me.tbpCandidatos.Controls.Add(Me.btnGravarC)
        Me.tbpCandidatos.Controls.Add(Me.btnModificarC)
        Me.tbpCandidatos.Controls.Add(Me.btnEliminarC)
        Me.tbpCandidatos.Controls.Add(Me.btnInsertarC)
        Me.tbpCandidatos.Location = New System.Drawing.Point(4, 22)
        Me.tbpCandidatos.Name = "tbpCandidatos"
        Me.tbpCandidatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCandidatos.Size = New System.Drawing.Size(404, 331)
        Me.tbpCandidatos.TabIndex = 2
        Me.tbpCandidatos.Text = "Candidatos"
        Me.tbpCandidatos.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(98, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 32
        '
        'txtNnombreC
        '
        Me.txtNnombreC.Location = New System.Drawing.Point(98, 129)
        Me.txtNnombreC.Name = "txtNnombreC"
        Me.txtNnombreC.Size = New System.Drawing.Size(124, 20)
        Me.txtNnombreC.TabIndex = 31
        '
        'txtCedulaC
        '
        Me.txtCedulaC.Location = New System.Drawing.Point(98, 95)
        Me.txtCedulaC.Name = "txtCedulaC"
        Me.txtCedulaC.Size = New System.Drawing.Size(124, 20)
        Me.txtCedulaC.TabIndex = 30
        '
        'tctCodigoC
        '
        Me.tctCodigoC.Location = New System.Drawing.Point(98, 50)
        Me.tctCodigoC.Name = "tctCodigoC"
        Me.tctCodigoC.Size = New System.Drawing.Size(124, 20)
        Me.tctCodigoC.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Foto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Cedula:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Codigo:"
        '
        'btnConsultarC
        '
        Me.btnConsultarC.Location = New System.Drawing.Point(300, 211)
        Me.btnConsultarC.Name = "btnConsultarC"
        Me.btnConsultarC.Size = New System.Drawing.Size(75, 20)
        Me.btnConsultarC.TabIndex = 24
        Me.btnConsultarC.Text = "Consultar"
        Me.btnConsultarC.UseVisualStyleBackColor = True
        '
        'btnGravarC
        '
        Me.btnGravarC.Location = New System.Drawing.Point(300, 176)
        Me.btnGravarC.Name = "btnGravarC"
        Me.btnGravarC.Size = New System.Drawing.Size(75, 23)
        Me.btnGravarC.TabIndex = 23
        Me.btnGravarC.Text = "Gravar"
        Me.btnGravarC.UseVisualStyleBackColor = True
        '
        'btnModificarC
        '
        Me.btnModificarC.Location = New System.Drawing.Point(300, 138)
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarC.TabIndex = 22
        Me.btnModificarC.Text = "Modificar"
        Me.btnModificarC.UseVisualStyleBackColor = True
        '
        'btnEliminarC
        '
        Me.btnEliminarC.Location = New System.Drawing.Point(300, 96)
        Me.btnEliminarC.Name = "btnEliminarC"
        Me.btnEliminarC.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarC.TabIndex = 21
        Me.btnEliminarC.Text = "Eliminar"
        Me.btnEliminarC.UseVisualStyleBackColor = True
        '
        'btnInsertarC
        '
        Me.btnInsertarC.Location = New System.Drawing.Point(300, 47)
        Me.btnInsertarC.Name = "btnInsertarC"
        Me.btnInsertarC.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertarC.TabIndex = 20
        Me.btnInsertarC.Text = "Insertar"
        Me.btnInsertarC.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 361)
        Me.Controls.Add(Me.tbcMantenimiento)
        Me.Name = "MenuMantenimiento"
        Me.Text = "Mantenimiento"
        Me.tbcMantenimiento.ResumeLayout(False)
        Me.tbpInstitucion.ResumeLayout(False)
        Me.tbpInstitucion.PerformLayout()
        Me.tbpEleccion.ResumeLayout(False)
        Me.tbpEleccion.PerformLayout()
        Me.tbpCandidatos.ResumeLayout(False)
        Me.tbpCandidatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcMantenimiento As System.Windows.Forms.TabControl
    Friend WithEvents tbpInstitucion As System.Windows.Forms.TabPage
    Friend WithEvents tbpEleccion As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbpCandidatos As System.Windows.Forms.TabPage
    Friend WithEvents btnConsultarI As System.Windows.Forms.Button
    Friend WithEvents btnGravarI As System.Windows.Forms.Button
    Friend WithEvents btnModificarI As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarI As System.Windows.Forms.Button
    Friend WithEvents btnInsertarI As System.Windows.Forms.Button
    Friend WithEvents txtTelefonoI As System.Windows.Forms.TextBox
    Friend WithEvents txtxDireccionI As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreI As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnConsultarE As System.Windows.Forms.Button
    Friend WithEvents btnGravarE As System.Windows.Forms.Button
    Friend WithEvents btnModificarE As System.Windows.Forms.Button
    Friend WithEvents btnEliminarE As System.Windows.Forms.Button
    Friend WithEvents btnInsertarE As System.Windows.Forms.Button
    Friend WithEvents txtDescripcionE As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNnombreC As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaC As System.Windows.Forms.TextBox
    Friend WithEvents tctCodigoC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnConsultarC As System.Windows.Forms.Button
    Friend WithEvents btnGravarC As System.Windows.Forms.Button
    Friend WithEvents btnModificarC As System.Windows.Forms.Button
    Friend WithEvents btnEliminarC As System.Windows.Forms.Button
    Friend WithEvents btnInsertarC As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaE As System.Windows.Forms.DateTimePicker

    
    Private Sub btnInsertarI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarI.Click

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Votacion.ShowDialog()
        Principal.ShowDialog()
    End Sub
End Class
