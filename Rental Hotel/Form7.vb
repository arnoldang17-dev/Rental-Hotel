Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        connect()

        Dim cmd As New MySqlCommand("SELECT r.Room_ID, r.description, t.Type, r.Price, r.Capacity, s.Status FROM room r, Type t, Status s where r.Type_ID = t.Type_ID and r.Status_ID = s.Status_ID", con)
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

            ListView1.Items.Add(item)

            con.Close()

        Next

    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        Dim item As ListViewItem = ListView1.SelectedItems(0)
        Dim roomID As String = item.SubItems(0).Text
        'Dim roomDesc As String = item.SubItems(1).Text
        Dim roomType As String = item.SubItems(2).Text
        Dim roomPrice As String = item.SubItems(3).Text
        Dim roomCapacity As String = item.SubItems(4).Text
        Dim roomStatus As String = item.SubItems(5).Text

        Dim form8 As New Form8(roomID, roomPrice, roomCapacity)
        form8.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form10.Show()
    End Sub
End Class