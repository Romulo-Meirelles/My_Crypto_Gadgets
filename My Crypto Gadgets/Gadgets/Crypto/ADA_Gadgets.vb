Imports ToolsBox.Utils
Imports ToolsBox.Utils.Mouse_Objeto

Public Class Gadgets_ADA
    Private Price As String = Nothing
    Public Lock As Boolean = False
    ' Private ItemExchange As String


    Private Sub Gadgets_ADA_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ADA_Position = Me.Location
        My.Settings.ADA_Lock = Lock
        My.Settings.Save()
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = My.Settings.ADA_Position
        Lock = My.Settings.ADA_Lock

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

    Private Sub Close_Click(sender As System.Object, e As System.EventArgs) Handles Close_Pic.Click
        Config.ADA_Ckb.Checked = False
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

    Private Sub Crypto_Pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Crypto_Pic.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Crypto_Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Crypto_Pic.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Currency_Price_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Currency_Price.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Currency_Price_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Currency_Price.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Exchange_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Exchange_lbl.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Exchange_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Exchange_lbl.MouseMove
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

    Private Sub Price_lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Price_lbl.MouseDown
        If Lock Then
        Else
            Mouse_Objeto.MouseDown(sender, e)
        End If
    End Sub

    Private Sub Price_lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Price_lbl.MouseMove
        If Lock Then
        Else
            Mouse_Objeto.MouseMove(sender, e, Me)
        End If
    End Sub

    Private Sub Config_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Config_Pic.Click
        Try

            Config.WindowState = FormWindowState.Normal
            Config.ShowInTaskbar = True
            Config.Show()
            Config.NotifyIcon1.Visible = False
            My.Settings.Config_Hide = False
            My.Settings.Save()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            If My.Settings.Exchange = "Binance" Then
                Dim T As New Tools.Crypto
                Dim C() = T.GetPriceBinance("ADAUSDT")
                Price = FormatNumber(C(1).Replace(".", ","), 2) & " USD"

            ElseIf My.Settings.Exchange = "Bittrex" Then
                Dim T As New Tools.Crypto
                Dim C() = T.GetPriceBittrex("ADA-USDT")
                Price = FormatNumber(C(1).Replace(".", ","), 2) & " USD"

            ElseIf My.Settings.Exchange = "Bitfinex" Then
                Dim T As New Tools.Crypto
                Dim C() = T.GetPriceBitfinex("tADAUSD")
                Price = FormatNumber(C(6).Replace(".", ","), 2) & " USD"

            Else
                Price = "Wait..."
            End If

        Catch ex As Exception
            Price = "Wait..."
        End Try
       
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Price_lbl.Text = Price

        If My.Settings.Exchange = "Binance" Then
            Exchange_lbl.Text = "Exchange: Binance"
        ElseIf My.Settings.Exchange = "Bittrex" Then
            Exchange_lbl.Text = "Exchange: Bittrex"
        ElseIf My.Settings.Exchange = "Bitfinex" Then
            Exchange_lbl.Text = "Exchange: Bifinex"

        Else
            Price = "Wait..."
        End If
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
        Else
            Lock = True
            Pin_Pic.Image = My.Resources.Lock_8x8
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
