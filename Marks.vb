Imports System.Data
Imports System.Data.OleDb

Public Class Marks

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Student_IDTextBox.Clear()
        Full_NameTextBox.Clear()
        ClassTextBox.Clear()
        GenderTextBox.Clear()
        KannadaTextBox.Clear()
        EnglishTextBox.Clear()
        HindiTextBox.Clear()
        ScienceTextBox.Clear()
        SocialTextBox.Clear()
        MathematicsTextBox.Clear()
        TotalMarksTextBox.Clear()
        PercentageTextBox.Clear()
        ResultTextBox.Clear()
        GradeTextBox.Clear()
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(Stud_IdSearch.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Class,Gender from StudentInfo where Student_ID='" + Stud_IdSearch.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Student_IDTextBox.Text = myreader("Student_ID")
            Full_NameTextBox.Text = myreader("Full_Name")
            ClassTextBox.Text = myreader("Class")
            GenderTextBox.Text = myreader("Gender")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Enter a valid Student ID to Search Records!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Calculate
        If Len(Trim(KannadaTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Kannada Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            KannadaTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(EnglishTextBox.Text)) = 0 Then
            MessageBox.Show("Enter English Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            EnglishTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(HindiTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Hindi Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            HindiTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(ScienceTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Mathematics Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ScienceTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(MathematicsTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Science Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            MathematicsTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(SocialTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Social Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            SocialTextBox.Focus()
            Exit Sub
        End If
        Try
            Dim KannadaMarks As Integer = Val(KannadaTextBox.Text)
            Dim EnglishMarks As Integer = Val(EnglishTextBox.Text)
            Dim HindiMarks As Integer = Val(HindiTextBox.Text)
            Dim ScienceMarks As Integer = Val(ScienceTextBox.Text)
            Dim MathematicsMarks As Integer = Val(MathematicsTextBox.Text)
            Dim SocialMarks As Integer = Val(SocialTextBox.Text)

            Dim TotalMarks As Integer = KannadaMarks + EnglishMarks + HindiMarks + ScienceMarks + MathematicsMarks + SocialMarks
            Dim Percentage As Double = (TotalMarks / 600) * 100

            TotalMarksTextBox.Text = TotalMarks.ToString()
            PercentageTextBox.Text = Percentage.ToString("0.00") + "%"

            Dim Grade As String = ""
            Dim Result As String = ""
            If KannadaMarks < 35 Or EnglishMarks < 35 Or HindiMarks < 35 Or ScienceMarks < 35 Or MathematicsMarks < 35 Or SocialMarks < 35 Then
                Grade = "F"
                Result = "Fail"
                ResultTextBox.BackColor = Color.Red
                ResultTextBox.ForeColor = Color.White
            ElseIf Percentage >= 90 Then
                Grade = "A+"
                Result = "Distinction"
                ResultTextBox.BackColor = Color.Green
                ResultTextBox.ForeColor = Color.White
            ElseIf Percentage >= 80 Then
                Grade = "A"
                Result = "First Class"
                ResultTextBox.BackColor = Color.Green
                ResultTextBox.ForeColor = Color.White
            ElseIf Percentage >= 70 Then
                Grade = "B+"
                Result = "First Class"
                ResultTextBox.BackColor = Color.Green
                ResultTextBox.ForeColor = Color.White
            ElseIf Percentage >= 60 Then
                Grade = "B"
                Result = "Second Class"
                ResultTextBox.BackColor = Color.Green
                ResultTextBox.ForeColor = Color.White
            ElseIf Percentage >= 50 Then
                Grade = "C"
                Result = "Third Class"
                ResultTextBox.BackColor = Color.Yellow
                ResultTextBox.ForeColor = Color.Black
            Else
                Grade = "F"
                Result = "Fail"
                ResultTextBox.BackColor = Color.Red
                ResultTextBox.ForeColor = Color.White
            End If
            GradeTextBox.Text = Grade
            ResultTextBox.Text = Result
        Catch ex As Exception
            MessageBox.Show("Something went wrong!! Please try again..", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save Data
        If Len(Trim(Student_IDTextBox.Text)) = 0 Then
            MessageBox.Show("Student Detail's Can't be null!! Please Search data then save data", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Stud_IdSearch.Focus()
            Exit Sub
        ElseIf Len(Trim(Full_NameTextBox.Text)) = 0 Then
            MessageBox.Show("Student Detail's Can't be null!! Please Search data then save data", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Stud_IdSearch.Focus()
            Exit Sub
        ElseIf Len(Trim(GenderTextBox.Text)) = 0 Then
            MessageBox.Show("Student Detail's Can't be null!! Please Search data then save data", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Stud_IdSearch.Focus()
            Exit Sub
        ElseIf Len(Trim(ClassTextBox.Text)) = 0 Then
            MessageBox.Show("Student Detail's Can't be null!! Please Search data then save data", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Stud_IdSearch.Focus()
            Exit Sub
        ElseIf Len(Trim(KannadaTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Kannada Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            KannadaTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(EnglishTextBox.Text)) = 0 Then
            MessageBox.Show("Enter English Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            EnglishTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(HindiTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Hindi Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            HindiTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(ScienceTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Mathematics Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ScienceTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(MathematicsTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Science Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            MathematicsTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(SocialTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Social Marks", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            SocialTextBox.Focus()
            Exit Sub
        End If
        Try
            conn.Open()
            sql = "INSERT INTO Marks VALUES('" & Student_IDTextBox.Text & "', '" & Full_NameTextBox.Text & "','" & ClassTextBox.Text & "','" & GenderTextBox.Text & "', '" & KannadaTextBox.Text & "','" & EnglishTextBox.Text & "','" & HindiTextBox.Text & "', '" & ScienceTextBox.Text & "','" & MathematicsTextBox.Text & "','" & SocialTextBox.Text & "', '" & TotalMarksTextBox.Text & "','" & PercentageTextBox.Text & "','" & GradeTextBox.Text & "','" & ResultTextBox.Text & "');"
            cmd.Connection = conn
            cmd.CommandText = Sql
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(Full_NameTextBox.Text + " Marks has been Saved Successfully!")
            Else
                MsgBox("No record has been Saved!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
        Student_IDTextBox.Clear()
        Full_NameTextBox.Clear()
        ClassTextBox.Clear()
        GenderTextBox.Clear()
        KannadaTextBox.Clear()
        EnglishTextBox.Clear()
        HindiTextBox.Clear()
        ScienceTextBox.Clear()
        SocialTextBox.Clear()
        MathematicsTextBox.Clear()
        TotalMarksTextBox.Clear()
        PercentageTextBox.Clear()
        ResultTextBox.Clear()
        GradeTextBox.Clear()
        Me.Refresh()
    End Sub

    Private Sub Marks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
        Stud_IdSearch.Focus()
    End Sub




    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SocialTextBox.KeyPress, ScienceTextBox.KeyPress, MathematicsTextBox.KeyPress, KannadaTextBox.KeyPress, HindiTextBox.KeyPress, EnglishTextBox.KeyPress
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim number As Integer

        If Not Integer.TryParse(textBox.Text & e.KeyChar, number) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' Show validation error
            MessageBox.Show("Validation Error: Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textBox.Focus()
            e.Handled = True ' Suppresses the key press event
        ElseIf number < 0 OrElse number > 100 Then
            ' Show validation error
            MessageBox.Show("Validation Error: Number must be between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textBox.Focus()
            e.Handled = True ' Suppresses the key press event
        End If
    End Sub
End Class