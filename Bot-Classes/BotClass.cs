using System;
using System.Text;
using AutoItX3Lib;
using System.Diagnostics;

namespace BotManager
{
    /// <summary>
    /// Pseudo-Klasse um alle Bots in einem Array zu verwalten
    /// </summary>
    abstract class BotClass
    {

        #region Propertys
        /// <summary>
        /// Gibt den Fenstertitel zurück oder legt diesen fest
        /// </summary>
        public abstract string WindowTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Gibt den Namen des Characters zurück (readonly)
        /// </summary>
        public abstract string Charname
        {
            get;
        }

        /// <summary>
        /// Gibt den Servernamen zurück (readonly)
        /// </summary>
        public abstract string Server
        {
            get;
        }

        /// <summary>
        /// Gibt das Level des Characters zurück (readonly)
        /// </summary>
        public abstract byte Level
        {
            get;
        }
        #endregion

    }
}
