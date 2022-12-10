Imports ProGrid.ProGrid

''' <summary>Used by the ProGrid to enter a multicolumn sort.</summary>
Public Class frmSort

    Public pgCaller As ProGrid
    Public dtUnsorted As DataTable = Nothing
    Public SortString As String = ""
    Public LicenseFolder As String = ""

    Private dtSort As DataTable = Nothing

    Private Sub frmSortSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor

            ' Set the license file
            pg.LicenseFolder = LicenseFolder

            ' Configure sort selection table
            dtSort = New DataTable
            dtSort.Columns.Add("Column Name", GetType(String))
            dtSort.Columns.Add("Sort Order", GetType(Integer))
            dtSort.Columns.Add("Direction", GetType(String))
            For Each c As DataColumn In dtUnsorted.Columns
                If pgCaller.StyleGet(c).ProVisible Then
                    dtSort.Rows.Add(c.ColumnName, DBNull.Value, "")
                End If
            Next

            ' Create the Sort Direction dropdown choices
            Dim dtDirection As New DataTable
            dtDirection.Columns.Add("Direction", GetType(String))
            dtDirection.Rows.Add("Ascending")
            dtDirection.Rows.Add("Descending")

            ' Configure and display grid
            pg.ButtonSet(1, "Sort", "Close sort dialog and perform sort", "Sort")
            pg.ButtonSet(2, "Cancel", "Close sort dialog and cancel sorting", "Cancel")
            pg.EnableEditing = True
            pg.EnableOptionsButton = False
            pg.StyleSet("Column Name", New ProGridStyle(ProGridStyleTypes.Freeform, editable:=False))
            pg.StyleSet("Direction", New ProGridStyle(ProGridStyleTypes.Dropdown, Dropdown:=dtDirection))
            pg.StyleSet("Sort Order", New ProGridStyle(ProGridStyleTypes.Numeric))
            pg.GridShow(dtSort)
            pg.CellSelect(0, 1)

        Catch ex As Exception
            Throw New Exception("ProGrid Error in Sort Load - " + ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub sg_ToolButtonClicked(ByVal ButtonTag As System.String) Handles pg.UserClickedButton
        Select Case ButtonTag
            Case "Sort"
                Dim rows() As DataRow = dtSort.Select("[Sort Order] > 0", "[Sort Order]")
                If rows.Length > 0 Then
                    For Each r As DataRow In rows
                        SortString += "[" + r("Column Name") + "]"
                        If r("Direction") = "Descending" Then SortString += " DESC"
                        SortString += ", "
                    Next
                    SortString = Microsoft.VisualBasic.Left(SortString, SortString.Length - 2)
                End If
        End Select
        Me.Close()
    End Sub

End Class