namespace LOGIN_REGISTRATION
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_PassAfter = new System.Windows.Forms.PictureBox();
            this.picBox_UserAfter = new System.Windows.Forms.PictureBox();
            this.picBox_userBefore = new System.Windows.Forms.PictureBox();
            this.txt_UserLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignin_Login = new System.Windows.Forms.Button();
            this.btnSignup_Login = new System.Windows.Forms.Button();
            this.Login_label1 = new System.Windows.Forms.Label();
            this.picBox_PassBefore = new System.Windows.Forms.PictureBox();
            this.txt_PassLogin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBox_Eye = new System.Windows.Forms.PictureBox();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.Login_Label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PassAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_UserAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_userBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PassBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Eye)).BeginInit();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KHELA_GHOR.Properties.Resources.REGISTER_SCREEN_KHELAGHOR_LOGORIGHT;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1095, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_PassAfter
            // 
            this.picBox_PassAfter.Image = global::KHELA_GHOR.Properties.Resources.PASSWORD_AFTER;
            this.picBox_PassAfter.Location = new System.Drawing.Point(12, 149);
            this.picBox_PassAfter.Name = "picBox_PassAfter";
            this.picBox_PassAfter.Size = new System.Drawing.Size(23, 26);
            this.picBox_PassAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_PassAfter.TabIndex = 13;
            this.picBox_PassAfter.TabStop = false;
            this.picBox_PassAfter.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // picBox_UserAfter
            // 
            this.picBox_UserAfter.Image = global::KHELA_GHOR.Properties.Resources.USER_AFTER;
            this.picBox_UserAfter.Location = new System.Drawing.Point(15, 77);
            this.picBox_UserAfter.Name = "picBox_UserAfter";
            this.picBox_UserAfter.Size = new System.Drawing.Size(22, 22);
            this.picBox_UserAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_UserAfter.TabIndex = 12;
            this.picBox_UserAfter.TabStop = false;
            this.picBox_UserAfter.Visible = false;
            // 
            // picBox_userBefore
            // 
            this.picBox_userBefore.Image = global::KHELA_GHOR.Properties.Resources.USER_FIRST;
            this.picBox_userBefore.Location = new System.Drawing.Point(14, 77);
            this.picBox_userBefore.Name = "picBox_userBefore";
            this.picBox_userBefore.Size = new System.Drawing.Size(26, 25);
            this.picBox_userBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_userBefore.TabIndex = 0;
            this.picBox_userBefore.TabStop = false;
            this.picBox_userBefore.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_UserLogin
            // 
            this.txt_UserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserLogin.Font = new System.Drawing.Font("Roboto Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserLogin.Location = new System.Drawing.Point(46, 77);
            this.txt_UserLogin.Name = "txt_UserLogin";
            this.txt_UserLogin.Size = new System.Drawing.Size(256, 26);
            this.txt_UserLogin.TabIndex = 20;
            this.txt_UserLogin.Text = "Username";
            this.txt_UserLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_UserLogin_MouseClick);
            this.txt_UserLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_UserLogin.Leave += new System.EventHandler(this.txt_UserLogin_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 4);
            this.panel2.TabIndex = 3;
            // 
            // btnSignin_Login
            // 
            this.btnSignin_Login.AutoSize = true;
            this.btnSignin_Login.BackColor = System.Drawing.Color.Coral;
            this.btnSignin_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin_Login.FlatAppearance.BorderSize = 2;
            this.btnSignin_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin_Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin_Login.Location = new System.Drawing.Point(14, 229);
            this.btnSignin_Login.Name = "btnSignin_Login";
            this.btnSignin_Login.Size = new System.Drawing.Size(307, 59);
            this.btnSignin_Login.TabIndex = 19;
            this.btnSignin_Login.Text = "SIGN IN";
            this.btnSignin_Login.UseVisualStyleBackColor = false;
            this.btnSignin_Login.Click += new System.EventHandler(this.btnSignin_Login_Click);
            // 
            // btnSignup_Login
            // 
            this.btnSignup_Login.AutoSize = true;
            this.btnSignup_Login.BackColor = System.Drawing.Color.White;
            this.btnSignup_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup_Login.FlatAppearance.BorderSize = 2;
            this.btnSignup_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup_Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup_Login.Location = new System.Drawing.Point(14, 347);
            this.btnSignup_Login.Name = "btnSignup_Login";
            this.btnSignup_Login.Size = new System.Drawing.Size(307, 59);
            this.btnSignup_Login.TabIndex = 20;
            this.btnSignup_Login.Text = "SIGN UP";
            this.btnSignup_Login.UseVisualStyleBackColor = false;
            this.btnSignup_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_label1
            // 
            this.Login_label1.AutoSize = true;
            this.Login_label1.Font = new System.Drawing.Font("Roboto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_label1.Location = new System.Drawing.Point(12, 23);
            this.Login_label1.Name = "Login_label1";
            this.Login_label1.Size = new System.Drawing.Size(320, 25);
            this.Login_label1.TabIndex = 21;
            this.Login_label1.Text = "Please Login to Your Account\r\n";
            this.Login_label1.Click += new System.EventHandler(this.Label_Login_Click);
            // 
            // picBox_PassBefore
            // 
            this.picBox_PassBefore.Image = global::KHELA_GHOR.Properties.Resources.PASSWORD_FIRSTT;
            this.picBox_PassBefore.Location = new System.Drawing.Point(11, 150);
            this.picBox_PassBefore.Name = "picBox_PassBefore";
            this.picBox_PassBefore.Size = new System.Drawing.Size(26, 25);
            this.picBox_PassBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_PassBefore.TabIndex = 22;
            this.picBox_PassBefore.TabStop = false;
            // 
            // txt_PassLogin
            // 
            this.txt_PassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassLogin.Font = new System.Drawing.Font("Roboto Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassLogin.Location = new System.Drawing.Point(46, 146);
            this.txt_PassLogin.Name = "txt_PassLogin";
            this.txt_PassLogin.Size = new System.Drawing.Size(208, 26);
            this.txt_PassLogin.TabIndex = 23;
            this.txt_PassLogin.Text = "Password";
            this.txt_PassLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_PassLogin_MouseClick);
            this.txt_PassLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_PassLogin.Leave += new System.EventHandler(this.txt_PassLogin_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(14, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 4);
            this.panel3.TabIndex = 24;
            // 
            // picBox_Eye
            // 
            this.picBox_Eye.Image = global::KHELA_GHOR.Properties.Resources.Asset_1;
            this.picBox_Eye.Location = new System.Drawing.Point(290, 144);
            this.picBox_Eye.Name = "picBox_Eye";
            this.picBox_Eye.Size = new System.Drawing.Size(23, 28);
            this.picBox_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Eye.TabIndex = 25;
            this.picBox_Eye.TabStop = false;
            this.picBox_Eye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox_Eye_MouseClick);
            this.picBox_Eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_Eye_MouseDown);
            this.picBox_Eye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_Eye_MouseUp);
            // 
            // panel_Login
            // 
            this.panel_Login.AutoSize = true;
            this.panel_Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_Login.Controls.Add(this.Login_Label2);
            this.panel_Login.Controls.Add(this.picBox_Eye);
            this.panel_Login.Controls.Add(this.panel3);
            this.panel_Login.Controls.Add(this.txt_PassLogin);
            this.panel_Login.Controls.Add(this.picBox_PassBefore);
            this.panel_Login.Controls.Add(this.Login_label1);
            this.panel_Login.Controls.Add(this.btnSignup_Login);
            this.panel_Login.Controls.Add(this.btnSignin_Login);
            this.panel_Login.Controls.Add(this.panel2);
            this.panel_Login.Controls.Add(this.txt_UserLogin);
            this.panel_Login.Controls.Add(this.picBox_userBefore);
            this.panel_Login.Controls.Add(this.picBox_UserAfter);
            this.panel_Login.Controls.Add(this.picBox_PassAfter);
            this.panel_Login.Location = new System.Drawing.Point(605, 107);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(365, 434);
            this.panel_Login.TabIndex = 2;
            this.panel_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login_Label2
            // 
            this.Login_Label2.AutoSize = true;
            this.Login_Label2.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label2.Location = new System.Drawing.Point(53, 323);
            this.Login_Label2.Name = "Login_Label2";
            this.Login_Label2.Size = new System.Drawing.Size(230, 21);
            this.Login_Label2.TabIndex = 26;
            this.Login_Label2.Text = "Not A Khela Khor User?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnBack_Login
            // 
            this.btnBack_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack_Login.BackgroundImage")));
            this.btnBack_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack_Login.FlatAppearance.BorderSize = 0;
            this.btnBack_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_Login.Location = new System.Drawing.Point(3, 3);
            this.btnBack_Login.Name = "btnBack_Login";
            this.btnBack_Login.Size = new System.Drawing.Size(34, 34);
            this.btnBack_Login.TabIndex = 4;
            this.btnBack_Login.UseVisualStyleBackColor = true;
            this.btnBack_Login.Click += new System.EventHandler(this.btnBack_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.btnBack_Login);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PassAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_UserAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_userBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_PassBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Eye)).EndInit();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_PassAfter;
        private System.Windows.Forms.PictureBox picBox_UserAfter;
        private System.Windows.Forms.PictureBox picBox_userBefore;
        private System.Windows.Forms.TextBox txt_UserLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignin_Login;
        private System.Windows.Forms.Button btnSignup_Login;
        private System.Windows.Forms.Label Login_label1;
        private System.Windows.Forms.PictureBox picBox_PassBefore;
        private System.Windows.Forms.TextBox txt_PassLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBox_Eye;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Label Login_Label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnBack_Login;
    }
}