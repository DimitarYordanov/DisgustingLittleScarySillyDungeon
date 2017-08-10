using DisgustingLittleSillyScaryDungeon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisgustingLittleSillyScaryDungeon.Properties;
using DisgustingLittleSillyScaryDungeon.Heroes.Models;
using DisgustingLittleSillyScaryDungeon.Heroes.Contracts;
using DisgustingLittleSillyScaryDungeon.Artefacts;
using DisgustingLittleSillyScaryDungeon.Interfaces;
using DisgustingLittleSillyScaryDungeon.Characters.Monsters;

namespace DisgustingLittleSillyScaryDungeon
{
    public partial class DisgustingLittleSillyScaryDungeon : Form
    {
        bool right;
        bool left;
        bool up;
        bool down;

        Warrior warrior = new Warrior(100, 15, 10, 10);
        Rogue rogue = new Rogue(100, 10, 10, 15);
        Mage mage = new Mage(100, 10, 15, 10);

        FluffyBunny fluffBun = new FluffyBunny();
        RuthlessWasp wasp = new RuthlessWasp();
        Bandit bandit = new Bandit();
        BossMan boss = new BossMan();

        List<IPoints> obstacles = new List<IPoints>();
        List<IPoints> artefacts = new List<IPoints>();
        List<Artefact> artefacts1 = new List<Artefact>();
        List<bool> visited = new List<bool>();

        List<IPoints> enemies = new List<IPoints>();
        List<PictureBox> enemies1 = new List<PictureBox>();
        List<IMonster> enemies2 = new List<IMonster>();

        List<PictureBox> pics = new List<PictureBox>();
        List<IHero> hero = new List<IHero>();
        IHero playerHero;

        Points current = new Points();
        Points stepUp = new Points();
        Points stepDown = new Points();
        Points stepRight = new Points();
        Points stepLeft = new Points();
        Points exit = new Points();

        bool upStep = true;
        bool downStep = true;
        bool rightStep = true;
        bool leftStep = true;
        bool buttonPress = false;

