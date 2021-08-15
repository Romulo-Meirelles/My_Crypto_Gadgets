Imports ToolsBox.Utils
Imports ToolsBox.Utils.Mouse_Objeto
Public Class My_IP
    Private Information() As String = Nothing
    Public Lock As Boolean = False

    Private Sub My_IP_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.My_IP_Position = Me.Location
        My.Settings.My_IP_Lock = Lock
        My.Settings.Save()
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = My.Settings.My_IP_Position
        Lock = My.Settings.My_IP_Lock

        If Lock = True Then
            Pin_Pic.Image = My.Resources.Lock_8x8
        Else
            Pin_Pic.Image = My.Resources.Pin_8x8
        End If

        If My.Settings.Sound = True Then
            My.Computer.Audio.Play(My.Resources.Open, AudioPlayMode.Background)
        End If

        CarregaBordas(Me, 20)
        BackgroundWorker1.RunWorkerAsync()
        Timer1.Start()
    End Sub

    Private Sub Close_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Config.My_IP_ckb.Checked = False
        Timer1.Stop()

        If Application.OpenForms.Count <= 1 Then
            Config.Hide_Tray_ckb.Checked = False
            Config.NotifyIcon1.Visible = True
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Gadgets_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Gadgets_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Crypto_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles IP_Pic.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Crypto_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles IP_Pic.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Currency_Price_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Currency_Price_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Exchange_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Local_lbl.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Exchange_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Local_lbl.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Price_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles IP_lbl.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Price_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles IP_lbl.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Config_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Config_Pic.Click
        Try
            Config.Show()
            Config.NotifyIcon1.Visible = False
            My.Settings.Config_Hide = False
            My.Settings.Save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            Dim IP As New Tools.Internet_Protocol
            Information = IP.GetMyIP
        Catch ex As Exception
            IP_Pic.Image = My.Resources.IP_Red
        End Try
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            IP_lbl.Text = "IP: " & Information(0)
            Local_lbl.Text = Information(1) & ", " & Information(2) & ". " & Information(3)
            Servico_lbl.Text = Information(4)
            IP_Pic.Image = My.Resources.IP_Green
        Catch ex As Exception
            IP_Pic.Image = My.Resources.IP_Red
        End Try
       
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If BackgroundWorker1.IsBusy = True Then
        Else
            ProgressBar_Radial.Value = Config.TimeSec
            If ProgressBar_Radial.Value = 0 Then
                BackgroundWorker1.RunWorkerAsync()
            ElseIf ProgressBar_Radial.Value = -60 Then
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub Pin_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Pin_Pic.Click
        If Lock = True Then
            Lock = False
            Pin_Pic.Image = My.Resources.Pin_8x8
            My.Settings.My_IP_Lock = Lock
            My.Settings.Save()
        Else
            Lock = True
            Pin_Pic.Image = My.Resources.Lock_8x8
            My.Settings.My_IP_Lock = Lock
            My.Settings.Save()
        End If
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            ' turn on WS_EX_TOOLWINDOW style bit
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property
End Class
