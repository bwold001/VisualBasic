<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWageCalculator
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
        Me.lblHourlyWage = New System.Windows.Forms.Label()
        Me.lblWeeklyHours = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.txtWeeklyHours = New System.Windows.Forms.TextBox()
        Me.txtGrossEarning = New System.Windows.Forms.TextBox()
        Me.txtFWT = New System.Windows.Forms.TextBox()
        Me.txtNetEarning = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHourlyWage
        '
        Me.lblHourlyWage.AutoSize = True
        Me.lblHourlyWage.Location = New System.Drawing.Point(49, 19)
        Me.lblHourlyWage.Name = "lblHourlyWage"
        Me.lblHourlyWage.Size = New System.Drawing.Size(75, 13)
        Me.lblHourlyWage.TabIndex = 0
        Me.lblHourlyWage.Text = "Hourly Wage: "
        '
        'lblWeeklyHours
        '
        Me.lblWeeklyHours.AutoSize = True
        Me.lblWeeklyHours.Location = New System.Drawing.Point(49, 63)
        Me.lblWeeklyHours.Name = "lblWeeklyHours"
        Me.lblWeeklyHours.Size = New System.Drawing.Size(80, 13)
        Me.lblWeeklyHours.TabIndex = 1
        Me.lblWeeklyHours.Text = "Weekly Hours: "
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(49, 111)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(84, 13)
        Me.lblGross.TabIndex = 2
        Me.lblGross.Text = "Gross Earnings: "
        '
        'lblFWT
        '
        Me.lblFWT.AutoSize = True
        Me.lblFWT.Location = New System.Drawing.Point(49, 162)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(62, 13)
        Me.lblFWT.TabIndex = 3
        Me.lblFWT.Text = "Less FWT: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Net Earnings: "
        '
        'txtHourlyWage
        '
        Me.txtHourlyWage.Location = New System.Drawing.Point(131, 16)
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(100, 20)
        Me.txtHourlyWage.TabIndex = 5
        '
        'txtWeeklyHours
        '
        Me.txtWeeklyHours.Location = New System.Drawing.Point(131, 60)
        Me.txtWeeklyHours.Name = "txtWeeklyHours"
        Me.txtWeeklyHours.Size = New System.Drawing.Size(100, 20)
        Me.txtWeeklyHours.TabIndex = 6
        '
        'txtGrossEarning
        '
        Me.txtGrossEarning.Location = New System.Drawing.Point(131, 108)
        Me.txtGrossEarning.Name = "txtGrossEarning"
        Me.txtGrossEarning.ReadOnly = True
        Me.txtGrossEarning.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossEarning.TabIndex = 7
        '
        'txtFWT
        '
        Me.txtFWT.Location = New System.Drawing.Point(131, 159)
        Me.txtFWT.Name = "txtFWT"
        Me.txtFWT.ReadOnly = True
        Me.txtFWT.Size = New System.Drawing.Size(100, 20)
        Me.txtFWT.TabIndex = 8
        '
        'txtNetEarning
        '
        Me.txtNetEarning.Location = New System.Drawing.Point(131, 211)
        Me.txtNetEarning.Name = "txtNetEarning"
        Me.txtNetEarning.ReadOnly = True
        Me.txtNetEarning.Size = New System.Drawing.Size(100, 20)
        Me.txtNetEarning.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(27, 259)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(156, 259)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmWageCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 312)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtNetEarning)
        Me.Controls.Add(Me.txtFWT)
        Me.Controls.Add(Me.txtGrossEarning)
        Me.Controls.Add(Me.txtWeeklyHours)
        Me.Controls.Add(Me.txtHourlyWage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblWeeklyHours)
        Me.Controls.Add(Me.lblHourlyWage)
        Me.Name = "frmWageCalculator"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHourlyWage As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyHours As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblFWT As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHourlyWage As System.Windows.Forms.TextBox
    Friend WithEvents txtWeeklyHours As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossEarning As System.Windows.Forms.TextBox
    Friend WithEvents txtFWT As System.Windows.Forms.TextBox
    Friend WithEvents txtNetEarning As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
