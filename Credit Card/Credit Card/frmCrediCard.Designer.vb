<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrediCard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxCharges = New System.Windows.Forms.TextBox()
        Me.txtBocCredits = New System.Windows.Forms.TextBox()
        Me.txtBoxOldBalance = New System.Windows.Forms.TextBox()
        Me.txtBoxMinPayment = New System.Windows.Forms.TextBox()
        Me.txtBoxNewBalance = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old balance: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Charges: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Credits: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New balance: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Minimum payment: "
        '
        'txtBoxCharges
        '
        Me.txtBoxCharges.Location = New System.Drawing.Point(61, 40)
        Me.txtBoxCharges.Name = "txtBoxCharges"
        Me.txtBoxCharges.Size = New System.Drawing.Size(55, 20)
        Me.txtBoxCharges.TabIndex = 5
        '
        'txtBocCredits
        '
        Me.txtBocCredits.Location = New System.Drawing.Point(167, 40)
        Me.txtBocCredits.Name = "txtBocCredits"
        Me.txtBocCredits.Size = New System.Drawing.Size(66, 20)
        Me.txtBocCredits.TabIndex = 6
        '
        'txtBoxOldBalance
        '
        Me.txtBoxOldBalance.Location = New System.Drawing.Point(105, 8)
        Me.txtBoxOldBalance.Name = "txtBoxOldBalance"
        Me.txtBoxOldBalance.Size = New System.Drawing.Size(61, 20)
        Me.txtBoxOldBalance.TabIndex = 7
        '
        'txtBoxMinPayment
        '
        Me.txtBoxMinPayment.Location = New System.Drawing.Point(130, 192)
        Me.txtBoxMinPayment.Name = "txtBoxMinPayment"
        Me.txtBoxMinPayment.ReadOnly = True
        Me.txtBoxMinPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxMinPayment.TabIndex = 8
        '
        'txtBoxNewBalance
        '
        Me.txtBoxNewBalance.Location = New System.Drawing.Point(130, 150)
        Me.txtBoxNewBalance.Name = "txtBoxNewBalance"
        Me.txtBoxNewBalance.ReadOnly = True
        Me.txtBoxNewBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNewBalance.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 77)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(191, 57)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate New Balance and Minimum Payment"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmCrediCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 224)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBoxNewBalance)
        Me.Controls.Add(Me.txtBoxMinPayment)
        Me.Controls.Add(Me.txtBoxOldBalance)
        Me.Controls.Add(Me.txtBocCredits)
        Me.Controls.Add(Me.txtBoxCharges)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCrediCard"
        Me.Text = "Credit Card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtBocCredits As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxOldBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxMinPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxNewBalance As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
