Imports Newtonsoft.Json

Public Class frmHistory

    Public _apiKey As String = "806cb3c80ed5df5ab2ac03c02298a63b"
    Public _sickRageURL As String = "http://192.168.1.2:8081/"
    Public _sickRageAPIURL As String = _sickRageURL & "api/" & _apiKey & "/"

    Private _historyJSON As History

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim historyURL As String = _sickRageAPIURL & "?cmd=history"
        Dim historyWebClient As New System.Net.WebClient

        Dim historyResult As String = historyWebClient.DownloadString(historyURL)
        _historyJSON = JsonConvert.DeserializeObject(Of History)(historyResult)

        For Each item In _historyJSON.data

            Dim season As String
            Dim episode As String

            If item.season <= 9 Then
                season = "S0" & item.season
            Else
                season = "S" & item.season
            End If

            If item.episode <= 9 Then
                episode = "E0" & item.episode
            Else
                episode = "E" & item.episode
            End If

            Dim historyItem As New ListViewItem

            historyItem.Text = item.date
            historyItem.Tag = item.indexerid
            historyItem.SubItems.Add("1").Text = item.show_name
            historyItem.SubItems.Add("2").Text = season & " " & episode
            historyItem.SubItems.Add("3").Text = item.quality
            historyItem.SubItems.Add("4").Text = item.status


            lvHistory.Items.Add(historyItem)

        Next
    End Sub

    Private Sub tsmiOpenShow_Click(sender As Object, e As EventArgs) Handles tsmiOpenShow.Click, lvHistory.DoubleClick
        Dim showDialog As New frmShow(lvHistory.FocusedItem.Tag)
        showDialog.ShowDialog()
    End Sub

End Class