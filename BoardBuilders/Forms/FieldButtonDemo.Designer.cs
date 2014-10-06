namespace BoardBuilders
{
    partial class FieldButtonDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.Black;
            this.customButton.Location = new System.Drawing.Point(70, 116);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(75, 23);
            this.customButton.TabIndex = 0;
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            this.customButton.Paint += new System.Windows.Forms.PaintEventHandler(this.customButton_Paint);
            // 
            // FieldButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.customButton);
            this.Name = "FieldButton";
            this.Text = "FieldButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customButton;
    }
}