namespace DASHBOARD
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
            this.picBox_Menu = new System.Windows.Forms.PictureBox();
            this.panel_home = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel_scoreboard = new System.Windows.Forms.Panel();
            this.btn_ScoreBoard = new System.Windows.Forms.Button();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.panel_help = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.sideBar_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_UserNameHi = new System.Windows.Forms.Label();
            this.panel_sideBarContainer.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Menu)).BeginInit();
            this.panel_home.SuspendLayout();
            this.panel_scoreboard.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.panel_help.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel_sideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideBarContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_sideBarContainer.Location = new System.Drawing.Point(0, 0);
            this.panel_sideBarContainer.MaximumSize = new System.Drawing.Size(203, 632);
            this.panel_sideBarContainer.MinimumSize = new System.Drawing.Size(76, 632);
            this.panel_sideBarContainer.Name = "panel_sideBarContainer";
            this.panel_sideBarContainer.Size = new System.Drawing.Size(203, 632);
            this.panel_sideBarContainer.TabIndex = 1;
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
            // picBox_Menu
            // 
            this.picBox_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_Menu.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Menu.Image")));
            this.picBox_Menu.Location = new System.Drawing.Point(12, 9);
            this.picBox_Menu.Name = "picBox_Menu";
            this.picBox_Menu.Size = new System.Drawing.Size(45, 43);
            this.picBox_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Menu.TabIndex = 0;
            this.picBox_Menu.TabStop = false;
            this.picBox_Menu.Click += new System.EventHandler(this.picBox_Menu_Click);
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.btn_Home);
            this.panel_home.Location = new System.Drawing.Point(3, 82);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(202, 77);
            this.panel_home.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
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
            // 
            // panel_scoreboard
            // 
            this.panel_scoreboard.Controls.Add(this.btn_ScoreBoard);
            this.panel_scoreboard.Location = new System.Drawing.Point(3, 165);
            this.panel_scoreboard.Name = "panel_scoreboard";
            this.panel_scoreboard.Size = new System.Drawing.Size(202, 77);
            this.panel_scoreboard.TabIndex = 2;
            // 
            // btn_ScoreBoard
            // 
            this.btn_ScoreBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_ScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ScoreBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ScoreBoard.FlatAppearance.BorderSize = 0;
            this.btn_ScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreBoard.Image = ((System.Drawing.Image)(resources.GetObject("btn_ScoreBoard.Image")));
            this.btn_ScoreBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ScoreBoard.Location = new System.Drawing.Point(12, 15);
            this.btn_ScoreBoard.Name = "btn_ScoreBoard";
            this.btn_ScoreBoard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ScoreBoard.Size = new System.Drawing.Size(179, 47);
            this.btn_ScoreBoard.TabIndex = 0;
            this.btn_ScoreBoard.TabStop = false;
            this.btn_ScoreBoard.Text = "              SCOREBOARD";
            this.btn_ScoreBoard.UseVisualStyleBackColor = false;
            this.btn_ScoreBoard.Click += new System.EventHandler(this.btn_ScoreBoard_Click);
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.btn_Settings);
            this.panel_settings.Location = new System.Drawing.Point(3, 248);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(202, 77);
            this.panel_settings.TabIndex = 2;
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
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
            // 
            // panel_help
            // 
            this.panel_help.Controls.Add(this.btn_Help);
            this.panel_help.Location = new System.Drawing.Point(3, 331);
            this.panel_help.Name = "panel_help";
            this.panel_help.Size = new System.Drawing.Size(202, 77);
            this.panel_help.TabIndex = 2;
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Location = new System.Drawing.Point(12, 15);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Help.Size = new System.Drawing.Size(179, 47);
            this.btn_Help.TabIndex = 0;
            this.btn_Help.TabStop = false;
            this.btn_Help.Text = "                 HELP";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.UseVisualStyleBackColor = false;
            // 
            // sideBar_timer
            // 
            this.sideBar_timer.Interval = 50;
            this.sideBar_timer.Tick += new System.EventHandler(this.sideBar_timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.lbl_UserNameHi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 32);
            this.panel1.TabIndex = 3;
            // 
            // lbl_UserNameHi
            // 
            this.lbl_UserNameHi.AutoSize = true;
            this.lbl_UserNameHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameHi.Location = new System.Drawing.Point(372, 4);
            this.lbl_UserNameHi.Name = "lbl_UserNameHi";
            this.lbl_UserNameHi.Size = new System.Drawing.Size(60, 24);
            this.lbl_UserNameHi.TabIndex = 0;
            this.lbl_UserNameHi.Text = "label1";
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_sideBarContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel_sideBarContainer.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Menu)).EndInit();
            this.panel_home.ResumeLayout(false);
            this.panel_scoreboard.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_help.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panel_sideBarContainer;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panel_scoreboard;
        private System.Windows.Forms.Button btn_ScoreBoard;
        private System.Windows.Forms.Panel panel_help;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.PictureBox picBox_Menu;
        private System.Windows.Forms.Timer sideBar_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_UserNameHi;
    }
}

