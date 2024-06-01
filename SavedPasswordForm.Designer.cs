namespace CrackMonkeyRemastered
{
    partial class SavedPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedPasswordForm));
            this.savedTextLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.gameVersionLabel2 = new System.Windows.Forms.Label();
            this.crackAgainLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.savedPasswordLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.copyButton = new ReaLTaiizor.Controls.MaterialButton();
            this.continueButton = new ReaLTaiizor.Controls.Button();
            this.exitButton = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // savedTextLabel
            // 
            this.savedTextLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedTextLabel.Location = new System.Drawing.Point(73, 66);
            this.savedTextLabel.Name = "savedTextLabel";
            this.savedTextLabel.Size = new System.Drawing.Size(218, 55);
            this.savedTextLabel.TabIndex = 0;
            this.savedTextLabel.Text = "Here\'s your cracked password! Happy modding!";
            this.savedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(32, 140);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(32, 169);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(81, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Game Version:";
            // 
            // gameVersionLabel2
            // 
            this.gameVersionLabel2.AutoSize = true;
            this.gameVersionLabel2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameVersionLabel2.ForeColor = System.Drawing.Color.Green;
            this.gameVersionLabel2.Location = new System.Drawing.Point(111, 168);
            this.gameVersionLabel2.Name = "gameVersionLabel2";
            this.gameVersionLabel2.Size = new System.Drawing.Size(45, 14);
            this.gameVersionLabel2.TabIndex = 5;
            this.gameVersionLabel2.Text = "X.XX.X";
            // 
            // crackAgainLabel
            // 
            this.crackAgainLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crackAgainLabel.Location = new System.Drawing.Point(18, 193);
            this.crackAgainLabel.Name = "crackAgainLabel";
            this.crackAgainLabel.Size = new System.Drawing.Size(330, 29);
            this.crackAgainLabel.TabIndex = 0;
            this.crackAgainLabel.Text = "Would you like to crack the password again?";
            this.crackAgainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.warningLabel.Location = new System.Drawing.Point(48, 217);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(270, 49);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "WARNING: This will delete your currently saved password!";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CrackMonkeyRemastered.Properties.Resources.icon;
            this.pictureBox1.InitialImage = global::CrackMonkeyRemastered.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // savedPasswordLabel
            // 
            this.savedPasswordLabel.Depth = 0;
            this.savedPasswordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.savedPasswordLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            this.savedPasswordLabel.HighEmphasis = true;
            this.savedPasswordLabel.Location = new System.Drawing.Point(92, 135);
            this.savedPasswordLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.savedPasswordLabel.Name = "savedPasswordLabel";
            this.savedPasswordLabel.Size = new System.Drawing.Size(141, 23);
            this.savedPasswordLabel.TabIndex = 9;
            this.savedPasswordLabel.Text = "materialLabel1";
            this.savedPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyButton
            // 
            this.copyButton.AutoSize = false;
            this.copyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.copyButton.Depth = 0;
            this.copyButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.HighEmphasis = true;
            this.copyButton.Icon = null;
            this.copyButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.copyButton.Location = new System.Drawing.Point(240, 133);
            this.copyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.copyButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.copyButton.Name = "copyButton";
            this.copyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.copyButton.Size = new System.Drawing.Size(50, 26);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy";
            this.copyButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.copyButton.UseAccentColor = false;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Transparent;
            this.continueButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.EnteredBorderColor = System.Drawing.Color.Black;
            this.continueButton.EnteredColor = System.Drawing.Color.LimeGreen;
            this.continueButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Image = null;
            this.continueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.continueButton.InactiveColor = System.Drawing.Color.ForestGreen;
            this.continueButton.Location = new System.Drawing.Point(78, 270);
            this.continueButton.Name = "continueButton";
            this.continueButton.PressedBorderColor = System.Drawing.Color.Black;
            this.continueButton.PressedColor = System.Drawing.Color.LightGreen;
            this.continueButton.Size = new System.Drawing.Size(91, 33);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Yes";
            this.continueButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.EnteredBorderColor = System.Drawing.Color.Black;
            this.exitButton.EnteredColor = System.Drawing.Color.Brown;
            this.exitButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = null;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.InactiveColor = System.Drawing.Color.IndianRed;
            this.exitButton.Location = new System.Drawing.Point(185, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedBorderColor = System.Drawing.Color.Black;
            this.exitButton.PressedColor = System.Drawing.Color.IndianRed;
            this.exitButton.Size = new System.Drawing.Size(91, 33);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SavedPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 316);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.savedPasswordLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crackAgainLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.gameVersionLabel2);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.savedTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavedPasswordForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     Saved Password";
            this.Load += new System.EventHandler(this.SavedPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label savedTextLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label gameVersionLabel2;
        private System.Windows.Forms.Label crackAgainLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialLabel savedPasswordLabel;
        private ReaLTaiizor.Controls.MaterialButton copyButton;
        private ReaLTaiizor.Controls.Button continueButton;
        private ReaLTaiizor.Controls.Button exitButton;
    }
}