''' <summary>
''' A set of functions for handling LPC code, and converting it into easier to handle data types. See individual function docs for more info.
''' </summary>
Public Module LPCParsing

    ''' <summary>
    ''' A simple exception class specifically for functions in this module. 
    ''' </summary>
    ''' <remarks>Apart from being a different type, this is near identical to a normal exception.</remarks>
    Public Class StringNotFoundException
        Inherits Exception

        Public Sub New()
        End Sub

        Public Sub New(message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(message As String, inner As Exception)
            MyBase.New(message, inner)
        End Sub
    End Class

    ''' <summary>
    ''' Searches through the source string and returns the substring between start and end.
    ''' </summary>
    ''' <param name="source">The string to search through</param>
    ''' <param name="start">The start of your target string</param>
    ''' <param name="end_">The end of your target string</param>
    ''' <returns>The substring between start and end_</returns>
    ''' <remarks>The result doesn't include the start and end strings. Will throw an exception if
    ''' it can't find the start or end string.</remarks>
    Public Function GetBetween(source As String, start As String, end_ As String)
        Dim s_len = start.Length
        Dim result As String
        Dim startIndex = source.IndexOf(start) + s_len
        'MsgBox(startIndex)
        If startIndex = start.Length - 1 Then
            Throw New StringNotFoundException("Failed to find the desired start string.")
        End If
        Dim toBeSearched = source.Substring(startIndex)
        Dim endIndex = toBeSearched.IndexOf(end_)
        'MsgBox(endIndex)
        If endIndex = end_.Length - 1 Then
            Throw New StringNotFoundException("Failed to find the desired end string.")
        End If
        result = source.Substring(startIndex, endIndex)
        Return result
    End Function

    ''' <summary>
    ''' Searches through a string and replaces whatever is between start and end with a new string
    ''' </summary>
    ''' <param name="source">THe string to search through and perform the replacement on.</param>
    ''' <param name="start">The start of your target area</param>
    ''' <param name="end_">The end of your target area</param>
    ''' <param name="new_">The thing to put between them</param>
    ''' <remarks>The area replaced doesn't include the start and end strings.</remarks>
    Public Function SetBetween(source As String, start As String, end_ As String, new_ As String)
        Dim target = GetBetween(source, start, end_)
        Return source.Replace(start + target + end_, start + new_ + end_)
    End Function

    ''' <summary>
    ''' Parses an LPC Mapping and returns an array of keys and an array of values
    ''' </summary>
    ''' <param name="mapping">The string of the mapping to parse</param>
    ''' <returns>An array containing the key array and value array.</returns>
    ''' <remarks>The mapping string MUST follow th following structure:
    ''' ([ key: value, 
    '''    key: value, 
    '''    key: value ])
    ''' If the mapping does not follow this structure, the parser can't handle 
    ''' it. Also, keep in mind it only seperates the keys and values, and they 
    ''' will still have tons of whitespace stuck to them. </remarks>
    Function ParseMapping(mapping As String)
        'Trim the ends of the mapping
        mapping = mapping.Replace("([", "")
        mapping = mapping.Replace("])", "")
        mapping = mapping.Trim()
        mapping = " " + mapping
        'Set up some variables
        Dim currentChar As Char
        Dim prevChar As Char
        Dim splitpoints As New List(Of Integer)
        splitpoints.Add(0)
        Dim insideArray As Boolean = False
        Dim insideLiteral As Boolean = False

        'This section marks the ends of each key/value pair
        'Go through the mapping, marking points where each key/value pair ends
        For i As Integer = 0 To mapping.Length - 1
            If i > 0 Then prevChar = mapping.Substring(i - 1, 1)
            currentChar = mapping.Substring(i, 1)
            'These statements take arrays and literals into consideration
            If prevChar + currentChar = "({" Then
                insideArray = True
            End If
            If prevChar + currentChar = "})" Then
                insideArray = False
            End If
            If currentChar = """" Then
                insideLiteral = Not (insideLiteral)
            End If

            'If we find a comma (outside of an array or literal) we mark it for a split
            If mapping.Substring(i, 1) = "," And Not (insideArray) And Not (insideLiteral) Then
                splitpoints.Add(i)
            End If
        Next

        'A quick check to see we got valid split points
        'For Each number In splitpoints
        '    Debug.Write(number.ToString() + ", ")
        'Next
        'Debug.Print("")

        'This section chops up the mapping into key value pairs
        Dim prevPoint As Integer = 0
        Dim currentpoint As Integer
        Dim pairs As New List(Of String)
        For i As Integer = 1 To splitpoints.Count - 1
            prevPoint = splitpoints(i - 1)
            currentpoint = splitpoints(i)
            pairs.Add(Trim(mapping.Substring(prevPoint + 1, currentpoint - prevPoint - 1)))
        Next
        pairs.Add(mapping.Substring(currentpoint + 1))

        'Another check to see how the splitting went
        'Debug.Print("Start of KV pairs")
        'For Each pair In pairs
        '    Debug.Print(pair)
        'Next
        'Debug.Print("End of KV pairs")

        'This section splits the pairs into 2 arrays, of keys and values
        Dim keys As New List(Of String)
        Dim values As New List(Of String)

        'We need to take into account that literals may have a colon in them, so we need to do a similar thing to last time
        Dim colonIndex As Integer
        'Do this for every pair
        For Each pair In pairs
            insideLiteral = False
            colonIndex = 0
            'Find the KV Seperator
            For i As Integer = 0 To pair.Length - 1
                If pair.Substring(i, 1) = """" Then insideLiteral = Not insideLiteral
                If pair.Substring(i, 1) = ":" And Not insideLiteral Then
                    colonIndex = i
                End If
            Next
            'Add the key and value to the lists
            Debug.Assert(Not (colonIndex = 0), "Error Parsing Mapping", "This mapping contains a non Key/Value pair element.")
            keys.Add(pair.Substring(0, colonIndex))
            values.Add(pair.Substring(colonIndex + 1))
        Next
        'Make sure the splitting went mostly smoothly
        Debug.Assert(keys.Count = values.Count, "Error Parsing Mapping", "Some kind of parsing error occured, the amout of keys and values doesn't match.")


        'Check that they got split correctly
        Debug.Print("Start of KV Splits")
        For i As Integer = 0 To keys.Count - 1
            Debug.Print("Key: " + keys(i).ToString())
            Debug.Print("Value: " + values(i).ToString())
        Next
        Debug.Print("End of KV Splits")

        'Copy the keys and values into proper arrays, instead of lists
        Dim finalKeys(keys.Count - 1) As String
        keys.CopyTo(finalKeys)
        Dim finalValues(values.Count - 1) As String
        values.CopyTo(finalValues)

        'Return the keys and values
        Return {finalKeys, finalValues}
    End Function

    ''' <summary>
    ''' Compiles a mapping into a single string from two arrays of keys and values
    ''' </summary>
    ''' <param name="keys">An array of strings to use as the keys</param>
    ''' <param name="values">An array of strings with the corresponsing values for the keys</param>
    ''' <returns>A string with the keys and values as an LPC Array.</returns>
    Function CompileMapping(keys As String(), values As String())
        Debug.Assert(keys.Length = values.Length, "Key/Value length mismatch!", "Please make sure the number of keys and values is the same.")
        Dim result As String = "(["
        For i As Integer = 0 To keys.Length - 1
            result = result + keys(i) + ":" + values(i) + ", "
        Next
        result = result + "])"
        Dim lastComma As Integer = result.LastIndexOf(",")
        Dim lastColon As Integer = result.LastIndexOf(":")
        If lastComma > lastColon Then
            'MsgBox("getting rid of the extra comma")
            Return result.Substring(0, lastComma) + result.Substring(lastComma + 1)
        Else
            Return result
        End If
    End Function

    ''' <summary>
    ''' Takes a string and removes all spaces, tabs, and new-liney things before and after any meaningful data
    ''' </summary>
    ''' <param name="source">The string to strip whitespace off of.</param>
    ''' <returns>A string with no whitepace before or after the real data</returns>
    ''' <remarks>Still a little buggy</remarks>
    Function StripWhitepace(source As String)
        Dim startchar As Integer = 0
        Dim endchar As Integer = 0
        'find the start
        For Each letter In source
            If Not (letter = ControlChars.CrLf Or letter = ControlChars.Cr Or letter = ControlChars.Lf Or letter = " " Or letter = ControlChars.Tab) Then
                startchar = source.IndexOf(letter)
                Exit For
            End If
        Next
        'trim the front
        Dim withoutStart As String = source.Substring(startchar)
        Dim withoutStartRev = withoutStart.Reverse.ToString
        For Each letter In withoutStartRev
            If Not (letter = ControlChars.CrLf Or letter = ControlChars.Cr Or letter = ControlChars.Lf Or letter = " " Or letter = ControlChars.Tab) Then
                endchar = withoutStartRev.IndexOf(letter)
                Exit For
            End If
        Next
        'trim the back
        Dim withoutEnd As String = withoutStartRev.Substring(endchar + 1)
        Dim result As String = withoutEnd.Reverse.ToString()
        Return withoutStart
    End Function

    ''' <summary>
    ''' Extracts the literals from a snippet of code.
    ''' </summary>
    ''' <param name="source">The code to get a literal out of.</param>
    ''' <returns>All the literals in the code block concatenated together.</returns>
    ''' <remarks>will simply grab everything between a pair of quotes.</remarks>
    Function DeQuote(source As String)
        'MsgBox("Dequoting this:" + vbNewLine + source)
        Dim insideLiteral As Boolean = False
        Dim startOfLiteral As Integer = False
        Dim endOfLiteral As Integer = False
        Dim result As String = ""
        For i As Integer = 0 To source.Length - 1
            Dim letter = source.Substring(i, 1)
            If insideLiteral Then
                If letter = """" Then
                    endOfLiteral = i
                    insideLiteral = False
                    result = result + source.Substring(startOfLiteral, endOfLiteral - startOfLiteral)
                End If
            Else
                If letter = """" Then
                    startOfLiteral = i + 1
                    insideLiteral = True
                End If
            End If
        Next
        'MsgBox("Result" + vbNewLine + result)
        Return result
    End Function

    ''' <summary>
    ''' Puts quotes back onto a string
    ''' </summary>
    ''' <param name="literal">The literal to be enclosed in quotes</param>
    ''' <returns>The string with double quotes around it.</returns>
    Function ReQuote(literal As String)
        Return """" + literal + """"
    End Function

    ''' <summary>
    ''' Converts an LPC array to a comma seperated list of values
    ''' </summary>
    ''' <param name="array">A string of an LPC Array, to be converted to a CSV</param>
    ''' <returns>a string with the LPC array in CSV form</returns>
    Function LPCArrayToCSV(array As String)
        'Get rid of whitespace and surrounding array syntax
        Dim arrayClean As String = StripWhitepace(array)
        arrayClean = arrayClean.Substring(3, arrayClean.Length - 6)
        'Get rid of quotes
        Dim result = arrayClean.Replace("""", "")
        result = result.Replace(",", ", ")
        Return result
    End Function

    ''' <summary>
    ''' Takes a string of a CSV and turns it into a string of an LPC array
    ''' </summary>
    ''' <param name="csv">A string of a CSV to be turned into an LPC array</param>
    ''' <returns>A string of an LPC Array, withe the contents of the CSV array</returns>
    Function CSVToLPCArray(csv As String)
        Dim items() As String = csv.Split(",")
        Dim processedItems As List(Of String) = New List(Of String)
        For Each item In items
            Dim processedItem As String = item
            'If processedItem.Substring(0, 1) = " " Then
            '    processedItem = item.Substring(1)
            'End If
            processedItem = ReQuote(processedItem)
            processedItems.Add(processedItem)
            'MsgBox(processedItem)
        Next
        'MsgBox("Items gathered:")
        For Each item In processedItems
            'MsgBox(item)
        Next
        Dim results As String = ""
        For Each item In processedItems
            results = results + item + ","
        Next
        Return "({" + results.Substring(0, results.Length - 1) + "})"
    End Function

    '//TODO: Add some more functions so it's super easy to compile the new LPC file and Parse the old one.
End Module
