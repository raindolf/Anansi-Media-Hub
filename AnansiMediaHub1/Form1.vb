'imported windows media librabry

Imports WMPLib
Public Class Form1


    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim o As New OpenFileDialog
        o.RestoreDirectory = True
        o.Filter = "All Files(*)|*|AVI Videos (*.avi)|*.avi|WMV Videos (*.wmv)|*.wmv|MOV Videos (*.mov)|*.mov|MP4 Videos (*.mp4)|*.mp4|MP3 Files (*mp3)|*.mp3|WAV Files (*.wav)|*.wav|WMA Files (*.wma)|*.wma|FLV Files (*.FLV|*.FLV"
        o.FilterIndex = 1
        o.FileName = ""
        '


        o.ShowDialog()
        AxWindowsMediaPlayer1.URL = o.FileName
    End Sub

    Private Sub PlayListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayListToolStripMenuItem1.Click

        
    End Sub

    Private Sub MinimalViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimalViewToolStripMenuItem.Click
        AxWindowsMediaPlayer1.uiMode = "mini"
    End Sub

    Private Sub MaxViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxViewToolStripMenuItem.Click
        AxWindowsMediaPlayer1.uiMode = "full"
    End Sub

    Private Sub AnansiShareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.ShowDialog()
    End Sub

    Private Sub IncreaseVolumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncreaseVolumeToolStripMenuItem.Click
      
        AxWindowsMediaPlayer1.settings.volume = AxWindowsMediaPlayer1.settings.volume + 10
    End Sub

    Private Sub DecreaseVolumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecreaseVolumeToolStripMenuItem.Click
        AxWindowsMediaPlayer1.settings.volume = AxWindowsMediaPlayer1.settings.volume - 10
    End Sub

    Private Sub MuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuteToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.settings.volume = AxWindowsMediaPlayer1.settings.mute() Then



            AxWindowsMediaPlayer1.settings.volume = 20



        Else



            AxWindowsMediaPlayer1.settings.volume = AxWindowsMediaPlayer1.settings.mute()



        End If

    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()




    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
    'On click it should open our official website

    Private Sub UrbanRollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuidoSohneToolStripMenuItem.Click
        Dim theWebSite As String
        theWebSite = "http://www.oasiswebsoft.com"
        Call Shell("explorer.exe " & theWebSite, vbNormalFocus)

    End Sub

    Private Sub PlaylistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaylistToolStripMenuItem.Click

    End Sub

    Private Sub XFMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.URL = "http://ghana-net.com/X951FMGhanaLiveOnlineRadiofromGhanaLiveStream2.aspx"
    End Sub

    Private Sub CityFMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim w As String
        w = "http://ghana-net.com/CityFMLiveOnlineRadiofromGhanaNjoyRadioLive.aspx"
        AxWindowsMediaPlayer1.URL = w
    End Sub

    Private Sub PeaceFMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.URL = "http://www.peacefmonline.com/streaming/win/"
        'peacefm.Show()
    End Sub

    Private Sub NextTrackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextTrackToolStripMenuItem.Click
        'AxWindowsMediaPlayer1.Controls.next()
    End Sub

    Private Sub VideoTrackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoTrackToolStripMenuItem.Click
        Dim v As New OpenFileDialog
        v.RestoreDirectory = True
        v.Filter = "All Files(*)|*|AVI Videos (*.avi)|*.avi|WMV Videos (*.wmv)|*.wmv|MOV Videos (*.mov)|*.mov|MP4 Videos (*.mp4)|*.mp4|FLV Files (*.FLV|*.FLV"
        v.FilterIndex = 1
        v.FileName = ""
        '
        v.ShowDialog()
        AxWindowsMediaPlayer1.URL = v.FileName
    End Sub

    Private Sub AudioTrackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioTrackToolStripMenuItem.Click
        Dim a As New OpenFileDialog
        a.RestoreDirectory = True
        a.Filter = "MP3 Files (*mp3)|*.mp3|WAV Files (*.wav)|*.wav|WMA Files (*.wma)|*.wma|FLV Files (*.FLV|*.FLV"
        a.FilterIndex = 1
        a.FileName = ""
        a.ShowDialog()
        AxWindowsMediaPlayer1.URL = a.FileName
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomToolStripMenuItem.Click

    End Sub

    Private Sub PreviousTrackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousTrackToolStripMenuItem.Click
        'AxWindowsMediaPlayer1.Controls.previous()
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderToolStripMenuItem.Click
        Dim f As New OpenFileDialog
        f.RestoreDirectory = True
        f.Filter = "All Files(*)|*"
        f.FilterIndex = 1
        f.FileName = ""
        '


        f.ShowDialog()
        AxWindowsMediaPlayer1.URL = f.FileName
    End Sub

    Private Sub OpenDiskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim cd As New OpenFileDialog
        'cd.Filter = "*D:/"
    End Sub

    Private Sub DemoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenToolStripMenuItem.Click

    End Sub
End Class
