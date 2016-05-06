Public Class Form2

    Private staffBindingSource As New BindingSource
    Private qualsBindingSource As New BindingSource
   Private workExpBindingSource As New BindingSource
   Private allButtons As New List(Of System.Windows.Forms.Button)

   Private staffDataView As New DataView()
   Private qualsDataView As New DataView()
   Private workExpDataView As New DataView()




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      'data bindings for staff table

      staffDataView.Table = Oracle.staffTable
      staffBindingSource.DataSource = staffDataView


      staffnoTxt.DataBindings.Add("Text", staffBindingSource, "staffNo")
      fnameTxt.DataBindings.Add("Text", staffBindingSource, "fName")
      lnameTxt.DataBindings.Add("Text", staffBindingSource, "lName")
      streetTxt.DataBindings.Add("Text", staffBindingSource, "street")
      cityTxt.DataBindings.Add("Text", staffBindingSource, "city")
      stateTxt.DataBindings.Add("Text", staffBindingSource, "state")
      zipTxt.DataBindings.Add("Text", staffBindingSource, "zip")
      phoneTxt.DataBindings.Add("Text", staffBindingSource, "phone")
      genderTxt.DataBindings.Add("Text", staffBindingSource, "gender")
      ninTxt.DataBindings.Add("Text", staffBindingSource, "NIN")
      empInfoPositionTxt.DataBindings.Add("Text", staffBindingSource, "position")
      cursalTxt.DataBindings.Add("Text", staffBindingSource, "curSalary")
      salscaleTxt.DataBindings.Add("Text", staffBindingSource, "salaryScale")
      hrsperwkTxt.DataBindings.Add("Text", staffBindingSource, "hrsPerWk")
      pospermtempTxt.DataBindings.Add("Text", staffBindingSource, "posPermTemp")
      typepayTxt.DataBindings.Add("Text", staffBindingSource, "typeOfPay")
      dtpDOB.DataBindings.Add("Value", staffBindingSource, "DOB")


      qualsDataView.Table = Oracle.qualsTable
      qualsBindingSource.DataSource = qualsDataView

      qualtypeTxt.DataBindings.Add("Text", qualsBindingSource, "type")
      instnameTxt.DataBindings.Add("Text", qualsBindingSource, "instName")
      dtpQualdate.DataBindings.Add("Value", qualsBindingSource, "qualDate")



      workExpDataView.Table = Oracle.workExpTable
      workExpBindingSource.DataSource = workExpDataView

      orgnameTxt.DataBindings.Add("Text", workExpBindingSource, "orgName")
      workExpPositionTxt.DataBindings.Add("Text", workExpBindingSource, "position")
      dtpStartDate.DataBindings.Add(New Binding("Value", workExpBindingSource, "startDate"))
      dtpEndDate.DataBindings.Add(New Binding("Value", workExpBindingSource, "finishDate"))

      populateButtonList()

      updateCounts()

    End Sub

   Private Sub populateButtonList()

      allButtons.Add(empInfoDeleteBtn)
      allButtons.Add(empInfoFirstPageBtn)
      allButtons.Add(empInfoLastPageBtn)
      allButtons.Add(empInfoNewBtn)
      allButtons.Add(empInfoNextPageBtn)
      allButtons.Add(empInfoPrevPageBtn)
      allButtons.Add(empInfoSaveBtn)

      allButtons.Add(workExpDeleteBtn)
      allButtons.Add(workExpFirstPageBtn)
      allButtons.Add(workExpLastPageBtn)
      allButtons.Add(workExpNewBtn)
      allButtons.Add(workExpNextPageBtn)
      allButtons.Add(workExpPrevPageBtn)
      allButtons.Add(workExpSaveBtn)

      allButtons.Add(qualsDeleteBtn)
      allButtons.Add(qualsFirstPageBtn)
      allButtons.Add(qualsLastPageBtn)
      allButtons.Add(qualsNewBtn)
      allButtons.Add(qualsNextPageBtn)
      allButtons.Add(qualsPrevPageBtn)
      allButtons.Add(qualsSaveBtn)

      allButtons.Add(exitBtn)
      allButtons.Add(searchBtn)

   End Sub

   Private Sub DisableAllBtnExcept(list As List(Of System.Windows.Forms.Button))

      For Each btn In allButtons
         If list.Contains(btn) Then

            btn.Enabled = True

         Else

            btn.Enabled = False

         End If
      Next


   End Sub

   Private Sub EnableAllBtn()

      For Each btn In allButtons
         btn.Enabled = True
      Next

   End Sub

   Private Sub empInfoFirstPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoFirstPageBtn.Click
      staffBindingSource.MoveFirst()

      updateCounts()

   End Sub

   Private Sub empInfoPrevPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoPrevPageBtn.Click
      staffBindingSource.MovePrevious()

      updateCounts()

   End Sub

   Private Sub empInfoNextPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoNextPageBtn.Click
      staffBindingSource.MoveNext()

      updateCounts()

   End Sub

   Private Sub empInfoLastPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoLastPageBtn.Click
      staffBindingSource.MoveLast()

      updateCounts()

   End Sub

   Private Sub qualsFirstPageBtn_Click(sender As Object, e As EventArgs) Handles qualsFirstPageBtn.Click
      qualsBindingSource.MoveFirst()

      updateCounts()

   End Sub

   Private Sub qualsPrevPageBtn_Click(sender As Object, e As EventArgs) Handles qualsPrevPageBtn.Click
      qualsBindingSource.MovePrevious()

      updateCounts()

   End Sub

   Private Sub qualsNextPageBtn_Click(sender As Object, e As EventArgs) Handles qualsNextPageBtn.Click
      qualsBindingSource.MoveNext()

      updateCounts()

   End Sub

   Private Sub qualsLastPageBtn_Click(sender As Object, e As EventArgs) Handles qualsLastPageBtn.Click
      qualsBindingSource.MoveLast()

      updateCounts()

   End Sub

   Private Sub workExpFirstPageBtn_Click(sender As Object, e As EventArgs) Handles workExpFirstPageBtn.Click
      workExpBindingSource.MoveFirst()

      updateCounts()

   End Sub

   Private Sub workExpPrevPageBtn_Click(sender As Object, e As EventArgs) Handles workExpPrevPageBtn.Click
      workExpBindingSource.MovePrevious()

      updateCounts()

   End Sub

   Private Sub workExpNextPageBtn_Click(sender As Object, e As EventArgs) Handles workExpNextPageBtn.Click
      workExpBindingSource.MoveNext()

      updateCounts()

   End Sub

   Private Sub workExpLastPageBtn_Click(sender As Object, e As EventArgs) Handles workExpLastPageBtn.Click
      workExpBindingSource.MoveLast()

      updateCounts()

   End Sub

   Private Sub updateEmpInfoDatabase()

      Try
         staffBindingSource.EndEdit()
         Oracle.staffAdapter.Update(Oracle.staffTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub empInfoSaveBtn_Click(sender As Object, e As EventArgs) Handles empInfoSaveBtn.Click

      updateEmpInfoDatabase()

      EnableAllBtn()

      updateCounts()

   End Sub

   Private Sub empInfoNewBtn_Click(sender As Object, e As EventArgs) Handles empInfoNewBtn.Click
      'disable qualifications, workexperience, and navigation buttons


      Dim r As DataRow

      r = Oracle.staffTable.NewRow
      Oracle.staffTable.Rows.Add(r)
      ' The new row is added at the end
      staffBindingSource.MoveLast()

      empInfoPageNumTxt.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count


      updateCounts()

      'Keep Save and Delete Button enabled
      Dim enableList As New List(Of System.Windows.Forms.Button)
      enableList.Add(empInfoDeleteBtn)
      enableList.Add(empInfoSaveBtn)
      DisableAllBtnExcept(enableList)


   End Sub

   Private Sub empInfoDeleteBtn_Click(sender As Object, e As EventArgs) Handles empInfoDeleteBtn.Click
      Try
         staffBindingSource.RemoveCurrent()
         empInfoPageNumTxt.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      updateEmpInfoDatabase()

      EnableAllBtn()

      updateCounts()

   End Sub

   Private Sub updateQualsDatabase()

      Try
         qualsBindingSource.EndEdit()
         Oracle.qualsAdapter.Update(Oracle.qualsTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub qualsSaveBtn_Click(sender As Object, e As EventArgs) Handles qualsSaveBtn.Click

      updateQualsDatabase()

      EnableAllBtn()

      updateCounts()

   End Sub

   Private Sub qualsNewBtn_Click(sender As Object, e As EventArgs) Handles qualsNewBtn.Click

      Dim r As DataRowView

      r = qualsBindingSource.AddNew

      r(0) = staffnoTxt.Text

      qualsBindingSource.MoveLast()

      updateCounts()

      'disable staff, workexperience, and navigation buttons
      'Keep Save and Delete Button enabled

      Dim enableList As New List(Of System.Windows.Forms.Button)
      enableList.Add(qualsDeleteBtn)
      enableList.Add(qualsSaveBtn)
      DisableAllBtnExcept(enableList)

   End Sub

   Private Sub qualsDeleteBtn_Click(sender As Object, e As EventArgs) Handles qualsDeleteBtn.Click
      Try
         qualsBindingSource.RemoveCurrent()
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      updateQualsDatabase()

      EnableAllBtn()

      updateCounts()

   End Sub

   Private Sub updateWorkExpDatabase()

      Try
         workExpBindingSource.EndEdit()
         Oracle.workExpAdapter.Update(Oracle.workExpTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub workExpSaveBtn_Click(sender As Object, e As EventArgs) Handles workExpSaveBtn.Click

      updateWorkExpDatabase()

      EnableAllBtn()

      updateCounts()

   End Sub

   Private Sub workExpNewBtn_Click(sender As Object, e As EventArgs) Handles workExpNewBtn.Click


      Dim r As DataRow

      r = Oracle.workExpTable.NewRow
      Oracle.workExpTable.Rows.Add(r)
      ' The new row is added at the end
      workExpBindingSource.MoveLast()

      workExpPageNumTxt.Text = (workExpBindingSource.Position + 1) & "/" & workExpBindingSource.Count

      updateCounts()

      'Keep Save and Delete Button enabled
      Dim enableList As New List(Of System.Windows.Forms.Button)
      enableList.Add(workExpDeleteBtn)
      enableList.Add(workExpSaveBtn)
      DisableAllBtnExcept(enableList)

   End Sub

   Private Sub workExpDeleteBtn_Click(sender As Object, e As EventArgs) Handles workExpDeleteBtn.Click

      Try
         workExpBindingSource.RemoveCurrent()
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      updateWorkExpDatabase()

      EnableAllBtn()

      updateCounts()

   End Sub

   Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
      Close()
   End Sub


   Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)

      MyBase.OnPaint(e)

   End Sub


   Private Sub updateQualifications()

      qualsDataView.RowFilter = "staffNo = '" & staffnoTxt.Text & "'"

      If qualsBindingSource.Position + 1 = qualsBindingSource.Count Then

         qualsNextPageBtn.Enabled = False
         qualsLastPageBtn.Enabled = False

      Else

         qualsNextPageBtn.Enabled = True
         qualsLastPageBtn.Enabled = True

      End If

      If qualsBindingSource.Position <= 0 Then

         qualsPrevPageBtn.Enabled = False
         qualsFirstPageBtn.Enabled = False

      Else

         qualsPrevPageBtn.Enabled = True
         qualsFirstPageBtn.Enabled = True

      End If

   End Sub

   Private Sub updateWorkExp()

      workExpDataView.RowFilter = "staffNo = '" & staffnoTxt.Text & "'"

      If workExpBindingSource.Position + 1 = workExpBindingSource.Count Then

         workExpNextPageBtn.Enabled = False
         workExpLastPageBtn.Enabled = False

      Else

         workExpNextPageBtn.Enabled = True
         workExpLastPageBtn.Enabled = True

      End If

      If workExpBindingSource.Position <= 0 Then

         workExpPrevPageBtn.Enabled = False
         workExpFirstPageBtn.Enabled = False

      Else

         workExpPrevPageBtn.Enabled = True
         workExpFirstPageBtn.Enabled = True

      End If

   End Sub

   Private Sub updateEmpInfo()

      If staffBindingSource.Position + 1 = staffBindingSource.Count Then

         empInfoNextPageBtn.Enabled = False
         empInfoLastPageBtn.Enabled = False

      Else

         empInfoNextPageBtn.Enabled = True
         empInfoLastPageBtn.Enabled = True

      End If

      If staffBindingSource.Position <= 0 Then

         empInfoPrevPageBtn.Enabled = False
         empInfoFirstPageBtn.Enabled = False

      Else

         empInfoPrevPageBtn.Enabled = True
         empInfoFirstPageBtn.Enabled = True

      End If

   End Sub

   Private Sub updateCounts()


      updateQualifications()

      updateWorkExp()

      updateEmpInfo()

      qualsPageNumTxt.Text = (qualsBindingSource.Position + 1) & "/" & qualsBindingSource.Count

      workExpPageNumTxt.Text = (workExpBindingSource.Position + 1) & "/" & workExpBindingSource.Count

      empInfoPageNumTxt.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count

   End Sub



   Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click

      Oracle.staffCommand.CommandText = "Select * From UWP_WorkExperience E join UWP_Staff S on S.staffNo = E.staffNo and E.orgName = '" & valueTxt.Text & "'"

      Oracle.staffTable.Clear()
      Oracle.staffAdapter.Fill(Oracle.staffTable)

      '      Select * From UWP_WorkExperience E join UWP_Staff S on S.staffNo = E.staffNo and E.orgName = 'Southwest Hospital';


   End Sub
End Class
