Public Class Form1
    ' This event is triggered when the form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the progress bar and timer settings
        ProgressBar1.Value = 0
        ProgressBar1.ForeColor = Color.Purple
        Timer1.Interval = 50 ' Adjust interval for progress speed
        Timer1.Start() ' Start the timer
    End Sub

    ' This event is triggered with each tick of the timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar
        ProgressBar1.Increment(1) ' Adjust increment value if needed

        ' Check if the progress bar is full
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop() ' Stop the timer
            Me.Hide() ' Hide the splash screen

            ' Show the login form (replace 'LoginForm' with the actual name of your login form)
            Dim loginForm As New login()
            loginForm.Show()
        End If
    End Sub

    ' Handle custom close button click event
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close() ' Close the current form
    End Sub

End Class
