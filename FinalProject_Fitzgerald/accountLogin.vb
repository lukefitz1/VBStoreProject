'Filename: accountLogin.vb
'Programmer: Luke Fitzgerald
'Purpose:  login screen for customers to log into their accounts

Imports System.Data.OleDb

Public Class accountLogin

    Dim pin As Integer
    Dim logCounter As Integer = 0

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        welcomeScreen.Show()
        Me.Close()
    End Sub

    Private Sub tbLogin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbLogin.Validating
        If tbLogin.Text = "" Then
            MessageBox.Show("Please enter your account ID number, 1", "Login Error", MessageBoxButtons.OK)
            tbLogin.Clear()
            e.Cancel = True
        ElseIf Not IsNumeric(tbLogin.Text) Then
            MessageBox.Show("Invalid ID Number, 2", "Login Error", MessageBoxButtons.OK)
            tbLogin.Clear()
            e.Cancel = True
        ElseIf tbLogin.Text.Length <> 6 Then
            MessageBox.Show("Invalid ID Number, 3", "Login Error", MessageBoxButtons.OK)
            tbLogin.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbLogin.Text) Then
            MessageBox.Show("Invalid ID Number, 4", "Login Error", MessageBoxButtons.OK)
            tbLogin.Clear()
            e.Cancel = True
        End If
    End Sub

    Private Sub tbPin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPin.Validating
        If tbPin.Text = "" Then
            MessageBox.Show("Please enter your pin number, 1", "Login error", MessageBoxButtons.OK)
            e.Cancel = True
        ElseIf Not IsNumeric(tbPin.Text) Then
            MessageBox.Show("Please enter your 4 digit pin number, 2", "Login Error", MessageBoxButtons.OK)
            tbPin.Clear()
            e.Cancel = True
        ElseIf tbPin.Text.Length <> 4 Then
            MessageBox.Show("Please enter your 4 digit pin number, 3", "Login Error", MessageBoxButtons.OK)
            tbPin.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbPin.Text) Then
            MessageBox.Show("Invalid Pin Number", "Login Error, 4", MessageBoxButtons.OK)
            tbPin.Clear()
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

    Private Sub btEnter_Click(sender As Object, e As EventArgs) Handles btEnter.Click
        'set variable values
        accountNum = tbLogin.Text
        pin = tbPin.Text

        'create connection
        Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

        'data connection
        Dim command As New OleDbCommand("SELECT IDNumber, pin FROM Customer Where IDNumber = ?", connection)

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
            If reader("Pin") = pin Then
                accountHome.Show()
            Else
                If logCounter <= 2 Then
                    MessageBox.Show("Invalid Username Or Password", "Login Failure", MessageBoxButtons.OK)
                    tbLogin.Clear()
                    tbPin.Clear()
                    logCounter += 1
                End If
                If logCounter = 3 Then
                    MessageBox.Show("Too many failed attempts....Goodbye", "Login Failure", MessageBoxButtons.OK)
                    welcomeScreen.Show()
                    Me.Close()
                End If
            End If
        Else
            If logCounter <= 2 Then
                MessageBox.Show("Invalid UserName or Password", "Login Failed", MessageBoxButtons.OK)
                tbLogin.Clear()
                tbPin.Clear()
                logCounter += 1
            ElseIf logCounter = 3 Then
                MessageBox.Show("Too many failed attempts....Goodbye", "Failure", MessageBoxButtons.OK)
                welcomeScreen.Show()
                Me.Close()
            End If
        End If

        connection.Close()
        loadRetailTypeAndStatus()
    End Sub

    Private Sub loadRetailTypeAndStatus()
        'create connection
        Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

        'data connection
        Dim command As New OleDbCommand("SELECT Balance, AccountType, AccountStatus FROM Customer Where IDNumber = ?", connection)

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
            acctBalance = reader("Balance")
            accountType = reader("AccountType")
            accountStatus = reader("AccountStatus")
        End If
        connection.Close()
    End Sub

    Private Sub accountLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class