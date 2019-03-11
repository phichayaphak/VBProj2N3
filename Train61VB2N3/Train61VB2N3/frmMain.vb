Public Class frmMain


    Private Sub ประเภทสนคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ประเภทสนคาToolStripMenuItem.Click
        Dim fFirst As New frmFirst
        fFirst.ShowDialog()


    End Sub

    Private Sub สนคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles สนคาToolStripMenuItem.Click
        Dim fSecond As New frmSecondForm
        fSecond.ShowDialog()
    End Sub

    Private Sub ขอมลพนกงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ขอมลพนกงานToolStripMenuItem.Click
        Dim fThird As New frmThird
        fThird.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmLogin As New LoginForm1
        empID = ""
        frmLogin.ShowDialog()

        If empID = "" Then
            End
        Else
            Select Case staName
                Case "พนักงานขาย"
                    mnu10.Enabled = False
                    mnu30.Enabled = False
                    mnu40.Enabled = False
                    สงซอสนคาToolStripMenuItem.Enabled = False
                    รบสนคาToolStripMenuItem.Enabled = False
                    ขายสนคาToolStripMenuItem.Enabled = False
                    สงสนคาToolStripMenuItem.Enabled = False
                    รบคนToolStripMenuItem.Enabled = False
                Case "ผู้จัดการทั่วไป"
                    mun20.Enabled = False
            End Select
        End If




    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        Dim frmNewSale As New frmSale
        frmNewSale.Show()

    End Sub
End Class