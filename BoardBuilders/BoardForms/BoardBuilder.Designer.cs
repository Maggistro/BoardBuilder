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
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildmenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woodcutterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stonemasonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fruitfarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fischerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coalmineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ironmineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refiningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ironsmelterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swordsmithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armorsmithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bowyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bowmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swordsmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnLabel = new System.Windows.Forms.Label();
            this.activePlayerLabel = new System.Windows.Forms.Label();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.buildmenuToolStripMenuItem,
            this.unitsToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.GameMenu.Location = new System.Drawing.Point(0, 0);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(508, 24);
            this.GameMenu.TabIndex = 1;
            this.GameMenu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateWorldToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.gameToolStripMenuItem.Text = "Spiel";
            // 
            // generateWorldToolStripMenuItem
            // 
            this.generateWorldToolStripMenuItem.Name = "generateWorldToolStripMenuItem";
            this.generateWorldToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.generateWorldToolStripMenuItem.Text = "Generiere Welt";
            this.generateWorldToolStripMenuItem.Click += new System.EventHandler(this.generiereWeltToolStripMenuItem_Click);
            // 
            // buildmenuToolStripMenuItem
            // 
            this.buildmenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productionToolStripMenuItem,
            this.refiningToolStripMenuItem,
            this.specialToolStripMenuItem,
            this.upgradeToolStripMenuItem});
            this.buildmenuToolStripMenuItem.Name = "buildmenuToolStripMenuItem";
            this.buildmenuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.buildmenuToolStripMenuItem.Text = "Baumenu";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.woodcutterToolStripMenuItem,
            this.stonemasonToolStripMenuItem,
            this.fruitfarmToolStripMenuItem,
            this.hunterToolStripMenuItem,
            this.fischerToolStripMenuItem,
            this.coalmineToolStripMenuItem,
            this.ironmineToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productionToolStripMenuItem.Text = "Produktion";
            // 
            // woodcutterToolStripMenuItem
            // 
            this.woodcutterToolStripMenuItem.Name = "woodcutterToolStripMenuItem";
            this.woodcutterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.woodcutterToolStripMenuItem.Text = "Holzfäller";
            this.woodcutterToolStripMenuItem.Click += new System.EventHandler(this.woodcutterToolStripMenuItem_Click);
            // 
            // stonemasonToolStripMenuItem
            // 
            this.stonemasonToolStripMenuItem.Name = "stonemasonToolStripMenuItem";
            this.stonemasonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stonemasonToolStripMenuItem.Text = "Steinmetz";
            this.stonemasonToolStripMenuItem.Click += new System.EventHandler(this.stonemasonToolStripMenuItem_Click);
            // 
            // fruitfarmToolStripMenuItem
            // 
            this.fruitfarmToolStripMenuItem.Name = "fruitfarmToolStripMenuItem";
            this.fruitfarmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fruitfarmToolStripMenuItem.Text = "Obstplantage";
            this.fruitfarmToolStripMenuItem.Click += new System.EventHandler(this.fruitfarmToolStripMenuItem_Click);
            // 
            // hunterToolStripMenuItem
            // 
            this.hunterToolStripMenuItem.Name = "hunterToolStripMenuItem";
            this.hunterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hunterToolStripMenuItem.Text = "Jäger";
            this.hunterToolStripMenuItem.Click += new System.EventHandler(this.hunterToolStripMenuItem_Click);
            // 
            // fischerToolStripMenuItem
            // 
            this.fischerToolStripMenuItem.Name = "fischerToolStripMenuItem";
            this.fischerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fischerToolStripMenuItem.Text = "Fischer";
            this.fischerToolStripMenuItem.Click += new System.EventHandler(this.fischerToolStripMenuItem_Click);
            // 
            // coalmineToolStripMenuItem
            // 
            this.coalmineToolStripMenuItem.Name = "coalmineToolStripMenuItem";
            this.coalmineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coalmineToolStripMenuItem.Text = "Kohlemine";
            this.coalmineToolStripMenuItem.Click += new System.EventHandler(this.coalmineToolStripMenuItem_Click);
            // 
            // ironmineToolStripMenuItem
            // 
            this.ironmineToolStripMenuItem.Name = "ironmineToolStripMenuItem";
            this.ironmineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ironmineToolStripMenuItem.Text = "Eisenmine";
            this.ironmineToolStripMenuItem.Click += new System.EventHandler(this.ironmineToolStripMenuItem_Click);
            // 
            // refiningToolStripMenuItem
            // 
            this.refiningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ironsmelterToolStripMenuItem,
            this.swordsmithToolStripMenuItem,
            this.armorsmithToolStripMenuItem,
            this.bowyerToolStripMenuItem});
            this.refiningToolStripMenuItem.Name = "refiningToolStripMenuItem";
            this.refiningToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refiningToolStripMenuItem.Text = "Verarbeitung";
            // 
            // ironsmelterToolStripMenuItem
            // 
            this.ironsmelterToolStripMenuItem.Name = "ironsmelterToolStripMenuItem";
            this.ironsmelterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ironsmelterToolStripMenuItem.Text = "Eisenschmelze";
            // 
            // swordsmithToolStripMenuItem
            // 
            this.swordsmithToolStripMenuItem.Name = "swordsmithToolStripMenuItem";
            this.swordsmithToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.swordsmithToolStripMenuItem.Text = "Schwertschmied";
            // 
            // armorsmithToolStripMenuItem
            // 
            this.armorsmithToolStripMenuItem.Name = "armorsmithToolStripMenuItem";
            this.armorsmithToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.armorsmithToolStripMenuItem.Text = "Rüstungsschmied";
            // 
            // bowyerToolStripMenuItem
            // 
            this.bowyerToolStripMenuItem.Name = "bowyerToolStripMenuItem";
            this.bowyerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.bowyerToolStripMenuItem.Text = "Bogenmache";
            // 
            // specialToolStripMenuItem
            // 
            this.specialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storageToolStripMenuItem,
            this.streetToolStripMenuItem,
            this.baracksToolStripMenuItem});
            this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
            this.specialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.specialToolStripMenuItem.Text = "Spezial";
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.storageToolStripMenuItem.Text = "Warenlage";
            // 
            // streetToolStripMenuItem
            // 
            this.streetToolStripMenuItem.Name = "streetToolStripMenuItem";
            this.streetToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.streetToolStripMenuItem.Text = "Straße";
            // 
            // baracksToolStripMenuItem
            // 
            this.baracksToolStripMenuItem.Name = "baracksToolStripMenuItem";
            this.baracksToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.baracksToolStripMenuItem.Text = "Kaserne";
            // 
            // upgradeToolStripMenuItem
            // 
            this.upgradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.villageToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.megacityToolStripMenuItem});
            this.upgradeToolStripMenuItem.Name = "upgradeToolStripMenuItem";
            this.upgradeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.upgradeToolStripMenuItem.Text = "Ausbau";
            // 
            // villageToolStripMenuItem
            // 
            this.villageToolStripMenuItem.Name = "villageToolStripMenuItem";
            this.villageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.villageToolStripMenuItem.Text = "Dorf";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cityToolStripMenuItem.Text = "Stadt";
            // 
            // megacityToolStripMenuItem
            // 
            this.megacityToolStripMenuItem.Name = "megacityToolStripMenuItem";
            this.megacityToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.megacityToolStripMenuItem.Text = "Großstadt";
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settlerToolStripMenuItem,
            this.scoutToolStripMenuItem,
            this.bowmanToolStripMenuItem,
            this.swordsmanToolStripMenuItem});
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.unitsToolStripMenuItem.Text = "Einheiten";
            // 
            // settlerToolStripMenuItem
            // 
            this.settlerToolStripMenuItem.Name = "settlerToolStripMenuItem";
            this.settlerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.settlerToolStripMenuItem.Text = "Siedler";
            this.settlerToolStripMenuItem.Click += new System.EventHandler(this.settlerToolStripMenuItem_Click);
            // 
            // scoutToolStripMenuItem
            // 
            this.scoutToolStripMenuItem.Name = "scoutToolStripMenuItem";
            this.scoutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.scoutToolStripMenuItem.Text = "Scout";
            this.scoutToolStripMenuItem.Click += new System.EventHandler(this.scoutToolStripMenuItem_Click);
            // 
            // bowmanToolStripMenuItem
            // 
            this.bowmanToolStripMenuItem.Name = "bowmanToolStripMenuItem";
            this.bowmanToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.bowmanToolStripMenuItem.Text = "Bogenschütze";
            this.bowmanToolStripMenuItem.Click += new System.EventHandler(this.bowmanToolStripMenuItem_Click);
            // 
            // swordsmanToolStripMenuItem
            // 
            this.swordsmanToolStripMenuItem.Name = "swordsmanToolStripMenuItem";
            this.swordsmanToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.swordsmanToolStripMenuItem.Text = "Schwertkämpfer";
            this.swordsmanToolStripMenuItem.Click += new System.EventHandler(this.swordsmanToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradeToolStripMenuItem,
            this.endturnToolStripMenuItem,
            this.handToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.playerToolStripMenuItem.Text = "Spieler";
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tradeToolStripMenuItem.Text = "Handel";
            this.tradeToolStripMenuItem.Click += new System.EventHandler(this.tradeToolStripMenuItem_Click);
            // 
            // endturnToolStripMenuItem
            // 
            this.endturnToolStripMenuItem.Name = "endturnToolStripMenuItem";
            this.endturnToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.endturnToolStripMenuItem.Text = "Zug beenden";
            this.endturnToolStripMenuItem.Click += new System.EventHandler(this.endturnToolStripMenuItem_Click);
            // 
            // handToolStripMenuItem
            // 
            this.handToolStripMenuItem.Name = "handToolStripMenuItem";
            this.handToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.handToolStripMenuItem.Text = "Handkarten";
            this.handToolStripMenuItem.Click += new System.EventHandler(this.handToolStripMenuItem_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(433, 5);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(63, 13);
            this.turnLabel.TabIndex = 3;
            this.turnLabel.Text = "Zuganzeige";
            // 
            // activePlayerLabel
            // 
            this.activePlayerLabel.AutoSize = true;
            this.activePlayerLabel.Location = new System.Drawing.Point(380, 5);
            this.activePlayerLabel.Name = "activePlayerLabel";
            this.activePlayerLabel.Size = new System.Drawing.Size(39, 13);
            this.activePlayerLabel.TabIndex = 4;
            this.activePlayerLabel.Text = "Spieler";
            // 
            // BoardBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 339);
            this.Controls.Add(this.activePlayerLabel);
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
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateWorldToolStripMenuItem;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.ToolStripMenuItem buildmenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem woodcutterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stonemasonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fruitfarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hunterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fischerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coalmineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ironmineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refiningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ironsmelterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swordsmithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armorsmithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bowyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bowmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swordsmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endturnToolStripMenuItem;
        private System.Windows.Forms.Label activePlayerLabel;
        private System.Windows.Forms.ToolStripMenuItem handToolStripMenuItem;

    }
}

