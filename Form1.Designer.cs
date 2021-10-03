
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.button8.Text = "Sissors";
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
            this.pictureBox1.Size = new System.Drawing.Size(539, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 574);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

