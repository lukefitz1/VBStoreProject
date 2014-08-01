<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountInquiry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAccountID = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbBalance = New System.Windows.Forms.TextBox()
        Me.btChangeInfo = New System.Windows.Forms.Button()
        Me.btHome = New System.Windows.Forms.Button()
        Me.btLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCityState = New System.Windows.Forms.TextBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbZip = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(524, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(524, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(524, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Account Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(524, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Account ID"
        '
        'tbAccountID
        '
        Me.tbAccountID.Enabled = False
        Me.tbAccountID.Location = New System.Drawing.Point(689, 320)
        Me.tbAccountID.Name = "tbAccountID"
        Me.tbAccountID.Size = New System.Drawing.Size(143, 20)
        Me.tbAccountID.TabIndex = 7
        '
        'tbFirstName
        '
        Me.tbFirstName.Enabled = False
        Me.tbFirstName.Location = New System.Drawing.Point(689, 345)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(143, 20)
        Me.tbFirstName.TabIndex = 8
        '
        'tbLastName
        '
        Me.tbLastName.Enabled = False
        Me.tbLastName.Location = New System.Drawing.Point(689, 370)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(143, 20)
        Me.tbLastName.TabIndex = 9
        '
        'tbAddress
        '
        Me.tbAddress.Enabled = False
        Me.tbAddress.Location = New System.Drawing.Point(689, 395)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(143, 20)
        Me.tbAddress.TabIndex = 10
        '
        'tbBalance
        '
        Me.tbBalance.Enabled = False
        Me.tbBalance.Location = New System.Drawing.Point(689, 495)
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.Size = New System.Drawing.Size(143, 20)
        Me.tbBalance.TabIndex = 11
        '
        'btChangeInfo
        '
        Me.btChangeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btChangeInfo.Location = New System.Drawing.Point(541, 558)
        Me.btChangeInfo.Name = "btChangeInfo"
        Me.btChangeInfo.Size = New System.Drawing.Size(268, 61)
        Me.btChangeInfo.TabIndex = 12
        Me.btChangeInfo.Text = "Change Account Information"
        Me.btChangeInfo.UseVisualStyleBackColor = True
        '
        'btHome
        '
        Me.btHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHome.Location = New System.Drawing.Point(541, 638)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(128, 61)
        Me.btHome.TabIndex = 13
        Me.btHome.Text = "Home"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'btLogout
        '
        Me.btLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogout.Location = New System.Drawing.Point(681, 638)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(128, 61)
        Me.btLogout.TabIndex = 14
        Me.btLogout.Text = "Logout"
        Me.btLogout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(524, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "City, State"
        '
        'tbCityState
        '
        Me.tbCityState.Enabled = False
        Me.tbCityState.Location = New System.Drawing.Point(688, 420)
        Me.tbCityState.Name = "tbCityState"
        Me.tbCityState.Size = New System.Drawing.Size(143, 20)
        Me.tbCityState.TabIndex = 16
        '
        'tbPhone
        '
        Me.tbPhone.Enabled = False
        Me.tbPhone.Location = New System.Drawing.Point(688, 470)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(143, 20)
        Me.tbPhone.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(524, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Phone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(524, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Zip"
        '
        'tbZip
        '
        Me.tbZip.Enabled = False
        Me.tbZip.Location = New System.Drawing.Point(689, 445)
        Me.tbZip.Name = "tbZip"
        Me.tbZip.Size = New System.Drawing.Size(143, 20)
        Me.tbZip.TabIndex = 20
        '
        'accountInquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.tbZip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.tbCityState)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.btChangeInfo)
        Me.Controls.Add(Me.tbBalance)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.tbAccountID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "accountInquiry"
        Me.Text = "Account Inquiry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbAccountID As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbBalance As System.Windows.Forms.TextBox
    Friend WithEvents btChangeInfo As System.Windows.Forms.Button
    Friend WithEvents btHome As System.Windows.Forms.Button
    Friend WithEvents btLogout As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCityState As System.Windows.Forms.TextBox
    Friend WithEvents tbPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbZip As System.Windows.Forms.TextBox
End Class
