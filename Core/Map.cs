/*
 * Name:    Map-Class
 * Author:  florian0
 * Version: 1.2
*/ 

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BotManager
{
    public static class Map
    {
        #region ToDo
        /* Improve Mapgeneration-code for more speed and less CPU-usage (more RAM-usage)
         * Image-Scaling -> ADD RECTANGLE SCALE !!!
         * 
         */
        #endregion

        // Path for the Map Folder
        static string basepath = "map/";

        // Coordinate to center the Map
        public static Coordinate CenterCoordinate = new Coordinate(0,0);

        // Size of the Image
        static Size imagesize;

        // Scale Factor
        static double scalefactor = 0.50;

        #region GenerateImage
        public static Image GenerateImage()
        {

            // Basic Image Container
            Image baseimage = new Bitmap(imagesize.Width, imagesize.Height);

            // GDI+ for the Basic Image Container
            Graphics graph = Graphics.FromImage(baseimage);

            // Get the Center of the PictureBox
            Point pbcenter = new Point(imagesize.Width / 2, imagesize.Height / 2);

            // Calculate the Scale-Value based on the Scale-Factor
            int scalevalue = (int)((double)256 * scalefactor);
            

            // Calculate the Number of Images
            Point num = new Point(
                (int)Math.Truncate((double)(imagesize.Width / scalevalue)),
                (int)Math.Truncate((double)(imagesize.Height / scalevalue))
                );

            // Calculate the starting Position
            Point startpos = new Point(
                (pbcenter.X - (int)(Math.Truncate((double)(pbcenter.X / scalevalue)) * scalevalue)) - (int)(CenterCoordinate.PixelOnSector.X * scalefactor),
                (pbcenter.Y - (int)(Math.Truncate((double)(pbcenter.Y / scalevalue)) * scalevalue)) - (int)(CenterCoordinate.PixelOnSector.Y * scalefactor)
                );

            // Calculate the starting Sector
            Point startsec = new Point(
                CenterCoordinate.Sector.X - (int)(Math.Truncate((double)(pbcenter.X / scalevalue))),
                CenterCoordinate.Sector.Y + (int)(Math.Truncate((double)(pbcenter.Y / scalevalue)))
                );

            for(int cx = 0; cx <= num.X;cx++)
            {
                for(int cy = 0; cy <= num.Y;cy++)
                {

                    try
                    {
                        // Load Image from File
                        Image newimg = ImageFromSection(startsec.X + cx, startsec.Y - cy);

                        // Draw Image to Position
                        graph.DrawImage(
                            newimg,
                            new Rectangle(
                                new Point(
                                    startpos.X + (cx * scalevalue),
                                    startpos.Y + (cy * scalevalue)
                                    ),
                                new Size(scalevalue, scalevalue)
                            )
                        );
                    }
                    catch (FileNotFoundException fex)
                    {
                        // Disabled for debugging
                        //MessageBox.Show(fex.ToString());
                        continue;
                    }
                }
            }

            // Temporary Draw the Center of the Image
            graph.DrawEllipse(new Pen(Color.Blue), new Rectangle(pbcenter, new Size(5,5)));

            return baseimage;
        }
        #endregion

        #region MoveMap
        public static void MoveMap(int diffx, int diffy)
        {
            // Divide the difference by 1.33_ to calculate the InGame-Coordinate
            CenterCoordinate.InGame = new Point(
                CenterCoordinate.InGame.X + (int)(diffx / 1.33333333333333),
                CenterCoordinate.InGame.Y + (int)(diffy / 1.33333333333333)
            );
        }
        #endregion

        #region Scale
        /// <summary>
        /// Scale the Image
        /// </summary>
        /// <param name="scaling">The Scaling-Value. </param>
        public static double Scale
        {
            get
            {
                return scalefactor;
            }
            set
            {
                if (value >= 0 || value <= 2.00)
                {
                    scalefactor = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "ScaleFactor", 
                        "The Scalefactor has to be between 0 and 2.0"
                    );
                }
            }

        }
        #endregion

        #region ChangeWindowSize
        /// <summary>
        /// Changes the ImageSize of the drawn Image
        /// </summary>
        /// <param name="nSize">The new Size of the Image</param>
        public static void ChangeSize(Size nSize)
        {
            imagesize = nSize;
        }
        #endregion

        #region ImageFromSection
        /// <summary>
        /// Load the Image from File
        /// </summary>
        /// <param name="xSec"></param>
        /// <param name="ySec"></param>
        /// <returns></returns>
        private static Image ImageFromSection(int xSec, int ySec)
        {
            return Image.FromFile((basepath + xSec.ToString() + "x" + ySec.ToString() + ".jpg"));
        }
        /// <summary>
        /// /// Load the Image from File
        /// </summary>
        /// <param name="section">The Section</param>
        /// <returns>The Image loaded</returns>
        private static Image ImageFromSection(Point section)
        {
            return Image.FromFile((basepath + section.X.ToString() + "x" + section.Y.ToString() + ".jpg"));
        }
        #endregion

    }
}
