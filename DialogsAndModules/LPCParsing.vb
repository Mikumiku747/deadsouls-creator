Module LPCParsing

    ''' <summary>
    ''' Searches through the source string and returns the substring between start and end.
    ''' </summary>
    ''' <param name="source">The string to search through</param>
    ''' <param name="start">The start of your target string</param>
    ''' <param name="end_">The end of your target string</param>
    ''' <returns>The substring between start and end_</returns>
    ''' <remarks>The result doesn't include the start and end strings.</remarks>
    Public Function GetBetween(source As String, start As String, end_ As String)
        Dim s_len = start.Length
        Dim result As String
        Dim startIndex = source.IndexOf(start) + s_len
        Dim toBeSearched = source.Substring(startIndex)
        Dim endIndex = toBeSearched.IndexOf(end_)
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

    Function DeQuote(source As String)
        Dim stripped As String = StripWhitepace(source)
        stripped = stripped.Replace(vbNewLine, "")
        Return stripped.Replace("""", "")
    End Function

    Function LPCArrayToCSV(array As String)
        'Get rid of whitespace and surrounding array syntax
        Dim arrayClean As String = StripWhitepace(array)
        arrayClean = arrayClean.Substring(3, arrayClean.Length - 6)
        'Get rid of quotes
        Dim result = arrayClean.Replace("""", "")
        result = result.Replace(",", ", ")
        Return result
    End Function

    '//TODO: Add some more functions so it's super easy to compile the new LPC file and Parse the old one.
End Module
