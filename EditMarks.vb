Imports System.Data
Imports System.Data.OleDb

Public Class EditMarks

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0

    Private Sub EditMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Student_ID.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Len(Trim(Student_ID.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Student_ID.Focus()
            Exit Sub
        End If
        Try

            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Kannada,English,Hindi,Mathematics,Science,Social,Total,Percentage,Grade,Result from Marks where Student_ID='" + Student_ID.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Student_ID.Text = myreader("Student_ID")
            Full_Name.Text = myreader("Full_Name")
            KannadaTextBox.Text = myreader("Kannada")
            EnglishTextBox.Text = myreader("English")
            HindiTextBox.Text = myreader("Hindi")
            MathematicsTextBox.Text = myreader("Mathematics")
            ScienceTextBox.Text = myreader("Science")
            SocialTextBox.Text = myreader("Social")
            TotalMarksTextBox.Text = myreader("Total")
            PercentageTextBox.Text = myreader("Percentage")
            GradeTextBox.Text = myreader("Grade")
            ResultTextBox.Text = myreader("Result")
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


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(Student_ID.Text)) = 0 Then
            MessageBox.Show("Student Detail's Can't be null!! Please Search data then save data", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Full_Name.Focus()
            Exit Sub
        ElseIf Len(Trim(Full_Name.Text)) = 0 Then
            MessageBox.Show("Student Detail's Can't be null!! Please Search data then save data", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Full_Name.Focus()
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
            sql = "UPDATE Marks SET Kannada='" & KannadaTextBox.Text & "', English='" & EnglishTextBox.Text & "', Hindi='" & HindiTextBox.Text & "', Mathematics='" & MathematicsTextBox.Text & "', Science='" & ScienceTextBox.Text & "', Social='" & SocialTextBox.Text & "', Total='" & TotalMarksTextBox.Text & "', Percentage='" & PercentageTextBox.Text & "', Grade='" & GradeTextBox.Text & "', Result='" & ResultTextBox.Text & "' WHERE Student_ID='" + Student_ID.Text + "'"
            cmd.Connection = conn
            cmd.CommandText = sql
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(Full_Name.Text + " has been Updated successfully!")
                conn.Close()
                Me.Hide()
            Else
                MsgBox("No record has been UPDATED!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
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