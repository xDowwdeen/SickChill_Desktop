
Option Strict Off
Imports Newtonsoft.Json


Public Class frmMain

    Public _apiKey As String = "806cb3c80ed5df5ab2ac03c02298a63b"
    Public _sickRageURL As String = "http://192.168.1.2:8081/"
    Public _sickRageAPIURL As String = _sickRageURL & "api/" & _apiKey & "/"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatsTotalShows.Text = String.Format(lblStatsTotalShows.Text, 27)
        lblStatsActiveShows.Text = String.Format(lblStatsActiveShows.Text, 26)
        lblStatsDownloadedEp.Text = String.Format(lblStatsDownloadedEp.Text, 1859)
        lblStatsTotalEp.Text = String.Format(lblStatsTotalEp.Text, 1983)

    End Sub

    Private Sub lvShowList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvShowList.MouseDoubleClick
        Dim showDialog As New frmShow(260092)
        showDialog.ShowDialog()



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
End Class
