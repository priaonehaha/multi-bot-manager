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
        static Coordinate center_coord = new Coordinate(new Point(25, 43));

        // Größe des Image
        static Size imagesize;

        public static Image GenerateImage()
        {
            // Basic Image Container
            Image baseimage = new Bitmap(imagesize.Width, imagesize.Height);

            // GDI+ for the Basic Image Container
            Graphics graph = Graphics.FromImage(baseimage);

            // Load the Center Image
            Image center = Image.FromFile(basepath + center_coord.Sector.X.ToString() + "x" + center_coord.Sector.Y.ToString() + ".jpg");

            // Get the Center of the PictureBox
            Point pbcenter = new Point(imagesize.Width / 2, imagesize.Height / 2);

            // Calculate Image Position
            //Point position = new Point(pbcenter.X - posaspix.X, posaspix.Y - pbcenter.Y);

            //graph.DrawImage(center,position);

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
