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
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

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
        private Image originalImage;

        bool siderBarExpand;

        private Size originalSize;
        private bool isHovered = false;

        //for resize functionality
        private Rectangle OriginalFormSize;

        private Rectangle PicMenuOriginalRectangle1;
        private Rectangle PanelMenuOriginalRectangle1;
        private Rectangle lblMenuOriginalRectangle1;

        private Rectangle PanelTopContainerOriginalRectangle1;
        private Rectangle lblUsernameHiriginalRectangle1;

        private Rectangle PanelSideContainerOriginalRectangle1;


        //private float originalPanelFontSize;

        private Rectangle BtnHomeOriginalRectangle1;
        private Rectangle PanelHOmeOriginalRectangl2;
        private Rectangle PanelSideHomeOriginalRectangl3;


        private Rectangle BtnScoreBoardOriginalRectangle1;
        private Rectangle PanelScoreBoardOriginalRectangl2;
        private Rectangle PanelSideScoreBoardOriginalRectangl3;

        private Rectangle BtnSettingsOriginalRectangle1;
        private Rectangle PanelSettingsOriginalRectangl2;
        private Rectangle PanelSideSettinsOriginalRectangl3;

        private Rectangle BtnHelpOriginalRectangle1;
        private Rectangle PanelHelpOriginalRectangl2;
        private Rectangle PanelSideHelpOriginalRectangl3;

        


        private float originalButtonsFontSize;
        private float originalLabelUsernameFontSize;
        private float originalLabelMenuFontSize;

        public Dashboard()
        {
            InitializeComponent();

            //InitCustomLabelFont();
            btn_Help.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_ScoreBoard.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
        }

        public Dashboard(string username)
        {
            //lbl_UserNameHi.Text = "dsa";
            InitializeComponent();
           // InitCustomLabelFont();
            lbl_UserNameHi.Text = "Hi , "+ username;
            usernmaepass = username;
            btn_Help.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
            btn_ScoreBoard.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 90, 41);
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
            panel_sidehome.Visible = true;
            panel_sidescore.Visible = false;
            panel_sidesettings.Visible = false;
            panel_sidehelp.Visible = false;

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
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            PicMenuOriginalRectangle1 = new Rectangle(picBox_Menu.Location.X, picBox_Menu.Location.Y, picBox_Menu.Width, picBox_Menu.Height);
            PanelMenuOriginalRectangle1 = new Rectangle(panel_top.Location.X, panel_top.Location.Y, panel_top.Width, panel_top.Height);
            lblMenuOriginalRectangle1 = new Rectangle(lbl_Menu.Location.X, lbl_Menu.Location.Y, lbl_Menu.Width, lbl_Menu.Height);

            PanelTopContainerOriginalRectangle1 = new Rectangle(panel_topcontainer.Location.X, panel_topcontainer.Location.Y, panel_topcontainer.Width, panel_topcontainer.Height);
            lblUsernameHiriginalRectangle1 = new Rectangle(lbl_UserNameHi.Location.X, lbl_UserNameHi.Location.Y, lbl_UserNameHi.Width, lbl_UserNameHi.Height);
            PanelSideContainerOriginalRectangle1 = new Rectangle(panel_sideBarContainer.Location.X, panel_sideBarContainer.Location.Y, panel_sideBarContainer.Width, panel_sideBarContainer.Height);
           
            
            BtnHomeOriginalRectangle1 = new Rectangle(btn_Home.Location.X, btn_Home.Location.Y, btn_Home.Width, btn_Home.Height);
            PanelHOmeOriginalRectangl2 = new Rectangle(panel_home.Location.X, panel_home.Location.Y, panel_home.Width, panel_home.Height); 
            PanelSideHomeOriginalRectangl3 = new Rectangle(panel_sidehome.Location.X, panel_sidehome.Location.Y, panel_sidehome.Width, panel_sidehome.Height);


            BtnScoreBoardOriginalRectangle1 = new Rectangle(btn_ScoreBoard.Location.X, btn_ScoreBoard.Location.Y, btn_ScoreBoard.Width, btn_ScoreBoard.Height);
            PanelScoreBoardOriginalRectangl2 = new Rectangle(panel_scoreboard.Location.X, panel_scoreboard.Location.Y, panel_scoreboard.Width, panel_scoreboard.Height);
            PanelSideScoreBoardOriginalRectangl3 = new Rectangle(panel_sidescore.Location.X, panel_sidescore.Location.Y, panel_sidescore.Width, panel_sidescore.Height);


            BtnSettingsOriginalRectangle1 = new Rectangle(btn_Settings.Location.X, btn_Settings.Location.Y, btn_Settings.Width, btn_Settings.Height);
            PanelSettingsOriginalRectangl2 = new Rectangle(panel_settings.Location.X, panel_settings.Location.Y, panel_settings.Width, panel_settings.Height);
            PanelSideSettinsOriginalRectangl3 = new Rectangle(panel_sidesettings.Location.X, panel_sidesettings.Location.Y, panel_sidesettings.Width, panel_sidesettings.Height);

            BtnHelpOriginalRectangle1 = new Rectangle(btn_Help.Location.X, btn_Help.Location.Y, btn_Help.Width, btn_Help.Height);
            PanelHelpOriginalRectangl2 = new Rectangle(panel_help.Location.X, panel_help.Location.Y, panel_help.Width, panel_help.Height);
            PanelSideHelpOriginalRectangl3 = new Rectangle(panel_sidehelp.Location.X, panel_sidehelp.Location.Y, panel_sidehelp.Width, panel_sidehelp.Height);

            originalButtonsFontSize = btn_Home.Font.Size;
            originalLabelMenuFontSize = lbl_Menu.Font.Size;
            originalLabelUsernameFontSize = lbl_UserNameHi.Font.Size;

           

            panel_sidehome.Visible = true;
            home = new FormHome();
            home.FormClosed += FormHome_FormClosed;
            home.MdiParent = this;
            home.Dock = DockStyle.Fill;
            home.Show();
            MDIprob();
                    

    }

    private void resizeControl(Rectangle r, Control c, float originalfontsize)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
            float newfontsize = originalfontsize * ratio;
            Font newfont = new Font(c.Font.FontFamily, newfontsize);
            c.Font = newfont;
        }
        private void resizeControl2(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }

        }
        private void Dashboard_Resize(object sender, EventArgs e)
        {
            resizeControl2(PicMenuOriginalRectangle1, picBox_Menu);
            resizeControl2(PanelMenuOriginalRectangle1, panel_top);
            resizeControl(lblMenuOriginalRectangle1, lbl_Menu, originalLabelMenuFontSize);

            resizeControl2(PanelTopContainerOriginalRectangle1, panel_topcontainer);
            resizeControl(lblUsernameHiriginalRectangle1, lbl_UserNameHi, originalLabelUsernameFontSize);
            resizeControl2(PanelSideContainerOriginalRectangle1, panel_sideBarContainer);

            resizeControl(BtnHomeOriginalRectangle1, btn_Home, originalButtonsFontSize);
            resizeControl2(PanelHOmeOriginalRectangl2, panel_home);
            resizeControl2(PanelSideHomeOriginalRectangl3, panel_sidehome);

            resizeControl(BtnScoreBoardOriginalRectangle1, btn_ScoreBoard, originalButtonsFontSize);
            resizeControl2(PanelScoreBoardOriginalRectangl2, panel_scoreboard);
            resizeControl2(PanelSideScoreBoardOriginalRectangl3, panel_sidescore);

            resizeControl(BtnSettingsOriginalRectangle1, btn_Settings, originalButtonsFontSize);
            resizeControl2(PanelSettingsOriginalRectangl2, panel_settings);
            resizeControl2(PanelSideSettinsOriginalRectangl3, panel_sidesettings);

            resizeControl(BtnHelpOriginalRectangle1, btn_Help, originalButtonsFontSize);
            resizeControl2(PanelHelpOriginalRectangl2, panel_help);
            resizeControl2(PanelSideHelpOriginalRectangl3, panel_sidehelp);


        }

        private void MDIprob()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void btn_ScoreBoard_Click(object sender, EventArgs e)
        {
            panel_sidehome.Visible = false;
            panel_sidescore.Visible = true;
            panel_sidesettings.Visible = false;
            panel_sidehelp.Visible = false;
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

        private void panel_sideBarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsidepanel_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //button.Location = new Point(button.Location.X -7, button.Location.Y);
            //button.Size = new Size(120, 115);
            //button.BringToFront();

            if (!isHovered)
            {
                originalSize = button.Size;
                button.Location = new Point(button.Location.X - 5, button.Location.Y - 5);

                button.Size = new Size(originalSize.Width + 26, originalSize.Height + 24);
                isHovered = true;
            }
        }

        private void btn_sidepanel_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // button.Location = new Point(button.Location.X +7, button.Location.Y);
            // button.Size = new Size(94, 91);
            //button.BringToFront();

            if (isHovered)
            {
                button.Location = new Point(button.Location.X + 5, button.Location.Y + 5);

                button.Size = originalSize;
                isHovered = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            panel_sidehome.Visible = false;
            panel_sidescore.Visible = false;
            panel_sidesettings.Visible = true;
            panel_sidehelp.Visible = false;
            Settings = new FormSettings();
            Settings.FormClosed += formSettings_FormClosed;
            Settings.MdiParent = this;
            Settings.Dock = DockStyle.Fill;
            Settings.Show();
        }

        private void formSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            panel_sidehome.Visible = false;
            panel_sidescore.Visible = false;
            panel_sidesettings.Visible = false;
            panel_sidehelp.Visible = true;

            if (help == null)
            {
                help = new FormHelp();
                help.FormClosed += FormHome_FormClosed;
                help.MdiParent = this;
                help.Dock = DockStyle.Fill;
                help.Show();
            }
            else
            {
                help.Activate();
            }
        }

        
    }
}
