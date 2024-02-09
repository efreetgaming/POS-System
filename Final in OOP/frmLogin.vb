Imports System.Data.OleDb
Public Class frmLogin
    ' Start of Design
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.DarkGray

        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.DarkGray

        'Round in the avatar
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        gp.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Region = New Region(gp)
    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub lblClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClose.MouseHover
        lblClose.ForeColor = Color.Red
        lblClose.BackColor = Color.White
    End Sub

    Private Sub lblClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClose.MouseLeave
        lblClose.ForeColor = Color.Red
        lblClose.BackColor = Color.White
    End Sub
    ' End of Design

    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        da = New OleDbDataAdapter("Select * from tblAccounts where Username='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Wrong Input Please check your Username and Password")
        Else
            Try
                If dset.Tables("tblAccounts").Rows(0)("Roles") = "Administrator" Then
                    MessageBox.Show("Hello! Welcome Admin! " & dset.Tables("tblAccounts").Rows(0)("Names").ToString())
                    frmAdmin.lblName.Text = dset.Tables("tblAccounts").Rows(0)("Names").ToString
                    frmAdmin.Show()
                    Me.Hide()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    chkBoxPassword.Checked = False
                ElseIf dset.Tables("tblAccounts").Rows(0)("Roles") = "Cashier" Then
                    MessageBox.Show("Hello! Welcome Cashier! " & dset.Tables("tblAccounts").Rows(0)("Names").ToString())
                    frmCashier.lblCashier.Text = dset.Tables("tblAccounts").Rows(0)("Names").ToString
                    frmCashier.Show()
                    Me.Hide()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    chkBoxPassword.Checked = False
                Else
                    MessageBox.Show("Hey! Mind if you check your Username or Password? I think you inputted the wrong one.")
                End If
            Catch ex As Exception
                MessageBox.Show("Hey! Mind if you check your Username or Password? I think you inputted the wrong one.")
            End Try
        End If
    End Sub

    Private Sub chkBoxPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBoxPassword.CheckedChanged
        If chkBoxPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub
End Class