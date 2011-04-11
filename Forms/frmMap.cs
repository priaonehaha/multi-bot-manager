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
            Map.CenterCoordinate = new Coordinate(-111,385);
        }


        #region MouseMove (Disabled)
        /*
        private void pb_map_MouseMove(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Left)
            {
                int diffX = e.X - oldX;
                int diffY = e.Y - oldY;

                if (diffX < 10 || diffY < 10)
                    return;

                oldX = e.X;
                oldY = e.Y;

                Map.MoveMap(diffX, diffY);

                pb_map.Image = Map.GenerateImage();
            }
        }*/
        #endregion

        private void tsb_follow_char_Click(object sender, EventArgs e)
        {
            Map.CenterCoordinate = new Coordinate(Convert.ToInt32(toolStripTextBox1.Text), (Convert.ToInt32(toolStripTextBox2.Text)));
            
            pb_map.Image = Map.GenerateImage();
        }

        private void frmMap_ResizeEnd(object sender, EventArgs e)
        {
            pb_map.Size = new Size(Size.Width - 42, Size.Height - toolStrip1.Size.Height - 52);
            
            Map.ChangeSize(pb_map.Size);
        }

        private void tsl_zoomin_Click(object sender, EventArgs e)
        {
            Map.Scale = Map.Scale + 0.1;
            pb_map.Image = Map.GenerateImage();
        }

        private void tsl_zoomout_Click(object sender, EventArgs e)
        {
            Map.Scale = Map.Scale - 0.1;
            pb_map.Image = Map.GenerateImage();
        }



    }
}
