Imports System.Data.OleDb

Public Class shoppingCart
    Dim index As Integer
    Dim indexRemoved As Integer = 0
    Dim numPurchased As Integer
    Private Sub btAccountHome_Click(sender As Object, e As EventArgs) Handles btAccountHome.Click
        accountHome.Show()
        Me.Close()
    End Sub

    Private Sub btPurchase_Click(sender As Object, e As EventArgs) Handles btPurchase.Click
        buyProducts.Show()
        Me.Close()
    End Sub

    Private Sub shoppingCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim price As Double
        Dim numPurchased As Integer

        For i As Integer = 0 To cart.Count - 1
            lbProductNum.Items.Add(cart(i))
            i += 1
            lbProduct.Items.Add(cart(i))
            i += 1
            lbPrice.Items.Add(cart(i))
            price = CDbl(cart(i))
            i += 1
            lbQuantity.Items.Add(cart(i))
            numPurchased = CInt(cart(i))
        Next

        tbTotal.Text = total
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        cart.Clear()
        total = 0
        accountHome.Show()
        Me.Close()
    End Sub

    Private Sub lbQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbQuantity.SelectedIndexChanged
        index = lbQuantity.SelectedIndex

        lbPrice.SelectedIndex = index
        lbProduct.SelectedIndex = index
        lbProductNum.SelectedIndex = index
    End Sub

    Private Sub lbPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPrice.SelectedIndexChanged
        index = lbPrice.SelectedIndex

        lbProduct.SelectedIndex = index
        lbProductNum.SelectedIndex = index
        lbQuantity.SelectedIndex = index
    End Sub

    Private Sub lbProductNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProductNum.SelectedIndexChanged
        index = lbProductNum.SelectedIndex

        lbPrice.SelectedIndex = index
        lbProduct.SelectedIndex = index
        lbQuantity.SelectedIndex = index
    End Sub

    Private Sub lbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProduct.SelectedIndexChanged
        index = lbProduct.SelectedIndex

        lbPrice.SelectedIndex = index
        lbProductNum.SelectedIndex = index
        lbQuantity.SelectedIndex = index
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        indexRemoved = lbProductNum.SelectedIndex

        cart.RemoveAt(indexRemoved)
        cart.RemoveAt(indexRemoved)
        cart.RemoveAt(indexRemoved)
        cart.RemoveAt(indexRemoved)

        lbProductNum.Items.Clear()
        lbProduct.Items.Clear()
        lbPrice.Items.Clear()
        lbQuantity.Items.Clear()
        total = 0
        tbTotal.Text = 0


        Dim price As Double

        For i As Integer = 0 To cart.Count - 1
            lbProductNum.Items.Add(cart(i))
            i += 1
            lbProduct.Items.Add(cart(i))
            i += 1
            lbPrice.Items.Add(cart(i))
            price = CDbl(cart(i))
            i += 1
            lbQuantity.Items.Add(cart(i))
            numPurchased = CInt(cart(i))
            total += numPurchased * price
        Next

        tbTotal.Text = total
    End Sub

    Private Sub btComplete_Click(sender As Object, e As EventArgs) Handles btComplete.Click
        'copy contents from shopping cart to transaction cart
        transaction.Clear()
        For i As Integer = 0 To cart.Count - 1
            transaction.Add(cart(i))
        Next
        completeTransaction.Show()
        Me.Close()
    End Sub
End Class