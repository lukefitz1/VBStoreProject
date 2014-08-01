<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class storeProfile
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
        Me.tbProfile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject_Fitzgerald.My.Resources.Resources.Final_Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(541, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 162)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btGeneralInfo
        '
        Me.btGeneralInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGeneralInfo.Location = New System.Drawing.Point(541, 500)
        Me.btGeneralInfo.Name = "btGeneralInfo"
        Me.btGeneralInfo.Size = New System.Drawing.Size(268, 55)
        Me.btGeneralInfo.TabIndex = 2
        Me.btGeneralInfo.Text = "General Store Information"
        Me.btGeneralInfo.UseVisualStyleBackColor = True
        '
        'tbProfile
        '
        Me.tbProfile.Location = New System.Drawing.Point(541, 319)
        Me.tbProfile.Multiline = True
        Me.tbProfile.Name = "tbProfile"
        Me.tbProfile.Size = New System.Drawing.Size(268, 165)
        Me.tbProfile.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(498, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Fitzgerald's Computer Shop!"
        '
        'storeProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbProfile)
        Me.Controls.Add(Me.btGeneralInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "storeProfile"
        Me.Text = "Store Profile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btGeneralInfo As System.Windows.Forms.Button
    Friend WithEvents tbProfile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
