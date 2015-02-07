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
End Class