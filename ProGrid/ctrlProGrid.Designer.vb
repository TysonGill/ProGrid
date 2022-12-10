<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProGrid))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.hsb = New System.Windows.Forms.HScrollBar()
        Me.vsb = New System.Windows.Forms.VScrollBar()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.picSizer = New System.Windows.Forms.PictureBox()
        Me.tb = New System.Windows.Forms.ToolStrip()
        Me.btnFlip = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrev = New System.Windows.Forms.ToolStripButton()
        Me.lblRecord = New System.Windows.Forms.ToolStripLabel()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.sepAdd = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.sepButtons = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCopyGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUserOne = New System.Windows.Forms.ToolStripButton()
        Me.btnUserTwo = New System.Windows.Forms.ToolStripButton()
        Me.btnUserThree = New System.Windows.Forms.ToolStripButton()
        Me.btnUserFour = New System.Windows.Forms.ToolStripButton()
        Me.btnUserFive = New System.Windows.Forms.ToolStripButton()
        Me.btnUserSix = New System.Windows.Forms.ToolStripButton()
        Me.btnUserSeven = New System.Windows.Forms.ToolStripButton()
        Me.btnUserEight = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.calendar = New System.Windows.Forms.DateTimePicker()
        Me.editor = New System.Windows.Forms.TextBox()
        Me.ctxCell = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxCopyCell = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxPasteCell = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ctxCopyRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxColorSep = New System.Windows.Forms.ToolStripSeparator()
        Me.ctxEditColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxEditLighten = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxEditDarken = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxHighColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxHighLighten = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxHighDarken = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.ctxHeader = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxCopyCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxFilterSep = New System.Windows.Forms.ToolStripSeparator()
        Me.ctxFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxRemoveFilters = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ctxResizeToData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxResizeToHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTip = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb.SuspendLayout()
        Me.ctxCell.SuspendLayout()
        Me.ctxHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Location = New System.Drawing.Point(13, 34)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(155, 17)
        Me.pnlHeader.TabIndex = 0
        '
        'hsb
        '
        Me.hsb.Location = New System.Drawing.Point(13, 168)
        Me.hsb.Name = "hsb"
        Me.hsb.Size = New System.Drawing.Size(155, 18)
        Me.hsb.TabIndex = 1
        '
        'vsb
        '
        Me.vsb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.vsb.Location = New System.Drawing.Point(176, 37)
        Me.vsb.Minimum = 1
        Me.vsb.Name = "vsb"
        Me.vsb.Size = New System.Drawing.Size(18, 140)
        Me.vsb.TabIndex = 3
        Me.vsb.Value = 1
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(13, 57)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(155, 108)
        Me.pic.TabIndex = 4
        Me.pic.TabStop = False
        '
        'picSizer
        '
        Me.picSizer.BackColor = System.Drawing.Color.DarkRed
        Me.picSizer.Cursor = System.Windows.Forms.Cursors.Default
        Me.picSizer.Location = New System.Drawing.Point(28, 70)
        Me.picSizer.Name = "picSizer"
        Me.picSizer.Size = New System.Drawing.Size(10, 50)
        Me.picSizer.TabIndex = 5
        Me.picSizer.TabStop = False
        '
        'tb
        '
        Me.tb.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFlip, Me.ToolStripSeparator1, Me.btnPrev, Me.lblRecord, Me.btnNext, Me.sepAdd, Me.btnAdd, Me.btnDelete, Me.sepButtons, Me.mnuOptions, Me.btnUserOne, Me.btnUserTwo, Me.btnUserThree, Me.btnUserFour, Me.btnUserFive, Me.btnUserSix, Me.btnUserSeven, Me.btnUserEight, Me.btnRefresh})
        Me.tb.Location = New System.Drawing.Point(0, 0)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(204, 25)
        Me.tb.TabIndex = 6
        Me.tb.Text = "ToolStrip1"
        '
        'btnFlip
        '
        Me.btnFlip.AutoToolTip = False
        Me.btnFlip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFlip.Enabled = False
        Me.btnFlip.Image = CType(resources.GetObject("btnFlip.Image"), System.Drawing.Image)
        Me.btnFlip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(23, 22)
        Me.btnFlip.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnPrev
        '
        Me.btnPrev.AutoToolTip = False
        Me.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrev.Enabled = False
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(23, 22)
        Me.btnPrev.Text = "ToolStripButton1"
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = False
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(48, 22)
        Me.lblRecord.Text = "1 of 100"
        '
        'btnNext
        '
        Me.btnNext.AutoToolTip = False
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Enabled = False
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(23, 22)
        Me.btnNext.Text = "ToolStripButton2"
        '
        'sepAdd
        '
        Me.sepAdd.Name = "sepAdd"
        Me.sepAdd.Size = New System.Drawing.Size(6, 25)
        Me.sepAdd.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AutoToolTip = False
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(23, 22)
        Me.btnAdd.Text = "ToolStripButton1"
        Me.btnAdd.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoToolTip = False
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "ToolStripButton2"
        Me.btnDelete.Visible = False
        '
        'sepButtons
        '
        Me.sepButtons.Name = "sepButtons"
        Me.sepButtons.Size = New System.Drawing.Size(6, 25)
        '
        'mnuOptions
        '
        Me.mnuOptions.AutoToolTip = False
        Me.mnuOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFind, Me.mnuFindNext, Me.mnuFindSep, Me.mnuSort, Me.mnuSortSep, Me.mnuCopyGrid, Me.mnuPrint, Me.mnuExport})
        Me.mnuOptions.Image = CType(resources.GetObject("mnuOptions.Image"), System.Drawing.Image)
        Me.mnuOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(62, 19)
        Me.mnuOptions.Text = "Options"
        Me.mnuOptions.Visible = False
        '
        'mnuFind
        '
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFind.Size = New System.Drawing.Size(176, 22)
        Me.mnuFind.Text = "Find..."
        '
        'mnuFindNext
        '
        Me.mnuFindNext.Name = "mnuFindNext"
        Me.mnuFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuFindNext.Size = New System.Drawing.Size(176, 22)
        Me.mnuFindNext.Text = "Find Next"
        '
        'mnuFindSep
        '
        Me.mnuFindSep.Name = "mnuFindSep"
        Me.mnuFindSep.Size = New System.Drawing.Size(173, 6)
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(176, 22)
        Me.mnuSort.Text = "Multicolumn Sort..."
        '
        'mnuSortSep
        '
        Me.mnuSortSep.Name = "mnuSortSep"
        Me.mnuSortSep.Size = New System.Drawing.Size(173, 6)
        '
        'mnuCopyGrid
        '
        Me.mnuCopyGrid.Name = "mnuCopyGrid"
        Me.mnuCopyGrid.Size = New System.Drawing.Size(176, 22)
        Me.mnuCopyGrid.Text = "Copy Grid"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(176, 22)
        Me.mnuPrint.Text = "Print Grid"
        '
        'mnuExport
        '
        Me.mnuExport.Name = "mnuExport"
        Me.mnuExport.Size = New System.Drawing.Size(176, 22)
        Me.mnuExport.Text = "Export Grid..."
        '
        'btnUserOne
        '
        Me.btnUserOne.AutoToolTip = False
        Me.btnUserOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserOne.Image = CType(resources.GetObject("btnUserOne.Image"), System.Drawing.Image)
        Me.btnUserOne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserOne.Name = "btnUserOne"
        Me.btnUserOne.Size = New System.Drawing.Size(33, 22)
        Me.btnUserOne.Tag = "1"
        Me.btnUserOne.Text = "One"
        Me.btnUserOne.Visible = False
        '
        'btnUserTwo
        '
        Me.btnUserTwo.AutoToolTip = False
        Me.btnUserTwo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserTwo.Image = CType(resources.GetObject("btnUserTwo.Image"), System.Drawing.Image)
        Me.btnUserTwo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserTwo.Name = "btnUserTwo"
        Me.btnUserTwo.Size = New System.Drawing.Size(34, 22)
        Me.btnUserTwo.Tag = "2"
        Me.btnUserTwo.Text = "Two"
        Me.btnUserTwo.Visible = False
        '
        'btnUserThree
        '
        Me.btnUserThree.AutoToolTip = False
        Me.btnUserThree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserThree.Image = CType(resources.GetObject("btnUserThree.Image"), System.Drawing.Image)
        Me.btnUserThree.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserThree.Name = "btnUserThree"
        Me.btnUserThree.Size = New System.Drawing.Size(41, 22)
        Me.btnUserThree.Tag = "3"
        Me.btnUserThree.Text = "Three"
        Me.btnUserThree.Visible = False
        '
        'btnUserFour
        '
        Me.btnUserFour.AutoToolTip = False
        Me.btnUserFour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserFour.Image = CType(resources.GetObject("btnUserFour.Image"), System.Drawing.Image)
        Me.btnUserFour.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserFour.Name = "btnUserFour"
        Me.btnUserFour.Size = New System.Drawing.Size(35, 22)
        Me.btnUserFour.Tag = "4"
        Me.btnUserFour.Text = "Four"
        Me.btnUserFour.Visible = False
        '
        'btnUserFive
        '
        Me.btnUserFive.AutoToolTip = False
        Me.btnUserFive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserFive.Image = CType(resources.GetObject("btnUserFive.Image"), System.Drawing.Image)
        Me.btnUserFive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserFive.Name = "btnUserFive"
        Me.btnUserFive.Size = New System.Drawing.Size(32, 22)
        Me.btnUserFive.Tag = "5"
        Me.btnUserFive.Text = "Five"
        Me.btnUserFive.Visible = False
        '
        'btnUserSix
        '
        Me.btnUserSix.AutoToolTip = False
        Me.btnUserSix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserSix.Image = CType(resources.GetObject("btnUserSix.Image"), System.Drawing.Image)
        Me.btnUserSix.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserSix.Name = "btnUserSix"
        Me.btnUserSix.Size = New System.Drawing.Size(25, 22)
        Me.btnUserSix.Tag = "6"
        Me.btnUserSix.Text = "Six"
        Me.btnUserSix.Visible = False
        '
        'btnUserSeven
        '
        Me.btnUserSeven.AutoToolTip = False
        Me.btnUserSeven.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserSeven.Image = CType(resources.GetObject("btnUserSeven.Image"), System.Drawing.Image)
        Me.btnUserSeven.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserSeven.Name = "btnUserSeven"
        Me.btnUserSeven.Size = New System.Drawing.Size(42, 22)
        Me.btnUserSeven.Tag = "6"
        Me.btnUserSeven.Text = "Seven"
        Me.btnUserSeven.ToolTipText = "Seven"
        Me.btnUserSeven.Visible = False
        '
        'btnUserEight
        '
        Me.btnUserEight.AutoToolTip = False
        Me.btnUserEight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUserEight.Image = CType(resources.GetObject("btnUserEight.Image"), System.Drawing.Image)
        Me.btnUserEight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserEight.Name = "btnUserEight"
        Me.btnUserEight.Size = New System.Drawing.Size(38, 22)
        Me.btnUserEight.Tag = "6"
        Me.btnUserEight.Text = "Eight"
        Me.btnUserEight.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "ToolStripButton1"
        Me.btnRefresh.ToolTipText = "Refresh All Records"
        Me.btnRefresh.Visible = False
        '
        'combo
        '
        Me.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo.FormattingEnabled = True
        Me.combo.IntegralHeight = False
        Me.combo.Location = New System.Drawing.Point(49, 113)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(100, 21)
        Me.combo.TabIndex = 11
        Me.combo.TabStop = False
        Me.combo.Visible = False
        '
        'calendar
        '
        Me.calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calendar.Location = New System.Drawing.Point(49, 87)
        Me.calendar.Name = "calendar"
        Me.calendar.Size = New System.Drawing.Size(100, 20)
        Me.calendar.TabIndex = 10
        Me.calendar.TabStop = False
        Me.calendar.Visible = False
        '
        'editor
        '
        Me.editor.BackColor = System.Drawing.Color.White
        Me.editor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editor.Location = New System.Drawing.Point(49, 68)
        Me.editor.Multiline = True
        Me.editor.Name = "editor"
        Me.editor.Size = New System.Drawing.Size(100, 20)
        Me.editor.TabIndex = 9
        Me.editor.TabStop = False
        Me.editor.Visible = False
        Me.editor.WordWrap = False
        '
        'ctxCell
        '
        Me.ctxCell.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxOpen, Me.ctxCopyCell, Me.ctxPasteCell, Me.ToolStripSeparator2, Me.ctxCopyRow, Me.ctxColorSep, Me.ctxEditColor, Me.ctxHighColor})
        Me.ctxCell.Name = "ctxCell"
        Me.ctxCell.Size = New System.Drawing.Size(155, 148)
        '
        'ctxOpen
        '
        Me.ctxOpen.Name = "ctxOpen"
        Me.ctxOpen.Size = New System.Drawing.Size(154, 22)
        Me.ctxOpen.Text = "Open..."
        '
        'ctxCopyCell
        '
        Me.ctxCopyCell.Name = "ctxCopyCell"
        Me.ctxCopyCell.Size = New System.Drawing.Size(154, 22)
        Me.ctxCopyCell.Text = "Copy Cell"
        '
        'ctxPasteCell
        '
        Me.ctxPasteCell.Name = "ctxPasteCell"
        Me.ctxPasteCell.Size = New System.Drawing.Size(154, 22)
        Me.ctxPasteCell.Text = "Paste Cell"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(151, 6)
        '
        'ctxCopyRow
        '
        Me.ctxCopyRow.Name = "ctxCopyRow"
        Me.ctxCopyRow.Size = New System.Drawing.Size(154, 22)
        Me.ctxCopyRow.Text = "Copy Row"
        '
        'ctxColorSep
        '
        Me.ctxColorSep.Name = "ctxColorSep"
        Me.ctxColorSep.Size = New System.Drawing.Size(151, 6)
        '
        'ctxEditColor
        '
        Me.ctxEditColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxEditLighten, Me.ctxEditDarken})
        Me.ctxEditColor.Name = "ctxEditColor"
        Me.ctxEditColor.Size = New System.Drawing.Size(154, 22)
        Me.ctxEditColor.Text = "Edit Color"
        '
        'ctxEditLighten
        '
        Me.ctxEditLighten.Name = "ctxEditLighten"
        Me.ctxEditLighten.Size = New System.Drawing.Size(114, 22)
        Me.ctxEditLighten.Text = "Lighten"
        '
        'ctxEditDarken
        '
        Me.ctxEditDarken.Name = "ctxEditDarken"
        Me.ctxEditDarken.Size = New System.Drawing.Size(114, 22)
        Me.ctxEditDarken.Text = "Darken"
        '
        'ctxHighColor
        '
        Me.ctxHighColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxHighLighten, Me.ctxHighDarken})
        Me.ctxHighColor.Name = "ctxHighColor"
        Me.ctxHighColor.Size = New System.Drawing.Size(154, 22)
        Me.ctxHighColor.Text = "Selection Color"
        '
        'ctxHighLighten
        '
        Me.ctxHighLighten.Name = "ctxHighLighten"
        Me.ctxHighLighten.Size = New System.Drawing.Size(114, 22)
        Me.ctxHighLighten.Text = "Lighten"
        '
        'ctxHighDarken
        '
        Me.ctxHighDarken.Name = "ctxHighDarken"
        Me.ctxHighDarken.Size = New System.Drawing.Size(114, 22)
        Me.ctxHighDarken.Text = "Darken"
        '
        'tmrMove
        '
        '
        'ctxHeader
        '
        Me.ctxHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxCopyCol, Me.ctxFilterSep, Me.ctxFilter, Me.ctxRemoveFilters, Me.ToolStripMenuItem1, Me.ctxResizeToData, Me.ctxResizeToHeader})
        Me.ctxHeader.Name = "ctxCell"
        Me.ctxHeader.Size = New System.Drawing.Size(173, 126)
        '
        'ctxCopyCol
        '
        Me.ctxCopyCol.Name = "ctxCopyCol"
        Me.ctxCopyCol.Size = New System.Drawing.Size(172, 22)
        Me.ctxCopyCol.Text = "Copy Column"
        '
        'ctxFilterSep
        '
        Me.ctxFilterSep.Name = "ctxFilterSep"
        Me.ctxFilterSep.Size = New System.Drawing.Size(169, 6)
        '
        'ctxFilter
        '
        Me.ctxFilter.Name = "ctxFilter"
        Me.ctxFilter.Size = New System.Drawing.Size(172, 22)
        Me.ctxFilter.Text = "Filter on Column..."
        '
        'ctxRemoveFilters
        '
        Me.ctxRemoveFilters.Name = "ctxRemoveFilters"
        Me.ctxRemoveFilters.Size = New System.Drawing.Size(172, 22)
        Me.ctxRemoveFilters.Text = "Remove All Filters"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(169, 6)
        '
        'ctxResizeToData
        '
        Me.ctxResizeToData.Name = "ctxResizeToData"
        Me.ctxResizeToData.Size = New System.Drawing.Size(172, 22)
        Me.ctxResizeToData.Text = "Resize to Data"
        '
        'ctxResizeToHeader
        '
        Me.ctxResizeToHeader.Name = "ctxResizeToHeader"
        Me.ctxResizeToHeader.Size = New System.Drawing.Size(172, 22)
        Me.ctxResizeToHeader.Text = "Resize to Header"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTip.Location = New System.Drawing.Point(46, 137)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(24, 15)
        Me.lblTip.TabIndex = 12
        Me.lblTip.Text = "Tip"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTip.Visible = False
        '
        'ProGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.editor)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.picSizer)
        Me.Controls.Add(Me.vsb)
        Me.Controls.Add(Me.hsb)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pic)
        Me.DoubleBuffered = True
        Me.Name = "ProGrid"
        Me.Size = New System.Drawing.Size(204, 186)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb.ResumeLayout(False)
        Me.tb.PerformLayout()
        Me.ctxCell.ResumeLayout(False)
        Me.ctxHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents hsb As System.Windows.Forms.HScrollBar
    Friend WithEvents vsb As System.Windows.Forms.VScrollBar
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents picSizer As System.Windows.Forms.PictureBox
    Friend WithEvents tb As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFlip As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblRecord As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepAdd As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepButtons As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFindNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFindSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCopyGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUserOne As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUserTwo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUserThree As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUserFour As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUserFive As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUserSix As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents combo As System.Windows.Forms.ComboBox
    Friend WithEvents calendar As System.Windows.Forms.DateTimePicker
    Friend WithEvents editor As System.Windows.Forms.TextBox
    Friend WithEvents ctxCell As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctxOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxCopyCell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxCopyRow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents btnUserSeven As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUserEight As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxHeader As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctxFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxCopyCol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxRemoveFilters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxFilterSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents ctxColorSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ctxEditColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxEditLighten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxEditDarken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxHighColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxHighLighten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxHighDarken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ctxResizeToData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxResizeToHeader As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxPasteCell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
