Imports System.Data.Odbc
Public Class ImportTableDAL
    Public Function InsertEBI7020T(
                       ConnectString As String,
                       DataSetName As String,
                       DataSetHeaderText As String,
                       TableName As String,
                       LibraryName As String,
                       UserID As String,
                       TextColumnName As String
                                      )

        Dim SQLStatement As String
        Using cn As New OdbcConnection(ConnectString)
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            With cm
                SQLStatement =
                "Insert into EBI7020T (" &
                "DatasetName, " &
                "DatasetHeaderText, " &
                "TableName, " &
                "LibraryName, " &
                "AuthorityFlag, " &
                "S21ApplicationCode, " &
                "crtUserID " &
                ") " &
            "Values (" &
            "'" & DataSetName.ToUpper & "', " &
            "'" & DataSetHeaderText & "', " &
            "'" & TableName.ToUpper & "', " &
            "'" & LibraryName.ToUpper & "', " &
            "'" & "0" & "', " &
            "'" & Mid(TableName.ToUpper, 1, 2) & "', " &
            "'" & UserID.ToUpper & "' " &
            ")"
                .CommandText = SQLStatement
                Dim da1 As New OdbcDataAdapter(cm)
                Dim ds1 As New DataSet
                Try
                    da1.Fill(ds1)
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & cn.State)
                End Try
            End With
        End Using
        Dim ID As Integer
        ID = GetDataSetID(
            ConnectString,
            DataSetName,
            TableName,
            LibraryName
                    )
        InsertEBI7023T(
            ConnectString,
            ID,
            TableName,
            LibraryName,
            TextColumnName
            )
    End Function

    Public Function InsertEBI7023T(
                       ConnectString As String,
                       DataSetID As Integer,
                       TableName As String,
                       LibraryName As String,
                       TextColumnName As String
                                  )

        Dim SQLStatement As String
        Using cn As New OdbcConnection(ConnectString)
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            With cm
                SQLStatement =
             "insert into ebi7023t ( " &
              "Select " &
                DataSetID & " as ""ID"", " &
                "0 as ""Seq"", " &
                "'*PRIMARY' as ""Table"", " &
                " whflde as ""Col Name"", " &
                " case when '" & TextColumnName & "'='Name'   then whflde " &
                "      when '" & TextColumnName & "'='ColHdg' then trim(whchd1) concat ' ' concat trim(whchd2) concat ' ' concat trim(whchd3) " &
                "      when '" & TextColumnName & "'='Alias'  then case when whalis<>'' then whalis else whflde end  " &
                " Else whftxt End As ""Text"", " &
                " Case when whfldt in ('P','S') then 'N' else whfldt end as ""Col Type"",  " &
                " case when whfldt='A' then whfldb else whfldd end as ""Len"", " &
                " whfldp as ""Dec""  , " &
                " 0 " &
                " From zxref/xffd " &
                " Where whlib = upper('" & LibraryName & "') " &
                " And whfile = upper('" & TableName & "') " &
                " ) "
                .CommandText = SQLStatement
                Dim da1 As New OdbcDataAdapter(cm)
                Dim ds1 As New DataSet
                Try
                    da1.Fill(ds1)
                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & cn.State)
                End Try
            End With
        End Using

    End Function

    Public Function GetDataSetID(
                    ConnectString As String,
                    DataSetName As String,
                    TableName As String,
                    LibraryName As String
                                   )
        Dim DataSetID As Integer

        Dim SQLStatement As String
        Dim dt As DataTable
        Using cn As New OdbcConnection(ConnectString)
            cn.Open()
            Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
            With cm

                SQLStatement =
                      "SELECT DataSetID " &
                  "FROM EBI7020T " &
                  "Where TableName='" & TableName & "' " &
                  " and LibraryName='" & LibraryName & "' "
                Try
                    cm.CommandTimeout = 0
                    cm.CommandType = CommandType.Text
                    cm.CommandText = SQLStatement
                    Dim da As New OdbcDataAdapter(cm)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    dt = ds.Tables(0)
                    If Not IsDBNull(dt.Rows(0)("DataSetID")) Then
                        DataSetID = dt.Rows(0)("DataSetID")
                    Else
                        DataSetID = 0
                    End If


                Catch ex As Exception
                    MsgBox("DB Error In GetLastID: " & ex.Message)
                End Try
            End With
        End Using
        Return DataSetID
    End Function

End Class
