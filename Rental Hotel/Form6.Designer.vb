<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Panel4 = New Panel()
        Label9 = New Label()
        Panel5 = New Panel()
        Label10 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cyan
        Panel1.BackgroundImage = My.Resources.Resources.pxfuel__1_
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1030, 784)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(125, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(746, 566)
        Panel2.TabIndex = 14
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Purple
        Panel7.Location = New Point(45, 520)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(645, 10)
        Panel7.TabIndex = 20
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(TextBox3)
        Panel6.Controls.Add(Panel4)
        Panel6.Controls.Add(Panel5)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(TextBox2)
        Panel6.Controls.Add(TextBox4)
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(TextBox5)
        Panel6.Controls.Add(TextBox6)
        Panel6.Controls.Add(TextBox1)
        Panel6.Location = New Point(45, 124)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(645, 390)
        Panel6.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(27, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 21)
        Label4.TabIndex = 6
        Label4.Text = "Re-Type Password :"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(186, 191)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(289, 23)
        TextBox3.TabIndex = 5
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(88, 329)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(106, 28)
        Panel4.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.WhiteSmoke
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 27)
        Label9.TabIndex = 0
        Label9.Text = "Submit"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label10)
        Panel5.Location = New Point(439, 328)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(106, 28)
        Panel5.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.WhiteSmoke
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 27)
        Label10.TabIndex = 0
        Label10.Text = "Cancel"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(93, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 4
        Label3.Text = "Password :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(186, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 15)
        Label5.TabIndex = 9
        Label5.Text = "Password does not match"
        Label5.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(186, 78)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(289, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(186, 245)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(289, 23)
        TextBox4.TabIndex = 7
        TextBox4.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(100, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 21)
        Label6.TabIndex = 10
        Label6.Text = "Address :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(39, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(139, 21)
        Label7.TabIndex = 13
        Label7.Text = "Contact Number :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(122, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 2
        Label2.Text = "Email :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(119, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 0
        Label1.Text = "Name :"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(186, 153)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(289, 23)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Location = New Point(186, 113)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(289, 23)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(186, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(289, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.SlateBlue
        Panel3.BackgroundImage = My.Resources.Resources.pxfuel__1_
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(45, 40)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(645, 68)
        Panel3.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(98, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(448, 68)
        Label8.TabIndex = 0
        Label8.Text = "Customer Details"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 690)
        ControlBox = False
        Controls.Add(Panel1)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
End Class
