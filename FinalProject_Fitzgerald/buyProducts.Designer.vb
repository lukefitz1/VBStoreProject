<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buyProducts
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
        Me.lbProductNum = New System.Windows.Forms.ListBox()
        Me.lbProduct = New System.Windows.Forms.ListBox()
        Me.lbPrice = New System.Windows.Forms.ListBox()
        Me.lbInStock = New System.Windows.Forms.ListBox()
        Me.lbCategory = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.btAddToCart = New System.Windows.Forms.Button()
        Me.btViewCart = New System.Windows.Forms.Button()
        Me.btAccountHome = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btComplete = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(598, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Products"
        '
        'lbProductNum
        '
        Me.lbProductNum.FormattingEnabled = True
        Me.lbProductNum.Location = New System.Drawing.Point(280, 292)
        Me.lbProductNum.Name = "lbProductNum"
        Me.lbProductNum.Size = New System.Drawing.Size(134, 329)
        Me.lbProductNum.TabIndex = 2
        '
        'lbProduct
        '
        Me.lbProduct.FormattingEnabled = True
        Me.lbProduct.Location = New System.Drawing.Point(444, 292)
        Me.lbProduct.Name = "lbProduct"
        Me.lbProduct.Size = New System.Drawing.Size(134, 329)
        Me.lbProduct.TabIndex = 3
        '
        'lbPrice
        '
        Me.lbPrice.FormattingEnabled = True
        Me.lbPrice.Location = New System.Drawing.Point(608, 292)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(134, 329)
        Me.lbPrice.TabIndex = 4
        '
        'lbInStock
        '
        Me.lbInStock.FormattingEnabled = True
        Me.lbInStock.Location = New System.Drawing.Point(772, 292)
        Me.lbInStock.Name = "lbInStock"
        Me.lbInStock.Size = New System.Drawing.Size(134, 329)
        Me.lbInStock.TabIndex = 5
        '
        'lbCategory
        '
        Me.lbCategory.FormattingEnabled = True
        Me.lbCategory.Location = New System.Drawing.Point(936, 292)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(134, 329)
        Me.lbCategory.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Product ID Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(449, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(766, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Number In Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(930, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Product Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(510, 631)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(331, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "How many would you like to buy?"
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(608, 659)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(134, 20)
        Me.tbQuantity.TabIndex = 13
        '
        'btAddToCart
        '
        Me.btAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddToCart.Location = New System.Drawing.Point(585, 685)
        Me.btAddToCart.Name = "btAddToCart"
        Me.btAddToCart.Size = New System.Drawing.Size(180, 56)
        Me.btAddToCart.TabIndex = 14
        Me.btAddToCart.Text = "Add To Cart"
        Me.btAddToCart.UseVisualStyleBackColor = True
        '
        'btViewCart
        '
        Me.btViewCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btViewCart.Location = New System.Drawing.Point(803, 685)
        Me.btViewCart.Name = "btViewCart"
        Me.btViewCart.Size = New System.Drawing.Size(180, 56)
        Me.btViewCart.TabIndex = 15
        Me.btViewCart.Text = "View Cart"
        Me.btViewCart.UseVisualStyleBackColor = True
        '
        'btAccountHome
        '
        Me.btAccountHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAccountHome.Location = New System.Drawing.Point(149, 683)
        Me.btAccountHome.Name = "btAccountHome"
        Me.btAccountHome.Size = New System.Drawing.Size(180, 56)
        Me.btAccountHome.TabIndex = 16
        Me.btAccountHome.Text = "Account Home"
        Me.btAccountHome.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Location = New System.Drawing.Point(1021, 685)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(180, 56)
        Me.btCancel.TabIndex = 17
        Me.btCancel.Text = "Cancel Shopping Trip"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btComplete
        '
        Me.btComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComplete.Location = New System.Drawing.Point(367, 683)
        Me.btComplete.Name = "btComplete"
        Me.btComplete.Size = New System.Drawing.Size(180, 56)
        Me.btComplete.TabIndex = 18
        Me.btComplete.Text = "Complete Trip"
        Me.btComplete.UseVisualStyleBackColor = True
        '
        'buyProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 750)
        Me.Controls.Add(Me.btComplete)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btAccountHome)
        Me.Controls.Add(Me.btViewCart)
        Me.Controls.Add(Me.btAddToCart)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbCategory)
        Me.Controls.Add(Me.lbInStock)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbProduct)
        Me.Controls.Add(Me.lbProductNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "buyProducts"
        Me.Text = "Buy Now"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbProductNum As System.Windows.Forms.ListBox
    Friend WithEvents lbProduct As System.Windows.Forms.ListBox
    Friend WithEvents lbPrice As System.Windows.Forms.ListBox
    Friend WithEvents lbInStock As System.Windows.Forms.ListBox
    Friend WithEvents lbCategory As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btAddToCart As System.Windows.Forms.Button
    Friend WithEvents btViewCart As System.Windows.Forms.Button
    Friend WithEvents btAccountHome As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btComplete As System.Windows.Forms.Button
End Class
