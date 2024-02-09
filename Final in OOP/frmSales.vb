Imports System.Data.OleDb
Public Class frmSales
    Dim comm As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Private Sub btnPrintSalesReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSalesReport.Click
        frmReportSales.Show()
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sales()
        labelComputation()
    End Sub

    Private Sub btnClearSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSales.Click
        If cboMonth.Text = "" Or cboDay.Text = "" Or cboYear.Text = "" Then
            If MessageBox.Show("Are you sure you want to clear the entire data in tblSales?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                connect()
                comm = New OleDbCommand("DELETE * FROM tblSales", conn)
                comm.ExecuteNonQuery()
                sales()
            End If
        Else
            If cboMonth.Text <> "" Or cboDay.Text <> "" Or cboYear.Text <> "" Then
                Dim message As String = "This action will clear all data in tblSales that match the selected month, day, and year. Are you sure you want to proceed?"
                Dim result As DialogResult = MessageBox.Show(message, "Clear Sales Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    connect()
                    Dim query As String = "DELETE FROM tblSales WHERE 1=1"
                    If cboMonth.Text <> "" Then
                        query &= " AND Month='" & cboMonth.Text & "'"
                    End If
                    If cboDay.Text <> "" Then
                        query &= " AND Day='" & cboDay.Text & "'"
                    End If
                    If cboYear.Text <> "" Then
                        query &= " AND Year='" & cboYear.Text & "'"
                    End If
                    comm = New OleDbCommand(query, conn)
                    comm.ExecuteNonQuery()
                    sales()
                End If
            End If
        End If
    End Sub

    Function sales()
        da = New OleDbDataAdapter("Select * from tblSales ", conn)
        dset = New DataSet
        da.Fill(dset, "tblSales")
        dgvSales.DataSource = dset.Tables("tblSales").DefaultView
        Return True
    End Function

    Function labelComputation()
        Dim totalsales As Integer
        Dim totalvat As Integer
        Dim totalcost As Integer

        For Each x As DataGridViewRow In dgvSales.Rows()
            totalsales += x.Cells(7).Value
            totalvat += x.Cells(8).Value
            totalcost += x.Cells(9).Value
        Next
        lbltotalsales.Text = totalsales
        lblTotalVat.Text = totalvat
        lblTotalCost.Text = totalcost
        Profit.Text = lbltotalsales.Text - lblTotalCost.Text
        Return True
    End Function

    Private Sub dgvSales_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSales.CellClick
        lbltotalsales.Text = dgvSales.Rows(e.RowIndex).Cells(9).Value.ToString
        lblTotalVat.Text = dgvSales.Rows(e.RowIndex).Cells(8).Value.ToString
        lblTotalCost.Text = dgvSales.Rows(e.RowIndex).Cells(7).Value.ToString
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        da = New OleDbDataAdapter("Select * from tblSales where Month like '%" & cboMonth.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "tblSales")
        dgvSales.DataSource = dset.Tables("tblSales").DefaultView
        labelComputation()
    End Sub

    Private Sub cboDay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDay.SelectedIndexChanged
        da = New OleDbDataAdapter("Select * from tblSales where Day like '%" & cboDay.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "tblSales")
        dgvSales.DataSource = dset.Tables("tblSales").DefaultView
        labelComputation()
    End Sub

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        da = New OleDbDataAdapter("Select * from tblSales where Year like '%" & cboYear.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "tblSales")
        dgvSales.DataSource = dset.Tables("tblSales").DefaultView
        labelComputation()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cboDay.SelectedIndex = -1
        cboMonth.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        TextBox1.Text = ""
    End Sub
End Class