Imports System.Data.OleDb
Public Class Viewmember
    Private RowIndex As Integer = 0
    Dim member As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = YSS_Dtb.accdb")

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        member = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        MsgBox(member)
    End Sub



    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        
    End Sub

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        Try
            
            Dim cmd As New OleDbCommand("Delete From Members Where Member_Registration_ID =" & member & "", con)

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.ExecuteNonQuery()
            
            Dim i As Integer
            For i = 0 To DataGridView1.Columns.Count - 1
                DataGridView1.Columns.Remove(DataGridView1.Columns(0).Name)
            Next


            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("your records are successfully deleted", MsgBoxStyle.Information)
            End If
            con.Close()
            DataGridView1.Columns.Clear()
            filldatagrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormViewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        '
        filldatagrid()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim q As String
            q = "Delete  from Members where Member_Registration_ID = '" & member & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(q, con)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.ExecuteNonQuery()
            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("your records are successfully deleted", MsgBoxStyle.Information)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        DataGridView1.Refresh()
    End Sub
    Private Sub filldatagrid()
        sql = "SELECT [Member_Registration_ID],[First_Name],[Last_Name],[Date_Of_Birth],[Parentage],[Current_Ward/Sector],[Current_House_No],[Current_Village/City],[Current_Post_Offices],[Current_Pin_Codes],[Current_Tehsils],[Current_Districts],[Current_States],[Current_Countrys],[Qualification],[Occupation],[Job_Type],[Department],[Designation]  FROM Members"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Members_Record")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filldatagrid()
    End Sub
End Class


