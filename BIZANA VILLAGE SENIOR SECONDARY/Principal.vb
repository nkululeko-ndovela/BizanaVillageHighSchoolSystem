Public Class Principal
    Dim B As New BizanaSenior
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmHOMEPAGE.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim res As String
        Dim dsy As New DataSet

        res = B.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404", "No connection to database")

        Else
            dsy = B.GetSubjectA(ComboBox1.SelectedItem)


            Me.DataGridView1.DataSource = dsy.Tables("dtSubjectAverage")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Panel4.Visible = True
        Panel7.Visible = False
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        frmHOMEPAGE.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim res As String=""
        Dim dsy As New DataSet

        res = B.getConnection()

        If res <> "True" Then
            MsgBox("ERROR 404!", "No connection to database")

        Else
            If ComboBox2.Text = "" Then
                MsgBox("PLEASE SELECT STREAM CODE")
            End If
            If ComboBox2.Text = "MS01" Then
                dsy = B.GetMSFinal()
                Me.DataGridView2.DataSource = dsy.Tables("dtMathsandScienceFinal")
            End If
            If ComboBox2.Text = "CS02" Then
                dsy = B.GetCormFinal()
                Me.DataGridView2.DataSource = dsy.Tables("dtCormmerceFinal")
            End If
            If ComboBox2.Text = "HS03" Then
                dsy = B.GetHistoryFinal()
                Me.DataGridView2.DataSource = dsy.Tables("dtHistoryFinal")
            End If
        End If
    End Sub
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Panel7.Visible = True
        Panel4.Visible = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class