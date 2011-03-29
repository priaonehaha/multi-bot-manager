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
            Map.ChangeSize(pb_map.Size);
        }



        private void pb_map_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int diffX = e.X - oldX;
                int diffY = e.Y - oldY;

                oldX = e.X;
                oldY = e.Y;
                
                //Map.MoveMap(diffX, diffY);

            }
        }

        private void tsb_follow_char_Click(object sender, EventArgs e)
        {
            //pb_map.Image = Map.GenerateImage();

            Coordinate coord = new Coordinate(new Point(-50, 50));

            MessageBox.Show(coord.PixelOnSector.ToString() + "\n" + coord.Sector.ToString());
        }

        private void pb_map_SizeChanged(object sender, EventArgs e)
        {
            Map.ChangeSize(pb_map.Size);
        }


    }
}
