using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gang_Fucker
{
    public partial class gangFucker : Form
    {
        public gangFucker()
        {
            InitializeComponent();
        }

        // VARIABLES \\

        public FolderBrowserDialog folder;
        public Point mouseLocation;

        // LOAD \\

        private void gangFucker_Load(object sender, EventArgs e)
        {

        }

        // VOIDS \\

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = false;
                fbd.RootFolder = Environment.SpecialFolder.ProgramFilesX86;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folder = fbd;
                    string[] files = Directory.GetFiles(folder.SelectedPath);
                    bool isUnity = false;
                    foreach (string file in files)
                    {
                        if (file.Contains("UnityPlayer.dll"))
                        {
                            isUnity = true;
                        }
                    }
                    if (!isUnity)
                    {
                        reporter.Text = "Failed, selected folder is not unity.";
                        reporter.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        reporter.Text = folder.SelectedPath.Split(char.Parse("\\")).Last();
                        reporter.ForeColor = Color.Green;
                    }
                }
                else
                {
                    reporter.Text = "Please provide a folder";
                    reporter.ForeColor = Color.Green;
                }
            }
        }

        void setProgress(int progressValue, string reporterValue, Color color)
        {
            progress.Value = progressValue;
            reporter.Text = reporterValue;
            reporter.ForeColor = color;
        }

        void setProgress(int progressValue, string reporterValue)
        {
            progress.Value = progressValue;
            reporter.Text = reporterValue;
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            try
            {
                setProgress(0, "Beginning Patch.", Color.GreenYellow);
                string folderName = folder.SelectedPath.Split(char.Parse("\\")).Last();
                if (Directory.Exists("C:\\GangFucker\\Games\\" + folderName))
                {
                    setProgress(0, "Game already patched.", Color.OrangeRed);
                    Process.Start("C:\\GangFucker\\Games\\" + folderName);
                    return;
                }
                if (Directory.Exists("C:\\GangFucker\\Games\\" + folderName))
                {
                    Directory.Delete("C:\\GangFucker\\Games\\" + folderName);
                }
                DirectoryInfo directory = Directory.CreateDirectory("C:\\GangFucker\\Games\\" + folderName);
                directory.CreationTime = DateTime.Now;
                directory.Create();
                setProgress(50, "Copying "+folderName+ " to C:\\GangFucker\\Games\\");
                CopyFilesRecursively(folder.SelectedPath, "C:\\GangFucker\\Games\\" + folderName);
                setProgress(70, "Deleting UnityEngine.dll");
                File.Delete("C:\\GangFucker\\Games\\" + folderName + "\\" + folderName + "_Data\\Managed\\UnityEngine.dll");
                setProgress(85, "Replacing UnityEngine.dll");
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri("https://github.com/OddieOldDev/GangFucker/raw/main/UnityEngine_GangBeasts_Edited_AppQuit.dll"), "C:\\GangFucker\\Games\\" + folderName + "\\" + folderName + "_Data\\Managed\\UnityEngine.dll");
                setProgress(100, "Done!");
                Process.Start("C:\\GangFucker\\Games\\" + folderName);
            }
            catch (Exception exce)
            {
                reporter.Text = "Failed." + exce.Message;
                reporter.ForeColor = Color.OrangeRed;
            }
        }

        private void draggerMouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void draggerMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Minimizer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (folder != null)
            {
                string folderName = folder.SelectedPath.Split(char.Parse("\\")).Last();
                if (Directory.Exists("C:\\GangFucker\\Games\\" + folderName))
                {
                    Process.Start("C:\\GangFucker\\Games\\" + folderName + "\\" + folderName + ".exe");
                }
                else
                {
                    setProgress(0, "There is no patched app for "+folderName, Color.Red);
                }
            }
            else
            {
                setProgress(0, "Please pick a game folder.", Color.Red);
            }
        }
    }
}
