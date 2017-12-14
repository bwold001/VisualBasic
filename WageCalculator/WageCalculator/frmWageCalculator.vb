Public Class frmWageCalculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hourlyWage, weeklyHours, grossEarnings, federalTaxes As Double
        Const TAX_RATE As Double = 0.15
        hourlyWage = txtHourlyWage.Text
        weeklyHours = txtWeeklyHours.Text

        If weeklyHours > 40 Then
            grossEarnings = (40 * hourlyWage) + (1.5 * hourlyWage * (weeklyHours - 40))
        Else
            grossEarnings = weeklyHours * hourlyWage
        End If

        txtGrossEarning.Text = FormatCurrency(CStr(grossEarnings))

        federalTaxes = grossEarnings * TAX_RATE
        txtFWT.Text = FormatCurrency(CStr(federalTaxes))


        txtNetEarning.Text = FormatCurrency(grossEarnings - federalTaxes)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHourlyWage.Clear()
        txtWeeklyHours.Clear()
        txtNetEarning.Clear()
        txtFWT.Clear()
        txtGrossEarning.Clear()
    End Sub
End Class
