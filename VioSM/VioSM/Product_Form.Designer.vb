<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Form))
        X = New Button()
        btnLogout = New Button()
        ProductsDGV = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnAdd = New Button()
        txtProductName = New TextBox()
        txtProductQuantity = New TextBox()
        txtCategoryName = New Label()
        txtCategoryQuantity = New Label()
        btnLogo = New PictureBox()
        Panel1 = New Panel()
        btnRefresh = New Button()
        cbSearchCategory = New ComboBox()
        cbSelectCategory = New ComboBox()
        txtCategory = New Label()
        txtProductPrice = New TextBox()
        txtCategoryPrice = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CType(ProductsDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(1241, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 21
        X.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Purple
        btnLogout.Location = New Point(22, 723)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 19
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' ProductsDGV
        ' 
        ProductsDGV.BackgroundColor = Color.Purple
        ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ProductsDGV.Location = New Point(435, 96)
        ProductsDGV.Name = "ProductsDGV"
        ProductsDGV.RowHeadersWidth = 51
        ProductsDGV.Size = New Size(675, 617)
        ProductsDGV.TabIndex = 23
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Purple
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(168, 426)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 33)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Purple
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(319, 426)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 33)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Purple
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(23, 426)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 33)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.Purple
        txtProductName.ForeColor = Color.White
        txtProductName.Location = New Point(140, 96)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(268, 32)
        txtProductName.TabIndex = 19
        ' 
        ' txtProductQuantity
        ' 
        txtProductQuantity.BackColor = Color.Purple
        txtProductQuantity.ForeColor = Color.White
        txtProductQuantity.Location = New Point(140, 188)
        txtProductQuantity.Name = "txtProductQuantity"
        txtProductQuantity.Size = New Size(268, 32)
        txtProductQuantity.TabIndex = 18
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.AutoSize = True
        txtCategoryName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryName.ForeColor = Color.Purple
        txtCategoryName.Location = New Point(15, 96)
        txtCategoryName.Margin = New Padding(4, 0, 4, 0)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(70, 23)
        txtCategoryName.TabIndex = 16
        txtCategoryName.Text = "Name"
        ' 
        ' txtCategoryQuantity
        ' 
        txtCategoryQuantity.AutoSize = True
        txtCategoryQuantity.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryQuantity.ForeColor = Color.Purple
        txtCategoryQuantity.Location = New Point(15, 191)
        txtCategoryQuantity.Margin = New Padding(4, 0, 4, 0)
        txtCategoryQuantity.Name = "txtCategoryQuantity"
        txtCategoryQuantity.Size = New Size(93, 23)
        txtCategoryQuantity.TabIndex = 15
        txtCategoryQuantity.Text = "Quantity"
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), Image)
        btnLogo.Location = New Point(22, 22)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(82, 81)
        btnLogo.TabIndex = 20
        btnLogo.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(cbSearchCategory)
        Panel1.Controls.Add(cbSelectCategory)
        Panel1.Controls.Add(txtCategory)
        Panel1.Controls.Add(txtProductPrice)
        Panel1.Controls.Add(txtCategoryPrice)
        Panel1.Controls.Add(ProductsDGV)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtProductName)
        Panel1.Controls.Add(txtProductQuantity)
        Panel1.Controls.Add(txtCategoryName)
        Panel1.Controls.Add(txtCategoryQuantity)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(131, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1110, 716)
        Panel1.TabIndex = 15
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Purple
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(976, 55)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 35)
        btnRefresh.TabIndex = 30
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' cbSearchCategory
        ' 
        cbSearchCategory.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbSearchCategory.ForeColor = Color.Purple
        cbSearchCategory.FormattingEnabled = True
        cbSearchCategory.Location = New Point(697, 55)
        cbSearchCategory.Name = "cbSearchCategory"
        cbSearchCategory.Size = New Size(273, 35)
        cbSearchCategory.TabIndex = 29
        cbSearchCategory.Text = "Select Category"
        ' 
        ' cbSelectCategory
        ' 
        cbSelectCategory.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbSelectCategory.ForeColor = Color.Purple
        cbSelectCategory.FormattingEnabled = True
        cbSelectCategory.Location = New Point(140, 350)
        cbSelectCategory.Name = "cbSelectCategory"
        cbSelectCategory.Size = New Size(273, 35)
        cbSelectCategory.TabIndex = 28
        cbSelectCategory.Text = "Select Category"
        ' 
        ' txtCategory
        ' 
        txtCategory.AutoSize = True
        txtCategory.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategory.ForeColor = Color.Purple
        txtCategory.Location = New Point(15, 356)
        txtCategory.Margin = New Padding(4, 0, 4, 0)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(102, 23)
        txtCategory.TabIndex = 27
        txtCategory.Text = "Category"
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.BackColor = Color.Purple
        txtProductPrice.ForeColor = Color.White
        txtProductPrice.Location = New Point(145, 273)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(268, 32)
        txtProductPrice.TabIndex = 25
        ' 
        ' txtCategoryPrice
        ' 
        txtCategoryPrice.AutoSize = True
        txtCategoryPrice.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryPrice.ForeColor = Color.Purple
        txtCategoryPrice.Location = New Point(15, 276)
        txtCategoryPrice.Margin = New Padding(4, 0, 4, 0)
        txtCategoryPrice.Name = "txtCategoryPrice"
        txtCategoryPrice.Size = New Size(58, 23)
        txtCategoryPrice.TabIndex = 24
        txtCategoryPrice.Text = "Price"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(447, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 34)
        Label1.TabIndex = 3
        Label1.Text = "Manage Products"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(450, 3)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(507, 34)
        Label2.TabIndex = 14
        Label2.Text = "Shopping-mall Management System"
        ' 
        ' Product_Form
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 768)
        Controls.Add(X)
        Controls.Add(btnLogout)
        Controls.Add(btnLogo)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Product_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product_Form"
        CType(ProductsDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents X As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents ProductsDGV As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents txtCategoryName As Label
    Friend WithEvents txtCategoryQuantity As Label
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtCategoryPrice As Label
    Friend WithEvents txtCategory As Label
    Friend WithEvents cbSelectCategory As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cbSearchCategory As ComboBox
End Class
