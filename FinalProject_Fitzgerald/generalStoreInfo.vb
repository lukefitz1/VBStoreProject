'Filename: generalStoreInfo.vb
'Programmer: Luke Fitzgerald
'Purpose: Navigation screen for customers to learn about the company

Public Class generalStoreInfo

    Private Sub btProductInfo_Click(sender As Object, e As EventArgs) Handles btProductInfo.Click
        productInfo.Show()
        Me.Close()
    End Sub
    Private Sub btRequest_Click(sender As Object, e As EventArgs) Handles btRequest.Click
        moreInfoRequest.Show()
        Me.Close()
    End Sub
    Private Sub btAccounts_Click(sender As Object, e As EventArgs) Handles btAccounts.Click
        accountTypes.Show()
        Me.Close()
    End Sub
    Private Sub btProfile_Click(sender As Object, e As EventArgs) Handles btProfile.Click
        storeProfile.Show()
        Me.Close()
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        doubleChecking.Show()
        Me.Close()
    End Sub

End Class