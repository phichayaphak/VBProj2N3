Public Class frmMenu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myform As New frmFirst
        myform.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myform As New frmSecondForm
        myform.BackColor = Color.Green
        myform.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myform As New frmThird
        myform.BackColor = Color.Green
        myform.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim salary, tax As Double
        'salary = Val(txtSalary.text) 

        If salary < 10000 Then
            tax = 0

        ElseIf salary < 30000 Then
            tax = salary * 0.05

        ElseIf salary < 50000 Then
            tax = salary * 0.07
        Else
            tax = salary * 0.1
        End If

        lblProjectName.Text = tax
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblProjectName.Text = myProjectName
    End Sub
End Class