<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContributionReceipt
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxMemberId = New System.Windows.Forms.TextBox()
        Me.TextBoxReceiptNo = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxContactNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxCityOrVillage = New System.Windows.Forms.TextBox()
        Me.TextBoxDistrict = New System.Windows.Forms.TextBox()
        Me.TextBoxTehsil = New System.Windows.Forms.TextBox()
        Me.TextBoxCountry = New System.Windows.Forms.TextBox()
        Me.TextBoxState = New System.Windows.Forms.TextBox()
        Me.TextBoxHouseNo = New System.Windows.Forms.TextBox()
        Me.TextBoxPIN = New System.Windows.Forms.TextBox()
        Me.TextBoxWard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Member ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(267, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Last Name"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(195, 273)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 12
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(315, 273)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(374, 76)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxLastName.TabIndex = 3
        '
        'TextBoxMemberId
        '
        Me.TextBoxMemberId.Location = New System.Drawing.Point(111, 74)
        Me.TextBoxMemberId.Name = "TextBoxMemberId"
        Me.TextBoxMemberId.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxMemberId.TabIndex = 1
        Me.TextBoxMemberId.Text = " "
        '
        'TextBoxReceiptNo
        '
        Me.TextBoxReceiptNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxReceiptNo.Location = New System.Drawing.Point(111, 29)
        Me.TextBoxReceiptNo.Name = "TextBoxReceiptNo"
        Me.TextBoxReceiptNo.ReadOnly = True
        Me.TextBoxReceiptNo.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxReceiptNo.TabIndex = 100
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(374, 31)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxFirstName.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Contact No."
        '
        'TextBoxContactNo
        '
        Me.TextBoxContactNo.BackColor = System.Drawing.Color.White
        Me.TextBoxContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxContactNo.Location = New System.Drawing.Point(124, 239)
        Me.TextBoxContactNo.Name = "TextBoxContactNo"
        Me.TextBoxContactNo.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxContactNo.TabIndex = 101
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(363, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Amount"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(463, 241)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxAmount.TabIndex = 102
        Me.TextBoxAmount.Text = " "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(575, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Date"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(551, 74)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxDate.TabIndex = 2
        '
        'TextBoxCityOrVillage
        '
        Me.TextBoxCityOrVillage.Location = New System.Drawing.Point(487, 119)
        Me.TextBoxCityOrVillage.Name = "TextBoxCityOrVillage"
        Me.TextBoxCityOrVillage.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxCityOrVillage.TabIndex = 105
        Me.TextBoxCityOrVillage.Text = " "
        '
        'TextBoxDistrict
        '
        Me.TextBoxDistrict.Location = New System.Drawing.Point(525, 153)
        Me.TextBoxDistrict.Name = "TextBoxDistrict"
        Me.TextBoxDistrict.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxDistrict.TabIndex = 108
        Me.TextBoxDistrict.Text = " "
        '
        'TextBoxTehsil
        '
        Me.TextBoxTehsil.Location = New System.Drawing.Point(292, 153)
        Me.TextBoxTehsil.Name = "TextBoxTehsil"
        Me.TextBoxTehsil.Size = New System.Drawing.Size(132, 20)
        Me.TextBoxTehsil.TabIndex = 107
        Me.TextBoxTehsil.Text = " "
        '
        'TextBoxCountry
        '
        Me.TextBoxCountry.Location = New System.Drawing.Point(463, 189)
        Me.TextBoxCountry.Name = "TextBoxCountry"
        Me.TextBoxCountry.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxCountry.TabIndex = 110
        Me.TextBoxCountry.Text = " "
        '
        'TextBoxState
        '
        Me.TextBoxState.Location = New System.Drawing.Point(124, 192)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxState.TabIndex = 109
        Me.TextBoxState.Text = " "
        '
        'TextBoxHouseNo
        '
        Me.TextBoxHouseNo.Location = New System.Drawing.Point(292, 119)
        Me.TextBoxHouseNo.Name = "TextBoxHouseNo"
        Me.TextBoxHouseNo.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxHouseNo.TabIndex = 104
        Me.TextBoxHouseNo.Text = " "
        '
        'TextBoxPIN
        '
        Me.TextBoxPIN.Location = New System.Drawing.Point(124, 155)
        Me.TextBoxPIN.Name = "TextBoxPIN"
        Me.TextBoxPIN.Size = New System.Drawing.Size(79, 20)
        Me.TextBoxPIN.TabIndex = 106
        Me.TextBoxPIN.Text = " "
        '
        'TextBoxWard
        '
        Me.TextBoxWard.BackColor = System.Drawing.Color.White
        Me.TextBoxWard.Location = New System.Drawing.Point(124, 122)
        Me.TextBoxWard.Name = "TextBoxWard"
        Me.TextBoxWard.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxWard.TabIndex = 103
        Me.TextBoxWard.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(369, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "City/Village"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(441, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "District"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(225, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Tehsil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(198, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "House No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(360, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Country"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(21, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(15, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(17, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Sec/Ward"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 119)
        Me.Panel1.TabIndex = 119
        '
        'FormContributionReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 306)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxCityOrVillage)
        Me.Controls.Add(Me.TextBoxDistrict)
        Me.Controls.Add(Me.TextBoxTehsil)
        Me.Controls.Add(Me.TextBoxCountry)
        Me.Controls.Add(Me.TextBoxState)
        Me.Controls.Add(Me.TextBoxHouseNo)
        Me.Controls.Add(Me.TextBoxPIN)
        Me.Controls.Add(Me.TextBoxWard)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.TextBoxContactNo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TextBoxMemberId)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxReceiptNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormContributionReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt Handler: Contribution Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxLastName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMemberId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCityOrVillage As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDistrict As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTehsil As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCountry As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxState As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPIN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxWard As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
