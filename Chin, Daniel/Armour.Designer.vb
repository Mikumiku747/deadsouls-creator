<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Armour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Armour))
        Me.StatusLabel = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewArmourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenArmourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveArmourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.armType = New System.Windows.Forms.TextBox()
        Me.armHp = New System.Windows.Forms.TextBox()
        Me.armDamageType = New System.Windows.Forms.ComboBox()
        Me.armID = New System.Windows.Forms.TextBox()
        Me.armName = New System.Windows.Forms.TextBox()
        Me.DamageType = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.armMass = New System.Windows.Forms.TextBox()
        Me.WeaponName = New System.Windows.Forms.Label()
        Me.armHitpoints = New System.Windows.Forms.Label()
        Me.Mass = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.armLongDesc = New System.Windows.Forms.TextBox()
        Me.armShortDesc = New System.Windows.Forms.TextBox()
        Me.armAdjectives = New System.Windows.Forms.TextBox()
        Me.LongDesc = New System.Windows.Forms.Label()
        Me.ShortDesc = New System.Windows.Forms.Label()
        Me.Adjectives = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.EditLPCCodeButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(0, 437)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(459, 22)
        Me.StatusLabel.TabIndex = 4
        Me.StatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(459, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewArmourToolStripMenuItem, Me.OpenArmourToolStripMenuItem, Me.SaveArmourToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIleToolStripMenuItem.Text = "File"
        '
        'NewArmourToolStripMenuItem
        '
        Me.NewArmourToolStripMenuItem.Name = "NewArmourToolStripMenuItem"
        Me.NewArmourToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NewArmourToolStripMenuItem.Text = "New Armour"
        '
        'OpenArmourToolStripMenuItem
        '
        Me.OpenArmourToolStripMenuItem.Name = "OpenArmourToolStripMenuItem"
        Me.OpenArmourToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.OpenArmourToolStripMenuItem.Text = "Open Armour"
        '
        'SaveArmourToolStripMenuItem
        '
        Me.SaveArmourToolStripMenuItem.Name = "SaveArmourToolStripMenuItem"
        Me.SaveArmourToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SaveArmourToolStripMenuItem.Text = "Save Armour"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.2477!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.75229!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(436, 396)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.armType)
        Me.GroupBox1.Controls.Add(Me.armHp)
        Me.GroupBox1.Controls.Add(Me.armDamageType)
        Me.GroupBox1.Controls.Add(Me.armID)
        Me.GroupBox1.Controls.Add(Me.armName)
        Me.GroupBox1.Controls.Add(Me.DamageType)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.armMass)
        Me.GroupBox1.Controls.Add(Me.WeaponName)
        Me.GroupBox1.Controls.Add(Me.armHitpoints)
        Me.GroupBox1.Controls.Add(Me.Mass)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ARmour Identifier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ArmourType"
        '
        'armType
        '
        Me.armType.Location = New System.Drawing.Point(170, 153)
        Me.armType.Name = "armType"
        Me.armType.Size = New System.Drawing.Size(100, 20)
        Me.armType.TabIndex = 11
        '
        'armHp
        '
        Me.armHp.Location = New System.Drawing.Point(170, 96)
        Me.armHp.Name = "armHp"
        Me.armHp.Size = New System.Drawing.Size(100, 20)
        Me.armHp.TabIndex = 10
        '
        'armDamageType
        '
        Me.armDamageType.FormattingEnabled = True
        Me.armDamageType.Items.AddRange(New Object() {"BLUNT", "BLADE", "KNIFE", "WATER", "SHOCK", "COLD", "HEAT", "GAS", "ACID", "MAGIC", "POISON", "DISEASE", "TRAUMA", "PIERCE", "PSIONIC", "ANOXIA", "DEATHRAY", "EMOTIONAL", "SONIC", "EMP", "OTHER", "KARMA", "DRAMA", "OVERPRESSURE", "UNDERPRESSURE", "INERTIA"})
        Me.armDamageType.Location = New System.Drawing.Point(10, 152)
        Me.armDamageType.Name = "armDamageType"
        Me.armDamageType.Size = New System.Drawing.Size(141, 21)
        Me.armDamageType.TabIndex = 9
        '
        'armID
        '
        Me.armID.Location = New System.Drawing.Point(170, 36)
        Me.armID.Name = "armID"
        Me.armID.Size = New System.Drawing.Size(100, 20)
        Me.armID.TabIndex = 3
        '
        'armName
        '
        Me.armName.Location = New System.Drawing.Point(13, 36)
        Me.armName.Name = "armName"
        Me.armName.Size = New System.Drawing.Size(138, 20)
        Me.armName.TabIndex = 2
        '
        'DamageType
        '
        Me.DamageType.AutoSize = True
        Me.DamageType.Location = New System.Drawing.Point(10, 129)
        Me.DamageType.Name = "DamageType"
        Me.DamageType.Size = New System.Drawing.Size(71, 13)
        Me.DamageType.TabIndex = 2
        Me.DamageType.Text = "DamageType"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(171, 16)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 1
        Me.ID.Text = "ID"
        '
        'armMass
        '
        Me.armMass.Location = New System.Drawing.Point(10, 96)
        Me.armMass.Name = "armMass"
        Me.armMass.Size = New System.Drawing.Size(141, 20)
        Me.armMass.TabIndex = 4
        '
        'WeaponName
        '
        Me.WeaponName.AutoSize = True
        Me.WeaponName.Location = New System.Drawing.Point(7, 20)
        Me.WeaponName.Name = "WeaponName"
        Me.WeaponName.Size = New System.Drawing.Size(35, 13)
        Me.WeaponName.TabIndex = 0
        Me.WeaponName.Text = "Name"
        '
        'armHitpoints
        '
        Me.armHitpoints.AutoSize = True
        Me.armHitpoints.Location = New System.Drawing.Point(167, 80)
        Me.armHitpoints.Name = "armHitpoints"
        Me.armHitpoints.Size = New System.Drawing.Size(49, 13)
        Me.armHitpoints.TabIndex = 1
        Me.armHitpoints.Text = "HitPoints"
        '
        'Mass
        '
        Me.Mass.AutoSize = True
        Me.Mass.Location = New System.Drawing.Point(6, 80)
        Me.Mass.Name = "Mass"
        Me.Mass.Size = New System.Drawing.Size(32, 13)
        Me.Mass.TabIndex = 0
        Me.Mass.Text = "Mass"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.armLongDesc)
        Me.GroupBox2.Controls.Add(Me.armShortDesc)
        Me.GroupBox2.Controls.Add(Me.armAdjectives)
        Me.GroupBox2.Controls.Add(Me.LongDesc)
        Me.GroupBox2.Controls.Add(Me.ShortDesc)
        Me.GroupBox2.Controls.Add(Me.Adjectives)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Armour Description"
        '
        'armLongDesc
        '
        Me.armLongDesc.Location = New System.Drawing.Point(13, 122)
        Me.armLongDesc.Multiline = True
        Me.armLongDesc.Name = "armLongDesc"
        Me.armLongDesc.Size = New System.Drawing.Size(277, 64)
        Me.armLongDesc.TabIndex = 5
        '
        'armShortDesc
        '
        Me.armShortDesc.Location = New System.Drawing.Point(13, 83)
        Me.armShortDesc.Name = "armShortDesc"
        Me.armShortDesc.Size = New System.Drawing.Size(277, 20)
        Me.armShortDesc.TabIndex = 4
        '
        'armAdjectives
        '
        Me.armAdjectives.Location = New System.Drawing.Point(13, 36)
        Me.armAdjectives.Name = "armAdjectives"
        Me.armAdjectives.Size = New System.Drawing.Size(277, 20)
        Me.armAdjectives.TabIndex = 3
        '
        'LongDesc
        '
        Me.LongDesc.AutoSize = True
        Me.LongDesc.Location = New System.Drawing.Point(10, 106)
        Me.LongDesc.Name = "LongDesc"
        Me.LongDesc.Size = New System.Drawing.Size(87, 13)
        Me.LongDesc.TabIndex = 2
        Me.LongDesc.Text = "Long Description"
        '
        'ShortDesc
        '
        Me.ShortDesc.AutoSize = True
        Me.ShortDesc.Location = New System.Drawing.Point(7, 67)
        Me.ShortDesc.Name = "ShortDesc"
        Me.ShortDesc.Size = New System.Drawing.Size(85, 13)
        Me.ShortDesc.TabIndex = 1
        Me.ShortDesc.Text = "ShortDescription"
        '
        'Adjectives
        '
        Me.Adjectives.AutoSize = True
        Me.Adjectives.Location = New System.Drawing.Point(7, 20)
        Me.Adjectives.Name = "Adjectives"
        Me.Adjectives.Size = New System.Drawing.Size(56, 13)
        Me.Adjectives.TabIndex = 0
        Me.Adjectives.Text = "Adjectives"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EditLPCCodeButton)
        Me.GroupBox4.Location = New System.Drawing.Point(318, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(115, 192)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc"
        '
        'EditLPCCodeButton
        '
        Me.EditLPCCodeButton.Location = New System.Drawing.Point(6, 20)
        Me.EditLPCCodeButton.Name = "EditLPCCodeButton"
        Me.EditLPCCodeButton.Size = New System.Drawing.Size(104, 23)
        Me.EditLPCCodeButton.TabIndex = 2
        Me.EditLPCCodeButton.Text = "Edit  LPC"
        Me.EditLPCCodeButton.UseVisualStyleBackColor = True
        '
        'Armour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 459)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Armour"
        Me.Text = "Armour"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusLabel As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FIleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewArmourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenArmourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveArmourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents armDamageType As System.Windows.Forms.ComboBox
    Friend WithEvents armID As System.Windows.Forms.TextBox
    Friend WithEvents armName As System.Windows.Forms.TextBox
    Friend WithEvents DamageType As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents armMass As System.Windows.Forms.TextBox
    Friend WithEvents WeaponName As System.Windows.Forms.Label
    Friend WithEvents armHitpoints As System.Windows.Forms.Label
    Friend WithEvents Mass As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents armLongDesc As System.Windows.Forms.TextBox
    Friend WithEvents armShortDesc As System.Windows.Forms.TextBox
    Friend WithEvents armAdjectives As System.Windows.Forms.TextBox
    Friend WithEvents LongDesc As System.Windows.Forms.Label
    Friend WithEvents ShortDesc As System.Windows.Forms.Label
    Friend WithEvents Adjectives As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents EditLPCCodeButton As System.Windows.Forms.Button
    Friend WithEvents armHp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents armType As System.Windows.Forms.TextBox
End Class
