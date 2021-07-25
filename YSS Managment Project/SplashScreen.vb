Public Class SplashScreen
    Dim sec As Integer
    Dim i As Decimal

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 800
        Timer1.Start()
        i = 0



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
       
        If sec = 3 Then

            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
        End If

        sec = sec + 1
        'i = sec / 2
        If sec = 8 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
            Form1.Focus()

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class