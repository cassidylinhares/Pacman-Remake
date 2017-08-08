Public Class Form1
    Dim firstFootForward As Boolean 'Checks if first foot is forward
    Dim direction As Integer 'Stores direction
    Dim vroads(3) As PictureBox
    Dim hroads(1) As PictureBox
    Dim cages(3) As PictureBox
    Dim cagesdirection(3) As Integer
    Dim cagestate(3) As Integer 'the state of the cage
    Dim cagenum As Integer ' what cage is currently moving out of his home
    Dim pizza(NUMPIZZA) As PictureBox
    Dim numPizzaEaten As Integer
    Dim sprite(1) As PictureBox
    Const INHOME As Integer = 0 'at the starting spot
    Const LEAVINGHOME As Integer = 1 'leaving the starting spot
    Const REGULAR As Integer = 2 'moving regularly across the map
    Const NUMPIZZA As Integer = 57
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            direction = e.KeyCode
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        characterSelection.ShowDialog()
        hroads(0) = hroad0
        hroads(1) = hroad1

        vroads(0) = vroad0
        vroads(1) = vroad1
        vroads(2) = vroad2
        vroads(3) = vroad3

        sprite(0) = reggie
        sprite(1) = Suzzy
        If charc = 0 Or charc = 1 Then
            Call resetLevel()
            Timer1.Start() 'Starts the timer
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim index As Integer
        If quitB = True Then
            Me.Close()
        End If
        Call MoveSprite()
        If charc = 0 Then
            Call animateReggie()
        End If
        For index = 0 To 3
            If cagestate(index) = REGULAR Then
                Call moveCages(index)
                If (atIntersect(index) = True) Then
                    Call chaseSprite(index)
                End If
            Else
                Call moveIntoGame()
            End If
            If Touching(sprite(charc), cages(index)) = True Then
                Timer1.Stop()
                Me.Hide()
                Captured.ShowDialog()

                Call resetLevel()
                Timer1.Start()
            End If
        Next index
        Call checkBeatLevel()
    End Sub
    Private Sub checkBeatLevel()
        Dim index As Integer
        Dim pindex As Integer
        For index = 0 To NUMPIZZA
            If Touching(sprite(charc), pizza(index)) = True And pizza(index).Visible = True Then
                pizza(index).Visible = False
                numPizzaEaten = numPizzaEaten + 1
                If numPizzaEaten = NUMPIZZA + 1 Then 'if we've beat the level
                    Timer1.Stop()
                    ' BeatLevelform.showdialog()
                    For pindex = 0 To NUMPIZZA
                        pizza(pindex).Visible = True
                    Next pindex
                    quitB = True
                    Me.Hide()
                    numPizzaEaten = 0
                    Call resetLevel()
                    Timer1.Start()
                End If
            End If
        Next index
    End Sub
    Private Sub pizzaSet()
        pizza(0) = PictureBox1
        pizza(1) = PictureBox2
        pizza(2) = PictureBox3
        pizza(3) = PictureBox4
        pizza(4) = PictureBox5
        pizza(5) = PictureBox6
        pizza(6) = PictureBox7
        pizza(7) = PictureBox8
        pizza(8) = PictureBox9
        pizza(9) = PictureBox10
        pizza(10) = PictureBox11
        pizza(11) = PictureBox12
        pizza(12) = PictureBox13
        pizza(13) = PictureBox14
        pizza(14) = PictureBox15
        pizza(15) = PictureBox16
        pizza(16) = PictureBox17
        pizza(17) = PictureBox18
        pizza(18) = PictureBox19
        pizza(19) = PictureBox20
        pizza(20) = PictureBox21
        pizza(21) = PictureBox22
        pizza(22) = PictureBox23
        pizza(23) = PictureBox24
        pizza(24) = PictureBox25
        pizza(25) = PictureBox26
        pizza(26) = PictureBox27
        pizza(27) = PictureBox28
        pizza(28) = PictureBox29
        pizza(29) = PictureBox30
        pizza(30) = PictureBox31
        pizza(31) = PictureBox32
        pizza(32) = PictureBox33
        pizza(33) = PictureBox34
        pizza(34) = PictureBox35
        pizza(35) = PictureBox36
        pizza(36) = PictureBox37
        pizza(37) = PictureBox38
        pizza(38) = PictureBox39
        pizza(39) = PictureBox40
        pizza(40) = PictureBox41
        pizza(41) = PictureBox42
        pizza(42) = PictureBox43
        pizza(43) = PictureBox44
        pizza(44) = PictureBox45
        pizza(45) = PictureBox46
        pizza(46) = PictureBox47
        pizza(47) = PictureBox48
        pizza(48) = PictureBox49
        pizza(49) = PictureBox50
        pizza(50) = PictureBox51
        pizza(51) = PictureBox52
        pizza(52) = PictureBox53
        pizza(53) = PictureBox54
        pizza(54) = PictureBox55
        pizza(55) = PictureBox56
        pizza(56) = PictureBox57
        pizza(57) = PictureBox58
    End Sub
    Private Sub moveIntoGame()
        If cagestate(cagenum) = INHOME Then
            cagestate(cagenum) = LEAVINGHOME
            cages(cagenum).Left = 529
            cages(cagenum).Top = 415
        ElseIf cagestate(cagenum) = LEAVINGHOME Then
            cages(cagenum).Top = cages(cagenum).Top - 2
            If cages(cagenum).Top < 230 Then
                cagestate(cagenum) = REGULAR
                cagenum = cagenum + 1
            End If
        End If
    End Sub
    Private Sub cageSet()
        cages(0) = cage0
        cages(1) = cage1
        cages(2) = cage2
        cages(3) = cage3
        cagesdirection(0) = Keys.Left
        cagesdirection(1) = Keys.Right
        cagesdirection(2) = Keys.Left
        cagesdirection(3) = Keys.Right

        cages(0).Left = 484
        cages(0).Top = 388
        cages(1).Left = 564
        cages(1).Top = 388
        cages(2).Left = 484
        cages(2).Top = 456
        cages(3).Left = 564
        cages(3).Top = 456

        cagestate(0) = INHOME
        cagestate(1) = INHOME
        cagestate(2) = INHOME
        cagestate(3) = INHOME

        cagenum = 0
    End Sub
    Private Sub spriteSet()
        If charc = 0 Then
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRRt1.png")
            Suzzy.Visible = False
        Else
            Suzzy.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Suzie Coo\SCRt1.png")
            reggie.Visible = False
        End If
        firstFootForward = True
        sprite(charc).Left = 539
        sprite(charc).Top = 621
    End Sub

    Private Sub resetLevel()
        Call cageSet()
        Call spriteSet()
        Call pizzaSet()
        numPizzaEaten = 0
    End Sub
    Private Sub chaseSprite(ByVal cindex As Integer)
        Dim xdistance As Integer
        Dim ydistance As Integer

        xdistance = Math.Abs(cages(cindex).Left - sprite(charc).Left)
        ydistance = Math.Abs(cages(cindex).Top - sprite(charc).Top)

        If xdistance > ydistance Then
            If sprite(charc).Left < cages(cindex).Left Then
                cagesdirection(cindex) = Keys.Left
            ElseIf sprite(charc).Left > cages(0).Left Then
                cagesdirection(cindex) = Keys.Right
            End If
        Else
            If sprite(charc).Top < cages(cindex).Top Then
                cagesdirection(cindex) = Keys.Up
            ElseIf sprite(charc).Top > cages(cindex).Top Then
                cagesdirection(cindex) = Keys.Down
            End If
        End If
    End Sub
    Private Function atIntersect(ByVal cindex As Integer)
        Dim index As Integer
        For index = 0 To 3
            If Touching(cages(cindex), hroad0) And Touching(cages(cindex), vroads(index)) Then
                Return True
            ElseIf Touching(cages(cindex), hroad1) And Touching(cages(cindex), vroads(index)) Then
                Return True
            End If
        Next index
        Return False
    End Function
    Private Sub moveCages(ByVal cindex As Integer)
        For index = 0 To 3
            If Touching(cages(cindex), vroads(index)) Then
                If cagesdirection(cindex) = Keys.Up Then 'If up key is pressed down Reggie moves up
                    MoveUp(cages(cindex), 5) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Up Direction
                    cages(cindex).Left = vroads(index).Left
                End If

                If cagesdirection(cindex) = Keys.Down Then 'If down key is pressed down Reggie moves down
                    MoveDown(cages(cindex), 5) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Down Direction
                    cages(cindex).Left = vroads(index).Left
                End If
            End If
        Next index
        For index = 0 To 1
            If Touching(cages(cindex), hroads(index)) Then
                If cagesdirection(cindex) = Keys.Left Then 'If left key is pressed down Reggie moves left
                    MoveLeft(cages(cindex), 5) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Left Direction
                    cages(cindex).Top = hroads(index).Top
                End If

                If cagesdirection(cindex) = Keys.Right Then 'If right key is pressed down Reggie moves right
                    MoveRight(cages(cindex), 5) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Right Direction
                    cages(cindex).Top = hroads(index).Top
                End If
            End If
        Next index
    End Sub
    Private Sub animateReggie()
        If direction = Keys.Up Then
            AnimateUp()
        ElseIf direction = Keys.Down Then
            AnimateDown()
        ElseIf direction = Keys.Left Then
            AnimateLeft()
        ElseIf direction = Keys.Right Then
            AnimateRight()
        End If
    End Sub
    Private Sub MoveSprite()
        For index = 0 To 3
            If Touching(sprite(charc), vroads(index)) Then
                If direction = Keys.Up Then 'If up key is pressed down Reggie moves up
                    MoveUp(sprite(charc), 10) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Up Direction
                    sprite(charc).Left = vroads(index).Left
                End If

                If direction = Keys.Down Then 'If down key is pressed down Reggie moves down
                    MoveDown(sprite(charc), 10) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Down Direction
                    sprite(charc).Left = vroads(index).Left
                End If
            End If
        Next index
        For index = 0 To 1
            If Touching(sprite(charc), hroads(index)) Then
                If direction = Keys.Left Then 'If left key is pressed down Reggie moves left
                    MoveLeft(sprite(charc), 10) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Left Direction
                    sprite(charc).Top = hroads(index).Top
                End If

                If direction = Keys.Right Then 'If right key is pressed down Reggie moves right
                    MoveRight(sprite(charc), 10) 'Controls how much Reggie moves each step and when Reggie reaches the edge of the screen in the Right Direction
                    sprite(charc).Top = hroads(index).Top
                End If
            End If
        Next index
    End Sub
    Private Function Touching(ByVal object1 As PictureBox, ByVal object2 As PictureBox)
        If object1.Right > object2.Left And object1.Left < object2.Right Then
            If object1.Top < object2.Bottom And object1.Bottom > object2.Top Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Sub AnimateUp()
        If firstFootForward = True Then
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRUp2.png")
            firstFootForward = False
        Else
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRUp1.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub AnimateDown()
        If firstFootForward = True Then
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRDn2.png")
            firstFootForward = False
        Else
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRDn1.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub AnimateLeft()
        If firstFootForward = True Then
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRLt2.png")
            firstFootForward = False
        Else
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRLt1.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub AnimateRight()
        If firstFootForward = True Then
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRRt2.png")
            firstFootForward = False
        Else
            reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\Reggie\RRRt1.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub MoveUp(ByVal guy As PictureBox, ByVal Speed As Integer)
        If guy.Top < (0 - guy.Height) Then
            guy.Top = 900
        Else
            guy.Top = guy.Top - Speed
        End If
    End Sub
    Private Sub MoveDown(ByVal guy As PictureBox, ByVal Speed As Integer)
        If guy.Top > 900 Then
            guy.Top = (0 - guy.Height)
        Else
            guy.Top = guy.Top + Speed
        End If
    End Sub

    Private Sub MoveLeft(ByVal guy As PictureBox, ByVal Speed As Integer)
        If guy.Left < (0 - guy.Width) Then
            guy.Left = 1200
        Else
            guy.Left = guy.Left - Speed
        End If
    End Sub

    Private Sub MoveRight(ByVal guy As PictureBox, ByVal Speed As Integer)
        If guy.Left > 1200 Then
            guy.Left = (0 - guy.Width)
        Else
            guy.Left = guy.Left + Speed
        End If
    End Sub

End Class
