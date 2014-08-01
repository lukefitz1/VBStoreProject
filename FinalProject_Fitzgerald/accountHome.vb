'Filename: accountHome.vb
'Programmer: Luke Fitzgerald
'Purpose: page displayed when customer logins to their profile, allows them to navigate their profile

Public Class accountHome

    Private Sub btInquiry_Click(sender As Object, e As EventArgs) Handles btInquiry.Click
        accountInquiry.Show()
        Me.Close()
    End Sub

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        welcomeScreen.Show()
        accountNum = 0
        Me.Close()
    End Sub

    Private Sub accountHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountLogin.Close()
    End Sub

    Private Sub btTransaction_Click(sender As Object, e As EventArgs) Handles btTransaction.Click
        buyProducts.Show()
        Me.Close()
    End Sub
End Class