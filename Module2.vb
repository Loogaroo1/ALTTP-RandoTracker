Module Module2
    Public Bow, Boomerang, Glove, Sword, Armor, Shield, Magic, MedallionCount, MireMedallion, TurtleMedallion, EPReward, DPReward, TOHReward, PODReward, SPReward, SWReward, TTReward, IPReward, MMReward, TRReward, BossEP, BossDP, BossTOH, BossPOD, BossSP, BossSW, BossTT, BossIP, BossMM, BossTR, BossPick, CrystalCount, FairyCrystal, PendantCount, Available, GameStyle As Integer
    Public Hookshot, Bombs, Powder, FireRod, IceRod, Bombos, Ether, Quake, Lamp, Hammer, Flute, Net, Book, Bottle, Somaria, Byrna, Cape, Mirror, Boots, Flippers, Pearl, Mushroom, Shovel, Aganhim, GreenPendant, TRAccess, Inverted, Enemizer, Swordless As Boolean

    Public Sub ResetGame()
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
        Form1.BowButton.Image = nobow
        Form1.BowButton.BackColor = Color.Black
        Form1.BoomButton.Image = noboomerang
        Form1.BoomButton.BackColor = Color.Black
        Form1.HookButton.Image = nohook
        Form1.HookButton.BackColor = Color.Black
        Form1.BombButton.Image = nobombs
        Form1.BombButton.BackColor = Color.Black
        Form1.PowderButton.Image = nopowder
        Form1.PowderButton.BackColor = Color.Black
        Form1.FireButton.Image = nofirerod
        Form1.FireButton.BackColor = Color.Black
        Form1.IceButton.Image = noicerod
        Form1.IceButton.BackColor = Color.Black
        Form1.BombosButton.Image = nobombos
        Form1.BombosButton.BackColor = Color.Black
        Form1.EtherButton.Image = noether
        Form1.EtherButton.BackColor = Color.Black
        Form1.QuakeButton.Image = noquake
        Form1.QuakeButton.BackColor = Color.Black
        Form1.LampButton.Image = nolamp
        Form1.LampButton.BackColor = Color.Black
        Form1.HammerButton.Image = nohammer
        Form1.HammerButton.BackColor = Color.Black
        Form1.FluteButton.Image = noflute
        Form1.FluteButton.BackColor = Color.Black
        Form1.NetButton.Image = nobugnet
        Form1.NetButton.BackColor = Color.Black
        Form1.BookButton.Image = nobook
        Form1.BookButton.BackColor = Color.Black
        Form1.BottleButton.Image = nobottle
        Form1.BottleButton.BackColor = Color.Black
        Form1.SomariaButton.Image = nosomaria
        Form1.SomariaButton.BackColor = Color.Black
        Form1.ByrnaButton.Image = nobyrna
        Form1.ByrnaButton.BackColor = Color.Black
        Form1.CapeButton.Image = nocape
        Form1.CapeButton.BackColor = Color.Black
        Form1.MirrorButton.Image = nomirror
        Form1.MirrorButton.BackColor = Color.Black
        Form1.BootButton.Image = noboots
        Form1.BootButton.BackColor = Color.Black
        Form1.GloveButton.Image = noglove
        Form1.GloveButton.BackColor = Color.Black
        Form1.FlipperButton.Image = noflippers
        Form1.FlipperButton.BackColor = Color.Black
        Form1.PearlButton.Image = nopearl
        Form1.PearlButton.BackColor = Color.Black
        Form1.MushButton.Image = nomushroom
        Form1.MushButton.BackColor = Color.Black
        Form1.ShovelButton.Image = noshovel
        Form1.ShovelButton.BackColor = Color.Black
        Form1.SwordButton.Image = nosword
        Form1.SwordButton.BackColor = Color.Black
        Form1.ArmorButton.Image = My.Resources.greenmail
        Form1.ShieldButton.Image = noshield
        Form1.ShieldButton.BackColor = Color.Black
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
        Form1.BottleNumber.Text = 0
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
        If Swordless = True Then Form1.SwordButton.Visible = False Else Form1.SwordButton.Visible = True
        Armor = 0
        Shield = 0
        MedallionCount = 0

        ' Resetting dungeon rewards/macguffin counts, clearing notes, expanding window for Keysanity
        MireMedallion = 0
        Form1.MireBEQ.Image = My.Resources.whatmedallion
        TurtleMedallion = 0
        Form1.TurtleBEQ.Image = My.Resources.whatmedallion
        If GameStyle = 3 Then
            Form1.Width = 480
            EPReward = -1 : Form1.EPButton.Image = Nothing : Form1.EPBoss.Left = 436 : Form1.EPKeys.Visible = True : Form1.EPChests.Visible = True : Form1.EPPrizes.Visible = False : Form1.EPMap.Visible = True : Form1.EPBigKey.Visible = True
            DPReward = -1 : Form1.DPButton.Image = Nothing : Form1.DPBoss.Left = 436 : Form1.DPKeys.Visible = True : Form1.DPChests.Visible = True : Form1.DPPrizes.Visible = False : Form1.DPMap.Visible = True : Form1.DPBigKey.Visible = True
            TOHReward = -1 : Form1.TOHButton.Image = Nothing : Form1.HeraBoss.Left = 436 : Form1.TOHKeys.Visible = True : Form1.TOHChests.Visible = True : Form1.TOHPrizes.Visible = False : Form1.HeraMap.Visible = True : Form1.HeraBigKey.Visible = True
            PODReward = -1 : Form1.PODButton.Image = Nothing : Form1.PODBoss.Left = 436 : Form1.PODKeys.Visible = True : Form1.PODChests.Visible = True : Form1.PODPrizes.Visible = False : Form1.PODMap.Visible = True : Form1.PODBigKey.Visible = True
            SPReward = -1 : Form1.SPButton.Image = Nothing : Form1.SPBoss.Left = 436 : Form1.SPKeys.Visible = True : Form1.SPChests.Visible = True : Form1.SPPrizes.Visible = False : Form1.SPMap.Visible = True : Form1.SPBigKey.Visible = True
            SWReward = -1 : Form1.SWButton.Image = Nothing : Form1.SWBoss.Left = 436 : Form1.SWKeys.Visible = True : Form1.SWChests.Visible = True : Form1.SWPrizes.Visible = False : Form1.SWMap.Visible = True : Form1.SWBigKey.Visible = True
            TTReward = -1 : Form1.TTButton.Image = Nothing : Form1.TTBoss.Left = 436 : Form1.TTKeys.Visible = True : Form1.TTChests.Visible = True : Form1.TTPrizes.Visible = False : Form1.TTMap.Visible = True : Form1.TTBigKey.Visible = True
            IPReward = -1 : Form1.IPButton.Image = Nothing : Form1.IPBoss.Left = 436 : Form1.IPKeys.Visible = True : Form1.IPChests.Visible = True : Form1.IPPrizes.Visible = False : Form1.IPMap.Visible = True : Form1.IPBigKey.Visible = True
            MMReward = -1 : Form1.MMButton.Image = Nothing : Form1.MMBoss.Left = 436 : Form1.MMKeys.Visible = True : Form1.MMChests.Visible = True : Form1.MMPrizes.Visible = False : Form1.MMMap.Visible = True : Form1.MMBigKey.Visible = True
            TRReward = -1 : Form1.TRButton.Image = Nothing : Form1.TRBoss.Left = 436 : Form1.TRKeys.Visible = True : Form1.TRChests.Visible = True : Form1.TRPrizes.Visible = False : Form1.TRMap.Visible = True : Form1.TRBigKey.Visible = True
            Form1.HCChests.Visible = True : Form1.HCKeys.Visible = True : Form1.HCPrizes.Visible = False
            Form1.AGLabel.Visible = True : Form1.AGChests.Visible = True : Form1.AGKeys.Visible = True : Form1.AGPrizes.Visible = False
            Form1.GTLabel.Visible = True : Form1.GTChests.Visible = True : Form1.GTKeys.Visible = True : Form1.GTBigKey.Visible = True
        Else
            Form1.Width = 456
            EPReward = 0 : Form1.EPButton.Image = My.Resources.crystal : Form1.EPBoss.Left = 352 : Form1.EPKeys.Visible = False : Form1.EPChests.Visible = False : Form1.EPPrizes.Visible = True : Form1.EPMap.Visible = False : Form1.EPBigKey.Visible = False
            DPReward = 0 : Form1.DPButton.Image = My.Resources.crystal : Form1.DPBoss.Left = 352 : Form1.DPKeys.Visible = False : Form1.DPChests.Visible = False : Form1.DPPrizes.Visible = True : Form1.DPMap.Visible = False : Form1.DPBigKey.Visible = False
            TOHReward = 0 : Form1.TOHButton.Image = My.Resources.crystal : Form1.HeraBoss.Left = 352 : Form1.TOHKeys.Visible = False : Form1.TOHChests.Visible = False : Form1.TOHPrizes.Visible = True : Form1.HeraMap.Visible = False : Form1.HeraBigKey.Visible = False
            PODReward = 0 : Form1.PODButton.Image = My.Resources.crystal : Form1.PODBoss.Left = 352 : Form1.PODKeys.Visible = False : Form1.PODChests.Visible = False : Form1.PODPrizes.Visible = True : Form1.PODMap.Visible = False : Form1.PODBigKey.Visible = False
            SPReward = 0 : Form1.SPButton.Image = My.Resources.crystal : Form1.SPBoss.Left = 352 : Form1.SPKeys.Visible = False : Form1.SPChests.Visible = False : Form1.SPPrizes.Visible = True : Form1.SPMap.Visible = False : Form1.SPBigKey.Visible = False
            SWReward = 0 : Form1.SWButton.Image = My.Resources.crystal : Form1.SWBoss.Left = 352 : Form1.SWKeys.Visible = False : Form1.SWChests.Visible = False : Form1.SWPrizes.Visible = True : Form1.SWMap.Visible = False : Form1.SWBigKey.Visible = False
            TTReward = 0 : Form1.TTButton.Image = My.Resources.crystal : Form1.TTBoss.Left = 352 : Form1.TTKeys.Visible = False : Form1.TTChests.Visible = False : Form1.TTPrizes.Visible = True : Form1.TTMap.Visible = False : Form1.TTBigKey.Visible = False
            IPReward = 0 : Form1.IPButton.Image = My.Resources.crystal : Form1.IPBoss.Left = 352 : Form1.IPKeys.Visible = False : Form1.IPChests.Visible = False : Form1.IPPrizes.Visible = True : Form1.IPMap.Visible = False : Form1.IPBigKey.Visible = False
            MMReward = 0 : Form1.MMButton.Image = My.Resources.crystal : Form1.MMBoss.Left = 352 : Form1.MMKeys.Visible = False : Form1.MMChests.Visible = False : Form1.MMPrizes.Visible = True : Form1.MMMap.Visible = False : Form1.MMBigKey.Visible = False
            TRReward = 0 : Form1.TRButton.Image = My.Resources.crystal : Form1.TRBoss.Left = 352 : Form1.TRKeys.Visible = False : Form1.TRChests.Visible = False : Form1.TRPrizes.Visible = True : Form1.TRMap.Visible = False : Form1.TRBigKey.Visible = False
            Form1.HCChests.Visible = False : Form1.HCKeys.Visible = False : Form1.HCPrizes.Visible = True
            If GameStyle = 2 Then
                Form1.AGLabel.Visible = True : Form1.AGChests.Visible = False : Form1.AGKeys.Visible = False : Form1.AGPrizes.Visible = True
            Else
                Form1.AGLabel.Visible = False : Form1.AGChests.Visible = False : Form1.AGKeys.Visible = False : Form1.AGPrizes.Visible = False
            End If
            Form1.GTLabel.Visible = False : Form1.GTChests.Visible = False : Form1.GTKeys.Visible = False : Form1.GTBigKey.Visible = False
            End If
            CrystalCount = 0
        FairyCrystal = 0
        PendantCount = 0
        GreenPendant = False
        Form1.TextBox1.Text = Nothing

        ' Resetting all dungeons
        If GameStyle = 2 Then
            Form1.HCPrizes.Text = 7
            Form1.EPPrizes.Text = 3
            Form1.DPPrizes.Text = 3
            Form1.TOHPrizes.Text = 3
            Form1.AGPrizes.Text = 2
            Form1.PODPrizes.Text = 11
            Form1.SPPrizes.Text = 7
            Form1.SWPrizes.Text = 5
            Form1.TTPrizes.Text = 5
            Form1.IPPrizes.Text = 5
            Form1.MMPrizes.Text = 5
            Form1.TRPrizes.Text = 9
        Else
            Form1.HCPrizes.Text = 6
            Form1.EPPrizes.Text = 3
            Form1.DPPrizes.Text = 2
            Form1.TOHPrizes.Text = 2
            Form1.AGPrizes.Text = "-"
            Form1.PODPrizes.Text = 5
            Form1.SPPrizes.Text = 6
            Form1.SWPrizes.Text = 2
            Form1.TTPrizes.Text = 4
            Form1.IPPrizes.Text = 3
            Form1.MMPrizes.Text = 2
            Form1.TRPrizes.Text = 5
        End If
        Form1.HCPrizes.BackColor = Color.Black
        Form1.HCChests.Text = 8
        Form1.HCChests.BackColor = Color.Black
        Form1.HCKeys.Text = 0
        Form1.EPPrizes.Text = 3
        Form1.EPPrizes.BackColor = Color.Black
        Form1.EPChests.Text = 6
        Form1.EPChests.BackColor = Color.Black
        Form1.EPKeys.Text = "-"
        Form1.EPMap.Checked = False
        Form1.EPBigKey.Checked = False
        Form1.EPBoss.Checked = False
        Form1.DPPrizes.BackColor = Color.Black
        Form1.DPChests.Text = 6
        Form1.DPChests.BackColor = Color.Black
        Form1.DPKeys.Text = 0
        Form1.DPMap.Checked = False
        Form1.DPBigKey.Checked = False
        Form1.DPBoss.Checked = False
        Form1.TOHPrizes.BackColor = Color.Black
        Form1.TOHChests.Text = 6
        Form1.TOHChests.BackColor = Color.Black
        Form1.TOHKeys.Text = 0
        Form1.HeraMap.Checked = False
        Form1.HeraBigKey.Checked = False
        Form1.HeraBoss.Checked = False
        Form1.AGPrizes.BackColor = Color.Black
        Form1.AGChests.Text = 2
        Form1.AGChests.BackColor = Color.Black
        Form1.AGKeys.Text = 0
        Form1.PODPrizes.BackColor = Color.Black
        Form1.PODChests.Text = 14
        Form1.PODChests.BackColor = Color.Black
        Form1.PODKeys.Text = 0
        Form1.PODMap.Checked = False
        Form1.PODBigKey.Checked = False
        Form1.PODBoss.Checked = False
        Form1.SPPrizes.BackColor = Color.Black
        Form1.SPChests.Text = 10
        Form1.SPChests.BackColor = Color.Black
        Form1.SPKeys.Text = 0
        Form1.SPMap.Checked = False
        Form1.SPBigKey.Checked = False
        Form1.SPBoss.Checked = False
        Form1.SWPrizes.BackColor = Color.Black
        Form1.SWChests.Text = 8
        Form1.SWChests.BackColor = Color.Black
        Form1.SWKeys.Text = 0
        Form1.SWMap.Checked = False
        Form1.SWBigKey.Checked = False
        Form1.SWBoss.Checked = False
        Form1.TTPrizes.BackColor = Color.Black
        Form1.TTChests.Text = 8
        Form1.TTChests.BackColor = Color.Black
        Form1.TTKeys.Text = 0
        Form1.TTMap.Checked = False
        Form1.TTBigKey.Checked = False
        Form1.TTBoss.Checked = False
        Form1.IPPrizes.BackColor = Color.Black
        Form1.IPChests.Text = 8
        Form1.IPChests.BackColor = Color.Black
        Form1.IPKeys.Text = 0
        Form1.IPMap.Checked = False
        Form1.IPBigKey.Checked = False
        Form1.IPBoss.Checked = False
        Form1.MMPrizes.BackColor = Color.Black
        Form1.MMChests.Text = 8
        Form1.MMChests.BackColor = Color.Black
        Form1.MMKeys.Text = 0
        Form1.MMMap.Checked = False
        Form1.MMBigKey.Checked = False
        Form1.MMBoss.Checked = False
        Form1.TRPrizes.BackColor = Color.Black
        Form1.TRChests.Text = 12
        Form1.TRChests.BackColor = Color.Black
        Form1.TRKeys.Text = 0
        Form1.TRMap.Checked = False
        Form1.TRBigKey.Checked = False
        Form1.TRBoss.Checked = False
        Form1.GTChests.Text = 27
        Form1.GTChests.BackColor = Color.Black
        Form1.GTKeys.Text = 0
        Form1.GTBigKey.Checked = False

        '' Resetting all locations
        Form1.LW1.Tag = 0
        Form1.LW2.Tag = 0
        Form1.LW3.Tag = 0
        Form1.LW4.Tag = 0
        Form1.LW5.Tag = 0
        Form1.LW6.Tag = 0
        Form1.LW7.Tag = 0
        Form1.LW8.Tag = 0
        Form1.LW9.Tag = 0
        Form1.LW10.Tag = 0
        Form1.LW11.Tag = 0
        Form1.LW12.Tag = 0
        Form1.LW13.Tag = 0
        Form1.LW14.Tag = 0
        Form1.LW15.Tag = 0
        Form1.LW16.Tag = 0
        Form1.LW17.Tag = 0
        Form1.LW18.Tag = 0
        Form1.LW19.Tag = 0
        Form1.LW20.Tag = 0
        Form1.LW21.Tag = 0
        Form1.LW22.Tag = 0
        Form1.LW23.Tag = 0
        Form1.LW24.Tag = 0
        Form1.LW25.Tag = 0
        Form1.LW26.Tag = 0
        Form1.LW27.Tag = 0
        Form1.LW28.Tag = 0
        Form1.LW29.Tag = 0
        Form1.LW30.Tag = 0
        Form1.LW31.Tag = 0
        Form1.LW32.Tag = 0
        Form1.LW33.Tag = 0
        Form1.LW34.Tag = 0
        Form1.LW35.Tag = 0
        Form1.LW36.Tag = 0
        Form1.LW37.Tag = 0
        Form1.LW38.Tag = 0
        Form1.LW39.Tag = 0
        Form1.LW40.Tag = 0
        Form1.LW41.Tag = 0
        Form1.LW42.Tag = 0
        Form1.LW43.Tag = 0
        Form1.LW44.Tag = 0
        Form1.DW1.Tag = 0
        Form1.DW2.Tag = 0
        Form1.DW3.Tag = 0
        Form1.DW4.Tag = 0
        Form1.DW5.Tag = 0
        Form1.DW6.Tag = 0
        Form1.DW7.Tag = 0
        Form1.DW8.Tag = 0
        Form1.DW9.Tag = 0
        Form1.DW10.Tag = 0
        Form1.DW11.Tag = 0
        Form1.DW12.Tag = 0
        Form1.DW13.Tag = 0
        Form1.DW14.Tag = 0
        Form1.DW15.Tag = 0
        Form1.DW16.Tag = 0

        '' Resetting Logic
        Form1.LogicCheck()

    End Sub

End Module
