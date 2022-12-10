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
        Me.sb = New System.Windows.Forms.StatusStrip()
        Me.txtRenderingTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCellLocation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pg = New ProGrid.ProGrid()
        Me.sb.SuspendLayout()
        Me.SuspendLayout()
        '
        'sb
        '
        Me.sb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtRenderingTime, Me.txtCellLocation})
        Me.sb.Location = New System.Drawing.Point(0, 338)
        Me.sb.Name = "sb"
        Me.sb.Size = New System.Drawing.Size(668, 24)
        Me.sb.TabIndex = 1
        Me.sb.Text = "StatusStrip1"
        '
        'txtRenderingTime
        '
        Me.txtRenderingTime.Name = "txtRenderingTime"
        Me.txtRenderingTime.Size = New System.Drawing.Size(197, 19)
        Me.txtRenderingTime.Text = "Click a Tool Button to display data..."
        '
        'txtCellLocation
        '
        Me.txtCellLocation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.txtCellLocation.Name = "txtCellLocation"
        Me.txtCellLocation.Size = New System.Drawing.Size(37, 19)
        Me.txtCellLocation.Text = "Cell: "
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
        Me.pg.CellTextMaxLength = "200"
        Me.pg.ContextMenuStrip = Nothing
        Me.pg.Cursor = System.Windows.Forms.Cursors.Default
        Me.pg.DefaultDateFormat = "M/d/yyyy"
        Me.pg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pg.EnableAddButton = True
        Me.pg.EnableColorAdjustment = False
        Me.pg.EnableDeleteButton = True
        Me.pg.EnableEditHighlighting = True
        Me.pg.EnableEditing = True
        Me.pg.EnableFiltering = True
        Me.pg.EnableFullRowSelection = False
        Me.pg.EnableIdentityHide = True
        Me.pg.EnableInvalidCellHandling = ProGrid.ProGrid.ProGridInvalidMethods.MarkAndShowTip
        Me.pg.EnableOptionsButton = True
        Me.pg.EnableOptionsCopy = True
        Me.pg.EnableOptionsExport = True
        Me.pg.EnableOptionsFind = True
        Me.pg.EnableOptionsPrint = True
        Me.pg.EnableOptionsSort = True
        Me.pg.EnableRefreshButton = True
        Me.pg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pg.LicenseFolder = "C:\Storage\ProGrid\Licenses\Tyson Gill"
        Me.pg.Location = New System.Drawing.Point(0, 0)
        Me.pg.Name = "pg"
        Me.pg.PrintTitle = "ProGrid Report"
        Me.pg.Size = New System.Drawing.Size(668, 338)
        Me.pg.TabIndex = 2
        Me.pg.UseWaitCursor = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 362)
        Me.Controls.Add(Me.pg)
        Me.Controls.Add(Me.sb)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProGrid Demo"
        Me.sb.ResumeLayout(False)
        Me.sb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pg As ProGrid.ProGrid
    Friend WithEvents sb As System.Windows.Forms.StatusStrip
    Friend WithEvents txtRenderingTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCellLocation As System.Windows.Forms.ToolStripStatusLabel

End Class
