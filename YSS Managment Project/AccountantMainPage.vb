Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class AccountantMainPage

    Dim sql As String
    Dim i, j As Integer
    Dim misValue As Object = System.Reflection.Missing.Value

    Dim MyPassword As String = "password"
    'DEFINING CLASS OBJECTS
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Dim f1name As String = "Balance_Sheet "
    Dim fdate As String = System.DateTime.Now.Day & "-" & System.DateTime.Now.Month & "-" & System.DateTime.Now.Year & "  " & System.DateTime.Now.Hour & " hr " & System.DateTime.Now.Minute & " min"
    Dim file1name As String = f1name & fdate


    Private Sub ViewBalanceSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBalanceSheetToolStripMenuItem.Click
        FormBalancesheet.Show()
    End Sub

    Private Sub ContributionRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContributionRecordToolStripMenuItem.Click
        FormContributionRecord.Show()
    End Sub

    Private Sub ExpenseRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseRecordToolStripMenuItem.Click
        FormExpenseRecord.Show()
    End Sub

    Private Sub ExportBalanceSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportBalanceSheetToolStripMenuItem.Click
        If My.Computer.FileSystem.FileExists("F:\YSS Managment Project\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\Exports\" & file1name & ".xlsx") Then
            Dim result As Integer = MessageBox.Show("Do you want to Replace Existing File", "File Already Exists", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then


            ElseIf result = DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile("F:\YSS Managment Project\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\Exports\" & file1name & ".xlsx")

                Try
                    LoadingDataSet()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Try
                    SavingWorksheet(file1name)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If


        ElseIf My.Computer.FileSystem.FileExists("F:\YSS Managment Project\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\Exports\" & file1name & ".xlsx") = False Then

            Try
                LoadingDataSet()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Try
                SavingWorksheet(file1name)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub




    Private Sub SavingWorksheet(ByVal filename As String)

        xlWorkSheet = xlWorkBook.Sheets("Sheet1")
        xlWorkSheet.Protect(MyPassword, DrawingObjects:=True, Contents:=True, Scenarios:=True, _
                            AllowFormattingCells:=False, AllowFormattingColumns:=True, AllowDeletingRows:=False, _
                            AllowInsertingColumns:=False, AllowInsertingHyperlinks:=False, AllowDeletingColumns:=False, _
                            AllowSorting:=False, AllowFiltering:=True, AllowUsingPivotTables:=False, AllowInsertingRows:=False, AllowFormattingRows:=False)
        xlWorkSheet.SaveAs("F:\YSS Managment Project\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\Exports\" & filename & ".xlsx", FileFormat:=51, Password:=MyPassword, ReadOnlyRecommended:=False, CreateBackup:=False, WriteResPassword:="write")

        xlWorkBook.Close()

        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)


        Label1.Text = "Records Saved"
        MessageBox.Show("Location=F:\YSS Managment Project\YSS MANAGEMENT PROJECT\YSS Managment Project\bin\Exports\" & filename & ".xlsx", "Export Finished")
    End Sub


    Private Sub LoadingDataSet()
        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        sql = "SELECT * FROM [Balance_Sheet]"
        Dim dscmd As New OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        dscmd.Fill(ds)

        Label1.Visible = True
        Label2.Visible = True
        Dim int As Integer = 0
        For Me.i = 0 To ds.Tables(0).Rows.Count - 1

            Label2.Update()
            int = int + 1
            Label2.Text = int
            For Me.j = 0 To ds.Tables(0).Columns.Count - 1
                xlWorkSheet.Cells(i + 1, j + 1) = _
                ds.Tables(0).Rows(i).Item(j)

            Next
        Next
        Label1.ForeColor = Color.Green
        Label2.ForeColor = Color.Green
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub AccountantMainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub AccountantMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EventRefresh()
    End Sub
    Sub EventRefresh()

        Dim tmp As String
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
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
End Class