Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlDataAdapter
Imports System.IO

Public Class Votacion
    Dim sSql As String
    Dim adapter As MySqlDataReader

    Dim codigoc As Integer

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarV.Click
        If valida = 1 Then
            If txtNumCandV.Text = "" Then
                MsgBox("datos incorrectos")
                txtNumCandV.Clear()

            Else
                If txtNumCandV.Text = "blanco" Then
                    Dim blanco As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `voto_blanco`=voto_blanco+1 WHERE `CodigoE`='" & loginvot & "'", cn)
                    cn.Open()
                    adapter = blanco.ExecuteReader()
                    adapter.Close()
                    txtNumCandV.Clear()
                    Dim inicio As DateTime = DateTime.Now

                    'System.Media.SystemSounds.Exclamation.Play()

                    'MsgBox("votacion registradaa", MsgBoxStyle.Information)

                    txtNumCandV.Clear()

                    cn.Close()
                    Dim total_votantes As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `total_votos`=total_votos+1 WHERE `CodigoE`='" & loginvot & "'", cn)
                    cn.Open()
                    adapter = total_votantes.ExecuteReader()
                    adapter.Close()

                    cn.Close()
                    lblNombreCV.Text = ""

                    lbldatos1.Text = ""
                    Form2.Show()
                    Me.Close()


                Else

                    Dim existeconsulta As New DataTable
                    Dim consulta As String = "SELECT codigoc FROM eleccan WHERE codigoc = " & txtNumCandV.Text
                    Dim adapte As New MySqlDataAdapter(consulta, cn)

                    adapte.Fill(existeconsulta)

                    If existeconsulta.Rows.Count > 0 Then
                        codigoc = txtNumCandV.Text

                        Dim Comando As New MySqlCommand("UPDATE `bdproyecto`.`eleccan` SET `Voto`=Voto+1 WHERE `CodigoE`='" & loginvot & "' and`CodigoC`='" & codigoc & "'", cn)
                        cn.Open()
                        adapter = Comando.ExecuteReader()
                        adapter.Close()

                        MsgBox("votación registrada")

                        ptbFotoV.Image = Nothing
                        cn.Close()
                        Dim total_votantes As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `total_votos`=total_votos+1 WHERE `CodigoE`='" & loginvot & "'", cn)
                        cn.Open()
                        adapter = total_votantes.ExecuteReader()
                        adapter.Close()

                        cn.Close()
                        lblNombreCV.Text = ""

                        lbldatos1.Text = ""
                        Form2.Show()
                        Me.Close()

                    Else
                        MsgBox("votación incorrecta")
                        ptbFotoV.Image = Nothing

                    End If
                End If
            End If

            txtNumCandV.Clear()
        End If
        If valida = 2 Then
            If txtNumCandV.Text = "" Then
                MsgBox("datos incorrectos")
                txtNumCandV.Clear()

            Else
                If txtNumCandV.Text = "blanco" Then
                    Dim blanco As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `voto_blanco`=voto_blanco+1 WHERE `CodigoE`='" & loginvot & "'", cn)

                    adapter = blanco.ExecuteReader()
                    adapter.Close()
                    txtNumCandV.Clear()
                    Dim inicio As DateTime = DateTime.Now

                    MsgBox("votación registradaa")

                    txtNumCandV.Clear()

                    cn.Close()
                    Dim total_votantes As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `total_votos`=total_votos+1 WHERE `CodigoE`='" & loginvot & "'", cn)
                    cn.Open()
                    adapter = total_votantes.ExecuteReader()
                    adapter.Close()

                    cn.Close()
                    lblNombreCV.Text = ""

                    lbldatos1.Text = ""
                    Form2.Show()
                    Me.Close()


                Else

                    Dim existeconsulta As New DataTable
                    Dim consulta As String = "SELECT codigoc FROM eleccan WHERE codigoc = " & txtNumCandV.Text
                    Dim adapte As New MySqlDataAdapter(consulta, cn)

                    adapte.Fill(existeconsulta)

                    If existeconsulta.Rows.Count > 0 Then
                        codigoc = txtNumCandV.Text

                        Dim Comando As New MySqlCommand("UPDATE `bdproyecto`.`eleccan` SET `Voto`=Voto+1 WHERE `CodigoE`='" & loginvot & "' and`CodigoC`='" & codigoc & "'", cn)
                        cn.Open()
                        adapter = Comando.ExecuteReader()
                        adapter.Close()

                        MsgBox("votación registrada")

                        ptbFotoV.Image = Nothing
                        cn.Close()
                        Dim total_votantes As New MySqlCommand("UPDATE `bdproyecto`.`elecciones` SET `total_votos`=total_votos+1 WHERE `CodigoE`='" & loginvot & "'", cn)
                        cn.Open()
                        adapter = total_votantes.ExecuteReader()
                        adapter.Close()

                        cn.Close()
                        lblNombreCV.Text = ""

                        lbldatos1.Text = ""
                        Form2.Show()
                        Me.Close()

                    Else
                        MsgBox("votación incorrecta")
                        ptbFotoV.Image = Nothing

                    End If
                End If
            End If

            txtNumCandV.Clear()
        End If
        

    End Sub

    Private Sub btn7V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 7
            dat()

        End If

    End Sub

    Private Sub btn8V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 8
            dat()
        End If

    End Sub

    Private Sub btn9V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 9
            dat()
        End If

    End Sub

    Private Sub btn4V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 4
            dat()
        End If

    End Sub

    Private Sub btn5V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 5
            dat()
        End If

    End Sub

    Private Sub btn6V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 6
            dat()
        End If

    End Sub

    Private Sub btn1V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 1
            dat()

        End If
        
    End Sub

    Private Sub btn2V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 2
            dat()
        End If
    End Sub

    Private Sub btn3V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3V.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 3
            dat()
        End If

    End Sub

    Private Sub btnCeroV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeroV.Click
        If txtNumCandV.Enabled = ((txtNumCandV.Text <> "blanco")) Then
            txtNumCandV.Text = txtNumCandV.Text & 0
            dat()

        End If
    End Sub

    Private Sub btnBlancoV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlancoV.Click
        If btnBlancoV.Enabled = ((txtNumCandV.TextLength < 1)) Then

            txtNumCandV.Text = txtNumCandV.Text & "blanco"
        End If

    End Sub
   
    Private Sub txtNumCandV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCandV.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
           
        End If
        cn.Close()

    End Sub

    Private Sub btnCancelarV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        txtNumCandV.Clear()
        ptbFotoV.Image = Nothing
        lblNombreCV.Text = ""
        lbldatos1.Text = ""

    End Sub

    Private Sub Votacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class