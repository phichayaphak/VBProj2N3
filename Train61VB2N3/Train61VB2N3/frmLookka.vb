Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLookka
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConCompany").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Dim userAct As String
    Dim oldEmpID As String

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub frmDB_Mng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        strSQL = "select depName from Department"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myDR = myComm.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cmbDepartment.Items.Add(myDR.Item("depName"))
            End While
            cmbDepartment.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ยังไม่มีข้อมูลแผนกงานในระบบ ไม่สามารถจัดการข้อมูลพนักงานได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการแผนกก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If

        strSQL = "select * from Status"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myDR = myComm.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cmbStatus.Items.Add(myDR.Item("staName"))
            End While
            cmbStatus.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ยังไม่มีข้อมูลตำแหน่งในระบบ ไม่สามารถจัดการข้อมูลพนักงานได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการตำแหน่งก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If

        myCon.Close()
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        connectDB()
        strSQL = "Select empID, empName,empSurname, empAddress, IIF(empGender=1, 'ชาย', 'หญิง') As Gender, empSalary, staName from Employee, Department, Status Where Employee.depID = Department.depID and Employee.staID = Status.staID and depName =  '" & cmbDepartment.SelectedItem & "'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "dtEmployee")
        dgvData.DataSource = myDS.Tables("dtEmployee")

        dgvData.Columns(0).Width = 80
        dgvData.Columns(1).Width = 120
        dgvData.Columns(2).Width = 120
        dgvData.Columns(3).Width = 180
        dgvData.Columns(4).Width = 50
        dgvData.Columns(5).Width = 75
        dgvData.Columns(6).Width = 100

        dgvData.Columns(0).HeaderText = "รหัส"
        dgvData.Columns(1).HeaderText = "ชื่อ"
        dgvData.Columns(2).HeaderText = "สกุล"
        dgvData.Columns(3).HeaderText = "ที่อยู่"
        dgvData.Columns(4).HeaderText = "เพศ"
        dgvData.Columns(5).HeaderText = "เงินเดือน"
        dgvData.Columns(6).HeaderText = "ตำแหน่ง"

        dgvData.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvData.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If dgvData.RowCount = 0 Then
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        gbShow.Enabled = False
        gbData.Enabled = True
        txtEmpId.Clear()
        txtEmpName.Clear()
        txtEmpSurname.Clear()
        txtEmpAddress.Clear()
        txtEmpSalary.Clear()
        txtEmpPassword.Clear()
        radMale.Checked = True
        cmbStatus.SelectedIndex = 0
        txtEmpId.Focus()

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnExit.Enabled = False
        userAct = "insert"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtEmpId.Text = txtEmpId.Text.Trim()
        txtEmpName.Text = txtEmpName.Text.Trim()
        txtEmpSurname.Text = txtEmpSurname.Text.Trim()
        txtEmpAddress.Text = txtEmpAddress.Text.Trim()
        If txtEmpId.Text = "" Or txtEmpName.Text = "" Or txtEmpSurname.Text = "" Or txtEmpAddress.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmpId.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtEmpSalary.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลเงินเดือนไม่ถูกต้อง" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmpSalary.Focus()
            Exit Sub
        Else
            'บันทึก 
            Dim gender As Boolean
            Dim depID As String
            Dim staID As String

            If radMale.Checked Then
                gender = True
            Else
                gender = False
            End If

            connectDB()
            strSQL = "select depID from Department where depName = @cname "
            myComm = New SqlCommand(strSQL, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("cname", cmbDepartment.SelectedItem)
            myDR = myComm.ExecuteReader
            myDR.Read()
            depID = myDR.Item("depID")
            myDR.Close()

            strSQL = "select staID from Status where staName = @sname "
            myComm = New SqlCommand(strSQL, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("sname", cmbStatus.SelectedItem)
            myDR = myComm.ExecuteReader
            myDR.Read()
            staID = myDR.Item("staID")
            myDR.Close()


            If userAct = "insert" Then 'เพิ่ม
                'เช็ค PK
                strSQL = "select empID from Employee where empID = @eid "
                myComm = New SqlCommand(strSQL, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myDR = myComm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสพนักงานที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSQL = "Insert into Employee(empID, empName, empSurname, empAddress, empGender, empSalary, empPassword, depID, staID) " & _
                    " Values(@eid, @ename, @esurname, @eadd, @egen, @esalary, @ePassword, @depid, @staid)  "
                myComm = New SqlCommand(strSQL, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                myComm.Parameters.AddWithValue("esurname", txtEmpSurname.Text)
                myComm.Parameters.AddWithValue("eadd", txtEmpAddress.Text)
                myComm.Parameters.AddWithValue("egen", gender)
                myComm.Parameters.AddWithValue("esalary", txtEmpSalary.Text)
                myComm.Parameters.AddWithValue("epassword", txtEmpPassword.Text)
                myComm.Parameters.AddWithValue("depid", depID)
                myComm.Parameters.AddWithValue("staid", staID)
                myComm.ExecuteNonQuery()
                Call cmbDepartment_SelectedIndexChanged(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If oldEmpID <> txtEmpId.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSQL = "select empID from Employee where empID = @eid "
                    myComm = New SqlCommand(strSQL, myCon)
                    myComm.CommandType = CommandType.Text
                    myComm.CommandTimeout = 15
                    myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                    myDR = myComm.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("รหัสพนักงานที่ท่านเปลี่ยนแปลง เป็นรหัสของพนักงานคนอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                strSQL = "Update Employee Set empID = @eid, empName=@ename, empSurname=@esurname, empAddress=@eadd, empGender=@egen,empSalary=@esalary, empPassword=@epassword, depID=@depid, staID=@staid " & _
                    " where empID = @eoid"
                myComm = New SqlCommand(strSQL, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                myComm.Parameters.AddWithValue("esurname", txtEmpSurname.Text)
                myComm.Parameters.AddWithValue("eadd", txtEmpAddress.Text)
                myComm.Parameters.AddWithValue("egen", gender)
                myComm.Parameters.AddWithValue("esalary", txtEmpSalary.Text)
                myComm.Parameters.AddWithValue("epassword", txtEmpPassword.Text)
                myComm.Parameters.AddWithValue("depid", depID)
                myComm.Parameters.AddWithValue("staid", staID)
                myComm.Parameters.AddWithValue("eoid", oldEmpID)
                myComm.ExecuteNonQuery()
                Call cmbDepartment_SelectedIndexChanged(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("แก้ไขข้อมูลพนักงานเรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        gbShow.Enabled = False
        gbData.Enabled = True
        txtEmpId.Focus()

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnExit.Enabled = False
        userAct = "update"
        oldEmpID = txtEmpId.Text

    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub dgvData_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellEnter
        If dgvData.RowCount = 0 Or dgvData.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim r As Integer = dgvData.CurrentCell.RowIndex
        Dim eid As String = dgvData.Item(0, r).Value

        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        connectDB()
        strSQL = "select Employee.*, Status.staName  from Employee, Status where Employee.staID = Status.staID and empID = @eid "
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandType = CommandType.Text
        myComm.CommandTimeout = 15
        myComm.Parameters.AddWithValue("@eid", eid)
        myDR = myComm.ExecuteReader

        myDR.Read()
        txtEmpId.Text = myDR.Item("empID")
        txtEmpName.Text = myDR.Item("empName")
        txtEmpSurname.Text = myDR.Item("empSurname")
        txtEmpAddress.Text = myDR.Item("empAddress")
        txtEmpSalary.Text = myDR.Item("empSalary")
        txtEmpPassword.Text = myDR.Item("empPassword")
        If myDR.Item("empGender") = True Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If

        cmbStatus.SelectedItem = myDR.Item("staName")

        'For i = 0 To cmbStatus.Items.Count - 1
        'If cmbStatus.Items(i) = myDR.Item("staName") Then
        'cmbStatus.SelectedIndex = i
        'Exit For
        'End If
        'Next
        myDR.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        gbShow.Enabled = True
        gbData.Enabled = False

        btnInsert.Enabled = True
        If txtEmpId.Text = "" Then
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        Else
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        End If
        btnExit.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลพนักงาน รหัส: " & txtEmpId.Text & " ชื่อ: " & txtEmpName.Text & "  " & txtEmpSurname.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            connectDB()
            strSQL = "Delete From Employee where empID = @eid "
            myComm = New SqlCommand(strSQL, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
            myComm.ExecuteNonQuery()
            Call cmbDepartment_SelectedIndexChanged(sender, e)
            MessageBox.Show("ลบข้อมูลพนักงานที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class