Public Class Oracle
    Friend Shared UserName As String
    Friend Shared PassWd As String
    Friend Shared Server As String

    ' Make sure to add reference to System.Data.OracleClient
    Friend Shared myOracleDataAdapter As New System.Data.OracleClient.OracleDataAdapter
    Friend Shared myOracleCommand As New System.Data.OracleClient.OracleCommand
    Friend Shared myOracleConnection As New System.Data.OracleClient.OracleConnection
    Friend Shared myOracleCommandBuilder As System.Data.OracleClient.OracleCommandBuilder

    Friend Shared myTable As New System.Data.DataTable

    Public Shared Sub LogInAtRunTime()

      'UserName = "yangq"
      'PassWd = "CS3630"
      'Server = "EDDB"

        myOracleConnection.ConnectionString = "user id=" & UserName & ";data source=" & Server &
                                              ";password=" & PassWd & ";persist security info=False"

        myOracleCommand.CommandType = CommandType.Text
        myOracleCommand.CommandText = "Select * from booking"
        myOracleCommand.Connection = myOracleConnection

        myOracleDataAdapter.SelectCommand = myOracleCommand
        myOracleCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(myOracleDataAdapter)

        myOracleDataAdapter.Fill(myTable)
    End Sub

    Public Shared Sub main()
      'LogInAtRunTime()

      Application.Run(New Form2)

    End Sub
End Class
