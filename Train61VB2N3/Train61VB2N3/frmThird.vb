Public Class frmThird

   
    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Integer = Val(cboSelect.Text)

        txtMyNumber.Font = New Font(txtMyNumber.Font.Name, size, FontStyle.Regular)
        txtMyNumber.Text = FormatNumber(txtMyNumber.Text, 2)


    End Sub



    Private Sub frmThird_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim today As Date = Date.Now
        lblToday.Text = FormatDateTime(today, DateFormat.LongDate)

    End Sub

    Private Sub lblBgRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBgRed.Click
        txtMyNumber.BackColor = lblBgRed.BackColor
    End Sub

    Private Sub lblFgRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFgRed.Click
        txtMyNumber.ForeColor = lblBgRed.BackColor

    End Sub

    Private Sub lblBgYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBgYellow.Click
        txtMyNumber.BackColor = Color.Yellow
    End Sub

    Private Sub lblFgYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFgYellow.Click
        txtMyNumber.ForeColor = Color.Yellow
    End Sub

End Class