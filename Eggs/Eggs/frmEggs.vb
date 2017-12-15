Public Class frmEggs

    Dim eggs() As String = IO.File.ReadAllLines("Eggs.txt")
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        Dim jumbo, extraLarge, large, medium, small As Integer
        count(jumbo, extraLarge, large, medium, small)
        display(jumbo, extraLarge, large, medium, small)

    End Sub

    Sub count(ByRef jumbo As Integer, ByRef extraLarge As Integer, ByRef large As Integer, ByRef medium As Integer, ByRef small As Integer)
        For i As Integer = 0 To eggs.Count - 1
            If eggs(i) >= 2.5 Then
                jumbo += 1
            ElseIf eggs(i) >= 2.25 And eggs(i) < 2.5 Then
                extraLarge += 1
            ElseIf eggs(i) >= 2 And eggs(i) < 2.25 Then
                large += 1
            ElseIf eggs(i) >= 1.75 And eggs(i) < 2 Then
                medium += 1
            ElseIf eggs(i) >= 1.5 And eggs(i) < 1.75 Then
                small += 1
            End If
        Next
    End Sub

    Function calculateLightest()
        Dim lightest As Double = eggs(0)
        For i As Integer = 0 To eggs.Count - 1
            If eggs(i) < lightest Then
                lightest = eggs(i)
            End If
        Next
        Return lightest
    End Function

    Function calculateHeaviest()
        Dim heaviest As Double = eggs(0)
        For i As Integer = 0 To eggs.Count - 1
            If eggs(i) > heaviest Then
                heaviest = eggs(i)
            End If
        Next
        Return heaviest
    End Function

    Sub display(ByRef jumbo As Integer, ByRef extraLarge As Integer, ByRef large As Integer, ByRef medium As Integer, ByRef small As Integer)

        lstBoxEggs.Items.Add(jumbo & "  Jumbo eggs")
        lstBoxEggs.Items.Add(extraLarge & "  Extra Large eggs")
        lstBoxEggs.Items.Add(large & "  Large eggs")
        lstBoxEggs.Items.Add(medium & "  Medium eggs")
        lstBoxEggs.Items.Add(small & "  Small eggs")
        lstBoxEggs.Items.Add("Lightest egg: " & calculateLightest() & "  ounces")
        lstBoxEggs.Items.Add("Heaviest egg: " & calculateHeaviest() & "  ounces")

    End Sub

End Class
