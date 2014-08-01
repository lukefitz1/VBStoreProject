'Filename: storeProfile.vb
'Programmer: Luke Fitzgerald
'Purpose: Gives customer information about the company

Public Class storeProfile

    Private Sub btGeneralInfo_Click(sender As Object, e As EventArgs) Handles btGeneralInfo.Click
        generalStoreInfo.Show()
        Me.Close()
    End Sub

    Private Sub storeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbProfile.Text = "Welcome! We are your one-stop shop for all your computer needs! Feel free to browse around " +
                            "this site, take a look at our products and services, and let us know any suggestions, " +
                            "concerns, or questions that you have for us!"
    End Sub
End Class