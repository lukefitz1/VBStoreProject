'Filename: accountTypes.vb
'Programmer: Luke Fitzgerald
'Purpose: Explains the different account types offered by the company

Public Class accountTypes

    Private Sub accountTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbAccountType.Text = "Please choose an account type from the drop down menu to view the features of each account. " +
                        "You may only have one account type."
    End Sub

    Private Sub cbAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccountType.SelectedIndexChanged
        If cbAccountType.SelectedIndex = 1 Then
            tbAccountType.Text = "Our Business Accounts " +
                                    "offer discounts on all purchases. The amount discounted depends on how much the customer has spent before, and it can be up to " +
                                    "5%."
        ElseIf cbAccountType.SelectedIndex = 0 Then
            tbAccountType.Text = "Our Retail Account offers 5% discounts on purchases of $500 or more. "
        End If
    End Sub

    Private Sub btGeneralInfo_Click(sender As Object, e As EventArgs) Handles btGeneralInfo.Click
        generalStoreInfo.Show()
        Me.Close()
    End Sub

End Class