Public Class LOGINN
    Dim Lilitha As New LilithaClasss
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim AccLev As Integer
        Dim re As String = ""
        Dim flag As Integer
        flag = 0
        Dim dsDet As New DataSet
        'VALIDATING USERNAME IS EMPTY OR NOT
        If txtUser.Text = "" Then
            MsgBox("Please input User name")
            txtUser.Focus()
            Return
        End If
        'VALIDATING PASSWORD IS EMPTY OR NOT
        If txtPass.Text = "" Then
            MsgBox("Please input Password")
            txtPass.Focus()
            Return
        End If
        'VALIDATING Job title IS EMPTY OR NOT
        If cmbTitle.Text = "Select" Then
            MsgBox("Please select Job Title")
            cmbTitle.Focus()
            Return
        End If
        If cmbTitle.SelectedItem = "Manager" Then
            AccLev = 2
        End If
        If cmbTitle.SelectedItem = "Receptionist" Then
            AccLev = 1
        End If
        re = Lilitha.getConnection()
        If re = "True" Then

            dsDet = Lilitha.GetLogin()
            Dim count As Integer
            For count = 0 To dsDet.Tables("LOGIN").Rows.Count - 1
                If (txtUser.Text = dsDet.Tables("LOGIN").Rows(count).Item("Username")) Then
                    If (txtPass.Text = dsDet.Tables("LOGIN").Rows(count).Item("Password")) Then
                        If (AccLev = dsDet.Tables("LOGIN").Rows(count).Item("AccessLevel")) Then
                            flag = 0
                            MsgBox("Sucessfuly Loggedin")
                            Me.Hide()
                            If (AccLev = 1) Then
                                Reception.Show()
                            Else
                                Management.Show()
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
                MsgBox("Invalid user")
                txtUser.Text = ""
                txtPass.Text = ""
                cmbTitle.Text = "Select"
                txtUser.Focus()
            End If
        Else
            MessageBox.Show(re, "Connetion has failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        NewUser.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Just create new account", "We can't help you", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        HomePage.Show()
    End Sub
End Class