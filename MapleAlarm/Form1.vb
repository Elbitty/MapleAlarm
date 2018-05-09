Public Class Form1

    Dim MuseumTimeMin As Integer
    Dim MuseumTimeSec As Integer

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub ToTray()
        Me.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(200)
    End Sub


    Private Sub notifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
        Me.Activate()
        Me.NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If FormWindowState.Minimized = WindowState Then ToTray()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/Elbitty")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PinkThe.Enabled = True
        Else
            PinkThe.Enabled = False
        End If
    End Sub

    Private Sub PinkThe_Tick(sender As Object, e As EventArgs) Handles PinkThe.Tick

        If Mid(TimeString, 4, 5) = "14:15" Then
            NotifyIcon1.ShowBalloonTip(200, "핑크빈 씨어터", "곧 정시 15분 입니다. 핑크빈 씨어터에 방문하세요.", ToolTipIcon.Info)
            My.Computer.Audio.Play(My.Resources.Resource1.up, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Everyday.Enabled = True
        Else
            Everyday.Enabled = False
        End If
    End Sub

    Private Sub Everyday_Tick(sender As Object, e As EventArgs) Handles Everyday.Tick

        If TimeString = "23:59:05" Then
            NotifyIcon1.ShowBalloonTip(200, "날짜 변경", "곧 0시입니다. 마일리지를 정산 하세요. 데일리 기프트를 수령하세요.", ToolTipIcon.Info)
            My.Computer.Audio.Play(My.Resources.Resource1.trans, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            Museum.Enabled = True
            MuseumTimeMin = Val(Mid(TimeString, 4, 2))
            MuseumTimeSec = Val(Mid(TimeString, 7, 2))

            Debug.Print(MuseumTimeSec)

            MuseumTimeMin = MuseumTimeMin + 42
            Debug.Print(MuseumTimeMin)

            If MuseumTimeMin >= 60 Then MuseumTimeMin = MuseumTimeMin - 60
        Else
            Museum.Enabled = False
        End If
    End Sub

    Private Sub Museum_Tick(sender As Object, e As EventArgs) Handles Museum.Tick

        Dim MuseumTime As String = MuseumTimeMin.ToString & ":" & MuseumTimeSec.ToString

        If Mid(TimeString, 4, 5) = MuseumTime Then
            NotifyIcon1.ShowBalloonTip(200, "ARK 뮤지엄", "성향 500을 모두 달성했습니다.", ToolTipIcon.Info)
            My.Computer.Audio.Play(My.Resources.Resource1.up, AudioPlayMode.Background)
            CheckBox12.Checked = False
            Museum.Enabled = False
        End If


    End Sub
End Class
