Imports System.Data.SqlClient

Public Class login
    ' Database connection string
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\DASVI\ONEDRIVE\DESKTOP\VIOSM\VIOSM\SMMSD.MDF;Integrated Security=True"

    ' Close the login form
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    ' Login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a role.")
        ElseIf String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Please enter both username and password.")
        Else
            Dim username As String = TextBox1.Text.Trim()
            Dim password As String = TextBox2.Text.Trim()

            If ComboBox1.SelectedItem.ToString() = "Admin" Then
                ' Validate Admin login
                If ValidateAdminLogin(username, password) Then
                    MessageBox.Show("Admin login successful!")
                    Me.Hide()
                    Dim adminDashboard As New Admin_Dashboard()
                    adminDashboard.Show()
                Else
                    MessageBox.Show("Invalid admin username or password.")
                End If
            ElseIf ComboBox1.SelectedItem.ToString() = "Seller" Then
                ' Validate Seller login
                If ValidateSellerLogin(username, password) Then
                    MessageBox.Show("Seller login successful!")
                    Me.Hide()
                    Dim sellerDashboard As New Seller_Dashboard()
                    sellerDashboard.Show()
                Else
                    MessageBox.Show("Invalid seller username or password.")
                End If
            Else
                MessageBox.Show("Role not recognized.")
            End If
        End If
    End Sub

    ' Hardcoded validation for Admin
    Public Function ValidateAdminLogin(username As String, password As String) As Boolean
        Return username = "admin" AndAlso password = "admin123"
    End Function

    ' Database validation for Seller
    Public Function ValidateSellerLogin(username As String, password As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM SellersTbl WHERE SellerName = @SellerName AND SellerPassword = @SellerPassword"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SellerName", username)
                    command.Parameters.AddWithValue("@SellerPassword", password)
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
            Return False
        End Try
    End Function

    ' Reset fields
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    ' Load roles into ComboBox
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Seller")
        ComboBox1.SelectedIndex = -1
        TextBox2.PasswordChar = "●" ' Use a bullet character to mask the password
    End Sub

    ' Exit application on form close
    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Toggle password visibility
    ' Toggle password visibility
    Private Sub btnTogglePW_Click(sender As Object, e As EventArgs) Handles btnTogglePW.Click
        ' Check the current state of PasswordChar
        If TextBox2.PasswordChar = "●" Then
            TextBox2.PasswordChar = "" ' Show the password
        Else
            TextBox2.PasswordChar = "●" ' Mask the password
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
