namespace Classic_Snake_Game
{
    partial class SnakeGamepop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUPerror_Oops = new System.Windows.Forms.Label();
            this.lbl_congrats = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Restart = new System.Windows.Forms.Label();
            this.lbl_Gameover = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picbox_gameOver = new System.Windows.Forms.PictureBox();
            this.picBox_lottie = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_lottie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.signUPerror_Oops);
            this.panel1.Controls.Add(this.lbl_congrats);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 49);
            this.panel1.TabIndex = 6;
            // 
            // signUPerror_Oops
            // 
            this.signUPerror_Oops.AutoSize = true;
            this.signUPerror_Oops.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUPerror_Oops.Location = new System.Drawing.Point(3, 9);
            this.signUPerror_Oops.Name = "signUPerror_Oops";
            this.signUPerror_Oops.Size = new System.Drawing.Size(59, 18);
            this.signUPerror_Oops.TabIndex = 3;
            this.signUPerror_Oops.Text = "Oops..";
            // 
            // lbl_congrats
            // 
            this.lbl_congrats.AutoSize = true;
            this.lbl_congrats.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congrats.Location = new System.Drawing.Point(169, 9);
            this.lbl_congrats.Name = "lbl_congrats";
            this.lbl_congrats.Size = new System.Drawing.Size(220, 37);
            this.lbl_congrats.TabIndex = 2;
            this.lbl_congrats.Text = "Congratulations";
            this.lbl_congrats.Visible = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(184, 97);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(163, 30);
            this.lbl_Score.TabIndex = 10;
            this.lbl_Score.Text = "Your Score is :";
            this.lbl_Score.Visible = false;
            // 
            // lbl_Restart
            // 
            this.lbl_Restart.AutoSize = true;
            this.lbl_Restart.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Restart.Location = new System.Drawing.Point(192, 139);
            this.lbl_Restart.Name = "lbl_Restart";
            this.lbl_Restart.Size = new System.Drawing.Size(165, 30);
            this.lbl_Restart.TabIndex = 11;
            this.lbl_Restart.Text = "Restart Again?";
            this.lbl_Restart.Visible = false;
            // 
            // lbl_Gameover
            // 
            this.lbl_Gameover.AutoSize = true;
            this.lbl_Gameover.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gameover.Location = new System.Drawing.Point(196, 51);
            this.lbl_Gameover.Name = "lbl_Gameover";
            this.lbl_Gameover.Size = new System.Drawing.Size(161, 37);
            this.lbl_Gameover.TabIndex = 9;
            this.lbl_Gameover.Text = "Game Over";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(318, 194);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 36);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(142, 194);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(106, 36);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Classic_Snake_Game.Properties.Resources.exit_full_screen__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(488, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 43);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picbox_gameOver
            // 
            this.picbox_gameOver.Image = global::Classic_Snake_Game.Properties.Resources.Animation___1702655022387;
            this.picbox_gameOver.Location = new System.Drawing.Point(12, 51);
            this.picbox_gameOver.Name = "picbox_gameOver";
            this.picbox_gameOver.Size = new System.Drawing.Size(148, 147);
            this.picbox_gameOver.TabIndex = 12;
            this.picbox_gameOver.TabStop = false;
            // 
            // picBox_lottie
            // 
            this.picBox_lottie.Location = new System.Drawing.Point(197, 44);
            this.picBox_lottie.Name = "picBox_lottie";
            this.picBox_lottie.Size = new System.Drawing.Size(133, 144);
            this.picBox_lottie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_lottie.TabIndex = 13;
            this.picBox_lottie.TabStop = false;
            // 
            // SnakeGamepop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Restart);
            this.Controls.Add(this.lbl_Gameover);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.picbox_gameOver);
            this.Controls.Add(this.picBox_lottie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnakeGamepop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGamepop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_lottie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signUPerror_Oops;
        private System.Windows.Forms.Label lbl_congrats;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Restart;
        private System.Windows.Forms.Label lbl_Gameover;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.PictureBox picbox_gameOver;
        private System.Windows.Forms.PictureBox picBox_lottie;
    }
}