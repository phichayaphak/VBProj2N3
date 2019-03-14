Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReportProduct
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConq").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsProduct
    Dim myRPT As New crpProduct

    Dim myComm As New SqlCommand
    Dim myDr As SqlDataReader

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub showReport()
        connectDB()

        ' If cmbCategory.SelectedIndex = 0 Then
        'strSQL = "Select * from products, categories where products.categoryID = categories.categoryID"
        'Else
        'strSQL = "Select * from products, categories where products.categoryID = categories.categoryID " & _
        '   " and categoryName = '" & cmbCategory.SelectedItem & "'"
        'End If

        strSQL = "Select * from products, categories where products.categoryID = categories.categoryID"
        If cmbCategory.SelectedIndex > 0 Then
            strSQL = strSQL & " and categoryName = '" & cmbCategory.SelectedItem & "'"
        End If


        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "dtProduct")

        myRPT.SetDataSource(myDS.Tables("dtProduct"))
        myRPT.SetParameterValue(0, COMPANY_NAME)
        myRPT.SetParameterValue(1, COMPANY_ADDRESS)

        crvProduct.ReportSource = myRPT
        crvProduct.Show()

    End Sub

    Private Sub frmReportProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        strSQL = "Select categoryName from Categories"
        myComm = New SqlCommand(strSQL, myCon)
        myDr = myComm.ExecuteReader
        If myDr.HasRows Then
            cmbCategory.Items.Add("ทั้งหมด")
            While myDr.Read
                cmbCategory.Items.Add(myDr.Item("categoryName"))
            End While
            cmbCategory.SelectedIndex = 0
        Else
            MessageBox.Show("ไม่มีประเภทสินค้า ทำรายงานไม่ได้")
            Me.Close()
        End If

        Call showReport()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Call showReport()
    End Sub
End Class