Imports System.Data.SqlClient
Module ModuleDbConnect
    Public DBicecream As New SqlConnection
    Public CMDiceJr As New SqlCommand
    Public DTRiceJr As SqlDataReader

    Public AdptEmployee As New SqlDataAdapter
    Public TblEmployeeData As New DataTable

    Public AdptCustomer As New SqlDataAdapter
    Public TblCustomer As New DataTable

    Public AdptIceCream As New SqlDataAdapter
    Public TblIceCream As New DataTable

    Public AdptTopping As New SqlDataAdapter
    Public TblTopping As New DataTable

    Public AdptFlavor As New SqlDataAdapter
    Public TblFlavor As New DataTable

    Public AdptOrder As New SqlDataAdapter
    Public TblOrder As New DataTable

    Public AdptLineOrder As New SqlDataAdapter
    Public TblLineOrder As New DataTable


    Sub DB_Connect()
        DBicecream = New SqlConnection("server=DESKTOP-PRT29ON; database=IceCreamShopDB; trusted_connection=true")
        If DBicecream.State = ConnectionState.Closed Then
            DBicecream.Open()
        End If
    End Sub
End Module
