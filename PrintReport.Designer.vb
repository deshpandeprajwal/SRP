<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintReport
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintReport))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ScienceTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.SocialTextBox = New System.Windows.Forms.TextBox()
        Me.HindiTextBox = New System.Windows.Forms.TextBox()
        Me.MathematicsTextBox = New System.Windows.Forms.TextBox()
        Me.KannadaTextBox = New System.Windows.Forms.TextBox()
        Me.EnglishTextBox = New System.Windows.Forms.TextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.PercentTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Label7 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(466, 320)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(81, 23)
        Label7.TabIndex = 442
        Label7.Text = "Gender:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(466, 276)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(62, 23)
        Label3.TabIndex = 443
        Label3.Text = "Class:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(90, 276)
        Student_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(108, 23)
        Student_IDLabel.TabIndex = 441
        Student_IDLabel.Text = "Student ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(90, 319)
        Full_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(102, 23)
        Full_NameLabel.TabIndex = 440
        Full_NameLabel.Text = "Full Name:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(635, 945)
        Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(55, 23)
        Label21.TabIndex = 444
        Label21.Text = "HOD"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(30, 232)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(119, 23)
        Label1.TabIndex = 460
        Label1.Text = "Mathematics"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(32, 391)
        Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(58, 23)
        Label18.TabIndex = 461
        Label18.Text = "Total "
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(31, 334)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(129, 23)
        Label4.TabIndex = 462
        Label4.Text = "Social Science"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(30, 178)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 23)
        Label5.TabIndex = 458
        Label5.Text = "Hindi"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(30, 283)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(74, 23)
        Label6.TabIndex = 459
        Label6.Text = "Science"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(291, 391)
        Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(40, 23)
        Label19.TabIndex = 451
        Label19.Text = "600"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(292, 334)
        Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(40, 23)
        Label16.TabIndex = 452
        Label16.Text = "100"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(291, 283)
        Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(40, 23)
        Label15.TabIndex = 449
        Label15.Text = "100"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(291, 232)
        Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(40, 23)
        Label14.TabIndex = 450
        Label14.Text = "100"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(291, 178)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(40, 23)
        Label13.TabIndex = 455
        Label13.Text = "100"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(291, 125)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(40, 23)
        Label12.TabIndex = 456
        Label12.Text = "100"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(291, 65)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(40, 23)
        Label11.TabIndex = 453
        Label11.Text = "100"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(32, 65)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(84, 23)
        First_NameLabel.TabIndex = 454
        First_NameLabel.Text = "Kannada"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OccupationLabel.Location = New System.Drawing.Point(30, 125)
        OccupationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(71, 23)
        OccupationLabel.TabIndex = 457
        OccupationLabel.Text = "English"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(42, 9)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(98, 26)
        Label9.TabIndex = 448
        Label9.Text = "Subjects"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(457, 9)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(182, 26)
        Label10.TabIndex = 446
        Label10.Text = "Marks Obtained"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(250, 9)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(138, 26)
        Label8.TabIndex = 447
        Label8.Text = "Total Marks"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(297, 364)
        Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(142, 26)
        Label17.TabIndex = 447
        Label17.Text = "Marks Sheet"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(477, 856)
        Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(64, 23)
        Label22.TabIndex = 472
        Label22.Text = "Result"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.Location = New System.Drawing.Point(69, 856)
        Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(106, 23)
        Label20.TabIndex = 473
        Label20.Text = "Percentage"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.Location = New System.Drawing.Point(298, 856)
        Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(64, 23)
        Label23.TabIndex = 473
        Label23.Text = "Grade"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(794, 154)
        Me.Panel4.TabIndex = 413
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 155)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(794, 81)
        Me.Panel3.TabIndex = 414
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(112, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 68)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Example School Name Here " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kalaburagi 585-102"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(428, 906)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 31)
        Me.btnSearch.TabIndex = 445
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(266, 906)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 31)
        Me.btnPrint.TabIndex = 445
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ScienceTextBox
        '
        Me.ScienceTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScienceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ScienceTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScienceTextBox.Location = New System.Drawing.Point(478, 277)
        Me.ScienceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ScienceTextBox.MaxLength = 3
        Me.ScienceTextBox.Name = "ScienceTextBox"
        Me.ScienceTextBox.ReadOnly = True
        Me.ScienceTextBox.Size = New System.Drawing.Size(135, 34)
        Me.ScienceTextBox.TabIndex = 467
        Me.ScienceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalTextBox
        '
        Me.TotalTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(478, 380)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTextBox.MaxLength = 3
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(135, 34)
        Me.TotalTextBox.TabIndex = 468
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SocialTextBox
        '
        Me.SocialTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SocialTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SocialTextBox.Location = New System.Drawing.Point(478, 328)
        Me.SocialTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SocialTextBox.MaxLength = 3
        Me.SocialTextBox.Name = "SocialTextBox"
        Me.SocialTextBox.ReadOnly = True
        Me.SocialTextBox.Size = New System.Drawing.Size(135, 34)
        Me.SocialTextBox.TabIndex = 469
        Me.SocialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HindiTextBox
        '
        Me.HindiTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HindiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HindiTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HindiTextBox.Location = New System.Drawing.Point(478, 172)
        Me.HindiTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.HindiTextBox.MaxLength = 3
        Me.HindiTextBox.Name = "HindiTextBox"
        Me.HindiTextBox.ReadOnly = True
        Me.HindiTextBox.Size = New System.Drawing.Size(135, 34)
        Me.HindiTextBox.TabIndex = 465
        Me.HindiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MathematicsTextBox
        '
        Me.MathematicsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MathematicsTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathematicsTextBox.Location = New System.Drawing.Point(478, 226)
        Me.MathematicsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MathematicsTextBox.MaxLength = 3
        Me.MathematicsTextBox.Name = "MathematicsTextBox"
        Me.MathematicsTextBox.ReadOnly = True
        Me.MathematicsTextBox.Size = New System.Drawing.Size(135, 34)
        Me.MathematicsTextBox.TabIndex = 466
        Me.MathematicsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KannadaTextBox
        '
        Me.KannadaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KannadaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KannadaTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KannadaTextBox.Location = New System.Drawing.Point(478, 54)
        Me.KannadaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.KannadaTextBox.MaxLength = 3
        Me.KannadaTextBox.Name = "KannadaTextBox"
        Me.KannadaTextBox.ReadOnly = True
        Me.KannadaTextBox.Size = New System.Drawing.Size(135, 34)
        Me.KannadaTextBox.TabIndex = 463
        Me.KannadaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EnglishTextBox
        '
        Me.EnglishTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EnglishTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EnglishTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishTextBox.Location = New System.Drawing.Point(478, 119)
        Me.EnglishTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EnglishTextBox.MaxLength = 3
        Me.EnglishTextBox.Name = "EnglishTextBox"
        Me.EnglishTextBox.ReadOnly = True
        Me.EnglishTextBox.Size = New System.Drawing.Size(135, 34)
        Me.EnglishTextBox.TabIndex = 464
        Me.EnglishTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(794, 981)
        Me.ShapeContainer3.TabIndex = 470
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape3.Location = New System.Drawing.Point(-1, -1)
        Me.RectangleShape3.Name = "RectangleShape2"
        Me.RectangleShape3.Size = New System.Drawing.Size(750, 50)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ScienceTextBox)
        Me.Panel1.Controls.Add(Me.TotalTextBox)
        Me.Panel1.Controls.Add(Me.SocialTextBox)
        Me.Panel1.Controls.Add(Me.HindiTextBox)
        Me.Panel1.Controls.Add(Me.MathematicsTextBox)
        Me.Panel1.Controls.Add(Me.KannadaTextBox)
        Me.Panel1.Controls.Add(Me.EnglishTextBox)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label18)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label19)
        Me.Panel1.Controls.Add(Label16)
        Me.Panel1.Controls.Add(Label15)
        Me.Panel1.Controls.Add(Label14)
        Me.Panel1.Controls.Add(Label13)
        Me.Panel1.Controls.Add(Label12)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(First_NameLabel)
        Me.Panel1.Controls.Add(OccupationLabel)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(60, 408)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 422)
        Me.Panel1.TabIndex = 471
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(661, 420)
        Me.ShapeContainer1.TabIndex = 470
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 420
        Me.LineShape2.X2 = 420
        Me.LineShape2.Y1 = 2
        Me.LineShape2.Y2 = 422
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 205
        Me.LineShape1.X2 = 205
        Me.LineShape1.Y1 = -1
        Me.LineShape1.Y2 = 419
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(206, 265)
        Me.Student_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Student_IDTextBox.MaxLength = 3
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(135, 34)
        Me.Student_IDTextBox.TabIndex = 463
        Me.Student_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Full_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(206, 307)
        Me.Full_NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Full_NameTextBox.MaxLength = 3
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.ReadOnly = True
        Me.Full_NameTextBox.Size = New System.Drawing.Size(219, 34)
        Me.Full_NameTextBox.TabIndex = 463
        Me.Full_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClassTextBox
        '
        Me.ClassTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClassTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClassTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassTextBox.Location = New System.Drawing.Point(555, 265)
        Me.ClassTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ClassTextBox.MaxLength = 3
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.ReadOnly = True
        Me.ClassTextBox.Size = New System.Drawing.Size(135, 34)
        Me.ClassTextBox.TabIndex = 463
        Me.ClassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GenderTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GenderTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(555, 309)
        Me.GenderTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GenderTextBox.MaxLength = 3
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(135, 34)
        Me.GenderTextBox.TabIndex = 463
        Me.GenderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultTextBox
        '
        Me.ResultTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextBox.Location = New System.Drawing.Point(549, 845)
        Me.ResultTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ResultTextBox.MaxLength = 3
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ReadOnly = True
        Me.ResultTextBox.Size = New System.Drawing.Size(161, 34)
        Me.ResultTextBox.TabIndex = 468
        Me.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PercentTextBox
        '
        Me.PercentTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PercentTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentTextBox.Location = New System.Drawing.Point(183, 845)
        Me.PercentTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PercentTextBox.MaxLength = 3
        Me.PercentTextBox.Name = "PercentTextBox"
        Me.PercentTextBox.ReadOnly = True
        Me.PercentTextBox.Size = New System.Drawing.Size(67, 34)
        Me.PercentTextBox.TabIndex = 468
        Me.PercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GradeTextBox
        '
        Me.GradeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GradeTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextBox.Location = New System.Drawing.Point(370, 845)
        Me.GradeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GradeTextBox.MaxLength = 3
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.ReadOnly = True
        Me.GradeTextBox.Size = New System.Drawing.Size(67, 34)
        Me.GradeTextBox.TabIndex = 468
        Me.GradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.RectangleShape1.Location = New System.Drawing.Point(60, 836)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(663, 51)
        '
        'LineShape3
        '
        Me.LineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 661
        Me.LineShape3.X2 = 1
        Me.LineShape3.Y1 = 45
        Me.LineShape3.Y2 = 45
        '
        'LineShape4
        '
        Me.LineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 660
        Me.LineShape4.X2 = 0
        Me.LineShape4.Y1 = 102
        Me.LineShape4.Y2 = 102
        '
        'LineShape5
        '
        Me.LineShape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 660
        Me.LineShape5.X2 = 0
        Me.LineShape5.Y1 = 163
        Me.LineShape5.Y2 = 163
        '
        'LineShape6
        '
        Me.LineShape6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 661
        Me.LineShape6.X2 = 1
        Me.LineShape6.Y1 = 214
        Me.LineShape6.Y2 = 214
        '
        'LineShape7
        '
        Me.LineShape7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 661
        Me.LineShape7.X2 = 1
        Me.LineShape7.Y1 = 268
        Me.LineShape7.Y2 = 268
        '
        'LineShape8
        '
        Me.LineShape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 659
        Me.LineShape8.X2 = -1
        Me.LineShape8.Y1 = 320
        Me.LineShape8.Y2 = 320
        '
        'LineShape9
        '
        Me.LineShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 660
        Me.LineShape9.X2 = 0
        Me.LineShape9.Y1 = 372
        Me.LineShape9.Y2 = 372
        '
        'PrintReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(794, 981)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.PercentTextBox)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(Label23)
        Me.Controls.Add(Label22)
        Me.Controls.Add(Label20)
        Me.Controls.Add(Label17)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Label21)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ScienceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HindiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MathematicsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KannadaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnglishTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
