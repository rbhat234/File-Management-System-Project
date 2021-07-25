<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountantMainPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MembersRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBalanceSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventOrganizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContributionRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpenseRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportBalanceSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembersRecordToolStripMenuItem, Me.EventOrganizerToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MembersRecordToolStripMenuItem
        '
        Me.MembersRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBalanceSheetToolStripMenuItem})
        Me.MembersRecordToolStripMenuItem.Name = "MembersRecordToolStripMenuItem"
        Me.MembersRecordToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.MembersRecordToolStripMenuItem.Text = "Balance Sheet"
        '
        'ViewBalanceSheetToolStripMenuItem
        '
        Me.ViewBalanceSheetToolStripMenuItem.Name = "ViewBalanceSheetToolStripMenuItem"
        Me.ViewBalanceSheetToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ViewBalanceSheetToolStripMenuItem.Text = "View Balance Sheet"
        '
        'EventOrganizerToolStripMenuItem
        '
        Me.EventOrganizerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewRecordToolStripMenuItem})
        Me.EventOrganizerToolStripMenuItem.Name = "EventOrganizerToolStripMenuItem"
        Me.EventOrganizerToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.EventOrganizerToolStripMenuItem.Text = "Cash Record"
        '
        'ViewRecordToolStripMenuItem
        '
        Me.ViewRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContributionRecordToolStripMenuItem, Me.ExpenseRecordToolStripMenuItem})
        Me.ViewRecordToolStripMenuItem.Name = "ViewRecordToolStripMenuItem"
        Me.ViewRecordToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ViewRecordToolStripMenuItem.Text = "View Record"
        '
        'ContributionRecordToolStripMenuItem
        '
        Me.ContributionRecordToolStripMenuItem.Name = "ContributionRecordToolStripMenuItem"
        Me.ContributionRecordToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ContributionRecordToolStripMenuItem.Text = "Contribution Record"
        '
        'ExpenseRecordToolStripMenuItem
        '
        Me.ExpenseRecordToolStripMenuItem.Name = "ExpenseRecordToolStripMenuItem"
        Me.ExpenseRecordToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExpenseRecordToolStripMenuItem.Text = "Expense Record"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportBalanceSheetToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ExportBalanceSheetToolStripMenuItem
        '
        Me.ExportBalanceSheetToolStripMenuItem.Name = "ExportBalanceSheetToolStripMenuItem"
        Me.ExportBalanceSheetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportBalanceSheetToolStripMenuItem.Text = "Export BalanceSheet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(657, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Records Loaded"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(616, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        Me.Label2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(578, 135)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(192, 244)
        Me.ListBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(626, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UpComing Events"
        '
        'AccountantMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(782, 398)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AccountantMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "                                                                 Accountant"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MembersRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventOrganizerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBalanceSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContributionRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpenseRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportBalanceSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
