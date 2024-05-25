using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrackMonkeyRemastered.Properties;

namespace CrackMonkeyRemastered
{
    
    public partial class SavedPasswordForm : Form
    {
        Settings crackMonkeySettings = new Settings();
        private Form CrackMonkeyForm = new CrackMonkeyForm();

        public SavedPasswordForm()
        {
            InitializeComponent();
        }

        private void SavedPasswordForm_Load(object sender, EventArgs e)
        {
            if (crackMonkeySettings.btdPassword.Length < 4)
            {
                if (CrackMonkeyForm.IsDisposed)
                {
                    this.Hide();
                    CrackMonkeyForm = new CrackMonkeyForm();
                    CrackMonkeyForm.Show();
                }

                else
                {
                    this.Hide();
                    CrackMonkeyForm.Show();
                }
            }
            else
            {
                passwordTextBox.Text = crackMonkeySettings.btdPassword;
                gameVersionLabel2.Text = crackMonkeySettings.btdVersion;
            }
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
            Clipboard.SetText(passwordTextBox.Text);
        }
    }
}
