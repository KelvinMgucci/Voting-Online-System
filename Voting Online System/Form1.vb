Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUserName.Text
        Dim password As String = TxtPass.Text


        Try
            If AuthenticateUser(username, password) Then
                MessageBox.Show("Login successful!")
                Frm_AdminMain.Show()
            Else
                MessageBox.Show("Invalid username or password. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"

        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM user WHERE Name = @Username AND Password = @Password"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error authenticating user: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
