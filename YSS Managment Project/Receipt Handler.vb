Imports System.Data.OleDb
Public Class FormContributionReceipt
    Dim LastReceiptNo As Integer

    Dim chkTxtBoxes As Boolean = False


    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBoxMemberId.Leave

    End Sub

    Private Sub Receipt_Handler_Load(sender As Object, e As EventArgs)
        If TextBoxReceiptNo.Text = "LEAVED" Then

        End If
    End Sub


    Private Sub FormContributionReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim NewReceiptNo As Integer
        Dim sql As String
        Dim MaxRows As Integer
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet


        sql = "SELECT * FROM Contribution_Receipt_Record"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "RecNo")
        MaxRows = ds.Tables("RecNo").Rows.Count
        MaxRows = MaxRows - 1
        If MaxRows > -1 Then
            LastReceiptNo = ds.Tables("RecNo").Rows(MaxRows).Item(1)

            NewReceiptNo = LastReceiptNo + 1
            TextBoxReceiptNo.Text = NewReceiptNo
        Else

            TextBoxReceiptNo.Text = 1600001

        End If

        con.Close()

        TextBoxDate.Text = System.DateTime.Now


    End Sub



    Private Function chTxtBoxes()
        Dim t

        For Each t In Me.Controls
            If TypeOf t Is TextBox Then
                If t.text = "" Then
                    chkTxtBoxes = True


                    Exit For

                End If
                If t.text <> "" Then
                    chkTxtBoxes = False

                End If
            End If

        Next
        Return chkTxtBoxes
    End Function



    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click






        If chTxtBoxes() = True Then
            MsgBox("Please fill all details")
        End If
        If chTxtBoxes() = False Then

            Dim Rdate As String = System.DateTime.Now

            Dim cmd As New OleDbCommand("Insert Into Contribution_Receipt_Record([Receipt_No],[Member_Id],[First_Name],[Last_Name],[Amount],[Receipt_Date],[Sec/Ward],[House_No],[City],[PIN],[Tehsil],[District],[State],[Country],[Contact]) values(@RecNo,@memberid,@firstname,@lastname,@Amount,@Date,@ward,@houseno,@city,@pin,@teh,@dist,@state,@country,@contact)", con)
            cmd.Parameters.AddWithValue("@RecNo", TextBoxReceiptNo.Text)
            cmd.Parameters.AddWithValue("@memberid", TextBoxMemberId.Text)
            cmd.Parameters.AddWithValue("@firstname", TextBoxFirstName.Text)
            cmd.Parameters.AddWithValue("@lastname", TextBoxLastName.Text)
            cmd.Parameters.AddWithValue("@Amount", TextBoxAmount.Text)
            cmd.Parameters.AddWithValue("@Date", Rdate)
            cmd.Parameters.AddWithValue("@ward", TextBoxWard.Text)
            cmd.Parameters.AddWithValue("@houseno", TextBoxHouseNo.Text)
            cmd.Parameters.AddWithValue("@city", TextBoxCityOrVillage.Text)
            cmd.Parameters.AddWithValue("@pin", TextBoxPIN.Text)
            cmd.Parameters.AddWithValue("@teh", TextBoxTehsil.Text)
            cmd.Parameters.AddWithValue("@dist", TextBoxDistrict.Text)
            cmd.Parameters.AddWithValue("@state", TextBoxState.Text)
            cmd.Parameters.AddWithValue("@country", TextBoxCountry.Text)
            cmd.Parameters.AddWithValue("@contact", TextBoxContactNo.Text)


            con.Open()
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Saved")
                cmd.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "In expense Record")
            End Try

            con.Close()






            Dim cmdR As New OleDbCommand("Insert Into Balance_Sheet([Credit],[Date_Time]) values(@Amount,@Date)", con)

            cmdR.Parameters.AddWithValue("@Amount", TextBoxAmount.Text)
            cmdR.Parameters.AddWithValue("@Date", Rdate)

            Try
                con.Open()
                cmdR.ExecuteNonQuery()
                cmdR.Dispose()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "in balance sheet")
            End Try



            TextBoxMemberId.Clear()
            TextBoxFirstName.Clear()
            TextBoxLastName.Clear()
            TextBoxAmount.Clear()
            TextBoxWard.Clear()
            TextBoxHouseNo.Clear()
            TextBoxCityOrVillage.Clear()
            TextBoxPIN.Clear()
            TextBoxTehsil.Clear()
            TextBoxDistrict.Clear()
            TextBoxState.Clear()
            TextBoxCountry.Clear()
            TextBoxContactNo.Clear()

            TextBoxDate.Text = System.DateTime.Now


            Dim LRcpt As Integer
            LRcpt = TextBoxReceiptNo.Text
            TextBoxReceiptNo.Text = LRcpt + 1
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ContextMenuStrip1_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub FormContributionReceipt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CashierMainPage.Focus()
    End Sub
End Class