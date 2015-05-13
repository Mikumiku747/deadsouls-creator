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
            Try
                file = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory & "\Resources\RoomTemplate.c")
            Catch ex As IO.IOException
                MsgBox("Sorry, there was an error loading the room template. Try re-installing the program, or contant support if that doesn't resolve the issue.", MsgBoxStyle.Critical, "Critical Error")
                Debug.Print("CRITICAL ERROR - " & Now.ToString & ": Failed to load template error for room file! Room editor, exiting...")
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
        Dim lpceditor As New FileEditor
        lpceditor.dialogValue = file
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
End Class