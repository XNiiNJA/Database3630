Public Class Form2

    Private staffBindingSource As New BindingSource
    Private qualsBindingSource As New BindingSource
    Private workExpBindingSource As New BindingSource

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'data bindings for staff table
        staffBindingSource.DataSource = Oracle.staffTable

        staffnoTxt.DataBindings.Add("Text", Oracle.staffTable, "staffNo")
        fnameTxt.DataBindings.Add("Text", Oracle.staffTable, "fName")
        lnameTxt.DataBindings.Add("Text", Oracle.staffTable, "lName")
        streetTxt.DataBindings.Add("Text", Oracle.staffTable, "street")
        cityTxt.DataBindings.Add("Text", Oracle.staffTable, "city")
        stateTxt.DataBindings.Add("Text", Oracle.staffTable, "state")
        zipTxt.DataBindings.Add("Text", Oracle.staffTable, "zip")
        phoneTxt.DataBindings.Add("Text", Oracle.staffTable, "phone")
        genderTxt.DataBindings.Add("Text", Oracle.staffTable, "gender")
        ninTxt.DataBindings.Add("Text", Oracle.staffTable, "NIN")
        empInfoPositionTxt.DataBindings.Add("Text", Oracle.staffTable, "position")
        cursalTxt.DataBindings.Add("Text", Oracle.staffTable, "curSalary")
        salscaleTxt.DataBindings.Add("Text", Oracle.staffTable, "salaryScale")
        hrsperwkTxt.DataBindings.Add("Text", Oracle.staffTable, "hrsPerWk")
        pospermtempTxt.DataBindings.Add("Text", Oracle.staffTable, "posPermTemp")
        typepayTxt.DataBindings.Add("Text", Oracle.staffTable, "typeOfPay")

        'data bindings for qualifications table
        qualsBindingSource.DataSource = Oracle.qualsTable

        qualtypeTxt.DataBindings.Add("Text", Oracle.qualsTable, "type")
        instnameTxt.DataBindings.Add("Text", Oracle.qualsTable, "instName")

        'data bindings for workexperience table
        workExpBindingSource.DataSource = Oracle.workExpTable

        orgnameTxt.DataBindings.Add("Text", Oracle.workExpTable, "orgName")
        workExpPositionTxt.DataBindings.Add("Text", Oracle.workExpTable, "position")

    End Sub

    Private Sub empInfoFirstPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoFirstPageBtn.Click
        staffBindingSource.MoveFirst()
    End Sub

    Private Sub empInfoPrevPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoPrevPageBtn.Click
        staffBindingSource.MovePrevious()
    End Sub

    Private Sub empInfoNextPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoNextPageBtn.Click
        staffBindingSource.MoveNext()
    End Sub

    Private Sub empInfoLastPageBtn_Click(sender As Object, e As EventArgs) Handles empInfoLastPageBtn.Click
        staffBindingSource.MoveLast()
    End Sub

    Private Sub qualsFirstPageBtn_Click(sender As Object, e As EventArgs) Handles qualsFirstPageBtn.Click
        qualsBindingSource.MoveFirst()
    End Sub

    Private Sub qualsPrevPageBtn_Click(sender As Object, e As EventArgs) Handles qualsPrevPageBtn.Click
        qualsBindingSource.MovePrevious()
    End Sub

    Private Sub qualsNextPageBtn_Click(sender As Object, e As EventArgs) Handles qualsNextPageBtn.Click
        qualsBindingSource.MoveNext()
    End Sub

    Private Sub qualsLastPageBtn_Click(sender As Object, e As EventArgs) Handles qualsLastPageBtn.Click
        qualsBindingSource.MoveLast()
    End Sub

    Private Sub workExpFirstPageBtn_Click(sender As Object, e As EventArgs) Handles workExpFirstPageBtn.Click
        workExpBindingSource.MoveFirst()
    End Sub

    Private Sub workExpPrevPageBtn_Click(sender As Object, e As EventArgs) Handles workExpPrevPageBtn.Click
        workExpBindingSource.MovePrevious()
    End Sub

    Private Sub workExpNextPageBtn_Click(sender As Object, e As EventArgs) Handles workExpNextPageBtn.Click
        workExpBindingSource.MoveNext()
    End Sub

    Private Sub workExpLastPageBtn_Click(sender As Object, e As EventArgs) Handles workExpLastPageBtn.Click
        workExpBindingSource.MoveLast()
    End Sub

    Private Sub empInfoPageNumTxt_TextChanged(sender As Object, e As EventArgs) Handles empInfoPageNumTxt.TextChanged
        empInfoPageNumTxt.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
    End Sub

    Private Sub qualsPageNumTxt_TextChanged(sender As Object, e As EventArgs) Handles qualsPageNumTxt.TextChanged
        qualsPageNumTxt.Text = (qualsBindingSource.Position + 1) & "/" & qualsBindingSource.Count
    End Sub

    Private Sub workExpPageNumTxt_TextChanged(sender As Object, e As EventArgs) Handles workExpPageNumTxt.TextChanged
        workExpPageNumTxt.Text = (workExpBindingSource.Position + 1) & "/" & workExpBindingSource.Count
    End Sub

    Private Sub empInfoSaveBtn_Click(sender As Object, e As EventArgs) Handles empInfoSaveBtn.Click
        Try
            staffBindingSource.EndEdit()
            Oracle.staffAdapter.Update(Oracle.staffTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub empInfoNewBtn_Click(sender As Object, e As EventArgs) Handles empInfoNewBtn.Click
        'disable qualifications, workexperience, and navigation buttons
        qualsNewBtn.Enabled = False
        qualsSaveBtn.Enabled = False
        qualsDeleteBtn.Enabled = False
        workExpNewBtn.Enabled = False
        workExpSaveBtn.Enabled = False
        workExpDeleteBtn.Enabled = False
        empInfoFirstPageBtn.Enabled = False
        empInfoPrevPageBtn.Enabled = False
        empInfoNextPageBtn.Enabled = False
        empInfoLastPageBtn.Enabled = False
        qualsFirstPageBtn.Enabled = False
        qualsPrevPageBtn.Enabled = False
        qualsNextPageBtn.Enabled = False
        qualsLastPageBtn.Enabled = False
        workExpFirstPageBtn.Enabled = False
        workExpPrevPageBtn.Enabled = False
        workExpNextPageBtn.Enabled = False
        workExpLastPageBtn.Enabled = False

        Dim r As DataRow

        r = Oracle.staffTable.NewRow
        Oracle.staffTable.Rows.Add(r)
        ' The new row is added at the end
        staffBindingSource.MoveLast()

        empInfoPageNumTxt.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count

        'enable qualifications, workexperience, and navigation buttons
        qualsNewBtn.Enabled = True
        qualsSaveBtn.Enabled = True
        qualsDeleteBtn.Enabled = True
        workExpNewBtn.Enabled = True
        workExpSaveBtn.Enabled = True
        workExpDeleteBtn.Enabled = True
        empInfoFirstPageBtn.Enabled = True
        empInfoPrevPageBtn.Enabled = True
        empInfoNextPageBtn.Enabled = True
        empInfoLastPageBtn.Enabled = True
        qualsFirstPageBtn.Enabled = True
        qualsPrevPageBtn.Enabled = True
        qualsNextPageBtn.Enabled = True
        qualsLastPageBtn.Enabled = True
        workExpFirstPageBtn.Enabled = True
        workExpPrevPageBtn.Enabled = True
        workExpNextPageBtn.Enabled = True
        workExpLastPageBtn.Enabled = True
    End Sub

    Private Sub empInfoDeleteBtn_Click(sender As Object, e As EventArgs) Handles empInfoDeleteBtn.Click
        Try
            staffBindingSource.RemoveCurrent()
            empInfoPageNumTxt.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub qualsSaveBtn_Click(sender As Object, e As EventArgs) Handles qualsSaveBtn.Click
        Try
            qualsBindingSource.EndEdit()
            Oracle.qualsAdapter.Update(Oracle.qualsTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub qualsNewBtn_Click(sender As Object, e As EventArgs) Handles qualsNewBtn.Click
        'disable staff, workexperience, and navigation buttons
        empInfoNewBtn.Enabled = False
        empInfoSaveBtn.Enabled = False
        empInfoDeleteBtn.Enabled = False
        workExpNewBtn.Enabled = False
        workExpSaveBtn.Enabled = False
        workExpDeleteBtn.Enabled = False
        empInfoFirstPageBtn.Enabled = False
        empInfoPrevPageBtn.Enabled = False
        empInfoNextPageBtn.Enabled = False
        empInfoLastPageBtn.Enabled = False
        qualsFirstPageBtn.Enabled = False
        qualsPrevPageBtn.Enabled = False
        qualsNextPageBtn.Enabled = False
        qualsLastPageBtn.Enabled = False
        workExpFirstPageBtn.Enabled = False
        workExpPrevPageBtn.Enabled = False
        workExpNextPageBtn.Enabled = False
        workExpLastPageBtn.Enabled = False

        Dim r As DataRow

        r = Oracle.qualsTable.NewRow
        Oracle.qualsTable.Rows.Add(r)
        ' The new row is added at the end
        qualsBindingSource.MoveLast()

        qualsPageNumTxt.Text = (qualsBindingSource.Position + 1) & "/" & qualsBindingSource.Count

        'enable staff, workexperience, and navigation buttons
        empInfoNewBtn.Enabled = True
        empInfoSaveBtn.Enabled = True
        empInfoDeleteBtn.Enabled = True
        workExpNewBtn.Enabled = True
        workExpSaveBtn.Enabled = True
        workExpDeleteBtn.Enabled = True
        empInfoFirstPageBtn.Enabled = True
        empInfoPrevPageBtn.Enabled = True
        empInfoNextPageBtn.Enabled = True
        empInfoLastPageBtn.Enabled = True
        qualsFirstPageBtn.Enabled = True
        qualsPrevPageBtn.Enabled = True
        qualsNextPageBtn.Enabled = True
        qualsLastPageBtn.Enabled = True
        workExpFirstPageBtn.Enabled = True
        workExpPrevPageBtn.Enabled = True
        workExpNextPageBtn.Enabled = True
        workExpLastPageBtn.Enabled = True
    End Sub

    Private Sub qualsDeleteBtn_Click(sender As Object, e As EventArgs) Handles qualsDeleteBtn.Click
        Try
            qualsBindingSource.RemoveCurrent()
            qualsPageNumTxt.Text = (qualsBindingSource.Position + 1) & "/" & qualsBindingSource.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub workExpSaveBtn_Click(sender As Object, e As EventArgs) Handles workExpSaveBtn.Click
        Try
            workExpBindingSource.EndEdit()
            Oracle.workExpAdapter.Update(Oracle.workExpTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub workExpNewBtn_Click(sender As Object, e As EventArgs) Handles workExpNewBtn.Click
        'disable staff, qualifications, and navigation buttons
        empInfoNewBtn.Enabled = False
        empInfoSaveBtn.Enabled = False
        empInfoDeleteBtn.Enabled = False
        qualsNewBtn.Enabled = False
        qualsSaveBtn.Enabled = False
        qualsDeleteBtn.Enabled = False
        empInfoFirstPageBtn.Enabled = False
        empInfoPrevPageBtn.Enabled = False
        empInfoNextPageBtn.Enabled = False
        empInfoLastPageBtn.Enabled = False
        qualsFirstPageBtn.Enabled = False
        qualsPrevPageBtn.Enabled = False
        qualsNextPageBtn.Enabled = False
        qualsLastPageBtn.Enabled = False
        workExpFirstPageBtn.Enabled = False
        workExpPrevPageBtn.Enabled = False
        workExpNextPageBtn.Enabled = False
        workExpLastPageBtn.Enabled = False

        Dim r As DataRow

        r = Oracle.workExpTable.NewRow
        Oracle.workExpTable.Rows.Add(r)
        ' The new row is added at the end
        workExpBindingSource.MoveLast()

        workExpPageNumTxt.Text = (workExpBindingSource.Position + 1) & "/" & workExpBindingSource.Count

        'enable staff, qualifications, and navigation buttons
        empInfoNewBtn.Enabled = True
        empInfoSaveBtn.Enabled = True
        empInfoDeleteBtn.Enabled = True
        qualsNewBtn.Enabled = True
        qualsSaveBtn.Enabled = True
        qualsDeleteBtn.Enabled = True
        empInfoFirstPageBtn.Enabled = True
        empInfoPrevPageBtn.Enabled = True
        empInfoNextPageBtn.Enabled = True
        empInfoLastPageBtn.Enabled = True
        qualsFirstPageBtn.Enabled = True
        qualsPrevPageBtn.Enabled = True
        qualsNextPageBtn.Enabled = True
        qualsLastPageBtn.Enabled = True
        workExpFirstPageBtn.Enabled = True
        workExpPrevPageBtn.Enabled = True
        workExpNextPageBtn.Enabled = True
        workExpLastPageBtn.Enabled = True
    End Sub

    Private Sub workExpDeleteBtn_Click(sender As Object, e As EventArgs) Handles workExpDeleteBtn.Click
        Try
            workExpBindingSource.RemoveCurrent()
            workExpPageNumTxt.Text = (workExpBindingSource.Position + 1) & "/" & workExpBindingSource.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Close()
    End Sub
End Class
