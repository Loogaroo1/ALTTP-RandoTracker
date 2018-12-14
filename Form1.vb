Public Class Form1
    Dim Bow, Boomerang, Glove, Sword, Armor, Shield, Magic, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, CrystalCount, FairyCrystal, PendantCount, Available As Integer
    Dim Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess As Boolean

    Public Sub LogicCheck()
        If Inverted.Checked = False Then
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Me.Width = 458
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
                AGLabel.Visible = False
                AGChests.Visible = False
                AGKeys.Visible = False
                AGPrizes.Visible = False
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
                EPBoss.Left = 352
                DPBoss.Left = 352
                HeraBoss.Left = 352
                PODBoss.Left = 352
                SPBoss.Left = 352
                SWBoss.Left = 352
                TTBoss.Left = 352
                IPBoss.Left = 352
                MMBoss.Left = 352
                TRBoss.Left = 352
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
                Me.Width = 482
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
                AGLabel.Visible = True
                AGChests.Visible = True
                AGKeys.Visible = True
                GTLabel.Visible = True
                GTChests.Visible = True
                GTKeys.Visible = True
                GTBigKey.Visible = True
                HCPrizes.Visible = False
                EPPrizes.Visible = False
                DPPrizes.Visible = False
                TOHPrizes.Visible = False
                AGPrizes.Visible = False
                PODPrizes.Visible = False
                SPPrizes.Visible = False
                SWPrizes.Visible = False
                TTPrizes.Visible = False
                IPPrizes.Visible = False
                MMPrizes.Visible = False
                TRPrizes.Visible = False
                EPBoss.Left = 436
                DPBoss.Left = 436
                HeraBoss.Left = 436
                PODBoss.Left = 436
                SPBoss.Left = 436
                SWBoss.Left = 436
                TTBoss.Left = 436
                IPBoss.Left = 436
                MMBoss.Left = 436
                TRBoss.Left = 436
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
            Case 2
                Me.Width = 458
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
                AGLabel.Visible = True
                AGChests.Visible = True
                AGPrizes.Visible = True
                AGKeys.Visible = False
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
                EPBoss.Left = 352
                DPBoss.Left = 352
                HeraBoss.Left = 352
                PODBoss.Left = 352
                SPBoss.Left = 352
                SWBoss.Left = 352
                TTBoss.Left = 352
                IPBoss.Left = 352
                MMBoss.Left = 352
                TRBoss.Left = 352
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
                Me.Width = 458
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
                AGLabel.Visible = False
                AGChests.Visible = False
                AGKeys.Visible = False
                AGPrizes.Visible = False
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
                EPBoss.Left = 352
                DPBoss.Left = 352
                HeraBoss.Left = 352
                PODBoss.Left = 352
                SPBoss.Left = 352
                SWBoss.Left = 352
                TTBoss.Left = 352
                IPBoss.Left = 352
                MMBoss.Left = 352
                TRBoss.Left = 352
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
                Me.Width = 482
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
                AGLabel.Visible = True
                AGChests.Visible = True
                AGKeys.Visible = True
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
                EPBoss.Left = 436
                DPBoss.Left = 436
                HeraBoss.Left = 436
                PODBoss.Left = 436
                SPBoss.Left = 436
                SWBoss.Left = 436
                TTBoss.Left = 436
                IPBoss.Left = 436
                MMBoss.Left = 436
                TRBoss.Left = 436
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
            Case 5
                Me.Width = 458
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
                AGLabel.Visible = True
                AGChests.Visible = True
                AGPrizes.Visible = True
                AGKeys.Visible = False
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
                EPBoss.Left = 352
                DPBoss.Left = 352
                HeraBoss.Left = 352
                PODBoss.Left = 352
                SPBoss.Left = 352
                SWBoss.Left = 352
                TTBoss.Left = 352
                IPBoss.Left = 352
                MMBoss.Left = 352
                TRBoss.Left = 352
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
                Me.Width = 458
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
                AGLabel.Visible = False
                AGChests.Visible = False
                AGKeys.Visible = False
                AGPrizes.Visible = False
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
                EPBoss.Left = 352
                DPBoss.Left = 352
                HeraBoss.Left = 352
                PODBoss.Left = 352
                SPBoss.Left = 352
                SWBoss.Left = 352
                TTBoss.Left = 352
                IPBoss.Left = 352
                MMBoss.Left = 352
                TRBoss.Left = 352
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
        If ComboBox1.SelectedIndex = 6 Then GoTo Line1

        '' Sphere 0
        LW1.Visible = True : LW1.Image = My.Resources.lightgreen
        LW2.Visible = True : LW2.Image = My.Resources.lightgreen
        LW3.Visible = True : LW3.Image = My.Resources.lightgreen
        LW4.Visible = True : LW4.Image = My.Resources.lightgreen
        LW7.Visible = True : LW7.Image = My.Resources.lightgreen
        LW8.Visible = True : LW8.Image = My.Resources.lightgreen
        LW11.Visible = True : LW11.Image = My.Resources.lightgreen

        '' Lumberjack Tree (Normal) - Aganhim and Boots
        '' Lumberjack Tree (Inverted) - Add Pearl and LW Access
        If Aganhim = True And Boots = True Then
            LW21.Visible = True : LW21.Image = My.Resources.lightgreen
        Else
            LW21.Visible = True : LW21.Image = My.Resources.lightyellow
        End If

        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave (Normal) - Bomb
        '' Blind Hut, Kakariko Well, Chicken House, Mini-moldorm Cave, Aginah, Ice Cave (Normal) - Add LW Access
        If Bombs = True Then
            LW5.Visible = True : LW5.Image = My.Resources.lightgreen
            LW6.Visible = True : LW6.Image = My.Resources.lightgreen
            LW9.Visible = True : LW9.Image = My.Resources.lightgreen
            LW12.Visible = True : LW12.Image = My.Resources.lightgreen
            LW14.Visible = True : LW14.Image = My.Resources.lightgreen
            LW15.Visible = True : LW15.Image = My.Resources.lightgreen
        Else
            LW5.Visible = True : LW5.Image = My.Resources.lightyellow
            LW6.Visible = True : LW6.Image = My.Resources.lightyellow
            LW9.Visible = False
            LW12.Visible = False
            LW14.Visible = False
            LW15.Visible = False
        End If

        '' Sick Kid - Bottle
        If Bottle = True Then
            LW22.Visible = True : LW22.Image = My.Resources.lightgreen
        Else
            LW22.Visible = False
        End If

        '' Library, Bonk Rocks - Boots
        If Boots = True Then
            LW23.Visible = True : LW23.Image = My.Resources.lightgreen
            LW24.Visible = True : LW24.Image = My.Resources.lightgreen
        Else
            LW23.Visible = True : LW23.Image = My.Resources.lightyellow
            LW24.Visible = False
        End If

        '' Maze Race, Sahasrahla's Back Room - Boots or Bomb
        If Boots = True Or Bombs = True Then
            LW10.Visible = True : LW10.Image = My.Resources.lightgreen
            LW13.Visible = True : LW13.Image = My.Resources.lightgreen
        Else
            LW10.Visible = True : LW10.Image = My.Resources.lightyellow
            LW13.Visible = False
        End If

        '' Desert Ledge - Desert Palace access (Book or Flute/Mitt/Mirror)
        If Book = True Or (Flute = True And Glove = 2 And Mirror = True) Then
            LW27.Visible = True : LW27.Image = My.Resources.lightgreen
        Else
            LW27.Visible = True : LW27.Image = My.Resources.lightyellow
        End If

        '' Bombos Tablet (Swords) - Master Sword, Book, Access via Dark World
        '' Bombos Tablet (Swordless) - Hammer, Book, Access via Dark World
        Select Case ComboBox1.SelectedIndex
            Case 0, 1, 2
                If Pearl = True And Mirror = True And Book = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or Aganhim = True And Hookshot = True And (Hammer = True Or Glove > 0 Or Flippers = True)) Then
                    LW28.Visible = True
                    If Sword > 1 Then LW28.Image = My.Resources.lightgreen Else LW28.Image = My.Resources.lightyellow
                Else
                    LW28.Visible = False
                End If
            Case 3, 4, 5
                If Pearl = True And Mirror = True And Book = True And (Glove > 0 Or Aganhim = True) Then
                    LW28.Visible = True
                    If Hammer = True Then LW28.Image = My.Resources.lightgreen Else LW28.Image = My.Resources.lightyellow
                Else
                    LW28.Visible = False
                End If
        End Select

        '' Checkerboard - Flute, Mitt, Mirror (no Pearl required)
        If Flute = True And Glove = 2 And Mirror = True Then
            LW29.Visible = True : LW29.Image = My.Resources.lightgreen
        Else
            LW29.Visible = False
        End If

        '' Dwarves - Pearl, Mitt (no Mirror required)
        If Pearl = True And Glove = 2 Then
            LW42.Visible = True : LW42.Image = My.Resources.lightgreen
        Else
            LW42.Visible = False
        End If

        '' Powder Bat - Powder, Hammer or Mirror+Pearl+Mitt
        If Powder = True And (Hammer = True Or (Mirror = True And Pearl = True And Glove = 2)) Then
            LW41.Visible = True : LW41.Image = My.Resources.lightgreen
        Else
            LW41.Visible = False
        End If

        '' Dig Spot - Shovel
        If Shovel = True Then
            LW30.Visible = True : LW30.Image = My.Resources.lightgreen
        Else
            LW30.Visible = False
        End If

        '' Cave south of Grove, Graveyard Cave - Mirror, Access via Dark World
        If Mirror = True And Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Flippers = True))) Then
            LW25.Visible = True : LW25.Image = My.Resources.lightgreen
            LW40.Visible = True : LW40.Image = My.Resources.lightgreen
        Else
            LW25.Visible = False
            LW40.Visible = False
        End If

        '' King's Tomb - Boots, Mitt or Access via Dark World
        If Boots = True And (Glove = 2 Or (Mirror = True And (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Hammer = True Or Flippers = True Or Glove > 0)))) Then
            LW26.Visible = True : LW26.Image = My.Resources.lightgreen
        Else
            LW26.Visible = False
        End If

        '' Hobo, Zora's Ledge, Waterfall - Flippers (Hobo can be faked)
        If Flippers = True Then
            LW16.Visible = True : LW16.Image = My.Resources.lightgreen
            LW18.Visible = True : LW18.Image = My.Resources.lightgreen
            LW20.Visible = True : LW20.Image = My.Resources.lightgreen
        Else
            LW16.Visible = True : LW16.Image = My.Resources.lightorange
            If Pearl = True Then
                LW18.Visible = True : LW18.Image = My.Resources.lightorange
            Else
                LW18.Visible = False
            End If
            LW20.Visible = True : LW20.Image = My.Resources.lightyellow
        End If

        '' Hylia Island - Flippers, Mirror, Pearl, access via Dark World
        If Pearl = True And Flippers = True And Mirror = True And (Aganhim = True Or (Glove > 0 And Hammer = True) Or Glove = 2) Then
            LW19.Visible = True : LW19.Image = My.Resources.lightgreen
        Else
            LW19.Visible = True : LW19.Image = My.Resources.lightyellow
        End If

        '' Witch - Mushroom
        If Mushroom = True Then
            LW31.Visible = True : LW31.Image = My.Resources.lightgreen
        Else
            LW31.Visible = False
        End If

        '' Zora - Glove or Flippers (can be faked)
        If Flippers = True Or Glove > 0 Then
            LW17.Visible = True : LW17.Image = My.Resources.lightgreen
        Else
            LW17.Visible = True : LW17.Image = My.Resources.lightorange
        End If

        '' Old Man - Death Mountain access and Lamp (can be dark-navved)
        If Flute = True Or Glove > 0 Then
            If Lamp = True Then
                LW32.Visible = True : LW32.Image = My.Resources.lightgreen
            Else
                LW32.Visible = True : LW32.Image = My.Resources.lightorange
            End If
        Else
            LW32.Visible = False
        End If

        '' Spectacle Cave - Death Mountain access (Lamp prevents sequence break if Glove is used)
        If Flute = True Or (Glove > 0 And Lamp = True) Then
            LW33.Visible = True : LW33.Image = My.Resources.lightgreen
        ElseIf Glove > 0 Then
            LW33.Visible = True : LW33.Image = My.Resources.lightorange
        Else
            LW33.Visible = False
        End If

        '' Spectacle Rock - Death Mountain access (Lamp prevents sequence break if Glove is used) and Mirror
        If Mirror = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
            LW34.Visible = True : LW34.Image = My.Resources.lightgreen
        ElseIf Mirror = True And Glove > 0 Then
            LW34.Visible = True : LW34.Image = My.Resources.lightorange
        ElseIf Glove > 0 Or Flute = True Then
            LW34.Visible = True : LW34.Image = My.Resources.lightyellow
        Else
            LW34.Visible = False
        End If

        '' Ether Tablet (Swords) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot+Hammer, Master Sword, Book
        '' Ether Tablet (SWordless) - Death Mountain access (Lamp prevents sequence break if Glove is used), Mirror or Hookshot, Hammer, Book
        If ComboBox1.SelectedIndex < 3 Then
            If Sword >= 2 And Book = True And (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                LW35.Visible = True : LW35.Image = My.Resources.lightgreen
            ElseIf Sword >= 2 And Book = True And Glove > 0 And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                LW35.Visible = True : LW35.Image = My.Resources.lightorange
            ElseIf Book = True And (Flute = True Or Glove > 0) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                LW35.Visible = True : LW35.Image = My.Resources.lightyellow
            Else
                LW35.Visible = False
            End If
        Else
            If Book = True And Hammer = True And (Flute = True Or (Glove > 0 And Lamp = True)) And (Mirror = True Or Hookshot = True) Then
                LW35.Visible = True : LW35.Image = My.Resources.lightgreen
            ElseIf Book = True And Glove > 0 And Hammer = True And (Mirror = True Or Hookshot = True) Then
                LW35.Visible = True : LW35.Image = My.Resources.lightorange
            ElseIf Book = True And Glove > 0 And Mirror = True Then
                LW35.Visible = False : LW35.Image = My.Resources.lightyellow
            Else
                LW35.Visible = False
            End If
        End If

        '' East Death Mountain, Spiral Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Hookshot or Mirror+Hammer
        If (Flute = True Or (Glove > 0 And Lamp = True)) And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Bombs = True Then
                LW36.Visible = True : LW36.Image = My.Resources.lightgreen
            Else
                LW36.Visible = True : LW36.Image = My.Resources.lightyellow
            End If
            LW37.Visible = True : LW37.Image = My.Resources.lightgreen
        ElseIf Glove > 0 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If Bombs = True Then
                LW36.Visible = True : LW36.Image = My.Resources.lightorange
            Else
                LW36.Visible = True : LW36.Image = My.Resources.lightyellow
            End If
            LW37.Visible = True : LW37.Image = My.Resources.lightorange
        Else
            LW36.Visible = False
            LW37.Visible = False
        End If

        '' Floating Island - Death Mountain access (Lamp prevents sequence break if Glove is used), Mitt, Pearl, Mirror
        If Pearl = True And Glove = 2 And Mirror = True And (Hookshot = True Or Hammer = True) Then
            LW38.Visible = True
            If Flute = True Or Lamp = True Then LW38.Image = My.Resources.lightgreen Else LW38.Image = My.Resources.lightorange
        ElseIf (Glove > 0 Or Flute = True) And (Mirror = True Or Hookshot = True) Then
            LW38.Visible = True : LW38.Image = My.Resources.lightyellow
        Else
            LW38.Visible = False
        End If

        '' Sahasrahla's Green Pendant
        If GreenPendant = True Then
            LW43.Visible = True : LW43.Image = My.Resources.lightgreen
        Else
            LW43.Visible = False
        End If

        '' Pedestal
        If PendantCount = 3 Then
            LW44.Visible = True : LW44.Image = My.Resources.lightgreen
        ElseIf Book = True Then
            LW44.Visible = True : LW44.Image = My.Resources.lightyellow
        Else
            LW44.Visible = False
        End If

Line1:
        If LW1.Tag = 1 Then LW1.Image = My.Resources.lightoff
        If LW2.Tag = 1 Then LW2.Image = My.Resources.lightoff
        If LW3.Tag = 1 Then LW3.Image = My.Resources.lightoff
        If LW4.Tag = 1 Then LW4.Image = My.Resources.lightoff
        If LW5.Tag = 1 Then LW5.Image = My.Resources.lightoff
        If LW6.Tag = 1 Then LW6.Image = My.Resources.lightoff
        If LW7.Tag = 1 Then LW7.Image = My.Resources.lightoff
        If LW8.Tag = 1 Then LW8.Image = My.Resources.lightoff
        If LW9.Tag = 1 Then LW9.Image = My.Resources.lightoff
        If LW10.Tag = 1 Then LW10.Image = My.Resources.lightoff
        If LW11.Tag = 1 Then LW11.Image = My.Resources.lightoff
        If LW12.Tag = 1 Then LW12.Image = My.Resources.lightoff
        If LW13.Tag = 1 Then LW13.Image = My.Resources.lightoff
        If LW14.Tag = 1 Then LW14.Image = My.Resources.lightoff
        If LW15.Tag = 1 Then LW15.Image = My.Resources.lightoff
        If LW16.Tag = 1 Then LW16.Image = My.Resources.lightoff
        If LW17.Tag = 1 Then LW17.Image = My.Resources.lightoff
        If LW18.Tag = 1 Then LW18.Image = My.Resources.lightoff
        If LW19.Tag = 1 Then LW19.Image = My.Resources.lightoff
        If LW20.Tag = 1 Then LW20.Image = My.Resources.lightoff
        If LW21.Tag = 1 Then LW21.Image = My.Resources.lightoff
        If LW22.Tag = 1 Then LW22.Image = My.Resources.lightoff
        If LW23.Tag = 1 Then LW23.Image = My.Resources.lightoff
        If LW24.Tag = 1 Then LW24.Image = My.Resources.lightoff
        If LW25.Tag = 1 Then LW25.Image = My.Resources.lightoff
        If LW26.Tag = 1 Then LW26.Image = My.Resources.lightoff
        If LW27.Tag = 1 Then LW27.Image = My.Resources.lightoff
        If LW28.Tag = 1 Then LW28.Image = My.Resources.lightoff
        If LW29.Tag = 1 Then LW29.Image = My.Resources.lightoff
        If LW30.Tag = 1 Then LW30.Image = My.Resources.lightoff
        If LW31.Tag = 1 Then LW31.Image = My.Resources.lightoff
        If LW32.Tag = 1 Then LW32.Image = My.Resources.lightoff
        If LW33.Tag = 1 Then LW33.Image = My.Resources.lightoff
        If LW34.Tag = 1 Then LW34.Image = My.Resources.lightoff
        If LW35.Tag = 1 Then LW35.Image = My.Resources.lightoff
        If LW36.Tag = 1 Then LW36.Image = My.Resources.lightoff
        If LW37.Tag = 1 Then LW37.Image = My.Resources.lightoff
        If LW38.Tag = 1 Then LW38.Image = My.Resources.lightoff
        If LW39.Tag = 1 Then LW39.Image = My.Resources.lightoff
        If LW40.Tag = 1 Then LW40.Image = My.Resources.lightoff
        If LW41.Tag = 1 Then LW41.Image = My.Resources.lightoff
        If LW42.Tag = 1 Then LW42.Image = My.Resources.lightoff
        If LW43.Tag = 1 Then LW43.Image = My.Resources.lightoff
        If LW44.Tag = 1 Then LW44.Image = My.Resources.lightoff
    End Sub

    Public Sub InvLWCheck()
        If ComboBox1.SelectedIndex = 6 Then GoTo Line1

        '' Link's House: Free
        LW1.Visible = True : LW1.Image = My.Resources.lightgreen

        '' Sphere 0, Grove Cave, Graveyard: LW Access
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW2.Visible = True : LW2.Image = My.Resources.lightgreen
            LW3.Visible = True : LW3.Image = My.Resources.lightgreen
            LW4.Visible = True : LW4.Image = My.Resources.lightgreen
            LW7.Visible = True : LW7.Image = My.Resources.lightgreen
            LW8.Visible = True : LW8.Image = My.Resources.lightgreen
            LW11.Visible = True : LW11.Image = My.Resources.lightgreen
            LW25.Visible = True : LW25.Image = My.Resources.lightgreen
            LW40.Visible = True : LW40.Image = My.Resources.lightgreen
            If Bombs = True Then
                LW5.Visible = True : LW5.Image = My.Resources.lightgreen
                LW6.Visible = True : LW6.Image = My.Resources.lightgreen
                LW9.Visible = True : LW9.Image = My.Resources.lightgreen
                LW10.Visible = True : LW10.Image = My.Resources.lightgreen
                LW12.Visible = True : LW12.Image = My.Resources.lightgreen
                LW13.Visible = True : LW13.Image = My.Resources.lightgreen
                LW14.Visible = True : LW14.Image = My.Resources.lightgreen
                LW15.Visible = True : LW15.Image = My.Resources.lightgreen
            Else
                LW5.Visible = True : LW5.Image = My.Resources.lightyellow
                LW6.Visible = True : LW6.Image = My.Resources.lightyellow
                LW9.Visible = False
                If Boots = True Then
                    LW10.Visible = True : LW10.Image = My.Resources.lightgreen
                Else
                    LW10.Visible = False
                End If
                LW12.Visible = False
                LW13.Visible = False
                LW14.Visible = False
                LW15.Visible = False
            End If
        Else
            LW2.Visible = False
            LW3.Visible = False
            LW4.Visible = False
            LW5.Visible = False
            LW6.Visible = False
            LW7.Visible = False
            LW8.Visible = False
            LW9.Visible = False
            LW10.Visible = False
            LW11.Visible = False
            LW12.Visible = False
            LW13.Visible = False
            LW14.Visible = False
            LW15.Visible = False
            LW25.Visible = False
            LW40.Visible = False
        End If

        '' Sick Kid - Bottle
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Bottle = True Then
            LW22.Visible = True : LW22.Image = My.Resources.lightgreen
        Else
            LW22.Visible = False
        End If

        '' Pegasus Rocks, Library - Boots
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Boots = True Then
            LW23.Visible = True : LW23.Image = My.Resources.lightgreen
            LW24.Visible = True : LW24.Image = My.Resources.lightgreen
        Else
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                LW23.Visible = True : LW23.Image = My.Resources.lightyellow
            Else
                LW23.Visible = False
            End If
            LW24.Visible = False
        End If

        '' Aganhim's Tree - Aganhim defeated, Pearl, Boots
        If Aganhim = True And Pearl = True And Boots = True Then
            LW21.Visible = True : LW21.Image = My.Resources.lightgreen
        ElseIf Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW21.Visible = True : LW21.Image = My.Resources.lightyellow
        Else
            LW21.Visible = False
        End If

        '' DP Ledge - Book
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Book = True Then
            LW27.Visible = True : LW27.Image = My.Resources.lightgreen
        Else
            LW27.Visible = False
        End If

        '' Bombos Tablet - Book, Master Sword or Hammer (Swordless)
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2 Then
            If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Book = True And Sword > 1 Then
                LW28.Visible = True : LW28.Image = My.Resources.lightgreen
            ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Book = True Then
                LW28.Visible = True : LW28.Image = My.Resources.lightyellow
            Else
                LW28.Visible = False
            End If
        Else
            If Pearl = True And (Aganhim = True Or Glove = 1) And Book = True And Hammer = True Then
                LW23.Visible = True : LW23.Image = My.Resources.lightgreen
            ElseIf Pearl = True And (Aganhim = True Or Glove = 1) And Book = True Then
                LW23.Visible = True : LW23.Image = My.Resources.lightyellow
            Else
                LW28.Visible = False
            End If
        End If

        '' Checkerboard Cave - Glove
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Glove > 0 Then
            LW29.Visible = True : LW29.Image = My.Resources.lightgreen
        Else
            LW29.Visible = False
        End If

        '' Blacksmith - Mitt + Pearl
        If Glove = 2 And Pearl = True Then
            LW42.Visible = True : LW42.Image = My.Resources.lightgreen
        Else
            LW42.Visible = False
        End If

        '' Magic Bat - Glove
        If Pearl = True And (Aganhim = True Or Glove > 0) And Hammer = True And Powder = True Then
            LW41.Visible = True : LW41.Image = My.Resources.lightgreen
        Else
            LW41.Visible = False
        End If

        '' Flute Spot - Shovel
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Shovel = True Then
            LW30.Visible = True : LW30.Image = My.Resources.lightgreen
        Else
            LW30.Visible = False
        End If

        '' King's Tomb - Mitt, Boots
        If Pearl = True And Glove = 2 And Boots = True Then
            LW26.Visible = True : LW26.Image = My.Resources.lightgreen
        Else
            LW26.Visible = False
        End If

        '' Hobo, Waterfall, Island - Flippers avoids sequence break
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW16.Visible = True
            LW18.Visible = True
            LW19.Visible = True
            If Flippers = True Then
                LW16.Image = My.Resources.lightgreen
                LW18.Image = My.Resources.lightgreen
                LW19.Image = My.Resources.lightgreen
            Else
                LW16.Image = My.Resources.lightorange
                LW18.Image = My.Resources.lightorange
                LW19.Image = My.Resources.lightorange
            End If
        Else
            LW16.Visible = False
            LW18.Visible = False
            LW19.Visible = False
        End If

        '' Potion Shop - Mushroom
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Mushroom = True Then
            LW31.Visible = True : LW31.Image = My.Resources.lightgreen
        Else
            LW31.Visible = False
        End If

        '' Zora - Glove or Flippers avoids sequence break
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW17.Visible = True
            If Flippers = True Or Glove > 0 Then LW17.Image = My.Resources.lightgreen Else LW17.Image = My.Resources.lightorange
        Else
            LW17.Visible = False
        End If

        '' Ledge - Flippers ONLY
        If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Flippers = True Then
            LW20.Visible = True : LW20.Image = My.Resources.lightgreen
        ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW20.Visible = True : LW20.Image = My.Resources.lightyellow
        Else
            LW20.Visible = False
        End If

        '' Old Man, Spectacle Cave - Flute or Glove (+ Lamp to avoid sequence break)
        If Flute = True Or Glove > 0 Then
            LW32.Visible = True
            LW33.Visible = True
            If Flute = True Or Lamp = True Then
                LW32.Image = My.Resources.lightgreen
                LW33.Image = My.Resources.lightgreen
            Else
                LW32.Image = My.Resources.lightorange
                LW33.Image = My.Resources.lightorange
            End If
        Else
            LW32.Visible = False
            LW33.Visible = False
        End If

        '' Spectacle Rock - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt, Hammer
        If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True Then
            LW34.Visible = True
            If (Flute = True Or Lamp = True) Then LW40.Image = My.Resources.lightgreen Else LW40.Image = My.Resources.lightorange
        ElseIf (Flute = True Or Glove > 0) And Pearl = True Then
            LW34.Visible = True : LW40.Image = My.Resources.lightyellow
        Else
            LW34.Visible = False
        End If

        '' Ether Tablet - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt, Hammer, Book
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True And Book = True And Sword > 1 Then
                LW35.Visible = True
                If (Flute = True Or Lamp = True) Then LW35.Image = My.Resources.lightgreen Else LW35.Image = My.Resources.lightorange
            ElseIf (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True And Book = True Then
                LW35.Visible = True : LW35.Image = My.Resources.lightyellow
            Else
                LW35.Visible = False
            End If
        ElseIf ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 5 Then
            If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True And Book = True Then
                LW35.Visible = True
                If (Flute = True Or Lamp = True) Then LW35.Image = My.Resources.lightgreen Else LW35.Image = My.Resources.lightorange
            Else
                LW41.Visible = False
            End If
        End If

        '' Paradox Cave, Spiral Cave, Floating Island - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt + Hammer
        If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or (Glove = 2 And Hammer = True)) Then
            LW36.Visible = True
            LW37.Visible = True
            LW38.Visible = True
            If (Flute = True Or Lamp = True) Then
                LW36.Image = My.Resources.lightgreen
                LW37.Image = My.Resources.lightgreen
                LW38.Image = My.Resources.lightgreen
            Else
                LW36.Image = My.Resources.lightorange
                LW37.Image = My.Resources.lightorange
                LW38.Image = My.Resources.lightorange
            End If
        Else
            LW42.Visible = False
            LW43.Visible = False
            LW44.Visible = False
        End If

        '' Mimic Cave - Flute or Glove (+ Lamp to avoid sequence break), Pearl, Hookshot or Mitt, Hammer
        If (Flute = True Or Glove > 0) And Pearl = True And (Hookshot = True Or Glove = 2) And Hammer = True Then
            LW39.Visible = True
            If (Flute = True Or Lamp = True) Then LW39.Image = My.Resources.lightgreen Else LW39.Image = My.Resources.lightorange
        Else
            LW39.Visible = False
        End If

        '' Macguffins
        If GreenPendant = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW43.Visible = True : LW43.Image = My.Resources.lightgreen
        Else
            LW43.Visible = False
        End If

        If PendantCount = 3 And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            LW44.Visible = True : LW44.Image = My.Resources.lightgreen
        Else
            LW44.Visible = False
        End If

Line1:
        If LW1.Tag = 1 Then LW1.Image = My.Resources.lightoff
        If LW2.Tag = 1 Then LW2.Image = My.Resources.lightoff
        If LW3.Tag = 1 Then LW3.Image = My.Resources.lightoff
        If LW4.Tag = 1 Then LW4.Image = My.Resources.lightoff
        If LW5.Tag = 1 Then LW5.Image = My.Resources.lightoff
        If LW6.Tag = 1 Then LW6.Image = My.Resources.lightoff
        If LW7.Tag = 1 Then LW7.Image = My.Resources.lightoff
        If LW8.Tag = 1 Then LW8.Image = My.Resources.lightoff
        If LW9.Tag = 1 Then LW9.Image = My.Resources.lightoff
        If LW10.Tag = 1 Then LW10.Image = My.Resources.lightoff
        If LW11.Tag = 1 Then LW11.Image = My.Resources.lightoff
        If LW12.Tag = 1 Then LW12.Image = My.Resources.lightoff
        If LW13.Tag = 1 Then LW13.Image = My.Resources.lightoff
        If LW14.Tag = 1 Then LW14.Image = My.Resources.lightoff
        If LW15.Tag = 1 Then LW15.Image = My.Resources.lightoff
        If LW16.Tag = 1 Then LW16.Image = My.Resources.lightoff
        If LW17.Tag = 1 Then LW17.Image = My.Resources.lightoff
        If LW18.Tag = 1 Then LW18.Image = My.Resources.lightoff
        If LW19.Tag = 1 Then LW19.Image = My.Resources.lightoff
        If LW20.Tag = 1 Then LW20.Image = My.Resources.lightoff
        If LW21.Tag = 1 Then LW21.Image = My.Resources.lightoff
        If LW22.Tag = 1 Then LW22.Image = My.Resources.lightoff
        If LW23.Tag = 1 Then LW23.Image = My.Resources.lightoff
        If LW24.Tag = 1 Then LW24.Image = My.Resources.lightoff
        If LW25.Tag = 1 Then LW25.Image = My.Resources.lightoff
        If LW26.Tag = 1 Then LW26.Image = My.Resources.lightoff
        If LW27.Tag = 1 Then LW27.Image = My.Resources.lightoff
        If LW28.Tag = 1 Then LW28.Image = My.Resources.lightoff
        If LW29.Tag = 1 Then LW29.Image = My.Resources.lightoff
        If LW30.Tag = 1 Then LW30.Image = My.Resources.lightoff
        If LW31.Tag = 1 Then LW31.Image = My.Resources.lightoff
        If LW32.Tag = 1 Then LW32.Image = My.Resources.lightoff
        If LW33.Tag = 1 Then LW33.Image = My.Resources.lightoff
        If LW34.Tag = 1 Then LW34.Image = My.Resources.lightoff
        If LW35.Tag = 1 Then LW35.Image = My.Resources.lightoff
        If LW36.Tag = 1 Then LW36.Image = My.Resources.lightoff
        If LW37.Tag = 1 Then LW37.Image = My.Resources.lightoff
        If LW38.Tag = 1 Then LW38.Image = My.Resources.lightoff
        If LW39.Tag = 1 Then LW39.Image = My.Resources.lightoff
        If LW40.Tag = 1 Then LW40.Image = My.Resources.lightoff
        If LW41.Tag = 1 Then LW41.Image = My.Resources.lightoff
        If LW42.Tag = 1 Then LW42.Image = My.Resources.lightoff
        If LW43.Tag = 1 Then LW43.Image = My.Resources.lightoff
        If LW44.Tag = 1 Then LW44.Image = My.Resources.lightoff

    End Sub

    Public Sub DWCheck()
        '' Pyramid - Aganhim or Access from warp
        If ComboBox1.SelectedIndex = 6 Then GoTo Line1

        If Aganhim = True Or (Pearl = True And ((Glove > 0 And Hammer = True) Or (Glove = 2 And Flippers = True))) Then
            DW1.Visible = True : DW1.Image = My.Resources.lightgreen
        Else
            DW1.Visible = False
        End If

        '' Chest Game, C House, Sealed Hut, Bumper Cave - Mitt, Glove/Hammer, or Aganhim/Hookshot/Access (Cape also required for Bumper Cave)
        If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
            DW5.Visible = True : DW5.Image = My.Resources.lightgreen
            DW6.Visible = True : DW6.Image = My.Resources.lightgreen
            DW7.Visible = True : DW7.Image = My.Resources.lightgreen
            If Cape = True And Glove > 0 Then
                DW8.Visible = True : DW8.Image = My.Resources.lightgreen
            Else
                DW8.Visible = True : DW8.Image = My.Resources.lightyellow
            End If
        Else
            DW5.Visible = False
            DW6.Visible = False
            DW7.Visible = False
            DW8.Visible = False
        End If

        '' Digging Game, Tree Kid, Swamp Hype - Mitt, Glove/Hammer, Aganhim/Hammer, or Aganhim/Hookshot/Glove or Flippers
        If Pearl = True And (Glove = 2 Or (Hammer = True And Glove > 0) Or (Hammer = True And Aganhim = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Flippers = True))) Then
            DW3.Visible = True : DW3.Image = My.Resources.lightgreen
            DW14.Visible = True : DW14.Image = My.Resources.lightgreen
            If Bombs = True Then
                DW4.Visible = True : DW4.Image = My.Resources.lightgreen
            Else
                DW4.Visible = False
            End If
        Else
            DW3.Visible = False
            DW4.Visible = False
            DW14.Visible = False
        End If

        '' Mire Cave - Flute, Mitt, Pearl
        If Flute = True And Glove = 2 And Pearl = True Then
            DW9.Visible = True : DW9.Image = My.Resources.lightgreen
        Else
            DW9.Visible = False
        End If

        '' Purple Chest - Dwarves complete (no further items required)
        If LW42.Tag = 1 Then
            DW15.Visible = True : DW15.Image = My.Resources.lightgreen
        Else
            DW15.Visible = False
        End If

        '' Hammer Pegs - Pearl, Mitt, Hammer
        If Pearl = True And Glove = 2 And Hammer = True Then
            DW13.Visible = True : DW13.Image = My.Resources.lightgreen
        Else
            DW13.Visible = False
        End If

        '' Catfish - Pearl, Glove, Aganhim/Hammer/Mitt+Flippers
        If Pearl = True And Glove > 0 And ((Glove = 2 And Flippers = True) Or Hammer = True Or Aganhim = True) Then
            DW2.Visible = True : DW2.Image = My.Resources.lightgreen
        Else
            DW2.Visible = False
        End If

        '' Spike Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Hammer, Glove; Safety item (Byrna or Cape) and either 1/2 magic or bottle to avoid sequence break
        If Pearl = True And Hammer = True And (Flute = True Or (Glove > 0 And Lamp = True)) Then
            If (Byrna = True Or Cape = True And Glove > 0) And (Magic > 0 Or BottleNumber.Text > 0) Then
                DW10.Visible = True : DW10.Image = My.Resources.lightgreen
            Else
                DW10.Visible = True : DW10.Image = My.Resources.lightorange
            End If
        ElseIf Pearl = True And Hammer = True And Glove > 0 Then
            DW10.Visible = True : DW10.Image = My.Resources.lightorange
        Else
            DW10.Visible = False
        End If

        '' Superbunny Cave - Death Mountain access (Lamp prevents sequence break if Glove is used, Pearl prevents sequence break), Mitt, Hookshot or Hammer+Mirror
        If Glove = 2 And (Hookshot = True Or (Hammer = True And Mirror = True)) Then
            If (Flute = True Or Lamp = True) And Pearl = True Then
                DW11.Visible = True : DW11.Image = My.Resources.lightgreen
            Else
                DW11.Visible = True : DW11.Image = My.Resources.lightorange
            End If
        Else
            DW11.Visible = False
        End If

        '' Hookshot Cave - Death Mountain access (Lamp prevents sequence break if Glove is used), Pearl, Mitt, Hookshot or Hammer+Mirror+Boots (Partially blocked without Hookshot)
        If Pearl = True And Glove = 2 And Hookshot = True Then
            If Flute = True Or Lamp = True Then
                DW12.Visible = True : DW12.Image = My.Resources.lightgreen
            Else
                DW12.Visible = True : DW12.Image = My.Resources.lightorange
            End If
        ElseIf Pearl = True And Glove = 2 And Hammer = True And Mirror = True And Boots = True Then
            DW12.Visible = True : DW12.Image = My.Resources.lightyellow
        Else
            DW12.Visible = False
        End If

        '' Fat Fairy - Crystals 5 & 6, Pearl, Hammer, Glove or Aganhim
        If Pearl = True And FairyCrystal = 2 And ((Glove > 0 And Hammer = True) Or (Aganhim = True And Mirror = True) Or (Aganhim = True And Hammer = True)) Then
            DW16.Visible = True : DW16.Image = My.Resources.lightgreen
        Else
            DW16.Visible = False
        End If

