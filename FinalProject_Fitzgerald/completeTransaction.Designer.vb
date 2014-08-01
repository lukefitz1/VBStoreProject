<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class completeTransaction
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbProductNum = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbQuantity = New System.Windows.Forms.ListBox()
        Me.lbPrice = New System.Windows.Forms.ListBox()
        Me.lbProduct = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btComplete = New System.Windows.Forms.Button()
        Me.btHome = New System.Windows.Forms.Button()
        Me.btShoppingCart = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.tbBalance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(569, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "View Your Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(541, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hit Complete to Finalize"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Product Number"
        '
        'lbProductNum
        '
        Me.lbProductNum.FormattingEnabled = True
        Me.lbProductNum.Location = New System.Drawing.Point(217, 354)
        Me.lbProductNum.Name = "lbProductNum"
        Me.lbProductNum.Size = New System.Drawing.Size(120, 264)
        Me.lbProductNum.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(732, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(579, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(395, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Product"
        '
        'lbQuantity
        '
        Me.lbQuantity.FormattingEnabled = True
        Me.lbQuantity.Location = New System.Drawing.Point(712, 354)
        Me.lbQuantity.Name = "lbQuantity"
        Me.lbQuantity.Size = New System.Drawing.Size(120, 264)
        Me.lbQuantity.TabIndex = 19
        '
        'lbPrice
        '
        Me.lbPrice.FormattingEnabled = True
        Me.lbPrice.Location = New System.Drawing.Point(547, 354)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(120, 264)
        Me.lbPrice.TabIndex = 18
        '
        'lbProduct
        '
        Me.lbProduct.FormattingEnabled = True
        Me.lbProduct.Location = New System.Drawing.Point(382, 354)
        Me.lbProduct.Name = "lbProduct"
        Me.lbProduct.Size = New System.Drawing.Size(120, 264)
        Me.lbProduct.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(896, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Total"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(877, 354)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(120, 31)
        Me.tbTotal.TabIndex = 26
        '
        'btComplete
        '
        Me.btComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComplete.Location = New System.Drawing.Point(877, 391)
        Me.btComplete.Name = "btComplete"
        Me.btComplete.Size = New System.Drawing.Size(120, 59)
        Me.btComplete.TabIndex = 27
        Me.btComplete.Text = "Complete"
        Me.btComplete.UseVisualStyleBackColor = True
        '
        'btHome
        '
        Me.btHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHome.Location = New System.Drawing.Point(1014, 466)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(120, 59)
        Me.btHome.TabIndex = 28
        Me.btHome.Text = "Home"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'btShoppingCart
        '
        Me.btShoppingCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btShoppingCart.Location = New System.Drawing.Point(1014, 391)
        Me.btShoppingCart.Name = "btShoppingCart"
        Me.btShoppingCart.Size = New System.Drawing.Size(120, 59)
        Me.btShoppingCart.TabIndex = 29
        Me.btShoppingCart.Text = "Shopping Cart"
        Me.btShoppingCart.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Location = New System.Drawing.Point(877, 466)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(120, 59)
        Me.btCancel.TabIndex = 30
        Me.btCancel.Text = "Cancel Order"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'tbBalance
        '
        Me.tbBalance.Enabled = False
        Me.tbBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalance.Location = New System.Drawing.Point(1014, 354)
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.Size = New System.Drawing.Size(120, 31)
        Me.tbBalance.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1024, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Balance"
        '
        'completeTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbBalance)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btShoppingCart)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.btComplete)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbProductNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbQuantity)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "completeTransaction"
        Me.Text = "Complete Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbProductNum As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbQuantity As System.Windows.Forms.ListBox
    Friend WithEvents lbPrice As System.Windows.Forms.ListBox
    Friend WithEvents lbProduct As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents btComplete As System.Windows.Forms.Button
    Friend WithEvents btHome As System.Windows.Forms.Button
    Friend WithEvents btShoppingCart As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents tbBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
