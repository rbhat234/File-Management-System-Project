Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Imports System.DateTime
Public Class FormAddEvent
    Dim str As String
    Dim cmd As OleDbCommand
    Dim item As String = "0"
    Private Sub AddEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EventRefresh()
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        If TextBox1.Text = "" Or RichTextBox1.Text = "" Then
            MessageBox.Show("Please Choose some Date and give Note")
        Else

            str = "insert into Feel ([Date], [Note], [EventStatus]) values (?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, con)
            cmd.Parameters.Add(New OleDbParameter("Date", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Note", CType(RichTextBox1.Text, String)))
            If TextBox1.Text >= Now.Date Then
                cmd.Parameters.Add(New OleDbParameter("EventStatus", ("T")))
            Else
                cmd.Parameters.Add(New OleDbParameter("EventStatus", ("F")))
            End If

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                RichTextBox1.Clear()
                TextBox1.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ListBox1.Items.Clear()
            EventRefresh()
            item = "0"
        End If
    End Sub

    

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        item = ListBox1.Text
        item = item.Substring(0, 12)


    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If item = "0" Then
            MessageBox.Show("Please Select Some Event From ListBox")
        ElseIf item <> "0" Then
            Try

                Dim q As String
                q = "Delete  from feel where [Date] =  #" & item & "#"

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
            EventRefresh()
        End If

    End Sub

    Sub EventRefresh()
        'LOADING CALENDER
        Dim tmp As String
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim command As New OleDbCommand("SELECT Date, Note FROM Feel where EventStatus ='T' order by Date ", con)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        ListBox1.Items.Clear()
        Do While (reader.Read())
            ListBox1.BeginUpdate()
            tmp = reader.Item("Date") & "   " & reader.Item("Note")
            If reader.Item("Date") >= Now.Date Then
                ListBox1.Items.Add(tmp)
                
            End If
            ListBox1.EndUpdate()
        Loop
        reader.Close()
        con.Close()
        Form1.ListBox1.Items.Clear()
        AdminMainPage.ListBox1.Items.Clear()
        AdminMainPage.EventRefresh()
        Form1.EventRefresh()
    End Sub
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Me.TextBox1.Text = (e.Start.ToShortDateString())
    End Sub

   
   
End Class





















