Public Class Principal

    Private Sub Principal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.F1 Then

            Process.Start(Application.StartupPath & "\Manual_usuario_Pruyecto_final_2015.pdf")
        Else
            If e.KeyValue = Keys.Down Then
                Me.btnIngresoVP.Select()
                Me.ActiveControl = btnIngresoVP


            End If
        End If
    End Sub


    Private Sub btnMantenimientoP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMantenimientoP.Click
        Mantenimiento.Show()

    End Sub

    Private Sub btnIngresoVP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresoVP.Click
        LoginVotacion.Show()

    End Sub

    Private Sub btnConsultaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaP.Click
        Consultas.Show()

    End Sub

    
    Private Sub btnmanual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanual.Click

        Process.Start(Application.StartupPath & "\Manual_usuario_Pruyecto_final_2015.pdf")

    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class