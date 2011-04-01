using System;
using System.Drawing;
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
            
            // Call this before trying to generate an Image
            Map.ChangeSize(pb_map.Size);
            Map.CenterCoordinate = new Coordinate(50, 50);
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
            pb_map.Image = Map.GenerateImage();
        }

        private void pb_map_SizeChanged(object sender, EventArgs e)
        {
            Map.ChangeSize(pb_map.Size);
        }

        private void frmMap_ResizeEnd(object sender, EventArgs e)
        {
            pb_map.Size = new Size(Size.Width - 42, Size.Height - toolStrip1.Size.Height - 52);
        }


    }
}
