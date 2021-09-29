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
        Random random = new Random();


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
        //TODO Fix sissors, Using + or any other it crashes

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
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Image img = Image.FromFile("WindowsFormsApp1.Properties.Resources.steen1");
            pictureBox1.BackgroundImage = Properties.Resources.steen1;
            HitPoints.Value = 2;
            label1.Text = "you picked" + " rock";
            playerchoice = "rock";
            npc = "rock";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.paperboy;
            HitPoints.Value = 1;
            label1.Text = "you picked" + " paper";
            playerchoice = "paper";
            npc = "paper";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Sissors;
            HitPoints.Value = 0;
            label1.Text = "you picked" + " sissors";
            playerchoice = "sissors";
            npc = "sissors";

            int randomOne = random1.Next(1, 4);



        }
    }
}
