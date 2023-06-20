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

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp

        If TextBox1.Text = roomPrice Then
            Label12.Visible = False

        Else
            Label12.Visible = True
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

        If (DateTimePicker1.Value > DateTimePicker2.Value) Or (DateTimePicker2.Value < DateTime.Today) Or (DateTimePicker1.Value = DateTimePicker2.Value) Then
            Label16.Visible = True
        Else
            Dim dateDifference As TimeSpan = DateTimePicker2.Value.Date - DateTimePicker1.Value.Date

            Label6.Text = (dateDifference.Days * roomPrice).ToString
            TextBox1.Text = ""
            Label16.Visible = False

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        If (DateTimePicker1.Value > DateTimePicker2.Value) Or (DateTimePicker1.Value < DateTime.Today) Or (DateTimePicker1.Value = DateTimePicker2.Value) Then
            Label15.Visible = True
        Else
            Dim dateDifference As TimeSpan = DateTimePicker2.Value.Date - DateTimePicker1.Value.Date

            Label6.Text = (dateDifference.Days * roomPrice).ToString
            TextBox1.Text = ""
            Label16.Visible = False

        End If

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim random As New Random()
        Dim value As Integer = random.Next(100000, 999999)


        If Label12.Visible Or Label15.Visible Or Label16.Visible Or ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please fill the Payment correctly.")
        Else
            connect()
            Dim query As String = "UPDATE room SET Status_ID = 1 WHERE room_ID = '" & roomID & "'"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            reader.Close()

            Dim query4 As String = "Select Payment_Method_ID from Payment_Method where Method = '" & ComboBox1.SelectedItem & "'"
            Dim cmd4 As New MySqlCommand(query4, con)
            Dim reader4 As MySqlDataReader = cmd4.ExecuteReader()
            reader4.Read()
            Dim paymentMethod As String = reader4("Payment_Method_ID")
            reader4.Close()

            Dim query5 As String = "INSERT INTO Payment VALUES(NULL, '" & Date.Now.ToString("yyyy-MM-dd") & "', '" & value & "', '" & Label6.Text & "', '" & paymentMethod & "')"
            Dim cmd5 As New MySqlCommand(query5, con)
            Dim reader5 As MySqlDataReader = cmd5.ExecuteReader()
            reader5.Close()

            Dim query6 As String = "Select Payment_ID from Payment where Payment_Date = '" & Date.Now.ToString("yyyy-MM-dd") & "'"
            Dim cmd6 As New MySqlCommand(query6, con)
            Dim reader6 As MySqlDataReader = cmd6.ExecuteReader()
            reader6.Read()
            Dim paymentID As String = reader6("Payment_ID")
            reader6.Close()


            Dim query2 As String = "INSERT INTO Reservation VALUES(NULL, '" & userID & "', '" & roomID & "', '" & paymentID & "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "', current_timestamp())"
            Dim cmd2 As New MySqlCommand(query2, con)
            Dim reader2 As MySqlDataReader = cmd2.ExecuteReader()
            reader2.Close()

            con.Close()
            MessageBox.Show("Room " & roomID & " has been booked.")
            Me.Close()


        End If
    End Sub
End Class