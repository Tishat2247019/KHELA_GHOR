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

namespace DASHBOARD
{

        public partial class FormHome : Form
    {
    public static string username;

        private Size originalSize;
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
            Form1 car_racing = new Form1();
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
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnCarracing, "CAR RACING");
            tt.SetToolTip(this.btn_Arcade, "ARCADE GAME");
            tt.SetToolTip(this.btn_Snake, "CLASSIC SNAKE GAME");
            tt.SetToolTip(this.btn_RunningGame, "GRAVITY RUNNING GAME");
            tt.SetToolTip(this.btn_Helicopter, "HELICOPTER SHOOTER");
            tt.SetToolTip(this.btn_OtherGame, "OTHER GAME");
            if (!isHovered)
            {
                originalSize = button.Size;
               button.Location = new Point(button.Location.X -15, button.Location.Y);

                button.Size = new Size(originalSize.Width + 36, originalSize.Height + 34);
                isHovered = true;
            }
        }

        private void btn_RunningGame_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // button.Location = new Point(button.Location.X +7, button.Location.Y);
            // button.Size = new Size(94, 91);
            //button.BringToFront();

            if (isHovered)
            {
                 button.Location = new Point(button.Location.X + 15, button.Location.Y);

                button.Size = originalSize;
                isHovered = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
