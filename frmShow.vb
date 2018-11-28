Imports Newtonsoft.Json

Public Class frmShow

    Private _showID As Integer
    Private _showInfoJSON As ShowInfo

    Public _apiKey As String = "806cb3c80ed5df5ab2ac03c02298a63b"
    Public _sickRageURL As String = "http://192.168.1.2:8081/"
    Public _sickRageAPIURL As String = _sickRageURL & "api/" & _apiKey & "/"

    Public Sub New(ByVal showId As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _showID = showId

    End Sub

    Private Sub frmShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim showInfoURL As String = _sickRageAPIURL & "?cmd=show&indexerid=" & _showID
        Dim showInfoWebClient As New System.Net.WebClient

        Dim showInfoResult As String = showInfoWebClient.DownloadString(showInfoURL)
        _showInfoJSON = JsonConvert.DeserializeObject(Of ShowInfo)(showInfoResult)

        Me.Text = String.Format(Me.Text, _showInfoJSON.data.show_name)
        lblShowName.Text = _showInfoJSON.data.show_name
        lblQuality.Text = String.Format(lblQuality.Text, _showInfoJSON.data.quality)
        lblOriginallyAirs.Text = String.Format(lblOriginallyAirs.Text, _showInfoJSON.data.airs, _showInfoJSON.data.network)
        lblShowStatus.Text = String.Format(lblShowStatus.Text, _showInfoJSON.data.status)
        lblLocation.Text = String.Format(lblLocation.Text, _showInfoJSON.data.location)

        Dim showPosterURL As String = _sickRageAPIURL & "?cmd=show.getposter&indexerid=" & _showID
        Dim showNetworkLogoURL As String = _sickRageAPIURL & "?cmd=show.getnetworklogo&indexerid=" & _showID

        pbShowPoster.ImageLocation = showPosterURL
        pbnetworkLogo.ImageLocation = showNetworkLogoURL

        Dim genres As String = ""

        For Each item In _showInfoJSON.data.genre
            genres += item & ", "
        Next

        lblGenres.Text = String.Format(lblGenres.Text, genres)




        For Each item In _showInfoJSON.data.season_list
            If item = 0 Then
                tcSeasons.TabPages.Add("tpSpecials", "Specials")

                Dim seasonListView As New ListView

                seasonListView.Columns.Add("Episode", 67)
                seasonListView.Columns.Add("Name", 238)
                seasonListView.Columns.Add("Size", 79)
                seasonListView.Columns.Add("Airdate", 145)
                seasonListView.Columns.Add("Status", 148)

                seasonListView.Location = New System.Drawing.Point(3, 3)
                seasonListView.Size = New System.Drawing.Size(705, 293)
                seasonListView.FullRowSelect = True
                seasonListView.GridLines = True

                seasonListView.View = System.Windows.Forms.View.Details
                seasonListView.MultiSelect = False
                seasonListView.Name = "lvSpecials"

                tcSeasons.TabPages.Item("tpSpecials").Controls.Add(seasonListView)
            Else
                tcSeasons.TabPages.Add("tpSeason" & item, "Season " & item)

                Dim seasonListView As New ListView

                seasonListView.Columns.Add("Episode", 67)
                seasonListView.Columns.Add("Name", 238, HorizontalAlignment.Center)
                seasonListView.Columns.Add("Size", 79, HorizontalAlignment.Center)
                seasonListView.Columns.Add("Airdate", 115, HorizontalAlignment.Center)
                seasonListView.Columns.Add("Status", 188, HorizontalAlignment.Center)

                seasonListView.Location = New System.Drawing.Point(3, 3)
                seasonListView.Size = New System.Drawing.Size(705, 293)
                seasonListView.FullRowSelect = True
                seasonListView.GridLines = True

                seasonListView.View = System.Windows.Forms.View.Details
                seasonListView.MultiSelect = False
                seasonListView.Name = "lvSeason" & item

                tcSeasons.TabPages.Item("tpSeason" & item).Controls.Add(seasonListView)
                tcSeasons.TabPages.Item("tpSeason" & item).Tag = item



            End If
        Next



        For Each tabPage As TabPage In tcSeasons.TabPages
            'MessageBox.Show(tabPage.Tag)

            For Each listView As ListView In tabPage.Controls
                Dim episodeListJSON As EpisodeList
                Dim episodeListURL As String = _sickRageAPIURL & "?cmd=show.seasons&indexerid=" & _showID & "&season=" & tabPage.Tag
                Dim episodeListClient As New System.Net.WebClient
                Dim episodeNumber As Integer = 1

                Dim episodeListResult As String = episodeListClient.DownloadString(episodeListURL)
                episodeListJSON = JsonConvert.DeserializeObject(Of EpisodeList)(episodeListResult)

                For Each item In episodeListJSON.data.Values
                    Dim episodeItem As New ListViewItem

                    episodeItem.Text = episodeNumber
                    episodeItem.SubItems.Add(item.name)
                    episodeItem.SubItems.Add(FormatBytes(item.file_size))
                    episodeItem.SubItems.Add(item.airdate)

                    Select Case item.status
                        Case "Downloaded"
                            episodeItem.SubItems.Add(item.status & " (" & item.quality & ")")
                        Case Else
                            episodeItem.SubItems.Add(item.status)
                    End Select



                    listView.Items.Add(episodeItem)
                    episodeNumber = episodeNumber + 1
                Next

                episodeListJSON.data.Clear()

            Next
        Next





        'For Each tabPage As TabPage In tcSeasons.TabPages

        '    If tabPage.Name = "Test" Then
        '    Else

        '        Dim seasonListView As New ListView

        '        seasonListView.Columns.Add("Episode", 67)
        '        seasonListView.Columns.Add("Name", 238)
        '        seasonListView.Columns.Add("Size", 79)
        '        seasonListView.Columns.Add("Airdate", 145)
        '        seasonListView.Columns.Add("Status", 148)

        '        seasonListView.Location = New System.Drawing.Point(3, 3)
        '        seasonListView.Size = New System.Drawing.Size(705, 293)
        '        seasonListView.FullRowSelect = True
        '        seasonListView.GridLines = True
        '        'Me.lvSeason1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})

        '        seasonListView.View = System.Windows.Forms.View.Details
        '        seasonListView.MultiSelect = False



        '        tabPage.Controls.Add(seasonListView)
        '    End If

        ' Next




    End Sub

    Private DoubleBytes As Double
    Public Function FormatBytes(ByVal BytesCaller As ULong) As String

        Try
            Select Case BytesCaller
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = BytesCaller ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try

    End Function

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub btnIMDb_Click(sender As Object, e As EventArgs) Handles btnIMDb.Click
        Process.Start("https://www.imdb.com/title/" & _showInfoJSON.data.imdbid)
    End Sub

    Private Sub btnTVDB_Click(sender As Object, e As EventArgs) Handles btnTVDB.Click
        Process.Start("http://thetvdb.com/?tab=series&id=" & _showInfoJSON.data.tvdbid)
    End Sub
End Class