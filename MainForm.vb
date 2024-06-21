﻿Public Class MainForm
    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class


