namespace BoardBuilders
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem});
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
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Yellow;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.playerLabel.Location = new System.Drawing.Point(436, 7);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(52, 17);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Spieler";
            // 
            // BoardBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 339);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.GameMenu);
            this.MainMenuStrip = this.GameMenu;
            this.Name = "BoardBuilder";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label playerLabel;

    }
}

