Public Class show
    Public Property air_by_date As Integer
    Public Property indexerid As Integer
    Public Property network As String
    Public Property next_ep_airdate As String
    Public Property paused As Integer
    Public Property quality As String
    Public Property show_name As String
    Public Property status As String
End Class

Public Class showList

    Public Property Data As Dictionary(Of String, show)
End Class