<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_IP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(My_IP))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IP_lbl = New System.Windows.Forms.Label()
        Me.Local_lbl = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar_Radial = New ToolsBox.ProgressBar_Radial_2()
        Me.IP_Pic = New System.Windows.Forms.PictureBox()
        Me.Pin_Pic = New System.Windows.Forms.PictureBox()
        Me.Config_Pic = New System.Windows.Forms.PictureBox()
        Me.Close_Pic = New System.Windows.Forms.PictureBox()
        Me.Servico_lbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.IP_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pin_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Config_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Servico_lbl)
        Me.Panel1.Controls.Add(Me.ProgressBar_Radial)
        Me.Panel1.Controls.Add(Me.IP_lbl)
        Me.Panel1.Controls.Add(Me.Local_lbl)
        Me.Panel1.Location = New System.Drawing.Point(74, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 81)
        Me.Panel1.TabIndex = 1
        '
        'IP_lbl
        '
        Me.IP_lbl.Font = New System.Drawing.Font("Dungeon", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_lbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.IP_lbl.Location = New System.Drawing.Point(5, 7)
        Me.IP_lbl.Name = "IP_lbl"
        Me.IP_lbl.Size = New System.Drawing.Size(125, 18)
        Me.IP_lbl.TabIndex = 0
        Me.IP_lbl.Text = "IP: Wait..."
        Me.IP_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Local_lbl
        '
        Me.Local_lbl.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Local_lbl.Location = New System.Drawing.Point(5, 28)
        Me.Local_lbl.Name = "Local_lbl"
        Me.Local_lbl.Size = New System.Drawing.Size(151, 13)
        Me.Local_lbl.TabIndex = 3
        Me.Local_lbl.Text = "Region: Wait..."
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        '
        'ProgressBar_Radial
        '
        Me.ProgressBar_Radial.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.BaseColour = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.BorderColour = System.Drawing.Color.Transparent
        Me.ProgressBar_Radial.Location = New System.Drawing.Point(141, 5)
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
        'IP_Pic
        '
        Me.IP_Pic.BackColor = System.Drawing.Color.Transparent
        Me.IP_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.IP_Red
        Me.IP_Pic.Location = New System.Drawing.Point(4, 16)
        Me.IP_Pic.Name = "IP_Pic"
        Me.IP_Pic.Size = New System.Drawing.Size(64, 64)
        Me.IP_Pic.TabIndex = 0
        Me.IP_Pic.TabStop = False
        '
        'Pin_Pic
        '
        Me.Pin_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pin_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Pin_8x8
        Me.Pin_Pic.Location = New System.Drawing.Point(190, 6)
        Me.Pin_Pic.Name = "Pin_Pic"
        Me.Pin_Pic.Size = New System.Drawing.Size(8, 8)
        Me.Pin_Pic.TabIndex = 14
        Me.Pin_Pic.TabStop = False
        '
        'Config_Pic
        '
        Me.Config_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Config_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.services_8x8
        Me.Config_Pic.Location = New System.Drawing.Point(206, 6)
        Me.Config_Pic.Name = "Config_Pic"
        Me.Config_Pic.Size = New System.Drawing.Size(8, 8)
        Me.Config_Pic.TabIndex = 5
        Me.Config_Pic.TabStop = False
        '
        'Close_Pic
        '
        Me.Close_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Pic.Image = Global.My_Crypto_Gadgets.My.Resources.Resources.Close_8x8
        Me.Close_Pic.Location = New System.Drawing.Point(222, 6)
        Me.Close_Pic.Name = "Close_Pic"
        Me.Close_Pic.Size = New System.Drawing.Size(8, 8)
        Me.Close_Pic.TabIndex = 4
        Me.Close_Pic.TabStop = False
        '
        'Servico_lbl
        '
        Me.Servico_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servico_lbl.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Servico_lbl.Location = New System.Drawing.Point(5, 46)
        Me.Servico_lbl.Name = "Servico_lbl"
        Me.Servico_lbl.Size = New System.Drawing.Size(151, 32)
        Me.Servico_lbl.TabIndex = 4
        Me.Servico_lbl.Text = "Service: Wait..."
        '
        'My_IP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(245, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.IP_Pic)
        Me.Controls.Add(Me.Pin_Pic)
        Me.Controls.Add(Me.Config_Pic)
        Me.Controls.Add(Me.Close_Pic)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "My_IP"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "My Gadgets"
        Me.Panel1.ResumeLayout(False)
        CType(Me.IP_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pin_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Config_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IP_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IP_lbl As System.Windows.Forms.Label
    Friend WithEvents Local_lbl As System.Windows.Forms.Label
    Friend WithEvents Close_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Config_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Pin_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar_Radial As ToolsBox.ProgressBar_Radial_2
    Friend WithEvents Servico_lbl As System.Windows.Forms.Label

End Class
