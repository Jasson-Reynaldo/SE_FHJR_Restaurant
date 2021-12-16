Imports System.Data.SqlClient
Module ModuleDbConnect
    Public DBresto As New SqlConnection
    Public CMDresto As New SqlCommand
    Public DTRresto As SqlDataReader

    Public AdptMenu As New SqlDataAdapter
    Public TblMenu As New DataTable

    Public AdptOrders As New SqlDataAdapter
    Public TblOrders As New DataTable

    Public AdptTransactions As New SqlDataAdapter
    Public TblTransactions As New DataTable

    Public AdptFeedback As New SqlDataAdapter
    Public TblFeedback As New DataTable

    Sub DB_Connect()
        DBresto = New SqlConnection("server=DESKTOP-PRT29ON; database=RestoDB; trusted_connection=true")
        If DBresto.State = ConnectionState.Closed Then
            DBresto.Open()
        End If
    End Sub
End Module