Imports System.Data.SqlClient

Public Class Product_Form
    ' Connection string to the local database file
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\DASVI\ONEDRIVE\DESKTOP\VIOSM\VIOSM\SMMSD.MDF;Integrated Security=True"

    ' Load Form and retrieve data from the database
    Private Sub Product_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCategoryComboBox()    ' Populate the combo boxes with data on load
        PopulateSearchCategoryComboBox()  ' Populate search category ComboBox dynamically
        LoadData()    ' Load all products into DataGridView initially
    End Sub

    ' Populate categories in the ComboBox from the database (for product addition)
    Private Sub PopulateCategoryComboBox()
        cbSelectCategory.Items.Clear()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT CatName FROM CategoriesTbl"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        cbSelectCategory.Items.Add(reader("CatName").ToString())
                    End While
                End If
                cbSelectCategory.Text = "Select Category"
                cbSelectCategory.SelectedIndex = -1
            Catch ex As Exception
                MessageBox.Show("Error loading categories: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Populate categories for search
    Private Sub PopulateSearchCategoryComboBox()
        cbSearchCategory.Items.Clear()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT CatName FROM CategoriesTbl"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        cbSearchCategory.Items.Add(reader("CatName").ToString())
                    End While
                End If
                cbSearchCategory.Text = "Select Category"
                cbSearchCategory.SelectedIndex = -1
            Catch ex As Exception
                MessageBox.Show("Error loading search categories: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load data into DataGridView
    Private Sub LoadData(Optional ByVal categoryFilter As String = "")
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM ProductsTbl"
                If Not String.IsNullOrEmpty(categoryFilter) Then
                    query &= " WHERE ProdCat = @ProdCat"
                End If

                Dim adapter As New SqlDataAdapter(query, conn)
                If Not String.IsNullOrEmpty(categoryFilter) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@ProdCat", categoryFilter)
                End If

                Dim table As New DataTable()
                adapter.Fill(table)
                ProductsDGV.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add Product
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProductName.Text = "" OrElse txtProductQuantity.Text = "" OrElse txtProductPrice.Text = "" OrElse cbSelectCategory.SelectedItem Is Nothing OrElse cbSelectCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO ProductsTbl (ProdName, ProdQty, ProdPrice, ProdCat) VALUES (@ProdName, @ProdQty, @ProdPrice, @ProdCat)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProdName", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@ProdQty", CInt(txtProductQuantity.Text))
                    cmd.Parameters.AddWithValue("@ProdPrice", CDbl(txtProductPrice.Text))
                    cmd.Parameters.AddWithValue("@ProdCat", cbSelectCategory.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product added successfully!")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error adding product: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update Product
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ProductsDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to update.")
            Return
        End If

        Dim prodId As Integer = CInt(ProductsDGV.SelectedRows(0).Cells("ProdID").Value)

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE ProductsTbl SET ProdName = @ProdName, ProdQty = @ProdQty, ProdPrice = @ProdPrice, ProdCat = @ProdCat WHERE ProdID = @ProdID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProdID", prodId)
                    cmd.Parameters.AddWithValue("@ProdName", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@ProdQty", CInt(txtProductQuantity.Text))
                    cmd.Parameters.AddWithValue("@ProdPrice", CDbl(txtProductPrice.Text))
                    cmd.Parameters.AddWithValue("@ProdCat", cbSelectCategory.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product updated successfully!")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error updating product: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete Product
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ProductsDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.")
            Return
        End If

        Dim prodId As Integer = CInt(ProductsDGV.SelectedRows(0).Cells("ProdID").Value)

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM ProductsTbl WHERE ProdID = @ProdID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProdID", prodId)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product deleted successfully!")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Search by category
    Private Sub cbSearchCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchCategory.SelectedIndexChanged
        If cbSearchCategory.SelectedIndex >= 0 Then
            LoadData(cbSearchCategory.SelectedItem.ToString())
        End If
    End Sub

    ' Refresh
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cbSearchCategory.SelectedIndex = -1
        LoadData()
    End Sub

    ' Populate fields on DataGridView row click
    Private Sub ProductsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDGV.CellClick
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex >= 0 Then
            txtProductName.Text = ProductsDGV.Rows(rowIndex).Cells("ProdName").Value.ToString()
            txtProductQuantity.Text = ProductsDGV.Rows(rowIndex).Cells("ProdQty").Value.ToString()
            txtProductPrice.Text = ProductsDGV.Rows(rowIndex).Cells("ProdPrice").Value.ToString()
            cbSelectCategory.SelectedItem = ProductsDGV.Rows(rowIndex).Cells("ProdCat").Value.ToString()
        End If
    End Sub

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
End Class
