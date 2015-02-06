<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomEditor
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.WindowStatusString = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RoomDescriptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NightDescriptionEnabledCheckbox = New System.Windows.Forms.CheckBox()
        Me.LongDescriptionBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShortDescriptionBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoomSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.LightLevelTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LightLevelIndicatorLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.RoomDescriptionGroupBox.SuspendLayout()
        Me.RoomSettingsGroupBox.SuspendLayout()
        CType(Me.LightLevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(860, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRoomToolStripMenuItem, Me.OpenRoomToolStripMenuItem, Me.SaveRoomToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseFileToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRoomToolStripMenuItem
        '
        Me.NewRoomToolStripMenuItem.Name = "NewRoomToolStripMenuItem"
        Me.NewRoomToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewRoomToolStripMenuItem.Text = "New room"
        '
        'OpenRoomToolStripMenuItem
        '
        Me.OpenRoomToolStripMenuItem.Name = "OpenRoomToolStripMenuItem"
        Me.OpenRoomToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OpenRoomToolStripMenuItem.Text = "Open room..."
        '
        'SaveRoomToolStripMenuItem
        '
        Me.SaveRoomToolStripMenuItem.Name = "SaveRoomToolStripMenuItem"
        Me.SaveRoomToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SaveRoomToolStripMenuItem.Text = "Save room..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'CloseFileToolStripMenuItem
        '
        Me.CloseFileToolStripMenuItem.Name = "CloseFileToolStripMenuItem"
        Me.CloseFileToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CloseFileToolStripMenuItem.Text = "Close file"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = Global.Deadsouls_Creator.My.Resources.Resources.redCrossIcon
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowStatusString})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 498)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(860, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'WindowStatusString
        '
        Me.WindowStatusString.Name = "WindowStatusString"
        Me.WindowStatusString.Size = New System.Drawing.Size(134, 17)
        Me.WindowStatusString.Text = "Dead Souls Room Editor"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.RoomDescriptionGroupBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RoomSettingsGroupBox, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(860, 474)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'RoomDescriptionGroupBox
        '
        Me.RoomDescriptionGroupBox.AutoSize = True
        Me.RoomDescriptionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RoomDescriptionGroupBox.Controls.Add(Me.TextBox1)
        Me.RoomDescriptionGroupBox.Controls.Add(Me.NightDescriptionEnabledCheckbox)
        Me.RoomDescriptionGroupBox.Controls.Add(Me.LongDescriptionBox)
        Me.RoomDescriptionGroupBox.Controls.Add(Me.Label2)
        Me.RoomDescriptionGroupBox.Controls.Add(Me.ShortDescriptionBox)
        Me.RoomDescriptionGroupBox.Controls.Add(Me.Label1)
        Me.RoomDescriptionGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.RoomDescriptionGroupBox.Name = "RoomDescriptionGroupBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.RoomDescriptionGroupBox, 2)
        Me.RoomDescriptionGroupBox.Size = New System.Drawing.Size(300, 211)
        Me.RoomDescriptionGroupBox.TabIndex = 0
        Me.RoomDescriptionGroupBox.TabStop = False
        Me.RoomDescriptionGroupBox.Text = "Description"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(9, 146)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 46)
        Me.TextBox1.TabIndex = 5
        '
        'NightDescriptionEnabledCheckbox
        '
        Me.NightDescriptionEnabledCheckbox.AutoSize = True
        Me.NightDescriptionEnabledCheckbox.Location = New System.Drawing.Point(9, 123)
        Me.NightDescriptionEnabledCheckbox.Name = "NightDescriptionEnabledCheckbox"
        Me.NightDescriptionEnabledCheckbox.Size = New System.Drawing.Size(107, 17)
        Me.NightDescriptionEnabledCheckbox.TabIndex = 4
        Me.NightDescriptionEnabledCheckbox.Text = "Night Description"
        Me.NightDescriptionEnabledCheckbox.UseVisualStyleBackColor = True
        '
        'LongDescriptionBox
        '
        Me.LongDescriptionBox.Location = New System.Drawing.Point(9, 71)
        Me.LongDescriptionBox.Multiline = True
        Me.LongDescriptionBox.Name = "LongDescriptionBox"
        Me.LongDescriptionBox.Size = New System.Drawing.Size(285, 46)
        Me.LongDescriptionBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Long description"
        '
        'ShortDescriptionBox
        '
        Me.ShortDescriptionBox.Location = New System.Drawing.Point(9, 32)
        Me.ShortDescriptionBox.Name = "ShortDescriptionBox"
        Me.ShortDescriptionBox.Size = New System.Drawing.Size(285, 20)
        Me.ShortDescriptionBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Short description"
        '
        'RoomSettingsGroupBox
        '
        Me.RoomSettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RoomSettingsGroupBox.Controls.Add(Me.TextBox2)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label5)
        Me.RoomSettingsGroupBox.Controls.Add(Me.ComboBox1)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label4)
        Me.RoomSettingsGroupBox.Controls.Add(Me.LightLevelIndicatorLabel)
        Me.RoomSettingsGroupBox.Controls.Add(Me.LightLevelTrackBar)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label3)
        Me.RoomSettingsGroupBox.Location = New System.Drawing.Point(309, 3)
        Me.RoomSettingsGroupBox.Name = "RoomSettingsGroupBox"
        Me.RoomSettingsGroupBox.Size = New System.Drawing.Size(300, 117)
        Me.RoomSettingsGroupBox.TabIndex = 1
        Me.RoomSettingsGroupBox.TabStop = False
        Me.RoomSettingsGroupBox.Text = "Settings"
        '
        'LightLevelTrackBar
        '
        Me.LightLevelTrackBar.Location = New System.Drawing.Point(59, 20)
        Me.LightLevelTrackBar.Name = "LightLevelTrackBar"
        Me.LightLevelTrackBar.Size = New System.Drawing.Size(219, 45)
        Me.LightLevelTrackBar.TabIndex = 1
        Me.LightLevelTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LightLevelTrackBar.Value = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Light level"
        '
        'LightLevelIndicatorLabel
        '
        Me.LightLevelIndicatorLabel.AutoSize = True
        Me.LightLevelIndicatorLabel.Location = New System.Drawing.Point(275, 23)
        Me.LightLevelIndicatorLabel.Name = "LightLevelIndicatorLabel"
        Me.LightLevelIndicatorLabel.Size = New System.Drawing.Size(19, 13)
        Me.LightLevelIndicatorLabel.TabIndex = 2
        Me.LightLevelIndicatorLabel.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Climate"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"indoors", "outdoors", "snowy", "windy"})
        Me.ComboBox1.Location = New System.Drawing.Point(59, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Town"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(59, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(235, 20)
        Me.TextBox2.TabIndex = 6
        '
        'RoomEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 520)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "RoomEditor"
        Me.Text = "Dead Souls Room Editor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.RoomDescriptionGroupBox.ResumeLayout(False)
        Me.RoomDescriptionGroupBox.PerformLayout()
        Me.RoomSettingsGroupBox.ResumeLayout(False)
        Me.RoomSettingsGroupBox.PerformLayout()
        CType(Me.LightLevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowStatusString As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RoomDescriptionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LongDescriptionBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShortDescriptionBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NightDescriptionEnabledCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RoomSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LightLevelTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LightLevelIndicatorLabel As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
