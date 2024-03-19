Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Frm_manageUsers
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer


    Private Sub Frm_manageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PcBxClose_Click(sender As Object, e As EventArgs) Handles PcBxClose.Click
        Me.Close()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'This is where the Data are sent to the Database
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `User`(`Name`, `UserName`, `password`, `role`) VALUES (@UserName,@Name,@password,@role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Name", TxtName.Text)
            cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text)
            cmd.Parameters.AddWithValue("@password", TxtPasword.Text)
            cmd.Parameters.AddWithValue("@role", CmbRole.Text)
            i = cmd.ExecuteNonQuery

            'Authorizing User
            If i > 0 Then
                MsgBox("New User register successful !!", vbInformation, "Vote")
            Else
                MsgBox("New User register Unsuccessful !!", vbExclamation, "Vote")
            End If

            'clearing text boxes
            TxtName.Clear()
            TxtUserName.Clear()
            TxtPasword.Clear()
            CmbRole.SelectedIndex = -1


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class