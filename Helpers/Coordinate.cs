using System;
using System.Text;
using System.Drawing;

namespace BotManager
{
    /// <summary>
    /// Coordinate Conversion Helper Class
    /// </summary>
    class Coordinate
    {
        private Point InGameCoord;

        // IMPORTANT: InGame (0|0) = Pixel (0|0) at Sector (135|91)

        #region Constructor
        /// <summary>
        /// Creates a new Coordinate Object
        /// </summary>
        /// <param name="Coord">Silkroad InGame Coordinate</param>
        public Coordinate(Point Coord)
        {
            InGameCoord = Coord;
        }
        #endregion

        #region Sector
        /// <summary>
        /// Returns the Sector of the Coordinate (readonly)
        /// </summary>
        public Point Sector
        {
            get
            {
                int xSec = 0;
                int ySec = 0;

                if (InGameCoord.X >= 0)
                {
                    xSec = (InGameCoord.X / 192) + 135;
                }
                else if (InGameCoord.X < 0)
                {
                    xSec = 134 - (InGameCoord.X / 192);
                }

                if (InGameCoord.Y >= 0)
                {
                    ySec = (InGameCoord.Y / 192) + 92;
                }
                else if (InGameCoord.Y < 0)
                {
                    ySec = 91 - (InGameCoord.Y / 192);
                }

                return new Point(xSec, ySec);
            }
        }
        #endregion

        #region RealCoordinates
        // Idea:
        // Caluclate with InGame Coordinates first and Convert the remaining Value into Pixel
        // Might be more accurate
        public Point RealCoordinates
        {
            get
            {
                int sectordiff_x;
                int pixeldiff_x;

                if (Sector.X >= 135)
                {
                    // Sector >= 135 means our coordinate is right of (0|0)
                    sectordiff_x = Sector.X - 135;
                    pixeldiff_x = AsPixel().X - (sectordiff_x * 256);
                }
                else
                {
                    sectordiff_x = 135 - Sector.X;
                    pixeldiff_x = (sectordiff_x * 256) + AsPixel().X;
                }


                int sectordiff_y;
                int pixeldiff_y;

                if (Sector.Y <= 91)
                {
                    // Sector <= 91 means our coordinate is lower than (0|0)
                    sectordiff_y = 91 - Sector.Y;
                    pixeldiff_y = AsPixel().Y - (sectordiff_y * 256);
                }
                else
                {
                    sectordiff_y = Sector.Y - 91;
                    pixeldiff_y = (sectordiff_y * 256) + AsPixel().Y;
                }


                return new Point(pixeldiff_x, pixeldiff_y);
            }

        }
        #endregion


        /// <summary>
        /// Convert InGame Coordinates into Pixels
        /// </summary>
        /// <returns>InGame Coordinate as Pixel</returns>
        private Point AsPixel()
        {
            return new Point(
                Convert.ToInt32((double)InGameCoord.X * 1.333333333),
                Convert.ToInt32((double)InGameCoord.Y * 1.333333333)
                );
        }
    }
}
