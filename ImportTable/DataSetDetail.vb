Public Class DataSetDetail
    Dim GlobalParms As ESPOBIParms.BIParms
    Dim GlobalSession As ESPOParms.Session
    Public Sub GetParms(Session As ESPOParms.Session, Parms As ESPOBIParms.BIParms)
        GlobalParms = Parms
        GlobalSession = Session
    End Sub

    Private Sub DataSetDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AcceptButton = btnImport
        MdiParent = FromHandle(GlobalSession.MDIParentHandle)

        txtDataSetID.Text = GlobalParms.DataSetID

    End Sub


    Public Sub populateForm(ConnectString As String, ID As Integer, EstablishmentID As Integer, FrameworkID As Integer, CustomerID As Integer, UpdateFlag As Integer)
        Me.Cursor = Cursors.Default
    End Sub

End Class