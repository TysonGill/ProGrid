<Assembly: System.Runtime.CompilerServices.SuppressIldasmAttribute()> 

''' <summary>The ProGrid Datagrid Component</summary>
Public Class ProGrid

    Private EnforceLicense As Boolean = True

#Region "Hide Base Class Properties"

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AccessibleDescription() As String
        Get
            Return Nothing
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AccessibleName() As String
        Get
            Return Nothing
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AccessibleRole() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AutoScroll() As Boolean
        Get
            Return Nothing
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AutoScrollMargin() As Size
        Get
            Return Nothing
        End Get
        Set(ByVal value As Size)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AutoScrollMinSize() As Size
        Get
            Return Nothing
        End Get
        Set(ByVal value As Size)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AutoSizeMode() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AutoValidate() As Boolean
        Get
            Return Nothing
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AllowDrop() As Boolean
        Get
            Return Nothing
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property AutoSize() As Boolean
        Get
            Return Nothing
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property BackgroundImage() As Image
        Get
            Return Nothing
        End Get
        Set(ByVal value As Image)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property BackgroundImageLayout() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property CausesValidation() As Boolean
        Get
            Return Nothing
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property ContextMenuStrip() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property ForeColor() As Color
        Get
            Return Nothing
        End Get
        Set(ByVal value As Color)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property ImeMode() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property Margin() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property Padding() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
Public Shadows Property RightToLeft() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property

    <System.ComponentModel.Browsable(False), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
    Public Shadows Property UseWaitCursor() As Object
        Get
            Return Nothing
        End Get
        Set(ByVal value As Object)
        End Set
    End Property
#End Region

#Region "General Settings"

    Private FirstHorzDisplay As Boolean = True ' Flags that the grid is being displayed for the first time
    Private Redrawing As Boolean = True ' Flags that the grid is being updated

    Private dt As DataTable
    Private RowHeight As Integer = 20
    Private CapsLock As Boolean = False

    Private g As Graphics
    Private bmap As Bitmap
    Private TextBrush As Brush
    Private LinePen As Pen
    Private EditBrush As Brush
    Private HeaderBrush As Brush
    Private InvalidPen As Pen
    Private SelectBrush As Brush
    Private CurFont As Font
    Private CheckFont As Font
    Private CurFontBold As Font
    Private CurFontUnderline As Font
    Private DisplayWidth As Integer

    Private Structure SavedPositionDef
        Dim LastHorizontalPosition As Integer
        Dim LastTopRow As Integer
        Dim IsValid As Boolean
    End Structure
    Dim SavedPosition As SavedPositionDef

    Private Structure DisplayCell
        Dim CellRec As Rectangle
        Dim CellText As String
        Dim GridRow As Integer
        Dim GridCol As Integer
        Dim Editable As Boolean
        Dim FillBrush As Brush
    End Structure
    Private CellGrid(,) As DisplayCell
    Private CellRows As Integer
    Private CellCols As Integer

    Private DefaultColWidth As Integer = 200
    Private DefaultHeaderHeight As Integer = 24
    Private MinimumColWidth As Integer = 30

    Private DLLPath As String = ""

    Private Structure ColumnDef
        Dim ColumnName As String
        Dim ctrlButton As PictureBox
        Dim ctrlSplit As PictureBox
        Dim Left As Integer
        Dim Right As Integer
        Dim Width As Integer
        Dim Visible As Boolean
        Dim Displayed As Boolean
    End Structure
    Private ColDefs() As ColumnDef

#End Region

#Region "Location Settings"

    Private FirstVisibleRow As Integer = -1
    Private LastVisibleRow As Integer = -1
    Private FirstVisibleCol As Integer = -1
    Private CurCellRow As Integer = -1
    Private CurCellCol As Integer = -1

    Private CurGridRow As Integer = -1
    ''' <summary>Returns the index of the currently selected record.</summary>
    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property SelectedRecord() As Integer
        Get
            Return CurGridRow
        End Get
    End Property

    Private CurGridCol As Integer = -1
    ''' <summary>Returns the index of the currently selected column.</summary>
    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property SelectedColumn() As Integer
        Get
            Return CurGridCol
        End Get
    End Property

    ''' <summary>Returns the current record count.</summary>
    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property RecordCount() As Integer
        Get
            Return GetRowCount(dt)
        End Get
    End Property

    ''' <summary>Returns the current column count.</summary>
    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property ColumnCount() As Integer
        Get
            Return GetColCount(dt)
        End Get
    End Property

    Private Class Cart

        Private _Row As Integer
        Friend Property Row() As Integer
            Get
                Return _Row
            End Get
            Set(ByVal Row As Integer)
                _Row = Row
            End Set
        End Property

        Private _Col As Integer
        Friend Property Col() As Integer
            Get
                Return _Col
            End Get
            Set(ByVal Col As Integer)
                _Col = Col
            End Set
        End Property

        Sub New(ByVal CellRow As Integer, ByVal CellCol As Integer)
            Row = CellRow
            Col = CellCol
        End Sub

    End Class

#End Region

#Region "Style Settings"

    Private CurOrientation As ProGridOrienations
    ''' <summary>Returns the current display orientation (vertical or horizontal).</summary>
    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property Orientation() As ProGridOrienations
        Get
            Return CurOrientation
        End Get
    End Property

    ''' <summary>Enumeration of ProGrid orientations.</summary>
    Public Enum ProGridOrienations
        Vertical
        Horizontal
        Automatic
    End Enum

    Private ProGridStyles As New Dictionary(Of String, ProGridStyle)(StringComparer.OrdinalIgnoreCase)

    ''' <summary>Enumeration of ProGrid display styles.</summary>
    Public Enum ProGridStyleTypes
        Freeform = 0
        LowerCase = 1
        UpperCase = 2
        TitleCase = 3
        ZipCode = 4
        PhoneNumber = 5
        SSN = 6
        Percent = 7
        Currency = 8
        DateOnly = 9
        TimeOnly = 10
        Numeric = 11
        Dropdown = 12
        CheckBox = 13
    End Enum

    ''' <summary>Enumeration of ProGrid column sizing methods.</summary>
    Public Enum ProGridSizingMethods
        HeaderOnly = 0
        AllDataOnly = 1
        AllDataAndHeader = 2
        SampledDataOnly = 3
        SampledDataAndHeader = 4
    End Enum

    ''' <summary>Enumeration of ProGrid invalid cell handling methods.</summary>
    Public Enum ProGridInvalidMethods
        Ignore = 0
        MarkOnly = 1
        MarkAndShowTip = 2
    End Enum

    ''' <summary>Enumeration of ProGrid cell alignment methods.</summary>
    Public Enum ProGridAlignmentStyles
        Left = 0
        Center = 1
        Right = 2
    End Enum

    ''' <summary>A Style specification for a given data column.</summary>
    Public Class ProGridStyle
        Public ProStyleType As ProGridStyleTypes = ProGridStyleTypes.Freeform
        Public ProDecimalPlaces As Integer = 0
        Public ProMinValue As Object = Nothing
        Public ProMaxValue As Object = Nothing
        Public ProMaxStringLength As Integer = 0
        Public ProFormatString As String = ""
        Public ProOverrideString As String = ""
        Public ProDataFileExtension As String = ""
        Public ProDropdown As DataTable = Nothing
        Public ProEditable As Boolean = True
        Public ProVisible As Boolean = True
        Public ProSizingMethod As ProGridSizingMethods = ProGridSizingMethods.SampledDataAndHeader
        Public ProAlignmentMethod As ProGridAlignmentStyles = ProGridAlignmentStyles.Left
        ''' <summary>
        ''' Initializes a new data column Style.
        ''' </summary>
        ''' <param name="Style">The ProGridStyleTypes enumeration.</param>
        ''' <param name="Visible">True if the data column is visible in the ProGrid.</param>
        ''' <param name="Editable">True if the data column is editable.</param>
        ''' <param name="DecimalPlaces">For Numeric styles, sets the decimal places to display.</param>
        ''' <param name="MinValue">For Numeric styles, sets the minimum allowed value.</param>
        ''' <param name="MaxValue">For Numeric styles, sets the maximum allowed value.</param>
        ''' <param name="MaxStringLength">For String styles, sets the maximum character count.</param>
        ''' <param name="Dropdown">For Dropdown styles, provides the selection list in a 1 or 2 column datatable.</param>
        ''' <param name="FormatString">A custom format string to apply to the column.</param>
        ''' <param name="OverrideString">Hides cell contents of the data column and displays the specified text.</param>
        ''' <param name="DataFileExtension">Sets the default file type extension to display contents in an external viewer.</param>
        ''' <param name="SizingMethod">Sets the ProGridSizingMethods enumeration for initial column sizing.</param>
        ''' <param name="AlignmentMethod">Sets the ProGridAlignmentMethods enumeration for column text alignment.</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal Style As ProGridStyleTypes, _
                    Optional ByVal Visible As Boolean = True, _
                    Optional ByVal Editable As Boolean = True, _
                    Optional ByVal DecimalPlaces As Integer = Nothing, _
                    Optional ByVal MinValue As Object = Nothing, _
                    Optional ByVal MaxValue As Object = Nothing, _
                    Optional ByVal MaxStringLength As Integer = 0, _
                    Optional ByVal Dropdown As DataTable = Nothing, _
                    Optional ByVal FormatString As String = "", _
                    Optional ByVal OverrideString As String = "", _
                    Optional ByVal DataFileExtension As String = "", _
                    Optional ByVal SizingMethod As ProGridSizingMethods = ProGridSizingMethods.SampledDataAndHeader, _
                    Optional ByVal AlignmentMethod As ProGridAlignmentStyles = ProGridAlignmentStyles.Left)
            ProStyleType = Style
            ProVisible = Visible
            ProEditable = Editable
            ProDecimalPlaces = DecimalPlaces
            ProMinValue = MinValue
            ProMaxValue = MaxValue
            ProMaxStringLength = MaxStringLength
            ProDropdown = Dropdown
            ProFormatString = FormatString.Trim
            ProOverrideString = OverrideString.Trim
            ProDataFileExtension = DataFileExtension.Trim
            ProSizingMethod = SizingMethod
            ProAlignmentMethod = AlignmentMethod
        End Sub
    End Class

    ''' <summary>
    ''' Sets the display style of a data column.
    ''' </summary>
    ''' <param name="ColumnName">The name of the data table column to apply the Style.</param>
    ''' <param name="Style">A ProGridStyleTypes class specifying the column display style.</param>
    ''' <remarks>Note that styles conflicting with the underlying data type will be ignored.</remarks>
    Public Sub StyleSet(ByVal ColumnName As String, ByVal Style As ProGridStyle)
        Try
            ' Set default values
            Select Case Style.ProStyleType
                Case ProGridStyleTypes.Freeform, ProGridStyleTypes.LowerCase, ProGridStyleTypes.UpperCase, ProGridStyleTypes.TitleCase
                    Style.ProMinValue = Nothing
                    Style.ProMaxValue = Nothing
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.ZipCode
                    If Style.ProMaxStringLength = 0 Then Style.ProMaxStringLength = 10
                    Style.ProMinValue = Nothing
                    Style.ProMaxValue = Nothing
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.PhoneNumber
                    If Style.ProMaxStringLength = 0 Then Style.ProMaxStringLength = 14
                    Style.ProMinValue = Nothing
                    Style.ProMaxValue = Nothing
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.SSN
                    If Style.ProMaxStringLength = 0 Then Style.ProMaxStringLength = 11
                    Style.ProMinValue = Nothing
                    Style.ProMaxValue = Nothing
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.Percent
                    If Style.ProDecimalPlaces = Nothing Then Style.ProDecimalPlaces = 2
                    If Style.ProMinValue = Nothing Then Style.ProMinValue = 0
                    If Style.ProMaxValue = Nothing Then Style.ProMaxValue = 100
                    If Not IsNumeric(Style.ProMinValue) Then Style.ProMinValue = Nothing
                    Style.ProMinValue = Val(Style.ProMinValue)
                    If Not IsNumeric(Style.ProMaxValue) Then Style.ProMaxValue = Nothing
                    Style.ProMaxValue = Val(Style.ProMaxValue)
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.Currency
                    If Style.ProDecimalPlaces = Nothing Then Style.ProDecimalPlaces = 2
                    If Style.ProMinValue IsNot Nothing And Not IsNumeric(Style.ProMinValue) Then Style.ProMinValue = Nothing
                    If Style.ProMinValue IsNot Nothing Then Style.ProMinValue = Val(Style.ProMinValue)
                    If Style.ProMaxValue IsNot Nothing And Not IsNumeric(Style.ProMaxValue) Then Style.ProMaxValue = Nothing
                    If Style.ProMaxValue IsNot Nothing Then Style.ProMaxValue = Val(Style.ProMaxValue)
                    Style.ProFormatString = ""
                    Style.ProAlignmentMethod = ProGridAlignmentStyles.Right
                Case ProGridStyleTypes.DateOnly
                    If Style.ProMaxStringLength = 0 Then Style.ProMaxStringLength = 10
                    If Style.ProMinValue IsNot Nothing And Not IsDate(Style.ProMinValue) Then Style.ProMinValue = Nothing
                    If Style.ProMinValue IsNot Nothing Then Style.ProMinValue = Date.Parse(Style.ProMinValue)
                    If Style.ProMaxValue IsNot Nothing And Not IsDate(Style.ProMaxValue) Then Style.ProMaxValue = Nothing
                    If Style.ProMaxValue IsNot Nothing Then Style.ProMaxValue = Date.Parse(Style.ProMaxValue)
                    If Style.ProFormatString = "" Then Style.ProFormatString = _DefaultDateFormat
                    If Not IsValidDateFormat(Style.ProFormatString) Then Style.ProFormatString = _DefaultDateFormat
                Case ProGridStyleTypes.TimeOnly
                    If Style.ProMaxStringLength = 0 Then Style.ProMaxStringLength = 8
                    If Style.ProMinValue IsNot Nothing And Not IsDate("1/1/2000 " + Style.ProMinValue) Then Style.ProMinValue = Nothing
                    If Style.ProMinValue IsNot Nothing Then Style.ProMinValue = Date.Parse("1/1/2000 " + Style.ProMinValue)
                    If Style.ProMaxValue IsNot Nothing And Not IsDate("1/1/2000 " + Style.ProMaxValue) Then Style.ProMaxValue = Nothing
                    If Style.ProMaxValue IsNot Nothing Then Style.ProMaxValue = Date.Parse("1/1/2000 " + Style.ProMaxValue)
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.Numeric
                    If Style.ProDecimalPlaces = Nothing Then Style.ProDecimalPlaces = 0
                    If Style.ProMinValue IsNot Nothing And Not IsNumeric(Style.ProMinValue) Then Style.ProMinValue = Nothing
                    If Style.ProMinValue IsNot Nothing Then Style.ProMinValue = Val(Style.ProMinValue)
                    If Style.ProMaxValue IsNot Nothing And Not IsNumeric(Style.ProMaxValue) Then Style.ProMaxValue = Nothing
                    If Style.ProMaxValue IsNot Nothing Then Style.ProMaxValue = Val(Style.ProMaxValue)
                Case ProGridStyleTypes.Dropdown
                    Style.ProMinValue = Nothing
                    Style.ProMaxValue = Nothing
                    If Style.ProDropdown Is Nothing OrElse (Style.ProDropdown.Columns.Count <> 1 AndAlso Style.ProDropdown.Columns.Count <> 2) OrElse Style.ProDropdown.Rows.Count = 0 Then
                        Style = New ProGridStyle(ProGridStyleTypes.Freeform)
                    End If
                    Style.ProFormatString = ""
                Case ProGridStyleTypes.CheckBox
                    Style.ProAlignmentMethod = ProGridAlignmentStyles.Center
            End Select

            If ProGridStyles.ContainsKey(ColumnName) Then
                ProGridStyles(ColumnName) = Style
            Else
                ProGridStyles.Add(ColumnName, Style)
            End If

        Catch ex As Exception
            Throw New Exception("StyleSet: " + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Returns the display style of a data column.
    ''' </summary>
    ''' <param name="ColumnName">The name of the data table column to apply the Style.</param>
    ''' <returns>A ProGridStyle.</returns>
    ''' <remarks>Note that incompatible style settings might be overridden.</remarks>
    Public Function StyleGet(ByVal ColumnName As String) As ProGridStyle
        Try
            Dim Style As ProGridStyle
            If ProGridStyles.ContainsKey(ColumnName) Then
                ' Get the existing Style
                Style = ProGridStyles(ColumnName)
                ' Make sure the style is valid for the underlying data type
                Style = ValidateColumnStyle(ColumnName, Style)
            Else
                ' Create a new Style
                Style = StyleGetDefault(ColumnName)
                ProGridStyles.Add(ColumnName, Style)
            End If

            If dt Is Nothing OrElse Not dt.Columns.Contains(ColumnName) Then Return Style

            ' If a file type is given, ensure that an override string is provided
            If Style.ProDataFileExtension <> "" AndAlso Style.ProOverrideString = "" Then Style.ProOverrideString = "<Data>"

            ' Force style to hide autoincrement if necessary
            If EnableIdentityHide AndAlso dt.Columns(ColumnName).AutoIncrement Then Style.ProVisible = False

            ' Force style to readonly if necessary
            If dt.Columns(ColumnName).ReadOnly OrElse Style.ProOverrideString <> "" Then Style.ProEditable = False

            Return Style

        Catch ex As Exception
            Throw New Exception("StyleGet: " + ex.Message)
        End Try
    End Function

    ' Ensure that style is compatible with underlying data type
    Private Function ValidateColumnStyle(ByVal ColumnName As String, ByVal Style As ProGridStyle) As ProGridStyle

        If dt Is Nothing OrElse Not dt.Columns.Contains(ColumnName) Then Return Style
        If Style.ProStyleType = ProGridStyleTypes.Freeform Then Return Style

        If IsStringColumn(ColumnName) Then Return Style

        If IsBooleanColumn(ColumnName) Then
            Select Case Style.ProStyleType
                Case ProGridStyleTypes.Freeform, ProGridStyleTypes.Dropdown, ProGridStyleTypes.CheckBox
                    Return Style
            End Select
        End If

        If IsNumericColumn(ColumnName) Then
            Select Case Style.ProStyleType
                Case ProGridStyleTypes.Numeric, ProGridStyleTypes.Currency, ProGridStyleTypes.SSN, ProGridStyleTypes.ZipCode, ProGridStyleTypes.PhoneNumber, ProGridStyleTypes.Percent, ProGridStyleTypes.Dropdown, ProGridStyleTypes.CheckBox
                    Return Style
            End Select
        End If

        If IsDateColumn(ColumnName) Then
            Select Case Style.ProStyleType
                Case ProGridStyleTypes.DateOnly, ProGridStyleTypes.TimeOnly
                    Return Style
            End Select
        End If

        Return StyleGetDefault(ColumnName)

    End Function

    Private Function StyleGetDefault(ByVal ColumnName As String) As ProGridStyle

        If dt Is Nothing OrElse Not dt.Columns.Contains(ColumnName) Then Return New ProGridStyle(ProGridStyleTypes.Freeform)

        If IsStringColumn(ColumnName) Then
            Return New ProGridStyle(ProGridStyleTypes.Freeform)
        End If

        If IsDateColumn(ColumnName) Then
            Return New ProGridStyle(ProGridStyleTypes.Freeform)
        End If

        If IsBooleanColumn(ColumnName) Then
            Return New ProGridStyle(ProGridStyleTypes.CheckBox)
        End If

        If IsNumericColumn(ColumnName) Then
            Dim Style As ProGridStyle = New ProGridStyle(ProGridStyleTypes.Numeric)
            If IsDecimalColumn(ColumnName) Then Style.ProDecimalPlaces = 2
            Return (Style)
        End If

        If IsTextColumn(ColumnName) Then
            Return New ProGridStyle(ProGridStyleTypes.Freeform, OverrideString:="<Text>", datafileextension:="txt", Editable:=False)
        End If

        If IsBlobColumn(ColumnName) Then
            Return New ProGridStyle(ProGridStyleTypes.Freeform, OverrideString:="<Object>", Editable:=False)
        End If

        Return New ProGridStyle(ProGridStyleTypes.Freeform)

    End Function

    ''' <summary>
    ''' Returns the display style of a data column.
    ''' </summary>
    ''' <param name="GridCol">The index of the data table column.</param>
    ''' <returns>A ProGridStyle.</returns>
    Public Function StyleGet(ByVal GridCol As Integer) As ProGridStyle
        Try
            If GridCol < 0 OrElse GridCol >= ColumnCount Then Return Nothing
            Return StyleGet(dt.Columns(GridCol).ColumnName)

        Catch ex As Exception
            Throw New Exception("StyleGet: " + ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Returns the display style of a data column.
    ''' </summary>
    ''' <param name="Column">The name of the data table column.</param>
    ''' <returns>A ProGridStyle.</returns>
    Public Function StyleGet(ByVal Column As DataColumn) As ProGridStyle
        Try
            If Not dt.Columns.Contains(Column.ColumnName) Then Return Nothing
            Return StyleGet(Column.ColumnName)

        Catch ex As Exception
            Throw New Exception("StyleGet: " + ex.Message)
        End Try
    End Function

#End Region

#Region "User Settings"

    ''' <summary>Enumeration of Add and Delete event statuses.</summary>
    Public Enum ProGridSaveActions
        ''' <summary>Tells the ProGrid to commit the requested Add or Delete.</summary>
        CommitChanges
        ''' <summary>Tells the ProGrid to cancel the requested Add or Delete.</summary>
        UndoChanges
    End Enum

    ''' <summary>Returns a reference to the table assigned to the grid.</summary>
    Public ReadOnly Property GridTable() As DataTable
        Get
            Return dt
        End Get
    End Property

    ''' <summary>Get the component version number.</summary>
    <System.ComponentModel.Browsable(True), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)> _
    Public ReadOnly Property Version() As String
        Get
            Return Me.ProductVersion
        End Get

    End Property

    Private _PrintTitle As String = "ProGrid Report"
    ''' <summary>Sets the default name to appear on printed reports.</summary>
    Public Property PrintTitle() As String
        Get
            Return _PrintTitle
        End Get
        Set(ByVal Title As String)
            _PrintTitle = Title.Trim
        End Set
    End Property

    Private _DefaultDateFormat As String = "M/d/yyyy"
    ''' <summary>Sets the default date format to be used unless overridden by a Style setting.</summary>
    Public Property DefaultDateFormat() As String
        Get
            Return _DefaultDateFormat
        End Get
        Set(ByVal DateFormat As String)
            If IsValidDateFormat(DateFormat) Then _DefaultDateFormat = DateFormat Else Throw New Exception("DefaultDateFormat: An invalid date format was passed in.")
        End Set
    End Property

    Private _CellTextMaxLength As Integer = 200
    ''' <summary>Sets the maximum length string to display in-cell.</summary>
    Public Property CellTextMaxLength() As String
        Get
            Return _CellTextMaxLength
        End Get
        Set(ByVal MaxLength As String)
            _CellTextMaxLength = MaxLength
        End Set
    End Property

    Private _EnableRefreshButton As Boolean = True
    ''' <summary>True to enable the Refresh button.</summary>
    Public Property EnableRefreshButton() As Boolean
        Get
            Return _EnableRefreshButton
        End Get
        Set(ByVal RefreshButtonEnabled As Boolean)
            _EnableRefreshButton = RefreshButtonEnabled
            btnRefresh.Visible = _EnableRefreshButton
        End Set
    End Property

    Private _EnableIdentityHide As Boolean = True
    ''' <summary>True to hide Identity columns in the grid.</summary>
    Public Property EnableIdentityHide() As Boolean
        Get
            Return _EnableIdentityHide
        End Get
        Set(ByVal IdentityHideEnabled As Boolean)
            _EnableIdentityHide = IdentityHideEnabled
        End Set
    End Property

    Private _EnableEditing As Boolean = False
    ''' <summary>True to enable editing for editable data columns.</summary>
    Public Property EnableEditing() As Boolean
        Get
            Return _EnableEditing
        End Get
        Set(ByVal EnableEditing As Boolean)
            _EnableEditing = EnableEditing
            btnAdd.Visible = (_EnableAddButton AndAlso EnableEditing)
            btnDelete.Visible = (_EnableDeleteButton AndAlso EnableEditing)
            sepAdd.Visible = (btnAdd.Visible OrElse btnDelete.Visible)
        End Set
    End Property

    Private _EnableAddButton As Boolean = True
    ''' <summary>True to enable the Add button.</summary>
    Public Property EnableAddButton() As Boolean
        Get
            Return _EnableAddButton
        End Get
        Set(ByVal EnableAddButton As Boolean)
            _EnableAddButton = EnableAddButton
            btnAdd.Visible = (_EnableAddButton AndAlso EnableEditing)
            sepAdd.Visible = (btnAdd.Visible OrElse btnDelete.Visible)
        End Set
    End Property

    Private _EnableDeleteButton As Boolean = True
    ''' <summary>True to enable the Delete button.</summary>
    Public Property EnableDeleteButton() As Boolean
        Get
            Return _EnableDeleteButton
        End Get
        Set(ByVal DeleteButtonEnabled As Boolean)
            _EnableDeleteButton = DeleteButtonEnabled
            btnDelete.Visible = (_EnableDeleteButton AndAlso EnableEditing)
            sepAdd.Visible = (btnAdd.Visible OrElse btnDelete.Visible)
        End Set
    End Property

    Private _EnableOptionsButton As Boolean = True
    ''' <summary>True to enable the Options Menu button.</summary>
    Public Property EnableOptionsButton() As Boolean
        Get
            Return _EnableOptionsButton
        End Get
        Set(ByVal OptionsButtonEnabled As Boolean)
            _EnableOptionsButton = OptionsButtonEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableOptionsFind As Boolean = True
    ''' <summary>True to enable the Find items in the Options Menu.</summary>
    Public Property EnableOptionsFind() As Boolean
        Get
            Return _EnableOptionsFind
        End Get
        Set(ByVal OptionsFindEnabled As Boolean)
            _EnableOptionsFind = OptionsFindEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableOptionsSort As Boolean = True
    ''' <summary>True to enable the Sort item in the Options Menu.</summary>
    Public Property EnableOptionsSort() As Boolean
        Get
            Return _EnableOptionsSort
        End Get
        Set(ByVal OptionsSortEnabled As Boolean)
            _EnableOptionsSort = OptionsSortEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableFiltering As Boolean = True
    ''' <summary>True to enable the Filter item in the Header context menu.</summary>
    Public Property EnableFiltering() As Boolean
        Get
            Return _EnableFiltering
        End Get
        Set(ByVal FilterEnabled As Boolean)
            _EnableFiltering = FilterEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableOptionsCopy As Boolean = True
    ''' <summary>True to enable the Copy item in the Options Menu.</summary>
    Public Property EnableOptionsCopy() As Boolean
        Get
            Return _EnableOptionsCopy
        End Get
        Set(ByVal OptionsCopyEnabled As Boolean)
            _EnableOptionsCopy = OptionsCopyEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableOptionsPrint As Boolean = True
    ''' <summary>True to enable the Print item in the Options Menu.</summary>
    Public Property EnableOptionsPrint() As Boolean
        Get
            Return _EnableOptionsPrint
        End Get
        Set(ByVal OptionsPrintEnabled As Boolean)
            _EnableOptionsPrint = OptionsPrintEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableOptionsExport As Boolean = True
    ''' <summary>True to enable the Export item in the Options Menu.</summary>
    Public Property EnableOptionsExport() As Boolean
        Get
            Return _EnableOptionsExport
        End Get
        Set(ByVal OptionsExportEnabled As Boolean)
            _EnableOptionsExport = OptionsExportEnabled
            ConfigureOptions()
        End Set
    End Property

    Private _EnableEditHighlighting As Boolean = True
    ''' <summary>True to enable the highlighting of editable cells.</summary>
    Public Property EnableEditHighlighting() As Boolean
        Get
            Return _EnableEditHighlighting
        End Get
        Set(ByVal EditHighlightingEnabled As Boolean)
            _EnableEditHighlighting = EditHighlightingEnabled
            ctxEditColor.Visible = (_EnableColorAdjustment AndAlso _EnableEditHighlighting)
        End Set
    End Property

    Private _EnableInvalidCellHandling As ProGridInvalidMethods = ProGridInvalidMethods.MarkAndShowTip
    ''' <summary>True to enable the marking of out of range cell values.</summary>
    Public Property EnableInvalidCellHandling() As ProGridInvalidMethods
        Get
            Return _EnableInvalidCellHandling
        End Get
        Set(ByVal InvalidHandlingMethod As ProGridInvalidMethods)
            _EnableInvalidCellHandling = InvalidHandlingMethod
        End Set
    End Property

    Private _EnableFullRowSelection As Boolean
    ''' <summary>True to highlight the entire row in horizontal mode.</summary>
    Public Property EnableFullRowSelection() As Boolean
        Get
            Return _EnableFullRowSelection
        End Get
        Set(ByVal FullRowSelectionEnabled As Boolean)
            _EnableFullRowSelection = FullRowSelectionEnabled
        End Set
    End Property

    Private _EnableColorAdjustment As Boolean
    ''' <summary>True to enable user color adjustment menu items.</summary>
    Public Property EnableColorAdjustment() As Boolean
        Get
            Return _EnableColorAdjustment
        End Get
        Set(ByVal ColorAdjustmentEnabled As Boolean)
            _EnableColorAdjustment = ColorAdjustmentEnabled
            ctxColorSep.Visible = _EnableColorAdjustment
            ctxHighColor.Visible = _EnableColorAdjustment
            ctxEditColor.Visible = (_EnableColorAdjustment AndAlso _EnableEditHighlighting)
        End Set
    End Property
    Public ColorText As Color
    Public ColorLine As Color
    Public ColorCell As Color
    Public ColorCellEditable As Color
    Public ColorHeader As Color
    Public ColorCellSelected As Color
    Public ColorInvalid As Color
    Public ColorHeaderSeparator As Color
    Public ColorSizerBar As Color

    Private Sub ConfigureOptions()

        mnuOptions.Visible = (EnableOptionsButton AndAlso (EnableOptionsFind OrElse EnableOptionsSort OrElse EnableOptionsCopy OrElse EnableOptionsPrint OrElse EnableOptionsExport))
        mnuOptions.Enabled = GetRowCount(dt)

        If Not mnuOptions.Visible OrElse Not mnuOptions.Enabled Then Exit Sub

        mnuFind.Visible = EnableOptionsFind
        mnuFind.Enabled = (CurOrientation = ProGridOrienations.Horizontal)
        mnuFindNext.Visible = EnableOptionsFind
        mnuFindNext.Enabled = (CurOrientation = ProGridOrienations.Horizontal)
        mnuFindSep.Visible = EnableOptionsFind

        mnuSort.Visible = EnableOptionsSort
        mnuSort.Enabled = (CurOrientation = ProGridOrienations.Horizontal)
        mnuSortSep.Visible = EnableOptionsSort

        mnuCopyGrid.Visible = EnableOptionsCopy
        mnuPrint.Visible = EnableOptionsPrint
        mnuExport.Visible = EnableOptionsExport

    End Sub

#End Region

#Region "Initialization Routines"

    ''' <summary>Initializes a new ProGrid instance.</summary>
    Public Sub New()
        Try
            Cursor = Cursors.WaitCursor

            ' This call is required by the designer.
            InitializeComponent()
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)

            ' Create an internal table for vertical display
            dtVert = New DataTable
            dtVert.Columns.Add("GridColName", GetType(System.String))
            dtVert.Columns.Add("GridData", GetType(System.Object))
            dtVert.Columns.Add("GridColIndex", GetType(System.Int32))

            ' Initialize
            Me.DoubleBuffered = True
            editor.Font = CurFont
            editor.AutoSize = False
            calendar.Font = CurFont
            combo.Font = CurFont

            ColorText = Color.Black
            ColorLine = Color.Gray
            ColorCell = Color.White
            ColorCellEditable = Color.FromArgb(255, 255, 255, 170)
            ColorCellSelected = Color.Aquamarine
            ColorHeader = Color.FromArgb(222, 222, 222)
            ColorHeaderSeparator = Color.FromArgb(200, 200, 200)
            ColorInvalid = Color.IndianRed
            ColorSizerBar = Color.FromArgb(160, 160, 160)
            DLLPath = System.Reflection.Assembly.GetExecutingAssembly().Location 'System.AppDomain.CurrentDomain.BaseDirectory()

            ' Draw the blank control
            InitGraphics()
            GridClear()

        Catch ex As Exception
            Throw New Exception("New: " + ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' Displays a datatable in the ProGrid.
    ''' </summary>
    ''' <param name="dtGrid">The data table to display and update.</param>
    ''' <param name="Orientation">The initial ProGridOrientation.</param>
    ''' <remarks>Include the schema in your data table if possible so that ProGrid can apply data constraints.</remarks>
    Public Sub GridShow(ByRef dtGrid As DataTable, Optional ByVal Orientation As ProGridOrienations = ProGridOrienations.Automatic)
        Try
            Cursor = Cursors.WaitCursor

            ' Make sure there are columns to display
            dt = dtGrid
            If EnableFiltering AndAlso Not EnableEditing Then dtUnfiltered = dtGrid.Copy Else dtUnfiltered = Nothing
            If dt Is Nothing OrElse ColumnCount = 0 Then
                Throw New Exception("ProGridShow: No columns in data grid.")
            End If
            If VisibleColumnCount() = 0 Then
                Throw New Exception("ProGridShow: No visible columns in data grid.")
            End If

            ' Initialize display settings
            Redrawing = True
            FirstHorzDisplay = True
            CurFont = Me.Font
            CurFontBold = New Font(CurFont.FontFamily, CurFont.Size, FontStyle.Bold)
            CheckFont = New Font("Arial Unicode MS", CurFont.Size)
            CurFontUnderline = New Font(CurFont.FontFamily, CurFont.Size, FontStyle.Underline)
            editor.Font = CurFont
            calendar.Font = CurFont
            combo.Font = CurFont
            TextBrush = New SolidBrush(ColorText)
            LinePen = New Pen(New SolidBrush(ColorLine))
            HeaderBrush = New SolidBrush(ColorHeader)
            SelectBrush = New SolidBrush(ColorCellSelected)
            InvalidPen = New Pen(ColorInvalid)
            picSizer.BackColor = ColorSizerBar
            lblTip.ForeColor = ColorInvalid

            RowHeight = CurFont.Height + 8
            vsb.Visible = True
            lblRecord.Width = Me.CreateGraphics.MeasureString(RecordCount.ToString + " of " + RecordCount.ToString, lblRecord.Font).Width
            Dim EditColor As Color
            If EnableEditing AndAlso EnableEditHighlighting Then
                EditColor = ColorCellEditable
            Else
                EditColor = ColorCell
            End If
            EditBrush = New SolidBrush(EditColor)
            lblTip.Visible = False

            ' Determine the starting orientation
            CurOrientation = Orientation
            If CurOrientation = ProGridOrienations.Automatic Then
                If RecordCount < 2 Then CurOrientation = ProGridOrienations.Vertical Else CurOrientation = ProGridOrienations.Horizontal
            End If

            ' Draw the grid
            CurCellRow = -1
            CurCellCol = -1
            CurGridRow = -1
            CurGridCol = -1
            ClearSorts()
            DrawGrid(FullRedraw:=True)
            UpdateStatus()

            ' Select the default cell
            If GetRowCount(dt) > 0 Then
                CellSelect(0, GetFirstVisibleColumn())
            End If

            Redrawing = False

        Catch ex As Exception
            Throw
        Finally
            Me.Refresh()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function VisibleColumnCount() As Integer
        If ColumnCount = 0 Then Return 0

        Dim Count As Integer = 0
        For Each c As DataColumn In dt.Columns
            If StyleGet(c).ProVisible Then Count += 1
        Next
        Return Count

    End Function

    Private Function GetFirstVisibleColumn() As Integer
        If ColumnCount = 0 Then Return -1

        Dim Count As Integer = 0
        For ColIndex As Integer = 0 To ColumnCount - 1
            If StyleGet(ColIndex).ProVisible Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetNextVisibleColumn(Optional ByVal FromCol As Integer = -1) As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1
        If FromCol = -1 Then FromCol = CurGridCol

        Dim Count As Integer = 0
        For ColIndex As Integer = FromCol + 1 To ColumnCount - 1
            If ColDefs(ColIndex).Visible Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetPrevVisibleColumn(Optional ByVal FromCol As Integer = -1) As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1
        If FromCol = -1 Then FromCol = CurGridCol

        Dim Count As Integer = 0
        For ColIndex As Integer = FromCol - 1 To 0 Step -1
            If ColDefs(ColIndex).Visible Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetLastVisibleColumn() As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1

        Dim Count As Integer = 0
        For ColIndex As Integer = ColumnCount - 1 To 0 Step -1
            If StyleGet(ColIndex).ProVisible Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetFirstDisplayedColumn() As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1

        Dim Count As Integer = 0
        For ColIndex As Integer = 0 To ColumnCount - 1
            If ColDefs(ColIndex).Visible AndAlso ColDefs(ColIndex).Displayed Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetNextDisplayedColumn(Optional ByVal FromCol As Integer = -1) As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1
        If FromCol = -1 Then FromCol = CurGridCol

        Dim Count As Integer = 0
        For ColIndex As Integer = FromCol + 1 To ColumnCount - 1
            If ColDefs(ColIndex).Visible AndAlso ColDefs(ColIndex).Displayed Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetPrevDisplayedColumn(Optional ByVal FromCol As Integer = -1) As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1
        If FromCol = -1 Then FromCol = CurGridCol

        Dim Count As Integer = 0
        For ColIndex As Integer = FromCol - 1 To 0 Step -1
            If ColDefs(ColIndex).Visible AndAlso ColDefs(ColIndex).Displayed Then Return ColIndex
        Next
        Return -1

    End Function

    Private Function GetLastDisplayedColumn() As Integer
        If CurOrientation = ProGridOrienations.Vertical Then Return 1
        If ColumnCount = 0 Then Return -1

        Dim Count As Integer = 0
        For ColIndex As Integer = ColumnCount - 1 To 0 Step -1
            If ColDefs(ColIndex).Visible AndAlso ColDefs(ColIndex).Displayed Then Return ColIndex
        Next
        Return -1

    End Function

#End Region

#Region "Base Operations"

    Private Sub BaseLayout()
        If CurOrientation = ProGridOrienations.Horizontal Then
            BaseLayoutHoriz()
        Else
            BaseLayoutVert()
        End If
    End Sub

    Private Sub BaseLayoutHoriz()

        ' Header
        pnlHeader.Left = 0
        pnlHeader.Top = tb.Height
        pnlHeader.Height = DefaultHeaderHeight

        ' Vertical Scroll Bar
        vsb.Left = Me.ClientSize.Width - vsb.Width
        vsb.Top = tb.Height
        vsb.Height = Me.ClientSize.Height - vsb.Top - hsb.Height

        ' Grid picturebox
        pic.Left = 0
        pic.Top = tb.Height + pnlHeader.Height
        pic.Height = Me.ClientSize.Height - pic.Top - hsb.Height
        DisplayWidth = Me.ClientSize.Width - vsb.Width
        pic.Width = Me.ClientSize.Width - vsb.Width

        ' Sizer
        picSizer.Top = pic.Top
        picSizer.Width = 2
        picSizer.Height = pic.Height
        picSizer.Visible = False

        ' Horizontal Scroll Bar
        hsb.Left = 0
        hsb.Top = pic.Top + pic.Height
        hsb.Width = Me.ClientSize.Width - vsb.Width
        hsb.Visible = True

    End Sub

    Private Sub BaseLayoutVert()

        ' Header
        pnlHeader.Visible = False

        ' Vertical Scroll Bar
        vsb.Left = Me.ClientSize.Width - vsb.Width
        vsb.Top = tb.Height
        vsb.Height = Me.ClientSize.Height - vsb.Top - hsb.Height

        ' Grid picturebox
        pic.Left = 0
        pic.Top = tb.Height
        pic.Height = Me.ClientSize.Height - pic.Top
        DisplayWidth = Me.ClientSize.Width - vsb.Width
        pic.Width = Me.ClientSize.Width - vsb.Width

        ' Sizer
        picSizer.Visible = False

        ' Horizontal Scroll Bar
        hsb.Visible = False

    End Sub

#End Region

#Region "Header Operations"

    Private Sub HeaderChangeLayout()
        HeaderRecalcPositions()
        HeaderRedraw()
        HorizontalScrollbarUpdate()
    End Sub

    Sub HeaderRebuildControls(ByVal HeaderColumns As Integer)
        Try

            ReDim ColDefs(HeaderColumns - 1)

            For ColIndex = 0 To HeaderColumns - 1

                ' Set the default width
                ColDefs(ColIndex).Width = DefaultColWidth

                ' Set visibility for the column
                Dim IsVisible As Boolean = True
                If CurOrientation = ProGridOrienations.Horizontal Then
                    Dim Style As ProGridStyle = StyleGet(ColIndex)
                    IsVisible = Style.ProVisible
                    ColDefs(ColIndex).Visible = IsVisible
                    If Not ColDefs(ColIndex).Visible Then ColDefs(ColIndex).Width = 0
                End If

                ' Get controls
                Dim btn As PictureBox = CreateButton(ColIndex)
                Dim spl As PictureBox = CreateSplitter(ColIndex)

                ' Configure button
                btn.Top = 0
                btn.Height = pnlHeader.Height - 2
                btn.BackColor = ColorHeader
                btn.Visible = IsVisible
                ColDefs(ColIndex).ctrlButton = btn

                ' Configure splitter
                spl.Top = 0
                spl.Height = pnlHeader.Height - 2
                spl.BackColor = ColorHeaderSeparator
                spl.Cursor = Cursors.VSplit
                spl.Visible = IsVisible
                ColDefs(ColIndex).ctrlSplit = spl

            Next

        Catch ex As Exception
            Throw New Exception("HeaderRebuildControls: " + ex.Message)
        End Try
    End Sub

    Private Function CreateButton(ByVal ColIndex As Integer) As PictureBox

        ' Return existing button if it exists
        Dim ButtonTag As String = ColIndex.ToString + "B"
        Dim btn As PictureBox
        For Each btn In pnlHeader.Controls
            If btn.Tag = ButtonTag Then Return btn
        Next

        ' Create a new button
        btn = New PictureBox
        btn.Tag = ButtonTag
        AddHandler btn.MouseUp, AddressOf HeaderColumnClicked
        pnlHeader.Controls.Add(btn)
        Return btn

    End Function

    Private Function CreateSplitter(ByVal ColIndex As Integer) As PictureBox

        ' Return existing splitter if it exists
        Dim SplitterTag As String = ColIndex.ToString + "S"
        Dim spl As PictureBox
        For Each spl In pnlHeader.Controls
            If spl.Tag = SplitterTag Then Return spl
        Next

        ' Create a new button
        spl = New PictureBox
        spl.Tag = SplitterTag
        AddHandler spl.MouseDown, AddressOf SplitterDown
        AddHandler spl.MouseMove, AddressOf SplitterMove
        AddHandler spl.MouseUp, AddressOf SplitterUp
        pnlHeader.Controls.Add(spl)
        Return spl

    End Function

    Private Function GetSplitter(ByVal ColIndex As Integer) As PictureBox

        ' Return existing button if it exists
        Dim btn As PictureBox
        For Each btn In pnlHeader.Controls
            If TypeOf btn Is PictureBox Then
                If btn.Tag = ColIndex Then Return btn
            End If
        Next

        ' Create a new button
        btn = New PictureBox
        AddHandler btn.Click, AddressOf HeaderColumnClicked
        pnlHeader.Controls.Add(btn)
        Return btn

    End Function

    Sub HeaderRecalcPositions()
        Try

            If pnlHeader.Controls.Count = 0 Then Exit Sub

            Dim NextLeftPos As Integer = 1
            For ColIndex As Integer = 0 To ColumnCount - 1

                If ColDefs(ColIndex).Visible Then
                    ColDefs(ColIndex).Left = NextLeftPos
                    ColDefs(ColIndex).Right = ColDefs(ColIndex).Left + ColDefs(ColIndex).Width
                Else
                    ColDefs(ColIndex).Left = -1
                    ColDefs(ColIndex).Right = -1
                End If

                NextLeftPos += ColDefs(ColIndex).Width

            Next

        Catch ex As Exception
            Throw New Exception("HeaderRecalcPositions: " + ex.Message)
        End Try
    End Sub

    Private Sub HeaderRedraw()

        If pnlHeader.Controls.Count = 0 Then Exit Sub

        ' Locate header controls
        Dim HeaderColumns As Integer = ColDefs.GetUpperBound(0)

        pnlHeader.SuspendLayout()
        pnlHeader.Width = ColDefs(GetLastVisibleColumn()).Right + 2
        For ColIndex As Integer = 0 To HeaderColumns

            If Not ColDefs(ColIndex).Visible Then Continue For

            ' Place the column button
            ColDefs(ColIndex).ctrlButton.Left = ColDefs(ColIndex).Left
            ColDefs(ColIndex).ctrlButton.Width = ColDefs(ColIndex).Width - 4

            ' Place the splitter
            ColDefs(ColIndex).ctrlSplit.Left = ColDefs(ColIndex).Right - 4
            ColDefs(ColIndex).ctrlSplit.Width = 4

            ' Label the button
            ColumnLabel(ColIndex)

        Next

        ' Size picture box
        DisplayWidth = Me.ClientSize.Width - vsb.Width
        If DisplayWidth > pnlHeader.Width Then DisplayWidth = pnlHeader.Width
        pic.Width = DisplayWidth
        InitGraphics()
        pnlHeader.ResumeLayout()
        pnlHeader.Visible = True

    End Sub

    Private Sub InitGraphics()
        bmap = New Bitmap(pic.Width, pic.Height)
        g = Graphics.FromImage(bmap)
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
        pic.Image = bmap
    End Sub

    Private Sub ColumnLabel(ByVal ColIndex As Integer)

        If ColIndex >= ColumnCount Then Exit Sub
        Dim btn As PictureBox = ColDefs(ColIndex).ctrlButton
        Dim Text As String = dt.Columns(ColIndex).ColumnName
        Dim Width As Integer = btn.Width
        Dim Height As Integer = btn.Height

        Dim TextBitmap As New Bitmap(Width, Height)
        Using bg = Graphics.FromImage(TextBitmap)
            If ColIndex = SortColumn AndAlso SortDirection <> ProGridSortDirection.None Then
                Dim p1 As Point
                Dim p2 As Point
                Dim p3 As Point
                If SortDirection = ProGridSortDirection.Ascending Then
                    p1 = New Point(Width - 10, 6)
                    p2 = New Point(Width - 5, 14)
                    p3 = New Point(Width - 15, 14)
                Else
                    p1 = New Point(Width - 10, 14)
                    p2 = New Point(Width - 5, 7)
                    p3 = New Point(Width - 15, 7)
                End If
                Dim gp As New System.Drawing.Drawing2D.GraphicsPath
                gp.AddLine(p1, p2)
                gp.AddLine(p2, p3)
                gp.AddLine(p3, p1)
                bg.FillPath(Brushes.DarkGray, gp)
                Text = ClipText(Text, btn.Width - 16)
            End If
            bg.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
            Dim y As Integer = btn.Height / 2 - CurFont.Height / 2 - 1
            bg.DrawString(Text, CurFont, TextBrush, 1, y)
        End Using
        btn.Image = TextBitmap

    End Sub

#End Region

#Region "Splitter Operations"

    Private Splitting As Boolean = False
    Private SplitterX As Integer
    Private SplitterColWidth As Integer
    Private SplitterColLeft As Integer

    Private Sub SplitterDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        SplitterX = e.X
        SplitterColWidth = 0
        SplitterColLeft = ColDefs(Val(sender.tag)).Left
        Dim CurrentX As Integer = sender.left + (e.X - SplitterX)

        ' Draw the sizing line
        picSizer.Left = CurrentX - hsb.Value
        picSizer.Height = pic.Height
        picSizer.BringToFront()
        picSizer.Visible = True
        Splitting = True

    End Sub

    Private Sub SplitterMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not Splitting Then Exit Sub

        ' Get the current location and see if it is within bounds
        Dim CurrentX As Integer = sender.left + (e.X - SplitterX)
        If CurrentX < SplitterColLeft + MinimumColWidth Then Exit Sub
        If CurrentX > Me.ClientSize.Width - vsb.Width - 2 + hsb.Value Then Exit Sub

        ' Move the splitter
        picSizer.Left = CurrentX - hsb.Value

        ' Set the new width
        SplitterColWidth = CurrentX - SplitterColLeft

    End Sub

    Private Sub SplitterUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not Splitting Then Exit Sub
        Splitting = False
        If SplitterColWidth = 0 Then Exit Sub

        ' Update the column width
        picSizer.Visible = False
        Dim ColIndex As Integer = Val(sender.tag)
        ColDefs(ColIndex).Width = SplitterColWidth

        ' Redisplay the header
        HeaderChangeLayout()
        FillHoriz()
        SetCurCell(CurGridRow, CurGridCol, True)
        HorizColWidthsSave()

    End Sub

#End Region

#Region "Grid Display"

    Private Sub DrawGrid(Optional ByVal FullRedraw As Boolean = False, Optional ByVal ResetVScroll As Boolean = True)

        Redrawing = True
        editor.Visible = False
        calendar.Visible = False
        combo.Visible = False

        ' We can't show 0 records in vertical mode
        If CurOrientation = ProGridOrienations.Vertical AndAlso RecordCount = 0 Then
            CurOrientation = ProGridOrienations.Horizontal
            FullRedraw = True
        End If

        Select Case CurOrientation
            Case ProGridOrienations.Vertical
                VertDrawGrid(FullRedraw, ResetVScroll)
            Case Else
                HorizDrawGrid(FullRedraw, ResetVScroll)
        End Select
        Redrawing = False

        ' Check the license
        CheckLicense()

    End Sub

    ''' <summary>
    ''' Update the grid with any changes to the underlying data table
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Populate()
        If CurOrientation = ProGridOrienations.Horizontal Then
            HorizPopulate()
        Else
            VertPopulate()
        End If
    End Sub

    Private Sub ProGrid_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Redrawing Then Exit Sub
        Try
            If CurOrientation = ProGridOrienations.Horizontal Then

                If tb.Height + pnlHeader.Height + hsb.Height + 40 >= Me.ClientSize.Height Then Exit Sub
                If vsb.Width >= Me.ClientSize.Width Then Exit Sub

                BaseLayout()
                HeaderChangeLayout()
                FillHoriz()

            Else

                If tb.Height >= Me.ClientSize.Height Then Exit Sub
                If vsb.Width >= Me.ClientSize.Width Then Exit Sub

                VertDrawGrid(FullRedraw:=True)

            End If
            CellSelect(CurGridRow, CurGridCol)

        Catch
        End Try
    End Sub

#End Region

#Region "Horizontal Scroll Bar"

    Dim Scrolling As Boolean = False
    Private Sub hsb_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsb.Scroll
        If Redrawing Then Exit Sub
        If e.Type = ScrollEventType.EndScroll Then Exit Sub
        Try
            Scrolling = True
            pnlHeader.Left = -e.NewValue
            HeaderChangeLayout()
            FillHoriz(False)
            SetCurCell(CurCellRow, CurCellCol, True)
        Catch
        Finally
            Scrolling = False
        End Try
    End Sub

    Private Sub HorizontalScrollbarUpdate()
        If pnlHeader.Width <= hsb.Width Then
            hsb.Enabled = False
        Else
            hsb.Minimum = 0
            hsb.Maximum = pnlHeader.Width
            hsb.SmallChange = DisplayWidth / 10
            hsb.LargeChange = DisplayWidth
            hsb.Enabled = True
        End If
    End Sub

#End Region

#Region "Horizontal Display"

    Private Sub HorizDrawGrid(Optional ByVal FullRedraw As Boolean = False, Optional ByVal ResetVScroll As Boolean = True)

        ' Configure vertical layout
        lblTip.Visible = False
        If FullRedraw Then
            BaseLayout()
            InitGraphics()
            HeaderRebuildControls(ColumnCount)
        End If

        ' Set column widths
        If FirstHorzDisplay Then
            For ColIndex As Integer = 0 To ColumnCount - 1
                If Not ColDefs(ColIndex).Visible Then Continue For
                ColDefs(ColIndex).Width = GetColumnWidth(dt, ColIndex)
            Next
            HorizColWidthsSave()
        Else
            If FullRedraw Then HorizColWidthsRestore()
        End If

        ' Restore any saved positioning
        If SavedPosition.IsValid Then pnlHeader.Left = SavedPosition.LastHorizontalPosition

        ' Draw the header
        HeaderChangeLayout()

        ' Draw the grid
        FillHoriz(ResetVScroll)

    End Sub

    Private Sub FillHoriz(Optional ByVal ResetVScroll As Boolean = True)

        ' Check if there are records to show
        lblTip.Visible = False
        If RecordCount = 0 Then
            pic.Image = bmap
            pic.Update()
            Exit Sub
        End If

        ' Recalculate the cell locations
        If pnlHeader.Right < DisplayWidth Then pnlHeader.Left = DisplayWidth - pnlHeader.Width
        HorizRecalculate()

        ' Draw the horizontal lines
        Dim y As Integer
        Dim x2 As Integer = CellGrid(0, GetLastVisibleColumn()).CellRec.Right
        If x2 = 0 Then x2 = pic.Right
        For row As Integer = 0 To CellRows
            y = row * RowHeight
            g.DrawLine(LinePen, 1, y, x2, y)
        Next

        ' Draw the vertical lines
        Dim x As Integer
        g.DrawLine(LinePen, 0, 0, 0, CellRows * RowHeight)
        For Col = 0 To CellCols - 1
            x = CellGrid(0, Col).CellRec.Right
            If x >= 0 AndAlso x <= DisplayWidth Then
                g.DrawLine(LinePen, x, 0, x, CellRows * RowHeight)
            End If
        Next

        ' Display the image
        pic.Invalidate()
        pic.Update()

        ' Position the cursors
        vsb.Enabled = (GetRowCount(dt) > CellRows)
        If ResetVScroll Then
            If SavedPosition.IsValid Then FirstVisibleRow = SavedPosition.LastTopRow Else FirstVisibleRow = 1
            vsb.Maximum = RecordCount
            vsb.LargeChange = CellRows
            vsb.Value = FirstVisibleRow
        End If

        ' Populate the grid
        HorizPopulate()
        FirstHorzDisplay = False

    End Sub

    Private Sub HorizRecalculate()

        CellRows = pic.Height \ RowHeight
        If CellRows > RecordCount Then CellRows = RecordCount

        CellCols = ColumnCount
        ReDim CellGrid(CellRows - 1, CellCols - 1)

        Dim StyleEditable As Boolean
        For CellCol = 0 To CellCols - 1

            ' Determine if column is editable
            StyleEditable = EnableEditing AndAlso StyleGet(CellCol).ProEditable

            ' Calculate all rows for column
            For CellRow = 0 To CellRows - 1
                CellGrid(CellRow, CellCol).CellRec.X = ColDefs(CellCol).Left + 1 + pnlHeader.Left
                CellGrid(CellRow, CellCol).CellRec.Width = ColDefs(CellCol).Width - 1
                CellGrid(CellRow, CellCol).CellRec.Y = CellRow * RowHeight + 1
                CellGrid(CellRow, CellCol).CellRec.Height = RowHeight - 1
                CellGrid(CellRow, CellCol).Editable = StyleEditable
            Next
        Next

    End Sub

    Private Sub HorizPopulate()
        lblTip.Visible = False
        Dim GridRow As Integer
        Dim RawText As String
        Dim FormattedText As String
        Dim DisplayText As String
        Dim Offset As Integer = 0
        Dim DrawRec As Rectangle
        FirstVisibleCol = -1
        Dim Style As ProGridStyle
        For CellCol = 0 To CellCols - 1

            ColDefs(CellCol).Displayed = ColDefs(CellCol).Visible AndAlso CellGrid(0, CellCol).CellRec.Right >= 1 AndAlso CellGrid(0, CellCol).CellRec.Left <= DisplayWidth
            If ColDefs(CellCol).Displayed Then

                Style = StyleGet(CellCol)
                If FirstVisibleCol = -1 Then FirstVisibleCol = CellCol

                For CellRow = 0 To CellRows - 1

                    GridRow = FirstVisibleRow + CellRow - 1
                    CellGrid(CellRow, CellCol).GridRow = GridRow
                    CellGrid(CellRow, CellCol).GridCol = CellCol
                    DrawRec = CellGrid(CellRow, CellCol).CellRec
                    RawText = ToStr(dt.Rows(GridRow)(CellCol))
                    If IsDBNull(RawText) Then FormattedText = ""
                    FormattedText = GetFormattedText(CellCol, RawText)
                    CellGrid(CellRow, CellCol).CellText = FormattedText

                    ' Make sure we cannot edit hidden data
                    DisplayText = GetDisplayText(CellRow, CellCol)
                    If DisplayText = "<Data>" OrElse DisplayText = "<Text>" Then CellGrid(CellRow, CellCol).Editable = False

                    DrawCell(CellRow, CellCol)

                Next
            End If
        Next
        LastVisibleRow = CellRows - 1

        pic.Invalidate(False)
        pic.Update()
        pic.Visible = True
    End Sub

    Private HorizColWidths() As Integer

    Private Sub HorizColWidthsSave()
        ReDim HorizColWidths(ColumnCount)
        For ColIndex As Integer = 0 To ColumnCount - 1
            HorizColWidths(ColIndex) = ColDefs(ColIndex).Width
        Next
    End Sub

    Private Sub HorizColWidthsRestore()
        If HorizColWidths Is Nothing Then Exit Sub
        For ColIndex As Integer = 0 To ColumnCount - 1
            ColDefs(ColIndex).Width = HorizColWidths(ColIndex)
        Next
    End Sub

#End Region

#Region "Vertical Display"

    Dim dtVert As DataTable = Nothing

    Private Sub VertDrawGrid(Optional ByVal FullRedraw As Boolean = False, Optional ByVal ResetVScroll As Boolean = True)

        ' No records to show
        lblTip.Visible = False
        If RecordCount = 0 Then
            pic.Image = bmap
            pic.Update()
            Exit Sub
        End If

        ' Make sure a row is selected
        If CurGridRow < 0 OrElse CurGridRow >= GetRowCount(dt) Then CurGridRow = 0

        ' Move data to the vertical grid
        dtVert.Rows.Clear()
        If RecordCount > 0 Then
            For i As Integer = 0 To ColumnCount - 1
                If StyleGet(i).ProVisible Then
                    dtVert.Rows.Add(dt.Columns(i).ColumnName, dt.Rows(CurGridRow)(i), i)
                End If
            Next
        End If

        ' Configure vertical layout
        If FullRedraw Then
            BaseLayout()
            InitGraphics()
            HeaderRebuildControls(2)
            ColDefs(0).Left = 1
            ColDefs(0).Width = GetMaxHeaderWidth(dt)
            ColDefs(0).Right = ColDefs(0).Left + ColDefs(0).Width
            ColDefs(1).Left = ColDefs(0).Right
            ColDefs(1).Width = DisplayWidth - ColDefs(0).Width
            ColDefs(1).Right = DisplayWidth
        End If

        ' Recalculate the cell locations
        VertRecalculate()

        ' Draw the horizontal lines
        g.Clear(BackColor)
        Dim x2 As Integer = ColDefs(1).Right
        For Row = 0 To GetRowCount(dtVert)

            ' Determine the row position
            Dim y As Integer = (Row - 1) * RowHeight + RowHeight
            If y > pic.Height Then Exit For

            ' Draw the row
            g.DrawLine(LinePen, New Point(0, y), New Point(x2, y))

        Next

        ' Draw the vertical line
        g.DrawLine(LinePen, New Point(ColDefs(0).Right, 0), New Point(ColDefs(0).Right, CellRows * RowHeight))

        ' Display the image
        pic.Invalidate()
        pic.Update()

        ' Position the cursors
        vsb.Enabled = (GetRowCount(dtVert) > CellRows)
        If vsb.Enabled OrElse ResetVScroll Then
            FirstVisibleRow = 1
            vsb.Maximum = GetRowCount(dtVert)
            vsb.LargeChange = CellRows
            vsb.Value = 1
        End If

        ' Populate the grid
        VertPopulate()

    End Sub

    Private Sub VertRecalculate()

        CellRows = pic.Height \ RowHeight
        If CellRows > GetRowCount(dtVert) Then CellRows = GetRowCount(dtVert)

        CellCols = 2
        ReDim CellGrid(CellRows - 1, CellCols - 1)

        Dim ColEditable As Boolean = True
        ColDefs(0).Displayed = True
        ColDefs(1).Displayed = True

        For CellRow = 0 To CellRows - 1

            ' Calculate first column
            CellGrid(CellRow, 0).CellRec.X = 0
            CellGrid(CellRow, 0).CellRec.Width = ColDefs(0).Width + 1
            CellGrid(CellRow, 0).CellRec.Y = CellRow * RowHeight + 1
            CellGrid(CellRow, 0).CellRec.Height = RowHeight - 1
            CellGrid(CellRow, 0).Editable = False
            CellGrid(CellRow, 0).FillBrush = HeaderBrush

            ' Calculate second column
            CellGrid(CellRow, 1).CellRec.X = ColDefs(1).Left + 1
            CellGrid(CellRow, 1).CellRec.Width = DisplayWidth - ColDefs(0).Width
            CellGrid(CellRow, 1).CellRec.Y = CellRow * RowHeight + 1
            CellGrid(CellRow, 1).CellRec.Height = RowHeight - 1

        Next

    End Sub

    Private Sub VertPopulate()

        lblTip.Visible = False
        If CurGridRow = -1 Then Exit Sub

        Dim RawText As String
        Dim FormattedText As String
        Dim VertGridRow As Integer
        Dim GridColIndex As Integer
        Dim StyleEditable As Boolean
        Dim Style As ProGridStyle
        For CellRow = 0 To CellRows - 1

            VertGridRow = FirstVisibleRow + CellRow - 1
            GridColIndex = dtVert.Rows(VertGridRow)("GridColIndex")

            ' Determine if column is editable
            Style = StyleGet(GridColIndex)
            StyleEditable = EnableEditing AndAlso Style.ProEditable
            CellGrid(CellRow, 1).Editable = StyleEditable

            ' Assign the grid location
            CellGrid(CellRow, 0).GridRow = CurGridRow
            CellGrid(CellRow, 0).GridCol = -1
            CellGrid(CellRow, 1).GridRow = CurGridRow
            CellGrid(CellRow, 1).GridCol = GridColIndex

            ' Draw the header
            g.FillRectangle(HeaderBrush, CellGrid(CellRow, 0).CellRec)
            CellGrid(CellRow, 0).CellText = dtVert.Rows(VertGridRow)("GridColName")
            g.DrawString(CellGrid(CellRow, 0).CellText, CurFont, TextBrush, CellGrid(CellRow, 0).CellRec.X, CellGrid(CellRow, 0).CellRec.Y + 3)

            ' Get the data to display
            RawText = ToStr(dtVert.Rows(VertGridRow)("GridData"))
            If IsDBNull(RawText) Then FormattedText = ""
            FormattedText = GetFormattedText(CellGrid(CellRow, 0).CellText, RawText)
            CellGrid(CellRow, 1).CellText = FormattedText

            ' Draw the cell
            DrawCell(CellRow, 1)

        Next

        pic.Invalidate(False)
        pic.Update()
        pic.Visible = True

    End Sub

#End Region

#Region "Cell Display"

    ''' <summary>Raised when a new cell becomes current.</summary>
    Public Event UserSelectedCell(ByVal RowIndex As Integer, ByVal ColIndex As Integer)

    ''' <summary>Raised when a new row becomes current.</summary>
    Public Event UserSelectedRow(ByVal LastRowIndex As Integer, ByVal NewRowIndex As Integer)

    ''' <summary>Raised when the user completes editing a cell.</summary>
    Public Event UserEditedCell(ByRef EditedRow As System.Data.DataRow, ByVal EditedColIndex As Integer, ByRef SaveAction As ProGridSaveActions)

    ''' <summary>
    ''' Force closure of any active editor
    ''' </summary>
    ''' <param name="Save">False to discard any pending changes.</param>
    ''' <remarks></remarks>
    Public Sub CellEditClose(Optional ByVal Save As Boolean = True)
        Try
            ' Close any active editor
            If CurGridRow = -1 OrElse CurGridCol = -1 Then Exit Sub
            lblTip.Visible = False
            Dim NewText As Object
            If editor.Visible Then
                NewText = GetFormattedText(CurGridCol, dt.Rows(CurGridRow)(CurGridCol))
                editor.Visible = False
            ElseIf calendar.Visible Then
                NewText = GetFormattedText(CurGridCol, dt.Rows(CurGridRow)(CurGridCol))
                calendar.Visible = False
            ElseIf combo.Visible Then
                NewText = GetComboStorageValue(CurGridCol, dt.Rows(CurGridRow)(CurGridCol))
                combo.Visible = False
            ElseIf ChkEditor Then
                NewText = ToStr(dt.Rows(CurGridRow)(CurGridCol))
            Else
                Exit Sub
            End If

            ' See if the cell value has changed
            Dim OldText As String = CellGrid(CurCellRow, CurCellCol).CellText
            If OldText = NewText Then Exit Sub

            ' Confirm saving changes
            If Save Then
                Dim SaveAction As ProGridSaveActions = ProGridSaveActions.CommitChanges
                RaiseEvent UserEditedCell(dt.Rows(CurGridRow), CurGridCol, SaveAction)
                If SaveAction = ProGridSaveActions.CommitChanges Then
                    CellGrid(CurCellRow, CurCellCol).CellText = GetFormattedText(CurGridCol, NewText)
                    HighlightCell(CurCellRow, CurCellCol)
                    Exit Sub
                End If
            End If

            ' Undo changes
            dt.Rows(CurGridRow)(CurGridCol) = CellGrid(CurCellRow, CurCellCol).CellText
            HighlightCell(CurCellRow, CurCellCol)

        Finally
            pic.Focus()
        End Try
    End Sub

    Private Sub SetCurCell(ByVal CellRow As Integer, ByVal CellCol As Integer, Optional ByVal Redraw As Boolean = False)
        Try
            ' Exit if the column requested is not displayed
            If CellRows = 0 Then Exit Sub
            If Not ColDefs(CellCol).Displayed Then Exit Sub

            ' Close any active editor
            If IsInEditMode() Then CellEditClose()

            ' Clear previously selected cell
            ClearCell(CurCellRow, CurCellCol)

            ' Open editor if needed
            If EnableEditing AndAlso Not Redraw AndAlso CurCellRow = CellRow AndAlso CurCellCol = CellCol Then
                EditCell()
                Exit Sub
            End If

            ' Set the new current cell location
            CurCellRow = CellRow
            CurCellCol = CellCol

            ' Highlight the new cell
            HighlightCell(CurCellRow, CurCellCol)

            ' Set the new current grid location
            Dim loc As Cart = GetGridFromCell(New Cart(CurCellRow, CurCellCol))
            If loc Is Nothing Then Exit Sub
            Dim LastGridRow As Integer = CurGridRow
            CurGridRow = loc.Row
            CurGridCol = loc.Col

            ' Update the vertical scroll bar location
            If CurOrientation = ProGridOrienations.Horizontal Then
                vsb.Value = CurGridRow + 1
            Else
                vsb.Value = FirstVisibleRow + CurCellRow
            End If

            ' Update the status
            UpdateStatus()

            ' Notify the user that the current record has changed
            If LastGridRow <> CurGridRow Then RaiseEvent UserSelectedRow(LastGridRow, CurGridRow)
            RaiseEvent UserSelectedCell(CurGridRow, CurGridCol)

        Catch ex As Exception
            Throw New Exception("SetCurCell: " + ex.Message)
        Finally
            ' Focus on the grid so that keyboard events are captured immediately
            If Not IsInEditMode() Then pic.Focus()
        End Try
    End Sub

    Public Sub CellSelect()
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub
        CellSelect(CurGridRow, CurGridCol)
    End Sub

    ''' <summary>
    ''' Selects a cell, scrolling if necessary to make it visible.
    ''' </summary>
    ''' <param name="RowIndex">The row of the cell in the data table.</param>
    ''' <param name="ColumnName">The column name of the cell in the data table.</param>
    Public Sub CellSelect(ByVal RowIndex As Integer, ByVal ColumnName As String)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub
        If dt.Columns.Contains(ColumnName) Then
            CellSelect(RowIndex, dt.Columns(ColumnName).Ordinal)
        End If
    End Sub

    ''' <summary>
    ''' Selects a cell, scrolling if necessary to make it visible.
    ''' </summary>
    ''' <param name="RowIndex">The row of the cell in the data table.</param>
    ''' <param name="ColIndex">The column of the cell in the data table.</param>
    Public Sub CellSelect(ByVal RowIndex As Integer, ByVal ColIndex As Integer)
        Try
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub

            ' Make sure the requested coordinates are valid
            lblTip.Visible = False
            If RowIndex < 0 OrElse RowIndex > GetRowCount(dt) - 1 Then Exit Sub
            If ColIndex < 0 OrElse ColIndex > ColumnCount - 1 Then Exit Sub
            If CurOrientation = ProGridOrienations.Horizontal AndAlso Not ColDefs(ColIndex).Visible Then Exit Sub

            ' Close any active editor
            If IsInEditMode() Then CellEditClose()

            ' Select the new cell
            Dim LastGridRow As Integer = CurGridRow
            Select Case CurOrientation
                Case ProGridOrienations.Vertical
                    CellSelectVert(RowIndex, ColIndex)
                Case Else
                    CellSelectHorz(RowIndex, ColIndex)
            End Select

            ' Update the status
            UpdateStatus()

            ' Notify the user that the current record has changed
            If LastGridRow <> CurGridRow Then RaiseEvent UserSelectedRow(LastGridRow, CurGridRow)
            RaiseEvent UserSelectedCell(CurGridRow, CurGridCol)

        Catch ex As Exception
            Throw New Exception("CellSelect: " + ex.Message)
        End Try
    End Sub

    Private Sub CellSelectHorz(ByVal GridRow As Integer, ByVal GridCol As Integer)
        Try
            ' Scroll if necessary to display cell
            Dim RowShown As Boolean = IsGridRowDisplayed(GridRow)
            Dim ColShown As Boolean = IsGridColDisplayed(GridCol)
            If RowShown AndAlso Not ColShown Then
                ' Scroll horizontally
                If GridCol > CurGridCol Then
                    ' Scroll right
                    pnlHeader.Left = DisplayWidth - ColDefs(GridCol).Width - ColDefs(GridCol).Left
                Else
                    ' Scroll left
                    pnlHeader.Left = -(ColDefs(GridCol).Left)
                End If
                HeaderChangeLayout()
                FillHoriz(False)
            ElseIf ColShown AndAlso Not RowShown Then
                ' Scroll vertically
                FirstVisibleRow = GridRow + 1
                If FirstVisibleRow > RecordCount - CellRows + 1 Then FirstVisibleRow = RecordCount - CellRows + 1
                HorizPopulate()
            ElseIf Not ColShown AndAlso Not RowShown Then
                ' Scroll both
                FirstVisibleRow = GridRow + 1
                If FirstVisibleRow > RecordCount - CellRows + 1 Then FirstVisibleRow = RecordCount - CellRows + 1
                If GridCol > CurGridCol Then
                    ' Scroll right
                    pnlHeader.Left = DisplayWidth - ColDefs(GridCol).Width - ColDefs(GridCol).Left
                Else
                    ' Scroll left
                    pnlHeader.Left = -(ColDefs(GridCol).Left)
                End If
                HeaderChangeLayout()
                FillHoriz(False)
            Else
                ' No need to scroll, just clear any previously selected cell
                ClearCell(CurCellRow, CurCellCol)
            End If

            ' Assign the new grid current location
            CurGridRow = GridRow
            CurGridCol = GridCol

            ' Get the cell coordinates of the requested grid location
            Dim GridCart As Cart = GetCellFromGrid(New Cart(GridRow, GridCol))
            If GridCart IsNot Nothing Then
                CurCellRow = GridCart.Row
                CurCellCol = GridCart.Col
            End If

            ' Reset the scroll bar locations
            vsb.Value = CurGridRow + 1
            hsb.Value = -pnlHeader.Left

            ' Highlight the requested cell
            HighlightCell(CurCellRow, CurCellCol)

        Finally
            ' Focus on the grid so that keyboard events are captured immediately
            If Not IsInEditMode() Then pic.Focus()
        End Try
    End Sub

    Private Sub CellSelectVert(ByVal GridRow As Integer, ByVal GridCol As Integer)
        Try
            ' Scroll vertically if necessary to display the requested row
            Dim IsColDisplayed As Boolean = IsGridColDisplayed(GridCol)
            If GridRow = CurGridRow AndAlso IsColDisplayed Then
                ' No need to scroll, just clear any previously selected cell
                ClearCell(CurCellRow, CurCellCol)
            Else
                CurGridRow = GridRow
                If Not IsColDisplayed Then
                    FirstVisibleRow = GridCol
                    If FirstVisibleRow > GetRowCount(dtVert) - CellRows + 1 Then
                        FirstVisibleRow = GetRowCount(dtVert) - CellRows + 1
                    End If
                End If
                VertPopulate()
            End If

            ' Assign the new current location
            CurGridCol = GridCol

            ' Get the cell coordinates of the requested grid location
            Dim GridCart As Cart = GetCellFromGrid(New Cart(GridRow, GridCol))
            If GridCart IsNot Nothing Then
                CurCellRow = GridCart.Row
                CurCellCol = GridCart.Col
            End If

            ' Reposition scrollbar
            If GridCol < vsb.Minimum Then GridCol = vsb.Minimum
            If GridCol > vsb.Maximum Then GridCol = vsb.Maximum
            vsb.Value = GridCol

            ' Highlight the requested cell
            HighlightCell(CurCellRow, CurCellCol)

        Finally
            ' Focus on the grid so that keyboard events are captured immediately
            If Not IsInEditMode() Then pic.Focus()
        End Try
    End Sub

    Private Function IsGridCellDisplayed(ByVal GridRow As Integer, ByVal GridCol As Integer) As Boolean
        Return (IsGridRowDisplayed(GridRow) AndAlso IsGridColDisplayed(GridCol))
    End Function

    Private Function IsGridRowDisplayed(ByVal GridRow As Integer) As Boolean
        If CurOrientation = ProGridOrienations.Horizontal Then
            For CellRow As Integer = 0 To CellRows - 1
                If CellGrid(CellRow, FirstVisibleCol).GridRow = GridRow Then Return True
            Next
            Return False
        Else
            Return (GridRow = CurGridRow)
        End If
    End Function

    Private Function IsGridColDisplayed(ByVal GridCol As Integer) As Boolean
        If CurOrientation = ProGridOrienations.Horizontal Then
            Return ColDefs(GridCol).Displayed
        Else
            For CellRow As Integer = 0 To CellRows - 1
                If CellGrid(CellRow, 1).GridCol = GridCol Then Return True
            Next
            Return False
        End If
    End Function

    Private Sub pic_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseDown
        If Redrawing Then Exit Sub
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Exit Sub

            Dim CellCart As Cart = GetCellFromPic(New Point(e.X, e.Y))
            If CellCart Is Nothing Then Exit Sub
            If CellCart.Row <> CurCellRow OrElse CellCart.Col <> CurCellCol Then Exit Sub
            If CurOrientation = ProGridOrienations.Vertical AndAlso CurCellCol = 0 Then Exit Sub

            ctxCell.Show(pic, e.Location)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub pic_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseClick
        If Redrawing Then Exit Sub
        Try
            Dim CellCart As Cart = GetCellFromPic(New Point(e.X, e.Y))
            If CellCart Is Nothing Then Exit Sub
            If CurOrientation = ProGridOrienations.Vertical AndAlso CellCart.Col = 0 Then Exit Sub

            ' Select cell
            If CellCart.Row = CurCellRow AndAlso CellCart.Col = CurCellCol AndAlso Not CellGrid(CurCellRow, CurCellCol).Editable Then Exit Sub
            SetCurCell(CellCart.Row, CellCart.Col)

        Catch
        End Try
    End Sub

    Private Sub UpdateCell(ByVal CellRow As Integer, ByVal CellCol As Integer, ByVal NewText As String)
        Try
            ' Save the text
            CellGrid(CellRow, CellCol).CellText = NewText

            ' Draw the text
            Dim DrawRec As Rectangle = CellGrid(CellRow, CellCol).CellRec

            'ttg need to draw a checkbox...
            'g.FillRectangle(CellGrid(CellRow, CellCol).FillBrush, DrawRec)
            'g.DrawString(GetDisplayText(CellRow, CellCol), CurFont, TextBrush, DrawRec.Left, DrawRec.Top + 3)
            DrawCell(CellRow, CellCol)

            ' Show underline if cell value is invalid
            If CheckRange(CellRow, CellCol) <> "" Then
                g.DrawLine(InvalidPen, DrawRec.Left + 2, DrawRec.Bottom - 3, DrawRec.Right - 4, DrawRec.Bottom - 3)
            End If

            pic.Invalidate(CellGrid(CellRow, CellCol).CellRec)
            pic.Update()

        Finally
            pic.Focus()
        End Try
    End Sub

    Private Sub HighlightCell(ByVal CellRow As Integer, ByVal CellCol As Integer)
        Try
            ' Make sure the cell is in bounds
            If CellRow > CellGrid.GetUpperBound(0) OrElse CellCol > CellGrid.GetUpperBound(1) Then
                CurCellRow = -1
                CurCellCol = -1
            End If
            If CurCellRow = -1 OrElse CurCellCol = -1 Then Exit Sub

            ' Highlight the selected cell
            DrawCell(CellRow, CellCol, CellDrawTypes.SelectedCell)

            ' Highlight the row if row selection is enabled
            If EnableFullRowSelection AndAlso CurOrientation = ProGridOrienations.Horizontal Then
                For i As Integer = 0 To ColDefs.Count - 1
                    If ColDefs(i).Displayed AndAlso i <> CellCol Then
                        DrawCell(CellRow, i, CellDrawTypes.SelectedRow)
                    End If
                Next
            End If

            ' Update the picture
            pic.Update()

        Catch ex As Exception
            Dim mess As String = ex.Message
            Stop
        Finally
            pic.Focus()
        End Try
    End Sub

    Private Sub ClearCell(ByVal CellRow As Integer, ByVal CellCol As Integer)
        Try
            ' Make sure the cell is in bounds
            If CellRow = -1 OrElse CellCol = -1 OrElse CellRow > CellGrid.GetUpperBound(0) OrElse CellCol > CellGrid.GetUpperBound(1) Then
                CurCellRow = -1
                CurCellCol = -1
                Exit Sub
            End If

            ' Turn off any invalid tip showing
            lblTip.Visible = False

            ' Clear the selected cell
            DrawCell(CellRow, CellCol)

            ' Clear the row if row selection is enabled
            If EnableFullRowSelection AndAlso CurOrientation = ProGridOrienations.Horizontal Then
                For i As Integer = 0 To ColDefs.Count - 1
                    If ColDefs(i).Displayed AndAlso i <> CellCol Then
                        DrawCell(CellRow, i)
                    End If
                Next
            End If

            ' Update the picture
            pic.Update()

        Catch ex As Exception
            Dim mess As String = ex.Message
            Stop
        Finally
            pic.Focus()
        End Try
    End Sub

    Private Enum CellDrawTypes
        Normal = 0
        SelectedCell = 1
        SelectedRow = 2
    End Enum

    Private Sub DrawCell(ByVal CellRow As Integer, ByVal CellCol As Integer, Optional ByVal CellDrawType As CellDrawTypes = CellDrawTypes.Normal)

        ' Get the font and brush
        Dim DrawFont As Font = Nothing
        Dim DrawBrush As Brush = Nothing
        Select Case CellDrawType
            Case CellDrawTypes.Normal
                DrawFont = CurFont
                If CellGrid(CellRow, CellCol).Editable Then
                    DrawBrush = EditBrush
                Else
                    DrawBrush = Brushes.White
                End If
                If EnableFullRowSelection AndAlso CellRow = CurCellRow AndAlso Scrolling Then
                    DrawBrush = SelectBrush
                End If
            Case CellDrawTypes.SelectedCell
                DrawFont = CurFontBold
                DrawBrush = SelectBrush
            Case CellDrawTypes.SelectedRow
                DrawFont = CurFont
                DrawBrush = New SolidBrush(ColorLighten(ColorCellSelected, 0.5))
        End Select

        ' Save the current cell fill brush for cell updates
        CellGrid(CellRow, CellCol).FillBrush = DrawBrush

        ' Fill the background
        Dim DrawRec As Rectangle = CopyRec(CellGrid(CellRow, CellCol).CellRec)
        g.FillRectangle(DrawBrush, DrawRec)

        ' Draw the cell contents
        Dim Offset As Integer = 0
        Dim Style As ProGridStyle
        If CurOrientation = ProGridOrienations.Horizontal Then Style = StyleGet(CellCol) Else Style = StyleGet(CellGrid(CellRow, CellCol).GridCol)
        Dim DisplayText As String = GetDisplayText(CellRow, CellCol, DrawFont)
        If Style.ProStyleType = ProGridStyleTypes.CheckBox Then
            If CurOrientation = ProGridOrienations.Horizontal Then
                Select Case Style.ProAlignmentMethod
                    Case ProGridAlignmentStyles.Center
                        Offset = (DrawRec.Width - DrawRec.Height) / 2
                    Case ProGridAlignmentStyles.Right
                        Offset = DrawRec.Width - DrawRec.Height
                    Case Else
                        Offset = 0
                End Select
            Else
                If CellDrawType <> CellDrawTypes.Normal Then DrawRec.Width = 80
            End If
            If DisplayText = "True" OrElse DisplayText = "1" Then
                ' Draw a true checkbox
                If CellDrawType = CellDrawTypes.SelectedCell Then
                    ControlPaint.DrawCheckBox(g, DrawRec, ButtonState.Checked + ButtonState.Flat)
                Else
                    ControlPaint.DrawCheckBox(g, DrawRec.X + Offset, DrawRec.Y, DrawRec.Height, DrawRec.Height, ButtonState.Checked + ButtonState.Flat)
                End If
            Else
                ' Draw a false checkbox
                If CellDrawType = CellDrawTypes.SelectedCell Then
                    ControlPaint.DrawCheckBox(g, DrawRec, ButtonState.Normal + ButtonState.Flat)
                Else
                    ControlPaint.DrawCheckBox(g, DrawRec.X + Offset, DrawRec.Y, DrawRec.Height, DrawRec.Height, ButtonState.Normal + ButtonState.Flat)
                End If
            End If
        Else
            If CurOrientation = ProGridOrienations.Horizontal Then
                Select Case Style.ProAlignmentMethod
                    Case ProGridAlignmentStyles.Center
                        Offset = (DrawRec.Width - g.MeasureString(DisplayText, DrawFont).Width) / 2
                    Case ProGridAlignmentStyles.Right
                        Offset = DrawRec.Width - g.MeasureString(DisplayText, DrawFont).Width
                    Case Else
                        Offset = 0
                End Select
            End If
            g.DrawString(DisplayText, DrawFont, TextBrush, DrawRec.Left + Offset, DrawRec.Top + 3)
        End If

        ' Show underline if cell value is invalid
        Dim TipMsg As String = CheckRange(CellRow, CellCol)
        If TipMsg <> "" Then
            g.DrawLine(InvalidPen, DrawRec.Left + 2, DrawRec.Bottom - 3, DrawRec.Right - 4, DrawRec.Bottom - 3)
            If CellDrawType = CellDrawTypes.SelectedCell AndAlso EnableInvalidCellHandling = ProGridInvalidMethods.MarkAndShowTip Then
                lblTip.Left = pic.Left + DrawRec.Left + 2
                lblTip.Top = pic.Top + DrawRec.Bottom - 1
                lblTip.Text = TipMsg
                lblTip.Visible = True
                lblTip.BringToFront()
            End If
        End If

        ' Redraw the cell
        pic.Invalidate(DrawRec)

    End Sub

    ''' <summary>
    ''' Returns a row in the datatable.
    ''' </summary>
    ''' <param name="RecordIndex">The zero based row index to retrieve to get.</param>
    ''' <remarks>Returns the currently selected row if no RecordIndex is provided</remarks>
    Public Function RecordGet(Optional ByVal RecordIndex As Integer = -1) As DataRow
        If RecordIndex = -1 Then RecordIndex = CurGridRow
        If RecordIndex < 0 OrElse RecordIndex > RecordCount - 1 Then Return Nothing
        Return dt.Rows(RecordIndex)
    End Function

    ''' <summary>
    ''' Returns the value of a column in the currently selected row in the datatable.
    ''' </summary>
    ''' <param name="ColumnName">The name of the column to get.</param>
    ''' <returns>The raw value of the underlying data table cell.</returns>
    Public Function CellGet(ByVal ColumnName As String) As Object
        If dt.Columns.Contains(ColumnName) Then
            Return CellGet(CurGridRow, dt.Columns(ColumnName).Ordinal)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Returns the value of a column in the currently selected row in the datatable.
    ''' </summary>
    ''' <param name="ColIndex">The index of the column to get.</param>
    ''' <returns>The raw value of the underlying data table cell.</returns>
    Public Function CellGet(ByVal ColIndex As Integer) As Object
        Return CellGet(CurGridRow, ColIndex)
    End Function

    ''' <summary>
    ''' Returns the value of a given row and column in the datatable.
    ''' </summary>
    ''' <param name="RowIndex">The zero-based row index in the data table.</param>
    ''' <param name="ColumnName">The name of the column to get.</param>
    ''' <returns>The raw value of the underlying data table cell.</returns>
    Public Function CellGet(ByVal RowIndex As Integer, ByVal ColumnName As String) As Object
        If dt.Columns.Contains(ColumnName) Then
            Return CellGet(RowIndex, dt.Columns(ColumnName).Ordinal)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Returns the value of a given row and column in the datatable.
    ''' </summary>
    ''' <param name="RowIndex">The zero-based row index in the data table.</param>
    ''' <param name="ColIndex">The zero-based column index in the data table.</param>
    ''' <returns>The raw value of the underlying data table cell.</returns>
    Public Function CellGet(ByVal RowIndex As Integer, ByVal ColIndex As Integer) As Object
        Try
            If Not IsGridLocValid(RowIndex, ColIndex) Then
                Throw New Exception("CellGet: Invalid cell location")
            End If
            CellGet = GetFormattedText(RowIndex, ColIndex)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Assigns the value of a column in the current row of the datatable.
    ''' </summary>
    ''' <param name="ColumnName">The name of the column to set.</param>
    ''' <param name="CellValue">The raw value of the underlying data table cell.</param>
    ''' <remarks>Ignores invalid row and column combinations.</remarks>
    Public Sub CellSet(ByVal ColumnName As String, ByVal CellValue As Object)
        If dt.Columns.Contains(ColumnName) Then
            CellSet(CurGridRow, dt.Columns(ColumnName).Ordinal, CellValue)
        End If
    End Sub

    ''' <summary>
    ''' Assigns the value of a column in the current row of the datatable.
    ''' </summary>
    ''' <param name="ColIndex">The zero-based column index in the data table.</param>
    ''' <param name="CellValue">The raw value of the underlying data table cell.</param>
    ''' <remarks>Ignores invalid row and column combinations.</remarks>
    Public Sub CellSet(ByVal ColIndex As Integer, ByVal CellValue As Object)
        Try
            CellSet(CurGridRow, ColIndex, CellValue)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Assigns the value of a given row and column in the datatable.
    ''' </summary>
    ''' <param name="RowIndex">The zero-based row index in the data table.</param>
    ''' <param name="ColumnName">The name of the column to set.</param>
    ''' <param name="CellValue">The raw value of the underlying data table cell.</param>
    ''' <remarks>Ignores invalid row and column combinations.</remarks>
    Public Sub CellSet(ByVal RowIndex As Integer, ByVal ColumnName As String, ByVal CellValue As Object)
        If dt.Columns.Contains(ColumnName) Then
            CellSet(RowIndex, dt.Columns(ColumnName).Ordinal, CellValue)
        End If
    End Sub

    ''' <summary>
    ''' Assigns the value of a given row and column in the datatable.
    ''' </summary>
    ''' <param name="RowIndex">The zero-based row index in the data table.</param>
    ''' <param name="ColIndex">The zero-based column index in the data table.</param>
    ''' <param name="CellValue">The raw value of the underlying data table cell.</param>
    ''' <remarks>Ignores invalid row and column combinations.</remarks>
    Public Sub CellSet(ByVal RowIndex As Integer, ByVal ColIndex As Integer, ByVal CellValue As Object)
        Try
            If Not IsGridLocValid(RowIndex, ColIndex) Then
                Throw New Exception("CellSet: Invalid cell location")
                Exit Sub
            End If
            dt.Rows(RowIndex)(ColIndex) = CellValue

            ' See if cell is visible
            Dim CellCart As Cart = GetCellFromGrid(New Cart(RowIndex, ColIndex))
            If CellCart Is Nothing Then Exit Sub

            ' Update cell
            CellGrid(CellCart.Row, CellCart.Col).CellText = GetFormattedText(CellCart.Col, CellValue)
            UpdateCell(CellCart.Row, CellCart.Col, CellGrid(CellCart.Row, CellCart.Col).CellText)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function IsGridLocValid(ByVal GridRow As Integer, ByVal GridCol As Integer)
        Return (GridRow >= 0 AndAlso GridRow < RecordCount AndAlso GridCol >= 0 AndAlso GridCol < ColumnCount)
    End Function

#End Region

#Region "Grid Events"

    Private Sub pic_MouseWheel(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseWheel
        If Redrawing Then Exit Sub
        Try
            If CellRows < 2 Then Exit Sub
            If CurOrientation = ProGridOrienations.Horizontal Then
                If e.Delta >= 0 Then RowPrev() Else RowNext()
            Else
                If e.Delta >= 0 Then ' Up
                    If CurCellRow > 0 Then
                        SetCurCell(CurCellRow - 1, CurCellCol, True)
                    ElseIf FirstVisibleRow > 1 Then
                        FirstVisibleRow -= 1
                        VertPopulate()
                        SetCurCell(CurCellRow, CurCellCol, True)
                    End If
                Else ' Down
                    If CurCellRow < CellRows - 1 Then
                        SetCurCell(CurCellRow + 1, CurCellCol, True)
                    ElseIf FirstVisibleRow < GetRowCount(dtVert) - CellRows + 1 Then
                        FirstVisibleRow += 1
                        VertPopulate()
                        SetCurCell(CurCellRow, CurCellCol, True)
                    End If
                End If
            End If

        Catch
        End Try
    End Sub

    Private Sub vsc_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsb.Scroll
        If Redrawing Then Exit Sub
        If e.Type = ScrollEventType.EndScroll Then Exit Sub
        Try
            If e.NewValue = e.OldValue Then Exit Sub

            FirstVisibleRow = e.NewValue
            Populate()
            SetCurCell(CurCellRow, CurCellCol, True)

        Catch
        Finally
        End Try
    End Sub

#End Region

#Region "Editing"

    Private ChkEditor As Boolean = False

    Private Sub editor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles editor.KeyPress
        If Redrawing Then Exit Sub
        Try
            e.Handled = Not IsKeyValid(e.KeyChar, CurGridCol, CType(sender, TextBox).Text.Trim)
        Catch
        End Try
    End Sub

    Private Sub editor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles editor.KeyDown
        If Redrawing Then Exit Sub

        ' Handle control keys
        If sender.ModifierKeys = Keys.Control Then
            If e.KeyCode = Keys.A Then
                CType(sender, TextBox).SelectAll()
                e.SuppressKeyPress = True
                Exit Sub
            ElseIf e.KeyCode = Keys.C Then
                Clipboard.SetText(CType(sender, TextBox).Text)
                e.SuppressKeyPress = True
                Exit Sub
            ElseIf e.KeyCode = Keys.V AndAlso Clipboard.ContainsText Then
                CType(sender, TextBox).Text = Clipboard.GetText
                e.SuppressKeyPress = True
                Exit Sub
            End If
        End If

        Try
            Select Case e.KeyCode
                Case Keys.CapsLock
                    CapsLock = Not CapsLock
                Case Keys.Escape
                    CellEditClose(False)
                    e.SuppressKeyPress = True
                Case Keys.Enter
                    CellEditClose()
                    e.SuppressKeyPress = True
            End Select

        Catch
        End Try
    End Sub

    Private Function IsKeyValid(ByVal Key As Char, ByVal GridCol As Integer, ByVal CurString As String) As Boolean

        If Key = ChrW(Keys.Back) Then Return True

        ' Validate against cell style
        Dim KeyStr As String = Key.ToString()
        Dim CellStyle As ProGridStyle = StyleGet(GridCol)
        Select Case CellStyle.ProStyleType

            Case ProGridStyleTypes.SSN, ProGridStyleTypes.ZipCode
                Return (IsNumeric(KeyStr) OrElse Key = " " OrElse Key = "-")

            Case ProGridStyleTypes.PhoneNumber
                Return (IsNumeric(KeyStr) OrElse Key = " " OrElse Key = "-" OrElse Key = "(" OrElse Key = ")")

            Case ProGridStyleTypes.Numeric
                Return (IsNumeric(KeyStr) OrElse (CellStyle.ProDecimalPlaces > 0 AndAlso Key = ".") OrElse (CurString = "" AndAlso (CellStyle.ProMinValue Is Nothing OrElse CellStyle.ProMinValue < 0) AndAlso Key = "-"))

            Case ProGridStyleTypes.Currency
                If KeyStr = "$" Then Return True
                Return (IsNumeric(KeyStr) OrElse (CellStyle.ProDecimalPlaces > 0 AndAlso Key = ".") OrElse (CurString = "" AndAlso (CellStyle.ProMinValue Is Nothing OrElse CellStyle.ProMinValue < 0) AndAlso Key = "-"))

            Case ProGridStyleTypes.Percent
                If KeyStr = "%" Then Return True
                Return (IsNumeric(KeyStr) OrElse (CellStyle.ProDecimalPlaces > 0 AndAlso Key = ".") OrElse (CurString = "" AndAlso (CellStyle.ProMinValue Is Nothing OrElse CellStyle.ProMinValue < 0) AndAlso Key = "-"))

            Case ProGridStyleTypes.CheckBox
                Return (Asc(ChrW(Keys.Space)) = 32)

            Case ProGridStyleTypes.Dropdown
                Return True

            Case Else
                ' Validate against data type
                If IsNumericColumn(CurGridCol) Then
                    If Not (IsNumeric(Key) OrElse Key = "." OrElse Key = "-") Then Return False
                End If

        End Select

        Return True

    End Function

    Private Sub EditCell(Optional ByVal NewChar As String = "")

        If CurCellRow = -1 OrElse CurCellCol = -1 Then Exit Sub
        If Not CellGrid(CurCellRow, CurCellCol).Editable Then Exit Sub
        If CurOrientation = ProGridOrienations.Horizontal Then
            If Not ColDefs(CurGridCol).Displayed Then Exit Sub
        End If
        Dim CellStyle As ProGridStyle = StyleGet(CurGridCol)

        Select Case CellStyle.ProStyleType
            Case ProGridStyleTypes.DateOnly

                ' Position and configure editor
                calendar.CustomFormat = CellStyle.ProFormatString
                calendar.ShowUpDown = False
                calendar.Left = CellGrid(CurCellRow, CurCellCol).CellRec.Left
                calendar.Top = pic.Top + CellGrid(CurCellRow, CurCellCol).CellRec.Top
                calendar.Width = CellGrid(CurCellRow, CurCellCol).CellRec.Width
                calendar.Height = CellGrid(CurCellRow, CurCellCol).CellRec.Height

                If IsDate(CellGrid(CurCellRow, CurCellCol).CellText) Then
                    calendar.Value = CellGrid(CurCellRow, CurCellCol).CellText
                Else
                    calendar.Value = "1/1/1900"
                End If

                If CurOrientation = ProGridOrienations.Vertical Then
                    Dim vwidth As Integer = g.MeasureString(CellGrid(CurCellRow, CurCellCol).CellText, CurFont).Width + 50
                    If vwidth < calendar.Width Then calendar.Width = vwidth
                End If

                ' Display editor
                calendar.Visible = True
                calendar.Focus()

            Case ProGridStyleTypes.TimeOnly

                ' Position and configure editor
                calendar.CustomFormat = "h:mm tt"
                calendar.ShowUpDown = True
                calendar.Left = CellGrid(CurCellRow, CurCellCol).CellRec.Left
                calendar.Top = pic.Top + CellGrid(CurCellRow, CurCellCol).CellRec.Top
                calendar.Width = CellGrid(CurCellRow, CurCellCol).CellRec.Width
                calendar.Height = CellGrid(CurCellRow, CurCellCol).CellRec.Height

                If IsDate(CellGrid(CurCellRow, CurCellCol).CellText) Then calendar.Value = "1/1/2000 " + CellGrid(CurCellRow, CurCellCol).CellText

                If CurOrientation = ProGridOrienations.Vertical Then
                    Dim vwidth As Integer = g.MeasureString(CellGrid(CurCellRow, CurCellCol).CellText, CurFont).Width + 50
                    If vwidth < calendar.Width Then calendar.Width = vwidth
                End If

                ' Display editor
                calendar.Visible = True
                calendar.Focus()

            Case ProGridStyleTypes.Dropdown

                ' Position and configure editor
                combo.Left = CellGrid(CurCellRow, CurCellCol).CellRec.Left
                combo.Top = pic.Top + CellGrid(CurCellRow, CurCellCol).CellRec.Top
                combo.Width = CellGrid(CurCellRow, CurCellCol).CellRec.Width
                combo.Height = CellGrid(CurCellRow, CurCellCol).CellRec.Height

                ' Populate and display editor
                ComboLoad(CurGridCol)
                combo.SelectedIndex = -1

                ' Select the initial value if the first letter was pressed
                If NewChar <> "" AndAlso NewChar <> "CLEAR" Then
                    For i As Integer = 0 To combo.Items.Count - 1
                        If combo.Items(i).StartsWith(NewChar, True, Nothing) Then
                            combo.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
                If combo.SelectedIndex = -1 Then combo.Text = CellGrid(CurCellRow, CurCellCol).CellText

                If CurOrientation = ProGridOrienations.Vertical Then
                    Dim vwidth As Integer = g.MeasureString(CellGrid(CurCellRow, CurCellCol).CellText, CurFont).Width + 30
                    If vwidth < combo.Width Then combo.Width = vwidth
                End If

                combo.Visible = True
                combo.Focus()
                combo.DroppedDown = True

            Case ProGridStyleTypes.CheckBox

                ChkEditor = True
                If IsDBNull(dt.Rows(CurGridRow)(CurGridCol)) Then
                    dt.Rows(CurGridRow)(CurGridCol) = True
                ElseIf IsStringColumn(CurGridCol) Then
                    If ToStr(dt.Rows(CurGridRow)(CurGridCol)) = "True" Then dt.Rows(CurGridRow)(CurGridCol) = "False" Else dt.Rows(CurGridRow)(CurGridCol) = "True"
                Else
                    If dt.Rows(CurGridRow)(CurGridCol) Then dt.Rows(CurGridRow)(CurGridCol) = False Else dt.Rows(CurGridRow)(CurGridCol) = True
                End If
                CellEditClose()

            Case Else

                ' Position and configure editor
                editor.Left = CellGrid(CurCellRow, CurCellCol).CellRec.Left
                editor.Top = pic.Top + CellGrid(CurCellRow, CurCellCol).CellRec.Top
                editor.Width = CellGrid(CurCellRow, CurCellCol).CellRec.Width
                editor.Height = CellGrid(CurCellRow, CurCellCol).CellRec.Height

                ' Set max length for string types
                editor.MaxLength = 0
                If IsStringColumn(CurGridCol) Then
                    If dt.Columns(CurGridCol).MaxLength = -1 Then editor.MaxLength = 0 Else editor.MaxLength = dt.Columns(CurGridCol).MaxLength
                End If
                If CellStyle.ProMaxStringLength > 0 AndAlso (CellStyle.ProMaxStringLength < editor.MaxLength OrElse editor.MaxLength = 0) Then editor.MaxLength = CellStyle.ProMaxStringLength

                ' Populate and display editor
                If NewChar = "CLEAR" Then
                    editor.Text = ""
                ElseIf NewChar <> "" Then
                    editor.Text = NewChar
                Else
                    editor.Text = CellGrid(CurCellRow, CurCellCol).CellText
                End If
                editor.Visible = True
                editor.Focus()
                editor.Select(editor.Text.Length, 0)

        End Select

    End Sub

    Private Sub editor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editor.TextChanged
        If Redrawing Then Exit Sub
        Try
            ' Get the text to update
            Dim UpdatedValue As Object = editor.Text

            ' Convert to storable format
            If IsNumericColumn(CurGridCol) Then
                Dim Style As ProGridStyle = StyleGet(CurGridCol)
                Select Case Style.ProStyleType
                    Case ProGridStyleTypes.Percent, ProGridStyleTypes.Currency
                        UpdatedValue = ToNumericCharsOnly(UpdatedValue, True, True)
                End Select
            End If

            ' Save the value to the datatable
            If IsNumericColumn(CurGridCol) Then
                If UpdatedValue = "" Then UpdatedValue = DBNull.Value Else UpdatedValue = Val(UpdatedValue)
            End If
            dt.Rows(CurGridRow)(CurGridCol) = UpdatedValue

        Catch
        End Try
    End Sub

    Private Sub calendar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calendar.ValueChanged
        If Redrawing Then Exit Sub
        Try

            ' Save the value to the datatable
            dt.Rows(CurGridRow)(CurGridCol) = calendar.Value

        Catch
        End Try
    End Sub

    Private Sub combo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo.SelectionChangeCommitted
        If Redrawing Then Exit Sub
        Try
            ' Save the value to the datatable
            dt.Rows(CurGridRow)(CurGridCol) = GetComboStorageValue(CurGridCol, ToStr(combo.SelectedItem))

            ' Hide the combo
            CellEditClose()

        Catch
        End Try
    End Sub

    Private Sub ComboLoad(ByVal GridCol As Integer)

        combo.Items.Clear()

        Dim Style As ProGridStyle = StyleGet(GridCol)
        If Style.ProDropdown Is Nothing OrElse Style.ProDropdown.Columns.Count = 0 Then Exit Sub

        For Each row As DataRow In Style.ProDropdown.Rows
            Select Case Style.ProDropdown.Columns.Count
                Case 1
                    combo.Items.Add(row(0))
                Case Else
                    combo.Items.Add(row(1))
            End Select
        Next

    End Sub

    Private Function GetComboDisplayValue(ByVal GridCol As Integer, ByVal StoredValue As String) As String

        Return GetComboDisplayValue(dt.Columns(GridCol).ColumnName, StoredValue)

    End Function

    Private Function GetComboDisplayValue(ByVal ColumnName As String, ByVal StoredValue As Object) As String

        Dim Style As ProGridStyle = StyleGet(ColumnName)
        If Style.ProDropdown Is Nothing OrElse Style.ProDropdown.Columns.Count < 2 Then Return StoredValue

        Dim rows() As DataRow = Style.ProDropdown.Select("[" + Style.ProDropdown.Columns(0).ColumnName + "]=" + Val(StoredValue).ToString)
        If rows Is Nothing OrElse rows.Count <> 1 Then Return StoredValue
        Return ToStr(rows(0)(1))

    End Function

    Private Function GetComboStorageValue(ByVal GridCol As Integer, ByVal DisplayedValue As String) As Object

        Dim Style As ProGridStyle = StyleGet(GridCol)
        If Style.ProDropdown Is Nothing OrElse Style.ProDropdown.Columns.Count < 2 Then Return DisplayedValue

        Dim rows() As DataRow = Style.ProDropdown.Select("[" + Style.ProDropdown.Columns(1).ColumnName + "]='" + DisplayedValue + "'")
        If rows Is Nothing OrElse rows.Count <> 1 Then Return DisplayedValue
        Return rows(0)(0)

    End Function

    Private Sub pic_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles pic.PreviewKeyDown
        Dim WorkingKey As Keys = e.KeyCode
        If Redrawing Then Exit Sub
        Try
            If WorkingKey = Keys.CapsLock Then CapsLock = Not CapsLock
            If Redrawing Then Exit Sub
            If RecordCount = 0 Then Exit Sub
            If WorkingKey = Keys.ControlKey OrElse WorkingKey = Keys.Alt OrElse e.Modifiers = Keys.Alt Then Exit Sub
            If e.Modifiers = Keys.Control AndAlso EnableOptionsCopy Then
                Select Case WorkingKey
                    Case Keys.C
                        CopyCell()
                        Exit Sub
                    Case Keys.V
                        PasteCell()
                        Exit Sub
                End Select
            End If

            Select Case WorkingKey
                Case Keys.Home
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        If CurGridRow <> 0 OrElse CurGridCol <> FirstVisibleCol Then CellSelect(0, FirstVisibleCol)
                    Else
                        If CurGridCol <> FirstVisibleCol Then CellSelect(CurGridRow, FirstVisibleCol)
                    End If
                Case Keys.End
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        If CurGridRow <> RecordCount - 1 OrElse CurGridCol <> FirstVisibleCol Then CellSelect(RecordCount - 1, FirstVisibleCol)
                    Else
                        If CurGridCol <> GetLastVisibleColumn() Then CellSelect(CurGridRow, GetLastVisibleColumn())
                    End If
                Case Keys.Enter
                    If CurCellRow = -1 OrElse CurCellCol = -1 Then Exit Sub
                    EditCell()
                Case Keys.Back
                    If CurCellRow = -1 OrElse CurCellCol = -1 Then Exit Sub
                    dt.Rows(CurGridRow)(CurGridCol) = DBNull.Value
                    EditCell("CLEAR")
                Case Keys.Up
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        RowPrev()
                    Else
                        If CurCellRow > 0 Then
                            SetCurCell(CurCellRow - 1, CurCellCol, True)
                        ElseIf FirstVisibleRow > 1 Then
                            FirstVisibleRow -= 1
                            VertPopulate()
                            SetCurCell(CurCellRow, CurCellCol, True)
                        End If
                    End If
                Case Keys.Down
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        RowNext()
                    Else
                        If CurCellRow < CellRows - 1 Then
                            SetCurCell(CurCellRow + 1, CurCellCol, True)
                        ElseIf FirstVisibleRow < GetRowCount(dtVert) - CellRows + 1 Then
                            FirstVisibleRow += 1
                            VertPopulate()
                            SetCurCell(CurCellRow, CurCellCol, True)
                        End If
                    End If
                Case Keys.Left
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        If CurGridCol > GetFirstDisplayedColumn() Then
                            SetCurCell(CurCellRow, GetPrevDisplayedColumn, True)
                        ElseIf CurGridCol > GetFirstVisibleColumn() Then
                            CellSelect(CurGridRow, GetPrevVisibleColumn())
                        End If
                    End If
                Case Keys.Right
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        If CurGridCol < GetLastDisplayedColumn() Then
                            SetCurCell(CurCellRow, GetNextDisplayedColumn, True)
                        ElseIf CurGridCol < GetLastVisibleColumn() Then
                            CellSelect(CurGridRow, GetNextVisibleColumn())
                        End If
                    End If
                Case Keys.PageUp
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        Dim NewGridRow As Integer = CurGridRow - CellRows
                        If NewGridRow < 0 Then NewGridRow = 0
                        CellSelect(NewGridRow, CurCellCol)
                    End If
                Case Keys.PageDown
                    If CurOrientation = ProGridOrienations.Horizontal Then
                        Dim NewGridRow As Integer = CurGridRow + CellRows
                        If NewGridRow > RecordCount - 1 Then NewGridRow = RecordCount - 1
                        CellSelect(NewGridRow, CurCellCol)
                    End If
                Case Else
                    If CurCellRow = -1 OrElse CurCellCol = -1 Then Exit Sub
                    Dim key As String = GetKey(WorkingKey.ToString)
                    If Not IsKeyValid(key, CurGridCol, "") Then Exit Sub
                    If Not e.Shift AndAlso Not CapsLock Then key = key.ToLower
                    EditCell(key)
            End Select

        Catch
        Finally
            e.IsInputKey = Not ((WorkingKey = Keys.F3) OrElse WorkingKey = Keys.Tab OrElse (WorkingKey = Keys.F AndAlso e.Modifiers = Keys.Control))
            If Not IsInEditMode() Then pic.Focus()
        End Try
    End Sub

    Private Function GetKey(ByVal KeyCode As String) As String
        If KeyCode.Length = 1 Then Return KeyCode
        If KeyCode.Length = 2 AndAlso KeyCode.Substring(0, 1) = "D" Then Return KeyCode.Substring(1, 1)
        Dim AscNum As Integer = Asc(KeyCode)
        Select Case KeyCode
            Case "OemPeriod", "Decimal"
                Return "."
            Case "OemMinus", "Subtract"
                Return "-"
            Case Else
                Return ""
        End Select
    End Function

    Private Function IsInEditMode() As Boolean
        Return (editor.Visible OrElse calendar.Visible OrElse combo.Visible)
    End Function

    Private Sub calendar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles calendar.KeyDown
        If Redrawing Then Exit Sub
        Try
            Select Case e.KeyCode
                Case Keys.CapsLock
                    CapsLock = Not CapsLock
                Case Keys.Escape
                    CellEditClose(False)
                Case Keys.Enter
                    CellEditClose()
            End Select

        Catch
        End Try
    End Sub

    Private Sub combo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles combo.KeyDown
        If Redrawing Then Exit Sub
        Try

            Select Case e.KeyCode
                Case Keys.CapsLock
                    CapsLock = Not CapsLock
                Case Keys.Escape
                    CellEditClose(False)
                Case Keys.Enter
                    dt.Rows(CurGridRow)(CurGridCol) = GetComboStorageValue(CurGridCol, ToStr(combo.SelectedItem))
                    CellEditClose()
            End Select

        Catch
        End Try
    End Sub

#End Region

#Region "Navigation"

    Private Sub btnFlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlip.Click
        If Redrawing Then Exit Sub
        Try
            Cursor = Cursors.WaitCursor

            If CurOrientation = ProGridOrienations.Horizontal Then
                SavedPosition.LastHorizontalPosition = pnlHeader.Left
                SavedPosition.LastTopRow = FirstVisibleRow
                SavedPosition.IsValid = True
                CurOrientation = ProGridOrienations.Vertical
            Else
                CurOrientation = ProGridOrienations.Horizontal
            End If
            DrawGrid(FullRedraw:=True, ResetVScroll:=True)

            ' Select the default cell
            CurCellRow = -1
            CurCellCol = -1
            CellSelect(CurGridRow, CurGridCol)

        Catch
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If Redrawing Then Exit Sub
        Try
            RowPrev()

        Catch
        End Try
    End Sub

    Private Sub RowPrev()

        Redrawing = True
        If CurOrientation = ProGridOrienations.Horizontal Then
            If CurCellRow = 0 Then
                If CurGridRow > 0 Then
                    FirstVisibleRow -= 1
                    HorizPopulate()
                    SetCurCell(CurCellRow, CurCellCol, True)
                End If
            Else
                SetCurCell(CurCellRow - 1, CurCellCol, True)
            End If
        Else
            CurGridRow -= 1
            VertDrawGrid()
            CellSelect(CurGridRow, CurGridCol)
        End If
        Redrawing = False

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Redrawing Then Exit Sub
        Try
            RowNext()

        Catch
        End Try
    End Sub

    Private Sub RowNext()

        Redrawing = True
        If CurOrientation = ProGridOrienations.Horizontal Then
            If CurCellRow = LastVisibleRow Then
                If CurGridRow < RecordCount - 1 Then
                    FirstVisibleRow += 1
                    HorizPopulate()
                    SetCurCell(CurCellRow, CurCellCol, True)
                End If
            Else
                SetCurCell(CurCellRow + 1, CurCellCol, True)
            End If
        Else
            CurGridRow += 1
            VertDrawGrid()
            CellSelect(CurGridRow, CurGridCol)
        End If
        Redrawing = False

    End Sub

    Private Sub UpdateStatus()

        If tmrMove.Enabled AndAlso CurGridRow = 0 OrElse CurGridRow = RecordCount - 1 Then tmrMove.Enabled = False

        ConfigureOptions()
        btnAdd.Enabled = (dt IsNot Nothing AndAlso ColumnCount > 0)
        btnDelete.Enabled = (RecordCount > 0)
        btnFlip.Enabled = (RecordCount > 0)
        btnPrev.Enabled = ((RecordCount > 1) And (CurGridRow > 0))
        btnNext.Enabled = ((RecordCount > 1) And (CurGridRow < RecordCount - 1))
        If RecordCount > 0 Then
            lblRecord.Text = (CurGridRow + 1).ToString + " of " + RecordCount.ToString
        Else
            lblRecord.Text = "Empty"
        End If

    End Sub

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick
        If Redrawing Then Exit Sub
        Try
            Select Case tmrMove.Tag
                Case "Start Prev"
                    tmrMove.Tag = "Moving Prev"
                Case "Start Next"
                    tmrMove.Tag = "Moving Next"
                Case "Moving Prev"
                    RowPrev()
                Case "Moving Next"
                    RowNext()
            End Select

        Catch
        End Try
    End Sub

    Private Sub btnPrev_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrev.MouseDown
        If Redrawing Then Exit Sub
        Try
            tmrMove.Tag = "Start Prev"
            tmrMove.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub btnNext_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseDown
        If Redrawing Then Exit Sub
        Try
            tmrMove.Tag = "Start Next"
            tmrMove.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub Move_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrev.MouseUp, btnNext.MouseUp
        If Redrawing Then Exit Sub
        Try
            tmrMove.Enabled = False
        Catch
        End Try
    End Sub

    Private Sub Move_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.MouseLeave, btnNext.MouseLeave
        If Redrawing Then Exit Sub
        Try
            tmrMove.Enabled = False
        Catch
        End Try
    End Sub

#End Region

#Region "Menu"

    Dim sb As New System.Text.StringBuilder(10000)

    Private Sub ctxCell_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxCell.Opening
        If Redrawing Then Exit Sub
        Try
            Cursor = Cursors.WaitCursor

            If CurGridRow = -1 OrElse CurGridCol = -1 Then Exit Sub

            ' Get the data to potentially link ou
            Dim OpenLink As Object = dt.Rows(CurGridRow)(CurGridCol)

            ' Hide copy items if copying is disabled
            ctxCopyCell.Visible = EnableOptionsCopy
            ctxPasteCell.Visible = EnableEditing And EnableOptionsCopy And StyleGet(CurGridCol).ProEditable
            ctxCopyRow.Visible = EnableOptionsCopy

            ' We can't copy blob columns
            ctxCopyCol.Enabled = Not IsBlobColumn(CurGridCol) AndAlso Not IsTextColumn(CurGridCol)

            ' See if there is anything to open
            If IsDBNull(OpenLink) OrElse OpenLink.ToString = "" Then
                ctxCell.Tag = Nothing
                ctxOpen.Enabled = False
                Exit Sub
            End If

            ' See what kind of data we have
            Dim CellText As String = GetFormattedText(CurGridCol, GetFormattedText(CurGridRow, CurGridCol))
            Dim Style As ProGridStyle = StyleGet(CurGridCol)
            If Style.ProDataFileExtension <> "" Then
                ' Named file type
                ctxCell.Tag = OpenLink
                ctxOpen.Enabled = True
            ElseIf CellText = "<Text>" Then
                ' Named file type
                ctxCell.Tag = OpenLink
                ctxOpen.Enabled = True
            ElseIf IsURL(OpenLink.ToString) Then
                ' Url
                ctxCell.Tag = OpenLink
                ctxOpen.Enabled = True
            ElseIf IsFileName(OpenLink.ToString) AndAlso (IO.File.Exists(OpenLink.ToString) OrElse IO.Directory.Exists(OpenLink.ToString)) Then
                ' File or folder
                ctxCell.Tag = OpenLink
                ctxOpen.Enabled = True
            Else
                ctxCell.Tag = Nothing
                ctxOpen.Enabled = False
            End If

        Catch
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ctxOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxOpen.Click
        If Redrawing Then Exit Sub
        Try
            Cursor = Cursors.WaitCursor

            Dim Style As ProGridStyle = StyleGet(CurGridCol)
            Dim FileType As String = Style.ProDataFileExtension
            If GetFormattedText(CurGridCol, GetFormattedText(CurGridRow, CurGridCol)) = "<Text>" Then FileType = "txt"
            If FileType <> "" Then
                Dim tmpfile As String = IO.Path.GetTempFileName
                tmpfile = IO.Path.ChangeExtension(tmpfile, FileType)
                If IsBlobColumn(CurGridCol) Then
                    If TypeOf ctxCell.Tag Is Bitmap Then
                        Dim bmp As Bitmap
                        bmp = ctxCell.Tag
                        bmp.Save(tmpfile)
                    Else
                        IO.File.WriteAllBytes(tmpfile, ctxCell.Tag)
                    End If
                Else
                    IO.File.WriteAllText(tmpfile, ctxCell.Tag)
                End If
                Process.Start(tmpfile)
            Else
                Process.Start(ctxCell.Tag)
            End If

        Catch
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ctxCopyCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxCopyCell.Click
        If Redrawing Then Exit Sub
        Try
            CopyCell()
        Catch
        End Try
    End Sub

    Private Sub ctxPasteCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxPasteCell.Click
        If Redrawing Then Exit Sub
        Try
            PasteCell()
        Catch
        End Try
    End Sub

    Private Sub CopyCell()
        If CurGridRow = -1 OrElse CurGridCol = -1 Then Exit Sub
        If IsBlobColumn(CurGridCol) Then
            Dim ClipObj As Object = dt.Rows(CurGridRow)(CurGridCol)
            Clipboard.SetImage(ClipObj)
        Else
            Dim ClipText As String = GetFormattedText(CurGridRow, CurGridCol)
            Clipboard.SetText(ClipText)
        End If
    End Sub

    Private Sub PasteCell()
        If Not EnableEditing Then Exit Sub
        If Not Clipboard.ContainsText() Then Exit Sub
        Dim NewValue As String = Clipboard.GetText
        dt.Rows(CurGridRow)(CurGridCol) = NewValue
        CellGrid(CurCellRow, CurCellCol).CellText = GetFormattedText(CurGridCol, NewValue)
        HighlightCell(CurCellRow, CurCellCol)
    End Sub

    Private Sub ctxCopyRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxCopyRow.Click
        If Redrawing Then Exit Sub
        Try
            Cursor = Cursors.WaitCursor

            If CurGridRow = -1 Then Exit Sub

            sb.Clear()
            Dim ClipText As String = GetRowValues(CurGridRow)
            Clipboard.SetText(ClipText)

        Catch
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ctxCopyCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxCopyCol.Click
        If Redrawing Then Exit Sub
        Try

            If CurGridCol = -1 Then Exit Sub
            If IsBlobColumn(CurGridCol) OrElse IsTextColumn(CurGridCol) Then Exit Sub

            sb.Clear()
            For GridRow As Integer = 0 To GetRowCount(dt) - 1
                sb.Append(GetFormattedText(GridRow, CurGridCol)).Append(vbCrLf)
            Next
            Clipboard.SetText(sb.ToString)

        Catch
        End Try
    End Sub

    Private Sub mnuCopyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyGrid.Click
        If Redrawing Then Exit Sub
        Try
            Cursor = Cursors.WaitCursor
            Me.Enabled = False

            ' Generate string to export
            sb.Clear()
            For GridRow As Integer = 0 To GetRowCount(dt) - 1
                GetRowValues(GridRow)
                sb.Append(vbCrLf)
                If sb.Length > 200000 Then
                    MessageBox.Show("This grid is too large to copy to the clipboard." + vbCrLf + vbCrLf + "You may wish to export to file instead.", "Copy Grid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            ' Copy to clipboard
            Clipboard.SetText(sb.ToString)

            ' Inform the user
            MessageBox.Show("Your grid has been copied to the clipboard." + vbCrLf + vbCrLf + "You can paste it into Microsoft Excel but may need to select 'Text to Columns' to populate columns correctly.", "ProGrid Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch
        Finally
            sb.Length = 0
            sb.Capacity = 10000
            Me.Enabled = True
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetRowValues(ByVal GridRow As Integer) As String
        For GridCol As Integer = 0 To ColumnCount - 1
            If Not StyleGet(GridCol).ProVisible OrElse IsBlobColumn(GridCol) OrElse IsTextColumn(GridCol) Then Continue For
            sb.Append(Chr(34)).Append(GetFormattedText(GridRow, GridCol)).Append(Chr(34)).Append(",")
        Next
        sb.Remove(sb.Length - 1, 1)
        Return sb.ToString
    End Function

#End Region

#Region "Tool Bar"

    ''' <summary>
    ''' Quick configure of all user-defined tool buttons.
    ''' </summary>
    ''' <param name="One">The label and tag for button 1.</param>
    ''' <param name="Two">The label and tag for button 2.</param>
    ''' <param name="Three">The label and tag for button 3.</param>
    ''' <param name="Four">The label and tag for button 4.</param>
    ''' <param name="Five">The label and tag for button 5.</param>
    ''' <param name="Six">The label and tag for button 6.</param>
    ''' <param name="Seven">The label and tag for button 7.</param>
    ''' <param name="Eight">The label and tag for button 8.</param>
    ''' <remarks>Omitted buttons will be hidden.</remarks>
    Public Sub ButtonQuickSet(Optional ByVal One As String = "", Optional ByVal Two As String = "", Optional ByVal Three As String = "", Optional ByVal Four As String = "", Optional ByVal Five As String = "", Optional ByVal Six As String = "", Optional ByVal Seven As String = "", Optional ByVal Eight As String = "")
        Try
            btnUserOne.Visible = (One <> "")
            btnUserTwo.Visible = (Two <> "")
            btnUserThree.Visible = (Three <> "")
            btnUserFour.Visible = (Four <> "")
            btnUserFive.Visible = (Five <> "")
            btnUserSix.Visible = (Six <> "")
            btnUserSeven.Visible = (Seven <> "")
            btnUserEight.Visible = (Eight <> "")
            btnUserOne.Text = One
            btnUserTwo.Text = Two
            btnUserThree.Text = Three
            btnUserFour.Text = Four
            btnUserFive.Text = Five
            btnUserSix.Text = Six
            btnUserSeven.Text = Seven
            btnUserEight.Text = Eight
            btnUserOne.Tag = One
            btnUserTwo.Tag = Two
            btnUserThree.Tag = Three
            btnUserFour.Tag = Four
            btnUserFive.Tag = Five
            btnUserSix.Tag = Six
            btnUserSeven.Tag = Seven
            btnUserEight.Tag = Eight
            btnUserOne.ToolTipText = ""
            btnUserTwo.ToolTipText = ""
            btnUserThree.ToolTipText = ""
            btnUserFour.ToolTipText = ""
            btnUserFive.ToolTipText = ""
            btnUserSix.ToolTipText = ""
            btnUserSeven.ToolTipText = ""
            btnUserEight.ToolTipText = ""

        Catch ex As Exception
            Throw New Exception("ButtonQuickSet: " + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Configures a user-defined tool button.
    ''' </summary>
    ''' <param name="ButtonNumber">The button number to configure between 1 and 8.</param>
    ''' <param name="ButtonName">The label to display on the button.</param>
    ''' <param name="ToolTip">The tooltip associated with the button.</param>
    ''' <param name="ButtonTag">The tag for the button that is passed to the button clicked event.</param>
    ''' <param name="Enabled">True to enable the button.</param>
    Public Sub ButtonSet(ByVal ButtonNumber As Integer, ByVal ButtonName As String, Optional ByVal ToolTip As String = "", Optional ByVal ButtonTag As String = "", Optional ByVal Enabled As Boolean = True)
        Try
            ButtonName = ButtonName.Trim
            Select Case ButtonNumber
                Case 1
                    btnUserOne.Text = ButtonName
                    btnUserOne.Visible = (ButtonName <> "")
                    btnUserOne.Enabled = Enabled
                    btnUserOne.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserOne.Tag = ButtonName Else btnUserOne.Tag = ButtonTag
                Case 2
                    btnUserTwo.Text = ButtonName
                    btnUserTwo.Visible = (ButtonName <> "")
                    btnUserTwo.Enabled = Enabled
                    btnUserTwo.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserTwo.Tag = ButtonName Else btnUserTwo.Tag = ButtonTag
                Case 3
                    btnUserThree.Text = ButtonName
                    btnUserThree.Visible = (ButtonName <> "")
                    btnUserThree.Enabled = Enabled
                    btnUserThree.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserThree.Tag = ButtonName Else btnUserThree.Tag = ButtonTag
                Case 4
                    btnUserFour.Text = ButtonName
                    btnUserFour.Visible = (ButtonName <> "")
                    btnUserFour.Enabled = Enabled
                    btnUserFour.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserFour.Tag = ButtonName Else btnUserFour.Tag = ButtonTag
                    Me.Show()
                Case 5
                    btnUserFive.Text = ButtonName
                    btnUserFive.Visible = (ButtonName <> "")
                    btnUserFive.Enabled = Enabled
                    btnUserFive.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserFive.Tag = ButtonName Else btnUserFive.Tag = ButtonTag
                Case 6
                    btnUserSix.Text = ButtonName
                    btnUserSix.Visible = (ButtonName <> "")
                    btnUserSix.Enabled = Enabled
                    btnUserSix.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserSix.Tag = ButtonName Else btnUserSix.Tag = ButtonTag
                Case 7
                    btnUserSeven.Text = ButtonName
                    btnUserSeven.Visible = (ButtonName <> "")
                    btnUserSeven.Enabled = Enabled
                    btnUserSeven.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserSeven.Tag = ButtonName Else btnUserSeven.Tag = ButtonTag
                Case 8
                    btnUserEight.Text = ButtonName
                    btnUserEight.Visible = (ButtonName <> "")
                    btnUserEight.Enabled = Enabled
                    btnUserEight.ToolTipText = ToolTip
                    If ButtonTag = "" Then btnUserEight.Tag = ButtonName Else btnUserEight.Tag = ButtonTag
                Case Else
                    Throw New Exception("ButtonSet: ButtonNumber must be in the range of 1 to 8.")
            End Select

        Catch ex As Exception
            Throw New Exception("ButtonSet: " + ex.Message)
        End Try
    End Sub

    ''' <summary>Raised when the user clicks on a User-Defined Toolbutton.</summary>
    Public Event UserClickedButton(ByVal ButtonTag As String)
    Private Sub btnUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserOne.Click, btnUserTwo.Click, btnUserThree.Click, btnUserFour.Click, btnUserFive.Click, btnUserSix.Click, btnUserSeven.Click, btnUserEight.Click
        If Redrawing Then Exit Sub
        Try
            RaiseEvent UserClickedButton(CType(sender, ToolStripButton).Tag)
        Catch
        End Try
    End Sub

    ''' <summary>Raised when the user clicks on the Refresh button.</summary>
    Public Event UserClickedRefresh()
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If Redrawing Then Exit Sub
        Try
            RaiseEvent UserClickedRefresh()
        Catch
        End Try
    End Sub

    ''' <summary>Raised when the user clicks on the record Add button.</summary>
    Public Event UserClickedAdd(ByRef AddedRow As DataRow, ByRef SaveAction As ProGridSaveActions)
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Redrawing Then Exit Sub
        Try

            Dim AddedRow As DataRow = dt.NewRow

            Dim SaveAction As ProGridSaveActions = ProGridSaveActions.CommitChanges
            RaiseEvent UserClickedAdd(AddedRow, SaveAction)
            If SaveAction = ProGridSaveActions.UndoChanges Then Exit Sub

            dt.Rows.Add(AddedRow)

            CurGridRow = RecordCount - 1
            DrawGrid()
            CellSelect(CurGridRow, CurGridCol)

        Catch
        End Try
    End Sub

    ''' <summary>Raised when the user clicks on the record Delete button.</summary>
    Public Event UserClickedDelete(ByRef DeletedRow As DataRow, ByRef SaveAction As ProGridSaveActions)
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Redrawing Then Exit Sub
        Try

            If RecordCount = 0 OrElse CurGridRow < 0 Then Exit Sub
            Dim DeletedRow As DataRow = dt.Rows(CurGridRow)

            Dim SaveAction As ProGridSaveActions = ProGridSaveActions.CommitChanges
            RaiseEvent UserClickedDelete(DeletedRow, SaveAction)
            If SaveAction = ProGridSaveActions.UndoChanges Then Exit Sub

            dt.Rows.Remove(DeletedRow)

            If CurGridRow >= RecordCount Then CurGridRow -= 1
            DrawGrid()
            UpdateStatus()
            CellSelect(CurGridRow, CurGridCol)

        Catch
        End Try
    End Sub

    ''' <summary>Raised when the user double-clicks on a cell.</summary>
    Public Event UserDoubleClicked(ByVal RowIndex As Integer, ByVal ColIndex As Integer)
    Private Sub pic_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseDoubleClick
        If Redrawing Then Exit Sub
        Try
            Dim GridCell As Cart = GetGridFromPic(New Point(e.X, e.Y))
            If GridCell Is Nothing Then Exit Sub
            RaiseEvent UserDoubleClicked(GridCell.Row, GridCell.Col)
        Catch
        End Try
    End Sub

    Private Function GetCellFromPic(ByVal PicPoint As Point) As Cart

        For CellCol = 0 To CellCols - 1
            For CellRow = 0 To CellRows - 1
                If CellGrid(CellRow, CellCol).CellRec.Contains(PicPoint) Then
                    Return New Cart(CellRow, CellCol)
                End If
            Next
        Next
        Return Nothing

    End Function

    Private Function GetCellFromGrid(ByVal GridPoint As Cart) As Cart

        For CellCol = 0 To CellCols - 1
            For CellRow = 0 To CellRows - 1
                If CellGrid(CellRow, CellCol).GridRow = GridPoint.Row AndAlso CellGrid(CellRow, CellCol).GridCol = GridPoint.Col Then
                    Return New Cart(CellRow, CellCol)
                End If
            Next
        Next
        Return Nothing

    End Function

    Private Function GetGridFromCell(ByVal CellPoint As Cart) As Cart

        If CellPoint Is Nothing OrElse CellPoint.Row = -1 OrElse CellPoint.Col = -1 Then Return Nothing

        Return New Cart(CellGrid(CellPoint.Row, CellPoint.Col).GridRow, CellGrid(CellPoint.Row, CellPoint.Col).GridCol)

    End Function

    Private Function GetGridFromPic(ByVal PicPoint As Point) As Cart

        Dim CellPoint As Cart = GetCellFromPic(PicPoint)
        If CellPoint Is Nothing OrElse CellPoint.Row = -1 OrElse CellPoint.Col = -1 Then Return Nothing

        Return GetGridFromCell(CellPoint)

    End Function

#End Region

#Region "Export"

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        If Redrawing Then Exit Sub

        If RecordCount < 1 Then
            MessageBox.Show("There is nothing to Export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sel As New OpenFileDialog
        Try
            ' Display the file open box
            sel.Title = "Select file to export..."
            sel.CheckFileExists = False
            sel.DefaultExt = ".csv"
            sel.Filter = "Delimited (*.csv)|*.csv|Text (*.txt)|*.txt|All (*.*)|*.*"
            sel.FilterIndex = 1
            If sel.ShowDialog(Me) <> DialogResult.OK Then Exit Sub
            Me.Refresh()

            ' Confirm overwrites
            If IO.File.Exists(sel.FileName) Then
                If MessageBox.Show("Do you wish to overwrite the existing file?", "ProGrid Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            End If

            ' Export the data
            Cursor = Cursors.WaitCursor
            Me.Enabled = False
            DataTableExport(dt, sel.FileName)

            ' Inform the user
            MessageBox.Show("Your CSV file has been created." + vbCrLf + vbCrLf + "You should be able to open this with Microsoft Excel.", "ProGrid Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Throw New Exception("Export: " + ex.Message)
        Finally
            Me.Enabled = True
            ReleaseObj(sel)
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DataTableExport(ByVal dt As DataTable, ByVal FullPath As String)

        Dim tw As New IO.StreamWriter(FullPath, False)
        Try
            If dt Is Nothing OrElse ColumnCount = 0 Then Exit Sub
            Dim c As DataColumn

            ' Write the header
            Dim Delimiter As String = ","
            sb.Clear()
            For Each c In dt.Columns
                If Not StyleGet(c).ProVisible OrElse IsBlobColumn(c.ColumnName) OrElse IsTextColumn(c.ColumnName) Then Continue For
                sb.Append(c.ColumnName.Trim).Append(Delimiter)
            Next
            sb.Remove(sb.Length - 1, 1)
            sb.Append(vbCrLf)
            tw.Write(sb.ToString)

            ' Write the data
            If GetRowCount(dt) = 0 Then Exit Sub
            For Each r As DataRow In dt.Rows
                sb.Clear()
                For Each c In dt.Columns
                    If Not StyleGet(c).ProVisible OrElse IsBlobColumn(c.ColumnName) OrElse IsTextColumn(c.ColumnName) Then Continue For
                    sb.Append(Chr(34)).Append(GetFormattedText(c.ColumnName, r(c))).Append(Chr(34)).Append(Delimiter)
                Next
                sb.Remove(sb.Length - 1, 1)
                sb.Append(vbCrLf)
                tw.Write(sb.ToString)

            Next
            tw.Close()
        Finally
            ReleaseObj(tw)
        End Try
    End Sub

    Private Sub ReleaseObj(ByRef obj As Object)
        If obj Is Nothing Then Exit Sub
        Try
            obj.dispose()
        Finally
            obj = Nothing
        End Try
    End Sub

#End Region

#Region "Searching"

    ' The find / find next string
    Private FindString As String = ""

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        If Redrawing Then Exit Sub
        Try
            FindNextMatch(True)
        Catch
        End Try
    End Sub

    Private Sub mnuFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFindNext.Click
        If Redrawing Then Exit Sub
        Try
            FindNextMatch()
        Catch
        End Try
    End Sub

    Private Sub FindNextMatch(Optional ByVal NewMatch As Boolean = False)
        Try
            If RecordCount < 1 Then Exit Sub

            ' Get the search criteria
            If NewMatch OrElse FindString = "" Then
                Dim strSearch As String = InputBox("Enter the string to search for:", "ProGrid Search", FindString).Trim
                If strSearch = "" Then Exit Sub
                FindString = strSearch
            End If

            ' Find the next record
            Cursor = Cursors.WaitCursor
            Dim StartCol As Integer = CurGridCol + 1
            For GridRow As Integer = CurGridRow To RecordCount - 1
                For GridCol As Integer = StartCol To ColumnCount - 1
                    If ColDefs(GridCol).Visible Then
                        If GetFormattedText(GridRow, GridCol).ToUpper.Contains(FindString.ToUpper) Then
                            CellSelect(GridRow, GridCol)
                            Exit Sub
                        End If
                    End If
                Next
                StartCol = 0
            Next
            For GridRow As Integer = 0 To CurGridRow - 1
                For GridCol As Integer = 0 To ColumnCount - 1
                    If ColDefs(GridCol).Visible Then
                        If GetFormattedText(GridRow, GridCol).ToUpper.Contains(FindString.ToUpper) Then
                            CellSelect(GridRow, GridCol)
                            Exit Sub
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            Throw New Exception("FindNext: " + ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Sorting"

    Private SortColumn As Integer = -1
    Private SortDirection As ProGridSortDirection = ProGridSortDirection.None
    Public Enum ProGridSortDirection
        Ascending
        Descending
        Toggle
        None
    End Enum

    ''' <summary>
    ''' Sort on a column.
    ''' </summary>
    ''' <param name="ColumnName">The column name to sort on.</param>
    ''' <param name="Direction">True if ascending, False for descending.</param>
    Public Sub GridSort(ByVal ColumnName As String, Optional ByVal Direction As ProGridSortDirection = ProGridSortDirection.Toggle)
        If dt.Columns.Contains(ColumnName) Then
            GridSort(dt.Columns(ColumnName).Ordinal, Direction)
        End If
    End Sub

    ''' <summary>
    ''' Sort on a column.
    ''' </summary>
    ''' <param name="ColumnIndex">The zero-based column index to sort on.</param>
    ''' <param name="Direction">True if ascending, False for descending.</param>
    Public Sub GridSort(ByVal ColumnIndex As Integer, Optional ByVal Direction As ProGridSortDirection = ProGridSortDirection.Toggle)

        If CurOrientation = ProGridOrienations.Vertical Then Exit Sub

        ' Clear the previous sort
        If SortColumn > -1 AndAlso SortColumn <> ColumnIndex Then
            Dim PreviousSort As ProGridSortDirection = SortDirection
            SortDirection = ProGridSortDirection.None
            ColumnLabel(SortColumn)
            SortDirection = PreviousSort
        End If

        ' Get the new sort direction
        Select Case Direction
            Case ProGridSortDirection.Toggle
                If SortDirection = ProGridSortDirection.Ascending Then
                    SortDirection = ProGridSortDirection.Descending
                Else
                    SortDirection = ProGridSortDirection.Ascending
                End If
            Case ProGridSortDirection.Ascending
                SortDirection = ProGridSortDirection.Ascending
            Case ProGridSortDirection.Descending
                SortDirection = ProGridSortDirection.Descending
            Case Else ' No sort
                Exit Sub
        End Select

        ' Sort
        Select Case SortDirection
            Case ProGridSortDirection.Ascending
                dt = SortDataTable(dt, "[" + dt.Columns(ColumnIndex).ColumnName + "]")
            Case ProGridSortDirection.Descending
                dt = SortDataTable(dt, "[" + dt.Columns(ColumnIndex).ColumnName + "] DESC")
        End Select
        SortColumn = ColumnIndex
        ColumnLabel(ColumnIndex)
        FillHoriz(True)

    End Sub

    Private Sub HeaderColumnClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        ' Get the column clicked
        CellEditClose()
        Dim ColIndex As Integer = Val(sender.tag)

        ' Show context menu if the right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ctxHeader.Tag = ColIndex
            ctxHeader.Show(sender, e.Location)
            Exit Sub
        End If

        ' Toggle Sort
        GridSort(ColIndex)

    End Sub

    Private Sub ClearSorts()

        Dim CurSort As Integer = SortColumn
        SortColumn = -1
        SortDirection = ProGridSortDirection.None
        If CurSort >= 0 Then ColumnLabel(CurSort)

    End Sub

    Private Sub mnuSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSort.Click
        If Redrawing Then Exit Sub
        Dim frm As New frmSort
        Try
            Cursor = Cursors.WaitCursor

            ' Get the sort specification
            frm.pgCaller = Me
            frm.dtUnsorted = dt
            frm.LicenseFolder = LicenseFolder
            frm.ShowDialog(Me)
            Dim SortString As String = frm.SortString
            If SortString = "" Then Exit Sub

            ' Sort the datatable and redisplay
            ClearSorts()
            dt = SortDataTable(dt, SortString)
            FillHoriz(True)

        Catch ex As Exception
            Throw New Exception("Multicolumn Sort: " + ex.Message)
        Finally
            frm = Nothing
            Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Filtering"

    Private dtUnfiltered As DataTable = Nothing

    Private Sub ctxHeader_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxHeader.Opening
        If Redrawing Then Exit Sub
        Try
            Dim GridColIndex As Integer = ctxHeader.Tag

            ctxFilter.Visible = EnableFiltering
            ctxFilter.Enabled = (GetRowCount(dt) > 1 AndAlso (IsStringColumn(GridColIndex) OrElse IsNumericColumn(GridColIndex) OrElse IsDateColumn(GridColIndex)))
            ctxRemoveFilters.Visible = EnableFiltering AndAlso Not EnableEditing
            ctxRemoveFilters.Enabled = (GetRowCount(dt) <> GetRowCount(dtUnfiltered))
            ctxCopyCol.Visible = EnableOptionsCopy
            ctxFilterSep.Visible = (EnableOptionsCopy AndAlso EnableFiltering)

            e.Cancel = Not (EnableFiltering OrElse EnableOptionsCopy)

        Catch
        End Try
    End Sub

    Private Sub ctxFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxFilter.Click
        If Redrawing Then Exit Sub
        Dim frm As New frmFilter
        Try
            Dim GridColIndex As Integer = ctxHeader.Tag

            frm.ColumnName = dt.Columns(GridColIndex).ColumnName
            If IsStringColumn(GridColIndex) Then
                frm.ColumnType = "Text"
            ElseIf IsNumericColumn(GridColIndex) Then
                frm.ColumnType = "Numeric"
            ElseIf IsDateColumn(GridColIndex) Then
                frm.ColumnType = "Date"
            End If
            frm.ShowDialog(Me)
            If frm.Value = "" Then Exit Sub

            ' Apply filter
            Select Case frm.ColumnType
                Case "Text"
                    ApplyFilterText(GridColIndex, frm.Operation, frm.Value)
                Case "Numeric"
                    ApplyFilterNumeric(GridColIndex, frm.Operation, frm.Value)
                Case "Date"
                    ApplyFilterDate(GridColIndex, frm.Operation, frm.Value)
            End Select

        Catch ex As Exception
            Throw New Exception("Filter: " + ex.Message)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub ctxRemoveFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxRemoveFilters.Click
        If Redrawing Then Exit Sub
        Try
            dt = dtUnfiltered.Copy
            DrawGrid(FullRedraw:=True)
            UpdateStatus()
        Catch
        End Try
    End Sub

    Private Sub ApplyFilterText(ByVal GridColIndex As Integer, ByVal Operation As String, ByVal Value As String)

        Value = Value.ToUpper
        For RowIndex As Integer = GetRowCount(dt) - 1 To 0 Step -1

            ' Get current value
            Dim CellValue As String = GetFormattedText(RowIndex, GridColIndex).Trim.ToUpper

            Select Case Operation

                Case "Equals Include Records"
                    If CellValue <> Value Then dt.Rows(RowIndex).Delete()
                Case "Contains Include Records"
                    If Not CellValue.Contains(Value) Then dt.Rows(RowIndex).Delete()
                Case "Starts With Include Records"
                    If Not CellValue.StartsWith(Value) Then dt.Rows(RowIndex).Delete()
                Case "Equals Exclude Records"
                    If CellValue = Value Then dt.Rows(RowIndex).Delete()
                Case "Contains Exclude Records"
                    If CellValue.Contains(Value) Then dt.Rows(RowIndex).Delete()
                Case "Starts With Exclude Records"
                    If CellValue.StartsWith(Value) Then dt.Rows(RowIndex).Delete()

            End Select

        Next

        dt.AcceptChanges()
        DrawGrid(FullRedraw:=True)
        UpdateStatus()

    End Sub

    Private Sub ApplyFilterNumeric(ByVal GridColIndex As Integer, ByVal Operation As String, ByVal Value As Double)

        For RowIndex As Integer = GetRowCount(dt) - 1 To 0 Step -1

            ' Get current value
            Dim CellValue As Double = Val(GetFormattedText(RowIndex, GridColIndex))

            Select Case Operation

                Case "Equals Include Records"
                    If Not IsNumeric(CellValue) OrElse (Val(CellValue) <> Value) Then dt.Rows(RowIndex).Delete()
                Case "Less Than Include Records"
                    If Not IsNumeric(CellValue) OrElse (Val(CellValue) >= Value) Then dt.Rows(RowIndex).Delete()
                Case "Greater Than Include Records"
                    If Not IsNumeric(CellValue) OrElse (Val(CellValue) <= Value) Then dt.Rows(RowIndex).Delete()
                Case "Equals Exclude Records"
                    If Val(CellValue) = Value Then dt.Rows(RowIndex).Delete()
                Case "Less Than Exclude Records"
                    If Val(CellValue) < Value Then dt.Rows(RowIndex).Delete()
                Case "Greater Than Exclude Records"
                    If Val(CellValue) > Value Then dt.Rows(RowIndex).Delete()

            End Select

        Next

        dt.AcceptChanges()
        DrawGrid(FullRedraw:=True)
        UpdateStatus()

    End Sub

    Private Sub ApplyFilterDate(ByVal GridColIndex As Integer, ByVal Operation As String, ByVal Value As DateTime)

        For RowIndex As Integer = GetRowCount(dt) - 1 To 0 Step -1

            ' Get current value
            Dim CellValue As Object = dt.Rows(RowIndex)(GridColIndex)

            Select Case Operation

                Case "Equals Include Records"
                    If Not IsDate(CellValue) OrElse Date.Parse(CellValue).ToShortDateString <> Date.Parse(Value).ToShortDateString Then dt.Rows(RowIndex).Delete()
                Case "Starting On Include Records"
                    If Not IsDate(CellValue) OrElse Date.Parse(CellValue) < Date.Parse(Value) Then dt.Rows(RowIndex).Delete()
                Case "Ending On Include Records"
                    If Not IsDate(CellValue) OrElse Date.Parse(CellValue) > Date.Parse(Value) Then dt.Rows(RowIndex).Delete()
                Case "Equals Exclude Records"
                    If Date.Parse(CellValue).ToShortDateString = Date.Parse(Value).ToShortDateString Then dt.Rows(RowIndex).Delete()
                Case "Starting On Exclude Records"
                    If Date.Parse(CellValue) >= Date.Parse(Value) Then dt.Rows(RowIndex).Delete()
                Case "Ending On Exclude Records"
                    If Date.Parse(CellValue) <= Date.Parse(Value) Then dt.Rows(RowIndex).Delete()

            End Select

        Next

        dt.AcceptChanges()
        DrawGrid(FullRedraw:=True)
        UpdateStatus()

    End Sub

#End Region

#Region "Printing"

    Private WithEvents prn As System.Drawing.Printing.PrintDocument
    Private PrintNextRow As Integer
    Private PrintCurPage As Integer
    Private PrintLeftMargin As Integer
    Private PrintLinesPerPage As Integer
    Private PrintPosX As Integer
    Private PrintPosY As Integer

    Private Sub ctxPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        If Redrawing Then Exit Sub

        If RecordCount < 1 Then
            MessageBox.Show("There is nothing to Print.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        GridPrint()

    End Sub

    ''' <summary>Print the data as currently displayed in the ProGrid.</summary>
    ''' <param name="Title">Title to appear on the report.</param>
    ''' <remarks>Goes to current default printer.</remarks>
    Public Sub GridPrint(Optional ByVal Title As String = "")
        Try

            If dt Is Nothing OrElse GetRowCount(dt) = 0 Then Exit Sub

            ' Instantiate the printer object
            prn = New System.Drawing.Printing.PrintDocument
            If Title.Trim = "" Then prn.DocumentName = PrintTitle Else prn.DocumentName = Title.Trim

            ' Display the printer dialog
            Dim pdlg As New PrintDialog
            pdlg.Document = prn
            pdlg.AllowSomePages = False
            pdlg.AllowCurrentPage = False
            pdlg.AllowPrintToFile = True
            pdlg.AllowSomePages = False
            pdlg.AllowSelection = False
            If pdlg.ShowDialog(Me) <> DialogResult.OK Then Exit Sub

            ' Decide whether to print portrait or landscape
            prn.DefaultPageSettings.Landscape = False
            If CurOrientation = ProGridOrienations.Horizontal Then
                Dim width As Integer = 0
                For ColIndex = 0 To ColDefs.GetUpperBound(0)
                    If ColDefs(ColIndex).Visible Then width += ColDefs(ColIndex).Width
                Next
                If width > prn.DefaultPageSettings.PrintableArea.Width Then prn.DefaultPageSettings.Landscape = True
                If width > prn.DefaultPageSettings.PrintableArea.Width Then
                    If MessageBox.Show("The printout exceeds the width of the page." + vbCrLf + "Not all columns will be printed." + vbCrLf + vbCrLf + "Do you wish to print anyway?", "ProGrid Print Page Width Exceeded", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
                End If
            End If

            ' Initialize the printout
            PrintCurPage = 0
            PrintNextRow = 0
            PrintPosY = 0
            PrintLeftMargin = prn.DefaultPageSettings.PrintableArea.Left
            PrintLinesPerPage = prn.DefaultPageSettings.PrintableArea.Height / RowHeight

            ' Print
            prn.Print()

        Catch ex As Exception
            Throw New Exception("GridPrint: " + ex.Message)
        Finally
            ReleaseObj(prn)
        End Try
    End Sub

    Private Sub prn_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prn.PrintPage
        Try
            ' Configure the page
            PrintCurPage += 1
            PrintPosY += RowHeight
            PrintPosX = PrintLeftMargin

            ' Print the title
            Dim title As String
            title = PrintTitle + " (page " + PrintCurPage.ToString + ")"
            e.Graphics.DrawString(title, CurFontBold, TextBrush, PrintPosX, PrintPosY)
            PrintPosY += RowHeight + (RowHeight / 2)

            If CurOrientation = ProGridOrienations.Horizontal Then
                PrintGridHorizontal(e)
            Else
                PrintGridVertical(e)
            End If
        Catch
        End Try
    End Sub

    Private Sub PrintGridHorizontal(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        ' Print the header row
        For ColIndex = 0 To ColDefs.GetUpperBound(0)
            If ColDefs(ColIndex).Visible Then
                e.Graphics.DrawString(ColDefs(ColIndex).ColumnName, CurFontUnderline, TextBrush, PrintPosX, PrintPosY)
                PrintPosX += ColDefs(ColIndex).Width
                If PrintPosX > prn.DefaultPageSettings.PrintableArea.Right Then Exit For
            End If
        Next
        PrintPosY += (RowHeight / 2)

        ' Print each row
        Dim LineCount As Integer = 0
        Dim FormattedText As String
        For RowIndex As Integer = PrintNextRow To GetRowCount(dt) - 1
            PrintPosX = PrintLeftMargin
            PrintPosY += RowHeight
            For ColIndex = 0 To ColDefs.GetUpperBound(0)
                If ColDefs(ColIndex).Visible Then
                    FormattedText = GetFormattedText(RowIndex, ColIndex)
                    e.Graphics.DrawString(FormattedText, CurFont, TextBrush, PrintPosX, PrintPosY)
                    PrintPosX += ColDefs(ColIndex).Width
                    If PrintPosX > prn.DefaultPageSettings.PrintableArea.Right Then Exit For
                End If
            Next
            LineCount += 1
            If LineCount > PrintLinesPerPage Then
                PrintNextRow = RowIndex + 1
                e.HasMorePages = True
                Exit Sub
            End If
        Next
        e.HasMorePages = False

    End Sub

    Private Sub PrintGridVertical(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        ' Print each row
        Dim LineCount As Integer = 0
        Dim FormattedText As String
        For RowIndex As Integer = PrintNextRow To GetRowCount(dtVert) - 1
            PrintPosX = PrintLeftMargin
            FormattedText = ToStr(dtVert.Rows(RowIndex)("GridColName"))
            e.Graphics.DrawString(FormattedText, CurFont, TextBrush, PrintPosX, PrintPosY)
            PrintPosX += ColDefs(0).Width
            FormattedText = ToStr(dtVert.Rows(RowIndex)("GridData"))
            e.Graphics.DrawString(FormattedText, CurFont, TextBrush, PrintPosX, PrintPosY)
            PrintPosY += RowHeight
            LineCount += 1
            If LineCount > PrintLinesPerPage Then
                PrintNextRow = RowIndex + 1
                e.HasMorePages = True
                Exit Sub
            End If
        Next
        e.HasMorePages = False

    End Sub

#End Region

#Region "Worker Functions"

    ''' <summary>Clears and reinitializes the current grid.</summary>
    Public Sub GridClear()
        Try
            Redrawing = True
            editor.Visible = False
            calendar.Visible = False
            combo.Visible = False
            pic.Visible = False
            lblTip.Visible = False
            picSizer.Visible = False
            pnlHeader.Visible = False
            vsb.Visible = False
            hsb.Visible = False
            ClearSorts()
            CellGrid = Nothing
            dt = New DataTable
            dtVert.Rows.Clear()
            CurCellCol = -1
            CurCellRow = -1
            CurGridCol = -1
            CurGridRow = -1
            CellRows = 0
            CellCols = 0
            If g IsNot Nothing Then
                g.Clear(BackColor)
                pic.Invalidate(False)
                pic.Update()
            End If
            Redrawing = False
            UpdateStatus()
            System.Windows.Forms.Application.DoEvents()

        Catch ex As Exception
            Throw New Exception("GridClear: " + ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Clear (delete) one or all styles from ProGridStyles.
    ''' </summary>
    ''' <param name="StyleName">The style name to delete.</param>
    ''' <remarks>Leave StyleName empty to clear all styles.</remarks>
    Public Sub StyleClear(Optional ByVal StyleName As String = "")
        Try
            StyleName = StyleName.Trim
            If StyleName = "" Then
                ProGridStyles.Clear()
            Else
                If ProGridStyles.ContainsKey(StyleName) Then ProGridStyles.Remove(StyleName)
            End If
            Exit Sub
        Catch ex As Exception
            Throw New Exception("StyleClear: " + ex.Message)
        End Try
    End Sub

    Private Function GetCheckString() As String
        Return ChrW(&H2714)
    End Function

    Private Function CopyRec(ByVal Rect As Rectangle) As Rectangle
        CopyRec.X = Rect.X
        CopyRec.Y = Rect.Y
        CopyRec.Height = Rect.Height
        CopyRec.Width = Rect.Width
    End Function

    Private RanGen As New Random()
    Private Function GetRandom(Optional ByVal Min As Integer = 1, Optional ByVal Max As Integer = 100) As Integer
        Return RanGen.Next(Min, Max + 1)
    End Function

    Private Function AppendIfNeeded(ByVal sText As String, ByVal sAppend As String) As String
        If Microsoft.VisualBasic.Right(sText, sAppend.Length).ToUpper <> sAppend.ToUpper Then
            Return sText + sAppend
        Else
            Return sText
        End If
    End Function

    Private Function IsValidDateFormat(ByVal DateFormat As String) As Boolean
        Try
            Return IsDate(String.Format("{0:" + DateFormat + "}", Now))
        Catch
            Return False
        End Try
    End Function

    Private Function IsFileName(ByVal FileName As String) As Boolean

        If FileName Is Nothing OrElse FileName.Trim = "" Then Return False

        ' Determine if there are bad characters in the name
        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(FileName, badChar) > 0 Then Return False
        Next

        Return True

    End Function

    Private Function GetRowCount(ByVal dt As DataTable) As Integer
        If dt Is Nothing Then Return 0 Else Return dt.Rows.Count
    End Function

    Private Function GetColCount(ByVal dt As DataTable) As Integer
        If dt Is Nothing Then Return 0 Else Return dt.Columns.Count
    End Function

    Private Function IsURL(ByVal Path As String) As Boolean
        If Path Is Nothing OrElse Path.Trim = "" Then Return False
        Path = Path.Trim.ToLower
        If Path.StartsWith("http://") OrElse Path.StartsWith("https://") OrElse Path.StartsWith("www.") Then Return True
        Return False
    End Function

    Private Function GetColumnWidth(ByVal dt As DataTable, ByVal GridCol As Integer) As Integer

        ' If an override string is provided, then just return the length of that
        Dim Style As ProGridStyle = StyleGet(GridCol)
        If Style.ProOverrideString <> "" Then
            Return g.MeasureString(Style.ProOverrideString, CurFontBold).Width + 10
        End If

        ' Configure sampling
        Dim maxpix As Integer = 0
        Dim IncludeHeader As Boolean = True
        Dim MaxRow As Integer = GetRowCount(dt) - 1
        Dim Stepsize As Integer
        Select Case Style.ProSizingMethod
            Case ProGridSizingMethods.HeaderOnly
                Return g.MeasureString(dt.Columns(GridCol).ColumnName, CurFont).Width + 20
            Case ProGridSizingMethods.AllDataOnly
                maxpix = 0
                Stepsize = 1
            Case ProGridSizingMethods.SampledDataOnly
                maxpix = 0
                Stepsize = MaxRow \ 200 + 1
            Case ProGridSizingMethods.AllDataAndHeader
                maxpix = g.MeasureString(dt.Columns(GridCol).ColumnName, CurFont).Width
                Stepsize = 1
            Case Else 'ProGridSizingMethods.SampledDataAndHeader
                maxpix = g.MeasureString(dt.Columns(GridCol).ColumnName, CurFont).Width
                Stepsize = MaxRow \ 200 + 1
        End Select

        ' Get max data length
        Dim pix As Integer
        Dim FormattedText As String
        For GridRow As Integer = 0 To MaxRow Step Stepsize
            FormattedText = GetFormattedText(GridCol, dt.Rows(GridRow)(GridCol))
            pix = g.MeasureString(FormattedText, CurFontBold).Width
            If pix > maxpix Then maxpix = pix
        Next

        ' Include header if requested
        If IncludeHeader Then
            pix = g.MeasureString(dt.Columns(GridCol).ColumnName, CurFont).Width
            If pix > maxpix Then maxpix = pix
        End If
        maxpix += 20
        If Style.ProStyleType = ProGridStyleTypes.DateOnly Then maxpix += 20
        Return maxpix

    End Function

    Private Function GetFormattedText(ByVal GridRow As Integer, ByVal GridCol As Integer) As String
        Dim RawText As Object = dt.Rows(GridRow)(GridCol)
        Return GetFormattedText(dt.Columns(GridCol).ColumnName, RawText)
    End Function

    Private Function GetFormattedText(ByVal GridCol As Integer, ByVal RawText As Object) As String
        If IsDBNull(RawText) Then Return ""
        Return GetFormattedText(dt.Columns(GridCol).ColumnName, RawText)
    End Function

    Private Function GetFormattedText(ByVal ColumnName As String, ByVal RawText As Object) As String
        Try

            If RawText Is Nothing Then Return ""
            If IsDBNull(RawText) Then Return ""

            ' If an override is specified, return that
            Dim Style As ProGridStyle = StyleGet(ColumnName)
            If Style.ProOverrideString <> "" Then Return Style.ProOverrideString

            ' Get the string to format
            Dim FormattedText As String = RawText.ToString.Trim

            ' Clip text if necessary
            If IsStringColumn(ColumnName) Then
                If FormattedText.Length > CellTextMaxLength Then
                    Return "<Text>"
                End If
            End If

            ' Apply style specific formatting
            Select Case Style.ProStyleType
                Case ProGridStyleTypes.Freeform
                    Return FormattedText
                Case ProGridStyleTypes.LowerCase
                    FormattedText = FormattedText.ToLower
                Case ProGridStyleTypes.UpperCase
                    FormattedText = FormattedText.ToUpper
                Case ProGridStyleTypes.TitleCase
                    FormattedText = ToTitle(FormattedText)
                Case ProGridStyleTypes.ZipCode
                    FormattedText = ToZip(FormattedText)
                Case ProGridStyleTypes.PhoneNumber
                    FormattedText = ToPhone(FormattedText)
                Case ProGridStyleTypes.SSN
                    FormattedText = ToSSN(FormattedText)
                Case ProGridStyleTypes.Percent
                    FormattedText = ToPercent(FormattedText)
                Case ProGridStyleTypes.Currency
                    FormattedText = ToCurrency(FormattedText)
                Case ProGridStyleTypes.DateOnly
                    If Not IsDate(FormattedText) Then Return FormattedText
                    FormattedText = String.Format("{0:" + Style.ProFormatString + "}", Date.Parse(FormattedText))
                Case ProGridStyleTypes.TimeOnly
                    If Not IsDate(FormattedText) Then Return FormattedText
                    FormattedText = String.Format("{0:h:mm tt}", Date.Parse(FormattedText))
                Case ProGridStyleTypes.Numeric
                    FormattedText = ToDecimalPlaces(FormattedText, Style.ProDecimalPlaces)
                Case ProGridStyleTypes.Dropdown
                    FormattedText = GetComboDisplayValue(ColumnName, FormattedText)
                Case ProGridStyleTypes.CheckBox
                    If ToStr(FormattedText) = "" Then FormattedText = "False"
                    FormattedText = Convert.ToBoolean(FormattedText)
            End Select
            Return FormattedText
        Catch
            Return RawText
        End Try
    End Function

    Private Function CheckRange(ByVal CellRow As Integer, ByVal CellCol As Integer) As String

        If EnableInvalidCellHandling = ProGridInvalidMethods.Ignore Then Return ""
        Dim GridRow As Integer = CellGrid(CellRow, CellCol).GridRow
        Dim GridCol As Integer = CellGrid(CellRow, CellCol).GridCol
        Dim FormattedText As String = CellGrid(CellRow, CellCol).CellText
        If FormattedText = "" Then Return ""

        ' Check against the Style
        Dim Style As ProGridStyle = StyleGet(GridCol)
        Select Case Style.ProStyleType
            Case ProGridStyleTypes.ZipCode
                If Not IsZip(FormattedText) Then Return "Invalid Zip Code"
            Case ProGridStyleTypes.PhoneNumber
                If Not IsPhone(FormattedText) Then Return "Invalid Phone Number"
            Case ProGridStyleTypes.SSN
                If Not IsSSN(FormattedText) Then Return "Invalid SSN"
            Case ProGridStyleTypes.Percent
                FormattedText = Replace(FormattedText, "%", "")
                If Not IsNumeric(FormattedText) Then Return "Invalid Percent"
            Case ProGridStyleTypes.Currency
                If Not IsNumeric(FormattedText) Then Return "Invalid Currency"
            Case ProGridStyleTypes.DateOnly
                If Not IsDate(FormattedText) Then Return "Invalid Date"
            Case ProGridStyleTypes.TimeOnly
                FormattedText = "1/1/2000 " + FormattedText
                If Not IsDate(FormattedText) Then Return "Invalid Time"
            Case ProGridStyleTypes.Numeric
                If Not IsNumeric(FormattedText) Then Return "Invalid Number"
        End Select

        ' Check Ranges
        If IsNumericColumn(GridCol) OrElse Style.ProStyleType = ProGridStyleTypes.Numeric Then
            If Style.ProMinValue IsNot Nothing AndAlso IsNumeric(Style.ProMinValue) AndAlso FormattedText < Style.ProMinValue Then
                Return "Min=" + GetFormattedText(GridCol, Style.ProMinValue)
            End If
            If Style.ProMaxValue IsNot Nothing AndAlso IsNumeric(Style.ProMaxValue) AndAlso FormattedText > Style.ProMaxValue Then
                Return "Max=" + GetFormattedText(GridCol, Style.ProMaxValue)
            End If
        ElseIf IsDateColumn(GridCol) OrElse Style.ProStyleType = ProGridStyleTypes.DateOnly Then
            If Style.ProMinValue IsNot Nothing AndAlso IsDate(Style.ProMinValue) AndAlso FormattedText < Style.ProMinValue Then
                Return "Min=" + GetFormattedText(GridCol, Style.ProMinValue)
            End If
            If Style.ProMaxValue IsNot Nothing AndAlso IsDate(Style.ProMaxValue) AndAlso FormattedText > Style.ProMaxValue Then
                Return "Max=" + GetFormattedText(GridCol, Style.ProMaxValue)
            End If
        End If

        Return ""

    End Function

    Private Function IsBooleanColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.Boolean
                Return True
        End Select
        Return False
    End Function

    Private Function IsBooleanColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsBooleanColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsBlobColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.Object
                Return True
        End Select
        Return False
    End Function

    Private Function IsBlobColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsBlobColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsDecimalColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.[Single], TypeCode.[Double], TypeCode.[Decimal]
                Return True
        End Select
        Return False
    End Function

    Private Function IsDecimalColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsDecimalColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsSignedColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.[SByte], TypeCode.Int16, TypeCode.Int32, TypeCode.Int64, TypeCode.[Single], TypeCode.[Double], TypeCode.[Decimal]
                Return True
        End Select
        Return False
    End Function

    Private Function IsSignedColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsSignedColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsNumericColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.[Byte], TypeCode.[SByte], TypeCode.Int16, TypeCode.UInt16, TypeCode.Int32, TypeCode.UInt32, TypeCode.Int64, TypeCode.UInt64, TypeCode.[Single], TypeCode.[Double], TypeCode.[Decimal]
                Return True
        End Select
        Return False
    End Function

    Private Function IsNumericColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsNumericColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsStringColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.[Char], TypeCode.String
                Return (dt.Columns(ColumnName).MaxLength <= CellTextMaxLength)
        End Select
        Return False
    End Function

    Private Function IsStringColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsStringColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsTextColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.[Char], TypeCode.String
                Return (dt.Columns(ColumnName).MaxLength > CellTextMaxLength)
        End Select
        Return False
    End Function

    Private Function IsTextColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsTextColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function IsDateColumn(ByVal ColumnName As String) As Boolean
        Select Case Type.GetTypeCode(dt.Columns(ColumnName).DataType)
            Case TypeCode.DateTime
                Return True
        End Select
        Return False
    End Function

    Private Function IsDateColumn(ByVal GridColIndex As Integer) As Boolean
        Return IsDateColumn(dt.Columns(GridColIndex).ColumnName)
    End Function

    Private Function GetDisplayText(ByVal CellRow As Integer, ByVal CellCol As Integer, Optional ByVal TextFont As Font = Nothing) As String
        Dim DisplayText As String
        If CurOrientation = ProGridOrienations.Vertical AndAlso CellCol = 0 Then Return CellGrid(CellRow, CellCol).CellText
        Dim ProOverrideString As String = StyleGet(CellGrid(CellRow, CellCol).GridCol).ProOverrideString
        If ProOverrideString <> "" Then
            DisplayText = ProOverrideString
        Else
            DisplayText = Replace(CellGrid(CellRow, CellCol).CellText, vbCrLf, " ")
        End If
        DisplayText = ClipText(DisplayText, CellGrid(CellRow, CellCol).CellRec.Width, TextFont)
        Return DisplayText
    End Function

    Private Function GetMaxHeaderWidth(ByVal dt As DataTable) As Integer
        Dim pix As Integer
        Dim maxpix As Integer = 0
        For Each c As DataColumn In dt.Columns
            If StyleGet(c).ProVisible Then
                pix = g.MeasureString(c.ColumnName, CurFont).Width
                If pix > maxpix Then maxpix = pix
            End If
        Next
        maxpix += 10
        Return maxpix
    End Function

    Private Function ClipText(ByVal text As String, ByVal pixels As Integer, Optional ByVal TextFont As Font = Nothing) As String
        If text = Nothing Then Return ""
        If TextFont Is Nothing Then TextFont = CurFont
        Dim pixlen As Integer
        Dim ret As String = ""
        For i = text.Length To 1 Step -1
            ret = Microsoft.VisualBasic.Left(text, i)
            pixlen = g.MeasureString(ret, TextFont).Width
            If pixlen <= pixels Then Return Microsoft.VisualBasic.Left(text, i)
        Next
        Return ret
    End Function

    Private Function GetTypeMin(ByVal type As System.Type) As Object
        Select Case System.Type.GetTypeCode(type)
            Case TypeCode.[Byte], TypeCode.UInt16, TypeCode.UInt32, TypeCode.UInt64
                Return 0
            Case TypeCode.Int16
                Return -32768
            Case TypeCode.Int32
                Return -2147483648
            Case TypeCode.Int64
                Return Int64.MinValue
            Case TypeCode.[Single]
                Return -3.402823E+38!
            Case TypeCode.[Double]
                Return -1.7976931348623157E+308
            Case TypeCode.[Decimal]
                Return New Decimal(-1, -1, -1, True, 0)
        End Select
        Return Nothing
    End Function

    Private Function GetTypeMax(ByVal type As System.Type) As Object
        Select Case System.Type.GetTypeCode(type)
            Case TypeCode.[Byte]
                Return 255
            Case TypeCode.Int16
                Return 32767
            Case TypeCode.UInt16
                Return 65535
            Case TypeCode.Int32
                Return 2147483647
            Case TypeCode.UInt32
                Return UInt32.MaxValue
            Case TypeCode.Int64
                Return Int64.MaxValue
            Case TypeCode.UInt64
                Return UInt64.MaxValue
            Case TypeCode.[Single]
                Return Single.MaxValue
            Case TypeCode.[Double]
                Return 1.7976931348623157E+308
            Case TypeCode.[Decimal]
                Return New Decimal(-1, -1, -1, False, 0)
        End Select
        Return Nothing
    End Function

    Dim sbParser As New System.Text.StringBuilder(1000)
    Private Function ToNumericCharsOnly(ByVal Text As String, Optional ByVal DecimalAllowed As Boolean = False, Optional ByVal NegativeAllowed As Boolean = False) As String
        Dim i As Integer
        Dim c As String
        sbParser.Clear()
        For i = 1 To Text.Length
            c = Mid(Text, i, 1)
            If IsNumeric(c) Or (DecimalAllowed And c = ".") Or (NegativeAllowed And c = "-") Then sbParser.Append(c)
        Next
        Return sbParser.ToString
    End Function

    Private Function ToDecimalPlaces(ByVal Number As Object, Optional ByVal ProDecimalPlaces As Integer = 0) As String
        Dim NumText As String = ToNumericCharsOnly(Number.ToString, True, True)
        If Not IsNumeric(NumText) Then Return Number.ToString
        Dim FormatString As String = "{0:0." + New String("0", ProDecimalPlaces) + "}"
        Return String.Format(FormatString, Decimal.Parse(NumText))
    End Function

    Private Function IsPhone(ByVal Phone As String) As Boolean
        Dim NumChars As Integer = ToNumericCharsOnly(Phone).Length
        Return (NumChars = 10 OrElse NumChars = 7)
    End Function

    Private Function ToPhone(ByVal Phone As String) As String
        Dim s As String = ToNumericCharsOnly(Phone)
        If s.Length <> 7 AndAlso s.Length <> 10 Then Return Phone.ToString.Trim
        sbParser.Clear()
        If s.Length = 7 Then
            sbParser.Append(Microsoft.VisualBasic.Left(s, 3)).Append("-").Append(Microsoft.VisualBasic.Right(s, 4))
        Else
            sbParser.Append("(").Append(Microsoft.VisualBasic.Left(s, 3)).Append(") ").Append(Mid(s, 4, 3)).Append("-").Append(Microsoft.VisualBasic.Right(s, 4))
        End If
        Return sbParser.ToString
    End Function

    Private Function IsZip(ByVal zip As String) As Boolean
        Dim NumChars As Integer = ToNumericCharsOnly(zip).Length
        Return (NumChars = 5 OrElse NumChars = 9)
    End Function

    Private Function ToZip(ByVal zip As String) As String
        If Not IsZip(zip) Then Return zip
        Dim s As String = ToNumericCharsOnly(zip)
        If s.Length <> 9 Then Return s
        sbParser.Clear()
        sbParser.Append(Microsoft.VisualBasic.Left(s, 5)).Append("-").Append(Microsoft.VisualBasic.Right(s, 4))
        Return sbParser.ToString
    End Function

    Private Function ToTitle(ByVal sText As String) As String
        sText = sText.Trim
        If sText = "" Then Return ""
        Dim c As Char
        sbParser.Clear()
        sbParser.Append(Microsoft.VisualBasic.Left(sText, 1).ToUpper)
        For i As Integer = 2 To sText.Length
            c = sText.Chars(i - 2)
            If Not Char.IsLetter(c) AndAlso c <> "'" Then
                sbParser.Append(Microsoft.VisualBasic.Mid(sText, i, 1).ToUpper)
            Else
                sbParser.Append(Microsoft.VisualBasic.Mid(sText, i, 1).ToLower)
            End If
        Next
        Return sbParser.ToString()
    End Function

    Private Function ToCurrency(ByVal sText As String) As String
        If sText.Trim = "" Then Return ""
        Dim RawText As String = ToNumericCharsOnly(sText, True, True)
        If Not IsNumeric(RawText) Then Return sText
        Dim amt As Double = Double.Parse(Replace(RawText, "$", "").ToString)
        Return "$" + String.Format("{0:0.00}", amt)
    End Function

    Private Function ToPercent(ByVal sText As String) As String
        If sText.Trim = "" Then Return ""
        Dim RawText As String = ToNumericCharsOnly(sText, True, True)
        If Not IsNumeric(RawText) Then Return sText
        Dim amt As Double = Double.Parse(Replace(RawText, "%", "").ToString)
        Return String.Format("{0:0.00}", amt) + "%"
    End Function

    Private Function IsSSN(ByVal SSN As String) As Boolean
        Dim NumChars As Integer = ToNumericCharsOnly(SSN).Length
        Return (NumChars = 9)
    End Function

    Private Function ToSSN(ByVal SSN As String) As String
        Dim s As String = ToNumericCharsOnly(SSN)
        If s.Length <> 9 Then Return SSN
        sbParser.Clear()
        sbParser.Append(Microsoft.VisualBasic.Left(s, 3)).Append("-").Append(Microsoft.VisualBasic.Mid(s, 4, 2)).Append("-").Append(Microsoft.VisualBasic.Right(s, 4))
        Return sbParser.ToString
    End Function

    Private Function SortDataTable(ByVal dt As DataTable, Optional ByVal SortString As String = "") As DataTable
        Dim rows() As DataRow = dt.Select("", SortString)
        SortDataTable = dt.Clone()
        For Each r As DataRow In rows
            SortDataTable.ImportRow(r)
        Next
        SortDataTable.AcceptChanges()
    End Function

    Private Function GetMouseLocationInControl(ByVal ctrl As Control) As Point
        Return ctrl.PointToClient(Cursor.Position)
    End Function

    Private Function ToStr(ByVal str As Object) As String
        If str Is Nothing OrElse str Is DBNull.Value Then Return ""
        Return str.ToString
    End Function

#End Region

#Region "Colors"

    Private Sub ctxEditLighten_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ctxEditLighten.Click
        If Redrawing Then Exit Sub
        Try
            ColorCellEditable = ColorLighten(ColorCellEditable)
            If EnableEditing AndAlso EnableEditHighlighting Then
                EditBrush = New SolidBrush(ColorCellEditable)
            Else
                EditBrush = New SolidBrush(ColorCell)
            End If
            DrawGrid()
            CellSelect(CurCellRow, CurCellCol)
        Catch
        End Try
    End Sub

    Private Sub ctxEditDarken_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ctxEditDarken.Click
        If Redrawing Then Exit Sub
        Try
            ColorCellEditable = ColorDarken(ColorCellEditable)
            If EnableEditing AndAlso EnableEditHighlighting Then
                EditBrush = New SolidBrush(ColorCellEditable)
            Else
                EditBrush = New SolidBrush(ColorCell)
            End If
            DrawGrid()
            CellSelect(CurCellRow, CurCellCol)
        Catch
        End Try
    End Sub

    Private Sub ctxHighLighten_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ctxHighLighten.Click
        If Redrawing Then Exit Sub
        Try
            ColorCellSelected = ColorLighten(ColorCellSelected)
            SelectBrush = New SolidBrush(ColorCellSelected)
            HighlightCell(CurCellRow, CurCellCol)
        Catch
        End Try
    End Sub

    Private Sub ctxHighDarken_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ctxHighDarken.Click
        If Redrawing Then Exit Sub
        Try
            ColorCellSelected = ColorDarken(ColorCellSelected)
            SelectBrush = New SolidBrush(ColorCellSelected)
            HighlightCell(CurCellRow, CurCellCol)
        Catch
        End Try
    End Sub

    Private Function ColorDarken(ByVal CurColor As Color, Optional ByVal Factor As Double = 0.25) As Color
        Dim red As Double = CurColor.R - (255 - CurColor.R) * Factor
        Dim green As Double = CurColor.G - (255 - CurColor.G) * Factor
        Dim blue As Double = CurColor.B - (255 - CurColor.B) * Factor
        If red < 0 OrElse red > 255 OrElse green < 0 OrElse green > 255 OrElse blue < 0 OrElse blue > 255 Then Return CurColor
        ColorDarken = Color.FromArgb(CurColor.A, red, green, blue)
    End Function

    Private Function ColorLighten(ByVal CurColor As Color, Optional ByVal Factor As Double = 0.25) As Color
        Dim red As Double = (255 - CurColor.R) * Factor + CurColor.R
        Dim green As Double = (255 - CurColor.G) * Factor + CurColor.G
        Dim blue As Double = (255 - CurColor.B) * Factor + CurColor.B
        If red < 0 OrElse red > 255 OrElse green < 0 OrElse green > 255 OrElse blue < 0 OrElse blue > 255 Then Return CurColor
        ColorLighten = Color.FromArgb(CurColor.A, red, green, blue)
    End Function

#End Region

#Region "Column Resizing"

    Private Sub ctxResizeToData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxResizeToData.Click
        Try
            Dim GridColIndex As Integer = ctxHeader.Tag

            StyleGet(GridColIndex).ProSizingMethod = ProGridSizingMethods.AllDataOnly
            ColDefs(GridColIndex).Width = GetColumnWidth(dt, GridColIndex)
            HorizDrawGrid(False, False)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ctxResizeToHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxResizeToHeader.Click
        Try
            Dim GridColIndex As Integer = ctxHeader.Tag

            StyleGet(GridColIndex).ProSizingMethod = ProGridSizingMethods.HeaderOnly
            ColDefs(GridColIndex).Width = GetColumnWidth(dt, GridColIndex)
            HorizDrawGrid(False, False)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Liscensing"

    Private _LicenseFilePath As String = ""

    ''' <summary>Set the path to the folder with the user's license file.</summary>
    Public Property LicenseFolder() As String
        Get
            Return _LicenseFilePath
        End Get
        Set(ByVal LicenseFilePath As String)
            Dim LicenseFile As String = AppendIfNeeded(LicenseFilePath.Trim, "\") + "ProGridComponent.lic"
            _LicenseFilePath = LicenseFilePath
            LicenseInfo.LicenseFile = LicenseFile
        End Set
    End Property

    Structure LicenseInfoStruct
        Friend LicenseFile As String
        Friend LicenseStatus As String
        Friend Purchaser As String
        Friend PurchaseDate As Date
        Friend PurchaserEmail As String
    End Structure
    Private LicenseInfo As LicenseInfoStruct

    Private Sub CheckLicense()
        Try

            ' Check if license verification is disabled
            If Not EnforceLicense Then Exit Sub

            ' Don't check for a license if not running in Visual Studio
            If Not InVisualStudio() Then Exit Sub

            ' Skip if we already validated the license
            If LicenseInfo.LicenseStatus = "Valid" Then Exit Sub

            ' Randomize the check so it only happens about 1 in 4 times
            If GetRandom() < 75 Then Exit Sub

            ' See if a license file exists
            If Not IO.File.Exists(LicenseInfo.LicenseFile) Then
                MessageBox.Show("This is a reminder to license your evaluation copy of ProGrid." + vbCrLf + vbCrLf + "If you have already purchased a copy, be sure to assign the LicenseFolder property to avoid these reminders." + vbCrLf + vbCrLf + "If you have not purchased ProGrid yet, you can do so at http://surgicalgrade.net/progrid/buy-it/.", "ProGrid Evaluation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Load the key
            Dim LicenseKey As String = IO.File.ReadAllText(LicenseInfo.LicenseFile)

            ' Verify the signature
            Dim IsValid As Boolean = VerifyWithPublic(LicenseKey, My.Resources.PublicKey)
            If Not IsValid Then
                MessageBox.Show("Your license file is apparently invalid." + vbCrLf + vbCrLf + "You may have a license file that has been tampered with. Please ensure that your file is the one provided to you by the vendor.", "ProGrid Licensing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            LicenseInfo.LicenseStatus = "Valid"

        Catch ex As Exception
            MessageBox.Show("An Error was encountered while trying to validate your license file." + vbCrLf + vbCrLf + ex.Message, "ProGrid Licensing", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ' Check is we are currently running in Visual Studio
    Private Function InVisualStudio() As Boolean
        Dim process As System.Diagnostics.Process = process.GetCurrentProcess()
        Dim s As String = process.ProcessName
        InVisualStudio = process.ProcessName.ToLower.Trim.EndsWith(".vshost")
        process.Dispose()
        process = Nothing
    End Function

    ' Verify an xml document with a public key
    Private Function VerifyWithPublic(ByVal LicenseKey As String, ByVal strPublicKey As String) As [Boolean]

        ' Get key
        Dim key As New System.Security.Cryptography.RSACryptoServiceProvider()
        key.FromXmlString(strPublicKey)

        ' Create an XmlDoc
        Dim Doc As New System.Xml.XmlDocument
        Doc.LoadXml(LicenseKey)

        ' Create a new SignedXml object and pass it the XML document class
        Dim signedXml As New System.Security.Cryptography.Xml.SignedXml(Doc)

        ' Find the Signature node and create a new XmlNodeList object
        Dim nodeList As System.Xml.XmlNodeList = Doc.GetElementsByTagName("Signature")

        ' Throw an exception if no signature was found
        If nodeList.Count <> 1 Then Return False

        ' Load the signature node
        signedXml.LoadXml(CType(nodeList(0), System.Xml.XmlElement))

        ' Parse the User information from the XML
        Dim node As System.Xml.XmlNode = Doc.SelectSingleNode("root/purchaser")
        LicenseInfo.Purchaser = node.InnerText
        node = Doc.SelectSingleNode("root/email")
        LicenseInfo.PurchaserEmail = node.InnerText
        node = Doc.SelectSingleNode("root/purchasedate")
        LicenseInfo.PurchaseDate = Date.Parse(node.InnerText)

        ' Release the XML document
        Doc = Nothing

        ' Check the signature and return the result
        Return signedXml.CheckSignature(key)

    End Function

#End Region

End Class
