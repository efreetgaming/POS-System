Imports System.Data.OleDb
Public Class frmCashier
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand
    Dim PQuantity As Integer
    Dim OQuantity As Integer
    Dim PID As String
    Dim OID As String
    Dim PPrice As Integer
    Dim OPrice As Integer
    Dim VAT As Integer
    Dim rn As New Random
    Dim Code As String
    Dim loggedInTime As String

    Private Sub frmCashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SubTotalPrice As Double
        Dim SubTotalPriceNoVat As Double
        Dim TotVAT As Double
        product()
        cart()
        For Each x As DataGridViewRow In dgvCart.Rows()
            SubTotalPrice += x.Cells(5).Value
            SubTotalPriceNoVat += x.Cells(5).Value
            TotVAT += x.Cells(4).Value
        Next
        lblSubTotalPrice.Text = SubTotalPrice
        lblSubTotalNoVat.Text = SubTotalPriceNoVat
        lblTotalVat.Text = TotVAT
        If txtQuantity.Text = "" Then
            btnAddToCart.Enabled = False
        End If
        lblSubTotalNoVat.Text = "0.00"
        lblSubTotalPrice.Text = "0.00"
        lblTotalVat.Text = "0.00"

        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        loggedInTime = lblTime.Text
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")

        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Insert into tblLogHistory ([Name], [Roles], [Date], [Logged In], [Logged Out]) values('" & lblCashier.Text & "', '" & "Cashier" & "', '" & lblDate.Text & "', '" & lblTime.Text & "', '" & "Online" & "')"
        comm.ExecuteNonQuery()
    End Sub

    Function product()
        da = New OleDbDataAdapter("Select * from tblInventory", conn)
        dset = New DataSet
        da.Fill(dset, "tblInventory")
        dgvItem.DataSource = dset.Tables("tblInventory").DefaultView
        Return True
    End Function

    Function cart()
        da = New OleDbDataAdapter("Select * from tblOrder", conn)
        dset = New DataSet
        da.Fill(dset, "tblOrder")
        dgvCart.DataSource = dset.Tables("tblOrder").DefaultView
        Return True
    End Function

    Function computation()
        Dim SubTotalPrice As Double
        Dim SubTotalPriceNoVat As Double
        Dim TotVAT As Double
        For Each x As DataGridViewRow In dgvCart.Rows
            SubTotalPrice += x.Cells(5).Value
            SubTotalPriceNoVat += x.Cells(3).Value
            TotVAT += x.Cells(4).Value
        Next
        lblSubTotalPrice.Text = SubTotalPrice
        lblSubTotalNoVat.Text = SubTotalPriceNoVat
        lblTotalVat.Text = TotVAT
        Return True
    End Function

    Private Sub dgvItem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellClick
        PPrice = dgvItem.Rows(e.RowIndex).Cells(3).Value
        lblProduct.Text = dgvItem.Rows(e.RowIndex).Cells(1).Value.ToString
        lblPrice.Text = dgvItem.Rows(e.RowIndex).Cells(3).Value
        PQuantity = dgvItem.Rows(e.RowIndex).Cells(2).Value
        PID = dgvItem.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub dgvCart_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCart.CellClick
        OID = PID
        lblProduct.Text = dgvCart.Rows(e.RowIndex).Cells(1).Value.ToString
        lblPrice.Text = dgvItem.Rows(e.RowIndex).Cells(3).Value
        OQuantity = dgvCart.Rows(e.RowIndex).Cells(2).Value
        txtQuantity.Text = OQuantity
        OPrice = dgvCart.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub btnNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNone.Click
        lblTotal.Text = lblSubTotalPrice.Text
    End Sub

    Private Sub btnSeniorPWD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeniorPWD.Click
        Dim discount As Double
        discount = lblSubTotalPrice.Text * 0.12
        lblDiscount.Text = discount
        lblTotal.Text = lblSubTotalPrice.Text - discount
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        If txtQuantity.Text <> "" Then
            btnAddToCart.Enabled = True
        ElseIf txtQuantity.Text = "" Then
            btnAddToCart.Enabled = False
        End If
    End Sub


    Private Sub btnRemove_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Delete from tblOrder where Product_Name='" & lblProduct.Text & "'"
        comm.ExecuteNonQuery()
        cart()

        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Delete from tblSales where Purchase_Code='" & Code & "'"
        comm.ExecuteNonQuery()

        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "UPDATE tblInventory SET Product_Name=?, Quantity=? WHERE Product_Code=?"
        comm.Parameters.AddWithValue("@Product_Name", lblProduct.Text)
        comm.Parameters.AddWithValue("@Quantity", PQuantity)
        comm.Parameters.AddWithValue("@Product_Code", PID)
        comm.ExecuteNonQuery()
        product()

        lblPrice.Text = ""
        lblProduct.Text = ""
        txtQuantity.Clear()
        lblDiscount.Text = "0.00"
        lblTotal.Text = "0.00"
        lblChange.Text = "0.00"
        txtPayment.Clear()

        MsgBox("Item Removed Successfully!")
        cart()

        computation ()
    End Sub

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        Dim SubTotalPrice As Integer
        Dim SubTotalPriceNoVat As Integer
        Dim TotVAT As Integer
        For Each x As DataGridViewRow In dgvCart.Rows()
            SubTotalPrice += x.Cells(5).Value
            SubTotalPriceNoVat += x.Cells(5).Value
            TotVAT += x.Cells(4).Value
        Next
        lblSubTotalPrice.Text = SubTotalPrice
        lblSubTotalNoVat.Text = SubTotalPriceNoVat - TotVAT
        lblTotalVat.Text = TotVAT
        txtQuantity.Clear()

        If txtPayment.Text < SubTotalPrice Then
            MsgBox("Sorry your payment is not enough to complete purchase", MsgBoxStyle.Exclamation, "Notice")
            lblChange.Text = "0.00"
        Else
            Dim change As Double
            Dim payment As Double = txtPayment.Text
            change = payment - SubTotalPrice
            lblChange.Text = change
            MsgBox("Thank you for purchasing, your change is " + lblChange.Text, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NOTICE")
            frmReportReceipt.Show()
        End If
    End Sub

    Private Sub btnAddToCart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click
        If PQuantity >= txtQuantity.Text Then
            If txtQuantity.Text <> "" Then
                da = New OleDbDataAdapter("Select * from tblOrder where OID='" & PID & "'", conn)
                dset = New DataSet
                da.Fill(dset, "tblOrder")
                Dim Total As Integer = lblPrice.Text * txtQuantity.Text
                VAT = Total / 1.12
                Code = rn.Next(100000, 999999)
                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Insert into tblOrder values('" & PID & "','" & lblProduct.Text & "','" & txtQuantity.Text & "','" & lblPrice.Text & "', '" & VAT & "', '" & Total & "', '" & Code & "')"
                comm.ExecuteNonQuery()
                cart()

                Dim quantity As Integer = txtQuantity.Text
                Dim price As Integer = lblPrice.Text
                Dim vatprice As Integer = price - (price * 0.89)
                Dim novat As Integer = price - vatprice
                Dim cost As Integer = novat - 40
                Dim totalprice As Integer = lblPrice.Text * quantity
                Dim totalvat As Integer = vatprice * quantity
                Dim totalcost As Integer = cost * quantity
                Dim month As String = Date.Now.ToString("MMMM")
                Dim day As String = Date.Now.ToString("dd")
                Dim year As String = Date.Now.ToString("yyyy")
                Code = rn.Next(100000, 999999)

                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Insert into tblSales([Product_Code], [Product_Name], [Quantity], [Price], [VAT_Price], [Price_NoVAT], [Cost_Price], [Total_Price], [Total_VAT], [Total_Cost], [Cashier], [Month], [Day], [Year], [Time], [Purchase_Code]) values('" & PID & "','" & lblProduct.Text & "','" & txtQuantity.Text & "','" & lblPrice.Text & "', '" & vatprice & "', '" & novat & "', '" & cost & "', '" & totalprice & "', '" & totalvat & "', '" & totalcost & "', '" & lblCashier.Text & "', '" & month & "', '" & day & "', '" & year & "', '" & Date.Now.ToString("hh:mm:ss") & "', '" & Code & "')"
                comm.ExecuteNonQuery()

                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "UPDATE tblInventory SET Product_Name=?, Quantity=?, Price=? WHERE Product_Code=?"
                comm.Parameters.AddWithValue("@Product_Name", lblProduct.Text)
                comm.Parameters.AddWithValue("@Quantity", PQuantity - CInt(txtQuantity.Text))
                comm.Parameters.AddWithValue("@Price", CDbl(lblPrice.Text))
                comm.Parameters.AddWithValue("@Product_Code", PID)
                comm.ExecuteNonQuery()

                comm.ExecuteNonQuery()
                product()
                Dim SubTotalPrice As Integer
                Dim SubTotalPriceNoVat As Integer
                Dim TotVAT As Integer
                For Each x As DataGridViewRow In dgvCart.Rows()
                    SubTotalPrice += x.Cells(5).Value
                    SubTotalPriceNoVat += x.Cells(5).Value
                    TotVAT += x.Cells(4).Value
                Next
                lblSubTotalPrice.Text = SubTotalPrice
                lblSubTotalNoVat.Text = SubTotalPriceNoVat - TotVAT
                lblTotalVat.Text = TotVAT
                txtQuantity.Clear()
            End If
        Else
            MessageBox.Show("The quantity has exceeded the amount of stock available.")
            txtQuantity.Text = ""
        End If
        lblProduct.Text = ""
        txtQuantity.Text = ""
        lblPrice.Text = ""
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        If MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            connect()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "UPDATE tblHistory SET [Logged_Out]='" & Date.Now.ToString("hh:mm:ss") & "' WHERE [Names]='" & lblCashierName.Text & "' AND [Logged_In]='" & loggedInTime & "'"
            comm.ExecuteNonQuery()
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub lblCashierExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCashierExit.Click
        If MsgBox("Are you sure you want to log out?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Terminating...") = Windows.Forms.DialogResult.Yes Then
            connect()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "UPDATE tblLogHistory SET [Logged Out]='" & Date.Now.ToString("hh:mm:ss") & "' WHERE [Name]='" & lblCashierName.Text & "' AND [Logged In]='" & loggedInTime & "'"
            comm.ExecuteNonQuery()
            frmLogin.Show()
            Me.Close() ' This one will close the form
        Else
        End If
    End Sub
End Class