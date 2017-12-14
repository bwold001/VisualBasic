Public Class frmCrediCard

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim oldBalance, charges, credits, newBalance, minPayment As Double
        InputData(oldBalance, charges, credits)
        CalculateNewValues(oldBalance, charges, credits, newBalance, minPayment)
        DisplayData(newBalance, minPayment)
    End Sub

    Sub InputData(ByRef oldBalance As Double, ByRef charges As Double, ByRef credits As Double)
        oldBalance = txtBoxOldBalance.Text()
        charges = txtBoxCharges.Text()
        credits = txtBocCredits.Text()
    End Sub

    Sub CalculateNewValues(ByRef oldBalance As Double, ByRef charges As Double, ByRef credits As Double, ByRef newBalance As Double, ByRef minPayment As Double)
        Dim financeCharge As Double = 1.015
        newBalance = (financeCharge * oldBalance) + charges - credits
        If newBalance <= 20 Then
            minPayment = newBalance
        ElseIf newBalance > 20 Then
            minPayment = 20 + 0.1 * (newBalance - 20)
        End If
    End Sub

    Sub DisplayData(ByRef newBalance As Double, ByRef minPayment As Double)
        txtBoxNewBalance.Text = FormatCurrency(CStr(newBalance))
        txtBoxMinPayment.Text = FormatCurrency(CStr(minPayment))
    End Sub
End Class
