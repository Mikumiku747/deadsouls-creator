Public Class RoomEditor
    Public CurrentFile As String

    Private Sub RoomEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the current file
        If CurrentFile = "" Then
            Me.Text = "Dead Souls Room Editor"
        Else
            Me.Text = CurrentFile + " - Dead Souls Room Editor"
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
        mappingEditor.dialogValue = LPCParsing.GetBetween(My.Computer.FileSystem.ReadAllText(CurrentFile), "SetItems(", ");")
        mappingEditor.Text = "Edit Items"
        mappingEditor.KeysListBoxContainer.Text = "Item Aliases"
        mappingEditor.ValueGroupBox.Text = "Item Description"
        mappingEditor.KeysTextBoxLabel.Text = "Item Names (Seperated by commas)"
        mappingEditor.ValueTextBoxLabel.Text = "Item Description"
        mappingEditor.ShowDialog()
        MsgBox(mappingEditor.dialogValue)
        mappingEditor.Close()
    End Sub
End Class