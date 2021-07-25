Imports System.Data.OleDb
Public Class FormAddMember
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Dim chkTxtBoxes As Boolean = False


    Dim picloc As String
    Dim stu As String
    Dim pic As String = ""



    Dim lastRid As String
    Dim NewReceiptNo As Integer
    Dim sql As String
    Dim MaxRows As Integer
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim conR As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=ash.mdb")


    Private Sub FormAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.loginee



        sql = "SELECT * FROM Members"
        da = New OleDb.OleDbDataAdapter(sql, conR)
        da.Fill(ds, "Member")
        MaxRows = ds.Tables("Member").Rows.Count
        MaxRows = MaxRows - 1
        If MaxRows > -1 Then
            lastRid = ds.Tables("Member").Rows(MaxRows).Item(1)

            NewReceiptNo = lastRid + 1
            TextBoxRegistrationID.Text = NewReceiptNo
        Else

            TextBoxRegistrationID.Text = 1600001

        End If

        conR.Close()
        MRId = TextBoxRegistrationID.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If chTxtBoxes() = True Then
            MsgBox("Please fill all details")
        ElseIf chTxtBoxes() = False Then
            Try
                Insert_Value()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
        End If





    End Sub

    Private Sub TextBoxRegistrationID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRegistrationID.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBoxPWard.Text = TextBoxWard.Text
            TextBoxPHouse.Text = TextBoxHouseNo.Text
            TextBoxPCity.Text = TextBoxCity.Text
            TextBoxPDistrict.Text = TextBoxDistrict.Text
            TextBoxPPostOffice.Text = TextBoxPostOffice.Text
            TextBoxPPIN.Text = TextBoxPIN.Text
            TextBoxPTehsil.Text = TextBoxTehsil.Text
            TextBoxPState.Text = TextBoxState.Text
            TextBoxPCountry.Text = TextBoxCountry.Text
        Else
            TextBoxPWard.Clear()
            TextBoxPHouse.Clear()
            TextBoxPCity.Clear()
            TextBoxPDistrict.Clear()
            TextBoxPPostOffice.Clear()
            TextBoxPPIN.Clear()
            TextBoxPTehsil.Clear()
            TextBoxPState.Clear()
            TextBoxPCountry.Clear()
        End If
    End Sub

    

    Private Sub Insert_Value()

        Dim tmpfolder As String = "C:\Users\ash bhat\Desktop\YSS Mgt\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\Images\"

        Dim fext As String
        fext = picloc.Substring(picloc.LastIndexOf(CChar(".")))
        MsgBox(fext)
        pic = Now().GetHashCode() & fext           

        tmpfolder = tmpfolder & pic
        MsgBox(tmpfolder)
        PictureBox1.Image.Save(tmpfolder)

        

        Dim str As String
        str = "insert into Members ([Member_Registration_ID],[First_Name], [Middle_Name], [Last_Name], [Date_Of_Birth], [Parentage], [Current_Ward/Sector], [Permanent_Ward/Sector], [Current_House_No], [Permanent_House_No], [Current_Village/City], [Permanent_Village/City], [Current_Post_Offices], [Permanent_Post_Office], [Current_Pin_Codes], [Permanent_Pin_Code], [Current_Tehsils], [Permanent_Tehsil], [Current_Districts], [Permanent_District], [Current_States], [Permanent_State], [Current_Countrys], [Permanent_Country], [Pic]) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, conR)
        cmd.Parameters.Add(New OleDbParameter("Member_Registration_ID", CType(TextBoxRegistrationID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("First_Name", CType(TextBoxFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Middle_Name", CType(TextBoxMiddleName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Last_Name", CType(TextBoxLastName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date_Of_Birth", CType(DateTimePicker1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Parentage", CType(TextBoxParentage.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_Ward/Sector", CType(TextBoxWard.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_Ward/Sector", CType(TextBoxPWard.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_House_No", CType(TextBoxHouseNo.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_House_No", CType(TextBoxPHouse.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_Village/City", CType(TextBoxCity.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_Village/City", CType(TextBoxPCity.Text, String)))


        cmd.Parameters.Add(New OleDbParameter("Current_Post_Offices", CType(TextBoxPostOffice.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_Post_Offices", CType(TextBoxPPostOffice.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_Pin_Codes", CType(TextBoxPIN.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_Pin_Code", CType(TextBoxPPIN.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_Teshils", CType(TextBoxTehsil.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_Teshil", CType(TextBoxPTehsil.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_Districts", CType(TextBoxDistrict.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_District", CType(TextBoxPDistrict.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_State", CType(TextBoxState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_State", CType(TextBoxPState.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("Current_Country", CType(TextBoxCountry.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Permanent_Country", CType(TextBoxPCountry.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Pic", pic))

        Try

            conR.Open()

            cmd.ExecuteNonQuery()

           

            cmd.Dispose()
            conR.Close()
            TextBoxRegistrationID.Clear()
            TextBoxFirstName.Clear()
            TextBoxMiddleName.Clear()
            TextBoxLastName.Clear()
            TextBoxParentage.Clear()
            TextBoxWard.Clear()
            TextBoxHouseNo.Clear()
            TextBoxCity.Clear()
            TextBoxDistrict.Clear()
            TextBoxPostOffice.Clear()
            TextBoxPIN.Clear()
            TextBoxTehsil.Clear()
            TextBoxState.Clear()
            TextBoxCountry.Clear()
            TextBoxPWard.Clear()
            TextBoxPHouse.Clear()
            TextBoxPCity.Clear()
            TextBoxPDistrict.Clear()
            TextBoxPPostOffice.Clear()
            TextBoxPPIN.Clear()
            TextBoxPTehsil.Clear()
            TextBoxPState.Clear()
            TextBoxPCountry.Clear()

            FormAddMemberQualification.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        OpenFileDialog1.ShowDialog()
        picloc = OpenFileDialog1.FileName()

        PictureBox1.ImageLocation = picloc


    End Sub

   
End Class
Module RegistrationId
    Public MRId As Integer
End Module