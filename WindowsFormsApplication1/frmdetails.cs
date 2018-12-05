using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmdetails : Form
    {
        public DataRow dr;
        public frmreports Report;
        private Font printFont;
        private Font printExtra;
        string font_name = "Tahoma";
        string name = "";
        string manager = "";
        string mobile = "";

        public frmdetails()
        {
            InitializeComponent();
            LoadSetting();

        }

        private void LoadSetting()
        {

            try
            {
                font_name = File.ReadAllText(Application.StartupPath + "\\font");
            }
            catch (Exception e1) { }

            try
            {
                name = @File.ReadAllText(Application.StartupPath + "\\name");
            }
            catch (Exception e1)
            {
            }
            try
            {
                mobile = @File.ReadAllText(Application.StartupPath + "\\mobile");
            }
            catch (Exception e1) { }

            try
            {
                manager = @File.ReadAllText(Application.StartupPath + "\\manager");
            }
            catch (Exception e1) { }

        }

        private void frmdetails_Load(object sender, EventArgs e)
        {

            if (dr["sBargain"].ToString() == "فروشی")
            {
                rbt1.Checked = true;
            }

            if (dr["sBargain"].ToString() == "اجاره")
            {
                rbt2.Checked = true;
            }

            if (dr["sBargain"].ToString() == "رهن")
            {
                rbt3.Checked = true;
            }

            if (dr["sType"].ToString() == "آپارتمان")
            {
                rb1.Checked = true;
            }

            if (dr["sType"].ToString() == "کلنگی")
            {
                rb2.Checked = true;
            }

            if (dr["sType"].ToString() == "مغازه")
            {
                rb3.Checked = true;
            }

            if (dr["sType"].ToString() == "ویلا")
            {
                rb4.Checked = true;
            }

            if (dr["sType"].ToString() == "پارکینگ")
            {
                rb5.Checked = true;
            }

            if (dr["sType"].ToString() == "انباری")
            {
                rb6.Checked = true;
            }

            txtname.Text = dr["sOwnerName"].ToString();
            txtmobile.Text = dr["sMobile"].ToString();
            txtphone.Text = dr["sPhone"].ToString();

            if (IsNumber(dr["sNumberOfFloor"].ToString()))
            {
                txtnof.SelectedIndex = ConvertInt(dr["sNumberOfFloor"].ToString()) - 1;
            }

            if (IsNumber(dr["sNumberOfUnit"].ToString()))
            {
                txtnou.SelectedIndex = ConvertInt(dr["sNumberOfUnit"].ToString()) - 1;
            }

            if (IsNumber(dr["sBuildingYear"].ToString()))
            {
                txtyearbuilding.SelectedIndex = ConvertInt(dr["sBuildingYear"].ToString()) - 1;
            }

            string price;
            try
            {
                double db = Convert.ToDouble(dr["sPrice"].ToString());
                price = db.ToString("N0");
            }
            catch (Exception e1) { price = dr["sPrice"].ToString(); }
            txtprice.Text = price;
            if (txtprice.Text == "0") txtprice.Text = "";

            if (IsNumber(dr["sFloorPosition"].ToString()))
            {
                txtfloorposition.SelectedIndex = ConvertInt(dr["sFloorPosition"].ToString()) - 1;
            }

            txtarea.Text = dr["sArea"].ToString();
            if (txtarea.Text == "0") txtarea.Text = "";

            txtfoundation.Text = dr["sFoundation"].ToString();
            if (txtfoundation.Text == "0") txtfoundation.Text = "";

            txtdesc.Text = dr["sDesc"].ToString();
            txtaddress.Text = dr["sAddress"].ToString();

            string price2;
            try
            {
                double db = Convert.ToDouble(dr["sRent"].ToString());
                price2 = db.ToString("N0");
            }
            catch (Exception e1) { price2 = dr["sRent"].ToString(); }
            txtejareh.Text = price2;
            if (txtejareh.Text == "0") txtejareh.Text = "";

            string price3;
            try
            {
                double db = Convert.ToDouble(dr["sMortgage"].ToString());
                price3 = db.ToString("N0");
            }
            catch (Exception e1) { price3 = dr["sMortgage"].ToString(); }
            txtvadieh.Text = price3;
            if (txtvadieh.Text == "0") txtvadieh.Text = "";

            txtkhab.Text = dr["sKhab"].ToString();
            ckkooler.Checked = ConvertBoolean(dr["sKooler"].ToString());
            ckgaz.Checked = ConvertBoolean(dr["sGaz"].ToString());
            ckphone.Checked = ConvertBoolean(dr["sTelephone"].ToString());
            ckparking.Checked = ConvertBoolean(dr["sParking"].ToString());
            ckanbari.Checked = ConvertBoolean(dr["sAnbari"].ToString());
            ckasansor.Checked = ConvertBoolean(dr["sAsansor"].ToString());
            ckteras.Checked = ConvertBoolean(dr["sTeras"].ToString());
            txtnama.Text = dr["sNema"].ToString();
            txtkaf.Text = dr["sKaf"].ToString();
            txtashpazkhooneh.Text = dr["sAshpazkhooneh"].ToString();
            ckvam.Checked = ConvertBoolean(dr["sVam"].ToString());

        }

        bool IsNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }

        int ConvertInt(string str)
        {
            return Convert.ToInt16(str);
        }

        bool ConvertBoolean(string str)
        {
            return Convert.ToBoolean(str);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("آیا اطمینان به حذف این گزینه دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db DB = new db("");
                DB.RunQuery("DELETE FROM tbl_data WHERE sID = '" + dr["sID"].ToString() + "'");
                MessageBox.Show("ملک مورد نظر از سیستم حذف شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Report.ReloadData();
                Dispose();
            }

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

            string query;
            query = String.Format("UPDATE tbl_data SET sType = '{0}',sOwnerName = '{1}',sMobile = '{2}',sPhone = '{3}',sAddress = '{4}',sNumberOfFloor = '{5}',sNumberOfUnit = '{6}',sBuildingYear = '{7}',sPrice = '{8}',sFloorPosition = '{9}',sArea = '{10}',sFoundation = '{11}',sKhab = '{12}',sKooler = '{13}',sGaz = '{14}',sTelephone = '{15}',sParking = '{16}',sAnbari = '{17}',sAsansor = '{18}',sTeras = '{19}',sNema = '{20}',sKaf = '{21}',sAshpazkhooneh = '{22}',sVam = '{23}',sDesc = '{24}',sBargain = '{25}',sRent = '{26}',sMortgage = '{27}' WHERE sID = '" + dr["sID"].ToString() + "'", stype, txtname.Text, txtmobile.Text, txtphone.Text, txtaddress.Text, txtnof.SelectedIndex + 1, txtnou.SelectedIndex + 1, txtyearbuilding.SelectedIndex + 1, txtprice.Text.Replace(",", ""), txtfloorposition.SelectedIndex + 1, txtarea.Text, txtfoundation.Text, txtkhab.SelectedIndex + 1, ckkooler.Checked, ckgaz.Checked, ckphone.Checked, ckparking.Checked, ckanbari.Checked, ckasansor.Checked, ckteras.Checked, txtnama.Text, txtkaf.Text, txtashpazkhooneh.Text, ckvam.Checked, txtdesc.Text, bargain, txtejareh.Text.Replace(",", ""), txtvadieh.Text.Replace(",", ""));

            db DB = new db("");
            DB.RunQuery(query);

            MessageBox.Show("اطلاعات با موفقیت بروز شد","توجه",MessageBoxButtons.OK,MessageBoxIcon.Information);

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

        private void txtejareh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double db = Convert.ToDouble(txtejareh.Text);
                txtejareh.Text = db.ToString("N0");
                txtejareh.SelectionStart = txtvadieh.Text.Length;
            }
            catch (Exception e1) { }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double db = Convert.ToDouble(txtprice.Text);
                txtprice.Text = db.ToString("N0");
                txtprice.SelectionStart = txtprice.Text.Length;
            }
            catch (Exception e1) { }
        }

        private void frmdetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Report.ReloadData();
            }
            catch (Exception e1) { }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            LoadSetting();

            if (name.Length == 0 || manager.Length == 0 || mobile.Length == 0)
            {
                MessageBox.Show("لطفا وارد تنظیمات شده و اطلاعات را تکمیل سپس اقدام کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                MDIParent1 fr2 = this.MdiParent as MDIParent1;
                fr2.ShowSetting();
                return;
            }

            Printing();
            pnlparent.Visible = false;
        }

        public void Printing()
        {
            PrintDialog pr = new PrintDialog();
            if (pr.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    try
                    {
                        printFont = new Font(font_name, 14, FontStyle.Bold);
                        printExtra = new Font(font_name, 10);

                        PrintDocument pd = new PrintDocument();
                        pd.PrinterSettings = pr.PrinterSettings;
                    
                        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                        // Print the document.
                        pd.Print();
                    }
                    finally
                    {

                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        printFont = new Font(font_name, 14, FontStyle.Bold);
                        printExtra = new Font(font_name, 10, FontStyle.Bold);

                        PrintDocument pd = new PrintDocument();
                        pd.PrinterSettings = pr.PrinterSettings;

                        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                        // Print the document.
                        pd.Print();
                    }
                    catch (Exception et2)
                    {
                        printFont = new Font("Tahoma", 14, FontStyle.Bold);
                        printExtra = new Font("Tahoma", 10, FontStyle.Bold);

                        PrintDocument pd = new PrintDocument();
                        pd.PrinterSettings = pr.PrinterSettings;

                        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                        // Print the document.
                        pd.Print();
                    }
                }
            }

        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 3;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.PageBounds.Left + 220;
            float topMargin = 5;
            String line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            line = "شماره پرونده : " + dr["sID"].ToString() + "\r\n\r\n";

            // Iterate over the file, printing each line.
            if (ckname.Checked)
                line += "نام مالک : " + txtname.Text + "\r\n\r\n";
            
            if (ckaddress.Checked)
                line += "آدرس کامل : " + txtaddress.Text + "\r\n\r\n";

            if (chkprice.Checked)
            {
                if (rbt1.Checked)
                    line += "قیمت فروش : " + txtprice.Text + " تومان\r\n\r\n";
                else if (rbt2.Checked)
                {
                    line += "مبلغ اجاره : " + txtejareh.Text + " تومان و ودیعه " + txtvadieh.Text + " تومان\r\n\r\n";
                }
                else if (rbt3.Checked)
                {
                    line += "مبلغ رهن کامل " + txtvadieh.Text + " تومان\r\n\r\n";
                }
            }

            if (ckinformation.Checked)
            {
                line += "تعداد طبقات : " + txtnof.SelectedItem + " و تعداد واحد " + txtnou.SelectedItem + " و ساخت " + txtyearbuilding.SelectedItem + "\r\n\r\n";
            }

            if (chkstructure.Checked)
            {
                line += "طبقه " + txtfloorposition.SelectedItem + " به متراژ " + txtarea.Text + " و زیربنای " + txtfoundation.Text + "\r\n\r\n";
            }

            if (chkfeature.Checked)
            {
                line += "دارای امکانات : ";
                if (ckkooler.Checked)
                    line += "کولر,";

                if (ckphone.Checked)
                    line += "تلفن,";

                if (ckvam.Checked)
                    line += "دارای وام,";

                if (ckparking.Checked)
                    line += "پارکینگ,";

                if (ckgaz.Checked)
                    line += "گاز,\r\n";

                if (ckteras.Checked)
                    line += "تراس,";

                if (ckanbari.Checked)
                    line += "انباری,";

                if (ckasansor.Checked)
                    line += "آسانسور,";

                if (txtnama.Text.Length > 0)
                    line += "نمای " + txtnama.Text + ",";

                if (txtashpazkhooneh.Text.Length > 0)
                    line += "آشپزخانه " + txtashpazkhooneh.Text + ",\r\n";

                if (txtkhab.SelectedIndex > -1)
                    line += "تعداد خواب " + txtkhab.SelectedItem + ",";

                if (txtkaf.Text.Length > 0)
                    line += "کف " + txtkaf.Text + "";
            }
            
            yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(name, printFont, Brushes.Black,
               leftMargin, yPos, new StringFormat());

            yPos += 50;

            ev.Graphics.DrawString(line, printExtra, Brushes.Black,
               leftMargin, yPos, new StringFormat());

            ev.Graphics.DrawString("تلفن املاک : " + mobile, printExtra, Brushes.Black,
               leftMargin, 330, new StringFormat());

            ev.Graphics.DrawString(manager, printExtra, Brushes.Black,
               leftMargin, 350, new StringFormat());

            ev.HasMorePages = false;
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            pnlparent.Visible = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            pnlparent.Visible = false;
        }

    }
}
