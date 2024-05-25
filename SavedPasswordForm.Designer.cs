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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.gameVersionLabel2 = new System.Windows.Forms.Label();
            this.crackAgainLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savedTextLabel
            // 
            this.savedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedTextLabel.Location = new System.Drawing.Point(56, 10);
            this.savedTextLabel.Name = "savedTextLabel";
            this.savedTextLabel.Size = new System.Drawing.Size(218, 55);
            this.savedTextLabel.TabIndex = 0;
            this.savedTextLabel.Text = "Here\'s your cracked password! Happy modding!";
            this.savedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(15, 84);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(15, 113);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(76, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Game Version:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(78, 82);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(151, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(236, 82);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(83, 23);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // gameVersionLabel2
            // 
            this.gameVersionLabel2.AutoSize = true;
            this.gameVersionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameVersionLabel2.ForeColor = System.Drawing.Color.Green;
            this.gameVersionLabel2.Location = new System.Drawing.Point(89, 114);
            this.gameVersionLabel2.Name = "gameVersionLabel2";
            this.gameVersionLabel2.Size = new System.Drawing.Size(47, 13);
            this.gameVersionLabel2.TabIndex = 5;
            this.gameVersionLabel2.Text = "X.XX.X";
            // 
            // crackAgainLabel
            // 
            this.crackAgainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crackAgainLabel.Location = new System.Drawing.Point(1, 150);
            this.crackAgainLabel.Name = "crackAgainLabel";
            this.crackAgainLabel.Size = new System.Drawing.Size(330, 29);
            this.crackAgainLabel.TabIndex = 0;
            this.crackAgainLabel.Text = "Would you like to crack the password again?";
            this.crackAgainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(61, 227);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(91, 32);
            this.continueButton.TabIndex = 6;
            this.continueButton.Text = "Yes";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(168, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.warningLabel.Location = new System.Drawing.Point(31, 173);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(270, 49);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "WARNING: This will delete your currently saved password!";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavedPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 273);
            this.Controls.Add(this.crackAgainLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.gameVersionLabel2);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.savedTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SavedPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saved Password";
            this.Load += new System.EventHandler(this.SavedPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label savedTextLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label gameVersionLabel2;
        private System.Windows.Forms.Label crackAgainLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label warningLabel;
    }
}