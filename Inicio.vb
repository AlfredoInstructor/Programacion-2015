Imports MySql.Data.MySqlClient

Public Class Inicio
    Dim data As MySqlDataReader
    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        '    Try
        '        conex()

        '        Dim existeadm As String = "select usuario from permisos where usuario = ('" & txtusuario.Text & "') and contraseña = ('" & txtcontraseña.Text & "')"
        '        Dim adapter As New MySqlDataAdapter(existeadm, cn)
        '        Dim usuario As New DataTable
        '        adapter.Fill(usuario)
        '        If usuario.Rows.Count > 0 Then


        '            Dim tipopermisos As New MySqlCommand("select tipo from permisos where usuario = ('" & txtusuario.Text & "') and contraseña = ('" & txtcontraseña.Text & "')", cn)

        '            cn.Open()
        '            data = tipopermisos.ExecuteReader
        '            Dim permiso As New Integer
        '            While data.Read

        '                permiso = (data(0) & "")
        '            End While
        '            cn.Close()


        '            If permiso = 0 Then


        '                Principal.Show()
        '                Me.Close()

        '            End If
        '            If permiso = 1 Then


        '                Consultas.Show()
        '                Me.Close()


        '            End If

        '        Else

        '        End If
        '    Catch ex As Exception

        '    End Try


        'End Sub

        'Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged
        '    txtusuario.MaxLength = 20
        'End Sub

        'Private Sub txtcontraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.TextChanged
        '    txtcontraseña.MaxLength = 20
        'End Sub

        'Private Sub Inicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        '    If e.KeyValue = Keys.Enter Then
        '        btningresar.PerformClick()

        '    End If

        'End Sub

        'Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Me.KeyPreview = True

        '    Me.txtusuario.Select()
        '    Me.ActiveControl = txtusuario

        'End Sub

        'End Class
        Try
            If txtusuario.Text = "usuario" And txtcontraseña.Text = "usuario" Then
                conex()
                Consultas.Show()
                Me.Close()


            Else


                'usuario adminitrador 
                If txtusuario.Text = "admin" And txtcontraseña.Text = "admin" Then
                    conex()
                    Principal.Show()
                    Me.Close()
                Else
                    MsgBox(" Datos erróneo, ingrese nuevamente  ")
                    txtusuario.Clear()
                    txtcontraseña.Clear()
                    Me.txtusuario.Select()
                    Me.ActiveControl = txtusuario
                End If
            End If


        Catch ex As Exception

        End Try




    End Sub



    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged
        txtusuario.MaxLength = 20
    End Sub

    Private Sub txtcontraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.TextChanged
        txtcontraseña.MaxLength = 20
    End Sub

    Private Sub Inicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Enter Then
            btningresar.PerformClick()

        End If

    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        Me.txtusuario.Select()
        Me.ActiveControl = txtusuario


    End Sub




End Class