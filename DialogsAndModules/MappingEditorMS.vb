''' <summary>
''' Multiple-Single mapping editor dialog
''' </summary>
''' <remarks>Meant to be used as a dialog for editing LPC Mappings, spcefically, ones that 
''' map arrays of strings to single strings.</remarks>
Public Class MappingEditorMS

    ''' <summary>
    ''' The mapping to be edited, an LPC mapping as a string.
    ''' You can also read from this when the dialog has closed to get the modified value.
    ''' </summary>
    Public dialogValue As String

    Dim cleanKeys As List(Of String)
    Dim cleanValues As List(Of String)
    Dim currentItem As Integer = 0


    Private Sub MappingEditorMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Retrieve the keys and values
        Dim keysAndValues = LPCParsing.ParseMapping(dialogValue)
        Dim keys = CType(keysAndValues(0), String())
        Dim values = CType(keysAndValues(1), String())
        'Clean off the keys
        Dim keysStripped = keys
        For i As Integer = 0 To keysStripped.Length - 1
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
        For i As Integer = 0 To values.Length - 1
            valuesStripped(i) = LPCParsing.DeQuote(valuesStripped(i))
        Next
        cleanValues = valuesStripped.Cast(Of String)().ToList()

        'Put the keys into the list
        For Each item In cleanKeys
            KeysListBox.Items.Add(item)
        Next

        'Select the first item in the list
        KeysListBox.SetSelected(currentItem, True)
    End Sub

    Private Sub KeysListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KeysListBox.SelectedIndexChanged
        currentItem = cleanKeys.IndexOf(KeysListBox.SelectedItem)
        If currentItem = -1 Then
            currentItem = 0
        End If
        Dim cpos As Integer = KeysTextBox.SelectionStart
        KeysTextBox.Text = cleanKeys(currentItem)
        KeysTextBox.SelectionStart = cpos
        ValueTextBox.Text = cleanValues(currentItem)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Get an array version of the keys and values
        Dim keys(cleanKeys.Count - 1) As String
        Dim values(cleanValues.Count - 1) As String
        cleanKeys.CopyTo(keys)
        cleanValues.CopyTo(values)
        'Convert the lists to arrays if need be
        Dim keysConverted() As String = keys
        For i As Integer = 0 To keys.Length - 1
            If keys(i).Contains(",") Then
                keysConverted(i) = LPCParsing.CSVToLPCArray(keys(i))
            Else
                keysConverted(i) = ReQuote(keys(i))
            End If
        Next
        'Re-quote the values
        Dim valuesConverted() As String = values
        For i As Integer = 0 To values.Length - 1
            valuesConverted(i) = LPCParsing.ReQuote(values(i))
        Next
        'Compile the array back up
        dialogValue = LPCParsing.CompileMapping(keysConverted, valuesConverted)
        Me.Hide()
    End Sub

    Private Sub KeysTextBox_TextChanged(sender As Object, e As EventArgs) Handles KeysTextBox.TextChanged
        cleanKeys(currentItem) = KeysTextBox.Text
        KeysListBox.Items(currentItem) = KeysTextBox.Text
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

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        cleanKeys.Add("unnamed item")
        cleanValues.Add("item description here")
        KeysListBox.Items.Add("unnamed item")
        KeysListBox.SetSelected(KeysListBox.Items.Count - 1, True)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton_.Click
        dialogValue = "CANCEL"
        Me.Hide()
    End Sub


    Private Sub MappingEditorMS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub
End Class