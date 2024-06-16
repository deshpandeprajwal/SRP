<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMarks
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
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Room_NoLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Me.MarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SRP_DbDataSet = New SRP.SRP_DbDataSet()
        Me.MarksTableAdapter = New SRP.SRP_DbDataSetTableAdapters.MarksTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSearcjh = New System.Windows.Forms.Button()
        Me.Stud_IdSearch = New System.Windows.Forms.TextBox()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.ScienceTextBox = New System.Windows.Forms.TextBox()
        Me.SocialTextBox = New System.Windows.Forms.TextBox()
        Me.HindiTextBox = New System.Windows.Forms.TextBox()
        Me.MathematicsTextBox = New System.Windows.Forms.TextBox()
        Me.KannadaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalMarksTextBox = New System.Windows.Forms.TextBox()
        Me.EnglishTextBox = New System.Windows.Forms.TextBox()
        Me.PercentageTextBox = New System.Windows.Forms.TextBox()
        Student_IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Room_NoLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRP_DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Student_IDLabel.Location = New System.Drawing.Point(40, 155)
        Student_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(129, 24)
        Student_IDLabel.TabIndex = 367
        Student_IDLabel.Text = "Student ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Full_NameLabel.Location = New System.Drawing.Point(744, 154)
        Full_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(123, 24)
        Full_NameLabel.TabIndex = 369
        Full_NameLabel.Text = "Full Name:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Label6.Location = New System.Drawing.Point(40, 193)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(92, 24)
        Label6.TabIndex = 372
        Label6.Text = "Gender:"
        '
        'Room_NoLabel
        '
        Room_NoLabel.AutoSize = True
        Room_NoLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Room_NoLabel.Location = New System.Drawing.Point(744, 193)
        Room_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Room_NoLabel.Name = "Room_NoLabel"
        Room_NoLabel.Size = New System.Drawing.Size(70, 24)
        Room_NoLabel.TabIndex = 372
        Room_NoLabel.Text = "Class:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(691, 154)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(79, 24)
        Label7.TabIndex = 46
        Label7.Text = "Grade:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(691, 196)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(83, 24)
        Label5.TabIndex = 46
        Label5.Text = "Result:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(32, 183)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(150, 24)
        Label3.TabIndex = 42
        Label3.Text = "Mathematics:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(32, 267)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(163, 24)
        Label4.TabIndex = 44
        Label4.Text = "Social Science:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(32, 141)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 24)
        Label1.TabIndex = 38
        Label1.Text = "Hindi:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(32, 225)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(95, 24)
        Label2.TabIndex = 40
        Label2.Text = "Science:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(32, 56)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(110, 24)
        First_NameLabel.TabIndex = 28
        First_NameLabel.Text = "Kannada:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(691, 62)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(141, 24)
        Last_NameLabel.TabIndex = 30
        Last_NameLabel.Text = "Total Marks:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OccupationLabel.Location = New System.Drawing.Point(32, 99)
        OccupationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(95, 24)
        OccupationLabel.TabIndex = 32
        OccupationLabel.Text = "English:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NoLabel.Location = New System.Drawing.Point(691, 107)
        Mobile_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(131, 24)
        Mobile_NoLabel.TabIndex = 36
        Mobile_NoLabel.Text = "Percentage:"
        '
        'MarksBindingSource
        '
        Me.MarksBindingSource.DataMember = "Marks"
        Me.MarksBindingSource.DataSource = Me.SRP_DbDataSet
        '
        'SRP_DbDataSet
        '
        Me.SRP_DbDataSet.DataSetName = "SRP_DbDataSet"
        Me.SRP_DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarksTableAdapter
        '
        Me.MarksTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Student_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Student_IDTextBox)
        Me.GroupBox1.Controls.Add(Full_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Full_NameTextBox)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Room_NoLabel)
        Me.GroupBox1.Controls.Add(Me.GenderTextBox)
        Me.GroupBox1.Controls.Add(Me.ClassTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 82)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1652, 657)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Marks"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(1458, 480)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 34)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(1458, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 34)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.Location = New System.Drawing.Point(1458, 350)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 34)
        Me.btnEdit.TabIndex = 32
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.btnSearcjh)
        Me.GroupBox3.Controls.Add(Me.Stud_IdSearch)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(44, 28)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(490, 109)
        Me.GroupBox3.TabIndex = 375
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(346, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 34)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSearcjh
        '
        Me.btnSearcjh.Location = New System.Drawing.Point(348, 50)
        Me.btnSearcjh.Name = "btnSearcjh"
        Me.btnSearcjh.Size = New System.Drawing.Size(96, 34)
        Me.btnSearcjh.TabIndex = 32
        Me.btnSearcjh.Text = "Search"
        Me.btnSearcjh.UseVisualStyleBackColor = True
        '
        'Stud_IdSearch
        '
        Me.Stud_IdSearch.BackColor = System.Drawing.Color.White
        Me.Stud_IdSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Stud_IdSearch.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stud_IdSearch.Location = New System.Drawing.Point(16, 50)
        Me.Stud_IdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.Stud_IdSearch.MaxLength = 4
        Me.Stud_IdSearch.Name = "Stud_IdSearch"
        Me.Stud_IdSearch.Size = New System.Drawing.Size(312, 34)
        Me.Stud_IdSearch.TabIndex = 31
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(364, 145)
        Me.Student_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.ReadOnly = True
        Me.Student_IDTextBox.Size = New System.Drawing.Size(312, 34)
        Me.Student_IDTextBox.TabIndex = 368
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(1068, 144)
        Me.Full_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.ReadOnly = True
        Me.Full_NameTextBox.Size = New System.Drawing.Size(312, 34)
        Me.Full_NameTextBox.TabIndex = 370
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GenderTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(364, 190)
        Me.GenderTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(312, 34)
        Me.GenderTextBox.TabIndex = 373
        '
        'ClassTextBox
        '
        Me.ClassTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClassTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassTextBox.Location = New System.Drawing.Point(1068, 184)
        Me.ClassTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.ReadOnly = True
        Me.ClassTextBox.Size = New System.Drawing.Size(312, 34)
        Me.ClassTextBox.TabIndex = 373
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Me.GradeTextBox)
        Me.GroupBox2.Controls.Add(Me.ResultTextBox)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.ScienceTextBox)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.SocialTextBox)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.HindiTextBox)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.MathematicsTextBox)
        Me.GroupBox2.Controls.Add(First_NameLabel)
        Me.GroupBox2.Controls.Add(Me.KannadaTextBox)
        Me.GroupBox2.Controls.Add(Last_NameLabel)
        Me.GroupBox2.Controls.Add(Me.TotalMarksTextBox)
        Me.GroupBox2.Controls.Add(OccupationLabel)
        Me.GroupBox2.Controls.Add(Me.EnglishTextBox)
        Me.GroupBox2.Controls.Add(Mobile_NoLabel)
        Me.GroupBox2.Controls.Add(Me.PercentageTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 274)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1393, 350)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subjects"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GradeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GradeTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextBox.Location = New System.Drawing.Point(1015, 144)
        Me.GradeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GradeTextBox.MaxLength = 10
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.ReadOnly = True
        Me.GradeTextBox.Size = New System.Drawing.Size(189, 34)
        Me.GradeTextBox.TabIndex = 47
        Me.GradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultTextBox
        '
        Me.ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ResultTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextBox.Location = New System.Drawing.Point(1015, 186)
        Me.ResultTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ResultTextBox.MaxLength = 10
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ReadOnly = True
        Me.ResultTextBox.Size = New System.Drawing.Size(189, 34)
        Me.ResultTextBox.TabIndex = 47
        Me.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ScienceTextBox
        '
        Me.ScienceTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScienceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ScienceTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScienceTextBox.Location = New System.Drawing.Point(356, 221)
        Me.ScienceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ScienceTextBox.MaxLength = 3
        Me.ScienceTextBox.Name = "ScienceTextBox"
        Me.ScienceTextBox.ReadOnly = True
        Me.ScienceTextBox.Size = New System.Drawing.Size(135, 34)
        Me.ScienceTextBox.TabIndex = 43
        Me.ScienceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SocialTextBox
        '
        Me.SocialTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SocialTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SocialTextBox.Location = New System.Drawing.Point(355, 263)
        Me.SocialTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SocialTextBox.MaxLength = 3
        Me.SocialTextBox.Name = "SocialTextBox"
        Me.SocialTextBox.ReadOnly = True
        Me.SocialTextBox.Size = New System.Drawing.Size(135, 34)
        Me.SocialTextBox.TabIndex = 45
        Me.SocialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HindiTextBox
        '
        Me.HindiTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HindiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HindiTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HindiTextBox.Location = New System.Drawing.Point(356, 137)
        Me.HindiTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.HindiTextBox.MaxLength = 3
        Me.HindiTextBox.Name = "HindiTextBox"
        Me.HindiTextBox.ReadOnly = True
        Me.HindiTextBox.Size = New System.Drawing.Size(135, 34)
        Me.HindiTextBox.TabIndex = 39
        Me.HindiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MathematicsTextBox
        '
        Me.MathematicsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MathematicsTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathematicsTextBox.Location = New System.Drawing.Point(356, 179)
        Me.MathematicsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MathematicsTextBox.MaxLength = 3
        Me.MathematicsTextBox.Name = "MathematicsTextBox"
        Me.MathematicsTextBox.ReadOnly = True
        Me.MathematicsTextBox.Size = New System.Drawing.Size(135, 34)
        Me.MathematicsTextBox.TabIndex = 41
        Me.MathematicsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KannadaTextBox
        '
        Me.KannadaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KannadaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KannadaTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KannadaTextBox.Location = New System.Drawing.Point(356, 52)
        Me.KannadaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.KannadaTextBox.MaxLength = 3
        Me.KannadaTextBox.Name = "KannadaTextBox"
        Me.KannadaTextBox.ReadOnly = True
        Me.KannadaTextBox.Size = New System.Drawing.Size(135, 34)
        Me.KannadaTextBox.TabIndex = 29
        Me.KannadaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalMarksTextBox
        '
        Me.TotalMarksTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalMarksTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TotalMarksTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMarksTextBox.Location = New System.Drawing.Point(1015, 58)
        Me.TotalMarksTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalMarksTextBox.MaxLength = 3
        Me.TotalMarksTextBox.Name = "TotalMarksTextBox"
        Me.TotalMarksTextBox.ReadOnly = True
        Me.TotalMarksTextBox.Size = New System.Drawing.Size(189, 34)
        Me.TotalMarksTextBox.TabIndex = 31
        Me.TotalMarksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EnglishTextBox
        '
        Me.EnglishTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnglishTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EnglishTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishTextBox.Location = New System.Drawing.Point(356, 95)
        Me.EnglishTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EnglishTextBox.MaxLength = 3
        Me.EnglishTextBox.Name = "EnglishTextBox"
        Me.EnglishTextBox.ReadOnly = True
        Me.EnglishTextBox.Size = New System.Drawing.Size(135, 34)
        Me.EnglishTextBox.TabIndex = 33
        Me.EnglishTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PercentageTextBox
        '
        Me.PercentageTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PercentageTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageTextBox.Location = New System.Drawing.Point(1015, 101)
        Me.PercentageTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PercentageTextBox.MaxLength = 10
        Me.PercentageTextBox.Name = "PercentageTextBox"
        Me.PercentageTextBox.ReadOnly = True
        Me.PercentageTextBox.Size = New System.Drawing.Size(189, 34)
        Me.PercentageTextBox.TabIndex = 37
        Me.PercentageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ViewMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ViewMarks"
        Me.Text = "ViewMarks"
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRP_DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SRP_DbDataSet As SRP.SRP_DbDataSet
    Friend WithEvents MarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarksTableAdapter As SRP.SRP_DbDataSetTableAdapters.MarksTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSearcjh As System.Windows.Forms.Button
    Friend WithEvents Stud_IdSearch As System.Windows.Forms.TextBox
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScienceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HindiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MathematicsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KannadaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalMarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnglishTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
