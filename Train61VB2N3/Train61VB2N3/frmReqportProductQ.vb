Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReqportProductQ
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConq").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New dsNorthwindQ
    Dim myRPT As New crpProductQ

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
        strSQL = "Select * From Categories, Products where Categories.CategoryID = Products.CategoryID "
        If cmbCategory.SelectedIndex <> 0 Then
            strSQL = strSQL & " and CategoryName = '" & cmbCategory.SelectedItem & "'"
        End If
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDS.Clear()
        myDA.Fill(myDS, "dtProduct")

        myRPT.SetDataSource(myDS.Tables("dtProduct"))
        myRPT.SetParameterValue("CompanyName", COMPANY_NAME)
        myRPT.SetParameterValue("CompanyAdress", COMPANY_ADDRESS)

        crvProductQ.ReportSource = myRPT
        crvProductQ.Show()

    End Sub

    Private Sub frmReqportProductQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            MessageBox.Show("ไม่พบประเภทสินค้า ไม่สามารถรายงานข้อมูลได้", "No data...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If

        Call showReport()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Call showReport()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        '   crvProductQ.ReportSource = Nothing
        Call showReport()
    End Sub
End Class