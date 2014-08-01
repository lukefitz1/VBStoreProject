'Filename: byProducts.vb
'Programmer: Luke Fitzgerald
'Purpose: displays all products offered, allows customer to add them to shopping cart

Imports System.Data.OleDb

Public Class buyProducts
    Dim index As Integer
    Dim quantity As Integer

    Private Sub buyProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create connection
        Dim connection As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = FinalProject_DB_Fitzgerald.accdb")

        'data connection
        Dim command As New OleDbCommand("SELECT * FROM Product", connection)

        'execute
        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Try
            reader.Read()
        Catch except As OleDbException
            MessageBox.Show("read error")
        End Try


        Do While reader.Read
            lbProductNum.Items.Add(reader("ProductNumber"))
            lbProduct.Items.Add(reader("Product"))
            lbPrice.Items.Add(reader("Price"))
            lbInStock.Items.Add(reader("InStock"))
            lbCategory.Items.Add(reader("Category"))
        Loop

        connection.Close()

        tbQuantity.Text = 0
    End Sub

    Private Sub lbProductNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProductNum.SelectedIndexChanged
        index = lbProductNum.SelectedIndex

        lbProduct.SelectedIndex = index
        lbPrice.SelectedIndex = index
        lbInStock.SelectedIndex = index
        lbCategory.SelectedIndex = index
    End Sub

    Private Sub lbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCategory.SelectedIndexChanged
        index = lbCategory.SelectedIndex

        lbProductNum.SelectedIndex = index
        lbProduct.SelectedIndex = index
        lbPrice.SelectedIndex = index
        lbInStock.SelectedIndex = index
    End Sub

    Private Sub lbInStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbInStock.SelectedIndexChanged
        index = lbInStock.SelectedIndex

        lbProductNum.SelectedIndex = index
        lbProduct.SelectedIndex = index
        lbPrice.SelectedIndex = index
        lbCategory.SelectedIndex = index
    End Sub

    Private Sub lbPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPrice.SelectedIndexChanged
        index = lbPrice.SelectedIndex

        lbProductNum.SelectedIndex = index
        lbProduct.SelectedIndex = index
        lbInStock.SelectedIndex = index
        lbCategory.SelectedIndex = index
    End Sub

    Private Sub lbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProduct.SelectedIndexChanged
        index = lbProduct.SelectedIndex

        lbProductNum.SelectedIndex = index
        lbPrice.SelectedIndex = index
        lbInStock.SelectedIndex = index
        lbCategory.SelectedIndex = index
    End Sub

    Private Sub tbQuantity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbQuantity.Validating
        If tbQuantity.Text = "" Then
            MessageBox.Show("Please enter a quantity to purchase1", "Data Entry Error", MessageBoxButtons.OK)
            tbQuantity.Clear()
            e.Cancel = True
        ElseIf Not IsNumeric(tbQuantity.Text) Then
            MessageBox.Show("Please enter a quantity to purchase2", "Data Entry Error", MessageBoxButtons.OK)
            tbQuantity.Clear()
            e.Cancel = True
        ElseIf CheckForAlphaCharacters(tbQuantity.Text) Then
            MessageBox.Show("Please enter a quantity to purchase3", "Data Entry Error", MessageBoxButtons.OK)
            tbQuantity.Clear()
            e.Cancel = True
        ElseIf tbQuantity.Text < 1 Then
            MessageBox.Show("Please enter a quantity to purchase4", "Data Entry Error", MessageBoxButtons.OK)
            tbQuantity.Clear()
            e.Cancel = True
        ElseIf tbQuantity.Text > lbInStock.SelectedItem Then
            MessageBox.Show("We do not have that many in stock, please choose a lower quantity", "Data Entry Error", MessageBoxButtons.OK)
            tbQuantity.Clear()
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

    Private Sub tbAddToCart_Click(sender As Object, e As EventArgs) Handles btAddToCart.Click
        'If tbQuantity.Text = "" Then
        '    MessageBox.Show("Please enter a quantity to purchase1", "Data Entry Error", MessageBoxButtons.OK)
        '    tbQuantity.Clear()
        '    tbQuantity.Focus()
        'ElseIf Not IsNumeric(tbQuantity.Text) Then
        '    MessageBox.Show("Please enter a quantity to purchase2", "Data Entry Error", MessageBoxButtons.OK)
        '    tbQuantity.Clear()
        '    tbQuantity.Focus()
        'ElseIf CheckForAlphaCharacters(tbQuantity.Text) Then
        '    MessageBox.Show("Please enter a quantity to purchase3", "Data Entry Error", MessageBoxButtons.OK)
        '    tbQuantity.Clear()
        '    tbQuantity.Focus()
        'ElseIf tbQuantity.Text < 1 Then
        '    MessageBox.Show("Please enter a quantity to purchase4", "Data Entry Error", MessageBoxButtons.OK)
        '    tbQuantity.Clear()
        '    tbQuantity.Focus()
        'End If

        If tbQuantity.Text < 1 Then
            MessageBox.Show("Please enter a quantity to purchase", "Data Entry Error", MessageBoxButtons.OK)
            tbQuantity.Focus()
        Else
            quantity = tbQuantity.Text
            Dim productNum As String = lbProductNum.SelectedItem
            Dim product As String = lbProduct.SelectedItem
            Dim price As Double = lbPrice.SelectedItem

            total += price * quantity

            cart.Add(CStr(productNum))
            cart.Add(product)
            cart.Add(price)
            cart.Add(CStr(quantity))

            tbQuantity.Text = 0
        End If
    End Sub

    Private Sub btAccountHome_Click(sender As Object, e As EventArgs) Handles btAccountHome.Click
        accountHome.Show()
        Me.Close()
    End Sub

    Private Sub btViewCart_Click(sender As Object, e As EventArgs) Handles btViewCart.Click
        shoppingCart.Show()
        Me.Close()
    End Sub

    Private Sub btComplete_Click(sender As Object, e As EventArgs) Handles btComplete.Click
        shoppingCart.Show()
        Me.Close()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        cart.Clear()
        accountHome.Show()
        Me.Close()
    End Sub
End Class