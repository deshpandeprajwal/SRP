Imports System.Data
Imports System.Data.OleDb

Public Class ViewMarks

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0



    Private Sub ViewMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SRP_DbDataSet.Marks' table. You can move, or remove it, as needed.
        Stud_IdSearch.Focus()
        Me.Refresh()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Stud_IdSearch.Clear()
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



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Len(Trim(Stud_IdSearch.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Stud_IdSearch.Focus()
            Exit Sub
        End If
        Try

            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Class,Gender,Kannada,English,Hindi,Mathematics,Science,Social,Total,Percentage,Grade,Result from Marks where Student_ID='" + Stud_IdSearch.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Student_IDTextBox.Text = myreader("Student_ID")
            Full_NameTextBox.Text = myreader("Full_Name")
            ClassTextBox.Text = myreader("Class")
            GenderTextBox.Text = myreader("Gender")
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

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintReport.Student_IDTextBox.Clear()
        PrintReport.Full_NameTextBox.Clear()
        PrintReport.ClassTextBox.Clear()
        PrintReport.GenderTextBox.Clear()
        PrintReport.KannadaTextBox.Clear()
        PrintReport.EnglishTextBox.Clear()
        PrintReport.HindiTextBox.Clear()
        PrintReport.ScienceTextBox.Clear()
        PrintReport.SocialTextBox.Clear()
        PrintReport.MathematicsTextBox.Clear()
        PrintReport.TotalTextBox.Clear()

        Stud_IdSearch.Clear()
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
        PrintReport.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Stud_IdSearch.Clear()
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

        EditMarks.Full_Name.Clear()
        EditMarks.Student_ID.Clear()
        EditMarks.KannadaTextBox.Clear()
        EditMarks.EnglishTextBox.Clear()
        EditMarks.HindiTextBox.Clear()
        EditMarks.ScienceTextBox.Clear()
        EditMarks.SocialTextBox.Clear()
        EditMarks.MathematicsTextBox.Clear()
        EditMarks.TotalMarksTextBox.Clear()
        EditMarks.PercentageTextBox.Clear()
        EditMarks.ResultTextBox.Clear()
        EditMarks.GradeTextBox.Clear()
        EditMarks.ShowDialog()
    End Sub
End Class