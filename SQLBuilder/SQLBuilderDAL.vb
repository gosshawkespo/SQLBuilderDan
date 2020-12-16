﻿'**********************************************************************************************************
' DAL (Data Access Layer) Code Template. Dan Goss v90 SEP 14 2020
'**********************************************************************************************************
Imports System.Data.Odbc
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class SQLBuilderDAL

    Function GetHeaderList(ConnectString As String, Tablename As String, ByRef DatasetID As Integer) As DataTable
        Dim cn As New OdbcConnection(ConnectString)
        Dim SQLStatement As String
        Dim dt As DataTable

        GetHeaderList = Nothing
        DatasetID = 0
        SQLStatement = "SELECT " &
            "trim(DatasetName) as ""DataSet Name"", " &
            "trim(DataSetHeaderText) as ""DataSet Header Text"", " &
            "trim(Tablename) as ""Tablename"", " &
            "trim(AuthorityFlag) as ""Authority Flag"", " &
            "trim(CRTuserID) as ""CRT userID"", " &
            "CRTTIMESTAMP as ""CRT Timestamp"", " &
            "UPDUserID as ""UPD UserID"", " &
            "UPDTimestamp as ""UPD Timestamp"", " &
            "DatasetID " &
            "FROM ebi7020t "
        If Tablename <> "" Then
            SQLStatement += " WHERE Tablename='" & Tablename & "' "
        End If
        SQLStatement += "ORDER BY DatasetName"
        Try
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            If IsNothing(dt) Then
                Exit Function
            End If
            If dt.Rows.Count = 0 Then
                Exit Function
            End If
            If Not IsDBNull(dt.Rows(0)("DatasetID")) Then
                DatasetID = dt.Rows(0)("DatasetID")
            Else
                DatasetID = 0
            End If
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try

    End Function

    Function GetColumns(ConnectString As String, DatasetID As Integer, Tablename As String, ColumnName As String) As DataTable
        Dim cn As New OdbcConnection(ConnectString)
        Dim SQLStatement As String
        Dim strWhere As String

        GetColumns = Nothing
        strWhere = ""
        If DatasetID > 0 Then
            If strWhere <> "" Then
                strWhere += " AND "
            End If
            strWhere += "DatasetID= " & DatasetID
        End If
        If Tablename <> "" Then
            If strWhere <> "" Then
                strWhere += " AND "
            End If
            strWhere += "Tablename= '" & Tablename & "'"
        End If
        If ColumnName <> "" Then
            If strWhere <> "" Then
                strWhere += " AND "
            End If
            strWhere += "ColumnName= '" & ColumnName & "'"
        End If
        SQLStatement = "SELECT " &
            "trim(Tablename) as ""Tablename"", " &
            "trim(ColumnName) as ""Column Name"", " &
            "trim(ColumnText) as ""Column Text"", " &
            "trim(ColumnType) as ""Column Type"", " &
            "ColumnLength as ""Column Length""," &
            "ColumnDecimals as ""Column Decimals"", " &
            "ColumnID as ""Column ID"" " &
            "FROM ebi7023t "
        If DatasetID > 0 Or Tablename <> "" Or ColumnName <> "" Then
            SQLStatement += "WHERE " & strWhere & " "
        End If
        SQLStatement += " ORDER BY Tablename,Sequence"
        Try
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR in GetColumns(): " & ex.Message)
        End Try

    End Function

    Function GetHeaderAndColumns(ConnectString As String, DatasetID As Integer) As DataTable
        Dim cn As New OdbcConnection(ConnectString)
        Dim SQLStatement As String
        Dim strWhere As String

        GetHeaderAndColumns = Nothing
        strWhere = ""
        If DatasetID > 0 Then
            If strWhere <> "" Then
                strWhere += " AND "
            End If
            strWhere += "h.DatasetID= " & DatasetID
        End If
        'Check both tables contain identical datasetID 
        SQLStatement = "SELECT " &
            "h.DatasetID as ""Dataset ID"", " &
            "trim(h.Tablename) as ""Tablename"", " &
            "h.DatasetName as ""Dataset Name"", " &
            "trim(h.DataSetHeaderText) as ""DataSet Header Text"", " &
            "d.SEQUENCE as ""Sequence"", " &
            "trim(h.AuthorityFlag) as ""Auth Flag"", " &
            "trim(d.ColumnName) as ""Column Name"", " &
            "trim(d.ColumnText) as ""Column Text"", " &
            "trim(d.ColumnType) as ""Column Type"", " &
            "d.ColumnLength as ""Column Length""," &
            "d.ColumnDecimals as ""Column Decimals"", " &
            "d.ColumnID as ""Column ID"" " &
            "FROM ebi7020t as h" &
            " JOIN ebi7023t as d ON h.DatasetID = d.DatasetID"
        SQLStatement += " WHERE " & strWhere & " "
        SQLStatement += " ORDER BY d.Tablename,d.Sequence"
        Try
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try
    End Function

    Function CheckTableExists(ConnectString As String, Tablename As String) As DataTable
        Dim cn As New OdbcConnection(ConnectString)
        Dim SQLStatement As String

        CheckTableExists = Nothing
        SQLStatement = "SELECT * FROM " & Tablename
        Try
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR in CheckTableExists: " & ex.Message)
        End Try

    End Function

    Function GetLastID(ConnectString As String, Tablename As String, PrimaryField As String) As Integer
        Dim cn As New OdbcConnection(ConnectString)
        Dim SQLStatement As String
        Dim dt As DataTable
        Dim LastID As Integer

        GetLastID = 0
        LastID = 0
        Try
            cn.Open()
            SQLStatement = "SELECT MAX(" & PrimaryField & ") AS ""MAX"" " &
            "FROM " & Tablename

            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            If Not IsDBNull(dt.Rows(0)("MAX")) Then
                LastID = dt.Rows(0)("MAX")
            Else
                LastID = 0
            End If

            Return LastID

        Catch ex As Exception
            MsgBox("DB ERROR in GetLastID: " & ex.Message)
        End Try
    End Function

    Function GetLastID_MYSQL(Tablename As String, PrimaryField As String) As Integer
        Dim cn As MySqlConnection
        Dim SQLStatement As String
        Dim dt As DataTable
        Dim LastID As Integer
        Dim ConnString As String

        ConnString = GetMYSQLConnection()
        cn = New MySqlConnection(ConnString)
        GetLastID_MYSQL = 0
        LastID = 0
        Try
            cn.Open()
            SQLStatement = "SELECT MAX(" & PrimaryField & ") ""MAX"" " &
            "FROM " & Tablename

            Dim cm As MySqlCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            LastID = dt.Rows(0)("MAX")
            Return LastID

        Catch ex As Exception
            MsgBox("DB ERROR in GetLastID_MYSQL: " & ex.Message)
        End Try
    End Function

    Function LocateDataSetID_SQL(ConnectString As String, TableName As String) As DataTable
        Dim cn As New OdbcConnection(ConnectString)
        Dim SQLStatement As String

        LocateDataSetID_SQL = Nothing
        Try
            cn.Open()
            SQLStatement = "SELECT " &
            "DataSetID,DatasetName " &
            "FROM ebi7020t " &
            "Where Tablename= '" & TableName & "'"

            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New OdbcDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)

        Catch ex As Exception
            MsgBox("DB ERROR in LocateDataSetID_SQL: " & ex.Message)
        End Try

    End Function

    Public Function Update_DatasetHeader(
                    ConnectString As String,
                    ByRef DatasetID As Integer,
                    DatasetName As String,
                    DatasetHeaderText As String,
                    Tablename As String,
                    AuthFlag As String,
                    CreatedUserID As String,
                    UpdUserID As String
) As Integer
        Dim SQLStatement As String
        Dim SQLOK As Boolean = True
        Dim cn As New OdbcConnection(ConnectString)
        Dim Result As Integer
        Dim UpdTimestamp As String = Now().ToString("yyyy-MM-dd-HH.mm.ss")
        Dim CrtTimestamp As String = Now().ToString("yyyy-MM-dd-HH.mm.ss")
        Dim DatasetTable As String = "EBI7020T"
        Dim dtTest As DataTable

        If Tablename = "" Then
            MsgBox("Update_DatasetHeader(): Tablename cannot be blank")
            Exit Function
        End If
        cn.Open()
        Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
        Result = 0
        SQLStatement =
        "Select DatasetID  " &
        "From " & DatasetTable
        If DatasetID > 0 Then
            SQLStatement = SQLStatement & " Where DatasetID =" & DatasetID & " "
        Else
            SQLStatement = SQLStatement & " Where Tablename ='" & Tablename & "' "
        End If

        cm.CommandTimeout = 0
        cm.CommandType = CommandType.Text
        cm.CommandText = SQLStatement
        Dim da As New OdbcDataAdapter(cm)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            SQLStatement =
            "Update " & DatasetTable & " " &
            "set " &
            "DatasetName='" & DatasetName.ToUpper & "', " &
            "DatasetHeaderText='" & DatasetHeaderText & "', " &
            "Tablename='" & Tablename.ToUpper & "', " &
            "AuthorityFlag='" & AuthFlag & "', " &
            "UPDUserID='" & CreatedUserID & "', " &
            "UPDTIMESTAMP='" & UpdTimestamp & "' " &
            "Where Tablename= '" & Tablename.ToUpper & "' "
            Result = 2
        Else
            SQLStatement =
            "Insert into " & DatasetTable & " (" &
            "DatasetName, " &
            "DatasetHeaderText, " &
            "Tablename, " &
            "AuthorityFlag, " &
            "CRTUserID, " &
            "CRTTIMESTAMP, " &
            "UPDUserID, " &
            "UPDTIMESTAMP" &
            ") " &
            "Values (" &
            "'" & DatasetName.ToUpper & "', " &
            "'" & DatasetHeaderText & "', " &
            "'" & Tablename.ToUpper & "', " &
            "'" & AuthFlag & "', " &
            "'" & CreatedUserID & "', " &
            "'" & CrtTimestamp & "', " &
            "'" & UpdUserID & "', " &
            "'" & UpdTimestamp & "'" &
            ")"
            Result = 1

        End If
        cm.CommandText = SQLStatement
        Dim da1 As New OdbcDataAdapter(cm)
        Dim ds1 As New DataSet
        Try
            da1.Fill(ds1)
            'dtTest = ds1.Tables(0)
            If Result = 1 Then
                DatasetID = GetLastID(ConnectString, DatasetTable, "DatasetID")
            End If

        Catch ex As Exception
            Result = 3
            SQLOK = False
            MsgBox("Error in Update_DatasetHeader: " & ex.Message)
        End Try
        Return (Result)
    End Function

    Public Function Update_DatasetColumns(
                    ConnectString As String,
                    DatasetID As Integer,
                    DatasetName As String,
                    Sequence As Integer,
                    Tablename As String,
                    ColumnName As String,
                    ColumnText As String,
                    ColumnType As String,
                    ColumnLength As Integer,
                    ColumnDecimals As Integer,
                    ColumnID As Integer
) As Integer
        Dim SQLStatement As String
        Dim SQLOK As Boolean = True
        Dim cn As New OdbcConnection(ConnectString)
        Dim Result As Integer
        Dim CrtTimestamp As String = Now().ToString("yyyy-MM-dd-HH.mm.ss")
        Dim UpdTimestamp As String = Now().ToString("yyyy-MM-dd-HH.mm.ss")
        Dim DatasetTable As String = "EBI7023T"
        Dim dtTest As DataTable

        'Update using Tablename and Columnname (not datasetName)
        cn.Open()
        Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
        Result = 0
        SQLStatement =
        "Select DatasetID,Sequence,Tablename,ColumnName " &
        "From " & DatasetTable &
        " Where Tablename= '" & Tablename & "' AND ColumnName= '" & ColumnName & "'"
        cm.CommandTimeout = 0
        cm.CommandType = CommandType.Text
        cm.CommandText = SQLStatement
        Dim da As New OdbcDataAdapter(cm)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            SQLStatement =
            "Update " & DatasetTable & " " &
            "set " &
            "DatasetID=" & DatasetID & ", " &
            "DatasetName='" & DatasetName.ToUpper & "', " &
            "SEQUENCE=" & Sequence & ", " &
            "Tablename='" & Tablename.ToUpper & "', " &
            "ColumnName='" & ColumnName.ToUpper & "', " &
            "ColumnText='" & ColumnText & "', " &
            "ColumnType='" & ColumnType.ToUpper & "', " &
            "ColumnLength=" & ColumnLength & ", " &
            "ColumnDecimals=" & ColumnDecimals & ", " &
            "ColumnID=" & ColumnID & " " &
            "Where Tablename ='" & Tablename.ToUpper & "' AND ColumnName= '" & ColumnName.ToUpper & "'"
            Result = 2
        Else
            SQLStatement =
            "Insert into " & DatasetTable & " ( " &
            "DatasetID, " &
            "DatasetName, " &
            "SEQUENCE, " &
            "Tablename, " &
            "ColumnName, " &
            "ColumnText, " &
            "ColumnType, " &
            "ColumnLength, " &
            "ColumnDecimals," &
            "ColumnID" &
            ")  " &
            "Values (" &
            DatasetID & "," &
            "'" & DatasetName.ToUpper & "', " &
            Sequence & ", " &
            "'" & Tablename.ToUpper & "', " &
            "'" & ColumnName.ToUpper & "', " &
            "'" & ColumnText & "', " &
            "'" & ColumnType.ToUpper & "', " &
            ColumnLength & ", " &
            ColumnDecimals & "," &
            ColumnID &
            ")"
            Result = 1
        End If
        cm.CommandText = SQLStatement
        Dim da1 As New OdbcDataAdapter(cm)
        Dim ds1 As New DataSet
        Try
            da1.Fill(ds1)
            'dtTest = ds1.Tables(0)
        Catch ex As Exception
            Result = 3
            SQLOK = False
            MsgBox("Error in Update_DatasetColumns(): " & ex.Message)
        End Try
        Return (Result)
    End Function



    Function DeleteDatasetHeader(ConnectString As String, DatasetID As Integer, Tablename As String) As Boolean
        Dim SQLStatement As String

        Try
            DeleteDatasetHeader = False
            Using cn As New OdbcConnection(ConnectString)
                cn.Open()
                Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
                With cm
                    SQLStatement = "DELETE FROM EBI7020T WHERE TableName= '" & Tablename & "'"
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.CommandText = SQLStatement
                    Dim da As New OdbcDataAdapter(cm)
                    Dim ds As New DataSet
                    da.Fill(ds)
                End With
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Problem with Delete in DeleteDatasetHeader(): " & ex.Message)
        End Try

    End Function

    Function DeleteDatasetColumns(ConnectString As String, DatasetID As Integer, Tablename As String) As Boolean
        Dim SQLStatement As String

        Try
            DeleteDatasetColumns = False
            Using cn As New OdbcConnection(ConnectString)
                cn.Open()
                Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
                With cm
                    SQLStatement = "DELETE  FROM EBI7023T WHERE TableName= '" & Tablename & "'"
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.CommandText = SQLStatement
                    Dim da As New OdbcDataAdapter(cm)
                    Dim ds As New DataSet
                    da.Fill(ds)
                End With
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Problem with Delete in DeleteDatasetColumns(): " & ex.Message)
        End Try

    End Function

    Function GetMYSQLConnection(ByVal Optional MySQLDataBaseName As String = "") As String
        Dim ConnString As String
        Dim SQLStatement As String
        Dim ZeroDatetime As Boolean = True
        Dim Server As String = "localhost"
        Dim DbaseName As String = "simplequerybuilder"
        Dim USERNAME As String = "root"
        Dim password As String = "root"
        Dim port As String = "3306"

        If MySQLDataBaseName <> "" Then
            DbaseName = MySQLDataBaseName
        End If
        ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)
        Return ConnString
    End Function

    Function GetMYSQLDatabases() As DataTable
        Dim ConnString As String
        Dim SQLStatement As String

        GetMYSQLDatabases = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            ConnString = GetMYSQLConnection("mysql")
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            SQLStatement = "SHOW DATABASES"

            Dim cmd As New MySqlCommand
            cmd.Connection = cn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR WHILE GETTING MYSQL DATABASES: " & ex.Message)
        End Try

    End Function

    Function GetMYSQLTables(MySQLDatabase As String) As DataTable
        Dim ConnString As String
        Dim SQLStatement As String

        GetMYSQLTables = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            ConnString = GetMYSQLConnection(MySQLDatabase)
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            SQLStatement = "SHOW TABLES"

            Dim cmd As New MySqlCommand
            cmd.Connection = cn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR WHILE GETTING MYSQL TABLES: " & ex.Message)
        End Try

    End Function

    Function GetHeaderListMYSQL(DBName As String, Tablename As String, ByRef DatasetID As Integer) As DataTable
        Dim ConnString As String
        Dim SQLStatement As String
        Dim dt As DataTable

        GetHeaderListMYSQL = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            ConnString = GetMYSQLConnection(DBName)
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            SQLStatement = "SELECT " &
            "trim(DatasetName) as ""DataSet Name"", " &
            "trim(DataSetHeaderText) as ""DataSet Header Text"", " &
            "trim(Tablename) as ""Tablename"", " &
            "trim(AuthorityFlag) as ""Authority Flag"", " &
            "trim(CRTuserID) as ""CRT userID"", " &
            "trim(CRTTIMESTAMP) as ""CRT Timestamp"", " &
            "trim(UPDUserID) as ""UPD UserID"", " &
            "trim(UPDTimestamp) as ""UPD Timestamp"", " &
            "DatasetID " &
            "FROM ebi7020t "
            If Tablename <> "" Then
                SQLStatement += " WHERE Tablename= '" & Tablename & "' "
            End If
            SQLStatement += "ORDER BY DatasetID"

            Dim cmd As New MySqlCommand
            cmd.Connection = cn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            If IsNothing(dt) Then
                Exit Function
            End If
            If dt.Rows.Count > 0 And Not IsDBNull(dt.Rows(0)("DatasetID")) Then
                DatasetID = dt.Rows(0)("DatasetID")
            Else
                DatasetID = 0

            End If
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try

    End Function

    Function GetColumnsMYSQL(DatasetID As Integer, DBName As String, Tablename As String, ColumnName As String) As DataTable
        Dim ConnString As String
        Dim myDR As MySqlDataReader = Nothing
        Dim SQLStatement As String
        Dim strWhere As String

        GetColumnsMYSQL = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            ConnString = GetMYSQLConnection(DBName)

            strWhere = ""
            If DatasetID > 0 Then
                If strWhere <> "" Then
                    strWhere += " AND "
                End If
                strWhere += "DatasetID= " & DatasetID
            End If
            If Tablename <> "" Then
                If strWhere <> "" Then
                    strWhere += " AND "
                End If
                strWhere += "Tablename= '" & Tablename & "'"
            End If
            If ColumnName <> "" Then
                If strWhere <> "" Then
                    strWhere += " AND "
                End If
                strWhere += "ColumnName= '" & ColumnName & "'"
            End If
            SQLStatement = "SELECT " &
            "trim(Tablename) as ""Tablename"", " &
            "trim(ColumnName) as ""Column Name"", " &
            "trim(ColumnText) as ""Column Text"", " &
            "trim(ColumnType) as ""Column Type"", " &
            "ColumnLength as ""Column Length""," &
            "ColumnDecimals as ""Column Decimals""," &
            "ID as ""Column ID"" " &
            " FROM ebi7023t "
            If DatasetID > 0 Or Tablename <> "" Or ColumnName <> "" Then
                SQLStatement += "WHERE " & strWhere & " "
            End If
            SQLStatement += " ORDER BY Tablename,Sequence"
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = cn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR in GetColumnsMYSQL(): " & ex.Message)
        End Try

    End Function

    Function GetHeaderAndColumns_MYSQL(DatasetID As Integer) As DataTable
        Dim ConnectString As String = GetMYSQLConnection()
        Dim cn As New MySqlConnection(ConnectString)
        Dim SQLStatement As String
        Dim strWhere As String

        GetHeaderAndColumns_MYSQL = Nothing
        strWhere = ""
        If DatasetID > 0 Then
            If strWhere <> "" Then
                strWhere += " AND "
            End If
            strWhere += "h.DatasetID= " & DatasetID
        End If
        SQLStatement = "SELECT " &
            "h.DatasetID as ""Dataset ID"", " &
            "trim(h.Tablename) as ""Tablename"", " &
            "h.DatasetName as ""Dataset Name"", " &
            "trim(h.DataSetHeaderText) as ""DataSet Header Text"", " &
            "d.SEQUENCE as ""Sequence"", " &
            "trim(h.AuthorityFlag) as ""Auth Flag"", " &
            "trim(d.ColumnName) as ""Column Name"", " &
            "trim(d.ColumnText) as ""Column Text"", " &
            "trim(d.ColumnType) as ""Column Type"", " &
            "d.ColumnLength as ""Column Length""," &
            "d.ColumnDecimals as ""Column Decimals"", " &
            "d.ID as ""Column ID"" " &
            "FROM ebi7020t as h" &
            " JOIN ebi7023t as d ON h.DatasetID = d.DatasetID"
        SQLStatement += " WHERE " & strWhere & " "
        SQLStatement += " ORDER BY d.Tablename,d.Sequence"
        Try
            cn.Open()
            Dim cm As MySqlCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try
    End Function

    Function LocateDataSetID_MySQL(TableName As String) As DataTable
        Dim ConnString As String
        Dim myDR As MySqlDataReader = Nothing
        Dim SQLStatement As String

        LocateDataSetID_MySQL = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            ConnString = GetMYSQLConnection()
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            SQLStatement = "SELECT " &
            "DataSetID,DatasetName " &
            "FROM ebi7020t " &
            "Where Tablename= '" & TableName & "'"
            Dim cmd As New MySqlCommand
            '"FROM ebi7023t " &
            '"Where Tablename= '" & TableName & "' AND ColumnName= '" & ColumnName & "'"
            cmd.Connection = cn
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR in LocateDataSetID_MySQL: " & ex.Message)
        End Try

    End Function

    Function CheckTableExists_MYSQL(Tablename As String) As DataTable
        Dim ConnectString As String
        Dim SQLStatement As String

        ConnectString = GetMYSQLConnection()
        Dim cn As New MySqlConnection(ConnectString)
        CheckTableExists_MYSQL = Nothing
        SQLStatement = "SELECT * FROM " & Tablename
        Try
            cn.Open()
            Dim cm As MySqlCommand = cn.CreateCommand 'Create a command object via the connection
            cm.CommandTimeout = 0
            cm.CommandType = CommandType.Text
            cm.CommandText = SQLStatement
            Dim da As New MySqlDataAdapter(cm)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox("DB ERROR in CheckTableExists_MYSQL: " & ex.Message)
        End Try

    End Function

    Sub GetMySQLFieldsAndTypes(ByVal DBTable As String,
                         ByRef MyTypes As String,
                         ByRef Dic_Types As Object,
                         ByRef Fieldnames As String)
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim strSQL As String
        Dim NumFields As Integer
        Dim colIDX As Integer = 0
        Dim dr1 As MySqlDataReader
        Dim FieldType As String
        Dim Fieldname As String
        Dim NewFieldnames As String
        Dim ConnString As String
        Dim SQLStatement As String

        NewFieldnames = ""
        Fieldnames = ""
        MyTypes = ""
        NumFields = 0
        strSQL = ""
        Dic_Types = CreateObject("Scripting.Dictionary")
        Dic_Types.comparemode = vbTextCompare

        If Len(DBTable) = 0 Then
            MsgBox("DBError: No Table Specified")
            Exit Sub
        End If
        Try
            ConnString = GetMYSQLConnection()
            con = New MySqlConnection(ConnString)
            con.Open()
            strSQL = "SELECT * FROM " & DBTable
            cmd = New MySqlCommand(strSQL, con)
            dr1 = cmd.ExecuteReader()

            NumFields = dr1.FieldCount - 1
            While colIDX <= NumFields
                Fieldname = dr1.GetName(colIDX)
                FieldType = dr1.GetDataTypeName(colIDX)
                If Not Dic_Types.exists(Fieldname) Then
                    Dic_Types(Fieldname) = FieldType
                End If
                If Len(NewFieldnames) = 0 Then
                    NewFieldnames = Fieldname
                    MyTypes = FieldType.ToString
                Else
                    NewFieldnames = NewFieldnames & "," & Fieldname
                    MyTypes = MyTypes & "," & FieldType.ToString
                End If
                colIDX = colIDX + 1
            End While
            Fieldnames = NewFieldnames
            con.Close()
            dr1.Close()

        Catch ex As Exception
            MsgBox("DB Error In GetMySQLFieldsAndTypes: " & ex.Message.ToString)
        End Try

    End Sub

    Function Get_Total_Rows_From_CSVFile(CSVFilename As String, Optional ByRef TotalFields As Long = 0) As Long
        Dim rownum As Long
        Dim TotalRows As Long
        Dim wholeRows As String()

        Using csvReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(CSVFilename)
            csvReader.TextFieldType = FileIO.FieldType.Delimited
            csvReader.SetDelimiters(",")
            TotalRows = 0
            rownum = 0
            While Not csvReader.EndOfData
                Try
                    wholeRows = csvReader.ReadFields()

                    TotalFields = wholeRows.Length
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is NOT valid and will be skipped.")
                End Try
                rownum = rownum + 1
            End While

        End Using
        TotalRows = rownum
        Get_Total_Rows_From_CSVFile = TotalRows
    End Function

    Function CSVFileToArray(ByRef NewstrArray As String(,), ByVal CSVFilename As String, Optional ByRef TotalFields As Long = 0,
                                Optional ByRef Message As String = "") As Long
        Dim wholeRows As String()
        Dim numRowsRead As Long
        Dim colnum As Long
        Dim RowNum As Long
        Dim currentFields As String
        Dim Percentage As Long
        Dim TotalRows As Long
        Dim RowMessage As String
        Dim messages As String

        ReDim NewstrArray(1, 1)
        CSVFileToArray = 0
        numRowsRead = 0
        colnum = 0
        RowNum = 0
        messages = ""
        ReDim wholeRows(1)
        wholeRows(0) = ""
        Try
            Using csvReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(CSVFilename)
                csvReader.TextFieldType = FileIO.FieldType.Delimited
                csvReader.SetDelimiters(",")
                TotalRows = Get_Total_Rows_From_CSVFile(CSVFilename, TotalFields)
                ReDim NewstrArray(TotalFields, TotalRows)
                While Not csvReader.EndOfData
                    Try
                        wholeRows = csvReader.ReadFields()
                        colnum = 0
                        For Each currentFields In wholeRows
                            If TotalRows > 0 Then
                                Percentage = CLng((RowNum / TotalRows) * 100)
                            Else
                                Percentage = 0
                            End If
                            RowMessage = "Read " & CStr(RowNum) & " ROW / " & CStr(TotalRows) & " ROWS"
                            NewstrArray(colnum, RowNum) = currentFields

                            Application.DoEvents()

                            colnum = colnum + 1
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        If Len(messages) > 0 Then
                            messages = messages & ","
                        End If
                        messages = messages & " Line " & ex.Message & "is NOT valid and will be skipped."
                        Message = messages
                        'logERR.LogMessage("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "CSVFileToArray()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
                    End Try
                    RowNum = RowNum + 1
                End While
            End Using
        Catch ex As Exception
            Message = "Error In CSVFileToArray: " & ex.Message.ToString
            'logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "CSVFileToArray()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try
        numRowsRead = RowNum
        CSVFileToArray = numRowsRead
    End Function

    Sub CreateMySQLTable(DBName As String, Fieldnames As String, FieldTypes As String, FieldValues As String)

    End Sub

    Sub BulkLoaderMySQL(csvFilename As String, DBTable As String)
        Dim ConnString As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim strSQL As String
        Dim NumFields As Integer
        Dim colIDX As Integer = 0
        Dim dr1 As MySqlDataReader
        Dim FieldType As String
        Dim Fieldname As String
        Dim NewFieldnames As String
        Dim SQLStatement As String
        Dim bl As MySqlBulkLoader
        Dim intLineCount As Integer

        Try
            ConnString = GetMYSQLConnection()
            con = New MySqlConnection(ConnString)
            bl = New MySqlBulkLoader(con)
            bl.TableName = DBTable
            bl.FieldTerminator = "|"
            bl.LineTerminator = "\n"
            bl.FileName = csvFilename

            Try
                con.Open()
                intLineCount = bl.Load()

            Catch ex As Exception
                MsgBox("DB Error during IMPORT In BulkLoaderMySQL: " & ex.Message.ToString)
            End Try

            con.Close()

        Catch ex As Exception
            MsgBox("DB Error In BulkLoaderMySQL: " & ex.Message.ToString)
        End Try

        MsgBox("OK FINISHED: " & CStr(intLineCount) & " LINES IMPORTED")
    End Sub

    Public Function Update_DatasetHeader_MYSQL(
                    ByRef DatasetID As Integer,
                    DatasetName As String,
                    DatasetHeaderText As String,
                    DBName As String,
                    Tablename As String,
                    AuthFlag As String,
                    CreatedUserID As String,
                    UpdUserID As String
) As Integer
        Dim SQLStatement As String
        Dim SQLOK As Boolean = True
        Dim ConnString As String
        Dim Result As Integer
        Dim dtCreateTime As DateTime
        Dim dtUpdTime As DateTime

        ConnString = GetMYSQLConnection(DBName)
        Dim cn As New MySqlConnection(ConnString)

        cn.Open()
        Dim cm As MySqlCommand = cn.CreateCommand 'Create a command object via the connection
        Result = 0
        dtCreateTime = Now()
        dtUpdTime = Now()
        SQLStatement =
        "Select DatasetID  " &
        "From EBI7020T "
        If DatasetID > 0 Then
            SQLStatement = SQLStatement & " Where DatasetID =" & DatasetID & " "
        Else
            SQLStatement = SQLStatement & " Where Tablename ='" & Tablename & "' "
        End If
        cm.CommandTimeout = 0
        cm.CommandType = CommandType.Text
        cm.CommandText = SQLStatement
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            SQLStatement =
            "Update EB17020T " &
            "set " &
            "DatasetName='" & DatasetName.ToUpper & "', " &
            "DatasetHeaderText='" & DatasetHeaderText & "', " &
            "Tablename='" & Tablename.ToUpper & "', " &
            "AuthorityFlag='" & AuthFlag & "', " &
            "UPDUserID='" & CreatedUserID & "', " &
            "UPDTIMESTAMP=" & dtUpdTime & " " &
            "Where DatasetID =" & DatasetID & " "
            Result = 2
        Else
            SQLStatement =
            "Insert into EB17020T ( " &
            "DatasetName, " &
            "DatasetHeaderText, " &
            "Tablename, " &
            "AuthorityFlag, " &
            "CRTUserID, " &
            "CRTTIMESTAMP, " &
            "UPDUserID, " &
            "UPDTIMESTAMP" &
            ")  " &
            "Values(" &
            "'" & DatasetName.ToUpper & "' , " &
            "'" & DatasetHeaderText & "', " &
            "'" & Tablename.ToUpper & "', " &
            "'" & AuthFlag & "', " &
            "'" & CreatedUserID & "', " &
            dtCreateTime & ", " &
            "'" & UpdUserID & "', " &
            dtUpdTime &
            ")"
            Result = 1

        End If
        cm.CommandText = SQLStatement
        Dim da1 As New MySqlDataAdapter(cm)
        Dim ds1 As New DataSet
        Try
            da1.Fill(ds1)
            If Result = 1 Then
                DatasetID = GetLastID_MYSQL("EB17020T", "DatasetID")
            End If
        Catch ex As Exception
            Result = 3
            SQLOK = False
            MsgBox(ex.Message)
        End Try
        Return (Result)
    End Function

    Public Function Update_DatasetColumns_MYSQL(
                    DatasetID As Integer,
                    DatasetName As String,
                    Sequence As Integer,
                    Tablename As String,
                    ColumnName As String,
                    ColumnText As String,
                    ColumnType As String,
                    ColumnLength As Integer,
                    ColumnDecimals As Integer
) As Integer
        Dim SQLStatement As String
        Dim SQLOK As Boolean = True
        Dim ConnString As String
        Dim Result As Integer

        ConnString = GetMYSQLConnection()
        Dim cn As New MySqlConnection(ConnString)

        cn.Open()
        Dim cm As MySqlCommand = cn.CreateCommand 'Create a command object via the connection
        Result = 0
        SQLStatement =
        "Select DatasetID  " &
        "From EB17023T " &
        "Where DatasetID =" & DatasetID & " AND ColumnName= '" & ColumnName & "'"
        cm.CommandTimeout = 0
        cm.CommandType = CommandType.Text
        cm.CommandText = SQLStatement
        Dim da As New MySqlDataAdapter(cm)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            SQLStatement =
            "Update EB17023T " &
            "set " &
            "DatasetID=" & DatasetID & ", " &
            "DatasetName='" & DatasetName.ToUpper & "', " &
            "SEQUENCE=" & Sequence & ", " &
            "Tablename='" & Tablename.ToUpper & "', " &
            "ColumnName='" & ColumnName.ToUpper & "', " &
            "ColumnText='" & ColumnText & "', " &
            "ColumnType='" & ColumnType.ToUpper & "', " &
            "ColumnLength=" & ColumnLength & ", " &
            "ColumnDecimals=" & ColumnDecimals & " " &
            "Where DatasetName ='" & DatasetName.ToUpper & "' AND ColumnName= '" & ColumnName.ToUpper & "'"
            Result = 2
        Else
            SQLStatement =
            "Insert into EB17023T ( " &
            "DatasetID, " &
            "DatasetName, " &
            "SEQUENCE, " &
            "Tablename, " &
            "ColumnName, " &
            "ColumnText, " &
            "ColumnType, " &
            "ColumnLength, " &
            "ColumnDecimals" &
            ")  " &
            "Values(" &
            DatasetID & ", " &
            "'" & DatasetName.ToUpper & "', " &
            Sequence & ", " &
            "'" & Tablename.ToUpper & "', " &
            "'" & ColumnName.ToUpper & "', " &
            "'" & ColumnText & "', " &
            "'" & ColumnType.ToUpper & "', " &
            ColumnLength & ", " &
            ColumnDecimals &
            ")"
            Result = 1
        End If
        cm.CommandText = SQLStatement
        Dim da1 As New MySqlDataAdapter(cm)
        Dim ds1 As New DataSet
        Try
            da1.Fill(ds1)
        Catch ex As Exception
            Result = 3
            SQLOK = False
            MsgBox("Error in Update_DatasetColumns_MYSQL(): " & ex.Message)
        End Try
        Return (Result)
    End Function

    Sub ExtractSQLDetails(ConnectString As String, SQLStatement As String)
        Dim fldDetails As New clsFieldDetails(ConnectString, "", "IBM")

        fldDetails.ExtractInfo(SQLStatement)
        'need special methods to extract the arrays from the parser ...

    End Sub

    Function ExtractFieldDetails(ConnectString As String, Tablename As String, DBVersion As String, DatasetID As Integer,
                                 DatasetName As String, DatasetHeaderText As String, StartSequence As Integer, ByVal Optional DBName As String = "") As DataTable
        Dim fldDetails As New clsFieldDetails(ConnectString, "", DBVersion, DBName)
        Dim fldNames As String()
        Dim fldText As String()

        Dim fldTypes As String()
        Dim fldLengths As Integer()
        Dim fldDecimals As Integer()
        Dim dt As New DataTable
        Dim Sequence As Integer
        Dim intColumnID As Integer
        Dim intLastColumnID As Integer

        ExtractFieldDetails = Nothing
        Try
            fldDetails.GetSingleRowFieldDetails("", Tablename)
            fldNames = fldDetails.GetFieldNames()
            fldText = fldDetails.GetFieldNames()
            fldTypes = fldDetails.GetFieldTypes(True)
            fldLengths = fldDetails.GetFieldLengths()
            fldDecimals = fldDetails.GetFieldDP()

            'Convert types to GARY types:
            dt.Columns.Add("Dataset Name", GetType(String))
            dt.Columns.Add("Dataset Header Text", GetType(String))
            dt.Columns.Add("Sequence", GetType(Integer))
            dt.Columns.Add("Tablename", GetType(String))
            dt.Columns.Add("Column Name", GetType(String))
            dt.Columns.Add("Column Text", GetType(String))
            dt.Columns.Add("Column Type", GetType(String))
            dt.Columns.Add("Column Length", GetType(Integer))
            dt.Columns.Add("Column Decimals", GetType(Integer))
            dt.Columns.Add("Dataset ID", GetType(Integer))
            If DBVersion = "IBM" Then
                dt.Columns.Add("Column ID", GetType(Integer))
                Dim DatasetTable As String = "EBI7023T"
                intLastColumnID = GetLastID(ConnectString, DatasetTable, "ColumnID")
            End If

            If IsNothing(fldNames) Then
                Exit Function
            End If
            For i As Integer = 0 To fldNames.Length - 2
                Sequence = StartSequence + (i + 1) * 10
                If DBVersion = "IBM" Then
                    intColumnID = intLastColumnID + (i + 1)
                    dt.Rows.Add(DatasetName.ToUpper, DatasetHeaderText, Sequence, Tablename.ToUpper, fldNames(i).ToUpper, fldText(i), fldTypes(i).ToUpper, fldLengths(i), fldDecimals(i), DatasetID,
                        intColumnID)
                Else
                    dt.Rows.Add(DatasetName.ToUpper, DatasetHeaderText, Sequence, Tablename.ToUpper, fldNames(i).ToUpper, fldText(i), fldTypes(i).ToUpper, fldLengths(i), fldDecimals(i), DatasetID)
                End If

            Next

        Catch ex As Exception
            MsgBox("Error while extracting field details: " & ex.Message)

        End Try

        Return dt

    End Function

    Sub GetFieldDetail(ConnectString As String, TableName As String, FieldName As String, ByRef FieldType As String, ByRef FieldLength As Integer, ByRef DecimalPlaces As Integer)
        Dim DBTable As String
        Dim fldDetails As clsFieldDetails

        fldDetails = New clsFieldDetails(ConnectString, "", SQLBuilder.DataSetHeaderList.DBVersion)
        fldDetails.GetSingleRowFieldDetails("", TableName)
        fldDetails.GetFieldDetail(FieldName, FieldType, FieldLength, DecimalPlaces)
    End Sub

    Sub FormatIBMDate()
        Dim SQLStatement = "create function ts_fmt(TS timestamp, fmt varchar(20)) 
returns varchar(50) 
return 
with tmp (dd,mm,yyyy,hh,mi,ss,nnnnnn) as 
( 
    select 
    substr( digits (day(TS)),9), 
    substr( digits (month(TS)),9) , 
    rtrim(char(year(TS))) , 
    substr( digits (hour(TS)),9), 
    substr( digits (minute(TS)),9), 
    substr( digits (second(TS)),9), 
    rtrim(char(microsecond(TS))) 
    from sysibm.sysdummy1 
    ) 
select 
case fmt 
    when 'yyyymmdd' 
        then yyyy || mm || dd 
    when 'mm/dd/yyyy' 
        then mm || '/' || dd || '/' || yyyy 
    when 'yyyy/dd/mm hh:mi:ss' 
        then yyyy || '/' || mm || '/' || dd || ' ' ||  
               hh || ':' || mi || ':' || ss 
    when 'nnnnnn' 
        then nnnnnn 
    else 
        'date format ' || coalesce(fmt,' <null> ') ||  
        ' not recognized.' 
    end 
from tmp 
</null>"
        'Execute the above:

        'Use the above SQL:
        'values ts_fmt(current timestamp,'yyyymmdd') 
        '20030818' 
    End Sub

End Class
