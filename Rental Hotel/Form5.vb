Imports MySql.Data.MySqlClient

Public Class Form5

    Private roomID As String
    'Private roomDesc As String
    Private roomType As String
    Private roomPrice As String
    Private roomCapacity As String
    Private roomStatus As String
    Private userID As String

    Public Sub New(roomID As String, roomType As String, roomPrice As String, roomCapacity As String, roomStatus As String, userID As String)
        InitializeComponent()
        Me.roomID = roomID
        'Me.roomDesc = roomDesc
        Me.roomType = roomType
        Me.roomPrice = roomPrice
        Me.roomCapacity = roomCapacity
        Me.roomStatus = roomStatus
        Me.userID = userID

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = roomID
        'Label2.Text = roomDesc
        Label1.Text = roomType
        Label4.Text = roomCapacity
        Label5.Text = roomStatus
        Label6.Text = roomPrice
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = roomPrice Then
            Label12.Visible = False

            connect()
            Dim query As String = "UPDATE room SET Status_ID = 1 WHERE room_ID = '" & roomID & "'"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            reader.Close()

            Dim query2 As String = "INSERT INTO Reservation VALUES(NULL, '" & userID & "', '" & roomID & "', '" & Date.Now.ToString("yyyy-MM-dd") & "')"
            Dim cmd2 As New MySqlCommand(query2, con)
            Dim reader2 As MySqlDataReader = cmd2.ExecuteReader()
            reader2.Close()


            Dim query3 As String = "Select Reservation_ID from Reservation where room_ID = '" & roomID & "' and check_in_date = '" & Date.Now.ToString("yyyy-MM-dd") & "'"
            Dim cmd3 As New MySqlCommand(query3, con)
            Dim reader3 As MySqlDataReader = cmd3.ExecuteReader()
            reader3.Read()
            Dim reservationID As String = reader3("Reservation_ID")
            reader3.Close()

            Dim query4 As String = "Select Payment_Method_ID from Payment_Method where Method = '" & ComboBox1.SelectedItem & "'"
            Dim cmd4 As New MySqlCommand(query4, con)
            Dim reader4 As MySqlDataReader = cmd4.ExecuteReader()
            reader4.Read()
            Dim paymentMethod As String = reader4("Payment_Method_ID")
            reader4.Close()

            Dim query5 As String = "INSERT INTO Payment VALUES(NULL, '" & reservationID & "', '" & Date.Now.ToString("yyyy-MM-dd") & "', '" & roomPrice & "', '" & paymentMethod & "')"
            Dim cmd5 As New MySqlCommand(query5, con)
            Dim reader5 As MySqlDataReader = cmd5.ExecuteReader()
            reader5.Close()
            con.Close()
            MessageBox.Show("Room " & roomID & " has been booked")
            Me.Hide()

        Else
            Label12.Text = "Invalid amount"
            Label12.Visible = True
            Label12.ForeColor = Color.Red

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()

    End Sub
End Class