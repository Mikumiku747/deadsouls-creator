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
            file = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory & "\Resources\RoomTemplate.c")
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
            Debug.Print("Could not read climate, setting to indoors")
        End Try
        ClimateComboBox_SelectedIndexChanged(New Object, New EventArgs)

        'Light level
        Try
            LightLevelTrackBar.Value = Convert.ToDouble(GetBetween(file, "SetProperty(""light"",", ");"))
            Debug.Print(Convert.ToDouble(GetBetween(file, "SetProperty(""light"",", ");")))
        Catch ex As StringNotFoundException
            Debug.Print("Could not read light level, setting to 6")
            LightLevelTrackBar.Value = 6.0
        End Try
        LightLevelTrackBar_Scroll(New Object, New EventArgs)

        'Gravity
        Try
            GravityTrackBar.Value = Convert.ToDouble(GetBetween(file, "SetGravity(", ");"))
            Debug.Print("Gravity level: " & Convert.ToDouble(GetBetween(file, "SetGravity(", ");")))
        Catch ex As StringNotFoundException
            GravityTrackBar.Value = 2.0
        End Try
        GravityTrackBar_Scroll(New Object, New EventArgs)



        'OLD ROOM EDITOR CODE
        ''Get the room short description, or set if it doesn't exist (It's a BIG problem if it doesn't)
        'Try
        '    ShortDescriptionBox.Text = DeQuote(LPCParsing.GetBetween(file, "SetShort(", ");"))
        'Catch ex As LPCParsing.StringNotFoundException
        '    Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
        '    file = file.Substring(0, innerCreate) + vbNewLine + "SetShort(" + ReQuote(ShortDescriptionBox.Text) + ");" + vbNewLine + file.Substring(innerCreate)
        'End Try
        ''Get the room long description, if it exists. Checks for both day and night
        'If file.Contains("SetNightLong(") Then
        '    NightDescriptionEnabledCheckbox.Checked = True
        'End If
        'Try
        '    LongDescriptionBox.Text = DeQuote(LPCParsing.GetBetween(file, "SetLong(", ");"))
        'Catch ex As LPCParsing.StringNotFoundException
        '    Try
        '        LongDescriptionBox.Text = DeQuote(LPCParsing.GetBetween(file, "SetDayLong(", ");"))
        '    Catch ex2 As LPCParsing.StringNotFoundException
        '        Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
        '        file = file.Substring(0, innerCreate) + vbNewLine + "SetDayLong(" + """DayTime Description""" + ");" + vbNewLine + file.Substring(innerCreate)
        '        file = file.Substring(0, innerCreate) + vbNewLine + "SetNightLong(" + """NightTime Description""" + ");" + vbNewLine + file.Substring(innerCreate)
        '        LongDescriptionBox.Text = DeQuote(LPCParsing.GetBetween(file, "SetDayLong(", ");"))
        '        NightDescriptionTextBox.Text = DeQuote(LPCParsing.GetBetween(file, "SetNightLong(""", """);"))
        '        NightDescriptionEnabledCheckbox.Checked = True
        '    End Try
        'End Try
        ''Get the ambient light level
        'Try
        '    LightLevelTrackBar.Value = CInt((LPCParsing.GetBetween(file, "SetAmbientLight(", ");")))
        'Catch ex As LPCParsing.StringNotFoundException
        '    Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
        '    file = file.Substring(0, innerCreate) + vbNewLine + "SetAmbientLight(" + CStr(LightLevelTrackBar.Value) + ");" + vbNewLine + file.Substring(innerCreate)
        'End Try
        'LightLevelIndicatorLabel.Text = CStr(LightLevelTrackBar.Value)
        ''Get the gravity strength. This is an optional value
        'Try
        '    GravityTrackBar.Value = CInt((LPCParsing.GetBetween(file, "SetGravity(", ");")))
        '    GravityDisplayLabel.Text = CStr(GravityTrackBar.Value)
        'Catch ex As LPCParsing.StringNotFoundException
        'End Try
        ''Get the climate
        'Try
        '    LPCParsing.GetBetween(file, "SetClimate(", ");")
        'Catch exex As LPCParsing.StringNotFoundException
        '    Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
        '    file = file.Substring(0, innerCreate) + vbNewLine + "SetClimate(" + ReQuote("tempperate") + ");" + vbNewLine + file.Substring(innerCreate)
        '    If ClimateComboBox.Items.Contains(DeQuote(LPCParsing.GetBetween(file, "SetClimate(", ");"))) Then
        '        ClimateComboBox.Items.Add(DeQuote(LPCParsing.GetBetween(file, "SetClimate(", ");")))
        '    End If
        'End Try
        'ClimateComboBox.SelectedItem = DeQuote(LPCParsing.GetBetween(file, "SetClimate(", ");"))
    End Sub

    Private Sub LightLevelTrackBar_Scroll(sender As Object, e As EventArgs) Handles LightLevelTrackBar.Scroll
        LightLevelIndicatorLabel.Text = LightLevelTrackBar.Value.ToString()
        Try
            LPCParsing.GetBetween(file, "SetAmbientLight(", ");")
        Catch ex As LPCParsing.StringNotFoundException
            Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
            file = file.Substring(0, innerCreate) + vbNewLine + "SetAmbientLight(" + CStr(LightLevelTrackBar.Value) + ");" + vbNewLine + file.Substring(innerCreate)
        End Try

    End Sub

    Private Sub GravityTrackBar_Scroll(sender As Object, e As EventArgs) Handles GravityTrackBar.Scroll
        GravityDisplayLabel.Text = GravityTrackBar.Value.ToString() + "G"
        Try
            LPCParsing.GetBetween(file, "SetGravity(", ");")
        Catch ex As LPCParsing.StringNotFoundException
            Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
            file = file.Substring(0, innerCreate) + vbNewLine + "SetGravity(" + GravityTrackBar.Value.ToString + ");" + vbNewLine + file.Substring(innerCreate)
        End Try
    End Sub

    Private Sub NightDescriptionEnabledCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NightDescriptionEnabledCheckbox.CheckedChanged
        NightDescriptionTextBox.Enabled = NightDescriptionEnabledCheckbox.Checked
        If NightDescriptionEnabledCheckbox.Checked Then
            Try
                NightDescriptionTextBox.Text = DeQuote(LPCParsing.GetBetween(file, "SetNightLong(", ");"))
            Catch ex As LPCParsing.StringNotFoundException
                Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
                file = file.Substring(0, innerCreate) + vbNewLine + "SetNightLong(" + ReQuote(NightDescriptionTextBox.Text) + ");" + vbNewLine + file.Substring(innerCreate)
            End Try
        End If
    End Sub

    Private Sub EditItemsButton_Click(sender As Object, e As EventArgs) Handles EditItemsButton.Click
        Dim mappingEditor As New MappingEditorMS
        Try
            mappingEditor.dialogValue = LPCParsing.GetBetween(file, "SetItems(", ");")
            mappingEditor.Text = "Edit Items"
            mappingEditor.KeysListBoxContainer.Text = "Item Aliases"
            mappingEditor.ValueGroupBox.Text = "Item Description"
            mappingEditor.KeysTextBoxLabel.Text = "Item Names (Seperated by commas)"
            mappingEditor.ValueTextBoxLabel.Text = "Item Description"
        Catch ex As LPCParsing.StringNotFoundException
            If MsgBox("There are no items in this room yet. Do you want to create an item list?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
                file = file.Substring(0, innerCreate) + vbNewLine + "SetItems( ([""""default value"""":""""description here""""]) );" + vbNewLine + file.Substring(innerCreate)
                mappingEditor.dialogValue = LPCParsing.GetBetween(file, "SetItems(", ");")
            Else
                Return
            End If
        End Try
        mappingEditor.ShowDialog()
        file = SetBetween(file, "SetItems(", ");", mappingEditor.dialogValue)
        mappingEditor.Close()

    End Sub

    Private Sub EditLPCCodeButton_Click(sender As Object, e As EventArgs) Handles EditLPCCodeButton.Click
        Dim lpceditor As New FileEditor
        lpceditor.dialogValue = file
        lpceditor.Text = "LPC Code Editor: " + filePath
        lpceditor.ShowDialog()
        file = lpceditor.dialogValue
    End Sub

    Private Sub ShortDescriptionBox_TextChanged(sender As Object, e As EventArgs) Handles ShortDescriptionBox.TextChanged
        Try
            file = LPCParsing.SetBetween(file, "SetShort(", ");", "" + ReQuote(ShortDescriptionBox.Text) + "")
        Catch ex As LPCParsing.StringNotFoundException
            Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
            file = file.Substring(0, innerCreate) + vbNewLine + "SetShort(" + ReQuote(ShortDescriptionBox.Text) + ");" + vbNewLine + file.Substring(innerCreate)
        End Try
    End Sub

    Private Sub LongDescriptionBox_TextChanged(sender As Object, e As EventArgs) Handles LongDescriptionBox.TextChanged
        If NightDescriptionEnabledCheckbox.Checked = True Then
            Try
                file = LPCParsing.SetBetween(file, "SetDayLong(", ");", ReQuote(LongDescriptionBox.Text))
            Catch exex As LPCParsing.StringNotFoundException
                Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
                file = file.Substring(0, innerCreate) + vbNewLine + "SetDayLong(" + ReQuote(LongDescriptionBox.Text) + ");" + vbNewLine + file.Substring(innerCreate)
            End Try
        Else
            Try
                file = LPCParsing.SetBetween(file, "SetLong(", ");", ReQuote(LongDescriptionBox.Text))
            Catch exex As LPCParsing.StringNotFoundException
                Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
                file = file.Substring(0, innerCreate) + vbNewLine + "SetLong(" + ReQuote(LongDescriptionBox.Text) + ");" + vbNewLine + file.Substring(innerCreate)
            End Try
        End If
    End Sub

    Private Sub NightDescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles NightDescriptionTextBox.TextChanged
        Try
            file = LPCParsing.SetBetween(file, "SetNightLong(", ");", ReQuote(NightDescriptionTextBox.Text))
        Catch exex As LPCParsing.StringNotFoundException
            Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
            file = file.Substring(0, innerCreate) + vbNewLine + "SetNightLong(" + ReQuote(NightDescriptionTextBox.Text) + ");" + vbNewLine + file.Substring(innerCreate)
        End Try
    End Sub

    Private Sub ClimateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClimateComboBox.SelectedIndexChanged
        Dim selected As String = ClimateComboBox.SelectedItem
        If selected = "custom..." Then
            Dim stringdialog As New StringPrompt
            stringdialog.Text = "Custom climate..."
            stringdialog.TextPromptLabel.Text = "Enter a custom climate"
            stringdialog.CancelButton = Nothing
            stringdialog.ShowDialog()
            If selected = "" Then
                selected = "indoors"
                ClimateComboBox.SelectedItem = "indoors"
            Else
                selected = stringdialog.dialogValue
            End If
        End If
        Try
            file = LPCParsing.SetBetween(file, "SetClimate(", ");", ReQuote(selected))
        Catch exex As LPCParsing.StringNotFoundException
            Dim innerCreate As Integer = file.IndexOf("room::create();") + 16
            file = file.Substring(0, innerCreate) + vbNewLine + "SetClimate(" + ReQuote(selected) + ");" + vbNewLine + file.Substring(innerCreate)
            LPCParsing.SetBetween(file, "SetTemperature(", ");", "32 degrees")
        End Try
    End Sub
End Class