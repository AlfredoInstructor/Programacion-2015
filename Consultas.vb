Imports MySql.Data.MySqlClient
Public Class Consultas
    Dim data As MySqlDataReader
    Private Sub btnBuscarEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarEC.Click
        Try
            'mas votados 
            Dim dataadapter As New MySqlDataAdapter("select candidato.nombre,eleccan.voto from candidato,eleccan,elecciones where eleccan.CodigoE=elecciones.CodigoE and eleccan.CodigoE=( '" & txtCodigoEC.Text & "') and candidato.CodigoC = eleccan.CodigoC order by voto desc", cn)
            Dim dataset As New DataSet
            dataadapter.Fill(dataset, "candidatos")
            dtviewmasvotados.DataSource = dataset.Tables("candidatos")

            'menos votados 
            Dim candidatosmenosvotados As New MySqlDataAdapter("select candidato.nombre,eleccan.voto from candidato,eleccan,elecciones where eleccan.CodigoE=elecciones.CodigoE and eleccan.CodigoE=( '" & txtCodigoEC.Text & "') and candidato.CodigoC = eleccan.CodigoC order by voto asc", cn)
            Dim menosvotados As New DataSet
            candidatosmenosvotados.Fill(menosvotados, "candidatos")
            dtviewmenosvotados.DataSource = menosvotados.Tables("candidatos")
            'votos en blanco
            Dim votosblanco As New MySqlDataAdapter("select voto_blanco from elecciones where CodigoE=( '" & txtCodigoEC.Text & "')", cn)
            Dim blanco As New DataSet
            votosblanco.Fill(blanco, "vtoblanco")
            Dtvotosblanco.DataSource = blanco.Tables("vtoblanco")

            'total de votos
            Dim totalvot As New MySqlDataAdapter("select total_votos from elecciones where CodigoE=( '" & txtCodigoEC.Text & "') ", cn)
            Dim total As New DataSet
            totalvot.Fill(total, "total_votos")
            Dtviewtotalvotantes.DataSource = total.Tables("total_votos")

            txtCodigoEC.Clear()
        Catch ex As Exception

        End Try
       

    End Sub
    Private Sub txtCodigoEC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoEC.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Close()
        bscar.Show()
        'valor a variables para reconocer origen
        tipodebuscar = 4
        cargartxtdesdedtw = 3

        bscar.lbltipobuscar.Text = "Elecciones"
        bscar.buscartxt.Text = "Codigo:"
        'para que muestre todo en dataw
        bscar.txtbuscar.Text = "a"
        bscar.txtbuscar.Clear()
    End Sub

    Private Sub txtCodigoEC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoEC.TextChanged
        txtCodigoEC.MaxLength = 9
    End Sub

    

    Private Sub Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        Me.txtCodigoEC.Select()
        Me.ActiveControl = txtCodigoEC
    End Sub

   
    Private Sub dtviewmasvotados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtviewmasvotados.CellContentClick

    End Sub

    Private Sub dtviewmasvotados_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtviewmasvotados.RowEnter
        dtviewmasvotados.Columns(0).ReadOnly = True
        dtviewmasvotados.Columns(1).ReadOnly = True
       

    End Sub

    Private Sub dtviewmenosvotados_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtviewmenosvotados.RowEnter
        dtviewmenosvotados.Columns(0).ReadOnly = True
        dtviewmenosvotados.Columns(1).ReadOnly = True
    End Sub

    Private Sub Dtviewtotalvotantes_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtviewtotalvotantes.RowEnter
        Dtviewtotalvotantes.Columns(0).ReadOnly = True
    End Sub

    Private Sub Dtvotosblanco_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtvotosblanco.RowEnter
        Dtvotosblanco.Columns(0).ReadOnly = True
    End Sub
End Class