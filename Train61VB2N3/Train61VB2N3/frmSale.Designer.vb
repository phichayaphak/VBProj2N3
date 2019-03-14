<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale
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
        Me.gbHead = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSaleDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaleID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbHead.SuspendLayout()
        Me.gbDetail.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbHead
        '
        Me.gbHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbHead.Controls.Add(Me.btnPrint)
        Me.gbHead.Controls.Add(Me.btnExit)
        Me.gbHead.Controls.Add(Me.btnSale)
        Me.gbHead.Controls.Add(Me.lblEmployee)
        Me.gbHead.Controls.Add(Me.Label7)
        Me.gbHead.Controls.Add(Me.lblSaleDate)
        Me.gbHead.Controls.Add(Me.Label3)
        Me.gbHead.Controls.Add(Me.lblSaleID)
        Me.gbHead.Controls.Add(Me.Label1)
        Me.gbHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHead.Location = New System.Drawing.Point(29, 46)
        Me.gbHead.Name = "gbHead"
        Me.gbHead.Size = New System.Drawing.Size(846, 127)
        Me.gbHead.TabIndex = 0
        Me.gbHead.TabStop = False
        Me.gbHead.Text = "GroupBox1"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(565, 72)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 37)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "พิมพ์ใบเสร็จรับเงิน"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(692, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 37)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSale
        '
        Me.btnSale.Location = New System.Drawing.Point(565, 18)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(112, 37)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "เปิดบิลขาย"
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'lblEmployee
        '
        Me.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployee.Location = New System.Drawing.Point(171, 70)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(388, 39)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = " "
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(36, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "พนักงานขาย"
        '
        'lblSaleDate
        '
        Me.lblSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaleDate.Location = New System.Drawing.Point(408, 16)
        Me.lblSaleDate.Name = "lblSaleDate"
        Me.lblSaleDate.Size = New System.Drawing.Size(151, 39)
        Me.lblSaleDate.TabIndex = 0
        Me.lblSaleDate.Text = " "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(343, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "วันที่ขาย"
        '
        'lblSaleID
        '
        Me.lblSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaleID.Location = New System.Drawing.Point(171, 16)
        Me.lblSaleID.Name = "lblSaleID"
        Me.lblSaleID.Size = New System.Drawing.Size(151, 39)
        Me.lblSaleID.TabIndex = 0
        Me.lblSaleID.Text = " "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "หมายเลขใบเสร็จรับเงิน"
        '
        'gbDetail
        '
        Me.gbDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbDetail.Controls.Add(Me.btnDelete)
        Me.gbDetail.Controls.Add(Me.dgvSale)
        Me.gbDetail.Controls.Add(Me.lblNet)
        Me.gbDetail.Controls.Add(Me.lblDiscount)
        Me.gbDetail.Controls.Add(Me.lblTotal)
        Me.gbDetail.Controls.Add(Me.lblSaleTotal)
        Me.gbDetail.Controls.Add(Me.btnFind)
        Me.gbDetail.Controls.Add(Me.btnAdd)
        Me.gbDetail.Controls.Add(Me.txtSaleAmount)
        Me.gbDetail.Controls.Add(Me.txtProID)
        Me.gbDetail.Controls.Add(Me.Label10)
        Me.gbDetail.Controls.Add(Me.Label5)
        Me.gbDetail.Controls.Add(Me.Label4)
        Me.gbDetail.Controls.Add(Me.Label2)
        Me.gbDetail.Controls.Add(Me.Label13)
        Me.gbDetail.Controls.Add(Me.Label12)
        Me.gbDetail.Controls.Add(Me.Label11)
        Me.gbDetail.Controls.Add(Me.Label9)
        Me.gbDetail.Controls.Add(Me.lblProPrice)
        Me.gbDetail.Controls.Add(Me.lblProName)
        Me.gbDetail.Enabled = False
        Me.gbDetail.Location = New System.Drawing.Point(29, 179)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Size = New System.Drawing.Size(846, 430)
        Me.gbDetail.TabIndex = 1
        Me.gbDetail.TabStop = False
        Me.gbDetail.Text = "GroupBox2"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(582, 285)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(24, 26)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "X"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.AllowUserToDeleteRows = False
        Me.dgvSale.AllowUserToResizeColumns = False
        Me.dgvSale.AllowUserToResizeRows = False
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSale.Location = New System.Drawing.Point(12, 92)
        Me.dgvSale.MultiSelect = False
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.ReadOnly = True
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(819, 187)
        Me.dgvSale.TabIndex = 2
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Red
        Me.lblNet.Location = New System.Drawing.Point(616, 366)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(215, 42)
        Me.lblNet.TabIndex = 0
        Me.lblNet.Text = " "
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Red
        Me.lblDiscount.Location = New System.Drawing.Point(616, 324)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(215, 42)
        Me.lblDiscount.TabIndex = 0
        Me.lblDiscount.Text = " "
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(616, 282)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(215, 42)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaleTotal.Location = New System.Drawing.Point(661, 46)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(113, 23)
        Me.lblSaleTotal.TabIndex = 0
        Me.lblSaleTotal.Text = " "
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(118, 52)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(28, 26)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "..."
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(780, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(51, 26)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Location = New System.Drawing.Point(552, 49)
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(69, 20)
        Me.txtSaleAmount.TabIndex = 1
        '
        'txtProID
        '
        Me.txtProID.Location = New System.Drawing.Point(12, 54)
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(100, 20)
        Me.txtProID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(149, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ชื่อสินค้า"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(379, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "จำนวนเงินที่ต้องชำระ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ส่วนลด"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รวมเป็นเงิน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(658, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "เป็นเงิน"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(560, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "จำนวน"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(405, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ราคาต่อหน่วย"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(22, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "รหัสสินค้า"
        '
        'lblProPrice
        '
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProPrice.Location = New System.Drawing.Point(384, 51)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(113, 23)
        Me.lblProPrice.TabIndex = 0
        Me.lblProPrice.Text = " "
        '
        'lblProName
        '
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProName.Location = New System.Drawing.Point(152, 51)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(226, 23)
        Me.lblProName.TabIndex = 0
        Me.lblProName.Text = " "
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัส"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "ราคา"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวน"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "เป็นเงิน"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 621)
        Me.Controls.Add(Me.gbDetail)
        Me.Controls.Add(Me.gbHead)
        Me.Name = "frmSale"
        Me.Text = "ระบบขายสินค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbHead.ResumeLayout(False)
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbHead As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSale As System.Windows.Forms.Button
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSaleDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSaleID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbDetail As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSaleTotal As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSaleAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtProID As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblProPrice As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
