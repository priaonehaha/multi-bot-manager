/*
 * Name:    Running Bots Management Helper
 * Author:  florian0
 * Version: 1.1
*/ 

using System;
using System.Diagnostics;

namespace BotManager
{
    class RunningBots
    {
        
        public enum BotType : int
        {
            iBot = 1,
            phBot = 2,
            SBot = 3,
            iSroBot = 4,
            mBot = 5,
            sroKing = 6
            // Maybe DB-Bot ?
        }

        public struct BotInfo
        {
            public string Charname;
            public string Server;
            public byte Level;
        }

        private BotClass[] Bots = new BotClass[128];
        private byte BotUBound = 0;

        public BotClass this[int index]
        {
            get
            {
                return Bots[index];
            }
        }
        


        public void AddBotProc(int PID, BotType type)
        {
            int FreeField = 0;
            switch (type)
            {
                case BotType.iBot:
                    FreeField = GetFreeField();
                    Bots[FreeField] =  new iBot(PID);
                    

                    break;

            }

        }

        #region Collector
        /// <summary>
        /// Sammelt alle neuen Bots und fügt sie der Liste hinzu
        /// </summary>
        /// <returns>Anzahl der neu gefundenen Bots</returns>
        public byte CollectNew()
        {
            return 0;
        }

        /// <summary>
        /// Erneuert die Informationen über alle in der Liste vorhandenen Bots
        /// </summary>
        /// <returns>Anzahl der aktualisierten Bots</returns>
        public byte Quickrefresh()
        {
            return 0;
        }

        /// <summary>
        /// Löscht die gesamte Liste und sammelt alle Bots neu
        /// </summary>
        /// <returns>Anzahl der gefunden Bots</returns>
        public byte RefreshAll()
        {
            Array.Clear(Bots, 0, Bots.Length);

            Process[] ibot = Process.GetProcessesByName("iBot");
            byte Counter = 0;

            foreach (Process botproc in ibot)
            {
                AddBotProc(botproc.Id, BotType.iBot);
                Counter++;
            }

            return Counter;

        }
        #endregion

        private byte GetFreeField()
        {
            return BotUBound++;
        }
    }
}
    