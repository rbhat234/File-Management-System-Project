<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierMainPage
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
        Me.ReceiptHandlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesReceiptToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiptRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiptRecordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesReceiptRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContributionRecordToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesRecordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceiptHandlerToolStripMenuItem, Me.ReceiptRecordToolStripMenuItem, Me.ExportReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReceiptHandlerToolStripMenuItem
        '
        Me.ReceiptHandlerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecToolStripMenuItem, Me.ExpensesReceiptToolStripMenuItem1})
        Me.ReceiptHandlerToolStripMenuItem.Name = "ReceiptHandlerToolStripMenuItem"
        Me.ReceiptHandlerToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ReceiptHandlerToolStripMenuItem.Text = "Receipt Handler"
        '
        'RecToolStripMenuItem
        '
        Me.RecToolStripMenuItem.Name = "RecToolStripMenuItem"
        Me.RecToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RecToolStripMenuItem.Text = "Contribution Receipt"
        '
        'ExpensesReceiptToolStripMenuItem1
        '
        Me.ExpensesReceiptToolStripMenuItem1.Name = "ExpensesReceiptToolStripMenuItem1"
        Me.ExpensesReceiptToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ExpensesReceiptToolStripMenuItem1.Text = "Expenses Receipt"
        '
        'ReceiptRecordToolStripMenuItem
        '
        Me.ReceiptRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceiptRecordToolStripMenuItem1, Me.ExpensesReceiptRecordToolStripMenuItem})
        Me.ReceiptRecordToolStripMenuItem.Name = "ReceiptRecordToolStripMenuItem"
        Me.ReceiptRecordToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ReceiptRecordToolStripMenuItem.Text = "Records"
        '
        'ReceiptRecordToolStripMenuItem1
        '
        Me.ReceiptRecordToolStripMenuItem1.Name = "ReceiptRecordToolStripMenuItem1"
        Me.ReceiptRecordToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.ReceiptRecordToolStripMenuItem1.Text = "Contribution Receipt Record"
        '
        'ExpensesReceiptRecordToolStripMenuItem
        '
        Me.ExpensesReceiptRecordToolStripMenuItem.Name = "ExpensesReceiptRecordToolStripMenuItem"
        Me.ExpensesReceiptRecordToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ExpensesReceiptRecordToolStripMenuItem.Text = "Expenses Receipt Record"
        '
        'ExportReportsToolStripMenuItem
        '
        Me.ExportReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContributionRecordToolStripMenuItem2, Me.ExpensesRecordToolStripMenuItem1})
        Me.ExportReportsToolStripMenuItem.Name = "ExportReportsToolStripMenuItem"
        Me.ExportReportsToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ExportReportsToolStripMenuItem.Text = "Export Records"
        '
        'ContributionRecordToolStripMenuItem2
        '
        Me.ContributionRecordToolStripMenuItem2.Name = "ContributionRecordToolStripMenuItem2"
        Me.ContributionRecordToolStripMenuItem2.Size = New System.Drawing.Size(182, 22)
        Me.ContributionRecordToolStripMenuItem2.Text = "Contribution Record"
        '
        'ExpensesRecordToolStripMenuItem1
        '
        Me.ExpensesRecordToolStripMenuItem1.Name = "ExpensesRecordToolStripMenuItem1"
        Me.ExpensesRecordToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ExpensesRecordToolStripMenuItem1.Text = "Expenses Record"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(586, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Records Loaded"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(536, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        Me.Label2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(469, 108)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(203, 244)
        Me.ListBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "UpComing Events"
        '
        'CashierMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(690, 360)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CashierMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReceiptHandlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiptRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiptRecordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpensesReceiptRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContributionRecordToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpensesRecordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpensesReceiptToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
