Imports MySql.Data.MySqlClient
Public Class bscar

    Private Sub txtbuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbuscar.KeyDown
        Me.KeyPreview = True

        If e.KeyValue = Keys.Down Then
            dtbuscar.Focus()
        Else
            If e.KeyValue = Keys.Enter Then
                Me.Close()

            End If

        End If
    End Sub


    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged

        txtbuscar.MaxLength = 9


        If tipodebuscar = 1 Then
            'buscar(instituciones)
            Dim dataadapter1 As New MySqlDataAdapter("select nombre as Nombre,codigoi as Código,direccion as Dirección,telefono as Teléfono from instituciones where nombre like '" & txtbuscar.Text & "%'", cn)
            Dim dataset As New DataSet
            dataadapter1.Fill(dataset, "institución")
            dtbuscar.DataSource = dataset.Tables("institución")

        End If

        If tipodebuscar = 2 Then

            'buscar(cand)
            Dim dataadapter1 As New MySqlDataAdapter("select nombre as Nombre,codigoc as Código,cedula as Cédula,imagen as Imagen from candidato where nombre like '" & txtbuscar.Text & "%'", cn)
            Dim dataset As New DataSet
            dataadapter1.Fill(dataset, "candidatos")
            dtbuscar.DataSource = dataset.Tables("candidatos")

        End If
        If tipodebuscar = 3 Then

            'buscar(elec)
            Dim dataadapter1 As New MySqlDataAdapter("select instituciones.nombre as Nombre_Institución,elecciones.tipo as Tipo_elección,elecciones.codigoe as Código_Elección ,instituciones.codigoi as Código_Institución,elecciones.fecha as Fecha, elecciones.descripcion as Descripción from elecciones,instelec,instituciones where instelec.codigoe like  '" & txtbuscar.Text & "%' and instelec.codigoe = elecciones.codigoe and instelec.codigoi = instituciones.codigoi ", cn)
            Dim dataset As New DataSet
            dataadapter1.Fill(dataset, "elecciones")
            dtbuscar.DataSource = dataset.Tables("elecciones")
        End If
        If tipodebuscar = 4 Then

            'buscar(elec)
            Dim dataadapter1 As New MySqlDataAdapter("select instituciones.nombre as Nombre_Institución,elecciones.tipo as Tipo_elección,elecciones.codigoe as Código_Elección ,elecciones.fecha as Fecha, elecciones.descripcion as Descripción from elecciones,instelec,instituciones where instelec.codigoe like  '" & txtbuscar.Text & "%' and instelec.codigoe = elecciones.codigoe and instelec.codigoi = instituciones.codigoi ", cn)
            Dim dataset As New DataSet
            dataadapter1.Fill(dataset, "elecciones")
            dtbuscar.DataSource = dataset.Tables("elecciones")
        End If
        If tipodebuscar = 5 Then
            'buscar elecciones abiertas 
            Dim dataadapter1 As New MySqlDataAdapter("select codigoe as Código_Elección, tipo as Tipo,descripcion as Descripción,fecha as Fecha from elecciones where eleccioncerrada = 0  ", cn)
            Dim dataset As New DataSet
            dataadapter1.Fill(dataset, "elecciones")
            dtbuscar.DataSource = dataset.Tables("elecciones")
        End If
        
    End Sub

    Private Sub dtbuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtbuscar.KeyDown
        Me.KeyPreview = True
        If e.KeyValue = Keys.Enter Then
            Me.Close()
        End If

    End Sub

    Private Sub dtbuscar_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtbuscar.RowEnter

        'para cargar txts de cerrar elección al reconocer origen 1
        If cargartxtdesdedtw = 1 Then
            Mantenimiento.txtcerrarelec.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(2).Value()
            Mantenimiento.txtinstcod.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(3).Value()
            Mantenimiento.txttipoc.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(1).Value()
            Mantenimiento.txtdescc.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(5).Value()
            Mantenimiento.Txtnomnbinstc.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(0).Value()
            Mantenimiento.lblfechacerrareleccion.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(4).Value()
            dtbuscar.Columns(0).ReadOnly = True
            dtbuscar.Columns(1).ReadOnly = True
            dtbuscar.Columns(2).ReadOnly = True
            dtbuscar.Columns(3).ReadOnly = True
            dtbuscar.Columns(4).ReadOnly = True
            dtbuscar.Columns(5).ReadOnly = True
        End If
        'carga txt de agregar candidato origen 2
        If cargartxtdesdedtw = 2 Then
            agregarcandidato.txtcandidato.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(1).Value()
            dtbuscar.Columns(0).ReadOnly = True
            dtbuscar.Columns(1).ReadOnly = True
            dtbuscar.Columns(2).ReadOnly = True
            dtbuscar.Columns(3).ReadOnly = True
        End If
        'carga txt consultas elecciones desde origen 3
        If cargartxtdesdedtw = 3 Then
            Consultas.txtCodigoEC.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(2).Value()
            dtbuscar.Columns(0).ReadOnly = True
            dtbuscar.Columns(1).ReadOnly = True
            dtbuscar.Columns(2).ReadOnly = True
            dtbuscar.Columns(3).ReadOnly = True
            
        End If
        'carga txt consultas elecciones desde origen 4
        If cargartxtdesdedtw = 4 Then

            Mantenimiento.txtCodigoIE.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(1).Value()
            Mantenimiento.lblinstnombremant.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(0).Value()
            dtbuscar.Columns(0).ReadOnly = True
            dtbuscar.Columns(1).ReadOnly = True
            dtbuscar.Columns(2).ReadOnly = True
            dtbuscar.Columns(3).ReadOnly = True
            
        End If
        'carga txt consultas inst desde origen 5
        If cargartxtdesdedtw = 5 Then

            LoginVotacion.txtCodigoELV.Text = Me.dtbuscar.Rows(e.RowIndex).Cells(0).Value()

            dtbuscar.Columns(0).ReadOnly = True
            dtbuscar.Columns(1).ReadOnly = True
            dtbuscar.Columns(2).ReadOnly = True
            dtbuscar.Columns(3).ReadOnly = True
           
        End If
        
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()


    End Sub

    Private Sub bscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()


        End If
    End Sub

    Private Sub bscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub

End Class