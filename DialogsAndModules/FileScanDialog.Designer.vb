<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileScanDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StatusLabelMajor = New System.Windows.Forms.Label()
        Me.StatusLabelMinor = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(13, 13)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(359, 23)
        Me.ProgressBar.TabIndex = 0
        '
        'StatusLabelMajor
        '
        Me.StatusLabelMajor.AutoSize = True
        Me.StatusLabelMajor.Location = New System.Drawing.Point(12, 39)
        Me.StatusLabelMajor.Name = "StatusLabelMajor"
        Me.StatusLabelMajor.Size = New System.Drawing.Size(128, 13)
        Me.StatusLabelMajor.TabIndex = 1
        Me.StatusLabelMajor.Text = "Scanning for Game files..."
        '
        'StatusLabelMinor
        '
        Me.StatusLabelMinor.AutoSize = True
        Me.StatusLabelMinor.Location = New System.Drawing.Point(13, 56)
        Me.StatusLabelMinor.Name = "StatusLabelMinor"
        Me.StatusLabelMinor.Size = New System.Drawing.Size(155, 13)
        Me.StatusLabelMinor.TabIndex = 2
        Me.StatusLabelMinor.Text = "Scanning deadsouls directory..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'FileScanDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 101)
        Me.Controls.Add(Me.StatusLabelMinor)
        Me.Controls.Add(Me.StatusLabelMajor)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "FileScanDialog"
        Me.ShowIcon = False
        Me.Text = "Scanning for Game Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents StatusLabelMajor As Label
    Friend WithEvents StatusLabelMinor As Label
    Friend WithEvents Timer As Timer
End Class
