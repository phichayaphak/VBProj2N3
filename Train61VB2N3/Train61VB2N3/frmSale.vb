Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSale
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConCompany").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label13.Click, Label12.Click, Label11.Click, Label5.Click, Label4.Click, Label2.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function getNewBill() As String
        Dim newBillID As String = ""
        Dim lastBillID As String

        Dim curYear As Integer = Format(Date.Now, "yyyy") + 543
        connectDB()
        strSQL = "Select Max(saleID) as maxSale from Sale Where saleID Like 'S" & curYear & "%' "
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myDR = myComm.ExecuteReader
        myDR.Read()
        
        If Not IsDBNull(myDR.Item("maxSale")) Then
            lastBillID = myDR.Item("maxSale")
            lastBillID = Mid(lastBillID, 7)
            newBillID = Val(lastBillID) + 1
            Select Case newBillID.Length
                Case 1 : newBillID = "000000" & newBillID
                Case 2 : newBillID = "00000" & newBillID
                Case 3 : newBillID = "0000" & newBillID
                Case 4 : newBillID = "000" & newBillID
                Case 5 : newBillID = "00" & newBillID
                Case 6 : newBillID = "0" & newBillID
            End Select
            newBillID = "S" & curYear & "/" & newBillID
        Else
            newBillID = "S" & curYear & "/0000001"
        End If
        myDR.Close()
        myCon.Close()
        Return newBillID
    End Function

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        'Byyyy/xxxxxxx
        'B2562/0000001
        If btnSale.Text = "เปิดบิลขาย" Then
            lblSaleID.Text = getNewBill()
            lblSaleDate.Text = Format(Date.Now, "dd/MM/") & Val(Format(Date.Now, "yyyy")) + 543
            lblEmployee.Text = empName & "  " & empSurname
            btnSale.Text = "บันทึก"
            btnExit.Text = "ยกเลิก"
            gbDetail.Enabled = True
        Else

        End If
    End Sub

    Private Sub txtProID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtProID.Text = txtProID.Text.Trim
            If txtProID.Text.Length = 0 Then
                Exit Sub
            End If
            connectDB()
            strSQL = "Select proName, proPrice from Product where proID = @pid "
            myComm = New SqlCommand(strSQL, myCon)
            myComm.CommandTimeout = 15
            myComm.CommandType = CommandType.Text
            myComm.Parameters.AddWithValue("pid", txtProID.Text)
            myDR = myComm.ExecuteReader
            If myDR.HasRows Then
                myDR.Read()
                lblProName.Text = myDR.Item("proName")
                lblProPrice.Text = myDR.Item("proPrice")
                txtSaleAmount.Text = "1"
                txtSaleAmount.Focus()
            Else
                MessageBox.Show("ไม่พบสินค้าตามรหัสที่ท่านระบุ", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtProID.SelectAll()
                txtProID.Focus()
            End If

        End If
    End Sub

    Private Sub txtProID_TextChanged(sender As Object, e As EventArgs) Handles txtProID.TextChanged
        lblProName.Text = ""
        lblProPrice.Text = ""
        txtSaleAmount.Text = ""
        lblSaleTotal.Text = ""
    End Sub

    Private Sub txtSaleAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaleAmount.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub txtSaleAmount_TextChanged(sender As Object, e As EventArgs) Handles txtSaleAmount.TextChanged
        lblSaleTotal.Text = Val(lblProPrice.Text) * Val(txtSaleAmount.Text)
        If Val(lblSaleTotal.Text) = 0 Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim n As Integer
        dgvSale.Rows.Add()
        n = dgvSale.Rows.Count
        dgvSale.Item(0, n - 1).Value = txtProID.Text
        dgvSale.Item(1, n - 1).Value = lblProName.Text
        dgvSale.Item(2, n - 1).Value = lblProPrice.Text
        dgvSale.Item(3, n - 1).Value = txtSaleAmount.Text
        dgvSale.Item(4, n - 1).Value = lblSaleTotal.Text
        txtProID.Clear()
        lblProName.Text = ""
        lblProPrice.Text = ""
        txtSaleAmount.Text = ""
        lblSaleTotal.Text = ""
        txtProID.Focus()

    End Sub
End Class