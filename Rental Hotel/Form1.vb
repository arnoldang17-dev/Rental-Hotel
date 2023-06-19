Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
            Button1.Text = "Hide"
        Else
            TextBox2.UseSystemPasswordChar = True
            Button1.Text = "Show"
        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        'set label4 to underlined
        Label4.Font = New Font(Label4.Font, FontStyle.Underline)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        'set label4 to regular
        Label4.Font = New Font(Label4.Font, FontStyle.Regular)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.Font = New Font(Label6.Font, FontStyle.Underline)
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.Font = New Font(Label6.Font, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        Dim query As String = "SELECT * FROM user WHERE Email = '" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "'"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim form4 As New Form4(reader.GetString("user_ID"))
            form4.Show()
            con.Close()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password")
            con.Close()
        End If

        con.Close()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class
