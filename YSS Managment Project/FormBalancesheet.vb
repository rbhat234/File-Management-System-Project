Public Class FormBalancesheet

    Private Sub FormBalancesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sql As String

        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet


        Sql = "SELECT * FROM Balance_Sheet"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Expense_Record")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class