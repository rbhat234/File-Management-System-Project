Public Class ViewEvents
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub ViewEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldatagrid()
    End Sub
    Private Sub filldatagrid()
        sql = "SELECT [Date],[Note] FROM Feel"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Feel")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class