'Filename: welcomeScreen.vb
'Programmer: Luke Fitzgerald
'Purpose: Opening screen for the program. Customers choose to login or look for more info about the company

Public Class welcomeScreen

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub btGeneralStoreInfo_Click(sender As Object, e As EventArgs) Handles btGeneralStoreInfo.Click
        generalStoreInfo.Show()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        accountLogin.Show()
    End Sub

End Class
