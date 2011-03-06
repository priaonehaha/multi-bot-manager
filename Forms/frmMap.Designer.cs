namespace BotManager
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.pb_map = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsd_gotochar = new System.Windows.Forms.ToolStripDropDownButton();
            this.testchar1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testchar2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_map)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_map
            // 
            this.pb_map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pb_map.Location = new System.Drawing.Point(12, 28);
            this.pb_map.Name = "pb_map";
            this.pb_map.Size = new System.Drawing.Size(512, 512);
            this.pb_map.TabIndex = 0;
            this.pb_map.TabStop = false;
            this.pb_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_map_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.tsd_gotochar,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsd_gotochar
            // 
            this.tsd_gotochar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsd_gotochar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testchar1ToolStripMenuItem,
            this.testchar2ToolStripMenuItem});
            this.tsd_gotochar.Image = ((System.Drawing.Image)(resources.GetObject("tsd_gotochar.Image")));
            this.tsd_gotochar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsd_gotochar.Name = "tsd_gotochar";
            this.tsd_gotochar.Size = new System.Drawing.Size(105, 22);
            this.tsd_gotochar.Text = "Select Character";
            // 
            // testchar1ToolStripMenuItem
            // 
            this.testchar1ToolStripMenuItem.Name = "testchar1ToolStripMenuItem";
            this.testchar1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.testchar1ToolStripMenuItem.Text = "Testchar 1";
            // 
            // testchar2ToolStripMenuItem
            // 
            this.testchar2ToolStripMenuItem.Name = "testchar2ToolStripMenuItem";
            this.testchar2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.testchar2ToolStripMenuItem.Text = "Testchar 2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton3.Text = "Follow Character";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 550);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pb_map);
            this.Name = "frmMap";
            this.Text = "4Union - Map";
            ((System.ComponentModel.ISupportInitialize)(this.pb_map)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_map;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton tsd_gotochar;
        private System.Windows.Forms.ToolStripMenuItem testchar1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testchar2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}