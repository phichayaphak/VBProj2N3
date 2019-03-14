Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMain
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConq").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myComm As New SqlCommand
    Dim myDr As SqlDataReader
    Private Sub ประเภทสนคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ประเภทสนคาToolStripMenuItem.Click
        Dim fFirst As New frmFirst
        fFirst.ShowDialog()


    End Sub

    Private Sub สนคาToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles สนคาToolStripMenuItem.Click
        Dim fSecond As New frmSecondForm
        fSecond.ShowDialog()
    End Sub

    Private Sub ขอมลพนกงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ขอมลพนกงานToolStripMenuItem.Click
        Dim fThird As New frmThird
        fThird.ShowDialog()
    End Sub

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub loadCompanyData()
        connectDB()
        strSQL = "select * from Company"
        myComm = New SqlCommand(strSQL, myCon)
        myDr = myComm.ExecuteReader
        If myDr.HasRows Then
            myDr.Read()
            COMPANY_NAME = myDr.Item("CompanyName")
            COMPANY_ADDRESS = myDr.Item("CompanyAddress")
        Else
            COMPANY_NAME = ""
            COMPANY_ADDRESS = ""
        End If
        myDr.Close()
        myCon.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadCompanyData()

        lblCompanyName.Text = COMPANY_NAME
        lblCompanyAddress.Text = COMPANY_ADDRESS

        Dim frmLogin As New LoginForm1
        empID = ""
        frmLogin.ShowDialog()

        If empID = "" Then
            End
        Else
            Select Case staName
                Case "พนักงานขาย"
                    mnu10.Enabled = False
                    mnu30.Enabled = False
                    mnu40.Enabled = False
                    สงซอสนคาToolStripMenuItem.Enabled = False
                    รบสนคาToolStripMenuItem.Enabled = False
                    ขายสนคาToolStripMenuItem.Enabled = False
                    สงสนคาToolStripMenuItem.Enabled = False
                    รบคนToolStripMenuItem.Enabled = False
                Case "ผู้จัดการทั่วไป"
                    mun20.Enabled = False
            End Select
        End If




    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        Dim frmNewSale As New frmSale
        frmNewSale.Show()

    End Sub

    Private Sub รายงานสนคาคงคToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานสนคาคงคToolStripMenuItem.Click
        'Dim frmReport As New frmReportProduct
        'frmReport.ShowDialog()
        'Dim frmReport As New frmReportStock
        'frmReport.ShowDialog()
        'Dim frmReport As New frmReqportProductQ
        'frmReport.ShowDialog()
        Dim frmReport As New frmReportBIS2N2
        frmReport.ShowDialog()

    End Sub
End Class