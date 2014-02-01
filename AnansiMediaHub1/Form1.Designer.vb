<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AnansiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimalViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaxViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VedioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CropToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuidoSohneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.AnansiMediaHub1.My.Resources.Resources.anansimediahub
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnansiToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AudioToolStripMenuItem, Me.VedioToolStripMenuItem, Me.HelpToolStripMenuItem, Me.GuidoSohneToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AnansiToolStripMenuItem
        '
        Me.AnansiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.OpenFolderToolStripMenuItem, Me.PlayListToolStripMenuItem1})
        Me.AnansiToolStripMenuItem.Name = "AnansiToolStripMenuItem"
        Me.AnansiToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AnansiToolStripMenuItem.Text = "Media"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Open Folder"
        '
        'PlayListToolStripMenuItem1
        '
        Me.PlayListToolStripMenuItem1.Name = "PlayListToolStripMenuItem1"
        Me.PlayListToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PlayListToolStripMenuItem1.Text = "Play List"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaylistToolStripMenuItem, Me.MinimalViewToolStripMenuItem, Me.MaxViewToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PlaylistToolStripMenuItem.Text = "Playlist"
        '
        'MinimalViewToolStripMenuItem
        '
        Me.MinimalViewToolStripMenuItem.Name = "MinimalViewToolStripMenuItem"
        Me.MinimalViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MinimalViewToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MinimalViewToolStripMenuItem.Text = "Minimal View"
        '
        'MaxViewToolStripMenuItem
        '
        Me.MaxViewToolStripMenuItem.Name = "MaxViewToolStripMenuItem"
        Me.MaxViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.MaxViewToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MaxViewToolStripMenuItem.Text = "Full View"
        '
        'AudioToolStripMenuItem
        '
        Me.AudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AudioTrackToolStripMenuItem, Me.IncreaseVolumeToolStripMenuItem, Me.DecreaseVolumeToolStripMenuItem, Me.MuteToolStripMenuItem, Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.NextTrackToolStripMenuItem, Me.PreviousTrackToolStripMenuItem})
        Me.AudioToolStripMenuItem.Name = "AudioToolStripMenuItem"
        Me.AudioToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AudioToolStripMenuItem.Text = "Audio"
        '
        'AudioTrackToolStripMenuItem
        '
        Me.AudioTrackToolStripMenuItem.Name = "AudioTrackToolStripMenuItem"
        Me.AudioTrackToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AudioTrackToolStripMenuItem.Text = "Audio Track"
        '
        'IncreaseVolumeToolStripMenuItem
        '
        Me.IncreaseVolumeToolStripMenuItem.Name = "IncreaseVolumeToolStripMenuItem"
        Me.IncreaseVolumeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.IncreaseVolumeToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.IncreaseVolumeToolStripMenuItem.Text = "Increase Volume"
        '
        'DecreaseVolumeToolStripMenuItem
        '
        Me.DecreaseVolumeToolStripMenuItem.Name = "DecreaseVolumeToolStripMenuItem"
        Me.DecreaseVolumeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.DecreaseVolumeToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.DecreaseVolumeToolStripMenuItem.Text = "Decrease Volume"
        '
        'MuteToolStripMenuItem
        '
        Me.MuteToolStripMenuItem.Name = "MuteToolStripMenuItem"
        Me.MuteToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.MuteToolStripMenuItem.Text = "Mute"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'NextTrackToolStripMenuItem
        '
        Me.NextTrackToolStripMenuItem.Name = "NextTrackToolStripMenuItem"
        Me.NextTrackToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.NextTrackToolStripMenuItem.Text = "Next Track"
        '
        'PreviousTrackToolStripMenuItem
        '
        Me.PreviousTrackToolStripMenuItem.Name = "PreviousTrackToolStripMenuItem"
        Me.PreviousTrackToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PreviousTrackToolStripMenuItem.Text = "Previous Track"
        '
        'VedioToolStripMenuItem
        '
        Me.VedioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideoTrackToolStripMenuItem, Me.FullScreenToolStripMenuItem, Me.ZoomToolStripMenuItem, Me.CropToolStripMenuItem})
        Me.VedioToolStripMenuItem.Name = "VedioToolStripMenuItem"
        Me.VedioToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VedioToolStripMenuItem.Text = "Video"
        '
        'VideoTrackToolStripMenuItem
        '
        Me.VideoTrackToolStripMenuItem.Name = "VideoTrackToolStripMenuItem"
        Me.VideoTrackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VideoTrackToolStripMenuItem.Text = "Video Track"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FullScreenToolStripMenuItem.Text = "Full screen"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D7), System.Windows.Forms.Keys)
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'CropToolStripMenuItem
        '
        Me.CropToolStripMenuItem.Name = "CropToolStripMenuItem"
        Me.CropToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CropToolStripMenuItem.Text = "Crop"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GuidoSohneToolStripMenuItem
        '
        Me.GuidoSohneToolStripMenuItem.Name = "GuidoSohneToolStripMenuItem"
        Me.GuidoSohneToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.GuidoSohneToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.GuidoSohneToolStripMenuItem.Text = "Oasis Websoft"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 24)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(529, 244)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.AnansiMediaHub1.My.Resources.Resources.anansimediahub
        Me.ClientSize = New System.Drawing.Size(529, 268)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Anansi Media Hub"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AnansiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimalViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudioTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VedioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CropToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PlayListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaxViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuidoSohneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
