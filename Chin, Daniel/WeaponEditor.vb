Public Class WeaponEditor

    Public filepath As String

    Dim file As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If filepath = "" Then
            Try
                filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\WeaponTemplate.c"
                file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
                loadFromFile()
                filepath = "NEW"
            Catch ex As Exception
                MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
            End Try
        Else
            Text = filepath & " - Weapon editor - Deadsouls Creator"
            loadFromFile()
        End If
    End Sub

    Private Sub loadFromFile()
        'Load the file
        Try
            file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
        Catch ex As StringNotFoundException
            MsgBox("Failed to open the file, check that it exists and you have read/write access.", MsgBoxStyle.Critical, "Error opening file")
            EZLogging.WriteToLog("Failed to load file " & filepath & ". Exiting NPC editor", levels.critical)
            Close()
            Return
        End Try
        'Load all the properties
        Try
            wepName.Text = GetBetween(file, "SetKeyName(""", """);")
        Catch ex As StringNotFoundException
            wepName.Text = "Weapon name"
        End Try
        Try
            wepID.Text = GetBetween(file, "SetId(""", """);")
        Catch ex As StringNotFoundException
            wepID.Text = "ID"
        End Try
        Try
            wepAdjectives.Text = LPCArrayToCSV(GetBetween(file, "SetAdjectives(", ");"))
        Catch ex As StringNotFoundException
            wepAdjectives.Text = "blanky blunt"
        End Try
        Try
            wepShortDesc.Text = GetBetween(file, "SetShort(""", """);")
        Catch ex As StringNotFoundException
            wepShortDesc.Text = "a weapon"
        End Try
        Try
            wepLongDesc.Text = GetBetween(file, "SetLong(""", """);")
        Catch ex As StringNotFoundException
            wepLongDesc.Text = "a weapon that has no description"
        End Try

        Try
            wepMass.Text = GetBetween(file, "SetMass(""", """);")
        Catch ex As StringNotFoundException
            wepMass.Text = "0"
        End Try

        Try
            wepClassType.Text = GetBetween(file, "SetClass(""", """);")
        Catch ex As StringNotFoundException
            wepClassType.Text = "5"
        End Try

        Try
            wepDamageType.Text = GetBetween(file, "SetDamageType(""", """);")
        Catch ex As StringNotFoundException
            wepDamageType.Text = "KNIFE"
        End Try

        Try
            wepType.Text = GetBetween(file, "SetWeaponType(""", """);")
        Catch ex As StringNotFoundException
            wepType.Text = "knife"
        End Try

    End Sub

    Private Sub SaveWeaponToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveWeaponToolStripMenuItem.Click
        Dim chooser As New SaveFileDialog
        chooser.Title = "Save Weapon file to..."
        chooser.Filter = "LPC Item Files (*.c)|*.c"
        chooser.ShowDialog()
        Dim oldpath As String = filepath
        If chooser.FileName <> "" Then
            Try
                filepath = chooser.FileName
                SaveToFile()
            Catch ex As Exception
                MsgBox("Failed to save file: " & ex.Message, MsgBoxStyle.Critical, "Error Saving file")
                EZLogging.WriteToLog("Failed to save " & filepath & ": " & ex.Message, levels.warning)
                filepath = oldpath
                Return
            End Try
            StatusLabel.Text = "Successfully saved " & filepath
        End If
    End Sub

    Private Sub SaveToFile()
        'Get the current file
        Dim stringtosave As String = file
        'Replace in each of the parts of the file, or add them if they don't exist
        stringtosave = ReplaceOrCreate(stringtosave, "SetKeyName(", ReQuote(wepName.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetShort(", ReQuote(wepShortDesc.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetLong(", ReQuote(wepLongDesc.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetId(", CSVToLPCArray(wepID.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetAdjectives(", CSVToLPCArray(wepAdjectives.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetMass(", ReQuote(wepMass.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetDamageType(", ReQuote(wepDamageType.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetWeaponType(", ReQuote(wepType.Text), ");")

        'Actually save the file
        Try
            My.Computer.FileSystem.WriteAllText(filePath, stringtosave, False, System.Text.Encoding.Default)
            StatusLabel.Text = "Saved to " & filepath
        Catch ex As Exception
            MsgBox("Failed to save the file, check it exists and you have write permission. Error: " & ex.Message)
            Return
        End Try
    End Sub

    Private Function ReplaceOrCreate(source As String, start As String, middle As String, end_ As String)
        Dim final As String = source
        Try
            final = SetBetween(final, start, end_, middle)
        Catch ex As StringNotFoundException
            'Insert the string we need under the super call
            Dim firstpart As String = final.Substring(0, final.IndexOf(" : create();") + 15)
            Dim lastpart As String = final.Substring(final.IndexOf("::create();") + 15)
            final = firstpart & vbNewLine & start & middle & end_ & lastpart
        End Try
        Return final
    End Function

    Private Sub NewWeaponToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWeaponToolStripMenuItem.Click
        Try
            filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\WeaponTemplate.c"
            file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
            loadFromFile()
            filepath = "NEW"
        Catch ex As Exception
            MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
        End Try
    End Sub

    Private Sub OpenWeaponToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWeaponToolStripMenuItem.Click
        Dim chooser As New OpenFileDialog
        chooser.Title = "Open a Weapon file..."
        chooser.Filter = "LPC Item Files (*.c)|*.c "
        chooser.ShowDialog()
        If chooser.FileName <> "" Then
            Try
                file = My.Computer.FileSystem.ReadAllText(chooser.FileName)
                filepath = chooser.FileName
                loadFromFile()
                StatusLabel.Text = "Loaded from " & filepath
            Catch ex As Exception
                MsgBox("Failed To open " & chooser.FileName & ", check it exists And that you have read/write permission.", MsgBoxStyle.Critical, "Failed To open room file")
                Return
            End Try
        End If
    End Sub
    Private Sub EditLPCCodeButton_Click(sender As Object, e As EventArgs) Handles EditLPCCodeButton.Click
        If filePath = "NEW" Then
            MsgBox("You need to save the file before you can edit the code. Please save first.", MsgBoxStyle.Information, "Error opening code for editing")
        Else
            Dim lpceditor As New FileEditor
            Try
                file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
            Catch ex As Exception
                MsgBox("Failed to open the code file properly. Check file exists and is accessible.", MsgBoxStyle.Critical)
            End Try
            lpceditor.dialogValue = file
            lpceditor.Text = "LPC Code editor: " & filePath
            lpceditor.ShowDialog()
            file = lpceditor.dialogValue.Replace(vbLf, vbNewLine)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub wepName_TextChanged(sender As Object, e As EventArgs) Handles wepName.TextChanged

    End Sub
End Class
