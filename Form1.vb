Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\SRP\SRP_Db.accdb")

    Public sql As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim rowindex As Integer = 0

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUserName.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lbl_connection.Text = "Connected"
            lbl_connection.ForeColor = Color.DarkOliveGreen
        Catch ex As Exception
            lbl_connection.Text = "Dis-Connected"
            lbl_connection.ForeColor = Color.Red
        End Try
        conn.Close()
        txtPassword.UseSystemPasswordChar = True
        txtUserName.Focus()
        Me.Refresh()

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            cmd = New OleDbCommand("SELECT * FROM Users WHERE UserName = '" & txtUserName.Text & "' AND Password = '" & txtPassword.Text & "' ", conn)
            Dim user As String = ""
            Dim pass As String = ""
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                user = sdr("UserName")
                pass = sdr("Password")
                Me.Hide()
                Form2.LblShowUsername.Text = txtUserName.Text
                txtUserName.Clear()
                txtPassword.Clear()
                Form2.Show()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Username or Password!", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            conn.Close()

        End Try
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If txtUserName.Text.Length >= 5 Then
            If txtPassword.Text.Length >= 5 Then
                If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
                    e.Handled = True
                    MessageBox.Show("Only Letters Accepted", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
