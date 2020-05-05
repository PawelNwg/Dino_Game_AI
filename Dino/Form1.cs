using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    public partial class MainWindow : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        bool isGameOver = false;
        int position;

        public MainWindow()
        {
            InitializeComponent();
            GameReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Dino.Top += jumpSpeed;
            Score.Text = "Score: " + score;
            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (Dino.Top > 369 && jumping == false)
            {
                force = 12;
                Dino.Top = 370;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (Dino.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        Dino.Image = Properties.Resources.dead;
                        Score.Text += " Press R to restart!";
                        isGameOver = true;
                        score = 0;
                        obstacleSpeed = 10;
                    }
                }
            }

            if (score > 10)
            {
                obstacleSpeed = 15;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            bool jumping = false;
            int jumpSpeed = 0;
            int force = 12;
            int score = 0;
            int obstacleSpeed = 10;                    
            int position;
            Score.Text = "Score: " + score;
            Dino.Image = Properties.Resources.running;
            isGameOver = false;
            Dino.Top = 369;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")              
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }                    
            }

            gameTimer.Start();
        }

        private void Dino_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
