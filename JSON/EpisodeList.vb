Public Class Episode
    Public Property airdate As String
    Public Property file_size As Int64
    Public Property location As String
    Public Property name As String
    Public Property quality As String
    Public Property release_name As String
    Public Property status As String
    Public Property subtitles As String
End Class

Public Class EpisodeList
    Public Property data As Dictionary(Of String, Episode)
    Public Property message As String
    Public Property result As String
End Class

