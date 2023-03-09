Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim f, i, n As Integer
        n = TextBox1.Text
        ListBox1.Items.Add("Fibonacci series 0 to " & (n))
        ListBox1.Items.Add(0)
        ListBox1.Items.Add(1)
        For i = 2 To n
            f = a + b
            a = b
            b = f
            ListBox1.Items.Add(f)
        Next
    End Sub
End Class
