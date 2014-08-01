<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountLogin
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
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.tbPin = New System.Windows.Forms.TextBox()
        Me.btEnter = New System.Windows.Forms.Button()
        Me.btHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please login using your Account ID Number and 4-digit Pin Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pin:"
        '
        'tbLogin
        '
        Me.tbLogin.Location = New System.Drawing.Point(253, 98)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(226, 20)
        Me.tbLogin.TabIndex = 3
        '
        'tbPin
        '
        Me.tbPin.Location = New System.Drawing.Point(253, 139)
        Me.tbPin.Name = "tbPin"
        Me.tbPin.Size = New System.Drawing.Size(226, 20)
        Me.tbPin.TabIndex = 4
        '
        'btEnter
        '
        Me.btEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnter.Location = New System.Drawing.Point(253, 199)
        Me.btEnter.Name = "btEnter"
        Me.btEnter.Size = New System.Drawing.Size(226, 54)
        Me.btEnter.TabIndex = 5
        Me.btEnter.Text = "Enter"
        Me.btEnter.UseVisualStyleBackColor = True
        '
        'btHome
        '
        Me.btHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHome.Location = New System.Drawing.Point(253, 268)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(226, 54)
        Me.btHome.TabIndex = 6
        Me.btHome.Text = "Home"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'accountLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 354)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.btEnter)
        Me.Controls.Add(Me.tbPin)
        Me.Controls.Add(Me.tbLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "accountLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbLogin As System.Windows.Forms.TextBox
    Friend WithEvents tbPin As System.Windows.Forms.TextBox
    Friend WithEvents btEnter As System.Windows.Forms.Button
    Friend WithEvents btHome As System.Windows.Forms.Button
End Class
