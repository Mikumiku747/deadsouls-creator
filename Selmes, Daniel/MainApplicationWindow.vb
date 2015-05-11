''' <summary>
''' The main startup application for the deadsouls-creator software
''' This provides lists of game files so you can easily open them for editing, and manages the locations of game files, so that the individual modules don't have to locate them.
''' </summary>
Public Class MainApplicationWindow

    Private Sub MainApplicationWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check deadsouls installation path
        If My.Settings.deadsouls_installation_path = "" Then
            Dim path_dialog As New ds_path_dialog
            path_dialog.ShowDialog()
        End If

        Debug.Print("Deadsouls Path: " & My.Settings.deadsouls_installation_path)

        'Select the "create new [thing]" option by default for all the file lists
        RoomsListBox.SelectedItem = "Build new room..."
        NPCListBox.SelectedItem = "Make new NPC..."
        ShopkeeperListBox.SelectedItem = "Make new merchant..."
        WeaponsListBox.SelectedItem = "Forge new weapon..."
        ArmourListBox.SelectedItem = "Forge new armour..."
        ItemListBox.SelectedItem = "Craft new item..."

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub EditRoomButton_Click(sender As Object, e As EventArgs) Handles EditRoomButton.Click
        If RoomsListBox.SelectedItem = "Build new room..." Then
            'Create a new room
            Dim roomeditor As New RoomEditor()
            roomeditor.Show()
        Else
            'Open the selected room in the room editor
            Dim roomeditor As New RoomEditor()
            roomeditor.filePath = "C:\ds\lib\domains\" + RoomsListBox.SelectedItem
            roomeditor.Show()
        End If
    End Sub

    Private Sub EditNPCButton_Click(sender As Object, e As EventArgs) Handles EditNPCButton.Click
        If NPCListBox.SelectedItem = "Make new NPC..." Then
            'Create a new NPC
            MsgBox("Creating a new NPC in NPC editor...")
            Dim editor As New NPCEditor
            NPCEditor.Show()
        Else
            'Open the selected NPC in the NPC editor
            MsgBox("Opening file " + NPCListBox.SelectedItem.ToString() + " in NPC editor...")
            Dim editor As New NPCEditor
            NPCEditor.Show()
        End If
    End Sub

    Private Sub EditShopkeeperButton_Click(sender As Object, e As EventArgs) Handles EditShopkeeperButton.Click
        If ShopkeeperListBox.SelectedItem = "Make new merchant..." Then
            'Create a new NPC
            MsgBox("Creating a new shopkeeper in shopkeeper editor...")
        Else
            'Open the selected NPC in the NPC editor
            MsgBox("Opening file " + ShopkeeperListBox.SelectedItem.ToString() + " in shopkeeper editor...")
        End If
    End Sub

    Private Sub EditWeaponButton_Click(sender As Object, e As EventArgs) Handles EditWeaponButton.Click
        If WeaponsListBox.SelectedItem = "Forge new weapon..." Then
            'Create a new weapon
            MsgBox("Creating a new weapon in weapon editor...")
        Else
            'Open the selected weapon in the weapon editor
            MsgBox("Opening file " + WeaponsListBox.SelectedItem.ToString() + " in weapon editor...")
        End If
    End Sub

    Private Sub EditArmourButton_Click(sender As Object, e As EventArgs) Handles EditArmourButton.Click
        If ArmourListBox.SelectedItem = "Forge new armour..." Then
            'Create new armour
            MsgBox("Creating new armour in armour editor...")
        Else
            'Open the selected armour in the armour editor
            MsgBox("Opening file " + ArmourListBox.SelectedItem.ToString() + " in armour editor...")
        End If
    End Sub

    Private Sub DeadsoulsInstallationPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeadsoulsInstallationPathToolStripMenuItem.Click
        Dim path_dialog As New ds_path_dialog
        path_dialog.ShowDialog()
    End Sub

    Private Sub EditItemButton_Click(sender As Object, e As EventArgs) Handles EditItemButton.Click
        If ItemListBox.SelectedItem = "Craft new item..." Then
            'Create new item
            MsgBox("Creating new item in item editor...")
        Else
            'Open the selected item in the armour editor
            MsgBox("Opening file " + ItemListBox.SelectedItem.ToString() + " in item editor...")
        End If
    End Sub
End Class