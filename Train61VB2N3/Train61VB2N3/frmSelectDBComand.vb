Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmSelectDBComand
    Dim strCon As String =
       ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.strCon").ConnectionString
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strSQL As String

    Private Sub connetDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmSelectDBComand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connetDB()
        strSQL = "select categoryName From Categories"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myDR = myComm.ExecuteReader()
        '  Dim strName As String
        If myDR.HasRows Then
            While myDR.Read
                'strName = myDR.Item("CategoryName")
                cmbCategory.Items.Add(myDR.Item("CategoryName"))
            End While
            cmbCategory.SelectedIndex = 0
            myDR.Close()
            myCon.Close()
        Else
            MessageBox.Show("ไม่มีข้อมูลประเภทสินค้า ไม่สามารถทำรายการนี้ได้")
            Me.Close()
        End If

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        connetDB()
        strSQL = "Select ProductID, ProductName,  UnitPrice, UnitsInStock, (UnitPrice * UnitsInStock) AS Total " & _
        " From Products, Categories Where Products.CategoryID = Categories.CategoryID and CategoryName =  '" & cmbCategory.SelectedItem & "'    "

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
        myCon.Close()
    End Sub

    Private Sub dgvData_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellEnter
        If dgvData.RowCount = 0 Or dgvData.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim r As Integer = dgvData.CurrentCell.RowIndex
        Dim pId As String = dgvData.Item(0, r).Value

        connetDB()
        strSQL = "select * From Products Where productID = @id "
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("@id", pId)
        myDR = myComm.ExecuteReader()
        myDR.Read()
        lblID.Text = myDR.Item("ProductID")
        lblName.Text = myDR.Item("ProductName")
        lblQuantity.Text = myDR.Item("QuantityPerUnit")
        lblPrice.Text = myDR.Item("UnitPrice")
        lblUnitsInStock.Text = myDR.Item("UnitsInStock")
        lblReorderlevel.Text = myDR.Item("ReOrderLevel")
        If myDR.Item("Discontinued") = False Then
            radSale.Checked = True
        Else
            radNoSale.Checked = True
        End If
        myDR.Close()
        myCon.Close()

    End Sub

End Class