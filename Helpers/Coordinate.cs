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
                    xSec = (InGameCoord.X / 192) + 134;
                }

                if (InGameCoord.Y >= 0)
                {
                    ySec = (InGameCoord.Y / 192) + 92;
                }
                else if (InGameCoord.Y < 0)
                {
                    ySec = (InGameCoord.Y / 192) + 91;
                }

                return new Point(xSec, ySec);
            }
        }
        #endregion

        #region PixelOnSector
        // Idea:
        // Caluclate with InGame Coordinates first and Convert the remaining Value into Pixel
        // Might be more accurate
        
        /// <summary>
        /// Calculate the Pixels based on the Coordinates related to the file
        /// </summary>
        public Point PixelOnSector
        {
            get
            {
                int pixeldiff_x;

                if (InGameCoord.X >= 0)
                {
                    // X is bigger than 0 so its right of 0|0

                    // Actual Coordinate - Difference
                    pixeldiff_x = InGameCoord.X - ((Sector.X - 135) * 192);
                }
                else
                {
                    // Coordinate is negative
                    pixeldiff_x = (InGameCoord.X + ((134 - Sector.X) * 192)) * -1;
                }


                int pixeldiff_y;

                if (InGameCoord.Y <= 0)
                {
                    pixeldiff_y = (InGameCoord.Y - ((91 - Sector.Y) * 192)) * -1;
                }
                else
                {
                    pixeldiff_y = InGameCoord.Y + ((Sector.Y - 92) * 192);
                }

                return new Point(ToPixel(pixeldiff_x), ToPixel(pixeldiff_y));
            }

        }
        #endregion

        #region ToPixel
        /// <summary>
        /// Convert InGame Coordinates into Pixels
        /// </summary>
        /// <returns>InGame Coordinate as Pixel</returns>
        private int ToPixel(int coord)
        {
            return Convert.ToInt32((double)coord * 1.333333333);
        }
        #endregion

    }
}
