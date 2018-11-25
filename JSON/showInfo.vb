Public Class Cache
    Public Property banner As Integer
    Public Property poster As Integer
End Class

Public Class QualityDetails
    Public Property archive As Object()
    Public Property initial As String()
End Class

Public Class Data
    Public Property air_by_date As Integer
    Public Property airs As String
    Public Property anime As Integer
    Public Property archive_firstmatch As Integer
    Public Property cache As Cache
    Public Property dvdorder As Integer
    Public Property genre As String()
    Public Property imdbid As String
    Public Property indexerid As Integer
    Public Property language As String
    Public Property location As String
    Public Property network As String
    Public Property next_ep_airdate As String
    Public Property paused As Integer
    Public Property quality As String
    Public Property quality_details As QualityDetails
    Public Property rls_ignore_words As Object()
    Public Property rls_require_words As Object()
    Public Property scene As Integer
    Public Property season_folders As Integer
    Public Property season_list As Integer()
    Public Property show_name As String
    Public Property sports As Integer
    Public Property status As String
    Public Property subtitles As Integer
    Public Property tvdbid As Integer
End Class

Public Class ShowInfo
    Public Property data As Data
    Public Property message As String
    Public Property result As String
End Class