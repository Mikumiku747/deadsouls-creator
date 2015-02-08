Public Class MappingEditorMS

    Public dialogValue As String
    Dim cleanKeys As List(Of String)
    Dim cleanValues As List(Of String)
    
    Private Sub MappingEditorMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Retrieve the keys and values
        Dim keysAndValues = LPCParsing.ParseMapping(dialogValue)
        Dim keys = CType(keysAndValues(0), String())
        Dim values = CType(keysAndValues(1), String())
        'Clean off the keys
        Dim keysStripped = keys
        For i As Integer = 0 To keysStripped.length - 1
            keysStripped(i) = LPCParsing.StripWhitepace(keys(i))
            If keysStripped(i).StartsWith("({") Then
                keysStripped(i) = LPCParsing.LPCArrayToCSV(keysStripped(i))
            Else
                keysStripped(i) = LPCParsing.DeQuote(keysStripped(i))
            End If
        Next
        cleanKeys = keysStripped.Cast(Of String)().ToList()
        'Clean off the values
        Dim valuesStripped = values
        For i As Integer = 0 To values.length - 1
            valuesStripped(i) = values(i).replace(vbNewLine, "")
            valuesStripped(i) = valuesStripped(i).replace("""", "")
            valuesStripped(i) = LPCParsing.StripWhitepace(valuesStripped(i))
        Next
        cleanValues = valuesStripped.Cast(Of String)().ToList()

        'Put the keys into the list
        KeysListBox.DataSource = cleanKeys
    End Sub

    Private Sub KeysListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KeysListBox.SelectedIndexChanged
        KeysTextBox.Text = KeysListBox.SelectedItem
        Dim targetIndex As Integer = cleanKeys.IndexOf(KeysListBox.SelectedItem)
        ValueTextBox.Text = cleanValues(targetIndex)
    End Sub
End Class