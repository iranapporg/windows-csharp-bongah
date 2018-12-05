using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class alarm : Form
    {
        string sUrl;
        Chilkat.Rar rar1 = new Chilkat.Rar();

        public alarm()
        {
            InitializeComponent();
        }

        private void imgdownload_Click(object sender, EventArgs e)
        {
            lbldownload.Visible = true;
            Thread t1 = new Thread(new ThreadStart(downloadUpdate));
            t1.Start();
        }

        void downloadUpdate()
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://iranapp.org/bongah/bongah.rar", "update.rar");
            }

            if (Directory.Exists(Application.StartupPath + "\\update") == false)
                Directory.CreateDirectory(Application.StartupPath + "\\update");

            rar1.Open(Application.StartupPath + "\\update.rar");
            rar1.Unrar(Application.StartupPath + "\\update");

            MessageBox.Show("نرم افزار با موفقیت بروز رسانی شد\r\nبرای اعمال بروز رسانی،نرم افزار مجددا راه اندازی میشود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CancelEventArgs e = new CancelEventArgs(false);
            Application.Exit(e);

            System.Diagnostics.Process.Start(Application.StartupPath + "\\update.bat");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            imgdownload_Click(null, null);
        }

        private static void ProcessXcopy(string SolutionDirectory, string TargetDirectory)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = true;
            //Give the name as Xcopy
            startInfo.FileName = "xcopy";
            //make the window Hidden
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Send the Source and destination as Arguments to the process
            startInfo.Arguments = "\"" + SolutionDirectory + "\"" + " " + "\"" + TargetDirectory + "\"" + @" /e /y /I";
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

    }
}
