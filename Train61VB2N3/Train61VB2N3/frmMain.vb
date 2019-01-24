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
End Class