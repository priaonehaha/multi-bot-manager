using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotManager
{
    public static class Map
    {
        // Standart Pfad für den MapOrdner
        static string basepath = "map/";

        // Mittelpunkt des Bildes (in SroKoordinaten)
        public static Coordinate CenterCoordinate = new Coordinate(0,0);

        // Größe des Image
        static Size imagesize;

        public static Image GenerateImage()
        {
            // Basic Image Container
            Image baseimage = new Bitmap(imagesize.Width, imagesize.Height);

            // GDI+ for the Basic Image Container
            Graphics graph = Graphics.FromImage(baseimage);

            // Load the Center Image
            Image center = ImageFromSection(CenterCoordinate.Sector);

            // Get the Center of the PictureBox
            Point pbcenter = new Point(imagesize.Width / 2, imagesize.Height / 2);

            Point imagepos = new Point(pbcenter.X - CenterCoordinate.PixelOnSector.X, pbcenter.Y - CenterCoordinate.PixelOnSector.Y);

            graph.DrawImage(center, imagepos);


            int numx = 0;
            int numy = 0;
            while (true)
            {
                /*
                 * This Formula is a bit complicated. We will calculate the 
                 * Number of images that must be drawn to fill the image
                 * 
                    int distanceleft = pbcenter.X - CenterCoordinate.PixelOnSector.X;
                    int distancecalculated = numx * 256;
                    int distanceremaining = distanceleft - distancecalculated;
                 * 
                 * 
                 */

                if (!((pbcenter.X - CenterCoordinate.PixelOnSector.X) - (numx * 256) <= 0))
                { // If not reached the Border
                    numx++;
                }
                else if (!((pbcenter.Y - CenterCoordinate.PixelOnSector.Y) - (numy * 256) <= 0))
                {
                    numy++;
                }
                else
                { break; }
            }
            MessageBox.Show(numx.ToString() + " " + numy.ToString());

            int cx = 0;
            int cy = 0;

            while (true)
            {
                
                while (true)
                {
                    Image newimg = ImageFromSection(
                        CenterCoordinate.Sector.X - cx,
                        CenterCoordinate.Sector.Y - cy);

                    graph.DrawImage(newimg, new Point(
                        pbcenter.X - CenterCoordinate.PixelOnSector.X - (cx * 256),
                        pbcenter.Y - CenterCoordinate.PixelOnSector.Y - (cy * 256)
                        ));
                }
            }
            
            // Image drawn inverted. Fix it !


            // If Enough space on left
                // Draw image on left
                
                // Increase numleft ?
            

            

            // If Enough space on top

            // Draw image on left top

            // Draw image on top

            // In Enough space on right

            // Draw image on right top
            // Draw image on right

            // If Enough space on bottom

            // Draw image on right bottom
            // Draw image on bottom

            // As checked before -> Draw image on left bottom

            


            // Tempoary Draw the Center of the Image
            graph.DrawEllipse(new Pen(Color.Blue), new Rectangle(pbcenter, new Size(2, 2)));

            return baseimage;

        }

        #region ChangeWindowSize
        public static void ChangeSize(Size nSize)
        {
            imagesize = nSize;
        }
        #endregion


        #region ImageFromSection
        private static Image ImageFromSection(int xSec, int ySec)
        {
            return Image.FromFile((basepath + xSec.ToString() + "x" + ySec.ToString() + ".jpg"));
        }

        private static Image ImageFromSection(Point section)
        {
            return Image.FromFile((basepath + section.X.ToString() + "x" + section.Y.ToString() + ".jpg"));
        }
        #endregion

    }
}
