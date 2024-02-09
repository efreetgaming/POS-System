Imports System.Data.OleDb
Public Class frmInventory
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand
    Dim id As Integer

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inventory()
    End Sub

    Function inventory()
        da = New OleDbDataAdapter("Select * from tblInventory ", conn)
        dset = New DataSet
        da.Fill(dset, "tblInventory")
        dgvInventory.DataSource = dset.Tables("tblInventory").DefaultView
        Return True
    End Function

    Private Sub dgvInventory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        lblID.Text = dgvInventory.Rows(e.RowIndex).Cells(0).Value.ToString
        txtProductName.Text = dgvInventory.Rows(e.RowIndex).Cells(1).Value.ToString
        txtcostprice.Text = dgvInventory.Rows(e.RowIndex).Cells(6).Value.ToString
        txtquantity.Text = dgvInventory.Rows(e.RowIndex).Cells(2).Value.ToString
        txtpricewithoutvat.Text = dgvInventory.Rows(e.RowIndex).Cells(5).Value.ToString
        lblVatPrice.Text = dgvInventory.Rows(e.RowIndex).Cells(4).Value.ToString
        lblSellingPrice.Text = dgvInventory.Rows(e.RowIndex).Cells(3).Value.ToString()
    End Sub

    Private Sub btnAddInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInv.Click
        If txtProductName.Text <> "" And txtcostprice.Text <> "" And txtquantity.Text <> "" And txtpricewithoutvat.Text <> "" Then
            Dim isNumericFieldsValid As Boolean = IsNumeric(txtcostprice.Text) And IsNumeric(txtquantity.Text) And IsNumeric(txtpricewithoutvat.Text) And IsNumeric(lblVatPrice.Text) And IsNumeric(lblSellingPrice.Text)

            If isNumericFieldsValid Then
                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Insert into tblInventory ([Product_Name], [Quantity], [Price], [VAT_Price], [Price_NoVat], [Cost_Price]) values('" & txtProductName.Text & "', '" & txtquantity.Text & "', '" & lblSellingPrice.Text & "', '" & lblVatPrice.Text & "', '" & txtpricewithoutvat.Text & "', '" & txtcostprice.Text & "')"
                comm.ExecuteNonQuery()
                inventory()
            Else
                MessageBox.Show("Please ensure Product Name contains no letters and all numeric fields are valid.")
            End If
        Else
            MessageBox.Show("Please don't forget all the required field blanks")
        End If
    End Sub

    Private Sub btnUpdateInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateInv.Click
        connect()
        If txtProductName.Text <> "" And txtcostprice.Text <> "" And txtquantity.Text <> "" And txtpricewithoutvat.Text <> "" Then
            Dim isNumericFieldsValid As Boolean = IsNumeric(txtcostprice.Text) And IsNumeric(txtquantity.Text) And IsNumeric(txtpricewithoutvat.Text) And IsNumeric(lblVatPrice.Text) And IsNumeric(lblSellingPrice.Text)

            If isNumericFieldsValid Then
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Update tblInventory set [Product_Name]='" & txtProductName.Text & "', [Quantity]='" & txtquantity.Text & "', [Price]='" & lblSellingPrice.Text & "', [VAT_Price]='" & lblVatPrice.Text & "', [Price_NoVat]='" & txtpricewithoutvat.Text & "', [Cost_Price]='" & txtcostprice.Text & "' where [Product_Code]=" & id
                comm.ExecuteNonQuery()
                inventory()
            Else
                MessageBox.Show("Please ensure Product Name contains no letters and all numeric fields are valid.")
            End If
        Else
            MessageBox.Show("Please don't forget all the required field blanks")
        End If
    End Sub

    Private Sub btnDeleteInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInv.Click
        If txtProductName.Text = "" And txtcostprice.Text = "" And txtquantity.Text = "" And txtpricewithoutvat.Text = "" Then
            MsgBox("The Parameters or the text box are are missing please provide a number or text on it")
        End If
        If Integer.TryParse(lblID.Text, id) Then
            connect()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "Delete from tblInventory where Product_Code=" & id
            comm.ExecuteNonQuery()
            inventory()
        End If
    End Sub

    Private Sub btnClearInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearInv.Click
        txtcostprice.Clear()
        txtpricewithoutvat.Clear()
        txtProductName.Clear()
        txtquantity.Clear()
        lblSellingPrice.Text = ""
        lblVatPrice.Text = ""
    End Sub

    Private Sub btnPrintInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintInv.Click
        frmReportInventory.Show()
    End Sub

    Private Sub txtpricewithoutvat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpricewithoutvat.TextChanged
        If txtpricewithoutvat.Text = "" Then
            lblVatPrice.Text = ""
            lblSellingPrice.Text = ""
        ElseIf IsNumeric(txtpricewithoutvat.Text) Then
            Dim priceWithoutVat As Double = CDbl(txtpricewithoutvat.Text)
            Dim vatPrice As Double = priceWithoutVat * 0.12
            Dim sellingPrice As Double = priceWithoutVat + vatPrice
            lblVatPrice.Text = vatPrice.ToString()
            lblSellingPrice.Text = sellingPrice.ToString()
        End If
    End Sub

    Private Sub txtSearchInventory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchInventory.TextChanged
        da = New OleDbDataAdapter("Select * from tblInventory where Product_Code like '%" & txtSearchInventory.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "tblInventory")
        dgvInventory.DataSource = dset.Tables("tblInventory").DefaultView
    End Sub
End Class