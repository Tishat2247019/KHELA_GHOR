namespace LOGIN_REGISTRATION
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.HeyYouLabel_Welcom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmtertainLabel_Welcom = new System.Windows.Forms.Label();
            this.btnSignUp_Welcom = new System.Windows.Forms.Button();
            this.btnSignIn_Welcom = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // HeyYouLabel_Welcom
            // 
            this.HeyYouLabel_Welcom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeyYouLabel_Welcom.AutoSize = true;
            this.HeyYouLabel_Welcom.BackColor = System.Drawing.Color.Transparent;
            this.HeyYouLabel_Welcom.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeyYouLabel_Welcom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeyYouLabel_Welcom.Location = new System.Drawing.Point(703, 86);
            this.HeyYouLabel_Welcom.Name = "HeyYouLabel_Welcom";
            this.HeyYouLabel_Welcom.Size = new System.Drawing.Size(193, 37);
            this.HeyYouLabel_Welcom.TabIndex = 1;
            this.HeyYouLabel_Welcom.Text = "Hey You!";
            this.HeyYouLabel_Welcom.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(556, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connect With Khela Ghor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmtertainLabel_Welcom
            // 
            this.EmtertainLabel_Welcom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmtertainLabel_Welcom.AutoSize = true;
            this.EmtertainLabel_Welcom.BackColor = System.Drawing.Color.Transparent;
            this.EmtertainLabel_Welcom.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmtertainLabel_Welcom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmtertainLabel_Welcom.Location = new System.Drawing.Point(663, 181);
            this.EmtertainLabel_Welcom.Name = "EmtertainLabel_Welcom";
            this.EmtertainLabel_Welcom.Size = new System.Drawing.Size(337, 18);
            this.EmtertainLabel_Welcom.TabIndex = 3;
            this.EmtertainLabel_Welcom.Text = "Entertain Yourself By Playing Mini Games";
            // 
            // btnSignUp_Welcom
            // 
            this.btnSignUp_Welcom.AutoSize = true;
            this.btnSignUp_Welcom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btnSignUp_Welcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp_Welcom.FlatAppearance.BorderSize = 2;
            this.btnSignUp_Welcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp_Welcom.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp_Welcom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp_Welcom.Location = new System.Drawing.Point(677, 309);
            this.btnSignUp_Welcom.Name = "btnSignUp_Welcom";
            this.btnSignUp_Welcom.Size = new System.Drawing.Size(290, 59);
            this.btnSignUp_Welcom.TabIndex = 4;
            this.btnSignUp_Welcom.Text = "SIGN UP";
            this.btnSignUp_Welcom.UseVisualStyleBackColor = false;
            this.btnSignUp_Welcom.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // btnSignIn_Welcom
            // 
            this.btnSignIn_Welcom.AutoSize = true;
            this.btnSignIn_Welcom.BackColor = System.Drawing.Color.Gray;
            this.btnSignIn_Welcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn_Welcom.FlatAppearance.BorderSize = 2;
            this.btnSignIn_Welcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn_Welcom.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn_Welcom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignIn_Welcom.Location = new System.Drawing.Point(677, 390);
            this.btnSignIn_Welcom.Name = "btnSignIn_Welcom";
            this.btnSignIn_Welcom.Size = new System.Drawing.Size(290, 59);
            this.btnSignIn_Welcom.TabIndex = 5;
            this.btnSignIn_Welcom.Text = "SIGN IN";
            this.btnSignIn_Welcom.UseVisualStyleBackColor = false;
            this.btnSignIn_Welcom.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::KHELA_GHOR.Properties.Resources.KHELA_GHOR_WELCOM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 658);
            this.Controls.Add(this.btnSignIn_Welcom);
            this.Controls.Add(this.EmtertainLabel_Welcom);
            this.Controls.Add(this.HeyYouLabel_Welcom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp_Welcom);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Welcome_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeyYouLabel_Welcom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmtertainLabel_Welcom;
        private System.Windows.Forms.Button btnSignUp_Welcom;
        private System.Windows.Forms.Button btnSignIn_Welcom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

