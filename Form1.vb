Public Class Form1

    Dim card(16) As PictureBox
    Dim rec(52) As Integer  ' 出現次數
    Dim preVal(8) As Integer
    Dim val(16) As Integer  'card value
    Dim flip(1) As Integer
    Dim count As Integer = 0
    Dim myscore As Integer = 0
    Dim mytime As Integer = 0
    Dim mode As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        card(1) = card1 : card(2) = card2 : card(3) = card3 : card(4) = card4 : card(5) = card5
        card(6) = card6 : card(7) = card7 : card(8) = card8 : card(9) = card9 : card(10) = card10
        card(11) = card11 : card(12) = card12 : card(13) = card13 : card(14) = card14 : card(15) = card15
        card(16) = card16


        Me.StartPosition = FormStartPosition.CenterScreen

        mode1.Text = "一種" : mode2.Text = "兩種" : mode3.Text = "三種" : mode4.Text = "四種"
        mode1.ForeColor = Color.Black : mode2.ForeColor = Color.Black : mode3.ForeColor = Color.Black : mode4.ForeColor = Color.Black
        Button1.Text = "Start" : Button2.Text = "Restart" : Button3.Text = "偷看"
        Button3.Enabled = False
        For i As Integer = 1 To 16
            card(i).SizeMode = PictureBoxSizeMode.StretchImage
            card(i).Image() = ImageList1.Images(0)  'back
            card(i).Enabled = False
        Next

        '提示初始化
        tip.SizeMode = PictureBoxSizeMode.StretchImage
        ToolTip1.AutoPopDelay = 5000    '保持可見的時間
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.ShowAlways = True
        ToolTip1.IsBalloon = True
        'ToolTip1.UseAnimation = True
        ToolTip1.UseFading = True
        ToolTip1.Active = False

        'progressbar 初始化
        ProgressBar1.Minimum = 0  '設定進度條最小值
        ProgressBar1.Maximum = 8  '設定進度條最大值
        ProgressTimer.Enabled = False           '讓 timer1一開始不要計時,等START再計時

    End Sub

    Private Sub card_Click(sender As Object, e As EventArgs) Handles card1.Click, card2.Click, card3.Click,
     card4.Click, card5.Click, card6.Click, card7.Click, card8.Click, card9.Click, card10.Click, card11.Click,
     card12.Click, card13.Click, card14.Click, card15.Click, card16.Click

        For i As Integer = 1 To 16
            If sender.Equals(card(i)) Then
                card(i).Image = ImageList1.Images(val(i))
                flip(count) = val(i)
                count += 1
            End If
        Next

        If count = 2 Then   '啟動計時 
            For i As Integer = 1 To 16
                card(i).Enabled = False
            Next
            Timer1.Interval = 500
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub timer1_tric(sender As Object, e As EventArgs) Handles Timer1.Tick

        If count = 2 Then
            If (flip(0) <> flip(1) And (flip(0) <> 0)) And (flip(1) <> 0) Then  '2張牌不同
                For j As Integer = 1 To 16
                    card(j).Image() = ImageList1.Images(0)
                Next
            ElseIf (flip(0) = flip(1) And (flip(0) <> 0)) And (flip(1) <> 0) Then   '2張牌相同
                For j As Integer = 1 To 16
                    If val(j) = flip(count - 1) Then
                        card(j).Visible = False
                    End If
                Next
                myscore += 1
                score.Text = myscore
                ProgressBar1.Value = myscore
            End If

            'reset
            flip(0) = 0 : flip(1) = 0 : count = 0 : Timer1.Enabled = False
            For i As Integer = 1 To 16
                card(i).Enabled = True
            Next

            If score.Text = "8" Then
                Dim decide As Integer
                Timer2.Enabled = False
                decide = MsgBox("win!   花費" + Str(mytime) + "秒" + vbNewLine + "按確定繼續或按取消離開", 1 + 64, "結算")
                If decide = 2 Then
                    End
                End If
            End If


        End If



    End Sub  'end timer1

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        mytime += 1
        time.Text = Str(mytime)

        score.Text = myscore
        ProgressBar1.Value = myscore
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As RadioButton, e As EventArgs) Handles mode1.CheckedChanged,
        mode2.CheckedChanged, mode3.CheckedChanged, mode4.CheckedChanged
        If sender.Checked = True Then
            sender.ForeColor = Color.Blue
        Else
            sender.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '初始化
        For i As Integer = 1 To 16
            card(i).Image() = ImageList1.Images(0)  'back
            card(i).Cursor = Cursors.Hand
            card(i).Enabled = True
        Next

        ToolTip1.Active = True
        Button1.BackColor = Color.Gray
        Button1.Enabled = False
        Timer2.Enabled = True
        Timer2.Interval = 1000
        Button3.Enabled = True



        ProgressTimer.Enabled = True

        If mode1.Checked = True Then
            mode = 1
        ElseIf mode2.Checked = True Then
            mode = 2
        ElseIf mode3.Checked = True Then
            mode = 3
        ElseIf mode4.Checked = True Then
            mode = 4
        End If


        For i As Integer = 1 To 8
            Dim random As Integer
            Randomize()
            If mode = 1 Then
                random = Int((13 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((13 * Rnd()) + 1)
                End While
            ElseIf mode = 2 Then
                random = Int((26 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((26 * Rnd()) + 1)
                End While
            ElseIf mode = 3 Then
                random = Int((39 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((39 * Rnd()) + 1)
                End While
            ElseIf mode = 4 Then
                random = Int((52 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((52 * Rnd()) + 1)
                End While
            End If

            rec(random) += 1
            preVal(i) = random

        Next

        For i As Integer = 1 To 8
            Randomize()
            Dim random1 As Integer = Int((16 * Rnd()) + 1)
            Randomize()
            Dim random2 As Integer = Int((16 * Rnd()) + 1)
            While (val(random1) <> 0)
                random1 = Int((16 * Rnd()) + 1)
            End While
            While (val(random2) <> 0 Or random1 = random2)
                random2 = Int((16 * Rnd()) + 1)
            End While
            val(random1) = preVal(i)
            val(random2) = preVal(i)

        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 1 To 16
            card(i).Image() = ImageList1.Images(0)  'back
            card(i).Visible = True
            card(i).Enabled = True
        Next


        Erase rec, preVal, val, flip
        ReDim rec(56), preVal(8), val(16), flip(1)
        count = 0 : myscore = 0 : mytime = 0

        Timer2.Enabled = True
        Timer2.Interval = 1000

        Button3.Enabled = True

        If mode1.Checked = True Then
            mode = 1
        ElseIf mode2.Checked = True Then
            mode = 2
        ElseIf mode3.Checked = True Then
            mode = 3
        ElseIf mode4.Checked = True Then
            mode = 4
        End If


        For i As Integer = 1 To 8
            Dim random As Integer
            Randomize()
            If mode = 1 Then
                random = Int((13 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((13 * Rnd()) + 1)
                End While
            ElseIf mode = 2 Then
                random = Int((26 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((26 * Rnd()) + 1)
                End While
            ElseIf mode = 3 Then
                random = Int((39 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((39 * Rnd()) + 1)
                End While
            ElseIf mode = 4 Then
                random = Int((52 * Rnd()) + 1)
                While rec(random) >= 1
                    random = Int((52 * Rnd()) + 1)
                End While
            End If

            rec(random) += 1
            preVal(i) = random

        Next

        For i As Integer = 1 To 8
            Randomize()
            Dim random1 As Integer = Int((16 * Rnd()) + 1)
            Randomize()
            Dim random2 As Integer = Int((16 * Rnd()) + 1)
            While (val(random1) <> 0)
                random1 = Int((16 * Rnd()) + 1)
            End While
            While (val(random2) <> 0 Or random1 = random2)
                random2 = Int((16 * Rnd()) + 1)
            End While
            val(random1) = preVal(i)
            val(random2) = preVal(i)

        Next



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 1 To 16
            card(i).Image = ImageList1.Images(val(i))
            card(i).Cursor = Cursors.No
            card(i).Enabled = False
        Next
        Timer3.Interval = 500
        Timer3.Enabled = True

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Timer3.Enabled = False
        For i As Integer = 1 To 16
            card(i).Image() = ImageList1.Images(0)  'back
            card(i).Cursor = Cursors.Hand
            card(i).Enabled = True
        Next
    End Sub



    Private Sub tip_MouseEnter(sender As Object, e As EventArgs) Handles tip.MouseEnter
        tip.Cursor = Cursors.Help
        ToolTip1.SetToolTip(Me.tip, "右下角有提示")
        'ToolTip1.
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "打地鼠" Then
            Me.Hide()
            Form2.Show()
        ElseIf ComboBox1.Text = "Form3" Then
            Me.Hide()
            Form3.Show()

        End If

    End Sub
End Class
