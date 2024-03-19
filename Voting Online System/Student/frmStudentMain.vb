Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmStudentMain
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer

    Private Sub BtnExt_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Me.Close()
    End Sub

    Private Sub frmStudentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtStdLogin_Click(sender As Object, e As EventArgs) Handles btnStdLogin.Click
        If TxtStID.Text = String.Empty Then
            LblInfo.Text = "Please Fill student ID"
            LblInfo.ForeColor = Color.Red
        Else
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `student` WHERE `SID`=@SID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SID", TxtStID.Text)
                da = New MySqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    cmd = New MySqlCommand("SELECT * FROM `student` WHERE `SID`=@SID AND `Status`= @Status", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@SID", TxtStID.Text)
                    cmd.Parameters.AddWithValue("@Status", "Unvoted")
                    da = New MySqlDataAdapter
                    dt = New DataTable
                    da.SelectCommand = cmd
                    da.Fill(dt)

                    ' Changing the status to "Voted" in the database
                    If dt.Rows.Count > 0 Then
                        cmd = New MySqlCommand("UPDATE `student` SET `Status`=@NewStatus WHERE `SID`=@SID", conn)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@SID", TxtStID.Text)
                        cmd.Parameters.AddWithValue("@NewStatus", "Voted")
                        cmd.ExecuteNonQuery()

                        FrmVote.Show()
                    Else
                        LblInfo.Text = "Already Voted"
                        LblInfo.ForeColor = Color.Orange
                    End If

                Else
                    LblInfo.Text = "Student Not Found"
                    LblInfo.ForeColor = Color.Red
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Btnadmin_Click(sender As Object, e As EventArgs) Handles Btnadmin.Click
        Form1.Show()
    End Sub

    Private Sub LblInfo_Click(sender As Object, e As EventArgs) Handles LblInfo.Click

    End Sub
End Class
