
Imports System.Data.Odbc
    Imports MySql.Data.MySqlClient
Public Class QueryResultsDGV

    'ViewSQL_KeyDown KEYS: CTRL+R = RUN QUERY, CTRL+SHIFT+C = CLOSE FORM

    Dim GlobalParms As New ESPOParms.Framework
    Dim GlobalSession As New ESPOParms.Session
    Dim FieldAttributes As New ColumnAttributes.ColumnAttributes
    Dim SQLStatement As String


    Public Sub GetParms(Session As ESPOParms.Session, Parms As ESPOParms.Framework)
        GlobalParms = Parms
        GlobalSession = Session
    End Sub

    Private Sub ViewSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        KeyPreview = True
        Me.MdiParent = FromHandle(GlobalSession.MDIParentHandle)
        For Each c As Control In Controls
            AddHandler c.MouseClick, AddressOf ClickHandler
        Next
        'btnRun.PerformClick()
    End Sub

    Sub PopulateForm(SQLQuery As String, objFieldAttributes As Object)
        SQLStatement = SQLQuery
        txtSQLQuery.Text = SQLStatement
        FieldAttributes = objFieldAttributes
    End Sub

    Private Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Select Case e.Button
            Case MouseButtons.Left
                Me.BringToFront()
        End Select
    End Sub

    '    Public Shared Function ExecuteMySQLQuery(SqlStatement As String) As DataTable
    '   Dim ConnString As String
    '  Dim ZeroDatetime As Boolean = True
    ' Dim Server As String = "localhost"
    'Dim DbaseName As String = "simplequerybuilder"
    'Dim USERNAME As String = "root"
    'Dim password As String = "root"
    'Dim port As String = "3306"
    '
    '   ExecuteMySQLQuery = Nothing
    'Try
    '       'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
    '      ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)
    'Dim cn As New MySqlConnection(ConnString)
    '       cn.Open()
    'Dim cmd As New MySqlCommand
    '       cmd.Connection = cn
    '      cmd.CommandTimeout = 0
    '     cmd.CommandType = CommandType.Text
    '    cmd.CommandText = SqlStatement
    'Dim da As New MySqlDataAdapter(cmd)
    'Dim ds As New DataSet
    '       da.Fill(ds)
    'Return ds.Tables(0)
    'Catch ex As Exception
    '       MsgBox("DB ERROR: " & ex.Message)
    'End Try
    'End Function

    Public Shared Function ExecuteSQLQuery(ConnectString As String, SQLStatement As String) As DataTable
        '    Dim ConnectString As String
        '    ConnectString = GlobalSession.ConnectString
        'ConnectString = "Provider=MSDASQL.1;DRIVER=Client Access ODBC Driver (32-bit);SYSTEM=PARAGON;TRANSLATE=1;DBQ=,epobespliv,epobesiliv, ault2f3,ault1f3,epocrmfliv,epoapefliv,epoutility,islrtgf,aulamf3,eposysfliv,zxref;DFTPKGLIB=QGPL;LANGUAGEID=ENU;PKG=QGPL/DEFAULT(IBM),2,0,1,0,512;LIBVIEW=1;CONNTYPE=0;userid=odbcuser;password=odbcuser;Initial Catalog=PARAGON;NAM=1 "
        Dim cn As New OdbcConnection(ConnectString)
        Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
        cn.Open()
        cm.CommandTimeout = 0
        cm.CommandType = CommandType.Text
        cm.CommandText = SQLStatement
        Dim da As New OdbcDataAdapter(cm)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function

    Public Shared Function ExecuteMySQLQuery(SqlStatement As String) As DataTable
        Dim ConnString As String
        Dim ZeroDatetime As Boolean = True
        Dim Server As String = "localhost"
        Dim DbaseName As String = "simplequerybuilder"
        Dim USERNAME As String = "root"
        Dim password As String = "root"
        Dim port As String = "3306"

        ExecuteMySQLQuery = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = cn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SqlStatement
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Cursor = Cursors.WaitCursor
        Refresh()
        Dim dt As New DataTable

        Try
            dgvOutput.DataSource = Nothing
            Refresh()
            tssLabel1.Text = "Getting Data"
            Refresh()
            dt = ExecuteSQLQuery(GlobalSession.ConnectString, txtSQLQuery.Text)
            'dt = ExecuteMySQLQuery(txtSQLQuery.Text)


            If dt IsNot Nothing Then
                If dt.Rows.Count = 0 Then
                    'MsgBox("No records")
                    tssLabel1.Text = "Records: 0"
                Else
                    tssLabel1.Text = "Loading Data to Grid"
                    Refresh()
                    dgvOutput.DataSource = dt
                    tssLabel1.Text = "Formatting Grid"
                    Refresh()
                    FormatGrid()
                    dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
                    tssLabel1.Text = "Records:" & dt.Rows.Count
                End If
            End If

        Catch ex As Exception
            MsgBox("Output Error: " & ex.Message)
        End Try
        Cursor = Cursors.Default
        Refresh()
    End Sub

    Private Sub FormatGrid()
        Dim ColumnName As String
        Dim ColumnText As String
        Dim ColumnType As String
        Dim ColumnDecimals As String
        '
        For i As Integer = 0 To dgvOutput.Columns.Count - 1
            ColumnText = dgvOutput.Columns(i).HeaderText
            ColumnName = FieldAttributes.GetFieldNameFromFieldText(ColumnText)
            ColumnType = FieldAttributes.GetSelectedFieldType(ColumnName)
            ColumnDecimals = CStr(FieldAttributes.GetSelectedFieldDecimals(ColumnName))
            If ColumnType = "A" Then
                dgvOutput.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            ElseIf ColumnType = "L" Then
                dgvOutput.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            ElseIf ColumnType = "N" Or ColumnText = "Count" Then
                dgvOutput.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvOutput.Columns(i).DefaultCellStyle.Format = "N" & ColumnDecimals
            End If
        Next i
    End Sub


    Private Sub UndockChild()
        If Me.MdiParent Is Nothing Then
            Me.MdiParent = FromHandle(GlobalSession.MDIParentHandle)
        Else
            Me.MdiParent = Nothing
        End If
    End Sub

    Private Sub ViewSQL_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F5 Then
            'btnRefresh.PerformClick()
        ElseIf e.KeyValue = 27 Then 'ESC pressed
            'Clear certain fields
        ElseIf e.KeyValue = Keys.F7 Then
            UndockChild()
        ElseIf (e.Control AndAlso (e.Shift) AndAlso (e.KeyCode = Keys.C)) Then
            btnClose.PerformClick()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.R)) Then
            btnRun.PerformClick()
        End If
    End Sub

    Private Sub btnViewAttributes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Cursor = Cursors.WaitCursor
        Refresh()
        Dim rsADO As ADODB.Recordset
        rsADO = ExecuteSQL(GlobalSession.ConnectString, SQLStatement)
        ExportToExcel2("Report Title", rsADO)
    End Sub

    Public Function ExecuteSQL(ConnectString As String, SQLStatement As String) As ADODB.Recordset
        Dim rs As New ADODB.Recordset
        Dim cn As New ADODB.Connection
        cn.ConnectionString = ConnectString
        cn.Open()
        cn.CommandTimeout = 0
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.LockType = ADODB.LockTypeEnum.adLockReadOnly
        rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        rs.Open(SQLStatement, cn)
        Return rs
    End Function
    Private Sub ExportToExcel2(ReportName As String, rsADO As ADODB.Recordset)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim XLName As String

        XLName = "P:" & Trim(ReportName) & ".xlsx"

        Me.Cursor = Cursors.WaitCursor
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For lngCount = 1 To rsADO.Fields.Count
            xlWorkSheet.Cells(1, lngCount).Font.Bold = True
            xlWorkSheet.Cells(1, lngCount) = rsADO.Fields.Item(lngCount - 1).Name
        Next lngCount


        xlWorkSheet.Cells(2, 1).CopyFromRecordset(rsADO)

        xlWorkSheet.Range("A1:AZ1").Font.Bold = True
        xlWorkSheet.Range("A1").AutoFilter(Field:=1)
        xlWorkSheet.Columns.AutoFit()

        xlApp.ActiveWindow.SplitColumn = 0
        xlApp.ActiveWindow.SplitRow = 1
        xlApp.ActiveWindow.FreezePanes = True

        'xlWorkSheet.Cells.Columns("J").NumberFormat = "#,##0"

        'xlWorkSheet.Cells(rsADO.RecordCount + 2, "J") = "=SUBTOTAL(9,J2:J" & rsADO.RecordCount + 1 & ")"
        'xlWorkSheet.Cells(rsADO.RecordCount + 2, "J").Font.Bold = True

        '        xlWorkSheet.SaveAs(XLName)
        '        xlWorkBook.Close()
        '        xlApp.Quit()

        xlApp.Visible = True

        Try
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString, MsgBoxStyle.Critical, "Error!")
        End Try

        Me.Cursor = Cursors.Default
        Me.Refresh()

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
