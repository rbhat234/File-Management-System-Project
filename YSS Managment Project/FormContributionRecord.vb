Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class FormContributionRecord

    Private Sub FormContributionRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As String

        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet


        sql = "SELECT * FROM Contribution_Receipt_Record"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Contribution_Record")
        DataGridView1.DataSource = ds.Tables(0)

        
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class