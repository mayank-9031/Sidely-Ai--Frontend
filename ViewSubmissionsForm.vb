Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            LoadSubmission()
        End If
    End Sub

    Private Sub LoadSubmission()
        Dim submission = submissions(currentIndex)
        txtName.Text = submission.name
        txtEmail.Text = submission.email
        txtPhoneNum.Text = submission.PhoneNum
        txtGithubLink.Text = submission.GithubLink
        txtStopwatchTime.Text = submission.StopwatchTime
    End Sub
End Class
