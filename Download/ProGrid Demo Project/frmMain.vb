Imports ProGrid.ProGrid

Public Class frmMain

    ' Initialize the demo
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ' Assign the path to your license file.
            ' This takes effect during design mode only. You can also set it in your designer properties window.
            ' Your license file contains your personal information. You should not share it with other developers nor distribute with runtimes.
            pg.LicenseFolder = ""

            ' Configure ProGrid options
            ' All are true by default and are here just for illustration
            pg.EnableEditing = True ' True to enable the editing of editable data columns
            pg.EnableAddButton = True ' True to enable the Record Add button
            pg.EnableDeleteButton = True ' True to enable the Record Delete button
            pg.EnableEditHighlighting = True ' True to enable the highlighting of editable cells in yellow
            pg.EnableIdentityHide = True ' True to enable the hiding of identity columns when schema is present
            pg.EnableOptionsButton = True ' True to enable the Options dropdown button
            pg.EnableOptionsFind = True ' True to enable the Find items in the Options dropdown
            pg.EnableOptionsSort = True ' True to enable the Multicolumn Sort item in the Options dropdown
            pg.EnableOptionsCopy = True ' True to enable the all menu Copy options
            pg.EnableOptionsPrint = True ' True to enable the Print item in the Options dropdown
            pg.EnableOptionsExport = True ' True to enable the Export item in the Options dropdown
            pg.EnableRefreshButton = True ' True to enable the Refresh button in the upper right of the grid

            ' Enable full row selection mode
            pg.EnableFullRowSelection = True

            ' Set the method ProGrid will use to mark cells with out of range values
            pg.EnableInvalidCellHandling = ProGridInvalidMethods.MarkAndShowTip

            ' True to enable the Filter items in the Header context menu
            ' Note that this user will only be able to use the "Remove all Filters" menu item if EnableEditing = False 
            ' As an alternative they should use the Refresh button
            pg.EnableFiltering = True

            ' Override the default date format of M/d/yyyy. You can override this further on a per-column basis with a DateOnly style.
            pg.DefaultDateFormat = "MMM d, yyyy"

            ' Quick configure of the ProGrid Tool Buttons
            ' Use the ButtonSet() method to configure each button separately with additional options
            pg.ButtonQuickSet("Small", "Medium", "Large", "Data Types", "Styles")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Display a datatable in the Progrid and show elapsed time in the status bar
    Private Sub ShowTable(ByVal TableName As String)

        ' Get the datatable to display
        Dim dt As DataTable = Nothing
        Select Case TableName
            Case "Small"
                dt = CreateDemo(10, 5)
            Case "Medium"
                dt = CreateDemo(100, 20)
            Case "Large"
                dt = CreateDemo(10000, 50)
            Case "Data Types"
                dt = CreateTypes()
            Case "Styles"
                dt = CreateStyles()
            Case Else
                Exit Sub
        End Select

        ' Start timing our ProGrid display time
        Dim sw As New Stopwatch
        sw.Start()

        ' Load and display the table
        pg.GridShow(dt)

        ' Stop timing and report in status bar
        sw.Stop()
        txtRenderingTime.Text = "Refresh Time: " + sw.ElapsedMilliseconds.ToString + " ms"

    End Sub

    ' A quick way to initialize editing for all columns
    Public Sub SetStylesEditable(ByVal dt As DataTable, ByVal Editable As Boolean)
        For Each c As DataColumn In dt.Columns
            pg.StyleGet(c.ColumnName).ProEditable = Editable
        Next
    End Sub

