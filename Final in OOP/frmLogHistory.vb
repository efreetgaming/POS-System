Imports System.Data.OleDb
Public Class frmLogHistory
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand
    Public loggedInTime As String
    Public loggedInDate As String

    Private Sub frmLogHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogHistory()
    End Sub

    Function LogHistory()
        da = New OleDbDataAdapter("Select * from tblLogHistory ", conn)
        dset = New DataSet
        da.Fill(dset, "tblLogHistory")
        dgvLogHistory.DataSource = dset.Tables("tblLogHistory").DefaultView
        Return True
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        connect()
        comm = New OleDbCommand("DELETE * FROM tblLogHistory", conn)
        comm.ExecuteNonQuery()

        comm = New OleDbCommand("ALTER TABLE tblLogHistory ALTER COLUMN [No] COUNTER(1,1)", conn)
        comm.ExecuteNonQuery()

        LogHistory()
    End Sub

    Private Sub btnSearchCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCashier.Click
        Dim cmd As New OleDbCommand("SELECT * FROM tblLogHistory WHERE [Name] LIKE @name", conn)
        cmd.Parameters.AddWithValue("@name", OleDbType.VarChar).Value = "%" & txtSearchCashierLog.Text & ""
        da = New OleDbDataAdapter(cmd)
        dset = New DataSet
        da.Fill(dset, "tblLogHistory")
        dgvLogHistory.DataSource = dset.Tables("tblLogHistory").DefaultView
    End Sub
End Class