Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportInventory

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crystal As New ReportDocument
        crystal.Load("c:\users\llaga\documents\visual studio 2010\Projects\Final in OOP\Final in OOP\reportInventory.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub frmReportInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class