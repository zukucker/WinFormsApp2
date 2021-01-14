Imports MySql
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class DbConnector
    Public Function connect(name, imageByteArray)
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim query As String = "insert into pictures (image, name) values (@image, @name)"
        con.ConnectionString = "Server=192.168.0.132;user id=root;password=root;Database=opa"
        Try
            con.Open()
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@image", imageByteArray)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Erfolgreich gespeichert!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function search(name)
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim query As String = "select image from pictures where name=@name"
        Dim reader As MySqlDataReader
        Dim byteArray As Byte()

        con.ConnectionString = "Server=192.168.0.132;user id=root;password=root;Database=opa"
        Try
            con.Open()
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", name)
            reader = cmd.ExecuteReader
            While reader.Read()
                byteArray = reader(0)
            End While



            con.Close()
            Return byteArray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Class
