namespace BotManager
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Attention please", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Online", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Logging In", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Waiting", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Disconnected", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Disabled", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "XX_001",
            "41",
            "30% (+103%)",
            "7653424 (+1235)",
            "5",
            "7",
            "0"}, -1);
            this.mnsp_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payAttentionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_v_open_map = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsv_bots = new System.Windows.Forms.ListView();
            this.clmh_charname = new System.Windows.Forms.ColumnHeader();
            this.clmh_level = new System.Windows.Forms.ColumnHeader();
            this.clmh_exp = new System.Windows.Forms.ColumnHeader();
            this.clmh_sp = new System.Windows.Forms.ColumnHeader();
            this.clmh_gold = new System.Windows.Forms.ColumnHeader();
            this.clmh_died = new System.Windows.Forms.ColumnHeader();
            this.clmh_dced = new System.Windows.Forms.ColumnHeader();
            this.clmh_botname = new System.Windows.Forms.ColumnHeader();
            this.stts_main = new System.Windows.Forms.StatusStrip();
            this.tssl_sp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspb_exp = new System.Windows.Forms.ToolStripProgressBar();
            this.tssl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsp_main.SuspendLayout();
            this.stts_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsp_main
            // 
            this.mnsp_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.mnsp_main.Location = new System.Drawing.Point(0, 0);
            this.mnsp_main.Name = "mnsp_main";
            this.mnsp_main.Size = new System.Drawing.Size(474, 24);
            this.mnsp_main.TabIndex = 0;
            this.mnsp_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importConfigToolStripMenuItem,
            this.exportConfigToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.payAttentionOptionsToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // payAttentionOptionsToolStripMenuItem
            // 
            this.payAttentionOptionsToolStripMenuItem.Name = "payAttentionOptionsToolStripMenuItem";
            this.payAttentionOptionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.payAttentionOptionsToolStripMenuItem.Text = "Rules";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mm_v_open_map});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mm_v_open_map
            // 
            this.mm_v_open_map.Name = "mm_v_open_map";
            this.mm_v_open_map.Size = new System.Drawing.Size(152, 22);
            this.mm_v_open_map.Text = "Open Map";
            this.mm_v_open_map.Click += new System.EventHandler(this.mm_v_open_map_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // lsv_bots
            // 
            this.lsv_bots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmh_charname,
            this.clmh_level,
            this.clmh_exp,
            this.clmh_sp,
            this.clmh_gold,
            this.clmh_died,
            this.clmh_dced,
            this.clmh_botname});
            this.lsv_bots.FullRowSelect = true;
            listViewGroup13.Header = "Attention please";
            listViewGroup13.Name = "lvg_attention";
            listViewGroup14.Header = "Online";
            listViewGroup14.Name = "lvg_online";
            listViewGroup15.Header = "Logging In";
            listViewGroup15.Name = "lvg_lgin";
            listViewGroup16.Header = "Waiting";
            listViewGroup16.Name = "lvg_wait";
            listViewGroup17.Header = "Disconnected";
            listViewGroup17.Name = "lvg_dced";
            listViewGroup18.Header = "Disabled";
            listViewGroup18.Name = "lvg_disabled";
            this.lsv_bots.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16,
            listViewGroup17,
            listViewGroup18});
            this.lsv_bots.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lsv_bots.Location = new System.Drawing.Point(0, 27);
            this.lsv_bots.Name = "lsv_bots";
            this.lsv_bots.Size = new System.Drawing.Size(474, 335);
            this.lsv_bots.TabIndex = 1;
            this.lsv_bots.UseCompatibleStateImageBehavior = false;
            this.lsv_bots.View = System.Windows.Forms.View.Details;
            // 
            // clmh_charname
            // 
            this.clmh_charname.Text = "Charname";
            this.clmh_charname.Width = 91;
            // 
            // clmh_level
            // 
            this.clmh_level.Text = "Level";
            this.clmh_level.Width = 45;
            // 
            // clmh_exp
            // 
            this.clmh_exp.Text = "EXP";
            this.clmh_exp.Width = 61;
            // 
            // clmh_sp
            // 
            this.clmh_sp.Text = "SP";
            this.clmh_sp.Width = 53;
            // 
            // clmh_gold
            // 
            this.clmh_gold.Text = "Gold";
            // 
            // clmh_died
            // 
            this.clmh_died.Text = "Died";
            this.clmh_died.Width = 41;
            // 
            // clmh_dced
            // 
            this.clmh_dced.Text = "DC\'s";
            this.clmh_dced.Width = 44;
            // 
            // clmh_botname
            // 
            this.clmh_botname.Text = "Bot";
            // 
            // stts_main
            // 
            this.stts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_sp,
            this.tspb_exp,
            this.tssl_message});
            this.stts_main.Location = new System.Drawing.Point(0, 365);
            this.stts_main.Name = "stts_main";
            this.stts_main.Size = new System.Drawing.Size(474, 22);
            this.stts_main.TabIndex = 2;
            this.stts_main.Text = "statusStrip1";
            // 
            // tssl_sp
            // 
            this.tssl_sp.Name = "tssl_sp";
            this.tssl_sp.Size = new System.Drawing.Size(88, 17);
            this.tssl_sp.Text = "SP: 3342     EXP:";
            // 
            // tspb_exp
            // 
            this.tspb_exp.Name = "tspb_exp";
            this.tspb_exp.Size = new System.Drawing.Size(100, 16);
            this.tspb_exp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tspb_exp.Value = 50;
            // 
            // tssl_message
            // 
            this.tssl_message.Name = "tssl_message";
            this.tssl_message.Size = new System.Drawing.Size(126, 17);
            this.tssl_message.Text = "No Messages available";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.einstellungenToolStripMenuItem.Text = "Settings";
            // 
            // exportConfigToolStripMenuItem
            // 
            this.exportConfigToolStripMenuItem.Name = "exportConfigToolStripMenuItem";
            this.exportConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportConfigToolStripMenuItem.Text = "Export Config";
            // 
            // importConfigToolStripMenuItem
            // 
            this.importConfigToolStripMenuItem.Name = "importConfigToolStripMenuItem";
            this.importConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importConfigToolStripMenuItem.Text = "Import Config";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 387);
            this.Controls.Add(this.stts_main);
            this.Controls.Add(this.lsv_bots);
            this.Controls.Add(this.mnsp_main);
            this.MainMenuStrip = this.mnsp_main;
            this.Name = "frmMain";
            this.Text = "Multi-Bot-Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsp_main.ResumeLayout(false);
            this.mnsp_main.PerformLayout();
            this.stts_main.ResumeLayout(false);
            this.stts_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsp_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mm_v_open_map;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView lsv_bots;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmh_charname;
        private System.Windows.Forms.ColumnHeader clmh_level;
        private System.Windows.Forms.ColumnHeader clmh_exp;
        private System.Windows.Forms.ColumnHeader clmh_sp;
        private System.Windows.Forms.ColumnHeader clmh_died;
        private System.Windows.Forms.ColumnHeader clmh_dced;
        private System.Windows.Forms.ToolStripMenuItem payAttentionOptionsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmh_gold;
        private System.Windows.Forms.ColumnHeader clmh_botname;
        private System.Windows.Forms.StatusStrip stts_main;
        private System.Windows.Forms.ToolStripStatusLabel tssl_sp;
        private System.Windows.Forms.ToolStripProgressBar tspb_exp;
        private System.Windows.Forms.ToolStripStatusLabel tssl_message;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

