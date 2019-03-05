Imports System.Configuration
Module myModule
    Public empID, empName, empSurname, staName As String
    Public proIDFind As String
    Public myProjectName As String = "BIS Sale Expert System 2020"
    Public strCon As String =
      ConfigurationManager.ConnectionStrings("Train61VB2N3.My.MySettings.strCon").ConnectionString

End Module
