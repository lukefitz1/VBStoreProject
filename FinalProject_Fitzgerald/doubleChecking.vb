'Filename: doubleChecking.vb
'Programmer: Luke Fitzgerald
'Purpose: verifies with customer that they want to close the program

Public Class doubleChecking

    Private Sub btHomeScreen_Click(sender As Object, e As EventArgs) Handles btHomeScreen.Click
        welcomeScreen.Show()
        Me.Close()
    End Sub

    Private Sub btQuit_Click(sender As Object, e As EventArgs) Handles btQuit.Click
        Me.Close()
        welcomeScreen.Close()
    End Sub

    Private Sub doubleChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class