﻿Public Class FileScanDialog

    Private Sub FileScanDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub

    Private Function allfiles(path)
        Dim result As New Specialized.StringCollection
        For Each file In My.Computer.FileSystem.GetFiles(path)
            result.Add(file)
        Next
        For Each directory In My.Computer.FileSystem.GetDirectories(path)
            For Each file In allfiles(directory)
                result.Add(file)
            Next
        Next
        Return result
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()
        Cursor = Cursors.WaitCursor
        Dim everything As Specialized.StringCollection
        Try
            everything = allfiles(My.Settings.deadsouls_installation_path)
        Catch ex As Exception
            MsgBox("Scan for game files failed, check you have read access and that deadsouls is installed in a valid location.", MsgBoxStyle.Critical)
            Close()
            Return
        End Try
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = everything.Count * 5
        ProgressBar.Value = 0
        StatusLabelMajor.Text = "Scanning for room files..."
        StatusLabelMinor.Update()
        My.Settings.rooms_list = New Specialized.StringCollection
        For Each file In everything
            StatusLabelMinor.Text = "Checking " & file
            StatusLabelMinor.Update()
            If file.EndsWith(".c") And My.Computer.FileSystem.ReadAllText(file).Contains("LIB_ROOM") Then
                My.Settings.rooms_list.Add(file)
            End If
            ProgressBar.Value += 1
        Next
        StatusLabelMajor.Text = "Scanning for item files..."
        StatusLabelMinor.Update()
        My.Settings.items_list = New Specialized.StringCollection
        For Each file In everything
            StatusLabelMinor.Text = "Checking " & file
            StatusLabelMinor.Update()
            If file.EndsWith(".c") And My.Computer.FileSystem.ReadAllText(file).Contains("LIB_ITEM") Then
                My.Settings.items_list.Add(file)
            End If
            ProgressBar.Value += 1
        Next
        Close()
    End Sub
End Class