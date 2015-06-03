Public Class Armour

    Public filepath As String

    Dim file As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If filepath = "" Then
            Try
                filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\ArmourTemplate.c"
                file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
                loadFromFile()
                filepath = "NEW"
            Catch ex As Exception
                MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
            End Try
        Else
            Text = filepath & " - Armour editor - Deadsouls Creator"
            loadFromFile()
        End If
    End Sub

    Private Sub loadFromFile()
        'Load the file
        Try
            file = My.Computer.FileSystem.ReadAllText(filePath).Replace(vbLf, vbNewLine)
        Catch ex As StringNotFoundException
            MsgBox("Failed to open the file, check that it exists and you have read/write access.", MsgBoxStyle.Critical, "Error opening file")
            EZLogging.WriteToLog("Failed to load file " & filepath & ". Exiting Armour editor", levels.critical)
            Close()
            Return
        End Try
        'Load all the properties
        Try
            armName.Text = GetBetween(file, "SetKeyName(""", """);")
        Catch ex As StringNotFoundException
            armName.Text = "Armour name"
        End Try
        Try
            armID.Text = GetBetween(file, "SetId(""", """);")
        Catch ex As StringNotFoundException
            armID.Text = "ID"
        End Try
        Try
            armAdjectives.Text = LPCArrayToCSV(GetBetween(file, "SetAdjectives(", ");"))
        Catch ex As StringNotFoundException
            armAdjectives.Text = "blanky armour"
        End Try
        Try
            armShortDesc.Text = GetBetween(file, "SetShort(""", """);")
        Catch ex As StringNotFoundException
            armShortDesc.Text = "armour"
        End Try
        Try
            armLongDesc.Text = GetBetween(file, "SetLong(""", """);")
        Catch ex As StringNotFoundException
            armLongDesc.Text = "armour that has no description"
        End Try

        Try
            armMass.Text = GetBetween(file, "SetMass(""", """);")
        Catch ex As StringNotFoundException
            armMass.Text = "0"
        End Try

        Try
            armType.Text = GetBetween(file, "SetClass(""", """);")
        Catch ex As StringNotFoundException
            armType.Text = "A_ARMOR"
        End Try

        Try
            armDamageType.Text = GetBetween(file, "SetProtection(""", """);")
        Catch ex As StringNotFoundException
            armDamageType.Text = "BLUNT, 5"
        End Try


    End Sub

    Private Sub SaveArmourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveArmourToolStripMenuItem.Click
        Dim chooser As New SaveFileDialog
        chooser.Title = "Save Armour file to..."
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
        stringtosave = ReplaceOrCreate(stringtosave, "SetKeyName(", ReQuote(armName.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetShort(", ReQuote(armShortDesc.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetLong(", ReQuote(armLongDesc.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetId(", CSVToLPCArray(armID.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetAdjectives(", CSVToLPCArray(armAdjectives.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetMass(", ReQuote(armMass.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetProtection(", ReQuote(armDamageType.Text), ");")

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

    Private Sub NewArmourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewArmourToolStripMenuItem.Click
        Try
            filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\ArmourTemplate.c"
            file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
            loadFromFile()
            filepath = "NEW"
        Catch ex As Exception
            MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
        End Try
    End Sub

    Private Sub OpenArmourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenArmourToolStripMenuItem.Click
        Dim chooser As New OpenFileDialog
        chooser.Title = "Open a Armour file..."
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
    Private Sub Armour_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class