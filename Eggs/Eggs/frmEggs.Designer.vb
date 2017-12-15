<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEggs
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
        Me.lstBoxEggs = New System.Windows.Forms.ListBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxEggs
        '
        Me.lstBoxEggs.FormattingEnabled = True
        Me.lstBoxEggs.Location = New System.Drawing.Point(22, 86)
        Me.lstBoxEggs.Name = "lstBoxEggs"
        Me.lstBoxEggs.Size = New System.Drawing.Size(233, 134)
        Me.lstBoxEggs.TabIndex = 0
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(32, 12)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(208, 56)
        Me.btnProcess.TabIndex = 1
        Me.btnProcess.Text = "Process Eggs"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'frmEggs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 232)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lstBoxEggs)
        Me.Name = "frmEggs"
        Me.Text = "Eggs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstBoxEggs As System.Windows.Forms.ListBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button

End Class
