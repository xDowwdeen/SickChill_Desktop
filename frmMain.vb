
Option Strict Off
Imports Newtonsoft.Json


Public Class frmMain

    Public _apiKey As String = "806cb3c80ed5df5ab2ac03c02298a63b"
    Public _sickRageURL As String = "http://192.168.1.2:8081/"
    Public _sickRageAPIURL As String = _sickRageURL & "api/" & _apiKey & "/"

    Private _showListJSON As showList

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatsTotalShows.Text = String.Format(lblStatsTotalShows.Text, 27)
        lblStatsActiveShows.Text = String.Format(lblStatsActiveShows.Text, 26)
        lblStatsDownloadedEp.Text = String.Format(lblStatsDownloadedEp.Text, 1859)
        lblStatsTotalEp.Text = String.Format(lblStatsTotalEp.Text, 1983)

        refreshData()


    End Sub



    Private Sub ysmiMainSettings_Click(sender As Object, e As EventArgs) Handles ysmiMainSettings.Click
        frmSettings.ShowDialog()

    End Sub

    Private Sub tsmiMainExit_Click(sender As Object, e As EventArgs) Handles tsmiMainExit.Click
        Application.Exit()
    End Sub

    Private Sub tsmiShowRemove_Click(sender As Object, e As EventArgs) Handles tsmiShowRemove.Click
        Select Case MessageBox.Show("Are you sure you want to REMOVE: SHOW_NAME?" & vbNewLine & "This action CAN'T be undone!", "Remove Show", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Case DialogResult.Yes
                Select Case MessageBox.Show("Would you like to remove the assosicated files from the storage location?" & vbNewLine & "This action CAN'T be undone!", "Remove Show Files", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    Case DialogResult.Yes
                        MsgBox("REMOVE SHOW. REMOVE FILES")
                    Case DialogResult.No
                        MsgBox("REMOVE SHOW, KEEP FILES")

                End Select
        End Select
    End Sub

    Private Sub tsmiMainHistory_Click(sender As Object, e As EventArgs) Handles tsmiMainHistory.Click
        frmHistory.ShowDialog()

    End Sub

    Private Sub tsmiShowEdit_Click(sender As Object, e As EventArgs) Handles tsmiShowEdit.Click, lvShowList.DoubleClick
        Dim showDialog As New frmShow(lvShowList.FocusedItem.Tag)
        showDialog.ShowDialog()
    End Sub

    Private Sub refreshData()
        lvShowList.Items.Clear()


        Dim showListURL As String = _sickRageAPIURL & "?cmd=shows"
        Dim showListWebClient As New System.Net.WebClient

        Dim showListResult As String = showListWebClient.DownloadString(showListURL)
        _showListJSON = JsonConvert.DeserializeObject(Of showList)(showListResult)

        For Each item In _showListJSON.Data.Values


            Dim showItem As New ListViewItem

            showItem.Text = item.show_name
            showItem.Tag = item.indexerid
            showItem.UseItemStyleForSubItems = False

            showItem.SubItems.Add(item.network)
            showItem.SubItems.Add("2").Text = item.quality

            Select Case item.quality
                Case "Any"
                    showItem.SubItems.Item(2).ForeColor = Color.Gray
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "SD"
                    showItem.SubItems.Item(2).ForeColor = Color.OrangeRed
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "HD"
                    showItem.SubItems.Item(2).ForeColor = Color.RoyalBlue
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "HD720p"
                    showItem.SubItems.Item(2).ForeColor = Color.ForestGreen
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "HD1080p"
                    showItem.SubItems.Item(2).ForeColor = Color.RoyalBlue
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "UHD"
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "UHD-8K"
                    showItem.SubItems.Item(2).ForeColor = Color.DarkMagenta
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "UHD-4K"
                    showItem.SubItems.Item(2).ForeColor = Color.MediumPurple
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
                Case "Custom"
                    showItem.SubItems.Item(2).ForeColor = Color.Purple
                    showItem.SubItems.Item(2).Font = New Font(lvShowList.Font, FontStyle.Bold)
            End Select

            showItem.SubItems.Add("3").Text = item.next_ep_airdate
            showItem.SubItems.Add("4").Text = ""
            showItem.SubItems.Add("5").Text = ""
            showItem.SubItems.Add("6").Text = item.status

            lvShowList.Items.Add(showItem)

        Next
    End Sub

    Private Sub tsmiMainRefresh_Click_1(sender As Object, e As EventArgs) Handles tsmiMainRefresh.Click
        refreshData()

    End Sub

End Class
