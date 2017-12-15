<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrequency
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
        Me.lstBoxDisplay = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxDisplay
        '
        Me.lstBoxDisplay.FormattingEnabled = True
        Me.lstBoxDisplay.Location = New System.Drawing.Point(12, 75)
        Me.lstBoxDisplay.Name = "lstBoxDisplay"
        Me.lstBoxDisplay.Size = New System.Drawing.Size(206, 95)
        Me.lstBoxDisplay.TabIndex = 0
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 26)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(206, 29)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display Frequencies"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 190)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstBoxDisplay)
        Me.Name = "frmFrequency"
        Me.Text = "Frequency"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstBoxDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button

End Class
