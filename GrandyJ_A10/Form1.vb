Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Binding it to myTable
        DataGridView1.DataSource = Oracle.myTable
    End Sub

    ' Update
    Private Sub Button1_Click(. . .) Handles cmdUpdate.Click
        Try
            Me.BindingContext(Oracle.myTable).EndCurrentEdit()
            Oracle.myOracleDataAdapter.Update(Oracle.myTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub cboField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboField.SelectedIndexChanged

    End Sub
End Class
