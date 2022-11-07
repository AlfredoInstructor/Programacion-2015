Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlDataReader
Public Class Form2

    Private Sub txtcontrolarvot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontrolarvot.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtcontrolarvot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontrolarvot.TextChanged
        txtcontrolarvot.MaxLength = 9

    End Sub
    Dim data, dt1, dttipoelec As MySqlDataReader
    Private Sub btncontrolar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontrolar.Click
        Try
            valida = 2

            If loginvot = txtcontrolarvot.Text Then
                Dim oComando As New MySqlCommand("select candidato.*,eleccan.CodigoE from candidato,eleccan,elecciones where eleccan.CodigoE=elecciones.CodigoE and eleccan.CodigoE=( '" & loginvot & "') and candidato.CodigoC = eleccan.CodigoC", cn)
                cn.Open()
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
                Votacion.Show()
                Me.Close()
                data.Close()
                dttipoelec.Close()

            Else
                MsgBox("codigo eleccion incorrecto")
            End If
        Catch ex As Exception
            MsgBox("Ingrese código elección")
        End Try
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        Else

            If e.KeyValue = Keys.Enter Then
                btncontrolar.PerformClick()

            End If

        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.txtcontrolarvot.Select()
        Me.ActiveControl = txtcontrolarvot

    End Sub
End Class