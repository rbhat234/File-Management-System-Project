Imports System.Data.OleDb
Imports System.DateTime
Public Class FormExpensesReceipt
    Dim LastReceiptNo As Integer
    Dim NewReceiptNo As Integer

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        CashierMainPage.Show()
    End Sub

    Private Sub FormExpensesReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDate.Text = System.DateTime.Now

        Dim sql As String
        Dim MaxRows As Integer
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet


        sql = "SELECT * FROM Expense_Receipt_Record"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "RecNo")
        MaxRows = ds.Tables("RecNo").Rows.Count
        MaxRows = MaxRows - 1
        If MaxRows > -1 Then
            LastReceiptNo = ds.Tables("RecNo").Rows(MaxRows).Item(1)

            NewReceiptNo = LastReceiptNo + 1
            TextBoxReceiptNo.Text = NewReceiptNo
        Else

            TextBoxReceiptNo.Text = 1500001

        End If

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TextBoxReceiptNo.Text = "" Or
        TextBoxExpenseFor.Text = "" Or
        TextBoxDescription.Text = "" Or
        TextBoxDate.Text = "" Or
        TextBoxMemberId.Text = "" Then
            MessageBox.Show("Can't Leave TextBoxes Empty")
        End If

        Dim Rdate As String = System.DateTime.Now

        Dim cmd As New OleDbCommand("Insert Into Expense_Receipt_Record([Receipt_No],[Amount],[Receipt_Date],[Purpose],[Receiptent_Id],[Description]) values(@RecNo,@Amount,@Date,@purpose,@Receiptent,@Desc)", con)
        cmd.Parameters.AddWithValue("@RecNo", TextBoxReceiptNo.Text)
        cmd.Parameters.AddWithValue("@Amount", TextBoxAmount.Text)
        cmd.Parameters.AddWithValue("@Date", Rdate)
        cmd.Parameters.AddWithValue("@Purpose", TextBoxExpenseFor.Text)
        cmd.Parameters.AddWithValue("@Receiptent", TextBoxMemberId.Text)
        cmd.Parameters.AddWithValue("@Desc", TextBoxDescription.Text)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Saved")
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try





        Dim cmdR As New OleDbCommand("Insert Into Balance_Sheet([Debit],[Date_Time]) values(@Amount,@Date)", con)

        cmdR.Parameters.AddWithValue("@Amount", TextBoxAmount.Text)
        cmdR.Parameters.AddWithValue("@Date", Rdate)

        Try
            con.Open()
            cmdR.ExecuteNonQuery()
            cmdR.Dispose()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        TextBoxAmount.Clear()
        TextBoxExpenseFor.Clear()
        TextBoxDescription.Clear()
        TextBoxDate.Clear()
        TextBoxMemberId.Clear()

        Dim LRcpt As Integer

        LRcpt = TextBoxReceiptNo.Text
        TextBoxReceiptNo.Text = LRcpt + 1
    End Sub

    Private Sub FormExpensesReceipt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CashierMainPage.Focus()
    End Sub
End Class