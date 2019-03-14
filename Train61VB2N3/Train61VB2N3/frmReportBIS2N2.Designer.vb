<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportBIS2N2
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
        Me.btnReport = New System.Windows.Forms.Button()
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
        Me.crvProduct.ShowGroupTreeButton = False
        Me.crvProduct.ShowLogo = False
        Me.crvProduct.Size = New System.Drawing.Size(944, 730)
        Me.crvProduct.TabIndex = 0
        Me.crvProduct.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(440, 12)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(311, 21)
        Me.cmbCategory.TabIndex = 1
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(757, 11)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(65, 24)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "รายงาน"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'frmReportBIS2N2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 730)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.crvProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportBIS2N2"
        Me.Text = "frmReportBIS2N2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvProduct As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class
