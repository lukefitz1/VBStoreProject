'Filename: productInfo.vb
'Programmer: Luke Fitzgerald
'Purpose: Displays products

Public Class productInfo

    Private Sub btGeneralInfo_Click(sender As Object, e As EventArgs) Handles btGeneralInfo.Click
        generalStoreInfo.Show()
        Me.Close()
    End Sub

End Class