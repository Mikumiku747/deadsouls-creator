Public Class WeaponEditor

    Public filepath As String

    Dim file As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If filepath = "" Then
            Try
                filepath = My.Computer.FileSystem.CurrentDirectory & "\Resources\WeaponTemplate.c"
                file = My.Computer.FileSystem.ReadAllText(filepath).Replace(vbLf, vbNewLine)
                'loadFromFile()
                filepath = "NEW"
            Catch ex As Exception
                MsgBox("Failed to open the template file. Check the installation or contact support if the problem persists." & vbNewLine & vbNewLine & "More info: " & ex.Message, MsgBoxStyle.Critical, "Template Error")
            End Try
        Else
            Text = filepath & " - Weapon editor - Deadsouls Creator"
            'loadFromFile()
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
            ID.Text = GetBetween(file, "SetId(""", """);")
        Catch ex As StringNotFoundException
            ID.Text = "ID"
        End Try
        Try
            Adjectives.Text = LPCArrayToCSV(GetBetween(file, "SetAdjectives(", ");"))
        Catch ex As StringNotFoundException
            Adjectives.Text = "blanky blunt"
        End Try
        Try
            wepShortDesc.Text = GetBetween(file, "SetShort(""", """);")
        Catch ex As StringNotFoundException
            wepShortDescn.Text = "a weapon"
        End Try
        Try
            LongDesc.Text = GetBetween(file, "SetLong(""", """);")
        Catch ex As StringNotFoundException
            LongDesc.Text = "a weapon that has no description"
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



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub wepName_TextChanged(sender As Object, e As EventArgs) Handles wepName.TextChanged

    End Sub
End Class
