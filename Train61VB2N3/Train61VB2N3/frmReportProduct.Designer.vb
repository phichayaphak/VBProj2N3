<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportProduct
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
        Me.crvProduct = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvProduct
        '
        Me.crvProduct.ActiveViewIndex = -1
        Me.crvProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvProduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvProduct.Location = New System.Drawing.Point(0, 0)
        Me.crvProduct.Name = "crvProduct"
        Me.crvProduct.Size = New System.Drawing.Size(1008, 750)
        Me.crvProduct.TabIndex = 0
        Me.crvProduct.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(476, 0)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(239, 26)
        Me.cmbCategory.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(721, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 26)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "แสดง"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmReportProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 750)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.crvProduct)
        Me.Name = "frmReportProduct"
        Me.Text = "frmReportProduct"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvProduct As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
