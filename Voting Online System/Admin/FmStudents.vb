Imports MySql.Data.MySqlClient

Public Class FmStudents
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim i As Integer

    Private Sub connection()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"
    End Sub

    Private SelectedRowIndex As Integer
    Private Sub FmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        load_table()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        'Searching Students in the DB
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `student` WHERE SID like @Search OR Sname like @Search OR Course like @Search", conn)
            cmd.Parameters.AddWithValue("@Search", "%" & TxtSearch.Text & "%")
            dr = cmd.ExecuteReader


            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("SID"), dr.Item("Sname"), dr.Item("Course"), dr.Item("Year"), dr.Item("Status"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        ' Register a new student
        connection()
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `student`(`SID`, `Sname`, `Course`, `Year`, `Status`) VALUES (@SID,@Sname,@Course,@Year,@Status)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SID", TxtSID.Text)
            cmd.Parameters.AddWithValue("@Sname", TxtStName.Text)
            cmd.Parameters.AddWithValue("@Course", CmbCourse.Text)
            cmd.Parameters.AddWithValue("@Year", CmbYear.Text)
            cmd.Parameters.AddWithValue("@Status", "Unvoted")

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Student Registered successfully!", vbInformation)
            Else
                MsgBox("Student registration failed!", vbExclamation)
            End If

            ' Clearing text boxes
            TxtSID.Clear()
            TxtStName.Clear()
            CmbCourse.SelectedIndex = -1
            CmbYear.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            ' Refresh the table after registration
            load_table()
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If SelectedRowIndex >= 0 AndAlso SelectedRowIndex < DataGridView1.Rows.Count Then
            Dim selectedStudentID As String = DataGridView1.Rows(SelectedRowIndex).Cells("Column2").Value.ToString()
            'Deleting students in the datagridview
            connection()
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `student` WHERE SID = @SID", conn)
                cmd.Parameters.AddWithValue("@SID", selectedStudentID)
                i = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Student deleted successfully!", vbInformation)
                 
                    load_table()
                Else
                    MsgBox("Failed to delete student.", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("Please select a student to delete.", vbExclamation)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub
    Private Sub load_table()
        'Adding and arranging students in the datagrid view
        connection()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `student`", conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            DataGridView1.Rows.Clear()

            For Each row As DataRow In dt.Rows
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, row("SID"), row("Sname"), row("Course"), row("Year"), row("Status"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'Editing Students Info
        If SelectedRowIndex >= 0 AndAlso SelectedRowIndex < DataGridView1.Rows.Count Then
            Dim selectedStudentID As String = DataGridView1.Rows(SelectedRowIndex).Cells("Column2").Value.ToString()
            Dim editForm As New FrmEditStudent(selectedStudentID)
            editForm.ShowDialog()
            load_table()
        Else
            MsgBox("Please select a student to edit.", vbExclamation)
        End If
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        ' Get the selected row index when the selection changes
        If DataGridView1.SelectedRows.Count > 0 Then
            SelectedRowIndex = DataGridView1.SelectedRows(0).Index
        End If
    End Sub

End Class
