Imports MySql.Data.MySqlClient
Public Class FrmResultsPreview
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub connection()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=ifmelection_db"
    End Sub
    Private Sub FrmResultsPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResults()
    End Sub
    Private Sub LoadResults()
        Try
            connection()
            conn.Open()

            ' Fetch total votes for President 1 and President 2
            Dim totalPresiVotes As Integer = GetTotalVotes("President")
            Dim presi1Votes As Integer = GetCandidateVotes(1, "President")
            Dim presi2Votes As Integer = GetCandidateVotes(2, "President")

            ' Fetch total votes for Faculty Representative 1 and Faculty Representative 2
            Dim totalFRVotes As Integer = GetTotalVotes("Faculty Representative")
            Dim fr1Votes As Integer = GetCandidateVotes(5, "Faculty Representative")
            Dim fr2Votes As Integer = GetCandidateVotes(6, "Faculty Representative")

            ' Calculate percentages
            Dim presi1Percentage As Integer = CalculatePercentage(presi1Votes, totalPresiVotes)
            Dim presi2Percentage As Integer = CalculatePercentage(presi2Votes, totalPresiVotes)
            Dim fr1Percentage As Integer = CalculatePercentage(fr1Votes, totalFRVotes)
            Dim fr2Percentage As Integer = CalculatePercentage(fr2Votes, totalFRVotes)

            'Filling Textboxes with Percentage
            TextBoxPresi1.Text = $"{presi1Percentage}%"
            TextBoxPresi2.Text = $"{presi2Percentage}%"
            TextBoxFR1.Text = $"{fr1Percentage}%"
            TextBoxFR2.Text = $"{fr2Percentage}%"
            ' Update progress bars
            ProgressBarPresi1.Value = presi1Percentage
            ProgressBarPresi2.Value = presi2Percentage
            ProgressBarFR1.Value = fr1Percentage
            ProgressBarFR2.Value = fr2Percentage

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function GetTotalVotes(position As String) As Integer
        ' Fetch total votes for a specific position
        cmd = New MySqlCommand($"SELECT SUM(VoteCount) FROM Votes WHERE Position = '{position}'", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function GetCandidateVotes(candidateID As Integer, position As String) As Integer
        ' Fetch votes for a specific candidate and position
        cmd = New MySqlCommand($"SELECT VoteCount FROM Votes WHERE CandidateID = {candidateID} AND Position = '{position}'", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function CalculatePercentage(votes As Integer, totalVotes As Integer) As Integer
        ' Calculate the percentage
        If totalVotes > 0 Then
            Return CInt((votes / totalVotes) * 100)
        Else
            Return 0
        End If
    End Function

    Private Sub PcBxClose_Click(sender As Object, e As EventArgs) Handles PcBxClose.Click
        Me.Close()
    End Sub


End Class