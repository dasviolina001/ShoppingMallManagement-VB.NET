<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Label2 = New Label()
        X = New Button()
        btnLogout = New Button()
        btnLogo = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        btnPreview = New Button()
        txtBillId = New TextBox()
        btnDone = New Button()
        cbSelectProducts = New ComboBox()
        txtCustomerPhNO = New TextBox()
        txtSellingCustomerPhNO = New Label()
        txtCustomerName = New TextBox()
        txtSellingCustomerName = New Label()
        lblBillId = New Label()
        lblDate = New Label()
        lblAmount = New Label()
        txtProductQuantity = New TextBox()
        BillsDGV = New DataGridView()
        btnPrint = New Button()
        btnDelete = New Button()
        txtSellingQuantity = New Label()
        btnAdd = New Button()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(BillsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(394, 9)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(507, 34)
        Label2.TabIndex = 23
        Label2.Text = "Shopping-mall Management System"
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(1243, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 30
        X.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Purple
        btnLogout.Location = New Point(12, 723)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 31
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), Image)
        btnLogo.Location = New Point(12, 12)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(82, 79)
        btnLogo.TabIndex = 32
        btnLogo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(540, 43)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 34)
        Label1.TabIndex = 33
        Label1.Text = "Manage Sales"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(btnPreview)
        Panel1.Controls.Add(txtBillId)
        Panel1.Controls.Add(btnDone)
        Panel1.Controls.Add(cbSelectProducts)
        Panel1.Controls.Add(txtCustomerPhNO)
        Panel1.Controls.Add(txtSellingCustomerPhNO)
        Panel1.Controls.Add(txtCustomerName)
        Panel1.Controls.Add(txtSellingCustomerName)
        Panel1.Controls.Add(lblBillId)
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(lblAmount)
        Panel1.Controls.Add(txtProductQuantity)
        Panel1.Controls.Add(BillsDGV)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(txtSellingQuantity)
        Panel1.Controls.Add(btnAdd)
        Panel1.Location = New Point(149, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1119, 686)
        Panel1.TabIndex = 34
        ' 
        ' btnPreview
        ' 
        btnPreview.BackColor = Color.Purple
        btnPreview.FlatAppearance.BorderSize = 0
        btnPreview.FlatStyle = FlatStyle.Flat
        btnPreview.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPreview.ForeColor = Color.White
        btnPreview.Location = New Point(533, 641)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(94, 33)
        btnPreview.TabIndex = 47
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = False
        ' 
        ' txtBillId
        ' 
        txtBillId.BackColor = Color.Purple
        txtBillId.ForeColor = Color.White
        txtBillId.Location = New Point(170, 73)
        txtBillId.Name = "txtBillId"
        txtBillId.Size = New Size(178, 32)
        txtBillId.TabIndex = 46
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.Purple
        btnDone.FlatAppearance.BorderSize = 0
        btnDone.FlatStyle = FlatStyle.Flat
        btnDone.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDone.ForeColor = Color.White
        btnDone.Location = New Point(382, 641)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(94, 33)
        btnDone.TabIndex = 45
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' cbSelectProducts
        ' 
        cbSelectProducts.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbSelectProducts.ForeColor = Color.Purple
        cbSelectProducts.FormattingEnabled = True
        cbSelectProducts.Location = New Point(49, 260)
        cbSelectProducts.Name = "cbSelectProducts"
        cbSelectProducts.Size = New Size(273, 35)
        cbSelectProducts.TabIndex = 44
        cbSelectProducts.Text = "Select Products"
        ' 
        ' txtCustomerPhNO
        ' 
        txtCustomerPhNO.BackColor = Color.Purple
        txtCustomerPhNO.ForeColor = Color.White
        txtCustomerPhNO.Location = New Point(170, 169)
        txtCustomerPhNO.Name = "txtCustomerPhNO"
        txtCustomerPhNO.Size = New Size(178, 32)
        txtCustomerPhNO.TabIndex = 43
        ' 
        ' txtSellingCustomerPhNO
        ' 
        txtSellingCustomerPhNO.AutoSize = True
        txtSellingCustomerPhNO.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSellingCustomerPhNO.ForeColor = Color.Purple
        txtSellingCustomerPhNO.Location = New Point(4, 172)
        txtSellingCustomerPhNO.Margin = New Padding(4, 0, 4, 0)
        txtSellingCustomerPhNO.Name = "txtSellingCustomerPhNO"
        txtSellingCustomerPhNO.Size = New Size(159, 23)
        txtSellingCustomerPhNO.TabIndex = 42
        txtSellingCustomerPhNO.Text = "CustomerPhNO"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BackColor = Color.Purple
        txtCustomerName.ForeColor = Color.White
        txtCustomerName.Location = New Point(170, 119)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(178, 32)
        txtCustomerName.TabIndex = 41
        ' 
        ' txtSellingCustomerName
        ' 
        txtSellingCustomerName.AutoSize = True
        txtSellingCustomerName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSellingCustomerName.ForeColor = Color.Purple
        txtSellingCustomerName.Location = New Point(4, 119)
        txtSellingCustomerName.Margin = New Padding(4, 0, 4, 0)
        txtSellingCustomerName.Name = "txtSellingCustomerName"
        txtSellingCustomerName.Size = New Size(164, 23)
        txtSellingCustomerName.TabIndex = 40
        txtSellingCustomerName.Text = "CustomerName"
        ' 
        ' lblBillId
        ' 
        lblBillId.AutoSize = True
        lblBillId.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBillId.ForeColor = Color.Purple
        lblBillId.Location = New Point(16, 76)
        lblBillId.Margin = New Padding(4, 0, 4, 0)
        lblBillId.Name = "lblBillId"
        lblBillId.Size = New Size(63, 23)
        lblBillId.TabIndex = 39
        lblBillId.Text = "Bill ID"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.Purple
        lblDate.Location = New Point(940, 0)
        lblDate.Margin = New Padding(4, 0, 4, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(56, 23)
        lblDate.TabIndex = 38
        lblDate.Text = "Date"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAmount.ForeColor = Color.Purple
        lblAmount.Location = New Point(985, 641)
        lblAmount.Margin = New Padding(4, 0, 4, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(37, 23)
        lblAmount.TabIndex = 35
        lblAmount.Text = " Rs"
        ' 
        ' txtProductQuantity
        ' 
        txtProductQuantity.BackColor = Color.Purple
        txtProductQuantity.ForeColor = Color.White
        txtProductQuantity.Location = New Point(141, 327)
        txtProductQuantity.Name = "txtProductQuantity"
        txtProductQuantity.Size = New Size(196, 32)
        txtProductQuantity.TabIndex = 18
        ' 
        ' BillsDGV
        ' 
        BillsDGV.BackgroundColor = Color.Purple
        BillsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillsDGV.Location = New Point(354, 73)
        BillsDGV.Name = "BillsDGV"
        BillsDGV.RowHeadersWidth = 51
        BillsDGV.Size = New Size(753, 554)
        BillsDGV.TabIndex = 23
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Purple
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(683, 641)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 33)
        btnPrint.TabIndex = 22
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Purple
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(187, 417)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(135, 33)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' txtSellingQuantity
        ' 
        txtSellingQuantity.AutoSize = True
        txtSellingQuantity.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSellingQuantity.ForeColor = Color.Purple
        txtSellingQuantity.Location = New Point(29, 330)
        txtSellingQuantity.Margin = New Padding(4, 0, 4, 0)
        txtSellingQuantity.Name = "txtSellingQuantity"
        txtSellingQuantity.Size = New Size(93, 23)
        txtSellingQuantity.TabIndex = 15
        txtSellingQuantity.Text = "Quantity"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Purple
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(16, 417)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(134, 33)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 768)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(btnLogo)
        Controls.Add(btnLogout)
        Controls.Add(X)
        Controls.Add(Label2)
        Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Sales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales"
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(BillsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents X As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomerPhNO As TextBox
    Friend Protected WithEvents txtSellingCustomerPhNO As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend Protected WithEvents txtSellingCustomerName As Label
    Friend WithEvents lblBillId As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents BillsDGV As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents txtSellingQuantity As Label
    Friend WithEvents cbSelectProducts As ComboBox
    Friend WithEvents btnDone As Button
    Friend WithEvents txtBillId As TextBox
    Friend WithEvents btnPreview As Button
End Class
