<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCncl = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.ComboBoxSecQues = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSecAns = New System.Windows.Forms.TextBox()
        Me.TextBoxReEnterPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxeEnterPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxSignupAs = New System.Windows.Forms.ComboBox()
        Me.LblPasswrdNotMatch = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxLstName = New System.Windows.Forms.TextBox()
        Me.TextBoxFrstName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(332, 26)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "SignUp For YSS Management"
        '
        'BtnCncl
        '
        Me.BtnCncl.Location = New System.Drawing.Point(305, 372)
        Me.BtnCncl.Name = "BtnCncl"
        Me.BtnCncl.Size = New System.Drawing.Size(75, 23)
        Me.BtnCncl.TabIndex = 7
        Me.BtnCncl.Text = "Cancel"
        Me.BtnCncl.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(196, 372)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 6
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'ComboBoxSecQues
        '
        Me.ComboBoxSecQues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSecQues.FormattingEnabled = True
        Me.ComboBoxSecQues.ItemHeight = 13
        Me.ComboBoxSecQues.Items.AddRange(New Object() {"Where was Your Mother Born?", "Who was / is your Favourite Teacher?", "What's your favourite fruit?"})
        Me.ComboBoxSecQues.Location = New System.Drawing.Point(196, 264)
        Me.ComboBoxSecQues.Name = "ComboBoxSecQues"
        Me.ComboBoxSecQues.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxSecQues.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Secret Answer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Secret Question"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Re-enter Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Enter ID"
        '
        'TextBoxSecAns
        '
        Me.TextBoxSecAns.Location = New System.Drawing.Point(196, 297)
        Me.TextBoxSecAns.Name = "TextBoxSecAns"
        Me.TextBoxSecAns.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxSecAns.TabIndex = 4
        '
        'TextBoxReEnterPassword
        '
        Me.TextBoxReEnterPassword.Location = New System.Drawing.Point(196, 221)
        Me.TextBoxReEnterPassword.MaxLength = 15
        Me.TextBoxReEnterPassword.Name = "TextBoxReEnterPassword"
        Me.TextBoxReEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxReEnterPassword.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxReEnterPassword.TabIndex = 2
        '
        'TextBoxeEnterPassword
        '
        Me.TextBoxeEnterPassword.Location = New System.Drawing.Point(196, 178)
        Me.TextBoxeEnterPassword.MaxLength = 15
        Me.TextBoxeEnterPassword.Name = "TextBoxeEnterPassword"
        Me.TextBoxeEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxeEnterPassword.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxeEnterPassword.TabIndex = 1
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(196, 68)
        Me.TextBoxID.MaxLength = 15
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxID.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "SignUp As"
        '
        'ComboBoxSignupAs
        '
        Me.ComboBoxSignupAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSignupAs.FormattingEnabled = True
        Me.ComboBoxSignupAs.ItemHeight = 13
        Me.ComboBoxSignupAs.Items.AddRange(New Object() {"Admin", "Accountant", "Cashier"})
        Me.ComboBoxSignupAs.Location = New System.Drawing.Point(196, 337)
        Me.ComboBoxSignupAs.Name = "ComboBoxSignupAs"
        Me.ComboBoxSignupAs.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxSignupAs.TabIndex = 30
        '
        'LblPasswrdNotMatch
        '
        Me.LblPasswrdNotMatch.AutoSize = True
        Me.LblPasswrdNotMatch.ForeColor = System.Drawing.Color.Red
        Me.LblPasswrdNotMatch.Location = New System.Drawing.Point(208, 244)
        Me.LblPasswrdNotMatch.Name = "LblPasswrdNotMatch"
        Me.LblPasswrdNotMatch.Size = New System.Drawing.Size(115, 13)
        Me.LblPasswrdNotMatch.TabIndex = 31
        Me.LblPasswrdNotMatch.Text = "Password not matched"
        Me.LblPasswrdNotMatch.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "First Name"
        '
        'TextBoxLstName
        '
        Me.TextBoxLstName.Location = New System.Drawing.Point(196, 139)
        Me.TextBoxLstName.Name = "TextBoxLstName"
        Me.TextBoxLstName.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxLstName.TabIndex = 36
        '
        'TextBoxFrstName
        '
        Me.TextBoxFrstName.Location = New System.Drawing.Point(196, 102)
        Me.TextBoxFrstName.Name = "TextBoxFrstName"
        Me.TextBoxFrstName.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxFrstName.TabIndex = 35
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 445)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxLstName)
        Me.Controls.Add(Me.TextBoxFrstName)
        Me.Controls.Add(Me.LblPasswrdNotMatch)
        Me.Controls.Add(Me.ComboBoxSignupAs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCncl)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.ComboBoxSecQues)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSecAns)
        Me.Controls.Add(Me.TextBoxReEnterPassword)
        Me.Controls.Add(Me.TextBoxeEnterPassword)
        Me.Controls.Add(Me.TextBoxID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnCncl As System.Windows.Forms.Button
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSecQues As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSecAns As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxReEnterPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxeEnterPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSignupAs As System.Windows.Forms.ComboBox
    Friend WithEvents LblPasswrdNotMatch As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLstName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFrstName As System.Windows.Forms.TextBox
End Class
