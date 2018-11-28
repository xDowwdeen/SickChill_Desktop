Public Class Datum
    Public Property [date] As String
    Public Property episode As Integer
    Public Property indexerid As Integer
    Public Property provider As String
    Public Property quality As String
    Public Property resource As String
    Public Property resource_path As String
    Public Property season As Integer
    Public Property show_name As String
    Public Property status As String
    Public Property tvdbid As Integer
End Class

Public Class History
    Public Property data As Datum()
    Public Property message As String
    Public Property result As String
End Class

