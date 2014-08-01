'Filename: moreInfoRequest.vb
'Programmer: Luke Fitzgerald
'Purpose: Offers customers the option to request more information from the company

Imports System.Xml

Public Class moreInfoRequest

    Dim personName As String
    Dim city As String
    Dim state As String
    Dim zipCode As String
    Dim phone As String
    Dim request As String
    Dim accountType As String

    Private Const OutputPath As String = "POSSCUST.xml"


    Private Sub tbName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbName.Validating
        If IsNumeric(tbName.Text) Then
            MessageBox.Show("Please enter a valid name", "Data Entry Error", MessageBoxButtons.OK)
            tbName.Clear()
            e.Cancel = True
        ElseIf tbName.Text = "" Then
            MessageBox.Show("Please enter a valid name", "Data Entry Error", MessageBoxButtons.OK)
            tbName.Clear()
            e.Cancel = True
        ElseIf CheckForNumbers(tbName.Text) Then
            MessageBox.Show("Please enter a valid name", "Data Entry Error", MessageBoxButtons.OK)
            tbName.Clear()
            e.Cancel = True
        End If
    End Sub

    Private Sub tbCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCity.Validating
        If IsNumeric(tbCity.Text) Then
            MessageBox.Show("Please enter a valid city", "Data Entry Error", MessageBoxButtons.OK)
            tbCity.Clear()
            e.Cancel = True
        ElseIf tbCity.Text = "" Then
            MessageBox.Show("Please enter a valid city", "Data Entry Error", MessageBoxButtons.OK)
            tbCity.Clear()
            e.Cancel = True
        ElseIf CheckForNumbers(tbCity.Text) Then
            MessageBox.Show("Please enter a valid city", "Data Entry Error", MessageBoxButtons.OK)
            tbCity.Clear()
            e.Cancel = True
        End If
    End Sub

    Private Sub tbZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbZip.Validating
        If tbZip.Text = "" Then
            MessageBox.Show("Please enter a zip code", "Data Entry Error", MessageBoxButtons.OK)
            tbZip.Clear()
            e.Cancel = True
        ElseIf Not IsNumeric(tbZip.Text) Then
            MessageBox.Show("Please enter a valid 5 digit zip code", "Data Entry Error", MessageBoxButtons.OK)
            tbZip.Clear()
            e.Cancel = True
        ElseIf tbZip.Text.Length <> 5 Then
            MessageBox.Show("Zip Code must be 5 digits", "Data Entry Error", MessageBoxButtons.OK)
            tbZip.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbZip.Text) Then
            MessageBox.Show("Please enter a valid zip code", "Data Entry Error", MessageBoxButtons.OK)
            tbZip.Clear()
            e.Cancel = True
        End If
    End Sub

    Private Sub tbPhone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPhone.Validating
        If tbPhone.Text = "" Then
            MessageBox.Show("Please enter a phone number", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
        ElseIf Not IsNumeric(tbPhone.Text) Then
            MessageBox.Show("Please enter a valid phone number", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
        ElseIf tbPhone.Text.Length <> 10 Then
            MessageBox.Show("Phone Number must be 10 digits", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbPhone.Text) Then
            MessageBox.Show("Please enter a valid phone number", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
        End If
    End Sub

    Private Sub tbRequest_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbRequest.Validating
        If tbRequest.Text.Length > 250 Then
            MessageBox.Show("Message must be 250 characters or less", "Message Too Long", MessageBoxButtons.OK)
            tbRequest.Clear()
            tbRequest.Focus()
        End If
    End Sub

    'function to check and see if there are any non-numeric numbers in a string
    Public Function CheckForAlphaCharacters(ByVal StringToCheck As String)

        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False

    End Function

    'function to check and see if there are any numbers in a string
    Public Function CheckForNumbers(ByVal StringtoCheck As String)
        For i = 0 To StringtoCheck.Length - 1
            If Char.IsNumber(StringtoCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbName.Text = "" Then
            MessageBox.Show("You must enter a Name", "Enter a name", MessageBoxButtons.OK)
            tbName.Focus()
        Else
            personName = tbName.Text
        End If
        If tbCity.Text = "" Then
            MessageBox.Show("You must enter a city", "Enter a city", MessageBoxButtons.OK)
            tbCity.Focus()
        Else
            city = tbCity.Text
        End If
        If tbZip.Text = "" Then
            MessageBox.Show("You must enter a zipcode", "ENter a zipcode", MessageBoxButtons.OK)
            tbZip.Focus()
        Else
            zipCode = tbZip.Text
        End If

        Select Case cbState.SelectedIndex
            Case 0
                state = "Massachusetts"
            Case 1
                state = "Maine"
            Case 2
                state = "New Hampshire"
            Case 3
                state = "Vermont"
            Case 4
                state = "Rhode Island"
            Case 5
                state = "Connecticut"
        End Select

        If tbPhone.Text = "" Then
            MessageBox.Show("You must enter a phone number", "ENter a phone number", MessageBoxButtons.OK)
            tbPhone.Focus()
        Else
            phone = tbPhone.Text
        End If

        If cbAccountType.SelectedIndex = 0 Then
            accountType = "Retail Account"
        ElseIf cbAccountType.SelectedIndex = 1 Then
            accountType = "Business Account"
        End If

        If tbRequest.Text = "" Then
            MessageBox.Show("Must enter a request", "request error", MessageBoxButtons.OK)
            tbRequest.Focus()
        End If
        'create xmlwritersetrtings object
        Dim settings As New XmlWriterSettings
        settings.Indent = True
        settings.IndentChars = ("   ")

        'create xmlwriter object
        Dim xmlOut As XmlWriter = XmlWriter.Create(OutputPath, settings)

        'document start
        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("Requests")

        'write form data to file
        xmlOut.WriteStartElement("Information_Request")
        xmlOut.WriteElementString("Name", personName)
        xmlOut.WriteElementString("City", city)
        xmlOut.WriteElementString("State", state)
        xmlOut.WriteElementString("Zip_Code", zipCode)
        xmlOut.WriteElementString("Phone", phone)
        xmlOut.WriteElementString("Account_Type", accountType)
        xmlOut.WriteEndElement()

        'End Element
        xmlOut.WriteEndElement()
        xmlOut.Close()

        closeForm()
    End Sub

    Private Sub closeForm()
        MessageBox.Show("Thank you for your Request", "Thank You", MessageBoxButtons.OK)
        generalStoreInfo.Show()
        Me.Close()
    End Sub

    Private Sub btGeneralInfo_Click(sender As Object, e As EventArgs) Handles btGeneralInfo.Click
        generalStoreInfo.Show()
        Me.Close()
    End Sub

End Class