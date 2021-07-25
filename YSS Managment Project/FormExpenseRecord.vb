
Public Class FormExpenseRecord

    Private Sub FormExpenseRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim Sql As String

        Sql = "SELECT * FROM Expense_Receipt_Record"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Expense_Record")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class