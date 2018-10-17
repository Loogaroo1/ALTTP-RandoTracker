Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, Magic, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available, AgaTree, Library, SpecRock, EtherTab, Floating, DPLedge, BombosTab, ZoraLedge, LakeIsle, Pedestal, Bumper As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean

    Public Sub LogicCheck()
        If Inverted.Checked = False Then
            HCCheck()
            EPCheck()
            DPCheck()
            AgaCheck()
            PODCheck()
            SPCheck()
            SWCheck()
            TTCheck()
            IPCheck()
            MMCheck()
            TRCheck()
            GTCheck()
            LWCheck()
            DWCheck()
        Else
            InvHCCheck()
            InvEPCheck()
            InvDPCheck()
            InvTOHCheck()
            InvAgaCheck()
            InvPODCheck()
            InvSPCheck()
            InvSWCheck()
            InvTTCheck()
            InvIPCheck()
            InvMMCheck()
            InvTRCheck()
            InvLWCheck()
            InvDWCheck()
            GTCheck()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
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
            HCLabel.Text = "H"
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
        HCLabel.Text = "HC"
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
            Case "H", "h"
                If My.Computer.Keyboard.ShiftKeyDown Then
                    If ComboBox1.SelectedIndex Mod 3 <> 1 Then HCPrizes.Text = 0 Else HCChests.Text = 0
                End If
            Case "!"
                EPBoss.Checked = True
                EPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then EPPrizes.Text = 0 Else EPChests.Text = 0
                EPLabel2.BackColor = Color.Green
            Case "@"
                DPBoss.Checked = True
                DPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then DPPrizes.Text = 0 Else DPChests.Text = 0
                DPLabel2.BackColor = Color.Green
            Case "#"
                HeraBoss.Checked = True
                HeraBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then TOHPrizes.Text = 0 Else TOHChests.Text = 0
                TOHLabel2.BackColor = Color.Green
            Case "$"
                PODBoss.Checked = True
                PODBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then PODPrizes.Text = 0 Else PODChests.Text = 0
                PODLabel2.BackColor = Color.Green
            Case "%"
                SPBoss.Checked = True
                SPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then SPPrizes.Text = 0 Else SPChests.Text = 0
                SPLabel2.BackColor = Color.Green
            Case "^"
                SWBoss.Checked = True
                SWBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then SWPrizes.Text = 0 Else SWChests.Text = 0
                SWLabel2.BackColor = Color.Green
            Case "&"
                TTBoss.Checked = True
                TTBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then TTPrizes.Text = 0 Else TTChests.Text = 0
                TTLabel2.BackColor = Color.Green
            Case "*"
                IPBoss.Checked = True
                IPBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then IPPrizes.Text = 0 Else IPChests.Text = 0
                IPLabel2.BackColor = Color.Green
            Case "("
                MMBoss.Checked = True
                MMBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then MMPrizes.Text = 0 Else MMChests.Text = 0
                MMLabel2.BackColor = Color.Green
            Case ")"
                TRBoss.Checked = True
                TRBoss.Image = My.Resources.bossdeadsmall
                If ComboBox1.SelectedIndex Mod 3 <> 1 Then TRPrizes.Text = 0 Else TRChests.Text = 0
                TRLabel2.BackColor = Color.Green
        End Select
        CrystalCheck()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                SwordButton.Visible = True
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
                AGBorder.Visible = False
                AGLabel.Visible = False
                AGChests.Visible = False
                AGKeys.Visible = False
                AGPrizes.Visible = False
                GTBorder.Visible = False
                GTLabel.Visible = False
                GTChests.Visible = False
                GTKeys.Visible = False
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
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
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
            Case 1
                SwordButton.Visible = True
                HCKeys.Visible = True
                HCChests.ForeColor = Color.White
                EPKeys.Visible = True
                EPMap.Visible = True
                EPBigKey.Visible = True
                EPChests.ForeColor = Color.White
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
                AGBorder.Visible = True
                AGLabel.Visible = True
                AGChests.Visible = True
                AGKeys.Visible = True
                GTBorder.Visible = True
                GTLabel.Visible = True
                GTChests.Visible = True
                GTKeys.Visible = True
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
                EPBoss.Left = 163
                DPBoss.Left = 163
                HeraBoss.Left = 163
                PODBoss.Left = 163
                SPBoss.Left = 163
                SWBoss.Left = 365
                TTBoss.Left = 365
                IPBoss.Left = 365
                MMBoss.Left = 365
                TRBoss.Left = 365
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
            Case 2
                SwordButton.Visible = True
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
                AGBorder.Visible = True
                AGLabel.Visible = True
                AGChests.Visible = True
                AGPrizes.Visible = True
                AGKeys.Visible = False
                GTBorder.Visible = False
                GTLabel.Visible = False
                GTChests.Visible = False
                GTKeys.Visible = False
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
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
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
                HCPrizes.Text = 7
                EPPrizes.Text = 3
                DPPrizes.Text = 3
                AGPrizes.Text = 2
                TOHPrizes.Text = 3
                PODPrizes.Text = 11
                SPPrizes.Text = 7
                SWPrizes.Text = 5
                TTPrizes.Text = 5
                IPPrizes.Text = 5
                MMPrizes.Text = 5
                TRPrizes.Text = 9
            Case 3
                SwordButton.Visible = False
                Sword = 0
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
                AGBorder.Visible = False
                AGLabel.Visible = False
                AGChests.Visible = False
                AGKeys.Visible = False
                AGPrizes.Visible = False
                GTBorder.Visible = False
                GTLabel.Visible = False
                GTChests.Visible = False
                GTKeys.Visible = False
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
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
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
            Case 4
                SwordButton.Visible = False
                Sword = 0
                HCKeys.Visible = True
                HCChests.ForeColor = Color.White
                EPKeys.Visible = True
                EPMap.Visible = True
                EPBigKey.Visible = True
                EPChests.ForeColor = Color.White
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
                AGBorder.Visible = True
                AGLabel.Visible = True
                AGChests.Visible = True
                AGKeys.Visible = True
                GTBorder.Visible = True
                GTLabel.Visible = True
                GTChests.Visible = True
                GTKeys.Visible = True
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
                EPBoss.Left = 163
                DPBoss.Left = 163
                HeraBoss.Left = 163
                PODBoss.Left = 163
                SPBoss.Left = 163
                SWBoss.Left = 365
                TTBoss.Left = 365
                IPBoss.Left = 365
                MMBoss.Left = 365
                TRBoss.Left = 365
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
            Case 5
                SwordButton.Visible = False
                Sword = 0
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
                AGBorder.Visible = True
                AGLabel.Visible = True
                AGChests.Visible = True
                AGPrizes.Visible = True
                AGKeys.Visible = False
                GTBorder.Visible = False
                GTLabel.Visible = False
                GTChests.Visible = False
                GTKeys.Visible = False
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
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
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
                HCPrizes.Text = 7
                EPPrizes.Text = 3
                DPPrizes.Text = 3
                AGPrizes.Text = 2
                TOHPrizes.Text = 3
                PODPrizes.Text = 11
                SPPrizes.Text = 7
                SWPrizes.Text = 5
                TTPrizes.Text = 5
                IPPrizes.Text = 5
                MMPrizes.Text = 5
                TRPrizes.Text = 9
            Case 6
                SwordButton.Visible = True
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
                AGBorder.Visible = False
                AGLabel.Visible = False
                AGChests.Visible = False
                AGKeys.Visible = False
                AGPrizes.Visible = False
                GTBorder.Visible = False
                GTLabel.Visible = False
                GTChests.Visible = False
                GTKeys.Visible = False
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
                EPBoss.Left = 115
                DPBoss.Left = 115
                HeraBoss.Left = 115
                PODBoss.Left = 115
                SPBoss.Left = 115
                SWBoss.Left = 317
                TTBoss.Left = 317
                IPBoss.Left = 317
                MMBoss.Left = 317
                TRBoss.Left = 317
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
        End Select
        LogicCheck()
    End Sub

    Public Sub LWCheck()
        If ComboBox1.SelectedIndex = 6 Then
            LW1.Enabled = True
            LW1.BackColor = Color.WhiteSmoke
            LW2.Enabled = True
            LW2.BackColor = Color.WhiteSmoke
            LW6.Enabled = True
            LW6.BackColor = Color.WhiteSmoke
            LW7.Enabled = True
            LW7.BackColor = Color.WhiteSmoke
            LW8.Enabled = True
            LW8.BackColor = Color.WhiteSmoke
            LW9.Enabled = True
            LW9.BackColor = Color.WhiteSmoke
            LW10.Enabled = True
            LW10.BackColor = Color.WhiteSmoke
            LW12.Enabled = True
            LW12.BackColor = Color.WhiteSmoke
            LW15.Enabled = True
            LW15.BackColor = Color.WhiteSmoke
            LW16.Enabled = True
            LW16.BackColor = Color.WhiteSmoke
            LW18.Enabled = True
            LW18.BackColor = Color.WhiteSmoke
            LW19.Enabled = True
            LW19.BackColor = Color.WhiteSmoke
            LW20.Enabled = True
            LW20.BackColor = Color.WhiteSmoke
            LW21.Enabled = True
            LW21.BackColor = Color.WhiteSmoke
            LW22.Enabled = True
            LW22.BackColor = Color.WhiteSmoke
            LW23.Enabled = True
            LW23.BackColor = Color.WhiteSmoke
            LW24.Enabled = True
            LW24.BackColor = Color.WhiteSmoke
            LW25.Enabled = True
            LW25.BackColor = Color.WhiteSmoke
            LW26.Enabled = True
            LW26.BackColor = Color.WhiteSmoke
            LW27.Enabled = True
            LW27.BackColor = Color.WhiteSmoke
            LW28.Enabled = True
            LW28.BackColor = Color.WhiteSmoke
            LW29.Enabled = True
            LW29.BackColor = Color.WhiteSmoke
            LW30.Enabled = True
            LW30.BackColor = Color.WhiteSmoke
            LW31.Enabled = True
            LW31.BackColor = Color.WhiteSmoke
            LW32.Enabled = True
            LW32.BackColor = Color.WhiteSmoke
            LW33.Enabled = True
            LW33.BackColor = Color.WhiteSmoke
            LW34.Enabled = True
            LW34.BackColor = Color.WhiteSmoke
            LW35.Enabled = True
            LW35.BackColor = Color.WhiteSmoke
            LW36.Enabled = True
            LW36.BackColor = Color.WhiteSmoke
            LW37.Enabled = True
            LW37.BackColor = Color.WhiteSmoke
            LW38.Enabled = True
            LW38.BackColor = Color.WhiteSmoke
            LW39.Enabled = True
            LW39.BackColor = Color.WhiteSmoke
            LW40.Enabled = True
            LW40.BackColor = Color.WhiteSmoke
            LW41.Enabled = True
            LW41.BackColor = Color.WhiteSmoke
            LW42.Enabled = True
            LW42.BackColor = Color.WhiteSmoke
            LW43.Enabled = True
            LW43.BackColor = Color.WhiteSmoke
            LW44.Enabled = True
            LW44.BackColor = Color.WhiteSmoke
            LW45.Enabled = True
            LW45.BackColor = Color.WhiteSmoke
            LW46.Enabled = True
            LW46.BackColor = Color.WhiteSmoke
            LW47.Enabled = True
            LW47.BackColor = Color.WhiteSmoke
        End If

        '' Lumberjack Tree (Normal) - Aganhim and Boots
        '' Lumberjack Tree (Inverted) - Add Pearl and LW Access
        If ComboBox1.SelectedIndex <> 6 Then
            If Aganhim = True And Boots = True Then
                LW6.Enabled = True
                LW6.BackColor = Color.WhiteSmoke
            Else
                LW6.Checked = False
                LW6.Enabled = False
                LW6.BackColor = Color.Red
            End If
        End If

        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave (Normal) - Bomb
        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave (Normal) - Add LW Access
        If ComboBox1.SelectedIndex <> 6 Then
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
                LW20.Checked = False
                LW20.BackColor = Color.Red
            End If
        End If

        '' Sick Kid - Bottle
        If ComboBox1.SelectedIndex <> 6 Then
            If Bottle = True Then
                LW14.Enabled = True
                LW14.BackColor = Color.WhiteSmoke
            Else
                LW14.Checked = False
                LW14.Enabled = False
                LW14.BackColor = Color.Red
            End If
        Else
            LW14.Enabled = True
            LW14.BackColor = Color.WhiteSmoke
        End If

        '' Library, Bonk Rocks - Boots
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Maze Race, Sahasrahla's Back Room - Boots or Bomb
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Desert Ledge - Desert Palace access (Book or Flute/Mitt/Mirror)
        If ComboBox1.SelectedIndex <> 6 Then
            If Book = True Or (Flute = True And Glove = 2 And Mirror = True) Then
                LW22.Enabled = True
                LW22.BackColor = Color.WhiteSmoke
            Else
                LW22.Checked = False
                LW22.Enabled = False
                LW22.BackColor = Color.Red
            End If
        Else
            LW22.Enabled = True
            LW22.BackColor = Color.WhiteSmoke
        End If

        '' Bombos Tablet (Swords) - Master Sword, Book, Access via Dark World
        '' Bombos Tablet (Swordless) - Hammer, Book, Access via Dark World
        Select Case ComboBox1.SelectedIndex
            Case 0, 1, 2
                If Pearl = True And Mirror = True And Book = True And Sword >= 2 And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or Aganhim = True And Hookshot = True And (Hammer = True Or Glove > 0 Or Flippers = True)) Then
                    LW23.Enabled = True
                    LW23.BackColor = Color.WhiteSmoke
                Else
                    LW23.Checked = False
                    LW23.Enabled = False
                    LW23.BackColor = Color.Red
                End If
            Case 3, 4, 5
                If Pearl = True And Mirror = True And Book = True And Hammer = True And (Glove > 0 Or Aganhim = True) Then
                    LW23.Enabled = True
                    LW23.BackColor = Color.WhiteSmoke
                Else
                    LW23.Checked = False
                    LW23.Enabled = False
                    LW23.BackColor = Color.Red
                End If
            Case Else
                LW23.Enabled = True
                LW23.BackColor = Color.WhiteSmoke
        End Select

        '' Checkerboard - Flute, Mitt, Mirror (no Pearl required)
        If ComboBox1.SelectedIndex <> 6 Then
            If Flute = True And Glove = 2 And Mirror = True Then
                LW24.Enabled = True
                LW24.BackColor = Color.WhiteSmoke
            Else
                LW24.Checked = False
                LW24.Enabled = False
                LW24.BackColor = Color.Red
            End If
        Else
            LW24.Enabled = True
            LW24.BackColor = Color.WhiteSmoke
        End If

        '' Dwarves - Pearl, Mitt (no Mirror required)
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Glove = 2 Then
                LW25.Enabled = True
                LW25.BackColor = Color.WhiteSmoke
            Else
                LW25.Checked = False
                LW25.Enabled = False
                LW25.BackColor = Color.Red
            End If
        End If

        '' Powder Bat - Powder, Hammer or Mirror+Pearl+Mitt
        If ComboBox1.SelectedIndex <> 6 Then
            If Powder = True And (Hammer = True Or (Mirror = True And Pearl = True And Glove = 2)) Then
                LW26.Enabled = True
                LW26.BackColor = Color.WhiteSmoke
            Else
                LW26.Checked = False
                LW26.Enabled = False
                LW26.BackColor = Color.Red
            End If
        End If

        '' Dig Spot - Shovel
        If ComboBox1.SelectedIndex <> 6 Then
            If Shovel = True Then
                LW27.Enabled = True
                LW27.BackColor = Color.WhiteSmoke
            Else
                LW27.Checked = False
                LW27.Enabled = False
                LW27.BackColor = Color.Red
            End If
        End If

        '' Cave south of Grove, Graveyard Cave - Mirror, Access via Dark World
        If ComboBox1.SelectedIndex <> 6 Then
            If Mirror = True And Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Flippers = True))) Then
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
        End If

        '' King's Tomb - Boots, Mitt or Access via Dark World
        If ComboBox1.SelectedIndex <> 6 Then
            If Boots = True And (Glove = 2 Or (Mirror = True And (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Hammer = True Or Flippers = True Or Glove > 0)))) Then
                LW31.Enabled = True
                LW31.BackColor = Color.WhiteSmoke
            Else
                LW31.Enabled = False
                LW31.Checked = False
                LW31.BackColor = Color.Red
            End If
        End If

        '' Hobo, Zora's Ledge, Waterfall - Flippers (Hobo can be faked)
        If ComboBox1.SelectedIndex <> 6 Then
            If Flippers = True Then
                LW32.Enabled = True
                LW32.BackColor = Color.WhiteSmoke
                LW35.Enabled = True
                LW35.BackColor = Color.WhiteSmoke
                LW37.Enabled = True
                LW37.BackColor = Color.WhiteSmoke
            Else
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
        End If

        '' Hylia Island - Flippers, Mirror, Pearl, access via Dark World
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Flippers = True And Mirror = True And (Aganhim = True Or (Glove > 0 And Hammer = True) Or Glove = 2) Then
                LW33.Enabled = True
                LW33.BackColor = Color.WhiteSmoke
            Else
                LW33.Checked = False
                LW33.Enabled = False
                LW33.BackColor = Color.Red
            End If
        End If

        '' Witch - Mushroom
        If ComboBox1.SelectedIndex <> 6 Then
            If Mushroom = True Then
                LW34.Enabled = True
                LW34.BackColor = Color.WhiteSmoke
            Else
                LW34.Checked = False
                LW34.Enabled = False
                LW34.BackColor = Color.Red
            End If
        End If

        '' Zora - Glove or Flippers (can be faked)
        If ComboBox1.SelectedIndex <> 6 Then
            If Flippers = True Or Glove > 0 Then
                LW36.Enabled = True
                LW36.BackColor = Color.WhiteSmoke
            Else
                LW36.Enabled = True
                LW36.BackColor = Color.Orange
            End If
        End If

        '' Old Man - Death Mountain access and Lamp (can be dark-navved)
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Spectacle Cave - Death Mountain access (Lamp prevents sequence break if Glove is used)
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Spectacle Rock - Death Mountain access (Lamp prevents sequence break if Glove is used) and Mirror
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Ether Tablet (Swords) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot+Hammer, Master Sword, Book
        '' Ether Tablet (SWordless) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot, Hammer, Book
        If ComboBox1.SelectedIndex < 3 Then
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
        ElseIf ComboBox1.SelectedIndex < 6 Then
            If Book = True And Hammer = True And (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or Hookshot = True) Then
                LW41.Enabled = True
                LW41.BackColor = Color.WhiteSmoke
            ElseIf Book = True And Glove > 0 And Hammer = True And (Mirror = True Or Hookshot = True) Then
                LW41.Enabled = True
                LW41.BackColor = Color.Orange
            Else
                LW41.Checked = False
                LW41.Enabled = False
                LW41.BackColor = Color.Red
            End If
        End If

        '' East Death Mountain, Spiral Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Hookshot or Mirror+Hammer
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Floating Island - Death Mountain access (Lamp prevents sequence break if Glove is used), Mitt, Pearl, Mirror
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Sahasrahla's Green Pendant
        If ComboBox1.SelectedIndex <> 6 Then
            If GreenPendant = True Then
                LW46.Enabled = True
                LW46.BackColor = Color.WhiteSmoke
            Else
                LW46.Checked = False
                LW46.Enabled = False
                LW46.BackColor = Color.Red
            End If
        End If

        '' Pedestal
        If ComboBox1.SelectedIndex <> 6 Then
            If PendantCount = 3 Then
                LW47.Enabled = True
                LW47.BackColor = Color.WhiteSmoke
            Else
                LW47.Checked = False
                LW47.Enabled = False
                LW47.BackColor = Color.Red
            End If
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

    Public Sub InvLWCheck()
        If ComboBox1.SelectedIndex = 6 Then
            LW1.Enabled = True
            LW1.BackColor = Color.WhiteSmoke
            LW2.Enabled = True
            LW2.BackColor = Color.WhiteSmoke
            LW6.Enabled = True
            LW6.BackColor = Color.WhiteSmoke
            LW7.Enabled = True
            LW7.BackColor = Color.WhiteSmoke
            LW8.Enabled = True
            LW8.BackColor = Color.WhiteSmoke
            LW9.Enabled = True
            LW9.BackColor = Color.WhiteSmoke
            LW10.Enabled = True
            LW10.BackColor = Color.WhiteSmoke
            LW12.Enabled = True
            LW12.BackColor = Color.WhiteSmoke
            LW15.Enabled = True
            LW15.BackColor = Color.WhiteSmoke
            LW16.Enabled = True
            LW16.BackColor = Color.WhiteSmoke
            LW18.Enabled = True
            LW18.BackColor = Color.WhiteSmoke
            LW19.Enabled = True
            LW19.BackColor = Color.WhiteSmoke
            LW20.Enabled = True
            LW20.BackColor = Color.WhiteSmoke
            LW21.Enabled = True
            LW21.BackColor = Color.WhiteSmoke
            LW22.Enabled = True
            LW22.BackColor = Color.WhiteSmoke
            LW23.Enabled = True
            LW23.BackColor = Color.WhiteSmoke
            LW24.Enabled = True
            LW24.BackColor = Color.WhiteSmoke
            LW25.Enabled = True
            LW25.BackColor = Color.WhiteSmoke
            LW26.Enabled = True
            LW26.BackColor = Color.WhiteSmoke
            LW27.Enabled = True
            LW27.BackColor = Color.WhiteSmoke
            LW28.Enabled = True
            LW28.BackColor = Color.WhiteSmoke
            LW29.Enabled = True
            LW29.BackColor = Color.WhiteSmoke
            LW30.Enabled = True
            LW30.BackColor = Color.WhiteSmoke
            LW31.Enabled = True
            LW31.BackColor = Color.WhiteSmoke
            LW32.Enabled = True
            LW32.BackColor = Color.WhiteSmoke
            LW33.Enabled = True
            LW33.BackColor = Color.WhiteSmoke
            LW34.Enabled = True
            LW34.BackColor = Color.WhiteSmoke
            LW35.Enabled = True
            LW35.BackColor = Color.WhiteSmoke
            LW36.Enabled = True
            LW36.BackColor = Color.WhiteSmoke
            LW37.Enabled = True
            LW37.BackColor = Color.WhiteSmoke
            LW38.Enabled = True
            LW38.BackColor = Color.WhiteSmoke
            LW39.Enabled = True
            LW39.BackColor = Color.WhiteSmoke
            LW40.Enabled = True
            LW40.BackColor = Color.WhiteSmoke
            LW41.Enabled = True
            LW41.BackColor = Color.WhiteSmoke
            LW42.Enabled = True
            LW42.BackColor = Color.WhiteSmoke
            LW43.Enabled = True
            LW43.BackColor = Color.WhiteSmoke
            LW44.Enabled = True
            LW44.BackColor = Color.WhiteSmoke
            LW45.Enabled = True
            LW45.BackColor = Color.WhiteSmoke
            LW46.Enabled = True
            LW46.BackColor = Color.WhiteSmoke
            LW47.Enabled = True
            LW47.BackColor = Color.WhiteSmoke
        End If

        '' Sphere 0, Grove Cave: LW Access
        If ComboBox1.SelectedIndex <> 6 Then
            LW1.Enabled = True
            LW1.BackColor = Color.WhiteSmoke
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                LW2.Enabled = True
                LW2.BackColor = Color.WhiteSmoke
                LW7.Enabled = True
                LW7.BackColor = Color.WhiteSmoke
                LW8.Enabled = True
                LW8.BackColor = Color.WhiteSmoke
                LW9.Enabled = True
                LW9.BackColor = Color.WhiteSmoke
                LW10.Enabled = True
                LW10.BackColor = Color.WhiteSmoke
                LW11.Enabled = True
                LW11.BackColor = Color.WhiteSmoke
                LW13.Enabled = True
                LW13.BackColor = Color.WhiteSmoke
                LW17.Enabled = True
                LW17.BackColor = Color.WhiteSmoke
                LW28.Enabled = True
                LW28.BackColor = Color.WhiteSmoke
                LW30.Enabled = True
                LW30.BackColor = Color.WhiteSmoke
            Else
                LW2.Checked = False
                LW2.Enabled = False
                LW2.BackColor = Color.Red
                LW7.Checked = False
                LW7.Enabled = False
                LW7.BackColor = Color.Red
                LW8.Checked = False
                LW8.Enabled = False
                LW8.BackColor = Color.Red
                LW9.Checked = False
                LW9.Enabled = False
                LW9.BackColor = Color.Red
                LW10.Checked = False
                LW10.Enabled = False
                LW10.BackColor = Color.Red
                LW11.Checked = False
                LW11.Enabled = False
                LW11.BackColor = Color.Red
                LW13.Checked = False
                LW13.Enabled = False
                LW13.BackColor = Color.Red
                LW17.Checked = False
                LW17.Enabled = False
                LW17.BackColor = Color.Red
                LW28.Checked = False
                LW28.Enabled = False
                LW28.BackColor = Color.Red
                LW30.Checked = False
                LW30.Enabled = False
                LW30.BackColor = Color.Red
            End If
        End If

        '' Sphere 0 Bomb locations
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Bombs = True Then
                LW12.Enabled = True
                LW12.BackColor = Color.WhiteSmoke
                LW16.Enabled = True
                LW16.BackColor = Color.WhiteSmoke
                LW18.Enabled = True
                LW18.BackColor = Color.WhiteSmoke
                LW19.Enabled = True
                LW19.BackColor = Color.WhiteSmoke
                LW20.Enabled = True
                LW20.BackColor = Color.WhiteSmoke
                LW21.Enabled = True
                LW21.BackColor = Color.WhiteSmoke
            Else
                LW12.Enabled = False
                LW12.BackColor = Color.Red
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Boots = True Then
                    LW16.Enabled = True
                    LW16.BackColor = Color.WhiteSmoke
                Else
                    LW16.Enabled = False
                    LW16.BackColor = Color.Red
                End If
                LW18.Checked = False
                LW18.Enabled = False
                LW18.BackColor = Color.Red
                LW19.Checked = False
                LW19.Enabled = False
                LW19.BackColor = Color.Red
                LW20.Checked = False
                LW20.Enabled = False
                LW20.BackColor = Color.Red
                LW21.Checked = False
                LW21.Enabled = False
                LW21.BackColor = Color.Red
            End If
        End If

        '' Sick Kid - Bottle
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Bottle = True Then
                LW14.Enabled = True
                LW14.BackColor = Color.WhiteSmoke
            Else
                LW14.Checked = False
                LW14.Enabled = False
                LW14.BackColor = Color.Red
            End If
        End If

        '' Pegasus Rocks, Library - Boots
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Boots = True Then
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
        End If

        '' DP Ledge - Book
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Book = True Then
                LW22.Enabled = True
                LW22.BackColor = Color.WhiteSmoke
            Else
                LW22.Checked = False
                LW22.Enabled = False
                LW22.BackColor = Color.Red
            End If
        End If

        '' Bombos Tablet - Book, Master Sword or Hammer (Swordless)
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Book = True And Sword > 1 Then
                LW23.Enabled = True
                LW23.BackColor = Color.WhiteSmoke
            Else
                LW23.Checked = False
                LW23.Enabled = False
                LW23.BackColor = Color.Red
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 5 Then
            If Pearl = True And (Aganhim = True Or Glove = 1) And Book = True And Hammer = True Then
                LW23.Enabled = True
                LW23.BackColor = Color.WhiteSmoke
            Else
                LW23.Checked = False
                LW23.Enabled = False
                LW23.BackColor = Color.Red
            End If
        End If

        '' Checkerboard Cave - Glove
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Glove > 0 Then
                LW24.Enabled = True
                LW24.BackColor = Color.WhiteSmoke
            Else
                LW24.Checked = False
                LW24.Enabled = False
                LW24.BackColor = Color.Red
            End If
        End If

        '' Blacksmith - Mitt + Pearl or LW Access + Mirror
        If ComboBox1.SelectedIndex <> 6 Then
            If (Aganhim = True And Mirror = True) Or (Glove = 2 And Pearl = True) Or (Glove = 1 And Hammer = True And Mirror = True And Pearl = True) Then
                LW25.Enabled = True
                LW25.BackColor = Color.WhiteSmoke
            Else
                LW25.Checked = False
                LW25.Enabled = False
                LW25.BackColor = Color.Red
            End If
        End If

        '' Magic Bat - Glove
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove > 0) And Hammer = True And Powder = True Then
                LW26.Enabled = True
                LW26.BackColor = Color.WhiteSmoke
            Else
                LW26.Checked = False
                LW26.Enabled = False
                LW26.BackColor = Color.Red
            End If
        End If

        '' Flute Spot - Shovel
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Shovel = True Then
                LW27.Enabled = True
                LW27.BackColor = Color.WhiteSmoke
            Else
                LW27.Checked = False
                LW27.Enabled = False
                LW27.BackColor = Color.Red
            End If
        End If

        '' King's Tomb - Mitt, Boots
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Glove = 2 And Boots = True Then
                LW31.Enabled = True
                LW31.BackColor = Color.WhiteSmoke
            Else
                LW31.Checked = False
                LW31.Enabled = False
                LW31.BackColor = Color.Red
            End If
        End If

        '' Hobo, Waterfall, Island - Flippers avoids sequence break
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                LW32.Enabled = True
                LW33.Enabled = True
                LW35.Enabled = True
                If Flippers = True Then
                    LW32.BackColor = Color.WhiteSmoke
                    LW33.BackColor = Color.WhiteSmoke
                    LW35.BackColor = Color.WhiteSmoke
                Else
                    LW32.BackColor = Color.Orange
                    LW33.BackColor = Color.Orange
                    LW35.BackColor = Color.Orange
                End If
            Else
                LW32.Checked = False
                LW32.Enabled = False
                LW32.BackColor = Color.Red
                LW33.Checked = False
                LW33.Enabled = False
                LW33.BackColor = Color.Red
                LW35.Checked = False
                LW35.Enabled = False
                LW35.BackColor = Color.Red
            End If
        End If

        '' Potion Shop - Mushroom
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Mushroom = True Then
                LW34.Enabled = True
                LW34.BackColor = Color.WhiteSmoke
            Else
                LW34.Checked = False
                LW34.Enabled = False
                LW34.BackColor = Color.Red
            End If
        End If

        '' Zora - Glove or Flippers avoids sequence break
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                LW36.Enabled = True
                If Flippers = True Or Glove > 0 Then LW36.BackColor = Color.WhiteSmoke Else LW36.BackColor = Color.Orange
            Else
                LW36.Checked = False
                LW36.Enabled = False
                LW36.BackColor = Color.Red
            End If
        End If

        '' Ledge - Flippers ONLY
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Flippers = True Then
                LW37.Enabled = True
                LW37.BackColor = Color.WhiteSmoke
            Else
                LW37.Checked = False
                LW37.Enabled = False
                LW37.BackColor = Color.Red
            End If
        End If

        '' Old Man, Spectacle Cave - Flute or Glove (+ Lamp to avoid sequence break)
        If ComboBox1.SelectedIndex <> 6 Then
            If Flute = True Or Glove > 0 Then
                LW38.Enabled = True
                LW39.Enabled = True
                If Flute = True Or Lamp = True Then
                    LW38.BackColor = Color.WhiteSmoke
                    LW39.BackColor = Color.WhiteSmoke
                Else
                    LW38.BackColor = Color.Orange
                    LW39.BackColor = Color.Orange
                End If
            Else
                LW38.Checked = False
                LW38.Enabled = False
                LW38.BackColor = Color.Red
                LW39.Checked = False
                LW39.Enabled = False
                LW39.BackColor = Color.Red
            End If
        End If

        '' Spectacle Rock - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt, Hammer
        If ComboBox1.SelectedIndex <> 6 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True Then
                LW40.Enabled = True
                If (Flute = True Or Lamp = True) Then LW40.BackColor = Color.WhiteSmoke Else LW40.BackColor = Color.Orange
            Else
                LW40.Checked = False
                LW40.Enabled = False
                LW40.BackColor = Color.Red
            End If
        End If

        '' Ether Tablet - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt, Hammer, Book
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True And Book = True And Sword > 1 Then
                LW41.Enabled = True
                If (Flute = True Or Lamp = True) Then LW41.BackColor = Color.WhiteSmoke Else LW41.BackColor = Color.Orange
            Else
                LW41.Checked = False
                LW41.Enabled = False
                LW41.BackColor = Color.Red
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 5 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True And Book = True Then
                LW41.Enabled = True
                If (Flute = True Or Lamp = True) Then LW41.BackColor = Color.WhiteSmoke Else LW41.BackColor = Color.Orange
            Else
                LW41.Checked = False
                LW41.Enabled = False
                LW41.BackColor = Color.Red
            End If
        End If

        '' Paradox Cave, Spiral Cave, Floating Island - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt + Hammer
        If ComboBox1.SelectedIndex <> 6 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or (Glove = 2 And Hammer = True)) Then
                LW42.Enabled = True
                LW43.Enabled = True
                LW44.Enabled = True
                If (Flute = True Or Lamp = True) Then
                    LW42.BackColor = Color.WhiteSmoke
                    LW43.BackColor = Color.WhiteSmoke
                    LW44.BackColor = Color.WhiteSmoke
                Else
                    LW42.BackColor = Color.Orange
                    LW43.BackColor = Color.Orange
                    LW44.BackColor = Color.Orange
                End If
            Else
                LW42.Checked = False
                LW42.Enabled = False
                LW42.BackColor = Color.Red
                LW43.Checked = False
                LW43.Enabled = False
                LW43.BackColor = Color.Red
                LW44.Checked = False
                LW44.Enabled = False
                LW44.BackColor = Color.Red
                LW45.Checked = False
            End If
        End If

        '' Mimic Cave - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt, Hammer
        If ComboBox1.SelectedIndex <> 6 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True Then
                LW45.Enabled = True
                If (Flute = True Or Lamp = True) Then LW45.BackColor = Color.WhiteSmoke Else LW45.BackColor = Color.Orange
            Else
                LW45.Checked = False
                LW45.Enabled = False
                LW45.BackColor = Color.Red
            End If
        End If

        '' Macguffins
        If ComboBox1.SelectedIndex <> 6 Then
            If GreenPendant = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                LW46.Enabled = True
                LW46.BackColor = Color.WhiteSmoke
            Else
                LW46.Enabled = False
                LW46.BackColor = Color.Red
            End If
        End If

        If ComboBox1.SelectedIndex <> 6 Then
            If PendantCount = 3 And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                LW47.Enabled = True
                LW47.BackColor = Color.WhiteSmoke
            Else
                LW47.Enabled = False
                LW47.BackColor = Color.Red
            End If
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
        If ComboBox1.SelectedIndex = 6 Then
            DW1.Enabled = True
            DW1.BackColor = Color.WhiteSmoke
            DW2.Enabled = True
            DW2.BackColor = Color.WhiteSmoke
            DW3.Enabled = True
            DW3.BackColor = Color.WhiteSmoke
            DW4.Enabled = True
            DW4.BackColor = Color.WhiteSmoke
            DW5.Enabled = True
            DW5.BackColor = Color.WhiteSmoke
            DW6.Enabled = True
            DW6.BackColor = Color.WhiteSmoke
            DW7.Enabled = True
            DW7.BackColor = Color.WhiteSmoke
            DW8.Enabled = True
            DW8.BackColor = Color.WhiteSmoke
            DW9.Enabled = True
            DW9.BackColor = Color.WhiteSmoke
            DW10.Enabled = True
            DW10.BackColor = Color.WhiteSmoke
            DW11.Enabled = True
            DW11.BackColor = Color.WhiteSmoke
            DW12.Enabled = True
            DW12.BackColor = Color.WhiteSmoke
            DW13.Enabled = True
            DW13.BackColor = Color.WhiteSmoke
            DW14.Enabled = True
            DW14.BackColor = Color.WhiteSmoke
            DW15.Enabled = True
            DW15.BackColor = Color.WhiteSmoke
            DW16.Enabled = True
            DW16.BackColor = Color.WhiteSmoke
        End If

        If ComboBox1.SelectedIndex <> 6 Then
            If Aganhim = True Or (Pearl = True And ((Glove > 0 And Hammer = True) Or (Glove = 2 And Flippers = True))) Then
                DW1.Enabled = True
                DW1.BackColor = Color.WhiteSmoke
            Else
                DW1.Checked = False
                DW1.Enabled = False
                DW1.BackColor = Color.Red
            End If
        End If

        '' Chest Game, C House, Sealed Hut, Bumper Cave - Mitt, Glove/Hammer, or Aganhim/Hookshot/Access (Cape also required for Bumper Cave)
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                DW2.Enabled = True
                DW2.BackColor = Color.WhiteSmoke
                DW3.Enabled = True
                DW3.BackColor = Color.WhiteSmoke
                DW4.Enabled = True
                DW4.BackColor = Color.WhiteSmoke
                If Cape = True And Glove > 0 Then
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
        End If

        '' Digging Game, Tree Kid, Swamp Hype - Mitt, Glove/Hammer, Aganhim/Hammer, or Aganhim/Hookshot/Glove or Flippers
        If ComboBox1.SelectedIndex <> 6 Then
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
        End If

        '' Mire Cave - Flute, Mitt, Pearl
        If ComboBox1.SelectedIndex <> 6 Then
            If Flute = True And Glove = 2 And Pearl = True Then
                DW6.Enabled = True
                DW6.BackColor = Color.WhiteSmoke
            Else
                DW6.Checked = False
                DW6.Enabled = False
                DW6.BackColor = Color.Red
            End If
        End If

        '' Purple Chest - Dwarves complete (no further items required)
        If ComboBox1.SelectedIndex <> 6 Then
            If LW25.Checked = True Then
                DW8.Enabled = True
                DW8.BackColor = Color.WhiteSmoke
            Else
                DW8.Checked = False
                DW8.Enabled = False
                DW8.BackColor = Color.Red
            End If
        End If

        '' Hammer Pegs - Pearl, Mitt, Hammer
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Glove = 2 And Hammer = True Then
                DW9.Enabled = True
                DW9.BackColor = Color.WhiteSmoke
            Else
                DW9.Checked = False
                DW9.Enabled = False
                DW9.BackColor = Color.Red
            End If
        End If

        '' Catfish - Pearl, Glove, Aganhim/Hammer/Mitt+Flippers
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Glove > 0 And ((Glove = 2 And Flippers = True) Or Hammer = True Or Aganhim = True) Then
                DW12.Enabled = True
                DW12.BackColor = Color.WhiteSmoke
            Else
                DW12.Checked = False
                DW12.Enabled = False
                DW12.BackColor = Color.Red
            End If
        End If

        '' Spike Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Hammer, Glove; Safety item (Byrna or Cape) and either 1/2 magic or bottle to avoid sequence break
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Hammer = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
                If (Byrna = True Or Cape = True And Glove > 0) And (Magic > 0 Or BottleNumber.Text > 0) Then
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
        End If

        '' Superbunny Cave - Death Mountain access (Lamp prevents sequence break if Glove is used, Pearl prevents sequence break), Mitt, Hookshot or Hammer+Mirror
        If ComboBox1.SelectedIndex <> 6 Then
            If Glove = 2 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
                If (Flute = True Or Lamp = True) And Pearl = True Then
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
        End If

        '' Hookshot Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror+Boots (Partially blocked without Hookshot)
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And Glove = 2 And Hookshot = True Then
                If Flute = True Or Lamp = True Then
                    DW15.Enabled = True
                    DW15.BackColor = Color.WhiteSmoke
                Else
                    DW15.Enabled = True
                    DW15.BackColor = Color.Orange
                End If
                DW15.TextAlign = ContentAlignment.MiddleCenter
                DW15Boots.Visible = False
            ElseIf Pearl = True And Glove = 2 And Hammer = True And Mirror = True And Boots = True Then
                DW15.Checked = False
                DW15.Enabled = False
                DW15.BackColor = Color.Red
                DW15.TextAlign = ContentAlignment.MiddleLeft
                DW15Boots.Visible = True
            Else
                DW15.Checked = False
                DW15.Enabled = False
                DW15.BackColor = Color.Red
                DW15.TextAlign = ContentAlignment.MiddleCenter
                DW15Boots.Visible = False
            End If
        End If

        '' Fat Fairy - Crystals 5 & 6, Pearl, Hammer, Glove or Aganhim
        If ComboBox1.SelectedIndex <> 6 Then
            If Pearl = True And FairyCrystal = 2 And ((Glove > 0 And Hammer = True) Or (Aganhim = True And Mirror = True) Or (Aganhim = True And Hammer = True)) Then
                DW16.Enabled = True
                DW16.BackColor = Color.WhiteSmoke
            Else
                DW16.Checked = False
                DW16.Enabled = False
                DW16.BackColor = Color.Red
            End If
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

    Public Sub InvDWCheck()
        If ComboBox1.SelectedIndex = 6 Then
            DW1.Enabled = True
            DW1.BackColor = Color.WhiteSmoke
            DW2.Enabled = True
            DW2.BackColor = Color.WhiteSmoke
            DW3.Enabled = True
            DW3.BackColor = Color.WhiteSmoke
            DW4.Enabled = True
            DW4.BackColor = Color.WhiteSmoke
            DW5.Enabled = True
            DW5.BackColor = Color.WhiteSmoke
            DW6.Enabled = True
            DW6.BackColor = Color.WhiteSmoke
            DW7.Enabled = True
            DW7.BackColor = Color.WhiteSmoke
            DW8.Enabled = True
            DW8.BackColor = Color.WhiteSmoke
            DW9.Enabled = True
            DW9.BackColor = Color.WhiteSmoke
            DW10.Enabled = True
            DW10.BackColor = Color.WhiteSmoke
            DW11.Enabled = True
            DW11.BackColor = Color.WhiteSmoke
            DW12.Enabled = True
            DW12.BackColor = Color.WhiteSmoke
            DW13.Enabled = True
            DW13.BackColor = Color.WhiteSmoke
            DW14.Enabled = True
            DW14.BackColor = Color.WhiteSmoke
            DW15.Enabled = True
            DW15.BackColor = Color.WhiteSmoke
            DW16.Enabled = True
            DW16.BackColor = Color.WhiteSmoke
        End If

        '' Chest Game, C-Shaped House, Stumpy, Digging Game - Free
        If ComboBox1.SelectedIndex <> 6 Then
            DW2.Enabled = True
            DW2.BackColor = Color.WhiteSmoke
            DW3.Enabled = True
            DW3.BackColor = Color.WhiteSmoke
            DW5.Enabled = True
            DW5.BackColor = Color.WhiteSmoke
            DW10.Enabled = True
            DW10.BackColor = Color.WhiteSmoke
        End If

        '' Sealed Brewery, Hype Cave - Bombs
        If ComboBox1.SelectedIndex <> 6 Then
            If Bombs = True Then
                DW4.Enabled = True
                DW4.BackColor = Color.WhiteSmoke
                DW11.Enabled = True
                DW11.BackColor = Color.WhiteSmoke
            Else
                DW4.Checked = False
                DW4.Enabled = False
                DW4.BackColor = Color.Red
                DW11.Checked = False
                DW11.Enabled = False
                DW11.BackColor = Color.Red
            End If
        End If

        '' Pyramid, Catfish - Hammer or Flippers; Catfish needs Glove
        If ComboBox1.SelectedIndex <> 6 Then
            If Hammer = True Or Flippers = True Then
                DW1.Enabled = True
                DW1.BackColor = Color.WhiteSmoke
                If Glove > 0 Then
                    DW12.Enabled = True
                    DW12.BackColor = Color.WhiteSmoke
                Else
                    DW12.Enabled = False
                    DW12.BackColor = Color.Red
                End If
            Else
                DW1.Checked = False
                DW1.Enabled = False
                DW1.BackColor = Color.Red
                DW12.Checked = False
                DW12.Enabled = False
                DW12.BackColor = Color.Red
            End If
        End If

        '' Mire Cave - Flute or LW Access + Mirror
        If ComboBox1.SelectedIndex <> 6 Then
            If Flute = True Or (Pearl = True And Mirror = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True))) Then
                DW6.Enabled = True
                DW6.BackColor = Color.WhiteSmoke
            End If
        Else
            DW6.Checked = False
            DW6.Enabled = False
            DW6.BackColor = Color.Red
        End If

        '' Bumper Cave - LW Access, Mirror, Glove, Cape
        If ComboBox1.SelectedIndex <> 6 Then
            If Cape = True And Pearl = True And Mirror = True And Glove > 0 And (Aganhim = True Or Glove = 2 Or Hammer = True) Then
                DW7.Enabled = True
                DW7.BackColor = Color.WhiteSmoke
            End If
        Else
            DW7.Checked = False
            DW7.Enabled = False
            DW7.BackColor = Color.Red
        End If

        '' Purple Chest - Blacksmith
        If ComboBox1.SelectedIndex <> 6 Then
            If LW25.Checked = True Then
                DW8.Enabled = True
                DW8.BackColor = Color.WhiteSmoke
            End If
        Else
            DW8.Checked = False
            DW8.Enabled = False
            DW8.BackColor = Color.Red
        End If

        '' Hammer Pegs - Hammer, Mitt or Mirror
        If ComboBox1.SelectedIndex <> 6 Then
            If (Glove = 2 Or ((Aganhim = True Or (Glove = 1 And Pearl = True)) And Mirror = True)) And Hammer = True Then
                DW9.Enabled = True
                DW9.BackColor = Color.WhiteSmoke
            Else
                DW9.Checked = False
                DW9.Enabled = False
                DW9.BackColor = Color.Red
            End If
        End If

        '' Spike Cave - DM Access, Hammer, Safety Item
        If ComboBox1.SelectedIndex <> 6 Then
            If (Flute = True Or Glove > 0) And Hammer = True And (Cape = True Or Byrna = True) Then
                DW13.Enabled = True
                If (Flute = True Or Lamp = True) And (Bottle = True Or Magic > 0) Then DW13.BackColor = Color.WhiteSmoke Else DW13.BackColor = Color.Orange
            End If
        Else
            DW13.Checked = False
            DW13.Enabled = False
            DW13.BackColor = Color.Red
        End If

        '' Superbunny Cave - DM Access
        If ComboBox1.SelectedIndex <> 6 Then
            If (Flute = True Or Glove > 0) Then
                DW14.Enabled = True
                If Flute = True Or Lamp = True Then DW14.BackColor = Color.WhiteSmoke Else DW14.BackColor = Color.Orange
            End If
        Else
            DW14.Checked = False
            DW14.Enabled = False
            DW14.BackColor = Color.Red
        End If

        '' Hookshot Cave - DM Access, Hookshot; Boots opens Partial
        If ComboBox1.SelectedIndex <> 6 Then
            If (Flute = True Or Glove > 0) And Hookshot = True Then
                If Flute = True Or Lamp = True Then
                    DW15.Enabled = True
                    DW15.BackColor = Color.WhiteSmoke
                Else
                    DW15.Enabled = True
                    DW15.BackColor = Color.Orange
                End If
                DW15.TextAlign = ContentAlignment.MiddleCenter
                DW15Boots.Visible = False
            ElseIf (Flute = True Or Glove > 0) And Boots = True Then
                DW15.Checked = False
                DW15.Enabled = False
                DW15.BackColor = Color.Red
                DW15.TextAlign = ContentAlignment.MiddleLeft
                DW15Boots.Visible = True
            End If
        End If

        '' Pyramid Fairy - Fairy Crystals, LW Access, Mirror
        If ComboBox1.SelectedIndex <> 6 Then
            If FairyCrystal = 2 And Mirror = True And Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                DW16.Enabled = True
                DW16.BackColor = Color.WhiteSmoke
            Else
                DW16.Checked = False
                DW16.Enabled = False
                DW16.BackColor = Color.Red
            End If
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
        If Inverted.Checked = False Then
            LWCheck()
            DWCheck()
        Else
            InvLWCheck()
            InvDWCheck()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgaTree = (AgaTree + 1) Mod 3
        Select Case AgaTree
            Case 1
                Button1.Image = My.Resources.redchestsmall
            Case 2
                Button1.Image = My.Resources.greenchestsmall
            Case Else
                Button1.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Library = (Library + 1) Mod 3
        Select Case Library
            Case 1
                Button2.Image = My.Resources.redchestsmall
            Case 2
                Button2.Image = My.Resources.greenchestsmall
            Case Else
                Button2.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SpecRock = (SpecRock + 1) Mod 3
        Select Case SpecRock
            Case 1
                Button4.Image = My.Resources.redchestsmall
            Case 2
                Button4.Image = My.Resources.greenchestsmall
            Case Else
                Button4.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EtherTab = (EtherTab + 1) Mod 3
        Select Case EtherTab
            Case 1
                Button5.Image = My.Resources.redchestsmall
            Case 2
                Button5.Image = My.Resources.greenchestsmall
            Case Else
                Button5.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Floating = (Floating + 1) Mod 3
        Select Case Floating
            Case 1
                Button6.Image = My.Resources.redchestsmall
            Case 2
                Button6.Image = My.Resources.greenchestsmall
            Case Else
                Button6.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DPLedge = (DPLedge + 1) Mod 3
        Select Case DPLedge
            Case 1
                Button7.Image = My.Resources.redchestsmall
            Case 2
                Button7.Image = My.Resources.greenchestsmall
            Case Else
                Button7.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BombosTab = (BombosTab + 1) Mod 3
        Select Case BombosTab
            Case 1
                Button8.Image = My.Resources.redchestsmall
            Case 2
                Button8.Image = My.Resources.greenchestsmall
            Case Else
                Button8.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ZoraLedge = (ZoraLedge + 1) Mod 3
        Select Case ZoraLedge
            Case 1
                Button9.Image = My.Resources.redchestsmall
            Case 2
                Button9.Image = My.Resources.greenchestsmall
            Case Else
                Button9.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LakeIsle = (LakeIsle + 1) Mod 3
        Select Case LakeIsle
            Case 1
                Button10.Image = My.Resources.redchestsmall
            Case 2
                Button10.Image = My.Resources.greenchestsmall
            Case Else
                Button10.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Pedestal = (Pedestal + 1) Mod 3
        Select Case Pedestal
            Case 1
                Button11.Image = My.Resources.redchestsmall
            Case 2
                Button11.Image = My.Resources.greenchestsmall
            Case Else
                Button11.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Bumper = (Bumper + 1) Mod 3
        Select Case Bumper
            Case 1
                Button12.Image = My.Resources.redchestsmall
            Case 2
                Button12.Image = My.Resources.greenchestsmall
            Case Else
                Button12.Image = My.Resources.chestmaybesmall
        End Select
    End Sub

    Public Sub HCCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Glove > 0 And Lamp = True And (Bombs = True Or Boots = True) Then
                    HCLabel.BackColor = Color.Green
                    HCLabel.ForeColor = Color.White
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.White
                    HCBorder.BackColor = Color.White
                ElseIf Lamp = True And (Bombs = True Or Boots = True) Then
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.Yellow
                    HCBorder.BackColor = Color.Black
                ElseIf Glove > 0 And (Bombs = True Or Boots = True) Then
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.Orange
                    HCBorder.BackColor = Color.Black
                ElseIf Lamp = True Then
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCChests.Text = 5
                    HCChests.ForeColor = Color.White
                    HCBorder.BackColor = Color.Black
                Else
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCChests.Text = 5
                    HCChests.ForeColor = Color.Yellow
                    HCBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If (Glove > 0 Or HCKeys.Text = 1) And (Bombs = True Or Boots = True) Then
                    If Lamp = True Then HCLabel.BackColor = Color.Green Else HCLabel.BackColor = Color.Orange
                    HCLabel.ForeColor = Color.White
                    HCChests.ForeColor = Color.White
                    HCBorder.BackColor = Color.White
                Else
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCBorder.BackColor = Color.Black
                End If
            Case Else
                HCLabel.BackColor = Color.Green
                HCLabel.ForeColor = Color.White
                HCChests.Text = 8
                HCChests.ForeColor = Color.White
                HCBorder.BackColor = Color.White
        End Select
    End Sub

    Public Sub InvHCCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And (Bombs = True Or Boots = True) Then
                    If Lamp = True Then HCLabel.BackColor = Color.Green Else HCLabel.BackColor = Color.Orange
                    HCLabel.ForeColor = Color.White
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.White
                    HCBorder.BackColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCChests.Text = 5
                    If Lamp = True Then HCChests.ForeColor = Color.White Else HCChests.ForeColor = Color.Yellow
                    HCBorder.BackColor = Color.Black
                Else
                    HCLabel.BackColor = Color.Red
                    HCLabel.ForeColor = Color.Black
                    HCChests.Text = 0
                    HCChests.ForeColor = Color.White
                    HCBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And (Bombs = True Or Boots = True) Then
                    If Lamp = True And HCKeys.Text = 1 Then HCLabel.BackColor = Color.Green Else HCLabel.BackColor = Color.Orange
                    HCLabel.ForeColor = Color.White
                    HCBorder.BackColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                    HCLabel.BackColor = Color.Yellow
                    HCLabel.ForeColor = Color.Black
                    HCBorder.BackColor = Color.Black
                Else
                    HCLabel.BackColor = Color.Red
                    HCLabel.ForeColor = Color.Black
                    HCBorder.BackColor = Color.Black
                End If
            Case 6
                HCLabel.BackColor = Color.Green
                HCLabel.ForeColor = Color.White
                HCChests.Text = 8
                HCChests.ForeColor = Color.White
                HCBorder.BackColor = Color.White
        End Select
    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As EventArgs) Handles HCChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Then
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
        If Inverted.Checked = False Then
            HCCheck()
            LWCheck()
        Else
            InvHCCheck()
            InvLWCheck()
        End If
    End Sub

    Private Sub HCPrizes_MouseDown(sender As Object, e As EventArgs) Handles HCPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 Then
            If MouseButtons = MouseButtons.Left Then
                If HCPrizes.Text > 0 Then HCPrizes.Text = HCPrizes.Text - 1
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If HCPrizes.Text < 6 Then HCPrizes.Text = HCPrizes.Text + 1
                Else
                    If HCPrizes.Text < 7 Then HCPrizes.Text = HCPrizes.Text + 1
                End If
            End If
        End If
    End Sub

    Private Sub AGChests_MouseDown(sender As Object, e As MouseEventArgs) Handles AGChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Then
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
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If EPReward = -1 Then EPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "EPBigKey"
                If EPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    EPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    EPBigKey.BackColor = Color.Red
                End If
            Case "EPBoss"
                If EPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    EPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    EPButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then EPCheck() Else InvEPCheck()
        CrystalCheck()
    End Sub

    Private Sub EPChests_MouseDown(sender As Object, e As EventArgs) Handles EPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
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
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Bow > 1 Then
                    EPLabel.ForeColor = Color.White
                    EPBoss.Enabled = True
                    EPChests.Text = 6
                    If Lamp = True Then
                        EPLabel.BackColor = Color.Green
                        EPChests.ForeColor = Color.White
                        EPBorder.BackColor = Color.White
                    Else
                        EPLabel.BackColor = Color.Orange
                        EPChests.ForeColor = Color.Orange
                        EPBorder.BackColor = Color.White
                    End If
                Else
                    EPLabel.BackColor = Color.Yellow
                    EPLabel.ForeColor = Color.Black
                    EPBorder.BackColor = Color.Black
                    EPBoss.Enabled = False
                    EPChests.Text = 5
                    If Lamp = True Then EPChests.ForeColor = Color.White Else EPChests.ForeColor = Color.Yellow
                End If
            Case 1, 4
                If Bow > 1 And Lamp = True And EPBigKey.Checked = True Then
                    EPLabel.ForeColor = Color.White
                    EPLabel.BackColor = Color.Green
                    EPBoss.Enabled = True
                    EPChests.ForeColor = Color.White
                    EPBorder.BackColor = Color.White
                ElseIf Bow > 1 And EPBigKey.Checked = True Then
                    EPLabel.ForeColor = Color.White
                    EPLabel.BackColor = Color.Orange
                    EPBoss.Enabled = True
                    EPChests.ForeColor = Color.White
                    EPBorder.BackColor = Color.White
                Else
                    EPLabel.ForeColor = Color.Black
                    EPLabel.BackColor = Color.Yellow
                    EPBoss.Enabled = False
                    If Lamp = True Then EPChests.ForeColor = Color.White Else EPChests.ForeColor = Color.Yellow
                    EPBorder.BackColor = Color.Black
                End If
            Case 6
                EPLabel.ForeColor = Color.White
                EPBoss.Enabled = True
                EPChests.Text = 6
                EPLabel.BackColor = Color.Green
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.White
        End Select
    End Sub

    Public Sub InvEPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Bow > 1 Then
                    EPLabel.ForeColor = Color.White
                    EPBoss.Enabled = True
                    EPChests.Text = 6
                    If Lamp = True Then
                        EPLabel.BackColor = Color.Green
                        EPChests.ForeColor = Color.White
                        EPBorder.BackColor = Color.White
                    Else
                        EPLabel.BackColor = Color.Orange
                        EPChests.ForeColor = Color.Orange
                        EPBorder.BackColor = Color.White
                    End If
                ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                    EPLabel.ForeColor = Color.White
                    EPBoss.Enabled = False
                    EPChests.Text = 5
                    EPLabel.BackColor = Color.Yellow
                    EPLabel.ForeColor = Color.Black
                    If Lamp = True Then EPChests.ForeColor = Color.White Else EPChests.ForeColor = Color.Orange
                    EPBorder.BackColor = Color.Black
                Else
                    EPLabel.BackColor = Color.Red
                    EPLabel.ForeColor = Color.Black
                    EPBorder.BackColor = Color.Black
                    EPBoss.Enabled = False
                    EPChests.Text = 0
                    EPChests.ForeColor = Color.White
                End If
            Case 1, 4
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = 1)) And Bow > 1 And EPBigKey.Checked = True Then
                    If Lamp = True Then
                        EPLabel.BackColor = Color.Green
                        EPChests.ForeColor = Color.White
                        EPBorder.BackColor = Color.White
                    Else
                        EPLabel.BackColor = Color.Orange
                        EPChests.ForeColor = Color.Orange
                        EPBorder.BackColor = Color.White
                    End If
                    EPBoss.Enabled = True
                    EPLabel.ForeColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or (Glove > 0 And Hammer = True) Or (Glove = 2 And Flippers = True)) Then
                    EPLabel.ForeColor = Color.Black
                    EPLabel.BackColor = Color.Yellow
                    EPBoss.Enabled = False
                    EPChests.ForeColor = Color.White
                    EPBorder.BackColor = Color.Black
                Else
                    EPLabel.ForeColor = Color.Black
                    EPLabel.BackColor = Color.Red
                    EPBoss.Enabled = False
                    EPChests.ForeColor = Color.White
                    EPBorder.BackColor = Color.Black
                End If
            Case 6
                EPLabel.ForeColor = Color.White
                EPBoss.Enabled = True
                EPChests.Text = 6
                EPLabel.BackColor = Color.Green
                EPChests.ForeColor = Color.White
                EPBorder.BackColor = Color.White
        End Select
    End Sub

    Private Sub DPClick(sender As Object, e As EventArgs) Handles DPMap.CheckedChanged, DPBigKey.CheckedChanged, DPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "DPMap"
                If DPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If DPReward = -1 Then DPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "DPBigKey"
                If DPBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    DPBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    DPBigKey.BackColor = Color.Red
                End If
            Case "DPBoss"
                If DPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    DPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    DPButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then DPCheck() Else InvDPCheck()
        CrystalCheck()
    End Sub
    Private Sub DPChests_MouseDown(sender As Object, e As EventArgs) Handles DPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If DPPrizes.Text > 0 Then DPPrizes.Text = DPPrizes.Text - 1
                If DPPrizes.Text = 0 Then DPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If DPPrizes.Text < 2 Then DPPrizes.Text = DPPrizes.Text + 1
                Else
                    If DPPrizes.Text < 3 Then DPPrizes.Text = DPPrizes.Text + 1
                End If
                DPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DPKeys_MouseDown(sender As Object, e As EventArgs) Handles DPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then DPKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then DPKeys.Text = 0
        If Inverted.Checked = False Then DPCheck() Else InvDPCheck()
    End Sub

    Public Sub DPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 Then
                    DPLabel.BackColor = Color.Green
                    DPLabel.ForeColor = Color.White
                    DPChests.Text = 6
                    DPChests.ForeColor = Color.White
                    DPBorder.BackColor = Color.White
                    DPBoss.Enabled = True
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPChests.Text = 5
                    DPChests.ForeColor = Color.Yellow
                    DPBorder.BackColor = Color.Black
                    DPBoss.Enabled = True
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPChests.Text = 4
                    DPChests.ForeColor = Color.Yellow
                    DPBorder.BackColor = Color.Black
                    DPBoss.Enabled = False
                Else
                    DPLabel.BackColor = Color.Red
                    DPLabel.ForeColor = Color.Black
                    DPChests.Text = 0
                    DPChests.ForeColor = Color.White
                    DPBorder.BackColor = Color.Black
                    DPBoss.Enabled = False
                End If
            Case 1, 4
                If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                    If DPKeys.Text = 1 Then DPLabel.BackColor = Color.Green Else DPLabel.BackColor = Color.Orange
                    DPLabel.ForeColor = Color.White
                    DPBoss.Enabled = True
                    DPBorder.BackColor = Color.White
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPBoss.Enabled = True
                    DPBorder.BackColor = Color.Black
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPBoss.Enabled = False
                    DPBorder.BackColor = Color.Black
                Else
                    DPLabel.BackColor = Color.Red
                    DPLabel.ForeColor = Color.Black
                    DPBoss.Enabled = False
                    DPBorder.BackColor = Color.Black
                End If
            Case 6
                DPLabel.BackColor = Color.Green
                DPLabel.ForeColor = Color.White
                DPChests.Text = 6
                DPChests.ForeColor = Color.White
                DPBorder.BackColor = Color.White
                DPBoss.Enabled = True
        End Select
    End Sub
    Public Sub InvDPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 Then
                    DPLabel.BackColor = Color.Green
                    DPLabel.ForeColor = Color.White
                    DPChests.Text = 6
                    DPChests.ForeColor = Color.White
                    DPBorder.BackColor = Color.White
                    DPBoss.Enabled = True
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Glove > 0 Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPChests.Text = 5
                    DPChests.ForeColor = Color.Yellow
                    DPBorder.BackColor = Color.Black
                    DPBoss.Enabled = True
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPChests.Text = 4
                    DPChests.ForeColor = Color.Yellow
                    DPBorder.BackColor = Color.Black
                    DPBoss.Enabled = False
                Else
                    DPLabel.BackColor = Color.Red
                    DPLabel.ForeColor = Color.Black
                    DPChests.Text = 0
                    DPChests.ForeColor = Color.White
                    DPBorder.BackColor = Color.Black
                    DPBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 And DPBigKey.Checked = True Then
                    If DPKeys.Text = 1 Then DPLabel.BackColor = Color.Green Else DPLabel.BackColor = Color.Orange
                    DPLabel.ForeColor = Color.White
                    DPBoss.Enabled = True
                    DPBorder.BackColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPBoss.Enabled = True
                    DPBorder.BackColor = Color.Black
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True Then
                    DPLabel.BackColor = Color.Yellow
                    DPLabel.ForeColor = Color.Black
                    DPBoss.Enabled = False
                    DPBorder.BackColor = Color.Black
                Else
                    DPLabel.BackColor = Color.Red
                    DPLabel.ForeColor = Color.Black
                    DPBoss.Enabled = False
                    DPBorder.BackColor = Color.Black
                End If
            Case 6
                DPLabel.BackColor = Color.Green
                DPLabel.ForeColor = Color.White
                DPChests.Text = 6
                DPChests.ForeColor = Color.White
                DPBorder.BackColor = Color.White
                DPBoss.Enabled = True
        End Select
    End Sub

    Private Sub TOHClick(sender As Object, e As EventArgs) Handles HeraMap.CheckedChanged, HeraBigKey.CheckedChanged, HeraBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "HeraMap"
                If HeraMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If TOHReward = -1 Then TOHButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "HeraBigKey"
                If HeraBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    HeraBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    HeraBigKey.BackColor = Color.Red
                End If
            Case "HeraBoss"
                If HeraBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    TOHButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    TOHButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then TOHCheck() Else InvTOHCheck()
        CrystalCheck()
    End Sub
    Private Sub TOHChests_MouseDown(sender As Object, e As EventArgs) Handles TOHChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If TOHPrizes.Text > 0 Then TOHPrizes.Text = TOHPrizes.Text - 1
                If TOHPrizes.Text = 0 Then TOHLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If TOHPrizes.Text < 2 Then TOHPrizes.Text = TOHPrizes.Text + 1
                Else
                    If TOHPrizes.Text < 3 Then TOHPrizes.Text = TOHPrizes.Text + 1
                End If
                TOHLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub HeraKeys_MouseDown(sender As Object, e As EventArgs) Handles TOHKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then TOHKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then TOHKeys.Text = 0
        If Inverted.Checked = False Then TOHCheck() Else InvTOHCheck()
    End Sub
    Public Sub TOHCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If (Glove > 0 Or Flute = True) And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) And (Lamp = True Or FireRod = True) Then
                    TOHLabel.ForeColor = Color.White
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
                    TOHChests.Text = 6
                    TOHChests.ForeColor = Color.White
                    TOHBorder.BackColor = Color.White
                ElseIf (Glove > 0 Or Flute = True) And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) Then
                    TOHLabel.BackColor = Color.Yellow
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = True
                    TOHChests.Text = 5
                    TOHChests.ForeColor = Color.Yellow
                    TOHBorder.BackColor = Color.Black
                ElseIf (Glove > 0 Or Flute = True) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                    TOHLabel.BackColor = Color.Yellow
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = False
                    TOHChests.Text = 4
                    TOHChests.ForeColor = Color.Yellow
                    TOHBorder.BackColor = Color.Black
                Else
                    TOHLabel.BackColor = Color.Red
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = False
                    TOHChests.Text = 0
                    TOHChests.ForeColor = Color.White
                    TOHBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If (Glove > 0 Or Flute = True) And Hammer = True And Hookshot = True And (Sword > 0 Or Hammer = True) And (Lamp = True Or FireRod = True) And HeraBigKey.Checked = True Then
                    TOHLabel.ForeColor = Color.White
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
                    TOHBorder.BackColor = Color.White
                ElseIf (Flute = True Or Glove > 0) And (Mirror = True Or (Hammer = True And Hookshot = True)) And HeraBigKey.Checked = True Then
                    TOHLabel.BackColor = Color.Yellow
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = False
                    TOHBorder.BackColor = Color.Black
                Else
                    TOHLabel.BackColor = Color.Red
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = False
                    TOHBorder.BackColor = Color.Black
                End If
            Case 6
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                TOHLabel.BackColor = Color.Green
                TOHChests.Text = 6
                TOHChests.ForeColor = Color.White
                TOHBorder.BackColor = Color.White
        End Select
    End Sub
    Public Sub InvTOHCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True And (Lamp = True Or FireRod = True) Then
                    TOHLabel.ForeColor = Color.White
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
                    TOHChests.Text = 6
                    TOHChests.ForeColor = Color.White
                    TOHBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True Then
                    TOHLabel.BackColor = Color.Yellow
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = True
                    TOHChests.Text = 5
                    TOHChests.ForeColor = Color.Yellow
                    TOHBorder.BackColor = Color.Black
                Else
                    TOHLabel.BackColor = Color.Red
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = False
                    TOHChests.Text = 0
                    TOHChests.ForeColor = Color.White
                    TOHBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True And (Lamp = True Or FireRod = True) And HeraBigKey.Checked = True Then
                    TOHLabel.ForeColor = Color.White
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.BackColor = Color.Green Else TOHLabel.BackColor = Color.Orange
                    TOHBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True And HeraBigKey.Checked = True Then
                    TOHLabel.BackColor = Color.Yellow
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = True
                    TOHBorder.BackColor = Color.Black
                ElseIf Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True Then
                    TOHLabel.BackColor = Color.Yellow
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = True
                    TOHBorder.BackColor = Color.Black
                Else
                    TOHLabel.BackColor = Color.Red
                    TOHLabel.ForeColor = Color.Black
                    HeraBoss.Enabled = False
                    TOHBorder.BackColor = Color.Black
                End If
            Case 6
                TOHLabel.ForeColor = Color.White
                HeraBoss.Enabled = True
                TOHLabel.BackColor = Color.Green
                TOHChests.Text = 6
                TOHChests.ForeColor = Color.White
                TOHBorder.BackColor = Color.White
        End Select
    End Sub
    Private Sub AGPrizes_MouseDown(sender As Object, e As EventArgs) Handles AGPrizes.MouseDown
        If ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Then
            If MouseButtons = MouseButtons.Left Then
                If AGPrizes.Text > 0 Then AGPrizes.Text = AGPrizes.Text - 1
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If AGPrizes.Text < 2 Then AGPrizes.Text = AGPrizes.Text + 1
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
        If Inverted.Checked = False Then AgaCheck() Else InvAgaCheck()
    End Sub

    Public Sub AgaCheck()
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
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                    AGChests.Text = 2
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                    AGChests.Text = 0
                End If
            Case 3, 5
                If Cape = True And Hammer = True And Lamp = True Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                    AGChests.Text = 2
                ElseIf Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                    AGChests.Text = 1
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                    AGChests.Text = 0
                End If
            Case 1
                If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                ElseIf Sword >= 2 Or Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Yellow
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                End If
            Case 4
                If Hammer = True And Cape = True And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                ElseIf Hammer = True Or Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Yellow
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                End If
            Case 6
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                AGLabel.BackColor = Color.Green
                AGLabel.ForeColor = Color.White
                AGBorder.BackColor = Color.White
        End Select
    End Sub
    Public Sub InvAgaCheck()
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
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If (Glove > 0 Or Flute = True) And (Sword > 0 Or Net = True) And Lamp = True Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                    AGChests.Text = 2
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                    AGChests.Text = 0
                End If
            Case 3, 5
                If (Glove > 0 Or Flute = True) And Net = True And Lamp = True Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                    AGChests.Text = 2
                ElseIf Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                    AGChests.Text = 1
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                    AGChests.Text = 0
                End If
            Case 1
                If (Glove > 0 Or Flute = True) And Sword > 0 And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                ElseIf Glove > 0 Or Flute = True Then
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Yellow
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                End If
            Case 4
                If (Glove > 0 Or Flute = True) And Net = True And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.BackColor = Color.Green
                    AGLabel.ForeColor = Color.White
                    AGBorder.BackColor = Color.White
                ElseIf Hammer = True Or Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Yellow
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                Else
                    AgaButton.Visible = False
                    AGLabel.BackColor = Color.Red
                    AGLabel.ForeColor = Color.Black
                    AGBorder.BackColor = Color.Black
                End If
            Case 6
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                AGLabel.BackColor = Color.Green
                AGLabel.ForeColor = Color.White
                AGBorder.BackColor = Color.White
        End Select
    End Sub
    Private Sub PODClick(sender As Object, e As EventArgs) Handles PODMap.CheckedChanged, PODBigKey.CheckedChanged, PODBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "PODMap"
                If PODMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If PODReward = -1 Then PODButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "PODBigKey"
                If PODBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    PODBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    PODBigKey.BackColor = Color.Red
                End If
            Case "PODBoss"
                If PODBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    PODButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    PODButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then PODCheck() Else InvPODCheck()
        CrystalCheck()
    End Sub
    Private Sub PODChests_MouseDown(sender As Object, e As EventArgs) Handles PODChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If PODPrizes.Text > 0 Then PODPrizes.Text = PODPrizes.Text - 1
                If PODPrizes.Text = 0 Then PODLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If PODPrizes.Text < 5 Then PODPrizes.Text = PODPrizes.Text + 1
                Else
                    If PODPrizes.Text < 11 Then PODPrizes.Text = PODPrizes.Text + 1
                End If
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
        If Inverted.Checked = False Then PODCheck() Else InvPODCheck()
    End Sub
    Public Sub PODCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 1 And Hammer = True Then
                    PODBoss.Enabled = True
                    PODChests.Text = 14
                    PODChests.ForeColor = Color.White
                    If Lamp = True Then
                        PODLabel.BackColor = Color.Green
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    Else
                        PODLabel.BackColor = Color.Orange
                        PODChests.ForeColor = Color.Orange
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    End If
                ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 1 Then
                    PODBoss.Enabled = False
                    PODChests.Text = 13
                    PODChests.ForeColor = Color.Yellow
                    PODLabel.BackColor = Color.Yellow
                    PODLabel.ForeColor = Color.Black
                    PODBorder.BackColor = Color.Black
                ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                    PODBoss.Enabled = False
                    PODChests.Text = 11
                    PODChests.ForeColor = Color.Yellow
                    PODLabel.BackColor = Color.Yellow
                    PODLabel.ForeColor = Color.Black
                    PODBorder.BackColor = Color.Black
                Else
                    PODChests.Text = 0
                    PODChests.ForeColor = Color.White
                    PODLabel.BackColor = Color.Red
                    PODLabel.ForeColor = Color.Black
                    PODBoss.Enabled = False
                    PODBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Pearl = True And Hammer = True And Bow > 1 And (Aganhim = True Or Glove > 1) And PODBigKey.Checked = True And PODKeys.Text >= 1 Then
                    PODBoss.Enabled = True
                    If Lamp = True And PODKeys.Text = 6 Then
                        PODLabel.BackColor = Color.Green
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    Else
                        PODLabel.BackColor = Color.Orange
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    End If
                ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                    PODLabel.BackColor = Color.Yellow
                    PODLabel.ForeColor = Color.Black
                    PODBoss.Enabled = False
                    PODBorder.BackColor = Color.Black
                Else
                    PODLabel.BackColor = Color.Red
                    PODLabel.ForeColor = Color.Black
                    PODBoss.Enabled = False
                    PODBorder.BackColor = Color.Black
                End If
            Case 6
                PODBoss.Enabled = True
                PODChests.Text = 14
                PODChests.ForeColor = Color.White
                PODLabel.BackColor = Color.Green
                PODLabel.ForeColor = Color.White
                PODBorder.BackColor = Color.White
        End Select
    End Sub
    Public Sub InvPODCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Hammer = True And Bow > 1 Then
                    PODBoss.Enabled = True
                    PODChests.Text = 14
                    PODChests.ForeColor = Color.White
                    If Lamp = True Then
                        PODLabel.BackColor = Color.Green
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    Else
                        PODLabel.BackColor = Color.Orange
                        PODChests.ForeColor = Color.Orange
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    End If
                ElseIf Flippers = True Or Hammer = True Then
                    PODBoss.Enabled = False
                    If Bow > 1 Then PODChests.Text = 13 Else PODChests.Text = 11
                    If Lamp = True Then PODChests.ForeColor = Color.White Else PODChests.ForeColor = Color.Yellow
                    PODLabel.BackColor = Color.Yellow
                    PODLabel.ForeColor = Color.Black
                    PODBorder.BackColor = Color.Black
                Else
                    PODChests.Text = 0
                    PODChests.ForeColor = Color.White
                    PODLabel.BackColor = Color.Red
                    PODLabel.ForeColor = Color.Black
                    PODBoss.Enabled = False
                    PODBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Hammer = True And Bow > 1 And PODBigKey.Checked = True And PODKeys.Text >= 1 Then
                    PODBoss.Enabled = True
                    If Lamp = True And PODKeys.Text = 6 Then
                        PODLabel.BackColor = Color.Green
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    Else
                        PODLabel.BackColor = Color.Orange
                        PODLabel.ForeColor = Color.White
                        PODBorder.BackColor = Color.White
                    End If
                ElseIf Hammer = True Or Flippers = True Then
                    PODLabel.BackColor = Color.Yellow
                    PODLabel.ForeColor = Color.Black
                    PODBoss.Enabled = False
                    PODBorder.BackColor = Color.Black
                Else
                    PODLabel.BackColor = Color.Red
                    PODLabel.ForeColor = Color.Black
                    PODBoss.Enabled = False
                    PODBorder.BackColor = Color.Black
                End If
            Case 6
                PODBoss.Enabled = True
                PODChests.Text = 14
                PODChests.ForeColor = Color.White
                PODLabel.BackColor = Color.Green
                PODLabel.ForeColor = Color.White
                PODBorder.BackColor = Color.White
        End Select
    End Sub
    Private Sub SPClick(sender As Object, e As EventArgs) Handles SPMap.CheckedChanged, SPBigKey.CheckedChanged, SPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SPMap"
                If SPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If SPReward = -1 Then SPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "SPBigKey"
                If SPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            Case "SPBoss"
                If SPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    SPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    SPButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then SPCheck() Else InvSPCheck()
        CrystalCheck()
    End Sub
    Private Sub SPChests_MouseDown(sender As Object, e As EventArgs) Handles SPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If SPPrizes.Text > 0 Then SPPrizes.Text = SPPrizes.Text - 1
                If SPPrizes.Text = 0 Then SPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If SPPrizes.Text < 6 Then SPPrizes.Text = SPPrizes.Text + 1
                Else
                    If SPPrizes.Text < 7 Then SPPrizes.Text = SPPrizes.Text + 1
                End If
                SPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPKeys_MouseDown(sender As Object, e As EventArgs) Handles SPKeys.MouseDown
        If MouseButtons = MouseButtons.Left Then SPKeys.Text = 1
        If MouseButtons = MouseButtons.Right = True Then SPKeys.Text = 0
        If Inverted.Checked = False Then SPCheck() Else InvSPCheck()
    End Sub
    Public Sub SPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.BackColor = Color.Green
                    SPLabel.ForeColor = Color.White
                    SPChests.Text = 10
                    SPChests.ForeColor = Color.White
                    SPBoss.Enabled = True
                    SPBorder.BackColor = Color.White
                ElseIf Pearl = True And Flippers = True And Mirror = True And Hammer = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.BackColor = Color.Yellow
                    SPLabel.ForeColor = Color.Black
                    SPChests.Text = 6
                    SPChests.ForeColor = Color.Yellow
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or Aganhim = True) Then
                    SPLabel.BackColor = Color.Yellow
                    SPLabel.ForeColor = Color.Black
                    SPChests.Text = 2
                    SPChests.ForeColor = Color.White
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                Else
                    SPLabel.BackColor = Color.Red
                    SPLabel.ForeColor = Color.Black
                    SPChests.Text = 0
                    SPChests.ForeColor = Color.White
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SPKeys.Text = 1 Then
                    SPLabel.BackColor = Color.Green
                    SPLabel.ForeColor = Color.White
                    SPBoss.Enabled = True
                    SPBorder.BackColor = Color.White
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                    SPLabel.BackColor = Color.Yellow
                    SPLabel.ForeColor = Color.Black
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                Else
                    SPLabel.BackColor = Color.Red
                    SPLabel.ForeColor = Color.Black
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                End If
            Case 6
                SPLabel.BackColor = Color.Green
                SPLabel.ForeColor = Color.White
                SPChests.Text = 10
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = True
                SPBorder.BackColor = Color.White
        End Select
    End Sub

    Public Sub InvSPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.BackColor = Color.Green
                    SPLabel.ForeColor = Color.White
                    SPChests.Text = 10
                    SPChests.ForeColor = Color.White
                    SPBoss.Enabled = True
                    SPBorder.BackColor = Color.White
                ElseIf Pearl = True And Flippers = True And Mirror = True And Hammer = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.BackColor = Color.Yellow
                    SPLabel.ForeColor = Color.Black
                    SPChests.Text = 6
                    SPChests.ForeColor = Color.Yellow
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or Aganhim = True) Then
                    SPLabel.BackColor = Color.Yellow
                    SPLabel.ForeColor = Color.Black
                    SPChests.Text = 2
                    SPChests.ForeColor = Color.White
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                Else
                    SPLabel.BackColor = Color.Red
                    SPLabel.ForeColor = Color.Black
                    SPChests.Text = 0
                    SPChests.ForeColor = Color.White
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SPKeys.Text = 1 Then
                    SPLabel.BackColor = Color.Green
                    SPLabel.ForeColor = Color.White
                    SPBoss.Enabled = True
                    SPBorder.BackColor = Color.White
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                    SPLabel.BackColor = Color.Yellow
                    SPLabel.ForeColor = Color.Black
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                Else
                    SPLabel.BackColor = Color.Red
                    SPLabel.ForeColor = Color.Black
                    SPBoss.Enabled = False
                    SPBorder.BackColor = Color.Black
                End If
            Case 6
                SPLabel.BackColor = Color.Green
                SPLabel.ForeColor = Color.White
                SPChests.Text = 10
                SPChests.ForeColor = Color.White
                SPBoss.Enabled = True
                SPBorder.BackColor = Color.White
        End Select
    End Sub

    Private Sub SWClick(sender As Object, e As EventArgs) Handles SWMap.CheckedChanged, SWBigKey.CheckedChanged, SWBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "SWMap"
                If SWMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If SWReward = -1 Then SWButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "SWBigKey"
                If SWBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            Case "SWBoss"
                If SWBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    SWButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    SWButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then SWCheck() Else InvSWCheck()
        CrystalCheck()
    End Sub
    Private Sub SWChests_MouseDown(sender As Object, e As EventArgs) Handles SWChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If SWPrizes.Text > 0 Then SWPrizes.Text = SWPrizes.Text - 1
                If SWPrizes.Text = 0 Then SWLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If SWPrizes.Text < 2 Then SWPrizes.Text = SWPrizes.Text + 1
                Else
                    If SWPrizes.Text < 5 Then SWPrizes.Text = SWPrizes.Text + 1
                End If
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
        If Inverted.Checked = False Then SWCheck() Else InvSWCheck()
    End Sub


    Public Sub SWCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                    SWLabel.BackColor = Color.Green
                    SWLabel.ForeColor = Color.White
                    SWChests.Text = 8
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 7
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 6
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                Else
                    SWLabel.BackColor = Color.Red
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 0
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                    SWLabel.BackColor = Color.Green
                    SWLabel.ForeColor = Color.White
                    SWChests.Text = 8
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 6
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                Else
                    SWLabel.BackColor = Color.Red
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 0
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 1
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                    If SWKeys.Text >= 2 Then SWLabel.BackColor = Color.Green Else SWLabel.BackColor = Color.Orange
                    SWLabel.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                Else
                    SWLabel.BackColor = Color.Red
                    SWLabel.ForeColor = Color.Black
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 4
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                    If SWKeys.Text >= 2 Then SWLabel.BackColor = Color.Green Else SWLabel.BackColor = Color.Orange
                    SWLabel.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                Else
                    SWLabel.BackColor = Color.Red
                    SWLabel.ForeColor = Color.Black
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 6
                SWLabel.BackColor = Color.Green
                SWLabel.ForeColor = Color.White
                SWChests.Text = 8
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = True
                SWBorder.BackColor = Color.White
        End Select
    End Sub

    Public Sub InvSWCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If FireRod = True And Sword > 0 Then
                    SWLabel.BackColor = Color.Green
                    SWLabel.ForeColor = Color.White
                    SWChests.Text = 8
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                ElseIf FireRod = True Then
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 7
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                Else
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 6
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If FireRod = True Then
                    SWLabel.BackColor = Color.Green
                    SWLabel.ForeColor = Color.White
                    SWChests.Text = 8
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                Else
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWChests.Text = 6
                    SWChests.ForeColor = Color.White
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 1
                If FireRod = True And Sword > 0 Then
                    If SWKeys.Text >= 2 Then SWLabel.BackColor = Color.Green Else SWLabel.BackColor = Color.Orange
                    SWLabel.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                Else
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 4
                If FireRod = True Then
                    If SWKeys.Text >= 2 Then SWLabel.BackColor = Color.Green Else SWLabel.BackColor = Color.Orange
                    SWLabel.ForeColor = Color.White
                    SWBoss.Enabled = True
                    SWBorder.BackColor = Color.White
                Else
                    SWLabel.BackColor = Color.Yellow
                    SWLabel.ForeColor = Color.Black
                    SWBoss.Enabled = False
                    SWBorder.BackColor = Color.Black
                End If
            Case 6
                SWLabel.BackColor = Color.Green
                SWLabel.ForeColor = Color.White
                SWChests.Text = 8
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = True
                SWBorder.BackColor = Color.White
        End Select
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Dim a As Integer = MsgBox("Are you sure you want to reset everything?", vbOKCancel)
        If a = DialogResult.OK Then
            ' Resetting all items
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
            BowButton.BackColor = Color.Black
            BoomButton.Image = noboomerang
            BoomButton.BackColor = Color.Black
            HookButton.Image = nohook
            HookButton.BackColor = Color.Black
            BombButton.Image = nobombs
            BombButton.BackColor = Color.Black
            PowderButton.Image = nopowder
            PowderButton.BackColor = Color.Black
            FireButton.Image = nofirerod
            FireButton.BackColor = Color.Black
            IceButton.Image = noicerod
            IceButton.BackColor = Color.Black
            BombosButton.Image = nobombos
            BombosButton.BackColor = Color.Black
            EtherButton.Image = noether
            EtherButton.BackColor = Color.Black
            QuakeButton.Image = noquake
            QuakeButton.BackColor = Color.Black
            LampButton.Image = nolamp
            LampButton.BackColor = Color.Black
            HammerButton.Image = nohammer
            HammerButton.BackColor = Color.Black
            FluteButton.Image = noflute
            FluteButton.BackColor = Color.Black
            NetButton.Image = nobugnet
            NetButton.BackColor = Color.Black
            BookButton.Image = nobook
            BookButton.BackColor = Color.Black
            BottleButton.Image = nobottle
            BottleButton.BackColor = Color.Black
            SomariaButton.Image = nosomaria
            SomariaButton.BackColor = Color.Black
            ByrnaButton.Image = nobyrna
            ByrnaButton.BackColor = Color.Black
            CapeButton.Image = nocape
            CapeButton.BackColor = Color.Black
            MirrorButton.Image = nomirror
            MirrorButton.BackColor = Color.Black
            BootButton.Image = noboots
            BootButton.BackColor = Color.Black
            GloveButton.Image = noglove
            GloveButton.BackColor = Color.Black
            FlipperButton.Image = noflippers
            FlipperButton.BackColor = Color.Black
            PearlButton.Image = nopearl
            PearlButton.BackColor = Color.Black
            MushButton.Image = nomushroom
            MushButton.BackColor = Color.Black
            ShovelButton.Image = noshovel
            ShovelButton.BackColor = Color.Black
            SwordButton.Image = nosword
            SwordButton.BackColor = Color.Black
            ArmorButton.Image = My.Resources.greenmail
            ShieldButton.Image = noshield
            ShieldButton.BackColor = Color.Black
            Bow = 0
            Boomerang = 0
            Hookshot = False
            Bombs = False
            Powder = False
            FireRod = False
            IceRod = False
            Bombos = False
            Ether = False
            Quake = False
            Lamp = False
            Hammer = False
            Flute = False
            Net = False
            Book = False
            Bottle = False
            BottleNumber.Text = 0
            Somaria = False
            Byrna = False
            Cape = False
            Mirror = False
            Boots = False
            Glove = 0
            Flippers = False
            Pearl = False
            Mushroom = False
            Shovel = False
            Sword = 0
            Armor = 0
            Shield = 0
            MedallionCount = 0
            ' Resetting all dungeons
            HCLabel.ForeColor = Color.Black
            HCLabel.BackColor = Color.Yellow
            HCBorder.BackColor = Color.Black
            HCKeys.Text = 0
            HCPrizes.Text = 6
            HCChests.ForeColor = Color.Yellow
            If ComboBox1.SelectedIndex = 0 Then HCChests.Text = 5 Else HCChests.Text = 8
            EPLabel.ForeColor = Color.Black
            EPLabel.BackColor = Color.Yellow
            EPBorder.BackColor = Color.Black
            EPKeys.Text = "-"
            EPPrizes.Text = 3
            EPMap.Checked = False
            EPBigKey.Checked = False
            EPBoss.Checked = False
            EPChests.ForeColor = Color.Yellow
            EPLabel2.BackColor = Color.Black
            EPButton.BackColor = Color.Black
            If ComboBox1.SelectedIndex = 0 Then
                EPChests.Text = 5
                EPReward = 0
                EPButton.Image = My.Resources.crystal
            Else
                EPChests.Text = 6
                EPReward = -1
                EPButton.Image = Nothing
            End If
            DPLabel.ForeColor = Color.Black
            DPLabel.BackColor = Color.Red
            DPBorder.BackColor = Color.Black
            DPKeys.Text = 0
            DPPrizes.Text = 2
            DPMap.Checked = False
            DPBigKey.Checked = False
            DPBoss.Checked = False
            DPChests.ForeColor = Color.White
            DPLabel2.BackColor = Color.Black
            DPButton.BackColor = Color.Black
            DPButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                DPChests.Text = 0
                DPReward = 0
                DPButton.Image = My.Resources.crystal
            Else
                DPChests.Text = 6
                DPReward = -1
                DPButton.Image = Nothing
            End If
            TOHLabel.ForeColor = Color.Black
            TOHLabel.BackColor = Color.Red
            TOHBorder.BackColor = Color.Black
            TOHKeys.Text = 0
            TOHPrizes.Text = 2
            HeraMap.Checked = False
            HeraBigKey.Checked = False
            HeraBoss.Checked = False
            TOHChests.ForeColor = Color.White
            TOHLabel2.BackColor = Color.Black
            TOHButton.BackColor = Color.Black
            TOHButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                TOHChests.Text = 0
                TOHReward = 0
                TOHButton.Image = My.Resources.crystal
            Else
                TOHChests.Text = 6
                TOHReward = -1
                TOHButton.Image = Nothing
            End If
            AGLabel.BackColor = Color.Red
            AGLabel.ForeColor = Color.Black
            AGBorder.BackColor = Color.Black
            AGKeys.Text = 0
            AGChests.Text = 2
            AgaButton.Visible = False
            Aganhim = False
            PODLabel.ForeColor = Color.Black
            PODLabel.BackColor = Color.Red
            PODBorder.BackColor = Color.Black
            PODKeys.Text = 0
            PODPrizes.Text = 5
            PODMap.Checked = False
            PODBigKey.Checked = False
            PODBoss.Checked = False
            PODChests.ForeColor = Color.White
            PODLabel2.BackColor = Color.Black
            PODButton.BackColor = Color.Black
            PODButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                PODChests.Text = 0
                PODReward = 0
                PODButton.Image = My.Resources.crystal
            Else
                PODChests.Text = 14
                PODReward = -1
                PODButton.Image = Nothing
            End If
            PODLabel2.BackColor = Color.Black
            PODButton.BackColor = Color.Black
            SPLabel.ForeColor = Color.Black
            SPLabel.BackColor = Color.Red
            SPBorder.BackColor = Color.Black
            SPKeys.Text = 0
            SPPrizes.Text = 6
            SPMap.Checked = False
            SPBigKey.Checked = False
            SPBoss.Checked = False
            SPChests.ForeColor = Color.White
            SPLabel2.BackColor = Color.Black
            SPButton.BackColor = Color.Black
            If ComboBox1.SelectedIndex = 0 Then
                SPChests.Text = 0
                SPReward = 0
                SPButton.Image = My.Resources.crystal
            Else
                SPChests.Text = 10
                SPReward = -1
                SPButton.Image = Nothing
            End If
            SPLabel2.BackColor = Color.Black
            SPButton.BackColor = Color.Black
            SWLabel.ForeColor = Color.Black
            SWLabel.BackColor = Color.Red
            SWBorder.BackColor = Color.Black
            SWKeys.Text = 0
            SWPrizes.Text = 2
            SWMap.Checked = False
            SWBigKey.Checked = False
            SWBoss.Checked = False
            SWChests.ForeColor = Color.White
            SWLabel2.BackColor = Color.Black
            SWButton.BackColor = Color.Black
            If ComboBox1.SelectedIndex = 0 Then
                SWChests.Text = 0
                SWReward = 0
                SWButton.Image = My.Resources.crystal
            Else
                SWChests.Text = 8
                SWReward = -1
                SWButton.Image = Nothing
            End If
            SWLabel2.BackColor = Color.Black
            SWButton.BackColor = Color.Black
            TTLabel.ForeColor = Color.Black
            TTLabel.BackColor = Color.Red
            TTBorder.BackColor = Color.Black
            TTKeys.Text = 0
            TTPrizes.Text = 4
            TTMap.Checked = False
            TTBigKey.Checked = False
            TTBoss.Checked = False
            TTChests.ForeColor = Color.White
            TTLabel2.BackColor = Color.Black
            TTButton.BackColor = Color.Black
            TTButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                TTChests.Text = 0
                TTReward = 0
                TTButton.Image = My.Resources.crystal
            Else
                TTChests.Text = 8
                TTReward = -1
                TTButton.Image = Nothing
            End If
            TTLabel2.BackColor = Color.Black
            TTButton.BackColor = Color.Black
            IPLabel.ForeColor = Color.Black
            IPLabel.BackColor = Color.Red
            IPBorder.BackColor = Color.Black
            IPKeys.Text = 0
            IPPrizes.Text = 3
            IPMap.Checked = False
            IPBigKey.Checked = False
            IPBoss.Checked = False
            IPChests.ForeColor = Color.White
            IPLabel2.BackColor = Color.Black
            IPButton.BackColor = Color.Black
            IPButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                IPChests.Text = 0
                IPReward = 0
                IPButton.Image = My.Resources.crystal
            Else
                IPChests.Text = 8
                IPReward = -1
                IPButton.Image = Nothing
            End If
            IPLabel2.BackColor = Color.Black
            IPButton.BackColor = Color.Black
            MMLabel.ForeColor = Color.Black
            MMLabel.BackColor = Color.Red
            MMBorder.BackColor = Color.Black
            MMKeys.Text = 0
            MMPrizes.Text = 2
            MMMap.Checked = False
            MMBigKey.Checked = False
            MMBoss.Checked = False
            MMChests.ForeColor = Color.White
            MMLabel2.BackColor = Color.Black
            MMButton.BackColor = Color.Black
            MMButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                MMChests.Text = 0
                MMReward = 0
                MMButton.Image = My.Resources.crystal
            Else
                MMChests.Text = 8
                MMReward = -1
                MMButton.Image = Nothing
            End If
            MMLabel2.BackColor = Color.Black
            MMButton.BackColor = Color.Black
            MireMedallion = 0
            MireBEQ.Image = My.Resources.whatmedallion
            TRLabel.ForeColor = Color.Black
            TRLabel.BackColor = Color.Red
            TRBorder.BackColor = Color.Black
            TRKeys.Text = 0
            TRPrizes.Text = 2
            TRMap.Checked = False
            TRBigKey.Checked = False
            TRBoss.Checked = False
            TRChests.ForeColor = Color.White
            TRLabel2.BackColor = Color.Black
            TRButton.BackColor = Color.Black
            TRButton.Image = Nothing
            If ComboBox1.SelectedIndex = 0 Then
                TRChests.Text = 0
                TRReward = 0
                TRButton.Image = My.Resources.crystal
            Else
                TRChests.Text = 12
                TRReward = -1
                TRButton.Image = Nothing
            End If
            TRLabel2.BackColor = Color.Black
            TRButton.BackColor = Color.Black
            TurtleMedallion = 0
            TurtleBEQ.Image = My.Resources.whatmedallion
            GTLabel.ForeColor = Color.Black
            GTLabel.BackColor = Color.Red
            GTBorder.BackColor = Color.Black
            GTKeys.Text = 0
            GTBigKey.Checked = False
            GTChests.ForeColor = Color.White
            GTChests.Text = 27
            ' Resetting all Sphere 1 locations
            LW1.Checked = False
            LW2.Checked = False
            LW7.Checked = False
            LW8.Checked = False
            LW9.Checked = False
            LW10.Checked = False
            LW11.Checked = False
            LW13.Checked = False
            LW17.Checked = False
            LW32.Checked = False
            LW36.Checked = False
            ' Resetting all scoutable items
            AgaTree = 0
            Button1.Image = My.Resources.chestmaybesmall
            Library = 0
            Button2.Image = My.Resources.chestmaybesmall
            SpecRock = 0
            Button4.Image = My.Resources.chestmaybesmall
            EtherTab = 0
            Button5.Image = My.Resources.chestmaybesmall
            Floating = 0
            Button6.Image = My.Resources.chestmaybesmall
            DPLedge = 0
            Button7.Image = My.Resources.chestmaybesmall
            BombosTab = 0
            Button8.Image = My.Resources.chestmaybesmall
            ZoraLedge = 0
            Button9.Image = My.Resources.chestmaybesmall
            LakeIsle = 0
            Button10.Image = My.Resources.chestmaybesmall
            Pedestal = 0
            Button11.Image = My.Resources.chestmaybesmall
            Bumper = 0
            Button12.Image = My.Resources.chestmaybesmall
            ' Resetting all dungeons and overworld locations
            If Inverted.Checked = False Then
                HCCheck()
                EPCheck()
                DPCheck()
                AgaCheck()
                PODCheck()
                SPCheck()
                SWCheck()
                TTCheck()
                IPCheck()
                MMCheck()
                TRCheck()
                GTCheck()
                LWCheck()
                DWCheck()
            Else
                InvHCCheck()
                InvEPCheck()
                InvDPCheck()
                InvTOHCheck()
                InvAgaCheck()
                InvPODCheck()
                InvSPCheck()
                InvSWCheck()
                InvTTCheck()
                InvIPCheck()
                InvMMCheck()
                InvTRCheck()
                InvLWCheck()
                InvDWCheck()
                GTCheck()
            End If
            CrystalCheck()
        End If
    End Sub

    Private Sub DW15Boots_CheckedChanged(sender As Object, e As EventArgs) Handles DW15Boots.CheckedChanged
        If DW15Boots.Checked = True Then DW15Boots.BackColor = Color.FromArgb(64, 64, 64) Else DW15Boots.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub MagicButton_Click(sender As Object, e As MouseEventArgs) Handles MagicButton.MouseDown

    End Sub

    Private Sub AGPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles AGPrizes.MouseDown

    End Sub

    Private Sub TurtleBEQ_Click(sender As Object, e As MouseEventArgs) Handles TurtleBEQ.MouseDown

    End Sub

    Private Sub MireBEQ_Click(sender As Object, e As MouseEventArgs) Handles MireBEQ.MouseDown

    End Sub

    Private Sub GTChests_MouseDown(sender As Object, e As MouseEventArgs) Handles GTChests.MouseDown

    End Sub

    Private Sub TRChests_MouseDown(sender As Object, e As MouseEventArgs) Handles TRChests.MouseDown

    End Sub

    Private Sub MMChests_MouseDown(sender As Object, e As MouseEventArgs) Handles MMChests.MouseDown

    End Sub

    Private Sub IPChests_MouseDown(sender As Object, e As MouseEventArgs) Handles IPChests.MouseDown

    End Sub

    Private Sub TTChests_MouseDown(sender As Object, e As MouseEventArgs) Handles TTChests.MouseDown

    End Sub

    Private Sub SWChests_MouseDown(sender As Object, e As MouseEventArgs) Handles SWChests.MouseDown

    End Sub

    Private Sub SPChests_MouseDown(sender As Object, e As MouseEventArgs) Handles SPChests.MouseDown

    End Sub

    Private Sub PODChests_MouseDown(sender As Object, e As MouseEventArgs) Handles PODChests.MouseDown

    End Sub

    Private Sub TOHChests_MouseDown(sender As Object, e As MouseEventArgs) Handles TOHChests.MouseDown

    End Sub

    Private Sub DPChests_MouseDown(sender As Object, e As MouseEventArgs) Handles DPChests.MouseDown

    End Sub

    Private Sub EPChests_MouseDown(sender As Object, e As MouseEventArgs) Handles EPChests.MouseDown

    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As MouseEventArgs) Handles HCChests.MouseDown

    End Sub

    Private Sub CrystalClick(sender As Object, e As MouseEventArgs) Handles TTButton.MouseDown, TRButton.MouseDown, TOHButton.MouseDown, SWButton.MouseDown, SPButton.MouseDown, PODButton.MouseDown, MMButton.MouseDown, IPButton.MouseDown, EPButton.MouseDown, DPButton.MouseDown

    End Sub

    Private Sub ShovelButton_Click(sender As Object, e As MouseEventArgs) Handles ShovelButton.MouseDown

    End Sub

    Private Sub MushButton_Click(sender As Object, e As MouseEventArgs) Handles MushButton.MouseDown

    End Sub

    Private Sub PearlButton_Click(sender As Object, e As MouseEventArgs) Handles PearlButton.MouseDown

    End Sub

    Private Sub FlipperButton_Click(sender As Object, e As MouseEventArgs) Handles FlipperButton.MouseDown

    End Sub

    Private Sub GloveButton_Click(sender As Object, e As MouseEventArgs) Handles GloveButton.MouseDown

    End Sub

    Private Sub BootButton_Click(sender As Object, e As MouseEventArgs) Handles BootButton.MouseDown

    End Sub

    Private Sub AgaButton_Click(sender As Object, e As MouseEventArgs) Handles AgaButton.MouseDown

    End Sub

    Private Sub MirrorButton_Click(sender As Object, e As MouseEventArgs) Handles MirrorButton.MouseDown

    End Sub

    Private Sub CapeButton_Click(sender As Object, e As MouseEventArgs) Handles CapeButton.MouseDown

    End Sub

    Private Sub ByrnaButton_Click(sender As Object, e As MouseEventArgs) Handles ByrnaButton.MouseDown

    End Sub

    Private Sub SomariaButton_Click(sender As Object, e As MouseEventArgs) Handles SomariaButton.MouseDown

    End Sub

    Private Sub BottleButton_Click(sender As Object, e As MouseEventArgs) Handles BottleNumber.MouseDown, BottleButton.MouseDown

    End Sub

    Private Sub ShieldButton_Click(sender As Object, e As MouseEventArgs) Handles ShieldButton.MouseDown

    End Sub

    Private Sub BookButton_Click(sender As Object, e As MouseEventArgs) Handles BookButton.MouseDown

    End Sub

    Private Sub NetButton_Click(sender As Object, e As MouseEventArgs) Handles NetButton.MouseDown

    End Sub

    Private Sub FluteButton_Click(sender As Object, e As MouseEventArgs) Handles FluteButton.MouseDown

    End Sub

    Private Sub HammerButton_Click(sender As Object, e As MouseEventArgs) Handles HammerButton.MouseDown

    End Sub

    Private Sub LampButton_Click(sender As Object, e As MouseEventArgs) Handles LampButton.MouseDown

    End Sub

    Private Sub ArmorButton_Click(sender As Object, e As MouseEventArgs) Handles ArmorButton.MouseDown

    End Sub

    Private Sub QuakeButton_Click(sender As Object, e As MouseEventArgs) Handles QuakeButton.MouseDown

    End Sub

    Private Sub EtherButton_Click(sender As Object, e As MouseEventArgs) Handles EtherButton.MouseDown

    End Sub

    Private Sub BombosButton_Click(sender As Object, e As MouseEventArgs) Handles BombosButton.MouseDown

    End Sub

    Private Sub IceButton_Click(sender As Object, e As MouseEventArgs) Handles IceButton.MouseDown

    End Sub

    Private Sub FireButton_Click(sender As Object, e As MouseEventArgs) Handles FireButton.MouseDown

    End Sub

    Private Sub SwordButton_Click(sender As Object, e As MouseEventArgs) Handles SwordButton.MouseDown

    End Sub

    Private Sub PowderButton_Click(sender As Object, e As MouseEventArgs) Handles PowderButton.MouseDown

    End Sub

    Private Sub BombButton_Click(sender As Object, e As MouseEventArgs) Handles BombButton.MouseDown

    End Sub

    Private Sub HookButton_Click(sender As Object, e As MouseEventArgs) Handles HookButton.MouseDown

    End Sub

    Private Sub BoomButton_Click(sender As Object, e As MouseEventArgs) Handles BoomButton.MouseDown

    End Sub

    Private Sub BowButton_Click(sender As Object, e As MouseEventArgs) Handles BowButton.MouseDown

    End Sub

    Private Sub MMPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles MMPrizes.MouseDown

    End Sub

    Private Sub IPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles IPPrizes.MouseDown

    End Sub

    Private Sub TTPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TTPrizes.MouseDown

    End Sub

    Private Sub SWPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles SWPrizes.MouseDown

    End Sub

    Private Sub TRPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TRPrizes.MouseDown

    End Sub

    Private Sub SPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles SPPrizes.MouseDown

    End Sub

    Private Sub PODPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles PODPrizes.MouseDown

    End Sub

    Private Sub TOHPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles TOHPrizes.MouseDown

    End Sub

    Private Sub DPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles DPPrizes.MouseDown

    End Sub

    Private Sub EPPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles EPPrizes.MouseDown

    End Sub

    Private Sub HCPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles HCPrizes.MouseDown

    End Sub

    Private Sub MMKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles MMKeys.MouseDown

    End Sub

    Private Sub IPKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles IPKeys.MouseDown

    End Sub

    Private Sub TTKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles TTKeys.MouseDown

    End Sub

    Private Sub SWKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles SWKeys.MouseDown

    End Sub

    Private Sub TRKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles TRKeys.MouseDown

    End Sub

    Private Sub AGKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles AGKeys.MouseDown

    End Sub

    Private Sub GTKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles GTKeys.MouseDown

    End Sub

    Private Sub SPKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles SPKeys.MouseDown

    End Sub

    Private Sub PODKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles PODKeys.MouseDown

    End Sub

    Private Sub HeraKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles TOHKeys.MouseDown

    End Sub

    Private Sub DPKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles DPKeys.MouseDown

    End Sub

    Private Sub HCKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles HCKeys.MouseDown

    End Sub

    Private Sub MagicButton_Click(sender As Object, e As EventArgs) Handles MagicButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Magic = (Magic + 1) Mod 3 Else Magic = (Magic + 2) Mod 3
        Select Case Magic
            Case 0
                MagicButton.Image = My.Resources.magicbottle
            Case 1
                MagicButton.Image = My.Resources.halfmagic
            Case 2
                MagicButton.Image = My.Resources.quartermagic
        End Select
        If Inverted.Checked = False Then
            TRCheck()
            DWCheck()
        Else
            InvTRCheck()
            InvDWCheck()
        End If
    End Sub

    Private Sub Inverted_CheckedChanged(sender As Object, e As EventArgs) Handles Inverted.CheckedChanged
        If Inverted.Checked = False Then
            HCCheck()
            EPCheck()
            DPCheck()
            AgaCheck()
            PODCheck()
            SPCheck()
            SWCheck()
            TTCheck()
            IPCheck()
            MMCheck()
            TRCheck()
            GTCheck()
            LWCheck()
            DWCheck()
        Else
            InvHCCheck()
            InvEPCheck()
            InvDPCheck()
            InvTOHCheck()
            InvAgaCheck()
            InvPODCheck()
            InvSPCheck()
            InvSWCheck()
            InvTTCheck()
            InvIPCheck()
            InvMMCheck()
            InvTRCheck()
            InvLWCheck()
            InvDWCheck()
            GTCheck()
        End If
    End Sub

    Private Sub TTClick(sender As Object, e As EventArgs) Handles TTMap.CheckedChanged, TTBigKey.CheckedChanged, TTBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TTMap"
                If TTMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If TTReward = -1 Then TTButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "TTBigKey"
                If TTBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    TTBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    TTBigKey.BackColor = Color.Red
                End If
            Case "TTBoss"
                If TTBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    TTButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    TTButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then TTCheck() Else InvTTCheck()
        CrystalCheck()
    End Sub

    Private Sub TTPrizes_MouseDown(sender As Object, e As EventArgs) Handles TTPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If TTPrizes.Text > 0 Then TTPrizes.Text = TTPrizes.Text - 1
                If TTPrizes.Text = 0 Then TTLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If TTPrizes.Text < 4 Then TTPrizes.Text = TTPrizes.Text + 1
                Else
                    If TTPrizes.Text < 5 Then TTPrizes.Text = TTPrizes.Text + 1
                End If
                TTLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TTChests_MouseDown(sender As Object, e As EventArgs) Handles TTChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If Inverted.Checked = False Then TTCheck() Else InvTTCheck()
    End Sub

    Public Sub TTCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    TTLabel.BackColor = Color.Green
                    TTLabel.ForeColor = Color.White
                    If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                    TTChests.ForeColor = Color.White
                    TTBoss.Enabled = True
                    TTBorder.BackColor = Color.White
                Else
                    TTLabel.BackColor = Color.Red
                    TTLabel.ForeColor = Color.Black
                    TTChests.Text = 0
                    TTChests.ForeColor = Color.White
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If Pearl = True And TTBigKey.Checked = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    If TTKeys.Text = 1 Then TTLabel.BackColor = Color.Green Else TTLabel.BackColor = Color.Orange
                    TTLabel.ForeColor = Color.White
                    TTBoss.Enabled = True
                    TTBorder.BackColor = Color.White
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    TTLabel.BackColor = Color.Yellow
                    TTLabel.ForeColor = Color.Black
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                Else
                    TTLabel.BackColor = Color.Red
                    TTLabel.ForeColor = Color.Black
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                End If
            Case 6
                TTLabel.BackColor = Color.Green
                TTLabel.ForeColor = Color.White
                If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.White
        End Select
    End Sub
    Public Sub InvTTCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If Sword > 0 Or Hammer = True Or Somaria = True Or Byrna = True Then
                    TTLabel.BackColor = Color.Green
                    TTLabel.ForeColor = Color.White
                    If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                    TTChests.ForeColor = Color.White
                    TTBoss.Enabled = True
                    TTBorder.BackColor = Color.White
                Else
                    TTLabel.BackColor = Color.Yellow
                    TTLabel.ForeColor = Color.Black
                    TTChests.Text = 6
                    TTChests.ForeColor = Color.White
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If Hammer = True Or Somaria = True Or Byrna = True Then
                    TTLabel.BackColor = Color.Green
                    TTLabel.ForeColor = Color.White
                    If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                    TTChests.ForeColor = Color.White
                    TTBoss.Enabled = True
                    TTBorder.BackColor = Color.White
                Else
                    TTLabel.BackColor = Color.Yellow
                    TTLabel.ForeColor = Color.Black
                    TTChests.Text = 6
                    TTChests.ForeColor = Color.White
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                End If
            Case 1
                If (Sword > 0 Or Hammer = True Or Somaria = True Or Byrna = True) And TTBigKey.Checked = True Then
                    If TTKeys.Text = 1 Then TTLabel.BackColor = Color.Green Else TTLabel.BackColor = Color.Orange
                    TTLabel.ForeColor = Color.White
                    TTBoss.Enabled = True
                    TTBorder.BackColor = Color.White
                Else
                    TTLabel.BackColor = Color.Yellow
                    TTLabel.ForeColor = Color.Black
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                End If
            Case 4
                If (Hammer = True Or Somaria = True Or Byrna = True) And TTBigKey.Checked = True Then
                    If TTKeys.Text = 1 Then TTLabel.BackColor = Color.Green Else TTLabel.BackColor = Color.Orange
                    TTLabel.ForeColor = Color.White
                    TTBoss.Enabled = True
                    TTBorder.BackColor = Color.White
                Else
                    TTLabel.BackColor = Color.Yellow
                    TTLabel.ForeColor = Color.Black
                    TTBoss.Enabled = False
                    TTBorder.BackColor = Color.Black
                End If
            Case 6
                TTLabel.BackColor = Color.Green
                TTLabel.ForeColor = Color.White
                If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = True
                TTBorder.BackColor = Color.White
        End Select
    End Sub
    Private Sub IPClick(sender As Object, e As EventArgs) Handles IPMap.CheckedChanged, IPBigKey.CheckedChanged, IPBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "IPMap"
                If IPMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If IPReward = -1 Then IPButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "IPBigKey"
                If IPBigKey.Checked = True Then DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall Else DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            Case "IPBoss"
                If IPBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    IPButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    IPButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then IPCheck() Else InvIPCheck()
        CrystalCheck()
    End Sub
    Private Sub IPPrizes_MouseDown(sender As Object, e As EventArgs) Handles IPPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If IPPrizes.Text > 0 Then IPPrizes.Text = IPPrizes.Text - 1
                If IPPrizes.Text = 0 Then IPLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If IPPrizes.Text < 3 Then IPPrizes.Text = IPPrizes.Text + 1
                Else
                    If IPPrizes.Text < 5 Then IPPrizes.Text = IPPrizes.Text + 1
                End If
                IPLabel2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPChests_MouseDown(sender As Object, e As EventArgs) Handles IPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
            If IPKeys.Text < 2 Then IPKeys.Text = IPKeys.Text + 1
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If IPKeys.Text > 0 Then IPKeys.Text = IPKeys.Text - 1
        End If
        If Inverted.Checked = False Then IPCheck() Else InvIPCheck()
    End Sub

    Public Sub IPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True Then
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
                    IPBorder.BackColor = Color.White
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 8
                    IPChests.ForeColor = Color.Yellow
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 7
                    IPChests.ForeColor = Color.Yellow
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 0
                    IPChests.ForeColor = Color.White
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True Then
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
                    IPBorder.BackColor = Color.White
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) And Hammer = True Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 8
                    IPChests.ForeColor = Color.Yellow
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf Pearl = True And Glove = 2 And FireRod = True Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 7
                    IPChests.ForeColor = Color.Yellow
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 0
                    IPChests.ForeColor = Color.White
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 1
                If Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Orange
                    IPLabel.ForeColor = Color.White
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.White
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 4
                If Pearl = True And Glove = 2 And (FireRod = True And Bombos = True) And Hammer = True And Hookshot = True Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Orange
                    IPLabel.ForeColor = Color.White
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.White
                ElseIf Pearl = True And Glove = 2 And (FireRod = True And Bombos = True) And Hammer = True Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf Pearl = True And Glove = 2 And FireRod = True Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 6
                IPLabel.ForeColor = Color.White
                IPChests.Text = 8
                IPBoss.Enabled = True
                IPLabel.BackColor = Color.Green
                IPChests.ForeColor = Color.White
                IPBorder.BackColor = Color.White
        End Select
    End Sub
    Public Sub InvIPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True And Glove > 0 Then
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
                    IPBorder.BackColor = Color.White
                ElseIf (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Glove > 0 Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 8
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf (FireRod = True Or (Bombos = True And Sword > 0)) Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 5
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 0
                    IPChests.ForeColor = Color.White
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If (FireRod = True Or Bombos = True) And Hammer = True And Hookshot = True And Glove > 0 Then
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
                    IPBorder.BackColor = Color.White
                ElseIf (FireRod = True Or Bombos = True) And Hammer = True And Glove > 0 Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 8
                    IPChests.ForeColor = Color.Yellow
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf FireRod = True Or (Bombos = True And Hammer = True) Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 5
                    IPChests.ForeColor = Color.Yellow
                    If Flippers = True Then IPChests.ForeColor = Color.White Else IPChests.ForeColor = Color.Orange
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPChests.Text = 0
                    IPChests.ForeColor = Color.White
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 1
                If (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True And Glove > 0 Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Orange
                    IPLabel.ForeColor = Color.White
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.White
                ElseIf (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Glove > 0 Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf FireRod = True Or (Bombos = True And Sword > 0) Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 4
                If (FireRod = True Or Bombos = True) And Hammer = True And Hookshot = True And Glove > 0 Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.BackColor = Color.Green Else IPLabel.BackColor = Color.Orange
                    IPLabel.ForeColor = Color.White
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.White
                ElseIf (FireRod = True Or Bombos = True) And Hammer = True And Glove > 0 Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = True
                    IPBorder.BackColor = Color.Black
                ElseIf FireRod = True Or (Bombos = True And Hammer = True) Then
                    IPLabel.BackColor = Color.Yellow
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                Else
                    IPLabel.BackColor = Color.Red
                    IPLabel.ForeColor = Color.Black
                    IPBoss.Enabled = False
                    IPBorder.BackColor = Color.Black
                End If
            Case 6
                IPLabel.ForeColor = Color.White
                IPChests.Text = 8
                IPBoss.Enabled = True
                IPLabel.BackColor = Color.Green
                IPChests.ForeColor = Color.White
                IPBorder.BackColor = Color.White
        End Select
    End Sub
    Private Sub MMClick(sender As Object, e As EventArgs) Handles MMMap.CheckedChanged, MMBigKey.CheckedChanged, MMBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "MMMap"
                If MMMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If MMReward = -1 Then MMButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "MMBigKey"
                If MMBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    MMBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    MMBigKey.BackColor = Color.Red
                End If
            Case "MMBoss"
                If MMBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    MMButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    MMButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then MMCheck() Else InvMMCheck()
        CrystalCheck()
    End Sub
    Private Sub MMPrizes_MouseDown(sender As Object, e As EventArgs) Handles MMPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If MMPrizes.Text > 0 Then MMPrizes.Text = MMPrizes.Text - 1
                If MMPrizes.Text = 0 Then MMLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If MMPrizes.Text < 2 Then MMPrizes.Text = MMPrizes.Text + 1
                Else
                    If MMPrizes.Text < 5 Then MMPrizes.Text = MMPrizes.Text + 1
                End If
                MMLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMChests_MouseDown(sender As Object, e As EventArgs) Handles MMChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True Then
                    MMBoss.Enabled = True
                    MMChests.Text = 8
                    MMLabel.ForeColor = Color.White
                    MMBorder.BackColor = Color.White
                    If Lamp = True Then
                        MMLabel.BackColor = Color.Green
                        MMChests.ForeColor = Color.White
                    Else
                        MMLabel.BackColor = Color.Orange
                        MMChests.ForeColor = Color.Orange
                    End If
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.BackColor = Color.Yellow
                    MMBorder.BackColor = Color.Black
                    If Somaria = True Then
                        MMBoss.Enabled = True
                        MMChests.Text = 8
                        MMChests.ForeColor = Color.Yellow
                    Else
                        MMBoss.Enabled = False
                        MMChests.Text = 7
                        MMChests.ForeColor = Color.Yellow
                    End If
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 7
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 0
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True Then
                    MMBoss.Enabled = True
                    MMChests.Text = 8
                    MMLabel.ForeColor = Color.White
                    MMBorder.BackColor = Color.White
                    If Lamp = True Then
                        MMLabel.BackColor = Color.Green
                        MMChests.ForeColor = Color.White
                    Else
                        MMLabel.BackColor = Color.Orange
                        MMChests.ForeColor = Color.Orange
                    End If
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.ForeColor = Color.Black
                    MMLabel.BackColor = Color.Yellow
                    MMBorder.BackColor = Color.Black
                    If Somaria = True Then
                        MMBoss.Enabled = True
                        MMChests.Text = 8
                        MMChests.ForeColor = Color.Yellow
                    Else
                        MMBoss.Enabled = False
                        MMChests.Text = 7
                        MMChests.ForeColor = Color.Yellow
                    End If
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 7
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 0
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 1
                If Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                    MMLabel.ForeColor = Color.White
                    MMBoss.Enabled = True
                    MMBorder.BackColor = Color.White
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 4
                If Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                    MMLabel.ForeColor = Color.White
                    MMBoss.Enabled = True
                    MMBorder.BackColor = Color.White
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 6
                MMBoss.Enabled = True
                MMChests.Text = 8
                MMLabel.ForeColor = Color.White
                MMBorder.BackColor = Color.White
                MMLabel.BackColor = Color.Green
                MMChests.ForeColor = Color.White
        End Select
    End Sub

    Public Sub InvMMCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMBoss.Enabled = True
                    MMChests.Text = 8
                    MMLabel.ForeColor = Color.White
                    MMBorder.BackColor = Color.White
                    If Lamp = True Then
                        MMLabel.BackColor = Color.Green
                        MMChests.ForeColor = Color.White
                    Else
                        MMLabel.BackColor = Color.Orange
                        MMChests.ForeColor = Color.Orange
                    End If
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Sword > 0 And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.BackColor = Color.Yellow
                    MMBorder.BackColor = Color.Black
                    If Somaria = True Then
                        MMBoss.Enabled = True
                        MMChests.Text = 8
                        MMChests.ForeColor = Color.Yellow
                    Else
                        MMBoss.Enabled = False
                        MMChests.Text = 7
                        MMChests.ForeColor = Color.Yellow
                    End If
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True) Or (MedallionCount > 0 And MireMedallion = 0)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 7
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 0
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 3, 5
                If (Flute = True Or (Pearl = True And Glove = 1 And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMBoss.Enabled = True
                    MMChests.Text = 8
                    MMLabel.ForeColor = Color.White
                    MMBorder.BackColor = Color.White
                    If Lamp = True Then
                        MMLabel.BackColor = Color.Green
                        MMChests.ForeColor = Color.White
                    Else
                        MMLabel.BackColor = Color.Orange
                        MMChests.ForeColor = Color.Orange
                    End If
                ElseIf (Flute = True Or (Pearl = True And Glove = 1 And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.ForeColor = Color.Black
                    MMLabel.BackColor = Color.Yellow
                    MMBorder.BackColor = Color.Black
                    If Somaria = True Then
                        MMBoss.Enabled = True
                        MMChests.Text = 8
                        MMChests.ForeColor = Color.Yellow
                    Else
                        MMBoss.Enabled = False
                        MMChests.Text = 7
                        MMChests.ForeColor = Color.Yellow
                    End If
                ElseIf (Flute = True Or (Pearl = True And Glove = 1 And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 7
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMChests.Text = 0
                    MMChests.ForeColor = Color.White
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 1
                If (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                    MMLabel.ForeColor = Color.White
                    MMBoss.Enabled = True
                    MMBorder.BackColor = Color.White
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Sword > 0 And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    If Somaria = True And MMBigKey.Checked = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True) Or (MedallionCount > 0 And MireMedallion = 0)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 4
                If (Flute = True Or (Pearl = True And Glove > 0) And Mirror = True) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.BackColor = Color.Green Else MMLabel.BackColor = Color.Orange
                    MMLabel.ForeColor = Color.White
                    MMBoss.Enabled = True
                    MMBorder.BackColor = Color.White
                ElseIf (Flute = True Or (Pearl = True And Glove > 0) And Mirror = True) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And MedallionCount > 0 And MireMedallion = 0 And MMBigKey.Checked = True Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    If Somaria = True And MMBigKey.Checked = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                ElseIf (Flute = True Or (Pearl = True And Glove > 0) And Mirror = True) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And ((MedallionCount > 0 And MireMedallion = 0) Or MireMedallion = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.BackColor = Color.Yellow
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                Else
                    MMLabel.BackColor = Color.Red
                    MMLabel.ForeColor = Color.Black
                    MMBoss.Enabled = False
                    MMBorder.BackColor = Color.Black
                End If
            Case 6
                MMBoss.Enabled = True
                MMChests.Text = 8
                MMLabel.ForeColor = Color.White
                MMBorder.BackColor = Color.White
                MMLabel.BackColor = Color.Green
                MMChests.ForeColor = Color.White
        End Select
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
        If Inverted.Checked = False Then MMCheck() Else InvMMCheck()
    End Sub
    Private Sub TRClick(sender As Object, e As EventArgs) Handles TRMap.CheckedChanged, TRBigKey.CheckedChanged, TRBoss.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case "TRMap"
                If TRMap.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.mapsmall
                    If TRReward = -1 Then TRButton.Image = My.Resources.map
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nomapsmall
                End If
            Case "TRBigKey"
                If TRBigKey.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
                    TRBigKey.BackColor = Color.WhiteSmoke
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
                    TRBigKey.BackColor = Color.Red
                End If
            Case "TRBoss"
                If TRBoss.Checked = True Then
                    DirectCast(sender, CheckBox).Image = My.Resources.bossdeadsmall
                    TRButton.BackColor = Color.Green
                Else
                    DirectCast(sender, CheckBox).Image = My.Resources.bosssmall
                    TRButton.BackColor = Color.Black
                End If
        End Select
        If Inverted.Checked = False Then TRCheck() Else InvTRCheck()
        CrystalCheck()
    End Sub
    Private Sub TRPrizes_MouseDown(sender As Object, e As EventArgs) Handles TRPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If TRPrizes.Text > 0 Then TRPrizes.Text = TRPrizes.Text - 1
                If TRPrizes.Text = 0 Then TRLabel2.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If TRPrizes.Text < 5 Then TRPrizes.Text = TRPrizes.Text + 1
                Else
                    If TRPrizes.Text < 9 Then TRPrizes.Text = TRPrizes.Text + 1
                End If
                TRLabel2.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRChests_MouseDown(sender As Object, e As EventArgs) Handles TRChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
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
        If Inverted.Checked = False Then TRCheck() Else InvTRCheck()
    End Sub
    Public Sub TRCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                    TRAccess = True
                    TRChests.Text = 12
                    If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) Then
                        TRLabel.BackColor = Color.Green
                        TRChests.ForeColor = Color.White
                    Else
                        TRLabel.BackColor = Color.Orange
                        TRChests.ForeColor = Color.Orange
                    End If
                    TRLabel.ForeColor = Color.White
                    TRBorder.BackColor = Color.White
                    TRBoss.Enabled = True
                    If Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.WhiteSmoke
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And MedallionCount > 0 And TurtleMedallion = 0 Then
                    TRAccess = True
                    TRLabel.BackColor = Color.Yellow
                    TRLabel.ForeColor = Color.Black
                    TRBorder.BackColor = Color.Black
                    If FireRod = True And IceRod = True Then
                        TRChests.Text = 12
                        TRChests.ForeColor = Color.Yellow
                        TRBoss.Enabled = True
                    ElseIf FireRod = True Then
                        TRChests.Text = 11
                        TRChests.ForeColor = Color.Yellow
                        TRBoss.Enabled = False
                    Else
                        TRChests.Text = 9
                        TRChests.ForeColor = Color.Yellow
                        TRBoss.Enabled = False
                    End If
                    If Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.Yellow
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And FireRod = True Then
                    TRAccess = True
                    TRChests.Text = 11
                    If Lamp = True Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                    TRLabel.BackColor = Color.Yellow
                    TRLabel.ForeColor = Color.Black
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                    If Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.WhiteSmoke
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                    TRAccess = True
                    TRChests.Text = 9
                    TRChests.ForeColor = Color.Yellow
                    TRLabel.BackColor = Color.Yellow
                    TRLabel.ForeColor = Color.Black
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                    If Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.Yellow
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                Else
                    TRAccess = False
                    TRLabel.BackColor = Color.Red
                    TRLabel.ForeColor = Color.Black
                    TRChests.Text = 0
                    TRChests.ForeColor = Color.White
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                    LW45.Enabled = True
                    LW45.Checked = False
                    LW45.BackColor = Color.Red
                End If
            Case 1, 4
                If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TRBigKey.Checked = True And TRKeys.Text >= 3 Then
                    TRAccess = True
                    If Lamp = True And TRKeys.Text = 4 And (Shield = 3 Or Byrna = True Or Cape = True) Then
                        TRLabel.BackColor = Color.Green
                        TRLabel.ForeColor = Color.White
                    ElseIf TRKeys.Text = 4 Then
                        TRLabel.BackColor = Color.Orange
                        TRLabel.ForeColor = Color.White
                    ElseIf TRKeys.Text = 3 Then
                        TRLabel.BackColor = Color.Yellow
                        TRLabel.ForeColor = Color.Black
                    End If
                    TRBoss.Enabled = True
                    TRBorder.BackColor = Color.White
                    If Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.WhiteSmoke
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And TurtleMedallion = 0 And MedallionCount > 0 Then
                    TRAccess = True
                    TRLabel.BackColor = Color.Yellow
                    TRLabel.ForeColor = Color.Black
                    TRBorder.BackColor = Color.Black
                    If FireRod = True And IceRod = True Then TRBoss.Enabled = True Else TRBoss.Enabled = False
                    If TRKeys.Text >= 2 And Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.Yellow
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                    TRAccess = True
                    TRLabel.BackColor = Color.Yellow
                    TRLabel.ForeColor = Color.Black
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                    If TRKeys.Text >= 2 And Mirror = True Then
                        LW45.Enabled = True
                        LW45.BackColor = Color.WhiteSmoke
                    Else
                        LW45.Enabled = True
                        LW45.Checked = False
                        LW45.BackColor = Color.Red
                    End If
                Else
                    TRAccess = False
                    TRLabel.BackColor = Color.Red
                    TRLabel.ForeColor = Color.Black
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                    LW45.Enabled = True
                    LW45.Checked = False
                    LW45.BackColor = Color.Red
                End If
            Case 6
                TRAccess = True
                TRChests.Text = 12
                TRLabel.BackColor = Color.Green
                TRChests.ForeColor = Color.White
                TRLabel.ForeColor = Color.White
                TRBorder.BackColor = Color.White
                TRBoss.Enabled = True
        End Select
        If LW45.Checked = True Then LW45.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Public Sub InvTRCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If ((Glove > 0 Or Flute = True) And (Sword > 0 And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True))) Or (Pearl = True And (Hookshot = True Or Hammer = True) And Mirror = True)) Then TRAccess = True Else TRAccess = False
                If TRAccess = True Then
                    If Somaria = True And FireRod = True And IceRod = True And (Hammer = True Or Sword > 0) Then
                        TRChests.Text = 12
                        If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) Then
                            TRLabel.BackColor = Color.Green
                            TRChests.ForeColor = Color.White
                        Else
                            TRLabel.BackColor = Color.Orange
                            TRChests.ForeColor = Color.Orange
                        End If
                        TRLabel.ForeColor = Color.White
                        TRBorder.BackColor = Color.White
                        TRBoss.Enabled = True
                    ElseIf Somaria = True And FireRod = True Then
                        TRChests.Text = 11
                        TRLabel.BackColor = Color.Yellow
                        If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                        TRLabel.ForeColor = Color.Black
                        TRBorder.BackColor = Color.Black
                        TRBoss.Enabled = False
                    ElseIf Somaria = True Then
                        TRChests.Text = 9
                        TRLabel.BackColor = Color.Yellow
                        If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                        TRLabel.ForeColor = Color.Black
                        TRBorder.BackColor = Color.Black
                        TRBoss.Enabled = False
                    Else
                        TRChests.Text = 8
                        TRLabel.BackColor = Color.Yellow
                        TRChests.ForeColor = Color.Yellow
                        TRLabel.ForeColor = Color.Black
                        TRBorder.BackColor = Color.Black
                        TRBoss.Enabled = False
                    End If
                Else
                    TRLabel.BackColor = Color.Red
                    TRLabel.ForeColor = Color.Black
                    TRChests.Text = 0
                    TRChests.ForeColor = Color.White
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                End If
            Case 1, 4
                If ((Glove > 0 Or Flute = True) And (Hammer = True And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True))) Or (Pearl = True And (Hookshot = True Or Hammer = True) And Mirror = True)) Then TRAccess = True Else TRAccess = False
                If TRAccess = True Then
                    If Somaria = True And FireRod = True And IceRod = True And Hammer = True And TRBigKey.Checked = True Then
                        If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) And TRKeys.Text = 4 Then
                            TRLabel.BackColor = Color.Green
                            TRChests.ForeColor = Color.White
                        Else
                            TRLabel.BackColor = Color.Orange
                            TRChests.ForeColor = Color.Orange
                        End If
                        TRLabel.ForeColor = Color.White
                        TRBorder.BackColor = Color.White
                        TRBoss.Enabled = True
                    Else
                        TRLabel.BackColor = Color.Yellow
                        TRChests.ForeColor = Color.Yellow
                        TRLabel.ForeColor = Color.Black
                        TRBorder.BackColor = Color.Black
                        TRBoss.Enabled = False
                    End If
                Else
                    TRLabel.BackColor = Color.Red
                    TRLabel.ForeColor = Color.Black
                    TRChests.ForeColor = Color.White
                    TRBoss.Enabled = False
                    TRBorder.BackColor = Color.Black
                End If
            Case 6
                TRAccess = True
                TRChests.Text = 12
                TRLabel.BackColor = Color.Green
                TRChests.ForeColor = Color.White
                TRLabel.ForeColor = Color.White
                TRBorder.BackColor = Color.White
                TRBoss.Enabled = True
        End Select
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
        If Inverted.Checked = False Then
            LWCheck()
            DWCheck()
            TRCheck()
        Else
            InvLWCheck()
            InvDWCheck()
            InvTRCheck()
        End If
    End Sub

    Private Sub GTClick(sender As Object, e As EventArgs) Handles GTBigKey.CheckedChanged
        If GTBigKey.Checked = True Then
            DirectCast(sender, CheckBox).Image = My.Resources.bigkeysmall
            GTBigKey.BackColor = Color.WhiteSmoke
        Else
            DirectCast(sender, CheckBox).Image = My.Resources.nobigkeysmall
            GTBigKey.BackColor = Color.Red
        End If
        GTCheck()
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
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If CrystalCount = 7 And GTBigKey.Checked = True Then
                GTLabel.BackColor = Color.Green
                GTLabel.ForeColor = Color.White
                GTBorder.BackColor = Color.White
            ElseIf CrystalCount = 7 Then
                GTLabel.BackColor = Color.Yellow
                GTLabel.ForeColor = Color.Black
                GTBorder.BackColor = Color.Black
            Else
                GTLabel.BackColor = Color.Red
                GTLabel.ForeColor = Color.Black
                GTBorder.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub CrystalClick(sender As Object, e As EventArgs) Handles EPButton.MouseDown, DPButton.MouseDown, TOHButton.MouseDown, PODButton.MouseDown, SPButton.MouseDown, SWButton.MouseDown, TTButton.MouseDown, IPButton.MouseDown, MMButton.MouseDown, TRButton.MouseDown
        Select Case DirectCast(sender, PictureBox).Name
            Case "EPButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    EPReward = -1
                    EPButton.Image = Nothing
                End If
            Case "DPButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    DPReward = -1
                    DPButton.Image = Nothing
                End If
            Case "TOHButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    TOHReward = -1
                    TOHButton.Image = Nothing
                End If

            Case "PODButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    PODReward = -1
                    PODButton.Image = Nothing
                End If
            Case "SPButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    SPReward = -1
                    SPButton.Image = Nothing
                End If
            Case "SWButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    SWReward = -1
                    SWButton.Image = Nothing
                End If
            Case "TTButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    TTReward = -1
                    TTButton.Image = Nothing
                End If
            Case "IPButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    IPReward = -1
                    IPButton.Image = Nothing
                End If
            Case "MMButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    MMReward = -1
                    MMButton.Image = Nothing
                End If
            Case "TRButton"
                If MouseButtons = MouseButtons.Left Then
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
                Else
                    TRReward = -1
                    TRButton.Image = Nothing
                End If
        End Select
        If Inverted.Checked = False Then
            LWCheck()
            DWCheck()
        Else
            InvLWCheck()
            InvDWCheck()
        End If
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
        If Inverted.Checked = False Then
            LWCheck()
            DWCheck()
            GTCheck()
        Else
            InvLWCheck()
            InvDWCheck()
            GTCheck()
        End If
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
        LogicCheck()
    End Sub

    Private Sub BoomButton_Click(sender As Object, e As EventArgs) Handles BoomButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Boomerang = (Boomerang + 1) Mod 4 Else Boomerang = (Boomerang + 3) Mod 4
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
        LogicCheck()
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
        LogicCheck()
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
        If Inverted.Checked = False Then LWCheck() Else InvLWCheck()
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
        LogicCheck()
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
        If Inverted.Checked = False Then TRCheck() Else InvTRCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        If Inverted.Checked = False Then AgaCheck() Else InvAgaCheck()
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
        LogicCheck()
    End Sub

    Private Sub BottleButton_Click(sender As Object, e As EventArgs) Handles BottleButton.MouseDown, BottleNumber.MouseDown
        If MouseButtons = MouseButtons.Left Then
            BottleButton.Image = My.Resources.bottle
            BottleButton.BackColor = Color.WhiteSmoke
            Bottle = True
            BottleNumber.BackColor = Color.FromArgb(64, 64, 64)
            If BottleNumber.Text < 4 Then BottleNumber.Text = BottleNumber.Text + 1
        Else
            If BottleNumber.Text > 0 Then BottleNumber.Text = BottleNumber.Text - 1
            If BottleNumber.Text = 0 Then
                Bottle = False
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
        End If
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
    End Sub

    Private Sub GloveButton_Click(sender As Object, e As EventArgs) Handles GloveButton.MouseDown
        If MouseButtons = MouseButtons.Left Then Glove = (Glove + 1) Mod 3 Else Glove = (Glove + 2) Mod 3
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
        LogicCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        If Inverted.Checked = False Then LWCheck() Else InvLWCheck()
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
        If Inverted.Checked = False Then LWCheck() Else InvLWCheck()
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
        LogicCheck()
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
        LogicCheck()
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
        If Inverted.Checked = False Then TRCheck() Else InvTRCheck()
    End Sub

    Private Sub HlpButton_Click(sender As Object, e As EventArgs) Handles HlpButton.MouseDown
        Form2.ShowDialog()
    End Sub

End Class
