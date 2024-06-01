using CrackMonkeyRemastered.Properties;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrackMonkeyRemastered
{

    public partial class SavedPasswordForm : MaterialForm
    {
        // Declare necessary public variables
        Settings crackMonkeySettings = new Settings();
        Form CrackMonkeyForm = new CrackMonkeyForm();
        Size formSize = new Size(356, 316);

        public SavedPasswordForm()
        {
            InitializeComponent();
        }

        private void SavedPasswordForm_Load(object sender, EventArgs e)
        {
            this.Size = formSize;

            if (crackMonkeySettings.btdPassword.Length <= 15 || crackMonkeySettings.btdPassword.Length >= 17)
            {
                string mBoxText = "Error extracting password! To avoid any issues,\r\nwhen the game launches, wait until\r\nthe 'Ninja Kiwi' logo appears then click 'Start'\r\n\r\nIf you keep getting this error, please send me an email at:\r\nbtdbugreports@gmail.com\r\n";
                MaterialMessageBox.Show(mBoxText, "Password Extract Error!", MessageBoxButtons.OK, false, MaterialFlexibleForm.ButtonsPosition.Center);

                crackMonkeySettings.Reset();
                crackMonkeySettings.Save();
                Application.Exit();
            }

            else
            {
                savedPasswordLabel.Text = crackMonkeySettings.btdPassword;
                gameVersionLabel2.Text = crackMonkeySettings.btdVersion;
            }

            //else
            //{
            //    string mBoxText = "Error extracting password! To avoid any issues,\r\nwhen the game launches, wait until\r\nthe 'Ninja Kiwi' logo appears then click 'Start'\r\n\r\nIf you keep getting this error, please send me an email at:\r\nbtdbugreports@gmail.com\r\n";
            //    MaterialMessageBox.Show(mBoxText, "Password Extract Error!", MessageBoxButtons.OK, false, MaterialFlexibleForm.ButtonsPosition.Center);

            //    crackMonkeySettings.Reset();
            //    crackMonkeySettings.Save();
            //    Application.Exit();
            //}
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (CrackMonkeyForm.IsDisposed)
            {
                crackMonkeySettings.Reset();
                crackMonkeySettings.Save();
                this.Hide();
                CrackMonkeyForm = new CrackMonkeyForm();
                CrackMonkeyForm.Show();
            }

            else
            {
                crackMonkeySettings.Reset();
                crackMonkeySettings.Save();
                this.Hide();
                CrackMonkeyForm.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(savedPasswordLabel.Text);
        }
    }
}
