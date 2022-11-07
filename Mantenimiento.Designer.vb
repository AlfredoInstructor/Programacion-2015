<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbpCandidatosM = New System.Windows.Forms.TabPage()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.cargar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarCM = New System.Windows.Forms.Button()
        Me.btnInsertarCM = New System.Windows.Forms.Button()
        Me.txtNombreCM = New System.Windows.Forms.TextBox()
        Me.txtCedulaCM = New System.Windows.Forms.TextBox()
        Me.txtCodigoCM = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tboEleccionesM = New System.Windows.Forms.TabPage()
        Me.lblinstnombremant = New System.Windows.Forms.Label()
        Me.btnbscrinst = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCodigoIE = New System.Windows.Forms.TextBox()
        Me.txtDescripcionEM = New System.Windows.Forms.TextBox()
        Me.txtTipoEM = New System.Windows.Forms.TextBox()
        Me.txtCodigoEM = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCrearEM = New System.Windows.Forms.Button()
        Me.dttFechaEM = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbpInstitucionesM = New System.Windows.Forms.TabPage()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnBuscarIM = New System.Windows.Forms.Button()
        Me.btnInsertarIM = New System.Windows.Forms.Button()
        Me.txtTelefonoIM = New System.Windows.Forms.TextBox()
        Me.txtDireccionIM = New System.Windows.Forms.TextBox()
        Me.txtDescripcionIM = New System.Windows.Forms.TextBox()
        Me.txtNombreIM = New System.Windows.Forms.TextBox()
        Me.txtCodigoIM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblfechacerrareleccion = New System.Windows.Forms.Label()
        Me.La = New System.Windows.Forms.Label()
        Me.Txtnomnbinstc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtbuscarcerrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtinstcod = New System.Windows.Forms.TextBox()
        Me.txtdescc = New System.Windows.Forms.TextBox()
        Me.txttipoc = New System.Windows.Forms.TextBox()
        Me.txtcerrarelec = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbpCandidatosM.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tboEleccionesM.SuspendLayout()
        Me.tbpInstitucionesM.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "(*.jpg)|*.jpg|All Files (*.*)|*.*"
        '
        'tbpCandidatosM
        '
        Me.tbpCandidatosM.Controls.Add(Me.limpiar)
        Me.tbpCandidatosM.Controls.Add(Me.cargar)
        Me.tbpCandidatosM.Controls.Add(Me.PictureBox1)
        Me.tbpCandidatosM.Controls.Add(Me.btnBuscarCM)
        Me.tbpCandidatosM.Controls.Add(Me.btnInsertarCM)
        Me.tbpCandidatosM.Controls.Add(Me.txtNombreCM)
        Me.tbpCandidatosM.Controls.Add(Me.txtCedulaCM)
        Me.tbpCandidatosM.Controls.Add(Me.txtCodigoCM)
        Me.tbpCandidatosM.Controls.Add(Me.Label13)
        Me.tbpCandidatosM.Controls.Add(Me.Label12)
        Me.tbpCandidatosM.Controls.Add(Me.Label11)
        Me.tbpCandidatosM.Controls.Add(Me.Label10)
        Me.tbpCandidatosM.Location = New System.Drawing.Point(4, 22)
        Me.tbpCandidatosM.Name = "tbpCandidatosM"
        Me.tbpCandidatosM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCandidatosM.Size = New System.Drawing.Size(399, 364)
        Me.tbpCandidatosM.TabIndex = 2
        Me.tbpCandidatosM.Text = "Candidatos"
        Me.tbpCandidatosM.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(243, 39)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(80, 23)
        Me.limpiar.TabIndex = 22
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'cargar
        '
        Me.cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargar.Location = New System.Drawing.Point(76, 157)
        Me.cargar.Name = "cargar"
        Me.cargar.Size = New System.Drawing.Size(58, 24)
        Me.cargar.TabIndex = 21
        Me.cargar.Text = "Importar"
        Me.cargar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(74, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnBuscarCM
        '
        Me.btnBuscarCM.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.btnBuscarCM.Location = New System.Drawing.Point(204, 39)
        Me.btnBuscarCM.Name = "btnBuscarCM"
        Me.btnBuscarCM.Size = New System.Drawing.Size(33, 23)
        Me.btnBuscarCM.TabIndex = 19
        Me.btnBuscarCM.UseVisualStyleBackColor = True
        '
        'btnInsertarCM
        '
        Me.btnInsertarCM.Location = New System.Drawing.Point(74, 315)
        Me.btnInsertarCM.Name = "btnInsertarCM"
        Me.btnInsertarCM.Size = New System.Drawing.Size(102, 30)
        Me.btnInsertarCM.TabIndex = 15
        Me.btnInsertarCM.Text = "Insertar"
        Me.btnInsertarCM.UseVisualStyleBackColor = True
        '
        'txtNombreCM
        '
        Me.txtNombreCM.Location = New System.Drawing.Point(76, 120)
        Me.txtNombreCM.Name = "txtNombreCM"
        Me.txtNombreCM.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCM.TabIndex = 6
        '
        'txtCedulaCM
        '
        Me.txtCedulaCM.Location = New System.Drawing.Point(76, 82)
        Me.txtCedulaCM.Name = "txtCedulaCM"
        Me.txtCedulaCM.Size = New System.Drawing.Size(100, 20)
        Me.txtCedulaCM.TabIndex = 5
        '
        'txtCodigoCM
        '
        Me.txtCodigoCM.Location = New System.Drawing.Point(76, 42)
        Me.txtCodigoCM.Name = "txtCodigoCM"
        Me.txtCodigoCM.Size = New System.Drawing.Size(122, 20)
        Me.txtCodigoCM.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Foto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cedula:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Código:"
        '
        'tboEleccionesM
        '
        Me.tboEleccionesM.Controls.Add(Me.lblinstnombremant)
        Me.tboEleccionesM.Controls.Add(Me.btnbscrinst)
        Me.tboEleccionesM.Controls.Add(Me.btnclear)
        Me.tboEleccionesM.Controls.Add(Me.Button1)
        Me.tboEleccionesM.Controls.Add(Me.txtCodigoIE)
        Me.tboEleccionesM.Controls.Add(Me.txtDescripcionEM)
        Me.tboEleccionesM.Controls.Add(Me.txtTipoEM)
        Me.tboEleccionesM.Controls.Add(Me.txtCodigoEM)
        Me.tboEleccionesM.Controls.Add(Me.Label14)
        Me.tboEleccionesM.Controls.Add(Me.btnCrearEM)
        Me.tboEleccionesM.Controls.Add(Me.dttFechaEM)
        Me.tboEleccionesM.Controls.Add(Me.Label9)
        Me.tboEleccionesM.Controls.Add(Me.Label8)
        Me.tboEleccionesM.Controls.Add(Me.Label7)
        Me.tboEleccionesM.Controls.Add(Me.Label6)
        Me.tboEleccionesM.Location = New System.Drawing.Point(4, 22)
        Me.tboEleccionesM.Name = "tboEleccionesM"
        Me.tboEleccionesM.Padding = New System.Windows.Forms.Padding(3)
        Me.tboEleccionesM.Size = New System.Drawing.Size(399, 364)
        Me.tboEleccionesM.TabIndex = 1
        Me.tboEleccionesM.Text = "Elecciones"
        Me.tboEleccionesM.UseVisualStyleBackColor = True
        '
        'lblinstnombremant
        '
        Me.lblinstnombremant.AutoSize = True
        Me.lblinstnombremant.Location = New System.Drawing.Point(310, 80)
        Me.lblinstnombremant.Name = "lblinstnombremant"
        Me.lblinstnombremant.Size = New System.Drawing.Size(0, 13)
        Me.lblinstnombremant.TabIndex = 29
        '
        'btnbscrinst
        '
        Me.btnbscrinst.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.btnbscrinst.Location = New System.Drawing.Point(269, 77)
        Me.btnbscrinst.Name = "btnbscrinst"
        Me.btnbscrinst.Size = New System.Drawing.Size(25, 20)
        Me.btnbscrinst.TabIndex = 28
        Me.btnbscrinst.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(303, 35)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(62, 20)
        Me.btnclear.TabIndex = 27
        Me.btnclear.Text = "Limpiar"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.Button1.Location = New System.Drawing.Point(269, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCodigoIE
        '
        Me.txtCodigoIE.Location = New System.Drawing.Point(119, 78)
        Me.txtCodigoIE.Name = "txtCodigoIE"
        Me.txtCodigoIE.Size = New System.Drawing.Size(144, 20)
        Me.txtCodigoIE.TabIndex = 5
        '
        'txtDescripcionEM
        '
        Me.txtDescripcionEM.Location = New System.Drawing.Point(119, 173)
        Me.txtDescripcionEM.Multiline = True
        Me.txtDescripcionEM.Name = "txtDescripcionEM"
        Me.txtDescripcionEM.Size = New System.Drawing.Size(144, 78)
        Me.txtDescripcionEM.TabIndex = 7
        '
        'txtTipoEM
        '
        Me.txtTipoEM.Location = New System.Drawing.Point(119, 124)
        Me.txtTipoEM.Name = "txtTipoEM"
        Me.txtTipoEM.Size = New System.Drawing.Size(144, 20)
        Me.txtTipoEM.TabIndex = 6
        '
        'txtCodigoEM
        '
        Me.txtCodigoEM.Location = New System.Drawing.Point(119, 36)
        Me.txtCodigoEM.Name = "txtCodigoEM"
        Me.txtCodigoEM.Size = New System.Drawing.Size(144, 20)
        Me.txtCodigoEM.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Institución(Código):"
        '
        'btnCrearEM
        '
        Me.btnCrearEM.Location = New System.Drawing.Point(119, 316)
        Me.btnCrearEM.Name = "btnCrearEM"
        Me.btnCrearEM.Size = New System.Drawing.Size(97, 27)
        Me.btnCrearEM.TabIndex = 15
        Me.btnCrearEM.Text = "Siguiente"
        Me.btnCrearEM.UseVisualStyleBackColor = True
        '
        'dttFechaEM
        '
        Me.dttFechaEM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttFechaEM.Location = New System.Drawing.Point(119, 274)
        Me.dttFechaEM.Name = "dttFechaEM"
        Me.dttFechaEM.Size = New System.Drawing.Size(144, 20)
        Me.dttFechaEM.TabIndex = 8
        Me.dttFechaEM.Value = New Date(2015, 11, 4, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Descripción:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código:"
        '
        'tbpInstitucionesM
        '
        Me.tbpInstitucionesM.Controls.Add(Me.btnlimpiar)
        Me.tbpInstitucionesM.Controls.Add(Me.btnBuscarIM)
        Me.tbpInstitucionesM.Controls.Add(Me.btnInsertarIM)
        Me.tbpInstitucionesM.Controls.Add(Me.txtTelefonoIM)
        Me.tbpInstitucionesM.Controls.Add(Me.txtDireccionIM)
        Me.tbpInstitucionesM.Controls.Add(Me.txtDescripcionIM)
        Me.tbpInstitucionesM.Controls.Add(Me.txtNombreIM)
        Me.tbpInstitucionesM.Controls.Add(Me.txtCodigoIM)
        Me.tbpInstitucionesM.Controls.Add(Me.Label5)
        Me.tbpInstitucionesM.Controls.Add(Me.Label4)
        Me.tbpInstitucionesM.Controls.Add(Me.Label3)
        Me.tbpInstitucionesM.Controls.Add(Me.Label2)
        Me.tbpInstitucionesM.Controls.Add(Me.Label1)
        Me.tbpInstitucionesM.Location = New System.Drawing.Point(4, 22)
        Me.tbpInstitucionesM.Name = "tbpInstitucionesM"
        Me.tbpInstitucionesM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInstitucionesM.Size = New System.Drawing.Size(399, 364)
        Me.tbpInstitucionesM.TabIndex = 0
        Me.tbpInstitucionesM.Text = "Instituciones"
        Me.tbpInstitucionesM.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(272, 41)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(61, 21)
        Me.btnlimpiar.TabIndex = 15
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscarIM
        '
        Me.btnBuscarIM.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.btnBuscarIM.Location = New System.Drawing.Point(214, 41)
        Me.btnBuscarIM.Name = "btnBuscarIM"
        Me.btnBuscarIM.Size = New System.Drawing.Size(29, 21)
        Me.btnBuscarIM.TabIndex = 1
        Me.btnBuscarIM.UseVisualStyleBackColor = True
        '
        'btnInsertarIM
        '
        Me.btnInsertarIM.Location = New System.Drawing.Point(79, 301)
        Me.btnInsertarIM.Name = "btnInsertarIM"
        Me.btnInsertarIM.Size = New System.Drawing.Size(100, 32)
        Me.btnInsertarIM.TabIndex = 6
        Me.btnInsertarIM.Text = "Insertar"
        Me.btnInsertarIM.UseVisualStyleBackColor = True
        '
        'txtTelefonoIM
        '
        Me.txtTelefonoIM.Location = New System.Drawing.Point(79, 251)
        Me.txtTelefonoIM.Name = "txtTelefonoIM"
        Me.txtTelefonoIM.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefonoIM.TabIndex = 5
        '
        'txtDireccionIM
        '
        Me.txtDireccionIM.Location = New System.Drawing.Point(79, 210)
        Me.txtDireccionIM.Name = "txtDireccionIM"
        Me.txtDireccionIM.Size = New System.Drawing.Size(198, 20)
        Me.txtDireccionIM.TabIndex = 4
        '
        'txtDescripcionIM
        '
        Me.txtDescripcionIM.Location = New System.Drawing.Point(79, 121)
        Me.txtDescripcionIM.Multiline = True
        Me.txtDescripcionIM.Name = "txtDescripcionIM"
        Me.txtDescripcionIM.Size = New System.Drawing.Size(198, 66)
        Me.txtDescripcionIM.TabIndex = 3
        '
        'txtNombreIM
        '
        Me.txtNombreIM.Location = New System.Drawing.Point(79, 80)
        Me.txtNombreIM.Name = "txtNombreIM"
        Me.txtNombreIM.Size = New System.Drawing.Size(129, 20)
        Me.txtNombreIM.TabIndex = 2
        '
        'txtCodigoIM
        '
        Me.txtCodigoIM.Location = New System.Drawing.Point(79, 41)
        Me.txtCodigoIM.Name = "txtCodigoIM"
        Me.txtCodigoIM.Size = New System.Drawing.Size(129, 20)
        Me.txtCodigoIM.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabControl1.Controls.Add(Me.tbpInstitucionesM)
        Me.TabControl1.Controls.Add(Me.tbpCandidatosM)
        Me.TabControl1.Controls.Add(Me.tboEleccionesM)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(407, 390)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblfechacerrareleccion)
        Me.TabPage1.Controls.Add(Me.La)
        Me.TabPage1.Controls.Add(Me.Txtnomnbinstc)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtbuscarcerrar)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.txtinstcod)
        Me.TabPage1.Controls.Add(Me.txtdescc)
        Me.TabPage1.Controls.Add(Me.txttipoc)
        Me.TabPage1.Controls.Add(Me.txtcerrarelec)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(399, 364)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Cerrar Elección"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblfechacerrareleccion
        '
        Me.lblfechacerrareleccion.AutoSize = True
        Me.lblfechacerrareleccion.Location = New System.Drawing.Point(112, 307)
        Me.lblfechacerrareleccion.Name = "lblfechacerrareleccion"
        Me.lblfechacerrareleccion.Size = New System.Drawing.Size(0, 13)
        Me.lblfechacerrareleccion.TabIndex = 37
        '
        'La
        '
        Me.La.AutoSize = True
        Me.La.Location = New System.Drawing.Point(66, 307)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(40, 13)
        Me.La.TabIndex = 36
        Me.La.Text = "Fecha:"
        '
        'Txtnomnbinstc
        '
        Me.Txtnomnbinstc.Location = New System.Drawing.Point(112, 86)
        Me.Txtnomnbinstc.Name = "Txtnomnbinstc"
        Me.Txtnomnbinstc.Size = New System.Drawing.Size(128, 20)
        Me.Txtnomnbinstc.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Nombre Institución"
        '
        'txtbuscarcerrar
        '
        Me.txtbuscarcerrar.Image = Global.Proyecto_Final_2015.My.Resources.Resources.zoom
        Me.txtbuscarcerrar.Location = New System.Drawing.Point(268, 42)
        Me.txtbuscarcerrar.Name = "txtbuscarcerrar"
        Me.txtbuscarcerrar.Size = New System.Drawing.Size(32, 23)
        Me.txtbuscarcerrar.TabIndex = 33
        Me.txtbuscarcerrar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 39)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cerrar Elección"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtinstcod
        '
        Me.txtinstcod.Location = New System.Drawing.Point(114, 130)
        Me.txtinstcod.Name = "txtinstcod"
        Me.txtinstcod.Size = New System.Drawing.Size(128, 20)
        Me.txtinstcod.TabIndex = 3
        '
        'txtdescc
        '
        Me.txtdescc.Location = New System.Drawing.Point(112, 216)
        Me.txtdescc.Multiline = True
        Me.txtdescc.Name = "txtdescc"
        Me.txtdescc.Size = New System.Drawing.Size(144, 78)
        Me.txtdescc.TabIndex = 5
        '
        'txttipoc
        '
        Me.txttipoc.Location = New System.Drawing.Point(114, 174)
        Me.txttipoc.Name = "txttipoc"
        Me.txttipoc.Size = New System.Drawing.Size(144, 20)
        Me.txttipoc.TabIndex = 4
        '
        'txtcerrarelec
        '
        Me.txtcerrarelec.Location = New System.Drawing.Point(112, 49)
        Me.txtcerrarelec.Name = "txtcerrarelec"
        Me.txtcerrarelec.Size = New System.Drawing.Size(144, 20)
        Me.txtcerrarelec.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Institución(Código):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 219)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Descripción:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Tipo (Elección):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(63, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Código:"
        '
        'Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Proyecto_Final_2015.My.Resources.Resources.wt4NRqA
        Me.ClientSize = New System.Drawing.Size(405, 394)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Mantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Mantenimiento"
        Me.tbpCandidatosM.ResumeLayout(False)
        Me.tbpCandidatosM.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tboEleccionesM.ResumeLayout(False)
        Me.tboEleccionesM.PerformLayout()
        Me.tbpInstitucionesM.ResumeLayout(False)
        Me.tbpInstitucionesM.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbpCandidatosM As System.Windows.Forms.TabPage
    Friend WithEvents cargar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscarCM As System.Windows.Forms.Button
    Friend WithEvents btnInsertarCM As System.Windows.Forms.Button
    Friend WithEvents txtNombreCM As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaCM As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCM As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tboEleccionesM As System.Windows.Forms.TabPage
    Friend WithEvents txtCodigoIE As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionEM As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoEM As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoEM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCrearEM As System.Windows.Forms.Button
    Friend WithEvents dttFechaEM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbpInstitucionesM As System.Windows.Forms.TabPage
    Friend WithEvents btnBuscarIM As System.Windows.Forms.Button
    Friend WithEvents btnInsertarIM As System.Windows.Forms.Button
    Friend WithEvents txtTelefonoIM As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionIM As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionIM As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreIM As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoIM As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtinstcod As System.Windows.Forms.TextBox
    Friend WithEvents txtdescc As System.Windows.Forms.TextBox
    Friend WithEvents txttipoc As System.Windows.Forms.TextBox
    Friend WithEvents txtcerrarelec As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtbuscarcerrar As System.Windows.Forms.Button
    Friend WithEvents Txtnomnbinstc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblfechacerrareleccion As System.Windows.Forms.Label
    Friend WithEvents La As System.Windows.Forms.Label
    Friend WithEvents btnbscrinst As System.Windows.Forms.Button
    Friend WithEvents lblinstnombremant As System.Windows.Forms.Label
End Class
