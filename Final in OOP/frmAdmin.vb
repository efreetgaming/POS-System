Imports System.Threading
Imports System.Data.OleDb
Public Class frmAdmin
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand
    Dim loggedInTime As String
    Dim loggedInDate As String

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrDate.Enabled = True
        tmrTime.Enabled = True
        Me.Visible = False
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
        loggedInTime = lblTime.Text
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        loggedInDate = lblDate.Text
        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Insert into tblLogHistory ([Name], [Roles], [Date], [Logged In], [Logged Out]) values('" & lblName.Text & "', '" & "Administrator" & "', '" & lblDate.Text & "', '" & lblTime.Text & "', '" & "Online" & "')"
        comm.ExecuteNonQuery()
    End Sub

    ' Button Function
    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "UPDATE tblLogHistory SET [Logged Out]='" & Date.Now.ToString("hh:mm:ss") & "' WHERE [Name]='" & lblName.Text & "' AND [Logged In]='" & loggedInTime & "'"
        comm.ExecuteNonQuery()
        frmLogin.Show()
        Me.Close() ' This one will close the form
        frmLogin.Close()
    End Sub

    Private Sub lblExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseHover
        lblExit.BackColor = Color.Red ' When you hover the mouse in the label it will turn into red
    End Sub

    Private Sub lblExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseLeave
        lblExit.BackColor = Color.FromArgb(0, 0, 0, 0) ' This will go back to normal state of color
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "UPDATE tblLogHistory SET [Logged Out]='" & Date.Now.ToString("hh:mm:ss") & "' WHERE [Name]='" & lblName.Text & "' AND [Logged In]='" & loggedInTime & "'"
        comm.ExecuteNonQuery()
        frmLogin.Show()
        Me.Close() ' This one will close the form
    End Sub
    ' End of Button Function

    ' Changing the Form's Layout
    Private Sub addform(ByVal frm As Form)
        Panel1.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        Panel1.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub change_menu(ByVal menu As String)
        Select Case menu
            Case "Accountmanager"
                addform(frmAccountManager)
            Case "Sales"
                addform(frmSales)
            Case "Inventory"
                addform(frmInventory)
            Case "Log History"
                addform(frmLogHistory)
        End Select
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        change_menu("Inventory")
    End Sub

    Private Sub btnAccountManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccountManager.Click
        change_menu("Accountmanager")
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        change_menu("Sales")
    End Sub

    Private Sub btnLogHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogHistory.Click
        change_menu("Log History")
    End Sub
    ' End of Changing the Form

    ' Time and Date 
    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        If Not Me.DesignMode Then
            lblTime.Text = Date.Now.ToString("hh:mm:ss")
        End If
    End Sub

    Private Sub tmrDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDate.Tick
        If Not Me.DesignMode Then
            lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        End If
    End Sub
End Class