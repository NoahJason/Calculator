using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // Using I added
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
        int lives = 3;
        string Darkmode = "";

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
                HitPoints.Text = "scissors";
                npc = "scissors";
                pictureBox1.Image = Properties.Resources.Scissors;
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
            if (playerchoice == "paper" && npc == "scissors")
            {
                lives = lives - 1;
                HitPoints.Value = lives;
            }
            if (playerchoice == "scissors" && npc == "rock")
            {
                lives = lives - 1;
                HitPoints.Value = lives;
            }
            if (lives == 0)
            {
                // Console.WriteLine("Control");
                label1.Hide();
                button6.Hide();
                button8.Hide();
                button7.Hide();
                HitPoints.Hide();
                // MessageBox.Show(lives.ToString());
                pictureBox1.Image = Properties.Resources.Game_over;
                MessageBox.Show("You Lost!");

            }
        }
        public void Darkmode1()
        {

            label1.BackColor = Color.Gray;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            button10.BackColor = Color.Gray;
            this.BackColor = Color.Gray;

        }

        public void Normal1()
        {
            label1.BackColor = default(Color);
            this.BackColor = default(Color);
            button1.BackColor = SystemColors.ButtonFace;
            button1.ForeColor = default(Color);
            button2.BackColor = SystemColors.ButtonFace;
            button2.ForeColor = default(Color);
            button3.BackColor = SystemColors.ButtonFace;
            button3.ForeColor = default(Color);
            button4.BackColor = SystemColors.ButtonFace;
            button4.ForeColor = default(Color);
            button5.BackColor = SystemColors.ButtonFace;
            button5.ForeColor = default(Color);
            button6.BackColor = SystemColors.ButtonFace;
            button6.ForeColor = default(Color);
            button7.BackColor = SystemColors.ButtonFace;
            button7.ForeColor = default(Color);
            button8.BackColor = SystemColors.ButtonFace;
            button8.ForeColor = default(Color);
            button9.BackColor = SystemColors.ButtonFace;
            button9.ForeColor = default(Color);
            button10.BackColor = SystemColors.ButtonFace;
            button10.ForeColor = default(Color);



        }

        public Random random;

        public Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        public void Random1()
        {
            label1.BackColor = GetRandomColor();
            button1.BackColor = GetRandomColor();
            button2.BackColor = GetRandomColor();
            button3.BackColor = GetRandomColor();
            button4.BackColor = GetRandomColor();
            button5.BackColor = GetRandomColor();
            button6.BackColor = GetRandomColor();
            button7.BackColor = GetRandomColor();
            button8.BackColor = GetRandomColor();
            button9.BackColor = GetRandomColor();
            button10.BackColor = GetRandomColor();
            this.BackColor = GetRandomColor();
        }
        #region Sound stuff
        //Audio DLL import
        [DllImport("winmm.dll")]
        //default audio handling code
        private static extern long mciSendString(
        string strCommand,
        StringBuilder strReturn,
        int iReturnLength,
        IntPtr hwndCallback);
        #endregion



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
            HitPoints.Value = HitPoints.Maximum;
            pictureBox1.Image = Properties.Resources.RockPaperSissors;
            label1.Text = "your pick";
            pictureBox1.Show();
            label1.Show();
            button6.Show();
            button8.Show();
            button7.Show();
            HitPoints.Show();
            HitPoints.Value = 3;
            lives = 3;
            WindowState = FormWindowState.Normal;

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
            pictureBox1.BackgroundImage = Properties.Resources.Scissors;
            label1.Text = "you picked" + " scissors";
            playerchoice = "scissors";
            randomcall();

        }

        private void HitPoints_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Darkmode")
            {
                Darkmode1();
            }
            if (comboBox1.SelectedItem == "Normal")
            {
                Normal1();
            }
            if (comboBox1.SelectedItem == "Random color")
            {
                Random1();
            }





            // comboBox1.Text = "Normal";
            //  this.BackColor = colorDialog1.Color = (255, 255, 255);

        }
        public void Readingcolors()
        {
            trackBar1.Value = BackColor.R;
            trackBar2.Value = BackColor.G;
            trackBar3.Value = BackColor.B;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            //this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            trackbarvalue();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            trackbarvalue();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            trackbarvalue();
        }
        public void trackbarvalue()
        {
            button10.BackColor = BackColor;                                     //edit
            button10.ForeColor = Color.FromArgb(BackColor.ToArgb() ^ 0xffffff); //edit
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            mciSendString("Close MediaFile", null, 0, IntPtr.Zero);
            //play audio
            mciSendString("open \"" + Application.StartupPath
                  + "\\..\\..\\Music\\Pharrell Williams - Happy.mp3"
                  + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
        }

        private void full_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void better_Click(object sender, EventArgs e)
        {
            mciSendString("Close MediaFile", null, 0, IntPtr.Zero);
            //play audio
            mciSendString("open \"" + Application.StartupPath
                  + "\\..\\..\\MusicBetter\\Queen - Somebody to Love.mp3"
                  + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void Path_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

