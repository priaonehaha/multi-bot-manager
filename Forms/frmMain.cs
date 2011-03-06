using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace BotManager
{

    public partial class frmMain : Form
    {
        private RunningBots runningbots = new RunningBots();

        public frmMain()
        {
            InitializeComponent();
        }

        private void mm_v_open_map_Click(object sender, EventArgs e)
        {
            frmMap map = new frmMap();
            map.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Collect all running Bots
            runningbots.RefreshAll();
            Thread.Sleep(50);
            MessageBox.Show("Charname: " + runningbots[0].Charname);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


    }
}
