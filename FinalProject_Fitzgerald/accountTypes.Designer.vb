<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountTypes
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
        Me.btGeneralInfo = New System.Windows.Forms.Button()
        Me.cbAccountType = New System.Windows.Forms.ComboBox()
        Me.tbAccountType = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btGeneralInfo
        '
        Me.btGeneralInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGeneralInfo.Location = New System.Drawing.Point(541, 545)
        Me.btGeneralInfo.Name = "btGeneralInfo"
        Me.btGeneralInfo.Size = New System.Drawing.Size(268, 55)
        Me.btGeneralInfo.TabIndex = 3
        Me.btGeneralInfo.Text = "General Store Information"
        Me.btGeneralInfo.UseVisualStyleBackColor = True
        '
        'cbAccountType
        '
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Items.AddRange(New Object() {"Retail Account", "Business Account"})
        Me.cbAccountType.Location = New System.Drawing.Point(541, 286)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(268, 21)
        Me.cbAccountType.TabIndex = 4
        '
        'tbAccountType
        '
        Me.tbAccountType.Location = New System.Drawing.Point(541, 324)
        Me.tbAccountType.Multiline = True
        Me.tbAccountType.Name = "tbAccountType"
        Me.tbAccountType.Size = New System.Drawing.Size(268, 201)
        Me.tbAccountType.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'accountTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.tbAccountType)
        Me.Controls.Add(Me.cbAccountType)
        Me.Controls.Add(Me.btGeneralInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "accountTypes"
        Me.Text = "Account Types"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btGeneralInfo As System.Windows.Forms.Button
    Friend WithEvents cbAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents tbAccountType As System.Windows.Forms.TextBox
End Class
