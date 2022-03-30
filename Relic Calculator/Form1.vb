Public Class RelicCalculatorForm
    Sub Update(sender As Object, e As EventArgs) Handles _
        ChkC.Click, ChkU.Click, ChkR.Click, NumInt.ValueChanged, NumExc.ValueChanged, NumFla.ValueChanged, NumRad.ValueChanged, ChkC.Click

        Dim Chance As Decimal

        If sender.name = "ChkC" Or sender.name = "ChkU" Or sender.name = "ChkR" Then
            ChkC.CheckState = CheckState.Unchecked
            ChkU.CheckState = CheckState.Unchecked
            ChkR.CheckState = CheckState.Unchecked
            sender.checkstate = CheckState.Checked
        End If

        If ChkC.CheckState = CheckState.Checked Then
            Chance = Math.Round(100 * (1 - ((1 - (0.76 / 3)) ^ NumInt.Value) * ((1 - (0.7 / 3)) ^ NumExc.Value) * ((1 - (0.6 / 3)) ^ NumFla.Value) * ((1 - (0.5 / 3)) ^ NumRad.Value)), 2)
        ElseIf ChkU.CheckState = CheckState.Checked Then
            Chance = Math.Round(100 * (1 - (0.89 ^ NumInt.Value) * (0.87 ^ NumExc.Value) * (0.83 ^ NumFla.Value) * (0.8 ^ NumRad.Value)), 2)
        ElseIf ChkR.CheckState = CheckState.Checked Then
            Chance = Math.Round(100 * (1 - (0.98 ^ NumInt.Value) * (0.96 ^ NumExc.Value) * (0.94 ^ NumFla.Value) * (0.9 ^ NumRad.Value)), 2)
        End If

        TxtChance.Text = String.Format("{0}% Chance", Chance)

    End Sub
End Class

