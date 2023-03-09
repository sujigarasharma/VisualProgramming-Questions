Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 65 To 70
            ListBox1.Items.Add(Chr(i))
        Next
    End Sub
End Class
