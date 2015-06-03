''' <summary>
''' An application for editing LPC item files
''' </summary>
''' <remarks>You can provide a file to open with the filePath member</remarks>
Public Class ItemEditor

    ''' <summary>
    ''' Set this to a file you want to open for editing
    ''' </summary>
    ''' <remarks></remarks>
    Public filePath As String

    Dim file As String

    Private Sub ItemEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If filePath = "" Then
            Try
                filePath = My.Computer.FileSystem.CurrentDirectory & "\Resources\ItemTemplate.c"
                file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
                loadFromFile()
                filePath = "NEW"
            Catch ex As Exception
                MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
            End Try
        Else
            Text = filePath & " - Item editor - Deadsouls Creator"
            loadFromFile()
        End If
    End Sub

    Private Sub loadFromFile()
        'Load the file
        Try
            file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
        Catch ex As StringNotFoundException
            MsgBox("Failed to open the file, check that it exists and you have read/write access.", MsgBoxStyle.Critical, "Error opening file")
            EZLogging.WriteToLog("Failed to load file " & filePath & ". Exiting item editor", levels.critical)
            Close()
            Return
        End Try
        'Load all the properties
        Try
            KeyNameTextBox.Text = GetBetween(file, "SetKeyName(""", """);")
        Catch ex As StringNotFoundException
            KeyNameTextBox.Text = "itemname"
        End Try
        Try
            ShortNameTextBox.Text = GetBetween(file, "SetShort(""", """);")
        Catch ex As StringNotFoundException
            ShortNameTextBox.Text = "an itemname"
        End Try
        Try
            DescriptionTextBox.Text = DeQuote(GetBetween(file, "SetLong(", ");"))
        Catch ex As StringNotFoundException
            DescriptionTextBox.Text = "An item so generic you can't make out a songle distinguishable feature on it. It's really strange actually."
        End Try
        Try
            IDTextBox.Text = LPCArrayToCSV(GetBetween(file, "SetId(", ");"))
        Catch ex As StringNotFoundException
            IDTextBox.Text = "item, itemname"
        End Try
        Try
            AdjectivesTextBox.Text = LPCArrayToCSV(GetBetween(file, "SetAdjectives(", ");"))
        Catch ex As StringNotFoundException
            AdjectivesTextBox.Text = "bland, generic, boring"
        End Try
        Try
            MassNumBox.Value = Convert.ToInt32(GetBetween(file, "SetMass(", ");"))
        Catch ex As StringNotFoundException
            MassNumBox.Value = 5
        End Try
        Try
            ValueNumBox.Value = Convert.ToInt32(GetBetween(file, "SetValue(", ");"))
        Catch ex As StringNotFoundException
            ValueNumBox.Value = 20
        End Try
        Try
            DamageNumBox.Value = Convert.ToInt32(GetBetween(file, "SetDamagePoints(", ");"))
        Catch ex As StringNotFoundException
            DamageNumBox.Value = 100
        End Try
        DestroySellCheckBox.Checked = file.Contains("SetDestroyOnSell(")
        'Load all the types
        Try
            Dim vendortypes As String = GetBetween(file, "SetVendorType(", ");")
            If vendortypes.Contains("VT_ALL") Then
                AllTypeTextBox.Checked = True
                WeaponTypeTextBox.Enabled = False
                ArmourTypeTextBox.Enabled = False
                LightTypeTextBox.Enabled = False
                FoodTypeTextBox.Enabled = False
                DrinkTypeTextBox.Enabled = False
                MagicTypeTextBox.Enabled = False
                FishingTypeTextBox.Enabled = False
                PlantTypeTextBox.Enabled = False
                HerbTypeTextBox.Enabled = False
                ContrabandTypeTextBox.Enabled = False
                TreasureTypeTextBox.Enabled = False
            Else
                WeaponTypeTextBox.Checked = vendortypes.Contains("VT_WEAPON")
                ArmourTypeTextBox.Checked = vendortypes.Contains("TV_ARMOUR")
                LightTypeTextBox.Checked = vendortypes.Contains("VT_LIGHT")
                FoodTypeTextBox.Checked = vendortypes.Contains("VT_FOOD")
                DrinkTypeTextBox.Checked = vendortypes.Contains("VT_DRINK")
                MagicTypeTextBox.Checked = vendortypes.Contains("VT_MAGIC")
                FishingTypeTextBox.Checked = vendortypes.Contains("VT_FISHING")
                PlantTypeTextBox.Checked = vendortypes.Contains("VT_PLANT")
                HerbTypeTextBox.Checked = vendortypes.Contains("VT_HERB")
                ContrabandTypeTextBox.Checked = vendortypes.Contains("VT_CONTRABAND")
            End If
        Catch ex As StringNotFoundException
            'Don't do anything
        End Try
    End Sub

    Private Sub SaveToFile()
        'Get the current file
        Dim stringtosave As String = file
        'Replace in each of the parts of the file, or add them if they don't exist
        stringtosave = ReplaceOrCreate(stringtosave, "SetKeyName(", ReQuote(KeyNameTextBox.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetShort(", ReQuote(ShortNameTextBox.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetLong(", ReQuote(DescriptionTextBox.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetId(", CSVToLPCArray(IDTextBox.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetAdjectives(", CSVToLPCArray(AdjectivesTextBox.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetMass(", MassNumBox.Value.ToString, ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetValue(", ValueNumBox.Value.ToString, ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetDamagePoints(", DamageNumBox.Value.ToString, ");")
        If DestroySellCheckBox.Checked() Then
            stringtosave = ReplaceOrCreate(stringtosave, "SetDestroyOnSell(", "1", ");")
        End If
        'Generate the list of item types and save that too
        Dim types As String = ""
        If AllTypeTextBox.Checked Then types &= " VT_ALL |"
        If WeaponTypeTextBox.Checked Then types &= " VT_WEAPON |"
        If ArmourTypeTextBox.Checked Then types &= " VT_ARMOUR |"
        If LightTypeTextBox.Checked Then types &= " VT_LIGHT |"
        If FoodTypeTextBox.Checked Then types &= " VT_FOOD |"
        If DrinkTypeTextBox.Checked Then types &= " VT_DRINK |"
        If MagicTypeTextBox.Checked Then types &= " VT_MAGIC |"
        If FishingTypeTextBox.Checked Then types &= " VT_FISHING |"
        If PlantTypeTextBox.Checked Then types &= " VT_PLANT |"
        If HerbTypeTextBox.Checked Then types &= " VT_HERB |"
        If ContrabandTypeTextBox.Checked Then types &= " VT_CONTRABAND |"
        If TreasureTypeTextBox.Checked Then types &= " VT_TREASURE |"
        If types <> "" Then
            types = types.Substring(0, types.Length - 1)
            stringtosave = ReplaceOrCreate(stringtosave, "SetVendorType(", types, ");")
        End If
        'Actually save the file
        Try
            My.Computer.FileSystem.WriteAllText(filePath, stringtosave, False, System.Text.Encoding.Default)
            StatusLabel.Text = "Saved to " & filePath
        Catch ex As Exception
            MsgBox("Failed to save the file, check it exists and you have write permission. Error: " & ex.Message)
            Return
        End Try
    End Sub

    Private Function ReplaceOrCreate(source As String, start As String, middle As String, end_ As String)
        Dim final As String = source
        Try
            final = SetBetween(final, start, end_, middle)
        Catch ex As StringNotFoundException
            'Insert the string we need under the super call
            Dim firstpart As String = final.Substring(0, final.IndexOf("::create();") + 9)
            Dim lastpart As String = final.Substring(final.IndexOf("::create();") + 10)
            final = firstpart & vbNewLine & start & middle & end_ & lastpart
        End Try
        Return final
    End Function

    Private Sub AllTypeTextBox_CheckedChanged(sender As Object, e As EventArgs) Handles AllTypeTextBox.CheckedChanged
        If AllTypeTextBox.Checked Then
            WeaponTypeTextBox.Enabled = False
            ArmourTypeTextBox.Enabled = False
            LightTypeTextBox.Enabled = False
            FoodTypeTextBox.Enabled = False
            DrinkTypeTextBox.Enabled = False
            MagicTypeTextBox.Enabled = False
            FishingTypeTextBox.Enabled = False
            PlantTypeTextBox.Enabled = False
            HerbTypeTextBox.Enabled = False
            ContrabandTypeTextBox.Enabled = False
            TreasureTypeTextBox.Enabled = False
        Else
            WeaponTypeTextBox.Enabled = True
            ArmourTypeTextBox.Enabled = True
            LightTypeTextBox.Enabled = True
            FoodTypeTextBox.Enabled = True
            DrinkTypeTextBox.Enabled = True
            MagicTypeTextBox.Enabled = True
            FishingTypeTextBox.Enabled = True
            PlantTypeTextBox.Enabled = True
            HerbTypeTextBox.Enabled = True
            ContrabandTypeTextBox.Enabled = True
            TreasureTypeTextBox.Enabled = True
        End If
    End Sub

    Private Sub EditLPCCodeButton_Click(sender As Object, e As EventArgs) Handles EditLPCCodeButton.Click
        If filePath = "NEW" Then
            MsgBox("You need to save the file before you can edit the code. Please save first.", MsgBoxStyle.Information, "Error opening code for editing")
        Else
            Dim lpceditor As New FileEditor
            Try
                file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
            Catch ex As Exception
                MsgBox("Failed to open the code file properly. Check file exists and is accessible.", MsgBoxStyle.Critical)
            End Try
            lpceditor.dialogValue = file
            lpceditor.Text = "LPC Code editor: " & filePath
            lpceditor.ShowDialog()
            file = lpceditor.dialogValue.Replace(vbLf, vbNewLine)
        End If
    End Sub

    Private Sub NewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewItemToolStripMenuItem.Click
        Try
            filePath = My.Computer.FileSystem.CurrentDirectory & "\Resources\ItemTemplate.c"
            file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
            loadFromFile()
            filePath = "NEW"
        Catch ex As Exception
            MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
        End Try
    End Sub

    Private Sub OpenItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenItemToolStripMenuItem.Click
        Dim chooser As New OpenFileDialog
        chooser.Title = "Open an item file..."
        chooser.Filter = "LPC Item Files (*.c)|*.c"
        chooser.ShowDialog()
        If chooser.FileName <> "" Then
            Try
                file = My.Computer.FileSystem.ReadAllText(chooser.FileName)
                filePath = chooser.FileName
                loadFromFile()
                StatusLabel.Text = "Loaded from " & filePath
            Catch ex As Exception
                MsgBox("Failed To open " & chooser.FileName & ", check it exists And that you have read/write permission.", MsgBoxStyle.Critical, "Failed To open room file")
                Return
            End Try
        End If
    End Sub

    Private Sub MiscAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiscAllToolStripMenuItem.Click
        AllTypeTextBox.Checked = Not AllTypeTextBox.Checked
        AllTypeTextBox_CheckedChanged(sender, e)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        WeaponTypeTextBox.Checked = False
        ArmourTypeTextBox.Checked = False
        LightTypeTextBox.Checked = False
        FoodTypeTextBox.Checked = False
        DrinkTypeTextBox.Checked = False
        MagicTypeTextBox.Checked = False
        FishingTypeTextBox.Checked = False
        PlantTypeTextBox.Checked = False
        HerbTypeTextBox.Checked = False
        ContrabandTypeTextBox.Checked = False
        TreasureTypeTextBox.Checked = False
        AllTypeTextBox.Checked = False
    End Sub

    Private Sub SaveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveItemToolStripMenuItem.Click
        If filePath = "NEW" Then
            SaveItemAsToolStripMenuItem_Click(sender, e)
        Else
            SaveToFile()
        End If
    End Sub

    Private Sub SaveItemAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveItemAsToolStripMenuItem.Click
        Dim chooser As New SaveFileDialog
        chooser.Title = "Save item file to..."
        chooser.Filter = "LPC Item Files (*.c)|*.c"
        chooser.ShowDialog()
        Dim oldpath As String = filePath
        If chooser.FileName <> "" Then
            Try
                filePath = chooser.FileName
                SaveToFile()
            Catch ex As Exception
                MsgBox("Failed to save file: " & ex.Message, MsgBoxStyle.Critical, "Error Saving file")
                EZLogging.WriteToLog("Failed to save " & filePath & ": " & ex.Message, levels.warning)
                filePath = oldpath
                Return
            End Try
            StatusLabel.Text = "Successfully saved " & filePath
        End If
    End Sub
End Class