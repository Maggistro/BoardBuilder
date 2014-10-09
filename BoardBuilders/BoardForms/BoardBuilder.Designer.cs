namespace BoardBuilders.BoardForms
{
    partial class BoardBuilder
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
            this.GameMenu = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generiereWeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnLabel = new System.Windows.Forms.Label();
            this.baumenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holzfällerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steinmetzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obstplantageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jägerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fischerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kohlemineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eisenmineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verarbeitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eisenschmelzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwertschmiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rüstungsschmiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bogenmacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spezialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warenlageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.straßeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaserneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausbauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dorfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.großstadtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einheitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siedlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bogenschützeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwertkämpferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handkartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zugBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.baumenuToolStripMenuItem,
            this.einheitenToolStripMenuItem,
            this.spielerToolStripMenuItem});
            this.GameMenu.Location = new System.Drawing.Point(0, 0);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(500, 24);
            this.GameMenu.TabIndex = 1;
            this.GameMenu.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generiereWeltToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // generiereWeltToolStripMenuItem
            // 
            this.generiereWeltToolStripMenuItem.Name = "generiereWeltToolStripMenuItem";
            this.generiereWeltToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.generiereWeltToolStripMenuItem.Text = "Generiere Welt";
            this.generiereWeltToolStripMenuItem.Click += new System.EventHandler(this.generiereWeltToolStripMenuItem_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(425, 5);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(63, 13);
            this.turnLabel.TabIndex = 3;
            this.turnLabel.Text = "Zuganzeige";
            // 
            // baumenuToolStripMenuItem
            // 
            this.baumenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produktionToolStripMenuItem,
            this.verarbeitungToolStripMenuItem,
            this.spezialToolStripMenuItem,
            this.ausbauToolStripMenuItem});
            this.baumenuToolStripMenuItem.Name = "baumenuToolStripMenuItem";
            this.baumenuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.baumenuToolStripMenuItem.Text = "Baumenu";
            // 
            // produktionToolStripMenuItem
            // 
            this.produktionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holzfällerToolStripMenuItem,
            this.steinmetzToolStripMenuItem,
            this.obstplantageToolStripMenuItem,
            this.jägerToolStripMenuItem,
            this.fischerToolStripMenuItem,
            this.kohlemineToolStripMenuItem,
            this.eisenmineToolStripMenuItem});
            this.produktionToolStripMenuItem.Name = "produktionToolStripMenuItem";
            this.produktionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produktionToolStripMenuItem.Text = "Produktion";
            // 
            // holzfällerToolStripMenuItem
            // 
            this.holzfällerToolStripMenuItem.Name = "holzfällerToolStripMenuItem";
            this.holzfällerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.holzfällerToolStripMenuItem.Text = "Holzfäller";
            this.holzfällerToolStripMenuItem.Click += new System.EventHandler(this.holzfällerToolStripMenuItem_Click);
            // 
            // steinmetzToolStripMenuItem
            // 
            this.steinmetzToolStripMenuItem.Name = "steinmetzToolStripMenuItem";
            this.steinmetzToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.steinmetzToolStripMenuItem.Text = "Steinmetz";
            // 
            // obstplantageToolStripMenuItem
            // 
            this.obstplantageToolStripMenuItem.Name = "obstplantageToolStripMenuItem";
            this.obstplantageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obstplantageToolStripMenuItem.Text = "Obstplantage";
            // 
            // jägerToolStripMenuItem
            // 
            this.jägerToolStripMenuItem.Name = "jägerToolStripMenuItem";
            this.jägerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jägerToolStripMenuItem.Text = "Jäger";
            // 
            // fischerToolStripMenuItem
            // 
            this.fischerToolStripMenuItem.Name = "fischerToolStripMenuItem";
            this.fischerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fischerToolStripMenuItem.Text = "Fischer";
            // 
            // kohlemineToolStripMenuItem
            // 
            this.kohlemineToolStripMenuItem.Name = "kohlemineToolStripMenuItem";
            this.kohlemineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kohlemineToolStripMenuItem.Text = "Kohlemine";
            // 
            // eisenmineToolStripMenuItem
            // 
            this.eisenmineToolStripMenuItem.Name = "eisenmineToolStripMenuItem";
            this.eisenmineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eisenmineToolStripMenuItem.Text = "Eisenmine";
            // 
            // verarbeitungToolStripMenuItem
            // 
            this.verarbeitungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eisenschmelzeToolStripMenuItem,
            this.schwertschmiedToolStripMenuItem,
            this.rüstungsschmiedToolStripMenuItem,
            this.bogenmacheToolStripMenuItem});
            this.verarbeitungToolStripMenuItem.Name = "verarbeitungToolStripMenuItem";
            this.verarbeitungToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verarbeitungToolStripMenuItem.Text = "Verarbeitung";
            // 
            // eisenschmelzeToolStripMenuItem
            // 
            this.eisenschmelzeToolStripMenuItem.Name = "eisenschmelzeToolStripMenuItem";
            this.eisenschmelzeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eisenschmelzeToolStripMenuItem.Text = "Eisenschmelze";
            // 
            // schwertschmiedToolStripMenuItem
            // 
            this.schwertschmiedToolStripMenuItem.Name = "schwertschmiedToolStripMenuItem";
            this.schwertschmiedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.schwertschmiedToolStripMenuItem.Text = "Schwertschmied";
            // 
            // rüstungsschmiedToolStripMenuItem
            // 
            this.rüstungsschmiedToolStripMenuItem.Name = "rüstungsschmiedToolStripMenuItem";
            this.rüstungsschmiedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.rüstungsschmiedToolStripMenuItem.Text = "Rüstungsschmied";
            // 
            // bogenmacheToolStripMenuItem
            // 
            this.bogenmacheToolStripMenuItem.Name = "bogenmacheToolStripMenuItem";
            this.bogenmacheToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.bogenmacheToolStripMenuItem.Text = "Bogenmache";
            // 
            // spezialToolStripMenuItem
            // 
            this.spezialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warenlageToolStripMenuItem,
            this.straßeToolStripMenuItem,
            this.kaserneToolStripMenuItem});
            this.spezialToolStripMenuItem.Name = "spezialToolStripMenuItem";
            this.spezialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.spezialToolStripMenuItem.Text = "Spezial";
            // 
            // warenlageToolStripMenuItem
            // 
            this.warenlageToolStripMenuItem.Name = "warenlageToolStripMenuItem";
            this.warenlageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.warenlageToolStripMenuItem.Text = "Warenlage";
            // 
            // straßeToolStripMenuItem
            // 
            this.straßeToolStripMenuItem.Name = "straßeToolStripMenuItem";
            this.straßeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.straßeToolStripMenuItem.Text = "Straße";
            // 
            // kaserneToolStripMenuItem
            // 
            this.kaserneToolStripMenuItem.Name = "kaserneToolStripMenuItem";
            this.kaserneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaserneToolStripMenuItem.Text = "Kaserne";
            // 
            // ausbauToolStripMenuItem
            // 
            this.ausbauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dorfToolStripMenuItem,
            this.stadtToolStripMenuItem,
            this.großstadtToolStripMenuItem});
            this.ausbauToolStripMenuItem.Name = "ausbauToolStripMenuItem";
            this.ausbauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ausbauToolStripMenuItem.Text = "Ausbau";
            // 
            // dorfToolStripMenuItem
            // 
            this.dorfToolStripMenuItem.Name = "dorfToolStripMenuItem";
            this.dorfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dorfToolStripMenuItem.Text = "Dorf";
            // 
            // stadtToolStripMenuItem
            // 
            this.stadtToolStripMenuItem.Name = "stadtToolStripMenuItem";
            this.stadtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stadtToolStripMenuItem.Text = "Stadt";
            // 
            // großstadtToolStripMenuItem
            // 
            this.großstadtToolStripMenuItem.Name = "großstadtToolStripMenuItem";
            this.großstadtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.großstadtToolStripMenuItem.Text = "Großstadt";
            // 
            // einheitenToolStripMenuItem
            // 
            this.einheitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siedlerToolStripMenuItem,
            this.scoutToolStripMenuItem,
            this.bogenschützeToolStripMenuItem,
            this.schwertkämpferToolStripMenuItem});
            this.einheitenToolStripMenuItem.Name = "einheitenToolStripMenuItem";
            this.einheitenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.einheitenToolStripMenuItem.Text = "Einheiten";
            // 
            // siedlerToolStripMenuItem
            // 
            this.siedlerToolStripMenuItem.Name = "siedlerToolStripMenuItem";
            this.siedlerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.siedlerToolStripMenuItem.Text = "Siedler";
            // 
            // scoutToolStripMenuItem
            // 
            this.scoutToolStripMenuItem.Name = "scoutToolStripMenuItem";
            this.scoutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.scoutToolStripMenuItem.Text = "Scout";
            // 
            // bogenschützeToolStripMenuItem
            // 
            this.bogenschützeToolStripMenuItem.Name = "bogenschützeToolStripMenuItem";
            this.bogenschützeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.bogenschützeToolStripMenuItem.Text = "Bogenschütze";
            // 
            // schwertkämpferToolStripMenuItem
            // 
            this.schwertkämpferToolStripMenuItem.Name = "schwertkämpferToolStripMenuItem";
            this.schwertkämpferToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.schwertkämpferToolStripMenuItem.Text = "Schwertkämpfer";
            // 
            // spielerToolStripMenuItem
            // 
            this.spielerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handelToolStripMenuItem,
            this.handkartenToolStripMenuItem,
            this.zugBeendenToolStripMenuItem});
            this.spielerToolStripMenuItem.Name = "spielerToolStripMenuItem";
            this.spielerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.spielerToolStripMenuItem.Text = "Spieler";
            // 
            // handkartenToolStripMenuItem
            // 
            this.handkartenToolStripMenuItem.Name = "handkartenToolStripMenuItem";
            this.handkartenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.handkartenToolStripMenuItem.Text = "Handkarten";
            // 
            // zugBeendenToolStripMenuItem
            // 
            this.zugBeendenToolStripMenuItem.Name = "zugBeendenToolStripMenuItem";
            this.zugBeendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zugBeendenToolStripMenuItem.Text = "Zug beenden";
            // 
            // handelToolStripMenuItem
            // 
            this.handelToolStripMenuItem.Name = "handelToolStripMenuItem";
            this.handelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.handelToolStripMenuItem.Text = "Handel";
            // 
            // BoardBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 339);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.GameMenu);
            this.MainMenuStrip = this.GameMenu;
            this.Name = "BoardBuilder";
            this.Text = "Board Builder";
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FieldButton_Paint(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip GameMenu;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generiereWeltToolStripMenuItem;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.ToolStripMenuItem baumenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holzfällerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steinmetzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obstplantageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jägerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fischerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kohlemineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eisenmineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verarbeitungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eisenschmelzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwertschmiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rüstungsschmiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bogenmacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spezialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warenlageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem straßeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaserneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausbauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dorfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem großstadtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einheitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siedlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bogenschützeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwertkämpferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handkartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zugBeendenToolStripMenuItem;

    }
}

