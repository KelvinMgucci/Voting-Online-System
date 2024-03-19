Public Class Frm_AdminMain
    Dim presidentVotes As Integer
    Dim facultyRepVotes As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnMngStd.Click
        With FmStudents
            .TopLevel = False
            Panel1.Controls.Add(FmStudents)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnMngCandi.Click
        With FrmCandidates
            .TopLevel = False
            Panel1.Controls.Add(FrmCandidates)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnResults.Click
        With FrmCandidates
            FrmResultsPreview.Show()
        End With

    End Sub





    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMngUsr.Click
        Frm_manageUsers.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class