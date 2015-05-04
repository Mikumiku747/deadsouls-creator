<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ds_path_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ds_path_dialog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NormalPathRadioButton = New System.Windows.Forms.RadioButton()
        Me.dsInstallPathTextBox = New System.Windows.Forms.TextBox()
        Me.BrowsePathButton = New System.Windows.Forms.Button()
        Me.NoPathRadioButton = New System.Windows.Forms.RadioButton()
        Me.GetServerRadioButton = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'NormalPathRadioButton
        '
        Me.NormalPathRadioButton.AutoSize = True
        Me.NormalPathRadioButton.Checked = True
        Me.NormalPathRadioButton.Location = New System.Drawing.Point(16, 87)
        Me.NormalPathRadioButton.Name = "NormalPathRadioButton"
        Me.NormalPathRadioButton.Size = New System.Drawing.Size(199, 17)
        Me.NormalPathRadioButton.TabIndex = 1
        Me.NormalPathRadioButton.TabStop = True
        Me.NormalPathRadioButton.Text = "Use this as my deadsouls installation:"
        Me.NormalPathRadioButton.UseVisualStyleBackColor = True
        '
        'dsInstallPathTextBox
        '
        Me.dsInstallPathTextBox.Location = New System.Drawing.Point(16, 111)
        Me.dsInstallPathTextBox.Name = "dsInstallPathTextBox"
        Me.dsInstallPathTextBox.Size = New System.Drawing.Size(175, 20)
        Me.dsInstallPathTextBox.TabIndex = 2
        '
        'BrowsePathButton
        '
        Me.BrowsePathButton.Location = New System.Drawing.Point(197, 111)
        Me.BrowsePathButton.Name = "BrowsePathButton"
        Me.BrowsePathButton.Size = New System.Drawing.Size(75, 20)
        Me.BrowsePathButton.TabIndex = 3
        Me.BrowsePathButton.Text = "Browse..."
        Me.BrowsePathButton.UseVisualStyleBackColor = True
        '
        'NoPathRadioButton
        '
        Me.NoPathRadioButton.Location = New System.Drawing.Point(16, 138)
        Me.NoPathRadioButton.Name = "NoPathRadioButton"
        Me.NoPathRadioButton.Size = New System.Drawing.Size(256, 47)
        Me.NoPathRadioButton.TabIndex = 4
        Me.NoPathRadioButton.TabStop = True
        Me.NoPathRadioButton.Text = "Don't use a deadsouls path. (This isn't the server computer, or you don't want to" &
    " scan for game files)"
        Me.NoPathRadioButton.UseVisualStyleBackColor = True
        '
        'GetServerRadioButton
        '
        Me.GetServerRadioButton.Location = New System.Drawing.Point(13, 192)
        Me.GetServerRadioButton.Name = "GetServerRadioButton"
        Me.GetServerRadioButton.Size = New System.Drawing.Size(259, 35)
        Me.GetServerRadioButton.TabIndex = 5
        Me.GetServerRadioButton.Text = "Take me to the deadsouls website so I can install the server software. (This will" &
    " be set to not scan for game files, go to ""Tools""->""Deadsouls installation path""" &
    " to re-configure it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.GetServerRadioButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(197, 245)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 6
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ds_path_dialog
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.GetServerRadioButton)
        Me.Controls.Add(Me.NoPathRadioButton)
        Me.Controls.Add(Me.BrowsePathButton)
        Me.Controls.Add(Me.dsInstallPathTextBox)
        Me.Controls.Add(Me.NormalPathRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ds_path_dialog"
        Me.ShowIcon = False
        Me.Text = "Installation Path"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NormalPathRadioButton As RadioButton
    Friend WithEvents dsInstallPathTextBox As TextBox
    Friend WithEvents BrowsePathButton As Button
    Friend WithEvents NoPathRadioButton As RadioButton
    Friend WithEvents GetServerRadioButton As RadioButton
    Friend WithEvents OKButton As Button
End Class
