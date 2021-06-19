Public Class frmHOMEPAGE
    Dim B As New BizanaSenior
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

        PictureBox18.Visible = False
        pnlAboutF.Visible = True
        pnlLoginFF.Visible = False
        pnlHistoryF.Visible = False
        pnlGalleryF.Visible = False
        pnlLogin.Visible = True
        pnlHome.Visible = True
        pnlHistory.Visible = True
        pnlStudents.Visible = True
        pnlAbout.Visible = False
        pnlGallery.Visible = True

    End Sub
    Private Sub switchpanel(ByVal panel As Form)
        pnlAboutF.Controls.Clear()
        panel.TopLevel = False
        pnlAboutF.Controls.Add(panel)
        panel.Show()


    End Sub
    Private Sub btnGallery_Click(sender As Object, e As EventArgs) Handles btnGallery.Click
        '   switchpanel(Gallery)
        pnlStudentsF.Visible = False
        PictureBox18.Visible = False
        pnlAboutF.Visible = False
        pnlGalleryF.Visible = True
        pnlLoginFF.Visible = False
        pnlHistoryF.Visible = False
        pnlLogin.Visible = True
        pnlHome.Visible = True
        pnlHistory.Visible = True
        pnlStudents.Visible = True
        pnlAbout.Visible = True
        pnlGallery.Visible = False

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

        pnlStudentsF.Visible = False
        PictureBox18.Visible = False
        pnlAboutF.Visible = False
        pnlGalleryF.Visible = False
        pnlLoginFF.Visible = False
        pnlHistoryF.Visible = True
        pnlLogin.Visible = True
        pnlHome.Visible = True
        pnlHistory.Visible = False
        pnlStudents.Visible = True
        pnlAbout.Visible = True
        pnlGallery.Visible = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        pnlStudentsF.Visible = False
        PictureBox18.Visible = False
        pnlAboutF.Visible = False
        pnlGalleryF.Visible = False
        pnlLoginFF.Visible = True
        pnlHistoryF.Visible = False
        pnlLogin.Visible = False
        pnlHome.Visible = True
        pnlHistory.Visible = True
        pnlStudents.Visible = True
        pnlAbout.Visible = True
        pnlGallery.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        PictureBox18.Visible = True
        pnlStudentsF.Visible = False
        pnlAboutF.Visible = False
        pnlGalleryF.Visible = False
        pnlLoginFF.Visible = False
        pnlHistoryF.Visible = False
        pnlLogin.Visible = True
        pnlHome.Visible = False
        pnlHistory.Visible = True
        pnlStudents.Visible = True
        pnlAbout.Visible = True
        pnlGallery.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
        End
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        pnlStudentsF.Visible = True
        PictureBox18.Visible = False
        pnlAboutF.Visible = False
        pnlGalleryF.Visible = False
        pnlLoginFF.Visible = False
        pnlHistoryF.Visible = False
        pnlLogin.Visible = True
        pnlHome.Visible = True
        pnlHistory.Visible = True
        pnlStudents.Visible = False
        pnlAbout.Visible = True
        pnlGallery.Visible = True

    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Just go to the admin or create new account", "Soory we can't help you", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        If IsNumeric(TextBox3.Text) = False Then
            MsgBox(" Please enter valid ID")
            TextBox3.Clear()
            TextBox3.Focus()
            Return
        End If
        If (TextBox3.Text = "") Then
            MsgBox(" Please enter ID")
            TextBox3.Clear()
            TextBox3.Focus()
            Return
        End If
        If (TextBox3.Text.Length <> 13) Then
            MsgBox("Id number must be 13 digits")
            TextBox3.Clear()
            TextBox3.Focus()
            Return
        End If
        Dim res As String
        Dim dsy As New DataSet

        res = B.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404!", "No connection to database")

        Else
            dsy = B.GetStudentById(TextBox3.Text)



            Me.DataGridView2.DataSource = dsy.Tables("dtMathsandScienceFinal")

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        pnlAboutF.Show()
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("SORRY , WE CAN'T HELP YOU ", "JUST CALL DEVELOPERS ON 0781851046")
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Dim AccLev As Integer
        Dim re As String = ""
        Dim flag As Integer
        flag = 0
        Dim dsDet As New DataSet
        'VALIDATING USERNAME IS EMPTY OR NOT
        If TextBox1.Text = "" Then
            MsgBox("Please input User name")
            TextBox1.Focus()
            Return
        End If
        'VALIDATING PASSWORD IS EMPTY OR NOT
        If TextBox2.Text = "" Then
            MsgBox("Please input Password")
            TextBox2.Focus()
            Return
        End If
        'VALIDATING Job title IS EMPTY OR NOT
        If ComboBox1.Text = "" Then
            MsgBox("Please select Job Title")
            ComboBox1.Focus()
            Return
        End If
        If ComboBox1.SelectedItem = "Principal" Then
            AccLev = 2
        End If
        If ComboBox1.SelectedItem = "Deputy" Then
            AccLev = 2
        End If
        If ComboBox1.SelectedItem = "Clerk" Then
            AccLev = 1
        End If
        re = B.getConnection()
        If re = "True" Then

            dsDet = B.GetLogin()
            Dim count As Integer
            For count = 0 To dsDet.Tables("Login").Rows.Count - 1
                If (TextBox1.Text = dsDet.Tables("Login").Rows(count).Item("Surname")) Then
                    If (TextBox2.Text = dsDet.Tables("Login").Rows(count).Item("ID")) Then
                        If (AccLev = dsDet.Tables("Login").Rows(count).Item("AccessLevel")) Then
                            flag = 0
                            MsgBox("Sucessfuly Login to the system")
                            Me.Hide()
                            If (AccLev = 1) Then
                                Clerk.Show()
                            Else
                                Principal.Show()
                            End If
                            Return
                        Else
                            flag = 1
                        End If
                    Else
                        flag = 1
                    End If
                Else
                    flag = 1
                End If
            Next
            If flag = 1 Then
                MsgBox("Invalid user logins")
                TextBox1.Text = ""
                TextBox2.Text = ""
                ComboBox1.Text = ""
                TextBox1.Focus()
            End If
        Else
            MessageBox.Show("ERROR OCCURED!", "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If IsNumeric(TextBox3.Text) = False Then
            MsgBox(" Please enter valid ID")
            TextBox3.Clear()
            TextBox3.Focus()
            Return
        End If
        If (TextBox3.Text = "") Then
            MsgBox(" Please enter ID")
            TextBox3.Clear()
            TextBox3.Focus()
            Return
        End If
        If (TextBox3.Text.Length <> 13) Then
            MsgBox("Id number must be 13 digits")
            TextBox3.Clear()
            TextBox3.Focus()
            Return
        End If
        Dim res As String
        Dim dsy As New DataSet

        res = B.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404!", "No connection to database")

        Else
            dsy = B.GetSById(TextBox3.Text)


            Me.DataGridView2.DataSource = dsy.Tables("dtMathsandScienceFinal")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub
End Class
