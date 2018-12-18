Public Class frmFirst

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'ค่าจ้าง = ชั่วโมงการทำงาน * อัตราค่าจ้าง
        'ชั่วโมงการทำงาน => txtHours.text 
        'อัตราค่างจ้าง => txtPayRate.text
        'lblResult.text 
        lblResult.Text = Val(txtHours.Text) * Val(txtPayRate.Text)
        lblResult.BackColor = Color.Red


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtPayRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayRate.TextChanged

    End Sub
End Class
