Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public con As New MySqlConnection

    Sub connect()
        Try
            con.ConnectionString = "server=localhost;userid=root;password=;database=rental_hotel"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Module
