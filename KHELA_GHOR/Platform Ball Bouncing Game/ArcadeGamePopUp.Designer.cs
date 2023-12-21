namespace Platform_Ball_Bouncing_Game
{
    partial class ArcadeGamePopUp
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
            this.signUPerror_Oops = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_congrats = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Restart = new System.Windows.Forms.Label();
            this.lbl_Gameover = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.picbox_gameOver = new System.Windows.Forms.PictureBox();
            this.picbox_lottie = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_lottie)).BeginInit();
            this.SuspendLayout();
            // 
            // signUPerror_Oops
            // 
            this.signUPerror_Oops.AutoSize = true;
            this.signUPerror_Oops.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUPerror_Oops.Location = new System.Drawing.Point(4, 11);
            this.signUPerror_Oops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUPerror_Oops.Name = "signUPerror_Oops";
            this.signUPerror_Oops.Size = new System.Drawing.Size(72, 24);
            this.signUPerror_Oops.TabIndex = 3;
            this.signUPerror_Oops.Text = "Oops..";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.signUPerror_Oops);
            this.panel1.Controls.Add(this.lbl_congrats);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 60);
            this.panel1.TabIndex = 6;
            // 
            // lbl_congrats
            // 
            this.lbl_congrats.AutoSize = true;
            this.lbl_congrats.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congrats.Location = new System.Drawing.Point(225, 11);
            this.lbl_congrats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_congrats.Name = "lbl_congrats";
            this.lbl_congrats.Size = new System.Drawing.Size(283, 47);
            this.lbl_congrats.TabIndex = 2;
            this.lbl_congrats.Text = "Congratulations";
            this.lbl_congrats.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(651, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_Restart
            // 
            this.lbl_Restart.AutoSize = true;
            this.lbl_Restart.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Restart.Location = new System.Drawing.Point(256, 185);
            this.lbl_Restart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Restart.Name = "lbl_Restart";
            this.lbl_Restart.Size = new System.Drawing.Size(206, 38);
            this.lbl_Restart.TabIndex = 10;
            this.lbl_Restart.Text = "Restart Again?";
            this.lbl_Restart.Visible = false;
            // 
            // lbl_Gameover
            // 
            this.lbl_Gameover.AutoSize = true;
            this.lbl_Gameover.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gameover.Location = new System.Drawing.Point(261, 76);
            this.lbl_Gameover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gameover.Name = "lbl_Gameover";
            this.lbl_Gameover.Size = new System.Drawing.Size(203, 47);
            this.lbl_Gameover.TabIndex = 9;
            this.lbl_Gameover.Text = "Game Over";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(424, 252);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(141, 44);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(189, 252);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(141, 44);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_ok_MouseClick);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(245, 133);
            this.lbl_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(204, 38);
            this.lbl_Score.TabIndex = 11;
            this.lbl_Score.Text = "Your Score is :";
            this.lbl_Score.Visible = false;
            // 
            // picbox_gameOver
            // 
            this.picbox_gameOver.Location = new System.Drawing.Point(16, 76);
            this.picbox_gameOver.Margin = new System.Windows.Forms.Padding(4);
            this.picbox_gameOver.Name = "picbox_gameOver";
            this.picbox_gameOver.Size = new System.Drawing.Size(197, 181);
            this.picbox_gameOver.TabIndex = 12;
            this.picbox_gameOver.TabStop = false;
            // 
            // picbox_lottie
            // 
            this.picbox_lottie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox_lottie.Location = new System.Drawing.Point(0, 0);
            this.picbox_lottie.Margin = new System.Windows.Forms.Padding(4);
            this.picbox_lottie.Name = "picbox_lottie";
            this.picbox_lottie.Size = new System.Drawing.Size(709, 316);
            this.picbox_lottie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_lottie.TabIndex = 13;
            this.picbox_lottie.TabStop = false;
            this.picbox_lottie.Visible = false;
            // 
            // ArcadeGamePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Restart);
            this.Controls.Add(this.lbl_Gameover);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.picbox_gameOver);
            this.Controls.Add(this.picbox_lottie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArcadeGamePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcadeGamePopUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_lottie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUPerror_Oops;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_congrats;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Restart;
        private System.Windows.Forms.Label lbl_Gameover;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.PictureBox picbox_gameOver;
        private System.Windows.Forms.PictureBox picbox_lottie;
    }
}