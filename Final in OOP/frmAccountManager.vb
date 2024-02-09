Imports System.Data.OleDb
Public Class frmAccountManager
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand
    Dim rcode As String
    Dim id As Integer

    Private Sub frmAccountManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        accountManager()
        cboDescription()
    End Sub

    Function cboDescription()
        da = New OleDbDataAdapter("Select * from tblRoles", conn)
        dset = New DataSet
        da.Fill(dset, "tblRoles")
        Dim count As Integer = dset.Tables("tblRoles").Rows.Count
        For x = 0 To count - 1
            cboRoles.Items.Add(dset.Tables("tblRoles").Rows(x).Item("RDes"))
        Next
        Return True
    End Function

    Function accountManager()
        da = New OleDbDataAdapter("Select * from tblAccounts", conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")
        dgvAccountManager.DataSource = dset.Tables("tblAccounts").DefaultView
        Return True
    End Function

    Private Sub cboRoles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoles.SelectedIndexChanged
        da = New OleDbDataAdapter("Select * from tblRoles where RDes='" & cboRoles.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "tblRoles")
        rcode = dset.Tables("tblRoles").Rows(0).Item("RCode")
    End Sub

    Private Sub dgvAccountManager_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccountManager.CellClick
        lblID.Text = dgvAccountManager.Rows(e.RowIndex).Cells(0).Value.ToString
        txtUsername.Text = dgvAccountManager.Rows(e.RowIndex).Cells(1).Value.ToString
        txtPassword.Text = dgvAccountManager.Rows(e.RowIndex).Cells(2).Value.ToString
        cboRoles.Text = dgvAccountManager.Rows(e.RowIndex).Cells(3).Value.ToString
        txtName.Text = dgvAccountManager.Rows(e.RowIndex).Cells(4).Value.ToString
        txtEmail.Text = dgvAccountManager.Rows(e.RowIndex).Cells(5).Value.ToString
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        da = New OleDbDataAdapter("Select * from tblAccounts where ID like '%" & txtSearch.Text & "%'", conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")
        dgvAccountManager.DataSource = dset.Tables("tblAccounts").DefaultView
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtUsername.Text <> "" And txtPassword.Text <> "" And cboRoles.Text <> "" And txtName.Text <> "" And txtEmail.Text <> "" Then
            connect()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "Insert into tblAccounts ([Username], [Password], [Roles], [Names], [Email]) values('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cboRoles.Text & "', '" & txtName.Text & "', '" & txtEmail.Text & "')"
            comm.ExecuteNonQuery()
            accountManager()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        connect()
        If Integer.TryParse(lblID.Text, id) Then
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "UPDATE tblAccounts SET [Username]='" & txtUsername.Text & "', [Password]='" & txtPassword.Text & "', [Roles]='" & cboRoles.Text & "', [Names]='" & txtName.Text & "', [Email]='" & txtEmail.Text & "' WHERE [ID]=" & id
            comm.ExecuteNonQuery()
            accountManager()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtEmail.Text = "" And txtName.Text = "" And txtPassword.Text = "" And txtUsername.Text = "" And cboRoles.Text = "" Then
            MsgBox("Please a select a data first before you delete")
        End If
        If Integer.TryParse(lblID.Text, id) Then
            connect()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "Delete from tblAccounts where ID=" & id
            comm.ExecuteNonQuery()
            accountManager()
        End If
    End Sub

    'Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
    'If txtName.Text <> "" Then
    'da = New OleDbDataAdapter("Select * from tblAccounts where Names='" & txtSearch.Text & "'", conn)
    'dset = New DataSet
    'da.Fill(dset, "tblAccounts")
    'If dset.Tables("tblAccounts").Rows.Count > 0 Then
    'MessageBox.Show("This name already existed to the Database")
    'End If
    'Else
    'MessageBox.Show("This name should not be leave as blank")
    'End If
    'End Sub
End Class