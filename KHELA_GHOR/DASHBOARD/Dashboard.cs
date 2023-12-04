﻿using System;
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


namespace DASHBOARD
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_RunningGame_Click(object sender, EventArgs e)
        {
            RunningGame r = new RunningGame();
            r.Show();
            this.Close();

        }

        private void btnCarracing_Click(object sender, EventArgs e)
        {
            Form1 car_racing  = new Form1();
            car_racing.Show();
            this.Close();
        }
    }
}
