Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmCandidates
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PcBxClose_Click(sender As Object, e As EventArgs) Handles PcBxClose.Click
        Me.Close()
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"

        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `candidate`(`name`,`course`, `year`, `position`) VALUES (@name,@course,@year,@position)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", TxtName.Text)
            cmd.Parameters.AddWithValue("@course", TxtCourse.Text)
            cmd.Parameters.AddWithValue("@year", CmbYear.Text)
            cmd.Parameters.AddWithValue("@position", CmbPosition.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Candidate Registered successful !!", vbInformation)
            Else
                MsgBox("Candidate register Failed !!", vbExclamation)
            End If

            'clearing text boxes
            TxtName.Clear()
            TxtCourse.Clear()
            CmbYear.SelectedIndex = -1
            CmbPosition.SelectedIndex = -1
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub FrmCandidates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class