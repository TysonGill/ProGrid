<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilter
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
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.optAlt1 = New System.Windows.Forms.RadioButton()
        Me.optAlt2 = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.optEquals = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLogic = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblColumnName
        '
        Me.lblColumnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColumnName.Location = New System.Drawing.Point(91, 10)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(201, 19)
        Me.lblColumnName.TabIndex = 0
        Me.lblColumnName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optAlt1
        '
        Me.optAlt1.AutoSize = True
        Me.optAlt1.Location = New System.Drawing.Point(91, 92)
        Me.optAlt1.Name = "optAlt1"
        Me.optAlt1.Size = New System.Drawing.Size(75, 17)
        Me.optAlt1.TabIndex = 3
        Me.optAlt1.Text = "Less Than"
        Me.optAlt1.UseVisualStyleBackColor = True
        '
        'optAlt2
        '
        Me.optAlt2.AutoSize = True
        Me.optAlt2.Location = New System.Drawing.Point(172, 92)
        Me.optAlt2.Name = "optAlt2"
        Me.optAlt2.Size = New System.Drawing.Size(88, 17)
        Me.optAlt2.TabIndex = 4
        Me.optAlt2.Text = "Greater Than"
        Me.optAlt2.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(126, 156)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "&Apply"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(217, 156)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(25, 115)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(267, 20)
        Me.txtValue.TabIndex = 5
        '
        'optEquals
        '
        Me.optEquals.AutoSize = True
        Me.optEquals.Checked = True
        Me.optEquals.Location = New System.Drawing.Point(25, 92)
        Me.optEquals.Name = "optEquals"
        Me.optEquals.Size = New System.Drawing.Size(57, 17)
        Me.optEquals.TabIndex = 2
        Me.optEquals.TabStop = True
        Me.optEquals.Text = "Equals"
        Me.optEquals.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Logic"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Column"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboLogic
        '
        Me.cboLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogic.FormattingEnabled = True
        Me.cboLogic.Items.AddRange(New Object() {"Include Records", "Exclude Records"})
        Me.cboLogic.Location = New System.Drawing.Point(91, 44)
        Me.cboLogic.Name = "cboLogic"
        Me.cboLogic.Size = New System.Drawing.Size(201, 21)
        Me.cboLogic.TabIndex = 1
        '
        'frmFilter
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(316, 199)
        Me.Controls.Add(Me.cboLogic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.optAlt1)
        Me.Controls.Add(Me.optAlt2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.optEquals)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFilter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProGrid Numeric Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumnName As System.Windows.Forms.Label
    Friend WithEvents optAlt1 As System.Windows.Forms.RadioButton
    Friend WithEvents optAlt2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents optEquals As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboLogic As System.Windows.Forms.ComboBox
End Class
