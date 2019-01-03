﻿Public Class frmFive
    Dim data(0) As String

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then 'backspace
                e.KeyChar = Nothing
            End If
        End If


        'Asc(e.KeyChar) <> 46  Dot 
        'MessageBox.Show(Asc(e.KeyChar))


    End Sub

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim found As Boolean = False

        If txtInput.Text.Trim = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลตัวเลขสำหรับการเพิ่ม", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        For i = 0 To lstData.Items.Count - 1
            If txtInput.Text = lstData.Items(i) Then
                found = True
                Exit For
            End If
        Next

        If found = False Then
            lstData.Items.Add(txtInput.Text)
            lstData.SelectedIndex = lstData.Items.Count - 1
            lblTotal.Text = getTotal()
            txtInput.Clear()
            txtInput.Focus()

        Else
            MessageBox.Show("ข้อมูลที่ป้อน มีอยู่แล้วในลิสต์กรุณาป้อนค่าใหม่")
            txtInput.Text = ""
            'txtInput.Clear()
            txtInput.Focus()
        End If
    End Sub

    Private Function getTotal() As Integer
        Dim total As Integer
        For i = 0 To lstData.Items.Count - 1
            total = total + Val(lstData.Items(i))
        Next
        Return total
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim found As Boolean = False
        Dim n As Integer
        If txtKey.Text.Trim = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลตัวเลขสำหรับการค้นหา", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        For i = 0 To lstData.Items.Count - 1
            If txtKey.Text = lstData.Items(i) Then
                found = True
                n = i
                Exit For
            End If
        Next

        If found = False Then
            lstData.SelectedIndex = -1
            MessageBox.Show("ไม่พบข้อมูลที่ท่านค้นหา")
        Else
            lstData.SelectedIndex = n
            MessageBox.Show("พบข้อมูลที่ท่านค้นหา")
        End If

    End Sub




    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ReDim data(lstData.Items.Count - 1)
        For i = 0 To lstData.Items.Count - 1
            data(i) = lstData.Items(i)
        Next
        Call sort()
        Call display()

    End Sub

    Private Sub sort()
        Dim temp As String
        For i = 0 To data.Length - 1
            For j = i + 1 To data.Length - 1
                If Val(data(j)) < Val(data(i)) Then
                    temp = data(j)
                    data(j) = data(i)
                    data(i) = temp
                End If
            Next
        Next

    End Sub

    Private Sub display()
        For i = 0 To data.Length - 1
            lstDataSorted.Items.Add(data(i))
        Next
        lstDataSorted.SelectedIndex = lstDataSorted.Items.Count - 1
    End Sub

End Class