Public Class frmFrequency

    Dim scores() As String = IO.File.ReadAllLines("Scores.txt")
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstBoxDisplay.Items.Add("Intervals" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "Frequency")
        lstBoxDisplay.Items.Add("0 to 9" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & frequencies(0, scores))
        lstBoxDisplay.Items.Add("10 to 19" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & frequencies(1, scores))
        lstBoxDisplay.Items.Add("20 to 29" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & frequencies(2, scores))
        lstBoxDisplay.Items.Add("30 to 39" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & frequencies(3, scores))
        lstBoxDisplay.Items.Add("40 to 49" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & frequencies(4, scores))
    End Sub

    Function frequencies(num As Integer, data() As String) As Integer
        Dim count As Integer = 0
        Select Case num
            Case 0
                For i As Integer = 0 To data.Count() - 1
                    If data(i) < 10 Then
                        count += 1
                    End If
                Next
                Return count
            Case 1
                For i As Integer = 0 To data.Count() - 1
                    If data(i) >= 10 And data(i) < 20 Then
                        count += 1
                    End If
                Next
                Return count
            Case 2
                For i As Integer = 0 To data.Count() - 1
                    If data(i) >= 20 And data(i) < 30 Then
                        count += 1
                    End If
                Next
                Return count
            Case 3
                For i As Integer = 0 To data.Count() - 1
                    If data(i) >= 30 And data(i) < 40 Then
                        count += 1
                    End If
                Next
                Return count
            Case 4
                For i As Integer = 0 To data.Count() - 1
                    If data(i) >= 40 And data(i) < 50 Then
                        count += 1
                    End If
                Next
                Return count
        End Select
    End Function
End Class
