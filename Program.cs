using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrackMonkeyRemastered.Properties;

namespace CrackMonkeyRemastered
{
    
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Settings crackMonkeySettings = new Settings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (crackMonkeySettings.btdPassword != null && crackMonkeySettings.btdPassword.Length > 4)
            {
                Application.Run(new SavedPasswordForm());
            }
            
            else
            {
                Application.Run(new CrackMonkeyForm());
            }
        }
    }
}
