Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FrmVote
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Public dt As DataTable
    Public i As Integer
    Dim bsrc As New BindingSource
    Dim presidentVotes As Integer = 0
    Dim presidentVotes2 As Integer = 0
    Dim facultyRepVotes As Integer = 0
    Dim facultyRepVotes2 As Integer = 0
    Private Const CandidateID_President1 As Integer = 1
    Private Const CandidateID_President2 As Integer = 2
    Private Const CandidateID_FacultyRep1 As Integer = 3
    Private Const CandidateID_FacultyRep2 As Integer = 4
    Private Sub connection()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateSelection(GroupBox1, "President") AndAlso ValidateSelection(GroupBox2, "Faculty Representative") Then

            Dim selectedPresidentID As Integer = GetSelectedCandidateID(GroupBox1)
            Dim selectedFacultyRepID As Integer = GetSelectedCandidateID(GroupBox2)

            RecordVote(selectedPresidentID, "President")
            RecordVote(selectedFacultyRepID, "Faculty Representative")

            MessageBox.Show("Vote cast successfully!", "Vote Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Me.Close()
        Else

            MessageBox.Show("Please select one candidate for each category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetSelectedCandidateID(radioButtonGroup As GroupBox) As Integer

        Dim selectedRadioButton As RadioButton = radioButtonGroup.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked)

        If selectedRadioButton IsNot Nothing AndAlso selectedRadioButton.Tag IsNot Nothing Then

            Return Convert.ToInt32(selectedRadioButton.Tag)
        Else

            Return -1
        End If
    End Function

    Private Sub RecordVote(candidateID As Integer, position As String)

        Try
            connection()
            conn.Open()

            ' Check if the candidate already has a record in the Votes table
            cmd = New MySqlCommand("SELECT * FROM Votes WHERE CandidateID = @CandidateID AND Position = @Position", conn)
            cmd.Parameters.AddWithValue("@CandidateID", candidateID)
            cmd.Parameters.AddWithValue("@Position", position)

            Dim candidateExists As Boolean = False
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                candidateExists = reader.Read()
            End Using

            If candidateExists Then
                cmd = New MySqlCommand("UPDATE Votes SET VoteCount = VoteCount + 1 WHERE CandidateID = @CandidateID AND Position = @Position", conn)
            Else
                cmd = New MySqlCommand("INSERT INTO Votes (CandidateID, Position, VoteCount) VALUES (@CandidateID, @Position, 1)", conn)
            End If

            cmd.Parameters.AddWithValue("@CandidateID", candidateID)
            cmd.Parameters.AddWithValue("@Position", position)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    ' Function to validate that a candidate is selected
    Private Function ValidateSelection(radioButtonGroup As GroupBox, category As String) As Boolean
        Dim selectedRadioButton As RadioButton = radioButtonGroup.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked)
        Return selectedRadioButton IsNot Nothing
    End Function

    Private Sub PcBxClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class