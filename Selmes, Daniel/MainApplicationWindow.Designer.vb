<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApplicationWindow
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
        Me.NewDomainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDomainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRoomEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNPCEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenShopkeeperEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWeaponEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenArmourEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PublishDomainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportABugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EditRoomButton = New System.Windows.Forms.Button()
        Me.EditNPCButton = New System.Windows.Forms.Button()
        Me.EditShopkeeperButton = New System.Windows.Forms.Button()
        Me.EditWeaponButton = New System.Windows.Forms.Button()
        Me.EditArmourButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoomsListBox = New System.Windows.Forms.ListBox()
        Me.NPCListBox = New System.Windows.Forms.ListBox()
        Me.ShopkeeperListBox = New System.Windows.Forms.ListBox()
        Me.WeaponsListBox = New System.Windows.Forms.ListBox()
        Me.ArmourListBox = New System.Windows.Forms.ListBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.WindowStatusString = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ITEMEDITORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DomainToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ITEMEDITORToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDomainToolStripMenuItem, Me.OpenDomainToolStripMenuItem, Me.ToolStripSeparator1, Me.NewFileToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewDomainToolStripMenuItem
        '
        Me.NewDomainToolStripMenuItem.Name = "NewDomainToolStripMenuItem"
        Me.NewDomainToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NewDomainToolStripMenuItem.Text = "New Domain..."
        '
        'OpenDomainToolStripMenuItem
        '
        Me.OpenDomainToolStripMenuItem.Name = "OpenDomainToolStripMenuItem"
        Me.OpenDomainToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OpenDomainToolStripMenuItem.Text = "Open Domain..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NewFileToolStripMenuItem.Text = "New File..."
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(154, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Deadsouls_Creator.My.Resources.Resources.infoIcon
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = Global.Deadsouls_Creator.My.Resources.Resources.redCrossIcon
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'DomainToolStripMenuItem
        '
        Me.DomainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshFilesToolStripMenuItem, Me.OpenInExplorerToolStripMenuItem})
        Me.DomainToolStripMenuItem.Name = "DomainToolStripMenuItem"
        Me.DomainToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DomainToolStripMenuItem.Text = "Domain"
        '
        'RefreshFilesToolStripMenuItem
        '
        Me.RefreshFilesToolStripMenuItem.Name = "RefreshFilesToolStripMenuItem"
        Me.RefreshFilesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RefreshFilesToolStripMenuItem.Text = "Refresh files"
        '
        'OpenInExplorerToolStripMenuItem
        '
        Me.OpenInExplorerToolStripMenuItem.Name = "OpenInExplorerToolStripMenuItem"
        Me.OpenInExplorerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenInExplorerToolStripMenuItem.Text = "Open in explorer"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenRoomEditorToolStripMenuItem, Me.OpenNPCEditorToolStripMenuItem, Me.OpenShopkeeperEditorToolStripMenuItem, Me.OpenWeaponEditorToolStripMenuItem, Me.OpenArmourEditorToolStripMenuItem, Me.ToolStripSeparator3, Me.PublishDomainToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OpenRoomEditorToolStripMenuItem
        '
        Me.OpenRoomEditorToolStripMenuItem.Name = "OpenRoomEditorToolStripMenuItem"
        Me.OpenRoomEditorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenRoomEditorToolStripMenuItem.Text = "Open Room Editor"
        '
        'OpenNPCEditorToolStripMenuItem
        '
        Me.OpenNPCEditorToolStripMenuItem.Name = "OpenNPCEditorToolStripMenuItem"
        Me.OpenNPCEditorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenNPCEditorToolStripMenuItem.Text = "Open NPC Editor"
        '
        'OpenShopkeeperEditorToolStripMenuItem
        '
        Me.OpenShopkeeperEditorToolStripMenuItem.Name = "OpenShopkeeperEditorToolStripMenuItem"
        Me.OpenShopkeeperEditorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenShopkeeperEditorToolStripMenuItem.Text = "Open Shopkeeper Editor"
        '
        'OpenWeaponEditorToolStripMenuItem
        '
        Me.OpenWeaponEditorToolStripMenuItem.Name = "OpenWeaponEditorToolStripMenuItem"
        Me.OpenWeaponEditorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenWeaponEditorToolStripMenuItem.Text = "Open Weapon Editor"
        '
        'OpenArmourEditorToolStripMenuItem
        '
        Me.OpenArmourEditorToolStripMenuItem.Name = "OpenArmourEditorToolStripMenuItem"
        Me.OpenArmourEditorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenArmourEditorToolStripMenuItem.Text = "Open Armour Editor"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(199, 6)
        '
        'PublishDomainToolStripMenuItem
        '
        Me.PublishDomainToolStripMenuItem.Name = "PublishDomainToolStripMenuItem"
        Me.PublishDomainToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PublishDomainToolStripMenuItem.Text = "Publish domain..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.ReportABugToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Image = Global.Deadsouls_Creator.My.Resources.Resources.infoIcon
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Online Help..."
        '
        'ReportABugToolStripMenuItem
        '
        Me.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem"
        Me.ReportABugToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ReportABugToolStripMenuItem.Text = "Report a bug"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.EditRoomButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EditNPCButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EditShopkeeperButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EditWeaponButton, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EditArmourButton, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RoomsListBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NPCListBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ShopkeeperListBox, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.WeaponsListBox, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ArmourListBox, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 437)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'EditRoomButton
        '
        Me.EditRoomButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditRoomButton.Location = New System.Drawing.Point(3, 23)
        Me.EditRoomButton.Name = "EditRoomButton"
        Me.EditRoomButton.Size = New System.Drawing.Size(150, 23)
        Me.EditRoomButton.TabIndex = 0
        Me.EditRoomButton.Text = "Open in Room Editor"
        Me.EditRoomButton.UseVisualStyleBackColor = True
        '
        'EditNPCButton
        '
        Me.EditNPCButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditNPCButton.Location = New System.Drawing.Point(159, 23)
        Me.EditNPCButton.Name = "EditNPCButton"
        Me.EditNPCButton.Size = New System.Drawing.Size(150, 23)
        Me.EditNPCButton.TabIndex = 1
        Me.EditNPCButton.Text = "Open in NPC editor"
        Me.EditNPCButton.UseVisualStyleBackColor = True
        '
        'EditShopkeeperButton
        '
        Me.EditShopkeeperButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditShopkeeperButton.Location = New System.Drawing.Point(315, 23)
        Me.EditShopkeeperButton.Name = "EditShopkeeperButton"
        Me.EditShopkeeperButton.Size = New System.Drawing.Size(150, 23)
        Me.EditShopkeeperButton.TabIndex = 2
        Me.EditShopkeeperButton.Text = "Open in Merchant Editor"
        Me.EditShopkeeperButton.UseVisualStyleBackColor = True
        '
        'EditWeaponButton
        '
        Me.EditWeaponButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditWeaponButton.Location = New System.Drawing.Point(471, 23)
        Me.EditWeaponButton.Name = "EditWeaponButton"
        Me.EditWeaponButton.Size = New System.Drawing.Size(150, 23)
        Me.EditWeaponButton.TabIndex = 3
        Me.EditWeaponButton.Text = "Open in Weapon Editor"
        Me.EditWeaponButton.UseVisualStyleBackColor = True
        '
        'EditArmourButton
        '
        Me.EditArmourButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditArmourButton.Location = New System.Drawing.Point(627, 23)
        Me.EditArmourButton.Name = "EditArmourButton"
        Me.EditArmourButton.Size = New System.Drawing.Size(154, 23)
        Me.EditArmourButton.TabIndex = 4
        Me.EditArmourButton.Text = "Open in Armour Editor"
        Me.EditArmourButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rooms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(159, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NPCs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(315, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Merchants"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(471, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Weapons"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(627, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Armour"
        '
        'RoomsListBox
        '
        Me.RoomsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomsListBox.FormattingEnabled = True
        Me.RoomsListBox.Items.AddRange(New Object() {"Build new room...", "daniel\room\test.c", "town\room\bridge.c", "cave\room\freezer.c", "town\room\road0.c"})
        Me.RoomsListBox.Location = New System.Drawing.Point(3, 52)
        Me.RoomsListBox.Name = "RoomsListBox"
        Me.RoomsListBox.Size = New System.Drawing.Size(150, 360)
        Me.RoomsListBox.TabIndex = 10
        '
        'NPCListBox
        '
        Me.NPCListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NPCListBox.FormattingEnabled = True
        Me.NPCListBox.Items.AddRange(New Object() {"Make new NPC..."})
        Me.NPCListBox.Location = New System.Drawing.Point(159, 52)
        Me.NPCListBox.Name = "NPCListBox"
        Me.NPCListBox.Size = New System.Drawing.Size(150, 360)
        Me.NPCListBox.TabIndex = 11
        '
        'ShopkeeperListBox
        '
        Me.ShopkeeperListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShopkeeperListBox.FormattingEnabled = True
        Me.ShopkeeperListBox.Items.AddRange(New Object() {"Make new merchant..."})
        Me.ShopkeeperListBox.Location = New System.Drawing.Point(315, 52)
        Me.ShopkeeperListBox.Name = "ShopkeeperListBox"
        Me.ShopkeeperListBox.Size = New System.Drawing.Size(150, 360)
        Me.ShopkeeperListBox.TabIndex = 12
        '
        'WeaponsListBox
        '
        Me.WeaponsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WeaponsListBox.FormattingEnabled = True
        Me.WeaponsListBox.Items.AddRange(New Object() {"Forge new weapon..."})
        Me.WeaponsListBox.Location = New System.Drawing.Point(471, 52)
        Me.WeaponsListBox.Name = "WeaponsListBox"
        Me.WeaponsListBox.Size = New System.Drawing.Size(150, 360)
        Me.WeaponsListBox.TabIndex = 13
        '
        'ArmourListBox
        '
        Me.ArmourListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArmourListBox.FormattingEnabled = True
        Me.ArmourListBox.Items.AddRange(New Object() {"Forge new armour..."})
        Me.ArmourListBox.Location = New System.Drawing.Point(627, 52)
        Me.ArmourListBox.Name = "ArmourListBox"
        Me.ArmourListBox.Size = New System.Drawing.Size(154, 360)
        Me.ArmourListBox.TabIndex = 14
        '
        'StatusStrip
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip, 5)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowStatusString})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip.TabIndex = 15
        Me.StatusStrip.Text = "StatusStrip"
        '
        'WindowStatusString
        '
        Me.WindowStatusString.Name = "WindowStatusString"
        Me.WindowStatusString.Size = New System.Drawing.Size(107, 17)
        Me.WindowStatusString.Text = "Dead Souls Creator"
        '
        'ITEMEDITORToolStripMenuItem
        '
        Me.ITEMEDITORToolStripMenuItem.Name = "ITEMEDITORToolStripMenuItem"
        Me.ITEMEDITORToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ITEMEDITORToolStripMenuItem.Text = "ITEMEDITOR"
        '
        'MainApplicationWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainApplicationWindow"
        Me.Text = "Dead Souls Creator"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDomainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDomainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DomainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenRoomEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenNPCEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenShopkeeperEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenWeaponEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenArmourEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PublishDomainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditRoomButton As System.Windows.Forms.Button
    Friend WithEvents EditNPCButton As System.Windows.Forms.Button
    Friend WithEvents EditShopkeeperButton As System.Windows.Forms.Button
    Friend WithEvents EditWeaponButton As System.Windows.Forms.Button
    Friend WithEvents EditArmourButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RoomsListBox As System.Windows.Forms.ListBox
    Friend WithEvents NPCListBox As System.Windows.Forms.ListBox
    Friend WithEvents ShopkeeperListBox As System.Windows.Forms.ListBox
    Friend WithEvents WeaponsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ArmourListBox As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents WindowStatusString As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportABugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITEMEDITORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
