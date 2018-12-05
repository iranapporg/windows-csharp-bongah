using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        db DB = new db("");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.AutoComplete(txtkaf, "SELECT sKaf FROM tbl_data GROUP BY sKaf","sKaf");
            DB.AutoComplete(txtnama, "SELECT sNema FROM tbl_data GROUP BY sNema", "sNema");
            DB.AutoComplete(txtashpazkhooneh, "SELECT sAshpazkhooneh FROM tbl_data GROUP BY sAshpazkhooneh", "sAshpazkhooneh");
        }

        private string GetDate(bool WithName)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            int year, month, day;

            year    =   pc.GetYear(DateTime.Now);
            month   =   pc.GetMonth(DateTime.Now);
            day     =   pc.GetDayOfMonth(DateTime.Now);

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

                string Text = DayOfWeeks["fa"][(int)DateTime.Today.DayOfWeek+1];

                return Text + " " + day + " " + month_name + " " + year;

            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            rb1.Checked = true;
            txtname.Text = txtmobile.Text = txtphone.Text = "";
            txtaddress.Text = txtprice.Text =   "";
            txtnof.SelectedIndex = txtnou.SelectedIndex = txtyearbuilding.SelectedIndex = - 1;
            txtfloorposition.SelectedIndex = -1;
            txtarea.Text = txtfoundation.Text = txtdesc.Text = "";
            txtkhab.Text = "";
            ckkooler.Checked = false;
            ckgaz.Checked = false;
            ckphone.Checked = false;
            ckparking.Checked = false;
            ckanbari.Checked = false;
            ckasansor.Checked = false;
            ckteras.Checked = false;
            txtnama.Text = "";
            txtkaf.Text = "";
            txtashpazkhooneh.Text = "";
            ckvam.Checked = false;
            txtejareh.Text = txtvadieh.Text = "";
            rbt1.Checked = true;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Length == 0)
            {
                MessageBox.Show("لطفا نام مالک را وارد کنید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (txtmobile.Text.Length == 0)
            {
                MessageBox.Show("لطفا موبایل مالک را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtaddress.Text.Length == 0)
            {
                MessageBox.Show("لطفا آدرس ملک را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (txtprice.Text.Length == 0)
            //{
            //    MessageBox.Show("لطفا قیمت ملک را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string bargain;
            bargain = "فروشی";

            if (rbt1.Checked)
                bargain = "فروشی";
            else if (rbt2.Checked)
                bargain = "اجاره";
            else if (rbt3.Checked)
                bargain = "رهن";

            string stype;
            if (rb1.Checked)
                stype = "آپارتمان";
            else if (rb2.Checked)
                stype = "کلنگی";
            else if (rb3.Checked)
                stype = "مغازه";
            else if (rb4.Checked)
                stype = "ویلا";
            else if (rb5.Checked)
                stype = "پارکینگ";
            else if (rb6.Checked)
                stype = "انباری";
            else
                stype = "آپارتمان";

            string date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;

            string last_id = DB.getLastInsertID().ToString();

            string query;
            query = String.Format("INSERT INTO tbl_data VALUES('" + last_id + "','{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}')", stype, txtname.Text, txtmobile.Text, txtphone.Text, txtaddress.Text, txtnof.SelectedIndex + 1, txtnou.SelectedIndex + 1, txtyearbuilding.SelectedIndex + 1, txtprice.Text.Replace(",", ""), txtfloorposition.SelectedIndex + 1, txtarea.Text, txtfoundation.Text, txtkhab.SelectedIndex + 1, ckkooler.Checked, ckgaz.Checked, ckphone.Checked, ckparking.Checked, ckanbari.Checked, ckasansor.Checked, ckteras.Checked, txtnama.Text, txtkaf.Text, txtashpazkhooneh.Text, ckvam.Checked, txtdesc.Text, date, GetDate(false), bargain, txtejareh.Text.Replace(",", ""), txtvadieh.Text.Replace(",", ""));

            DB.RunQuery(query);

            btnreset_Click(null, null);

            MessageBox.Show("اطلاعات با موفقیت ثبت و ذخیره شدند","توجه",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double db = Convert.ToDouble(txtprice.Text);
                txtprice.Text = db.ToString("N0");
                txtprice.SelectionStart = txtprice.Text.Length;
            }
            catch(Exception e1) {}

        }

        private void mnureport_Click(object sender, EventArgs e)
        {
            frmreports frm = new frmreports();
            frm.ShowDialog();
        }

        private void txtejareh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double db = Convert.ToDouble(txtejareh.Text);
                txtejareh.Text = db.ToString("N0");
                txtejareh.SelectionStart = txtejareh.Text.Length;
            }
            catch (Exception e1) { }
        }

        private void txtvadieh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double db = Convert.ToDouble(txtvadieh.Text);
                txtvadieh.Text = db.ToString("N0");
                txtvadieh.SelectionStart = txtvadieh.Text.Length;
            }
            catch (Exception e1) { }
        }

        private void rbt1_Click(object sender, EventArgs e)
        {
            pnlnosell.Visible = false;
        }

        private void rbt2_Click(object sender, EventArgs e)
        {
            pnlnosell.Visible = true;
        }

        private void rbt3_Click(object sender, EventArgs e)
        {
            pnlnosell.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

    }
}
