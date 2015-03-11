Public Class NPCEditor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub


    Private Sub LevelLabel_Click(sender As Object, e As EventArgs) Handles LevelLabel.Click

    End Sub

    Private Sub Level_Scroll(sender As Object, e As EventArgs) Handles Level.Scroll
        LevelLabel.Text = Level.Value.ToString()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub NewNPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewNPCToolStripMenuItem.Click

    End Sub
End Class
