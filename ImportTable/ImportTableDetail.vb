Imports System.Diagnostics
Public Class ImportTableDetail
    Dim GlobalParms As ESPOBIParms.BIParms
    Dim GlobalSession As ESPOParms.Session
    Public Sub GetParms(Session As ESPOParms.Session, Parms As ESPOBIParms.BIParms)
        GlobalParms = Parms
        GlobalSession = Session
    End Sub

    Private Sub FW00310_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If GlobalSession.CurrentUserReadOnly = False Then
            btnImport.Enabled = True
            AcceptButton = btnImport
        Else
            btnImport.Enabled = False
        End If
        MdiParent = FromHandle(GlobalSession.MDIParentHandle)
    End Sub


    Public Sub populateForm(ConnectString As String, ID As Integer, EstablishmentID As Integer, FrameworkID As Integer, CustomerID As Integer, UpdateFlag As Integer)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Cursor = Cursors.Default
        Dim dal As New ImportTableDAL
        dal.InsertEBI7020T(
            GlobalSession.ConnectString,
            txtDataSetName.Text,
            txtDataSetHeaderText.Text,
            txtTableName.Text,
            txtLibraryName.Text,
            GlobalSession.CurrentUserShort,
            txtTextColumnName.Text
                            )
        Me.Hide()
    End Sub

End Class