Imports System.Data.OleDb
Public Class SignUpForm
    Dim chkBox As Boolean = False
    Dim chkTxtBoxes As Boolean = False
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usrint = 0 Then

            Me.Text = "Administrator SIgnUp"
        ElseIf usrint = 1 Then
            Me.Text = "Accountant SignUp"
        ElseIf usrint = 2 Then
            Me.Text = "Cashier SignUp"
        End If
    End Sub



    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click




        If chTxtBoxes() = True Or chCheckBoxes() = True Then
            MsgBox("Please fill all details")
            BtnSubmit.Enabled = False
        Else
            BtnSubmit.Enabled = True
        End If

        If chTxtBoxes() = False And chCheckBoxes() = False And TextBoxeEnterPassword.Text <> TextBoxReEnterPassword.Text Then
            MessageBox.Show("Password don't Matches")
        Else

            Dim str As String
            str = "insert into Admin_Signup ([Signup As],[First Name], [Last Name], [Enter ID], [Enter Password], [Secret Question], [Secret Answer]) values (?, ?, ?, ?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, con)
            cmd.Parameters.Add(New OleDbParameter("Signup As", CType(ComboBoxSignupAs.SelectedItem, String)))
            cmd.Parameters.Add(New OleDbParameter("First Name", CType(TextBoxFrstName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Last Name", CType(TextBoxLstName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Enter ID", CType(TextBoxID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Enter Password", CType(TextBoxeEnterPassword.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Secret Question", CType(ComboBoxSecQues.SelectedIndex, String)))
            cmd.Parameters.Add(New OleDbParameter("Secret Answer", CType(TextBoxSecAns.Text, String)))

            If con.State = ConnectionState.Open Then
                con.Close()
            Else
                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    TextBoxFrstName.Clear()
                    TextBoxLstName.Clear()
                    TextBoxID.Clear()
                    TextBoxeEnterPassword.Clear()
                    TextBoxReEnterPassword.Clear()

                    MsgBox("Welcome  Admin.")
                    LoginForm.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                
            End If
        End If
    End Sub
    Private Function chCheckBoxes()
        Dim Cb

        For Each Cb In Me.Controls
            If TypeOf Cb Is ComboBox Then
                If Cb.text = "" Then

                    chkBox = True



                    Exit For
                End If
                If Cb.TEXT <> "" Then
                    chkBox = False


                End If
            End If
        Next
        Return chkBox
    End Function


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

    Private Sub TextBoxReEnterPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxReEnterPassword.Leave
        If TextBoxeEnterPassword.Text <> TextBoxReEnterPassword.Text Then
            LblPasswrdNotMatch.Visible = True
        ElseIf TextBoxeEnterPassword.Text = TextBoxReEnterPassword.Text Then
            LblPasswrdNotMatch.Visible = False
        End If
    End Sub

    Private Sub TextBoxID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged

    End Sub

    Private Sub SignUpForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Focus()
    End Sub
End Class