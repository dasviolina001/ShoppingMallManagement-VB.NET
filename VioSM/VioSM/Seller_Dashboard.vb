Public Class Seller_Dashboard
    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        ' Navigate to Category Form when btnCategories is clicked
        Dim categoryForm As New Category_Form()
        categoryForm.Show()
    End Sub
    ' Navigate to Product Form when btnProducts is clicked
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim productForm As New Product_Form() ' Assuming Product_Form exists
        productForm.Show()
    End Sub
    ' Navigate to Sales Form when btnSelling is clicked
    Private Sub btnSelling_Click(sender As Object, e As EventArgs) Handles btnSelling.Click
        ' Navigate to Sales form
        Dim salesForm As New Sales()
        salesForm.Show()
    End Sub

    ' Logout Button Click Event
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
    ' Close button (X) to exit the form
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Seller_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class