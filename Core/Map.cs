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
                (int)Math.Truncate((double)(imagesize.Width / 256) + 0.5),
                (int)Math.Truncate((double)(imagesize.Height / 256) + 0.5)
                );


            // Calculate the starting Position
            Point startpos = new Point(
                (pbcenter.X - (int)(Math.Truncate((double)(pbcenter.X / 256)) * 256)) - CenterCoordinate.PixelOnSector.X,
                (pbcenter.Y - (int)(Math.Truncate((double)(pbcenter.Y / 256)) * 256)) - CenterCoordinate.PixelOnSector.Y
                );

            // Calculate the starting Sector
            Point startsec = new Point(
                CenterCoordinate.Sector.X - (int)(Math.Truncate((double)(pbcenter.X / 256))),
                CenterCoordinate.Sector.Y + (int)(Math.Truncate((double)(pbcenter.Y / 256)))
                );
            
            for(int cx = 0; cx <= num.X;cx++)
            {
                for(int cy = 0; cy <= num.Y;cy++)
                {
                    Image newimg = ImageFromSection(startsec.X + cx, startsec.Y - cy);

                    graph.DrawImage(
                        newimg,
                        new Point(
                            startpos.X + (cx * 256),
                            startpos.Y + (cy * 256)
                            )
                        );
                }
            }

            // Temporary Draw the Center of the Image
            graph.DrawEllipse(new Pen(Color.Blue), new Rectangle(pbcenter, new Size(5,5)));

            return baseimage;
        }

        public static void MoveMap(int diffx, int diffy)
        {
            CenterCoordinate.InGame = new Point(
                CenterCoordinate.InGame.X + (int)(diffx / 1.33333333333333),
                CenterCoordinate.InGame.Y + (int)(diffy / 1.33333333333333)
            );
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
