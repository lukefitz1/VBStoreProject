'Filename: changeAccountInfo.vb
'Programmer: Luke Fitzgerald
'Purpose: allows customers to edit their personal information in their profile

Imports System.Data.OleDb

Public Class changeAccountInfo

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        welcomeScreen.Show()
        Me.Close()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        accountHome.Show()
        Me.Close()
    End Sub

    Private Sub changeAccountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbAccountID.Text = accountNum

        'create connection
        Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

        'data connection
        Dim command As New OleDbCommand("SELECT * FROM Customer WHERE IDNumber = ?", connection)

        'define a parameter
        Dim param As New OleDbParameter()
        param.Value = accountNum

        'add parameter to command
        command.Parameters.Add(param)

        'open connection, execute command
        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Try
            reader.Read()
        Catch except As OleDbException
            MessageBox.Show("read error")
        End Try

        If reader.HasRows Then
            tbFirstName.Text = reader("FirstName")
            tbLastName.Text = reader("LastName")
            tbStreetNum.Text = reader("StreetNumber")
            tbStreet.Text = reader("Street")
            tbCity.Text = reader("City")
            tbState.Text = reader("State")
            tbZip.Text = reader("Zip")
            tbPhone.Text = reader("Phone")
        End If

    End Sub

    Private Sub tbStreetNum_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbStreetNum.Validating
        If tbStreetNum.Text = "" Then
            MessageBox.Show("Please enter a street number", "Data Entry Error", MessageBoxButtons.OK)
            tbStreetNum.Clear()
            e.Cancel = True
        ElseIf Not IsNumeric(tbStreetNum.Text) Then
            MessageBox.Show("Please enter a valid street number", "Data Entry Error", MessageBoxButtons.OK)
            tbStreetNum.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbStreetNum.Text) Then
            MessageBox.Show("Please enter a valid street number", "Data Entry Error", MessageBoxButtons.OK)
            tbStreetNum.Clear()
            e.Cancel = True
        End If
    End Sub

    Private Sub tbStreet_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbStreet.Validating
        If IsNumeric(tbStreet.Text) Then
            MessageBox.Show("Please enter a valid street", "Data Entry Error", MessageBoxButtons.OK)
            tbStreet.Clear()
            e.Cancel = True
        ElseIf tbStreet.Text = "" Then
            MessageBox.Show("Please enter a valid street", "Data Entry Error", MessageBoxButtons.OK)
            tbStreet.Clear()
            e.Cancel = True
        ElseIf CheckForNumbers(tbStreet.Text) Then
            MessageBox.Show("Please enter a valid street", "Data Entry Error", MessageBoxButtons.OK)
            tbStreet.Clear()
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

    Private Sub tbState_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbState.Validating
        Select Case tbState.Text.ToUpper
            Case "MA"
            Case "ME"
            Case "NH"
            Case "VT"
            Case "RI"
            Case "CT"
            Case Else
                MessageBox.Show("Invalid State, must be MA, ME, NH, VT, RI or CT", "Invalid State", MessageBoxButtons.OK)
                tbState.Clear()
                e.Cancel = True
        End Select
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
            MessageBox.Show("Please enter a valid 10 digit phone number", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
        ElseIf tbPhone.Text.Length <> 10 Then
            MessageBox.Show("Phone must be 10 digits", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbPhone.Text) Then
            MessageBox.Show("Please enter a valid phone number", "Data Entry Error", MessageBoxButtons.OK)
            tbPhone.Clear()
            e.Cancel = True
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

    Private Sub btDone_Click(sender As Object, e As EventArgs) Handles btDone.Click
        'create connection
        Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

        'data connection
        Dim insertCommand As New OleDbCommand("UPDATE Customer SET StreetNumber = ?, Street = ?, City = ?, State = ?, Zip = ?, Phone =? WHERE IDNumber = ?", connection)

        'define parameters
        Dim streetNum As New OleDbParameter()
        Dim street As New OleDbParameter()
        Dim city As New OleDbParameter()
        Dim state As New OleDbParameter()
        Dim zip As New OleDbParameter()
        Dim phone As New OleDbParameter()
        Dim IDNum As New OleDbParameter()

        streetNum.Value = tbStreetNum.Text
        street.Value = tbStreet.Text
        city.Value = tbCity.Text
        state.Value = tbState.Text
        zip.Value = tbZip.Text
        phone.Value = tbPhone.Text
        IDNum.Value = accountNum

        'add parameters to command
        insertCommand.Parameters.Add(streetNum)
        insertCommand.Parameters.Add(street)
        insertCommand.Parameters.Add(city)
        insertCommand.Parameters.Add(state)
        insertCommand.Parameters.Add(zip)
        insertCommand.Parameters.Add(phone)
        insertCommand.Parameters.Add(IDNum)

        Try
            'open connection, execute command
            connection.Open()
            Dim count As Integer = insertCommand.ExecuteNonQuery()
            MessageBox.Show("Update Complete")
            Me.Close()
            accountHome.Show()
        Catch ex As OleDbException
            MessageBox.Show("write error " & ex.Message, ex.GetType.ToString)
        End Try

        'close connection
        connection.Close()

    End Sub
End Class