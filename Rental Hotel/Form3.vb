Imports MySql.Data.MySqlClient

Public Class Form3

    Private userID As String
    Public Sub New(userID As String)

        InitializeComponent()
        Me.userID = userID
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Dim query As String = "SELECT r.Room_ID,
p.Reference_Number,
r.description,
fr.Floor,
t.Type, r.Capacity,
s.Status 
FROM room r,
Type t,
Status s,
Reservation rs,
floor fr,
payment p,
user u
where r.Type_ID = t.Type_ID 
and r.Status_ID = s.Status_ID 
and r.Floor_ID = fr.Floor_ID 
and rs.Room_ID = r.Room_ID 
and rs.Payment_ID = p.Payment_ID 
and rs.User_ID = u.User_ID
and u.user_ID = '" & userID & "'"
        Dim cmd As New MySqlCommand(query, con)
        Dim da As New MySqlDataAdapter(cmd)

        Dim imgList As New ImageList
        imgList.ImageSize = New Size(200, 150)
        imgList.ColorDepth = ColorDepth.Depth32Bit

        For i As Integer = 1 To 36
            imgList.Images.Add(Image.FromFile("C:\Users\arnol\source\repos\arnoldang17-dev\Rental-Hotel\Rental Hotel\Resources\" & i & ".jpg"))
        Next

        ListView1.SmallImageList = imgList

        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows

            Dim item As New ListViewItem(row(0).ToString()) With {
                        .ImageIndex = Val(row(0).ToString()) - 1
                        }
            item.SubItems.Add(row(1).ToString())
            item.SubItems.Add(row(2).ToString())
            item.SubItems.Add(row(3).ToString())
            item.SubItems.Add(row(4).ToString())
            item.SubItems.Add(row(5).ToString())
            item.SubItems.Add(row(6).ToString())

            ListView1.Items.Add(item)

            con.Close()
            da.Dispose()
        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
        Dim form As New Form4(userID)
        form.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Dim item As ListViewItem = ListView1.SelectedItems(0)
        Dim room_ID As Integer = item.SubItems(0).Text
        Dim referenceNumber As Integer = item.SubItems(1).Text

        connect()

        'get transaction number from payment
        Dim query4 As String = "SELECT Payment_ID FROM payment where Reference_Number = '" & referenceNumber & "'"
        Dim cmd4 As New MySqlCommand(query4, con)
        Dim reader4 As MySqlDataReader = cmd4.ExecuteReader()
        reader4.Read()
        Dim payment As Integer = reader4("Payment_ID")
        reader4.Close()

        'delete from reservation by gett

        Dim query As String = "Delete from reservation where Room_ID = '" & room_ID & "' and User_ID = '" & userID & "' and Payment_ID = '" & payment & "' "
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Close()

        Dim query2 As String = "Update room set Status_ID = '6' where Room_ID = '" & room_ID & "'"
        Dim cmd2 As New MySqlCommand(query2, con)
        Dim reader2 As MySqlDataReader = cmd2.ExecuteReader()

        MessageBox.Show("Reservation has been cancelled.")

        Me.Close()
        con.Close()
        Dim form As New Form3(userID)
        form.Show()

    End Sub
End Class