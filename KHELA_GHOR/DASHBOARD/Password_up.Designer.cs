namespace DASHBOARD
{
    partial class Password_up
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.panel_usenamebelow = new System.Windows.Forms.Panel();
            this.txt_currentpass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_confirmpass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_changepass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 49);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.BackgroundImage = global::DASHBOARD.Properties.Resources.exit_full_screen__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(585, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 43);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password:";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Username.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Username.Location = new System.Drawing.Point(288, 60);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(187, 25);
            this.txtBox_Username.TabIndex = 6;
            this.txtBox_Username.TextChanged += new System.EventHandler(this.txtBox_Username_TextChanged);
            // 
            // panel_usenamebelow
            // 
            this.panel_usenamebelow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.panel_usenamebelow.Location = new System.Drawing.Point(279, 86);
            this.panel_usenamebelow.Name = "panel_usenamebelow";
            this.panel_usenamebelow.Size = new System.Drawing.Size(207, 4);
            this.panel_usenamebelow.TabIndex = 7;
            this.panel_usenamebelow.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_usenamebelow_Paint);
            // 
            // txt_currentpass
            // 
            this.txt_currentpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_currentpass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentpass.Location = new System.Drawing.Point(288, 95);
            this.txt_currentpass.Name = "txt_currentpass";
            this.txt_currentpass.Size = new System.Drawing.Size(198, 25);
            this.txt_currentpass.TabIndex = 6;
            this.txt_currentpass.TextChanged += new System.EventHandler(this.txt_currentpass_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(279, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 4);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_newpass
            // 
            this.txt_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newpass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpass.Location = new System.Drawing.Point(288, 135);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(198, 25);
            this.txt_newpass.TabIndex = 6;
            this.txt_newpass.TextChanged += new System.EventHandler(this.txt_newpass_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(279, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 4);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txt_confirmpass
            // 
            this.txt_confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmpass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpass.Location = new System.Drawing.Point(288, 182);
            this.txt_confirmpass.Name = "txt_confirmpass";
            this.txt_confirmpass.Size = new System.Drawing.Size(198, 25);
            this.txt_confirmpass.TabIndex = 6;
            this.txt_confirmpass.TextChanged += new System.EventHandler(this.txt_confirmpass_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(279, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 4);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_changepass
            // 
            this.btn_changepass.BackColor = System.Drawing.Color.Coral;
            this.btn_changepass.FlatAppearance.BorderSize = 0;
            this.btn_changepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepass.Location = new System.Drawing.Point(218, 251);
            this.btn_changepass.Name = "btn_changepass";
            this.btn_changepass.Size = new System.Drawing.Size(169, 53);
            this.btn_changepass.TabIndex = 3;
            this.btn_changepass.Text = "Change Password";
            this.btn_changepass.UseVisualStyleBackColor = false;
            this.btn_changepass.Click += new System.EventHandler(this.btn_changepass_Click);
            // 
            // Password_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 330);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_usenamebelow);
            this.Controls.Add(this.txt_confirmpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_currentpass);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_changepass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Password_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password_up";
            this.Load += new System.EventHandler(this.Password_up_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Panel panel_usenamebelow;
        private System.Windows.Forms.TextBox txt_currentpass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_confirmpass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_changepass;
    }
}