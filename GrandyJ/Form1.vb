Public Class Form1

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click

      Try

         Oracle.LogInAtRunTime(usernameTxt.Text, pwdTxt.Text, hostTxt.Text)

         Hide()

         Form2.Show()

      Catch ex As Exception

      End Try
      'Oracle.UserName = usernameTxt.Text
      'Oracle.PassWd = pwdTxt.Text
      'Oracle.Server = hostTxt.Text

      'Oracle.myConnection.ConnectionString = "user id=" & Oracle.UserName & ";data source=" & Oracle.Server &
      '                               ";password=" & Oracle.PassWd & ";persist security info=False"

      'Oracle.myOracleCommand.CommandType = CommandType.Text
      'Oracle.myOracleCommand.CommandText = "Select * from booking"
      'Oracle.myOracleCommand.Connection = Oracle.myOracleConnection

      'Oracle.myOracleDataAdapter.SelectCommand = Oracle.myOracleCommand
      'Oracle.myOracleCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(Oracle.myOracleDataAdapter)

      'Try

      '   Oracle.myOracleDataAdapter.Fill(Oracle.myTable)

      '   Hide()

      '   Form2.Show()

      'Catch ex As Exception

      'End Try
   End Sub

   Private Sub cnclBtn_Click(sender As Object, e As EventArgs) Handles cnclBtn.Click
      Close()
   End Sub
End Class
