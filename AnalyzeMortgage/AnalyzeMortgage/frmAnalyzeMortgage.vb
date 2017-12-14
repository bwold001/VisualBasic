Public Class frmAnalyzeMortgage

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        If ((Char.IsDigit(txtLoan.Text)) And (Char.IsDigit(txtInterestRate.Text)) And (Char.IsDigit(txtDuration.Text))) Then
            Dim loan, interestRate, duration, monthlyPayment, totalInterest As Double
            loan = txtLoan.Text
            interestRate = txtInterestRate.Text
            duration = txtDuration.Text

            monthlyPayment = loan * ((interestRate / 1200) / (1 - (1 + (interestRate / 1200)) ^ (-duration)))
            totalInterest = duration * monthlyPayment - loan

            txtMonthly.Text = FormatCurrency(CStr(monthlyPayment))
            txtInterestPaid.Text = FormatCurrency(CStr(totalInterest))
        Else
            MsgBox("Sorry only digits allowed!")
        End If
    End Sub

    Private Sub txtLoan_TextChanged(sender As Object, e As EventArgs) Handles txtLoan.TextChanged
        txtMonthly.Clear()
        txtInterestPaid.Clear()
    End Sub

    Private Sub txtInterestRate_TextChanged(sender As Object, e As EventArgs) Handles txtInterestRate.TextChanged
        txtMonthly.Clear()
        txtInterestPaid.Clear()
    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        txtMonthly.Clear()
        txtInterestPaid.Clear()
    End Sub

End Class
