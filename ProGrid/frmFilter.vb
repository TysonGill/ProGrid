''' <summary>Used by the ProGrid to enter a numeric filter.</summary>
Public Class frmFilter

    Public ColumnName As String = ""
    Public ColumnType As String = ""
    Public Operation As String = ""
    Public Value As String = ""

    Private Sub frmFilterText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblColumnName.Text = ColumnName
        Me.Text = "ProGrid " + ColumnType + " Filter"
        Select Case ColumnType
            Case "Text"
                optAlt1.Text = "Contains"
                optAlt2.Text = "Starts With"
            Case "Numeric"
                optAlt1.Text = "Less Than"
                optAlt2.Text = "Greater Than"
            Case "Date"
                optAlt1.Text = "Starting On"
                optAlt2.Text = "Ending On"
        End Select
        cboLogic.SelectedIndex = 0
        txtValue.Select()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Value = txtValue.Text.Trim
        Select Case ColumnType
            Case "Text"
                If Value = "" Then
                    MessageBox.Show("You must enter a text value for your filter comparison.", "Text Filtering", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtValue.Select()
                    Exit Sub
                End If
            Case "Numeric"
                If Value = "" OrElse Not IsNumeric(Value) Then
                    MessageBox.Show("You must enter a numeric value for your filter comparison.", "Numeric Filtering", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtValue.Select()
                    Exit Sub
                End If
            Case "Date"
                If Value = "" OrElse Not IsDate(Value) Then
                    MessageBox.Show("You must enter a date value for your filter comparison.", "Date Filtering", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtValue.Select()
                    Exit Sub
                End If
        End Select

        If optEquals.Checked Then
            Operation = optEquals.Text
        ElseIf optAlt1.Checked Then
            Operation = optAlt1.Text
        ElseIf optAlt2.Checked Then
            Operation = optAlt2.Text
        End If
        Operation += " " + cboLogic.Text
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Value = ""
        Me.Close()
    End Sub

    Private Sub optEquals_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEquals.CheckedChanged, optAlt1.CheckedChanged, optAlt2.CheckedChanged
        txtValue.Select()
    End Sub

End Class