<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generalStoreInfo
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
        Me.btProfile = New System.Windows.Forms.Button()
        Me.btAccounts = New System.Windows.Forms.Button()
        Me.btProductInfo = New System.Windows.Forms.Button()
        Me.btRequest = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "General Store Information"
        '
        'btProfile
        '
        Me.btProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btProfile.Location = New System.Drawing.Point(519, 356)
        Me.btProfile.Name = "btProfile"
        Me.btProfile.Size = New System.Drawing.Size(134, 55)
        Me.btProfile.TabIndex = 2
        Me.btProfile.Text = "Store Profile"
        Me.btProfile.UseVisualStyleBackColor = True
        '
        'btAccounts
        '
        Me.btAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAccounts.Location = New System.Drawing.Point(698, 356)
        Me.btAccounts.Name = "btAccounts"
        Me.btAccounts.Size = New System.Drawing.Size(134, 55)
        Me.btAccounts.TabIndex = 3
        Me.btAccounts.Text = "Account Types"
        Me.btAccounts.UseVisualStyleBackColor = True
        '
        'btProductInfo
        '
        Me.btProductInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btProductInfo.Location = New System.Drawing.Point(520, 433)
        Me.btProductInfo.Name = "btProductInfo"
        Me.btProductInfo.Size = New System.Drawing.Size(134, 55)
        Me.btProductInfo.TabIndex = 4
        Me.btProductInfo.Text = "Product Information"
        Me.btProductInfo.UseVisualStyleBackColor = True
        '
        'btRequest
        '
        Me.btRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRequest.Location = New System.Drawing.Point(698, 433)
        Me.btRequest.Name = "btRequest"
        Me.btRequest.Size = New System.Drawing.Size(134, 55)
        Me.btRequest.TabIndex = 5
        Me.btRequest.Text = "Request More Information"
        Me.btRequest.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Location = New System.Drawing.Point(544, 510)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(263, 53)
        Me.btClose.TabIndex = 6
        Me.btClose.Text = "Quit"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'generalStoreInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btRequest)
        Me.Controls.Add(Me.btProductInfo)
        Me.Controls.Add(Me.btAccounts)
        Me.Controls.Add(Me.btProfile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "generalStoreInfo"
        Me.Text = "Store Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btProfile As System.Windows.Forms.Button
    Friend WithEvents btAccounts As System.Windows.Forms.Button
    Friend WithEvents btProductInfo As System.Windows.Forms.Button
    Friend WithEvents btRequest As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
End Class
