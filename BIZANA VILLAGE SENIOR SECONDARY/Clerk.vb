Public Class Clerk
    Dim B1 As New BizanaSenior
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmHOMEPAGE.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

        Dim res As String
        Dim ds As New DataSet

        res = B1.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404", "no connection to database")

        Else
            ds = B1.GetMSFinal()

            DataGridView1.DataSource = ds.Tables("dtMathsandScienceFinal")

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

        Dim res As String
        Dim ds As New DataSet

        res = B1.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404!", "No connection to database")

        Else
            ds = B1.GetCormFinal()

            Me.DataGridView1.DataSource = ds.Tables("dtCommerceFinal")

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

        Dim res As String
        Dim ds As New DataSet

        res = B1.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404", "no connection to database")

        Else
            ds = B1.GetAllHistory()

            Me.DataGridView1.DataSource = ds.Tables("dtHistoryFinal")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim res As String
        Dim dsy As New DataSet

        res = B1.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404", "No connection to database")

        Else
            dsy = B1.GetSById(txtId.Text)


            Me.DataGridView1.DataSource = dsy.Tables("dtMathsandScienceFinal")
        End If

        '  Dim res As String
        '  Dim ds As New DataSet

        '  res = B1.getConnection()

        '   If res <> "True" Then
        'MsgBox("error", "no connection to database")

        '  Else
        '  ds = B1.GetStuByID(txtId.Text)

        'If ds.Tables("Maths and Science Final").Rows.Count = 0 Then
        'MsgBox("no values in the database")

        ' Else
        '  DataGridView1.DataSource = ds.Tables("MathsandScienceFinal")
        ' End If
        '  End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim result, delete As String

        result = B1.getConnection()
        If result = "True" Then

            delete = B1.GetDeleteStu(txtId.Text)
            If delete = "true" Then
                If (DialogResult.Yes = MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                    MessageBox.Show(" Employee deleted successfully", "DELETED")
                Else
                    Panel2.Visible = True
                    Exit Sub
                End If
            Else
                MessageBox.Show("ERROR", "Error has occurred in Delete Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub Clerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel7.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Panel7.Visible = True
        Panel9.Visible = False
        Panel14.Visible = False
    End Sub

    Private Sub mat_Click(sender As Object, e As EventArgs)
        Dim result, resUpdate As String

        result = B1.getConnection()
        If result = "true" Then

            resUpdate = B1.UpdateTestsMaths(ComboBox1.SelectedItem, t1m.Text, t2m.Text, t3m.Text, t4m.Text, am.Text)
            If resUpdate = "true" Then
                MessageBox.Show("Updated successfully", "The maths marks  has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("SOORY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Panel9.Visible = True
        Panel7.Visible = False
        Panel14.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        frmHOMEPAGE.Show()


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Panel14.Visible = True
        Panel9.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Phy_Click(sender As Object, e As EventArgs)
        Dim result, resUpdate As String

        result = B1.getConnection()
        If result = "True" Then

            resUpdate = B1.UpdateTestsPhysics(ComboBox1.SelectedItem, t1p.Text, t2p.Text, t3p.Text, t4p.Text, ap.Text)

            If resUpdate = "true" Then
                MessageBox.Show("Updated successfully", "The physics marks has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("SORRY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub
    Private Sub hit_Click(sender As Object, e As EventArgs)
        Dim result, resUpdate As String

        result = B1.getConnection()
        If result = "true" Then

            resUpdate = B1.UpdateTestsHistory(ComboBox1.SelectedItem, t1h.Text, t2h.Text, t3h.Text, t4h.Text, ah.Text)
            If resUpdate = "true" Then
                MessageBox.Show("Updated successfully", "The history marks has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("SORRY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub radAcc_CheckedChanged(sender As Object, e As EventArgs)
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsA()



            Dim count As Integer
            For count = 0 To ds.Tables("dtAccounting").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtAccounting").Rows(count).Item("ID"))
            Next



        End If
    End Sub

    Private Sub radP_CheckedChanged(sender As Object, e As EventArgs)
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsP()


            Dim count As Integer
            For count = 0 To ds.Tables("dtPhysicalScience").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtPhysicalScience").Rows(count).Item("ID"))
            Next

        End If
    End Sub

    Private Sub radH_CheckedChanged(sender As Object, e As EventArgs)
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsH()

            Dim count As Integer
            For count = 0 To ds.Tables("dtHistory").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtHistory").Rows(count).Item("ID"))
            Next

        End If
    End Sub

    Private Sub radM_CheckedChanged(sender As Object, e As EventArgs)
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsM()

            Dim count As Integer
            For count = 0 To ds.Tables("dtMathematics").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtMathematics").Rows(count).Item("ID"))
            Next

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        If (IsNumeric(t2m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t3m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t1m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(t4m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t2m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t1m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t4m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If

        am.Text = CStr(((CDbl(t2m.Text)) + (CDbl(t3m.Text)) + (CDbl(t1m.Text)) + (CDbl(t4m.Text))) / 4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        If (IsNumeric(t4p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t3p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t1p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(t2p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t4p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t2p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t1p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        ap.Text = CStr(((CDbl(t4p.Text)) + (CDbl(t3p.Text)) + (CDbl(t2p.Text)) + (CDbl(t1p.Text))) / 4)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        If (IsNumeric(t4a.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t3a.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t2a.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(ah.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t4a.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3a.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t2a.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If ah.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        aa.Text = CStr(((CDbl(t4a.Text)) + (CDbl(t3a.Text)) + (CDbl(t2a.Text)) + (CDbl(ah.Text))) / 4)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        If (IsNumeric(t1h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t2h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t3h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(t4h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t4h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t2h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t1h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        ah.Text = CStr(((CDbl(t4h.Text)) + (CDbl(t3h.Text)) + (CDbl(t2h.Text)) + (CDbl(t1h.Text))) / 4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Dispose()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub radP_CheckedChanged_1(sender As Object, e As EventArgs) Handles radP.CheckedChanged
        mat.Enabled = False
        hit.Enabled = False
        Phy.Enabled = True
        acc.Enabled = False
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsP()


            Dim count As Integer
            For count = 0 To ds.Tables("dtPhysicalScience").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtPhysicalScience").Rows(count).Item("ID"))
            Next

        End If
    End Sub

    Private Sub radAcc_CheckedChanged_1(sender As Object, e As EventArgs) Handles radAcc.CheckedChanged
        mat.Enabled = False
        hit.Enabled = False
        Phy.Enabled = False
        acc.Enabled = True
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsA()



            Dim count As Integer
            For count = 0 To ds.Tables("dtAccounting").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtAccounting").Rows(count).Item("ID") + "-" + ds.Tables("dtAccounting").Rows(count).Item("Grade"))
            Next



        End If
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        If (IsNumeric(t4a.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t3a.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t2a.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t4a.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3a.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t2a.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        aa.Text = CStr(((CDbl(t4a.Text)) + (CDbl(t3a.Text)) + (CDbl(t2a.Text)) + (CDbl(t1a.Text))) / 4)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As String
        Dim dsy As New DataSet

        res = B1.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404", "No connection to database")

        Else
            dsy = B1.GetSById(txtId.Text)
            Me.DataGridView1.DataSource = dsy.Tables("dtMathsandScienceFinal")
        End If
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Dim result, delete As String

        result = B1.getConnection()
        If result = "True" Then

            delete = B1.GetDeleteStu(txtId.Text)
            If delete = "true" Then
                If (DialogResult.Yes = MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) Then
                    MessageBox.Show(" Student deleted successfully", "DELETED")
                Else
                    Panel2.Visible = True
                    Exit Sub
                End If
            Else
                MessageBox.Show("ERROR", "Error has occurred in Delete Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetMSFinal()

            Me.DataGridView1.DataSource = ds.Tables("dtMathsandScienceFinal")

        End If
    End Sub

    Private Sub radH_CheckedChanged_1(sender As Object, e As EventArgs) Handles radH.CheckedChanged
        mat.Enabled = False
        hit.Enabled = True
        Phy.Enabled = False
        acc.Enabled = False
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsH()

            Dim count As Integer
            For count = 0 To ds.Tables("dtHistory").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtHistory").Rows(count).Item("ID"))
            Next

        End If
    End Sub

    Private Sub radM_CheckedChanged_1(sender As Object, e As EventArgs) Handles radM.CheckedChanged
        mat.Enabled = True
        hit.Enabled = False
        Phy.Enabled = False
        acc.Enabled = False
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllIdsM()

            Dim count As Integer
            For count = 0 To ds.Tables("dtMathematics").Rows.Count - 1
                ComboBox1.Items.Add(ds.Tables("dtMathematics").Rows(count).Item("ID"))
            Next

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetCormFinal()

            Me.DataGridView1.DataSource = ds.Tables("dtCommerceFinal")

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim results As String
        Dim ds As New DataSet
        results = B1.getConnection()
        If results <> "True" Then
            MsgBox("ERROR 404", "ConnectionState has failed")

        Else

            ds = B1.GetAllHistory()

            Me.DataGridView1.DataSource = ds.Tables("dtHistoryFinal")

        End If
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        If (IsNumeric(t2m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t3m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t1m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(t4m.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t2m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t1m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t4m.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If

        am.Text = CStr(((CDbl(t2m.Text)) + (CDbl(t3m.Text)) + (CDbl(t1m.Text)) + (CDbl(t4m.Text))) / 4)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If (IsNumeric(t1h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t2h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t3h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(t4h.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t4h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t2h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t1h.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        ah.Text = CStr(((CDbl(t4h.Text)) + (CDbl(t3h.Text)) + (CDbl(t2h.Text)) + (CDbl(t1h.Text))) / 4)
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        If (IsNumeric(t4p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()
        End If

        If (IsNumeric(t3p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If

        If (IsNumeric(t1p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If (IsNumeric(t2p.Text)) = False Then
            MsgBox("numbers only")
            t2m.Clear()
            t2m.Focus()

        End If
        If t4p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t3p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t2p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        If t1p.Text < 0 Then
            MsgBox("Must greater than zero")
            t2m.Clear()
            t2m.Focus()
        End If
        ap.Text = CStr(((CDbl(t4p.Text)) + (CDbl(t3p.Text)) + (CDbl(t2p.Text)) + (CDbl(t1p.Text))) / 4)
    End Sub

    Private Sub mat_Click_1(sender As Object, e As EventArgs) Handles mat.Click
        Dim result, resUpdate As String

        result = B1.getConnection()
        If result = "True" Then

            resUpdate = B1.UpdateTestsMaths(ComboBox1.SelectedItem, t1m.Text, t2m.Text, t3m.Text, t4m.Text, am.Text)
            If resUpdate = "true" Then
                MessageBox.Show("Updated successfully", "The maths marks  has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("SOORY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub Phy_Click_1(sender As Object, e As EventArgs) Handles Phy.Click
        Dim result, resUpdate As String

        result = B1.getConnection()
        If result = "True" Then

            resUpdate = B1.UpdateTestsPhysics(ComboBox1.SelectedItem, t1p.Text, t2p.Text, t3p.Text, t4p.Text, ap.Text)

            If resUpdate = "true" Then
                MessageBox.Show("Updated successfully", "The physics marks has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("SORRY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub acc_Click_1(sender As Object, e As EventArgs) Handles acc.Click
        Dim result, resUp As String

        result = B1.getConnection()
        If result = "True" Then

            resUp = B1.UpdateTestsAccounting(ComboBox1.Text.Substring(0, 12), ComboBox1.Text.Substring(14, 2), t1a.Text, t2a.Text, t3a.Text, t4a.Text, aa.Text)
            If resUp = " True" Then
                MessageBox.Show("Updated successfully", "The accounting marks has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else
                MessageBox.Show("SORRY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub hit_Click_1(sender As Object, e As EventArgs) Handles hit.Click
        Dim result, resUpdate As String

        result = B1.getConnection()
        If result = "True" Then

            resUpdate = B1.UpdateTestsHistory(ComboBox1.SelectedItem, t1h.Text, t2h.Text, t3h.Text, t4h.Text, ah.Text)
            If resUpdate = "true" Then
                MessageBox.Show("Updated successfully", "The history marks has been successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("SORRY THERE IS AN ERROR", "Error has occurred in update Process", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MsgBox("ERROR 404", "Error has occured in connection")
            Exit Sub
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox3.Text = ""
        TextBox8.Clear()
        TextBox2.Focus()
        ComboBox2.Text = ""

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        frmHOMEPAGE.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox2.Text = "" Then
            MsgBox("Please enter surname")

            TextBox2.Focus()
            Return
        End If
        If TextBox3.Text = "" Then
            MsgBox("Please enter name")
            TextBox3.Focus()
            Return
        End If
        If IsNumeric(TextBox4.Text.Trim) = False Then
            MsgBox("Id number must be number only")
            TextBox4.Focus()
            Return
        End If
        If (TextBox4.Text.Trim.Length) <> 13 Then
            MsgBox("Id must be 13 digits exactly")
            TextBox4.Focus()
            Return
        End If
        If ComboBox3.Text = "" Then
            MsgBox("Please enter gender")
            ComboBox3.Focus()
            Return

        End If
        If IsNumeric(TextBox8.Text.Trim) = False Then
            MsgBox("Grade number must be number only")
            TextBox8.Focus()
            Return
        End If
        If (TextBox8.Text.Trim.Length) <> 2 Then
            MsgBox("Grade must be 2digits exactly")
            TextBox8.Focus()
            Return
        End If
        If ComboBox2.Text = "" Then
            MsgBox("Please select stream")
            ComboBox2.Focus()
            Return

        End If
        Dim result As String
        Dim res As String
        result = B1.getConnection()
        If result = "True" Then
            res = B1.AddLearner(TextBox4.Text, TextBox2.Text, TextBox3.Text, ComboBox3.Text, TextBox8.Text, ComboBox2.Text)
            If res = "True" Then
                MsgBox("Learner added succesfully")
            Else
                MsgBox("Error has occured when adding learner")

            End If
        Else

            MessageBox.Show(result, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class