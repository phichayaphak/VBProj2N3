Public Class frmFifth

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim Grade As Double = Val(txtGrade.Text)
        Dim Result As String
        If Grade >= 3.75 Then
            Result = "ได้รับเกียรตินิยมอันดับ 1"
        ElseIf Grade >= 3.5 Then
            Result = "ได้รับเกียรตินิยมอันดับ 2"
        ElseIf Grade >= 2.0 Then
            Result = "ได้รับปริญญาบัตรปกติ"
        Else
            Result = "ไม่อยู่ในเกณฑ์รับปริญญา "
        End If
        lblResult.Text = Result

    End Sub

    Private Sub btnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaid.Click
        Dim age As Integer = Val(txtAge.Text)
        Dim getSalary As Boolean = chkGetSalary.Checked
        Dim paid As Double

        If age >= 60 And getSalary = False Then
            paid = 500
        Else
            paid = 0
        End If
        lblPaid.Text = FormatNumber(paid, 2)
    End Sub

    Private Sub btnTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTax.Click
        Dim incomes, tax As Double

        incomes = Val(txtIncomes.Text)
        If incomes < 200000 Then
            tax = 0
        ElseIf incomes >= 200000 And incomes <= 500000 Then
            tax = incomes * 0.03
        Else
            tax = incomes * 0.05
        End If
        lblTax.Text = FormatNumber(tax, 2)

    End Sub
   
End Class