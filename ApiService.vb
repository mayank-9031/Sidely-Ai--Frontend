Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ApiService
    Private ReadOnly _client As New HttpClient()

    Public Async Function GetSubmissions() As Task(Of List(Of Submission))
        Dim response = Await _client.GetAsync("YOUR_BACKEND_URL_HERE")
        response.EnsureSuccessStatusCode()
        Dim content = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of List(Of Submission))(content)
    End Function

    Public Async Function CreateSubmission(submission As Submission) As Task
        Dim content = New StringContent(JsonConvert.SerializeObject(submission), System.Text.Encoding.UTF8, "application/json")
        Dim response = Await _client.PostAsync("YOUR_BACKEND_URL_HERE", content)
        response.EnsureSuccessStatusCode()
    End Function
End Class
