<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatus
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtStaName = New System.Windows.Forms.TextBox()
        Me.lblStaID = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvData.Location = New System.Drawing.Point(39, 43)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(301, 235)
        Me.dgvData.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Image = Global.Train61VB2N3.My.Resources.Resources._exit
        Me.btnExit.Location = New System.Drawing.Point(187, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 48)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "ออก"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.Train61VB2N3.My.Resources.Resources._new1
        Me.btnInsert.Location = New System.Drawing.Point(67, 343)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(98, 48)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtStaName
        '
        Me.txtStaName.Enabled = False
        Me.txtStaName.Location = New System.Drawing.Point(142, 297)
        Me.txtStaName.Name = "txtStaName"
        Me.txtStaName.Size = New System.Drawing.Size(198, 20)
        Me.txtStaName.TabIndex = 7
        '
        'lblStaID
        '
        Me.lblStaID.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblStaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaID.Location = New System.Drawing.Point(36, 297)
        Me.lblStaID.Name = "lblStaID"
        Me.lblStaID.Size = New System.Drawing.Size(100, 23)
        Me.lblStaID.TabIndex = 8
        Me.lblStaID.Text = " "
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 403)
        Me.Controls.Add(Me.lblStaID)
        Me.Controls.Add(Me.txtStaName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "frmStatus"
        Me.Text = "frmStatus"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtStaName As System.Windows.Forms.TextBox
    Friend WithEvents lblStaID As System.Windows.Forms.Label
End Class
