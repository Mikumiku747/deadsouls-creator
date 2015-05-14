''' <summary>
''' A dialog for editing Mappings to file names
''' </summary>
Public Class MappingEditorSF

    ''' <summary>
    ''' The value of this dialog, set it to a default before showing, or check it for the result after it is closed
    ''' </summary>
    Public dialogValue As String

    ''' <summary>
    ''' A list of files for the user to choose from, if they need a hint as to what file they should map
    ''' </summary>
    Public fileList As List(Of String) = Nothing

    Dim currentItem As Integer = 0
    Dim cleanValues As New List(Of String)
    Dim cleanKeys As New List(Of String)

    Private Sub MappingEditorSF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load in the file list
        If IsNothing(fileList) Then
            FileListBox.Items.Add("No files to choose from...")
            FileListBox.Enabled = False
        Else
            For Each filepath In fileList
                FileListBox.Items.Add(filepath)
            Next
        End If

        'Load in the mapping
        'Retrieve the keys and values
        Dim keysAndValues = LPCParsing.ParseMapping(dialogValue)
        Dim keys = CType(keysAndValues(0), String())
        Dim values = CType(keysAndValues(1), String())
        'Clean the keys, dequote the values
        For Each key In keys
            'keys(Array.IndexOf(keys, key))
        Next
        For Each key In keys
            KeysListBox.Items.Add(DeQuote(key))
            cleanKeys.Add(DeQuote(key))
        Next
        For Each value In values
            cleanValues.Add(DeQuote(value))
        Next
        currentItem = 0
        KeysListBox.SelectedIndex = currentItem
    End Sub

    Private Sub KeysListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KeysListBox.SelectedIndexChanged
        currentItem = cleanKeys.IndexOf(KeysListBox.SelectedItem)
        If currentItem = -1 Then
            currentItem = 0
        End If
        Dim cpos As Integer = KeyTextBox.SelectionStart
        KeyTextBox.Text = cleanKeys(currentItem)
        KeyTextBox.SelectionStart = cpos
        ValueTextBox.Text = cleanValues(currentItem)
    End Sub

    Private Sub KeyTextBox_TextChanged(sender As Object, e As EventArgs) Handles KeyTextBox.TextChanged
        cleanKeys(currentItem) = KeyTextBox.Text
        KeysListBox.Items(currentItem) = KeyTextBox.Text
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        cleanKeys.Add("unnamed item")
        cleanValues.Add("item description here")
        KeysListBox.Items.Add("unnamed item")
        KeysListBox.SetSelected(KeysListBox.Items.Count - 1, True)
    End Sub

    Private Sub ValueTextBox_TextChanged(sender As Object, e As EventArgs) Handles ValueTextBox.TextChanged
        cleanValues(currentItem) = ValueTextBox.Text
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        cleanKeys.RemoveAt(currentItem)
        cleanValues.RemoveAt(currentItem)
        Try
            KeysListBox.Items.RemoveAt(currentItem)
        Catch ex As Exception
            dialogValue = "EMPTY"
            Close()
            Return
        End Try
    End Sub

    Private Sub FileListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileListBox.SelectedIndexChanged
        If FileListBox.SelectedItem <> "" Then
            ValueTextBox.Text = FileListBox.SelectedItem
            ValueTextBox_TextChanged(New Object, New EventArgs)
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        'Put the keys and values back in arrays
        Dim keys(cleanKeys.Count - 1) As String
        Dim values(cleanValues.Count - 1) As String
        cleanKeys.CopyTo(keys)
        cleanValues.CopyTo(values)
        'Re quote the keys and values
        For Each key In keys
            keys(Array.IndexOf(keys, key)) = ReQuote(key)
        Next
        For Each value In values
            values(Array.IndexOf(values, value)) = ReQuote(value)
        Next
        dialogValue = CompileMapping(keys, values)
        Close()
    End Sub
End Class