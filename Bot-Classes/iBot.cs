/*
 * Name:    iBot-Handler Class
 * Author:  florian0
 * Version: 2.3
*/ 

using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BotManager
{
    /// <summary>
    /// Die iBot-Klasse verwaltet den iBot
    /// </summary>
    class iBot : BotClass
    {
        /* Infos zum iBot
         * 
         * Wenn man den iBot startet, kommt als erstes die Meldung:
         * "Dieser Bot ist kostenlos, botten ist illegal und man soll doch bitte donaten, etc."
         * 
         * Die Process-Klasse des .NET-Framework nimmt dieses Fenster als MainWindow was hier
         * nicht brauchbar ist.
         * 
         * Wir verwenden die Funktion EnumWindows um das richtige Fenster zu finden
         */

        private Process proc;                               // Prozess des Bots
        private RunningBots.BotInfo GUI;                    // BotInfo-Struct Instanz zur einfacheren Verwaltung von Informationen
        private EnumWindowsItem eWindowsItem;

        private enum ControlID : int
        {
            charname = 334,
            guildname,
            level,
            skillpoints,
            experience,
            gold,
            PosX,
            PosY
        }

        #region Propertys

        /// <summary>
        /// Gibt den Fenstertitel zurück oder legt diesen fest
        /// </summary>
        public override string WindowTitle
        {
            get { return eWindowsItem.Text; }
            set { eWindowsItem.Text = value; }
        }

        #endregion

        #region Bot Propertys
        /// <summary>
        /// Gibt den Namen des Characters zurück (readonly)
        /// </summary>
        public override string Charname
        {
            get 
            {
                EnumWindows ewn = new EnumWindows();
                ewn.GetWindows(eWindowsItem.Handle);
                
                for(int i = 0; i != ewn.Items.Count - 1;i++)
                {
                    if (ewn.Items[i].Text == "XX_005")
                    {
                        MessageBox.Show("Num " + i.ToString() + " " + ewn.Items[i].ClassName);

                    }
                }
                return ewn.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Gibt den Servernamen zurück (readonly)
        /// </summary>
        public override string Server
        {
            get { return GUI.Server; }
        }

        /// <summary>
        /// Gibt das Level des Characters zurück (readonly)
        /// </summary>
        public override byte Level
        {
            get { return GUI.Level; }
        }
        #endregion


        #region Constructor

        #region Construct by PID
        /// <summary>
        /// Constructor-Methode
        /// </summary>
        /// <param name="PID">Prozess-ID des Bot(-prozesses)</param>
        public iBot(int PID)
        {
            // Process-Objekt erstellen
            proc = Process.GetProcessById(PID);

            // Fenster enumerieren um das iBot Hauptfenster zu finden
            EnumWindows ew = new EnumWindows();
            ew.GetWindows();

            // Die Liste der Fenster durchsuchen
            foreach (EnumWindowsItem item in ew.Items)
            {
                // Und jedes Fenster, das iB0t] im Titel hat bearbeiten
                if (item.Text.Contains("iB0T]"))
                {
                    // Überprüfen ob die WindowThreadId in der ThreadListe des Prozesses vorkommt.
                    foreach (ProcessThread thr in proc.Threads)
                    {
                        if ((int)item.WndThreadId == thr.Id)
                        { // Wenn ja
                            // EnumWindowsItem speichern
                            eWindowsItem = item;
                            break;
                        }
                    }
                }
                if (eWindowsItem != null)
                    break;
            }

        }
        #endregion

        #region Construct by Process
        /// <summary>
        /// Constructor-Methode
        /// </summary>
        /// <param name="iProc">Prozess-Klasse des iBot-Prozesses</param>
        public iBot(Process iProc)
        {
            // Process-Objekt erstellen
            proc = iProc;

            // Fenster enumerieren um das iBot Hauptfenster zu finden
            EnumWindows ew = new EnumWindows();
            ew.GetWindows();

            // Die Liste der Fenster durchsuchen
            foreach (EnumWindowsItem item in ew.Items)
            {
                // Und jedes Fenster, das iB0t] im Titel hat bearbeiten
                if (item.Text.Contains("iB0t]"))
                {
                    // Überprüfen ob die WindowThreadId in der ThreadListe des Prozesses vorkommt.
                    foreach (ProcessThread thr in proc.Threads)
                    {
                        if ((int)item.WndThreadId == thr.Id)
                        { // Wenn ja
                            // EnumWindowsItem speichern
                            eWindowsItem = item;
                            break;
                        }
                    }
                }
                if (eWindowsItem != null)
                    break;
            }

        }
        #endregion

        #endregion
    }
}
