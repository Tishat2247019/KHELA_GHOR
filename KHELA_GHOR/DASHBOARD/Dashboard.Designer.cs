﻿namespace DASHBOARD
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel_sideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.panel_home = new System.Windows.Forms.Panel();
            this.panel_sidehome = new System.Windows.Forms.Panel();
            this.panel_scoreboard = new System.Windows.Forms.Panel();
            this.panel_sidescore = new System.Windows.Forms.Panel();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.panel_sidesettings = new System.Windows.Forms.Panel();
            this.panel_help = new System.Windows.Forms.Panel();
            this.panel_sidehelp = new System.Windows.Forms.Panel();
            this.sideBar_timer = new System.Windows.Forms.Timer(this.components);
            this.panel_topcontainer = new System.Windows.Forms.Panel();
            this.lbl_UserNameHi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.picBox_Menu = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_ScoreBoard = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sideBarContainer.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.panel_scoreboard.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.panel_help.SuspendLayout();
            this.panel_topcontainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sideBarContainer
            // 
            this.panel_sideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.panel_sideBarContainer.Controls.Add(this.panel_top);
            this.panel_sideBarContainer.Controls.Add(this.panel_home);
            this.panel_sideBarContainer.Controls.Add(this.panel_scoreboard);
            this.panel_sideBarContainer.Controls.Add(this.panel_settings);
            this.panel_sideBarContainer.Controls.Add(this.panel_help);
            this.panel_sideBarContainer.Controls.Add(this.panel1);
            this.panel_sideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideBarContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_sideBarContainer.Location = new System.Drawing.Point(0, 0);
            this.panel_sideBarContainer.MaximumSize = new System.Drawing.Size(203, 632);
            this.panel_sideBarContainer.MinimumSize = new System.Drawing.Size(76, 632);
            this.panel_sideBarContainer.Name = "panel_sideBarContainer";
            this.panel_sideBarContainer.Size = new System.Drawing.Size(203, 632);
            this.panel_sideBarContainer.TabIndex = 1;
            this.panel_sideBarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sideBarContainer_Paint);
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.lbl_Menu);
            this.panel_top.Controls.Add(this.picBox_Menu);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(202, 73);
            this.panel_top.TabIndex = 0;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.Location = new System.Drawing.Point(79, 19);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(66, 24);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "MENU";
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.panel_sidehome);
            this.panel_home.Controls.Add(this.btn_Home);
            this.panel_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_home.Location = new System.Drawing.Point(3, 82);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(202, 77);
            this.panel_home.TabIndex = 1;
            // 
            // panel_sidehome
            // 
            this.panel_sidehome.BackColor = System.Drawing.Color.Black;
            this.panel_sidehome.Location = new System.Drawing.Point(0, 4);
            this.panel_sidehome.Name = "panel_sidehome";
            this.panel_sidehome.Size = new System.Drawing.Size(5, 70);
            this.panel_sidehome.TabIndex = 6;
            this.panel_sidehome.Visible = false;
            // 
            // panel_scoreboard
            // 
            this.panel_scoreboard.Controls.Add(this.panel_sidescore);
            this.panel_scoreboard.Controls.Add(this.btn_ScoreBoard);
            this.panel_scoreboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_scoreboard.Location = new System.Drawing.Point(3, 165);
            this.panel_scoreboard.Name = "panel_scoreboard";
            this.panel_scoreboard.Size = new System.Drawing.Size(202, 77);
            this.panel_scoreboard.TabIndex = 2;
            // 
            // panel_sidescore
            // 
            this.panel_sidescore.BackColor = System.Drawing.Color.Black;
            this.panel_sidescore.Location = new System.Drawing.Point(0, 4);
            this.panel_sidescore.Name = "panel_sidescore";
            this.panel_sidescore.Size = new System.Drawing.Size(5, 70);
            this.panel_sidescore.TabIndex = 6;
            this.panel_sidescore.Visible = false;
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.panel_sidesettings);
            this.panel_settings.Controls.Add(this.btn_Settings);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_settings.Location = new System.Drawing.Point(3, 248);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(202, 77);
            this.panel_settings.TabIndex = 2;
            // 
            // panel_sidesettings
            // 
            this.panel_sidesettings.BackColor = System.Drawing.Color.Black;
            this.panel_sidesettings.Location = new System.Drawing.Point(0, 4);
            this.panel_sidesettings.Name = "panel_sidesettings";
            this.panel_sidesettings.Size = new System.Drawing.Size(5, 70);
            this.panel_sidesettings.TabIndex = 6;
            this.panel_sidesettings.Visible = false;
            // 
            // panel_help
            // 
            this.panel_help.Controls.Add(this.panel_sidehelp);
            this.panel_help.Controls.Add(this.btn_Help);
            this.panel_help.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_help.Location = new System.Drawing.Point(3, 331);
            this.panel_help.Name = "panel_help";
            this.panel_help.Size = new System.Drawing.Size(202, 77);
            this.panel_help.TabIndex = 2;
            // 
            // panel_sidehelp
            // 
            this.panel_sidehelp.BackColor = System.Drawing.Color.Black;
            this.panel_sidehelp.Location = new System.Drawing.Point(0, 4);
            this.panel_sidehelp.Name = "panel_sidehelp";
            this.panel_sidehelp.Size = new System.Drawing.Size(5, 70);
            this.panel_sidehelp.TabIndex = 6;
            this.panel_sidehelp.Visible = false;
            // 
            // sideBar_timer
            // 
            this.sideBar_timer.Interval = 50;
            this.sideBar_timer.Tick += new System.EventHandler(this.sideBar_timer_Tick);
            // 
            // panel_topcontainer
            // 
            this.panel_topcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.panel_topcontainer.Controls.Add(this.lbl_UserNameHi);
            this.panel_topcontainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topcontainer.Location = new System.Drawing.Point(203, 0);
            this.panel_topcontainer.Name = "panel_topcontainer";
            this.panel_topcontainer.Size = new System.Drawing.Size(892, 32);
            this.panel_topcontainer.TabIndex = 3;
            // 
            // lbl_UserNameHi
            // 
            this.lbl_UserNameHi.AutoSize = true;
            this.lbl_UserNameHi.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameHi.Location = new System.Drawing.Point(372, 4);
            this.lbl_UserNameHi.Name = "lbl_UserNameHi";
            this.lbl_UserNameHi.Size = new System.Drawing.Size(68, 23);
            this.lbl_UserNameHi.TabIndex = 0;
            this.lbl_UserNameHi.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 206);
            this.panel1.TabIndex = 3;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(83, 75);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(64, 18);
            this.lbl_logout.TabIndex = 1;
            this.lbl_logout.Text = "Logout";
            // 
            // picBox_Menu
            // 
            this.picBox_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_Menu.Image = global::DASHBOARD.Properties.Resources.Animation___1702661425530;
            this.picBox_Menu.Location = new System.Drawing.Point(-16, -13);
            this.picBox_Menu.Name = "picBox_Menu";
            this.picBox_Menu.Size = new System.Drawing.Size(87, 91);
            this.picBox_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Menu.TabIndex = 0;
            this.picBox_Menu.TabStop = false;
            this.picBox_Menu.Click += new System.EventHandler(this.picBox_Menu_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Image = global::DASHBOARD.Properties.Resources.home_135x35;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(12, 15);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(179, 47);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Text = "               HOME";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            this.btn_Home.MouseLeave += new System.EventHandler(this.btn_sidepanel_MouseLeave);
            this.btn_Home.MouseHover += new System.EventHandler(this.btnsidepanel_MouseHover);
            // 
            // btn_ScoreBoard
            // 
            this.btn_ScoreBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_ScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ScoreBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ScoreBoard.FlatAppearance.BorderSize = 0;
            this.btn_ScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ScoreBoard.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreBoard.Image = global::DASHBOARD.Properties.Resources.scoreboard35x35;
            this.btn_ScoreBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ScoreBoard.Location = new System.Drawing.Point(12, 15);
            this.btn_ScoreBoard.Name = "btn_ScoreBoard";
            this.btn_ScoreBoard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ScoreBoard.Size = new System.Drawing.Size(179, 47);
            this.btn_ScoreBoard.TabIndex = 0;
            this.btn_ScoreBoard.TabStop = false;
            this.btn_ScoreBoard.Text = "           SCOREBOARD";
            this.btn_ScoreBoard.UseVisualStyleBackColor = false;
            this.btn_ScoreBoard.Click += new System.EventHandler(this.btn_ScoreBoard_Click);
            this.btn_ScoreBoard.MouseLeave += new System.EventHandler(this.btn_sidepanel_MouseLeave);
            this.btn_ScoreBoard.MouseHover += new System.EventHandler(this.btnsidepanel_MouseHover);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Image = global::DASHBOARD.Properties.Resources.settings35x35;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(12, 15);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Settings.Size = new System.Drawing.Size(179, 47);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.TabStop = false;
            this.btn_Settings.Text = "               SETTINGS";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            this.btn_Settings.MouseLeave += new System.EventHandler(this.btn_sidepanel_MouseLeave);
            this.btn_Settings.MouseHover += new System.EventHandler(this.btnsidepanel_MouseHover);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Image = global::DASHBOARD.Properties.Resources.support35x35;
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Location = new System.Drawing.Point(12, 15);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Help.Size = new System.Drawing.Size(179, 47);
            this.btn_Help.TabIndex = 0;
            this.btn_Help.TabStop = false;
            this.btn_Help.Text = "                 HELP";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.UseCompatibleTextRendering = true;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            this.btn_Help.MouseLeave += new System.EventHandler(this.btn_sidepanel_MouseLeave);
            this.btn_Help.MouseHover += new System.EventHandler(this.btnsidepanel_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DASHBOARD.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(17, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.panel_topcontainer);
            this.Controls.Add(this.panel_sideBarContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.panel_sideBarContainer.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_home.ResumeLayout(false);
            this.panel_scoreboard.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_help.ResumeLayout(false);
            this.panel_topcontainer.ResumeLayout(false);
            this.panel_topcontainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panel_sideBarContainer;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panel_scoreboard;
        private System.Windows.Forms.Button btn_ScoreBoard;
        private System.Windows.Forms.Panel panel_help;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Timer sideBar_timer;
        private System.Windows.Forms.Panel panel_topcontainer;
        private System.Windows.Forms.Label lbl_UserNameHi;
        private System.Windows.Forms.Panel panel_sidehome;
        private System.Windows.Forms.Panel panel_sidescore;
        private System.Windows.Forms.Panel panel_sidesettings;
        private System.Windows.Forms.Panel panel_sidehelp;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.PictureBox picBox_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

