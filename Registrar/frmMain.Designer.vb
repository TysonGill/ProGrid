<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.AppName = New System.Windows.Forms.TextBox()
        Me.btnPublic = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.btnLicense = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblApplication
        '
        Me.lblApplication.AutoSize = True
        Me.lblApplication.Location = New System.Drawing.Point(13, 13)
        Me.lblApplication.Name = "lblApplication"
        Me.lblApplication.Size = New System.Drawing.Size(90, 13)
        Me.lblApplication.TabIndex = 1
        Me.lblApplication.Text = "Application Name"
        '
        'AppName
        '
        Me.AppName.Location = New System.Drawing.Point(16, 30)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(200, 20)
        Me.AppName.TabIndex = 0
        Me.AppName.Text = "ProGridComponent"
        '
        'btnPublic
        '
        Me.btnPublic.Location = New System.Drawing.Point(285, 30)
        Me.btnPublic.Name = "btnPublic"
        Me.btnPublic.Size = New System.Drawing.Size(102, 23)
        Me.btnPublic.TabIndex = 1
        Me.btnPublic.Text = "Copy Public key"
        Me.btnPublic.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 94)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(372, 20)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(16, 144)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(372, 20)
        Me.txtEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Purchase Date"
        '
        'dtDate
        '
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(16, 190)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(200, 20)
        Me.dtDate.TabIndex = 4
        '
        'btnLicense
        '
        Me.btnLicense.Location = New System.Drawing.Point(285, 187)
        Me.btnLicense.Name = "btnLicense"
        Me.btnLicense.Size = New System.Drawing.Size(102, 23)
        Me.btnLicense.TabIndex = 9
        Me.btnLicense.Text = "Create License"
        Me.btnLicense.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 223)
        Me.Controls.Add(Me.btnLicense)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPublic)
        Me.Controls.Add(Me.AppName)
        Me.Controls.Add(Me.lblApplication)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblApplication As System.Windows.Forms.Label
    Friend WithEvents AppName As System.Windows.Forms.TextBox
    Friend WithEvents btnPublic As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLicense As System.Windows.Forms.Button

End Class
