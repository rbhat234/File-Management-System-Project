Imports System.Data.OleDb
Imports System.DateTime
Public Class Form1
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreen.Hide()



        'LOADING CALENDER
        ' Dim tmp As String
        'con.Open()
        'Dim command As New OleDbCommand("SELECT Date, Note FROM Feel where EventStatus ='T' order by Date ", con)
        'Dim reader As OleDbDataReader = command.ExecuteReader()

        'Do While (reader.Read())
        'ListBox1.BeginUpdate()
        'tmp = reader.Item("Date") & "   " & reader.Item("Note")
        'If reader.Item("Date") >= Now.Date Then
        'ListBox1.Items.Add(tmp)
        'ElseIf reader.Item("Date") < Now.Date Then
        'End If
        'ListBox1.EndUpdate()
        'Loop
        'reader.Close()
        'con.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
        MonthCalendar1.BackColor = Color.Aqua
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        usrint = 2
        LoginForm.Focus()
        LoginForm.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        usrint = 1
        LoginForm.Focus()
        LoginForm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        About.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Help.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        usrint = 1
        LoginForm.Show()
        LoginForm.Focus()
    End Sub

    

   
    Sub EventRefresh()
        'LOADING CALENDER
        Dim tmp As String
        con.Open()
        Dim command As New OleDbCommand("SELECT Date, Note FROM Feel where EventStatus ='T' order by Date ", con)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Do While (reader.Read())
            ListBox1.BeginUpdate()
            tmp = reader.Item("Date") & "   " & reader.Item("Note")
            If reader.Item("Date") >= Now.Date Then
                ListBox1.Items.Add(tmp)
            ElseIf reader.Item("Date") < Now.Date Then

            End If
            ListBox1.EndUpdate()
        Loop
        reader.Close()
        con.Close()
        
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SplashScreen.Close()
    End Sub

   
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class


Module GlobalVar
    Public usrint As Integer
    Public p As Integer
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data source=YSS_Dtb.accdb")


End Module

