using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Racing;
using RUNNING_GAME;
using Classic_Snake_Game;

namespace DASHBOARD
{

        public partial class FormHome : Form
    {
    public static string username;

        private Size originalSize;
        private Size originalSize2;
        private bool isHovered = false;

        public FormHome()
        {
            InitializeComponent();
            username = Dashboard.usernmaepass;
            btnCarracing.FlatAppearance.MouseOverBackColor = Color.White;
            btn_RunningGame.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Snake.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Arcade.FlatAppearance.MouseOverBackColor = Color.White;
            btn_OtherGame.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Helicopter.FlatAppearance.MouseOverBackColor = Color.White;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
           

        }

        private void btnCarracing_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                this.MdiParent.Hide();
            }
            this.Hide();
            Car_Racing.Form1 car_racing = new Car_Racing.Form1(username);
            car_racing.FormClosed += CarRacing_FormClosed;
            car_racing.Show();
        }

        private void CarRacing_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show both the MdiParent (Dashboard form) and the Home form when the car racing game form is closed
            if (this.MdiParent != null)
            {
                this.MdiParent.Show();
            }

            this.Show();
        }

        private void btn_RunningGame_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                this.MdiParent.Hide();
            }
            this.Hide();
            RunningGame run_game = new RunningGame(username);
            run_game.FormClosed += RunningGame_FormClosed;
            run_game.Show();
        }

        private void RunningGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show both the MdiParent (Dashboard form) and the Home  form when the car racing game form is closed
            if (this.MdiParent != null)
            {
                this.MdiParent.Show();
            }

            this.Show();
        }

        private void btnCarracing_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //button.Location = new Point(button.Location.X -7, button.Location.Y);
            //button.Size = new Size(120, 115);
            //button.BringToFront();
            Label label; // Declare the label separately
            if (sender == btnCarracing)
            {
                label = lbl_carracing;// Replace lbl_CarRacing with the actual label name
            }
            else if (sender == btn_Arcade)
            {
                label = lbl_arcadegame; // Replace lbl_Arcade with the actual label name
            }
            else if (sender == btn_Snake)
            {
                label = lbl_classicsnkegame; // Replace lbl_Snake with the actual label name
            }
            else if (sender == btn_RunningGame)
            {
                label = lbl_runninggame; // Replace lbl_RunningGame with the actual label name
            }
            else if (sender == btn_Helicopter)
            {
                label = lbl_helicoptergame; // Replace lbl_Helicopter with the actual label name
            }

            else
            {
                return; // Handle other cases if necessary
            }


            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnCarracing, "CAR RACING");
            tt.SetToolTip(this.btn_Arcade, "ARCADE GAME");
            tt.SetToolTip(this.btn_Snake, "CLASSIC SNAKE GAME");
            tt.SetToolTip(this.btn_RunningGame, "GRAVITY RUNNING GAME");
            tt.SetToolTip(this.btn_Helicopter, "HELICOPTER SHOOTER");
            tt.SetToolTip(this.btn_OtherGame, "COMING SOON");
            if (!isHovered)
            {
                originalSize = button.Size;
                originalSize2 = label.Size;
               button.Location = new Point(button.Location.X - 15, button.Location.Y);
                button.Size = new Size(originalSize.Width + 36, originalSize.Height + 34);

                label.Location = new Point(label.Location.X - 5, label.Location.Y + 10);
                label.Size = new Size(originalSize2.Width + 36, originalSize2.Height + 34);
                isHovered = true;
            }
        }

        private void btn_RunningGame_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Label label; // Declare the label separately
            if (sender == btnCarracing)
            {
                label = lbl_carracing;// Replace lbl_CarRacing with the actual label name
            }
            else if (sender == btn_Arcade)
            {
                label = lbl_arcadegame; // Replace lbl_Arcade with the actual label name
            }
            else if (sender == btn_Snake)
            {
                label = lbl_classicsnkegame; // Replace lbl_Snake with the actual label name
            }
            else if (sender == btn_RunningGame)
            {
                label = lbl_runninggame; // Replace lbl_RunningGame with the actual label name
            }
            else if (sender == btn_Helicopter)
            {
                label = lbl_helicoptergame; // Replace lbl_Helicopter with the actual label name
            }
            
            else
            {
                return; // Handle other cases if necessary
            }

            // button.Location = new Point(button.Location.X +7, button.Location.Y);
            // button.Size = new Size(94, 91);
            //button.BringToFront();

            if (isHovered)
            {
                 button.Location = new Point(button.Location.X + 15, button.Location.Y);

                button.Size = originalSize;

                label.Location = new Point(label.Location.X + 5, label.Location.Y -10);
                label.Size = originalSize2;
                isHovered = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Snake_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                this.MdiParent.Hide();
            }
            this.Hide();
            Classic_Snake_Game.Form1 snake_game = new Classic_Snake_Game.Form1(username);
            snake_game.FormClosed += Snakegame_FormClosed;
            snake_game.Show();
        }

        private void Snakegame_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show both the MdiParent (Dashboard form) and the Home form when the car racing game form is closed
            if (this.MdiParent != null)
            {
                this.MdiParent.Show();
            }

            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
