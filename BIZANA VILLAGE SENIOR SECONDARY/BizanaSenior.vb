Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Public Class BizanaSenior
    Dim con As New OleDbConnection
    Public Function getConnection() As String
        Dim str As String = ""
        Try
            con.ConnectionString = "PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source =BIZANA.mdb"
            str = "True"
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function GetLogin() As DataSet
        Dim sqlUsers As String
        Dim dsUsers As New DataSet
        Dim daUsers As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlUsers = "SELECT * FROM Login"
        daUsers = New OleDb.OleDbDataAdapter(sqlUsers, con)
        daUsers.Fill(dsUsers, "Login")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsUsers
    End Function
    Public Function AddUser(ByVal Uname As String, ByVal Pword As String, ByVal Alevel As String) As String
        Dim sqlAdd As String
        Dim cmd As OleDbCommand
        Dim result As String = ""

        Try
            sqlAdd = "INSERT INTO Login Values ('" + Uname + "','" + Pword + "','" + Alevel + "')"
            cmd = New OleDbCommand(sqlAdd, con)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sqlAdd
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function GetUserByName(ByVal UName As String) As DataSet
        Dim sqlName As String
        Dim dsName As New DataSet
        Dim daName As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlName = "SELECT * FROM Login WHERE Username = '" + UName + "'"
        daName = New OleDb.OleDbDataAdapter(sqlName, con)
        daName.Fill(dsName, "dtLogin")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsName
    End Function
    Public Function GetALLLearners() As DataSet
        Dim sqlMS As String
        Dim dsMS As New DataSet
        Dim daMS As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlMS = "SELECT * FROM Learners"
        daMS = New OleDb.OleDbDataAdapter(sqlMS, con)
        daMS.Fill(dsMS, "dtLearners")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsMS
    End Function
    Public Function GetAllMaths() As DataSet
        Dim sqlMaths As String
        Dim dsMaths As New DataSet
        Dim daMaths As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlMaths = "SELECT * FROM Mathematics"
        daMaths = New OleDb.OleDbDataAdapter(sqlMaths, con)
        daMaths.Fill(dsMaths, "dtMathematics")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsMaths
    End Function
    Public Function GetAllAccounting() As DataSet
        Dim sqlAcc As String
        Dim dsAcc As New DataSet
        Dim daAcc As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlAcc = "SELECT * FROM Accounting "
        daAcc = New OleDb.OleDbDataAdapter(sqlAcc, con)
        daAcc.Fill(dsAcc, "dtAccounting")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsAcc
    End Function
    Public Function GetAllPhysics() As DataSet
        Dim sqlPhy As String
        Dim dsPhy As New DataSet
        Dim daPhy As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlPhy = "SELECT * FROM PhysicalScience"
        daPhy = New OleDb.OleDbDataAdapter(sqlPhy, con)
        daPhy.Fill(dsPhy, "dtPhysicalScience")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsPhy
    End Function
    Public Function GetAllHistory() As DataSet
        Dim sqlH As String
        Dim dsH As New DataSet
        Dim daH As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlH = "SELECT * FROM HistoryFinal"
        daH = New OleDb.OleDbDataAdapter(sqlH, con)
        daH.Fill(dsH, "dtHistoryFinal")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsH
    End Function

    Public Function GetCormFinal() As DataSet
        Dim sqlCF As String
        Dim dsCF As New DataSet
        Dim daCF As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlCF = "SELECT * FROM CommerceFinal"
        daCF = New OleDb.OleDbDataAdapter(sqlCF, con)
        daCF.Fill(dsCF, "dtCommerceFinal")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsCF
    End Function
    Public Function GetMSFinal() As DataSet
        Dim sqlMS As String
        Dim dsMS As New DataSet
        Dim daMS As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlMS = "SELECT * FROM MathsandScienceFinal"
        daMS = New OleDb.OleDbDataAdapter(sqlMS, con)
        daMS.Fill(dsMS, "dtMathsandScienceFinal")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsMS
    End Function
    Public Function GetHistoryFinal() As DataSet
        Dim sqlHF As String
        Dim dsHF As New DataSet
        Dim daHF As OleDb.OleDbDataAdapter

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        sqlHF = "SELECT * FROM HistoryFinal"
        daHF = New OleDb.OleDbDataAdapter(sqlHF, con)
        daHF.Fill(dsHF, "dtHistoryFinal")

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Return dsHF
    End Function
    Public Function GetAllIdsM() As DataSet
        Dim sqlID As String
        Dim dsID As New DataSet
        Dim daID As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlID = "SELECT ID,Grade FROM Mathematics"
        daID = New OleDb.OleDbDataAdapter(sqlID, con)
        daID.Fill(dsID, "dtMathematics")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsID
    End Function
    Public Function GetAllIdsP() As DataSet
        Dim sqlID As String
        Dim dsID As New DataSet
        Dim daID As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlID = "SELECT ID,Grade FROM PhysicalScience"
        daID = New OleDb.OleDbDataAdapter(sqlID, con)
        daID.Fill(dsID, "dtPhysicalScience")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsID
    End Function
    Public Function GetAllIdsA() As DataSet
        Dim sqlID As String
        Dim dsID As New DataSet
        Dim daID As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlID = "SELECT ID,Grade FROM Accounting"
        daID = New OleDb.OleDbDataAdapter(sqlID, con)
        daID.Fill(dsID, "dtAccounting")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsID
    End Function
    Public Function GetAllIdsH() As DataSet
        Dim sqlID As String
        Dim dsID As New DataSet
        Dim daID As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlID = "SELECT ID,Grade FROM History"
        daID = New OleDb.OleDbDataAdapter(sqlID, con)
        daID.Fill(dsID, "dtHistory")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsID
    End Function
    Public Function GetAllIdsLearners() As DataSet
        Dim sqlID As String
        Dim dsID As New DataSet
        Dim daID As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sqlID = "SELECT ID FROM Learners"
        daID = New OleDb.OleDbDataAdapter(sqlID, con)
        daID.Fill(dsID, "dtLearners")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsID
    End Function
    Public Function UpdateTestsMaths(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "Update Mathematics Set Test 1='" + b + "',Test 2='" + c + "',Test 3='" + d + "',Test 4='" + e + "',Average='" + f + "' where ID='" + a + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function UpdateTestsPhysics(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "Update PhysicalScience Set Test 1='" + b + "',Test 2='" + c + "',Test 3='" + d + "',Test 4='" + e + "',Average='" + f + "' where (ID='" + a + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function UpdateTestsAccounting(ByVal a As String, ByVal g As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String) As String

        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "UPDATE Accounting SET Grade='" + g + "',Test 1='" + b + "',Test 2='" + c + "',Test 3='" + d + "',Test 4='" + e + "',Average='" + f + "' WHERE ID='" + a + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function UpdateTestsHistory(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "Update History Set Test 1='" + b + "',Test 2='" + c + "',Test 3='" + d + "',Test 4='" + e + "',Average='" + f + "' where ID='" + a + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function GetStuByID(ByVal id As String) As DataSet
        Dim dsE As New DataSet
        Dim sql As String
        Dim daS As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM HistoryFinal WHERE ID = ( '" + id + "')"
        daS = New OleDb.OleDbDataAdapter(sql, con)
        daS.Fill(dsE, "dtHistoryFinal")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsE
    End Function
    Public Function GetStudentById(ByVal id As String) As DataSet
        Dim dsL As New DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Learners WHERE ID = '" + id + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dsL, "dtLearners")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsL
    End Function
    Public Function GetSById(ByVal id As String) As DataSet
        Dim dsL As New DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM MathsandScienceFinal WHERE ID = '" + id + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dsL, "dtMathsandScienceFinal")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsL
    End Function
    Public Function GetSubjectA(ByVal id As String) As DataSet
        Dim dsL As New DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM SubjectAverage WHERE SubjectCode= '" + id + "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dsL, "dtSubjectAverage")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dsL
    End Function
    Public Function GetDeleteStu(ByVal id As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "DELETE * FROM MathsandScienceFinal where ID='" + id + "'"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
    Public Function AddLearner(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String) As String
        Dim str, sql As String
        Dim cmd As OleDb.OleDbCommand
        Try
            sql = "INSERT  INTO Learners VALUES ('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','" + f + "')"
            cmd = New OleDb.OleDbCommand(sql, con)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            str = "True"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            str = ex.Message.ToString()
        End Try
        Return str
    End Function
End Class

