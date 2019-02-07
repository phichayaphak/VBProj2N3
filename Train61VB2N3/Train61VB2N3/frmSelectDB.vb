Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSelectDB
    Dim strCon As String =
        ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.strCon").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim strSQL As String

    Private Sub connetDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub btnShowProduct_Click(sender As Object, e As EventArgs) Handles btnShowProduct.Click
        connetDB()
        strSQL = "Select ProductID, ProductName,  UnitPrice, UnitsInStock, (UnitPrice * UnitsInStock) AS Total From Products "
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "myCat")
        dgvData.DataSource = myDS.Tables("myCat")

        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 250
        dgvData.Columns(2).Width = 100
        dgvData.Columns(3).Width = 80
        dgvData.Columns(4).Width = 100
        dgvData.Columns(0).HeaderText = "รหัส"
        dgvData.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvData.Columns(2).HeaderText = "ราคา"
        dgvData.Columns(3).HeaderText = "คงเหลือ"
        dgvData.Columns(4).HeaderText = "มูลค่า"

    End Sub

    Private Sub btnShowSale_Click(sender As Object, e As EventArgs) Handles btnShowSale.Click
        connetDB()
        strSQL = "Select OrderID, OrderDate, CompanyName, FirstName, Lastname From Orders, Customers, Employees Where Orders.CustomerID = Customers.CustomerID and Orders.EmployeeID = Employees.EmployeeID "
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "myOrders")
        dgvData.DataSource = myDS.Tables("myOrders")
    End Sub
End Class