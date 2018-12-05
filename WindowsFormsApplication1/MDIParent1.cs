using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        frmsetting frsetting = new frmsetting();
        Form1 fr = new Form1();

        public MDIParent1()
        {
            InitializeComponent();
            lbldate.Text = GetDate(true);
            fr.MdiParent = this;
            fr.Show();
            fr.BringToFront();
            frsetting.MdiParent = this;
            checkUpdate();
        }

        private string GetDate(bool WithName)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            int year, month, day;

            year = pc.GetYear(DateTime.Now);
            month = pc.GetMonth(DateTime.Now);
            day = pc.GetDayOfMonth(DateTime.Now);

            if (WithName == false)
                return year + "/" + month + "/" + day;
            else
            {
                string month_name;
                month_name = "";

                switch (month)
                {
                    case 1:
                        month_name = "فروردین";
                        break;

                    case 2:
                        month_name = "اردبیهشت";
                        break;

                    case 3:
                        month_name = "خرداد";
                        break;

                    case 4:
                        month_name = "تیر";
                        break;

                    case 5:
                        month_name = "مرداد";
                        break;

                    case 6:
                        month_name = "شهریور";
                        break;

                    case 7:
                        month_name = "مهر";
                        break;

                    case 8:
                        month_name = "آبان";
                        break;

                    case 9:
                        month_name = "آذر";
                        break;

                    case 10:
                        month_name = "دی";
                        break;

                    case 11:
                        month_name = "بهمن";
                        break;

                    case 12:
                        month_name = "اسفند";
                        break;
                }

                Dictionary<string, string[]> DayOfWeeks = new Dictionary<string, string[]>();
                DayOfWeeks.Add("en", new string[] { "Saturday", "Sunday", "Monday", "Tuesday", "Thursday", "Wednesday", "Friday" });
                DayOfWeeks.Add("fa", new string[] { "شنبه", "یک شنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه" });

                string Text = DateTime.Today.DayOfWeek.ToString();

                if (Text == "Saturday")
                    Text = "شنبه";
                else if (Text == "Sunday")
                    Text = "یک شنبه";
                else if (Text == "Monday")
                    Text = "دو شنبه";
                else if (Text == "Tuesday")
                    Text = "سه شنبه";
                else if (Text == "Wednesday")
                    Text = "چهار شنبه";
                else if (Text == "Thursday")
                    Text = "پنج شنبه";
                else if (Text == "Friday")
                    Text = "جمعه";

                return Text + " " + day + " " + month_name + " " + year;

            }

        }

        private void mnubackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog of = new FolderBrowserDialog();
            of.ShowDialog();
            if (of.SelectedPath != "")
            {
                File.Copy(Application.StartupPath + "\\bank.db", of.SelectedPath + "\\backup.dat", true);
                MessageBox.Show("فایل حاوی اطلاعات به عنوان پشتیبان ذخیره شد\nفایل را در جای امن نگهداری کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void mnurestore_Click(object sender, EventArgs e)
        {

            OpenFileDialog fo = new OpenFileDialog();
            fo.DefaultExt = "*.dat|*.dat";
            fo.Title = "لطفا فایل پشتیبان را انتخاب کنید";
            fo.ShowDialog();
            if (fo.FileName.Length > 0)
            {
                Class1.DB.stopConnect();
                File.Copy(fo.FileName, Application.StartupPath + "\\bank.db", true);
                Class1.DB.OpenConnection();
                MessageBox.Show("بازیابی اطلاعات با موفقیت انجام شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void mnuexit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void mnuall_Click(object sender, EventArgs e)
        {
            frmreports frm = new frmreports();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnufilter_Click(object sender, EventArgs e)
        {
            frmreport frm = new frmreport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuadd_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.MdiParent = this;
            fr.Show();
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void mnusetting_Click(object sender, EventArgs e)
        {
            frsetting.Show();
        }

        public void ShowSetting()
        {
            frsetting.Show();
            frsetting.BringToFront();
        }

        private void checkUpdate()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        public static void DownloadRemoteImageFile(string uri, string fileName)
        {
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(uri, fileName);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadRemoteImageFile("https://iranapp.org/bongah/version.txt", Application.StartupPath + "\\version");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\version"))
            {
                if (Convert.ToInt16(File.ReadAllText(Application.StartupPath + "\\version")) > 1)
                {
                    if (MessageBox.Show("نسخه جدید نرم افزار منتشر شده است\r\nآیا مایل به دریافت نرم افزار هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        alarm al = new alarm();
                        al.MdiParent = this;
                        al.Show();
                    }
                }
            }
            
        }

        private void mnuadd_Click_1(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.MdiParent = this;
            fr.Show();
        }
    
    }
}
