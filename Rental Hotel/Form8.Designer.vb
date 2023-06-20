<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Panel5 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        Panel7 = New Panel()
        Label18 = New Label()
        Panel6 = New Panel()
        Label17 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.BackgroundImage = My.Resources.Resources.pxfuel
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-15, -26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(825, 575)
        Panel1.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Purple
        Panel5.Location = New Point(75, 541)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(663, 10)
        Panel5.TabIndex = 19
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(75, 40)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(664, 522)
        Panel2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BackgroundImage = My.Resources.Resources.pxfuel__1_
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(13, 12)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(634, 75)
        Panel4.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(13, 93)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(634, 399)
        Panel3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(458, 205)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(114, 23)
        TextBox4.TabIndex = 27
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(146, 205)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 23)
        TextBox2.TabIndex = 24
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(Label18)
        Panel7.Location = New Point(42, 330)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(123, 25)
        Panel7.TabIndex = 23
        ' 
        ' Label18
        ' 
        Label18.BackColor = Color.WhiteSmoke
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(-1, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(121, 23)
        Label18.TabIndex = 0
        Label18.Text = "Change"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label17)
        Panel6.Location = New Point(458, 331)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(123, 25)
        Panel6.TabIndex = 22
        ' 
        ' Label17
        ' 
        Label17.BackColor = Color.WhiteSmoke
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(-1, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(121, 23)
        Label17.TabIndex = 0
        Label17.Text = "Cancel"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(23, 207)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 21)
        Label7.TabIndex = 6
        Label7.Text = "New Capacity :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(299, 207)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 21)
        Label9.TabIndex = 8
        Label9.Text = "New Price/Night :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(213, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 2
        Label3.Text = "Room ID :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(323, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 21)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(198, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 53)
        Label2.TabIndex = 1
        Label2.Text = "Change Labels"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(794, 522)
        ControlBox = False
        Controls.Add(Panel1)
        Name = "Form8"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
End Class
