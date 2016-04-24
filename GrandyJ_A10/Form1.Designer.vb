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
      Me.DataGridView1 = New System.Windows.Forms.DataGridView()
      Me.btnUpdate = New System.Windows.Forms.Button()
      Me.btnAll = New System.Windows.Forms.Button()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.btnSearch = New System.Windows.Forms.Button()
      Me.cboOperator = New System.Windows.Forms.ComboBox()
      Me.cboField = New System.Windows.Forms.ComboBox()
      Me.txtValue = New System.Windows.Forms.TextBox()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'DataGridView1
      '
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.Size = New System.Drawing.Size(565, 378)
      Me.DataGridView1.TabIndex = 0
      '
      'btnUpdate
      '
      Me.btnUpdate.Location = New System.Drawing.Point(583, 83)
      Me.btnUpdate.Name = "btnUpdate"
      Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
      Me.btnUpdate.TabIndex = 1
      Me.btnUpdate.Text = "Update"
      Me.btnUpdate.UseVisualStyleBackColor = True
      '
      'btnAll
      '
      Me.btnAll.Location = New System.Drawing.Point(583, 156)
      Me.btnAll.Name = "btnAll"
      Me.btnAll.Size = New System.Drawing.Size(75, 23)
      Me.btnAll.TabIndex = 2
      Me.btnAll.Text = "All"
      Me.btnAll.UseVisualStyleBackColor = True
      '
      'Button3
      '
      Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button3.Location = New System.Drawing.Point(583, 237)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(75, 23)
      Me.Button3.TabIndex = 3
      Me.Button3.Text = "Exit"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'btnSearch
      '
      Me.btnSearch.Location = New System.Drawing.Point(583, 396)
      Me.btnSearch.Name = "btnSearch"
      Me.btnSearch.Size = New System.Drawing.Size(75, 23)
      Me.btnSearch.TabIndex = 4
      Me.btnSearch.Text = "Search"
      Me.btnSearch.UseVisualStyleBackColor = True
      '
      'cboOperator
      '
      Me.cboOperator.FormattingEnabled = True
      Me.cboOperator.Items.AddRange(New Object() {"=", "<", "<=", ">", ">="})
      Me.cboOperator.Location = New System.Drawing.Point(183, 396)
      Me.cboOperator.Name = "cboOperator"
      Me.cboOperator.Size = New System.Drawing.Size(121, 21)
      Me.cboOperator.TabIndex = 0
      '
      'cboField
      '
      Me.cboField.FormattingEnabled = True
      Me.cboField.Items.AddRange(New Object() {"Hotel_No", "Guest_No", "Date_From", "Date_To", "Room_No"})
      Me.cboField.Location = New System.Drawing.Point(12, 396)
      Me.cboField.Name = "cboField"
      Me.cboField.Size = New System.Drawing.Size(121, 21)
      Me.cboField.TabIndex = 0
      '
      'txtValue
      '
      Me.txtValue.Location = New System.Drawing.Point(360, 396)
      Me.txtValue.Name = "txtValue"
      Me.txtValue.Size = New System.Drawing.Size(128, 20)
      Me.txtValue.TabIndex = 7
      '
      'Form1
      '
      Me.AcceptButton = Me.btnSearch
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.Button3
      Me.ClientSize = New System.Drawing.Size(670, 431)
      Me.Controls.Add(Me.txtValue)
      Me.Controls.Add(Me.cboField)
      Me.Controls.Add(Me.cboOperator)
      Me.Controls.Add(Me.btnSearch)
      Me.Controls.Add(Me.Button3)
      Me.Controls.Add(Me.btnAll)
      Me.Controls.Add(Me.btnUpdate)
      Me.Controls.Add(Me.DataGridView1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "Form1"
      Me.Text = "CS 3630 GrandyJ OberhauserG"
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents DataGridView1 As DataGridView
   Friend WithEvents btnUpdate As Button
   Friend WithEvents btnAll As Button
   Friend WithEvents Button3 As Button
   Friend WithEvents btnSearch As Button
    Friend WithEvents cboOperator As ComboBox
    Friend WithEvents cboField As ComboBox
    Friend WithEvents txtValue As TextBox
End Class
