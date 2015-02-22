Public Class RoomEditor
    Public filePath As String
    Public file As String

    Private Sub RoomEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set the current file
        If filePath = "" Then
            Me.Text = "Dead Souls Room Editor"
            file = My.Computer.FileSystem.ReadAllText("C:\ds\lib\domains\town\room\bridge.c")
        Else
            Me.Text = filePath + " - Dead Souls Room Editor"
            file = My.Computer.FileSystem.ReadAllText(filePath)
        End If
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
End Class