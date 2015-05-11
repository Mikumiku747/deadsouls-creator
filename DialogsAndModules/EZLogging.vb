'EZ Logging module
'This file is written by Daniel Selmes, you may distribute it freely, but you 
'cannot edit it. If you use any part of it, make sure a user can tell that I 
'helped make the product. 

''' <summary>
''' Some functions to make logging quicker and easier
''' </summary>
Module EZLogging

    ''' <summary>
    ''' The file that the log is currently writing to
    ''' </summary>
    Public logfile As String

    Public mask As Integer

    ''' <summary>
    ''' Initialises the log file, provide a path for the log to be saved to and optionally a mask to ignore messages below a certain priority level. 
    ''' </summary>
    ''' <param name="filename">The file to use as a log, it's OK if this file already exists, it'll be appended</param>
    ''' <param name="mask">The debug mask to use, anything below this level will be ignoreds</param>
    Public Sub InitialiseLogging(filename As String, Optional ByVal mask As levels = levels.output)
        Debug.Print("Deadsouls-Creator starting, " & Now.ToString & ", logging to " & filename)
        logfile = filename
        Try
            My.Computer.FileSystem.WriteAllText(logfile, vbNewLine & "--------------------------------------------------------------------------------" & vbNewLine & vbNewLine, True)
        Catch ex As IO.IOException
            Debug.Print("[WARNING - " & Now.ToString & " ] Could not open log file, no log will be made on disk!" & vbNewLine)
        End Try
        WriteToLog("Deadsouls-Creator Starting...", levels.output)
    End Sub

    ''' <summary>
    ''' The different debug levels
    ''' </summary>
    Public Enum levels As Integer
        ''' <summary>
        ''' For messages that will only be seen when debugging
        ''' </summary>
        debug = 0
        ''' <summary>
        ''' For standard output messages, visible to the user
        ''' </summary>
        output = 1
        ''' <summary>
        ''' For warnings where the program can continue
        ''' </summary>
        warning = 2
        ''' <summary>
        ''' For errors which result in the program stopping
        ''' </summary>
        critical = 3
    End Enum

    ''' <summary>
    ''' Makes a log entry, 
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="level"></param>
    Public Sub WriteToLog(text As String, Optional ByVal level As levels = 0)
        Dim writestring As String = ""
        Select Case level
            Case Is = 1
                If mask >= 1 Then
                    writestring = "[OUTPUT - " & Now.ToString & " ] " & text & vbNewLine
                End If
            Case Is = 2
                If mask >= 2 Then
                    writestring = "[WARNING - " & Now.ToString & " ] " & text & vbNewLine
                End If
            Case Is = 3
                If mask >= 3 Then
                    writestring = "[CRITICAL - " & Now.ToString & " ] " & text & vbNewLine
                End If
            Case Else
                writestring = "[DEBUG - " & Now.ToString & " ] " & text & vbNewLine
        End Select
        Try
            My.Computer.FileSystem.WriteAllText(logfile, writestring, True)
        Catch ex As IO.IOException
            Debug.Print("[WARNING - " & Now.ToString & " ] Could not open log file, no log will be made on disk!" & vbNewLine)
        End Try
        If writestring.Length > 0 Then
            Debug.Print(writestring.Substring(0, writestring.Length - 2))
        End If
    End Sub

End Module
