Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Integer
        a = InputBox("Enter The Number to check the Negative or Positive")
        If a < 0 Then
            MsgBox("The Entered Number is Negetive")
        ElseIf a > 0 Then
            MsgBox("The Entered Number is Positive")
        End If
    End Sub
End Class
