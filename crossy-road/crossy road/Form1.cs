using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crossy_road
{
    public partial class Form1 : Form
    {
        int kecepatan = 10;
        int horizontal = 0; //kesamping
        int vertikal = 0; // keatas
        int waktuHabis = 0;
        int levelCount = 0;
        int posisiMundur = 0;
        int nyawaPlayer = 3;
        int levelakhir = 1;


        //Random obstacle = new Random();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer2.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
        }

        private void Movement(object sender, KeyEventArgs e) // bebek
        {
            if (nyawaPlayer != 0)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {

                    vertikal = -100;
                    if (posisiMundur == 0)
                    {
                        levelCount++;
                    }
                    else if (posisiMundur < 0)
                    {
                        posisiMundur++;
                    }
                    waktuHabis = 0;
                }
                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left && bebek.Left > 60)
                {
                    horizontal = -97;
                    waktuHabis = 0;
                }
                else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && bebek.Top < 601)
                {
                    vertikal = 100;
                    waktuHabis = 0;
                    posisiMundur--;

                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right && bebek.Left <= 741)
                {
                    horizontal = 97;
                    waktuHabis = 0;
                }
            }
           
        }
        private void GameTimer () // bebek
        {
            level.Text = "LEVEL : " + levelakhir.ToString();
           
            if (bebek.Top < 96)
            {
                bebek.Top = 601;
                bebek.Left = 367;
                kecepatan += 1;
                //levelCount++;
                levelakhir++;
                level.Text = "LEVEL : " + levelCount.ToString();
                


            }
            

            waktuHabis++;
            bebek.Top += vertikal;
            bebek.Left += horizontal;
            vertikal = 0;
            horizontal = 0;

            if (bebek.Bounds.IntersectsWith(mobil1.Bounds) ||
                bebek.Bounds.IntersectsWith(mobil2.Bounds) ||
                bebek.Bounds.IntersectsWith(mobil3.Bounds) ||
                bebek.Bounds.IntersectsWith(mobil4.Bounds) ||
                bebek.Bounds.IntersectsWith(mobil5.Bounds) || waktuHabis > 200)
            {
                nyawaPlayer--;
                bebek.Top = 601;
                bebek.Left = 367;
            }
            if (nyawaPlayer == 2)
            {
                nyawa.Left = 780;
            }
            if (nyawaPlayer == 1)
            {
                nyawa.Left = 836;
            }
            if (nyawaPlayer == 0)
            {
                nyawa.Left = 892;
                gameover();

            }
            
        }
        private void gameover()
        {
            boxgameover.Top = 220;
            skorAkhir.Text = levelCount.ToString();

        }
        private void timer1_Tick(object sender, EventArgs e) // bebek
        {
            bebek.Top += vertikal;
            bebek.Left += horizontal;
            vertikal = 0;
            horizontal = 0;
            GameTimer();
        }
        private void timer3_Tick(object sender, EventArgs e) // mobil
        {
            mobil1.Left = mobil1.Left + 20;
            if (mobil1.Left >= 900)
            {
                 mobil1.Left = 1;
            }
            skor.Text = "SCORE : " + levelCount.ToString();
            GameTimer();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mobil2.Left = mobil2.Left - 20;
            if (mobil2.Left <= 1)
            {
                mobil2.Left = 900;
            }
            GameTimer();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            mobil3.Left = mobil3.Left + 30;
            if (mobil3.Left >= 900)
            {
                mobil3.Left = 1;
            }
            GameTimer();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            mobil4.Left = mobil4.Left - 30;
            if (mobil4.Left <= 1)
            {
                mobil4.Left = 900;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            mobil5.Left = mobil5.Left - 40;
            if (mobil5.Left <= 1)
            {
                mobil5.Left = 900;
            }
        }        
    }
}