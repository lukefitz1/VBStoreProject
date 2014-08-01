'Filename: completeTransaction.vb
'Programmer: Luke Fitzgerald
'Purpose: finalizes purchase, updates db

Imports System.Data.OleDb

Public Class completeTransaction

    Private Sub completeTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbBalance.Text = FormatCurrency(acctBalance)
        Dim price As Double
        Dim numPurchased As Integer

        For i As Integer = 0 To transaction.Count - 1
            lbProductNum.Items.Add(transaction(i))
            i += 1
            lbProduct.Items.Add(transaction(i))
            i += 1
            lbPrice.Items.Add(transaction(i))
            price = CDbl(transaction(i))
            i += 1
            lbQuantity.Items.Add(transaction(i))
            numPurchased = CInt(transaction(i))
        Next

        If accountType = "Retail" Then
            If total > 500 Then
                total = total - (total * 0.05)
                tbTotal.Text = FormatCurrency(total)
            End If
        ElseIf accountType = "Business" Then
            Select Case accountStatus
                Case 1
                    total = total - (total * 0.01)
                    tbTotal.Text = FormatCurrency(total)
                Case 2
                    total = total - (total * 0.02)
                    tbTotal.Text = FormatCurrency(total)
                Case 3
                    total = total - (total * 0.03)
                    tbTotal.Text = FormatCurrency(total)
                Case 4
                    total = total - (total * 0.04)
                    tbTotal.Text = FormatCurrency(total)
                Case 5
                    total = total - (total * 0.05)
                    tbTotal.Text = FormatCurrency(total)
            End Select
        End If

    End Sub

    Private Sub btComplete_Click(sender As Object, e As EventArgs) Handles btComplete.Click
        If acctBalance < total Then
            MessageBox.Show("There is not enough money in your account for this purchase", "You need more money", MessageBoxButtons.OK)
        Else
            Dim inStock As Integer
            Dim prodNum As Integer
            Dim prod As String
            Dim price As Double
            Dim number As Integer

            'create connection
            Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

            'update db
            For i As Integer = 0 To transaction.Count - 1
                prodNum = transaction(i)
                i += 1
                prod = transaction(i)
                i += 1
                price = transaction(i)
                i += 1
                number = transaction(i)

                Dim commandInStock As New OleDbCommand("SELECT InStock FROM Product WHERE ProductNumber = ?", connection)
                Dim paramInStock As New OleDbParameter()

                'assign value to parameter
                paramInStock.Value = prodNum
                'add parameter
                commandInStock.Parameters.Add(paramInStock)

                'open connection
                connection.Open()
                'execute
                Dim reader As OleDbDataReader = commandInStock.ExecuteReader()

                Try
                    reader.Read()
                Catch except As OleDbException
                    MessageBox.Show("read error")
                End Try

                If reader.HasRows Then
                    inStock = reader("InStock")

                    Dim commandUpdate As New OleDbCommand("UPDATE Product SET InStock = ? WHERE ProductNumber = ?", connection)
                    Dim paramQuantityUpdate As New OleDbParameter()
                    Dim paramProdNum As New OleDbParameter()

                    'assign Value
                    paramQuantityUpdate.Value = inStock - number
                    paramProdNum.Value = prodNum
                    'add parameter
                    commandUpdate.Parameters.Add(paramQuantityUpdate)
                    commandUpdate.Parameters.Add(paramProdNum)

                    Try
                        'execute command
                        Dim count As Integer = commandUpdate.ExecuteNonQuery()
                    Catch ex As OleDbException
                        MessageBox.Show("write error " & ex.Message, ex.GetType.ToString)
                    End Try

                End If
                connection.Close()
            Next

            acctBalance = acctBalance - total
            MessageBox.Show("Thank you for your purchase!", "Thanks!", MessageBoxButtons.OK)
            accountHome.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btShoppingCart_Click(sender As Object, e As EventArgs) Handles btShoppingCart.Click
        shoppingCart.Show()
        Me.Close()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        accountHome.Show()
        Me.Close()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        cart.Clear()
        transaction.Clear()
        total = 0
        accountHome.Show()
        Me.Close()
    End Sub
End Class