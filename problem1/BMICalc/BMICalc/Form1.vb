Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click

    End Sub

    Private Sub txtWeight_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtWeight.TextChanged

        Dim hst As String
        Dim wst As String

        hSt = txtHeight.Text
        wst = txtWeight.Text

        Dim h As Double
        Dim w As Double

        h = CDbl(hst)
        w = CDbl(wst)

        Dim BMI As Double

        BMI = (w * 7.03) / (h ^ 2)

        txtBodyMass.Text = CStr(BMI)






    End Sub
End Class
