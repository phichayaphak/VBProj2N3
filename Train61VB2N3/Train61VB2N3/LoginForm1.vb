Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm1
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.myConCompany").ConnectionString
    Dim strSQL As String

    Dim myCon As New SqlConnection

    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Private Sub connectDB()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        connectDB()
        strSQL = "Select * From Employee, Status Where Employee.staID = Status.staID " & _
            " and empID = @eid and empPassword = @epassword"
        myComm = New SqlCommand(strSQL, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("eid", txtEmpID.Text)
        myComm.Parameters.AddWithValue("epassword", txtEmpPassword.Text)
        myDR = myComm.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            empID = myDR.Item("empID")
            empName = myDR.Item("empName")
            empSurname = myDR.Item("empSurName")
            staName = myDR.Item("staName")
            myDR.Close()
            myCon.Close()
            Me.Close()
        Else
            MessageBox.Show("ท่านระบุรหัสประจำตัวหรือรหัสผ่านไม่ถูกต้อง" & Chr(10) & "กรุณาระบุใหม่ให้ถูกต้อง", "Invalid user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmpID.Focus()
            myDR.Close()
            myCon.Close()
            Exit Sub
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
