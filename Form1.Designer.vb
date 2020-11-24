<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mode4 = New System.Windows.Forms.RadioButton()
        Me.mode3 = New System.Windows.Forms.RadioButton()
        Me.mode2 = New System.Windows.Forms.RadioButton()
        Me.mode1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tip = New System.Windows.Forms.PictureBox()
        Me.card16 = New System.Windows.Forms.PictureBox()
        Me.card15 = New System.Windows.Forms.PictureBox()
        Me.card14 = New System.Windows.Forms.PictureBox()
        Me.card13 = New System.Windows.Forms.PictureBox()
        Me.card12 = New System.Windows.Forms.PictureBox()
        Me.card11 = New System.Windows.Forms.PictureBox()
        Me.card10 = New System.Windows.Forms.PictureBox()
        Me.card9 = New System.Windows.Forms.PictureBox()
        Me.card8 = New System.Windows.Forms.PictureBox()
        Me.card7 = New System.Windows.Forms.PictureBox()
        Me.card6 = New System.Windows.Forms.PictureBox()
        Me.card5 = New System.Windows.Forms.PictureBox()
        Me.card4 = New System.Windows.Forms.PictureBox()
        Me.card3 = New System.Windows.Forms.PictureBox()
        Me.card2 = New System.Windows.Forms.PictureBox()
        Me.card1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.card16)
        Me.Panel1.Controls.Add(Me.card15)
        Me.Panel1.Controls.Add(Me.card14)
        Me.Panel1.Controls.Add(Me.card13)
        Me.Panel1.Controls.Add(Me.card12)
        Me.Panel1.Controls.Add(Me.card11)
        Me.Panel1.Controls.Add(Me.card10)
        Me.Panel1.Controls.Add(Me.card9)
        Me.Panel1.Controls.Add(Me.card8)
        Me.Panel1.Controls.Add(Me.card7)
        Me.Panel1.Controls.Add(Me.card6)
        Me.Panel1.Controls.Add(Me.card5)
        Me.Panel1.Controls.Add(Me.card4)
        Me.Panel1.Controls.Add(Me.card3)
        Me.Panel1.Controls.Add(Me.card2)
        Me.Panel1.Controls.Add(Me.card1)
        Me.Panel1.Location = New System.Drawing.Point(402, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 489)
        Me.Panel1.TabIndex = 9
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.SystemColors.Info
        Me.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScoreLabel.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(927, 56)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(125, 50)
        Me.ScoreLabel.TabIndex = 10
        Me.ScoreLabel.Text = "Score"
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.score.Location = New System.Drawing.Point(1058, 58)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(43, 48)
        Me.score.TabIndex = 11
        Me.score.Text = "0"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.time.Location = New System.Drawing.Point(1058, 178)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(43, 48)
        Me.time.TabIndex = 13
        Me.time.Text = "0"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.SystemColors.Info
        Me.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeLabel.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(927, 178)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(118, 50)
        Me.TimeLabel.TabIndex = 12
        Me.TimeLabel.Text = "Time"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "_back.jpg")
        Me.ImageList1.Images.SetKeyName(1, "c1.jpg")
        Me.ImageList1.Images.SetKeyName(2, "c2.jpg")
        Me.ImageList1.Images.SetKeyName(3, "c3.jpg")
        Me.ImageList1.Images.SetKeyName(4, "c4.jpg")
        Me.ImageList1.Images.SetKeyName(5, "c5.jpg")
        Me.ImageList1.Images.SetKeyName(6, "c6.jpg")
        Me.ImageList1.Images.SetKeyName(7, "c7.jpg")
        Me.ImageList1.Images.SetKeyName(8, "c8.jpg")
        Me.ImageList1.Images.SetKeyName(9, "c9.jpg")
        Me.ImageList1.Images.SetKeyName(10, "c10.jpg")
        Me.ImageList1.Images.SetKeyName(11, "c11.jpg")
        Me.ImageList1.Images.SetKeyName(12, "c12.jpg")
        Me.ImageList1.Images.SetKeyName(13, "c13.jpg")
        Me.ImageList1.Images.SetKeyName(14, "d1.jpg")
        Me.ImageList1.Images.SetKeyName(15, "d2.jpg")
        Me.ImageList1.Images.SetKeyName(16, "d3.jpg")
        Me.ImageList1.Images.SetKeyName(17, "d4.jpg")
        Me.ImageList1.Images.SetKeyName(18, "d5.jpg")
        Me.ImageList1.Images.SetKeyName(19, "d6.jpg")
        Me.ImageList1.Images.SetKeyName(20, "d7.jpg")
        Me.ImageList1.Images.SetKeyName(21, "d8.jpg")
        Me.ImageList1.Images.SetKeyName(22, "d9.jpg")
        Me.ImageList1.Images.SetKeyName(23, "d10.jpg")
        Me.ImageList1.Images.SetKeyName(24, "d11.jpg")
        Me.ImageList1.Images.SetKeyName(25, "d12.jpg")
        Me.ImageList1.Images.SetKeyName(26, "d13.jpg")
        Me.ImageList1.Images.SetKeyName(27, "h1.jpg")
        Me.ImageList1.Images.SetKeyName(28, "h2.jpg")
        Me.ImageList1.Images.SetKeyName(29, "h3.jpg")
        Me.ImageList1.Images.SetKeyName(30, "h4.jpg")
        Me.ImageList1.Images.SetKeyName(31, "h5.jpg")
        Me.ImageList1.Images.SetKeyName(32, "h6.jpg")
        Me.ImageList1.Images.SetKeyName(33, "h7.jpg")
        Me.ImageList1.Images.SetKeyName(34, "h8.jpg")
        Me.ImageList1.Images.SetKeyName(35, "h9.jpg")
        Me.ImageList1.Images.SetKeyName(36, "h10.jpg")
        Me.ImageList1.Images.SetKeyName(37, "h11.jpg")
        Me.ImageList1.Images.SetKeyName(38, "h12.jpg")
        Me.ImageList1.Images.SetKeyName(39, "h13.jpg")
        Me.ImageList1.Images.SetKeyName(40, "s1.jpg")
        Me.ImageList1.Images.SetKeyName(41, "s2.jpg")
        Me.ImageList1.Images.SetKeyName(42, "s3.jpg")
        Me.ImageList1.Images.SetKeyName(43, "s4.jpg")
        Me.ImageList1.Images.SetKeyName(44, "s5.jpg")
        Me.ImageList1.Images.SetKeyName(45, "s6.jpg")
        Me.ImageList1.Images.SetKeyName(46, "s7.jpg")
        Me.ImageList1.Images.SetKeyName(47, "s8.jpg")
        Me.ImageList1.Images.SetKeyName(48, "s9.jpg")
        Me.ImageList1.Images.SetKeyName(49, "s10.jpg")
        Me.ImageList1.Images.SetKeyName(50, "s11.jpg")
        Me.ImageList1.Images.SetKeyName(51, "s12.jpg")
        Me.ImageList1.Images.SetKeyName(52, "s13.jpg")
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.mode4)
        Me.GroupBox1.Controls.Add(Me.mode3)
        Me.GroupBox1.Controls.Add(Me.mode2)
        Me.GroupBox1.Controls.Add(Me.mode1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(107, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 245)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "花色"
        '
        'mode4
        '
        Me.mode4.AutoSize = True
        Me.mode4.Location = New System.Drawing.Point(18, 183)
        Me.mode4.Name = "mode4"
        Me.mode4.Size = New System.Drawing.Size(122, 39)
        Me.mode4.TabIndex = 3
        Me.mode4.TabStop = True
        Me.mode4.Text = "mode4"
        Me.mode4.UseVisualStyleBackColor = True
        '
        'mode3
        '
        Me.mode3.AutoSize = True
        Me.mode3.Location = New System.Drawing.Point(18, 138)
        Me.mode3.Name = "mode3"
        Me.mode3.Size = New System.Drawing.Size(122, 39)
        Me.mode3.TabIndex = 2
        Me.mode3.TabStop = True
        Me.mode3.Text = "mode3"
        Me.mode3.UseVisualStyleBackColor = True
        '
        'mode2
        '
        Me.mode2.AutoSize = True
        Me.mode2.Location = New System.Drawing.Point(18, 93)
        Me.mode2.Name = "mode2"
        Me.mode2.Size = New System.Drawing.Size(122, 39)
        Me.mode2.TabIndex = 1
        Me.mode2.TabStop = True
        Me.mode2.Text = "mode2"
        Me.mode2.UseVisualStyleBackColor = True
        '
        'mode1
        '
        Me.mode1.AutoSize = True
        Me.mode1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mode1.Location = New System.Drawing.Point(18, 48)
        Me.mode1.Name = "mode1"
        Me.mode1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mode1.Size = New System.Drawing.Size(122, 39)
        Me.mode1.TabIndex = 0
        Me.mode1.TabStop = True
        Me.mode1.Text = "mode1"
        Me.mode1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("新細明體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(28, 456)
        Me.Button1.Margin = New System.Windows.Forms.Padding(30)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10)
        Me.Button1.Size = New System.Drawing.Size(152, 68)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("新細明體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(206, 456)
        Me.Button2.Margin = New System.Windows.Forms.Padding(30)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10)
        Me.Button2.Size = New System.Drawing.Size(152, 68)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1156, 534)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"翻牌遊戲", "打地鼠", "Form3"})
        Me.ComboBox1.Location = New System.Drawing.Point(107, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 29)
        Me.ComboBox1.TabIndex = 20
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(549, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(194, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(430, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "完成進度"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tip
        '
        Me.tip.Image = Global._2MinHalf.My.Resources.Resources.下載1
        Me.tip.Location = New System.Drawing.Point(1167, 36)
        Me.tip.Name = "tip"
        Me.tip.Size = New System.Drawing.Size(51, 50)
        Me.tip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tip.TabIndex = 19
        Me.tip.TabStop = False
        '
        'card16
        '
        Me.card16.Location = New System.Drawing.Point(261, 369)
        Me.card16.Name = "card16"
        Me.card16.Size = New System.Drawing.Size(80, 116)
        Me.card16.TabIndex = 23
        Me.card16.TabStop = False
        '
        'card15
        '
        Me.card15.Location = New System.Drawing.Point(175, 369)
        Me.card15.Name = "card15"
        Me.card15.Size = New System.Drawing.Size(80, 116)
        Me.card15.TabIndex = 22
        Me.card15.TabStop = False
        '
        'card14
        '
        Me.card14.Location = New System.Drawing.Point(89, 369)
        Me.card14.Name = "card14"
        Me.card14.Size = New System.Drawing.Size(80, 116)
        Me.card14.TabIndex = 21
        Me.card14.TabStop = False
        '
        'card13
        '
        Me.card13.Location = New System.Drawing.Point(3, 369)
        Me.card13.Name = "card13"
        Me.card13.Size = New System.Drawing.Size(80, 116)
        Me.card13.TabIndex = 20
        Me.card13.TabStop = False
        '
        'card12
        '
        Me.card12.Location = New System.Drawing.Point(261, 247)
        Me.card12.Name = "card12"
        Me.card12.Size = New System.Drawing.Size(80, 116)
        Me.card12.TabIndex = 19
        Me.card12.TabStop = False
        '
        'card11
        '
        Me.card11.Location = New System.Drawing.Point(175, 247)
        Me.card11.Name = "card11"
        Me.card11.Size = New System.Drawing.Size(80, 116)
        Me.card11.TabIndex = 18
        Me.card11.TabStop = False
        '
        'card10
        '
        Me.card10.Location = New System.Drawing.Point(89, 247)
        Me.card10.Name = "card10"
        Me.card10.Size = New System.Drawing.Size(80, 116)
        Me.card10.TabIndex = 17
        Me.card10.TabStop = False
        '
        'card9
        '
        Me.card9.Location = New System.Drawing.Point(3, 247)
        Me.card9.Name = "card9"
        Me.card9.Size = New System.Drawing.Size(80, 116)
        Me.card9.TabIndex = 16
        Me.card9.TabStop = False
        '
        'card8
        '
        Me.card8.Location = New System.Drawing.Point(261, 125)
        Me.card8.Name = "card8"
        Me.card8.Size = New System.Drawing.Size(80, 116)
        Me.card8.TabIndex = 15
        Me.card8.TabStop = False
        '
        'card7
        '
        Me.card7.Location = New System.Drawing.Point(175, 125)
        Me.card7.Name = "card7"
        Me.card7.Size = New System.Drawing.Size(80, 116)
        Me.card7.TabIndex = 14
        Me.card7.TabStop = False
        '
        'card6
        '
        Me.card6.Location = New System.Drawing.Point(89, 125)
        Me.card6.Name = "card6"
        Me.card6.Size = New System.Drawing.Size(80, 116)
        Me.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card6.TabIndex = 13
        Me.card6.TabStop = False
        '
        'card5
        '
        Me.card5.Location = New System.Drawing.Point(3, 125)
        Me.card5.Name = "card5"
        Me.card5.Size = New System.Drawing.Size(80, 116)
        Me.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.card5.TabIndex = 12
        Me.card5.TabStop = False
        '
        'card4
        '
        Me.card4.Location = New System.Drawing.Point(261, 3)
        Me.card4.Name = "card4"
        Me.card4.Size = New System.Drawing.Size(80, 116)
        Me.card4.TabIndex = 11
        Me.card4.TabStop = False
        '
        'card3
        '
        Me.card3.Location = New System.Drawing.Point(175, 3)
        Me.card3.Name = "card3"
        Me.card3.Size = New System.Drawing.Size(80, 116)
        Me.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.card3.TabIndex = 10
        Me.card3.TabStop = False
        '
        'card2
        '
        Me.card2.Location = New System.Drawing.Point(89, 3)
        Me.card2.Name = "card2"
        Me.card2.Size = New System.Drawing.Size(80, 116)
        Me.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.card2.TabIndex = 9
        Me.card2.TabStop = False
        '
        'card1
        '
        Me.card1.Location = New System.Drawing.Point(3, 3)
        Me.card1.Name = "card1"
        Me.card1.Size = New System.Drawing.Size(78, 113)
        Me.card1.TabIndex = 8
        Me.card1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1269, 636)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tip)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents card1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents card16 As PictureBox
    Friend WithEvents card15 As PictureBox
    Friend WithEvents card14 As PictureBox
    Friend WithEvents card13 As PictureBox
    Friend WithEvents card12 As PictureBox
    Friend WithEvents card11 As PictureBox
    Friend WithEvents card10 As PictureBox
    Friend WithEvents card9 As PictureBox
    Friend WithEvents card8 As PictureBox
    Friend WithEvents card7 As PictureBox
    Friend WithEvents card6 As PictureBox
    Friend WithEvents card5 As PictureBox
    Friend WithEvents card4 As PictureBox
    Friend WithEvents card3 As PictureBox
    Friend WithEvents card2 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents score As Label
    Friend WithEvents time As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mode3 As RadioButton
    Friend WithEvents mode2 As RadioButton
    Friend WithEvents mode1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents mode4 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents tip As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressTimer As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox1 As TextBox
End Class
