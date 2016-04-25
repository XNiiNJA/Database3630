Public Class Form1


   Dim stringValCols = New String() {"Hotel_No", "Guest_No", "Room_No"}

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      ' Binding it to myTable
      DataGridView1.DataSource = Oracle.myTable
   End Sub

   Private Sub cboField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboField.SelectedIndexChanged

   End Sub
   ' Update
   Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
      Try
         Me.BindingContext(Oracle.myTable).EndCurrentEdit()
         Oracle.myOracleDataAdapter.Update(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

      If (Array.IndexOf(stringValCols, cboField.Text) > -1) Then

         Oracle.myOracleCommand.CommandText = _
                    "Select * " & _
                    "From Booking " & _
                    "Where " & cboField.Text & cboOperator.Text & " '" & txtValue.Text & "'"
      Else
         Oracle.myOracleCommand.CommandText = _
                       "Select * " & _
                       "From Booking " & _
                       "Where " & cboField.Text & cboOperator.Text & "to_Date('" & txtValue.Text & "', 'mm/dd/yyyy')"
      End If

      Try
         Oracle.myTable.Clear()
         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try

   End Sub

   Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click


      Oracle.myOracleCommand.CommandText = "Select * from booking"

      Try
         Oracle.myTable.Clear()
         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try

   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      Close()
   End Sub
End Class
