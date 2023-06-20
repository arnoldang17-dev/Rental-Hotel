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

        Dim query As String = "INSERT INTO Customer VALUES(NULL, '" & TextBox1.Text & "', '" & TextBox2.Text & "',  '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Close()

        Dim query1 As String = "Select Customer_ID from Customer where name = '" & TextBox1.Text & "'"
        Dim cmd1 As New MySqlCommand(query1, con)
        Dim reader1 As MySqlDataReader = cmd1.ExecuteReader()
        reader1.Read()
        Dim customerID As String = reader1("Customer_ID")
        reader1.Close()


        Dim query2 As String = "INSERT INTO user VALUES(NULL, '" & customerID & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')"
        Dim cmd2 As New MySqlCommand(query2, con)
        Dim reader2 As MySqlDataReader = cmd2.ExecuteReader()
        reader2.Close()

        con.Close()
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