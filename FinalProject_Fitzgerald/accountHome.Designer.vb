<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountHome
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
        Me.btInquiry = New System.Windows.Forms.Button()
        Me.btTransaction = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Home"
        '
        'btInquiry
        '
        Me.btInquiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInquiry.Location = New System.Drawing.Point(483, 366)
        Me.btInquiry.Name = "btInquiry"
        Me.btInquiry.Size = New System.Drawing.Size(186, 54)
        Me.btInquiry.TabIndex = 2
        Me.btInquiry.Text = "Account Inquiry"
        Me.btInquiry.UseVisualStyleBackColor = True
        '
        'btTransaction
        '
        Me.btTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTransaction.Location = New System.Drawing.Point(681, 366)
        Me.btTransaction.Name = "btTransaction"
        Me.btTransaction.Size = New System.Drawing.Size(186, 54)
        Me.btTransaction.TabIndex = 3
        Me.btTransaction.Text = "Buy Now"
        Me.btTransaction.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btLogout
        '
        Me.btLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogout.Location = New System.Drawing.Point(541, 436)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(268, 54)
        Me.btLogout.TabIndex = 4
        Me.btLogout.Text = "Logout"
        Me.btLogout.UseVisualStyleBackColor = True
        '
        'accountHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.btTransaction)
        Me.Controls.Add(Me.btInquiry)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "accountHome"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btInquiry As System.Windows.Forms.Button
    Friend WithEvents btTransaction As System.Windows.Forms.Button
    Friend WithEvents btLogout As System.Windows.Forms.Button
End Class
