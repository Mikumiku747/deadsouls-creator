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

    '//TODO: Add some more functions so it's super easy to compile the new LPC file and Parse the old one.

End Module
