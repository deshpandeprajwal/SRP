Imports System.Data
Imports System.Data.OleDb

Public Class PrintReport

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0

    Private Sub PrintReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        btnSearch.Show()
        btnPrint.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Len(Trim(Student_IDTextBox.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Student_IDTextBox.Focus()
            Exit Sub
        End If
        Try

            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Class,Gender,Kannada,English,Hindi,Mathematics,Science,Social,Total,Percentage,Grade,Result from Marks where Student_ID='" + Student_IDTextBox.Text + "'"
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
            TotalTextBox.Text = myreader("Total")
            PercentTextBox.Text = myreader("Percentage")
            GradeTextBox.Text = myreader("Grade")
            ResultTextBox.Text = myreader("Result")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Enter a valid Student ID to Search Records!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        btnPrint.Hide()
        btnSearch.Hide()
        Timer1.Interval = 3000
        Timer1.Start()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.Print()
        Me.Close()
    End Sub

End Class