#Region "Data Loaders"

    ' Display a table of a given size
    Private Function CreateDemo(ByVal RowCount As Integer, ByVal ColCount As Integer) As DataTable

        ' Create datatable
        Dim dt As DataTable = New DataTable("Demo")
        dt.Columns.Add("PK", GetType(System.Int32))
        dt.Columns("PK").AutoIncrement = True
        For ColIndex As Integer = 1 To ColCount
            dt.Columns.Add("Column " + ColIndex.ToString, GetType(System.Decimal))
        Next

        ' Populate datatable
        For RowIndex As Integer = 1 To RowCount
            Dim n As DataRow = dt.NewRow
            n(0) = RowIndex
            For ColIndex As Integer = 1 To ColCount
                n(ColIndex) = Val(RowIndex.ToString + "." + ColIndex.ToString)
            Next
            dt.Rows.Add(n)
        Next

        ' Set the column styles
        pg.StyleClear()
        pg.StyleSet("Column 1", New ProGridStyle(ProGridStyleTypes.Numeric, DecimalPlaces:=0, MinValue:="4", MaxValue:=RowCount - 3))

        ' Return the table
        dt.Rows.Clear()
        Return dt

    End Function

    ' Display a table to demonstrate the various ProGrid primary styles
    Private Function CreateTypes() As DataTable

        ' Create datatable
        Dim dt As DataTable = New DataTable("Types")
        dt.Columns.Add("Bit", GetType(System.Boolean))
        dt.Columns.Add("Integer", GetType(System.Int32))
        dt.Columns.Add("Double", GetType(System.Double))
        dt.Columns.Add("String", GetType(System.String))
        dt.Columns("String").MaxLength = 20 ' Data entry will limit the characters by default
        dt.Columns.Add("Date", GetType(System.DateTime))
        dt.Columns.Add("Text", GetType(System.String))
        dt.Columns("Text").MaxLength = 1000 ' This will be handled as a text column.
        dt.Columns.Add("Image", GetType(System.Object))

        ' Populate datatable
        For RowIndex As Integer = 1 To 1
            Dim n As DataRow = dt.NewRow
            n("Bit") = 1
            n("Integer") = RowIndex
            n("Double") = RowIndex
            n("String") = "This is a string."
            n("Date") = Now
            n("Text") = "This is long text column."
            n("Image") = My.Resources.ProGridLogo
            dt.Rows.Add(n)
        Next

        ' Override the default max text length of 200 for text display in cells
        ' Cells longer than this will be overridden with a "<Text>" label but can be viewed through the Open... context menu item.
        pg.CellTextMaxLength = 100

        ' Set the column styles
        pg.StyleClear()
        pg.StyleSet("Image", New ProGridStyle(ProGridStyleTypes.Freeform, DataFileExtension:="png"))

        ' Return the table
        Return dt

    End Function

    ' Display a table to demonstrate the various ProGrid secondary styles
    Private Function CreateStyles() As DataTable

        ' Create datatable
        Dim dt As DataTable = New DataTable("Styles")
        dt.Columns.Add("Freeform", GetType(System.String))
        dt.Columns.Add("Lower Case", GetType(System.String))
        dt.Columns.Add("Upper Case", GetType(System.String))
        dt.Columns.Add("Title Case", GetType(System.String))
        dt.Columns.Add("ZipCode", GetType(System.String))
        dt.Columns.Add("Phone Number", GetType(System.String))
        dt.Columns.Add("SSN", GetType(System.String))
        dt.Columns.Add("Integer", GetType(System.Int32))
        dt.Columns.Add("Float", GetType(System.Double))
        dt.Columns.Add("Percent", GetType(System.Double))
        dt.Columns.Add("Currency", GetType(System.Double))
        dt.Columns.Add("DateOnly", GetType(System.DateTime))
        dt.Columns.Add("TimeOnly", GetType(System.DateTime))
        dt.Columns.Add("Link", GetType(System.String))
        dt.Columns.Add("DropDownList", GetType(System.String))
        dt.Columns.Add("DropDownPairs", GetType(System.Int32))

        ' Populate datatable
        For RowIndex As Integer = 1 To 1
            Dim n As DataRow = dt.NewRow
            n("Freeform") = "Freeform " + RowIndex.ToString
            n("Lower Case") = "lower case " + RowIndex.ToString
            n("Upper Case") = "UPPER CASE " + RowIndex.ToString
            n("Title Case") = "Title case " + RowIndex.ToString
            n("ZipCode") = "100053456"
            n("Phone Number") = "2123445456"
            n("SSN") = "233446756"
            n("Integer") = RowIndex
            n("Float") = RowIndex
            n("Percent") = RowIndex
            n("Currency") = RowIndex
            n("DateOnly") = DateAdd(DateInterval.Day, RowIndex, Now)
            n("TimeOnly") = DateAdd(DateInterval.Minute, RowIndex, Now)
            n("Link") = "www.google.com"
            n("DropDownList") = True
            n("DropDownPairs") = 0
            dt.Rows.Add(n)
        Next

        ' Create a simple dropdown list for the boolean column
        Dim DropList As New DataTable
        DropList.Columns.Add("Choice")
        DropList.Rows.Add("True")
        DropList.Rows.Add("False")

        ' Create a dropdown list demonstrating a key-value lookup list
        Dim DropPairs As New DataTable
        DropPairs.Columns.Add("Value")
        DropPairs.Columns.Add("Choice")
        DropPairs.Rows.Add(1, "Yes")
        DropPairs.Rows.Add(0, "No")

        ' Set the column styles
        pg.StyleClear()
        pg.StyleSet("Freeform", New ProGridStyle(ProGridStyleTypes.Freeform))
        pg.StyleSet("Lower Case", New ProGridStyle(ProGridStyleTypes.LowerCase))
        pg.StyleSet("Upper Case", New ProGridStyle(ProGridStyleTypes.UpperCase))
        pg.StyleSet("title Case", New ProGridStyle(ProGridStyleTypes.TitleCase))
        pg.StyleSet("ZipCode", New ProGridStyle(ProGridStyleTypes.ZipCode))
        pg.StyleSet("Phone Number", New ProGridStyle(ProGridStyleTypes.PhoneNumber))
        pg.StyleSet("SSN", New ProGridStyle(ProGridStyleTypes.SSN))
        pg.StyleSet("Percent", New ProGridStyle(ProGridStyleTypes.Percent))
        pg.StyleSet("Currency", New ProGridStyle(ProGridStyleTypes.Currency))
        pg.StyleSet("DateOnly", New ProGridStyle(ProGridStyleTypes.DateOnly))
        pg.StyleSet("TimeOnly", New ProGridStyle(ProGridStyleTypes.TimeOnly, MinValue:="6:00 AM"))
        pg.StyleSet("Integer", New ProGridStyle(ProGridStyleTypes.Numeric))
        pg.StyleSet("Float", New ProGridStyle(ProGridStyleTypes.Numeric, DecimalPlaces:=2))
        pg.StyleSet("DropDownList", New ProGridStyle(ProGridStyleTypes.Dropdown, Dropdown:=DropList))
        pg.StyleSet("DropDownPairs", New ProGridStyle(ProGridStyleTypes.Dropdown, Dropdown:=DropPairs))
        pg.StyleSet("Link", New ProGridStyle(ProGridStyleTypes.Freeform, OverrideString:="<file link>"))

        ' Return the table
        Return dt

    End Function

