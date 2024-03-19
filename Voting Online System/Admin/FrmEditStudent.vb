Imports MySql.Data.MySqlClient

Public Class FrmEditStudent
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim studentID As String

    Public Sub New(studentID As String)

        InitializeComponent()
        Me.studentID = studentID
    End Sub

    Private Sub connection()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"
    End Sub

    Private Sub FrmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `student` WHERE SID = @SID", conn)
            cmd.Parameters.AddWithValue("@SID", studentID)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                TxtStName.Text = dr("Sname").ToString()
                TxtSID.Text = dr("SID").ToString()
                CmbCourse.Text = dr("Course").ToString()
                CmbYear.Text = dr("Year").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        connection()
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `student` SET Sname = @Sname, Course = @Course, Year = @Year WHERE SID = @SID", conn)
            cmd.Parameters.AddWithValue("@SID", studentID)
            cmd.Parameters.AddWithValue("@Sname", TxtStName.Text)
            cmd.Parameters.AddWithValue("@Course", CmbCourse.Text)
            cmd.Parameters.AddWithValue("@Year", CmbYear.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MsgBox("Student information updated successfully!", vbInformation)
                Me.Close()
            Else
                MsgBox("Failed to update student information.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCourse.SelectedIndexChanged

    End Sub

    Private Sub TxtSID_TextChanged(sender As Object, e As EventArgs) Handles TxtSID.TextChanged

    End Sub

    Private Sub PcBxClose_Click(sender As Object, e As EventArgs) Handles PcBxClose.Click
        Me.Close()
    End Sub
End Class
