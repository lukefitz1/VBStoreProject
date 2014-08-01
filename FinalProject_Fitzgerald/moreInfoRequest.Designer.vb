<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class moreInfoRequest
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
        Me.btGeneralInfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbZip = New System.Windows.Forms.TextBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.tbRequest = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbAccountType = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btGeneralInfo
        '
        Me.btGeneralInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGeneralInfo.Location = New System.Drawing.Point(549, 679)
        Me.btGeneralInfo.Name = "btGeneralInfo"
        Me.btGeneralInfo.Size = New System.Drawing.Size(252, 30)
        Me.btGeneralInfo.TabIndex = 5
        Me.btGeneralInfo.Text = "General Store Information"
        Me.btGeneralInfo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "City:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Zip Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone (ex. 1234567891)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(525, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "State:"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(661, 235)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(164, 20)
        Me.tbName.TabIndex = 11
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(661, 274)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(164, 20)
        Me.tbCity.TabIndex = 12
        '
        'tbZip
        '
        Me.tbZip.Location = New System.Drawing.Point(661, 349)
        Me.tbZip.Name = "tbZip"
        Me.tbZip.Size = New System.Drawing.Size(164, 20)
        Me.tbZip.TabIndex = 13
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(724, 385)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(101, 20)
        Me.tbPhone.TabIndex = 14
        '
        'cbState
        '
        Me.cbState.FormattingEnabled = True
        Me.cbState.Items.AddRange(New Object() {"MA", "ME", "NH", "VT", "RI", "CT"})
        Me.cbState.Location = New System.Drawing.Point(661, 309)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(163, 21)
        Me.cbState.TabIndex = 15
        '
        'tbRequest
        '
        Me.tbRequest.Location = New System.Drawing.Point(529, 489)
        Me.tbRequest.Multiline = True
        Me.tbRequest.Name = "tbRequest"
        Me.tbRequest.Size = New System.Drawing.Size(296, 108)
        Me.tbRequest.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(549, 626)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(510, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(330, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Which account do you have questions about?"
        '
        'cbAccountType
        '
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Items.AddRange(New Object() {"Retail Accounts", "Business Accounts"})
        Me.cbAccountType.Location = New System.Drawing.Point(529, 456)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(296, 21)
        Me.cbAccountType.TabIndex = 19
        '
        'moreInfoRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.cbAccountType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbRequest)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.tbZip)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btGeneralInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "moreInfoRequest"
        Me.Text = "Request More Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btGeneralInfo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents tbZip As System.Windows.Forms.TextBox
    Friend WithEvents tbPhone As System.Windows.Forms.TextBox
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents tbRequest As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbAccountType As System.Windows.Forms.ComboBox
End Class
