<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeaponEditor
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
        Me.StatusLabel = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWeaponToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWeaponToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveWeaponToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.wepID = New System.Windows.Forms.TextBox()
        Me.wepName = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.WeaponName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.wepLongDesc = New System.Windows.Forms.TextBox()
        Me.wepShortDesc = New System.Windows.Forms.TextBox()
        Me.wepAdjectives = New System.Windows.Forms.TextBox()
        Me.LongDesc = New System.Windows.Forms.Label()
        Me.ShortDesc = New System.Windows.Forms.Label()
        Me.Adjectives = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.wepDamageType = New System.Windows.Forms.ComboBox()
        Me.wepClassType = New System.Windows.Forms.ComboBox()
        Me.wepType = New System.Windows.Forms.TextBox()
        Me.wepMass = New System.Windows.Forms.TextBox()
        Me.wepType2 = New System.Windows.Forms.Label()
        Me.DamageType = New System.Windows.Forms.Label()
        Me.wepClass = New System.Windows.Forms.Label()
        Me.Mass = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(0, 434)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(646, 22)
        Me.StatusLabel.TabIndex = 1
        Me.StatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWeaponToolStripMenuItem, Me.OpenWeaponToolStripMenuItem, Me.SaveWeaponToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIleToolStripMenuItem.Text = "File"
        '
        'NewWeaponToolStripMenuItem
        '
        Me.NewWeaponToolStripMenuItem.Name = "NewWeaponToolStripMenuItem"
        Me.NewWeaponToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NewWeaponToolStripMenuItem.Text = "New Weapon"
        '
        'OpenWeaponToolStripMenuItem
        '
        Me.OpenWeaponToolStripMenuItem.Name = "OpenWeaponToolStripMenuItem"
        Me.OpenWeaponToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OpenWeaponToolStripMenuItem.Text = "Open Weapon"
        '
        'SaveWeaponToolStripMenuItem
        '
        Me.SaveWeaponToolStripMenuItem.Name = "SaveWeaponToolStripMenuItem"
        Me.SaveWeaponToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SaveWeaponToolStripMenuItem.Text = "Save Weapon"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.85944!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.14056!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(622, 396)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.wepID)
        Me.GroupBox1.Controls.Add(Me.wepName)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.WeaponName)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weapon Identifier"
        '
        'wepID
        '
        Me.wepID.Location = New System.Drawing.Point(13, 78)
        Me.wepID.Name = "wepID"
        Me.wepID.Size = New System.Drawing.Size(100, 20)
        Me.wepID.TabIndex = 3
        '
        'wepName
        '
        Me.wepName.Location = New System.Drawing.Point(13, 36)
        Me.wepName.Name = "wepName"
        Me.wepName.Size = New System.Drawing.Size(100, 20)
        Me.wepName.TabIndex = 2
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(6, 60)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 1
        Me.ID.Text = "ID"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.wepLongDesc)
        Me.GroupBox2.Controls.Add(Me.wepShortDesc)
        Me.GroupBox2.Controls.Add(Me.wepAdjectives)
        Me.GroupBox2.Controls.Add(Me.LongDesc)
        Me.GroupBox2.Controls.Add(Me.ShortDesc)
        Me.GroupBox2.Controls.Add(Me.Adjectives)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weapon Description"
        '
        'wepLongDesc
        '
        Me.wepLongDesc.Location = New System.Drawing.Point(13, 125)
        Me.wepLongDesc.Name = "wepLongDesc"
        Me.wepLongDesc.Size = New System.Drawing.Size(378, 20)
        Me.wepLongDesc.TabIndex = 5
        '
        'wepShortDesc
        '
        Me.wepShortDesc.Location = New System.Drawing.Point(13, 85)
        Me.wepShortDesc.Name = "wepShortDesc"
        Me.wepShortDesc.Size = New System.Drawing.Size(378, 20)
        Me.wepShortDesc.TabIndex = 4
        '
        'wepAdjectives
        '
        Me.wepAdjectives.Location = New System.Drawing.Point(13, 36)
        Me.wepAdjectives.Name = "wepAdjectives"
        Me.wepAdjectives.Size = New System.Drawing.Size(378, 20)
        Me.wepAdjectives.TabIndex = 3
        '
        'LongDesc
        '
        Me.LongDesc.AutoSize = True
        Me.LongDesc.Location = New System.Drawing.Point(10, 108)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.wepDamageType)
        Me.GroupBox3.Controls.Add(Me.wepClassType)
        Me.GroupBox3.Controls.Add(Me.wepType)
        Me.GroupBox3.Controls.Add(Me.wepMass)
        Me.GroupBox3.Controls.Add(Me.wepType2)
        Me.GroupBox3.Controls.Add(Me.DamageType)
        Me.GroupBox3.Controls.Add(Me.wepClass)
        Me.GroupBox3.Controls.Add(Me.Mass)
        Me.GroupBox3.Location = New System.Drawing.Point(406, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(195, 192)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Weapon Atributes"
        '
        'wepDamageType
        '
        Me.wepDamageType.FormattingEnabled = True
        Me.wepDamageType.Location = New System.Drawing.Point(10, 121)
        Me.wepDamageType.Name = "wepDamageType"
        Me.wepDamageType.Size = New System.Drawing.Size(121, 21)
        Me.wepDamageType.TabIndex = 9
        '
        'wepClassType
        '
        Me.wepClassType.FormattingEnabled = True
        Me.wepClassType.Location = New System.Drawing.Point(10, 77)
        Me.wepClassType.Name = "wepClassType"
        Me.wepClassType.Size = New System.Drawing.Size(121, 21)
        Me.wepClassType.TabIndex = 8
        '
        'wepType
        '
        Me.wepType.Location = New System.Drawing.Point(10, 172)
        Me.wepType.Name = "wepType"
        Me.wepType.Size = New System.Drawing.Size(121, 20)
        Me.wepType.TabIndex = 7
        '
        'wepMass
        '
        Me.wepMass.Location = New System.Drawing.Point(10, 36)
        Me.wepMass.Name = "wepMass"
        Me.wepMass.Size = New System.Drawing.Size(121, 20)
        Me.wepMass.TabIndex = 4
        '
        'wepType2
        '
        Me.wepType2.AutoSize = True
        Me.wepType2.Location = New System.Drawing.Point(7, 152)
        Me.wepType2.Name = "wepType2"
        Me.wepType2.Size = New System.Drawing.Size(75, 13)
        Me.wepType2.TabIndex = 3
        Me.wepType2.Text = "Weapon Type"
        '
        'DamageType
        '
        Me.DamageType.AutoSize = True
        Me.DamageType.Location = New System.Drawing.Point(7, 105)
        Me.DamageType.Name = "DamageType"
        Me.DamageType.Size = New System.Drawing.Size(71, 13)
        Me.DamageType.TabIndex = 2
        Me.DamageType.Text = "DamageType"
        '
        'wepClass
        '
        Me.wepClass.AutoSize = True
        Me.wepClass.Location = New System.Drawing.Point(7, 59)
        Me.wepClass.Name = "wepClass"
        Me.wepClass.Size = New System.Drawing.Size(32, 13)
        Me.wepClass.TabIndex = 1
        Me.wepClass.Text = "Class"
        '
        'Mass
        '
        Me.Mass.AutoSize = True
        Me.Mass.Location = New System.Drawing.Point(7, 20)
        Me.Mass.Name = "Mass"
        Me.Mass.Size = New System.Drawing.Size(32, 13)
        Me.Mass.TabIndex = 0
        Me.Mass.Text = "Mass"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(406, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(195, 192)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc"
        '
        'WeaponEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 456)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WeaponEditor"
        Me.Text = "WeaponEditor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusLabel As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FIleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWeaponToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenWeaponToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveWeaponToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents WeaponName As System.Windows.Forms.Label
    Friend WithEvents wepType2 As System.Windows.Forms.Label
    Friend WithEvents DamageType As System.Windows.Forms.Label
    Friend WithEvents wepClass As System.Windows.Forms.Label
    Friend WithEvents Mass As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LongDesc As System.Windows.Forms.Label
    Friend WithEvents ShortDesc As System.Windows.Forms.Label
    Friend WithEvents Adjectives As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents wepID As System.Windows.Forms.TextBox
    Friend WithEvents wepName As System.Windows.Forms.TextBox
    Friend WithEvents wepLongDesc As System.Windows.Forms.TextBox
    Friend WithEvents wepShortDesc As System.Windows.Forms.TextBox
    Friend WithEvents wepAdjectives As System.Windows.Forms.TextBox
    Friend WithEvents wepDamageType As System.Windows.Forms.ComboBox
    Friend WithEvents wepClassType As System.Windows.Forms.ComboBox
    Friend WithEvents wepType As System.Windows.Forms.TextBox
    Friend WithEvents wepMass As System.Windows.Forms.TextBox

End Class
