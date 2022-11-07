Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlDataReader

Public Class LoginVotacion

    Dim data, dt1, dttipoelec As MySqlDataReader

    Private Sub btnEntrarELV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrarELV.Click
        valida = 1

        If txtCodigoELV.Text = "" Then
            MsgBox("datos incorrectos")
            txtCodigoELV.Clear()

        Else
            Dim eleccioncerrada As New Integer
            'comando para ver eleccioncerrada de codigoe
            Dim Comando As New MySqlCommand("select eleccioncerrada from elecciones where codigoe=( '" & txtCodigoELV.Text & "')", cn)
            cn.Open()

            dt1 = Comando.ExecuteReader

            While dt1.Read
                eleccioncerrada = CStr(dt1("eleccioncerrada"))

            End While
            dt1.Close()

            If eleccioncerrada = 1 Then
                MsgBox("eleccion cerrada ")
                txtCodigoELV.Clear()

            Else
                Dim existeeleccion As String = "select codigoe from elecciones where Codigoe = " & txtCodigoELV.Text
                Dim Adapter As New MySqlDataAdapter(existeeleccion, cn)
                Dim eleccion As New DataTable
                ' Dim data As MySqlDataReader
                Adapter.Fill(eleccion)

                If eleccion.Rows.Count > 0 Then
                    loginvot = txtCodigoELV.Text
                    Votacion.Show()
                    Me.Close()
                    Dim oComando As New MySqlCommand("select candidato.*,eleccan.CodigoE from candidato,eleccan,elecciones where eleccan.CodigoE=elecciones.CodigoE and eleccan.CodigoE=( '" & loginvot & "') and candidato.CodigoC = eleccan.CodigoC", cn)

                    data = oComando.ExecuteReader()
                    Votacion.ltbxcandidato.Items.Clear()

                    'carga todos los candidatos en ltbx
                    While data.Read
                        Votacion.ltbxcandidato.Items.Add(data("Nombre") & " " & data("CodigoC") & "")
                    End While
                    data.Close()
                    'cargar tipo eleccion en label 
                    Dim tipoelec As New MySqlCommand("select tipo from elecciones where codigoe=('" & loginvot & "')", cn)
                    dttipoelec = tipoelec.ExecuteReader
                    While dttipoelec.Read
                        Votacion.lbltipoelec.Text = (dttipoelec(0) & "")

                    End While
                Else
                    MsgBox("eleccion no existe")
                    txtCodigoELV.Clear()

                End If

            End If
            cn.Close()
        End If

    End Sub

    Private Sub txtCodigoELV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoELV.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        End If

    End Sub

    Private Sub txtCodigoELV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoELV.TextChanged
        txtCodigoELV.MaxLength = 9
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Close()
        bscar.Show()
        'valor a variables para reconocer origen
        tipodebuscar = 5
        cargartxtdesdedtw = 5

        bscar.lbltipobuscar.Text = "Elecciones"
        bscar.buscartxt.Text = "Código:"
        'para que muestre todo en dataw
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()

    End Sub

    Private Sub LoginVotacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        Else
            If e.KeyValue = Keys.Enter Then
                btnEntrarELV.PerformClick()

            End If

        End If
    End Sub

    Private Sub LoginVotacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub

End Class