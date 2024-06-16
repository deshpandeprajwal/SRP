<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Base_Body = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblShowUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_connection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print_Report = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Base_Body
        '
        Me.Base_Body.BackColor = System.Drawing.Color.Transparent
        Me.Base_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Base_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Base_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Base_Body.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Base_Body.Location = New System.Drawing.Point(0, 60)
        Me.Base_Body.Margin = New System.Windows.Forms.Padding(4)
        Me.Base_Body.Name = "Base_Body"
        Me.Base_Body.Size = New System.Drawing.Size(1922, 967)
        Me.Base_Body.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel4, Me.LblShowUsername, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel5, Me.lbl_connection, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1027)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1922, 28)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 23)
        Me.ToolStripStatusLabel1.Text = "Logged In As:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 23)
        '
        'LblShowUsername
        '
        Me.LblShowUsername.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.LblShowUsername.AutoToolTip = True
        Me.LblShowUsername.DoubleClickEnabled = True
        Me.LblShowUsername.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblShowUsername.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.LblShowUsername.IsLink = True
        Me.LblShowUsername.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblShowUsername.LinkVisited = True
        Me.LblShowUsername.Name = "LblShowUsername"
        Me.LblShowUsername.Size = New System.Drawing.Size(50, 23)
        Me.LblShowUsername.Text = "SKN"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(1290, 23)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(189, 23)
        Me.ToolStripStatusLabel5.Text = "Connection Status:"
        '
        'lbl_connection
        '
        Me.lbl_connection.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connection.Name = "lbl_connection"
        Me.lbl_connection.Size = New System.Drawing.Size(118, 23)
        Me.lbl_connection.Text = "Connection"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(114, 23)
        Me.ToolStripStatusLabel2.Text = "Date_Time"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(107, 31)
        Me.RecordsToolStripMenuItem.Text = "Records"
        Me.RecordsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RecordsToolStripMenuItem.ToolTipText = "Search Records"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Panel1.Size = New System.Drawing.Size(1922, 60)
        Me.Panel1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.MarksToolStripMenuItem, Me.Print_Report, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(13, 12)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1896, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentsToolStripMenuItem, Me.ViewStudentsToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(151, 31)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        Me.RegistrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RegistrationToolStripMenuItem.ToolTipText = "Registration"
        '
        'AddStudentsToolStripMenuItem
        '
        Me.AddStudentsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddStudentsToolStripMenuItem.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentsToolStripMenuItem.Name = "AddStudentsToolStripMenuItem"
        Me.AddStudentsToolStripMenuItem.Size = New System.Drawing.Size(229, 32)
        Me.AddStudentsToolStripMenuItem.Text = "Add Students"
        Me.AddStudentsToolStripMenuItem.ToolTipText = "New Registration"
        '
        'ViewStudentsToolStripMenuItem
        '
        Me.ViewStudentsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ViewStudentsToolStripMenuItem.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStudentsToolStripMenuItem.Name = "ViewStudentsToolStripMenuItem"
        Me.ViewStudentsToolStripMenuItem.Size = New System.Drawing.Size(229, 32)
        Me.ViewStudentsToolStripMenuItem.Text = "View Students"
        Me.ViewStudentsToolStripMenuItem.ToolTipText = "View Saved Registration"
        '
        'MarksToolStripMenuItem
        '
        Me.MarksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMarksToolStripMenuItem})
        Me.MarksToolStripMenuItem.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarksToolStripMenuItem.Name = "MarksToolStripMenuItem"
        Me.MarksToolStripMenuItem.Size = New System.Drawing.Size(89, 31)
        Me.MarksToolStripMenuItem.Text = "Marks"
        '
        'ViewMarksToolStripMenuItem
        '
        Me.ViewMarksToolStripMenuItem.Name = "ViewMarksToolStripMenuItem"
        Me.ViewMarksToolStripMenuItem.Size = New System.Drawing.Size(206, 32)
        Me.ViewMarksToolStripMenuItem.Text = "View Marks"
        '
        'Print_Report
        '
        Me.Print_Report.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print_Report.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Print_Report.Name = "Print_Report"
        Me.Print_Report.Size = New System.Drawing.Size(75, 31)
        Me.Print_Report.Text = "Print"
        Me.Print_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Print_Report.ToolTipText = "Logout"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(99, 31)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LogoutToolStripMenuItem.ToolTipText = "Logout"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1922, 1055)
        Me.Controls.Add(Me.Base_Body)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SRP"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Base_Body As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblShowUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_connection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Print_Report As System.Windows.Forms.ToolStripMenuItem
End Class
