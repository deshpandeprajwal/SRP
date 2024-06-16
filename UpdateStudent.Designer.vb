<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStudent
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
        Dim Permanant_AddressLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.MobileNo = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.Class_ = New System.Windows.Forms.TextBox()
        Me.FullName = New System.Windows.Forms.TextBox()
        Me.StudentID = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SRP_DbDataSet = New SRP.SRP_DbDataSet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoTableAdapter = New SRP.SRP_DbDataSetTableAdapters.StudentInfoTableAdapter()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Permanant_AddressLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SRP_DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Permanant_AddressLabel
        '
        Permanant_AddressLabel.AutoSize = True
        Permanant_AddressLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Permanant_AddressLabel.Location = New System.Drawing.Point(61, 415)
        Permanant_AddressLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Permanant_AddressLabel.Name = "Permanant_AddressLabel"
        Permanant_AddressLabel.Size = New System.Drawing.Size(85, 23)
        Permanant_AddressLabel.TabIndex = 380
        Permanant_AddressLabel.Text = "Address:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(60, 329)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(109, 23)
        Last_NameLabel.TabIndex = 379
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(58, 282)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(110, 23)
        First_NameLabel.TabIndex = 378
        First_NameLabel.Text = "First Name:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(60, 374)
        Mobile_NoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(104, 23)
        Mobile_NoLabel.TabIndex = 377
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(60, 100)
        Student_IDLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(108, 23)
        Student_IDLabel.TabIndex = 372
        Student_IDLabel.Text = "Student ID:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(61, 236)
        DOBLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(60, 23)
        DOBLabel.TabIndex = 371
        DOBLabel.Text = "DOB:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassLabel.Location = New System.Drawing.Point(61, 190)
        ClassLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(62, 23)
        ClassLabel.TabIndex = 370
        ClassLabel.Text = "Class:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(60, 144)
        Full_NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(102, 23)
        Full_NameLabel.TabIndex = 369
        Full_NameLabel.Text = "Full Name:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Centaur", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(218, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update Records"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Picture)
        Me.Panel4.Controls.Add(Me.Address)
        Me.Panel4.Controls.Add(Me.MobileNo)
        Me.Panel4.Controls.Add(Me.LastName)
        Me.Panel4.Controls.Add(Me.FirstName)
        Me.Panel4.Controls.Add(Me.DOB)
        Me.Panel4.Controls.Add(Me.Class_)
        Me.Panel4.Controls.Add(Me.FullName)
        Me.Panel4.Controls.Add(Me.StudentID)
        Me.Panel4.Controls.Add(Me.btnBrowse)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Permanant_AddressLabel)
        Me.Panel4.Controls.Add(Last_NameLabel)
        Me.Panel4.Controls.Add(First_NameLabel)
        Me.Panel4.Controls.Add(Mobile_NoLabel)
        Me.Panel4.Controls.Add(Student_IDLabel)
        Me.Panel4.Controls.Add(DOBLabel)
        Me.Panel4.Controls.Add(ClassLabel)
        Me.Panel4.Controls.Add(Full_NameLabel)
        Me.Panel4.Controls.Add(Me.PictureTextBox)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(656, 566)
        Me.Panel4.TabIndex = 393
        '
        'Picture
        '
        Me.Picture.BackgroundImage = Global.SRP.My.Resources.Resources.User
        Me.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture.Location = New System.Drawing.Point(464, 178)
        Me.Picture.Margin = New System.Windows.Forms.Padding(6)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(150, 150)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 387
        Me.Picture.TabStop = False
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(208, 410)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(416, 76)
        Me.Address.TabIndex = 393
        '
        'MobileNo
        '
        Me.MobileNo.Location = New System.Drawing.Point(208, 366)
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.Size = New System.Drawing.Size(164, 30)
        Me.MobileNo.TabIndex = 393
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(208, 321)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(164, 30)
        Me.LastName.TabIndex = 393
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(208, 275)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(164, 30)
        Me.FirstName.TabIndex = 393
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(208, 231)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(164, 30)
        Me.DOB.TabIndex = 393
        '
        'Class_
        '
        Me.Class_.Location = New System.Drawing.Point(208, 183)
        Me.Class_.Name = "Class_"
        Me.Class_.Size = New System.Drawing.Size(164, 30)
        Me.Class_.TabIndex = 393
        '
        'FullName
        '
        Me.FullName.Location = New System.Drawing.Point(208, 139)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(263, 30)
        Me.FullName.TabIndex = 393
        '
        'StudentID
        '
        Me.StudentID.Location = New System.Drawing.Point(208, 95)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(164, 30)
        Me.StudentID.TabIndex = 393
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(492, 337)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(102, 33)
        Me.btnBrowse.TabIndex = 392
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(264, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 33)
        Me.btnSearch.TabIndex = 392
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(112, 18)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 33)
        Me.btnUpdate.TabIndex = 392
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(656, 80)
        Me.Panel3.TabIndex = 391
        '
        'PictureTextBox
        '
        Me.PictureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PictureTextBox.Location = New System.Drawing.Point(492, 247)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.Size = New System.Drawing.Size(84, 23)
        Me.PictureTextBox.TabIndex = 393
        Me.PictureTextBox.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Location = New System.Drawing.Point(0, 493)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 73)
        Me.Panel1.TabIndex = 394
        '
        'SRP_DbDataSet
        '
        Me.SRP_DbDataSet.DataSetName = "SRP_DbDataSet"
        Me.SRP_DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(414, 18)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 33)
        Me.btnClear.TabIndex = 393
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'UpdateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(656, 566)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UpdateStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Student Information"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.SRP_DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents StudentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents MobileNo As System.Windows.Forms.TextBox
    Friend WithEvents LastName As System.Windows.Forms.TextBox
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents DOB As System.Windows.Forms.TextBox
    Friend WithEvents Class_ As System.Windows.Forms.TextBox
    Friend WithEvents FullName As System.Windows.Forms.TextBox
    Friend WithEvents StudentID As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents PictureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents SRP_DbDataSet As SRP.SRP_DbDataSet
    Friend WithEvents StudentInfoTableAdapter As SRP.SRP_DbDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
