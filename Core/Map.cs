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
        static Point centercoord = new Point(119,23);

        // Größe des Image
        static Size imagesize;

        public static Image GenerateImage()
        {
            // Basic Image Container
            Image baseimage = new Bitmap(imagesize.Width, imagesize.Height);

            // GDI+ for the Basic Image Container
            Graphics graph = Graphics.FromImage(baseimage);

            #region Region / Sektor berechnen
            int xSec = 0;
            int ySec = 0;

            if (centercoord.X >= 0)
            {
                xSec = (centercoord.X / 192) + 135;
            }
            else if (centercoord.X < 0)
            {
                xSec = 134 - (centercoord.X / 192);
            }

            if (centercoord.Y >= 0)
            {
                ySec = (centercoord.Y / 192) + 92;
            }
            else if (centercoord.Y < 0)
            {
                ySec = 91 - (centercoord.Y / 192);
            }
            #endregion

            // Load the Center Image
            Image center = Image.FromFile(basepath + xSec.ToString() + "x" + ySec.ToString() + ".jpg");

            // Generate the Position based on the InGameCoordinates
            
            // Get the Pixel of the Coordinate on the Image
            double modifier = 1.333333333333;

            

            Point posaspix = new Point(
                Convert.ToInt32(centercoord.X * modifier), 
                Convert.ToInt32(centercoord.Y * modifier)
                );

            // Get the Center of the PictureBox
            Point pbcenter = new Point(imagesize.Width / 2, imagesize.Height / 2);

            // Calculate Image Position
            Point position = new Point(pbcenter.X - posaspix.X, posaspix.Y - pbcenter.Y);

            graph.DrawImage(center,position);

            // Tempoary Draw the Center of the Image

            graph.DrawEllipse(new Pen(Color.Blue), new Rectangle(pbcenter, new Size(2, 2)));

            return baseimage;

        }

        public static void ChangeSize(Size nSize)
        {
            imagesize = nSize;
        }

    }
}
