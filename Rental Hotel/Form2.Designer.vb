﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label5 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(490, 301)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(131, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(226, 37)
        Label5.TabIndex = 8
        Label5.Text = "Change Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(192, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(192, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 15)
        Label4.TabIndex = 6
        Label4.Text = "Password does not match"
        Label4.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(192, 198)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(199, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(9, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 21)
        Label3.TabIndex = 4
        Label3.Text = "Re-type New Password :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(192, 135)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(199, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(67, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 21)
        Label2.TabIndex = 2
        Label2.Text = "New Password :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(192, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(131, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 21)
        Label1.TabIndex = 0
        Label1.Text = "Email :"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 305)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
