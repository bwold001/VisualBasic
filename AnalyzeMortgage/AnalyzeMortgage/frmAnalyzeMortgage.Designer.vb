<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalyzeMortgage
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
        Me.lblAmountOfLoan = New System.Windows.Forms.Label()
        Me.lblInterestRate1 = New System.Windows.Forms.Label()
        Me.lblInterestRate2 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalInterest = New System.Windows.Forms.Label()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtMonthly = New System.Windows.Forms.TextBox()
        Me.txtInterestPaid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAmountOfLoan
        '
        Me.lblAmountOfLoan.AutoSize = True
        Me.lblAmountOfLoan.Location = New System.Drawing.Point(12, 29)
        Me.lblAmountOfLoan.Name = "lblAmountOfLoan"
        Me.lblAmountOfLoan.Size = New System.Drawing.Size(84, 13)
        Me.lblAmountOfLoan.TabIndex = 0
        Me.lblAmountOfLoan.Text = "Amount of loan: "
        '
        'lblInterestRate1
        '
        Me.lblInterestRate1.AutoSize = True
        Me.lblInterestRate1.Location = New System.Drawing.Point(15, 68)
        Me.lblInterestRate1.Name = "lblInterestRate1"
        Me.lblInterestRate1.Size = New System.Drawing.Size(71, 13)
        Me.lblInterestRate1.TabIndex = 1
        Me.lblInterestRate1.Text = "Interest Rate:"
        '
        'lblInterestRate2
        '
        Me.lblInterestRate2.AutoSize = True
        Me.lblInterestRate2.Location = New System.Drawing.Point(12, 81)
        Me.lblInterestRate2.Name = "lblInterestRate2"
        Me.lblInterestRate2.Size = New System.Drawing.Size(74, 13)
        Me.lblInterestRate2.TabIndex = 2
        Me.lblInterestRate2.Text = "(such as 5.25)"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(15, 119)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(101, 13)
        Me.lblDuration.TabIndex = 3
        Me.lblDuration.Text = "Duration in months: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monthly payment: "
        '
        'lblTotalInterest
        '
        Me.lblTotalInterest.AutoSize = True
        Me.lblTotalInterest.Location = New System.Drawing.Point(15, 236)
        Me.lblTotalInterest.Name = "lblTotalInterest"
        Me.lblTotalInterest.Size = New System.Drawing.Size(97, 13)
        Me.lblTotalInterest.TabIndex = 5
        Me.lblTotalInterest.Text = "Total interest paid: "
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(12, 142)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(212, 35)
        Me.btnAnalyze.TabIndex = 6
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(124, 29)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(100, 20)
        Me.txtLoan.TabIndex = 7
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(124, 74)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestRate.TabIndex = 8
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(124, 116)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 9
        '
        'txtMonthly
        '
        Me.txtMonthly.Location = New System.Drawing.Point(124, 193)
        Me.txtMonthly.Name = "txtMonthly"
        Me.txtMonthly.ReadOnly = True
        Me.txtMonthly.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthly.TabIndex = 10
        '
        'txtInterestPaid
        '
        Me.txtInterestPaid.Location = New System.Drawing.Point(124, 233)
        Me.txtInterestPaid.Name = "txtInterestPaid"
        Me.txtInterestPaid.ReadOnly = True
        Me.txtInterestPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestPaid.TabIndex = 11
        '
        'frmAnalyzeMortgage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 261)
        Me.Controls.Add(Me.txtInterestPaid)
        Me.Controls.Add(Me.txtMonthly)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.lblTotalInterest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblInterestRate2)
        Me.Controls.Add(Me.lblInterestRate1)
        Me.Controls.Add(Me.lblAmountOfLoan)
        Me.Name = "frmAnalyzeMortgage"
        Me.Text = "Analyze Mortgage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmountOfLoan As System.Windows.Forms.Label
    Friend WithEvents lblInterestRate1 As System.Windows.Forms.Label
    Friend WithEvents lblInterestRate2 As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalInterest As System.Windows.Forms.Label
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
    Friend WithEvents txtLoan As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthly As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestPaid As System.Windows.Forms.TextBox

End Class
