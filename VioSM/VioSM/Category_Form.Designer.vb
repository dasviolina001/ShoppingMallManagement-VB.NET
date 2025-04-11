<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category_Form))
        Label2 = New Label()
        Panel1 = New Panel()
        CatagoriesDGV = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnAdd = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        txtCategoryName = New Label()
        txtCategoryDescription = New Label()
        Label1 = New Label()
        btnLogout = New Button()
        btnLogo = New PictureBox()
        X = New Button()
        Panel1.SuspendLayout()
        CType(CatagoriesDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(456, 9)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(507, 34)
        Label2.TabIndex = 5
        Label2.Text = "Shopping-mall Management System"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(CatagoriesDGV)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(txtCategoryName)
        Panel1.Controls.Add(txtCategoryDescription)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(131, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1110, 668)
        Panel1.TabIndex = 6
        ' 
        ' CatagoriesDGV
        ' 
        CatagoriesDGV.BackgroundColor = Color.Purple
        CatagoriesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CatagoriesDGV.Location = New Point(432, 48)
        CatagoriesDGV.Name = "CatagoriesDGV"
        CatagoriesDGV.RowHeadersWidth = 51
        CatagoriesDGV.Size = New Size(675, 617)
        CatagoriesDGV.TabIndex = 23
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Purple
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(182, 257)
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
        btnDelete.Location = New Point(325, 257)
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
        btnAdd.Location = New Point(14, 257)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 33)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Purple
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(140, 48)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(223, 27)
        TextBox4.TabIndex = 19
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Purple
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(140, 135)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(223, 27)
        TextBox3.TabIndex = 18
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.AutoSize = True
        txtCategoryName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryName.ForeColor = Color.Purple
        txtCategoryName.Location = New Point(14, 48)
        txtCategoryName.Margin = New Padding(4, 0, 4, 0)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(70, 23)
        txtCategoryName.TabIndex = 16
        txtCategoryName.Text = "Name"
        ' 
        ' txtCategoryDescription
        ' 
        txtCategoryDescription.AutoSize = True
        txtCategoryDescription.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryDescription.ForeColor = Color.Purple
        txtCategoryDescription.Location = New Point(14, 135)
        txtCategoryDescription.Margin = New Padding(4, 0, 4, 0)
        txtCategoryDescription.Name = "txtCategoryDescription"
        txtCategoryDescription.Size = New Size(119, 23)
        txtCategoryDescription.TabIndex = 15
        txtCategoryDescription.Text = "Description"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(447, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 34)
        Label1.TabIndex = 3
        Label1.Text = "Manage Categories"
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Purple
        btnLogout.Location = New Point(22, 694)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 11
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = My.Resources.Resources.menulogo__1_
        btnLogo.Location = New Point(22, 22)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(82, 81)
        btnLogo.TabIndex = 12
        btnLogo.TabStop = False
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(1240, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 13
        X.UseVisualStyleBackColor = True
        ' 
        ' Category_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 768)
        Controls.Add(X)
        Controls.Add(btnLogo)
        Controls.Add(btnLogout)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Category_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Category_Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(CatagoriesDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtCategoryName As Label
    Friend WithEvents txtCategoryDescription As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CatagoriesDGV As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents X As Button
End Class
