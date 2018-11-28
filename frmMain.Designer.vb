<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.tsmiMainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMainRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiMainBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiMainExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMainManage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMainAddShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiMainShutdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMainRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ysmiMainLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMainHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ysmiMainSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMainAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvShowList = New System.Windows.Forms.ListView()
        Me.chShowName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNetwork = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chQuality = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNextEpisode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDownloads = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsShows = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiShowEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssShow1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiShowRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssShow2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiShowRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbStats = New System.Windows.Forms.GroupBox()
        Me.lblStatsTotalEp = New System.Windows.Forms.Label()
        Me.lblStatsDownloadedEp = New System.Windows.Forms.Label()
        Me.lblStatsActiveShows = New System.Windows.Forms.Label()
        Me.lblStatsTotalShows = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.msMain.SuspendLayout()
        Me.cmsShows.SuspendLayout()
        Me.gbStats.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMainFile, Me.tsmiMainManage, Me.tsmiMainHistory, Me.ysmiMainSettings, Me.tsmiMainAbout})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMain.Size = New System.Drawing.Size(1011, 24)
        Me.msMain.TabIndex = 1
        '
        'tsmiMainFile
        '
        Me.tsmiMainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMainRefresh, Me.ToolStripSeparator4, Me.tsmiMainBrowser, Me.ToolStripSeparator3, Me.tsmiMainExit})
        Me.tsmiMainFile.Name = "tsmiMainFile"
        Me.tsmiMainFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiMainFile.Text = "File"
        '
        'tsmiMainRefresh
        '
        Me.tsmiMainRefresh.Image = Global.SickChill_Desktop.My.Resources.Resources.refresh
        Me.tsmiMainRefresh.Name = "tsmiMainRefresh"
        Me.tsmiMainRefresh.Size = New System.Drawing.Size(148, 22)
        Me.tsmiMainRefresh.Text = "Refresh"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(145, 6)
        '
        'tsmiMainBrowser
        '
        Me.tsmiMainBrowser.Image = Global.SickChill_Desktop.My.Resources.Resources.browser
        Me.tsmiMainBrowser.Name = "tsmiMainBrowser"
        Me.tsmiMainBrowser.Size = New System.Drawing.Size(148, 22)
        Me.tsmiMainBrowser.Text = "Open Browser"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(145, 6)
        '
        'tsmiMainExit
        '
        Me.tsmiMainExit.Image = CType(resources.GetObject("tsmiMainExit.Image"), System.Drawing.Image)
        Me.tsmiMainExit.Name = "tsmiMainExit"
        Me.tsmiMainExit.Size = New System.Drawing.Size(148, 22)
        Me.tsmiMainExit.Text = "Exit"
        '
        'tsmiMainManage
        '
        Me.tsmiMainManage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMainAddShow, Me.ToolStripSeparator1, Me.tsmiMainShutdown, Me.tsmiMainRestart, Me.ToolStripSeparator2, Me.ysmiMainLogs})
        Me.tsmiMainManage.Name = "tsmiMainManage"
        Me.tsmiMainManage.Size = New System.Drawing.Size(62, 20)
        Me.tsmiMainManage.Text = "Manage"
        '
        'tsmiMainAddShow
        '
        Me.tsmiMainAddShow.Image = Global.SickChill_Desktop.My.Resources.Resources.addTvShow
        Me.tsmiMainAddShow.Name = "tsmiMainAddShow"
        Me.tsmiMainAddShow.Size = New System.Drawing.Size(150, 22)
        Me.tsmiMainAddShow.Text = "Add TV Shows"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'tsmiMainShutdown
        '
        Me.tsmiMainShutdown.Name = "tsmiMainShutdown"
        Me.tsmiMainShutdown.Size = New System.Drawing.Size(150, 22)
        Me.tsmiMainShutdown.Text = "Shutdown"
        '
        'tsmiMainRestart
        '
        Me.tsmiMainRestart.Name = "tsmiMainRestart"
        Me.tsmiMainRestart.Size = New System.Drawing.Size(150, 22)
        Me.tsmiMainRestart.Text = "Restart"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'ysmiMainLogs
        '
        Me.ysmiMainLogs.Image = Global.SickChill_Desktop.My.Resources.Resources.logs
        Me.ysmiMainLogs.Name = "ysmiMainLogs"
        Me.ysmiMainLogs.Size = New System.Drawing.Size(150, 22)
        Me.ysmiMainLogs.Text = "Logs"
        '
        'tsmiMainHistory
        '
        Me.tsmiMainHistory.Name = "tsmiMainHistory"
        Me.tsmiMainHistory.Size = New System.Drawing.Size(57, 20)
        Me.tsmiMainHistory.Text = "History"
        '
        'ysmiMainSettings
        '
        Me.ysmiMainSettings.Name = "ysmiMainSettings"
        Me.ysmiMainSettings.Size = New System.Drawing.Size(61, 20)
        Me.ysmiMainSettings.Text = "Settings"
        '
        'tsmiMainAbout
        '
        Me.tsmiMainAbout.Name = "tsmiMainAbout"
        Me.tsmiMainAbout.Size = New System.Drawing.Size(52, 20)
        Me.tsmiMainAbout.Text = "About"
        '
        'lvShowList
        '
        Me.lvShowList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chShowName, Me.chNetwork, Me.chQuality, Me.chNextEpisode, Me.chDownloads, Me.chSize, Me.chStatus})
        Me.lvShowList.ContextMenuStrip = Me.cmsShows
        Me.lvShowList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvShowList.FullRowSelect = True
        Me.lvShowList.GridLines = True
        Me.lvShowList.Location = New System.Drawing.Point(12, 99)
        Me.lvShowList.MultiSelect = False
        Me.lvShowList.Name = "lvShowList"
        Me.lvShowList.Size = New System.Drawing.Size(987, 671)
        Me.lvShowList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvShowList.TabIndex = 3
        Me.lvShowList.UseCompatibleStateImageBehavior = False
        Me.lvShowList.View = System.Windows.Forms.View.Details
        '
        'chShowName
        '
        Me.chShowName.Text = "Show"
        Me.chShowName.Width = 268
        '
        'chNetwork
        '
        Me.chNetwork.Text = "Network"
        Me.chNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chNetwork.Width = 94
        '
        'chQuality
        '
        Me.chQuality.Text = "Quality"
        Me.chQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chQuality.Width = 88
        '
        'chNextEpisode
        '
        Me.chNextEpisode.Text = "Next Episode"
        Me.chNextEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chNextEpisode.Width = 142
        '
        'chDownloads
        '
        Me.chDownloads.Text = "Downloads"
        Me.chDownloads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDownloads.Width = 132
        '
        'chSize
        '
        Me.chSize.Text = "Size"
        Me.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chSize.Width = 106
        '
        'chStatus
        '
        Me.chStatus.Text = "Status"
        Me.chStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chStatus.Width = 135
        '
        'cmsShows
        '
        Me.cmsShows.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiShowEdit, Me.tsmiShowPause, Me.tssShow1, Me.tsmiShowRefresh, Me.tsmiShowUpdate, Me.tssShow2, Me.OpenBrowserToolStripMenuItem, Me.ToolStripSeparator5, Me.tsmiShowRemove})
        Me.cmsShows.Name = "cmsShows"
        Me.cmsShows.Size = New System.Drawing.Size(149, 154)
        '
        'tsmiShowEdit
        '
        Me.tsmiShowEdit.Image = Global.SickChill_Desktop.My.Resources.Resources.edit
        Me.tsmiShowEdit.Name = "tsmiShowEdit"
        Me.tsmiShowEdit.Size = New System.Drawing.Size(148, 22)
        Me.tsmiShowEdit.Text = "Edit"
        '
        'tsmiShowPause
        '
        Me.tsmiShowPause.Image = Global.SickChill_Desktop.My.Resources.Resources.pause
        Me.tsmiShowPause.Name = "tsmiShowPause"
        Me.tsmiShowPause.Size = New System.Drawing.Size(148, 22)
        Me.tsmiShowPause.Text = "Pause"
        '
        'tssShow1
        '
        Me.tssShow1.Name = "tssShow1"
        Me.tssShow1.Size = New System.Drawing.Size(145, 6)
        '
        'tsmiShowRefresh
        '
        Me.tsmiShowRefresh.Image = Global.SickChill_Desktop.My.Resources.Resources.refresh
        Me.tsmiShowRefresh.Name = "tsmiShowRefresh"
        Me.tsmiShowRefresh.Size = New System.Drawing.Size(148, 22)
        Me.tsmiShowRefresh.Text = "Refresh"
        '
        'tsmiShowUpdate
        '
        Me.tsmiShowUpdate.Image = Global.SickChill_Desktop.My.Resources.Resources.update
        Me.tsmiShowUpdate.Name = "tsmiShowUpdate"
        Me.tsmiShowUpdate.Size = New System.Drawing.Size(148, 22)
        Me.tsmiShowUpdate.Text = "Update"
        '
        'tssShow2
        '
        Me.tssShow2.Name = "tssShow2"
        Me.tssShow2.Size = New System.Drawing.Size(145, 6)
        '
        'OpenBrowserToolStripMenuItem
        '
        Me.OpenBrowserToolStripMenuItem.Image = Global.SickChill_Desktop.My.Resources.Resources.browser
        Me.OpenBrowserToolStripMenuItem.Name = "OpenBrowserToolStripMenuItem"
        Me.OpenBrowserToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OpenBrowserToolStripMenuItem.Text = "Open Browser"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(145, 6)
        '
        'tsmiShowRemove
        '
        Me.tsmiShowRemove.Image = Global.SickChill_Desktop.My.Resources.Resources.remove
        Me.tsmiShowRemove.Name = "tsmiShowRemove"
        Me.tsmiShowRemove.Size = New System.Drawing.Size(148, 22)
        Me.tsmiShowRemove.Text = "Remove"
        '
        'gbStats
        '
        Me.gbStats.Controls.Add(Me.lblStatsTotalEp)
        Me.gbStats.Controls.Add(Me.lblStatsDownloadedEp)
        Me.gbStats.Controls.Add(Me.lblStatsActiveShows)
        Me.gbStats.Controls.Add(Me.lblStatsTotalShows)
        Me.gbStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStats.Location = New System.Drawing.Point(734, 27)
        Me.gbStats.Name = "gbStats"
        Me.gbStats.Size = New System.Drawing.Size(265, 66)
        Me.gbStats.TabIndex = 4
        Me.gbStats.TabStop = False
        Me.gbStats.Text = "Statistics"
        '
        'lblStatsTotalEp
        '
        Me.lblStatsTotalEp.AutoSize = True
        Me.lblStatsTotalEp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatsTotalEp.Location = New System.Drawing.Point(114, 39)
        Me.lblStatsTotalEp.Name = "lblStatsTotalEp"
        Me.lblStatsTotalEp.Size = New System.Drawing.Size(97, 13)
        Me.lblStatsTotalEp.TabIndex = 5
        Me.lblStatsTotalEp.Text = "Total Episodes: {0}"
        '
        'lblStatsDownloadedEp
        '
        Me.lblStatsDownloadedEp.AutoSize = True
        Me.lblStatsDownloadedEp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatsDownloadedEp.Location = New System.Drawing.Point(114, 18)
        Me.lblStatsDownloadedEp.Name = "lblStatsDownloadedEp"
        Me.lblStatsDownloadedEp.Size = New System.Drawing.Size(133, 13)
        Me.lblStatsDownloadedEp.TabIndex = 4
        Me.lblStatsDownloadedEp.Text = "Downloaded Episodes: {0}"
        '
        'lblStatsActiveShows
        '
        Me.lblStatsActiveShows.AutoSize = True
        Me.lblStatsActiveShows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatsActiveShows.Location = New System.Drawing.Point(6, 39)
        Me.lblStatsActiveShows.Name = "lblStatsActiveShows"
        Me.lblStatsActiveShows.Size = New System.Drawing.Size(92, 13)
        Me.lblStatsActiveShows.TabIndex = 1
        Me.lblStatsActiveShows.Text = "Active Shows: {0}"
        '
        'lblStatsTotalShows
        '
        Me.lblStatsTotalShows.AutoSize = True
        Me.lblStatsTotalShows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatsTotalShows.Location = New System.Drawing.Point(6, 18)
        Me.lblStatsTotalShows.Name = "lblStatsTotalShows"
        Me.lblStatsTotalShows.Size = New System.Drawing.Size(86, 13)
        Me.lblStatsTotalShows.TabIndex = 0
        Me.lblStatsTotalShows.Text = "Total Shows: {0}"
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(12, 27)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(716, 66)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 782)
        Me.Controls.Add(Me.gbStats)
        Me.Controls.Add(Me.lvShowList)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SickChill - Desktop"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.cmsShows.ResumeLayout(False)
        Me.gbStats.ResumeLayout(False)
        Me.gbStats.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents tsmiMainFile As ToolStripMenuItem
    Friend WithEvents tsmiMainManage As ToolStripMenuItem
    Friend WithEvents tsmiMainAddShow As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmiMainShutdown As ToolStripMenuItem
    Friend WithEvents tsmiMainRestart As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ysmiMainLogs As ToolStripMenuItem
    Friend WithEvents ysmiMainSettings As ToolStripMenuItem
    Friend WithEvents tsmiMainAbout As ToolStripMenuItem
    Friend WithEvents lvShowList As ListView
    Friend WithEvents chShowName As ColumnHeader
    Friend WithEvents chNetwork As ColumnHeader
    Friend WithEvents chQuality As ColumnHeader
    Friend WithEvents chNextEpisode As ColumnHeader
    Friend WithEvents chDownloads As ColumnHeader
    Friend WithEvents chSize As ColumnHeader
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents tsmiMainRefresh As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsmiMainExit As ToolStripMenuItem
    Friend WithEvents cmsShows As ContextMenuStrip
    Friend WithEvents tsmiShowEdit As ToolStripMenuItem
    Friend WithEvents tsmiShowPause As ToolStripMenuItem
    Friend WithEvents tssShow1 As ToolStripSeparator
    Friend WithEvents tsmiShowRefresh As ToolStripMenuItem
    Friend WithEvents tsmiShowUpdate As ToolStripMenuItem
    Friend WithEvents tssShow2 As ToolStripSeparator
    Friend WithEvents tsmiShowRemove As ToolStripMenuItem
    Friend WithEvents tsmiMainBrowser As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents gbStats As GroupBox
    Friend WithEvents lblStatsTotalShows As Label
    Friend WithEvents lblStatsTotalEp As Label
    Friend WithEvents lblStatsDownloadedEp As Label
    Friend WithEvents lblStatsActiveShows As Label
    Friend WithEvents tsmiMainHistory As ToolStripMenuItem
    Friend WithEvents OpenBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
