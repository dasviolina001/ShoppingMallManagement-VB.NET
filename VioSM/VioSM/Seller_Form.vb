Imports System.Data.SqlClient
Public Class Seller_Form
    ' Connection string to your database file
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\DASVI\ONEDRIVE\DESKTOP\VIOSM\VIOSM\SMMSD.MDF;Integrated Security=True"
    ' Form Load event handler
    Private Sub Seller_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataGridView columns
        If SellersDGV.Columns.Count = 0 Then
            SellersDGV.Columns.Add("SellerId", "Seller ID")
            SellersDGV.Columns.Add("SellerName", "Seller Name")
            SellersDGV.Columns.Add("SellerAge", "Seller Age")
            SellersDGV.Columns.Add("SellerMobileNo", "Seller Mobile No")
            SellersDGV.Columns.Add("SellerPassword", "Seller Password")
        End If
        LoadSellers() ' Load sellers from database into DataGridView
    End Sub

    ' Load sellers from the database into DataGridView
    Private Sub LoadSellers()
        Try
            SellersDGV.Rows.Clear()
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT SellerId, SellerName, SellerAge, SellerMobileNo, SellerPassword FROM SellersTbl"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    For Each row As DataRow In table.Rows
                        SellersDGV.Rows.Add(row("SellerId"), row("SellerName"), row("SellerAge"), row("SellerMobileNo"), row("SellerPassword"))
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sellers: " & ex.Message)
        End Try
    End Sub

    ' Populate textboxes when a row is clicked in DataGridView
    Private Sub SellersDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SellersDGV.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = SellersDGV.Rows(e.RowIndex)
            txtSellerName.Text = selectedRow.Cells("SellerName").Value.ToString()
            txtSellerAge.Text = selectedRow.Cells("SellerAge").Value.ToString()
            txtSellerMobileNO.Text = selectedRow.Cells("SellerMobileNo").Value.ToString()
            txtSellerPassword.Text = selectedRow.Cells("SellerPassword").Value.ToString()
        End If
    End Sub

    ' Add Button Click Event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sellerName As String = txtSellerName.Text
        Dim sellerAge As String = txtSellerAge.Text
        Dim sellerMobileNo As String = txtSellerMobileNO.Text
        Dim sellerPassword As String = txtSellerPassword.Text

        If String.IsNullOrEmpty(sellerName) Or String.IsNullOrEmpty(sellerAge) Or String.IsNullOrEmpty(sellerMobileNo) Or String.IsNullOrEmpty(sellerPassword) Then
            MessageBox.Show("Please fill in all fields before adding.")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO SellersTbl (SellerName, SellerAge, SellerMobileNo, SellerPassword) VALUES (@SellerName, @SellerAge, @SellerMobileNo, @SellerPassword)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@SellerName", sellerName)
                        command.Parameters.AddWithValue("@SellerAge", sellerAge)
                        command.Parameters.AddWithValue("@SellerMobileNo", sellerMobileNo)
                        command.Parameters.AddWithValue("@SellerPassword", sellerPassword)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Seller Added Successfully!")
                LoadSellers()
                txtSellerName.Clear()
                txtSellerAge.Clear()
                txtSellerMobileNO.Clear()
                txtSellerPassword.Clear()
            Catch ex As Exception
                MessageBox.Show("Error adding seller: " & ex.Message)
            End Try
        End If
    End Sub

    ' Update Button Click Event
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedRow As DataGridViewRow = SellersDGV.CurrentRow
        If selectedRow IsNot Nothing Then
            Try
                Dim sellerId As Integer = selectedRow.Cells("SellerId").Value
                Dim sellerName As String = txtSellerName.Text
                Dim sellerAge As String = txtSellerAge.Text
                Dim sellerMobileNo As String = txtSellerMobileNO.Text
                Dim sellerPassword As String = txtSellerPassword.Text

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE SellersTbl SET SellerName = @SellerName, SellerAge = @SellerAge, SellerMobileNo = @SellerMobileNo, SellerPassword = @SellerPassword WHERE SellerId = @SellerId"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@SellerId", sellerId)
                        command.Parameters.AddWithValue("@SellerName", sellerName)
                        command.Parameters.AddWithValue("@SellerAge", sellerAge)
                        command.Parameters.AddWithValue("@SellerMobileNo", sellerMobileNo)
                        command.Parameters.AddWithValue("@SellerPassword", sellerPassword)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Seller Updated Successfully!")
                LoadSellers()
            Catch ex As Exception
                MessageBox.Show("Error updating seller: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a seller to update.")
        End If
    End Sub

    ' Delete Button Click Event
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRow As DataGridViewRow = SellersDGV.CurrentRow
        If selectedRow IsNot Nothing Then
            Try
                Dim sellerId As Integer = selectedRow.Cells("SellerId").Value
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM SellersTbl WHERE SellerId = @SellerId"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@SellerId", sellerId)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Seller Deleted Successfully!")
                LoadSellers()
            Catch ex As Exception
                MessageBox.Show("Error deleting seller: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a seller to delete.")
        End If
    End Sub

    ' Validate Seller Login Method
    Public Function ValidateSellerLogin(username As String, password As String) As Boolean
        Try
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Username or Password cannot be empty.")
                Return False
            End If

            username = username.Trim()
            password = password.Trim()

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
            MessageBox.Show("Error validating login: " & ex.Message)
            Return False
        End Try
    End Function

    ' Logout Button Click Event
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    ' Close button (X) to close the current form without exiting the application
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close() ' Closes only the current form
    End Sub

    Private Sub txtSellerName_TextChanged(sender As Object, e As EventArgs) Handles txtSellerName.TextChanged

    End Sub

End Class
