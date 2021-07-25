Imports System.Data.OleDb
Public Class LoginForm


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Admin_Signup] WHERE [Enter ID] = '" & UsernameTextBox.Text & "' AND [Enter Password] = '" & PasswordTextBox.Text & "'", con)
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        Dim userFound As Boolean = False

        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim SignupAs As String = ""
        

        While (dr.Read())
            userFound = True
            FirstName = dr("First Name").ToString
            LastName = dr("Last Name").ToString
            SignupAs = dr("Signup As").ToString
        End While        'checking the result

        If userFound = True Then

            If SignupAs.Equals("Admin") Then
                AdminMainPage.Show()
                AdminMainPage.Label1.Text = "Welcome " & FirstName & " " & LastName
                Me.Close()

            ElseIf SignupAs.Equals("Accountant") Then
                AccountantMainPage.Show()
                AccountantMainPage.Label1.Text = "Welcome " & FirstName & " " & LastName
                Me.Close()

            ElseIf SignupAs.Equals("Cashier") Then
                CashierMainPage.Show()
                CashierMainPage.Label1.Text = "Welcome " & FirstName & " " & LastName
                Me.Close()
            Else
                MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
            End If
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
        dr.Close()
        con.Close()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ForgotPassword.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        SignUpForm.Show()
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usrint = 0 Then

            Me.Text = "Administrator Login"
        ElseIf usrint = 1 Then
            Me.Text = "Accountant Login"
        ElseIf usrint = 2 Then
            Me.Text = "Cashier Login"
        End If
    End Sub
End Class
