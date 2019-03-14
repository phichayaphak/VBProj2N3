Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReportBIS2N2
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConq").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsBIS2N2
    Dim myRPT As New crpProductBIS2N2

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub showReport()
        connectDB()
        strSQL = "Select * From Products, Categories Where Products.CategoryID = Categories.CategoryID "
        If cmbCategory.SelectedIndex <> 0 Then
            strSQL = strSQL & " and CategoryName = '" & cmbCategory.SelectedItem & "'"
        End If

        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "dtProduct")

        myRPT.SetDataSource(myDS.Tables("dtProduct"))
        myRPT.SetParameterValue("CompanyName", COMPANY_NAME)
        myRPT.SetParameterValue("CompanyAddress", COMPANY_ADDRESS)

        crvProduct.ReportSource = myRPT
        crvProduct.Show()
        myCon.Close()
    End Sub

    Private Sub frmReportBIS2N2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        strSQL = "Select CategoryName From Categories"
        myComm = New SqlCommand(strSQL, myCon)
        myDR = myComm.ExecuteReader
        If myDR.HasRows Then
            cmbCategory.Items.Add("ทั้งหมด")
            While myDR.Read
                cmbCategory.Items.Add(myDR.Item("CategoryName"))
            End While
            cmbCategory.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ไม่มีข้อมูลประเภทสินค้า ไม่สามารถนำเสนอรายงานได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If

        Call showReport()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Call showReport()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        'crvProduct.ReportSource = Nothing
        Call showReport()
    End Sub
End Class