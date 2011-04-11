using System;
using System.Text;
using System.Diagnostics;

namespace BotManager
{
    /// <summary>
    /// Pseudo-Class to manage all Bots in one Array
    /// </summary>
    abstract class BotClass
    {

        #region Propertys
        /// <summary>
        /// Returns the WindowTitle or changes it
        /// </summary>
        public abstract string WindowTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the Name of the Character (readonly)
        /// </summary>
        public abstract string Charname
        {
            get;
        }

        /// <summary>
        /// Returns the Name of the Server the Bot is connected to (readonly)
        /// </summary>
        public abstract string Server
        {
            get;
        }

        /// <summary>
        /// Returns the Level of the selected Character (readonly)
        /// </summary>
        public abstract byte Level
        {
            get;
        }
        #endregion

    }
}
