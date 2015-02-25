''' <summary>
''' A dialog box for editing a text file, with some basic editing controls
''' </summary>
''' <remarks>Mainly intended to be used as a dialog for editing raw file code.</remarks>
Public Class FileEditor

    Public dialogValue As String
    Public tempValue As String

    Private Sub FileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempValue = dialogValue
        TextBox.Text = tempValue
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        dialogValue = tempValue
        Me.Close()
    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        If MsgBox("Discard all changes?", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub


    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If MsgBox("Discard changes and reload from source?", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then
            tempValue = dialogValue
            TextBox.Text = tempValue
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        If MsgBox("Clear all text?", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then
            tempValue = ""
            TextBox.Text = ""
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged
        tempValue = TextBox.Text
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(TextBox.SelectedText)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(TextBox.SelectedText)
        TextBox.SelectedText = ""
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox.SelectedText = My.Computer.Clipboard.GetText
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        If MsgBox("Clear all text?", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then
            tempValue = ""
            TextBox.Text = ""
        End If
    End Sub
End Class