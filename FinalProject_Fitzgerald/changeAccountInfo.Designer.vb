<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeAccountInfo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbStreetNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btDone = New System.Windows.Forms.Button()
        Me.btHome = New System.Windows.Forms.Button()
        Me.btLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbStreet = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbZip = New System.Windows.Forms.TextBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAccountID = New System.Windows.Forms.TextBox()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Street Number, Street"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(499, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name"
        '
        'tbFirstName
        '
        Me.tbFirstName.Enabled = False
        Me.tbFirstName.Location = New System.Drawing.Point(671, 352)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(168, 20)
        Me.tbFirstName.TabIndex = 8
        '
        'tbLastName
        '
        Me.tbLastName.Enabled = False
        Me.tbLastName.Location = New System.Drawing.Point(671, 387)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(168, 20)
        Me.tbLastName.TabIndex = 9
        '
        'tbStreetNum
        '
        Me.tbStreetNum.Location = New System.Drawing.Point(649, 422)
        Me.tbStreetNum.Name = "tbStreetNum"
        Me.tbStreetNum.Size = New System.Drawing.Size(68, 20)
        Me.tbStreetNum.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(479, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Change Personal Information"
        '
        'btDone
        '
        Me.btDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDone.Location = New System.Drawing.Point(535, 569)
        Me.btDone.Name = "btDone"
        Me.btDone.Size = New System.Drawing.Size(274, 41)
        Me.btDone.TabIndex = 12
        Me.btDone.Text = "Done"
        Me.btDone.UseVisualStyleBackColor = True
        '
        'btHome
        '
        Me.btHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHome.Location = New System.Drawing.Point(535, 630)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(128, 41)
        Me.btHome.TabIndex = 13
        Me.btHome.Text = "Home"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'btLogout
        '
        Me.btLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogout.Location = New System.Drawing.Point(681, 630)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(128, 41)
        Me.btLogout.TabIndex = 14
        Me.btLogout.Text = "Logout"
        Me.btLogout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tbStreet
        '
        Me.tbStreet.Location = New System.Drawing.Point(723, 422)
        Me.tbStreet.Name = "tbStreet"
        Me.tbStreet.Size = New System.Drawing.Size(115, 20)
        Me.tbStreet.TabIndex = 18
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(670, 457)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(79, 20)
        Me.tbCity.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(499, 457)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 40)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "City, State" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(499, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Zip Code"
        '
        'tbZip
        '
        Me.tbZip.Location = New System.Drawing.Point(671, 493)
        Me.tbZip.Name = "tbZip"
        Me.tbZip.Size = New System.Drawing.Size(167, 20)
        Me.tbZip.TabIndex = 23
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(671, 528)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(166, 20)
        Me.tbPhone.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(499, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(499, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Account ID"
        '
        'tbAccountID
        '
        Me.tbAccountID.Enabled = False
        Me.tbAccountID.Location = New System.Drawing.Point(669, 317)
        Me.tbAccountID.Name = "tbAccountID"
        Me.tbAccountID.Size = New System.Drawing.Size(169, 20)
        Me.tbAccountID.TabIndex = 30
        '
        'tbState
        '
        Me.tbState.Location = New System.Drawing.Point(759, 457)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(79, 20)
        Me.tbState.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(844, 460)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "State must be MA, ME, NH, VT, RI, or CT"
        '
        'changeAccountInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbAccountID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.tbZip)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbState)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbStreet)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.btDone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbStreetNum)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "changeAccountInfo"
        Me.Text = "Edit Account"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbStreetNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btDone As System.Windows.Forms.Button
    Friend WithEvents btHome As System.Windows.Forms.Button
    Friend WithEvents btLogout As System.Windows.Forms.Button
    Friend WithEvents tbStreet As System.Windows.Forms.TextBox
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbZip As System.Windows.Forms.TextBox
    Friend WithEvents tbPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbAccountID As System.Windows.Forms.TextBox
    Friend WithEvents tbState As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
