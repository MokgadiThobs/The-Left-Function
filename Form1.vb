Public Class BtnShow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyText As String
        MyText = "Visual Basic"
        MsgBox(Microsoft.VisualBasic.Left(MyText, 4))
    End Sub
End Class
