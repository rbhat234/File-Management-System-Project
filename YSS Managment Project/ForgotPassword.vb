Imports System.Data.OleDb

Public Class ForgotPassword
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Admin_Signup] WHERE [Enter ID] = '" & TextBox1.Text & "' AND [Secret Answer] = '" & TextBox2.Text & "' ", con)
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        Dim userFound As Boolean = False

        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim Password As String = ""

        While (dr.Read())
            userFound = True
            FirstName = dr("First Name").ToString
            LastName = dr("Last Name").ToString
            Password = dr("Enter Password").ToString

        End While

        If userFound = True Then
            Recover_Password.Show()
            Recover_Password.Label1.Text = "Welcome In Password Recovery."
            Recover_Password.Label2.Text = "Your Name => " & FirstName & " " & LastName
            Recover_Password.Label3.Text = "Your Password => " & Password
        Else
            MsgBox("Sorry, ID or Secret Question or Secret Answer not found", MsgBoxStyle.OkOnly, "Invalid Login")

        End If
        dr.Close()
        con.Close()
        Me.Close()
    End Sub

 
End Class