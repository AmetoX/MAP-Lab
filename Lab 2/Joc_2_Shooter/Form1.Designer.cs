﻿namespace Joc_2_Shooter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.WaveLabel = new System.Windows.Forms.Label();
            this.Gun = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1259, 805);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(0, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(34, 39);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "0";
            // 
            // HealthLabel
            // 
            this.HealthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HealthLabel.ForeColor = System.Drawing.Color.Black;
            this.HealthLabel.Location = new System.Drawing.Point(1088, 0);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(171, 39);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "Health 100";
            // 
            // WaveLabel
            // 
            this.WaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WaveLabel.AutoSize = true;
            this.WaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.WaveLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WaveLabel.ForeColor = System.Drawing.Color.Black;
            this.WaveLabel.Location = new System.Drawing.Point(613, 0);
            this.WaveLabel.Name = "WaveLabel";
            this.WaveLabel.Size = new System.Drawing.Size(121, 39);
            this.WaveLabel.TabIndex = 3;
            this.WaveLabel.Text = "Wave 1";
            // 
            // Gun
            // 
            this.Gun.BackColor = System.Drawing.Color.Transparent;
            this.Gun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gun.Image = ((System.Drawing.Image)(resources.GetObject("Gun.Image")));
            this.Gun.Location = new System.Drawing.Point(857, 379);
            this.Gun.Name = "Gun";
            this.Gun.Size = new System.Drawing.Size(200, 200);
            this.Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun.TabIndex = 4;
            this.Gun.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(122, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 358);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Play
            // 
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.Location = new System.Drawing.Point(355, 222);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(94, 29);
            this.Play.TabIndex = 6;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(355, 257);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 796);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.WaveLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label TimeLabel;
        public System.Windows.Forms.Label HealthLabel;
        public System.Windows.Forms.Label WaveLabel;
        public PictureBox Gun;
        private PictureBox pictureBox2;
        private Button Play;
        private Button Exit;
    }
}