Imports System.Drawing
Imports ToolsBox.Utils
Public Class Config

    Public Hid As Boolean = False
    Public Property TimeSec As Decimal = 60

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        CarregaBordas(Hide_btn, 10)
        CarregaBordas(Me, 10)
        Exchange_cbx.Items.AddRange({"Bittrex", "Binance", "Bitfinex"})
        Call SelectColor()
        Call CheckBoxes()
        Timer_Counter_60.Start()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Config_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If Hid = True Then
            Me.Hide()
            Hid = False
        End If
    End Sub

    Private Sub Config_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Hid = True Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Config_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms.OfType(Of Gadgets_ADA).Any Then
            My.Settings.ADA_Position = Gadgets_ADA.Location
            My.Settings.ADA_Lock = Gadgets_ADA.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_BCH).Any Then
            My.Settings.BCH_Position = Gadgets_BCH.Location
            My.Settings.BCH_Lock = Gadgets_BCH.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_BTC).Any Then
            My.Settings.BTC_Position = Gadgets_BTC.Location
            My.Settings.BTC_Lock = Gadgets_BTC.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_DOGE).Any Then
            My.Settings.DOGE_Position = Gadgets_DOGE.Location
            My.Settings.DOGE_Lock = Gadgets_DOGE.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_ETH).Any Then
            My.Settings.ETH_Position = Gadgets_ETH.Location
            My.Settings.ETH_Lock = Gadgets_ETH.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_LTC).Any Then
            My.Settings.LTC_Position = Gadgets_LTC.Location
            My.Settings.LTC_Lock = Gadgets_LTC.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_NANO).Any Then
            My.Settings.NANO_Position = Gadgets_NANO.Location
            My.Settings.NANO_Lock = Gadgets_NANO.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_XMR).Any Then
            My.Settings.XMR_Position = Gadgets_XMR.Location
            My.Settings.XMR_Lock = Gadgets_XMR.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of Gadgets_XRP).Any Then
            My.Settings.XRP_Position = Gadgets_XRP.Location
            My.Settings.XRP_Lock = Gadgets_XRP.Lock
        Else
        End If

        If Application.OpenForms.OfType(Of My_IP).Any Then
            My.Settings.My_IP_Position = My_IP.Location
            My.Settings.My_IP_Lock = My_IP.Lock
        Else
        End If

        My.Settings.Save()
    End Sub
    Private Sub SelectColor()
        If My.Settings.Night_And_Day = True Then
            Theme_Dark_White.Checked = True 'BLACK
            Me.Panel_Top.BackColor = Color.FromArgb(25, 30, 35)
            Me.BackColor = Color.FromArgb(25, 30, 44)
            Gadgets_BTC.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_BTC.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_BTC.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_ADA.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_ADA.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_ADA.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_BCH.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_BCH.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_BCH.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_DOGE.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_DOGE.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_DOGE.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_ETH.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_ETH.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_ETH.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_LTC.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_LTC.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_LTC.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_NANO.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_NANO.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_NANO.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_XMR.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_XMR.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_XMR.Price_lbl.ForeColor = Color.LimeGreen
            Gadgets_XRP.BackColor = Color.FromArgb(25, 30, 44) : Gadgets_XRP.Currency_Price.ForeColor = Color.MediumSpringGreen : Gadgets_XRP.Price_lbl.ForeColor = Color.LimeGreen
            My_IP.BackColor = Color.FromArgb(25, 30, 44) : My_IP.IP_lbl.ForeColor = Color.MediumSpringGreen : My_IP.Local_lbl.ForeColor = Color.DeepSkyBlue : My_IP.Servico_lbl.ForeColor = Color.LightSteelBlue

        Else
            Theme_Dark_White.Checked = False 'WHITE
            Me.Panel_Top.BackColor = Color.Silver
            Me.BackColor = Color.Gainsboro
            Gadgets_BTC.BackColor = Color.Gainsboro : Gadgets_BTC.Currency_Price.ForeColor = Color.Gray : Gadgets_BTC.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_ADA.BackColor = Color.Gainsboro : Gadgets_ADA.Currency_Price.ForeColor = Color.Gray : Gadgets_ADA.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_BCH.BackColor = Color.Gainsboro : Gadgets_BCH.Currency_Price.ForeColor = Color.Gray : Gadgets_BCH.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_DOGE.BackColor = Color.Gainsboro : Gadgets_DOGE.Currency_Price.ForeColor = Color.Gray : Gadgets_DOGE.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_ETH.BackColor = Color.Gainsboro : Gadgets_ETH.Currency_Price.ForeColor = Color.Gray : Gadgets_ETH.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_LTC.BackColor = Color.Gainsboro : Gadgets_LTC.Currency_Price.ForeColor = Color.Gray : Gadgets_LTC.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_NANO.BackColor = Color.Gainsboro : Gadgets_NANO.Currency_Price.ForeColor = Color.Gray : Gadgets_NANO.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_XMR.BackColor = Color.Gainsboro : Gadgets_XMR.Currency_Price.ForeColor = Color.Gray : Gadgets_XMR.Price_lbl.ForeColor = Color.DarkGreen
            Gadgets_XRP.BackColor = Color.Gainsboro : Gadgets_XRP.Currency_Price.ForeColor = Color.Gray : Gadgets_XRP.Price_lbl.ForeColor = Color.DarkGreen
            My_IP.BackColor = Color.Gainsboro : My_IP.IP_lbl.ForeColor = Color.Gray : My_IP.Local_lbl.ForeColor = Color.DarkGreen : My_IP.Servico_lbl.ForeColor = Color.DarkBlue

        End If
    End Sub
    Private Sub CCT()
        If Theme_Dark_White.Checked = True Then
            Me.Panel_Top.BackColor = Color.FromArgb(25, 30, 35)
            Me.BackColor = Color.FromArgb(25, 30, 44)
            My.Settings.Night_And_Day = True
            My.Settings.Save()
            Call SelectColor()
        Else
            Me.BackColor = Color.Gainsboro
            Me.Panel_Top.BackColor = Color.Silver
            My.Settings.Night_And_Day = False
            My.Settings.Save()
            Call SelectColor()
        End If
    End Sub


    Private Sub CheckBoxes()

        'START TO TRAY
        If My.Settings.Hide_Tray = True Then
            Hide_Tray_ckb.Checked = True
        Else
            Hide_Tray_ckb.Checked = False
        End If

        'START WINDOWS
        If My.Settings.Start_Windows = True Then
            Start_Windows_ckb.Checked = True
        Else
            Start_Windows_ckb.Checked = False
        End If

        'SOUND
        If My.Settings.Sound = True Then
            Sound.Checked = True
        Else
            Sound.Checked = False
        End If

        'EXCHANGE
        Exchange_cbx.SelectedItem = My.Settings.Exchange

        If My.Settings.ADA_Ativate = True Then
            ADA_Ckb.Checked = True
        Else
            ADA_Ckb.Checked = False
        End If

        If My.Settings.BTC_Ativate = True Then
            BTC_Ckb.Checked = True
        Else
            BTC_Ckb.Checked = False
        End If

        If My.Settings.BCH_Ativate = True Then
            BCH_Ckb.Checked = True
        Else
            BCH_Ckb.Checked = False
        End If

        If My.Settings.DOGE_Ativate = True Then
            DOGE_Ckb.Checked = True
        Else
            DOGE_Ckb.Checked = False
        End If

        If My.Settings.ETH_Ativate = True Then
            ETH_Ckb.Checked = True
        Else
            ETH_Ckb.Checked = False
        End If

        If My.Settings.LTC_Ativate = True Then
            LTC_Ckb.Checked = True
        Else
            LTC_Ckb.Checked = False
        End If

        If My.Settings.NANO_Ativate = True Then
            NANO_Ckb.Checked = True
        Else
            NANO_Ckb.Checked = False
        End If

        If My.Settings.XMR_Ativate = True Then
            XMR_Ckb.Checked = True
        Else
            XMR_Ckb.Checked = False
        End If

        If My.Settings.XRP_Ativate = True Then
            XRP_Ckb.Checked = True
        Else
            XRP_Ckb.Checked = False
        End If

        If My.Settings.My_IP_Activate = True Then
            My_IP_ckb.Checked = True
        Else
            My_IP_ckb.Checked = False
        End If

      
    End Sub


    Private Sub Gadgets()
        On Error Resume Next

        If My.Settings.ADA_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_ADA).Any Then
            Else
                Gadgets_ADA.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_ADA).Any Then
                Gadgets_ADA.Close()
            Else
            End If
        End If

        If My.Settings.BTC_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_BTC).Any Then
            Else
                Gadgets_BTC.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_BTC).Any Then
                Gadgets_BTC.Close()
            Else
            End If
        End If

        If My.Settings.BCH_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_BCH).Any Then
            Else
                Gadgets_BCH.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_BCH).Any Then
                Gadgets_BCH.Close()
            Else
            End If
        End If

        If My.Settings.DOGE_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_DOGE).Any Then
            Else
                Gadgets_DOGE.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_DOGE).Any Then
                Gadgets_DOGE.Close()
            Else
            End If
        End If

        If My.Settings.ETH_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_ETH).Any Then
            Else
                Gadgets_ETH.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_ETH).Any Then
                Gadgets_ETH.Close()
            Else
            End If
        End If

        If My.Settings.LTC_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_LTC).Any Then
            Else
                Gadgets_LTC.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_LTC).Any Then
                Gadgets_LTC.Close()
            Else
            End If
        End If

        If My.Settings.NANO_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_NANO).Any Then
            Else
                Gadgets_NANO.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_NANO).Any Then
                Gadgets_NANO.Close()
            Else
            End If
        End If

        If My.Settings.XMR_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_XMR).Any Then
            Else
                Gadgets_XMR.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_XMR).Any Then
                Gadgets_XMR.Close()
            Else
            End If
        End If

        If My.Settings.XRP_Ativate = True Then
            If Application.OpenForms.OfType(Of Gadgets_XRP).Any Then
            Else
                Gadgets_XRP.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of Gadgets_XRP).Any Then
                Gadgets_XRP.Close()
            Else
            End If
        End If

        If My.Settings.My_IP_Activate = True Then
            If Application.OpenForms.OfType(Of My_IP).Any Then
            Else
                My_IP.Show()
            End If
        Else
            If Application.OpenForms.OfType(Of My_IP).Any Then
                My_IP.Close()
            Else
            End If
        End If
        Call SelectColor()
    End Sub

    Private Sub Theme_Dark_White_CheckedChanged(sender As System.Object) Handles Theme_Dark_White.CheckedChanged
        Call CCT()
    End Sub

    Private Sub Hide_btn_Click(sender As System.Object, e As System.EventArgs) Handles Hide_btn.Click
        Try
            Me.Hide()
            My.Settings.Config_Hide = True
            My.Settings.Save()

            If Hide_Tray_ckb.Checked = False Then
                NotifyIcon1.Visible = True
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.ShowInTaskbar = True
            My.Settings.Config_Hide = False
            My.Settings.Save()
            NotifyIcon1.Visible = False
            Me.Show()
            '   Me.Select()
            Me.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Do you want to close the program?", "Close.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End
        Else
        End If
    End Sub

    Private Sub Panel_Top_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseDown
        Mouse_Objeto.MouseDown(sender, e)
    End Sub

    Private Sub Panel_Top_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel_Top.MouseMove
        Mouse_Objeto.MouseMove(sender, e, Me)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        Mouse_Objeto.MouseDown(sender, e)
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        Mouse_Objeto.MouseMove(sender, e, Me)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Mouse_Objeto.MouseDown(sender, e)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Mouse_Objeto.MouseMove(sender, e, Me)
    End Sub
    Private Sub ADA_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ADA_Ckb.CheckedChanged
        If ADA_Ckb.Checked = True Then
            My.Settings.ADA_Ativate = True : My.Settings.Save()
            CardanoADAToolStripMenuItem.Checked = True
        Else
            My.Settings.ADA_Ativate = False : My.Settings.Save()
            CardanoADAToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub BTC_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BTC_Ckb.CheckedChanged
        If BTC_Ckb.Checked = True Then
            My.Settings.BTC_Ativate = True : My.Settings.Save()
            BitCoinBTCToolStripMenuItem.Checked = True
        Else
            My.Settings.BTC_Ativate = False : My.Settings.Save()
            BitCoinBTCToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub BCH_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BCH_Ckb.CheckedChanged
        If BCH_Ckb.Checked = True Then
            My.Settings.BCH_Ativate = True : My.Settings.Save()
            BitCoinCashBCHToolStripMenuItem.Checked = True
        Else
            My.Settings.BCH_Ativate = False : My.Settings.Save()
            BitCoinCashBCHToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub
    Private Sub DOGE_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles DOGE_Ckb.CheckedChanged
        If DOGE_Ckb.Checked = True Then
            My.Settings.DOGE_Ativate = True : My.Settings.Save()
            DogeCoinDOGEToolStripMenuItem.Checked = True
        Else
            My.Settings.DOGE_Ativate = False : My.Settings.Save()
            DogeCoinDOGEToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub ETH_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ETH_Ckb.CheckedChanged
        If ETH_Ckb.Checked = True Then
            My.Settings.ETH_Ativate = True : My.Settings.Save()
            EthereumETHToolStripMenuItem.Checked = True
        Else
            My.Settings.ETH_Ativate = False : My.Settings.Save()
            EthereumETHToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub LTC_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles LTC_Ckb.CheckedChanged
        If LTC_Ckb.Checked = True Then
            My.Settings.LTC_Ativate = True : My.Settings.Save()
            LiteCoinLTCToolStripMenuItem.Checked = True
        Else
            My.Settings.LTC_Ativate = False : My.Settings.Save()
            LiteCoinLTCToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub NANO_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NANO_Ckb.CheckedChanged
        If NANO_Ckb.Checked = True Then
            My.Settings.NANO_Ativate = True : My.Settings.Save()
            NanoNANOToolStripMenuItem.Checked = True
        Else
            My.Settings.NANO_Ativate = False : My.Settings.Save()
            NanoNANOToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub XMR_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles XMR_Ckb.CheckedChanged
        If XMR_Ckb.Checked = True Then
            My.Settings.XMR_Ativate = True : My.Settings.Save()
            MoneroXMRToolStripMenuItem.Checked = True
        Else
            My.Settings.XMR_Ativate = False : My.Settings.Save()
            MoneroXMRToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub

    Private Sub XRP_Ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles XRP_Ckb.CheckedChanged
        If XRP_Ckb.Checked = True Then
            My.Settings.XRP_Ativate = True : My.Settings.Save()
            RippleXRPToolStripMenuItem.Checked = True
        Else
            My.Settings.XRP_Ativate = False : My.Settings.Save()
            RippleXRPToolStripMenuItem.Checked = False
        End If
        Call Gadgets()
    End Sub
    Private Sub My_IP_ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles My_IP_ckb.CheckedChanged
        If My_IP_ckb.Checked = True Then
            My.Settings.My_IP_Activate = True : My.Settings.Save()
        Else
            My.Settings.My_IP_Activate = False : My.Settings.Save()
        End If
        Call Gadgets()
    End Sub
    '------------------ CMS ------------------

    Private Sub CardanoADAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CardanoADAToolStripMenuItem.Click
        If CardanoADAToolStripMenuItem.Checked = True Then
            ADA_Ckb.Checked = False
        Else
            ADA_Ckb.Checked = True
        End If
    End Sub

    Private Sub BitCoinBTCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BitCoinBTCToolStripMenuItem.Click
        If BitCoinBTCToolStripMenuItem.Checked = True Then
            BTC_Ckb.Checked = False
        Else
            BTC_Ckb.Checked = True
        End If

    End Sub

    Private Sub BitCoinCashBCHToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BitCoinCashBCHToolStripMenuItem.Click
        If BitCoinCashBCHToolStripMenuItem.Checked = True Then
            BCH_Ckb.Checked = False
        Else
            BCH_Ckb.Checked = True
        End If
    End Sub

    Private Sub LiteCoinLTCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LiteCoinLTCToolStripMenuItem.Click
        If LiteCoinLTCToolStripMenuItem.Checked = True Then
            LTC_Ckb.Checked = False
        Else
            LTC_Ckb.Checked = True
        End If
    End Sub

    Private Sub EthereumETHToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EthereumETHToolStripMenuItem.Click
        If EthereumETHToolStripMenuItem.Checked = True Then
            ETH_Ckb.Checked = False
        Else
            ETH_Ckb.Checked = True
        End If
    End Sub

    Private Sub DogeCoinDOGEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DogeCoinDOGEToolStripMenuItem.Click
        If DogeCoinDOGEToolStripMenuItem.Checked = True Then
            DOGE_Ckb.Checked = False
        Else
            DOGE_Ckb.Checked = True
        End If
    End Sub

    Private Sub NanoNANOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NanoNANOToolStripMenuItem.Click
        If NanoNANOToolStripMenuItem.Checked = True Then
            NANO_Ckb.Checked = False
        Else
            NANO_Ckb.Checked = True
        End If
    End Sub

    Private Sub MoneroXMRToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles MoneroXMRToolStripMenuItem.Click
        If MoneroXMRToolStripMenuItem.Checked = True Then
            XMR_Ckb.Checked = False
        Else
            XMR_Ckb.Checked = True
        End If
    End Sub

    Private Sub RippleXRPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RippleXRPToolStripMenuItem.Click
        If RippleXRPToolStripMenuItem.Checked = True Then
            XRP_Ckb.Checked = False
        Else
            XRP_Ckb.Checked = True
        End If
    End Sub

    Private Sub RestaureToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestaureToolStripMenuItem.Click
        Try
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
            Me.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitGadgetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitGadgetToolStripMenuItem.Click
        If MessageBox.Show("Do you want to close the program?", "Close.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            End
        Else
        End If
    End Sub

    Private Sub HideTrayIconToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HideTrayIconToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Hide_Tray_ckb.Checked = True
    End Sub

    Private Sub Hide_Tray_ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Hide_Tray_ckb.CheckedChanged
        If Hide_Tray_ckb.Checked = True Then
            If Application.OpenForms.Count <= 1 Then
                Hide_Tray_ckb.Checked = False
            Else
                My.Settings.Hide_Tray = True
            End If
        Else
            My.Settings.Hide_Tray = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub Start_Windows_ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Start_Windows_ckb.CheckedChanged
        If Start_Windows_ckb.Checked = True Then
            My.Settings.Start_Windows = True
            Tools.RegistryInsert()
        Else
            My.Settings.Start_Windows = False
            Tools.RegistryDelete()
        End If
        My.Settings.Save()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Sound.CheckedChanged
        If Sound.Checked = True Then
            My.Settings.Sound = True
        Else
            My.Settings.Sound = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub Exchange_cbx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Exchange_cbx.SelectedIndexChanged
        Try
            My.Settings.Exchange = Exchange_cbx.SelectedItem.ToString
            My.Settings.Save()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer_Counter_60_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Counter_60.Tick
        If TimeSec = -60 Then
            TimeSec = 60
        End If
        TimeSec -= CDec(0.1)
    End Sub
End Class