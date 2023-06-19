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
        TextBox5 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cyan
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(810, 469)
        Panel1.TabIndex = 0
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(284, 218)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(246, 23)
        TextBox5.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(204, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 10
        Label6.Text = "Address :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(284, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 15)
        Label5.TabIndex = 9
        Label5.Text = "Password does not match"
        Label5.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(366, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(284, 334)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(246, 23)
        TextBox4.TabIndex = 7
        TextBox4.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(151, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 6
        Label4.Text = "Re-Type Password :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(284, 266)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 23)
        TextBox3.TabIndex = 5
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(196, 274)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 4
        Label3.Text = "Password :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(284, 156)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(217, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(284, 99)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(246, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(217, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name :"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(687, 218)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(111, 23)
        TextBox6.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(560, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 15)
        Label7.TabIndex = 13
        Label7.Text = "Contact Number :"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(811, 468)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
