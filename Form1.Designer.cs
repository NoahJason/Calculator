
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbnumberone = new System.Windows.Forms.TextBox();
            this.lbnumberone = new System.Windows.Forms.Label();
            this.tbnumbertwo = new System.Windows.Forms.TextBox();
            this.lbnumbertwo = new System.Windows.Forms.Label();
            this.lbantwoord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.HitPoints = new System.Windows.Forms.ProgressBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button10 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.full = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.better = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnumberone
            // 
            this.tbnumberone.Location = new System.Drawing.Point(79, 79);
            this.tbnumberone.Name = "tbnumberone";
            this.tbnumberone.Size = new System.Drawing.Size(100, 20);
            this.tbnumberone.TabIndex = 0;
            this.tbnumberone.TextChanged += new System.EventHandler(this.tbnumberone_TextChanged);
            // 
            // lbnumberone
            // 
            this.lbnumberone.AutoSize = true;
            this.lbnumberone.Location = new System.Drawing.Point(236, 86);
            this.lbnumberone.Name = "lbnumberone";
            this.lbnumberone.Size = new System.Drawing.Size(13, 13);
            this.lbnumberone.TabIndex = 1;
            this.lbnumberone.Text = "+";
            this.lbnumberone.Click += new System.EventHandler(this.lbnumberone_Click);
            // 
            // tbnumbertwo
            // 
            this.tbnumbertwo.Location = new System.Drawing.Point(309, 79);
            this.tbnumbertwo.Name = "tbnumbertwo";
            this.tbnumbertwo.Size = new System.Drawing.Size(100, 20);
            this.tbnumbertwo.TabIndex = 2;
            this.tbnumbertwo.TextChanged += new System.EventHandler(this.tbnumbertwo_TextChanged);
            // 
            // lbnumbertwo
            // 
            this.lbnumbertwo.AutoSize = true;
            this.lbnumbertwo.Location = new System.Drawing.Point(467, 86);
            this.lbnumbertwo.Name = "lbnumbertwo";
            this.lbnumbertwo.Size = new System.Drawing.Size(13, 13);
            this.lbnumbertwo.TabIndex = 3;
            this.lbnumbertwo.Text = "=";
            this.lbnumbertwo.Click += new System.EventHandler(this.lbnumbertwo_Click);
            // 
            // lbantwoord
            // 
            this.lbantwoord.AutoSize = true;
            this.lbantwoord.Location = new System.Drawing.Point(538, 86);
            this.lbantwoord.Name = "lbantwoord";
            this.lbantwoord.Size = new System.Drawing.Size(42, 13);
            this.lbantwoord.TabIndex = 4;
            this.lbantwoord.Text = "Awnser";
            this.lbantwoord.Click += new System.EventHandler(this.lbantwoord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(578, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Random";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // HitPoints
            // 
            this.HitPoints.Location = new System.Drawing.Point(79, 273);
            this.HitPoints.Maximum = 3;
            this.HitPoints.Name = "HitPoints";
            this.HitPoints.Size = new System.Drawing.Size(294, 32);
            this.HitPoints.TabIndex = 10;
            this.HitPoints.Value = 3;
            this.HitPoints.Click += new System.EventHandler(this.HitPoints_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(79, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Rock";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(192, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Paper";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(298, 321);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Scissors";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(79, 244);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(294, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Start game";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "your pick";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.RockPaperSissors;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(445, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Darkmode",
            "Random color"});
            this.comboBox1.Location = new System.Drawing.Point(58, 489);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(58, 526);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(290, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(58, 577);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(290, 45);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(58, 628);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(290, 45);
            this.trackBar3.TabIndex = 20;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(60, 679);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(288, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "Pick a color";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(445, 457);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(321, 73);
            this.btnplay.TabIndex = 22;
            this.btnplay.Text = "play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(445, 536);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(321, 73);
            this.btnstop.TabIndex = 23;
            this.btnstop.Text = "stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // full
            // 
            this.full.Location = new System.Drawing.Point(79, 203);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(100, 23);
            this.full.TabIndex = 24;
            this.full.Text = "Fullscreen";
            this.full.UseVisualStyleBackColor = true;
            this.full.Click += new System.EventHandler(this.full_Click);
            // 
            // Normal
            // 
            this.Normal.Location = new System.Drawing.Point(276, 203);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(97, 23);
            this.Normal.TabIndex = 25;
            this.Normal.Text = "Normal screen";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(445, 694);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(321, 23);
            this.Path.TabIndex = 27;
            this.Path.Text = "Application path";
            this.Path.UseVisualStyleBackColor = true;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(781, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 28;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // better
            // 
            this.better.Location = new System.Drawing.Point(445, 615);
            this.better.Name = "better";
            this.better.Size = new System.Drawing.Size(321, 73);
            this.better.TabIndex = 31;
            this.better.Text = "Play better";
            this.better.UseVisualStyleBackColor = true;
            this.better.Click += new System.EventHandler(this.better_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 743);
            this.Controls.Add(this.better);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.full);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HitPoints);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbantwoord);
            this.Controls.Add(this.lbnumbertwo);
            this.Controls.Add(this.tbnumbertwo);
            this.Controls.Add(this.lbnumberone);
            this.Controls.Add(this.tbnumberone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnumberone;
        private System.Windows.Forms.Label lbnumberone;
        private System.Windows.Forms.TextBox tbnumbertwo;
        private System.Windows.Forms.Label lbnumbertwo;
        private System.Windows.Forms.Label lbantwoord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar HitPoints;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button full;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Path;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button better;
    }
}

