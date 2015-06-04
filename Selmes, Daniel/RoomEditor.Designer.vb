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
        Me.SaveRoomAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.WindowStatusString = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EntersGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditEntersButton = New System.Windows.Forms.Button()
        Me.EntersTextBox = New System.Windows.Forms.TextBox()
        Me.ExitsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditExitsButton = New System.Windows.Forms.Button()
        Me.ExitsTextBox = New System.Windows.Forms.TextBox()
        Me.SoundsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditSoundsButton = New System.Windows.Forms.Button()
        Me.SoundsTextBox = New System.Windows.Forms.TextBox()
        Me.RoomDescriptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NightDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ShortDescriptionBox = New System.Windows.Forms.TextBox()
        Me.NightDescriptionEnabledCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LongDescriptionBox = New System.Windows.Forms.TextBox()
        Me.RoomSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TownTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClimateComboBox = New System.Windows.Forms.ComboBox()
        Me.GravityDisplayLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LightLevelIndicatorLabel = New System.Windows.Forms.Label()
        Me.LightLevelTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GravityTrackBar = New System.Windows.Forms.TrackBar()
        Me.CodeButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.EditLPCCodeButton = New System.Windows.Forms.Button()
        Me.ItemsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditItemsButton = New System.Windows.Forms.Button()
        Me.ItemsTextBox = New System.Windows.Forms.TextBox()
        Me.SmellsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditSmellsButton = New System.Windows.Forms.Button()
        Me.SmellsTextBox = New System.Windows.Forms.TextBox()
        Me.SearchesGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditSearchesButton = New System.Windows.Forms.Button()
        Me.SearchesTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.EntersGroupBox.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.ExitsGroupBox.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SoundsGroupBox.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.RoomDescriptionGroupBox.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.RoomSettingsGroupBox.SuspendLayout()
        CType(Me.LightLevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GravityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CodeButtonsGroupBox.SuspendLayout()
        Me.ItemsGroupBox.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SmellsGroupBox.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SearchesGroupBox.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRoomToolStripMenuItem, Me.OpenRoomToolStripMenuItem, Me.SaveRoomToolStripMenuItem, Me.SaveRoomAsToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRoomToolStripMenuItem
        '
        Me.NewRoomToolStripMenuItem.Name = "NewRoomToolStripMenuItem"
        Me.NewRoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewRoomToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.NewRoomToolStripMenuItem.Text = "New room"
        '
        'OpenRoomToolStripMenuItem
        '
        Me.OpenRoomToolStripMenuItem.Name = "OpenRoomToolStripMenuItem"
        Me.OpenRoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenRoomToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.OpenRoomToolStripMenuItem.Text = "Open room..."
        '
        'SaveRoomToolStripMenuItem
        '
        Me.SaveRoomToolStripMenuItem.Name = "SaveRoomToolStripMenuItem"
        Me.SaveRoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveRoomToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SaveRoomToolStripMenuItem.Text = "Save room"
        '
        'SaveRoomAsToolStripMenuItem
        '
        Me.SaveRoomAsToolStripMenuItem.Name = "SaveRoomAsToolStripMenuItem"
        Me.SaveRoomAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveRoomAsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SaveRoomAsToolStripMenuItem.Text = "Save room as..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(222, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = Global.Deadsouls_Creator.My.Resources.Resources.redCrossIcon
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
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
        Me.StatusStrip.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(884, 22)
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
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.EntersGroupBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ExitsGroupBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SoundsGroupBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RoomDescriptionGroupBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RoomSettingsGroupBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CodeButtonsGroupBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ItemsGroupBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SmellsGroupBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SearchesGroupBox, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(884, 515)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'EntersGroupBox
        '
        Me.EntersGroupBox.Controls.Add(Me.TableLayoutPanel8)
        Me.EntersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EntersGroupBox.Location = New System.Drawing.Point(501, 3)
        Me.EntersGroupBox.Name = "EntersGroupBox"
        Me.EntersGroupBox.Size = New System.Drawing.Size(186, 251)
        Me.EntersGroupBox.TabIndex = 8
        Me.EntersGroupBox.TabStop = False
        Me.EntersGroupBox.Text = "Enters"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.EditEntersButton, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.EntersTextBox, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(180, 232)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'EditEntersButton
        '
        Me.EditEntersButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditEntersButton.Location = New System.Drawing.Point(3, 206)
        Me.EditEntersButton.Name = "EditEntersButton"
        Me.EditEntersButton.Size = New System.Drawing.Size(174, 23)
        Me.EditEntersButton.TabIndex = 0
        Me.EditEntersButton.Text = "Edit Enters"
        Me.EditEntersButton.UseVisualStyleBackColor = True
        '
        'EntersTextBox
        '
        Me.EntersTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EntersTextBox.Location = New System.Drawing.Point(3, 3)
        Me.EntersTextBox.Multiline = True
        Me.EntersTextBox.Name = "EntersTextBox"
        Me.EntersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.EntersTextBox.Size = New System.Drawing.Size(174, 197)
        Me.EntersTextBox.TabIndex = 1
        '
        'ExitsGroupBox
        '
        Me.ExitsGroupBox.Controls.Add(Me.TableLayoutPanel7)
        Me.ExitsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitsGroupBox.Location = New System.Drawing.Point(693, 3)
        Me.ExitsGroupBox.Name = "ExitsGroupBox"
        Me.ExitsGroupBox.Size = New System.Drawing.Size(188, 251)
        Me.ExitsGroupBox.TabIndex = 7
        Me.ExitsGroupBox.TabStop = False
        Me.ExitsGroupBox.Text = "Exits"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.EditExitsButton, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.ExitsTextBox, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(182, 232)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'EditExitsButton
        '
        Me.EditExitsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditExitsButton.Location = New System.Drawing.Point(3, 206)
        Me.EditExitsButton.Name = "EditExitsButton"
        Me.EditExitsButton.Size = New System.Drawing.Size(176, 23)
        Me.EditExitsButton.TabIndex = 0
        Me.EditExitsButton.Text = "Edit Exits"
        Me.EditExitsButton.UseVisualStyleBackColor = True
        '
        'ExitsTextBox
        '
        Me.ExitsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitsTextBox.Location = New System.Drawing.Point(3, 3)
        Me.ExitsTextBox.Multiline = True
        Me.ExitsTextBox.Name = "ExitsTextBox"
        Me.ExitsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ExitsTextBox.Size = New System.Drawing.Size(176, 197)
        Me.ExitsTextBox.TabIndex = 1
        '
        'SoundsGroupBox
        '
        Me.SoundsGroupBox.Controls.Add(Me.TableLayoutPanel6)
        Me.SoundsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SoundsGroupBox.Location = New System.Drawing.Point(501, 260)
        Me.SoundsGroupBox.Name = "SoundsGroupBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.SoundsGroupBox, 2)
        Me.SoundsGroupBox.Size = New System.Drawing.Size(186, 252)
        Me.SoundsGroupBox.TabIndex = 0
        Me.SoundsGroupBox.TabStop = False
        Me.SoundsGroupBox.Text = "Sounds"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.EditSoundsButton, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.SoundsTextBox, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(180, 233)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'EditSoundsButton
        '
        Me.EditSoundsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditSoundsButton.Location = New System.Drawing.Point(3, 207)
        Me.EditSoundsButton.Name = "EditSoundsButton"
        Me.EditSoundsButton.Size = New System.Drawing.Size(174, 23)
        Me.EditSoundsButton.TabIndex = 0
        Me.EditSoundsButton.Text = "Edit Sounds"
        Me.EditSoundsButton.UseVisualStyleBackColor = True
        '
        'SoundsTextBox
        '
        Me.SoundsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SoundsTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SoundsTextBox.Multiline = True
        Me.SoundsTextBox.Name = "SoundsTextBox"
        Me.SoundsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SoundsTextBox.Size = New System.Drawing.Size(174, 198)
        Me.SoundsTextBox.TabIndex = 1
        '
        'RoomDescriptionGroupBox
        '
        Me.RoomDescriptionGroupBox.AutoSize = True
        Me.RoomDescriptionGroupBox.Controls.Add(Me.TableLayoutPanel10)
        Me.RoomDescriptionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomDescriptionGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.RoomDescriptionGroupBox.Name = "RoomDescriptionGroupBox"
        Me.RoomDescriptionGroupBox.Size = New System.Drawing.Size(300, 251)
        Me.RoomDescriptionGroupBox.TabIndex = 0
        Me.RoomDescriptionGroupBox.TabStop = False
        Me.RoomDescriptionGroupBox.Text = "Description"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.NightDescriptionTextBox, 0, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.ShortDescriptionBox, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.NightDescriptionEnabledCheckbox, 0, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.LongDescriptionBox, 0, 3)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 6
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(294, 232)
        Me.TableLayoutPanel10.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Short description"
        '
        'NightDescriptionTextBox
        '
        Me.NightDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NightDescriptionTextBox.Enabled = False
        Me.NightDescriptionTextBox.Location = New System.Drawing.Point(3, 162)
        Me.NightDescriptionTextBox.Multiline = True
        Me.NightDescriptionTextBox.Name = "NightDescriptionTextBox"
        Me.NightDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NightDescriptionTextBox.Size = New System.Drawing.Size(288, 67)
        Me.NightDescriptionTextBox.TabIndex = 5
        '
        'ShortDescriptionBox
        '
        Me.ShortDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShortDescriptionBox.Location = New System.Drawing.Point(3, 19)
        Me.ShortDescriptionBox.Name = "ShortDescriptionBox"
        Me.ShortDescriptionBox.Size = New System.Drawing.Size(288, 20)
        Me.ShortDescriptionBox.TabIndex = 1
        '
        'NightDescriptionEnabledCheckbox
        '
        Me.NightDescriptionEnabledCheckbox.AutoSize = True
        Me.NightDescriptionEnabledCheckbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NightDescriptionEnabledCheckbox.Location = New System.Drawing.Point(3, 132)
        Me.NightDescriptionEnabledCheckbox.Name = "NightDescriptionEnabledCheckbox"
        Me.NightDescriptionEnabledCheckbox.Size = New System.Drawing.Size(288, 24)
        Me.NightDescriptionEnabledCheckbox.TabIndex = 4
        Me.NightDescriptionEnabledCheckbox.Text = "Night Description"
        Me.NightDescriptionEnabledCheckbox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Long description"
        '
        'LongDescriptionBox
        '
        Me.LongDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LongDescriptionBox.Location = New System.Drawing.Point(3, 59)
        Me.LongDescriptionBox.Multiline = True
        Me.LongDescriptionBox.Name = "LongDescriptionBox"
        Me.LongDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LongDescriptionBox.Size = New System.Drawing.Size(288, 67)
        Me.LongDescriptionBox.TabIndex = 3
        '
        'RoomSettingsGroupBox
        '
        Me.RoomSettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RoomSettingsGroupBox.Controls.Add(Me.TownTextBox)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label4)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label5)
        Me.RoomSettingsGroupBox.Controls.Add(Me.ClimateComboBox)
        Me.RoomSettingsGroupBox.Controls.Add(Me.GravityDisplayLabel)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label7)
        Me.RoomSettingsGroupBox.Controls.Add(Me.LightLevelIndicatorLabel)
        Me.RoomSettingsGroupBox.Controls.Add(Me.LightLevelTrackBar)
        Me.RoomSettingsGroupBox.Controls.Add(Me.Label3)
        Me.RoomSettingsGroupBox.Controls.Add(Me.GravityTrackBar)
        Me.RoomSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomSettingsGroupBox.Location = New System.Drawing.Point(3, 260)
        Me.RoomSettingsGroupBox.Name = "RoomSettingsGroupBox"
        Me.RoomSettingsGroupBox.Size = New System.Drawing.Size(300, 133)
        Me.RoomSettingsGroupBox.TabIndex = 1
        Me.RoomSettingsGroupBox.TabStop = False
        Me.RoomSettingsGroupBox.Text = "Settings"
        '
        'TownTextBox
        '
        Me.TownTextBox.Location = New System.Drawing.Point(57, 105)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(235, 20)
        Me.TownTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Climate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Town"
        '
        'ClimateComboBox
        '
        Me.ClimateComboBox.FormattingEnabled = True
        Me.ClimateComboBox.Items.AddRange(New Object() {"indoors", "temperate", "arid", "arctic", "tropical", "sub-tropical"})
        Me.ClimateComboBox.Location = New System.Drawing.Point(59, 49)
        Me.ClimateComboBox.Name = "ClimateComboBox"
        Me.ClimateComboBox.Size = New System.Drawing.Size(235, 21)
        Me.ClimateComboBox.TabIndex = 4
        '
        'GravityDisplayLabel
        '
        Me.GravityDisplayLabel.AutoSize = True
        Me.GravityDisplayLabel.Location = New System.Drawing.Point(273, 79)
        Me.GravityDisplayLabel.Name = "GravityDisplayLabel"
        Me.GravityDisplayLabel.Size = New System.Drawing.Size(21, 13)
        Me.GravityDisplayLabel.TabIndex = 9
        Me.GravityDisplayLabel.Text = "1G"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gravity"
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
        'LightLevelTrackBar
        '
        Me.LightLevelTrackBar.LargeChange = 4
        Me.LightLevelTrackBar.Location = New System.Drawing.Point(59, 20)
        Me.LightLevelTrackBar.Maximum = 100
        Me.LightLevelTrackBar.Name = "LightLevelTrackBar"
        Me.LightLevelTrackBar.Size = New System.Drawing.Size(210, 45)
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
        'GravityTrackBar
        '
        Me.GravityTrackBar.LargeChange = 2
        Me.GravityTrackBar.Location = New System.Drawing.Point(57, 76)
        Me.GravityTrackBar.Maximum = 5
        Me.GravityTrackBar.Name = "GravityTrackBar"
        Me.GravityTrackBar.Size = New System.Drawing.Size(212, 45)
        Me.GravityTrackBar.TabIndex = 8
        Me.GravityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.GravityTrackBar.Value = 1
        '
        'CodeButtonsGroupBox
        '
        Me.CodeButtonsGroupBox.Controls.Add(Me.EditLPCCodeButton)
        Me.CodeButtonsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeButtonsGroupBox.Location = New System.Drawing.Point(3, 399)
        Me.CodeButtonsGroupBox.Name = "CodeButtonsGroupBox"
        Me.CodeButtonsGroupBox.Size = New System.Drawing.Size(300, 113)
        Me.CodeButtonsGroupBox.TabIndex = 2
        Me.CodeButtonsGroupBox.TabStop = False
        Me.CodeButtonsGroupBox.Text = "Code (Advanced Users)"
        '
        'EditLPCCodeButton
        '
        Me.EditLPCCodeButton.Location = New System.Drawing.Point(6, 19)
        Me.EditLPCCodeButton.Name = "EditLPCCodeButton"
        Me.EditLPCCodeButton.Size = New System.Drawing.Size(287, 23)
        Me.EditLPCCodeButton.TabIndex = 2
        Me.EditLPCCodeButton.Text = "Edit LPC Code"
        Me.EditLPCCodeButton.UseVisualStyleBackColor = True
        '
        'ItemsGroupBox
        '
        Me.ItemsGroupBox.Controls.Add(Me.TableLayoutPanel2)
        Me.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsGroupBox.Location = New System.Drawing.Point(309, 3)
        Me.ItemsGroupBox.Name = "ItemsGroupBox"
        Me.ItemsGroupBox.Size = New System.Drawing.Size(186, 251)
        Me.ItemsGroupBox.TabIndex = 3
        Me.ItemsGroupBox.TabStop = False
        Me.ItemsGroupBox.Text = "Items"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.EditItemsButton, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ItemsTextBox, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(180, 232)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'EditItemsButton
        '
        Me.EditItemsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditItemsButton.Location = New System.Drawing.Point(3, 206)
        Me.EditItemsButton.Name = "EditItemsButton"
        Me.EditItemsButton.Size = New System.Drawing.Size(174, 23)
        Me.EditItemsButton.TabIndex = 0
        Me.EditItemsButton.Text = "Edit Items"
        Me.EditItemsButton.UseVisualStyleBackColor = True
        '
        'ItemsTextBox
        '
        Me.ItemsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsTextBox.Location = New System.Drawing.Point(3, 3)
        Me.ItemsTextBox.Multiline = True
        Me.ItemsTextBox.Name = "ItemsTextBox"
        Me.ItemsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ItemsTextBox.Size = New System.Drawing.Size(174, 197)
        Me.ItemsTextBox.TabIndex = 1
        '
        'SmellsGroupBox
        '
        Me.SmellsGroupBox.Controls.Add(Me.TableLayoutPanel4)
        Me.SmellsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SmellsGroupBox.Location = New System.Drawing.Point(309, 260)
        Me.SmellsGroupBox.Name = "SmellsGroupBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.SmellsGroupBox, 2)
        Me.SmellsGroupBox.Size = New System.Drawing.Size(186, 252)
        Me.SmellsGroupBox.TabIndex = 5
        Me.SmellsGroupBox.TabStop = False
        Me.SmellsGroupBox.Text = "Smells"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.EditSmellsButton, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.SmellsTextBox, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(180, 233)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'EditSmellsButton
        '
        Me.EditSmellsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditSmellsButton.Location = New System.Drawing.Point(3, 207)
        Me.EditSmellsButton.Name = "EditSmellsButton"
        Me.EditSmellsButton.Size = New System.Drawing.Size(174, 23)
        Me.EditSmellsButton.TabIndex = 0
        Me.EditSmellsButton.Text = "Edit Smells"
        Me.EditSmellsButton.UseVisualStyleBackColor = True
        '
        'SmellsTextBox
        '
        Me.SmellsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SmellsTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SmellsTextBox.Multiline = True
        Me.SmellsTextBox.Name = "SmellsTextBox"
        Me.SmellsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SmellsTextBox.Size = New System.Drawing.Size(174, 198)
        Me.SmellsTextBox.TabIndex = 1
        '
        'SearchesGroupBox
        '
        Me.SearchesGroupBox.Controls.Add(Me.TableLayoutPanel5)
        Me.SearchesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchesGroupBox.Location = New System.Drawing.Point(693, 260)
        Me.SearchesGroupBox.Name = "SearchesGroupBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.SearchesGroupBox, 2)
        Me.SearchesGroupBox.Size = New System.Drawing.Size(188, 252)
        Me.SearchesGroupBox.TabIndex = 6
        Me.SearchesGroupBox.TabStop = False
        Me.SearchesGroupBox.Text = "Searches"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.EditSearchesButton, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.SearchesTextBox, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(182, 233)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'EditSearchesButton
        '
        Me.EditSearchesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditSearchesButton.Location = New System.Drawing.Point(3, 207)
        Me.EditSearchesButton.Name = "EditSearchesButton"
        Me.EditSearchesButton.Size = New System.Drawing.Size(176, 23)
        Me.EditSearchesButton.TabIndex = 0
        Me.EditSearchesButton.Text = "Edit Searches"
        Me.EditSearchesButton.UseVisualStyleBackColor = True
        '
        'SearchesTextBox
        '
        Me.SearchesTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchesTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SearchesTextBox.Multiline = True
        Me.SearchesTextBox.Name = "SearchesTextBox"
        Me.SearchesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SearchesTextBox.Size = New System.Drawing.Size(176, 198)
        Me.SearchesTextBox.TabIndex = 1
        '
        'RoomEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "RoomEditor"
        Me.Text = "Dead Souls Room Editor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.EntersGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ExitsGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.SoundsGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.RoomDescriptionGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.RoomSettingsGroupBox.ResumeLayout(False)
        Me.RoomSettingsGroupBox.PerformLayout()
        CType(Me.LightLevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GravityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CodeButtonsGroupBox.ResumeLayout(False)
        Me.ItemsGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.SmellsGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.SearchesGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
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
    Friend WithEvents NightDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ClimateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LightLevelIndicatorLabel As System.Windows.Forms.Label
    Friend WithEvents LightLevelTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GravityDisplayLabel As System.Windows.Forms.Label
    Friend WithEvents GravityTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CodeButtonsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EditLPCCodeButton As System.Windows.Forms.Button
    Friend WithEvents ItemsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SmellsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SoundsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditSoundsButton As System.Windows.Forms.Button
    Friend WithEvents SoundsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditItemsButton As System.Windows.Forms.Button
    Friend WithEvents ItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditSmellsButton As System.Windows.Forms.Button
    Friend WithEvents SmellsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditSearchesButton As System.Windows.Forms.Button
    Friend WithEvents SearchesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EntersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditEntersButton As System.Windows.Forms.Button
    Friend WithEvents EntersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditExitsButton As System.Windows.Forms.Button
    Friend WithEvents ExitsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SaveRoomAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
