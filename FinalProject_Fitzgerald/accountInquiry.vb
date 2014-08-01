'Filename: accountInquiry.vb
'Programmer: Luke Fitzgerald
'Purpose: Allows customer to view their profile information

Imports System.Data.OleDb

Public Class accountInquiry

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        welcomeScreen.Show()
        Me.Close()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        accountHome.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btChangeInfo.Click
        changeAccountInfo.Show()
        Me.Close()
    End Sub

    Private Sub accountInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbAccountID.Text = accountNum

        'create connection
        Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

        'data connection
        Dim command As New OleDbCommand("SELECT * FROM Customer Where IDNumber = ?", connection)

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
            tbAddress.Text = reader("StreetNumber") & " " & reader("Street")
            tbCityState.Text = reader("City") & ", " & reader("State")
            tbZip.Text = reader("Zip")
            tbPhone.Text = reader("Phone")
            tbBalance.Text = FormatCurrency(reader("Balance"))
        End If

        connection.Close()

    End Sub

End Class