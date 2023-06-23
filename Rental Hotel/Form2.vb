Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If TextBox2.Text IsNot TextBox3.Text Then
            Label4.Text = "Password does not match"
            Label4.ForeColor = Color.Red
        Else
            Label4.Text = "Password match"
            Label4.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        connect()

        Dim query As String = "Update user set Password = password('" & TextBox2.Text & "') where Email = '" & TextBox1.Text & "'"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        con.Close()
        MsgBox("Success changing password.")
        Me.Hide()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

End Class