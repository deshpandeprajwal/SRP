Imports System.Data
Imports System.Data.OleDb

Public Class Form2
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0

    'SKN
    Sub loadform(ByVal PANEL As Form)
        Base_Body.Controls.Clear()
        PANEL.TopLevel = False
        Base_Body.Controls.Add(PANEL)
        PANEL.Show()
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadform(newreg)
        Try
            conn.Open()
            lbl_connection.Text = "Connected"
            lbl_connection.ForeColor = Color.DarkOliveGreen
        Catch ex As Exception
            lbl_connection.Text = "Dis-Connected"
            lbl_connection.ForeColor = Color.Red
        End Try
        conn.Close()
        ToolStripStatusLabel2.Text = Now
        Me.Refresh()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        Dim d As String
        d = MsgBox("Are you sure want to exit?", vbYesNo + vbQuestion)
        If d = vbYes Then
            Application.Restart()
        Else
            Exit Sub
        End If

    End Sub


    Private Sub AddStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentsToolStripMenuItem.Click
        newreg.Full_NameTextBox.Clear()
        newreg.GenderTextBox.Clear()
        newreg.PictureTextBox.Clear()
        newreg.First_NameTextBox.Clear()
        newreg.Last_NameTextBox.Clear()
        newreg.Mobile_NoTextBox.Clear()
        newreg.OccupationTextBox.Clear()
        newreg.Permanant_AddressTextBox.Clear()
        newreg.PictureBox1.Image = Nothing
        newreg.Refresh()
        loadform(newreg)
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordsToolStripMenuItem.Click
        searchrecords.Full_NameTextBox.Clear()
        searchrecords.Gender.Clear()
        searchrecords.Student_IDTextBox.Clear()
        searchrecords.PictureTextBox.Clear()
        searchrecords.First_NameTextBox.Clear()
        searchrecords.Last_NameTextBox.Clear()
        searchrecords.DOB.Clear()
        searchrecords.YOA.Clear()
        searchrecords.ClassTextBox.Clear()
        searchrecords.PictureBox1.Refresh()
        searchrecords.Mobile_NoTextBox.Clear()
        searchrecords.OccupationTextBox.Clear()
        searchrecords.Permanant_AddressTextBox.Clear()
        searchrecords.PictureBox1.Image = Nothing
        searchrecords.Refresh()
        loadform(searchrecords)
    End Sub

    Private Sub MarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksToolStripMenuItem.Click
        Marks.Student_IDTextBox.Clear()
        Marks.Full_NameTextBox.Clear()
        Marks.ClassTextBox.Clear()
        Marks.GenderTextBox.Clear()
        Marks.KannadaTextBox.Clear()
        Marks.EnglishTextBox.Clear()
        Marks.HindiTextBox.Clear()
        Marks.ScienceTextBox.Clear()
        Marks.SocialTextBox.Clear()
        Marks.MathematicsTextBox.Clear()
        Marks.TotalMarksTextBox.Clear()
        Marks.PercentageTextBox.Clear()
        Marks.ResultTextBox.Clear()
        Marks.GradeTextBox.Clear()
        Marks.Refresh()
        loadform(Marks)
    End Sub

    Private Sub ViewMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMarksToolStripMenuItem.Click
        ViewMarks.Student_IDTextBox.Clear()
        ViewMarks.Full_NameTextBox.Clear()
        ViewMarks.ClassTextBox.Clear()
        ViewMarks.GenderTextBox.Clear()
        ViewMarks.KannadaTextBox.Clear()
        ViewMarks.EnglishTextBox.Clear()
        ViewMarks.HindiTextBox.Clear()
        ViewMarks.ScienceTextBox.Clear()
        ViewMarks.SocialTextBox.Clear()
        ViewMarks.MathematicsTextBox.Clear()
        ViewMarks.TotalMarksTextBox.Clear()
        ViewMarks.PercentageTextBox.Clear()
        ViewMarks.ResultTextBox.Clear()
        ViewMarks.GradeTextBox.Clear()
        ViewMarks.Refresh()
        loadform(ViewMarks)
    End Sub

    Private Sub ViewStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentsToolStripMenuItem.Click
        ViewStudent.Refresh()
        loadform(ViewStudent)
    End Sub


    Private Sub Print_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_Report.Click
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
        PrintReport.ShowDialog()
        PrintReport.Refresh()

    End Sub
End Class