Imports MySql.Data.MySqlClient

Public Class Form6
    Private Sub TextBox4_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyUp

        If TextBox4.Text IsNot TextBox3.Text Then
            Label5.Visible = True
            Label5.Text = "Password does not match"
            Label5.ForeColor = Color.Red
        Else
            Label5.Text = "Password match"
            Label5.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        connect()

        Dim query2 As String = "INSERT INTO user VALUES(NULL, '" & TextBox2.Text & "', password('" & TextBox3.Text & "'), 1)"
        Dim cmd2 As New MySqlCommand(query2, con)
        Dim reader2 As MySqlDataReader = cmd2.ExecuteReader()
        reader2.Close()

        'get user id
        Dim query3 As String = "Select user_ID from user where Email = '" & TextBox2.Text & "'"
        Dim cmd3 As New MySqlCommand(query3, con)
        Dim reader3 As MySqlDataReader = cmd3.ExecuteReader()
        reader3.Read()
        Dim userID As String = reader3("user_ID")
        reader3.Close()

        Dim query As String = "INSERT INTO Customer VALUES(NULL, '" & userID & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "',  '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Close()

        MessageBox.Show("Account has been created.")
        Me.Close()

        Form1.Show()
        con.Close()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class