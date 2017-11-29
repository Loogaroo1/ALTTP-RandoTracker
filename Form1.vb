Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available, AgaTree, Library, MazeRace, SpecRock, EtherTab, Floating, DPLedge, BombosTab, ZoraLedge, LakeIsle, Pedestal, Bumper As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

        Dim nobow As New Bitmap(My.Resources.nobow)
        Dim noboomerang As New Bitmap(My.Resources.redboom)
        Dim nohook As New Bitmap(My.Resources.hookshot)
        Dim nobombs As New Bitmap(My.Resources.bombs)
        Dim nopowder As New Bitmap(My.Resources.powder)
        Dim nofirerod As New Bitmap(My.Resources.firerod)
        Dim noicerod As New Bitmap(My.Resources.icerod)
        Dim nobombos As New Bitmap(My.Resources.bombos)
        Dim noether As New Bitmap(My.Resources.ether)
        Dim noquake As New Bitmap(My.Resources.quake)
        Dim nolamp As New Bitmap(My.Resources.lamp)
        Dim nohammer As New Bitmap(My.Resources.hammer)
        Dim noflute As New Bitmap(My.Resources.flute)
        Dim nobugnet As New Bitmap(My.Resources.bugnet)
        Dim nobook As New Bitmap(My.Resources.book)
        Dim nobottle As New Bitmap(My.Resources.bottle)
        Dim nosomaria As New Bitmap(My.Resources.somaria)
        Dim nobyrna As New Bitmap(My.Resources.byrna)
        Dim nocape As New Bitmap(My.Resources.cape)
        Dim nomirror As New Bitmap(My.Resources.mirror)
        Dim noboots As New Bitmap(My.Resources.boots)
        Dim noglove As New Bitmap(My.Resources.glove)
        Dim noflippers As New Bitmap(My.Resources.flippers)
        Dim nopearl As New Bitmap(My.Resources.pearl)
        Dim nomushroom As New Bitmap(My.Resources.mushroom)
        Dim noshovel As New Bitmap(My.Resources.shovel)
        Dim nosword As New Bitmap(My.Resources.nosword)
        Dim noshield As New Bitmap(My.Resources.shield1)
        Dim noaganhim As New Bitmap(My.Resources.aganhim)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g As Graphics = Graphics.FromImage(nobow)
            g.DrawImage(nobow, New Rectangle(0, 0, nobow.Width, nobow.Height),
                    0, 0, nobow.Width, nobow.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noboomerang)
            g.DrawImage(noboomerang, New Rectangle(0, 0, noboomerang.Width, noboomerang.Height),
                    0, 0, noboomerang.Width, noboomerang.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nohook)
            g.DrawImage(nohook, New Rectangle(0, 0, nohook.Width, nohook.Height),
                    0, 0, nohook.Width, nohook.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobombs)
            g.DrawImage(nobombs, New Rectangle(0, 0, nobombs.Width, nobombs.Height),
                    0, 0, nobombs.Width, nobombs.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nopowder)
            g.DrawImage(nopowder, New Rectangle(0, 0, nopowder.Width, nopowder.Height),
                    0, 0, nopowder.Width, nopowder.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nofirerod)
            g.DrawImage(nofirerod, New Rectangle(0, 0, nofirerod.Width, nofirerod.Height),
                    0, 0, nofirerod.Width, nofirerod.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noicerod)
            g.DrawImage(noicerod, New Rectangle(0, 0, noicerod.Width, noicerod.Height),
                    0, 0, noicerod.Width, noicerod.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobombos)
            g.DrawImage(nobombos, New Rectangle(0, 0, nobombos.Width, nobombos.Height),
                    0, 0, nobombos.Width, nobombos.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noether)
            g.DrawImage(noether, New Rectangle(0, 0, noether.Width, noether.Height),
                    0, 0, noether.Width, noether.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noquake)
            g.DrawImage(noquake, New Rectangle(0, 0, noquake.Width, noquake.Height),
                    0, 0, noquake.Width, noquake.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nolamp)
            g.DrawImage(nolamp, New Rectangle(0, 0, nolamp.Width, nolamp.Height),
                    0, 0, nolamp.Width, nolamp.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nohammer)
            g.DrawImage(nohammer, New Rectangle(0, 0, nohammer.Width, nohammer.Height),
                    0, 0, nohammer.Width, nohammer.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noflute)
            g.DrawImage(noflute, New Rectangle(0, 0, noflute.Width, noflute.Height),
                    0, 0, noflute.Width, noflute.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobugnet)
            g.DrawImage(nobugnet, New Rectangle(0, 0, nobugnet.Width, nobugnet.Height),
                    0, 0, nobugnet.Width, nobugnet.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobook)
            g.DrawImage(nobook, New Rectangle(0, 0, nobook.Width, nobook.Height),
                    0, 0, nobook.Width, nobook.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobottle)
            g.DrawImage(nobottle, New Rectangle(0, 0, nobottle.Width, nobottle.Height),
                    0, 0, nobottle.Width, nobottle.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nosomaria)
            g.DrawImage(nosomaria, New Rectangle(0, 0, nosomaria.Width, nosomaria.Height),
                    0, 0, nosomaria.Width, nosomaria.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nobyrna)
            g.DrawImage(nobyrna, New Rectangle(0, 0, nobyrna.Width, nobyrna.Height),
                    0, 0, nobyrna.Width, nobyrna.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nocape)
            g.DrawImage(nocape, New Rectangle(0, 0, nocape.Width, nocape.Height),
                    0, 0, nocape.Width, nocape.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nomirror)
            g.DrawImage(nomirror, New Rectangle(0, 0, nomirror.Width, nomirror.Height),
                    0, 0, nomirror.Width, nomirror.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noboots)
            g.DrawImage(noboots, New Rectangle(0, 0, noboots.Width, noboots.Height),
                    0, 0, noboots.Width, noboots.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noglove)
            g.DrawImage(noglove, New Rectangle(0, 0, noglove.Width, noglove.Height),
                    0, 0, noglove.Width, noglove.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noflippers)
            g.DrawImage(noflippers, New Rectangle(0, 0, noflippers.Width, noflippers.Height),
                    0, 0, noflippers.Width, noflippers.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nopearl)
            g.DrawImage(nopearl, New Rectangle(0, 0, nopearl.Width, nopearl.Height),
                    0, 0, nopearl.Width, nopearl.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nomushroom)
            g.DrawImage(nomushroom, New Rectangle(0, 0, nomushroom.Width, nomushroom.Height),
                    0, 0, nomushroom.Width, nomushroom.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noshovel)
            g.DrawImage(noshovel, New Rectangle(0, 0, noshovel.Width, noshovel.Height),
                    0, 0, noshovel.Width, noshovel.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(nosword)
            g.DrawImage(nosword, New Rectangle(0, 0, nosword.Width, nosword.Height),
                    0, 0, nosword.Width, nosword.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noshield)
            g.DrawImage(noshield, New Rectangle(0, 0, noshield.Width, noshield.Height),
                    0, 0, noshield.Width, noshield.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        Using g As Graphics = Graphics.FromImage(noaganhim)
            g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                    0, 0, noaganhim.Width, noaganhim.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        BowButton.Image = nobow
        BoomButton.Image = noboomerang
        HookButton.Image = nohook
        BombButton.Image = nobombs
        PowderButton.Image = nopowder
        FireButton.Image = nofirerod
        IceButton.Image = noicerod
        BombosButton.Image = nobombos
        EtherButton.Image = noether
        QuakeButton.Image = noquake
        LampButton.Image = nolamp
        HammerButton.Image = nohammer
        FluteButton.Image = noflute
        NetButton.Image = nobugnet
        BookButton.Image = nobook
        BottleButton.Image = nobottle
        SomariaButton.Image = nosomaria
        ByrnaButton.Image = nobyrna
        CapeButton.Image = nocape
        MirrorButton.Image = nomirror
        BootButton.Image = noboots
        GloveButton.Image = noglove
        FlipperButton.Image = noflippers
        PearlButton.Image = nopearl
        MushButton.Image = nomushroom
        ShovelButton.Image = noshovel
        SwordButton.Image = nosword
        ShieldButton.Image = noshield
    End Sub

    Private Sub Form1_KeyDown() Handles Me.KeyDown
        If My.Computer.Keyboard.ShiftKeyDown Then
            EPLabel.Text = "1"
            DPLabel.Text = "2"
            TOHLabel.Text = "3"
            PODLabel.Text = "4"
            SPLabel.Text = "5"
            SWLabel.Text = "6"
            TTLabel.Text = "7"
            IPLabel.Text = "8"
            MMLabel.Text = "9"
            TRLabel.Text = "0"
        End If
    End Sub

    Private Sub Form1_KeyUp() Handles Me.KeyUp
        EPLabel.Text = "EP"
        DPLabel.Text = "DP"
        TOHLabel.Text = "TOH"
        PODLabel.Text = "POD"
        SPLabel.Text = "SP"
        SWLabel.Text = "SW"
        TTLabel.Text = "TT"
        IPLabel.Text = "IP"
        MMLabel.Text = "MM"
        TRLabel.Text = "TR"
    End Sub


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case (e.KeyChar)
            Case "!"
                EPBoss.Checked = True
                EPBoss.Image = My.Resources.bossdead
                EPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then EPPrizes.Text = 0 Else EPChests.Text = 0
                EPLabel2.BackColor = Color.Green
            Case "@"
                DPBoss.Checked = True
                DPBoss.Image = My.Resources.bossdead
                DPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then DPPrizes.Text = 0 Else DPChests.Text = 0
                DPLabel2.BackColor = Color.Green
            Case "#"
                HeraBoss.Checked = True
                HeraBoss.Image = My.Resources.bossdead
                TOHLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then TOHPrizes.Text = 0 Else TOHChests.Text = 0
                TOHLabel2.BackColor = Color.Green
            Case "$"
                PODBoss.Checked = True
                PODBoss.Image = My.Resources.bossdead
                PODLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then PODPrizes.Text = 0 Else PODChests.Text = 0
                PODLabel2.BackColor = Color.Green
            Case "%"
                SPBoss.Checked = True
                SPBoss.Image = My.Resources.bossdead
                SPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then SPPrizes.Text = 0 Else SPChests.Text = 0
                SPLabel2.BackColor = Color.Green
            Case "^"
                SWBoss.Checked = True
                SWBoss.Image = My.Resources.bossdead
                SWLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then SWPrizes.Text = 0 Else SWChests.Text = 0
                SWLabel2.BackColor = Color.Green
            Case "&"
                TTBoss.Checked = True
                TTBoss.Image = My.Resources.bossdead
                TTLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then TTPrizes.Text = 0 Else TTChests.Text = 0
                TTLabel2.BackColor = Color.Green
            Case "*"
                IPBoss.Checked = True
                IPBoss.Image = My.Resources.bossdead
                IPLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then IPPrizes.Text = 0 Else IPChests.Text = 0
                IPLabel2.BackColor = Color.Green
            Case "("
                MMBoss.Checked = True
                MMBoss.Image = My.Resources.bossdead
                MMLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then MMPrizes.Text = 0 Else MMChests.Text = 0
                MMLabel2.BackColor = Color.Green
            Case ")"
                TRBoss.Checked = True
                TRBoss.Image = My.Resources.bossdead
                TRLabel.BackColor = Color.Green
                If RadioButton1.Checked = True Then TRPrizes.Text = 0 Else TRChests.Text = 0
                TRLabel2.BackColor = Color.Green
        End Select
        CrystalCheck()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            HCKeys.Visible = False
            EPKeys.Visible = False
            EPMap.Visible = False
            EPBigKey.Visible = False
            DPKeys.Visible = False
            DPMap.Visible = False
            DPBigKey.Visible = False
            TOHKeys.Visible = False
            HeraMap.Visible = False
            HeraBigKey.Visible = False
            PODKeys.Visible = False
            PODMap.Visible = False
            PODBigKey.Visible = False
            SPKeys.Visible = False
            SPMap.Visible = False
            SPBigKey.Visible = False
            SWKeys.Visible = False
            SWMap.Visible = False
            SWBigKey.Visible = False
            TTKeys.Visible = False
            TTMap.Visible = False
            TTBigKey.Visible = False
            IPKeys.Visible = False
            IPMap.Visible = False
            IPBigKey.Visible = False
            MMKeys.Visible = False
            MMMap.Visible = False
            MMBigKey.Visible = False
            TRKeys.Visible = False
            TRMap.Visible = False
            TRBigKey.Visible = False
            AGLabel.Visible = False
            AGChests.Visible = False
            AGKeys.Visible = False
            GTLabel.Visible = False
            GTChests.Visible = False
            GTKeys.Visible = False
            GTMap.Visible = False
            GTBigKey.Visible = False
            HCPrizes.Visible = True
            EPPrizes.Visible = True
            DPPrizes.Visible = True
            TOHPrizes.Visible = True
            PODPrizes.Visible = True
            SPPrizes.Visible = True
            SWPrizes.Visible = True
            TTPrizes.Visible = True
            IPPrizes.Visible = True
            MMPrizes.Visible = True
            TRPrizes.Visible = True
            EPBoss.Left = 132
            DPBoss.Left = 132
            HeraBoss.Left = 132
            PODBoss.Left = 132
            SPBoss.Left = 132
            SWBoss.Left = 358
            TTBoss.Left = 358
            IPBoss.Left = 358
            MMBoss.Left = 358
            TRBoss.Left = 358
            SWBoss.Left = 347
            TTBoss.Left = 347
            IPBoss.Left = 347
            MMBoss.Left = 347
            TRBoss.Left = 347
            EPReward = 0
            DPReward = 0
            TOHReward = 0
            PODReward = 0
            SPReward = 0
            SWReward = 0
            TTReward = 0
            IPReward = 0
            MMReward = 0
            TRReward = 0
            EPButton.Image = My.Resources.crystal
            DPButton.Image = My.Resources.crystal
            TOHButton.Image = My.Resources.crystal
            PODButton.Image = My.Resources.crystal
            SPButton.Image = My.Resources.crystal
            SWButton.Image = My.Resources.crystal
            TTButton.Image = My.Resources.crystal
            IPButton.Image = My.Resources.crystal
            MMButton.Image = My.Resources.crystal
            TRButton.Image = My.Resources.crystal
            HCChests.Text = 0
            AGChests.Text = 0
            EPChests.Text = 0
            DPChests.Text = 0
            TOHChests.Text = 0
            PODChests.Text = 0
            SPChests.Text = 0
            SWChests.Text = 0
            TTChests.Text = 0
            IPChests.Text = 0
            MMChests.Text = 0
            TRChests.Text = 0
            GTChests.Text = 0
            HCPrizes.Text = 6
            EPPrizes.Text = 3
            DPPrizes.Text = 2
            TOHPrizes.Text = 2
            PODPrizes.Text = 5
            SPPrizes.Text = 6
            SWPrizes.Text = 2
            TTPrizes.Text = 4
            IPPrizes.Text = 3
            MMPrizes.Text = 2
            TRPrizes.Text = 5
            HCCheck()
            EPCheck()
            DPCheck()
            TOHCheck()
            AgaCheck()
            PODCheck()
            SPCheck()
            SWCheck()
            TTCheck()
            IPCheck()
            MMCheck()
            TRCheck()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            HCKeys.Visible = True
            EPKeys.Visible = True
            EPMap.Visible = True
            EPBigKey.Visible = True
            DPKeys.Visible = True
            DPMap.Visible = True
            DPBigKey.Visible = True
            TOHKeys.Visible = True
            HeraMap.Visible = True
            HeraBigKey.Visible = True
            PODKeys.Visible = True
            PODMap.Visible = True
            PODBigKey.Visible = True
            SPKeys.Visible = True
            SPMap.Visible = True
            SPBigKey.Visible = True
            SWKeys.Visible = True
            SWMap.Visible = True
            SWBigKey.Visible = True
            TTKeys.Visible = True
            TTMap.Visible = True
            TTBigKey.Visible = True
            IPKeys.Visible = True
            IPMap.Visible = True
            IPBigKey.Visible = True
            MMKeys.Visible = True
            MMMap.Visible = True
            MMBigKey.Visible = True
            TRKeys.Visible = True
            TRMap.Visible = True
            TRBigKey.Visible = True
            AGLabel.Visible = True
            AGChests.Visible = True
            AGKeys.Visible = True
            GTLabel.Visible = True
            GTChests.Visible = True
            GTKeys.Visible = True
            GTMap.Visible = True
            GTBigKey.Visible = True
            HCPrizes.Visible = False
            EPPrizes.Visible = False
            DPPrizes.Visible = False
            TOHPrizes.Visible = False
            PODPrizes.Visible = False
            SPPrizes.Visible = False
            SWPrizes.Visible = False
            TTPrizes.Visible = False
            IPPrizes.Visible = False
            MMPrizes.Visible = False
            TRPrizes.Visible = False
            EPBoss.Left = 190
            DPBoss.Left = 190
            HeraBoss.Left = 190
            PODBoss.Left = 190
            SPBoss.Left = 190
            SWBoss.Left = 416
            TTBoss.Left = 416
            IPBoss.Left = 416
            MMBoss.Left = 416
            TRBoss.Left = 416
            SWBoss.Left = 405
            TTBoss.Left = 405
            IPBoss.Left = 405
            MMBoss.Left = 405
            TRBoss.Left = 405
            EPReward = -1
            DPReward = -1
            TOHReward = -1
            PODReward = -1
            SPReward = -1
            SWReward = -1
            TTReward = -1
            IPReward = -1
            MMReward = -1
            TRReward = -1
            EPButton.Image = Nothing
            DPButton.Image = Nothing
            TOHButton.Image = Nothing
            PODButton.Image = Nothing
            SPButton.Image = Nothing
            SWButton.Image = Nothing
            TTButton.Image = Nothing
            IPButton.Image = Nothing
            MMButton.Image = Nothing
            TRButton.Image = Nothing
            HCChests.Text = 8
            AGChests.Text = 2
            EPChests.Text = 6
            DPChests.Text = 6
            TOHChests.Text = 6
            PODChests.Text = 14
            SPChests.Text = 10
            SWChests.Text = 8
            TTChests.Text = 8
            IPChests.Text = 8
            MMChests.Text = 8
            TRChests.Text = 12
            GTChests.Text = 27
            HCPrizes.Text = 6
            EPPrizes.Text = 3
            DPPrizes.Text = 2
            TOHPrizes.Text = 2
            PODPrizes.Text = 5
            SPPrizes.Text = 6
            SWPrizes.Text = 2
            TTPrizes.Text = 4
            IPPrizes.Text = 3
            MMPrizes.Text = 2
            TRPrizes.Text = 5
            HCCheck()
            EPCheck()
            DPCheck()
            TOHCheck()
            AgaCheck()
            PODCheck()
            SPCheck()
            SWCheck()
            TTCheck()
            IPCheck()
            MMCheck()
            TRCheck()
        End If
    End Sub

    Public Sub LWCheck()
        '' Lumberjack Tree - Aganhim and Boots
        If Aganhim = True And Boots = True Then
            LW6.Enabled = True
            LW6.BackColor = Color.WhiteSmoke
        Else
            LW6.Checked = False
            LW6.Enabled = False
            LW6.BackColor = Color.Red
        End If

        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave - Bomb
        If Bombs = True Then
            LW9.Enabled = True
            LW9.BackColor = Color.WhiteSmoke
            LW10.Enabled = True
            LW10.BackColor = Color.WhiteSmoke
            LW12.Enabled = True
            LW12.BackColor = Color.WhiteSmoke
            LW18.Enabled = True
            LW18.BackColor = Color.WhiteSmoke
            LW19.Enabled = True
            LW19.BackColor = Color.WhiteSmoke
            LW20.Enabled = True
            LW20.BackColor = Color.WhiteSmoke
        Else
            LW9.Enabled = True
            LW9.BackColor = Color.Yellow
            LW10.Enabled = True
            LW10.BackColor = Color.Yellow
            LW12.Checked = False
            LW12.Enabled = False
            LW12.BackColor = Color.Red
            LW18.Checked = False
            LW18.Enabled = False
            LW18.BackColor = Color.Red
            LW19.Checked = False
            LW19.Enabled = False
            LW19.BackColor = Color.Red
            LW20.Enabled = False
            LW20.BackColor = Color.Red
        End If

        '' Sick Kid - Bottle
        If Bottle = True Then
            LW14.Enabled = True
            LW14.BackColor = Color.WhiteSmoke
        Else
            LW14.Checked = False
            LW14.Enabled = False
            LW14.BackColor = Color.Red
        End If

        '' Library, Bonk Rocks - Boots
        If Boots = True Then
            LW15.Enabled = True
            LW15.BackColor = Color.WhiteSmoke
            LW29.Enabled = True
            LW29.BackColor = Color.WhiteSmoke
        Else
            LW15.Checked = False
            LW15.Enabled = False
            LW15.BackColor = Color.Red
            LW29.Checked = False
            LW29.Enabled = False
            LW29.BackColor = Color.Red
        End If

        '' Maze Race, Sahasrahla's Back Room - Boots or Bomb
        If Boots = True Or Bombs = True Then
            LW16.Enabled = True
            LW16.BackColor = Color.WhiteSmoke
            LW21.Enabled = True
            LW21.BackColor = Color.WhiteSmoke
        Else
            LW16.Checked = False
            LW16.Enabled = False
            LW16.BackColor = Color.Red
            LW21.Checked = False
            LW21.Enabled = True
            LW21.BackColor = Color.Red
        End If

        '' Desert Ledge - Desert Palace access (Book or Flute/Mitt/Mirror)
        If Book = True Or (Flute = True And Glove = 2 And Mirror = True) Then
            LW22.Enabled = True
            LW22.BackColor = Color.WhiteSmoke
        Else
            LW22.Checked = False
            LW22.Enabled = False
            LW22.BackColor = Color.Red
        End If

        '' Bombos Tablet - Master Sword, Book, Access via Dark World
        If Pearl = True And Mirror = True And Book = True And Sword >= 2 And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or Aganhim = True And Hookshot = True And (Hammer = True Or Glove > 0 Or Flippers = True)) Then
            LW23.Enabled = True
            LW23.BackColor = Color.WhiteSmoke
        Else
            LW23.Checked = False
            LW23.Enabled = False
            LW23.BackColor = Color.Red
        End If

        '' Checkerboard - Flute, Mitt, Mirror (no Pearl required)
        If Flute = True And Glove = 2 And Mirror = True Then
            LW24.Enabled = True
            LW24.BackColor = Color.WhiteSmoke
        Else
            LW24.Checked = False
            LW24.Enabled = False
            LW24.BackColor = Color.Red
        End If

        '' Dwarves - Pearl, Mitt (no Mirror required)
        If Pearl = True And Glove = 2 Then
            LW25.Enabled = True
            LW25.BackColor = Color.WhiteSmoke
        Else
            LW25.Checked = False
            LW25.Enabled = False
            LW25.BackColor = Color.Red
        End If

        '' Powder Bat - Powder, Hammer or Mirror+Pearl+Mitt
        If Powder = True And (Hammer = True Or (Mirror = True And Pearl = True And Glove = 2)) Then
            LW26.Enabled = True
            LW26.BackColor = Color.WhiteSmoke
        Else
            LW26.Checked = False
            LW26.Enabled = False
            LW26.BackColor = Color.Red
        End If

        '' Dig Spot - Shovel
        If Shovel = True Then
            LW27.Enabled = True
            LW27.BackColor = Color.WhiteSmoke
        Else
            LW27.Checked = False
            LW27.Enabled = False
            LW27.BackColor = Color.Red
        End If

        '' Cave south of Grove, Graveyard Cave - Mirror, Access via Dark World
        If Mirror = True And Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or (Aganhim = True And Hookshot = True And Flippers = True And Glove > 0)) Then
            LW28.Enabled = True
            LW28.BackColor = Color.WhiteSmoke
            LW30.Enabled = True
            LW30.BackColor = Color.WhiteSmoke
        Else
            LW28.Checked = False
            LW28.Enabled = False
            LW28.BackColor = Color.Red
            LW30.Checked = False
            LW30.Enabled = False
            LW30.BackColor = Color.Red
        End If

        '' King's Tomb - Boots, Mitt or Access via Dark World
        If Boots = True And (Glove = 2 Or (Mirror = True And (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Hammer = True Or Flippers = True Or Glove > 0)))) Then
            LW31.Enabled = True
            LW31.BackColor = Color.WhiteSmoke
        Else
            LW31.Enabled = False
            LW31.BackColor = Color.Red
        End If

        '' Hobo, Zora's Ledge, Waterfall - Flippers (Hobo can be faked)
        If Flippers = True Then
            LW32.Enabled = True
            LW32.BackColor = Color.WhiteSmoke
            LW35.Enabled = True
            LW35.BackColor = Color.WhiteSmoke
            LW37.Enabled = True
            LW37.BackColor = Color.WhiteSmoke
        Else
            LW32.Checked = False
            LW32.Enabled = True
            LW32.BackColor = Color.Orange
            If Pearl = True Then
                LW35.Enabled = True
                LW35.BackColor = Color.Orange
            Else
                LW35.Checked = False
                LW35.Enabled = False
                LW35.BackColor = Color.Red
            End If
            LW37.Checked = False
            LW37.Enabled = False
            LW37.BackColor = Color.Red
        End If

        '' Hylia Island - Flippers, Mirror, Pearl, access via Dark World
        If Pearl = True And Flippers = True And Mirror = True And (Aganhim = True Or (Glove > 0 And Hammer = True) Or Glove = 2) Then
            LW33.Enabled = True
            LW33.BackColor = Color.WhiteSmoke
        Else
            LW33.Checked = False
            LW33.Enabled = False
            LW33.BackColor = Color.Red
        End If

        '' Witch - Mushroom
        If Mushroom = True Then
            LW34.Enabled = True
            LW34.BackColor = Color.WhiteSmoke
        Else
            LW34.Checked = False
            LW34.Enabled = False
            LW34.BackColor = Color.Red
        End If

        '' Zora - Glove or Flippers (can be faked)
        If Flippers = True Or Glove > 0 Then
            LW36.Enabled = True
            LW36.BackColor = Color.WhiteSmoke
        Else
            LW36.Enabled = True
            LW36.BackColor = Color.Orange
        End If

        '' Old Man - Death Mountain access and Lamp (can be dark-navved)
        If Flute = True Or Glove > 0 Then
            If Lamp = True Then
                LW38.Enabled = True
                LW38.BackColor = Color.WhiteSmoke
            Else
                LW38.Enabled = True
                LW38.BackColor = Color.Orange
            End If
        Else
            LW38.Checked = False
            LW38.Enabled = False
            LW38.BackColor = Color.Red
        End If

        '' Spectacle Cave - Death Mountain access (Lamp prevents sequence break if Glove is used)
        If Flute = True Or (Glove > 0 And Lamp = True) Then
            LW39.Enabled = True
            LW39.BackColor = Color.WhiteSmoke
        ElseIf Glove > 0 Then
            LW39.Enabled = True
            LW39.BackColor = Color.Orange
        Else
            LW39.Checked = False
            LW39.Enabled = False
            LW39.BackColor = Color.Red
        End If

        '' Spectacle Rock - Death Mountain access (Lamp prevents sequence break if Glove is used) and Mirror
        If Mirror = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
            LW40.Enabled = True
            LW40.BackColor = Color.WhiteSmoke
        ElseIf Mirror = True And Glove > 0 Then
            LW40.Enabled = True
            LW40.BackColor = Color.Orange
        Else
            LW40.Checked = False
            LW40.Enabled = False
            LW40.BackColor = Color.Red
        End If

        '' Ether Tablet - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot+Hammer, Master Sword, Book
        If Sword >= 2 And Book = True And (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            LW41.Enabled = True
            LW41.BackColor = Color.WhiteSmoke
        ElseIf Sword >= 2 And Book = True And Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
            LW41.Enabled = True
            LW41.BackColor = Color.Orange
        Else
            LW41.Checked = False
            LW41.Enabled = False
            LW41.BackColor = Color.Red
        End If

        '' East Death Mountain, Spiral Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Hookshot or Mirror+Hammer
        If (Flute = True Or (Glove > 0 And Lamp = True)) And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Bombs = True Then
                LW42.Enabled = True
                LW42.BackColor = Color.WhiteSmoke
            Else
                LW42.Enabled = True
                LW42.BackColor = Color.Yellow
            End If
            LW43.Enabled = True
            LW43.BackColor = Color.WhiteSmoke
        ElseIf Glove > 0 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Bombs = True Then
                LW42.Enabled = True
                LW42.BackColor = Color.Orange
            Else
                LW42.Enabled = True
                LW42.BackColor = Color.Yellow
            End If
            LW43.Enabled = True
            LW43.BackColor = Color.Orange
        Else
            LW42.Checked = False
            LW42.Enabled = False
            LW42.BackColor = Color.Red
            LW43.Checked = False
            LW43.Enabled = False
            LW43.BackColor = Color.Red
        End If

        '' Floating Island - Death Mountain access (Lamp prevents sequence break if Glove is used), Mitt, Pearl, Mirror
        If Pearl = True And Glove = 2 And Mirror = True And (Hookshot = True Or Hammer = True) Then
            If Flute = True Or Lamp = True Then
                LW44.Enabled = True
                LW44.BackColor = Color.WhiteSmoke
            Else
                LW44.Enabled = True
                LW44.BackColor = Color.Orange
            End If
        Else
            LW44.Checked = False
            LW44.Enabled = False
            LW44.BackColor = Color.Red
        End If

        '' Mimic Cave - Turtle Rock access (Lamp prevents sequence break if Glove is used), Mirror
        If TRAccess = True And Mirror = True Then
            If FireRod = True Then
                LW45.Enabled = True
                LW45.BackColor = Color.WhiteSmoke
            Else
                LW45.Enabled = True
                LW45.BackColor = Color.Yellow
            End If
        Else
            LW45.Checked = False
            LW45.Enabled = False
            LW45.BackColor = Color.Red
        End If

        '' Sahasrahla's Green Pendant
        If GreenPendant = True Then
            LW46.Enabled = True
            LW46.BackColor = Color.WhiteSmoke
        Else
            LW46.Checked = False
            LW46.Enabled = False
            LW46.BackColor = Color.Red
        End If

        '' Pedestal
        If PendantCount = 3 Then
            LW47.Enabled = True
            LW47.BackColor = Color.WhiteSmoke
        Else
            LW47.Checked = False
            LW47.Enabled = False
            LW47.BackColor = Color.Red
        End If

        If LW1.Checked = True Then LW1.BackColor = Color.FromArgb(64, 64, 64)
        If LW2.Checked = True Then LW2.BackColor = Color.FromArgb(64, 64, 64)
        If LW6.Checked = True Then LW6.BackColor = Color.FromArgb(64, 64, 64)
        If LW7.Checked = True Then LW7.BackColor = Color.FromArgb(64, 64, 64)
        If LW8.Checked = True Then LW8.BackColor = Color.FromArgb(64, 64, 64)
        If LW9.Checked = True Then LW9.BackColor = Color.FromArgb(64, 64, 64)
        If LW10.Checked = True Then LW10.BackColor = Color.FromArgb(64, 64, 64)
        If LW11.Checked = True Then LW11.BackColor = Color.FromArgb(64, 64, 64)
        If LW12.Checked = True Then LW12.BackColor = Color.FromArgb(64, 64, 64)
        If LW13.Checked = True Then LW13.BackColor = Color.FromArgb(64, 64, 64)
        If LW14.Checked = True Then LW14.BackColor = Color.FromArgb(64, 64, 64)
        If LW15.Checked = True Then LW15.BackColor = Color.FromArgb(64, 64, 64)
        If LW16.Checked = True Then LW16.BackColor = Color.FromArgb(64, 64, 64)
        If LW17.Checked = True Then LW17.BackColor = Color.FromArgb(64, 64, 64)
        If LW18.Checked = True Then LW18.BackColor = Color.FromArgb(64, 64, 64)
        If LW19.Checked = True Then LW19.BackColor = Color.FromArgb(64, 64, 64)
        If LW20.Checked = True Then LW20.BackColor = Color.FromArgb(64, 64, 64)
        If LW21.Checked = True Then LW21.BackColor = Color.FromArgb(64, 64, 64)
        If LW22.Checked = True Then LW22.BackColor = Color.FromArgb(64, 64, 64)
        If LW23.Checked = True Then LW23.BackColor = Color.FromArgb(64, 64, 64)
        If LW24.Checked = True Then LW24.BackColor = Color.FromArgb(64, 64, 64)
        If LW25.Checked = True Then LW25.BackColor = Color.FromArgb(64, 64, 64)
        If LW26.Checked = True Then LW26.BackColor = Color.FromArgb(64, 64, 64)
        If LW27.Checked = True Then LW27.BackColor = Color.FromArgb(64, 64, 64)
        If LW28.Checked = True Then LW28.BackColor = Color.FromArgb(64, 64, 64)
        If LW29.Checked = True Then LW29.BackColor = Color.FromArgb(64, 64, 64)
        If LW30.Checked = True Then LW30.BackColor = Color.FromArgb(64, 64, 64)
        If LW31.Checked = True Then LW31.BackColor = Color.FromArgb(64, 64, 64)
        If LW32.Checked = True Then LW32.BackColor = Color.FromArgb(64, 64, 64)
        If LW33.Checked = True Then LW33.BackColor = Color.FromArgb(64, 64, 64)
        If LW34.Checked = True Then LW34.BackColor = Color.FromArgb(64, 64, 64)
        If LW35.Checked = True Then LW35.BackColor = Color.FromArgb(64, 64, 64)
        If LW36.Checked = True Then LW36.BackColor = Color.FromArgb(64, 64, 64)
        If LW37.Checked = True Then LW37.BackColor = Color.FromArgb(64, 64, 64)
        If LW38.Checked = True Then LW38.BackColor = Color.FromArgb(64, 64, 64)
        If LW39.Checked = True Then LW39.BackColor = Color.FromArgb(64, 64, 64)
        If LW40.Checked = True Then LW40.BackColor = Color.FromArgb(64, 64, 64)
        If LW41.Checked = True Then LW41.BackColor = Color.FromArgb(64, 64, 64)
        If LW42.Checked = True Then LW42.BackColor = Color.FromArgb(64, 64, 64)
        If LW43.Checked = True Then LW43.BackColor = Color.FromArgb(64, 64, 64)
        If LW44.Checked = True Then LW44.BackColor = Color.FromArgb(64, 64, 64)
        If LW45.Checked = True Then LW45.BackColor = Color.FromArgb(64, 64, 64)
        If LW46.Checked = True Then LW46.BackColor = Color.FromArgb(64, 64, 64)
        If LW47.Checked = True Then LW47.BackColor = Color.FromArgb(64, 64, 64)

    End Sub

    Public Sub DWCheck()
        '' Pyramid - Aganhim or Access from warp
        If Aganhim = True Or (Pearl = True And ((Glove > 0 And Hammer = True) Or (Glove = 2 And Flippers = True))) Then
            DW1.Enabled = True
            DW1.BackColor = Color.WhiteSmoke
        Else
            DW1.Checked = False
            DW1.Enabled = False
            DW1.BackColor = Color.Red
        End If

        '' Chest Game, C House, Sealed Hut, Bumper Cave - Mitt, Glove/Hammer, or Aganhim/Hookshot/Access (Cape also required for Bumper Cave)
        If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
            DW2.Enabled = True
            DW2.BackColor = Color.WhiteSmoke
            DW3.Enabled = True
            DW3.BackColor = Color.WhiteSmoke
            DW4.Enabled = True
            DW4.BackColor = Color.WhiteSmoke
            If Cape = True Then
                DW7.Enabled = True
                DW7.BackColor = Color.WhiteSmoke
            Else
                DW7.Checked = False
                DW7.Enabled = False
                DW7.BackColor = Color.Red
            End If
        Else
            DW2.Checked = False
            DW2.Enabled = False
            DW2.BackColor = Color.Red
            DW3.Checked = False
            DW3.Enabled = False
            DW3.BackColor = Color.Red
            DW4.Checked = False
            DW4.Enabled = False
            DW4.BackColor = Color.Red
            DW7.Checked = False
            DW7.Enabled = False
            DW7.BackColor = Color.Red
        End If

        '' Digging Game, Tree Kid, Swamp Hype - Mitt, Glove/Hammer, Aganhim/Hammer, or Aganhim/Hookshot/Glove or Flippers
        If Pearl = True And (Glove = 2 Or (Hammer = True And Glove > 0) Or (Hammer = True And Aganhim = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Flippers = True))) Then
            DW5.Enabled = True
            DW5.BackColor = Color.WhiteSmoke
            DW10.Enabled = True
            DW10.BackColor = Color.WhiteSmoke
            If Bombs = True Then
                DW11.Enabled = True
                DW11.BackColor = Color.WhiteSmoke
            Else
                DW11.Checked = False
                DW11.Enabled = False
                DW11.BackColor = Color.Red
            End If
        Else
            DW5.Checked = False
            DW5.Enabled = False
            DW5.BackColor = Color.Red
            DW10.Checked = False
            DW10.Enabled = False
            DW10.BackColor = Color.Red
            DW11.Checked = False
            DW11.Enabled = False
            DW11.BackColor = Color.Red
        End If

        '' Mire Cave - Flute, Mitt, Pearl
        If Flute = True And Glove = 2 And Pearl = True Then
            DW6.Enabled = True
            DW6.BackColor = Color.WhiteSmoke
        Else
            DW6.Checked = False
            DW6.Enabled = False
            DW6.BackColor = Color.Red
        End If

        '' Purple Chest - Dwarves complete (no further items required)
        If LW25.Checked = True Then
            DW8.Enabled = True
            DW8.BackColor = Color.WhiteSmoke
        Else
            DW8.Checked = False
            DW8.Enabled = False
            DW8.BackColor = Color.Red
        End If

        '' Hammer Pegs - Pearl, Mitt, Hammer
        If Pearl = True And Glove = 2 And Hammer = True Then
            DW9.Enabled = True
            DW9.BackColor = Color.WhiteSmoke
        Else
            DW9.Checked = False
            DW9.Enabled = False
            DW9.BackColor = Color.Red
        End If

        '' Catfish - Pearl, Glove, Aganhim/Hammer/Mitt+Flippers
        If Pearl = True And Glove > 0 And ((Glove = 2 And Flippers = True) Or Hammer = True Or Aganhim = True) Then
            DW12.Enabled = True
            DW12.BackColor = Color.WhiteSmoke
        Else
            DW12.Checked = False
            DW12.Enabled = False
            DW12.BackColor = Color.Red
        End If

        '' Spike Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Hammer, Safety item (Byrna or Cape)
        If Pearl = True And Hammer = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
            If Byrna = True Or Cape = True Then
                DW13.Enabled = True
                DW13.BackColor = Color.WhiteSmoke
            Else
                DW13.Enabled = True
                DW13.BackColor = Color.Orange
            End If
        ElseIf Pearl = True And Hammer = True And Glove > 0 Then
            DW13.Enabled = True
            DW13.BackColor = Color.Orange
        Else
            DW13.Checked = False
            DW13.Enabled = False
            DW13.BackColor = Color.Red
        End If

        '' East DW DM - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror
        If Glove = 2 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Flute = True Or Lamp = True Then
                DW14.Enabled = True
                DW14.BackColor = Color.WhiteSmoke
            Else
                DW14.Enabled = True
                DW14.BackColor = Color.Orange
            End If
        Else
            DW14.Checked = False
            DW14.Enabled = False
            DW14.BackColor = Color.Red
        End If

        '' Hookshot Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror+Boots (Partially blocked without Hookshot)
        If Pearl = True And Glove = 2 And Hookshot = True Then
            If Flute = True Or Lamp = True Then
                DW15.Enabled = True
                DW15.BackColor = Color.WhiteSmoke
            Else
                DW15.Enabled = True
                DW15.BackColor = Color.Orange
            End If
        ElseIf Pearl = True And Glove = 2 And Hammer = True And Mirror = True And Boots = True Then
            DW15.Enabled = True
            DW15.BackColor = Color.Yellow
        Else
            DW15.Checked = False
            DW15.Enabled = False
            DW15.BackColor = Color.Red
        End If

        '' Fat Fairy - Crystals 5 & 6, Pearl, Hammer, Glove or Aganhim
        If Pearl = True And FairyCrystal = 2 And ((Glove > 0 And Hammer = True) Or (Aganhim = True And Mirror = True) Or (Aganhim = True And Hammer = True)) Then
            DW16.Enabled = True
            DW16.BackColor = Color.WhiteSmoke
        Else
            DW16.Checked = False
            DW16.Enabled = False
            DW16.BackColor = Color.Red
        End If

        If DW1.Checked = True Then DW1.BackColor = Color.FromArgb(64, 64, 64)
        If DW2.Checked = True Then DW2.BackColor = Color.FromArgb(64, 64, 64)
        If DW3.Checked = True Then DW3.BackColor = Color.FromArgb(64, 64, 64)
        If DW4.Checked = True Then DW4.BackColor = Color.FromArgb(64, 64, 64)
        If DW5.Checked = True Then DW5.BackColor = Color.FromArgb(64, 64, 64)
        If DW6.Checked = True Then DW6.BackColor = Color.FromArgb(64, 64, 64)
        If DW7.Checked = True Then DW7.BackColor = Color.FromArgb(64, 64, 64)
        If DW8.Checked = True Then DW8.BackColor = Color.FromArgb(64, 64, 64)
        If DW9.Checked = True Then DW9.BackColor = Color.FromArgb(64, 64, 64)
        If DW10.Checked = True Then DW10.BackColor = Color.FromArgb(64, 64, 64)
        If DW11.Checked = True Then DW11.BackColor = Color.FromArgb(64, 64, 64)
        If DW12.Checked = True Then DW12.BackColor = Color.FromArgb(64, 64, 64)
        If DW13.Checked = True Then DW13.BackColor = Color.FromArgb(64, 64, 64)
        If DW14.Checked = True Then DW14.BackColor = Color.FromArgb(64, 64, 64)
        If DW15.Checked = True Then DW15.BackColor = Color.FromArgb(64, 64, 64)
        If DW16.Checked = True Then DW16.BackColor = Color.FromArgb(64, 64, 64)

    End Sub

    Private Sub LocationClick(sender As Object, e As EventArgs) Handles LW1.CheckedChanged, LW2.CheckedChanged, LW6.CheckedChanged, LW7.CheckedChanged, LW8.CheckedChanged, LW9.CheckedChanged, LW10.CheckedChanged, LW11.CheckedChanged, LW12.CheckedChanged, LW13.CheckedChanged, LW14.CheckedChanged, LW15.CheckedChanged, LW16.CheckedChanged,
        LW17.CheckedChanged, LW18.CheckedChanged, LW19.CheckedChanged, LW20.CheckedChanged, LW21.CheckedChanged, LW22.CheckedChanged, LW23.CheckedChanged, LW24.CheckedChanged, LW25.CheckedChanged, LW26.CheckedChanged, LW27.CheckedChanged, LW28.CheckedChanged, LW29.CheckedChanged, LW30.CheckedChanged, LW31.CheckedChanged, LW32.CheckedChanged,
        LW33.CheckedChanged, LW34.CheckedChanged, LW35.CheckedChanged, LW36.CheckedChanged, LW37.CheckedChanged, LW38.CheckedChanged, LW39.CheckedChanged, LW40.CheckedChanged, LW41.CheckedChanged, LW42.CheckedChanged, LW43.CheckedChanged, LW44.CheckedChanged, LW45.CheckedChanged, LW46.CheckedChanged, LW47.CheckedChanged, DW1.CheckedChanged,
        DW2.CheckedChanged, DW3.CheckedChanged, DW4.CheckedChanged, DW5.CheckedChanged, DW6.CheckedChanged, DW7.CheckedChanged, DW8.CheckedChanged, DW9.CheckedChanged, DW10.CheckedChanged, DW11.CheckedChanged, DW12.CheckedChanged, DW13.CheckedChanged, DW14.CheckedChanged, DW15.CheckedChanged, DW16.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then DirectCast(sender, CheckBox).BackColor = Color.FromArgb(64, 64, 64) Else DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
        LWCheck()
        DWCheck()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgaTree = (AgaTree + 1) Mod 3
        Select Case AgaTree
            Case 1
                Button1.Image = My.Resources.redchest
            Case 2
                Button1.Image = My.Resources.greenchest
            Case Else
                Button1.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Library = (Library + 1) Mod 3
        Select Case Library
            Case 1
                Button2.Image = My.Resources.redchest
            Case 2
                Button2.Image = My.Resources.greenchest
            Case Else
                Button2.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MazeRace = (MazeRace + 1) Mod 3
        Select Case MazeRace
            Case 1
                Button3.Image = My.Resources.redchest
            Case 2
                Button3.Image = My.Resources.greenchest
            Case Else
                Button3.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SpecRock = (SpecRock + 1) Mod 3
        Select Case SpecRock
            Case 1
                Button4.Image = My.Resources.redchest
            Case 2
                Button4.Image = My.Resources.greenchest
            Case Else
                Button4.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EtherTab = (EtherTab + 1) Mod 3
        Select Case EtherTab
            Case 1
                Button5.Image = My.Resources.redchest
            Case 2
                Button5.Image = My.Resources.greenchest
            Case Else
                Button5.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Floating = (Floating + 1) Mod 3
        Select Case Floating
            Case 1
                Button6.Image = My.Resources.redchest
            Case 2
                Button6.Image = My.Resources.greenchest
            Case Else
                Button6.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DPLedge = (DPLedge + 1) Mod 3
        Select Case DPLedge
            Case 1
                Button7.Image = My.Resources.redchest
            Case 2
                Button7.Image = My.Resources.greenchest
            Case Else
                Button7.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BombosTab = (BombosTab + 1) Mod 3
        Select Case BombosTab
            Case 1
                Button8.Image = My.Resources.redchest
            Case 2
                Button8.Image = My.Resources.greenchest
            Case Else
                Button8.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ZoraLedge = (ZoraLedge + 1) Mod 3
        Select Case ZoraLedge
            Case 1
                Button9.Image = My.Resources.redchest
            Case 2
                Button9.Image = My.Resources.greenchest
            Case Else
                Button9.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LakeIsle = (LakeIsle + 1) Mod 3
        Select Case LakeIsle
            Case 1
                Button10.Image = My.Resources.redchest
            Case 2
                Button10.Image = My.Resources.greenchest
            Case Else
                Button10.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Pedestal = (Pedestal + 1) Mod 3
        Select Case Pedestal
            Case 1
                Button11.Image = My.Resources.redchest
            Case 2
                Button11.Image = My.Resources.greenchest
            Case Else
                Button11.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Bumper = (Bumper + 1) Mod 3
        Select Case Bumper
            Case 1
                Button12.Image = My.Resources.redchest
            Case 2
                Button12.Image = My.Resources.greenchest
            Case Else
                Button12.Image = My.Resources.chestmaybe
        End Select
    End Sub

    Public Sub HCCheck()
        If RadioButton1.Checked = True Then
            If Glove > 0 And Lamp = True And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Green
                HCLabel.ForeColor = Color.White
                HCChests.Text = 8
                HCChests.ForeColor = Color.White
            ElseIf Lamp = True And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 8
                HCChests.ForeColor = Color.Yellow
            ElseIf Glove > 0 And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 8
                HCChests.ForeColor = Color.Orange
            ElseIf Lamp = True Then
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 5
                HCChests.ForeColor = Color.White
            Else
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
                HCChests.Text = 5
                HCChests.ForeColor = Color.Yellow
            End If
        Else
            If (Glove > 0 Or HCKeys.Text = 1) And Lamp = True And (Bombs = True Or Boots = True) Then
                HCLabel.BackColor = Color.Green
                HCLabel.ForeColor = Color.White
            Else
                HCLabel.BackColor = Color.Yellow
                HCLabel.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As EventArgs) Handles HCChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If HCChests.Text > 0 Then HCChests.Text = HCChests.Text - 1
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If HCChests.Text < 8 Then HCChests.Text = HCChests.Text + 1
            End If
        End If
    End Sub

    Private Sub HCKeys_MouseDown(sender As Object, e As EventArgs) Handles HCKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then HCKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then HCKeys.Text = 0
        LWCheck()
    End Sub

    Private Sub HCPrizes_MouseDown(sender As Object, e As EventArgs) Handles HCPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If HCPrizes.Text > 0 Then HCPrizes.Text = HCPrizes.Text - 1
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If HCPrizes.Text < 6 Then HCPrizes.Text = HCPrizes.Text + 1
            End If
        End If
    End Sub

    Private Sub AGChests_MouseDown(sender As Object, e As MouseEventArgs) Handles AGChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If AGChests.Text > 0 Then AGChests.Text = AGChests.Text - 1
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If AGChests.Text < 2 Then AGChests.Text = AGChests.Text + 1
            End If
        End If
    End Sub

    Private Sub EPClick(sender As Object, e As EventArgs) Handles EPMap.CheckedChanged, EPBigKey.CheckedChanged, EPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "EPMap"
                If EPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    EPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "EPBigKey"
                If EPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    EPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    EPBigKey.BackColor = Color.Red
                End If
            Case "EPBoss"
                If EPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    EPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    EPButton.BackColor = Color.Black
                End If
        End Select
        EPCheck()
        CrystalCheck()
    End Sub

    Private Sub EPChests_MouseDown(sender As Object, e As EventArgs) Handles EPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If EPChests.Text > 0 Then EPChests.Text = EPChests.Text - 1
                If EPChests.Text = 0 Then EPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If EPChests.Text < 6 Then EPChests.Text = EPChests.Text + 1
                EPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub EPPrizes_MouseDown(sender As Object, e As EventArgs) Handles EPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If EPPrizes.Text > 0 Then EPPrizes.Text = EPPrizes.Text - 1
                If EPPrizes.Text = 0 Then EPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If EPPrizes.Text < 3 Then EPPrizes.Text = EPPrizes.Text + 1
                EPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Public Sub EPCheck()
        If RadioButton1.Checked = True Then
            If Bow > 1 Then
                EPLabel.ForeColor = Color.White
                EPBoss.Enabled = True
                EPChests.Text = 6
                If Lamp = True Then
                    EPLabel.BackColor = Color.Green
                    EPChests.ForeColor = Color.White
                Else
                    EPLabel.BackColor = Color.Orange
                    EPChests.ForeColor = Color.Orange
                End If
            Else
                EPLabel.BackColor = Color.Yellow
                EPLabel.ForeColor = Color.Black
                EPBoss.Enabled = False
                EPChests.Text = 5
                If Lamp = True Then EPChests.ForeColor = Color.White Else EPChests.ForeColor = Color.Yellow
            End If
        Else
            If Bow > 1 And Lamp = True And EPBigKey.Checked = True Then
                EPLabel.ForeColor = Color.White
                EPLabel.BackColor = Color.Green
                EPBoss.Enabled = True
            ElseIf bow > 1 And EPBigKey.Checked = True Then
                EPLabel.ForeColor = Color.White
                EPLabel.BackColor = Color.Orange
                EPBoss.Enabled = True
            Else
                EPLabel.ForeColor = Color.Black
                EPLabel.BackColor = Color.Yellow
                EPBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub DPClick(sender As Object, e As EventArgs) Handles DPMap.CheckedChanged, DPBigKey.CheckedChanged, DPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "DPMap"
                If DPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    DPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "DPBigKey"
                If DPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    DPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    DPBigKey.BackColor = Color.Red
                End If
            Case "DPBoss"
                If DPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    DPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    DPButton.BackColor = Color.Black
                End If
        End Select
        DPCheck()
        CrystalCheck()
    End Sub
    Private Sub DPChests_MouseDown(sender As Object, e As EventArgs) Handles DPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If DPChests.Text > 0 Then DPChests.Text = DPChests.Text - 1
                If DPChests.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If DPChests.Text < 6 Then DPChests.Text = DPChests.Text + 1
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub DPPrizes_MouseDown(sender As Object, e As EventArgs) Handles DPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If DPPrizes.Text > 0 Then DPPrizes.Text = DPPrizes.Text - 1
                If DPPrizes.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If DPPrizes.Text < 2 Then DPPrizes.Text = DPPrizes.Text + 1
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DPKeys_MouseDown(sender As Object, e As EventArgs) Handles DPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then DPKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then DPKeys.Text = 0
        DPCheck()
    End Sub

    Public Sub DPCheck()
        If RadioButton1.Checked = True Then
            If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 Then
                DPLabel.BackColor = Color.Green
                DPLabel.ForeColor = Color.White
                DPChests.Text = 6
                DPChests.ForeColor = Color.White
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPChests.Text = 5
                DPChests.ForeColor = Color.Yellow
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPChests.Text = 4
                DPChests.ForeColor = Color.Yellow
                DPBoss.Enabled = False
            Else
                DPLabel.BackColor = Color.Red
                DPLabel.ForeColor = Color.Black
                DPChests.Text = 0
                DPChests.ForeColor = Color.White
                DPBoss.Enabled = False
            End If
        Else
            If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 And DPBigKey.Checked = True Then
                DPLabel.BackColor = Color.Green
                DPLabel.ForeColor = Color.White
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPBoss.Enabled = True
            ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                DPLabel.BackColor = Color.Yellow
                DPLabel.ForeColor = Color.Black
                DPBoss.Enabled = False
            Else
                DPLabel.BackColor = Color.Red
                DPLabel.ForeColor = Color.Black
                DPBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub TOHClick(sender As Object, e As EventArgs) Handles HeraMap.CheckedChanged, HeraBigKey.CheckedChanged, HeraBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "HeraMap"
                If HeraMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    TOHButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "HeraBigKey"
                If HeraBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    HeraBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    HeraBigKey.BackColor = Color.Red
                End If
            Case "HeraBoss"
                If HeraBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TOHButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TOHButton.BackColor = Color.Black
                End If
        End Select
        TOHCheck()
        CrystalCheck()
    End Sub
    Private Sub TOHChests_MouseDown(sender As Object, e As EventArgs) Handles TOHChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TOHChests.Text > 0 Then TOHChests.Text = TOHChests.Text - 1
                If TOHChests.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TOHChests.Text < 6 Then TOHChests.Text = TOHChests.Text + 1
                TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TOHPrizes_MouseDown(sender As Object, e As EventArgs) Handles TOHPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TOHPrizes.Text > 0 Then TOHPrizes.Text = TOHPrizes.Text - 1
                If TOHPrizes.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TOHPrizes.Text < 2 Then TOHPrizes.Text = TOHPrizes.Text + 1
                TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub HeraKeys_MouseDown(sender As Object, e As EventArgs) Handles TOHKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then TOHKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then TOHKeys.Text = 0
        TOHCheck()
    End Sub
    Public Sub TOHCheck()
        If RadioButton1.Checked = True Then
            If Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) And (Lamp = True Or FireRod = True) And (Sword > 0 Or Hammer = True) Then
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
                TOHChests.Text = 6
                TOHChests.ForeColor = Color.White
            ElseIf Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) Then
                TOHLabel.BackColor = Color.Yellow
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = True
                TOHChests.Text = 5
                TOHChests.ForeColor = Color.Yellow
            ElseIf Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                TOHLabel.BackColor = Color.Yellow
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
                TOHChests.Text = 4
                TOHChests.ForeColor = Color.Yellow
            Else
                TOHLabel.BackColor = Color.Red
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
                TOHChests.Text = 0
                TOHChests.ForeColor = Color.White
            End If
        Else
            If Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) And HeraBigKey.Checked = True Then
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
            ElseIf (Flute = True Or Glove > 0) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                TOHLabel.BackColor = Color.Yellow
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
            Else
                TOHLabel.BackColor = Color.Red
                TOHLabel.ForeColor = Color.Black
                HeraBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub AGKeys_MouseDown(sender As Object, e As EventArgs) Handles AGKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If AGKeys.Text < 2 Then AGKeys.Text = AGKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If AGKeys.Text > 0 Then AGKeys.Text = AGKeys.Text - 1
        End If
        AgaCheck()
    End Sub

    Public Sub AgaCheck()
        If RadioButton1.Checked = True Then
            If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True Then
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })
                Dim noaganhim As New Bitmap(My.Resources.aganhim)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noaganhim)
                    g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                    0, 0, noaganhim.Width, noaganhim.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                AgaButton.Visible = True
                AgaButton.Image = noaganhim
                AGLabel.BackColor = Color.Green
                AGLabel.ForeColor = Color.White
            Else
                AgaButton.Visible = False
                AGLabel.BackColor = Color.Red
                AGLabel.ForeColor = Color.Black
            End If
        Else
            If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True And AGKeys.Text = 2 Then
                AgaButton.Visible = True
                AgaButton.Image = My.Resources.noaganhim
                AGLabel.BackColor = Color.Green
                AGLabel.ForeColor = Color.White
            ElseIf (Sword >= 2 Or (Cape = True And Sword > 0)) Then
                AgaButton.Visible = False
                AGLabel.BackColor = Color.Yellow
                AGLabel.ForeColor = Color.Black
            Else
                AgaButton.Visible = False
                AGLabel.BackColor = Color.Red
                AGLabel.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODClick(sender As Object, e As EventArgs) Handles PODMap.CheckedChanged, PODBigKey.CheckedChanged, PODBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "PODMap"
                If PODMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    PODButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "PODBigKey"
                    If PODBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    PODBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    PODBigKey.BackColor = Color.Red
                End If
            Case "PODBoss"
                If PODBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    PODButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    PODButton.BackColor = Color.Black
                End If
        End Select
        PODCheck()
        CrystalCheck()
    End Sub
    Private Sub PODChests_MouseDown(sender As Object, e As EventArgs) Handles PODChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If PODChests.Text > 0 Then PODChests.Text = PODChests.Text - 1
                If PODChests.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If PODChests.Text < 14 Then PODChests.Text = PODChests.Text + 1
                PODLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODPrizes_MouseDown(sender As Object, e As EventArgs) Handles PODPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If PODPrizes.Text > 0 Then PODPrizes.Text = PODPrizes.Text - 1
                If PODPrizes.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If PODPrizes.Text < 5 Then PODPrizes.Text = PODPrizes.Text + 1
                PODLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODKeys_MouseDown(sender As Object, e As EventArgs) Handles PODKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If PODKeys.Text < 6 Then PODKeys.Text = PODKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If PODKeys.Text > 0 Then PODKeys.Text = PODKeys.Text - 1
        End If
    End Sub
    Public Sub PODCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 1 And Hammer = True Then
                PODBoss.Enabled = True
                PODChests.Text = 14
                PODChests.ForeColor = Color.White
                If Lamp = True Then
                    PODLabel.BackColor = Color.Green
                    PODLabel.ForeColor = Color.White
                Else
                    PODLabel.BackColor = Color.Orange
                    PODChests.ForeColor = Color.Orange
                End If
            ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And bow > 1 Then
                PODBoss.Enabled = False
                PODChests.Text = 13
                PODChests.ForeColor = Color.Yellow
                PODLabel.BackColor = Color.Yellow
                PODLabel.ForeColor = Color.Black
            ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                PODBoss.Enabled = False
                PODChests.Text = 11
                PODChests.ForeColor = Color.Yellow
                PODLabel.BackColor = Color.Yellow
                PODLabel.ForeColor = Color.Black
            Else
                PODChests.Text = 0
                PODChests.ForeColor = Color.White
                PODLabel.BackColor = Color.Red
                PODLabel.ForeColor = Color.Black
                PODBoss.Enabled = False
            End If
        Else
            If Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 1 And Hammer = True And PODBigKey.Checked = True Then
                If Lamp = True Then PODLabel.BackColor = Color.Green Else PODLabel.BackColor = Color.Orange
                PODLabel.ForeColor = Color.White
                PODBoss.Enabled = True
            ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                PODLabel.BackColor = Color.Yellow
                PODLabel.ForeColor = Color.Black
                PODBoss.Enabled = False
            Else
                PODLabel.BackColor = Color.Red
                PODLabel.ForeColor = Color.Black
                PODBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub SPClick(sender As Object, e As EventArgs) Handles SPMap.CheckedChanged, SPBigKey.CheckedChanged, SPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SPMap"
                If SPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    SPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "SPBigKey"
                If SPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkey Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
            Case "SPBoss"
                If SPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    SPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SPButton.BackColor = Color.Black
                End If
        End Select
        SPCheck()
        CrystalCheck()
    End Sub
    Private Sub SPChests_MouseDown(sender As Object, e As EventArgs) Handles SPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SPChests.Text > 0 Then SPChests.Text = SPChests.Text - 1
                If SPChests.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SPChests.Text < 10 Then SPChests.Text = SPChests.Text + 1
                SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPPrizes_MouseDown(sender As Object, e As EventArgs) Handles SPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SPPrizes.Text > 0 Then SPPrizes.Text = SPPrizes.Text - 1
                If SPPrizes.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SPPrizes.Text < 6 Then SPPrizes.Text = SPPrizes.Text + 1
                SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPKeys_MouseDown(sender As Object, e As EventArgs) Handles SPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then SPKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then SPKeys.Text = 0
        SPCheck()
    End Sub
    Public Sub SPCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) Then
                SPLabel.BackColor = Color.Green
                SPLabel.ForeColor = Color.White
                SPChests.Text = 10
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = True
            ElseIf Pearl = True And Flippers = True And Mirror = True And Hammer = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                SPLabel.BackColor = Color.Yellow
                SPLabel.ForeColor = Color.Black
                SPChests.Text = 6
                SPChests.ForeColor = Color.Yellow
                SPBoss.Enabled = False
            ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                SPLabel.BackColor = Color.Yellow
                SPLabel.ForeColor = Color.Black
                SPChests.Text = 2
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = False
            Else
                SPLabel.BackColor = Color.Red
                SPLabel.ForeColor = Color.Black
                SPChests.Text = 0
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = False
            End If
        Else
            If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SPKeys.Text = 1 Then
                SPLabel.BackColor = Color.Green
                SPLabel.ForeColor = Color.White
                SPBoss.Enabled = True
            ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                SPLabel.BackColor = Color.Yellow
                SPLabel.ForeColor = Color.Black
                SPBoss.Enabled = False
            Else
                SPLabel.BackColor = Color.Red
                SPLabel.ForeColor = Color.Black
                SPBoss.Enabled = False
            End If
        End If

    End Sub

    Private Sub SWClick(sender As Object, e As EventArgs) Handles SWMap.CheckedChanged, SWBigKey.CheckedChanged, SWBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SWMap"
                If SWMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    SWButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "SWBigKey"
                If SWBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkey Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
            Case "SWBoss"
                If SWBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    SWButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    SWButton.BackColor = Color.Black
                End If
        End Select
        SWCheck()
        CrystalCheck()
    End Sub
    Private Sub SWChests_MouseDown(sender As Object, e As EventArgs) Handles SWChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SWChests.Text > 0 Then SWChests.Text = SWChests.Text - 1
                If SWChests.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SWChests.Text < 8 Then SWChests.Text = SWChests.Text + 1
                SWLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SWPrizes_MouseDown(sender As Object, e As EventArgs) Handles SWPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If SWPrizes.Text > 0 Then SWPrizes.Text = SWPrizes.Text - 1
                If SWPrizes.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SWPrizes.Text < 2 Then SWPrizes.Text = SWPrizes.Text + 1
                SWLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub SWKeys_MouseDown(sender As Object, e As EventArgs) Handles SWKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If SWKeys.Text < 3 Then SWKeys.Text = SWKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If SWKeys.Text > 0 Then SWKeys.Text = SWKeys.Text - 1
        End If
    End Sub


    Public Sub SWCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                SWLabel.BackColor = Color.Green
                SWLabel.ForeColor = Color.White
                SWChests.Text = 8
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = True
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                SWLabel.BackColor = Color.Yellow
                SWLabel.ForeColor = Color.Black
                SWChests.Text = 7
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = False
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                SWLabel.BackColor = Color.Yellow
                SWLabel.ForeColor = Color.Black
                SWChests.Text = 6
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = False
            Else
                SWLabel.BackColor = Color.Red
                SWLabel.ForeColor = Color.Black
                SWChests.Text = 0
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = False
            End If
        Else
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                SWLabel.BackColor = Color.Green
                SWLabel.ForeColor = Color.White
                SWBoss.Enabled = True
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                SWLabel.BackColor = Color.Yellow
                SWLabel.ForeColor = Color.Black
                SWBoss.Enabled = False
            Else
                SWLabel.BackColor = Color.Red
                SWLabel.ForeColor = Color.Black
                SWBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub MireBEQ_Click(sender As Object, e As MouseEventArgs) Handles MireBEQ.MouseDown

    End Sub

    Private Sub TTClick(sender As Object, e As EventArgs) Handles TTMap.CheckedChanged, TTBigKey.CheckedChanged, TTBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TTMap"
                If TTMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    TTButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "TTBigKey"
                If TTBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    TTBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    TTBigKey.BackColor = Color.Red
                End If
            Case "TTBoss"
                If TTBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TTButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TTButton.BackColor = Color.Black
                End If
        End Select
        TTCheck()
        CrystalCheck()
    End Sub

    Private Sub TTPrizes_MouseDown(sender As Object, e As EventArgs) Handles TTPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TTPrizes.Text > 0 Then TTPrizes.Text = TTPrizes.Text - 1
                If TTPrizes.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TTPrizes.Text < 4 Then TTPrizes.Text = TTPrizes.Text + 1
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TTChests_MouseDown(sender As Object, e As EventArgs) Handles TTChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TTChests.Text > 0 Then TTChests.Text = TTChests.Text - 1
                If TTChests.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TTChests.Text < 8 Then TTChests.Text = TTChests.Text + 1
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub TTKeys_MouseDown(sender As Object, e As EventArgs) Handles TTKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then TTKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then TTKeys.Text = 0
    End Sub

    Public Sub TTCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                TTLabel.BackColor = Color.Green
                TTLabel.ForeColor = Color.White
                If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = True
            Else
                TTLabel.BackColor = Color.Red
                TTLabel.ForeColor = Color.Black
                TTChests.Text = 0
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = False
            End If
        Else
            If Pearl = True And TTBigKey.Checked = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                TTLabel.BackColor = Color.Green
                TTLabel.ForeColor = Color.White
                TTBoss.Enabled = True
            ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                TTLabel.BackColor = Color.Yellow
                TTLabel.ForeColor = Color.Black
                TTBoss.Enabled = False
            Else
                TTLabel.BackColor = Color.Red
                TTLabel.ForeColor = Color.Black
                TTBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub IPClick(sender As Object, e As EventArgs) Handles IPMap.CheckedChanged, IPBigKey.CheckedChanged, IPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "IPMap"
                If IPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    IPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "IPBigKey"
                If IPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkey Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
            Case "IPBoss"
                If IPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    IPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    IPButton.BackColor = Color.Black
                End If
        End Select
        IPCheck()
        CrystalCheck()
    End Sub
    Private Sub IPPrizes_MouseDown(sender As Object, e As EventArgs) Handles IPPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If IPPrizes.Text > 0 Then IPPrizes.Text = IPPrizes.Text - 1
                If IPPrizes.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If IPPrizes.Text < 3 Then IPPrizes.Text = IPPrizes.Text + 1
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPChests_MouseDown(sender As Object, e As EventArgs) Handles IPChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If IPChests.Text > 0 Then IPChests.Text = IPChests.Text - 1
                If IPChests.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If IPChests.Text < 8 Then IPChests.Text = IPChests.Text + 1
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPKeys_MouseDown(sender As Object, e As EventArgs) Handles IPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If IPKeys.Text < 3 Then IPKeys.Text = IPKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If IPKeys.Text < 3 Then IPKeys.Text = IPKeys.Text - 1
        End If
    End Sub

    Public Sub IPCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) And Hammer = True And Hookshot = True Then
                IPLabel.ForeColor = Color.White
                IPChests.Text = 8
                IPBoss.Enabled = True
                If Flippers = True Then
                    IPLabel.BackColor = Color.Green
                    IPChests.ForeColor = Color.White
                Else
                    IPLabel.BackColor = Color.Orange
                    IPChests.ForeColor = Color.Orange
                End If
            ElseIf Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) Then
                IPLabel.BackColor = Color.Yellow
                IPLabel.ForeColor = Color.Black
                IPChests.Text = 7
                If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                IPBoss.Enabled = False
            Else
                IPLabel.BackColor = Color.Red
                IPLabel.ForeColor = Color.Black
                IPChests.Text = 0
                IPChests.ForeColor = Color.White
                IPBoss.Enabled = False
            End If
        Else
            If Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) And Hammer = True Then
                If Flippers = True And Hookshot = True And (Somaria = True Or IPBigKey.Checked = True) Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Orange
                IPLabel.ForeColor = Color.White
                IPBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Flippers = True And (FireRod = True Or Bombos = True) Then
                IPLabel.BackColor = Color.Yellow
                IPLabel.ForeColor = Color.Black
                IPBoss.Enabled = False
            Else
                IPLabel.BackColor = Color.Red
                IPLabel.ForeColor = Color.Black
                IPBoss.Enabled = False
            End If
        End If
    End Sub
    Private Sub MMClick(sender As Object, e As EventArgs) Handles MMMap.CheckedChanged, MMBigKey.CheckedChanged, MMBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "MMMap"
                If MMMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    MMButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "MMBigKey"
                If MMBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    MMBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    MMBigKey.BackColor = Color.Red
                End If
            Case "MMBoss"
                If MMBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    MMButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    MMButton.BackColor = Color.Black
                End If
        End Select
        MMCheck()
        CrystalCheck()
    End Sub
    Private Sub MMPrizes_MouseDown(sender As Object, e As EventArgs) Handles MMPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If MMPrizes.Text > 0 Then MMPrizes.Text = MMPrizes.Text - 1
                If MMPrizes.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If MMPrizes.Text < 2 Then MMPrizes.Text = MMPrizes.Text + 1
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMChests_MouseDown(sender As Object, e As EventArgs) Handles MMChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If MMChests.Text > 0 Then MMChests.Text = MMChests.Text - 1
                If MMChests.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If MMChests.Text < 8 Then MMChests.Text = MMChests.Text + 1
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMKeys_MouseDown(sender As Object, e As EventArgs) Handles MMKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If MMKeys.Text < 3 Then MMKeys.Text = MMKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If MMKeys.Text > 0 Then MMKeys.Text = MMKeys.Text - 1
        End If
    End Sub
    Public Sub MMCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True Then
                MMBoss.Enabled = True
                MMChests.Text = 8
                MMLabel.ForeColor = Color.White
                If Lamp = True Then
                    MMLabel.BackColor = Color.Green
                    MMChests.ForeColor = Color.White
                Else
                    MMLabel.BackColor = Color.Orange
                    MMChests.ForeColor = Color.Orange
                End If
            ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                MMLabel.BackColor = Color.Yellow
                MMLabel.ForeColor = Color.Black
                MMChests.Text = 7
                MMChests.ForeColor = Color.White
                MMBoss.Enabled = False
            Else
                MMLabel.BackColor = Color.Red
                MMLabel.ForeColor = Color.Black
                MMChests.Text = 0
                MMChests.ForeColor = Color.White
                MMBoss.Enabled = False
            End If
        Else
            If Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True And MMBigKey.Checked = True Then
                If Lamp = True Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                MMLabel.ForeColor = Color.White
                MMBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                MMLabel.BackColor = Color.Yellow
                MMLabel.ForeColor = Color.Black
                MMBoss.Enabled = False
            Else
                MMLabel.BackColor = Color.Red
                MMLabel.ForeColor = Color.Black
                MMBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub MireBEQ_Click(sender As Object, e As EventArgs) Handles MireBEQ.MouseDown
        MireMedallion = (MireMedallion + 1) Mod 4
        Select Case MireMedallion
            Case 0
                MireBEQ.Image = My.Resources.whatmedallion
            Case 1
                MireBEQ.Image = My.Resources.bombos
            Case 2
                MireBEQ.Image = My.Resources.ether
            Case 3
                MireBEQ.Image = My.Resources.quake
        End Select
        MMCheck()
    End Sub
    Private Sub TRClick(sender As Object, e As EventArgs) Handles TRMap.CheckedChanged, TRBigKey.CheckedChanged, TRBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TRMap"
                If TRMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.map
                    TRButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomap
                End If
            Case "TRBigKey"
                If TRBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    TRBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    TRBigKey.BackColor = Color.Red
                End If
            Case "TRBoss"
                If TRBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdead
                    TRButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.boss
                    TRButton.BackColor = Color.Black
                End If
        End Select
        TRCheck()
        CrystalCheck()
    End Sub
    Private Sub TRPrizes_MouseDown(sender As Object, e As EventArgs) Handles TRPrizes.MouseDown
        If RadioButton1.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TRPrizes.Text > 0 Then TRPrizes.Text = TRPrizes.Text - 1
                If TRPrizes.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TRPrizes.Text < 5 Then TRPrizes.Text = TRPrizes.Text + 1
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRChests_MouseDown(sender As Object, e As EventArgs) Handles TRChests.MouseDown
        If RadioButton2.Checked = True Then
            If MouseButtons = MouseButtons.Left Then
                If TRChests.Text > 0 Then TRChests.Text = TRChests.Text - 1
                If TRChests.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TRChests.Text < 12 Then TRChests.Text = TRChests.Text + 1
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRKeys_MouseDown(sender As Object, e As EventArgs) Handles TRKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If TRKeys.Text < 4 Then TRKeys.Text = TRKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If TRKeys.Text > 0 Then TRKeys.Text = TRKeys.Text - 1
        End If
    End Sub
    Public Sub TRCheck()
        If RadioButton1.Checked = True Then
            If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                TRAccess = True
                TRChests.Text = 12
                If Lamp = True And Sword > 1 Then
                    TRLabel.BackColor = Color.Green
                    TRChests.ForeColor = Color.White
                Else
                    TRLabel.BackColor = Color.Orange
                    TRChests.ForeColor = Color.Orange
                End If
                TRLabel.ForeColor = Color.White
                TRBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And FireRod = True Then
                TRAccess = True
                TRChests.Text = 11
                If Lamp = True Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                TRLabel.BackColor = Color.Yellow
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                TRAccess = True
                TRChests.Text = 9
                TRChests.ForeColor = Color.Yellow
                TRLabel.BackColor = Color.Yellow
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            Else
                TRAccess = False
                TRLabel.BackColor = Color.Red
                TRLabel.ForeColor = Color.Black
                TRChests.Text = 0
                TRChests.ForeColor = Color.White
                TRBoss.Enabled = False
            End If
        Else
            If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TRBigKey.Checked = True Then
                TRAccess = True
                If Lamp = True And Sword > 1 Then TRLabel.BackColor = Color.Green Else TRLabel.BackColor = Color.Orange
                TRLabel.ForeColor = Color.White
                TRBoss.Enabled = True
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                TRAccess = True
                TRLabel.BackColor = Color.Yellow
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            Else
                TRAccess = False
                TRLabel.BackColor = Color.Red
                TRLabel.ForeColor = Color.Black
                TRBoss.Enabled = False
            End If
        End If
    End Sub

    Private Sub TurtleBEQ_Click(sender As Object, e As EventArgs) Handles TurtleBEQ.MouseDown
        TurtleMedallion = (TurtleMedallion + 1) Mod 4
        Select Case TurtleMedallion
            Case 0
                TurtleBEQ.Image = My.Resources.whatmedallion
            Case 1
                TurtleBEQ.Image = My.Resources.bombos
            Case 2
                TurtleBEQ.Image = My.Resources.ether
            Case 3
                TurtleBEQ.Image = My.Resources.quake
        End Select
        TRCheck()
    End Sub

    Private Sub GTClick(sender As Object, e As EventArgs) Handles GTMap.CheckedChanged, GTBigKey.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "GTMap"
                If GTMap.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.map Else DirectCast(sender, CheckBox).Image = My.Resources.nomap
            Case "GTBigKey"
                If GTBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkey
                    GTBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkey
                    GTBigKey.BackColor = Color.Red
                End If
        End Select
        GTCheck()
        CrystalCheck()
    End Sub

    Private Sub GTChests_MouseDown(sender As Object, e As EventArgs) Handles GTChests.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If GTChests.Text > 0 Then GTChests.Text = GTChests.Text - 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If GTChests.Text < 27 Then GTChests.Text = GTChests.Text + 1
        End If
    End Sub

    Private Sub GTKeys_MouseDown(sender As Object, e As EventArgs) Handles GTKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then
            If GTKeys.Text < 4 Then GTKeys.Text = GTKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If GTKeys.Text > 0 Then GTKeys.Text = GTKeys.Text - 1
        End If
    End Sub

    Public Sub GTCheck()
        If RadioButton2.Checked = True Then
            If CrystalCount = 7 And GTBigKey.Checked = True Then
                GTLabel.BackColor = Color.Green
                GTLabel.ForeColor = Color.White
            ElseIf CrystalCount = 7 Then
                GTLabel.BackColor = Color.Yellow
                GTLabel.ForeColor = Color.Black
            Else
                GTLabel.BackColor = Color.Red
                GTLabel.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub CrystalClick(sender As Object, e As EventArgs) Handles EPButton.MouseDown, DPButton.MouseDown, TOHButton.MouseDown, PODButton.MouseDown, SPButton.MouseDown, SWButton.MouseDown, TTButton.MouseDown, IPButton.MouseDown, MMButton.MouseDown, TRButton.MouseDown
        Select Case DirectCast(sender, PictureBox).Name
            Case "EPButton"
                EPReward = (EPReward + 1) Mod 4
                Select Case EPReward
                    Case 0
                        EPButton.Image = My.Resources.crystal
                    Case 1
                        EPButton.Image = My.Resources.fairycrystal
                    Case 2
                        EPButton.Image = My.Resources.otherpendant
                    Case 3
                        EPButton.Image = My.Resources.greenpendant
                End Select
            Case "DPButton"
                DPReward = (DPReward + 1) Mod 4
                Select Case DPReward
                    Case 0
                        DPButton.Image = My.Resources.crystal
                    Case 1
                        DPButton.Image = My.Resources.fairycrystal
                    Case 2
                        DPButton.Image = My.Resources.otherpendant
                    Case 3
                        DPButton.Image = My.Resources.greenpendant
                End Select
            Case "TOHButton"
                TOHReward = (TOHReward + 1) Mod 4
                Select Case TOHReward
                    Case 0
                        TOHButton.Image = My.Resources.crystal
                    Case 1
                        TOHButton.Image = My.Resources.fairycrystal
                    Case 2
                        TOHButton.Image = My.Resources.otherpendant
                    Case 3
                        TOHButton.Image = My.Resources.greenpendant
                End Select
            Case "PODButton"
                PODReward = (PODReward + 1) Mod 4
                Select Case PODReward
                    Case 0
                        PODButton.Image = My.Resources.crystal
                    Case 1
                        PODButton.Image = My.Resources.fairycrystal
                    Case 2
                        PODButton.Image = My.Resources.otherpendant
                    Case 3
                        PODButton.Image = My.Resources.greenpendant
                End Select
            Case "SPButton"
                SPReward = (SPReward + 1) Mod 4
                Select Case SPReward
                    Case 0
                        SPButton.Image = My.Resources.crystal
                    Case 1
                        SPButton.Image = My.Resources.fairycrystal
                    Case 2
                        SPButton.Image = My.Resources.otherpendant
                    Case 3
                        SPButton.Image = My.Resources.greenpendant
                End Select
            Case "SWButton"
                SWReward = (SWReward + 1) Mod 4
                Select Case SWReward
                    Case 0
                        SWButton.Image = My.Resources.crystal
                    Case 1
                        SWButton.Image = My.Resources.fairycrystal
                    Case 2
                        SWButton.Image = My.Resources.otherpendant
                    Case 3
                        SWButton.Image = My.Resources.greenpendant
                End Select
            Case "TTButton"
                TTReward = (TTReward + 1) Mod 4
                Select Case TTReward
                    Case 0
                        TTButton.Image = My.Resources.crystal
                    Case 1
                        TTButton.Image = My.Resources.fairycrystal
                    Case 2
                        TTButton.Image = My.Resources.otherpendant
                    Case 3
                        TTButton.Image = My.Resources.greenpendant
                End Select
            Case "IPButton"
                IPReward = (IPReward + 1) Mod 4
                Select Case IPReward
                    Case 0
                        IPButton.Image = My.Resources.crystal
                    Case 1
                        IPButton.Image = My.Resources.fairycrystal
                    Case 2
                        IPButton.Image = My.Resources.otherpendant
                    Case 3
                        IPButton.Image = My.Resources.greenpendant
                End Select
            Case "MMButton"
                MMReward = (MMReward + 1) Mod 4
                Select Case MMReward
                    Case 0
                        MMButton.Image = My.Resources.crystal
                    Case 1
                        MMButton.Image = My.Resources.fairycrystal
                    Case 2
                        MMButton.Image = My.Resources.otherpendant
                    Case 3
                        MMButton.Image = My.Resources.greenpendant
                End Select
            Case "TRButton"
                TRReward = (TRReward + 1) Mod 4
                Select Case TRReward
                    Case 0
                        TRButton.Image = My.Resources.crystal
                    Case 1
                        TRButton.Image = My.Resources.fairycrystal
                    Case 2
                        TRButton.Image = My.Resources.otherpendant
                    Case 3
                        TRButton.Image = My.Resources.greenpendant
                End Select
        End Select
        LWCheck()
            DWCheck()
        CrystalCheck()
    End Sub
    Public Sub CrystalCheck()
        CrystalCount = 0
        FairyCrystal = 0
        PendantCount = 0
        GreenPendant = False
        If EPBoss.Checked = True Then
            Select Case EPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If DPBoss.Checked = True Then
            Select Case DPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If HeraBoss.Checked = True Then
            Select Case TOHReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If PODBoss.Checked = True Then
            Select Case PODReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If SPBoss.Checked = True Then
            Select Case SPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If SWBoss.Checked = True Then
            Select Case SWReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If TTBoss.Checked = True Then
            Select Case TTReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If IPBoss.Checked = True Then
            Select Case IPReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If MMBoss.Checked = True Then
            Select Case MMReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        If TRBoss.Checked = True Then
            Select Case TRReward
                Case 0
                    CrystalCount = CrystalCount + 1
                Case 1
                    CrystalCount = CrystalCount + 1
                    FairyCrystal = FairyCrystal + 1
                Case 2
                    PendantCount = PendantCount + 1
                Case 3
                    PendantCount = PendantCount + 1
                    GreenPendant = True
            End Select
        End If
        LWCheck()
        DWCheck()
        GTCheck()
    End Sub

    Private Sub BowButton_Click(sender As Object, e As EventArgs) Handles BowButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Bow = (Bow + 1) Mod 4 Else Bow = (Bow + 3) Mod 4
        Select Case Bow
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim nobow As New Bitmap(My.Resources.nobow)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(nobow)
                    g.DrawImage(nobow, New Rectangle(0, 0, nobow.Width, nobow.Height),
                    0, 0, nobow.Width, nobow.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                BowButton.Image = nobow
                BowButton.BackColor = Color.Black
            Case 1
                BowButton.Image = My.Resources.Agsonly
                BowButton.BackColor = Color.WhiteSmoke
            Case 2
                BowButton.Image = My.Resources.bow
                BowButton.BackColor = Color.WhiteSmoke
            Case 3
                BowButton.Image = My.Resources.silvers
                BowButton.BackColor = Color.WhiteSmoke
        End Select
        EPCheck()
        PODCheck()
    End Sub

    Private Sub BoomButton_Click(sender As Object, e As EventArgs) Handles BoomButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Boomerang = (Boomerang + 1) Mod 4 Else Boomerang = (Boomerang + 4) Mod 4
        Select Case Boomerang
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim noboomerang As New Bitmap(My.Resources.blueboom)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noboomerang)
                    g.DrawImage(noboomerang, New Rectangle(0, 0, noboomerang.Width, noboomerang.Height),
                    0, 0, noboomerang.Width, noboomerang.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                BoomButton.Image = noboomerang
                BoomButton.BackColor = Color.Black
            Case 1
                BoomButton.Image = My.Resources.blueboom
                BoomButton.BackColor = Color.WhiteSmoke
            Case 2
                BoomButton.Image = My.Resources.redboom
                BoomButton.BackColor = Color.WhiteSmoke
            Case 3
                BoomButton.Image = My.Resources.bothboom
                BoomButton.BackColor = Color.WhiteSmoke
        End Select
    End Sub

    Private Sub HookButton_Click(sender As Object, e As EventArgs) Handles HookButton.MouseDown
        If Hookshot = False Then Hookshot = True Else Hookshot = False
        If Hookshot = True Then
            HookButton.Image = My.Resources.hookshot
            HookButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nohook As New Bitmap(My.Resources.hookshot)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nohook)
                g.DrawImage(nohook, New Rectangle(0, 0, nohook.Width, nohook.Height),
                    0, 0, nohook.Width, nohook.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            HookButton.Image = nohook
            HookButton.BackColor = Color.Black
        End If
        TOHCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub BombButton_Click(sender As Object, e As EventArgs) Handles BombButton.MouseDown
        If Bombs = False Then Bombs = True Else Bombs = False
        If Bombs = True Then
            BombButton.Image = My.Resources.bombs
            BombButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobombs As New Bitmap(My.Resources.bombs)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobombs)
                g.DrawImage(nobombs, New Rectangle(0, 0, nobombs.Width, nobombs.Height),
                    0, 0, nobombs.Width, nobombs.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BombButton.Image = nobombs
            BombButton.BackColor = Color.Black
        End If
        HCCheck()
        SPCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub PowderButton_Click(sender As Object, e As EventArgs) Handles PowderButton.MouseDown
        If Powder = False Then Powder = True Else Powder = False
        If Powder = True Then
            PowderButton.Image = My.Resources.powder
            PowderButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nopowder As New Bitmap(My.Resources.powder)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nopowder)
                g.DrawImage(nopowder, New Rectangle(0, 0, nopowder.Width, nopowder.Height),
                    0, 0, nopowder.Width, nopowder.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            PowderButton.Image = nopowder
            PowderButton.BackColor = Color.Black
        End If
        LWCheck()
    End Sub

    Private Sub FireButton_Click(sender As Object, e As EventArgs) Handles FireButton.MouseDown
        If FireRod = False Then FireRod = True Else FireRod = False
        If FireRod = True Then
            FireButton.Image = My.Resources.firerod
            FireButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nofirerod As New Bitmap(My.Resources.firerod)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nofirerod)
                g.DrawImage(nofirerod, New Rectangle(0, 0, nofirerod.Width, nofirerod.Height),
                    0, 0, nofirerod.Width, nofirerod.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            FireButton.Image = nofirerod
            FireButton.BackColor = Color.Black
        End If
        DPCheck()
        TOHCheck()
        SWCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub IceButton_Click(sender As Object, e As EventArgs) Handles IceButton.MouseDown
        If IceRod = False Then IceRod = True Else IceRod = False
        If IceRod = True Then
            IceButton.Image = My.Resources.icerod
            IceButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noicerod As New Bitmap(My.Resources.icerod)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noicerod)
                g.DrawImage(noicerod, New Rectangle(0, 0, noicerod.Width, noicerod.Height),
                    0, 0, noicerod.Width, noicerod.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            IceButton.Image = noicerod
            IceButton.BackColor = Color.Black
        End If
        TRCheck()
    End Sub

    Private Sub BombosButton_Click(sender As Object, e As EventArgs) Handles BombosButton.MouseDown
        If Bombos = False Then Bombos = True Else Bombos = False
        If Bombos = True Then
            BombosButton.Image = My.Resources.bombos
            BombosButton.BackColor = Color.WhiteSmoke
            MedallionCount = MedallionCount + 1
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobombos As New Bitmap(My.Resources.bombos)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobombos)
                g.DrawImage(nobombos, New Rectangle(0, 0, nobombos.Width, nobombos.Height),
                    0, 0, nobombos.Width, nobombos.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BombosButton.Image = nobombos
            BombosButton.BackColor = Color.Black
            MedallionCount = MedallionCount - 1
        End If
        IPCheck()
        MMCheck()
        TRCheck()
    End Sub

    Private Sub EtherButton_Click(sender As Object, e As EventArgs) Handles EtherButton.MouseDown
        If Ether = False Then Ether = True Else Ether = False
        If Ether = True Then
            EtherButton.Image = My.Resources.ether
            EtherButton.BackColor = Color.WhiteSmoke
            MedallionCount = MedallionCount + 1
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noether As New Bitmap(My.Resources.ether)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noether)
                g.DrawImage(noether, New Rectangle(0, 0, noether.Width, noether.Height),
                    0, 0, noether.Width, noether.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            EtherButton.Image = noether
            EtherButton.BackColor = Color.Black
            MedallionCount = MedallionCount - 1
        End If
        MMCheck()
        TRCheck()
    End Sub

    Private Sub QuakeButton_Click(sender As Object, e As EventArgs) Handles QuakeButton.MouseDown
        If Quake = False Then Quake = True Else Quake = False
        If Quake = True Then
            QuakeButton.Image = My.Resources.quake
            QuakeButton.BackColor = Color.WhiteSmoke
            MedallionCount = MedallionCount + 1
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noquake As New Bitmap(My.Resources.quake)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noquake)
                g.DrawImage(noquake, New Rectangle(0, 0, noquake.Width, noquake.Height),
                    0, 0, noquake.Width, noquake.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            QuakeButton.Image = noquake
            QuakeButton.BackColor = Color.Black
            MedallionCount = MedallionCount - 1
        End If
        MMCheck()
        TRCheck()
    End Sub

    Private Sub LampButton_Click(sender As Object, e As EventArgs) Handles LampButton.MouseDown
        If Lamp = False Then Lamp = True Else Lamp = False
        If Lamp = True Then
            LampButton.Image = My.Resources.lamp
            LampButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nolamp As New Bitmap(My.Resources.lamp)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nolamp)
                g.DrawImage(nolamp, New Rectangle(0, 0, nolamp.Width, nolamp.Height),
                    0, 0, nolamp.Width, nolamp.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            LampButton.Image = nolamp
            LampButton.BackColor = Color.Black
        End If
        HCCheck()
        EPCheck()
        DPCheck()
        TOHCheck()
        AgaCheck()
        PODCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub HammerButton_Click(sender As Object, e As EventArgs) Handles HammerButton.MouseDown
        If Hammer = False Then Hammer = True Else Hammer = False
        If Hammer = True Then
            HammerButton.Image = My.Resources.hammer
            HammerButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nohammer As New Bitmap(My.Resources.hammer)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nohammer)
                g.DrawImage(nohammer, New Rectangle(0, 0, nohammer.Width, nohammer.Height),
                    0, 0, nohammer.Width, nohammer.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            HammerButton.Image = nohammer
            HammerButton.BackColor = Color.Black
        End If
        TOHCheck()
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub FluteButton_Click(sender As Object, e As EventArgs) Handles FluteButton.MouseDown
        If Flute = False Then Flute = True Else Flute = False
        If Flute = True Then
            FluteButton.Image = My.Resources.flute
            FluteButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noflute As New Bitmap(My.Resources.flute)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noflute)
                g.DrawImage(noflute, New Rectangle(0, 0, noflute.Width, noflute.Height),
                    0, 0, noflute.Width, noflute.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            FluteButton.Image = noflute
            FluteButton.BackColor = Color.Black
        End If
        DPCheck()
        TOHCheck()
        MMCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub NetButton_Click(sender As Object, e As EventArgs) Handles NetButton.MouseDown
        If Net = False Then Net = True Else Net = False
        If Net = True Then
            NetButton.Image = My.Resources.bugnet
            NetButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobugnet As New Bitmap(My.Resources.bugnet)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobugnet)
                g.DrawImage(nobugnet, New Rectangle(0, 0, nobugnet.Width, nobugnet.Height),
                    0, 0, nobugnet.Width, nobugnet.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            NetButton.Image = nobugnet
            NetButton.BackColor = Color.Black
        End If
        AgaCheck()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.MouseDown
        If Book = False Then Book = True Else Book = False
        If Book = True Then
            BookButton.Image = My.Resources.book
            BookButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobook As New Bitmap(My.Resources.book)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobook)
                g.DrawImage(nobook, New Rectangle(0, 0, nobook.Width, nobook.Height),
                    0, 0, nobook.Width, nobook.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BookButton.Image = nobook
            BookButton.BackColor = Color.Black
        End If
        DPCheck()
        LWCheck()
    End Sub

    Private Sub BottleButton_Click(sender As Object, e As EventArgs) Handles BottleButton.MouseDown
        If Bottle = False Then Bottle = True Else Bottle = False
        If Bottle = True Then
            BottleButton.Image = My.Resources.bottle
            BottleButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobottle As New Bitmap(My.Resources.bottle)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobottle)
                g.DrawImage(nobottle, New Rectangle(0, 0, nobottle.Width, nobottle.Height),
                    0, 0, nobottle.Width, nobottle.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BottleButton.Image = nobottle
            BottleButton.BackColor = Color.Black
        End If
        LWCheck()
    End Sub

    Private Sub SomariaButton_Click(sender As Object, e As EventArgs) Handles SomariaButton.MouseDown
        If Somaria = False Then Somaria = True Else Somaria = False
        If Somaria = True Then
            SomariaButton.Image = My.Resources.somaria
            SomariaButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nosomaria As New Bitmap(My.Resources.somaria)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nosomaria)
                g.DrawImage(nosomaria, New Rectangle(0, 0, nosomaria.Width, nosomaria.Height),
                    0, 0, nosomaria.Width, nosomaria.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            SomariaButton.Image = nosomaria
            SomariaButton.BackColor = Color.Black
        End If
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub ByrnaButton_Click(sender As Object, e As EventArgs) Handles ByrnaButton.MouseDown
        If Byrna = False Then Byrna = True Else Byrna = False
        If Byrna = True Then
            ByrnaButton.Image = My.Resources.byrna
            ByrnaButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nobyrna As New Bitmap(My.Resources.byrna)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nobyrna)
                g.DrawImage(nobyrna, New Rectangle(0, 0, nobyrna.Width, nobyrna.Height),
                    0, 0, nobyrna.Width, nobyrna.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            ByrnaButton.Image = nobyrna
            ByrnaButton.BackColor = Color.Black
        End If
        MMCheck()
        TRCheck()
        DWCheck()
    End Sub

    Private Sub CapeButton_Click(sender As Object, e As EventArgs) Handles CapeButton.MouseDown
        If Cape = False Then Cape = True Else Cape = False
        If Cape = True Then
            CapeButton.Image = My.Resources.cape
            CapeButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nocape As New Bitmap(My.Resources.cape)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nocape)
                g.DrawImage(nocape, New Rectangle(0, 0, nocape.Width, nocape.Height),
                    0, 0, nocape.Width, nocape.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            CapeButton.Image = nocape
            CapeButton.BackColor = Color.Black
        End If
        AgaCheck()
        MMCheck()
        TRCheck()
        DWCheck()
    End Sub

    Private Sub MirrorButton_Click(sender As Object, e As EventArgs) Handles MirrorButton.MouseDown
        If Mirror = False Then Mirror = True Else Mirror = False
        If Mirror = True Then
            MirrorButton.Image = My.Resources.mirror
            MirrorButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nomirror As New Bitmap(My.Resources.mirror)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nomirror)
                g.DrawImage(nomirror, New Rectangle(0, 0, nomirror.Width, nomirror.Height),
                    0, 0, nomirror.Width, nomirror.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            MirrorButton.Image = nomirror
            MirrorButton.BackColor = Color.Black
        End If
        DPCheck()
        TOHCheck()
        SPCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub BootButton_Click(sender As Object, e As EventArgs) Handles BootButton.MouseDown
        If Boots = False Then Boots = True Else Boots = False
        If Boots = True Then
            BootButton.Image = My.Resources.boots
            BootButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noboots As New Bitmap(My.Resources.boots)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noboots)
                g.DrawImage(noboots, New Rectangle(0, 0, noboots.Width, noboots.Height),
                    0, 0, noboots.Width, noboots.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            BootButton.Image = noboots
            BootButton.BackColor = Color.Black
        End If
        HCCheck()
        DPCheck()
        MMCheck()
        LWCheck()
    End Sub

    Private Sub GloveButton_Click(sender As Object, e As EventArgs) Handles GloveButton.MouseDown
        Glove = (Glove + 1) Mod 3
        Select Case Glove
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim noglove As New Bitmap(My.Resources.glove)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noglove)
                    g.DrawImage(noglove, New Rectangle(0, 0, noglove.Width, noglove.Height),
                    0, 0, noglove.Width, noglove.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                GloveButton.Image = noglove
                GloveButton.BackColor = Color.Black
            Case 1
                GloveButton.Image = My.Resources.glove
                GloveButton.BackColor = Color.WhiteSmoke
            Case 2
                GloveButton.Image = My.Resources.mitt
                GloveButton.BackColor = Color.WhiteSmoke
        End Select
        HCCheck()
        DPCheck()
        TOHCheck()
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub FlipperButton_Click(sender As Object, e As EventArgs) Handles FlipperButton.MouseDown
        If Flippers = False Then Flippers = True Else Flippers = False
        If Flippers = True Then
            FlipperButton.Image = My.Resources.flippers
            FlipperButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noflippers As New Bitmap(My.Resources.flippers)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noflippers)
                g.DrawImage(noflippers, New Rectangle(0, 0, noflippers.Width, noflippers.Height),
                    0, 0, noflippers.Width, noflippers.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            FlipperButton.Image = noflippers
            FlipperButton.BackColor = Color.Black
        End If
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub PearlButton_Click(sender As Object, e As EventArgs) Handles PearlButton.MouseDown
        If Pearl = False Then Pearl = True Else Pearl = False
        If Pearl = True Then
            PearlButton.Image = My.Resources.pearl
            PearlButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nopearl As New Bitmap(My.Resources.pearl)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nopearl)
                g.DrawImage(nopearl, New Rectangle(0, 0, nopearl.Width, nopearl.Height),
                    0, 0, nopearl.Width, nopearl.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            PearlButton.Image = nopearl
            PearlButton.BackColor = Color.Black
        End If
        PODCheck()
        SPCheck()
        SWCheck()
        TTCheck()
        IPCheck()
        MMCheck()
        TRCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub MushButton_Click(sender As Object, e As EventArgs) Handles MushButton.MouseDown
        If Mushroom = False Then Mushroom = True Else Mushroom = False
        If Mushroom = True Then
            MushButton.Image = My.Resources.mushroom
            MushButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim nomushroom As New Bitmap(My.Resources.mushroom)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(nomushroom)
                g.DrawImage(nomushroom, New Rectangle(0, 0, nomushroom.Width, nomushroom.Height),
                    0, 0, nomushroom.Width, nomushroom.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            MushButton.Image = nomushroom
            MushButton.BackColor = Color.Black
        End If
        LWCheck()
    End Sub

    Private Sub ShovelButton_Click(sender As Object, e As EventArgs) Handles ShovelButton.MouseDown
        If Shovel = False Then Shovel = True Else Shovel = False
        If Shovel = True Then
            ShovelButton.Image = My.Resources.shovel
            ShovelButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noshovel As New Bitmap(My.Resources.shovel)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noshovel)
                g.DrawImage(noshovel, New Rectangle(0, 0, noshovel.Width, noshovel.Height),
                    0, 0, noshovel.Width, noshovel.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            ShovelButton.Image = noshovel
            ShovelButton.BackColor = Color.Black
        End If
        LWCheck()
    End Sub

    Private Sub AgaButton_Click(sender As Object, e As EventArgs) Handles AgaButton.MouseDown
        If Aganhim = False Then Aganhim = True Else Aganhim = False
        If Aganhim = True Then
            AgaButton.Image = My.Resources.aganhim
            AgaButton.BackColor = Color.WhiteSmoke
        Else
            Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

            Dim noaganhim As New Bitmap(My.Resources.aganhim)
            Dim imgattr As New Imaging.ImageAttributes()
            imgattr.SetColorMatrix(grayscale)
            Using g As Graphics = Graphics.FromImage(noaganhim)
                g.DrawImage(noaganhim, New Rectangle(0, 0, noaganhim.Width, noaganhim.Height),
                    0, 0, noaganhim.Width, noaganhim.Height,
                    GraphicsUnit.Pixel, imgattr)
            End Using
            AgaButton.Image = noaganhim
            AgaButton.BackColor = Color.Black
        End If
        PODCheck()
        SWCheck()
        TTCheck()
        LWCheck()
        DWCheck()
    End Sub

    Private Sub SwordButton_Click(sender As Object, e As EventArgs) Handles SwordButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Sword = (Sword + 1) Mod 5 Else Sword = (Sword + 4) Mod 5
        Select Case Sword
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim nosword As New Bitmap(My.Resources.nosword)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(nosword)
                    g.DrawImage(nosword, New Rectangle(0, 0, nosword.Width, nosword.Height),
                    0, 0, nosword.Width, nosword.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                SwordButton.Image = nosword
                SwordButton.BackColor = Color.Black
            Case 1
                SwordButton.Image = My.Resources.sword1
                SwordButton.BackColor = Color.WhiteSmoke
            Case 2
                SwordButton.Image = My.Resources.sword2
                SwordButton.BackColor = Color.WhiteSmoke
            Case 3
                SwordButton.Image = My.Resources.sword3
                SwordButton.BackColor = Color.WhiteSmoke
            Case 4
                SwordButton.Image = My.Resources.sword4
                SwordButton.BackColor = Color.WhiteSmoke
        End Select
        LWCheck()
        AgaCheck()
        TOHCheck()
        SWCheck()
        MMCheck()
        TRCheck()
    End Sub

    Private Sub ArmorButton_Click(sender As Object, e As EventArgs) Handles ArmorButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Armor = (Armor + 1) Mod 3 Else Armor = (Armor + 2) Mod 3
        Select Case Armor
            Case 0
                ArmorButton.Image = My.Resources.greenmail
            Case 1
                ArmorButton.Image = My.Resources.bluemail
            Case 2
                ArmorButton.Image = My.Resources.redmail
        End Select

    End Sub

    Private Sub ShieldButton_Click(sender As Object, e As EventArgs) Handles ShieldButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Shield = (Shield + 1) Mod 4 Else Shield = (Shield + 3) Mod 4
        Select Case Shield
            Case 0
                Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

                Dim noshield As New Bitmap(My.Resources.shield1)
                Dim imgattr As New Imaging.ImageAttributes()
                imgattr.SetColorMatrix(grayscale)
                Using g As Graphics = Graphics.FromImage(noshield)
                    g.DrawImage(noshield, New Rectangle(0, 0, noshield.Width, noshield.Height),
                    0, 0, noshield.Width, noshield.Height,
                    GraphicsUnit.Pixel, imgattr)
                End Using
                ShieldButton.Image = noshield
                ShieldButton.BackColor = Color.Black
            Case 1
                ShieldButton.Image = My.Resources.shield1
                ShieldButton.BackColor = Color.WhiteSmoke
            Case 2
                ShieldButton.Image = My.Resources.shield2
                ShieldButton.BackColor = Color.WhiteSmoke
            Case 3
                ShieldButton.Image = My.Resources.shield3
                ShieldButton.BackColor = Color.WhiteSmoke
        End Select
        TRCheck()
    End Sub

    Private Sub HlpButton_Click(sender As Object, e As EventArgs) Handles HlpButton.MouseDown
        Form2.ShowDialog()
    End Sub

End Class