        public DisgustingLittleSillyScaryDungeon()
        {
            InitializeComponent();
            Points point1 = new Points(this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
            Points point2 = new Points(this.pictureBox2.Location.X, this.pictureBox2.Location.Y);
            Points point3 = new Points(this.pictureBox3.Location.X, this.pictureBox3.Location.Y);
            Points point4 = new Points(this.pictureBox4.Location.X, this.pictureBox4.Location.Y);
            Points point5 = new Points(this.pictureBox5.Location.X, this.pictureBox5.Location.Y);
            Points point6 = new Points(this.pictureBox6.Location.X, this.pictureBox6.Location.Y);
            Points point7 = new Points(this.pictureBox7.Location.X, this.pictureBox7.Location.Y);
            Points point8 = new Points(this.pictureBox8.Location.X, this.pictureBox8.Location.Y);
            Points point9 = new Points(this.pictureBox9.Location.X, this.pictureBox9.Location.Y);
            Points point10 = new Points(this.pictureBox10.Location.X, this.pictureBox10.Location.Y);
            Points point11 = new Points(this.pictureBox11.Location.X, this.pictureBox11.Location.Y);
            Points point12 = new Points(this.pictureBox12.Location.X, this.pictureBox12.Location.Y);
            Points point13 = new Points(this.pictureBox13.Location.X, this.pictureBox13.Location.Y);
            Points point14 = new Points(this.pictureBox14.Location.X, this.pictureBox14.Location.Y);
            Points point15 = new Points(this.pictureBox15.Location.X, this.pictureBox15.Location.Y);
            Points point16 = new Points(this.pictureBox16.Location.X, this.pictureBox16.Location.Y);
            Points point17 = new Points(this.pictureBox17.Location.X, this.pictureBox17.Location.Y);
            Points point18 = new Points(this.pictureBox18.Location.X, this.pictureBox18.Location.Y);
            Points point19 = new Points(this.pictureBox19.Location.X, this.pictureBox19.Location.Y);
            Points point20 = new Points(this.pictureBox20.Location.X, this.pictureBox20.Location.Y);
            Points point21 = new Points(this.pictureBox21.Location.X, this.pictureBox21.Location.Y);
            Points point22 = new Points(this.pictureBox22.Location.X, this.pictureBox22.Location.Y);
            Points point23 = new Points(this.pictureBox23.Location.X, this.pictureBox23.Location.Y);
            Points point24 = new Points(this.pictureBox24.Location.X, this.pictureBox24.Location.Y);
            Points point25 = new Points(this.pictureBox25.Location.X, this.pictureBox25.Location.Y);
            Points point26 = new Points(this.pictureBox26.Location.X, this.pictureBox26.Location.Y);
            Points point27 = new Points(this.pictureBox27.Location.X, this.pictureBox27.Location.Y);
            Points point28 = new Points(this.pictureBox28.Location.X, this.pictureBox28.Location.Y);
            Points point29 = new Points(this.pictureBox29.Location.X, this.pictureBox29.Location.Y);
            Points point30 = new Points(this.pictureBox30.Location.X, this.pictureBox30.Location.Y);
            Points point31 = new Points(this.pictureBox31.Location.X, this.pictureBox31.Location.Y);
            Points point32 = new Points(this.pictureBox32.Location.X, this.pictureBox32.Location.Y);
            Points point33 = new Points(this.pictureBox33.Location.X, this.pictureBox33.Location.Y);
            Points point34 = new Points(this.pictureBox34.Location.X, this.pictureBox34.Location.Y);
            Points point35 = new Points(this.pictureBox35.Location.X, this.pictureBox35.Location.Y);
            Points point36 = new Points(this.pictureBox36.Location.X, this.pictureBox36.Location.Y);
            Points point37 = new Points(this.pictureBox37.Location.X, this.pictureBox37.Location.Y);
            Points point38 = new Points(this.pictureBox38.Location.X, this.pictureBox38.Location.Y);
            Points point39 = new Points(this.pictureBox39.Location.X, this.pictureBox39.Location.Y);
            Points point40 = new Points(this.pictureBox40.Location.X, this.pictureBox40.Location.Y);
            Points point41 = new Points(this.pictureBox41.Location.X, this.pictureBox41.Location.Y);
            Points point42 = new Points(this.pictureBox42.Location.X, this.pictureBox42.Location.Y);
            Points point43 = new Points(this.pictureBox43.Location.X, this.pictureBox43.Location.Y);
            Points point44 = new Points(this.pictureBox44.Location.X, this.pictureBox44.Location.Y);
            Points point45 = new Points(this.pictureBox45.Location.X, this.pictureBox45.Location.Y);
            Points point46 = new Points(this.pictureBox46.Location.X, this.pictureBox46.Location.Y);
            Points point47 = new Points(this.pictureBox47.Location.X, this.pictureBox47.Location.Y);
            Points point48 = new Points(this.pictureBox48.Location.X, this.pictureBox48.Location.Y);
            Points point49 = new Points(this.pictureBox49.Location.X, this.pictureBox49.Location.Y);
            Points point50 = new Points(this.pictureBox50.Location.X, this.pictureBox50.Location.Y);
            Points point51 = new Points(this.pictureBox51.Location.X, this.pictureBox51.Location.Y);
            Points point52 = new Points(this.pictureBox52.Location.X, this.pictureBox52.Location.Y);
            Points point53 = new Points(this.pictureBox53.Location.X, this.pictureBox53.Location.Y);
            Points point54 = new Points(this.pictureBox54.Location.X, this.pictureBox54.Location.Y);
            Points point55 = new Points(this.pictureBox55.Location.X, this.pictureBox55.Location.Y);
            Points point56 = new Points(this.pictureBox56.Location.X, this.pictureBox56.Location.Y);
            Points point57 = new Points(this.pictureBox57.Location.X, this.pictureBox57.Location.Y);
            Points point58 = new Points(this.pictureBox58.Location.X, this.pictureBox58.Location.Y);
            Points point59 = new Points(this.pictureBox59.Location.X, this.pictureBox59.Location.Y);
            Points point60 = new Points(this.pictureBox60.Location.X, this.pictureBox60.Location.Y);
            Points point61 = new Points(this.pictureBox61.Location.X, this.pictureBox61.Location.Y);
            Points point62 = new Points(this.pictureBox62.Location.X, this.pictureBox62.Location.Y);
            Points point63 = new Points(this.pictureBox63.Location.X, this.pictureBox63.Location.Y);
            Points point64 = new Points(this.pictureBox64.Location.X, this.pictureBox64.Location.Y);
            Points point65 = new Points(this.pictureBox65.Location.X, this.pictureBox65.Location.Y);
            Points point66 = new Points(this.pictureBox66.Location.X, this.pictureBox66.Location.Y);
            Points point67 = new Points(this.pictureBox67.Location.X, this.pictureBox67.Location.Y);
            Points point68 = new Points(this.pictureBox68.Location.X, this.pictureBox68.Location.Y);
            Points point69 = new Points(this.pictureBox69.Location.X, this.pictureBox69.Location.Y);
            Points point70 = new Points(this.pictureBox70.Location.X, this.pictureBox70.Location.Y);
            Points point71 = new Points(this.pictureBox71.Location.X, this.pictureBox71.Location.Y);
            Points point72 = new Points(this.pictureBox72.Location.X, this.pictureBox72.Location.Y);
            Points point73 = new Points(this.pictureBox73.Location.X, this.pictureBox73.Location.Y);
            Points point74 = new Points(this.pictureBox74.Location.X, this.pictureBox74.Location.Y);
            Points point75 = new Points(this.pictureBox75.Location.X, this.pictureBox75.Location.Y);
            Points point76 = new Points(this.pictureBox76.Location.X, this.pictureBox76.Location.Y);
            Points point77 = new Points(this.pictureBox77.Location.X, this.pictureBox77.Location.Y);
            Points point78 = new Points(this.pictureBox78.Location.X, this.pictureBox78.Location.Y);
            Points point79 = new Points(this.pictureBox79.Location.X, this.pictureBox79.Location.Y);
            Points point80 = new Points(this.pictureBox80.Location.X, this.pictureBox80.Location.Y);
            Points point81 = new Points(this.pictureBox81.Location.X, this.pictureBox81.Location.Y);
            Points point82 = new Points(this.pictureBox82.Location.X, this.pictureBox82.Location.Y);
            Points point83 = new Points(this.pictureBox83.Location.X, this.pictureBox83.Location.Y);
            Points point84 = new Points(this.pictureBox84.Location.X, this.pictureBox84.Location.Y);
            Points point85 = new Points(this.pictureBox85.Location.X, this.pictureBox85.Location.Y);
            Points point86 = new Points(this.pictureBox86.Location.X, this.pictureBox86.Location.Y);
            Points point87 = new Points(this.pictureBox87.Location.X, this.pictureBox87.Location.Y);
            Points point88 = new Points(this.pictureBox88.Location.X, this.pictureBox88.Location.Y);
            Points point89 = new Points(this.pictureBox89.Location.X, this.pictureBox89.Location.Y);
            Points point90 = new Points(this.pictureBox90.Location.X, this.pictureBox90.Location.Y);
            Points point91 = new Points(this.pictureBox91.Location.X, this.pictureBox91.Location.Y);
            Points point92 = new Points(this.pictureBox92.Location.X, this.pictureBox92.Location.Y);
            Points point93 = new Points(this.pictureBox93.Location.X, this.pictureBox93.Location.Y);
            Points point94 = new Points(this.pictureBox94.Location.X, this.pictureBox94.Location.Y);
            Points point95 = new Points(this.pictureBox95.Location.X, this.pictureBox95.Location.Y);
            Points point96 = new Points(this.pictureBox96.Location.X, this.pictureBox96.Location.Y);
            Points point97 = new Points(this.pictureBox97.Location.X, this.pictureBox97.Location.Y);
            Points point98 = new Points(this.pictureBox98.Location.X, this.pictureBox98.Location.Y);
            Points point99 = new Points(this.pictureBox99.Location.X, this.pictureBox99.Location.Y);
            Points point100 = new Points(this.pictureBox100.Location.X, this.pictureBox100.Location.Y);
            Points point101 = new Points(this.pictureBox101.Location.X, this.pictureBox101.Location.Y);
            Points point102 = new Points(this.pictureBox102.Location.X, this.pictureBox102.Location.Y);
            Points point103 = new Points(this.pictureBox103.Location.X, this.pictureBox103.Location.Y);
            Points point104 = new Points(this.pictureBox104.Location.X, this.pictureBox104.Location.Y);
            Points point105 = new Points(this.pictureBox105.Location.X, this.pictureBox105.Location.Y);
            Points point106 = new Points(this.pictureBox106.Location.X, this.pictureBox106.Location.Y);
            Points point107 = new Points(this.pictureBox107.Location.X, this.pictureBox107.Location.Y);
            Points point108 = new Points(this.pictureBox108.Location.X, this.pictureBox108.Location.Y);
            Points point109 = new Points(this.pictureBox109.Location.X, this.pictureBox109.Location.Y);
            Points point110 = new Points(this.pictureBox110.Location.X, this.pictureBox110.Location.Y);
            Points point111 = new Points(this.pictureBox111.Location.X, this.pictureBox111.Location.Y);
            Points point112 = new Points(this.pictureBox112.Location.X, this.pictureBox112.Location.Y);
            Points point113 = new Points(this.pictureBox113.Location.X, this.pictureBox113.Location.Y);
            Points point114 = new Points(this.pictureBox114.Location.X, this.pictureBox114.Location.Y);
            Points point115 = new Points(this.pictureBox115.Location.X, this.pictureBox115.Location.Y);
            Points point116 = new Points(this.pictureBox116.Location.X, this.pictureBox116.Location.Y);
            Points point117 = new Points(this.pictureBox117.Location.X, this.pictureBox117.Location.Y);
            Points point118 = new Points(this.pictureBox118.Location.X, this.pictureBox118.Location.Y);
            Points point119 = new Points(this.pictureBox119.Location.X, this.pictureBox119.Location.Y);
            Points point120 = new Points(this.pictureBox120.Location.X, this.pictureBox120.Location.Y);
            Points point121 = new Points(this.pictureBox121.Location.X, this.pictureBox121.Location.Y);
            Points point122 = new Points(this.pictureBox122.Location.X, this.pictureBox122.Location.Y);
            Points point123 = new Points(this.pictureBox123.Location.X, this.pictureBox123.Location.Y);

            obstacles.Add(point1);
            obstacles.Add(point2);
            obstacles.Add(point3);
            obstacles.Add(point4);
            obstacles.Add(point5);
            obstacles.Add(point6);
            obstacles.Add(point7);
            obstacles.Add(point8);
            obstacles.Add(point9);
            obstacles.Add(point10);
            obstacles.Add(point11);
            obstacles.Add(point12);
            obstacles.Add(point13);
            obstacles.Add(point14);
            obstacles.Add(point15);
            obstacles.Add(point16);
            obstacles.Add(point17);
            obstacles.Add(point18);
            obstacles.Add(point19);
            obstacles.Add(point20);
            obstacles.Add(point21);
            obstacles.Add(point22);
            obstacles.Add(point23);
            obstacles.Add(point24);
            obstacles.Add(point25);
            obstacles.Add(point26);
            obstacles.Add(point27);
            obstacles.Add(point28);
            obstacles.Add(point29);
            obstacles.Add(point30);
            obstacles.Add(point31);
            obstacles.Add(point32);
            obstacles.Add(point33);
            obstacles.Add(point34);
            obstacles.Add(point35);
            obstacles.Add(point36);
            obstacles.Add(point37);
            obstacles.Add(point38);
            obstacles.Add(point39);
            obstacles.Add(point40);
            obstacles.Add(point41);
            obstacles.Add(point42);
            obstacles.Add(point43);
            obstacles.Add(point44);
            obstacles.Add(point45);
            obstacles.Add(point46);
            obstacles.Add(point47);
            obstacles.Add(point48);
            obstacles.Add(point49);
            obstacles.Add(point50);
            obstacles.Add(point51);
            obstacles.Add(point52);
            obstacles.Add(point53);
            obstacles.Add(point54);
            obstacles.Add(point55);
            obstacles.Add(point56);
            obstacles.Add(point57);
            obstacles.Add(point58);
            obstacles.Add(point59);
            obstacles.Add(point60);
            obstacles.Add(point61);
            obstacles.Add(point62);
            obstacles.Add(point63);
            obstacles.Add(point64);
            obstacles.Add(point65);
            obstacles.Add(point66);
            obstacles.Add(point67);
            obstacles.Add(point68);
            obstacles.Add(point69);
            obstacles.Add(point70);
            obstacles.Add(point71);
            obstacles.Add(point72);
            obstacles.Add(point73);
            obstacles.Add(point74);
            obstacles.Add(point75);
            obstacles.Add(point76);
            obstacles.Add(point77);
            obstacles.Add(point78);
            obstacles.Add(point79);
            obstacles.Add(point80);
            obstacles.Add(point81);
            obstacles.Add(point82);
            obstacles.Add(point83);
            obstacles.Add(point84);
            obstacles.Add(point85);
            obstacles.Add(point86);
            obstacles.Add(point87);
            obstacles.Add(point88);
            obstacles.Add(point89);
            obstacles.Add(point90);
            obstacles.Add(point91);
            obstacles.Add(point92);
            obstacles.Add(point93);
            obstacles.Add(point94);
            obstacles.Add(point95);
            obstacles.Add(point96);
            obstacles.Add(point97);
            obstacles.Add(point98);
            obstacles.Add(point99);
            obstacles.Add(point100);
            obstacles.Add(point101);
            obstacles.Add(point102);
            obstacles.Add(point103);
            obstacles.Add(point104);
            obstacles.Add(point105);
            obstacles.Add(point106);
            obstacles.Add(point107);
            obstacles.Add(point108);
            obstacles.Add(point109);
            obstacles.Add(point110);
            obstacles.Add(point111);
            obstacles.Add(point112);
            obstacles.Add(point113);
            obstacles.Add(point114);
            obstacles.Add(point115);
            obstacles.Add(point116);
            obstacles.Add(point117);
            obstacles.Add(point118);
            obstacles.Add(point119);
            obstacles.Add(point120);
            obstacles.Add(point121);
            obstacles.Add(point122);
            obstacles.Add(point123);

            this.exit.XCoord = this.pictureBox124.Location.X;
            this.exit.YCoord = this.pictureBox124.Location.Y;

            Points point125 = new Points(this.pictureBox125.Location.X, this.pictureBox125.Location.Y);
            Points point126 = new Points(this.pictureBox126.Location.X, this.pictureBox126.Location.Y);
            Points point127 = new Points(this.pictureBox127.Location.X, this.pictureBox127.Location.Y);

            artefacts.Add(point125);
            artefacts.Add(point126);
            artefacts.Add(point127);

            visited.Add(false);
            visited.Add(false);
            visited.Add(false);       
            
            Points point129 = new Points(this.pictureBox129.Location.X, this.pictureBox129.Location.Y);
            Points point130 = new Points(this.pictureBox130.Location.X, this.pictureBox130.Location.Y);
            Points point131 = new Points(this.pictureBox131.Location.X, this.pictureBox131.Location.Y);
            Points point132 = new Points(this.pictureBox132.Location.X, this.pictureBox132.Location.Y);

            enemies.Add(point129);
            enemies.Add(point130);
            enemies.Add(point131);
            enemies.Add(point132);

            enemies1.Add(pictureBox129);
            enemies1.Add(pictureBox130);
            enemies1.Add(pictureBox131);
            enemies1.Add(pictureBox132);

            enemies2.Add(this.fluffBun);
            enemies2.Add(this.wasp);
            enemies2.Add(this.bandit);
            enemies2.Add(this.boss);

            pics.Add(pictureBox125);
            pics.Add(pictureBox126);
            pics.Add(pictureBox127);

            hero.Add(this.warrior);
            hero.Add(this.rogue);
            hero.Add(this.mage);

            artefacts1.Add(new Hammer());
            artefacts1.Add(new Sword(SwordType.Diamond));
            artefacts1.Add(new Shield());           
        }

        public void PossibleMovement()
        {
            this.current.XCoord = this.player.Location.X;
            this.current.YCoord = this.player.Location.Y;

            this.stepUp.XCoord = this.current.XCoord;
            this.stepUp.YCoord = this.current.YCoord - 54;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].XCoord == stepUp.XCoord
                    && obstacles[i].YCoord == stepUp.YCoord)
                {
                    upStep = false;
                    break;
                }

