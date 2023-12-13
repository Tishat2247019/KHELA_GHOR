using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUNNING_GAME;
using Car_Racing;

//using MDITest;


namespace DASHBOARD
{
    public partial class Dashboard : Form
    {
        FormHome home;
        FormScoreBoard FormScoreBoard;
        FormSettings Settings;
        FormHelp help;

        public static string usernmaepass;

        bool siderBarExpand;
        public Dashboard()
        {
            InitializeComponent();
            

            btn_Help.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_ScoreBoard.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
        }

        public Dashboard(string username)
        {
            //lbl_UserNameHi.Text = "dsa";
            InitializeComponent();
            lbl_UserNameHi.Text = "Hi , "+ username;
            usernmaepass = username;
        }

        private void btn_RunningGame_Click(object sender, EventArgs e)
        {
            RunningGame r = new RunningGame();
            r.Show();
            this.Hide();

        }

        private void btnCarracing_Click(object sender, EventArgs e)
        {
            Form1 car_racing  = new Form1();
            car_racing.Show();
            this.Hide();
        }

        private void sideBar_timer_Tick(object sender, EventArgs e)
        {
            // set the minimum and miximum size of the panel_sidebarconatainer panel

            if (siderBarExpand)
            {
                panel_sideBarContainer.Width -= 15;
                if (panel_sideBarContainer.Width == panel_sideBarContainer.MinimumSize.Width)
                {
                    siderBarExpand = false; ;
                    sideBar_timer.Stop();

                    panel_home.Width = panel_sideBarContainer.Width;
                    panel_settings.Width = panel_sideBarContainer.Width;
                    panel_scoreboard.Width = panel_sideBarContainer.Width;
                    panel_help.Width = panel_sideBarContainer.Width; ;

                }
            }

            else
            {
                panel_sideBarContainer.Width += 15;
                if (panel_sideBarContainer.Width == panel_sideBarContainer.MaximumSize.Width)
                {
                    siderBarExpand = true;
                    sideBar_timer.Stop();

                    panel_home.Width = panel_sideBarContainer.Width;
                    panel_settings.Width = panel_sideBarContainer.Width;
                    panel_scoreboard.Width = panel_sideBarContainer.Width;
                    panel_help.Width = panel_sideBarContainer.Width; ;
                }
            }
        }

        private void picBox_Menu_Click(object sender, EventArgs e)
        {
            sideBar_timer.Start();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
           // Dashboard d = new Dashboard();
            if (home == null)
            {
                home = new FormHome();
                home.FormClosed += FormHome_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show(); 
            }
            else
            {
                home.Activate();
            }
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            home = new FormHome();
            home.FormClosed += FormHome_FormClosed;
            home.MdiParent = this;
            home.Dock = DockStyle.Fill;
            home.Show();
            MDIprob();
        }

        private void MDIprob()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void btn_ScoreBoard_Click(object sender, EventArgs e)
        {
            FormScoreBoard scoreboard = new FormScoreBoard();
            scoreboard.FormClosed += FormScoreboard_FormClosed;
            scoreboard.MdiParent = this;
            scoreboard.Dock = DockStyle.Fill;
            scoreboard.Show();
        }

        private void FormScoreboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        
    }
}
