namespace CrackMonkeyRemastered
{
    partial class CrackMonkeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrackMonkeyForm));
            this.statusLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLabel = new System.Windows.Forms.Label();
            this.futureFlashLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusLabel.Location = new System.Drawing.Point(2, 34);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(329, 37);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status: Checking...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(100, 74);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(131, 43);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(331, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.versionLabel.Location = new System.Drawing.Point(300, 141);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "v1.0";
            // 
            // futureFlashLabel
            // 
            this.futureFlashLabel.ActiveLinkColor = System.Drawing.Color.MediumPurple;
            this.futureFlashLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureFlashLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.futureFlashLabel.Location = new System.Drawing.Point(0, 131);
            this.futureFlashLabel.Name = "futureFlashLabel";
            this.futureFlashLabel.Size = new System.Drawing.Size(331, 23);
            this.futureFlashLabel.TabIndex = 4;
            this.futureFlashLabel.TabStop = true;
            this.futureFlashLabel.Text = "Created by FutureFlash";
            this.futureFlashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.futureFlashLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.futureFlashLabel_LinkClicked);
            // 
            // CrackMonkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 159);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.futureFlashLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "CrackMonkeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crack Monkey Remastered";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrackMonkeyForm_FormClosing);
            this.Load += new System.EventHandler(this.CrackMonkeyForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel futureFlashLabel;
    }
}

