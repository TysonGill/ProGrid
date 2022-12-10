<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSort
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
        Me.pg = New ProGrid()
        Me.SuspendLayout()
        '
        'pg
        '
        Me.pg.AccessibleRole = Nothing
        Me.pg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.pg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.pg.AutoSizeMode = Nothing
        Me.pg.BackgroundImageLayout = Nothing
        Me.pg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pg.CausesValidation = False
        Me.pg.ContextMenuStrip = Nothing
        Me.pg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pg.EnableAddButton = False
        Me.pg.EnableDeleteButton = False
        Me.pg.EnableEditHighlighting = True
        Me.pg.EnableEditing = False
        Me.pg.EnableIdentityHide = False
        Me.pg.EnableOptionsButton = True
        Me.pg.EnableRefreshButton = False
        Me.pg.Location = New System.Drawing.Point(0, 0)
        Me.pg.Name = "pg"
        Me.pg.Size = New System.Drawing.Size(296, 250)
        Me.pg.TabIndex = 4
        Me.pg.UseWaitCursor = Nothing
        '
        'frmSortSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 250)
        Me.Controls.Add(Me.pg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(225, 237)
        Me.Name = "frmSortSelect"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProGrid Multicolumn Sort"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pg As ProGrid

End Class
