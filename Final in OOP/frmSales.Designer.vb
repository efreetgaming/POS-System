<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Profit = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalVat = New System.Windows.Forms.Label()
        Me.lbltotalsales = New System.Windows.Forms.Label()
        Me.btnPrintSalesReport = New System.Windows.Forms.Button()
        Me.btnClearSales = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Profit
        '
        Me.Profit.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profit.Location = New System.Drawing.Point(137, 420)
        Me.Profit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Profit.Name = "Profit"
        Me.Profit.Size = New System.Drawing.Size(254, 21)
        Me.Profit.TabIndex = 43
        Me.Profit.Text = "0"
        Me.Profit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(137, 389)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(254, 21)
        Me.lblTotalCost.TabIndex = 42
        Me.lblTotalCost.Text = "0"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalVat
        '
        Me.lblTotalVat.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVat.Location = New System.Drawing.Point(137, 357)
        Me.lblTotalVat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalVat.Name = "lblTotalVat"
        Me.lblTotalVat.Size = New System.Drawing.Size(254, 21)
        Me.lblTotalVat.TabIndex = 41
        Me.lblTotalVat.Text = "0"
        Me.lblTotalVat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltotalsales
        '
        Me.lbltotalsales.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsales.Location = New System.Drawing.Point(137, 325)
        Me.lbltotalsales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotalsales.Name = "lbltotalsales"
        Me.lbltotalsales.Size = New System.Drawing.Size(254, 21)
        Me.lbltotalsales.TabIndex = 40
        Me.lbltotalsales.Text = "0"
        Me.lbltotalsales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrintSalesReport
        '
        Me.btnPrintSalesReport.BackColor = System.Drawing.Color.LightGray
        Me.btnPrintSalesReport.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnPrintSalesReport.Location = New System.Drawing.Point(426, 315)
        Me.btnPrintSalesReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintSalesReport.Name = "btnPrintSalesReport"
        Me.btnPrintSalesReport.Size = New System.Drawing.Size(138, 63)
        Me.btnPrintSalesReport.TabIndex = 39
        Me.btnPrintSalesReport.Text = "Print Sales Report"
        Me.btnPrintSalesReport.UseVisualStyleBackColor = False
        '
        'btnClearSales
        '
        Me.btnClearSales.BackColor = System.Drawing.Color.LightGray
        Me.btnClearSales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnClearSales.Location = New System.Drawing.Point(426, 392)
        Me.btnClearSales.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearSales.Name = "btnClearSales"
        Me.btnClearSales.Size = New System.Drawing.Size(138, 63)
        Me.btnClearSales.TabIndex = 38
        Me.btnClearSales.Text = "Clear Sales"
        Me.btnClearSales.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 417)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 27)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Profit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 386)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Total Cost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 351)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 27)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Total VAT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 322)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 27)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Total Sales:"
        '
        'dgvSales
        '
        Me.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(10, 69)
        Me.dgvSales.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.RowTemplate.Height = 24
        Me.dgvSales.Size = New System.Drawing.Size(569, 220)
        Me.dgvSales.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(426, 44)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 20)
        Me.TextBox1.TabIndex = 32
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.Color.LightGray
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cboYear.Location = New System.Drawing.Point(316, 44)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(2)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(107, 21)
        Me.cboYear.TabIndex = 31
        '
        'cboDay
        '
        Me.cboDay.BackColor = System.Drawing.Color.LightGray
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboDay.Location = New System.Drawing.Point(206, 44)
        Me.cboDay.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(107, 21)
        Me.cboDay.TabIndex = 30
        '
        'cboMonth
        '
        Me.cboMonth.BackColor = System.Drawing.Color.LightGray
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(95, 44)
        Me.cboMonth.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(107, 21)
        Me.cboMonth.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Search"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Clear "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 488)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Profit)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalVat)
        Me.Controls.Add(Me.lbltotalsales)
        Me.Controls.Add(Me.btnPrintSalesReport)
        Me.Controls.Add(Me.btnClearSales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvSales)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.Text = "frmSales"
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Profit As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalVat As System.Windows.Forms.Label
    Friend WithEvents lbltotalsales As System.Windows.Forms.Label
    Friend WithEvents btnPrintSalesReport As System.Windows.Forms.Button
    Friend WithEvents btnClearSales As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
