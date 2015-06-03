<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NPCEditor
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Language = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Classes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Race = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NPCEquipped = New System.Windows.Forms.TextBox()
        Me.equiplabel = New System.Windows.Forms.Label()
        Me.NPCObjects = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LongDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LongDescription = New System.Windows.Forms.Label()
        Me.Adjectives = New System.Windows.Forms.TextBox()
        Me.ShortDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CurrentHitPoints = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HitPoints = New System.Windows.Forms.TextBox()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.TrackBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.EditLPCCodeButton = New System.Windows.Forms.Button()
        Me.CombatCheck = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewNPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNPCFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveNPCFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusLabel = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.29921!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.70079!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox6, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.46696!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(707, 571)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Language)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Classes)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Race)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Name1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 267)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NPC Identity"
        '
        'Language
        '
        Me.Language.FormattingEnabled = True
        Me.Language.Location = New System.Drawing.Point(13, 240)
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(167, 21)
        Me.Language.TabIndex = 12
        Me.Language.Text = "Null"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Language"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Location = New System.Drawing.Point(11, 200)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(167, 21)
        Me.Gender.TabIndex = 10
        Me.Gender.Text = "Null"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Gender"
        '
        'Classes
        '
        Me.Classes.FormattingEnabled = True
        Me.Classes.Location = New System.Drawing.Point(11, 160)
        Me.Classes.Name = "Classes"
        Me.Classes.Size = New System.Drawing.Size(167, 21)
        Me.Classes.TabIndex = 8
        Me.Classes.Text = "Null"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Class"
        '
        'Race
        '
        Me.Race.FormattingEnabled = True
        Me.Race.Location = New System.Drawing.Point(10, 120)
        Me.Race.Name = "Race"
        Me.Race.Size = New System.Drawing.Size(167, 21)
        Me.Race.TabIndex = 6
        Me.Race.Text = "Human"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Race"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(10, 76)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(167, 20)
        Me.ID.TabIndex = 4
        Me.ID.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID"
        '
        'Name1
        '
        Me.Name1.Location = New System.Drawing.Point(10, 37)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(167, 20)
        Me.Name1.TabIndex = 1
        Me.Name1.Text = "Name of NPC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.NPCEquipped)
        Me.GroupBox2.Controls.Add(Me.equiplabel)
        Me.GroupBox2.Controls.Add(Me.NPCObjects)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(317, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 267)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NPC Inventory"
        '
        'NPCEquipped
        '
        Me.NPCEquipped.Location = New System.Drawing.Point(6, 119)
        Me.NPCEquipped.Multiline = True
        Me.NPCEquipped.Name = "NPCEquipped"
        Me.NPCEquipped.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NPCEquipped.Size = New System.Drawing.Size(193, 58)
        Me.NPCEquipped.TabIndex = 3
        Me.NPCEquipped.Text = "none"
        '
        'equiplabel
        '
        Me.equiplabel.AutoSize = True
        Me.equiplabel.Location = New System.Drawing.Point(6, 99)
        Me.equiplabel.Name = "equiplabel"
        Me.equiplabel.Size = New System.Drawing.Size(91, 13)
        Me.equiplabel.TabIndex = 2
        Me.equiplabel.Text = "Equipped Objects"
        '
        'NPCObjects
        '
        Me.NPCObjects.Location = New System.Drawing.Point(7, 37)
        Me.NPCObjects.Multiline = True
        Me.NPCObjects.Name = "NPCObjects"
        Me.NPCObjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NPCObjects.Size = New System.Drawing.Size(192, 59)
        Me.NPCObjects.TabIndex = 1
        Me.NPCObjects.Text = "nasty stuff, lit charge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Objects"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.LongDesc)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.LongDescription)
        Me.GroupBox3.Controls.Add(Me.Adjectives)
        Me.GroupBox3.Controls.Add(Me.ShortDescription)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 292)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NPC Description"
        '
        'LongDesc
        '
        Me.LongDesc.Location = New System.Drawing.Point(9, 164)
        Me.LongDesc.Multiline = True
        Me.LongDesc.Name = "LongDesc"
        Me.LongDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LongDesc.Size = New System.Drawing.Size(269, 68)
        Me.LongDesc.TabIndex = 12
        Me.LongDesc.Text = "The dog is biting ankles nursing its own nastiness under the floor boards of the " & _
    "pub it is said to have an army of mongrels"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Adjectives"
        '
        'LongDescription
        '
        Me.LongDescription.AutoSize = True
        Me.LongDescription.Location = New System.Drawing.Point(8, 148)
        Me.LongDescription.Name = "LongDescription"
        Me.LongDescription.Size = New System.Drawing.Size(85, 13)
        Me.LongDescription.TabIndex = 11
        Me.LongDescription.Text = "Long description"
        '
        'Adjectives
        '
        Me.Adjectives.Location = New System.Drawing.Point(10, 32)
        Me.Adjectives.Multiline = True
        Me.Adjectives.Name = "Adjectives"
        Me.Adjectives.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Adjectives.Size = New System.Drawing.Size(268, 43)
        Me.Adjectives.TabIndex = 6
        Me.Adjectives.Text = "viscous, nasty , black,  yellow"
        '
        'ShortDescription
        '
        Me.ShortDescription.Location = New System.Drawing.Point(9, 94)
        Me.ShortDescription.Multiline = True
        Me.ShortDescription.Name = "ShortDescription"
        Me.ShortDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShortDescription.Size = New System.Drawing.Size(269, 51)
        Me.ShortDescription.TabIndex = 10
        Me.ShortDescription.Text = "The dog is biting ankles nursing its own nastiness"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Short description"
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.CurrentHitPoints)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.HitPoints)
        Me.GroupBox4.Controls.Add(Me.LevelLabel)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Level)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(317, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 292)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NPC Stats"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Current Hitpoints"
        '
        'CurrentHitPoints
        '
        Me.CurrentHitPoints.Location = New System.Drawing.Point(14, 148)
        Me.CurrentHitPoints.Name = "CurrentHitPoints"
        Me.CurrentHitPoints.Size = New System.Drawing.Size(100, 20)
        Me.CurrentHitPoints.TabIndex = 5
        Me.CurrentHitPoints.Text = "35"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Max Hitpoints"
        '
        'HitPoints
        '
        Me.HitPoints.Location = New System.Drawing.Point(14, 96)
        Me.HitPoints.Name = "HitPoints"
        Me.HitPoints.Size = New System.Drawing.Size(100, 20)
        Me.HitPoints.TabIndex = 3
        Me.HitPoints.Text = "40"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(221, 35)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(13, 13)
        Me.LevelLabel.TabIndex = 2
        Me.LevelLabel.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Level"
        '
        'Level
        '
        Me.Level.Location = New System.Drawing.Point(14, 32)
        Me.Level.Maximum = 100
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(201, 45)
        Me.Level.TabIndex = 0
        Me.Level.TickFrequency = 10
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox6.Controls.Add(Me.EditLPCCodeButton)
        Me.GroupBox6.Controls.Add(Me.CombatCheck)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(561, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(143, 267)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "NPC Combat"
        '
        'EditLPCCodeButton
        '
        Me.EditLPCCodeButton.Location = New System.Drawing.Point(7, 35)
        Me.EditLPCCodeButton.Name = "EditLPCCodeButton"
        Me.EditLPCCodeButton.Size = New System.Drawing.Size(128, 23)
        Me.EditLPCCodeButton.TabIndex = 1
        Me.EditLPCCodeButton.Text = "Edit Action LPC"
        Me.EditLPCCodeButton.UseVisualStyleBackColor = True
        '
        'CombatCheck
        '
        Me.CombatCheck.AutoSize = True
        Me.CombatCheck.Checked = True
        Me.CombatCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CombatCheck.Location = New System.Drawing.Point(7, 20)
        Me.CombatCheck.Name = "CombatCheck"
        Me.CombatCheck.Size = New System.Drawing.Size(62, 17)
        Me.CombatCheck.TabIndex = 0
        Me.CombatCheck.Text = "Combat"
        Me.CombatCheck.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(738, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewNPCToolStripMenuItem, Me.OpenNPCFileToolStripMenuItem, Me.SaveNPCFileToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseFileToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'NewNPCToolStripMenuItem
        '
        Me.NewNPCToolStripMenuItem.Name = "NewNPCToolStripMenuItem"
        Me.NewNPCToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewNPCToolStripMenuItem.Text = " New NPC file"
        '
        'OpenNPCFileToolStripMenuItem
        '
        Me.OpenNPCFileToolStripMenuItem.Name = "OpenNPCFileToolStripMenuItem"
        Me.OpenNPCFileToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.OpenNPCFileToolStripMenuItem.Text = "Open NPC file"
        '
        'SaveNPCFileToolStripMenuItem
        '
        Me.SaveNPCFileToolStripMenuItem.Name = "SaveNPCFileToolStripMenuItem"
        Me.SaveNPCFileToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SaveNPCFileToolStripMenuItem.Text = "Save NPC file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(146, 6)
        '
        'CloseFileToolStripMenuItem
        '
        Me.CloseFileToolStripMenuItem.Name = "CloseFileToolStripMenuItem"
        Me.CloseFileToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CloseFileToolStripMenuItem.Text = "Close file"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'StatusLabel
        '
        Me.StatusLabel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusLabel.Location = New System.Drawing.Point(0, 539)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(738, 22)
        Me.StatusLabel.TabIndex = 10
        Me.StatusLabel.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(126, 17)
        Me.ToolStripStatusLabel1.Text = "Dead Souls NPC Editor"
        '
        'NPCEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(738, 561)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(500, 600)
        Me.Name = "NPCEditor"
        Me.Text = "NPC editor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusLabel.ResumeLayout(False)
        Me.StatusLabel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Name1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents equiplabel As System.Windows.Forms.Label
    Friend WithEvents NPCObjects As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NPCEquipped As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LongDesc As System.Windows.Forms.TextBox
    Friend WithEvents LongDescription As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Adjectives As System.Windows.Forms.TextBox
    Friend WithEvents ShortDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Race As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Classes As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Level As System.Windows.Forms.TrackBar
    Friend WithEvents LevelLabel As System.Windows.Forms.Label
    Friend WithEvents Language As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CurrentHitPoints As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents HitPoints As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CombatCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewNPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenNPCFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveNPCFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusLabel As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EditLPCCodeButton As System.Windows.Forms.Button

End Class
