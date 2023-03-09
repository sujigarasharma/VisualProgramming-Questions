Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Do While i <= 19
            i = i + 1
            ListBox1.Items.Add("Welcome to VIT University  " & i)
        Loop
    End Sub
End Class
