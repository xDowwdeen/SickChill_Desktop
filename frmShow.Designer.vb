<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShow))
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.cmsShow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbShowDetails = New System.Windows.Forms.GroupBox()
        Me.lblShowStatus = New System.Windows.Forms.Label()
        Me.lblSceneName = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblDefaultEPStatus = New System.Windows.Forms.Label()
        Me.lblOriginallyAirs = New System.Windows.Forms.Label()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.gbInformation = New System.Windows.Forms.GroupBox()
        Me.lblSceneNumbering = New System.Windows.Forms.Label()
        Me.lblDVDOrder = New System.Windows.Forms.Label()
        Me.lblSports = New System.Windows.Forms.Label()
        Me.lblAnime = New System.Windows.Forms.Label()
        Me.lblPaused = New System.Windows.Forms.Label()
        Me.lblSeasonFolders = New System.Windows.Forms.Label()
        Me.lblAirByDate = New System.Windows.Forms.Label()
        Me.lblSubtitlesMeta = New System.Windows.Forms.Label()
        Me.lblInfoLanguage = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblGenres = New System.Windows.Forms.Label()
        Me.btnTVDB = New System.Windows.Forms.Button()
        Me.btnIMDb = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.tcSeasons = New System.Windows.Forms.TabControl()
        Me.pbnetworkLogo = New System.Windows.Forms.PictureBox()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbShowPoster = New System.Windows.Forms.PictureBox()
        Me.cmsShow.SuspendLayout()
        Me.gbShowDetails.SuspendLayout()
        Me.gbInformation.SuspendLayout()
        CType(Me.pbnetworkLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShowPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblShowName
        '
        Me.lblShowName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowName.Location = New System.Drawing.Point(12, 9)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(625, 51)
        Me.lblShowName.TabIndex = 2
        Me.lblShowName.Text = "SHOW_NAME"
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmsShow
        '
        Me.cmsShow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenFileToolStripMenuItem, Me.OpenFolderToolStripMenuItem})
        Me.cmsShow.Name = "cmsShow"
        Me.cmsShow.Size = New System.Drawing.Size(140, 76)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Image = Global.SickChill_Desktop.My.Resources.Resources.folder
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Open Folder"
        '
        'gbShowDetails
        '
        Me.gbShowDetails.Controls.Add(Me.lblShowStatus)
        Me.gbShowDetails.Controls.Add(Me.lblSceneName)
        Me.gbShowDetails.Controls.Add(Me.lblLocation)
        Me.gbShowDetails.Controls.Add(Me.lblSize)
        Me.gbShowDetails.Controls.Add(Me.lblDefaultEPStatus)
        Me.gbShowDetails.Controls.Add(Me.lblOriginallyAirs)
        Me.gbShowDetails.Controls.Add(Me.lblQuality)
        Me.gbShowDetails.Location = New System.Drawing.Point(207, 114)
        Me.gbShowDetails.Name = "gbShowDetails"
        Me.gbShowDetails.Size = New System.Drawing.Size(363, 201)
        Me.gbShowDetails.TabIndex = 6
        Me.gbShowDetails.TabStop = False
        Me.gbShowDetails.Text = "Details"
        '
        'lblShowStatus
        '
        Me.lblShowStatus.AutoSize = True
        Me.lblShowStatus.Location = New System.Drawing.Point(6, 74)
        Me.lblShowStatus.Name = "lblShowStatus"
        Me.lblShowStatus.Size = New System.Drawing.Size(87, 13)
        Me.lblShowStatus.TabIndex = 5
        Me.lblShowStatus.Text = "Show Status: {0}"
        '
        'lblSceneName
        '
        Me.lblSceneName.AutoSize = True
        Me.lblSceneName.Location = New System.Drawing.Point(6, 152)
        Me.lblSceneName.Name = "lblSceneName"
        Me.lblSceneName.Size = New System.Drawing.Size(89, 13)
        Me.lblSceneName.TabIndex = 4
        Me.lblSceneName.Text = "Scene Name: {0}"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(6, 126)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(68, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Location: {0}"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(6, 178)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(47, 13)
        Me.lblSize.TabIndex = 3
        Me.lblSize.Text = "Size: {0}"
        '
        'lblDefaultEPStatus
        '
        Me.lblDefaultEPStatus.AutoSize = True
        Me.lblDefaultEPStatus.Location = New System.Drawing.Point(6, 100)
        Me.lblDefaultEPStatus.Name = "lblDefaultEPStatus"
        Me.lblDefaultEPStatus.Size = New System.Drawing.Size(111, 13)
        Me.lblDefaultEPStatus.TabIndex = 2
        Me.lblDefaultEPStatus.Text = "Default EP Status: {0}"
        '
        'lblOriginallyAirs
        '
        Me.lblOriginallyAirs.AutoSize = True
        Me.lblOriginallyAirs.Location = New System.Drawing.Point(6, 48)
        Me.lblOriginallyAirs.Name = "lblOriginallyAirs"
        Me.lblOriginallyAirs.Size = New System.Drawing.Size(121, 13)
        Me.lblOriginallyAirs.TabIndex = 1
        Me.lblOriginallyAirs.Text = "Originally Airs: {0} on {1}"
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Location = New System.Drawing.Point(6, 22)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(59, 13)
        Me.lblQuality.TabIndex = 0
        Me.lblQuality.Text = "Quality: {0}"
        '
        'gbInformation
        '
        Me.gbInformation.Controls.Add(Me.lblSceneNumbering)
        Me.gbInformation.Controls.Add(Me.lblDVDOrder)
        Me.gbInformation.Controls.Add(Me.lblSports)
        Me.gbInformation.Controls.Add(Me.lblAnime)
        Me.gbInformation.Controls.Add(Me.lblPaused)
        Me.gbInformation.Controls.Add(Me.lblSeasonFolders)
        Me.gbInformation.Controls.Add(Me.lblAirByDate)
        Me.gbInformation.Controls.Add(Me.lblSubtitlesMeta)
        Me.gbInformation.Controls.Add(Me.lblInfoLanguage)
        Me.gbInformation.Location = New System.Drawing.Point(576, 114)
        Me.gbInformation.Name = "gbInformation"
        Me.gbInformation.Size = New System.Drawing.Size(155, 201)
        Me.gbInformation.TabIndex = 7
        Me.gbInformation.TabStop = False
        Me.gbInformation.Text = "Information"
        '
        'lblSceneNumbering
        '
        Me.lblSceneNumbering.AutoSize = True
        Me.lblSceneNumbering.Location = New System.Drawing.Point(6, 180)
        Me.lblSceneNumbering.Name = "lblSceneNumbering"
        Me.lblSceneNumbering.Size = New System.Drawing.Size(112, 13)
        Me.lblSceneNumbering.TabIndex = 12
        Me.lblSceneNumbering.Text = "Scene Numbering: {0}"
        '
        'lblDVDOrder
        '
        Me.lblDVDOrder.AutoSize = True
        Me.lblDVDOrder.Location = New System.Drawing.Point(6, 160)
        Me.lblDVDOrder.Name = "lblDVDOrder"
        Me.lblDVDOrder.Size = New System.Drawing.Size(79, 13)
        Me.lblDVDOrder.TabIndex = 11
        Me.lblDVDOrder.Text = "DVD Order: {0}"
        '
        'lblSports
        '
        Me.lblSports.AutoSize = True
        Me.lblSports.Location = New System.Drawing.Point(6, 119)
        Me.lblSports.Name = "lblSports"
        Me.lblSports.Size = New System.Drawing.Size(57, 13)
        Me.lblSports.TabIndex = 10
        Me.lblSports.Text = "Sports: {0}"
        '
        'lblAnime
        '
        Me.lblAnime.AutoSize = True
        Me.lblAnime.Location = New System.Drawing.Point(6, 139)
        Me.lblAnime.Name = "lblAnime"
        Me.lblAnime.Size = New System.Drawing.Size(56, 13)
        Me.lblAnime.TabIndex = 10
        Me.lblAnime.Text = "Anime: {0}"
        '
        'lblPaused
        '
        Me.lblPaused.AutoSize = True
        Me.lblPaused.Location = New System.Drawing.Point(6, 79)
        Me.lblPaused.Name = "lblPaused"
        Me.lblPaused.Size = New System.Drawing.Size(63, 13)
        Me.lblPaused.TabIndex = 9
        Me.lblPaused.Text = "Paused: {0}"
        '
        'lblSeasonFolders
        '
        Me.lblSeasonFolders.AutoSize = True
        Me.lblSeasonFolders.Location = New System.Drawing.Point(6, 59)
        Me.lblSeasonFolders.Name = "lblSeasonFolders"
        Me.lblSeasonFolders.Size = New System.Drawing.Size(100, 13)
        Me.lblSeasonFolders.TabIndex = 8
        Me.lblSeasonFolders.Text = "Season Folders: {0}"
        '
        'lblAirByDate
        '
        Me.lblAirByDate.AutoSize = True
        Me.lblAirByDate.Location = New System.Drawing.Point(6, 99)
        Me.lblAirByDate.Name = "lblAirByDate"
        Me.lblAirByDate.Size = New System.Drawing.Size(79, 13)
        Me.lblAirByDate.TabIndex = 8
        Me.lblAirByDate.Text = "Air-by-Date: {0}"
        '
        'lblSubtitlesMeta
        '
        Me.lblSubtitlesMeta.AutoSize = True
        Me.lblSubtitlesMeta.Location = New System.Drawing.Point(6, 40)
        Me.lblSubtitlesMeta.Name = "lblSubtitlesMeta"
        Me.lblSubtitlesMeta.Size = New System.Drawing.Size(133, 13)
        Me.lblSubtitlesMeta.TabIndex = 7
        Me.lblSubtitlesMeta.Text = "Subtitles SR Metadate: {0}"
        '
        'lblInfoLanguage
        '
        Me.lblInfoLanguage.AutoSize = True
        Me.lblInfoLanguage.Location = New System.Drawing.Point(6, 20)
        Me.lblInfoLanguage.Name = "lblInfoLanguage"
        Me.lblInfoLanguage.Size = New System.Drawing.Size(96, 13)
        Me.lblInfoLanguage.TabIndex = 6
        Me.lblInfoLanguage.Text = "Info Language: {0}"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(207, 321)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(313, 321)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(100, 23)
        Me.btnPause.TabIndex = 9
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(419, 321)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 23)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(525, 321)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblGenres
        '
        Me.lblGenres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblGenres.Location = New System.Drawing.Point(207, 63)
        Me.lblGenres.Name = "lblGenres"
        Me.lblGenres.Size = New System.Drawing.Size(430, 48)
        Me.lblGenres.TabIndex = 13
        Me.lblGenres.Text = "Genres: {0}"
        Me.lblGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTVDB
        '
        Me.btnTVDB.Location = New System.Drawing.Point(643, 88)
        Me.btnTVDB.Name = "btnTVDB"
        Me.btnTVDB.Size = New System.Drawing.Size(88, 23)
        Me.btnTVDB.TabIndex = 14
        Me.btnTVDB.Text = "TVDB"
        Me.btnTVDB.UseVisualStyleBackColor = True
        '
        'btnIMDb
        '
        Me.btnIMDb.Location = New System.Drawing.Point(643, 63)
        Me.btnIMDb.Name = "btnIMDb"
        Me.btnIMDb.Size = New System.Drawing.Size(88, 23)
        Me.btnIMDb.TabIndex = 15
        Me.btnIMDb.Text = "IMDb"
        Me.btnIMDb.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(631, 321)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'tcSeasons
        '
        Me.tcSeasons.ContextMenuStrip = Me.cmsShow
        Me.tcSeasons.Location = New System.Drawing.Point(12, 350)
        Me.tcSeasons.Name = "tcSeasons"
        Me.tcSeasons.SelectedIndex = 0
        Me.tcSeasons.Size = New System.Drawing.Size(719, 325)
        Me.tcSeasons.TabIndex = 3
        '
        'pbnetworkLogo
        '
        Me.pbnetworkLogo.Location = New System.Drawing.Point(643, 9)
        Me.pbnetworkLogo.Name = "pbnetworkLogo"
        Me.pbnetworkLogo.Size = New System.Drawing.Size(88, 51)
        Me.pbnetworkLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbnetworkLogo.TabIndex = 5
        Me.pbnetworkLogo.TabStop = False
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Image = Global.SickChill_Desktop.My.Resources.Resources.file
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'pbShowPoster
        '
        Me.pbShowPoster.Location = New System.Drawing.Point(12, 63)
        Me.pbShowPoster.Name = "pbShowPoster"
        Me.pbShowPoster.Size = New System.Drawing.Size(189, 281)
        Me.pbShowPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbShowPoster.TabIndex = 0
        Me.pbShowPoster.TabStop = False
        '
        'frmShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 687)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnIMDb)
        Me.Controls.Add(Me.btnTVDB)
        Me.Controls.Add(Me.lblGenres)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gbInformation)
        Me.Controls.Add(Me.gbShowDetails)
        Me.Controls.Add(Me.pbnetworkLogo)
        Me.Controls.Add(Me.tcSeasons)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.pbShowPoster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Show Info - {0}"
        Me.cmsShow.ResumeLayout(False)
        Me.gbShowDetails.ResumeLayout(False)
        Me.gbShowDetails.PerformLayout()
        Me.gbInformation.ResumeLayout(False)
        Me.gbInformation.PerformLayout()
        CType(Me.pbnetworkLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShowPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbShowPoster As PictureBox
    Friend WithEvents lblShowName As Label
    Friend WithEvents cmsShow As ContextMenuStrip
    Friend WithEvents pbnetworkLogo As PictureBox
    Friend WithEvents gbShowDetails As GroupBox
    Friend WithEvents gbInformation As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblGenres As Label
    Friend WithEvents lblShowStatus As Label
    Friend WithEvents lblSceneName As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblDefaultEPStatus As Label
    Friend WithEvents lblOriginallyAirs As Label
    Friend WithEvents lblQuality As Label
    Friend WithEvents btnTVDB As Button
    Friend WithEvents btnIMDb As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents tcSeasons As TabControl
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSceneNumbering As Label
    Friend WithEvents lblDVDOrder As Label
    Friend WithEvents lblSports As Label
    Friend WithEvents lblAnime As Label
    Friend WithEvents lblPaused As Label
    Friend WithEvents lblSeasonFolders As Label
    Friend WithEvents lblAirByDate As Label
    Friend WithEvents lblSubtitlesMeta As Label
    Friend WithEvents lblInfoLanguage As Label
End Class
