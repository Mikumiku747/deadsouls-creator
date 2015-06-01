<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemEditor))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KeyNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShortNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdjectivesTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MassNumBox = New System.Windows.Forms.NumericUpDown()
        Me.DamageNumBox = New System.Windows.Forms.NumericUpDown()
        Me.ValueNumBox = New System.Windows.Forms.NumericUpDown()
        Me.DestroySellCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditLPCCodeButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.AllTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.WeaponTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.ArmourTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.LightTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.FoodTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.DrinkTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.MagicTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.FishingTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.PlantTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.HerbTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.ContrabandTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.TreasureTypeTextBox = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveItemAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.MassNumBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageNumBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValueNumBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 2)
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.KeyNameTextBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ShortNameTextBox, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.IDTextBox, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.AdjectivesTextBox, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.DescriptionTextBox, 0, 9)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'KeyNameTextBox
        '
        resources.ApplyResources(Me.KeyNameTextBox, "KeyNameTextBox")
        Me.KeyNameTextBox.Name = "KeyNameTextBox"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'ShortNameTextBox
        '
        resources.ApplyResources(Me.ShortNameTextBox, "ShortNameTextBox")
        Me.ShortNameTextBox.Name = "ShortNameTextBox"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'IDTextBox
        '
        resources.ApplyResources(Me.IDTextBox, "IDTextBox")
        Me.IDTextBox.Name = "IDTextBox"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'AdjectivesTextBox
        '
        resources.ApplyResources(Me.AdjectivesTextBox, "AdjectivesTextBox")
        Me.AdjectivesTextBox.Name = "AdjectivesTextBox"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'DescriptionTextBox
        '
        resources.ApplyResources(Me.DescriptionTextBox, "DescriptionTextBox")
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'TableLayoutPanel3
        '
        resources.ApplyResources(Me.TableLayoutPanel3, "TableLayoutPanel3")
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.MassNumBox, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DamageNumBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ValueNumBox, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.DestroySellCheckBox, 0, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'MassNumBox
        '
        resources.ApplyResources(Me.MassNumBox, "MassNumBox")
        Me.MassNumBox.Name = "MassNumBox"
        Me.MassNumBox.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'DamageNumBox
        '
        resources.ApplyResources(Me.DamageNumBox, "DamageNumBox")
        Me.DamageNumBox.Name = "DamageNumBox"
        Me.DamageNumBox.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'ValueNumBox
        '
        resources.ApplyResources(Me.ValueNumBox, "ValueNumBox")
        Me.ValueNumBox.Name = "ValueNumBox"
        Me.ValueNumBox.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'DestroySellCheckBox
        '
        resources.ApplyResources(Me.DestroySellCheckBox, "DestroySellCheckBox")
        Me.TableLayoutPanel3.SetColumnSpan(Me.DestroySellCheckBox, 2)
        Me.DestroySellCheckBox.Name = "DestroySellCheckBox"
        Me.DestroySellCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'TableLayoutPanel4
        '
        resources.ApplyResources(Me.TableLayoutPanel4, "TableLayoutPanel4")
        Me.TableLayoutPanel4.Controls.Add(Me.EditLPCCodeButton, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.StatusStrip, 0, 1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        '
        'EditLPCCodeButton
        '
        resources.ApplyResources(Me.EditLPCCodeButton, "EditLPCCodeButton")
        Me.EditLPCCodeButton.Name = "EditLPCCodeButton"
        Me.EditLPCCodeButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        resources.ApplyResources(Me.StatusLabel, "StatusLabel")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel5)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox4, 2)
        Me.GroupBox4.TabStop = False
        '
        'TableLayoutPanel5
        '
        resources.ApplyResources(Me.TableLayoutPanel5, "TableLayoutPanel5")
        Me.TableLayoutPanel5.Controls.Add(Me.AllTypeTextBox, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.WeaponTypeTextBox, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ArmourTypeTextBox, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.LightTypeTextBox, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.FoodTypeTextBox, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.DrinkTypeTextBox, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.MagicTypeTextBox, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.FishingTypeTextBox, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.PlantTypeTextBox, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.HerbTypeTextBox, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.ContrabandTypeTextBox, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.TreasureTypeTextBox, 1, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        '
        'AllTypeTextBox
        '
        resources.ApplyResources(Me.AllTypeTextBox, "AllTypeTextBox")
        Me.AllTypeTextBox.Name = "AllTypeTextBox"
        Me.AllTypeTextBox.Tag = "typecheckbox"
        Me.AllTypeTextBox.UseVisualStyleBackColor = True
        '
        'WeaponTypeTextBox
        '
        resources.ApplyResources(Me.WeaponTypeTextBox, "WeaponTypeTextBox")
        Me.WeaponTypeTextBox.Name = "WeaponTypeTextBox"
        Me.WeaponTypeTextBox.UseVisualStyleBackColor = True
        '
        'ArmourTypeTextBox
        '
        resources.ApplyResources(Me.ArmourTypeTextBox, "ArmourTypeTextBox")
        Me.ArmourTypeTextBox.Name = "ArmourTypeTextBox"
        Me.ArmourTypeTextBox.UseVisualStyleBackColor = True
        '
        'LightTypeTextBox
        '
        resources.ApplyResources(Me.LightTypeTextBox, "LightTypeTextBox")
        Me.LightTypeTextBox.Name = "LightTypeTextBox"
        Me.LightTypeTextBox.UseVisualStyleBackColor = True
        '
        'FoodTypeTextBox
        '
        resources.ApplyResources(Me.FoodTypeTextBox, "FoodTypeTextBox")
        Me.FoodTypeTextBox.Name = "FoodTypeTextBox"
        Me.FoodTypeTextBox.UseVisualStyleBackColor = True
        '
        'DrinkTypeTextBox
        '
        resources.ApplyResources(Me.DrinkTypeTextBox, "DrinkTypeTextBox")
        Me.DrinkTypeTextBox.Name = "DrinkTypeTextBox"
        Me.DrinkTypeTextBox.UseVisualStyleBackColor = True
        '
        'MagicTypeTextBox
        '
        resources.ApplyResources(Me.MagicTypeTextBox, "MagicTypeTextBox")
        Me.MagicTypeTextBox.Name = "MagicTypeTextBox"
        Me.MagicTypeTextBox.UseVisualStyleBackColor = True
        '
        'FishingTypeTextBox
        '
        resources.ApplyResources(Me.FishingTypeTextBox, "FishingTypeTextBox")
        Me.FishingTypeTextBox.Name = "FishingTypeTextBox"
        Me.FishingTypeTextBox.UseVisualStyleBackColor = True
        '
        'PlantTypeTextBox
        '
        resources.ApplyResources(Me.PlantTypeTextBox, "PlantTypeTextBox")
        Me.PlantTypeTextBox.Name = "PlantTypeTextBox"
        Me.PlantTypeTextBox.UseVisualStyleBackColor = True
        '
        'HerbTypeTextBox
        '
        resources.ApplyResources(Me.HerbTypeTextBox, "HerbTypeTextBox")
        Me.HerbTypeTextBox.Name = "HerbTypeTextBox"
        Me.HerbTypeTextBox.UseVisualStyleBackColor = True
        '
        'ContrabandTypeTextBox
        '
        resources.ApplyResources(Me.ContrabandTypeTextBox, "ContrabandTypeTextBox")
        Me.ContrabandTypeTextBox.Name = "ContrabandTypeTextBox"
        Me.ContrabandTypeTextBox.UseVisualStyleBackColor = True
        '
        'TreasureTypeTextBox
        '
        resources.ApplyResources(Me.TreasureTypeTextBox, "TreasureTypeTextBox")
        Me.TreasureTypeTextBox.Name = "TreasureTypeTextBox"
        Me.TreasureTypeTextBox.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ItemTypesToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewItemToolStripMenuItem, Me.OpenItemToolStripMenuItem, Me.SaveItemToolStripMenuItem, Me.SaveItemAsToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        resources.ApplyResources(Me.NewItemToolStripMenuItem, "NewItemToolStripMenuItem")
        '
        'OpenItemToolStripMenuItem
        '
        Me.OpenItemToolStripMenuItem.Name = "OpenItemToolStripMenuItem"
        resources.ApplyResources(Me.OpenItemToolStripMenuItem, "OpenItemToolStripMenuItem")
        '
        'SaveItemToolStripMenuItem
        '
        Me.SaveItemToolStripMenuItem.Name = "SaveItemToolStripMenuItem"
        resources.ApplyResources(Me.SaveItemToolStripMenuItem, "SaveItemToolStripMenuItem")
        '
        'SaveItemAsToolStripMenuItem
        '
        Me.SaveItemAsToolStripMenuItem.Name = "SaveItemAsToolStripMenuItem"
        resources.ApplyResources(Me.SaveItemAsToolStripMenuItem, "SaveItemAsToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        resources.ApplyResources(Me.QuitToolStripMenuItem, "QuitToolStripMenuItem")
        '
        'ItemTypesToolStripMenuItem
        '
        Me.ItemTypesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiscAllToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ItemTypesToolStripMenuItem.Name = "ItemTypesToolStripMenuItem"
        resources.ApplyResources(Me.ItemTypesToolStripMenuItem, "ItemTypesToolStripMenuItem")
        '
        'MiscAllToolStripMenuItem
        '
        Me.MiscAllToolStripMenuItem.Name = "MiscAllToolStripMenuItem"
        resources.ApplyResources(Me.MiscAllToolStripMenuItem, "MiscAllToolStripMenuItem")
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        resources.ApplyResources(Me.ClearToolStripMenuItem, "ClearToolStripMenuItem")
        '
        'ItemEditor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ItemEditor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.MassNumBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageNumBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValueNumBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveItemAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KeyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShortNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdjectivesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MassNumBox As NumericUpDown
    Friend WithEvents DamageNumBox As NumericUpDown
    Friend WithEvents ValueNumBox As NumericUpDown
    Friend WithEvents DestroySellCheckBox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents EditLPCCodeButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents AllTypeTextBox As CheckBox
    Friend WithEvents WeaponTypeTextBox As CheckBox
    Friend WithEvents ArmourTypeTextBox As CheckBox
    Friend WithEvents LightTypeTextBox As CheckBox
    Friend WithEvents FoodTypeTextBox As CheckBox
    Friend WithEvents DrinkTypeTextBox As CheckBox
    Friend WithEvents MagicTypeTextBox As CheckBox
    Friend WithEvents FishingTypeTextBox As CheckBox
    Friend WithEvents PlantTypeTextBox As CheckBox
    Friend WithEvents HerbTypeTextBox As CheckBox
    Friend WithEvents ContrabandTypeTextBox As CheckBox
    Friend WithEvents TreasureTypeTextBox As CheckBox
    Friend WithEvents ItemTypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
End Class
