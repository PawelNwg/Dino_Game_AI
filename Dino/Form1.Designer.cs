namespace Dino
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Dino = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Ground.Location = new System.Drawing.Point(-1, 411);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(801, 42);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(13, 13);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(67, 16);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Dino
            // 
            this.Dino.Image = global::Dino.Properties.Resources.running;
            this.Dino.Location = new System.Drawing.Point(71, 369);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(40, 43);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dino.TabIndex = 3;
            this.Dino.TabStop = false;
            this.Dino.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dino.Properties.Resources.obstacle_1;
            this.pictureBox2.Location = new System.Drawing.Point(358, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dino.Properties.Resources.obstacle_2;
            this.pictureBox3.Location = new System.Drawing.Point(548, 379);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Dino);
            this.MaximumSize = new System.Drawing.Size(818, 479);
            this.Name = "MainWindow";
            this.Tag = "obstacle";
            this.Text = "Dino Run";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

