Public Class ViewStudent
    Sub loaddata()
        Me.StudentInfoTableAdapter.Fill(Me.SRP_DbDataSet.StudentInfo)
    End Sub


    Private Sub ViewStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SRP_DbDataSet.StudentInfo' table. You can move, or remove it, as needed.

        loaddata()
        Me.Refresh()
    End Sub
End Class