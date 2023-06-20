<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label7 = New Label()
        Panel3 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ImageList1 = New ImageList(components)
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel1.BackgroundImage = My.Resources.Resources.pxfuel
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-4, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(983, 366)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(ListView1)
        Panel2.Location = New Point(16, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(952, 340)
        Panel2.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(819, 296)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 34)
        Label7.TabIndex = 3
        Label7.Text = "Close"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Purple
        Panel3.Location = New Point(3, 296)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(799, 10)
        Panel3.TabIndex = 2
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader1, ColumnHeader3, ColumnHeader2, ColumnHeader4, ColumnHeader6, ColumnHeader7})
        ListView1.FullRowSelect = True
        ListView1.Location = New Point(0, 0)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(952, 290)
        ListView1.SmallImageList = ImageList1
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Reference Number"
        ColumnHeader1.TextAlign = HorizontalAlignment.Center
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Floor"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 50
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Description"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 300
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Type"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "fernando-alvarez-rodriguez-M7GddPqJowg-unsplash.jpg")
        ImageList1.Images.SetKeyName(1, "francesca-saraco-_dS27XGgRyQ-unsplash.jpg")
        ImageList1.Images.SetKeyName(2, "marten-bjork-n_IKQDCyrG0-unsplash.jpg")
        ImageList1.Images.SetKeyName(3, "fernando-alvarez-rodriguez-M7GddPqJowg-unsplash.jpg")
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Preview"
        ColumnHeader5.Width = 250
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Capacity"
        ColumnHeader6.TextAlign = HorizontalAlignment.Center
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Status"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 364)
        ControlBox = False
        Controls.Add(Panel1)
        Name = "Form3"
        Text = " "
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
