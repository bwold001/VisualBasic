<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDayOfWeek
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
        Me.txtBoxDate = New System.Windows.Forms.TextBox()
        Me.txtBoxDayOfWeek = New System.Windows.Forms.TextBox()
        Me.btnDayOfWeek = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBoxDate
        '
        Me.txtBoxDate.Location = New System.Drawing.Point(139, 16)
        Me.txtBoxDate.Name = "txtBoxDate"
        Me.txtBoxDate.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxDate.TabIndex = 3
        '
        'txtBoxDayOfWeek
        '
        Me.txtBoxDayOfWeek.Location = New System.Drawing.Point(24, 100)
        Me.txtBoxDayOfWeek.Name = "txtBoxDayOfWeek"
        Me.txtBoxDayOfWeek.ReadOnly = True
        Me.txtBoxDayOfWeek.Size = New System.Drawing.Size(215, 20)
        Me.txtBoxDayOfWeek.TabIndex = 4
        '
        'btnDayOfWeek
        '
        Me.btnDayOfWeek.Location = New System.Drawing.Point(12, 50)
        Me.btnDayOfWeek.Name = "btnDayOfWeek"
        Me.btnDayOfWeek.Size = New System.Drawing.Size(253, 34)
        Me.btnDayOfWeek.TabIndex = 5
        Me.btnDayOfWeek.Text = "Determine Day of Week"
        Me.btnDayOfWeek.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(76, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date: "
        '
        'frmDayOfWeek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 132)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnDayOfWeek)
        Me.Controls.Add(Me.txtBoxDayOfWeek)
        Me.Controls.Add(Me.txtBoxDate)
        Me.Name = "frmDayOfWeek"
        Me.Text = "Day of Week"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBoxDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxDayOfWeek As System.Windows.Forms.TextBox
    Friend WithEvents btnDayOfWeek As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label

End Class