Line1:
        If DW1.Tag = 1 Then DW1.Image = My.Resources.lightoff
        If DW2.Tag = 1 Then DW2.Image = My.Resources.lightoff
        If DW3.Tag = 1 Then DW3.Image = My.Resources.lightoff
        If DW4.Tag = 1 Then DW4.Image = My.Resources.lightoff
        If DW5.Tag = 1 Then DW5.Image = My.Resources.lightoff
        If DW6.Tag = 1 Then DW6.Image = My.Resources.lightoff
        If DW7.Tag = 1 Then DW7.Image = My.Resources.lightoff
        If DW8.Tag = 1 Then DW8.Image = My.Resources.lightoff
        If DW9.Tag = 1 Then DW9.Image = My.Resources.lightoff
        If DW10.Tag = 1 Then DW10.Image = My.Resources.lightoff
        If DW11.Tag = 1 Then DW11.Image = My.Resources.lightoff
        If DW12.Tag = 1 Then DW12.Image = My.Resources.lightoff
        If DW13.Tag = 1 Then DW13.Image = My.Resources.lightoff
        If DW14.Tag = 1 Then DW14.Image = My.Resources.lightoff
        If DW15.Tag = 1 Then DW15.Image = My.Resources.lightoff
        If DW16.Tag = 1 Then DW16.Image = My.Resources.lightoff

    End Sub

    Public Sub InvDWCheck()
        If ComboBox1.SelectedIndex = 6 Then GoTo Line1

        '' Chest Game, C-Shaped House, Stumpy, Digging Game - Free
        DW3.Visible = True : DW3.Image = My.Resources.lightgreen
        DW5.Visible = True : DW5.Image = My.Resources.lightgreen
        DW6.Visible = True : DW6.Image = My.Resources.lightgreen
        DW14.Visible = True : DW14.Image = My.Resources.lightgreen

        '' Sealed Brewery, Hype Cave - Bombs
        If Bombs = True Then
            DW4.Visible = True : DW4.Image = My.Resources.lightgreen
            DW7.Visible = True : DW7.Image = My.Resources.lightgreen
        Else
            DW4.Visible = False
            DW7.Visible = False
        End If

        '' Pyramid, Catfish - Hammer or Flippers; Catfish needs Glove
        If Hammer = True Or Flippers = True Then
            DW1.Visible = True : DW1.Image = My.Resources.lightgreen
            If Glove > 0 Then
                DW2.Visible = True : DW2.Image = My.Resources.lightgreen
            Else
                DW2.Visible = False
            End If
        Else
            DW1.Visible = False
            DW2.Visible = False
        End If

        '' Mire Cave - Flute or LW Access + Mirror
        If Flute = True Or (Pearl = True And Mirror = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True))) Then
            DW9.Visible = True : DW9.Image = My.Resources.lightgreen
        Else
            DW9.Visible = False
        End If

        '' Bumper Cave - LW Access, Mirror, Glove, Cape
        If Pearl = True And Mirror = True And Glove > 0 And Cape = True And (Aganhim = True Or Glove = 2 Or Hammer = True) Then
            DW8.Visible = True : DW8.Image = My.Resources.lightgreen
        Else
            DW8.Visible = True : DW8.Image = My.Resources.lightyellow
        End If

        '' Purple Chest - Blacksmith
        If LW42.Tag = 1 Then
            DW15.Visible = True : DW15.Image = My.Resources.lightgreen
        Else
            DW15.Visible = False
        End If

        '' Hammer Pegs - Hammer, Mitt or Mirror
        If (Glove = 2 Or ((Aganhim = True Or (Glove = 1 And Pearl = True)) And Mirror = True)) And Hammer = True Then
            DW13.Visible = True : DW13.Image = My.Resources.lightgreen
        Else
            DW13.Visible = False
        End If

        '' Spike Cave - DM Access, Hammer, Safety Item
        If (Flute = True Or Glove > 0) And Hammer = True And (Cape = True Or Byrna = True) Then
            DW10.Visible = True
            If (Flute = True Or Lamp = True) And (Bottle = True Or Magic > 0) Then DW10.Image = My.Resources.lightgreen Else DW10.Image = My.Resources.lightorange
        Else
            DW10.Visible = False
        End If

        '' Superbunny Cave - DM Access
        If (Flute = True Or Glove > 0) Then
            DW11.Visible = True
            If Flute = True Or Lamp = True Then DW11.Image = My.Resources.lightgreen Else DW11.Image = My.Resources.lightorange
        Else
            DW11.Visible = False
        End If

        '' Hookshot Cave - DM Access, Hookshot; Boots opens Partial
        If (Flute = True Or Glove > 0) And Hookshot = True Then
            If Flute = True Or Lamp = True Then
                DW12.Visible = True : DW12.Image = My.Resources.lightgreen
            Else
                DW12.Visible = True : DW12.Image = My.Resources.lightorange
            End If
        ElseIf (Flute = True Or Glove > 0) And Boots = True Then
            DW12.Visible = False
        End If

        '' Pyramid Fairy - Fairy Crystals, LW Access, Mirror
        If FairyCrystal = 2 And Mirror = True And Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) Then
            DW16.Visible = True : DW16.Image = My.Resources.lightgreen
        Else
            DW16.Visible = False
        End If

