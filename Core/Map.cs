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

            // Get the Center of the PictureBox
            Point pbcenter = new Point(imagesize.Width / 2, imagesize.Height / 2);

            // Calculate the Number of Images
            Point num = new Point(
                
                (int)Math.Truncate((double)(imagesize.Width / 256)),
                (int)Math.Truncate((double)(imagesize.Height / 256))
                
                );


            // int remainingpixels = pbcenter.X - (Math.Truncate((double)(pbcenter.X / 256)) * 256)
            Point startpos = new Point(
                (pbcenter.X - (int)(Math.Truncate((double)(pbcenter.X / 256)) * 256)) - CenterCoordinate.PixelOnSector.X,
                (pbcenter.Y - (int)(Math.Truncate((double)(pbcenter.Y / 256)) * 256)) - CenterCoordinate.PixelOnSector.Y
                );

            Point startsec = new Point(
                CenterCoordinate.Sector.X - (int)(Math.Truncate((double)(pbcenter.X / 256))),
                CenterCoordinate.Sector.Y - (int)(Math.Truncate((double)(pbcenter.Y / 256)))
                );
            for(int cx = 0; cx <= num.X;cx++)
            {
                for(int cy = 0; cy <= num.Y;cy++)
                {
                    Image newimg = ImageFromSection(startsec.X + cx, startsec.Y - cy);

                    graph.DrawImage(
                        newimg,
                        new Point(
                            startpos.X + (cx * 257),
                            startpos.Y + (cy * 257)
                            )
                        );

                    
                    
                    //MessageBox.Show("Image drawn\n" + cx.ToString() + " " + cy.ToString() + "\n");
                    
                }
            }

            // Image is drawn inverted
            // Add a starting position and calculate from there

            // Tempoary Draw the Center of the Image
            graph.DrawEllipse(new Pen(Color.Blue), new Rectangle(pbcenter, new Size(5,5)));

            return baseimage;

        }

        private static Point NumberOfImages()
        {
            int numx = 0;
            int numy = 0;

            while (true)
            {
                /*
                 * This Formula is a bit complicated. We will calculate the 
                 * Number of images that must be drawn to fill the image
                 * Example:
                    int distancetocenter = imagesize.X / 2;
                    int distanceleft = distancetocenter - CenterCoordinate.PixelOnSector.X;
                    int distancecalculated = num.X * 256;
                    int distanceremaining = distanceleft - distancecalculated;
                 */

                if (!(((imagesize.Height / 2) - CenterCoordinate.PixelOnSector.X) - (numx * 256) <= 0))
                { // If not reached the Border
                    numx++;
                }
                else if (!(((imagesize.Width / 2) - CenterCoordinate.PixelOnSector.Y) - (numy * 256) <= 0))
                {
                    numy++;
                }
                else
                { break; }
            }

            return new Point(numx, numy);
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
