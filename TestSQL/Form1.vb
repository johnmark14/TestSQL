Imports MySql.Data.MySqlClient
Public Class Form1
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;user id=root;database=my_test_projects;")

        Try
            dbconn.Open()
            If dbconn.State = ConnectionState.Open Then
                MsgBox("Connection is now open")
            End If
        Catch ex As Exception
            MsgBox("Error in connection, Please check Database and connection server")
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        sql = "INSERT INTO testing_mysql_vb(user_name) VALUES ('" & txtusername.Text & "')"

        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try

        MsgBox("The User Name was saved.")
        txtusername.Clear()
    End Sub

    Private Sub btngetdata_Click(sender As Object, e As EventArgs) Handles btngetdata.Click
        listuser.Items.Clear()

        sql = "SELECT * FROM testing_mysql_vb"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            While dbread.Read
                listuser.Items.Add(dbread("user_name"))
            End While

            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub
End Class
