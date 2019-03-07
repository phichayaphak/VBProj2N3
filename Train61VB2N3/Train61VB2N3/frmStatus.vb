Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmStatus
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConCompany").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub loadData()
        connectDB()
        strSQL = "Select * from Status"
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "dtStatus")
        dgvData.DataSource = myDS.Tables("dtStatus")

        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 200

        dgvData.Columns(0).HeaderText = "รหัส"
        dgvData.Columns(1).HeaderText = "ตำแหน่ง"
        myCon.Close()
    End Sub

    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub dgvData_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellEnter
        If dgvData.RowCount = 0 Or dgvData.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim r As Integer = dgvData.CurrentCell.RowIndex
        Dim eid As String = dgvData.Item(0, r).Value
        lblStaID.Text = dgvData.Item(0, r).Value
        txtStaName.Text = dgvData.Item(1, r).Value

    End Sub

    Private Function getNewID() As String
        Dim newID As String
        Dim lastID As String
        'sxxxx
        connectDB()
        strSQL = "select max(staID) as maxID  from Status"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandType = CommandType.Text
        myComm.CommandTimeout = 15
        myDR = myComm.ExecuteReader
        myDR.Read()
        If IsDBNull(myDR.Item("maxID")) Then
            newID = "s0001"
            myDR.Close()
        Else
            lastID = myDR.Item("maxID")
            myDR.Close()

            lastID = Mid(lastID, 2)
            newID = Val(lastID) + 1
            Select Case newID.Length
                Case 1 : newID = "000" & newID
                Case 2 : newID = "00" & newID
                Case 3 : newID = "0" & newID
            End Select
            newID = "s" & newID
        End If

        myCon.Close()
        Return newID
    End Function

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If btnInsert.Text = "เพิ่ม" Then
            dgvData.Enabled = False
            btnInsert.Text = "บันทึก"
            btnExit.Text = "ยกเลิก"
            btnInsert.Image = My.Resources.save
            btnExit.Image = My.Resources.cancel

            lblStaID.Text = getNewID()
            txtStaName.Text = ""

            txtStaName.Enabled = True
            txtStaName.Focus()
        Else 'Click ขณะ บันทึก 
            'insert
            txtStaName.Text = txtStaName.Text.Trim
            If txtStaName.Text = "" Then
                MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtStaName.Focus()
                Exit Sub
            End If
            connectDB()
            strSQL = "Insert into Status(staID, staName) Values (@staID, @staName) "
            myComm = New SqlCommand(strSQL, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("staID", lblStaID.Text)
            myComm.Parameters.AddWithValue("staName", txtStaName.Text)
            myComm.ExecuteNonQuery()
            myCon.Close()

            Call loadData()
            Call btnExit_Click(sender, e)
            MessageBox.Show("เพิ่มตำแหน่งใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If btnExit.Text = "ออก" Then
            Me.Close()
        Else ' Click ขณะ ยกเลิก
            dgvData.Enabled = True
            txtStaName.Enabled = False
            btnInsert.Image = My.Resources._new1
            btnExit.Image = My.Resources._exit
            btnInsert.Text = "เพิ่ม"
            btnExit.Text = "ออก"
        End If
    End Sub
End Class