Line1:
        If DW1.Tag = 1 Then DW1.Image = My.Resources.lightoff
        If DW2.Tag = 1 Then DW2.Image = My.Resources.lightoff
        If DW3.Tag = 1 Then DW3.Image = My.Resources.lightoff
        If DW4.Tag = 1 Then DW4.Image = My.Resources.lightoff
        If DW5.Tag = 1 Then DW5.Image = My.Resources.lightoff
        If DW6.Tag = 1 Then DW6.Image = My.Resources.lightoff
        If DW7.Tag = 1 Then DW7.Image = My.Resources.lightoff
        If DW8.Tag = 1 Then DW8.Image = My.Resources.lightoff
        If DW9.Tag = 1 Then DW9.Image = My.Resources.lightoff
        If DW10.Tag = 1 Then DW10.Image = My.Resources.lightoff
        If DW11.Tag = 1 Then DW11.Image = My.Resources.lightoff
        If DW12.Tag = 1 Then DW12.Image = My.Resources.lightoff
        If DW13.Tag = 1 Then DW13.Image = My.Resources.lightoff
        If DW14.Tag = 1 Then DW14.Image = My.Resources.lightoff
        If DW15.Tag = 1 Then DW15.Image = My.Resources.lightoff
        If DW16.Tag = 1 Then DW16.Image = My.Resources.lightoff

    End Sub

    Private Sub LocationClick(sender As Object, e As EventArgs)
        If DirectCast(sender, CheckBox).Checked = True Then DirectCast(sender, CheckBox).BackColor = Color.FromArgb(64, 64, 64) Else DirectCast(sender, CheckBox).BackColor = Color.WhiteSmoke
        If Inverted.Checked = False Then
            LWCheck()
            DWCheck()
        Else
            InvLWCheck()
            InvDWCheck()
        End If
    End Sub


    Public Sub HCCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Glove > 0 And Lamp = True And (Bombs = True Or Boots = True) Then
                    HCLabel.Image = My.Resources.HCgreen
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.White
                ElseIf Lamp = True And (Bombs = True Or Boots = True) Then
                    HCLabel.Image = My.Resources.HCyellow
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.Yellow
                ElseIf Glove > 0 And (Bombs = True Or Boots = True) Then
                    HCLabel.Image = My.Resources.HCyellow
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.Orange
                ElseIf Lamp = True Then
                    HCLabel.Image = My.Resources.HCyellow
                    HCChests.Text = 5
                    HCChests.ForeColor = Color.White
                Else
                    HCLabel.Image = My.Resources.HCyellow
                    HCChests.Text = 5
                    HCChests.ForeColor = Color.Yellow
                End If
            Case 1, 4
                If (Glove > 0 Or HCKeys.Text = 1) And (Bombs = True Or Boots = True) Then
                    If Lamp = True Then HCLabel.Image = My.Resources.HCgreen Else HCLabel.Image = My.Resources.HCorange
                    HCChests.ForeColor = Color.White
                Else
                    HCLabel.Image = My.Resources.HCyellow
                End If
            Case Else
                HCLabel.Image = My.Resources.HCgreen
                HCChests.Text = 8
                HCChests.ForeColor = Color.White
        End Select
    End Sub

    Public Sub InvHCCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And (Bombs = True Or Boots = True) Then
                    If Lamp = True Then HCLabel.Image = My.Resources.HCgreen Else HCLabel.Image = My.Resources.HCorange
                    HCChests.Text = 8
                    HCChests.ForeColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                    HCLabel.Image = My.Resources.HCyellow
                    HCChests.Text = 5
                    If Lamp = True Then HCChests.ForeColor = Color.White Else HCChests.ForeColor = Color.Yellow
                Else
                    HCLabel.Image = My.Resources.HCred
                    HCChests.Text = 0
                    HCChests.ForeColor = Color.White
                End If
            Case 1, 4
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And (Bombs = True Or Boots = True) Then
                    If Lamp = True And HCKeys.Text = 1 Then HCLabel.Image = My.Resources.HCgreen Else HCLabel.Image = My.Resources.HCorange
                    HCLabel.ForeColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                    HCLabel.Image = My.Resources.HCyellow
                Else
                    HCLabel.Image = My.Resources.HCred
                End If
            Case 6
                HCLabel.Image = My.Resources.HCgreen
                HCChests.Text = 8
                HCChests.ForeColor = Color.White
        End Select
    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As EventArgs) Handles HCChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Then
            If MouseButtons = MouseButtons.Left Then
                If HCChests.Text > 0 Then HCChests.Text = HCChests.Text - 1
                If (ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4) And HCChests.Text = 0 Then HCChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If HCChests.Text < 8 Then HCChests.Text = HCChests.Text + 1
                HCChests.BackColor = Color.Black
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
                If HCPrizes.Text = 0 Then HCPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Then
                    If HCPrizes.Text < 6 Then HCPrizes.Text = HCPrizes.Text + 1
                Else
                    If HCPrizes.Text < 7 Then HCPrizes.Text = HCPrizes.Text + 1
                End If
                HCPrizes.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub AGChests_MouseDown(sender As Object, e As MouseEventArgs) Handles AGChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If MouseButtons = MouseButtons.Left Then
                If AGChests.Text > 0 Then AGChests.Text = AGChests.Text - 1
                If AGChests.Text = 0 Then AGChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If AGChests.Text < 2 Then AGChests.Text = AGChests.Text + 1
                AGChests.BackColor = Color.Black
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
                If EPChests.Text = 0 Then EPChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If EPChests.Text < 6 Then EPChests.Text = EPChests.Text + 1
                EPChests.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub EPPrizes_MouseDown(sender As Object, e As EventArgs) Handles EPPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If EPPrizes.Text > 0 Then EPPrizes.Text = EPPrizes.Text - 1
                If EPPrizes.Text = 0 Then EPPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If EPPrizes.Text < 3 Then EPPrizes.Text = EPPrizes.Text + 1
                EPPrizes.BackColor = Color.Black
            End If
        End If
    End Sub

    Public Sub EPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Bow > 1 Then
                    EPLabel.ForeColor = Color.White
                    EPBoss.Enabled = True
                    If Lamp = True Then
                        EPLabel.Image = My.Resources.EPgreen
                    Else
                        EPLabel.Image = My.Resources.EPorange
                    End If
                Else
                    EPLabel.Image = My.Resources.EPyellow
                    EPBoss.Enabled = False
                End If
            Case 1, 4
                If Bow > 1 And Lamp = True And EPBigKey.Checked = True Then
                    EPLabel.Image = My.Resources.EPgreen
                    EPBoss.Enabled = True
                ElseIf Bow > 1 And EPBigKey.Checked = True Then
                    EPLabel.Image = My.Resources.EPorange
                    EPBoss.Enabled = True
                Else
                    EPLabel.Image = My.Resources.EPyellow
                    EPBoss.Enabled = False
                End If
            Case 6
                EPBoss.Enabled = True
                EPLabel.Image = My.Resources.EPgreen
        End Select
    End Sub

    Public Sub InvEPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) And Bow > 1 Then
                    EPLabel.ForeColor = Color.White
                    EPBoss.Enabled = True
                    If Lamp = True Then EPLabel.Image = My.Resources.EPgreen Else EPLabel.Image = My.Resources.EPorange
                ElseIf Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = True)) Then
                    EPBoss.Enabled = False
                    EPLabel.Image = My.Resources.EPyellow
                Else
                    EPLabel.Image = My.Resources.EPred
                    EPBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And (Aganhim = True Or Glove = 2 Or (Glove = 1 And Hammer = 1)) And Bow > 1 And EPBigKey.Checked = True Then
                    If Lamp = True Then
                        EPLabel.Image = My.Resources.EPgreen
                    Else
                        EPLabel.Image = My.Resources.EPorange
                    End If
                    EPBoss.Enabled = True
                    EPLabel.ForeColor = Color.White
                ElseIf Pearl = True And (Aganhim = True Or (Glove > 0 And Hammer = True) Or (Glove = 2 And Flippers = True)) Then
                    EPLabel.Image = My.Resources.EPyellow
                    EPBoss.Enabled = False
                Else
                    EPLabel.Image = My.Resources.EPred
                    EPBoss.Enabled = False
                End If
            Case 6
                EPLabel.Image = My.Resources.EPgreen
                EPBoss.Enabled = True
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
                If DPChests.Text = 0 Then DPChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If DPChests.Text < 6 Then DPChests.Text = DPChests.Text + 1
                DPChests.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub DPPrizes_MouseDown(sender As Object, e As EventArgs) Handles DPPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If DPPrizes.Text > 0 Then DPPrizes.Text = DPPrizes.Text - 1
                If DPPrizes.Text = 0 Then DPPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex Mod 3 = 0 Then
                    If DPPrizes.Text < 2 Then DPPrizes.Text = DPPrizes.Text + 1
                Else
                    If DPPrizes.Text < 3 Then DPPrizes.Text = DPPrizes.Text + 1
                End If
                DPPrizes.BackColor = Color.Black
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
                    DPLabel.Image = My.Resources.DPgreen
                    DPBoss.Enabled = True
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = True
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = False
                Else
                    DPLabel.Image = My.Resources.DPred
                    DPBoss.Enabled = False
                End If
            Case 1, 4
                If (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                    If DPKeys.Text = 1 Then
                        DPLabel.Image = My.Resources.DPgreen
                    Else
                        DPLabel.Image = My.Resources.DPorange
                    End If
                    DPLabel.ForeColor = Color.White
                    DPBoss.Enabled = True
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = True
                ElseIf (Book = True Or (Glove = 2 And Flute = True And Mirror = True)) Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = False
                Else
                    DPLabel.Image = My.Resources.DPred
                    DPBoss.Enabled = False
                End If
            Case 6
                DPLabel.Image = My.Resources.DPgreen
                DPChests.Text = 6
                DPBoss.Enabled = True
        End Select
    End Sub
    Public Sub InvDPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 Then
                    DPLabel.Image = My.Resources.DPgreen
                    DPBoss.Enabled = True
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Glove > 0 Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = True
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = False
                Else
                    DPLabel.Image = My.Resources.DPred
                    DPBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Boots = True And Glove > 0 And DPBigKey.Checked = True Then
                    If DPKeys.Text = 1 Then DPLabel.Image = My.Resources.DPgreen Else DPLabel.Image = My.Resources.DPorange
                    DPLabel.ForeColor = Color.White
                    DPBoss.Enabled = True
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True And (FireRod = True Or Lamp = True) And Glove > 0 And DPBigKey.Checked = True Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = True
                ElseIf Pearl = True And (Aganhim = True Or Hammer = True Or Glove = 2) And Book = True Then
                    DPLabel.Image = My.Resources.DPyellow
                    DPBoss.Enabled = False
                Else
                    DPLabel.Image = My.Resources.DPred
                    DPBoss.Enabled = False
                End If
            Case 6
                DPLabel.Image = My.Resources.DPgreen
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
                If TOHChests.Text = 0 Then TOHChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TOHChests.Text < 6 Then TOHChests.Text = TOHChests.Text + 1
                TOHChests.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TOHPrizes_MouseDown(sender As Object, e As EventArgs) Handles TOHPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If TOHPrizes.Text > 0 Then TOHPrizes.Text = TOHPrizes.Text - 1
                If TOHPrizes.Text = 0 Then TOHPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 6 Then
                    If TOHPrizes.Text < 2 Then TOHPrizes.Text = TOHPrizes.Text + 1
                Else
                    If TOHPrizes.Text < 3 Then TOHPrizes.Text = TOHPrizes.Text + 1
                End If
                TOHPrizes.BackColor = Color.Black
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
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.Image = My.Resources.TOHgreen Else TOHLabel.Image = My.Resources.TOHorange
                ElseIf (Glove > 0 Or Flute = True) And (Mirror = True Or (Hammer = True And Hookshot = True)) And (Sword > 0 Or Hammer = True) Then
                    TOHLabel.Image = My.Resources.TOHyellow
                    HeraBoss.Enabled = True
                ElseIf (Glove > 0 Or Flute = True) And (Mirror = True Or (Hammer = True And Hookshot = True)) Then
                    TOHLabel.Image = My.Resources.TOHyellow
                    HeraBoss.Enabled = False
                Else
                    TOHLabel.Image = My.Resources.TOHred
                    HeraBoss.Enabled = False
                End If
            Case 1, 4
                If (Glove > 0 Or Flute = True) And Hammer = True And Hookshot = True And (Sword > 0 Or Hammer = True) And (Lamp = True Or FireRod = True) And HeraBigKey.Checked = True Then
                    TOHLabel.ForeColor = Color.White
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.Image = My.Resources.TOHgreen Else TOHLabel.Image = My.Resources.TOHorange
                ElseIf (Flute = True Or Glove > 0) And (Mirror = True Or (Hammer = True And Hookshot = True)) And HeraBigKey.Checked = True Then
                    TOHLabel.Image = My.Resources.TOHyellow
                    HeraBoss.Enabled = False
                Else
                    TOHLabel.Image = My.Resources.TOHred
                    HeraBoss.Enabled = False
                End If
            Case 6
                TOHLabel.Image = My.Resources.TOHgreen
                HeraBoss.Enabled = True
        End Select
    End Sub
    Public Sub InvTOHCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And ((Glove = 2 And Hammer = True) Or (Glove = 1 And Hammer = True And Hookshot = True)) And (Lamp = True Or FireRod = True) Then
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.Image = My.Resources.TOHgreen Else TOHLabel.Image = My.Resources.TOHorange
                ElseIf Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True Then
                    TOHLabel.Image = My.Resources.TOHyellow
                    HeraBoss.Enabled = True
                Else
                    TOHLabel.Image = My.Resources.TOHred
                    HeraBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And ((Glove = 2 And Hammer = True) Or (Glove = 1 And Hammer = True And Hookshot = True)) And Hammer = True And (Lamp = True Or FireRod = True) And HeraBigKey.Checked = True Then
                    HeraBoss.Enabled = True
                    If Flute = True Or Lamp = True Then TOHLabel.Image = My.Resources.TOHgreen Else TOHLabel.Image = My.Resources.TOHorange
                ElseIf Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True And HeraBigKey.Checked = True Then
                    TOHLabel.Image = My.Resources.TOHyellow
                    HeraBoss.Enabled = False
                ElseIf Pearl = True And (Glove > 0 Or Flute = True) And Hammer = True Then
                    TOHLabel.Image = My.Resources.TOHyellow
                    HeraBoss.Enabled = False
                Else
                    TOHLabel.Image = My.Resources.TOHred
                    HeraBoss.Enabled = False
                End If
            Case 6
                TOHLabel.Image = My.Resources.TOHgreen
                HeraBoss.Enabled = True
        End Select
    End Sub
    Private Sub AGPrizes_MouseDown(sender As Object, e As EventArgs) Handles AGPrizes.MouseDown
        If ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 5 Or ComboBox1.SelectedIndex = 6 Then
            If MouseButtons = MouseButtons.Left Then
                If AGPrizes.Text > 0 Then AGPrizes.Text = AGPrizes.Text - 1
                If AGPrizes.Text = 0 Then AGPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If AGPrizes.Text < 2 Then AGPrizes.Text = AGPrizes.Text + 1
                AGPrizes.BackColor = Color.Black
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
                    AGLabel.Image = My.Resources.AGgreen
                    AGChests.Text = 2
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                    AGChests.Text = 0
                End If
            Case 3, 5
                If Cape = True And Hammer = True And Lamp = True Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.Image = My.Resources.AGgreen
                    AGChests.Text = 2
                ElseIf Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                    AGChests.Text = 1
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                    AGChests.Text = 0
                End If
            Case 1
                If (Sword >= 2 Or (Cape = True And Sword > 0)) And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.Image = My.Resources.AGgreen
                ElseIf Sword >= 2 Or Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGyellow
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                End If
            Case 4
                If Hammer = True And Cape = True And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.Image = My.Resources.AGgreen
                ElseIf Hammer = True Or Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGyellow
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                End If
            Case 6
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                AGLabel.Image = My.Resources.AGgreen
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
                    AGLabel.Image = My.Resources.AGgreen
                    AGChests.Text = 2
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                    AGChests.Text = 0
                End If
            Case 3, 5
                If (Glove > 0 Or Flute = True) And Net = True And Lamp = True Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.Image = My.Resources.AGgreen
                    AGChests.Text = 2
                ElseIf Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                    AGChests.Text = 1
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                    AGChests.Text = 0
                End If
            Case 1
                If (Glove > 0 Or Flute = True) And Sword > 0 And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.Image = My.Resources.AGgreen
                ElseIf Glove > 0 Or Flute = True Then
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGyellow
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                End If
            Case 4
                If (Glove > 0 Or Flute = True) And Net = True And Lamp = True And AGKeys.Text = 2 Then
                    AgaButton.Visible = True
                    If Aganhim = False Then AgaButton.Image = noaganhim
                    AGLabel.Image = My.Resources.AGgreen
                ElseIf Hammer = True Or Cape = True Then
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGyellow
                Else
                    AgaButton.Visible = False
                    AGLabel.Image = My.Resources.AGred
                End If
            Case 6
                AgaButton.Visible = True
                If Aganhim = False Then AgaButton.Image = noaganhim
                AGLabel.Image = My.Resources.AGgreen
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
                If PODChests.Text = 0 Then PODChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If PODChests.Text < 14 Then PODChests.Text = PODChests.Text + 1
                PODChests.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub PODPrizes_MouseDown(sender As Object, e As EventArgs) Handles PODPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If PODPrizes.Text > 0 Then PODPrizes.Text = PODPrizes.Text - 1
                If PODPrizes.Text = 0 Then PODPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex Mod 3 = 0 Then
                    If PODPrizes.Text < 5 Then PODPrizes.Text = PODPrizes.Text + 1
                Else
                    If PODPrizes.Text < 11 Then PODPrizes.Text = PODPrizes.Text + 1
                End If
                PODPrizes.BackColor = Color.Black
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
                    If Lamp = True Then PODLabel.Image = My.Resources.PODgreen Else PODLabel.Image = My.Resources.PODorange
                ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) And Bow > 1 Then
                    PODBoss.Enabled = False
                    PODLabel.Image = My.Resources.PODyellow
                ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                    PODBoss.Enabled = False
                    PODLabel.Image = My.Resources.PODyellow
                Else
                    PODBoss.Enabled = False
                    PODLabel.Image = My.Resources.PODred
                End If
            Case 1, 4
                If Pearl = True And Hammer = True And Bow > 1 And (Aganhim = True Or Glove > 1) And PODBigKey.Checked = True And PODKeys.Text >= 1 Then
                    PODBoss.Enabled = True
                    If Lamp = True And PODKeys.Text = 6 Then PODLabel.Image = My.Resources.PODgreen Else PODLabel.Image = My.Resources.PODorange
                ElseIf Pearl = True And (Aganhim = True Or (Hammer = True And Glove > 0) Or (Glove = 2 And Flippers = True)) Then
                    PODLabel.Image = My.Resources.PODyellow
                    PODBoss.Enabled = False
                Else
                    PODLabel.Image = My.Resources.PODred
                    PODBoss.Enabled = False
                End If
            Case 6
                PODBoss.Enabled = True
                PODLabel.Image = My.Resources.PODgreen
        End Select
    End Sub
    Public Sub InvPODCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Hammer = True And Bow > 1 Then
                    PODBoss.Enabled = True
                    If Lamp = True Then PODLabel.Image = My.Resources.PODgreen Else PODLabel.Image = My.Resources.PODorange
                ElseIf Flippers = True Or Hammer = True Then
                    If Lamp = True Then PODChests.ForeColor = Color.White Else PODChests.ForeColor = Color.Yellow
                    PODLabel.Image = My.Resources.PODyellow
                Else
                    PODBoss.Enabled = False
                    PODLabel.Image = My.Resources.PODred
                End If
            Case 1, 4
                If Hammer = True And Bow > 1 And PODBigKey.Checked = True And PODKeys.Text >= 1 Then
                    PODBoss.Enabled = True
                    If Lamp = True And PODKeys.Text = 6 Then PODLabel.Image = My.Resources.PODgreen Else PODLabel.Image = My.Resources.PODorange
                ElseIf Hammer = True Or Flippers = True Then
                    PODLabel.Image = My.Resources.PODyellow
                    PODBoss.Enabled = False
                Else
                    PODLabel.Image = My.Resources.PODred
                    PODBoss.Enabled = False
                End If
            Case 6
                PODBoss.Enabled = True
                PODLabel.Image = My.Resources.PODgreen
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
                If SPChests.Text = 0 Then SPChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SPChests.Text < 10 Then SPChests.Text = SPChests.Text + 1
                SPChests.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SPPrizes_MouseDown(sender As Object, e As EventArgs) Handles SPPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If SPPrizes.Text > 0 Then SPPrizes.Text = SPPrizes.Text - 1
                If SPPrizes.Text = 0 Then SPPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex Mod 3 = 0 Then
                    If SPPrizes.Text < 6 Then SPPrizes.Text = SPPrizes.Text + 1
                Else
                    If SPPrizes.Text < 7 Then SPPrizes.Text = SPPrizes.Text + 1
                End If
                SPPrizes.BackColor = Color.Black
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
                    SPLabel.Image = My.Resources.SPgreen
                    SPBoss.Enabled = True
                ElseIf Pearl = True And Flippers = True And Mirror = True And Hammer = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.Image = My.Resources.SPyellow
                    SPBoss.Enabled = False
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or Aganhim = True) Then
                    SPLabel.Image = My.Resources.SPyellow
                    SPBoss.Enabled = False
                Else
                    SPLabel.Image = My.Resources.SPred
                    SPBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SPKeys.Text = 1 Then
                    SPLabel.Image = My.Resources.SPgreen
                    SPBoss.Enabled = True
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                    SPLabel.Image = My.Resources.SPyellow
                    SPBoss.Enabled = False
                Else
                    SPLabel.Image = My.Resources.SPred
                    SPBoss.Enabled = False
                End If
            Case 6
                SPLabel.Image = My.Resources.SPgreen
                SPBoss.Enabled = True
        End Select
    End Sub

    Public Sub InvSPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.Image = My.Resources.SPgreen
                    SPBoss.Enabled = True
                ElseIf Pearl = True And Flippers = True And Mirror = True And Hammer = True And (Glove > 0 Or Aganhim = True) Then
                    SPLabel.Image = My.Resources.SPyellow
                    SPBoss.Enabled = False
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or Aganhim = True) Then
                    SPLabel.Image = My.Resources.SPyellow
                    SPBoss.Enabled = False
                Else
                    SPLabel.Image = My.Resources.SPred
                    SPBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And Flippers = True And Mirror = True And Hammer = True And Hookshot = True And (Glove > 0 Or Aganhim = True) And SPKeys.Text = 1 Then
                    SPLabel.Image = My.Resources.SPgreen
                    SPBoss.Enabled = True
                ElseIf Pearl = True And Flippers = True And Mirror = True And (Glove = 2 Or (Hammer = True And (Glove > 0 Or Aganhim = True))) Then
                    SPLabel.Image = My.Resources.SPyellow
                    SPBoss.Enabled = False
                Else
                    SPLabel.Image = My.Resources.SPred
                    SPBoss.Enabled = False
                End If
            Case 6
                SPLabel.Image = My.Resources.SPgreen
                SPBoss.Enabled = True
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
                If SWChests.Text = 0 Then SWChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If SWChests.Text < 8 Then SWChests.Text = SWChests.Text + 1
                SWChests.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub SWPrizes_MouseDown(sender As Object, e As EventArgs) Handles SWPrizes.MouseDown
        If ComboBox1.SelectedIndex <> 1 And ComboBox1.SelectedIndex <> 4 Then
            If MouseButtons = MouseButtons.Left Then
                If SWPrizes.Text > 0 Then SWPrizes.Text = SWPrizes.Text - 1
                If SWPrizes.Text = 0 Then SWPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex Mod 3 = 0 Then
                    If SWPrizes.Text < 2 Then SWPrizes.Text = SWPrizes.Text + 1
                Else
                    If SWPrizes.Text < 5 Then SWPrizes.Text = SWPrizes.Text + 1
                End If
                SWPrizes.BackColor = Color.Black
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
                    SWLabel.Image = My.Resources.SWgreen
                    SWBoss.Enabled = True
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                Else
                    SWLabel.Image = My.Resources.SWred
                    SWBoss.Enabled = False
                End If
            Case 3, 5
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                    SWLabel.Image = My.Resources.SWgreen
                    SWBoss.Enabled = True
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                Else
                    SWLabel.Image = My.Resources.SWred
                    SWBoss.Enabled = False
                End If
            Case 1
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True And Sword > 0 Then
                    If SWKeys.Text >= 2 Then
                        SWLabel.Image = My.Resources.SWgreen
                    Else
                        SWLabel.Image = My.Resources.SWorange
                    End If
                    SWBoss.Enabled = True
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                Else
                    SWLabel.Image = My.Resources.SWred
                    SWBoss.Enabled = False
                End If
            Case 4
                If Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) And FireRod = True Then
                    If SWKeys.Text >= 2 Then
                        SWLabel.Image = My.Resources.SWgreen
                    Else
                        SWLabel.Image = My.Resources.SWorange
                    End If
                    SWBoss.Enabled = True
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                Else
                    SWLabel.Image = My.Resources.SWred
                    SWBoss.Enabled = False
                End If
            Case 6
                SWLabel.Image = My.Resources.SWgreen
                SWChests.Text = 8
                SWChests.ForeColor = Color.White
                SWBoss.Enabled = True
        End Select
    End Sub

    Public Sub InvSWCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If FireRod = True And Sword > 0 Then
                    SWLabel.Image = My.Resources.SWgreen
                    SWBoss.Enabled = True
                ElseIf FireRod = True Then
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                Else
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                End If
            Case 3, 5
                If FireRod = True Then
                    SWLabel.Image = My.Resources.SWgreen
                    SWBoss.Enabled = True
                Else
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                End If
            Case 1
                If FireRod = True And Sword > 0 Then
                    If SWKeys.Text >= 2 Then SWLabel.Image = My.Resources.SWgreen Else SWLabel.Image = My.Resources.SWorange
                    SWLabel.ForeColor = Color.White
                    SWBoss.Enabled = True
                Else
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                End If
            Case 4
                If FireRod = True Then
                    If SWKeys.Text >= 2 Then SWLabel.Image = My.Resources.SWgreen Else SWLabel.Image = My.Resources.SWorange
                    SWLabel.ForeColor = Color.White
                    SWBoss.Enabled = True
                Else
                    SWLabel.Image = My.Resources.SWyellow
                    SWBoss.Enabled = False
                End If
            Case 6
                SWLabel.Image = My.Resources.SWgreen
                SWBoss.Enabled = True
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
            Aganhim = False
            Sword = 0
            Armor = 0
            Shield = 0
            MedallionCount = 0

            ' Resetting dungeon rewards/macguffin counts, clearing notes
            MireMedallion = 0
            MireBEQ.Image = My.Resources.whatmedallion
            TurtleMedallion = 0
            TurtleBEQ.Image = My.Resources.whatmedallion
            If ComboBox1.SelectedIndex Mod 3 = 1 Then
                EPReward = -1 : EPButton.Image = Nothing
                DPReward = -1 : DPButton.Image = Nothing
                TOHReward = -1 : TOHButton.Image = Nothing
                PODReward = -1 : PODButton.Image = Nothing
                SPReward = -1 : SPButton.Image = Nothing
                SWReward = -1 : SWButton.Image = Nothing
                TTReward = -1 : TTButton.Image = Nothing
                IPReward = -1 : IPButton.Image = Nothing
                MMReward = -1 : MMButton.Image = Nothing
                TRReward = -1 : TRButton.Image = Nothing
            Else
                EPReward = 0 : EPButton.Image = My.Resources.crystal
                DPReward = 0 : DPButton.Image = My.Resources.crystal
                TOHReward = 0 : TOHButton.Image = My.Resources.crystal
                PODReward = 0 : PODButton.Image = My.Resources.crystal
                SPReward = 0 : SPButton.Image = My.Resources.crystal
                SWReward = 0 : SWButton.Image = My.Resources.crystal
                TTReward = 0 : TTButton.Image = My.Resources.crystal
                IPReward = 0 : IPButton.Image = My.Resources.crystal
                MMReward = 0 : MMButton.Image = My.Resources.crystal
                TRReward = 0 : TRButton.Image = My.Resources.crystal
            End If
            CrystalCount = 0
            FairyCrystal = 0
            PendantCount = 0
            GreenPendant = False
            TextBox1.Text = Nothing

            ' Resetting all dungeons
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then HCPrizes.Text = 6 Else HCPrizes.Text = 7
            HCPrizes.BackColor = Color.Black
            HCChests.Text = 8
            HCChests.BackColor = Color.Black
            HCKeys.Text = 0
            EPPrizes.Text = 3
            EPPrizes.BackColor = Color.Black
            EPChests.Text = 6
            EPChests.BackColor = Color.Black
            EPKeys.Text = "-"
            EPMap.Checked = False
            EPBigKey.Checked = False
            EPBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then DPPrizes.Text = 2 Else DPPrizes.Text = 3
            DPPrizes.BackColor = Color.Black
            DPChests.Text = 6
            DPChests.BackColor = Color.Black
            DPKeys.Text = 0
            DPMap.Checked = False
            DPBigKey.Checked = False
            DPBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then TOHPrizes.Text = 2 Else TOHPrizes.Text = 3
            TOHPrizes.BackColor = Color.Black
            TOHChests.Text = 6
            TOHChests.BackColor = Color.Black
            TOHKeys.Text = 0
            HeraMap.Checked = False
            HeraBigKey.Checked = False
            HeraBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then AGPrizes.Text = 0 Else AGPrizes.Text = 2
            AGPrizes.BackColor = Color.Black
            AGChests.Text = 2
            AGChests.BackColor = Color.Black
            AGKeys.Text = 0
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then PODPrizes.Text = 5 Else PODPrizes.Text = 11
            PODPrizes.BackColor = Color.Black
            PODChests.Text = 14
            PODChests.BackColor = Color.Black
            PODKeys.Text = 0
            PODMap.Checked = False
            PODBigKey.Checked = False
            PODBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then SPPrizes.Text = 6 Else SPPrizes.Text = 7
            SPPrizes.BackColor = Color.Black
            SPChests.Text = 10
            SPChests.BackColor = Color.Black
            SPKeys.Text = 0
            SPMap.Checked = False
            SPBigKey.Checked = False
            SPBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then SWPrizes.Text = 2 Else SWPrizes.Text = 5
            SWPrizes.BackColor = Color.Black
            SWChests.Text = 8
            SWChests.BackColor = Color.Black
            SWKeys.Text = 0
            SWMap.Checked = False
            SWBigKey.Checked = False
            SWBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then TTPrizes.Text = 4 Else TTPrizes.Text = 5
            TTPrizes.BackColor = Color.Black
            TTChests.Text = 8
            TTChests.BackColor = Color.Black
            TTKeys.Text = 0
            TTMap.Checked = False
            TTBigKey.Checked = False
            TTBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then IPPrizes.Text = 3 Else IPPrizes.Text = 5
            IPPrizes.BackColor = Color.Black
            IPChests.Text = 8
            IPChests.BackColor = Color.Black
            IPKeys.Text = 0
            IPMap.Checked = False
            IPBigKey.Checked = False
            IPBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then MMPrizes.Text = 2 Else MMPrizes.Text = 5
            MMPrizes.BackColor = Color.Black
            MMChests.Text = 8
            MMChests.BackColor = Color.Black
            MMKeys.Text = 0
            MMMap.Checked = False
            MMBigKey.Checked = False
            MMBoss.Checked = False
            If ComboBox1.SelectedIndex Mod 3 <> 2 Then TRPrizes.Text = 5 Else TRPrizes.Text = 9
            TRPrizes.BackColor = Color.Black
            TRChests.Text = 12
            TRChests.BackColor = Color.Black
            TRKeys.Text = 0
            TRMap.Checked = False
            TRBigKey.Checked = False
            TRBoss.Checked = False
            GTChests.Text = 27
            GTChests.BackColor = Color.Black
            GTKeys.Text = 0
            GTBigKey.Checked = False

            '' Resetting all locations
            LW1.Tag = 0
            LW2.Tag = 0
            LW3.Tag = 0
            LW4.Tag = 0
            LW5.Tag = 0
            LW6.Tag = 0
            LW7.Tag = 0
            LW8.Tag = 0
            LW9.Tag = 0
            LW10.Tag = 0
            LW11.Tag = 0
            LW12.Tag = 0
            LW13.Tag = 0
            LW14.Tag = 0
            LW15.Tag = 0
            LW16.Tag = 0
            LW17.Tag = 0
            LW18.Tag = 0
            LW19.Tag = 0
            LW20.Tag = 0
            LW21.Tag = 0
            LW22.Tag = 0
            LW23.Tag = 0
            LW24.Tag = 0
            LW25.Tag = 0
            LW26.Tag = 0
            LW27.Tag = 0
            LW28.Tag = 0
            LW29.Tag = 0
            LW30.Tag = 0
            LW31.Tag = 0
            LW32.Tag = 0
            LW33.Tag = 0
            LW34.Tag = 0
            LW35.Tag = 0
            LW36.Tag = 0
            LW37.Tag = 0
            LW38.Tag = 0
            LW39.Tag = 0
            LW40.Tag = 0
            LW41.Tag = 0
            LW42.Tag = 0
            LW43.Tag = 0
            LW44.Tag = 0
            DW1.Tag = 0
            DW2.Tag = 0
            DW3.Tag = 0
            DW4.Tag = 0
            DW5.Tag = 0
            DW6.Tag = 0
            DW7.Tag = 0
            DW8.Tag = 0
            DW9.Tag = 0
            DW10.Tag = 0
            DW11.Tag = 0
            DW12.Tag = 0
            DW13.Tag = 0
            DW14.Tag = 0
            DW15.Tag = 0
            DW16.Tag = 0

            '' Resetting Logic
            LogicCheck()
        End If
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

    Private Sub LWButtons_Click(sender As Object, e As EventArgs) Handles LW1.MouseDown, LW2.MouseDown, LW3.MouseDown, LW4.MouseDown, LW5.MouseDown, LW6.MouseDown, LW7.MouseDown, LW8.MouseDown, LW9.MouseDown, LW10.MouseDown, LW11.MouseDown,
            LW12.MouseDown, LW13.MouseDown, LW14.MouseDown, LW15.MouseDown, LW16.MouseDown, LW17.MouseDown, LW18.MouseDown, LW19.MouseDown, LW20.MouseDown, LW21.MouseDown, LW22.MouseDown, LW23.MouseDown, LW24.MouseDown,
            LW25.MouseDown, LW26.MouseDown, LW27.MouseDown, LW28.MouseDown, LW29.MouseDown, LW30.MouseDown, LW31.MouseDown, LW32.MouseDown, LW33.MouseDown, LW34.MouseDown, LW35.MouseDown, LW36.MouseDown, LW37.MouseDown,
            LW38.MouseDown, LW39.MouseDown, LW40.MouseDown, LW41.MouseDown, LW42.MouseDown, LW43.MouseDown, LW44.MouseDown, DW1.MouseDown,
            DW2.MouseDown, DW3.MouseDown, DW4.MouseDown, DW5.MouseDown, DW6.MouseDown, DW7.MouseDown, DW8.MouseDown, DW9.MouseDown, DW10.MouseDown, DW11.MouseDown, DW12.MouseDown,
            DW13.MouseDown, DW14.MouseDown, DW15.MouseDown, DW16.MouseDown

        If DirectCast(sender, Label).Tag = 0 Then
            DirectCast(sender, Label).Tag = 1
            DirectCast(sender, Label).Image = My.Resources.lightoff
        Else
            DirectCast(sender, Label).Tag = 0
        End If

        If Inverted.Checked = True Then
            InvLWCheck() : InvDWCheck()
        Else
            LWCheck() : DWCheck() : TRCheck()
        End If
    End Sub

    Private Sub LWButtons_Click(sender As Object, e As MouseEventArgs) Handles LW2.MouseDown, LW1.MouseDown, LW9.MouseDown, LW8.MouseDown, LW7.MouseDown, LW6.MouseDown, LW44.MouseDown, LW43.MouseDown, LW42.MouseDown, LW41.MouseDown, LW40.MouseDown, LW39.MouseDown, LW38.MouseDown, LW37.MouseDown, LW36.MouseDown, LW35.MouseDown, LW34.MouseDown, LW33.MouseDown, LW32.MouseDown, LW31.MouseDown, LW30.MouseDown, LW29.MouseDown, LW28.MouseDown, LW27.MouseDown, LW26.MouseDown, LW25.MouseDown, LW24.MouseDown, LW23.MouseDown, LW22.MouseDown, LW21.MouseDown, LW20.MouseDown, LW19.MouseDown, LW18.MouseDown, LW17.MouseDown, LW16.MouseDown, LW15.MouseDown, LW14.MouseDown, LW13.MouseDown, LW12.MouseDown, LW11.MouseDown, LW10.MouseDown, DW9.MouseDown, DW8.MouseDown, DW7.MouseDown, DW6.MouseDown, DW5.MouseDown, DW4.MouseDown, DW3.MouseDown, DW2.MouseDown, DW16.MouseDown, DW15.MouseDown, DW14.MouseDown, DW13.MouseDown, DW12.MouseDown, DW11.MouseDown, DW10.MouseDown, DW1.MouseDown, LW5.MouseDown, LW4.MouseDown, LW3.MouseDown

    End Sub

    Private Sub AGPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles AGPrizes.MouseDown

    End Sub

    Private Sub HCPrizes_MouseDown(sender As Object, e As MouseEventArgs) Handles HCPrizes.MouseDown

    End Sub

    Private Sub MagicButton_Click(sender As Object, e As MouseEventArgs) Handles MagicButton.MouseDown

    End Sub

    Private Sub TurtleBEQ_Click(sender As Object, e As MouseEventArgs) Handles TurtleBEQ.MouseDown

    End Sub

    Private Sub MireBEQ_Click(sender As Object, e As MouseEventArgs) Handles MireBEQ.MouseDown

    End Sub

    Private Sub GTChests_MouseDown(sender As Object, e As MouseEventArgs) Handles GTChests.MouseDown

    End Sub

    Private Sub HCChests_MouseDown(sender As Object, e As MouseEventArgs) Handles HCChests.MouseDown

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

    Private Sub SPKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles SPKeys.MouseDown

    End Sub

    Private Sub PODKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles PODKeys.MouseDown

    End Sub

    Private Sub HeraKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles TOHKeys.MouseDown

    End Sub

    Private Sub DPKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles DPKeys.MouseDown

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

    Private Sub AGKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles AGKeys.MouseDown

    End Sub

    Private Sub GTKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles GTKeys.MouseDown

    End Sub

    Private Sub HCKeys_MouseDown(sender As Object, e As MouseEventArgs) Handles HCKeys.MouseDown

    End Sub

    Private Sub CrystalClick(sender As Object, e As MouseEventArgs) Handles TTButton.MouseDown, TRButton.MouseDown, TOHButton.MouseDown, SWButton.MouseDown, SPButton.MouseDown, PODButton.MouseDown, MMButton.MouseDown, IPButton.MouseDown, EPButton.MouseDown, DPButton.MouseDown

    End Sub

    Private Sub LW30_Click(sender As Object, e As EventArgs) Handles LW30.Click

    End Sub

    Private Sub LW29_Click(sender As Object, e As EventArgs) Handles LW29.Click

    End Sub

    Private Sub LW28_Click(sender As Object, e As EventArgs) Handles LW28.Click

    End Sub

    Private Sub LW27_Click(sender As Object, e As EventArgs) Handles LW27.Click

    End Sub

    Private Sub LW26_Click(sender As Object, e As EventArgs) Handles LW26.Click

    End Sub

    Private Sub LW25_Click(sender As Object, e As EventArgs) Handles LW25.Click

    End Sub

    Private Sub LW24_Click(sender As Object, e As EventArgs) Handles LW24.Click

    End Sub

    Private Sub LW23_Click(sender As Object, e As EventArgs) Handles LW23.Click

    End Sub

    Private Sub LW22_Click(sender As Object, e As EventArgs) Handles LW22.Click

    End Sub

    Private Sub LW21_Click(sender As Object, e As EventArgs) Handles LW21.Click

    End Sub

    Private Sub LW20_Click(sender As Object, e As EventArgs) Handles LW20.Click

    End Sub

    Private Sub LW19_Click(sender As Object, e As EventArgs) Handles LW19.Click

    End Sub

    Private Sub LW18_Click(sender As Object, e As EventArgs) Handles LW18.Click

    End Sub

    Private Sub LW17_Click(sender As Object, e As EventArgs) Handles LW17.Click

    End Sub

    Private Sub LW16_Click(sender As Object, e As EventArgs) Handles LW16.Click

    End Sub

    Private Sub LW15_Click(sender As Object, e As EventArgs) Handles LW15.Click

    End Sub

    Private Sub LW14_Click(sender As Object, e As EventArgs) Handles LW14.Click

    End Sub

    Private Sub LW13_Click(sender As Object, e As EventArgs) Handles LW13.Click

    End Sub

    Private Sub LW12_Click(sender As Object, e As EventArgs) Handles LW12.Click

    End Sub

    Private Sub LW11_Click(sender As Object, e As EventArgs) Handles LW11.Click

    End Sub

    Private Sub LW10_Click(sender As Object, e As EventArgs) Handles LW10.Click

    End Sub

    Private Sub LW9_Click(sender As Object, e As EventArgs) Handles LW9.Click

    End Sub

    Private Sub LW8_Click(sender As Object, e As EventArgs) Handles LW8.Click

    End Sub

    Private Sub LW7_Click(sender As Object, e As EventArgs) Handles LW7.Click

    End Sub

    Private Sub LW6_Click(sender As Object, e As EventArgs) Handles LW6.Click

    End Sub

    Private Sub LW5_Click(sender As Object, e As EventArgs) Handles LW5.Click

    End Sub

    Private Sub LW4_Click(sender As Object, e As EventArgs) Handles LW4.Click

    End Sub

    Private Sub LW3_Click(sender As Object, e As EventArgs) Handles LW3.Click

    End Sub

    Private Sub LW2_Click(sender As Object, e As EventArgs) Handles LW2.Click

    End Sub

    Private Sub LW1_Click(sender As Object, e As EventArgs) Handles LW1.Click

    End Sub

    Private Sub HCLabel_Click(sender As Object, e As EventArgs) Handles HCLabel.DoubleClick
        HCPrizes.Text = 0 : HCPrizes.BackColor = Color.Green
        HCChests.Text = 0 : HCChests.BackColor = Color.Green
    End Sub

    Private Sub EPLabel_Click(sender As Object, e As EventArgs) Handles EPLabel.DoubleClick
        If EPBoss.Enabled = False Then GoTo Line1
        EPBoss.Checked = True
        EPPrizes.Text = 0 : EPPrizes.BackColor = Color.Green
        EPChests.Text = 0 : EPChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub DPLabel_Click(sender As Object, e As EventArgs) Handles DPLabel.DoubleClick
        If DPBoss.Enabled = False Then GoTo Line1
        DPBoss.Checked = True
        DPPrizes.Text = 0 : DPPrizes.BackColor = Color.Green
        DPChests.Text = 0 : DPChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub TOHLabel_Click(sender As Object, e As EventArgs) Handles TOHLabel.DoubleClick
        If HeraBoss.Enabled = False Then GoTo Line1
        HeraBoss.Checked = True
        TOHPrizes.Text = 0 : TOHPrizes.BackColor = Color.Green
        TOHChests.Text = 0 : TOHChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub PODLabel_Click(sender As Object, e As EventArgs) Handles PODLabel.DoubleClick
        If PODBoss.Enabled = False Then GoTo Line1
        PODBoss.Checked = True
        PODPrizes.Text = 0 : PODPrizes.BackColor = Color.Green
        PODChests.Text = 0 : PODChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub SPLabel_Click(sender As Object, e As EventArgs) Handles SPLabel.DoubleClick
        If SPBoss.Enabled = False Then GoTo Line1
        SPBoss.Checked = True
        SPPrizes.Text = 0 : SPPrizes.BackColor = Color.Green
        SPChests.Text = 0 : SPChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub SWLabel_Click(sender As Object, e As EventArgs) Handles SWLabel.DoubleClick
        If SWBoss.Enabled = False Then GoTo Line1
        SWBoss.Checked = True
        SWPrizes.Text = 0 : SWPrizes.BackColor = Color.Green
        SWChests.Text = 0 : SWChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub TTLabel_Click(sender As Object, e As EventArgs) Handles TTLabel.DoubleClick
        If TTBoss.Enabled = False Then GoTo Line1
        TTBoss.Checked = True
        TTPrizes.Text = 0 : TTPrizes.BackColor = Color.Green
        TTChests.Text = 0 : TTChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub IPLabel_Click(sender As Object, e As EventArgs) Handles IPLabel.DoubleClick
        If IPBoss.Enabled = False Then GoTo Line1
        IPBoss.Checked = True
        IPPrizes.Text = 0 : IPPrizes.BackColor = Color.Green
        IPChests.Text = 0 : IPChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub MMLabel_Click(sender As Object, e As EventArgs) Handles MMLabel.DoubleClick
        If MMBoss.Enabled = False Then GoTo Line1
        MMBoss.Checked = True
        MMPrizes.Text = 0 : MMPrizes.BackColor = Color.Green
        MMChests.Text = 0 : MMChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub TRLabel_Click(sender As Object, e As EventArgs) Handles TRLabel.DoubleClick
        If TRBoss.Enabled = False Then GoTo Line1
        TRBoss.Checked = True
        TRPrizes.Text = 0 : TRPrizes.BackColor = Color.Green
        TRChests.Text = 0 : TRChests.BackColor = Color.Green
