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
            this.versionLabel = new System.Windows.Forms.Label();
            this.startButton = new ReaLTaiizor.Controls.Button();
            this.statusLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.futureFlashLabel = new ReaLTaiizor.Controls.LinkLabelEdit();
            this.aboutButton = new ReaLTaiizor.Controls.HopeButton();
            this.windowIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.versionLabel.Location = new System.Drawing.Point(334, 186);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "v1.3";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.EnteredBorderColor = System.Drawing.Color.Lime;
            this.startButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Image = null;
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.startButton.Location = new System.Drawing.Point(116, 128);
            this.startButton.Name = "startButton";
            this.startButton.PressedBorderColor = System.Drawing.Color.Lime;
            this.startButton.PressedColor = System.Drawing.Color.DimGray;
            this.startButton.Size = new System.Drawing.Size(131, 43);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Depth = 0;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            this.statusLabel.Location = new System.Drawing.Point(3, 95);
            this.statusLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(359, 35);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status: Checking...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // futureFlashLabel
            // 
            this.futureFlashLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.futureFlashLabel.BackColor = System.Drawing.Color.Transparent;
            this.futureFlashLabel.Font = new System.Drawing.Font("Roboto", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureFlashLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.futureFlashLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.futureFlashLabel.Location = new System.Drawing.Point(117, 176);
            this.futureFlashLabel.Name = "futureFlashLabel";
            this.futureFlashLabel.Size = new System.Drawing.Size(134, 23);
            this.futureFlashLabel.TabIndex = 9;
            this.futureFlashLabel.TabStop = true;
            this.futureFlashLabel.Text = "Created by FutureFlash";
            this.futureFlashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.futureFlashLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.futureFlashLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.futureFlashLabel_LinkClicked);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.LightCoral;
            this.aboutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.aboutButton.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.aboutButton.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aboutButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.aboutButton.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.aboutButton.Location = new System.Drawing.Point(4, 68);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.PrimaryColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutButton.Size = new System.Drawing.Size(55, 24);
            this.aboutButton.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.aboutButton.TabIndex = 11;
            this.aboutButton.Text = "About";
            this.aboutButton.TextColor = System.Drawing.Color.Black;
            this.aboutButton.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // windowIcon
            // 
            this.windowIcon.Enabled = false;
            this.windowIcon.Image = global::CrackMonkeyRemastered.Properties.Resources.icon;
            this.windowIcon.InitialImage = global::CrackMonkeyRemastered.Properties.Resources.icon;
            this.windowIcon.Location = new System.Drawing.Point(8, 28);
            this.windowIcon.Name = "windowIcon";
            this.windowIcon.Size = new System.Drawing.Size(30, 30);
            this.windowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowIcon.TabIndex = 12;
            this.windowIcon.TabStop = false;
            // 
            // CrackMonkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(365, 201);
            this.Controls.Add(this.windowIcon);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.futureFlashLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.versionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrackMonkeyForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      CrackMonkey Remastered";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrackMonkeyForm_FormClosing);
            this.Load += new System.EventHandler(this.CrackMonkeyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label versionLabel;
        private ReaLTaiizor.Controls.Button startButton;
        private ReaLTaiizor.Controls.MaterialLabel statusLabel;
        private ReaLTaiizor.Controls.LinkLabelEdit futureFlashLabel;
        private ReaLTaiizor.Controls.HopeButton aboutButton;
        private System.Windows.Forms.PictureBox windowIcon;
    }
}

