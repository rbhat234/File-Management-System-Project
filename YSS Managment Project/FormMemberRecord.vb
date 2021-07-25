Imports System.Data.OleDb
Public Class FormMemberRecord

    Private Sub FormMemberRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String

        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim conR As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\YSS Managment Project\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\YSS_Dtb.accdb")

        sql = "SELECT * FROM Members"
        da = New OleDb.OleDbDataAdapter(sql, conR)
        da.Fill(ds, "Members_Record")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class