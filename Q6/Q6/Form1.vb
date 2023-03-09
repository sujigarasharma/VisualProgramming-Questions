Public Class Form1

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a, b, c, d, f, g As String
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text
        f = TextBox5.Text
        g = TextBox6.Text
        MsgBox(vbTab & "Address Of Detail" & vbTab & vbNewLine & vbNewLine & "Person Name " & vbTab & ": " + a & vbNewLine & "House Number " & vbTab & ": " + b & vbNewLine & "Street Name " & vbTab & ": " + c & vbNewLine & "Town/City " & vbTab & ": " + d & vbNewLine & "Country " & vbTab & ": " + f & vbNewLine & "Postal code " & vbTab & ": " + g)


    End Sub
End Class

