<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.lblHTTPUsername = New System.Windows.Forms.Label()
        Me.lblHTTPPassword = New System.Windows.Forms.Label()
        Me.txtHostURL = New System.Windows.Forms.TextBox()
        Me.txtHTTPPassword = New System.Windows.Forms.TextBox()
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.txtHTTPUsername = New System.Windows.Forms.TextBox()
        Me.gbSickChillDetails = New System.Windows.Forms.GroupBox()
        Me.cbRequireAuth = New System.Windows.Forms.CheckBox()
        Me.gbAuthentication = New System.Windows.Forms.GroupBox()
        Me.gbSickChillDetails.SuspendLayout()
        Me.gbAuthentication.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 206)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(265, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(6, 26)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(57, 13)
        Me.lblURL.TabIndex = 1
        Me.lblURL.Text = "Host URL:"
        '
        'lblAPIKey
        '
        Me.lblAPIKey.AutoSize = True
        Me.lblAPIKey.Location = New System.Drawing.Point(15, 52)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(48, 13)
        Me.lblAPIKey.TabIndex = 2
        Me.lblAPIKey.Text = "API Key:"
        '
        'lblHTTPUsername
        '
        Me.lblHTTPUsername.AutoSize = True
        Me.lblHTTPUsername.Location = New System.Drawing.Point(5, 45)
        Me.lblHTTPUsername.Name = "lblHTTPUsername"
        Me.lblHTTPUsername.Size = New System.Drawing.Size(90, 13)
        Me.lblHTTPUsername.TabIndex = 3
        Me.lblHTTPUsername.Text = "HTTP Username:"
        '
        'lblHTTPPassword
        '
        Me.lblHTTPPassword.AutoSize = True
        Me.lblHTTPPassword.Location = New System.Drawing.Point(7, 71)
        Me.lblHTTPPassword.Name = "lblHTTPPassword"
        Me.lblHTTPPassword.Size = New System.Drawing.Size(88, 13)
        Me.lblHTTPPassword.TabIndex = 4
        Me.lblHTTPPassword.Text = "HTTP Password:"
        '
        'txtHostURL
        '
        Me.txtHostURL.Location = New System.Drawing.Point(69, 23)
        Me.txtHostURL.Name = "txtHostURL"
        Me.txtHostURL.Size = New System.Drawing.Size(190, 20)
        Me.txtHostURL.TabIndex = 5
        '
        'txtHTTPPassword
        '
        Me.txtHTTPPassword.Location = New System.Drawing.Point(101, 68)
        Me.txtHTTPPassword.Name = "txtHTTPPassword"
        Me.txtHTTPPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtHTTPPassword.TabIndex = 6
        '
        'txtAPIKey
        '
        Me.txtAPIKey.Location = New System.Drawing.Point(69, 49)
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(190, 20)
        Me.txtAPIKey.TabIndex = 7
        '
        'txtHTTPUsername
        '
        Me.txtHTTPUsername.Location = New System.Drawing.Point(101, 42)
        Me.txtHTTPUsername.Name = "txtHTTPUsername"
        Me.txtHTTPUsername.Size = New System.Drawing.Size(158, 20)
        Me.txtHTTPUsername.TabIndex = 8
        '
        'gbSickChillDetails
        '
        Me.gbSickChillDetails.Controls.Add(Me.lblURL)
        Me.gbSickChillDetails.Controls.Add(Me.lblAPIKey)
        Me.gbSickChillDetails.Controls.Add(Me.txtAPIKey)
        Me.gbSickChillDetails.Controls.Add(Me.txtHostURL)
        Me.gbSickChillDetails.Location = New System.Drawing.Point(12, 12)
        Me.gbSickChillDetails.Name = "gbSickChillDetails"
        Me.gbSickChillDetails.Size = New System.Drawing.Size(265, 81)
        Me.gbSickChillDetails.TabIndex = 9
        Me.gbSickChillDetails.TabStop = False
        Me.gbSickChillDetails.Text = "Host Details"
        '
        'cbRequireAuth
        '
        Me.cbRequireAuth.AutoSize = True
        Me.cbRequireAuth.Location = New System.Drawing.Point(48, 19)
        Me.cbRequireAuth.Name = "cbRequireAuth"
        Me.cbRequireAuth.Size = New System.Drawing.Size(177, 17)
        Me.cbRequireAuth.TabIndex = 10
        Me.cbRequireAuth.Text = "Require Username / Password?"
        Me.cbRequireAuth.UseVisualStyleBackColor = True
        '
        'gbAuthentication
        '
        Me.gbAuthentication.Controls.Add(Me.txtHTTPPassword)
        Me.gbAuthentication.Controls.Add(Me.cbRequireAuth)
        Me.gbAuthentication.Controls.Add(Me.lblHTTPUsername)
        Me.gbAuthentication.Controls.Add(Me.lblHTTPPassword)
        Me.gbAuthentication.Controls.Add(Me.txtHTTPUsername)
        Me.gbAuthentication.Location = New System.Drawing.Point(12, 99)
        Me.gbAuthentication.Name = "gbAuthentication"
        Me.gbAuthentication.Size = New System.Drawing.Size(265, 101)
        Me.gbAuthentication.TabIndex = 11
        Me.gbAuthentication.TabStop = False
        Me.gbAuthentication.Text = "HTTP Authentication"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 241)
        Me.Controls.Add(Me.gbAuthentication)
        Me.Controls.Add(Me.gbSickChillDetails)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.gbSickChillDetails.ResumeLayout(False)
        Me.gbSickChillDetails.PerformLayout()
        Me.gbAuthentication.ResumeLayout(False)
        Me.gbAuthentication.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblURL As Label
    Friend WithEvents lblAPIKey As Label
    Friend WithEvents lblHTTPUsername As Label
    Friend WithEvents lblHTTPPassword As Label
    Friend WithEvents txtHostURL As TextBox
    Friend WithEvents txtHTTPPassword As TextBox
    Friend WithEvents txtAPIKey As TextBox
    Friend WithEvents txtHTTPUsername As TextBox
    Friend WithEvents gbSickChillDetails As GroupBox
    Friend WithEvents cbRequireAuth As CheckBox
    Friend WithEvents gbAuthentication As GroupBox
End Class
