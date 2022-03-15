Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class AdisyonRaporFormu
    Public AdisyonNo As Integer
    Private Sub AdisyonRaporFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As New ReportDocument()
        Dim connection As IConnectionInfo
        Dim CumleOlustur As New SqlConnectionStringBuilder(BaglantiCumlesi)
        Dim serverName1 As String = CumleOlustur.DataSource
        Dim userID As String = CumleOlustur.UserID
        Dim password As String = CumleOlustur.Password

        report = CrystalReportViewer1.ReportSource

        ' Set Database Logon to main report
        For Each connection In report.DataSourceConnections
            Select Case connection.ServerName
                Case serverName1
                    connection.SetLogon(userID, password)
            End Select
        Next

        ' Set Database Logon to subreport
        Dim subreport As ReportDocument
        For Each subreport In report.Subreports
            For Each connection In subreport.DataSourceConnections
                Select Case connection.ServerName
                    Case serverName1
                        connection.SetLogon(userID, password)
                End Select
            Next
        Next
        report.Refresh()
        Dim parameterField As ParameterField
        parameterField = report.ParameterFields("AdisyonNoParam")
        parameterField.CurrentValues.AddValue(AdisyonNo)


    End Sub
End Class