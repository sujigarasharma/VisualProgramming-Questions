Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n, i, s As Integer
        s = 0
        n = InputBox("Enter The Number : ")
        For i = 0 To n Step 2
            s = s + i

        Next i
        ListBox1.Items.Add(("Sum of ") & (n) & (" Number is ") & (s))
    End Sub
End Class
