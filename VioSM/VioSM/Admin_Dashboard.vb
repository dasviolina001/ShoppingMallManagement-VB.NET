Public Class Admin_Dashboard
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        ' Your existing code for btnLogo
    End Sub

    ' Navigate to Category Form when btnCategories is clicked
    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click

        ' Navigate to Category_Form
        Dim categoryForm As New Category_Form()
        categoryForm.Show()
    End Sub

    ' Navigate to Product Form when btnProducts is clicked
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ' Navigate to Product_Form
        Dim productForm As New Product_Form()
        productForm.Show()
    End Sub

    ' Navigation to Sellers section
    Private Sub btnSellers_Click(sender As Object, e As EventArgs) Handles btnSellers.Click
        ' Navigate to Seller_Form
        Dim sellerForm As New Seller_Form()
        sellerForm.Show()
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

    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any code you need to run when the Admin_Dashboard form is loaded
    End Sub
End Class
