Public Class Oracle
   Friend Shared UserName As String
   Friend Shared PassWd As String
   Friend Shared Server As String

   Friend Shared myConnection As New System.Data.OleDb.OleDbConnection

   Friend Shared staffAdapter As New System.Data.OleDb.OleDbDataAdapter
   Friend Shared staffCommand As New System.Data.OleDb.OleDbCommand
   Friend Shared staffBuilder As System.Data.OleDb.OleDbCommandBuilder
   Friend Shared staffTable As New System.Data.DataTable("UWP_Staff")

   Friend Shared qualsAdapter As New System.Data.OleDb.OleDbDataAdapter
   Friend Shared qualsCommand As New System.Data.OleDb.OleDbCommand
   Friend Shared qualsBuilder As System.Data.OleDb.OleDbCommandBuilder
   Friend Shared qualsTable As New System.Data.DataTable("UWP_WorkExperience")

   Friend Shared workExpAdapter As New System.Data.OleDb.OleDbDataAdapter
   Friend Shared workExpCommand As New System.Data.OleDb.OleDbCommand
   Friend Shared workExpBuilder As System.Data.OleDb.OleDbCommandBuilder
   Friend Shared workExpTable As New System.Data.DataTable("UWP_Qualifications")

   Public Shared Sub LogInAtRunTime(ByVal user As String, ByVal pass As String, ByVal host As String)

      myConnection.ConnectionString = "Provider=MSDAORA;user id=" & user & ";data source=" & host & _
                                      ";password=" & pass & ";persist security info=False"
      staffCommand.CommandType = CommandType.Text
      staffCommand.CommandText = "Select * from uwp_staff"
      staffCommand.Connection = myConnection

      staffAdapter.SelectCommand = staffCommand
      staffBuilder = New System.Data.OleDb.OleDbCommandBuilder(staffAdapter)
      staffAdapter.Fill(staffTable)

      qualsCommand.CommandType = CommandType.Text
      qualsCommand.CommandText = "Select * from uwp_qualifications"
      qualsCommand.Connection = myConnection

      qualsAdapter.SelectCommand = qualsCommand
      qualsBuilder = New System.Data.OleDb.OleDbCommandBuilder(qualsAdapter)
      qualsAdapter.Fill(qualsTable)

      workExpCommand.CommandType = CommandType.Text
      workExpCommand.CommandText = "Select * from uwp_workexperience"
      workExpCommand.Connection = myConnection

      workExpAdapter.SelectCommand = workExpCommand
      workExpBuilder = New System.Data.OleDb.OleDbCommandBuilder(workExpAdapter)
      workExpAdapter.Fill(workExpTable)
   End Sub

   Public Shared Sub main()

      Application.Run(New Form1)

   End Sub
End Class
