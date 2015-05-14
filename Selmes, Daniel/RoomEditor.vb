''' <summary>
''' An Application for editing LPC room code files
''' </summary>
''' <remarks>You can provide a file to open when the form starts up by putting a path into the filePath variable.</remarks>
Public Class RoomEditor

    ''' <summary>
    ''' An optional file path to open when the room editor starts
    ''' </summary>
    Public filePath As String

    Private file As String

    Private Sub RoomEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set the current file
        If filePath = "" Then
            Me.Text = "Dead Souls Room Editor"
            filePath = "NEW"
            Try
                file = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory & "\Resources\RoomTemplate.c")
            Catch ex As IO.IOException
                MsgBox("Sorry, there was an error loading the room template. Try re-installing the program, or contant support if that doesn't resolve the issue.", MsgBoxStyle.Critical, "Critical Error")
                WriteToLog("Failed to load template error for room file! Room editor, exiting...", levels.critical)
                Close()
                Return
            End Try
            file = file.Replace(vbLf, vbNewLine)
        Else
            Try
                Me.Text = filePath + " - Dead Souls Room Editor"
                file = My.Computer.FileSystem.ReadAllText(filePath)
                file = file.Replace(vbLf, vbNewLine)
            Catch ex As IO.IOException
                MsgBox("Welp, failed to open the file")
                Close()
                Return
            End Try
        End If

        'Load short description
        Try
            ShortDescriptionBox.Text = DeQuote(GetBetween(file, "SetShort(", ");"))
        Catch ex As StringNotFoundException
            ShortDescriptionBox.Text = "an empty room"
        End Try

        If file.Contains("SetNightLong(") And file.Contains("SetDayLong(") Then 'Day and night long desc
            Try
                NightDescriptionEnabledCheckbox.Checked = True
                LongDescriptionBox.Text = DeQuote(GetBetween(file, "SetDayLong(", ");"))
                NightDescriptionTextBox.Text = DeQuote(GetBetween(file, "SetNightLong(", ");"))
            Catch ex As StringNotFoundException
                NightDescriptionEnabledCheckbox.Checked = True
                LongDescriptionBox.Text = "An empty room, sunlight flows in through the window."
                NightDescriptionTextBox.Text = "An empty room, moonlight flows in through the window."
            End Try
        Else 'Just a long desc
            Try
                NightDescriptionEnabledCheckbox.Checked = False
                LongDescriptionBox.Text = DeQuote(GetBetween(file, "SetLong(", ");"))
            Catch ex As StringNotFoundException
                NightDescriptionEnabledCheckbox.Checked = False
                LongDescriptionBox.Text = "An empty room. Light flows in through the window."
            End Try
        End If

        'Load climate
        Try
            ClimateComboBox.Text = DeQuote(GetBetween(file, "SetClimate(", ");"))
        Catch ex As StringNotFoundException
            ClimateComboBox.Text = "indoors"
        End Try

        'Light level
        Try
            LightLevelTrackBar.Value = Convert.ToDouble(GetBetween(file, "SetProperty(""light"",", ");"))
        Catch ex As StringNotFoundException
            LightLevelTrackBar.Value = 6.0
        End Try
        LightLevelTrackBar_Scroll(New Object, New EventArgs)

        'Gravity
        Try
            GravityTrackBar.Value = Convert.ToDouble(GetBetween(file, "SetGravity(", ");"))
        Catch ex As StringNotFoundException
            GravityTrackBar.Value = 2.0
        End Try
        GravityTrackBar_Scroll(New Object, New EventArgs)

        'Town
        Try
            TownTextBox.Text = DeQuote(GetBetween(file, "SetTown(", ");"))
        Catch ex As StringNotFoundException
        End Try

        'Items
        Try
            ItemsTextBox.Text = GetBetween(file, "SetItems(", ");")
        Catch ex As StringNotFoundException
            ItemsTextBox.Text = ""
        End Try

        'Smells
        Try
            SmellsTextBox.Text = GetBetween(file, "SetSmell(", ");")
        Catch ex As StringNotFoundException
            SmellsTextBox.Text = ""
        End Try

        'sounds
        Try
            SoundsTextBox.Text = GetBetween(file, "SetListen(", ");")
        Catch ex As StringNotFoundException
            SoundsTextBox.Text = ""
        End Try

        'Searches
        Try
            SearchesTextBox.Text = GetBetween(file, "SetSearch(", ");")
        Catch ex As StringNotFoundException
            SearchesTextBox.Text = ""
        End Try

        Try
            ObjectsTextBox.Text = GetBetween(file, "SetObjects(", ");")
        Catch ex As Exception
            ObjectsTextBox.Text = ""
        End Try

    End Sub

    Private Sub LightLevelTrackBar_Scroll(sender As Object, e As EventArgs) Handles LightLevelTrackBar.Scroll
        LightLevelIndicatorLabel.Text = LightLevelTrackBar.Value.ToString()
    End Sub

    Private Sub GravityTrackBar_Scroll(sender As Object, e As EventArgs) Handles GravityTrackBar.Scroll
        GravityDisplayLabel.Text = GravityTrackBar.Value.ToString() + "G"
    End Sub

    Private Sub NightDescriptionEnabledCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NightDescriptionEnabledCheckbox.CheckedChanged
        NightDescriptionTextBox.Enabled = NightDescriptionEnabledCheckbox.Checked
    End Sub

    Private Sub EditItemsButton_Click(sender As Object, e As EventArgs) Handles EditItemsButton.Click
        Dim mappingEditor As New MappingEditorMS
        mappingEditor.dialogValue = ItemsTextBox.Text
        If mappingEditor.dialogValue = "" Then
            mappingEditor.dialogValue = "([""default"": ""nothing to see here""])"
        End If
        mappingEditor.Text = "Edit Items"
        mappingEditor.KeysListBoxContainer.Text = "Item Aliases"
        mappingEditor.ValueGroupBox.Text = "Item Description"
        mappingEditor.KeysTextBoxLabel.Text = "Item Names (Seperated by commas)"
        mappingEditor.ValueTextBoxLabel.Text = "Item Description"
        mappingEditor.ShowDialog()
        If mappingEditor.dialogValue = "EMPTY" Then
            ItemsTextBox.Text = "(["""":""""])"
        ElseIf mappingEditor.dialogValue <> "CANCEL" Then
            ItemsTextBox.Text = mappingEditor.dialogValue
        End If
        mappingEditor.Close()
    End Sub

    Private Sub EditLPCCodeButton_Click(sender As Object, e As EventArgs) Handles EditLPCCodeButton.Click
        If filePath = "NEW" Then
            MsgBox("You need to save the file before you can edit the LPC code by hand. Try again once, you've saved the file.", MsgBoxStyle.Information, "Couldn't open LPC code")
            SaveRoomAsToolStripMenuItem_Click(New Object, New EventArgs)
            Return
        Else
            If Not SaveToDisk(filePath) Then
                Return
            End If
        End If
        Dim lpceditor As New FileEditor
        lpceditor.dialogValue = My.Computer.FileSystem.ReadAllText(filePath)
        lpceditor.Text = "LPC Code Editor: " + filePath
        lpceditor.Show()
    End Sub

    Private Sub EditSmellsButton_Click(sender As Object, e As EventArgs) Handles EditSmellsButton.Click
        Dim mappingEditor As New MappingEditorMS
        mappingEditor.dialogValue = SmellsTextBox.Text
        If mappingEditor.dialogValue = "" Then
            mappingEditor.dialogValue = "([""default"": ""Nothing to smell here""])"
        End If
        mappingEditor.Text = "Edit Smells"
        mappingEditor.KeysListBoxContainer.Text = "Scent names"
        mappingEditor.ValueGroupBox.Text = "Scent descriptions"
        mappingEditor.KeysTextBoxLabel.Text = "Scent Names (Seperated by commas)"
        mappingEditor.ValueTextBoxLabel.Text = "Scent Description"
        mappingEditor.ShowDialog()
        If mappingEditor.dialogValue = "EMPTY" Then
            SmellsTextBox.Text = "(["""":""""])"
        ElseIf mappingEditor.dialogValue <> "CANCEL" Then
            SmellsTextBox.Text = mappingEditor.dialogValue
        End If
        mappingEditor.Close()
    End Sub

    Private Sub EditSoundsButton_Click(sender As Object, e As EventArgs) Handles EditSoundsButton.Click
        Dim mappingEditor As New MappingEditorMS
        mappingEditor.dialogValue = SoundsTextBox.Text
        If mappingEditor.dialogValue = "" Then
            mappingEditor.dialogValue = "([""default"": ""You don't hear anything of interest.""])"
        End If
        mappingEditor.Text = "Edit Sounds"
        mappingEditor.KeysListBoxContainer.Text = "Sound names"
        mappingEditor.ValueGroupBox.Text = "Sound descriptions"
        mappingEditor.KeysTextBoxLabel.Text = "Sound Names (Seperated by commas)"
        mappingEditor.ValueTextBoxLabel.Text = "Sound Description"
        mappingEditor.ShowDialog()
        If mappingEditor.dialogValue = "EMPTY" Then
            SoundsTextBox.Text = "(["""":""""])"
        ElseIf mappingEditor.dialogValue <> "CANCEL" Then
            SoundsTextBox.Text = mappingEditor.dialogValue
        End If
        mappingEditor.Close()
    End Sub

    Private Sub EditSearchesButton_Click(sender As Object, e As EventArgs) Handles EditSearchesButton.Click
        Dim mappingEditor As New MappingEditorMS
        mappingEditor.dialogValue = SearchesTextBox.Text
        If mappingEditor.dialogValue = "" Then
            mappingEditor.dialogValue = "([""default"": ""You find nothing, good day sir.""])"
        End If
        mappingEditor.Text = "Edit Search findings"
        mappingEditor.KeysListBoxContainer.Text = "Search names"
        mappingEditor.ValueGroupBox.Text = "Search results"
        mappingEditor.KeysTextBoxLabel.Text = "Search Names (Seperated by commas)"
        mappingEditor.ValueTextBoxLabel.Text = "Search results"
        mappingEditor.ShowDialog()
        If mappingEditor.dialogValue = "EMPTY" Then
            SearchesTextBox.Text = "(["""":""""])"
        ElseIf mappingEditor.dialogValue <> "CANCEL" Then
            SearchesTextBox.Text = mappingEditor.dialogValue
        End If
        mappingEditor.Close()
    End Sub

    Private Sub EditObjectsButton_Click(sender As Object, e As EventArgs) Handles EditObjectsButton.Click
        Dim mappingEditor As New MappingEditorSF
        mappingEditor.dialogValue = ObjectsTextBox.Text
        If mappingEditor.dialogValue = "" Then
            mappingEditor.dialogValue = "([""north"":""domains/example/room/kitchen.c"", ""south"":""/domains/example/room/basement.c""])"
        End If
        mappingEditor.ShowDialog()
        If mappingEditor.dialogValue <> "CANCEL" Or mappingEditor.dialogValue <> "EMPTY" Then
            ObjectsTextBox.Text = mappingEditor.dialogValue
        End If
    End Sub

    Private Function SaveToDisk(pathtosaveto As String)
        Dim stringtosave As String
        Try
            stringtosave = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory & "\Resources\RoomTemplate.c")
        Catch ex As Exception
            MsgBox("Sorry, there was an error loading the room template. Try re-installing the program, or contant support if that doesn't resolve the issue.", MsgBoxStyle.Critical, "Critical Error")
            WriteToLog("Failed to load template error for room file! Aborting save...", levels.warning)
            Return False
        End Try
        'Short desc
        If ShortDescriptionBox.Text = "" Then
            MsgBox("You must enter something for the short description.", MsgBoxStyle.Critical, "Invalid Short description")
            ShortDescriptionBox.Focus()
            Return False
        End If
        stringtosave = SetBetween(stringtosave, "SetShort(", ");", ReQuote(ShortDescriptionBox.Text))
        'Long desc
        If LongDescriptionBox.Text = "" Then
            MsgBox("You must enter something for the long/day description.", MsgBoxStyle.Critical, "Invalid Long description")
            LongDescriptionBox.Focus()
            Return False
        End If
        If NightDescriptionEnabledCheckbox.Checked And NightDescriptionTextBox.Text = "" Then
            MsgBox("You must enter something for the night description, or disable the night description.", MsgBoxStyle.Critical, "Invalid Long description")
            LongDescriptionBox.Focus()
            Return False
        End If
        If NightDescriptionEnabledCheckbox.Checked Then
            stringtosave = SetBetween(stringtosave, "SetDayLong(", ");", ReQuote(LongDescriptionBox.Text))
            stringtosave = SetBetween(stringtosave, "SetNightLong(", ");", ReQuote(NightDescriptionTextBox.Text))
        Else
            stringtosave = SetBetween(stringtosave, "SetDayLong(", ");", ReQuote(LongDescriptionBox.Text))
            stringtosave = SetBetween(stringtosave, "SetNightLong(", ");", ReQuote(LongDescriptionBox.Text))
        End If
        'Light
        stringtosave = SetBetween(stringtosave, "SetProperty(""light"",", ");", LightLevelTrackBar.Value.ToString)
        'Climate
        stringtosave = SetBetween(stringtosave, "SetClimate(", ");", ReQuote(ClimateComboBox.SelectedItem))
        'Gravity
        stringtosave = SetBetween(stringtosave, "SetGravity(", ");", GravityTrackBar.Value.ToString)
        'Town
        If TownTextBox.Text <> "" Then
            stringtosave = SetBetween(stringtosave, "SetTown(", ");", TownTextBox.Text)
        End If
        'Items
        If ItemsTextBox.Text <> "" Then
            stringtosave = SetBetween(stringtosave, "SetItems(", ");", ItemsTextBox.Text)
        End If
        'Smells
        If SmellsTextBox.Text <> "" Then
            stringtosave = SetBetween(stringtosave, "SetSmell(", ");", SmellsTextBox.Text)
        End If
        'Sounds
        If SoundsTextBox.Text <> "" Then
            stringtosave = SetBetween(stringtosave, "SetListen(", ");", SoundsTextBox.Text)
        End If
        'Searches
        If SearchesTextBox.Text <> "" Then
            stringtosave = SetBetween(stringtosave, "SetSearch(", ");", SearchesTextBox.Text)
        End If
        'Acutal saving of the string to the file
        My.Computer.FileSystem.WriteAllText(pathtosaveto, stringtosave, False, System.Text.Encoding.Default)
        Return True
    End Function

    Private Sub SaveRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveRoomToolStripMenuItem.Click
        If filePath = "NEW" Then
            SaveRoomAsToolStripMenuItem_Click(New Object, New EventArgs)
        Else
            SaveToDisk(filePath)
        End If
    End Sub

    Private Sub SaveRoomAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveRoomAsToolStripMenuItem.Click
        Dim chooser As New SaveFileDialog
        chooser.Filter = "LPC Files (*.c)|*.c|All Files (*.*)|*.*"
        chooser.FilterIndex = 0
        chooser.ShowDialog()
        If chooser.FileName = "" Then
            Return
        End If
        Try
            SaveToDisk(chooser.FileName)
        Catch ex As IO.IOException
            MsgBox("Sorry, there was an error saving the file, check that it exists and that you have read/write privelages.", MsgBoxStyle.Critical, "Could not save file.")
            WriteToLog("There was an error saving the file: " & ex.Message, levels.warning)
        End Try
        filePath = chooser.FileName
        Me.Text = filePath + " - Dead Souls Room Editor"
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Select Case MsgBox("Save changes before quitting?", MsgBoxStyle.YesNoCancel, "Save changes?")
            Case Is = MsgBoxResult.Yes
                If SaveToDisk(filePath) Then
                    Close()
                End If
            Case Is = MsgBoxResult.No
                Close()
        End Select
    End Sub

    Private Sub NewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRoomToolStripMenuItem.Click
        filePath = ""
        RoomEditor_Load(New Object, New EventArgs)
    End Sub

    Private Sub OpenRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRoomToolStripMenuItem.Click
        Dim chooser As New OpenFileDialog
        chooser.Filter = "LPC Files (*.c)|*.c|All Files (*.*)|*.*"
        chooser.FilterIndex = 0
        chooser.ShowDialog()
        If chooser.FileName = "" Then
            Return
        End If
        filePath = chooser.FileName
        RoomEditor_Load(New Object, New EventArgs)
    End Sub
End Class