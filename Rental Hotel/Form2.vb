Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If TextBox2.Text IsNot TextBox3.Text Then
            Label5.Text = "Password does not match"
            Label5.ForeColor = Color.Red
        Else
            Label5.Text = "Password match"
            Label5.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()

        Dim query As String = "Update user set Password =  '" & TextBox2.Text & "' where Email = '" & TextBox1.Text & "'"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        con.Close()
        MsgBox("Success")
        Me.Hide()
    End Sub

End Class