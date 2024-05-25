﻿using CrackMonkeyRemastered.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
namespace CrackMonkeyRemastered
{
    public partial class CrackMonkeyForm : Form
    {
        // READ BEFORE COMPILING:
        // For some reason, opening this project in Visual Studio and clicking the 'Start' button breaks the program!
        // It makes it not able to extract the password for whatever reason. I suspect it's the threading/debugging attachment, which might slow the
        // program down enough to where it doesn't have time to correctly read the output from previous commands.
        
        // To Fix the Issue:
        // Depending on how you set up your Visual Studio keyboard shortcuts, the default one is "CTRL+SHIFT+B". This just compiles 
        // the executable, but doesn't run it. You need to open your project folder and run the executable in the 'bin/Debug' or 'bin/Release' folder.
        // It's annoying having to do that everytime, but that's the only solution that I can think of at the moment.


        
        // Declare necessary public variables
        public string btdVersion;
        public string btdPath;
        public string btdPassword;
        public int btdPID;
        string currentPath = Environment.CurrentDirectory;

        Settings crackMonkeySettings = new Settings();

        public CrackMonkeyForm()
        {
            InitializeComponent();

            // 'System.Timers.Timer' is the timer I need here. There's 2 other timers which don't work how I want it to. These timers are:
            // 'System.Windows.Forms.Timer' and 'System.Threading.Timer'
            System.Timers.Timer gameStatusTimer = new System.Timers.Timer();
            gameStatusTimer.Elapsed += new ElapsedEventHandler(CheckGameStatus);
            gameStatusTimer.Interval = 1000;
            gameStatusTimer.Start();
        }
        private void GetPID()
        {
            Process btdProcess = new Process();
            btdProcess.StartInfo.FileName = currentPath + @"\src\strings2.exe";
            btdProcess.StartInfo.Arguments = "-pid " + btdPID.ToString();
            btdProcess.StartInfo.UseShellExecute = false;
            btdProcess.StartInfo.RedirectStandardOutput = true;
            btdProcess.StartInfo.CreateNoWindow = true;
            btdProcess.Start();

            string cmdOutput = btdProcess.StandardOutput.ReadToEnd();
            using (StreamWriter outputFile = new StreamWriter(currentPath + @"\src\strings.txt"))
            {
                outputFile.Write(cmdOutput);
            }

            btdProcess.WaitForExit();
        }
        private void HashPassword()
        {
            Process zip2JohnProcess = new Process();
            zip2JohnProcess.StartInfo.FileName = currentPath + @"\src\zip2john.exe";
            
            // You have NO IDEA how long this took me to figure out. Double quotes HAVE to be added to the arguments. Escaping the quotes was a nightmare...
            zip2JohnProcess.StartInfo.Arguments = @"""" + currentPath + @"\src\datajetCOPY.jet""";
            zip2JohnProcess.StartInfo.UseShellExecute = false;
            zip2JohnProcess.StartInfo.RedirectStandardOutput = true;
            zip2JohnProcess.StartInfo.CreateNoWindow = true;
            zip2JohnProcess.Start();

            string cmdOutput = zip2JohnProcess.StandardOutput.ReadToEnd();
            using (StreamWriter outputFile = new StreamWriter(currentPath + @"\src\data.hash"))
            {
                outputFile.Write(cmdOutput);
            }
            zip2JohnProcess.WaitForExit();
        }
        private void CrackPasswordHash()
        {
            Process crackPasswordProcess = new Process();
            crackPasswordProcess.StartInfo.FileName = currentPath + @"\src\john.exe";
            
            // You have NO IDEA how long this took me to figure out. Double quotes HAVE to be added to the arguments. Escaping the quotes was a nightmare...
            crackPasswordProcess.StartInfo.Arguments = @"--wordlist=" + @"""" + currentPath + @"\src\strings.txt""" + " " + @"""" + currentPath + @"\src\data.hash""";
            crackPasswordProcess.StartInfo.UseShellExecute = false;
            crackPasswordProcess.StartInfo.RedirectStandardOutput = true;
            crackPasswordProcess.StartInfo.CreateNoWindow = true;
            crackPasswordProcess.Start();
            crackPasswordProcess.WaitForExit();
        }
        private void ReadPassword()
        {
            string fullHashPath = Environment.CurrentDirectory + @"\src\john.pot";
            using (StreamReader inputFile = new StreamReader(fullHashPath))
            {
                string fullHashPath2 = inputFile.ReadToEnd();
                
                // Essentially, the final hash outputs to a file called 'john.pot'. However, it's full of junk, and we only want to extract the second line of the file.
                // This line contains the full hash
                string trimHash = File.ReadLines(fullHashPath).Skip(1).Take(1).First();
                
                // Before we set the 'btdPassword' string, the extracted hash from above is still too long. We only need the last 16 characters of it. This part is the actual cracked password
                btdPassword = trimHash.Substring(trimHash.Length - 16);
            }
        }
        private void CleanUp()
        {
            string currentPath = Environment.CurrentDirectory;
            string[] AppFiles =
            {
                "datajetCOPY.jet",
                "data.hash",
                "strings.txt",
                "john.pot"
            };

            foreach (var file in AppFiles)
            {
                if (File.Exists(currentPath + @"\src\" + file.ToString()))
                {
                    File.Delete(currentPath + @"\src\" + file.ToString());
                }
            }
        }
        private void CrackMonkeyForm_Load(object sender, EventArgs e)
        {
            startButton.Enabled = false;

            // This step deletes the files generated by this application. Messes are not cool!
            CleanUp();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            // Locates the 'data.jet' file for the game, then makes a copy of it
            File.Copy(btdPath + @"Assets\data.jet", @"src\datajetCOPY.jet");

            // This step gets the PID (Process ID) of the game. This is required for 'strings2' to function
            GetPID();

            // This step generates a crackable hash for the 'data.jet' file
            HashPassword();

            // This step actually cracks the password from the hash provided in the previous step
            CrackPasswordHash();

            // This step extracts the cracked password. This is necessary because the file containing this password is a long text file, so this strips it out
            ReadPassword();

            // This step puts the final cracked password in your clipboard so it's easy to paste
            Clipboard.SetText(btdPassword);

            MessageBox.Show(
            $"Password has been successfully cracked!\r\nHere's the password: {btdPassword}\r\n\r\nPassword has been copied to your clipboard!",
            "Success!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            Application.Restart();
        }

        // This whole function runs every second and it checks if the game is running or not.
        private void CheckGameStatus(object source, ElapsedEventArgs e)
        {
            // 'steamProcessPath' and 'winProcessPath' are not an array and this step is only used to return the file path of the running game
            Process steamProcessPath = Process.GetProcessesByName("Battles-Win").FirstOrDefault();
            Process winProcessPath = Process.GetProcessesByName("Battles-WinRT.Windows").FirstOrDefault();

            // 'steamProcess' and 'winProcess' are an array and is needed to actually check if the game is running
            Process[] steamProcess = Process.GetProcessesByName("Battles-Win");
            Process[] winProcess = Process.GetProcessesByName("Battles-WinRT.Windows");

            try
            {
                if (steamProcess.Length > 0)
                {
                    var btdVersionInfo = FileVersionInfo.GetVersionInfo(steamProcessPath.GetMainModuleFileName());
                    string btdPathFull = steamProcessPath.GetMainModuleFileName();

                    btdVersion = btdVersionInfo.FileVersion + " (Steam)";
                    btdPath = btdPathFull.Substring(0, btdPathFull.Length - 15);
                    btdPID = steamProcessPath.Id;

                    // All of the controls below HAVE to be invoked. This method is calling these controls from a separate thread (cross-threading)
                    statusLabel.BeginInvoke((Action)delegate ()
                    {
                        statusLabel.Text = "Status: Running!\r\nCurrent Version: " + btdVersion;
                        statusLabel.ForeColor = Color.Green;
                    });

                    startButton.BeginInvoke((Action)delegate ()
                    {
                        startButton.Enabled = true;
                    });
                }

                else if (winProcess.Length > 0)
                {
                    var btdVersionInfo = FileVersionInfo.GetVersionInfo(winProcessPath.GetMainModuleFileName());
                    string btdPathFull = winProcessPath.GetMainModuleFileName();

                    btdPath = btdPathFull.Substring(0, btdPathFull.Length - 25);
                    btdPID = winProcessPath.Id;

                    // The Windows Store version of the game doesn't have it's Game Version number in any file. However,
                    // the version number is in the file path. These 2 lines below extract it
                    string versionNumberFull = btdPath.Substring(55);
                    string versionNumberMin = versionNumberFull.Substring(0, 6);

                    btdVersion = versionNumberMin + " (Windows Store)";

                    // All of the controls below HAVE to be invoked. This method is calling these controls from a separate thread (cross-threading)
                    statusLabel.BeginInvoke((Action)delegate ()
                    {
                        statusLabel.Text = "Status: Running!\r\nCurrent Version: " + btdVersion;
                        statusLabel.ForeColor = Color.Green;
                    });

                    startButton.BeginInvoke((Action)delegate ()
                    {
                        startButton.Enabled = true;
                    });
                }

                else
                {
                    statusLabel.BeginInvoke((Action)delegate ()
                    {
                        statusLabel.Text = "Status: Not Running!";
                        statusLabel.ForeColor = Color.Red;
                    });

                    startButton.BeginInvoke((Action)delegate ()
                    {
                        startButton.Enabled = false;
                    });
                }
            }
            catch
            {

            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "CrackMonkey Remastered (CMR) is a program that cracks and extracts the encrypted password for the 'data.jet' file in BTD Battles. This program is only intended for modding purposes only, however I do not condone modding in any way! Use at your own risk!\r\n\r\nP.S: It's called remastered because I tried making this program a few years ago and I forgot about it. Also, this program is a successor to 'BTDPassExtractor' which was a program I made that was used by a lot of Redditors in the BTD Modding community!\r\n\r\nCreated by FutureFlash on 5/24/2024",
            $"Crack Monkey Remastered ({versionLabel.Text})",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void CrackMonkeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btdVersion != null)
            {
                CleanUp();

                // These 3 lines of code saves the current game password and game version to this application's settings
                crackMonkeySettings.btdVersion = btdVersion;
                crackMonkeySettings.btdPassword = btdPassword;
                crackMonkeySettings.Save();
            }
            else
            {
                CleanUp();
            }

            // This line is necessary for the 'Saved Password Form'. Once the user clicks 'Yes' on that form, it hides itself but
            // doesn't quite close. It still runs in the background. This ensures that the whole program exits properly
            Application.Exit();
        }

        private void futureFlashLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Shameless plug :) Please subscribe! Anything helps!
            Process.Start("https://www.youtube.com/@FutureFlash");
        }
    }

    internal static class Extensions
    {
        // This is some code I found on StackOverflow (let's be real we have all stolen code from this website at least once)
        // Original StackOverflow Post: https://stackoverflow.com/questions/5497064/how-to-get-the-full-path-of-running-process/48319879/#48319879
        [DllImport("Kernel32.dll")]
        private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In, Out] ref uint lpdwSize);
        public static string GetMainModuleFileName(this Process process, int buffer = 1024)
        {
            var fileNameBuilder = new StringBuilder(buffer);
            uint bufferLength = (uint)fileNameBuilder.Capacity + 1;
            return QueryFullProcessImageName(process.Handle, 0, fileNameBuilder, ref bufferLength) ? fileNameBuilder.ToString() : null;
        }
    }
}
