<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFive
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstDataSorted = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.chkManager = New System.Windows.Forms.CheckBox()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Items.AddRange(New Object() {"500", "230", "155", "620", "120", "45", "920"})
        Me.lstData.Location = New System.Drawing.Point(56, 59)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(116, 186)
        Me.lstData.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(249, 55)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 25)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(177, 58)
        Me.txtInput.MaxLength = 3
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(65, 20)
        Me.txtInput.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(247, 155)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 25)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(176, 158)
        Me.txtKey.MaxLength = 300
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(65, 20)
        Me.txtKey.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 412)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 25)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstDataSorted
        '
        Me.lstDataSorted.FormattingEnabled = True
        Me.lstDataSorted.Location = New System.Drawing.Point(56, 251)
        Me.lstDataSorted.Name = "lstDataSorted"
        Me.lstDataSorted.Size = New System.Drawing.Size(116, 186)
        Me.lstDataSorted.TabIndex = 0
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(176, 251)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(59, 25)
        Me.btnSort.TabIndex = 1
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(176, 108)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(131, 33)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total"
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(11, 21)
        Me.txtSale.MaxLength = 300
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(65, 20)
        Me.txtSale.TabIndex = 2
        '
        'chkManager
        '
        Me.chkManager.AutoSize = True
        Me.chkManager.Location = New System.Drawing.Point(11, 51)
        Me.chkManager.Name = "chkManager"
        Me.chkManager.Size = New System.Drawing.Size(68, 17)
        Me.chkManager.TabIndex = 5
        Me.chkManager.Text = "Manager"
        Me.chkManager.UseVisualStyleBackColor = True
        '
        'lblCommission
        '
        Me.lblCommission.BackColor = System.Drawing.Color.Yellow
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommission.Location = New System.Drawing.Point(6, 87)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(131, 33)
        Me.lblCommission.TabIndex = 3
        Me.lblCommission.Text = " "
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(77, 16)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(59, 25)
        Me.btnCal.TabIndex = 1
        Me.btnCal.Text = "Cal"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtSale)
        Me.GroupBox1.Controls.Add(Me.chkManager)
        Me.GroupBox1.Controls.Add(Me.lblSale)
        Me.GroupBox1.Controls.Add(Me.lblCommission)
        Me.GroupBox1.Controls.Add(Me.btnCal)
        Me.GroupBox1.Location = New System.Drawing.Point(178, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 175)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblSale
        '
        Me.lblSale.BackColor = System.Drawing.Color.Red
        Me.lblSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSale.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSale.Location = New System.Drawing.Point(6, 139)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(131, 33)
        Me.lblSale.TabIndex = 3
        Me.lblSale.Text = " "
        '
        'frmFive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstDataSorted)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmFive"
        Me.Text = "frmFive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstDataSorted As System.Windows.Forms.ListBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSale As System.Windows.Forms.TextBox
    Friend WithEvents chkManager As System.Windows.Forms.CheckBox
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSale As System.Windows.Forms.Label
End Class