#End Region

#Region "Event Handlers"

    ' Handle the ProGrid Tool Button Click event.
    Private Sub pg_UserClickedButton(ByVal ButtonTag As System.String) Handles pg.UserClickedButton

        pg.Tag = ButtonTag
        ShowTable(pg.Tag)

    End Sub

    ' The user clicked the "refresh" button. You should requery for your datatable and redisplay.
    Private Sub sg_UserClickedRefresh() Handles pg.UserClickedRefresh

        ShowTable(pg.Tag)

    End Sub

    ' A new cell was selected. The zero-based row and column in the datatable are returned.
    Private Sub sg_UserSelectedCell(ByVal RowIndex As System.Int32, ByVal ColIndex As System.Int32) Handles pg.UserSelectedCell

        ' Display the currently selected cell location
        Dim MsgText As String = "Row: " + RowIndex.ToString + ", Col: " + ColIndex.ToString
        txtCellLocation.Text = MsgText

    End Sub

    ' The user double-clicked on a cell. The zero-based row and column in the datatable are returned.
    Private Sub sg_UserDoubleClicked(ByVal RowIndex As System.Int32, ByVal ColIndex As System.Int32) Handles pg.UserDoubleClicked

        ' Display a message box
        Dim MsgText As String = "You double-clicked on Row: " + RowIndex.ToString + ", Col: " + ColIndex.ToString
        MessageBox.Show(MsgText, "Double Click Event", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    ' The user completed editing a cell. Validate, modify, commit or undo changes.
    Private Sub pg_UserEditedCell(ByRef EditedRow As System.Data.DataRow, ByVal EditedColIndex As System.Int32, ByRef SaveAction As ProGrid.ProGrid.ProGridSaveActions) Handles pg.UserEditedCell

        ' This event hander isn't really needed if there is no option to UndoChanges.
        SaveAction = ProGridSaveActions.CommitChanges

    End Sub

    ' The user clicked the Add Record button. Validate, modify, commit or undo the add.
    Private Sub sg_UserClickedAdd(ByRef AddedRow As System.Data.DataRow, ByRef SaveAction As ProGridSaveActions) Handles pg.UserClickedAdd

        ' Assign a new primary key if needed
        If AddedRow.Table.Columns.Contains("PK") Then AddedRow("PK") = pg.RecordCount + 1
        SaveAction = ProGridSaveActions.CommitChanges

    End Sub

    ' The user clicked the Delete Record button. Validate, modify, commit or undo the delete.
    Private Sub sg_UserClickedDelete(ByRef DeletedRow As System.Data.DataRow, ByRef SaveAction As ProGridSaveActions) Handles pg.UserClickedDelete

        ' This event hander isn't really needed if there is no option to UndoChanges.
        SaveAction = ProGridSaveActions.CommitChanges

    End Sub

#End Region

End Class
