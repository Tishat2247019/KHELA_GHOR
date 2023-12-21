namespace Helicopter_Shooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.lbl_HighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Indigo;
            this.txtScore.Location = new System.Drawing.Point(9, 7);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(89, 21);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(650, 26);
            this.bird.Margin = new System.Windows.Forms.Padding(2);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(75, 65);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 7;
            this.bird.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::Helicopter_Shooter.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(313, 7);
            this.explosion.Margin = new System.Windows.Forms.Padding(2);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(38, 41);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Image = global::Helicopter_Shooter.Properties.Resources.bomb1;
            this.bomb.Location = new System.Drawing.Point(446, 7);
            this.bomb.Margin = new System.Windows.Forms.Padding(2);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(30, 32);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb.TabIndex = 5;
            this.bomb.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Helicopter_Shooter.Properties.Resources.alien1;
            this.ufo.Location = new System.Drawing.Point(596, 240);
            this.ufo.Margin = new System.Windows.Forms.Padding(2);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Helicopter_Shooter.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(76, 97);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // pillar2
            // 
            this.pillar2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pillar2.Image = global::Helicopter_Shooter.Properties.Resources.wall75x185;
            this.pillar2.Location = new System.Drawing.Point(345, 459);
            this.pillar2.Margin = new System.Windows.Forms.Padding(2);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(59, 205);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 0;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // lbl_HighScore
            // 
            this.lbl_HighScore.AutoSize = true;
            this.lbl_HighScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HighScore.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HighScore.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_HighScore.Location = new System.Drawing.Point(887, 18);
            this.lbl_HighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HighScore.Name = "lbl_HighScore";
            this.lbl_HighScore.Size = new System.Drawing.Size(89, 21);
            this.lbl_HighScore.TabIndex = 4;
            this.lbl_HighScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.explosion);
            this.Controls.Add(this.lbl_HighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helicopter Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label lbl_HighScore;
    }
}

