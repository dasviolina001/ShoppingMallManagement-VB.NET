<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        X = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnUser = New PictureBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        btnLogin = New Button()
        btnReset = New Button()
        btnTogglePW = New Button()
        CType(btnUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(867, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(33, 31)
        X.TabIndex = 1
        X.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(365, 557)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(222, 34)
        Label3.TabIndex = 6
        Label3.Text = "Powered By VD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(374, 54)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 34)
        Label2.TabIndex = 5
        Label2.Text = "Login Panel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(206, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(507, 34)
        Label1.TabIndex = 4
        Label1.Text = "Shopping-mall Management System"
        ' 
        ' btnUser
        ' 
        btnUser.BackColor = Color.Transparent
        btnUser.Image = My.Resources.Resources.login__1_
        btnUser.Location = New Point(374, 123)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(159, 150)
        btnUser.TabIndex = 7
        btnUser.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = SystemColors.HotTrack
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(359, 290)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(228, 35)
        ComboBox1.TabIndex = 8
        ComboBox1.Text = "Select Role"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(440, 349)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 41)
        TextBox1.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(236, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 27)
        Label4.TabIndex = 10
        Label4.Text = "Enter Username"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(236, 411)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 27)
        Label5.TabIndex = 11
        Label5.Text = "Enter Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(440, 404)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(262, 41)
        TextBox2.TabIndex = 12
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Blue
        btnLogin.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(272, 477)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(167, 48)
        btnLogin.TabIndex = 13
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(497, 477)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(167, 48)
        btnReset.TabIndex = 14
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnTogglePW
        ' 
        btnTogglePW.Image = My.Resources.Resources.eyelogo__1_
        btnTogglePW.Location = New Point(655, 411)
        btnTogglePW.Name = "btnTogglePW"
        btnTogglePW.Size = New Size(38, 27)
        btnTogglePW.TabIndex = 15
        btnTogglePW.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(16F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 600)
        Controls.Add(btnTogglePW)
        Controls.Add(btnReset)
        Controls.Add(btnLogin)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(btnUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(X)
        Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(6, 5, 6, 5)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(btnUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents X As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUser As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnTogglePW As Button
End Class
