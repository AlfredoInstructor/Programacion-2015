Imports MySql.Data.MySqlClient
Imports System.IO

Public Class agregarcandidato

    Private Sub agregarcandidato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim data As MySqlDataReader
    Private Sub btnCargarCandidatoEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarCandidatoEM.Click
        Try
            'codigocnadidato
            Dim Consulta As String = "select nombre from candidato where CodigoC = " & txtcandidato.Text

            Dim Adapter As New MySqlDataAdapter(Consulta, cn)
            Dim Tbl As New DataTable

            Adapter.Fill(Tbl)

            If Tbl.Rows.Count > 0 Then

                cn.Close()

                Dim Comando As New MySqlCommand("select  codigoc from candidato where codigoC =( '" & txtcandidato.Text & "')", cn)
                cn.Open()
                data = Comando.ExecuteReader()
                'agrega candidao ltbx

                If (ltbxcand.Items.Contains(txtcandidato.Text)) Then

                Else
                    While data.Read
                        ltbxcand.Items.Add(data(0) & "")

                    End While
                End If
              
                data.Close()
                cn.Close()

                'insertar eleccan
                'consultacandidato EXISTE EN ELECCAN

                Try
                    Dim insertar_eleccan As New MySqlCommand("insert into eleccan(codigoe,codigoc) values ('" & Mantenimiento.txtCodigoEM.Text & "','" & txtcandidato.Text & "')", cn)
                    cn.Open()

                    insertar_eleccan.ExecuteNonQuery()
                    cn.Close()
                Catch ex As Exception

                End Try

            Else
                MsgBox("codigo candidato no existente ")
                txtcandidato.Clear()

            End If
        Catch ex As Exception
            MsgBox("cargar candidato")
        End Try

    End Sub

    Private Sub btnlisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlisto.Click

        'consulta si exite dos candidatos

        Dim Consulta As String = "select codigoe from eleccan where Codigoe = " & Mantenimiento.txtCodigoEM.Text

        Dim Adapter As New MySqlDataAdapter(Consulta, cn)
        Dim Tbl As New DataTable
        cn.Close()


        Adapter.Fill(Tbl)

        If Tbl.Rows.Count > 1 Then
            Mantenimiento.dttFechaEM.Format = DateTimePickerFormat.Custom
            ' formato fecha.
            Mantenimiento.dttFechaEM.CustomFormat = "yyyy/MM/dd"
            Dim insertar As New MySqlCommand(" INSERT INTO elecciones (codigoe,tipo,descripcion,fecha) VALUES ('" & Mantenimiento.txtCodigoEM.Text & "', '" & Mantenimiento.txtTipoEM.Text & "', '" & Mantenimiento.txtDescripcionEM.Text & "', '" & Mantenimiento.dttFechaEM.Text & "')", cn)
            cn.Open()

            insertar.ExecuteNonQuery()
            cn.Close()
            MsgBox("datos ingresados ")

            'insertar codigoecodigoi instelec

            Dim insertarinstelec As New MySqlCommand("insert into instelec (codigoe,codigoi) values('" & codigoem & "','" & Mantenimiento.txtCodigoIE.Text & "')", cn)
            cn.Open()
            insertarinstelec.ExecuteNonQuery()
            cn.Close()
            Close()
            Mantenimiento.txtCodigoEM.Clear()
            Mantenimiento.txtCodigoIE.Clear()
            Mantenimiento.txtDescripcionEM.Clear()
            Mantenimiento.txtTipoEM.Clear()
            Mantenimiento.lblinstnombremant.Text = ""

        Else
            MsgBox("debe ingresar almenos dos candidato")
        End If

    End Sub
    Dim imagen1 As MySqlDataReader

    Dim aBytImagen() As Byte
    Dim oFileStream As FileStream
    Dim oMemoryStream As MemoryStream
    Dim bmpImagen As Bitmap

    Private Sub btnvercandidato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvercandidato.Click
        Try
            cn.Close()

            Dim Consulta As New MySqlCommand("select nombre,codigoc from candidato where Codigoc = " & txtcandidato.Text, cn)

            cn.Open()

            data = Consulta.ExecuteReader

            While data.Read
                lblcandidatodato.Text = (data("Nombre") & " " & data("codigoc") & " ")
            End While
            cn.Close()
            data.Close()


            Try
                Dim imagen As New MySqlCommand("select imagen from candidato where codigoc= ('" & txtcandidato.Text & "')", cn)
                cn.Open()
                imagen1 = imagen.ExecuteReader(CommandBehavior.SingleRow)
                If imagen1.Read() Then
                    ' recuperar datos binarios de la foto
                    aBytImagen = imagen1("imagen")
                End If

                imagen1.Close()
                cn.Close()
                'crear un objeto stream en memoria conteniendo los datos de la imagen,
                ' crear un bitmap con el stream y
                ' visualizar la imagen en un control PictureBox

                oMemoryStream = New MemoryStream(aBytImagen)
                bmpImagen = New Bitmap(oMemoryStream)
                pctbximagcand.Image = bmpImagen

            Catch ex As Exception
                pctbximagcand.Image = Nothing
            End Try

        Catch ex As Exception

            pctbximagcand.Image = Nothing
            lblcandidatodato.Text = ""



        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bscar.Show()
        'valor a variables para reconocer origen
        tipodebuscar = 2
        cargartxtdesdedtw = 2

        bscar.lbltipobuscar.Text = "Elecciones"
        bscar.buscartxt.Text = "Codigo:"
        'para que muestre todo en dataw
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()
    End Sub

    Private Sub lblcandidatodato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcandidatodato.Click

    End Sub

    Private Sub txtcandidato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcandidato.TextChanged
        txtcandidato.MaxLength = 9
    End Sub

    
End Class