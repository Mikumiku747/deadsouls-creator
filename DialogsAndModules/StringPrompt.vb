''' <summary>
''' A Simple dialog box to get a string from the user
''' </summary>
''' <remarks>Meant to be used as a dialog for getting a string from the user. The result is 
''' stored in the string variable dialogValue.</remarks>
Public Class StringPrompt

    ''' <summary>
    ''' This is the value you use for the dialog. Set it to something before 
    ''' load to have a default value for the textbox. It contains the final 
    ''' value the user entered, or nothing if they cancelled/entered nothing
    ''' </summary>
    Public dialogValue As String = ""

    Private Sub StringPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox.Text = dialogValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dialogValue = TextBox.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dialogValue = ""
        Me.Close()
    End Sub
End Class