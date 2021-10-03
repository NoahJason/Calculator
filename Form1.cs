using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double NumberOne = 0;
        double NumberTwo = 0;
        double Answer = 0;
        Random random1 = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        string playerchoice = "";
        string npc = "";
        int count = 0;
        int lives = 3;

        private void randomcall()
        {
            int randomOne = random1.Next(1, 4);
            if (randomOne == 1)
            {
                HitPoints.Text = "rock";
                npc = "rock";
                pictureBox1.Image = Properties.Resources.steen1;
                livescall();
            }
            if (randomOne == 2)
            {
                HitPoints.Text = "paper";
                npc = "paper";
                pictureBox1.Image = Properties.Resources.paperboy;
                livescall();
            }
            if (randomOne == 3)
            {
                HitPoints.Text = "sissors";
                npc = "sissors";
                pictureBox1.Image = Properties.Resources.Sissors;
                livescall();
            }
        }

        private void livescall()
        {
            if (playerchoice == "rock" && npc == "paper")
            {
                lives = lives - 1;
                HitPoints.Value = lives;

                // MessageBox.Show(lives.ToString());
            }
            if (playerchoice == "paper" && npc == "sissors")
            {
                lives = lives - 1;
                HitPoints.Value = lives;
            }
            if (playerchoice == "sissors" && npc == "rock")
            {
                lives = lives - 1;
                HitPoints.Value = lives;
            }
            if (lives == 0)
            {
                pictureBox1.BackgroundImage = Properties.Resources.Game_over;
                label1.Hide();
                button6.Hide();
                button8.Hide();
                button7.Hide();
                HitPoints.Hide();

            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToInt32(tbnumberone.Text);
            NumberTwo = Convert.ToInt32(tbnumbertwo.Text);
            Answer = NumberOne + NumberTwo;
            lbantwoord.Text = Convert.ToString(Answer);
            lbnumberone.Text = "+";
        }

        private void tbnumberone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbnumberone_Click(object sender, EventArgs e)
        {

        }

        private void tbnumbertwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbnumbertwo_Click(object sender, EventArgs e)
        {

        }

        private void lbantwoord_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToInt32(tbnumberone.Text);
            NumberTwo = Convert.ToInt32(tbnumbertwo.Text);
            Answer = NumberOne - NumberTwo;
            lbantwoord.Text = Convert.ToString(Answer);
            lbnumberone.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToInt32(tbnumberone.Text);
            NumberTwo = Convert.ToInt32(tbnumbertwo.Text);
            Answer = NumberOne / NumberTwo;
            lbantwoord.Text = Convert.ToString(Answer);
            lbnumberone.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToInt32(tbnumberone.Text);
            NumberTwo = Convert.ToInt32(tbnumbertwo.Text);
            Answer = NumberOne * NumberTwo;
            lbantwoord.Text = Convert.ToString(Answer);
            lbnumberone.Text = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int randomOne = random1.Next(0, 101);
            tbnumberone.Text = (randomOne).ToString();
            int randomTwo = random1.Next(0, 101);
            tbnumbertwo.Text = (randomTwo).ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            HitPoints.Value = 3;
            pictureBox1.BackgroundImage = Properties.Resources.RockPaperSissors;
            label1.Text = "your pick";
            pictureBox1.Show();
            label1.Show();
            button6.Show();
            button8.Show();
            button7.Show();
            HitPoints.Show();
            HitPoints.Value = 3;
            lives = 3;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Image img = Image.FromFile("WindowsFormsApp1.Properties.Resources.steen1");
            pictureBox1.BackgroundImage = Properties.Resources.steen1;
            label1.Text = "you picked" + " rock";
            playerchoice = "rock";
            randomcall();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.paperboy;
            label1.Text = "you picked" + " paper";
            playerchoice = "paper";
            randomcall();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Sissors;
            label1.Text = "you picked" + " sissors";
            playerchoice = "sissors";
            randomcall();

        }

        private void HitPoints_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

