Imports MySql.Data.MySqlClient
Module conexion

    Public cn As New MySqlConnection("server=127.0.0.2;port=3306;User id=" + Inicio.txtusuario.Text + ";Password=" + Inicio.txtcontraseña.Text + ";Database=bdproyecto;")
    Sub conex()
        Try
            cn.Open()
            MsgBox("si")
            cn.Close()

        Catch ex As Exception
            MsgBox("Verifique datos de conexión")
            Inicio.Close()

        End Try
    End Sub
End Module

