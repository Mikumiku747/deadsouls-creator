''' <summary>
''' A form for modifiying Deadsouls Non Character Players (NPCs)
''' Pass a string value into filepath on startup to make the form open that file.
''' </summary>
Public Class NPCEditor

    ''' <summary>
    ''' An NPC file to be opened, pass the filename as a string
    ''' </summary>
    Public filepath As String

    Dim file As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If filepath = "" Then
            Try
                filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\NPCTemplate.c"
                file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
                loadFromFile()
                filepath = "NEW"
            Catch ex As Exception
                MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
            End Try
        Else
            Text = filepath & " - NPC editor - Deadsouls Creator"
            loadFromFile()
        End If
    End Sub

    Private Sub loadFromFile()
        'Load the file
        Try
            file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
        Catch ex As StringNotFoundException
            MsgBox("Failed to open the file, check that it exists and you have read/write access.", MsgBoxStyle.Critical, "Error opening file")
            EZLogging.WriteToLog("Failed to load file " & filepath & ". Exiting NPC editor", levels.critical)
            Close()
            Return
        End Try
        'Load all the properties
        Try
            Name1.Text = GetBetween(file, "SetKeyName(""", """);")
        Catch ex As StringNotFoundException
            Name1.Text = "NPCname"
        End Try
        Try
            ID.Text = GetBetween(file, "SetId(""", """);")
        Catch ex As StringNotFoundException
            ID.Text = "ID"
        End Try
        Try
            Adjectives.Text = LPCArrayToCSV(GetBetween(file, "SetAdjectives(", ");"))
        Catch ex As StringNotFoundException
            Adjectives.Text = "Basic as a beggar"
        End Try
        Try
            ShortDescription.Text = GetBetween(file, "SetShort(""", """);")
        Catch ex As StringNotFoundException
            ShortDescription.Text = "an NPC"
        End Try
        Try
            LongDesc.Text = GetBetween(file, "SetLong(""", """);")
        Catch ex As StringNotFoundException
            LongDesc.Text = "an NPC that has no description"
        End Try

        Try
            NPCObjects.Text = LPCArrayToCSV(GetBetween(file, "SetInventory(", ");"))
        Catch ex As StringNotFoundException
            NPCObjects.Text = "none"
        End Try

        Try
            LevelLabel.Text = GetBetween(file, "SetLevel(""", """);")
        Catch ex As StringNotFoundException
            LevelLabel.Text = "0"
        End Try

        Try
            Gender.Text = GetBetween(file, "SetGender(""", """);")
        Catch ex As StringNotFoundException
            Gender.Text = "null"
        End Try

        Try
            Language.Text = GetBetween(file, "SetDefaultLanguage(""", """);")
        Catch ex As StringNotFoundException
            Language.Text = "common"
        End Try

    End Sub

    Private Sub SaveNPCFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveNPCFileToolStripMenuItem.Click
        Dim chooser As New SaveFileDialog
        chooser.Title = "Save NPC file to..."
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
        stringtosave = ReplaceOrCreate(stringtosave, "SetKeyName(", ReQuote(Name1.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetShort(", ReQuote(ShortDescription.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetLong(", ReQuote(LongDesc.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetId(", CSVToLPCArray(ID.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetAdjectives(", CSVToLPCArray(Adjectives.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetInventory(", CSVToLPCArray(NPCObjects.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetLevel(", ReQuote(Level.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetGender(", ReQuote(Gender.Text), ");")
        stringtosave = ReplaceOrCreate(stringtosave, "SetDefaultLanguage(", ReQuote(Language.Text), ");")

        'Actually save the file
        Try
            My.Computer.FileSystem.WriteAllText(filepath, stringtosave, False, System.Text.Encoding.Default)
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

    Private Sub NewNPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewNPCToolStripMenuItem.Click
        Try
            filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\NPCTemplate.c"
            file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
            loadFromFile()
            filepath = "NEW"
        Catch ex As Exception
            MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
        End Try
    End Sub

    Private Sub OpenNPCFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNPCFileToolStripMenuItem.Click
        Dim chooser As New OpenFileDialog
        chooser.Title = "Open an NPC file..."
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
        If filepath = "NEW" Then
            MsgBox("You need to save the file before you can edit the code. Please save first.", MsgBoxStyle.Information, "Error opening code for editing")
        Else
            Dim lpceditor As New FileEditor
            Try
                file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
            Catch ex As Exception
                MsgBox("Failed to open the code file properly. Check file exists and is accessible.", MsgBoxStyle.Critical)
            End Try
            lpceditor.dialogValue = file
            lpceditor.Text = "LPC Code editor: " & filepath
            lpceditor.ShowDialog()
            file = lpceditor.dialogValue.Replace(vbLf, vbNewLine)
        End If
    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles LongDesc.TextChanged

    End Sub


    Private Sub LevelLabel_Click(sender As Object, e As EventArgs) Handles LevelLabel.Click

    End Sub

    Private Sub Level_Scroll(sender As Object, e As EventArgs) Handles Level.Scroll
        LevelLabel.Text = Level.Value.ToString()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
