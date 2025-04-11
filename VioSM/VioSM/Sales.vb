Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Sales
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\DASVI\ONEDRIVE\DESKTOP\VIOSM\VIOSM\SMMSD.MDF;Integrated Security=True"
    Private totalAmount As Decimal = 0

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd")
        PopulateProducts()

        If BillsDGV.Columns.Count = 0 Then

            BillsDGV.Columns.Add("BillId", "Bill ID")
            BillsDGV.Columns.Add("CustomerName", "Customer Name")
            BillsDGV.Columns.Add("CustomerPhNO", "Customer Phone")
            BillsDGV.Columns.Add("ProdName", "Product Name")
            BillsDGV.Columns.Add("ProdQty", "Quantity")
            BillsDGV.Columns.Add("ProdPrice", "Price")
            BillsDGV.Columns.Add("TotalAmount", "Total")
        End If
    End Sub

    ' Populate Products in ComboBox
    Private Sub PopulateProducts()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT ProdName FROM ProductsTbl"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                cbSelectProducts.Items.Clear()
                While reader.Read()
                    cbSelectProducts.Items.Add(reader("ProdName").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' Programmatically add columns to DataGridView


    ' Add product to the bill
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtCustomerName.Text) Or String.IsNullOrEmpty(txtCustomerPhNO.Text) Then
            MessageBox.Show("Please enter customer details.")
            Return
        End If

        If String.IsNullOrEmpty(txtBillId.Text) OrElse Not Integer.TryParse(txtBillId.Text, Nothing) Then
            MessageBox.Show("Please enter a valid Bill ID.")
            Return
        End If

        If cbSelectProducts.SelectedIndex = -1 Then
            MessageBox.Show("Please select a product.")
            Return
        End If

        If String.IsNullOrEmpty(txtProductQuantity.Text) OrElse Not Integer.TryParse(txtProductQuantity.Text, Nothing) Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        Dim billId As Integer = Integer.Parse(txtBillId.Text)
        Dim prodName As String = cbSelectProducts.SelectedItem.ToString()
        Dim prodQty As Integer = Integer.Parse(txtProductQuantity.Text)
        Dim prodPrice As Decimal
        Dim stock As Integer

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Get price and stock
                Dim query As String = "SELECT ProdPrice, ProdQty FROM ProductsTbl WHERE ProdName = @ProdName"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProdName", prodName)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    prodPrice = Decimal.Parse(reader("ProdPrice").ToString())
                    stock = Integer.Parse(reader("ProdQty").ToString())
                Else
                    MessageBox.Show("Product not found.")
                    Return
                End If
            End Using

            ' Check stock availability
            If prodQty > stock Then
                MessageBox.Show("Insufficient stock.")
                Return
            End If

            ' Calculate total for the product
            Dim total As Decimal = prodQty * prodPrice
            totalAmount += total
            lblAmount.Text = "Rs " & totalAmount.ToString("F2")

            ' Add to DataGridView
            BillsDGV.Rows.Add(billId, txtCustomerName.Text, txtCustomerPhNO.Text, prodName, prodQty, prodPrice.ToString("F2"), total.ToString("F2"))
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub

    ' Delete selected row from the bill
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If BillsDGV.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = BillsDGV.SelectedRows(0)
            Dim rowTotal As Decimal = Decimal.Parse(row.Cells("TotalAmount").Value.ToString())
            totalAmount -= rowTotal
            lblAmount.Text = "Rs " & totalAmount.ToString("F2")
            BillsDGV.Rows.Remove(row)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    ' Finalize the bill and update stock
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If String.IsNullOrEmpty(txtBillId.Text) OrElse Not Integer.TryParse(txtBillId.Text, Nothing) Then
            MessageBox.Show("Please enter a valid Bill ID.")
            Return
        End If

        Dim billId As Integer = Integer.Parse(txtBillId.Text)

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                For Each row As DataGridViewRow In BillsDGV.Rows
                    If row.IsNewRow Then Continue For
                    Dim prodName As String = row.Cells("ProdName").Value.ToString()
                    Dim prodQty As Integer = Integer.Parse(row.Cells("ProdQty").Value.ToString())

                    ' Insert into SalesTbl
                    Dim query As String = "INSERT INTO SalesTbl (BillId, CustomerName, CustomerPhNO, ProductName, Quantity, Price, TotalAmount, SaleDate) 
                                       VALUES (@BillId, @CustomerName, @CustomerPhNO, @ProdName, @ProdQty, @ProdPrice, @TotalAmount, @SaleDate)"
                    Dim cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BillId", billId)
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                    cmd.Parameters.AddWithValue("@CustomerPhNO", txtCustomerPhNO.Text)
                    cmd.Parameters.AddWithValue("@ProdName", prodName)
                    cmd.Parameters.AddWithValue("@ProdQty", prodQty)
                    cmd.Parameters.AddWithValue("@ProdPrice", Decimal.Parse(row.Cells("ProdPrice").Value.ToString()))
                    cmd.Parameters.AddWithValue("@TotalAmount", Decimal.Parse(row.Cells("TotalAmount").Value.ToString()))
                    cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now)
                    cmd.ExecuteNonQuery()

                    ' Update stock in ProductsTbl
                    Dim updateQuery As String = "UPDATE ProductsTbl SET ProdQty = ProdQty - @ProdQty WHERE ProdName = @ProdName"
                    Dim updateCmd As New SqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@ProdQty", prodQty)
                    updateCmd.Parameters.AddWithValue("@ProdName", prodName)
                    updateCmd.ExecuteNonQuery()
                Next
                MessageBox.Show("Bill finalized successfully!")

                ' Removed clearing DataGridView and lblAmount reset:
                ' BillsDGV.Rows.Clear()
                ' lblAmount.Text = "Rs 0.00"

            End Using
        Catch ex As Exception
            MessageBox.Show("Error finalizing bill: " & ex.Message)
        End Try
    End Sub



    ' Print bill as PDF
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ' Define the directory path where the bill will be saved
            Dim directoryPath As String = "C:\Users\dasvi\OneDrive\Desktop\Bills\"

            ' Check if the directory exists, if not, create it
            If Not Directory.Exists(directoryPath) Then
                Directory.CreateDirectory(directoryPath)
            End If

            ' Define the file path where the bill will be saved as PDF
            Dim filePath As String = Path.Combine(directoryPath, "Bill_" & txtBillId.Text & ".pdf")

            ' Create a Document object to generate the PDF
            Using doc As New Document()
                ' Create a PdfWriter instance to write to the file
                PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))

                ' Open the document to write content
                doc.Open()

                ' Add bill header
                doc.Add(New Paragraph("VD Shopping Mall"))
                doc.Add(New Paragraph("------------------------------------------------------------"))
                doc.Add(New Paragraph("Date: " & lblDate.Text))
                doc.Add(New Paragraph("Bill ID: " & txtBillId.Text))
                doc.Add(New Paragraph("------------------------------------------------------------"))
                doc.Add(New Paragraph("Customer Name: " & txtCustomerName.Text))
                doc.Add(New Paragraph("Customer Phone: " & txtCustomerPhNO.Text))
                doc.Add(New Paragraph("------------------------------------------------------------"))

                ' Add product details header
                doc.Add(New Paragraph("Product Details:"))
                doc.Add(New Paragraph("------------------------------------------------------------"))

                ' Ensure data from DataGridView is correctly added
                For Each row As DataGridViewRow In BillsDGV.Rows
                    If Not row.IsNewRow Then
                        ' Use correct column names
                        doc.Add(New Paragraph(
                            $"{row.Cells("ProdName").Value} - Qty: {row.Cells("ProdQty").Value} - Price: Rs {row.Cells("ProdPrice").Value} - Total: Rs {row.Cells("TotalAmount").Value}"
                        ))
                    End If
                Next

                ' Add the total amount from the label
                doc.Add(New Paragraph("------------------------------------------------------------"))
                doc.Add(New Paragraph("Total Amount:  " & lblAmount.Text))
                doc.Add(New Paragraph("------------------------------------------------------------"))
                doc.Add(New Paragraph("Thank you for shopping with us!"))
                ' Close the document
                doc.Close()
            End Using

            ' Notify the user that the bill has been saved
            MessageBox.Show("Bill saved as PDF at: " & filePath)

        Catch ex As Exception
            ' Show any errors encountered during the PDF creation process
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Close button (X) to close the current form without exiting the application
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close() ' Closes only the current form
    End Sub

    ' Logout Button Click Event
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        ' Check if there are rows in the DataGridView
        If BillsDGV.Rows.Count = 0 Then
            MessageBox.Show("No items in the bill to preview.", "Bill Preview", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Start building the bill preview
        Dim billPreview As New System.Text.StringBuilder()
        billPreview.AppendLine("---------- VD Shopping Mall ----------")
        billPreview.AppendLine("Date: " & lblDate.Text)
        billPreview.AppendLine("Bill ID: " & txtBillId.Text)
        billPreview.AppendLine("Customer Name: " & txtCustomerName.Text)
        billPreview.AppendLine("Customer Phone: " & txtCustomerPhNO.Text)
        billPreview.AppendLine("--------------------------------------")
        billPreview.AppendLine(String.Format("{0,-20} {1,6} {2,8} {3,8}", "Product", "Qty", "Price", "Total"))
        billPreview.AppendLine("--------------------------------------")

        ' Loop through the DataGridView rows and add product details
        For Each row As DataGridViewRow In BillsDGV.Rows
            If Not row.IsNewRow Then
                Dim prodName As String = row.Cells("ProdName").Value.ToString()
                Dim prodQty As String = row.Cells("ProdQty").Value.ToString()
                Dim prodPrice As String = row.Cells("ProdPrice").Value.ToString()
                Dim totalAmount As String = row.Cells("TotalAmount").Value.ToString()
                billPreview.AppendLine(String.Format("{0,-20} {1,6} {2,8} {3,8}", prodName, prodQty, prodPrice, totalAmount))
            End If
        Next

        billPreview.AppendLine("--------------------------------------")
        billPreview.AppendLine("Total Amount:  " & lblAmount.Text)
        billPreview.AppendLine("--------------------------------------")
        billPreview.AppendLine("Thank you for shopping with us!")

        ' Display the bill preview in a message box
        MessageBox.Show(billPreview.ToString(), "Bill Preview", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
