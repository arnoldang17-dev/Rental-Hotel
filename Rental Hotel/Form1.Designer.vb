<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        Label8 = New Label()
        Label4 = New Label()
        Panel5 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.BackgroundImage = My.Resources.Resources.pxfuel
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1280, 864)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Location = New Point(334, 229)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(592, 419)
        Panel2.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Purple
        Panel7.Location = New Point(50, 382)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(497, 10)
        Panel7.TabIndex = 21
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(TextBox1)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(TextBox2)
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(Panel3)
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(Panel4)
        Panel6.Controls.Add(Label4)
        Panel6.Location = New Point(49, 96)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(498, 280)
        Panel6.TabIndex = 17
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(143, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(225, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(82, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 2
        Label2.Text = "Email :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(54, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 4
        Label3.Text = "Password :"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(143, 120)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(225, 23)
        TextBox2.TabIndex = 5
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(254, 247)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 15)
        Label6.TabIndex = 10
        Label6.Text = "Click Here."
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(194, 190)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(90, 25)
        Panel3.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 23)
        Label7.TabIndex = 0
        Label7.Text = "Login"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(143, 247)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 15)
        Label5.TabIndex = 9
        Label5.Text = "Not Registered Yet? "
        ' 
        ' Panel4
        ' 
        Panel4.BackgroundImageLayout = ImageLayout.Stretch
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(375, 120)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(43, 23)
        Panel4.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.WhiteSmoke
        Label8.Location = New Point(3, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 20)
        Label8.TabIndex = 0
        Label8.Text = "Show"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(268, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 8
        Label4.Text = "Forgot Password?"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Violet
        Panel5.BackgroundImage = My.Resources.Resources.pxfuel__1_
        Panel5.BackgroundImageLayout = ImageLayout.Center
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(49, 33)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(498, 53)
        Panel5.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(144, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 53)
        Label1.TabIndex = 0
        Label1.Text = "Login Account"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1275, 855)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
End Class
