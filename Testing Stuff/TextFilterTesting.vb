Public Class TextFilterTesting

    Dim filePath As String = "C:\ds\lib\domains\daniel\room\police_box.c"

    Private Sub TextFilterTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim source As String = My.Computer.FileSystem.ReadAllText(filePath)
        TextBox1.Text = LPCParsing.GetBetween(source, "SetClimate(", ");")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim source As String = My.Computer.FileSystem.ReadAllText(filePath)
        source = LPCParsing.SetBetween(source, "SetClimate(", ");", TextBox1.Text)
        MsgBox(source)
    End Sub
End Class