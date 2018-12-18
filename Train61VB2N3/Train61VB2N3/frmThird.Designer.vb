<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThird
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
        Me.txtMyNumber = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.lblBgRed = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.lblFgRed = New System.Windows.Forms.Label()
        Me.lblBgYellow = New System.Windows.Forms.Label()
        Me.lblFgYellow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMyNumber
        '
        Me.txtMyNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMyNumber.Location = New System.Drawing.Point(149, 71)
        Me.txtMyNumber.Name = "txtMyNumber"
        Me.txtMyNumber.Size = New System.Drawing.Size(180, 40)
        Me.txtMyNumber.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(335, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"10", "14", "18", "22", "26", "30", "34", "50", "60"})
        Me.cboSelect.Location = New System.Drawing.Point(261, 127)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(66, 21)
        Me.cboSelect.TabIndex = 2
        '
        'lblBgRed
        '
        Me.lblBgRed.BackColor = System.Drawing.Color.Red
        Me.lblBgRed.Location = New System.Drawing.Point(145, 157)
        Me.lblBgRed.Name = "lblBgRed"
        Me.lblBgRed.Size = New System.Drawing.Size(28, 33)
        Me.lblBgRed.TabIndex = 3
        Me.lblBgRed.Text = " "
        '
        'lblToday
        '
        Me.lblToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToday.Location = New System.Drawing.Point(149, 31)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(180, 30)
        Me.lblToday.TabIndex = 5
        Me.lblToday.Text = " "
        '
        'lblFgRed
        '
        Me.lblFgRed.BackColor = System.Drawing.Color.Red
        Me.lblFgRed.Location = New System.Drawing.Point(52, 157)
        Me.lblFgRed.Name = "lblFgRed"
        Me.lblFgRed.Size = New System.Drawing.Size(28, 33)
        Me.lblFgRed.TabIndex = 3
        Me.lblFgRed.Text = " "
        '
        'lblBgYellow
        '
        Me.lblBgYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBgYellow.Location = New System.Drawing.Point(179, 157)
        Me.lblBgYellow.Name = "lblBgYellow"
        Me.lblBgYellow.Size = New System.Drawing.Size(28, 33)
        Me.lblBgYellow.TabIndex = 3
        Me.lblBgYellow.Text = " "
        '
        'lblFgYellow
        '
        Me.lblFgYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFgYellow.Location = New System.Drawing.Point(86, 157)
        Me.lblFgYellow.Name = "lblFgYellow"
        Me.lblFgYellow.Size = New System.Drawing.Size(28, 33)
        Me.lblFgYellow.TabIndex = 3
        Me.lblFgYellow.Text = " "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "วันที่"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ตัวเลข"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ขนาด"
        '
        'frmThird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 280)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.lblFgYellow)
        Me.Controls.Add(Me.lblFgRed)
        Me.Controls.Add(Me.lblBgYellow)
        Me.Controls.Add(Me.lblBgRed)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMyNumber)
        Me.Name = "frmThird"
        Me.Text = "frmThird"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMyNumber As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblBgRed As System.Windows.Forms.Label
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents lblFgRed As System.Windows.Forms.Label
    Friend WithEvents lblBgYellow As System.Windows.Forms.Label
    Friend WithEvents lblFgYellow As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
