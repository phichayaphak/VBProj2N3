Public Class frmSecondForm

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'int String double boolean  float
        Dim hours As Integer
        Dim payrate As Long
        Dim result As Long

        hours = Val(txtHours.Text)
        payrate = Val(txtPayRate.Text)

        result = hours * payrate

        lblResult.Text = result

    End Sub

    Private Sub frmSecondForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = myProjectName
    End Sub
End Class