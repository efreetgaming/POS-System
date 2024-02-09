<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.txtpricewithoutvat = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtcostprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddInv = New System.Windows.Forms.Button()
        Me.btnUpdateInv = New System.Windows.Forms.Button()
        Me.btnDeleteInv = New System.Windows.Forms.Button()
        Me.btnClearInv = New System.Windows.Forms.Button()
        Me.btnPrintInv = New System.Windows.Forms.Button()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.txtSearchInventory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblVatPrice = New System.Windows.Forms.Label()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpricewithoutvat
        '
        Me.txtpricewithoutvat.BackColor = System.Drawing.Color.LightCyan
        Me.txtpricewithoutvat.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpricewithoutvat.Location = New System.Drawing.Point(186, 382)
        Me.txtpricewithoutvat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpricewithoutvat.Name = "txtpricewithoutvat"
        Me.txtpricewithoutvat.Size = New System.Drawing.Size(180, 20)
        Me.txtpricewithoutvat.TabIndex = 45
        '
        'txtquantity
        '
        Me.txtquantity.BackColor = System.Drawing.Color.LightCyan
        Me.txtquantity.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(186, 353)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(180, 20)
        Me.txtquantity.TabIndex = 44
        '
        'txtcostprice
        '
        Me.txtcostprice.BackColor = System.Drawing.Color.LightCyan
        Me.txtcostprice.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcostprice.Location = New System.Drawing.Point(186, 325)
        Me.txtcostprice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcostprice.Name = "txtcostprice"
        Me.txtcostprice.Size = New System.Drawing.Size(180, 20)
        Me.txtcostprice.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(41, 293)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 23)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Product Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(55, 438)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Selling Price"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(70, 409)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "VAT Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(31, 380)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Price(w/o VAT)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(81, 350)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(70, 321)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Cost Price"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddInv
        '
        Me.btnAddInv.BackColor = System.Drawing.Color.Pink
        Me.btnAddInv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnAddInv.Location = New System.Drawing.Point(392, 295)
        Me.btnAddInv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddInv.Name = "btnAddInv"
        Me.btnAddInv.Size = New System.Drawing.Size(170, 26)
        Me.btnAddInv.TabIndex = 55
        Me.btnAddInv.Text = "Add"
        Me.btnAddInv.UseVisualStyleBackColor = False
        '
        'btnUpdateInv
        '
        Me.btnUpdateInv.BackColor = System.Drawing.Color.PeachPuff
        Me.btnUpdateInv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnUpdateInv.Location = New System.Drawing.Point(392, 330)
        Me.btnUpdateInv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateInv.Name = "btnUpdateInv"
        Me.btnUpdateInv.Size = New System.Drawing.Size(170, 26)
        Me.btnUpdateInv.TabIndex = 56
        Me.btnUpdateInv.Text = "Update"
        Me.btnUpdateInv.UseVisualStyleBackColor = False
        '
        'btnDeleteInv
        '
        Me.btnDeleteInv.BackColor = System.Drawing.Color.Salmon
        Me.btnDeleteInv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnDeleteInv.Location = New System.Drawing.Point(392, 365)
        Me.btnDeleteInv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteInv.Name = "btnDeleteInv"
        Me.btnDeleteInv.Size = New System.Drawing.Size(170, 26)
        Me.btnDeleteInv.TabIndex = 57
        Me.btnDeleteInv.Text = "Delete"
        Me.btnDeleteInv.UseVisualStyleBackColor = False
        '
        'btnClearInv
        '
        Me.btnClearInv.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClearInv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnClearInv.Location = New System.Drawing.Point(392, 400)
        Me.btnClearInv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearInv.Name = "btnClearInv"
        Me.btnClearInv.Size = New System.Drawing.Size(170, 25)
        Me.btnClearInv.TabIndex = 58
        Me.btnClearInv.Text = "Clear"
        Me.btnClearInv.UseVisualStyleBackColor = False
        '
        'btnPrintInv
        '
        Me.btnPrintInv.BackColor = System.Drawing.Color.SkyBlue
        Me.btnPrintInv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!)
        Me.btnPrintInv.Location = New System.Drawing.Point(392, 434)
        Me.btnPrintInv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintInv.Name = "btnPrintInv"
        Me.btnPrintInv.Size = New System.Drawing.Size(170, 25)
        Me.btnPrintInv.TabIndex = 59
        Me.btnPrintInv.Text = "Print"
        Me.btnPrintInv.UseVisualStyleBackColor = False
        '
        'dgvInventory
        '
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(11, 52)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowTemplate.Height = 24
        Me.dgvInventory.Size = New System.Drawing.Size(565, 229)
        Me.dgvInventory.TabIndex = 60
        '
        'txtSearchInventory
        '
        Me.txtSearchInventory.BackColor = System.Drawing.Color.MintCream
        Me.txtSearchInventory.Location = New System.Drawing.Point(11, 27)
        Me.txtSearchInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchInventory.Name = "txtSearchInventory"
        Me.txtSearchInventory.Size = New System.Drawing.Size(436, 20)
        Me.txtSearchInventory.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(447, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "SEARCH PRODUCT CODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(186, 295)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 63
        Me.lblID.Text = "Label2"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.LightCyan
        Me.txtProductName.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(186, 295)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(180, 20)
        Me.txtProductName.TabIndex = 64
        '
        'lblVatPrice
        '
        Me.lblVatPrice.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatPrice.Location = New System.Drawing.Point(186, 411)
        Me.lblVatPrice.Name = "lblVatPrice"
        Me.lblVatPrice.Size = New System.Drawing.Size(180, 21)
        Me.lblVatPrice.TabIndex = 65
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellingPrice.Location = New System.Drawing.Point(186, 440)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(180, 21)
        Me.lblSellingPrice.TabIndex = 66
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 488)
        Me.Controls.Add(Me.lblSellingPrice)
        Me.Controls.Add(Me.lblVatPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtSearchInventory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintInv)
        Me.Controls.Add(Me.btnClearInv)
        Me.Controls.Add(Me.btnDeleteInv)
        Me.Controls.Add(Me.btnUpdateInv)
        Me.Controls.Add(Me.btnAddInv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpricewithoutvat)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtcostprice)
        Me.Controls.Add(Me.dgvInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpricewithoutvat As System.Windows.Forms.TextBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txtcostprice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddInv As System.Windows.Forms.Button
    Friend WithEvents btnUpdateInv As System.Windows.Forms.Button
    Friend WithEvents btnDeleteInv As System.Windows.Forms.Button
    Friend WithEvents btnClearInv As System.Windows.Forms.Button
    Friend WithEvents btnPrintInv As System.Windows.Forms.Button
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchInventory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblVatPrice As System.Windows.Forms.Label
    Friend WithEvents lblSellingPrice As System.Windows.Forms.Label
End Class
