<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportStock
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
        Me.crvStock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvStock
        '
        Me.crvStock.ActiveViewIndex = -1
        Me.crvStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvStock.Location = New System.Drawing.Point(0, 0)
        Me.crvStock.Name = "crvStock"
        Me.crvStock.ShowGroupTreeButton = False
        Me.crvStock.ShowLogo = False
        Me.crvStock.Size = New System.Drawing.Size(1008, 730)
        Me.crvStock.TabIndex = 0
        Me.crvStock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(449, 12)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(305, 21)
        Me.cmbCategory.TabIndex = 1
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(760, 12)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "รายงาน"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'frmReportStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.crvStock)
        Me.Name = "frmReportStock"
        Me.Text = "frmReportStock"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvStock As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class
