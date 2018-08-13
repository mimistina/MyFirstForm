Public Class Form1
    Dim Message As String = "First constant"
    Dim Number As Integer = 2018
    Dim Number2 As Integer = 2010
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(Message)
        MessageBox.Show(Number)
        MessageBox.Show(Number2)
    End Sub
End Class
