using System;
using System.Text;
using System.Drawing;

namespace BotManager
{
    /// <summary>
    /// Coordinate Conversion Helper Class
    /// </summary>
    public class Coordinate
    {
        // Internal Variables
        private Point InGameCoord;
        private Point PixelOnSec;

        // IMPORTANT: InGame (0|0) = Pixel (0|0) at Sector (135|91)

        #region ToDo-List
        /*
         * Move out GetSector because we don't need to recalculate it every time
         * 
         * 
         */
        #endregion


        #region Constructor
        /// <summary>
        /// Creates a new Coordinate Object
        /// </summary>
        /// <param name="Coord">Silkroad InGame Coordinate</param>
        public Coordinate(Point Coord)
        {
            InGameCoord = Coord;

            PixelOnSec = calc_PixelOnSector();
        }

        /// <summary>
        /// Creates a new Coordinate Object
        /// </summary>
        /// <param name="x">X-Coordinate</param>
        /// <param name="y">Y-Coordinate</param>
        public Coordinate(int x, int y)
        {
            InGameCoord = new Point(x, y);

            PixelOnSec = calc_PixelOnSector();
        }
        #endregion

        #region InGame
        public Point InGame
        {
            get{
                return InGameCoord;
            }
            set {
                InGameCoord = value;
            }
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
        // Idea: Save the calculated Pixels inside a variable. Might increase speed and reduce CPU Load while using map
        /// <summary>
        /// Calculate the Pixels based on the Coordinates related to the file
        /// </summary>
        public Point PixelOnSector
        {
            get
            {
                return PixelOnSec;
            }

        }
        #endregion

        #region Calculate PixelOnSector
        /// <summary>
        /// This Method calculates the PixelOnSector.
        /// </summary>
        /// <returns></returns>
        /// I moved it out because we don't need to recalculate this everytime. Will save a little time
        private Point calc_PixelOnSector()
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

            if (InGameCoord.Y >= 0)
            {
                pixeldiff_y = 192 - (InGameCoord.Y + ((Sector.Y - 92) * 192));
            }
            else
            {
                pixeldiff_y = (InGameCoord.Y - ((91 - Sector.Y) * 192)) * -1;
            }

            return new Point(ToPixel(pixeldiff_x), ToPixel(pixeldiff_y));
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
