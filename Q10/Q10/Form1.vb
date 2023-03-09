Public Class Form1
    Dim a As String
    Dim b As String
    Private Sub LengthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LengthToolStripMenuItem.Click
        b = TextBox2.Text
        TextBox3.Text = Len(b)
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        a = TextBox1.Text
        TextBox4.Text = a.Replace("C", "M")
    End Sub

    Private Sub ReverseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseToolStripMenuItem.Click
        b = TextBox2.Text
        TextBox5.Text = StrReverse(b)
    End Sub

    Private Sub MiddleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleToolStripMenuItem.Click
        b = TextBox2.Text
        TextBox6.Text = Mid(b, 75, 10)
    End Sub

    Private Sub JoinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JoinToolStripMenuItem.Click
        Dim c As String
        a = TextBox1.Text
        b = TextBox2.Text
        c = a & b
        TextBox7.Text = c

    End Sub
End Class


