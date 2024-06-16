Imports System.Data
Imports System.Data.OleDb

Public Class searchrecords
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Stud_IdSearch.Clear()
        Full_NameTextBox.Clear()
        Gender.Clear()
        Student_IDTextBox.Clear()
        PictureTextBox.Clear()
        First_NameTextBox.Clear()
        Last_NameTextBox.Clear()
        DOB.Clear()
        YOA.Clear()
        ClassTextBox.Clear()
        PictureBox1.Refresh()
        Mobile_NoTextBox.Clear()
        OccupationTextBox.Clear()
        Permanant_AddressTextBox.Clear()
        PictureBox1.Image = Nothing
    End Sub


    Private Sub searchrecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
        Stud_IdSearch.Focus()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Len(Trim(Stud_IdSearch.Text)) = 0 Then
            MessageBox.Show("Enter Student ID to Search Records", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try

            conn.Open()
            Dim sql As String
            sql = "Select Student_ID,Full_Name,Class,Gender,DOB,YOA,Picture,First_Name,Last_Name,Occupation,Mobile_No,Permanant_Address from StudentInfo where Student_ID='" + Stud_IdSearch.Text + "'"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Student_IDTextBox.Text = myreader("Student_ID")
            Full_NameTextBox.Text = myreader("Full_Name")
            ClassTextBox.Text = myreader("Class")
            Gender.Text = myreader("Gender")
            DOB.Text = myreader("DOB")
            YOA.Text = myreader("YOA")
            PictureTextBox.Text = myreader("Picture")
            First_NameTextBox.Text = myreader("First_Name")
            Last_NameTextBox.Text = myreader("Last_Name")
            OccupationTextBox.Text = myreader("Occupation")
            Mobile_NoTextBox.Text = myreader("Mobile_No")
            Permanant_AddressTextBox.Text = myreader("Permanant_Address")
            PictureBox1.Refresh()
            PictureBox1.ImageLocation = PictureTextBox.Text
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Enter a valid Student ID to Search Records!!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Stud_IdSearch.Clear()
        Full_NameTextBox.Clear()
        Gender.Clear()
        Student_IDTextBox.Clear()
        PictureTextBox.Clear()
        First_NameTextBox.Clear()
        Last_NameTextBox.Clear()
        DOB.Clear()
        YOA.Clear()
        ClassTextBox.Clear()
        PictureBox1.Refresh()
        Mobile_NoTextBox.Clear()
        OccupationTextBox.Clear()
        Permanant_AddressTextBox.Clear()
        PictureBox1.Image = Nothing
        UpdateStudent.ShowDialog()
    End Sub
End Class