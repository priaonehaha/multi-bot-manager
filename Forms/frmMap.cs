using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BotManager
{
    public partial class frmMap : Form
    {
        private int oldX = 0;
        private int oldY = 0;

        public frmMap()
        {
            InitializeComponent();
        }

        

        private void pb_map_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int diffX = e.X - oldX;
                int diffY = e.Y - oldY;

                oldX = e.X;
                oldY = e.Y;

                Map.MoveMap(diffX, diffY);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
