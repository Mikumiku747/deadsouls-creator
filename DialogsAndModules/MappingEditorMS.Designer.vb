<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MappingEditorMS
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
        Me.KeysListBox = New System.Windows.Forms.ListBox()
        Me.KeysListBoxContainer = New System.Windows.Forms.GroupBox()
        Me.ValueGroupBox = New System.Windows.Forms.GroupBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ValueTextBoxLabel = New System.Windows.Forms.Label()
        Me.KeysTextBox = New System.Windows.Forms.TextBox()
        Me.KeysTextBoxLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton_ = New System.Windows.Forms.Button()
        Me.KeysListBoxContainer.SuspendLayout()
        Me.ValueGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'KeysListBox
        '
        Me.KeysListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KeysListBox.FormattingEnabled = True
        Me.KeysListBox.Location = New System.Drawing.Point(3, 16)
        Me.KeysListBox.Name = "KeysListBox"
        Me.KeysListBox.Size = New System.Drawing.Size(194, 231)
        Me.KeysListBox.TabIndex = 0
        '
        'KeysListBoxContainer
        '
        Me.KeysListBoxContainer.Controls.Add(Me.KeysListBox)
        Me.KeysListBoxContainer.Location = New System.Drawing.Point(12, 12)
        Me.KeysListBoxContainer.Name = "KeysListBoxContainer"
        Me.KeysListBoxContainer.Size = New System.Drawing.Size(200, 250)
        Me.KeysListBoxContainer.TabIndex = 1
        Me.KeysListBoxContainer.TabStop = False
        Me.KeysListBoxContainer.Text = "Keys"
        '
        'ValueGroupBox
        '
        Me.ValueGroupBox.Controls.Add(Me.RemoveButton)
        Me.ValueGroupBox.Controls.Add(Me.ValueTextBox)
        Me.ValueGroupBox.Controls.Add(Me.AddButton)
        Me.ValueGroupBox.Controls.Add(Me.ValueTextBoxLabel)
        Me.ValueGroupBox.Controls.Add(Me.KeysTextBox)
        Me.ValueGroupBox.Controls.Add(Me.KeysTextBoxLabel)
        Me.ValueGroupBox.Location = New System.Drawing.Point(221, 13)
        Me.ValueGroupBox.Name = "ValueGroupBox"
        Me.ValueGroupBox.Size = New System.Drawing.Size(250, 217)
        Me.ValueGroupBox.TabIndex = 2
        Me.ValueGroupBox.TabStop = False
        Me.ValueGroupBox.Text = "Value Editor"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(132, 188)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(112, 23)
        Me.RemoveButton.TabIndex = 4
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ValueTextBox
        '
        Me.ValueTextBox.Location = New System.Drawing.Point(10, 71)
        Me.ValueTextBox.Multiline = True
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(234, 111)
        Me.ValueTextBox.TabIndex = 3
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(10, 188)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(116, 23)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ValueTextBoxLabel
        '
        Me.ValueTextBoxLabel.AutoSize = True
        Me.ValueTextBoxLabel.Location = New System.Drawing.Point(7, 55)
        Me.ValueTextBoxLabel.Name = "ValueTextBoxLabel"
        Me.ValueTextBoxLabel.Size = New System.Drawing.Size(34, 13)
        Me.ValueTextBoxLabel.TabIndex = 2
        Me.ValueTextBoxLabel.Text = "Value"
        '
        'KeysTextBox
        '
        Me.KeysTextBox.Location = New System.Drawing.Point(10, 32)
        Me.KeysTextBox.Name = "KeysTextBox"
        Me.KeysTextBox.Size = New System.Drawing.Size(234, 20)
        Me.KeysTextBox.TabIndex = 1
        '
        'KeysTextBoxLabel
        '
        Me.KeysTextBoxLabel.AutoSize = True
        Me.KeysTextBoxLabel.Location = New System.Drawing.Point(7, 15)
        Me.KeysTextBoxLabel.Name = "KeysTextBoxLabel"
        Me.KeysTextBoxLabel.Size = New System.Drawing.Size(30, 13)
        Me.KeysTextBoxLabel.TabIndex = 0
        Me.KeysTextBoxLabel.Text = "Keys"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(353, 236)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(118, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton_
        '
        Me.CancelButton_.Location = New System.Drawing.Point(221, 236)
        Me.CancelButton_.Name = "CancelButton_"
        Me.CancelButton_.Size = New System.Drawing.Size(126, 23)
        Me.CancelButton_.TabIndex = 5
        Me.CancelButton_.Text = "Cancel"
        Me.CancelButton_.UseVisualStyleBackColor = True
        '
        'MappingEditorMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 269)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CancelButton_)
        Me.Controls.Add(Me.ValueGroupBox)
        Me.Controls.Add(Me.KeysListBoxContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MappingEditorMS"
        Me.Text = "Edit Mapping"
        Me.KeysListBoxContainer.ResumeLayout(False)
        Me.ValueGroupBox.ResumeLayout(False)
        Me.ValueGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KeysListBox As System.Windows.Forms.ListBox
    Friend WithEvents KeysListBoxContainer As System.Windows.Forms.GroupBox
    Friend WithEvents ValueGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValueTextBoxLabel As System.Windows.Forms.Label
    Friend WithEvents KeysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeysTextBoxLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton_ As System.Windows.Forms.Button
End Class
