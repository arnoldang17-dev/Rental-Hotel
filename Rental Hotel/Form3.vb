Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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

        For i As Integer = 1 To 14
            imgList.Images.Add(Image.FromFile("C:\Users\PC\source\repos\Rental Hotel\Rental Hotel\Resources\" & i & ".jpg"))
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

        Next
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
End Class