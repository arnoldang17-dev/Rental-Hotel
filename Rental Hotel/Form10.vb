Imports MySql.Data.MySqlClient

Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get Customer name phone number email room from reservation

        connect()
        Dim query As String = "Select c.Name, c.Contact_Number, c.Email, r.Room
from customer c, room r, reservation re
WHERE c.user_ID = re.User_ID AND
re.Room_ID = r.Room_ID
"
        Dim cmd As New MySqlCommand(query, con)
        Dim da As New MySqlDataAdapter(cmd)

        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows

            Dim item As New ListViewItem(row(0).ToString())

            item.SubItems.Add(row(1).ToString())
            item.SubItems.Add(row(2).ToString())
            item.SubItems.Add(row(3).ToString())

            ListView1.Items.Add(item)

            con.Close()
            da.Dispose()
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
End Class