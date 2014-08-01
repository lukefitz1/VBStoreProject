<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doubleChecking
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
        Me.btHomeScreen = New System.Windows.Forms.Button()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thank You for Visiting!"
        '
        'btHomeScreen
        '
        Me.btHomeScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHomeScreen.Location = New System.Drawing.Point(63, 103)
        Me.btHomeScreen.Name = "btHomeScreen"
        Me.btHomeScreen.Size = New System.Drawing.Size(154, 53)
        Me.btHomeScreen.TabIndex = 1
        Me.btHomeScreen.Text = "Home Screen"
        Me.btHomeScreen.UseVisualStyleBackColor = True
        '
        'btQuit
        '
        Me.btQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btQuit.Location = New System.Drawing.Point(239, 103)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(154, 53)
        Me.btQuit.TabIndex = 2
        Me.btQuit.Text = "Quit"
        Me.btQuit.UseVisualStyleBackColor = True
        '
        'doubleChecking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 210)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btHomeScreen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "doubleChecking"
        Me.Text = "Thank You!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btHomeScreen As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
End Class
