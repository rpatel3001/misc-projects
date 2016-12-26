'rajan

Public Class frmPvZ
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblSunPts As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents sunflowergrass As System.Windows.Forms.PictureBox
    Friend WithEvents peashootergrass As System.Windows.Forms.PictureBox
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents wallnutgrass As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents pea As System.Windows.Forms.PictureBox
    Friend WithEvents sunflowergrassclose As System.Windows.Forms.PictureBox
    Friend WithEvents picSunflower As System.Windows.Forms.PictureBox
    Friend WithEvents picShovel As System.Windows.Forms.PictureBox
    Friend WithEvents picPeaShooter As System.Windows.Forms.PictureBox
    Friend WithEvents picWallnut As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPvZ))
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblSunPts = New System.Windows.Forms.Label
        Me.sunflowergrass = New System.Windows.Forms.PictureBox
        Me.peashootergrass = New System.Windows.Forms.PictureBox
        Me.pea = New System.Windows.Forms.PictureBox
        Me.btnPause = New System.Windows.Forms.Button
        Me.wallnutgrass = New System.Windows.Forms.PictureBox
        Me.lblScore = New System.Windows.Forms.Label
        Me.sunflowergrassclose = New System.Windows.Forms.PictureBox
        Me.picSunflower = New System.Windows.Forms.PictureBox
        Me.picShovel = New System.Windows.Forms.PictureBox
        Me.picPeaShooter = New System.Windows.Forms.PictureBox
        Me.picWallnut = New System.Windows.Forms.PictureBox
        CType(Me.sunflowergrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peashootergrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wallnutgrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunflowergrassclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSunflower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShovel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPeaShooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWallnut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer
        '
        Me.timer.Interval = 500
        '
        'lblSunPts
        '
        Me.lblSunPts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSunPts.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSunPts.Location = New System.Drawing.Point(400, 0)
        Me.lblSunPts.Name = "lblSunPts"
        Me.lblSunPts.Size = New System.Drawing.Size(168, 24)
        Me.lblSunPts.TabIndex = 0
        Me.lblSunPts.Text = "Sun: 50"
        Me.lblSunPts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sunflowergrass
        '
        Me.sunflowergrass.Enabled = False
        Me.sunflowergrass.Image = CType(resources.GetObject("sunflowergrass.Image"), System.Drawing.Image)
        Me.sunflowergrass.Location = New System.Drawing.Point(52, 126)
        Me.sunflowergrass.Name = "sunflowergrass"
        Me.sunflowergrass.Size = New System.Drawing.Size(100, 96)
        Me.sunflowergrass.TabIndex = 3
        Me.sunflowergrass.TabStop = False
        Me.sunflowergrass.Visible = False
        '
        'peashootergrass
        '
        Me.peashootergrass.Enabled = False
        Me.peashootergrass.Image = CType(resources.GetObject("peashootergrass.Image"), System.Drawing.Image)
        Me.peashootergrass.Location = New System.Drawing.Point(152, 123)
        Me.peashootergrass.Name = "peashootergrass"
        Me.peashootergrass.Size = New System.Drawing.Size(100, 101)
        Me.peashootergrass.TabIndex = 4
        Me.peashootergrass.TabStop = False
        Me.peashootergrass.Visible = False
        '
        'pea
        '
        Me.pea.Enabled = False
        Me.pea.Image = CType(resources.GetObject("pea.Image"), System.Drawing.Image)
        Me.pea.Location = New System.Drawing.Point(224, 160)
        Me.pea.Name = "pea"
        Me.pea.Size = New System.Drawing.Size(16, 16)
        Me.pea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pea.TabIndex = 6
        Me.pea.TabStop = False
        Me.pea.Visible = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.SystemColors.Control
        Me.btnPause.Location = New System.Drawing.Point(8, 3)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(67, 21)
        Me.btnPause.TabIndex = 7
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'wallnutgrass
        '
        Me.wallnutgrass.Enabled = False
        Me.wallnutgrass.Image = CType(resources.GetObject("wallnutgrass.Image"), System.Drawing.Image)
        Me.wallnutgrass.Location = New System.Drawing.Point(352, 128)
        Me.wallnutgrass.Name = "wallnutgrass"
        Me.wallnutgrass.Size = New System.Drawing.Size(100, 99)
        Me.wallnutgrass.TabIndex = 8
        Me.wallnutgrass.TabStop = False
        Me.wallnutgrass.Visible = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(250, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(200, 24)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Score: 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sunflowergrassclose
        '
        Me.sunflowergrassclose.Enabled = False
        Me.sunflowergrassclose.Image = CType(resources.GetObject("sunflowergrassclose.Image"), System.Drawing.Image)
        Me.sunflowergrassclose.Location = New System.Drawing.Point(48, 224)
        Me.sunflowergrassclose.Name = "sunflowergrassclose"
        Me.sunflowergrassclose.Size = New System.Drawing.Size(100, 96)
        Me.sunflowergrassclose.TabIndex = 10
        Me.sunflowergrassclose.TabStop = False
        Me.sunflowergrassclose.Visible = False
        '
        'picSunflower
        '
        Me.picSunflower.Image = CType(resources.GetObject("picSunflower.Image"), System.Drawing.Image)
        Me.picSunflower.Location = New System.Drawing.Point(168, 0)
        Me.picSunflower.Name = "picSunflower"
        Me.picSunflower.Size = New System.Drawing.Size(32, 32)
        Me.picSunflower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSunflower.TabIndex = 11
        Me.picSunflower.TabStop = False
        '
        'picShovel
        '
        Me.picShovel.Image = CType(resources.GetObject("picShovel.Image"), System.Drawing.Image)
        Me.picShovel.Location = New System.Drawing.Point(80, 0)
        Me.picShovel.Name = "picShovel"
        Me.picShovel.Size = New System.Drawing.Size(80, 32)
        Me.picShovel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShovel.TabIndex = 12
        Me.picShovel.TabStop = False
        '
        'picPeaShooter
        '
        Me.picPeaShooter.Image = CType(resources.GetObject("picPeaShooter.Image"), System.Drawing.Image)
        Me.picPeaShooter.Location = New System.Drawing.Point(208, 0)
        Me.picPeaShooter.Name = "picPeaShooter"
        Me.picPeaShooter.Size = New System.Drawing.Size(32, 32)
        Me.picPeaShooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPeaShooter.TabIndex = 13
        Me.picPeaShooter.TabStop = False
        '
        'picWallnut
        '
        Me.picWallnut.Image = CType(resources.GetObject("picWallnut.Image"), System.Drawing.Image)
        Me.picWallnut.Location = New System.Drawing.Point(248, 0)
        Me.picWallnut.Name = "picWallnut"
        Me.picWallnut.Size = New System.Drawing.Size(32, 32)
        Me.picWallnut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWallnut.TabIndex = 14
        Me.picWallnut.TabStop = False
        '
        'frmPvZ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 527)
        Me.Controls.Add(Me.picWallnut)
        Me.Controls.Add(Me.picPeaShooter)
        Me.Controls.Add(Me.picShovel)
        Me.Controls.Add(Me.picSunflower)
        Me.Controls.Add(Me.sunflowergrassclose)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.wallnutgrass)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.pea)
        Me.Controls.Add(Me.peashootergrass)
        Me.Controls.Add(Me.sunflowergrass)
        Me.Controls.Add(Me.lblSunPts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPvZ"
        Me.Text = "Plants Vs Zombies"
        Me.TransparencyKey = System.Drawing.Color.MintCream
        CType(Me.sunflowergrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peashootergrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wallnutgrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunflowergrassclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSunflower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShovel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPeaShooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWallnut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend square(8, 4) As plant
    Friend zombies(99) As zombie
    Private zombiesSoFar As Integer = 0
    Private sunPts As Integer = 50
    Friend picSun(99) As sun
    Friend mowers(4) As PictureBox
    Private mowersState(4) As Boolean
    Private sunsSoFar As Integer = 0
    Private score As Integer = 0
    Private plantType As Integer
    Private peas(99) As PictureBox
    Private peasSoFar As Integer = 0
    Private speed As Single = 1
    Private health As Single = 1
    Private spawn As Integer = 60
    Private stime As Integer = 30
    Private sftime As Single = 1
    Private disSunflower, disPeashooter, disWallnut As Integer

    Private Sub frmPvZ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each pea As PictureBox In peas
            pea = New PictureBox
            pea.Image = pea.Image
            pea.Tag = "not pea"
            pea.Image = pea.Image
            pea.Enabled = False
            pea.Visible = False
            pea.Size = New Size(20, 20)
            pea.BackColor = Color.FromArgb(0, 0, 0, 0)
            Me.Controls.Add(pea)
            pea.BringToFront()
        Next

        Dim soFar As Integer = 0
        For m As Integer = 0 To 4
            mowers(m) = New PictureBox
            mowers(m).Image = Image.FromFile("lawnmower.png")
            mowers(m).Size = New Size(50, 100)
            mowers(m).Location = New Point(0, m * 100 + 25)
            mowers(m).BackColor = Color.FromArgb(0, 0, 0, 0)
            mowers(m).SizeMode = PictureBoxSizeMode.StretchImage
            Me.Controls.Add(mowers(m))
            mowers(m).BringToFront()
        Next

        For z As Integer = 0 To 99
            picSun(z) = New sun
            picSun(z).Tag = "new"
            AddHandler picSun(z).Click, AddressOf sunClick
            zombies(z) = New zombie
        Next

        For x As Integer = 0 To 8
            For y As Integer = 0 To 4
                If x <> 0 Then
                    square(x, y) = New plant
                    square(x, y).Location = New Point(x * 100 - 50, y * 100 + 25)
                    square(x, y).Size = New Size(100, 100)
                    square(x, y).Tag = "grass"
                    square(x, y).TabIndex = soFar
                    AddHandler square(x, y).Click, AddressOf clickSquare
                    soFar += 1
                Else
                    square(x, y) = New plant
                    square(x, y).Location = New Point(0, y * 100 + 25)
                    square(x, y).Size = New Size(50, 100)
                    square(x, y).Tag = "mower"
                End If
                square(x, y).SizeMode = PictureBoxSizeMode.StretchImage
                square(x, y).BackColor = Color.Green
                square(x, y).Image = Image.FromFile("grass.jpg")
                Me.Controls.Add(square(x, y))
            Next
        Next
        timer.Start()
        Randomize()
    End Sub

    Private Sub newZombie()
        Dim row As Integer = Rnd() * 4
        zombies(zombiesSoFar) = New zombie
        zombies(zombiesSoFar).health = Int(100 * health)
        zombies(zombiesSoFar).Location = New Point(860, row * 100 + 25)
        zombies(zombiesSoFar).Size = New Size(50, 80)
        zombies(zombiesSoFar).Tag = "zombie"
        zombies(zombiesSoFar).Enabled = True
        zombies(zombiesSoFar).Visible = True
        zombies(zombiesSoFar).SizeMode = PictureBoxSizeMode.StretchImage
        zombies(zombiesSoFar).BackColor = Color.FromArgb(0, 0, 0, 0)
        zombies(zombiesSoFar).Image = Image.FromFile("zombie.png")
        Me.Controls.Add(zombies(zombiesSoFar))
        zombies(zombiesSoFar).BringToFront()
    End Sub

    Private Sub moveZombies()
        For z As Integer = 0 To 99
            For x As Integer = 1 To 8
                For y As Integer = 0 To 4
                    If square(x, y).Location.Y = zombies(z).Location.Y Then
                        If zombies(z).Location.X > square(x, y).Location.X Then
                            If zombies(z).Location.X - 100 < square(x, y).Location.X Then
                                If square(x, y).health > 0 Then
                                    square(x, y).health -= 10
                                    zombies(z).Tag = "stopped"
                                Else
                                    square(x, y).Image = Image.FromFile("grass.jpg")
                                    square(x, y).Tag = "grass"
                                    zombies(z).Tag = "zombie"
                                End If
                            End If
                        End If
                    End If
                Next
            Next

            If zombies(z).Tag = "zombie" Then
                Dim x As Integer = zombies(z).Location.X
                Dim y As Integer = zombies(z).Location.Y
                zombies(z).Location = New Point(Int(x - 5 * speed), y)

                If zombies(z).Location.X <= 50 Then
                    mowersState((zombies(z).Location.Y - 25) \ 100) = True
                End If

                If zombies(z).Location.X <= 0 Then
                    timer.Stop()
                    For i As Integer = 0 To 99
                        picSun(i).Enabled = False
                        zombies(i).Enabled = False
                    Next
                    For Each s As PictureBox In square
                        s.Enabled = False
                    Next
                    MessageBox.Show("You lose with " & score & " points.", "You Lose!")
                End If
            End If
        Next
    End Sub

    Private Sub dropSun(ByVal x As Integer, ByVal y As Integer, ByVal type As Char)

        sunsSoFar += 1
        If sunsSoFar = 100 Then
            sunsSoFar = 0
        End If
        picSun(sunsSoFar).Location = New Point(x, y)
        picSun(sunsSoFar).Size = New Size(50, 50)
        If type = "d" Then
            picSun(sunsSoFar).Tag = "sun"
            picSun(sunsSoFar).tsf = 45
        ElseIf type = "f" Then
            picSun(sunsSoFar).Tag = "flowersun"
            picSun(sunsSoFar).tsf = 20
        End If
        picSun(sunsSoFar).BackColor = Color.FromArgb(0, 0, 0, 0)

        picSun(sunsSoFar).Enabled = True
        picSun(sunsSoFar).Visible = True
        picSun(sunsSoFar).SizeMode = PictureBoxSizeMode.StretchImage
        picSun(sunsSoFar).Image = Image.FromFile("sun.png")
        Me.Controls.Add(picSun(sunsSoFar))
        picSun(sunsSoFar).BringToFront()
    End Sub

    Private Sub goMower()
        For mow As Integer = 0 To 4
            If Not IsNothing(mowers(mow)) Then
                If mowersState(mow) = True Then
                    mowers(mow).Location = New Point(mowers(mow).Location.X + 25, mowers(mow).Location.Y)
                End If

                For i As Integer = 0 To 99
                    If (zombies(i).Tag = "zombie" Or zombies(i).Tag = "stopped") And mowers(mow).Location.X + 50 >= zombies(i).Location.X And mowers(mow).Location.Y = zombies(i).Location.Y Then
                        zombies(i).Tag = "not zombie"
                        zombies(i).Enabled = False
                        zombies(i).Visible = False
                        zombies(i).Location = New Point(860, 535)
                    End If
                Next
            End If
        Next

        For Each mower As PictureBox In mowers
            If mower.Location.X >= 860 Then
                mower.Location = New Point(0, 535)
                Me.Controls.Remove(mower)
            End If
        Next
    End Sub

    Private Sub shootPea()
        For Each s As plant In square
            If s.Tag = "peashooter" Then
                If s.wait <= 0 Then
                    For Each z As zombie In zombies
                        If peas(peasSoFar) Is Nothing Then
                            peas(peasSoFar) = New PictureBox
                            peas(peasSoFar).Image = pea.Image
                            peas(peasSoFar).Tag = "not pea"
                            peas(peasSoFar).Image = pea.Image
                            peas(peasSoFar).Enabled = False
                            peas(peasSoFar).Visible = False
                            peas(peasSoFar).Size = New Size(20, 20)
                            peas(peasSoFar).BackColor = Color.FromArgb(0, 0, 0, 0)
                            Me.Controls.Add(peas(peasSoFar))
                            peas(peasSoFar).BringToFront()
                        Else

                        End If
                        If s.Image Is peashootergrass.Image Then
                            If z.Location.Y = s.Location.Y Then
                                peas(peasSoFar).Location = New Point(s.Location.X + 55, s.Location.Y + 30)
                                peas(peasSoFar).Enabled = True
                                peas(peasSoFar).Visible = True
                                peas(peasSoFar).Tag = "pea"
                                s.wait = 11
                                peasSoFar += 1
                                If peasSoFar = 100 Then
                                    peasSoFar = 0
                                End If
                            End If
                        End If
                    Next
                Else
                    s.wait -= 1
                End If
            End If
        Next
    End Sub

    Private Sub movePea()
        For Each p As PictureBox In peas
            If Not p Is Nothing AndAlso p.Tag = "pea" Then
                p.Location = New Point(p.Location.X + 25, p.Location.Y)
                If p.Location.X > 870 Then
                    p.Enabled = False
                    p.Visible = False
                    p.Tag = "no"
                End If

                For Each s As zombie In zombies
                    If s.Tag = "zombie" Or s.Tag = "stopped" Then
                        If p.Location.Y - 30 = s.Location.Y Then
                            If p.Location.X + 20 >= s.Location.X Then
                                p.Visible = False
                                p.Enabled = False
                                p.Location = New Point(0, 0)
                                p.Tag = "no"
                                s.health -= 25
                                If s.health <= 0 Then
                                    s.Tag = "not zombie"
                                    s.Enabled = False
                                    s.Visible = False
                                    s.Location = New Point(860, 535)
                                    score += 10
                                    lblScore.Text = "Score: " & score
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Static seconds As Integer = 0
        seconds += 1
        If seconds = 1000 Then
            seconds = 0
        End If
        If 60 - score \ 100 * 2 > 0 Then
            spawn = 60 - score \ 100 * 2
        End If
        lblScore.Text = "Score: " & score
        score += 1
        For Each sf As plant In square
            If sf.Image Is sunflowergrass.Image Then
                If sf.wait <= 5 Then
                    sf.Image = sunflowergrassclose.Image
                End If
            End If
        Next

        If disSunflower = 0 And plantType <> 1 Then
            picSunflower.Enabled = True
            picSunflower.BorderStyle = BorderStyle.None
        Else
            disSunflower -= 1
        End If
        If disPeashooter = 0 And plantType <> 2 Then
            picPeaShooter.Enabled = True
            picPeaShooter.BorderStyle = BorderStyle.None
        Else
            disPeashooter -= 1
        End If
        If disWallnut = 0 And plantType <> 3 Then
            picWallnut.Enabled = True
            picWallnut.BorderStyle = BorderStyle.None
        Else
            disWallnut -= 1
        End If

        If seconds Mod 1 = 0 Then
            goMower()
        End If

        If seconds Mod stime = 0 Then
            dropSun(Rnd() * 770 + 50, -75, "d")
        End If

        If seconds Mod spawn = 0 Then
            zombiesSoFar += 1
            If zombiesSoFar = 100 Then
                zombiesSoFar = 0
            End If
            newZombie()
        End If

        If seconds Mod sftime = 0 Then
            flowerSun()
        End If

        If seconds Mod 1 = 0 Then
            shootPea()
            movePea()
        End If

        If seconds Mod 1 = 0 Then
            moveZombies()
        End If

        If seconds Mod 1 = 0 Then
            For Each sun As sun In picSun
                sun.tsf -= 1
                If sun.tsf = 0 Then
                    sun.Tag = "not"
                    sun.Visible = False
                    sun.Enabled = False
                    sun.tsf = 30
                End If
                If sun.Tag = "sun" Then
                    If sun.Location.Y < 500 Then
                        sun.Location = New Point(sun.Location.X, sun.Location.Y + 5)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub sunClick(ByVal sender As Object, ByVal e As System.EventArgs)
        sunPts += 25
        Me.lblSunPts.Text = "Sun: " & sunPts
        sender.tag = "not sun"
        sender.Enabled = False
        sender.Visible = False
        sender.location = New Point(860, 535)
    End Sub

    Private Sub plantChoice(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShovel.Click, picSunflower.Click, picPeaShooter.Click, picWallnut.Click
        If picSunflower.Enabled = True Then
            picSunflower.BorderStyle = BorderStyle.None
        End If
        If picPeaShooter.Enabled = True Then
            picPeaShooter.BorderStyle = BorderStyle.None
        End If
        If picWallnut.Enabled = True Then
            picWallnut.BorderStyle = BorderStyle.None
        End If
        If picShovel.Enabled = True Then
            picShovel.BorderStyle = BorderStyle.None
        End If
        If sender Is picShovel Then
            plantType = 0
        ElseIf sender Is picSunflower Then
            plantType = 1
        ElseIf sender Is picPeaShooter Then
            plantType = 2
        ElseIf sender Is picWallnut Then
            plantType = 3
        End If
        sender.borderstyle = BorderStyle.FixedSingle

    End Sub

    Private Sub clickSquare(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case plantType
            Case 0
                If sender.tag <> "grass" Then
                    sender.image = Image.FromFile("grass.jpg")
                    sender.tag = "grass"
                    sender.health = 0
                End If
            Case 1
                If sunPts >= 50 And sender.tag = "grass" Then
                    sender.image = sunflowergrass.Image
                    sender.tag = "sunflower"
                    sunPts -= 50
                    sender.wait = 7
                    Me.lblSunPts.Text = sunPts
                    sender.health = 100
                    picSunflower.Enabled = False
                    disSunflower = 15
                    picSunflower.BorderStyle = BorderStyle.Fixed3D
                End If
            Case 2
                If sunPts >= 100 And sender.tag = "grass" Then
                    sender.image = peashootergrass.Image
                    sender.tag = "peashooter"
                    sunPts -= 100
                    sender.wait = 1
                    Me.lblSunPts.Text = sunPts
                    sender.health = 150
                    picPeaShooter.Enabled = False
                    disPeashooter = 25
                    picPeaShooter.BorderStyle = BorderStyle.Fixed3D
                End If
            Case 3
                If sunPts >= 50 And sender.tag = "grass" Then
                    sender.image = wallnutgrass.Image
                    sender.tag = "wallnut"
                    sunPts -= 50
                    Me.lblSunPts.Text = sunPts
                    sender.health = 500
                    picWallnut.Enabled = False
                    disWallnut = 75
                    picWallnut.BorderStyle = BorderStyle.Fixed3D
                End If
        End Select
        lblSunPts.Text = "Sun: " & sunPts
        plantType = 13441345
    End Sub

    Private Sub flowerSun()
        For Each s As plant In square
            If s.wait <= 0 Then
                If s.Tag = "sunflower" Then
                    dropSun(s.Location.X + 25, s.Location.Y + 25, "f")
                    s.wait = 40
                    s.Image = sunflowergrass.Image
                End If
            Else
                s.wait -= 1
            End If
        Next
    End Sub

    Private Sub btnPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPause.Click
        Static times As Integer = 0
        If times = 0 Then
            timer.Stop()
            btnPause.Text = "Resume"
            For Each p As Control In Me.Controls
                If p.Name <> "btnPause" Then
                    p.Enabled = False
                End If
            Next
        ElseIf times = 1 Then
            timer.Start()
            btnPause.Text = "Pause"
            For Each p As Control In Me.Controls
                p.Enabled = True
            Next
        End If
        If times = 0 Then
            times = 1
        ElseIf times = 1 Then
            times = 0
        End If
    End Sub
End Class