                else
                {
                    upStep = true;
                }
            }

            this.stepDown.XCoord = this.current.XCoord;
            this.stepDown.YCoord = this.current.YCoord + 54;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].XCoord == stepDown.XCoord
                    && obstacles[i].YCoord == stepDown.YCoord)
                {
                    downStep = false;
                    break;
                }

                else
                {
                    downStep = true;
                }
            }

            this.stepRight.XCoord = this.current.XCoord + 54;
            this.stepRight.YCoord = this.current.YCoord;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].XCoord == stepRight.XCoord
                    && obstacles[i].YCoord == stepRight.YCoord)
                {
                    this.rightStep = false;
                    break;
                }

                else
                {
                    this.rightStep = true;
                }
            }

            this.stepLeft.XCoord = this.current.XCoord - 54;
            this.stepLeft.YCoord = this.current.YCoord;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].XCoord == stepLeft.XCoord
                    && obstacles[i].YCoord == stepLeft.YCoord)
                {
                    this.leftStep = false;
                    break;
                }

                else
                {
                    this.leftStep = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PossibleMovement();

            if (this.right == true && player.Left < 1080 - 54 && this.rightStep)
            {
                player.Left += 54;
            }

            if (this.left == true && player.Left > 0 && this.leftStep)
            {
                player.Left -= 54;
            }

            if (this.up == true && player.Top > 54 && upStep)
            {
                player.Top -= 54;
            }

            if (this.down == true && player.Top < 700 - 54 && this.downStep)
            {
                player.Top += 54;
            }

            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].XCoord == this.current.XCoord
                    && enemies[i].YCoord == this.current.YCoord)
                {

                    if (enemies1[i] == pictureBox129)
                    {
                        this.pictureBox134.Image = Resources._10;
                    }

                    if (enemies1[i] == pictureBox130)
                    {
                        this.pictureBox134.Image = Resources._11;
                    }

                    if (enemies1[i] == pictureBox131)
                    {
                        this.pictureBox134.Image = Resources._12;
                    }

                    if (enemies1[i] == pictureBox132)
                    {
                        this.pictureBox134.Image = Resources._13;
                    }

                    this.battlePanel.Visible = true;
                    this.battlePanel.Enabled = true;
                    this.battlePanel.Focus();
                    Thread.Sleep(2000);

                    

                    this.fullHealthBarPlayer.Width = this.playerHero.Health;
                    this.emptyHealthBarPlayer.Width = this.playerHero.Health;

                    this.fullHealthBarEnemy.Width = this.enemies2[i].Health;
                    this.emptyHealthBarEnemy.Width = this.enemies2[i].Health;


                    while (this.fullHealthBarEnemy.Width > 0 && fullHealthBarPlayer.Width > 0)
                    {
                        //this.enemies2[i].Health -= 10;

                        

                        this.fullHealthBarEnemy.Width -= 10;
                        Thread.Sleep(500);

                        this.fullHealthBarPlayer.Width -= 10;
                        Thread.Sleep(500);

                        
                    }

                    this.fullHealthBarPlayer.Width = this.playerHero.Health;
                    this.emptyHealthBarPlayer.Width = this.playerHero.Health;

                    this.battlePanel.Visible = false;
                    this.battlePanel.Enabled = false;

                    enemies1[i].Left += 1000;
                    enemies[i].XCoord += 1000;

                    
                }
            }

            for (int i = 0; i < artefacts.Count; i++)
            {
                if (artefacts[i].XCoord == this.current.XCoord
                    && artefacts[i].YCoord == this.current.YCoord
                    && visited[i] == false)
                {
                    visited[i] = true;
                    pics[i].Left += 1000;
                    playerHero.GetAttackPoints(artefacts1[i]);
                    break;
                }
            }

            if (this.current.XCoord == this.exit.XCoord
                && this.current.YCoord == this.exit.YCoord)
            {
                this.panel2.Visible = true;
            }
        }

        private void DisgustingLittleSillyScaryDungeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.right = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                this.left = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                this.up = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                this.down = true;
            }
        }

        private void DisgustingLittleSillyScaryDungeon_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                this.left = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                this.up = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                this.down = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                this.player.Image = Resources._3;
                this.playerHero = hero[0];
            }

            else if (this.radioButton2.Checked == true)
            {
                this.player.Image = Resources._31;
                this.playerHero = hero[1];
            }

            else
            {
                this.player.Image = Resources._32;
                this.playerHero = hero[2];
            }

            this.panel3.Visible = false;
            this.panel3.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void fullHealthBarPlayer_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
