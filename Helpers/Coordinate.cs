using System;
using System.Text;
using System.Drawing;

namespace BotManager.Helpers
{
    class Coordinate
    {
        private Point InGameCoord;

        #region Constructor
        /// <summary>
        /// Erstellt ein neues Coordinate-Objekt
        /// </summary>
        /// <param name="Coord">Silkroad InGame Koordinate</param>
        public Coordinate(Point Coord)
        {
            InGameCoord = Coord;
        }
        #endregion

        #region Sector
        /// <summary>
        /// Liest den Sektor der Koordinate ab (readonly)
        /// </summary>
        public Point Sector
        {
            get
            {
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

                return new Point(xSec, ySec);
            }
        }
        #endregion

        #region RealCoordinates
        public Point RealCoordinates
        {
            get
            {

            }

        }
        #endregion
    }
}
