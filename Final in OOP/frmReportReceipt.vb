Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb

Public Class frmReportReceipt
    Dim comm As OleDbCommand

    Private Sub frmReportReceipt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        connect()
        comm = New OleDbCommand("DELETE * FROM tblOrder", conn)
        comm.ExecuteNonQuery()
        frmCashier.cart()
        Me.Close()
    End Sub
End Class