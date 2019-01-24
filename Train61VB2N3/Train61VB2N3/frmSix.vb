Public Class frmSix
    Dim score(9, 2) As Integer

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtSaveScore.Text.Trim = "" Or txtMidterm.Text.Trim = "" Or txtFinal.Text.Trim = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่ถูกต้อง/ไม่สมบูรณ์")
            Exit Sub
        End If

        Dim n As Integer = Val(cmbStudent.SelectedIndex)
        score(n, 0) = Val(txtSaveScore.Text)
        score(n, 1) = Val(txtMidterm.Text)
        score(n, 2) = Val(txtFinal.Text)
        txtSaveScore.Clear()
        txtMidterm.Clear()
        txtFinal.Clear()

        If cmbStudent.SelectedIndex < cmbStudent.Items.Count - 1 Then
            cmbStudent.SelectedIndex = cmbStudent.SelectedIndex + 1
        End If
        txtSaveScore.Focus()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        dgvData.Rows.Clear()

        For i = 0 To cmbStudent.Items.Count - 1
            dgvData.Rows.Add()
            dgvData.Item(0, i).Value = score(i, 0)
            dgvData.Item(1, i).Value = score(i, 1)
            dgvData.Item(2, i).Value = score(i, 2)
            dgvData.Item(3, i).Value = getGrade(score(i, 0), score(i, 1), score(i, 2))
        Next
    End Sub
    Private Function getGrade(ByVal sc1 As Integer, ByVal sc2 As Integer, ByVal sc3 As Integer) As String
        Dim totalScore As Integer = sc1 + sc2 + sc3
        Dim grade As String
        If totalScore < 50 Then
            grade = "F"
        ElseIf totalScore < 55 Then
            grade = "D"
        ElseIf totalScore < 60 Then
            grade = "D+"
        ElseIf totalScore < 65 Then
            grade = "C"
        ElseIf totalScore < 70 Then
            grade = "C+"
        ElseIf totalScore < 75 Then
            grade = "B"
        ElseIf totalScore < 80 Then
            grade = "B+"
        Else
            grade = "A"
        End If
        Return grade
    End Function

    Private Sub frmSix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 9
            score(i, 0) = 10
            score(i, 1) = 0
            score(i, 2) = 0
        Next
    End Sub
End Class