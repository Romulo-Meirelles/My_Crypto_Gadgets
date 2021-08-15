<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadgets_XRP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gadgets_XRP))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Price_lbl = New System.Windows.Forms.Label()
        Me.Currency_Price = New System.Windows.Forms.Label()
        Me.Exchange_lbl = New System.Windows.Forms.Label()
        Me.Config_Pic = New System.Windows.Forms.PictureBox()
        Me.Close_Pic = New System.Windows.Forms.PictureBox()
        Me.Crypto_Pic = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pin_Pic = New System.Windows.Forms.PictureBox()
        Me.ProgressBar_Radial = New ToolsBox.ProgressBar_Radial_2()
        Me.Panel1.SuspendLayout()
        CType(Me.Config_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Crypto_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pin_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Price_lbl)
        Me.Panel1.Location = New System.Drawing.Point(58, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 35)
        Me.Panel1.TabIndex = 1
        '
        'Price_lbl
        '
        Me.Price_lbl.Font = New System.Drawing.Font("Dungeon", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price_lbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.Price_lbl.Location = New System.Drawing.Point(8, 7)
        Me.Price_lbl.Name = "Price_lbl"
        Me.Price_lbl.Size = New System.Drawing.Size(136, 21)
        Me.Price_lbl.TabIndex = 0
        Me.Price_lbl.Text = "Wait..."
        Me.Price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Currency_Price
        '
        Me.Currency_Price.AutoSize = True
        Me.Currency_Price.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Currency_Price.Location = New System.Drawing.Point(66, 12)
        Me.Currency_Price.Name = "Currency_Price"
        Me.Currency_Price.Size = New System.Drawing.Size(89, 13)
        Me.Currency_Price.TabIndex = 2
        Me.Currency_Price.Text = "XRP Crypto Price"
        '
        'Exchange_lbl
        '
        Me.Exchange_lbl.AutoSize = True
        Me.Exchange_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Exchange_lbl.Location = New System.Drawing.Point(66, 50)
        Me.Exchange_lbl.Name = "Exchange_lbl"
        Me.Exchange_lbl.Size = New System.Drawing.Size(90, 13)
        Me.Exchange_lbl.TabIndex = 3
        Me.Exchange_lbl.Text = "Exchange: Bittrex"
        '
        'Config_Pic
        '
        Me.Config_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Config_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.services_8x8
        Me.Config_Pic.Location = New System.Drawing.Point(182, 6)
        Me.Config_Pic.Name = "Config_Pic"
        Me.Config_Pic.Size = New System.Drawing.Size(8, 8)
        Me.Config_Pic.TabIndex = 5
        Me.Config_Pic.TabStop = False
        '
        'Close_Pic
        '
        Me.Close_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Close_8x8
        Me.Close_Pic.Location = New System.Drawing.Point(198, 6)
        Me.Close_Pic.Name = "Close_Pic"
        Me.Close_Pic.Size = New System.Drawing.Size(8, 8)
        Me.Close_Pic.TabIndex = 4
        Me.Close_Pic.TabStop = False
        '
        'Crypto_Pic
        '
        Me.Crypto_Pic.BackColor = System.Drawing.Color.Transparent
        Me.Crypto_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.XRP_48x48
        Me.Crypto_Pic.Location = New System.Drawing.Point(12, 12)
        Me.Crypto_Pic.Name = "Crypto_Pic"
        Me.Crypto_Pic.Size = New System.Drawing.Size(48, 48)
        Me.Crypto_Pic.TabIndex = 0
        Me.Crypto_Pic.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        '
        'Pin_Pic
        '
        Me.Pin_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pin_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Pin_8x8
        Me.Pin_Pic.Location = New System.Drawing.Point(166, 6)
        Me.Pin_Pic.Name = "Pin_Pic"
        Me.Pin_Pic.Size = New System.Drawing.Size(8, 8)
        Me.Pin_Pic.TabIndex = 14
        Me.Pin_Pic.TabStop = False
        '
        'ProgressBar_Radial
        '
        Me.ProgressBar_Radial.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.BaseColour = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.BorderColour = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.Location = New System.Drawing.Point(185, 47)
        Me.ProgressBar_Radial.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.ProgressBar_Radial.Name = "ProgressBar_Radial"
        Me.ProgressBar_Radial.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ProgressBar_Radial.RotationAngle = 360
        Me.ProgressBar_Radial.Size = New System.Drawing.Size(20, 20)
        Me.ProgressBar_Radial.StartingAngle = 275
        Me.ProgressBar_Radial.TabIndex = 15
        Me.ProgressBar_Radial.Text = "ProgressBar_Radial_21"
        Me.ProgressBar_Radial.TextColour = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Gadgets_XRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(213, 74)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar_Radial)
        Me.Controls.Add(Me.Pin_Pic)
        Me.Controls.Add(Me.Config_Pic)
        Me.Controls.Add(Me.Close_Pic)
        Me.Controls.Add(Me.Exchange_lbl)
        Me.Controls.Add(Me.Currency_Price)
        Me.Controls.Add(Me.Crypto_Pic)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gadgets_XRP"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "My Gadgets"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Config_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Crypto_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pin_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Crypto_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Price_lbl As System.Windows.Forms.Label
    Friend WithEvents Currency_Price As System.Windows.Forms.Label
    Friend WithEvents Exchange_lbl As System.Windows.Forms.Label
    Friend WithEvents Close_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Config_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Pin_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar_Radial As ToolsBox.ProgressBar_Radial_2

End Class
