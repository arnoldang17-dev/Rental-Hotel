Imports MySql.Data.MySqlClient


Public Class Form8
    Private roomID As String
    Private roomPrice As String
    Private roomCapacity As String

    Public Sub New(roomID As String, roomPrice As String, roomCapacity As String)
        InitializeComponent()
        Me.roomID = roomID
        Me.roomPrice = roomPrice
        Me.roomCapacity = roomCapacity

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = roomID
        TextBox4.Text = roomPrice
        TextBox2.Text = roomCapacity

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

        connect()
        Dim query As String = "UPDATE room set Capacity = '" & TextBox2.Text & "', Price = '" & TextBox4.Text & "' WHERE room_ID = '" & roomID & "'"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Close()

        con.Close()
        MessageBox.Show("Room " & roomID & " has been updated.")
        Me.Close()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Close()
    End Sub
End Class