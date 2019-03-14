Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSale
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConCompany").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim myTran As SqlTransaction

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
        If btnExit.Text = "ออก" Then
            Me.Close()
        Else
            dgvSale.Rows.Clear()
            dgvSale.Enabled = False
            lblSaleID.Text = ""
            lblSaleDate.Text = ""
            lblEmployee.Text = ""
            lblTotal.Text = ""
            lblDiscount.Text = ""
            lblNet.Text = ""
            btnSale.Text = "เปิดบิลขาย"
            btnExit.Text = "ออก"
        End If

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
            'B2562/0000109
            lastBillID = myDR.Item("maxSale")
            'lastBillID = Mid(lastBillID, 7)
            lastBillID = lastBillID.Substring(6)

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
        'Syyyy/xxxxxxx
        'S2562/0000001
        If btnSale.Text = "เปิดบิลขาย" Then
            lblSaleID.Text = getNewBill()
            lblSaleDate.Text = Format(Date.Now, "dd/MM/") & Val(Format(Date.Now, "yyyy")) + 543
            lblEmployee.Text = empName & "  " & empSurname
            btnSale.Text = "บันทึก"
            btnExit.Text = "ยกเลิก"
            gbDetail.Enabled = True
        Else 'บันทึก
            If dgvSale.RowCount = 0 Then
                MessageBox.Show("ท่านไม่ได้ระบุรายการขายสินค้าใดๆ ไม่สามารถบันทึกได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            connectDB()
            'บันทึกหัวใบเสร็จ
            myTran = myCon.BeginTransaction

            strSQL = "Insert into Sale(saleID,  saleDate, saleDiscount, empID) " & _
                " Values(@sid, @sdate, @sdiscount, @eid)"
            myComm = New SqlCommand(strSQL, myCon)
            myComm.Transaction = myTran
            myComm.CommandTimeout = 15
            myComm.CommandType = CommandType.Text
            Try
                myComm.Parameters.AddWithValue("sid", lblSaleID.Text)
                myComm.Parameters.Add("sdate", SqlDbType.Date).Value = lblSaleDate.Text
                myComm.Parameters.AddWithValue("sdiscount", lblDiscount.Text)
                myComm.Parameters.AddWithValue("eid", empID)
                myComm.ExecuteNonQuery()

                For i = 0 To dgvSale.RowCount - 1
                    'บันทึกรายการขาย
                    strSQL = "Insert into SaleDetail(saleID,  proID, amount, proPrice) " & _
                   " Values(@sid, @pid, @samount, @pprice)"
                    myComm.CommandText = strSQL
                    myComm.Parameters.Clear()
                    myComm.Parameters.AddWithValue("sid", lblSaleID.Text)
                    myComm.Parameters.AddWithValue("pid", dgvSale.Item(0, i).Value)
                    myComm.Parameters.AddWithValue("samount", dgvSale.Item(3, i).Value)
                    myComm.Parameters.AddWithValue("pprice", dgvSale.Item(2, i).Value)
                    myComm.ExecuteNonQuery()

                    'ตัดสต๊อก
                    strSQL = "update Product set proNet = proNet - @samount " & _
                        " Where proID = @pid "
                    myComm.CommandText = strSQL
                    myComm.ExecuteNonQuery()
                Next
                myCon.Close()
                MessageBox.Show("บันทึกการขายสินค้าเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call btnExit_Click(sender, e)
                myTran.Commit()
            Catch ex As Exception
                myTran.Rollback()
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ในขณะนี้ กรุณาดำเนินใหม่ในภายหลัง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub findProduct()
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
    End Sub

    Private Sub txtProID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtProID.Text = txtProID.Text.Trim
            If txtProID.Text.Length = 0 Then
                Exit Sub
            End If
            Call findProduct()
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
            If Asc(e.KeyChar) = 13 Then
                Call btnAdd_Click(sender, e)
            ElseIf Asc(e.KeyChar) <> 8 Then
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

    Private Sub calTotal()
        Dim total, discount, net As Double
        For i = 0 To dgvSale.RowCount - 1
            total = total + Val(dgvSale.Item(4, i).Value)
        Next

        If total < 1000 Then
            discount = 0
        ElseIf total < 50000 Then
            discount = total * 0.05
        Else
            discount = total * 0.1
        End If
        net = total - discount
        lblTotal.Text = FormatNumber(total, 2)
        lblDiscount.Text = FormatNumber(discount, 2)
        lblNet.Text = FormatNumber(net, 2)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Val(txtSaleAmount.Text) = 0 Then
            btnAdd.Enabled = False
            Exit Sub
        End If

        Dim found As Boolean = False
        Dim total As Double
        Dim sumAmount As Integer = Val(txtSaleAmount.Text)
        Dim proNet As Integer

        For i = 0 To dgvSale.RowCount - 1
            If txtProID.Text = dgvSale.Item(0, i).Value Then
                sumAmount = Val(dgvSale.Item(3, i).Value) + sumAmount
                Exit For
            End If
        Next
        connectDB()
        strSQL = "select proNet from Product where proID = @pid"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("pid", txtProID.Text)
        myDR = myComm.ExecuteReader
        myDR.Read()
        proNet = Val(myDR.Item("proNet"))
        myDR.Close()
        If sumAmount > proNet Then
            MessageBox.Show("สินค้าคงเหลือไม่เพียงพอต่อจำนวนขายที่ระบุ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSaleAmount.Focus()
            Exit Sub
        End If

        For i = 0 To dgvSale.RowCount - 1
            If txtProID.Text = dgvSale.Item(0, i).Value Then
                dgvSale.Item(3, i).Value = Val(dgvSale.Item(3, i).Value) + Val(txtSaleAmount.Text)
                total = Val(dgvSale.Item(2, i).Value) * Val(dgvSale.Item(3, i).Value)
                dgvSale.Item(4, i).Value = total
                found = True
                Exit For
            End If
        Next

        If found = False Then
            Dim n As Integer
            dgvSale.Rows.Add()
            n = dgvSale.Rows.Count - 1
            dgvSale.Item(0, n).Value = txtProID.Text
            dgvSale.Item(1, n).Value = lblProName.Text
            dgvSale.Item(2, n).Value = lblProPrice.Text
            dgvSale.Item(3, n).Value = txtSaleAmount.Text
            dgvSale.Item(4, n).Value = lblSaleTotal.Text
        End If

        Call calTotal()
        txtProID.Clear()
        lblProName.Text = ""
        lblProPrice.Text = ""
        txtSaleAmount.Text = ""
        lblSaleTotal.Text = ""
        txtProID.Focus()

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        proIDFind = ""
        Dim frmFindPro As New frmProductList
        frmFindPro.ShowDialog()

        If proIDFind <> "" Then
            txtProID.Text = proIDFind
            Call findProduct()
        Else
            txtProID.Focus()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvSale.RowCount = 0 Or dgvSale.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim r As Integer = dgvSale.CurrentCell.RowIndex
        If MessageBox.Show("ท่านต้องการยกเลิกรายการขายในแถวเลือกใช่หรือไม่?", "ยกเลิก...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dgvSale.Rows.RemoveAt(r)
            Call calTotal()
        End If
    End Sub
End Class