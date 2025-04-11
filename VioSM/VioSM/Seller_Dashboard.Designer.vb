<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seller_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seller_Dashboard))
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnLogo = New PictureBox()
        X = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnLogout = New Button()
        btnSelling = New Button()
        btnCategories = New Button()
        btnProducts = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(735, 175)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(82, 79)
        PictureBox3.TabIndex = 50
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(421, 173)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 81)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = My.Resources.Resources.menulogo__1_
        btnLogo.Location = New Point(76, 173)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(82, 81)
        btnLogo.TabIndex = 47
        btnLogo.TabStop = False
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(860, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 46
        X.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Purple
        Label3.Location = New Point(339, 557)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(222, 34)
        Label3.TabIndex = 45
        Label3.Text = "Powered By VD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(327, 53)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(245, 34)
        Label2.TabIndex = 44
        Label2.Text = "Seller Dashboard"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(206, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(507, 34)
        Label1.TabIndex = 43
        Label1.Text = "Shopping-mall Management System"
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Purple
        btnLogout.Location = New Point(411, 439)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 41
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnSelling
        ' 
        btnSelling.FlatAppearance.BorderSize = 0
        btnSelling.FlatStyle = FlatStyle.Flat
        btnSelling.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelling.ForeColor = Color.Purple
        btnSelling.Location = New Point(735, 273)
        btnSelling.Name = "btnSelling"
        btnSelling.Size = New Size(94, 33)
        btnSelling.TabIndex = 40
        btnSelling.Text = "Selling"
        btnSelling.UseVisualStyleBackColor = True
        ' 
        ' btnCategories
        ' 
        btnCategories.FlatAppearance.BorderSize = 0
        btnCategories.FlatStyle = FlatStyle.Flat
        btnCategories.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCategories.ForeColor = Color.Purple
        btnCategories.Location = New Point(54, 272)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(126, 32)
        btnCategories.TabIndex = 39
        btnCategories.Text = "Categories"
        btnCategories.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProducts.ForeColor = Color.Purple
        btnProducts.Location = New Point(411, 275)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(103, 29)
        btnProducts.TabIndex = 38
        btnProducts.Text = "Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' Seller_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(16F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 600)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogo)
        Controls.Add(X)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Controls.Add(btnSelling)
        Controls.Add(btnCategories)
        Controls.Add(btnProducts)
        Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 5, 6, 5)
        Name = "Seller_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Seller_Dashboard"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents X As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSelling As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnProducts As Button
End Class
