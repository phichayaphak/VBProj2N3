<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDB_Mng
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtEmpSurname = New System.Windows.Forms.TextBox()
        Me.txtEmpSalary = New System.Windows.Forms.TextBox()
        Me.txtEmpAddress = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbShow = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        Me.gbShow.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.AllowUserToResizeColumns = False
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 48)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(728, 235)
        Me.dgvData.TabIndex = 0
        '
        'gbData
        '
        Me.gbData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbData.Controls.Add(Me.btnCancel)
        Me.gbData.Controls.Add(Me.btnSave)
        Me.gbData.Controls.Add(Me.radFemale)
        Me.gbData.Controls.Add(Me.radMale)
        Me.gbData.Controls.Add(Me.cmbStatus)
        Me.gbData.Controls.Add(Me.txtEmpSurname)
        Me.gbData.Controls.Add(Me.txtEmpSalary)
        Me.gbData.Controls.Add(Me.txtEmpAddress)
        Me.gbData.Controls.Add(Me.txtEmpName)
        Me.gbData.Controls.Add(Me.txtEmpId)
        Me.gbData.Controls.Add(Me.Label7)
        Me.gbData.Controls.Add(Me.Label6)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label8)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.Label2)
        Me.gbData.Enabled = False
        Me.gbData.Location = New System.Drawing.Point(81, 352)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(756, 161)
        Me.gbData.TabIndex = 1
        Me.gbData.TabStop = False
        Me.gbData.Text = " "
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Train61VB2N3.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(572, 90)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 52)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Train61VB2N3.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(486, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 52)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(118, 42)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(46, 17)
        Me.radFemale.TabIndex = 6
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "หญิง"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(54, 42)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(44, 17)
        Me.radMale.TabIndex = 6
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(60, 102)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(157, 21)
        Me.cmbStatus.TabIndex = 5
        '
        'txtEmpSurname
        '
        Me.txtEmpSurname.Location = New System.Drawing.Point(466, 13)
        Me.txtEmpSurname.Name = "txtEmpSurname"
        Me.txtEmpSurname.Size = New System.Drawing.Size(191, 20)
        Me.txtEmpSurname.TabIndex = 4
        '
        'txtEmpSalary
        '
        Me.txtEmpSalary.Location = New System.Drawing.Point(309, 102)
        Me.txtEmpSalary.Name = "txtEmpSalary"
        Me.txtEmpSalary.Size = New System.Drawing.Size(118, 20)
        Me.txtEmpSalary.TabIndex = 4
        '
        'txtEmpAddress
        '
        Me.txtEmpAddress.Location = New System.Drawing.Point(220, 42)
        Me.txtEmpAddress.Multiline = True
        Me.txtEmpAddress.Name = "txtEmpAddress"
        Me.txtEmpAddress.Size = New System.Drawing.Size(437, 43)
        Me.txtEmpAddress.TabIndex = 4
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(220, 16)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(191, 20)
        Me.txtEmpName.TabIndex = 4
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(38, 13)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(123, 20)
        Me.txtEmpId.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(233, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "เงินเดือน"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ตำแหน่ง"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "เพศ"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(418, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "สกุล"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(187, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ที่อยู่"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(187, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รหัส"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(100, 19)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(257, 21)
        Me.cmbDepartment.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "แผนก"
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.Train61VB2N3.My.Resources.Resources._new1
        Me.btnInsert.Location = New System.Drawing.Point(258, 519)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(98, 48)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.Train61VB2N3.My.Resources.Resources.edit
        Me.btnUpdate.Location = New System.Drawing.Point(359, 519)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 48)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "แก้ไข"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Train61VB2N3.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(463, 519)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 48)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = Global.Train61VB2N3.My.Resources.Resources._exit
        Me.btnExit.Location = New System.Drawing.Point(567, 519)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 48)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "ออก"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbShow
        '
        Me.gbShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbShow.Controls.Add(Me.dgvData)
        Me.gbShow.Controls.Add(Me.Label1)
        Me.gbShow.Controls.Add(Me.cmbDepartment)
        Me.gbShow.Location = New System.Drawing.Point(81, 47)
        Me.gbShow.Name = "gbShow"
        Me.gbShow.Size = New System.Drawing.Size(756, 299)
        Me.gbShow.TabIndex = 5
        Me.gbShow.TabStop = False
        Me.gbShow.Text = " "
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(756, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "โปรแกรมจัดการฐานข้อมูลบุคลากร"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDB_Mng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 600)
        Me.Controls.Add(Me.gbShow)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.gbData)
        Me.Name = "frmDB_Mng"
        Me.Text = "frmDB_Mng"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.gbShow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gbShow As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
