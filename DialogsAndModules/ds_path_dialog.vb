Public Class ds_path_dialog

    Private Sub ds_path_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.deadsouls_installation_path = "NOINSTALLPATH" Then
            dsInstallPathTextBox.Text = "C:\ds"
            NoPathRadioButton.Checked = True
        Else
            dsInstallPathTextBox.Text = My.Settings.deadsouls_installation_path
        End If
    End Sub

    Private Sub BrowsePathButton_Click(sender As Object, e As EventArgs) Handles BrowsePathButton.Click
        Dim folderbrowser As New FolderBrowserDialog
        If folderbrowser.ShowDialog() = DialogResult.OK Then
            dsInstallPathTextBox.Text = folderbrowser.SelectedPath
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If NormalPathRadioButton.Checked Then
            My.Settings.deadsouls_installation_path = dsInstallPathTextBox.Text
            Close()
        ElseIf NoPathRadioButton.Checked Then
            My.Settings.deadsouls_installation_path = "NOINSTALLPATH"
            Close()
        Else
            My.Settings.deadsouls_installation_path = "NOINSTALLPATH"
            Cursor = Cursors.AppStarting
            Hide()
            Process.Start("http://dead-souls.net/")
            Close()
        End If
    End Sub
End Class