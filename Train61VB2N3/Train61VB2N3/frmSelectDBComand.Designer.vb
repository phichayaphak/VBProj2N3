<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDBComand
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.lblReorderlevel = New System.Windows.Forms.Label()
        Me.lblUnitsInStock = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radNoSale = New System.Windows.Forms.RadioButton()
        Me.radSale = New System.Windows.Forms.RadioButton()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(106, 22)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(345, 26)
        Me.cmbCategory.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ประเภทสินค้า"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeColumns = False
        Me.dgvData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(38, 54)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(645, 241)
        Me.dgvData.TabIndex = 2
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.radSale)
        Me.gb1.Controls.Add(Me.radNoSale)
        Me.gb1.Controls.Add(Me.lblReorderlevel)
        Me.gb1.Controls.Add(Me.lblUnitsInStock)
        Me.gb1.Controls.Add(Me.lblPrice)
        Me.gb1.Controls.Add(Me.Label12)
        Me.gb1.Controls.Add(Me.lblQuantity)
        Me.gb1.Controls.Add(Me.Label10)
        Me.gb1.Controls.Add(Me.lblName)
        Me.gb1.Controls.Add(Me.Label8)
        Me.gb1.Controls.Add(Me.lblID)
        Me.gb1.Controls.Add(Me.Label6)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(38, 339)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(645, 144)
        Me.gb1.TabIndex = 3
        Me.gb1.TabStop = False
        Me.gb1.Text = " "
        '
        'lblReorderlevel
        '
        Me.lblReorderlevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblReorderlevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReorderlevel.ForeColor = System.Drawing.Color.Red
        Me.lblReorderlevel.Location = New System.Drawing.Point(359, 107)
        Me.lblReorderlevel.Name = "lblReorderlevel"
        Me.lblReorderlevel.Size = New System.Drawing.Size(125, 23)
        Me.lblReorderlevel.TabIndex = 0
        Me.lblReorderlevel.Text = " "
        '
        'lblUnitsInStock
        '
        Me.lblUnitsInStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblUnitsInStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnitsInStock.ForeColor = System.Drawing.Color.Red
        Me.lblUnitsInStock.Location = New System.Drawing.Point(122, 108)
        Me.lblUnitsInStock.Name = "lblUnitsInStock"
        Me.lblUnitsInStock.Size = New System.Drawing.Size(125, 23)
        Me.lblUnitsInStock.TabIndex = 0
        Me.lblUnitsInStock.Text = " "
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.ForeColor = System.Drawing.Color.Red
        Me.lblPrice.Location = New System.Drawing.Point(359, 69)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(125, 23)
        Me.lblPrice.TabIndex = 0
        Me.lblPrice.Text = " "
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(253, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "จุดสั่งซื้อ"
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.ForeColor = System.Drawing.Color.Red
        Me.lblQuantity.Location = New System.Drawing.Point(122, 69)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(125, 23)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = " "
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(16, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "คงเหลือ"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(324, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(291, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = " "
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(253, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ราคาต่อหน่วย"
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.ForeColor = System.Drawing.Color.Red
        Me.lblID.Location = New System.Drawing.Point(122, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(90, 23)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = " "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(16, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "จำนวนต่อหน่วยบรรจุ"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(218, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รหัสสินค้า"
        '
        'radNoSale
        '
        Me.radNoSale.AutoSize = True
        Me.radNoSale.Location = New System.Drawing.Point(499, 109)
        Me.radNoSale.Name = "radNoSale"
        Me.radNoSale.Size = New System.Drawing.Size(67, 22)
        Me.radNoSale.TabIndex = 1
        Me.radNoSale.TabStop = True
        Me.radNoSale.Text = "เลิกขาย"
        Me.radNoSale.UseVisualStyleBackColor = True
        '
        'radSale
        '
        Me.radSale.AutoSize = True
        Me.radSale.Location = New System.Drawing.Point(499, 70)
        Me.radSale.Name = "radSale"
        Me.radSale.Size = New System.Drawing.Size(89, 22)
        Me.radSale.TabIndex = 1
        Me.radSale.TabStop = True
        Me.radSale.Text = "ขายอยู่ไหน"
        Me.radSale.UseVisualStyleBackColor = True
        '
        'frmSelectDBComand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 495)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Name = "frmSelectDBComand"
        Me.Text = "frmSelectDBComand"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblReorderlevel As System.Windows.Forms.Label
    Friend WithEvents lblUnitsInStock As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radSale As System.Windows.Forms.RadioButton
    Friend WithEvents radNoSale As System.Windows.Forms.RadioButton
End Class
