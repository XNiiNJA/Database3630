<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
      Me.txtUsername = New System.Windows.Forms.TextBox()
      Me.txtPassword = New System.Windows.Forms.TextBox()
      Me.txtHost = New System.Windows.Forms.TextBox()
      Me.cnclButton = New System.Windows.Forms.Button()
      Me.okButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(198, 67)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(57, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "UserName"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(198, 128)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(53, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Password"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(198, 188)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(59, 13)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Host String"
      '
      'txtUsername
      '
      Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtUsername.Location = New System.Drawing.Point(295, 64)
      Me.txtUsername.Name = "txtUsername"
      Me.txtUsername.Size = New System.Drawing.Size(151, 20)
      Me.txtUsername.TabIndex = 3
      '
      'txtPassword
      '
      Me.txtPassword.Location = New System.Drawing.Point(295, 125)
      Me.txtPassword.Name = "txtPassword"
      Me.txtPassword.Size = New System.Drawing.Size(151, 20)
      Me.txtPassword.TabIndex = 4
      Me.txtPassword.UseSystemPasswordChar = True
      '
      'txtHost
      '
      Me.txtHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtHost.Location = New System.Drawing.Point(295, 185)
      Me.txtHost.Name = "txtHost"
      Me.txtHost.Size = New System.Drawing.Size(151, 20)
      Me.txtHost.TabIndex = 5
      '
      'cnclButton
      '
      Me.cnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cnclButton.Location = New System.Drawing.Point(371, 289)
      Me.cnclButton.Name = "cnclButton"
      Me.cnclButton.Size = New System.Drawing.Size(75, 23)
      Me.cnclButton.TabIndex = 6
      Me.cnclButton.Text = "Cancel"
      Me.cnclButton.UseVisualStyleBackColor = True
      '
      'okButton
      '
      Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.okButton.Location = New System.Drawing.Point(201, 289)
      Me.okButton.Name = "okButton"
      Me.okButton.Size = New System.Drawing.Size(75, 23)
      Me.okButton.TabIndex = 7
      Me.okButton.Text = "OK"
      Me.okButton.UseVisualStyleBackColor = True
      '
      'Form2
      '
      Me.AcceptButton = Me.okButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.cnclButton
      Me.ClientSize = New System.Drawing.Size(670, 404)
      Me.Controls.Add(Me.okButton)
      Me.Controls.Add(Me.cnclButton)
      Me.Controls.Add(Me.txtHost)
      Me.Controls.Add(Me.txtPassword)
      Me.Controls.Add(Me.txtUsername)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "Form2"
      Me.Text = "Login GrandyJ OberhauserG"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents txtUsername As TextBox
   Friend WithEvents txtPassword As TextBox
   Friend WithEvents txtHost As TextBox
   'Friend WithEvents cnclButton As Button
   'Friend WithEvents okButton As System.Windows.Forms.Button
   Friend WithEvents cnclButton As System.Windows.Forms.Button
   Friend WithEvents okButton As System.Windows.Forms.Button
End Class
