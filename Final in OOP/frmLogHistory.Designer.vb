<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogHistory))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvLogHistory = New System.Windows.Forms.DataGridView()
        Me.txtSearchCashierLog = New System.Windows.Forms.TextBox()
        Me.btnSearchCashier = New System.Windows.Forms.Button()
        CType(Me.dgvLogHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDelete.Location = New System.Drawing.Point(483, 57)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 24)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvLogHistory
        '
        Me.dgvLogHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLogHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogHistory.Location = New System.Drawing.Point(12, 87)
        Me.dgvLogHistory.Name = "dgvLogHistory"
        Me.dgvLogHistory.Size = New System.Drawing.Size(563, 389)
        Me.dgvLogHistory.TabIndex = 2
        '
        'txtSearchCashierLog
        '
        Me.txtSearchCashierLog.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCashierLog.Location = New System.Drawing.Point(11, 57)
        Me.txtSearchCashierLog.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchCashierLog.Name = "txtSearchCashierLog"
        Me.txtSearchCashierLog.Size = New System.Drawing.Size(306, 24)
        Me.txtSearchCashierLog.TabIndex = 38
        '
        'btnSearchCashier
        '
        Me.btnSearchCashier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearchCashier.Location = New System.Drawing.Point(322, 57)
        Me.btnSearchCashier.Name = "btnSearchCashier"
        Me.btnSearchCashier.Size = New System.Drawing.Size(92, 24)
        Me.btnSearchCashier.TabIndex = 39
        Me.btnSearchCashier.Text = "Search Cashier"
        Me.btnSearchCashier.UseVisualStyleBackColor = False
        '
        'frmLogHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 488)
        Me.Controls.Add(Me.btnSearchCashier)
        Me.Controls.Add(Me.txtSearchCashierLog)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvLogHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogHistory"
        Me.Text = "frmLogHistory"
        CType(Me.dgvLogHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvLogHistory As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchCashierLog As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchCashier As System.Windows.Forms.Button
End Class
