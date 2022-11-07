Imports MySql.Data.MySqlClient
Imports System.IO

Module datos
    Dim data, imagen1 As MySqlDataReader

    Dim aBytImagen() As Byte
    Dim oFileStream As FileStream
    Dim oMemoryStream As MemoryStream
    Dim bmpImagen As Bitmap

    Sub dat()
        If valida = 1 Then

            Votacion.ptbFotoV.Image = Nothing
            Votacion.lblNombreCV.Text = ""
            Votacion.lbldatos1.Text = ""

            'preg si existe cand para mostrar dat
            Dim candidato As String = "select * from candidato,eleccan where eleccan.codigoe=('" & loginvot & "') and candidato.codigoc=('" & Votacion.txtNumCandV.Text & "') and candidato.codigoc = eleccan.codigoc "
            Dim adapter As New MySqlDataAdapter(candidato, cn)
            Dim cand As New DataTable
            adapter.Fill(cand)

            If cand.Rows.Count > 0 Then

                Dim Consulta As New MySqlCommand("select candidato.nombre,candidato.codigoc from candidato,eleccan where eleccan.codigoe=('" & loginvot & "') and candidato.codigoc=('" & Votacion.txtNumCandV.Text & "') and candidato.codigoc = eleccan.codigoc ", cn)

                cn.Open()

                data = Consulta.ExecuteReader

                While data.Read
                    'Votacion.lblNombreCV.Text = (data("Nombre") & " " & data("codigoc") & " ")
                    Votacion.lblNombreCV.Text = (data(0) & "")
                    Votacion.lbldatos1.Text = (data(1) & "")

                End While
                cn.Close()
                data.Close()

                Dim imagen As New MySqlCommand("select candidato.imagen from candidato,eleccan where candidato.codigoc= ('" & Votacion.txtNumCandV.Text & "') and eleccan.codigoe=('" & loginvot & "') and candidato.codigoc = eleccan.codigoc ", cn)
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
                Try
                    oMemoryStream = New MemoryStream(aBytImagen)
                    bmpImagen = New Bitmap(oMemoryStream)
                    Votacion.ptbFotoV.Image = bmpImagen
                Catch ex As Exception

                    Votacion.ptbFotoV.Image = Nothing
                End Try

            Else

                Votacion.ptbFotoV.Image = Nothing
                Votacion.lblNombreCV.Text = ""
                Votacion.lbldatos1.Text = ""

            End If
        End If
        If valida = 2 Then
            Votacion.ptbFotoV.Image = Nothing
            Votacion.lblNombreCV.Text = ""
            Votacion.lbldatos1.Text = ""

            'preg si existe cand para mostrar dat
            Dim candidato As String = "select * from candidato,eleccan where eleccan.codigoe=('" & loginvot & "') and candidato.codigoc=('" & Votacion.txtNumCandV.Text & "') and candidato.codigoc = eleccan.codigoc "
            Dim adapter As New MySqlDataAdapter(candidato, cn)
            Dim cand As New DataTable
            adapter.Fill(cand)

            If cand.Rows.Count > 0 Then
                cn.Close()
                Dim Consulta As New MySqlCommand("select candidato.nombre,candidato.codigoc from candidato,eleccan where eleccan.codigoe=('" & loginvot & "') and candidato.codigoc=('" & Votacion.txtNumCandV.Text & "') and candidato.codigoc = eleccan.codigoc ", cn)
                cn.Open()



                data = Consulta.ExecuteReader

                While data.Read
                    'Votacion.lblNombreCV.Text = (data("Nombre") & " " & data("codigoc") & " ")
                    Votacion.lblNombreCV.Text = (data(0) & "")
                    Votacion.lbldatos1.Text = (data(1) & "")

                End While
                cn.Close()
                data.Close()

                Dim imagen As New MySqlCommand("select candidato.imagen from candidato,eleccan where candidato.codigoc= ('" & Votacion.txtNumCandV.Text & "') and eleccan.codigoe=('" & loginvot & "') and candidato.codigoc = eleccan.codigoc ", cn)
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
                Try
                    oMemoryStream = New MemoryStream(aBytImagen)
                    bmpImagen = New Bitmap(oMemoryStream)
                    Votacion.ptbFotoV.Image = bmpImagen
                Catch ex As Exception

                    Votacion.ptbFotoV.Image = Nothing
                End Try

            Else

                Votacion.ptbFotoV.Image = Nothing
                Votacion.lblNombreCV.Text = ""
                Votacion.lbldatos1.Text = ""

            End If
        End If

    End Sub
  
End Module