Line1:
    End Sub

    Private Sub NoteButton_Click(sender As Object, e As EventArgs) Handles NoteButton.Click
        If Me.Height = 526 Then
            Me.Height = 626
            NoteButton.Text = "Close Notes"
        Else
            Me.Height = 526
            NoteButton.Text = "Open Notes"
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
                If TTPrizes.Text = 0 Then TTPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If TTPrizes.Text < 4 Then TTPrizes.Text = TTPrizes.Text + 1
                Else
                    If TTPrizes.Text < 5 Then TTPrizes.Text = TTPrizes.Text + 1
                End If
                TTPrizes.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TTChests_MouseDown(sender As Object, e As EventArgs) Handles TTChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If MouseButtons = MouseButtons.Left Then
                If TTChests.Text > 0 Then TTChests.Text = TTChests.Text - 1
                If TTChests.Text = 0 Then TTChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TTChests.Text < 8 Then TTChests.Text = TTChests.Text + 1
                TTChests.BackColor = Color.Black
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
                    TTLabel.Image = My.Resources.TTgreen
                    TTBoss.Enabled = True
                Else
                    TTLabel.Image = My.Resources.TTred
                    TTBoss.Enabled = False
                End If
            Case 1, 4
                If Pearl = True And TTBigKey.Checked = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    If TTKeys.Text = 1 Then
                        TTLabel.Image = My.Resources.TTgreen
                    Else
                        TTLabel.Image = My.Resources.TTorange
                    End If
                    TTLabel.ForeColor = Color.White
                    TTBoss.Enabled = True
                ElseIf Pearl = True And (Glove = 2 Or (Glove > 0 And Hammer = True) Or (Aganhim = True And Hookshot = True And (Glove > 0 Or Hammer = True Or Flippers = True))) Then
                    TTLabel.Image = My.Resources.TTyellow
                    TTBoss.Enabled = False
                Else
                    TTLabel.Image = My.Resources.TTred
                    TTBoss.Enabled = False
                End If
            Case 6
                TTLabel.Image = My.Resources.TTgreen
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = True
        End Select
    End Sub
    Public Sub InvTTCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If Sword > 0 Or Hammer = True Or Somaria = True Or Byrna = True Then
                    TTLabel.Image = My.Resources.TTgreen
                    TTBoss.Enabled = True
                Else
                    TTLabel.Image = My.Resources.TTorange
                    TTBoss.Enabled = False
                End If
            Case 3, 5
                If Hammer = True Or Somaria = True Or Byrna = True Then
                    TTLabel.Image = My.Resources.TTgreen
                    TTBoss.Enabled = True
                Else
                    TTLabel.Image = My.Resources.TTyellow
                    TTBoss.Enabled = False
                End If
            Case 1
                If (Sword > 0 Or Hammer = True Or Somaria = True Or Byrna = True) And TTBigKey.Checked = True Then
                    If TTKeys.Text = 1 Then TTLabel.Image = My.Resources.TTgreen Else TTLabel.Image = My.Resources.TTorange
                    TTLabel.ForeColor = Color.White
                    TTBoss.Enabled = True
                Else
                    TTLabel.Image = My.Resources.TTyellow
                    TTBoss.Enabled = False
                End If
            Case 4
                If (Hammer = True Or Somaria = True Or Byrna = True) And TTBigKey.Checked = True Then
                    If TTKeys.Text = 1 Then TTLabel.Image = My.Resources.TTgreen Else TTLabel.Image = My.Resources.TTorange
                    TTLabel.ForeColor = Color.White
                    TTBoss.Enabled = True
                Else
                    TTLabel.Image = My.Resources.TTyellow
                    TTBoss.Enabled = False
                End If
            Case 6
                TTLabel.Image = My.Resources.TTgreen
                If Hammer = True Then TTChests.Text = 8 Else TTChests.Text = 7
                TTChests.ForeColor = Color.White
                TTBoss.Enabled = True
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
                If IPPrizes.Text = 0 Then IPPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If IPPrizes.Text < 3 Then IPPrizes.Text = IPPrizes.Text + 1
                Else
                    If IPPrizes.Text < 5 Then IPPrizes.Text = IPPrizes.Text + 1
                End If
                IPPrizes.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub IPChests_MouseDown(sender As Object, e As EventArgs) Handles IPChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If MouseButtons = MouseButtons.Left Then
                If IPChests.Text > 0 Then IPChests.Text = IPChests.Text - 1
                If IPChests.Text = 0 Then IPChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If IPChests.Text < 8 Then IPChests.Text = IPChests.Text + 1
                IPChests.BackColor = Color.Green
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
                    IPBoss.Enabled = True
                    If Flippers = True Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 3, 5
                If Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True Then
                    IPBoss.Enabled = True
                    If Flippers = True Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or Bombos = True) And Hammer = True Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And FireRod = True Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 1
                If Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                    IPBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And (FireRod = True Or (Bombos = True And Sword > 0)) Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 4
                If Pearl = True And Glove = 2 And (FireRod = True And Bombos = True) And Hammer = True And Hookshot = True Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                    IPBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And (FireRod = True And Bombos = True) And Hammer = True Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And FireRod = True Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 6
                IPBoss.Enabled = True
                IPLabel.Image = My.Resources.IPgreen
        End Select
    End Sub
    Public Sub InvIPCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True And Glove > 0 Then
                    IPBoss.Enabled = True
                    If Flippers = True Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                ElseIf (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Glove > 0 Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf (FireRod = True Or (Bombos = True And Sword > 0)) Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 3, 5
                If (FireRod = True Or Bombos = True) And Hammer = True And Hookshot = True And Glove > 0 Then
                    IPChests.Text = 8
                    IPBoss.Enabled = True
                    If Flippers = True Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                ElseIf (FireRod = True Or Bombos = True) And Hammer = True And Glove > 0 Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf FireRod = True Or (Bombos = True And Hammer = True) Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 1
                If (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Hookshot = True And Glove > 0 Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                    IPLabel.ForeColor = Color.White
                    IPBoss.Enabled = True
                ElseIf (FireRod = True Or (Bombos = True And Sword > 0)) And Hammer = True And Glove > 0 Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf FireRod = True Or (Bombos = True And Sword > 0) Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 4
                If (FireRod = True Or Bombos = True) And Hammer = True And Hookshot = True And Glove > 0 Then
                    If Flippers = True And ((IPKeys.Text = 2 And IPBigKey.Checked = True) Or (IPKeys.Text >= 1 And IPBigKey.Checked = True And Somaria = True)) Then IPLabel.Image = My.Resources.IPgreen Else IPLabel.Image = My.Resources.IPorange
                    IPBoss.Enabled = True
                ElseIf (FireRod = True Or Bombos = True) And Hammer = True And Glove > 0 Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = True
                ElseIf FireRod = True Or (Bombos = True And Hammer = True) Then
                    IPLabel.Image = My.Resources.IPyellow
                    IPBoss.Enabled = False
                Else
                    IPLabel.Image = My.Resources.IPred
                    IPBoss.Enabled = False
                End If
            Case 6
                IPLabel.ForeColor = Color.White
                IPBoss.Enabled = True
                IPLabel.BackColor = Color.Green
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
                If MMPrizes.Text = 0 Then MMPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If MMPrizes.Text < 2 Then MMPrizes.Text = MMPrizes.Text + 1
                Else
                    If MMPrizes.Text < 5 Then MMPrizes.Text = MMPrizes.Text + 1
                End If
                MMPrizes.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub MMChests_MouseDown(sender As Object, e As EventArgs) Handles MMChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If MouseButtons = MouseButtons.Left Then
                If MMChests.Text > 0 Then MMChests.Text = MMChests.Text - 1
                If MMChests.Text = 0 Then MMChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If MMChests.Text < 8 Then MMChests.Text = MMChests.Text + 1
                MMChests.BackColor = Color.Black
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
                    MMLabel.ForeColor = Color.White
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True Then
                        MMBoss.Enabled = True
                    Else
                        MMBoss.Enabled = False
                    End If
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 3, 5
                If Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True Then
                    MMBoss.Enabled = True
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 1
                If Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                    MMBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf Pearl = True And Glove = 2 And Flute = True And Sword > 0 And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 4
                If Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And Somaria = True And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                    MMBoss.Enabled = True
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf Pearl = True And Glove = 2 And Flute = True And Hammer = True And (Hookshot = True Or Boots = True) And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 6
                MMLabel.Image = My.Resources.MMgreen
                MMBoss.Enabled = True
        End Select
    End Sub

    Public Sub InvMMCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2
                If (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMBoss.Enabled = True
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Sword > 0 And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True) Or (MedallionCount > 0 And MireMedallion = 0)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 3, 5
                If (Flute = True Or (Pearl = True And Glove = 1 And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMBoss.Enabled = True
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                ElseIf (Flute = True Or (Pearl = True And Glove = 1 And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf (Flute = True Or (Pearl = True And Glove = 1 And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 1
                If (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                    MMBoss.Enabled = True
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Somaria = True And Sword > 0 And MedallionCount > 0 And MireMedallion = 0 Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True And MMBigKey.Checked = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf (Flute = True Or (Pearl = True And (Glove = 2 Or (Glove = 1 And Hammer = True)) And Mirror = True)) And (Hookshot = True Or Boots = True) And Sword > 0 And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True) Or (MedallionCount > 0 And MireMedallion = 0)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 4
                If (Flute = True Or (Pearl = True And Glove > 0) And Mirror = True) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And (MedallionCount = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) And MMBigKey.Checked = True Then
                    If Lamp = True Then MMLabel.Image = My.Resources.MMgreen Else MMLabel.Image = My.Resources.MMorange
                    MMBoss.Enabled = True
                ElseIf (Flute = True Or (Pearl = True And Glove > 0) And Mirror = True) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And MedallionCount > 0 And MireMedallion = 0 And MMBigKey.Checked = True Then
                    MMLabel.Image = My.Resources.MMyellow
                    If Somaria = True And MMBigKey.Checked = True Then MMBoss.Enabled = True Else MMBoss.Enabled = False
                ElseIf (Flute = True Or (Pearl = True And Glove > 0) And Mirror = True) And (Hookshot = True Or Boots = True) And Somaria = True And Hammer = True And ((MedallionCount > 0 And MireMedallion = 0) Or MireMedallion = 3 Or (MireMedallion = 1 And Bombos = True) Or (MireMedallion = 2 And Ether = True) Or (MireMedallion = 3 And Quake = True)) Then
                    MMLabel.Image = My.Resources.MMyellow
                    MMBoss.Enabled = False
                Else
                    MMLabel.Image = My.Resources.MMred
                    MMBoss.Enabled = False
                End If
            Case 6
                MMLabel.Image = My.Resources.MMgreen
                MMBoss.Enabled = True
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
                If TRPrizes.Text = 0 Then TRPrizes.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If ComboBox1.SelectedIndex = 0 Then
                    If TRPrizes.Text < 5 Then TRPrizes.Text = TRPrizes.Text + 1
                Else
                    If TRPrizes.Text < 9 Then TRPrizes.Text = TRPrizes.Text + 1
                End If
                TRPrizes.BackColor = Color.Black
            End If
        End If
    End Sub
    Private Sub TRChests_MouseDown(sender As Object, e As EventArgs) Handles TRChests.MouseDown
        If ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 4 Then
            If MouseButtons = MouseButtons.Left Then
                If TRChests.Text > 0 Then TRChests.Text = TRChests.Text - 1
                If TRChests.Text = 0 Then TRChests.BackColor = Color.Green
            End If
            If MouseButtons = MouseButtons.Right = True Then
                If TRChests.Text < 12 Then TRChests.Text = TRChests.Text + 1
                TRChests.BackColor = Color.Black
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
                    If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) Then TRLabel.Image = My.Resources.TRgreen Else TRLabel.Image = My.Resources.TRorange
                    TRBoss.Enabled = True
                    If Mirror = True Then
                        LW39.Visible = True : LW39.Image = My.Resources.lightgreen
                    Else
                        LW39.Visible = True : LW39.Image = My.Resources.lightred
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And (Hookshot = True Or Mirror = True) And MedallionCount > 0 And TurtleMedallion = 0 Then
                    TRAccess = True
                    TRLabel.Image = My.Resources.TRyellow
                    If FireRod = True And IceRod = True Then
                        TRBoss.Enabled = True
                    ElseIf FireRod = True Then
                        TRBoss.Enabled = False
                        If Mirror = True Then
                            LW39.Visible = True : LW39.Image = My.Resources.lightgreen
                        Else
                            LW39.Visible = False
                        End If
                    Else
                        TRBoss.Enabled = False
                        If Mirror = True Then
                            LW39.Visible = True : LW39.Image = My.Resources.lightyellow
                        Else
                            LW39.Visible = False
                        End If
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And FireRod = True Then
                    TRAccess = True
                    If Lamp = True Then TRChests.ForeColor = Color.White Else TRChests.ForeColor = Color.Yellow
                    TRLabel.Image = My.Resources.TRyellow
                    TRBoss.Enabled = False
                    If Mirror = True Then
                        LW39.Visible = True : LW39.Image = My.Resources.lightgreen
                    Else
                        LW39.Visible = False
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                    TRAccess = True
                    TRLabel.Image = My.Resources.TRyellow
                    TRBoss.Enabled = False
                    If Mirror = True Then
                        LW39.Visible = True : LW39.Image = My.Resources.lightyellow
                    Else
                        LW39.Visible = False
                    End If
                Else
                    TRAccess = False
                    TRLabel.Image = My.Resources.TRred
                    TRBoss.Enabled = False
                    LW39.Visible = False
                End If
            Case 1, 4
                If Pearl = True And Glove = 2 And Hammer = True And Somaria = True And FireRod = True And IceRod = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) And TRBigKey.Checked = True And TRKeys.Text >= 3 Then
                    TRAccess = True
                    If Lamp = True And TRKeys.Text = 4 And (Shield = 3 Or Byrna = True Or Cape = True) Then
                        TRLabel.Image = My.Resources.TRgreen
                    ElseIf TRKeys.Text = 4 Then
                        TRLabel.Image = My.Resources.TRorange
                    ElseIf TRKeys.Text = 3 Then
                        TRLabel.Image = My.Resources.TRyellow
                    End If
                    TRBoss.Enabled = True
                    If Mirror = True Then
                        LW39.Visible = True : LW39.Image = My.Resources.lightgreen
                    Else
                        LW39.Visible = False
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And TurtleMedallion = 0 And MedallionCount > 0 Then
                    TRAccess = True
                    TRLabel.Image = My.Resources.TRyellow
                    If FireRod = True And IceRod = True Then TRBoss.Enabled = True Else TRBoss.Enabled = False
                    If TRKeys.Text >= 2 And Mirror = True Then
                        LW39.Visible = True : LW39.Image = My.Resources.lightyellow
                    Else
                        LW39.Visible = False
                    End If
                ElseIf Pearl = True And Glove = 2 And Hammer = True And Somaria = True And Sword > 0 And (Hookshot = True Or Mirror = True) And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True)) Then
                    TRAccess = True
                    TRLabel.Image = My.Resources.TRyellow
                    TRBoss.Enabled = False
                    If TRKeys.Text >= 2 And Mirror = True Then
                        LW39.Visible = True : LW39.Image = My.Resources.lightgreen
                    Else
                        LW39.Visible = False
                    End If
                Else
                    TRAccess = False
                    TRLabel.Image = My.Resources.TRred
                    TRBoss.Enabled = False
                    LW39.Visible = False
                End If
            Case 6
                TRAccess = True
                TRLabel.Image = My.Resources.TRgreen
                TRBoss.Enabled = True
        End Select
        If LW39.Tag = 1 Then LW39.Image = My.Resources.lightoff
    End Sub

    Public Sub InvTRCheck()
        Select Case ComboBox1.SelectedIndex
            Case 0, 2, 3, 5
                If ((Glove > 0 Or Flute = True) And (Sword > 0 And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True))) Or (Pearl = True And (Hookshot = True Or Hammer = True) And Mirror = True)) Then TRAccess = True Else TRAccess = False
                If TRAccess = True Then
                    If Somaria = True And FireRod = True And IceRod = True And (Hammer = True Or Sword > 0) Then
                        If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) Then TRLabel.Image = My.Resources.TRgreen Else TRLabel.Image = My.Resources.TRorange
                        TRBoss.Enabled = True
                    ElseIf Somaria = True And FireRod = True Then
                        TRLabel.Image = My.Resources.TRyellow
                        TRBoss.Enabled = False
                    ElseIf Somaria = True Then
                        TRLabel.Image = My.Resources.TRyellow
                        TRBoss.Enabled = False
                    Else
                        TRLabel.Image = My.Resources.TRyellow
                        TRBoss.Enabled = False
                    End If
                Else
                    TRLabel.Image = My.Resources.TRred
                    TRBoss.Enabled = False
                End If
            Case 1, 4
                If ((Glove > 0 Or Flute = True) And (Hammer = True And (MedallionCount = 3 Or (TurtleMedallion = 1 And Bombos = True) Or (TurtleMedallion = 2 And Ether = True) Or (TurtleMedallion = 3 And Quake = True))) Or (Pearl = True And (Hookshot = True Or Hammer = True) And Mirror = True)) Then TRAccess = True Else TRAccess = False
                If TRAccess = True Then
                    If Somaria = True And FireRod = True And IceRod = True And Hammer = True And TRBigKey.Checked = True Then
                        If Lamp = True And (Shield = 3 Or Byrna = True Or Cape = True) And TRKeys.Text = 4 Then TRLabel.Image = My.Resources.TRgreen Else TRLabel.Image = My.Resources.TRorange
                        TRBoss.Enabled = True
                    Else
                        TRLabel.Image = My.Resources.TRyellow
                        TRBoss.Enabled = False
                    End If
                Else
                    TRLabel.Image = My.Resources.TRred
                    TRBoss.Enabled = False
                End If
            Case 6
                TRAccess = True
                TRLabel.Image = My.Resources.TRgreen
                TRChests.Text = 12
                TRChests.ForeColor = Color.White
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
            If GTChests.Text = 0 Then GTChests.BackColor = Color.Green
        End If
        If MouseButtons = MouseButtons.Right = True Then
            If GTChests.Text < 27 Then GTChests.Text = GTChests.Text + 1
            GTChests.BackColor = Color.Black
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
            If CrystalCount = 7 And GTBigKey.Checked = True And Bow > 1 And Hookshot = True And FireRod = True And Somaria = True Then
                GTLabel.Image = My.Resources.GTgreen
            ElseIf CrystalCount = 7 Then
                GTLabel.Image = My.Resources.GTyellow
            Else
                GTLabel.Image = My.Resources.GTred
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
                BowButton.BackColor = Color.Black
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
