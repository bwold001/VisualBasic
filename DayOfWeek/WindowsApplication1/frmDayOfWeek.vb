Public Class frmDayOfWeek


    Private Sub btnDayOfWeek_Click(sender As Object, e As EventArgs) Handles btnDayOfWeek.Click
        Dim day As String
        day = txtBoxDate.Text
        day = DayOfWeek(day)
        txtBoxDayOfWeek.Text = CStr(day)
    End Sub

    Function DayOfWeek(ByVal d As Date) As String
        Dim str As String = FormatDateTime(d, DateFormat.LongDate)
        Dim n As Integer = str.IndexOf(","c)
        Return str.Substring(0, n)
    End Function
End Class
