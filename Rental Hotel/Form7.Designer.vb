﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader5, ColumnHeader6, ColumnHeader3, ColumnHeader4})
        ListView1.FullRowSelect = True
        ListView1.Location = New Point(2, 1)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1055, 640)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Preview"
        ColumnHeader1.TextAlign = HorizontalAlignment.Center
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Description"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 235
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Type"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Price Per Night"
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Capacity"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Status"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 150
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Indigo
        Panel1.BackgroundImage = My.Resources.Resources.pxfuel__1_
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(Panel4)
        Panel1.Location = New Point(2, 639)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1055, 126)
        Panel1.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(869, 44)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(166, 41)
        Panel4.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.WhiteSmoke
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(-1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 39)
        Label1.TabIndex = 0
        Label1.Text = "Logout"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1058, 762)
        Controls.Add(Panel1)
        Controls.Add(ListView1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
End Class