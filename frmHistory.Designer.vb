<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.lvHistory = New System.Windows.Forms.ListView()
        Me.chDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chShowName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSeasonEpisode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chQuality = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsHistoryShow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiOpenShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssShow1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiOpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHistoryShow.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvHistory
        '
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chDateTime, Me.chShowName, Me.chSeasonEpisode, Me.chQuality, Me.chStatus})
        Me.lvHistory.ContextMenuStrip = Me.cmsHistoryShow
        Me.lvHistory.FullRowSelect = True
        Me.lvHistory.GridLines = True
        Me.lvHistory.Location = New System.Drawing.Point(12, 12)
        Me.lvHistory.MultiSelect = False
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(737, 476)
        Me.lvHistory.TabIndex = 0
        Me.lvHistory.UseCompatibleStateImageBehavior = False
        Me.lvHistory.View = System.Windows.Forms.View.Details
        '
        'chDateTime
        '
        Me.chDateTime.Text = "Date / Time"
        Me.chDateTime.Width = 149
        '
        'chShowName
        '
        Me.chShowName.Text = "Show Name"
        Me.chShowName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chShowName.Width = 228
        '
        'chSeasonEpisode
        '
        Me.chSeasonEpisode.Text = "Season / Episode"
        Me.chSeasonEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chSeasonEpisode.Width = 109
        '
        'chQuality
        '
        Me.chQuality.Text = "Quality"
        Me.chQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chQuality.Width = 102
        '
        'chStatus
        '
        Me.chStatus.Text = "Status"
        Me.chStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chStatus.Width = 122
        '
        'cmsHistoryShow
        '
        Me.cmsHistoryShow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOpenShow, Me.tssShow1, Me.tsmiOpenFolder, Me.tsmiOpenFile})
        Me.cmsHistoryShow.Name = "cmsShows"
        Me.cmsHistoryShow.Size = New System.Drawing.Size(140, 76)
        '
        'tsmiOpenShow
        '
        Me.tsmiOpenShow.Name = "tsmiOpenShow"
        Me.tsmiOpenShow.Size = New System.Drawing.Size(139, 22)
        Me.tsmiOpenShow.Text = "Open Show"
        '
        'tssShow1
        '
        Me.tssShow1.Name = "tssShow1"
        Me.tssShow1.Size = New System.Drawing.Size(136, 6)
        '
        'tsmiOpenFolder
        '
        Me.tsmiOpenFolder.Name = "tsmiOpenFolder"
        Me.tsmiOpenFolder.Size = New System.Drawing.Size(139, 22)
        Me.tsmiOpenFolder.Text = "Open Folder"
        '
        'tsmiOpenFile
        '
        Me.tsmiOpenFile.Name = "tsmiOpenFile"
        Me.tsmiOpenFile.Size = New System.Drawing.Size(139, 22)
        Me.tsmiOpenFile.Text = "Open File"
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 500)
        Me.Controls.Add(Me.lvHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "History"
        Me.cmsHistoryShow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvHistory As ListView
    Friend WithEvents chDateTime As ColumnHeader
    Friend WithEvents chShowName As ColumnHeader
    Friend WithEvents chSeasonEpisode As ColumnHeader
    Friend WithEvents chQuality As ColumnHeader
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents cmsHistoryShow As ContextMenuStrip
    Friend WithEvents tsmiOpenShow As ToolStripMenuItem
    Friend WithEvents tssShow1 As ToolStripSeparator
    Friend WithEvents tsmiOpenFolder As ToolStripMenuItem
    Friend WithEvents tsmiOpenFile As ToolStripMenuItem
End Class
