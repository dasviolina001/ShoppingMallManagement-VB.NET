<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seller_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seller_Form))
        txtCategoryPassword = New Label()
        txtSellerMobileNO = New TextBox()
        txtCategoryMobileNO = New Label()
        SellersDGV = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnAdd = New Button()
        txtSellerName = New TextBox()
        txtSellerAge = New TextBox()
        txtCategoryName = New Label()
        Panel1 = New Panel()
        txtSellerPassword = New TextBox()
        txtCategoryAge = New Label()
        Label1 = New Label()
        Label2 = New Label()
        X = New Button()
        btnLogout = New Button()
        btnLogo = New PictureBox()
        CType(SellersDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCategoryPassword
        ' 
        txtCategoryPassword.AutoSize = True
        txtCategoryPassword.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryPassword.ForeColor = Color.Purple
        txtCategoryPassword.Location = New Point(15, 356)
        txtCategoryPassword.Margin = New Padding(4, 0, 4, 0)
        txtCategoryPassword.Name = "txtCategoryPassword"
        txtCategoryPassword.Size = New Size(100, 23)
        txtCategoryPassword.TabIndex = 27
        txtCategoryPassword.Text = "Password"
        ' 
        ' txtSellerMobileNO
        ' 
        txtSellerMobileNO.BackColor = Color.Purple
        txtSellerMobileNO.ForeColor = Color.White
        txtSellerMobileNO.Location = New Point(145, 268)
        txtSellerMobileNO.Name = "txtSellerMobileNO"
        txtSellerMobileNO.Size = New Size(268, 32)
        txtSellerMobileNO.TabIndex = 25
        ' 
        ' txtCategoryMobileNO
        ' 
        txtCategoryMobileNO.AutoSize = True
        txtCategoryMobileNO.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryMobileNO.ForeColor = Color.Purple
        txtCategoryMobileNO.Location = New Point(15, 271)
        txtCategoryMobileNO.Margin = New Padding(4, 0, 4, 0)
        txtCategoryMobileNO.Name = "txtCategoryMobileNO"
        txtCategoryMobileNO.Size = New Size(121, 23)
        txtCategoryMobileNO.TabIndex = 24
        txtCategoryMobileNO.Text = "Mobile NO."
        ' 
        ' SellersDGV
        ' 
        SellersDGV.BackgroundColor = Color.Purple
        SellersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SellersDGV.Location = New Point(435, 96)
        SellersDGV.Name = "SellersDGV"
        SellersDGV.RowHeadersWidth = 51
        SellersDGV.Size = New Size(675, 617)
        SellersDGV.TabIndex = 23
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
        ' txtSellerName
        ' 
        txtSellerName.BackColor = Color.Purple
        txtSellerName.ForeColor = Color.White
        txtSellerName.Location = New Point(145, 96)
        txtSellerName.Name = "txtSellerName"
        txtSellerName.Size = New Size(268, 32)
        txtSellerName.TabIndex = 19
        ' 
        ' txtSellerAge
        ' 
        txtSellerAge.BackColor = Color.Purple
        txtSellerAge.ForeColor = Color.White
        txtSellerAge.Location = New Point(145, 191)
        txtSellerAge.Name = "txtSellerAge"
        txtSellerAge.Size = New Size(268, 32)
        txtSellerAge.TabIndex = 18
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.AutoSize = True
        txtCategoryName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryName.ForeColor = Color.Purple
        txtCategoryName.Location = New Point(15, 105)
        txtCategoryName.Margin = New Padding(4, 0, 4, 0)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(70, 23)
        txtCategoryName.TabIndex = 16
        txtCategoryName.Text = "Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(txtSellerPassword)
        Panel1.Controls.Add(txtCategoryPassword)
        Panel1.Controls.Add(txtSellerMobileNO)
        Panel1.Controls.Add(txtCategoryMobileNO)
        Panel1.Controls.Add(SellersDGV)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtSellerName)
        Panel1.Controls.Add(txtSellerAge)
        Panel1.Controls.Add(txtCategoryName)
        Panel1.Controls.Add(txtCategoryAge)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(131, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1110, 716)
        Panel1.TabIndex = 23
        ' 
        ' txtSellerPassword
        ' 
        txtSellerPassword.BackColor = Color.Purple
        txtSellerPassword.ForeColor = Color.White
        txtSellerPassword.Location = New Point(145, 347)
        txtSellerPassword.Name = "txtSellerPassword"
        txtSellerPassword.Size = New Size(268, 32)
        txtSellerPassword.TabIndex = 28
        ' 
        ' txtCategoryAge
        ' 
        txtCategoryAge.AutoSize = True
        txtCategoryAge.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryAge.ForeColor = Color.Purple
        txtCategoryAge.Location = New Point(15, 194)
        txtCategoryAge.Margin = New Padding(4, 0, 4, 0)
        txtCategoryAge.Name = "txtCategoryAge"
        txtCategoryAge.Size = New Size(51, 23)
        txtCategoryAge.TabIndex = 15
        txtCategoryAge.Text = "Age"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(447, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 34)
        Label1.TabIndex = 3
        Label1.Text = "Manage Sellers"
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
        Label2.TabIndex = 22
        Label2.Text = "Shopping-mall Management System"
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(1241, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 29
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
        btnLogout.TabIndex = 27
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), Image)
        btnLogo.Location = New Point(22, 22)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(82, 81)
        btnLogo.TabIndex = 28
        btnLogo.TabStop = False
        ' 
        ' Seller_Form
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 768)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(X)
        Controls.Add(btnLogout)
        Controls.Add(btnLogo)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Seller_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Seller_Form"
        CType(SellersDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtCategoryPassword As Label
    Friend WithEvents txtSellerMobileNO As TextBox
    Friend WithEvents txtCategoryMobileNO As Label
    Friend WithEvents SellersDGV As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSellerName As TextBox
    Friend WithEvents txtSellerAge As TextBox
    Friend WithEvents txtCategoryName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCategoryAge As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents X As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents txtSellerPassword As TextBox
End Class
