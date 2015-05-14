<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MappingEditorSF
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
        Me.KeyListLabel = New System.Windows.Forms.Label()
        Me.KeysListBox = New System.Windows.Forms.ListBox()
        Me.ItemValueLabel = New System.Windows.Forms.Label()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.ChooseFileButton = New System.Windows.Forms.Button()
        Me.FileListBox = New System.Windows.Forms.ListBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.FileListLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.KeyTextBox = New System.Windows.Forms.TextBox()
        Me.KeyNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KeyListLabel
        '
        Me.KeyListLabel.AutoSize = True
        Me.KeyListLabel.Location = New System.Drawing.Point(12, 9)
        Me.KeyListLabel.Name = "KeyListLabel"
        Me.KeyListLabel.Size = New System.Drawing.Size(44, 13)
        Me.KeyListLabel.TabIndex = 0
        Me.KeyListLabel.Text = "Key List"
        '
        'KeysListBox
        '
        Me.KeysListBox.FormattingEnabled = True
        Me.KeysListBox.Location = New System.Drawing.Point(12, 25)
        Me.KeysListBox.Name = "KeysListBox"
        Me.KeysListBox.Size = New System.Drawing.Size(199, 173)
        Me.KeysListBox.TabIndex = 1
        '
        'ItemValueLabel
        '
        Me.ItemValueLabel.AutoSize = True
        Me.ItemValueLabel.Location = New System.Drawing.Point(226, 48)
        Me.ItemValueLabel.Name = "ItemValueLabel"
        Me.ItemValueLabel.Size = New System.Drawing.Size(57, 13)
        Me.ItemValueLabel.TabIndex = 3
        Me.ItemValueLabel.Text = "Item Value"
        '
        'ValueTextBox
        '
        Me.ValueTextBox.Location = New System.Drawing.Point(229, 64)
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(156, 20)
        Me.ValueTextBox.TabIndex = 4
        '
        'ChooseFileButton
        '
        Me.ChooseFileButton.Location = New System.Drawing.Point(229, 90)
        Me.ChooseFileButton.Name = "ChooseFileButton"
        Me.ChooseFileButton.Size = New System.Drawing.Size(156, 23)
        Me.ChooseFileButton.TabIndex = 5
        Me.ChooseFileButton.Text = "Choose a file..."
        Me.ChooseFileButton.UseVisualStyleBackColor = True
        '
        'FileListBox
        '
        Me.FileListBox.FormattingEnabled = True
        Me.FileListBox.Location = New System.Drawing.Point(229, 132)
        Me.FileListBox.Name = "FileListBox"
        Me.FileListBox.Size = New System.Drawing.Size(156, 69)
        Me.FileListBox.TabIndex = 6
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(229, 212)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(310, 213)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'FileListLabel
        '
        Me.FileListLabel.AutoSize = True
        Me.FileListLabel.Location = New System.Drawing.Point(226, 116)
        Me.FileListLabel.Name = "FileListLabel"
        Me.FileListLabel.Size = New System.Drawing.Size(42, 13)
        Me.FileListLabel.TabIndex = 9
        Me.FileListLabel.Text = "File List"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(12, 212)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(86, 23)
        Me.AddButton.TabIndex = 10
        Me.AddButton.Text = "Add Key"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(104, 212)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(107, 23)
        Me.RemoveButton.TabIndex = 11
        Me.RemoveButton.Text = "Remove Key"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'KeyTextBox
        '
        Me.KeyTextBox.Location = New System.Drawing.Point(229, 25)
        Me.KeyTextBox.Name = "KeyTextBox"
        Me.KeyTextBox.Size = New System.Drawing.Size(156, 20)
        Me.KeyTextBox.TabIndex = 12
        '
        'KeyNameLabel
        '
        Me.KeyNameLabel.AutoSize = True
        Me.KeyNameLabel.Location = New System.Drawing.Point(227, 9)
        Me.KeyNameLabel.Name = "KeyNameLabel"
        Me.KeyNameLabel.Size = New System.Drawing.Size(56, 13)
        Me.KeyNameLabel.TabIndex = 13
        Me.KeyNameLabel.Text = "Key Name"
        '
        'MappingEditorSF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 248)
        Me.Controls.Add(Me.KeyNameLabel)
        Me.Controls.Add(Me.KeyTextBox)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.FileListLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.FileListBox)
        Me.Controls.Add(Me.ChooseFileButton)
        Me.Controls.Add(Me.ValueTextBox)
        Me.Controls.Add(Me.ItemValueLabel)
        Me.Controls.Add(Me.KeysListBox)
        Me.Controls.Add(Me.KeyListLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MappingEditorSF"
        Me.ShowIcon = False
        Me.Text = "MappingEditorSF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KeyListLabel As Label
    Friend WithEvents KeysListBox As ListBox
    Friend WithEvents ItemValueLabel As Label
    Friend WithEvents ValueTextBox As TextBox
    Friend WithEvents ChooseFileButton As Button
    Friend WithEvents FileListBox As ListBox
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents FileListLabel As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents KeyTextBox As TextBox
    Friend WithEvents KeyNameLabel As Label
End Class
