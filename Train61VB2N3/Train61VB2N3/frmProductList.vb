Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmProductList
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConCompany").ConnectionString
    Dim strSQL As String
    Dim myCon As New SqlConnection()
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Private Sub connetDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connetDB()
        strSQL = "Select ProID, ProName,  proPrice From Product"
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "myPro")
        dgvProduct.DataSource = myDS.Tables("myPro")

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim r As Integer = dgvProduct.CurrentCell.RowIndex
        proIDFind = dgvProduct.Item(0, r).Value
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

 

    Private Sub dgvProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellDoubleClick
        Call btnSelect_Click(sender, e)
    End Sub
End Class