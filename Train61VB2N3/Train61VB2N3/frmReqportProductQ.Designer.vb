<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReqportProductQ
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
        Me.crvProductQ = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crvProductQ
        '
        Me.crvProductQ.ActiveViewIndex = -1
        Me.crvProductQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvProductQ.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvProductQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvProductQ.Location = New System.Drawing.Point(0, 0)
        Me.crvProductQ.Name = "crvProductQ"
        Me.crvProductQ.ShowGroupTreeButton = False
        Me.crvProductQ.ShowLogo = False
        Me.crvProductQ.Size = New System.Drawing.Size(1008, 730)
        Me.crvProductQ.TabIndex = 0
        Me.crvProductQ.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(446, 12)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(318, 21)
        Me.cmbCategory.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(770, 3)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(71, 36)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmReqportProductQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.crvProductQ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReqportProductQ"
        Me.Text = "frmReqportProductQ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvProductQ As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
