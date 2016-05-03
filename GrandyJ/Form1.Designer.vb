<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.usernameLbl = New System.Windows.Forms.Label()
      Me.pwdLbl = New System.Windows.Forms.Label()
      Me.hostLbl = New System.Windows.Forms.Label()
      Me.usernameTxt = New System.Windows.Forms.TextBox()
      Me.pwdTxt = New System.Windows.Forms.TextBox()
      Me.hostTxt = New System.Windows.Forms.TextBox()
      Me.okBtn = New System.Windows.Forms.Button()
      Me.cnclBtn = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'usernameLbl
      '
      Me.usernameLbl.AutoSize = True
      Me.usernameLbl.Location = New System.Drawing.Point(112, 38)
      Me.usernameLbl.Name = "usernameLbl"
      Me.usernameLbl.Size = New System.Drawing.Size(58, 13)
      Me.usernameLbl.TabIndex = 0
      Me.usernameLbl.Text = "User name"
      '
      'pwdLbl
      '
      Me.pwdLbl.AutoSize = True
      Me.pwdLbl.Location = New System.Drawing.Point(112, 86)
      Me.pwdLbl.Name = "pwdLbl"
      Me.pwdLbl.Size = New System.Drawing.Size(53, 13)
      Me.pwdLbl.TabIndex = 1
      Me.pwdLbl.Text = "Password"
      '
      'hostLbl
      '
      Me.hostLbl.AutoSize = True
      Me.hostLbl.Location = New System.Drawing.Point(112, 135)
      Me.hostLbl.Name = "hostLbl"
      Me.hostLbl.Size = New System.Drawing.Size(59, 13)
      Me.hostLbl.TabIndex = 2
      Me.hostLbl.Text = "Host String"
      '
      'usernameTxt
      '
      Me.usernameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.usernameTxt.Location = New System.Drawing.Point(110, 54)
      Me.usernameTxt.Name = "usernameTxt"
      Me.usernameTxt.Size = New System.Drawing.Size(216, 20)
      Me.usernameTxt.TabIndex = 3
      '
      'pwdTxt
      '
      Me.pwdTxt.Location = New System.Drawing.Point(110, 102)
      Me.pwdTxt.Name = "pwdTxt"
      Me.pwdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.pwdTxt.Size = New System.Drawing.Size(216, 20)
      Me.pwdTxt.TabIndex = 4
      '
      'hostTxt
      '
      Me.hostTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.hostTxt.Location = New System.Drawing.Point(110, 151)
      Me.hostTxt.Name = "hostTxt"
      Me.hostTxt.Size = New System.Drawing.Size(216, 20)
      Me.hostTxt.TabIndex = 5
      '
      'okBtn
      '
      Me.okBtn.Location = New System.Drawing.Point(115, 187)
      Me.okBtn.Name = "okBtn"
      Me.okBtn.Size = New System.Drawing.Size(100, 23)
      Me.okBtn.TabIndex = 6
      Me.okBtn.Text = "OK"
      Me.okBtn.UseVisualStyleBackColor = True
      '
      'cnclBtn
      '
      Me.cnclBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cnclBtn.Location = New System.Drawing.Point(226, 187)
      Me.cnclBtn.Name = "cnclBtn"
      Me.cnclBtn.Size = New System.Drawing.Size(100, 23)
      Me.cnclBtn.TabIndex = 7
      Me.cnclBtn.Text = "Cancel"
      Me.cnclBtn.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AcceptButton = Me.okBtn
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.cnclBtn
      Me.ClientSize = New System.Drawing.Size(434, 262)
      Me.Controls.Add(Me.cnclBtn)
      Me.Controls.Add(Me.okBtn)
      Me.Controls.Add(Me.hostTxt)
      Me.Controls.Add(Me.pwdTxt)
      Me.Controls.Add(Me.usernameTxt)
      Me.Controls.Add(Me.hostLbl)
      Me.Controls.Add(Me.pwdLbl)
      Me.Controls.Add(Me.usernameLbl)
      Me.Name = "Form1"
      Me.Text = "CS3630 GrandyJ OberhauserG"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents usernameLbl As System.Windows.Forms.Label
   Friend WithEvents pwdLbl As System.Windows.Forms.Label
   Friend WithEvents hostLbl As System.Windows.Forms.Label
   Friend WithEvents usernameTxt As System.Windows.Forms.TextBox
   Friend WithEvents pwdTxt As System.Windows.Forms.TextBox
   Friend WithEvents hostTxt As System.Windows.Forms.TextBox
   Friend WithEvents okBtn As System.Windows.Forms.Button
   Friend WithEvents cnclBtn As System.Windows.Forms.Button

End Class
