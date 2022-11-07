Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Mantenimiento

    Private Sub Mantenimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dttFechaEM.Value = Now
        Me.KeyPreview = True

        Me.txtCodigoIM.Select()
        Me.ActiveControl = txtCodigoIM

    End Sub
    Dim adapter As MySqlDataReader
    Private Sub btnInsertarIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarIM.Click
        If btnInsertarIM.Enabled = ((txtCodigoIM.TextLength > 0) And (txtNombreIM.TextLength > 0) And (txtDireccionIM.TextLength > 0) And (txtTelefonoIM.TextLength > 0)) Then
            'comprueba si existe institucion
            Dim Consultainst As String = "select codigoi from instituciones where Codigoi = " & txtCodigoIM.Text
            Dim Adapterinst As New MySqlDataAdapter(Consultainst, cn)
            Dim Tblinst As New DataTable

            Adapterinst.Fill(Tblinst)

            If Tblinst.Rows.Count > 0 Then
                MsgBox("institucion ya existe ")
                txtCodigoIM.Clear()
            Else
                'insertar institucion
                Dim insertar As New MySqlCommand(" INSERT INTO instituciones VALUES ('" & txtCodigoIM.Text & "', '" & txtNombreIM.Text & "', '" & txtDescripcionIM.Text & "' , '" & txtDireccionIM.Text & "', '" & txtTelefonoIM.Text & "')", cn)
                cn.Open()
                insertar.ExecuteNonQuery()
                cn.Close()
                MsgBox("datos ingresados")

                txtCodigoIM.Clear()
                txtNombreIM.Clear()
                txtDescripcionIM.Clear()
                txtDireccionIM.Clear()
                txtTelefonoIM.Clear()

            End If
        Else
            MsgBox("debe rellenar todos los datos")
        End If

    End Sub

    Private Sub cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cargar.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\AppData\Roaming\Microsoft\Windows\Libraries\Pictures.library-ms"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub btnInsertarCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertarCM.Click
        If btnInsertarCM.Enabled = ((txtCodigoCM.TextLength > 0) And (txtCedulaCM.TextLength > 0) And (txtNombreCM.TextLength > 0)) Then
            'candidato existe?
            Dim Consultacand As String = "select codigoc from candidato where Codigoc = " & txtCodigoCM.Text
            Dim Adapter As New MySqlDataAdapter(Consultacand, cn)
            Dim Tblcand As New DataTable
            Adapter.Fill(Tblcand)
            If Tblcand.Rows.Count > 0 Then
                MsgBox("candidato ya exite")
                txtCodigoCM.Clear()
            Else

                Try
                    'insertar imagen
                    Dim mstram As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(mstram, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrimage() As Byte = mstram.GetBuffer()
                    mstram.Close()
                    Try

                        'insertar datos candidato codigoc,cedula,nombre
                        Dim insertar As New MySqlCommand(" INSERT INTO candidato(codigoc,cedula,nombre,imagen) VALUES ('" & txtCodigoCM.Text & "', '" & txtCedulaCM.Text & "', '" & txtNombreCM.Text & "',@imagen)", cn)
                        cn.Open()
                        'guardar imagen

                        insertar.Parameters.AddWithValue("@imagen", arrimage)
                        insertar.ExecuteNonQuery()
                        cn.Close()
                        MsgBox("datos ingresados")
                        txtCodigoCM.Clear()
                        txtCedulaCM.Clear()
                        txtNombreCM.Clear()
                        PictureBox1.Image = Nothing
                    Catch ex As Exception
                        MsgBox("no ingresado  ")
                        txtCodigoCM.Clear()
                        txtCedulaCM.Clear()
                        txtNombreCM.Clear()
                        PictureBox1.Image = Nothing

                    End Try
                Catch ex As Exception
                    MsgBox("debe rellenar todos los campos ")
                End Try

            End If
        Else
            MsgBox("debe rellenar todos los campos ")

        End If
    End Sub

    Private Sub btnCrearEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearEM.Click

        If btnCrearEM.Enabled = ((txtCodigoEM.TextLength > 0) And (txtCodigoIE.TextLength > 0) And (txtTipoEM.TextLength > 0) And (txtDescripcionEM.TextLength > 0)) Then

            Dim Consult As String = "select * from candidato  "

            Dim Adapte As New MySqlDataAdapter(Consult, cn)
            Dim Tbl1 As New DataTable
            cn.Close()


            Adapte.Fill(Tbl1)

            If Tbl1.Rows.Count > 1 Then
                'eleccion existe?
                Dim Consulta As String = "select codigoe from elecciones where Codigoe = " & txtCodigoEM.Text
                Dim Adapter As New MySqlDataAdapter(Consulta, cn)
                Dim Tbl As New DataTable
                ' Dim data As MySqlDataReader
                Adapter.Fill(Tbl)

                If Tbl.Rows.Count > 0 Then

                    MsgBox("elección ya exite")
                    txtCodigoEM.Clear()
                    txtCodigoIE.Clear()
                Else
                    'si no exite eleccion comprueba si existe institucion
                    Dim Consultainstitucion As String = "select codigoi from instituciones where Codigoi = " & txtCodigoIE.Text
                    Dim Adapterinst As New MySqlDataAdapter(Consultainstitucion, cn)
                    Dim Tblinst As New DataTable

                    Adapterinst.Fill(Tblinst)
                    If Tblinst.Rows.Count > 0 Then
                        ' insertar crear  datos eleccion

                        agregarcandidato.Show()
                        codigoem = txtCodigoEM.Text

                    Else
                        MsgBox("institución no existe")
                        txtCodigoIE.Clear()

                    End If
                End If
            Else
                MsgBox("debe exister almenos 2 candidato regitrados")

            End If
            cn.Close()
        Else
            MsgBox("debe rellenar todos los compos de datos ")

        End If
            

    End Sub

    Private Sub btnEliminarCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'eliminar un candidato 
            Dim eliminarcandidato As New MySqlCommand("delete from candidato where codigoC = ('" & txtCodigoCM.Text & "')", cn)
            cn.Open()
            eliminarcandidato.ExecuteNonQuery()
            cn.Close()
            MsgBox("candidato eliminado su codigo =" & txtCodigoCM.Text)
            Dim eliminareleccan As New MySqlCommand("delete from eleccan where codigoC = ('" & txtCodigoCM.Text & "')", cn)
            cn.Open()
            eliminarcandidato.ExecuteNonQuery()
            cn.Close()

        Catch ex As Exception
            MsgBox("candidato no extiste, ingrese nuevo codigo")
        End Try

        cn.Close()
    End Sub

    Private Sub txtCodigoIM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoIM.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtTelefonoIM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoIM.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtCodigoEM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoEM.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        End If
    End Sub

    Private Sub txtCodigoIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoIE.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        End If
    End Sub

    Private Sub txtCodigoCM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoCM.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        End If
    End Sub

    Private Sub txtCedulaCM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaCM.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        End If
    End Sub

    Dim dt1 As MySqlDataReader
    Private Sub btnBuscarIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarIM.Click

        bscar.Show()
        tipodebuscar = 1
        cargartxtdesdedtw = 0
        bscar.lbltipobuscar.Text = "Institución"
        bscar.buscartxt.Text = "Nombre:"
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        cn.Close()
        bscar.Show()
        'valor a variables para reconocer origen
        tipodebuscar = 3
        cargartxtdesdedtw = 0

        bscar.lbltipobuscar.Text = "Elecciones"
        bscar.buscartxt.Text = "Código:"
        'para que muestre todo en dataw
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtCodigoEM.Clear()
        txtCodigoIE.Clear()
        txtTipoEM.Clear()
        txtDescripcionEM.Clear()

    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        txtCodigoIM.Clear()
        txtNombreIM.Clear()
        txtDescripcionIM.Clear()
        txtDireccionIM.Clear()
        txtTelefonoIM.Clear()

    End Sub
    Dim imagen2 As MySqlDataReader

    Dim aBytImagen() As Byte
    Dim oFileStream As FileStream
    Dim oMemoryStream As MemoryStream
    Dim bmpImagen As Bitmap
    Private Sub btnBuscarCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCM.Click

        bscar.Show()
        tipodebuscar = 2
        cargartxtdesdedtw = 0
        bscar.lbltipobuscar.Text = "Candidatos"
        bscar.buscartxt.Text = "Nombre:"
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()
    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        txtCodigoCM.Clear()
        txtCedulaCM.Clear()
        txtNombreCM.Clear()
        PictureBox1.Image = Nothing

    End Sub

    Private Sub txtNombreIM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreIM.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
        txtNombreIM.MaxLength = 30

    End Sub

    Private Sub txtDescripcionIM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionIM.TextChanged
        txtDescripcionIM.MaxLength = 100

    End Sub

    Private Sub txtDireccionIM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccionIM.TextChanged
        txtDireccionIM.MaxLength = 50

    End Sub

    Private Sub txtNombreCM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCM.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        txtNombreCM.MaxLength = 50

    End Sub


    Private Sub txtTipoEM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoEM.TextChanged
        txtTipoEM.MaxLength = 30

    End Sub

    Private Sub txtDescripcionEM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcionEM.TextChanged
        txtDescripcionEM.MaxLength = 90

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim existeeleccion As String = "select codigoe from elecciones where Codigoe = " & txtcerrarelec.Text
            Dim Adapter As New MySqlDataAdapter(existeeleccion, cn)
            Dim eleccion As New DataTable
            ' Dim data As MySqlDataReader
            Adapter.Fill(eleccion)

            If eleccion.Rows.Count > 0 Then
                Dim cerrareleccion As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `eleccioncerrada`=1 WHERE `CodigoE`=('" & txtcerrarelec.Text & "')", cn)
                cn.Open()
                cerrareleccion.ExecuteNonQuery()
                cn.Close()

                MsgBox("eleccion cerrada ")
                txtcerrarelec.Clear()
                Txtnomnbinstc.Clear()
                txtinstcod.Clear()
                txttipoc.Clear()
                txtdescc.Clear()
                lblfechacerrareleccion.Text = ""

            Else
                MsgBox("esta eleccion no existe")
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtbuscarcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarcerrar.Click
        tipodebuscar = 3
        cargartxtdesdedtw = 1
        bscar.lbltipobuscar.Text = "Elecciones"
        bscar.buscartxt.Text = "Código:"
        bscar.Show()
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()

    End Sub

    Private Sub txtCodigoIM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoIM.TextChanged
        txtCodigoIM.MaxLength = 9
    End Sub

    Private Sub txtNombreIM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreIM.TextChanged
        txtNombreIM.MaxLength = 30
    End Sub

    Private Sub txtTelefonoIM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefonoIM.TextChanged
        txtTelefonoIM.MaxLength = 9
    End Sub

    Private Sub txtCodigoCM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCM.TextChanged
        txtCodigoCM.MaxLength = 9
    End Sub

    Private Sub txtCedulaCM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCedulaCM.TextChanged
        txtCedulaCM.MaxLength = 8

    End Sub

    Private Sub txtNombreCM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreCM.TextChanged
        txtNombreCM.MaxLength = 30
    End Sub

    Private Sub txtCodigoEM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoEM.TextChanged
        txtCodigoEM.MaxLength = 9
    End Sub

    Private Sub txtCodigoIE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoIE.TextChanged
        txtCodigoIE.MaxLength = 9
    End Sub

    Private Sub txtcerrarelec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcerrarelec.TextChanged
        txtcerrarelec.MaxLength = 9
    End Sub

    Private Sub Txtnomnbinstc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtnomnbinstc.TextChanged
        Txtnomnbinstc.MaxLength = 30
    End Sub

    Private Sub txtinstcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinstcod.TextChanged
        txtinstcod.MaxLength = 9
    End Sub

    Private Sub txttipoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttipoc.TextChanged
        txttipoc.MaxLength = 30
    End Sub

    Private Sub txtdescc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescc.TextChanged
        txtdescc.MaxLength = 90
    End Sub

    Private Sub btnbscrinst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbscrinst.Click

        bscar.Show()
        tipodebuscar = 1
        cargartxtdesdedtw = 4
        bscar.lbltipobuscar.Text = "Institución"
        bscar.buscartxt.Text = "Nombre:"
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()
    End Sub

End Class