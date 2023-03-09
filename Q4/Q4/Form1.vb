Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim answer As Integer = 9
        Dim attempts As Integer = 0
        Dim userentry As String = ""
        While answer.ToString <> userentry
            userentry = InputBox("Enter a number between 1 and 30")
            attempts = attempts + 1
        End While
        MsgBox("Well done you correctly guessed the number, it took you " & attempts.ToString & " attempts")
    End Sub
End Class

