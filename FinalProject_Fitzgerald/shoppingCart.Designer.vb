<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shoppingCart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbProduct = New System.Windows.Forms.ListBox()
        Me.lbPrice = New System.Windows.Forms.ListBox()
        Me.lbQuantity = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btPurchase = New System.Windows.Forms.Button()
        Me.btAccountHome = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btComplete = New System.Windows.Forms.Button()
        Me.btRemove = New System.Windows.Forms.Button()
        Me.lbProductNum = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(547, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shopping Cart"
        '
        'lbProduct
        '
        Me.lbProduct.FormattingEnabled = True
        Me.lbProduct.Location = New System.Drawing.Point(541, 315)
        Me.lbProduct.Name = "lbProduct"
        Me.lbProduct.Size = New System.Drawing.Size(120, 264)
        Me.lbProduct.TabIndex = 2
        '
        'lbPrice
        '
        Me.lbPrice.FormattingEnabled = True
        Me.lbPrice.Location = New System.Drawing.Point(712, 315)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(120, 264)
        Me.lbPrice.TabIndex = 3
        '
        'lbQuantity
        '
        Me.lbQuantity.FormattingEnabled = True
        Me.lbQuantity.Location = New System.Drawing.Point(883, 315)
        Me.lbQuantity.Name = "lbQuantity"
        Me.lbQuantity.Size = New System.Drawing.Size(120, 264)
        Me.lbQuantity.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(559, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(743, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(896, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 601)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total: "
        '
        'tbTotal
        '
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(649, 606)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(161, 26)
        Me.tbTotal.TabIndex = 9
        '
        'btPurchase
        '
        Me.btPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPurchase.Location = New System.Drawing.Point(467, 650)
        Me.btPurchase.Name = "btPurchase"
        Me.btPurchase.Size = New System.Drawing.Size(205, 43)
        Me.btPurchase.TabIndex = 10
        Me.btPurchase.Text = "Purchase More"
        Me.btPurchase.UseVisualStyleBackColor = True
        '
        'btAccountHome
        '
        Me.btAccountHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAccountHome.Location = New System.Drawing.Point(256, 650)
        Me.btAccountHome.Name = "btAccountHome"
        Me.btAccountHome.Size = New System.Drawing.Size(205, 43)
        Me.btAccountHome.TabIndex = 11
        Me.btAccountHome.Text = "Account Home"
        Me.btAccountHome.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClear.Location = New System.Drawing.Point(889, 650)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(205, 43)
        Me.btClear.TabIndex = 12
        Me.btClear.Text = "Clear Cart"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btComplete
        '
        Me.btComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComplete.Location = New System.Drawing.Point(678, 650)
        Me.btComplete.Name = "btComplete"
        Me.btComplete.Size = New System.Drawing.Size(205, 43)
        Me.btComplete.TabIndex = 13
        Me.btComplete.Text = "Complete Order"
        Me.btComplete.UseVisualStyleBackColor = True
        '
        'btRemove
        '
        Me.btRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRemove.Location = New System.Drawing.Point(458, 708)
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Size = New System.Drawing.Size(447, 43)
        Me.btRemove.TabIndex = 14
        Me.btRemove.Text = "Remove Items (Select Item First)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btRemove.UseVisualStyleBackColor = True
        '
        'lbProductNum
        '
        Me.lbProductNum.FormattingEnabled = True
        Me.lbProductNum.Location = New System.Drawing.Point(370, 315)
        Me.lbProductNum.Name = "lbProductNum"
        Me.lbProductNum.Size = New System.Drawing.Size(120, 264)
        Me.lbProductNum.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Product Number"
        '
        'shoppingCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 750)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbProductNum)
        Me.Controls.Add(Me.btRemove)
        Me.Controls.Add(Me.btComplete)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btAccountHome)
        Me.Controls.Add(Me.btPurchase)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbQuantity)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "shoppingCart"
        Me.Text = "Shopping Cart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbProduct As System.Windows.Forms.ListBox
    Friend WithEvents lbPrice As System.Windows.Forms.ListBox
    Friend WithEvents lbQuantity As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents btPurchase As System.Windows.Forms.Button
    Friend WithEvents btAccountHome As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btComplete As System.Windows.Forms.Button
    Friend WithEvents btRemove As System.Windows.Forms.Button
    Friend WithEvents lbProductNum As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
