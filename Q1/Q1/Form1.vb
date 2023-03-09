Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As String
        Dim l As Integer

        t = InputBox("Enter The Word : ")
        l = t.Length
        If (l > 5) Then
            MsgBox("This is a more than 5 letters word.")
        Else
            MsgBox("This is a less than 5 letters word.")
        End If

    End Sub
End Class
