<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Theme_Dark_White = New ToolsBox.Switch_Vizual_White()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTC_Ckb = New System.Windows.Forms.CheckBox()
        Me.BCH_Ckb = New System.Windows.Forms.CheckBox()
        Me.LTC_Ckb = New System.Windows.Forms.CheckBox()
        Me.ETH_Ckb = New System.Windows.Forms.CheckBox()
        Me.DOGE_Ckb = New System.Windows.Forms.CheckBox()
        Me.ADA_Ckb = New System.Windows.Forms.CheckBox()
        Me.XRP_Ckb = New System.Windows.Forms.CheckBox()
        Me.XMR_Ckb = New System.Windows.Forms.CheckBox()
        Me.NANO_Ckb = New System.Windows.Forms.CheckBox()
        Me.Hide_btn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CMS_Notify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CurrenciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardanoADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitCoinBTCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitCoinCashBCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiteCoinLTCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EthereumETHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DogeCoinDOGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NanoNANOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoneroXMRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RippleXRPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideTrayIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGadgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Start_Windows_ckb = New System.Windows.Forms.CheckBox()
        Me.Hide_Tray_ckb = New System.Windows.Forms.CheckBox()
        Me.Sound = New System.Windows.Forms.CheckBox()
        Me.Exchange_cbx = New System.Windows.Forms.ComboBox()
        Me.Exchange_lbl = New System.Windows.Forms.Label()
        Me.Timer_Counter_60 = New System.Windows.Forms.Timer(Me.components)
        Me.My_IP_ckb = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Top.SuspendLayout()
        Me.CMS_Notify.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.Silver
        Me.Panel_Top.Controls.Add(Me.Label1)
        Me.Panel_Top.Controls.Add(Me.PictureBox2)
        Me.Panel_Top.Controls.Add(Me.PictureBox1)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(436, 24)
        Me.Panel_Top.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(29, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Crypto Gadgets - By Rômulo Meirelles"
        '
        'Theme_Dark_White
        '
        Me.Theme_Dark_White.Checked = False
        Me.Theme_Dark_White.Color = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Theme_Dark_White.Color_Enabled = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Theme_Dark_White.ColorBack = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Theme_Dark_White.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Theme_Dark_White.Customization = ""
        Me.Theme_Dark_White.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Theme_Dark_White.Image = Nothing
        Me.Theme_Dark_White.Location = New System.Drawing.Point(331, 52)
        Me.Theme_Dark_White.Name = "Theme_Dark_White"
        Me.Theme_Dark_White.NoRounding = False
        Me.Theme_Dark_White.Size = New System.Drawing.Size(35, 19)
        Me.Theme_Dark_White.TabIndex = 19
        Me.Theme_Dark_White.Text = "Switch_Vizual_White1"
        Me.Theme_Dark_White.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(311, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Layout Theme"
        '
        'BTC_Ckb
        '
        Me.BTC_Ckb.AutoSize = True
        Me.BTC_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.BTC_Ckb.Location = New System.Drawing.Point(23, 83)
        Me.BTC_Ckb.Name = "BTC_Ckb"
        Me.BTC_Ckb.Size = New System.Drawing.Size(115, 17)
        Me.BTC_Ckb.TabIndex = 23
        Me.BTC_Ckb.Text = "Show BTC Gadget"
        Me.BTC_Ckb.UseVisualStyleBackColor = True
        '
        'BCH_Ckb
        '
        Me.BCH_Ckb.AutoSize = True
        Me.BCH_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.BCH_Ckb.Location = New System.Drawing.Point(23, 60)
        Me.BCH_Ckb.Name = "BCH_Ckb"
        Me.BCH_Ckb.Size = New System.Drawing.Size(116, 17)
        Me.BCH_Ckb.TabIndex = 24
        Me.BCH_Ckb.Text = "Show BCH Gadget"
        Me.BCH_Ckb.UseVisualStyleBackColor = True
        '
        'LTC_Ckb
        '
        Me.LTC_Ckb.AutoSize = True
        Me.LTC_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.LTC_Ckb.Location = New System.Drawing.Point(23, 152)
        Me.LTC_Ckb.Name = "LTC_Ckb"
        Me.LTC_Ckb.Size = New System.Drawing.Size(114, 17)
        Me.LTC_Ckb.TabIndex = 25
        Me.LTC_Ckb.Text = "Show LTC Gadget"
        Me.LTC_Ckb.UseVisualStyleBackColor = True
        '
        'ETH_Ckb
        '
        Me.ETH_Ckb.AutoSize = True
        Me.ETH_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.ETH_Ckb.Location = New System.Drawing.Point(23, 129)
        Me.ETH_Ckb.Name = "ETH_Ckb"
        Me.ETH_Ckb.Size = New System.Drawing.Size(116, 17)
        Me.ETH_Ckb.TabIndex = 26
        Me.ETH_Ckb.Text = "Show ETH Gadget"
        Me.ETH_Ckb.UseVisualStyleBackColor = True
        '
        'DOGE_Ckb
        '
        Me.DOGE_Ckb.AutoSize = True
        Me.DOGE_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.DOGE_Ckb.Location = New System.Drawing.Point(23, 106)
        Me.DOGE_Ckb.Name = "DOGE_Ckb"
        Me.DOGE_Ckb.Size = New System.Drawing.Size(125, 17)
        Me.DOGE_Ckb.TabIndex = 27
        Me.DOGE_Ckb.Text = "Show DOGE Gadget"
        Me.DOGE_Ckb.UseVisualStyleBackColor = True
        '
        'ADA_Ckb
        '
        Me.ADA_Ckb.AutoSize = True
        Me.ADA_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.ADA_Ckb.Location = New System.Drawing.Point(23, 38)
        Me.ADA_Ckb.Name = "ADA_Ckb"
        Me.ADA_Ckb.Size = New System.Drawing.Size(116, 17)
        Me.ADA_Ckb.TabIndex = 28
        Me.ADA_Ckb.Text = "Show ADA Gadget"
        Me.ADA_Ckb.UseVisualStyleBackColor = True
        '
        'XRP_Ckb
        '
        Me.XRP_Ckb.AutoSize = True
        Me.XRP_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.XRP_Ckb.Location = New System.Drawing.Point(23, 221)
        Me.XRP_Ckb.Name = "XRP_Ckb"
        Me.XRP_Ckb.Size = New System.Drawing.Size(116, 17)
        Me.XRP_Ckb.TabIndex = 29
        Me.XRP_Ckb.Text = "Show XRP Gadget"
        Me.XRP_Ckb.UseVisualStyleBackColor = True
        '
        'XMR_Ckb
        '
        Me.XMR_Ckb.AutoSize = True
        Me.XMR_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.XMR_Ckb.Location = New System.Drawing.Point(23, 198)
        Me.XMR_Ckb.Name = "XMR_Ckb"
        Me.XMR_Ckb.Size = New System.Drawing.Size(118, 17)
        Me.XMR_Ckb.TabIndex = 30
        Me.XMR_Ckb.Text = "Show XMR Gadget"
        Me.XMR_Ckb.UseVisualStyleBackColor = True
        '
        'NANO_Ckb
        '
        Me.NANO_Ckb.AutoSize = True
        Me.NANO_Ckb.ForeColor = System.Drawing.Color.Gray
        Me.NANO_Ckb.Location = New System.Drawing.Point(23, 175)
        Me.NANO_Ckb.Name = "NANO_Ckb"
        Me.NANO_Ckb.Size = New System.Drawing.Size(125, 17)
        Me.NANO_Ckb.TabIndex = 31
        Me.NANO_Ckb.Text = "Show NANO Gadget"
        Me.NANO_Ckb.UseVisualStyleBackColor = True
        '
        'Hide_btn
        '
        Me.Hide_btn.BackColor = System.Drawing.Color.Silver
        Me.Hide_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Hide_btn.FlatAppearance.BorderSize = 0
        Me.Hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hide_btn.Location = New System.Drawing.Point(334, 277)
        Me.Hide_btn.Name = "Hide_btn"
        Me.Hide_btn.Size = New System.Drawing.Size(90, 39)
        Me.Hide_btn.TabIndex = 32
        Me.Hide_btn.Text = "Hide"
        Me.Hide_btn.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.CMS_Notify
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Crypto Gadgets"
        '
        'CMS_Notify
        '
        Me.CMS_Notify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrenciesToolStripMenuItem, Me.RestaureToolStripMenuItem, Me.HideTrayIconToolStripMenuItem, Me.ExitGadgetToolStripMenuItem})
        Me.CMS_Notify.Name = "CMS_Notify"
        Me.CMS_Notify.Size = New System.Drawing.Size(152, 92)
        '
        'CurrenciesToolStripMenuItem
        '
        Me.CurrenciesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardanoADAToolStripMenuItem, Me.BitCoinBTCToolStripMenuItem, Me.BitCoinCashBCHToolStripMenuItem, Me.LiteCoinLTCToolStripMenuItem, Me.EthereumETHToolStripMenuItem, Me.DogeCoinDOGEToolStripMenuItem, Me.NanoNANOToolStripMenuItem, Me.MoneroXMRToolStripMenuItem, Me.RippleXRPToolStripMenuItem})
        Me.CurrenciesToolStripMenuItem.Name = "CurrenciesToolStripMenuItem"
        Me.CurrenciesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CurrenciesToolStripMenuItem.Text = "Currencies"
        '
        'CardanoADAToolStripMenuItem
        '
        Me.CardanoADAToolStripMenuItem.Name = "CardanoADAToolStripMenuItem"
        Me.CardanoADAToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CardanoADAToolStripMenuItem.Text = "Cardano (ADA)"
        '
        'BitCoinBTCToolStripMenuItem
        '
        Me.BitCoinBTCToolStripMenuItem.Name = "BitCoinBTCToolStripMenuItem"
        Me.BitCoinBTCToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BitCoinBTCToolStripMenuItem.Text = "BitCoin (BTC)"
        '
        'BitCoinCashBCHToolStripMenuItem
        '
        Me.BitCoinCashBCHToolStripMenuItem.Name = "BitCoinCashBCHToolStripMenuItem"
        Me.BitCoinCashBCHToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BitCoinCashBCHToolStripMenuItem.Text = "BitCoin Cash (BCH)"
        '
        'LiteCoinLTCToolStripMenuItem
        '
        Me.LiteCoinLTCToolStripMenuItem.Name = "LiteCoinLTCToolStripMenuItem"
        Me.LiteCoinLTCToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LiteCoinLTCToolStripMenuItem.Text = "LiteCoin (LTC)"
        '
        'EthereumETHToolStripMenuItem
        '
        Me.EthereumETHToolStripMenuItem.Name = "EthereumETHToolStripMenuItem"
        Me.EthereumETHToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EthereumETHToolStripMenuItem.Text = "Ethereum (ETH)"
        '
        'DogeCoinDOGEToolStripMenuItem
        '
        Me.DogeCoinDOGEToolStripMenuItem.Name = "DogeCoinDOGEToolStripMenuItem"
        Me.DogeCoinDOGEToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DogeCoinDOGEToolStripMenuItem.Text = "DogeCoin (DOGE)"
        '
        'NanoNANOToolStripMenuItem
        '
        Me.NanoNANOToolStripMenuItem.Enabled = False
        Me.NanoNANOToolStripMenuItem.Name = "NanoNANOToolStripMenuItem"
        Me.NanoNANOToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NanoNANOToolStripMenuItem.Text = "Nano (NANO)"
        '
        'MoneroXMRToolStripMenuItem
        '
        Me.MoneroXMRToolStripMenuItem.Enabled = False
        Me.MoneroXMRToolStripMenuItem.Name = "MoneroXMRToolStripMenuItem"
        Me.MoneroXMRToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MoneroXMRToolStripMenuItem.Text = "Monero (XMR)"
        '
        'RippleXRPToolStripMenuItem
        '
        Me.RippleXRPToolStripMenuItem.Name = "RippleXRPToolStripMenuItem"
        Me.RippleXRPToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RippleXRPToolStripMenuItem.Text = "Ripple (XRP)"
        '
        'RestaureToolStripMenuItem
        '
        Me.RestaureToolStripMenuItem.Name = "RestaureToolStripMenuItem"
        Me.RestaureToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RestaureToolStripMenuItem.Text = "Restaure"
        '
        'HideTrayIconToolStripMenuItem
        '
        Me.HideTrayIconToolStripMenuItem.Name = "HideTrayIconToolStripMenuItem"
        Me.HideTrayIconToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.HideTrayIconToolStripMenuItem.Text = "Hide Tray Icon"
        '
        'ExitGadgetToolStripMenuItem
        '
        Me.ExitGadgetToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ExitGadgetToolStripMenuItem.Name = "ExitGadgetToolStripMenuItem"
        Me.ExitGadgetToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ExitGadgetToolStripMenuItem.Text = "Exit Gadget"
        '
        'Start_Windows_ckb
        '
        Me.Start_Windows_ckb.AutoSize = True
        Me.Start_Windows_ckb.ForeColor = System.Drawing.Color.Gray
        Me.Start_Windows_ckb.Location = New System.Drawing.Point(299, 94)
        Me.Start_Windows_ckb.Name = "Start_Windows_ckb"
        Me.Start_Windows_ckb.Size = New System.Drawing.Size(117, 17)
        Me.Start_Windows_ckb.TabIndex = 34
        Me.Start_Windows_ckb.Text = "Start with Windows"
        Me.Start_Windows_ckb.UseVisualStyleBackColor = True
        '
        'Hide_Tray_ckb
        '
        Me.Hide_Tray_ckb.AutoSize = True
        Me.Hide_Tray_ckb.ForeColor = System.Drawing.Color.Gray
        Me.Hide_Tray_ckb.Location = New System.Drawing.Point(299, 117)
        Me.Hide_Tray_ckb.Name = "Hide_Tray_ckb"
        Me.Hide_Tray_ckb.Size = New System.Drawing.Size(96, 17)
        Me.Hide_Tray_ckb.TabIndex = 35
        Me.Hide_Tray_ckb.Text = "Hide Icon Tray"
        Me.Hide_Tray_ckb.UseVisualStyleBackColor = True
        '
        'Sound
        '
        Me.Sound.AutoSize = True
        Me.Sound.ForeColor = System.Drawing.Color.Gray
        Me.Sound.Location = New System.Drawing.Point(299, 140)
        Me.Sound.Name = "Sound"
        Me.Sound.Size = New System.Drawing.Size(93, 17)
        Me.Sound.TabIndex = 36
        Me.Sound.Text = "Sound Enable"
        Me.Sound.UseVisualStyleBackColor = True
        '
        'Exchange_cbx
        '
        Me.Exchange_cbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exchange_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Exchange_cbx.FormattingEnabled = True
        Me.Exchange_cbx.Location = New System.Drawing.Point(286, 189)
        Me.Exchange_cbx.Name = "Exchange_cbx"
        Me.Exchange_cbx.Size = New System.Drawing.Size(121, 21)
        Me.Exchange_cbx.TabIndex = 37
        '
        'Exchange_lbl
        '
        Me.Exchange_lbl.AutoSize = True
        Me.Exchange_lbl.ForeColor = System.Drawing.Color.Gray
        Me.Exchange_lbl.Location = New System.Drawing.Point(284, 171)
        Me.Exchange_lbl.Name = "Exchange_lbl"
        Me.Exchange_lbl.Size = New System.Drawing.Size(58, 13)
        Me.Exchange_lbl.TabIndex = 38
        Me.Exchange_lbl.Text = "Exchange:"
        '
        'Timer_Counter_60
        '
        '
        'My_IP_ckb
        '
        Me.My_IP_ckb.AutoSize = True
        Me.My_IP_ckb.ForeColor = System.Drawing.Color.Gray
        Me.My_IP_ckb.Location = New System.Drawing.Point(23, 256)
        Me.My_IP_ckb.Name = "My_IP_ckb"
        Me.My_IP_ckb.Size = New System.Drawing.Size(83, 17)
        Me.My_IP_ckb.TabIndex = 39
        Me.My_IP_ckb.Text = "Show My IP"
        Me.My_IP_ckb.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Night_24x24
        Me.PictureBox4.Location = New System.Drawing.Point(372, 47)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Day_24x24
        Me.PictureBox3.Location = New System.Drawing.Point(301, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Close_16x16
        Me.PictureBox2.Location = New System.Drawing.Point(413, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.InfinityLogo_16x16
        Me.PictureBox1.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(436, 328)
        Me.Controls.Add(Me.My_IP_ckb)
        Me.Controls.Add(Me.Exchange_lbl)
        Me.Controls.Add(Me.Exchange_cbx)
        Me.Controls.Add(Me.Sound)
        Me.Controls.Add(Me.Hide_Tray_ckb)
        Me.Controls.Add(Me.Start_Windows_ckb)
        Me.Controls.Add(Me.Hide_btn)
        Me.Controls.Add(Me.NANO_Ckb)
        Me.Controls.Add(Me.XMR_Ckb)
        Me.Controls.Add(Me.XRP_Ckb)
        Me.Controls.Add(Me.ADA_Ckb)
        Me.Controls.Add(Me.DOGE_Ckb)
        Me.Controls.Add(Me.ETH_Ckb)
        Me.Controls.Add(Me.LTC_Ckb)
        Me.Controls.Add(Me.BCH_Ckb)
        Me.Controls.Add(Me.BTC_Ckb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Theme_Dark_White)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crypto Gadgets."
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.CMS_Notify.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Theme_Dark_White As ToolsBox.Switch_Vizual_White
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTC_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents BCH_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents LTC_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents ETH_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents DOGE_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents ADA_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents XRP_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents XMR_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents NANO_Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents Hide_btn As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents CMS_Notify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CurrenciesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CardanoADAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitCoinBTCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitCoinCashBCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiteCoinLTCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EthereumETHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DogeCoinDOGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NanoNANOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoneroXMRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RippleXRPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitGadgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Start_Windows_ckb As System.Windows.Forms.CheckBox
    Friend WithEvents Hide_Tray_ckb As System.Windows.Forms.CheckBox
    Friend WithEvents HideTrayIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sound As System.Windows.Forms.CheckBox
    Friend WithEvents Exchange_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Exchange_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer_Counter_60 As System.Windows.Forms.Timer
    Friend WithEvents My_IP_ckb As System.Windows.Forms.CheckBox
End Class
