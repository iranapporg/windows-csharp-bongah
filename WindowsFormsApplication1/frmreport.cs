using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmreport : Form
    {
        DataTable dt = new DataTable();

        public frmreport()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ck1.Checked = ck2.Checked = ck3.Checked = ck4.Checked = ck5.Checked = ck6.Checked = false;
            txtpricefrom.Text = txtpriceto.Text = txtfoundationfrom.Text = txtfoundationto.Text = "";
            txtnof.SelectedIndex = txtnou.SelectedIndex = txtyearbuilding.SelectedIndex = - 1;
            ckasansor.Checked = ckparking.Checked = ckanbari.Checked = ckvam.Checked = false;
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            string query;
            query = "SELECT * FROM tbl_data WHERE ";

            if (ck1.Checked || ck2.Checked || ck3.Checked || ck4.Checked || ck5.Checked || ck6.Checked) {
                
                string in_where = " sType IN (";
                var listOfStrings = new List<string>();

                if (ck1.Checked)
                    listOfStrings.Add("'آپارتمان'");

                if (ck2.Checked)
                    listOfStrings.Add("'کلنگی'");

                if (ck3.Checked)
                    listOfStrings.Add("'مغازه'");

                if (ck4.Checked)
                    listOfStrings.Add("'ویلا'");

                if (ck5.Checked)
                    listOfStrings.Add("'پارکینگ'");

                if (ck6.Checked)
                    listOfStrings.Add("'انباری'");

                in_where += String.Join(",",listOfStrings.ToArray());
                query += in_where + ") AND ";

            }

            if (ckt1.Checked || ckt2.Checked || ckt3.Checked)
            {

                string in_where = " sBargain IN (";
                var listOfStrings2 = new List<string>();

                if (ckt1.Checked)
                    listOfStrings2.Add("'فروشی'");

                if (ckt2.Checked)
                    listOfStrings2.Add("'اجاره'");

                if (ckt3.Checked)
                    listOfStrings2.Add("'رهن'");

                in_where += String.Join(",", listOfStrings2.ToArray());
                query += in_where + ") AND ";

            }

            if (txtpricefrom.Text.Length != 0 && txtpriceto.Text.Length != 0)
            {
                query += "sPrice BETWEEN '" + txtpricefrom.Text + "' AND '" + txtpriceto.Text + "' AND ";
            }

            if (txtkhab.SelectedIndex > -1)
            {
                query += "sKhab = '" + txtkhab.SelectedItem + "' AND ";
            }

            if (txtejarehfrom.Text.Length != 0 && txtejarehto.Text.Length != 0)
            {
                query += "sRent BETWEEN '" + txtejarehfrom.Text + "' AND '" + txtejarehto.Text + "' AND ";
            }

            if (txtrahnfrom.Text.Length != 0 && txtrahnto.Text.Length != 0)
            {
                query += "sMortgage BETWEEN '" + txtrahnfrom.Text + "' AND '" + txtrahnto.Text + "' AND ";
            }

            if (txtfoundationfrom.Text.Length != 0 && txtfoundationto.Text.Length != 0)
            {
                query += "sFoundation BETWEEN '" + txtfoundationfrom.Text + "' AND '" + txtfoundationto.Text + "' AND ";
            }

            if (txtnof.SelectedIndex != -1)
            {
                query += "sFloorPosition = '" + (txtnof.SelectedIndex + 1).ToString() + "' AND ";
            }

            if (txtnou.SelectedIndex != -1)
            {
                query += "sNumberOfUnit = '" + (txtnou.SelectedIndex + 1).ToString() + "' AND ";
            }

            if (txtyearbuilding.SelectedIndex != -1)
            {
                query += "sBuildingYear = '" + (txtyearbuilding.SelectedIndex + 1).ToString() + "' AND ";
            }

            if (ckasansor.Checked)
                query += "sAsansor = 'True' AND ";

            if (ckparking.Checked)
                query += "sParking = 'True' AND ";

            if (ckanbari.Checked)
                query += "sAnbari = 'True' AND ";

            if (ckvam.Checked)
                query += "sVam = 'True' AND ";

            query += " 1=1";

            db DB = new db("");
            dt.Clear();
            dt = DB.getRow(query);

            if (dt.Rows.Count == 0)
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("هیچ موردی برای فیلتر تعین شده پیدا نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                string price;
                try
                {
                    double db = Convert.ToDouble(dr["sPrice"].ToString());
                    price = db.ToString("N0") + " تومان";
                }
                catch (Exception e1) { price = dr["sPrice"].ToString() + " تومان"; }

                dataGridView1.Rows.Add(dr["sType"].ToString(), dr["sBargain"].ToString(), dr["sOwnerName"].ToString(), dr["sMobile"].ToString(), dr["sPhone"].ToString(), dr["sDateFa"].ToString(), price);
            }

            dataGridView1.ClearSelection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = dt.Rows[e.RowIndex];

            frmdetails fr = new frmdetails();
            fr.dr = dr;
            fr.ShowDialog();
        }

    }
}
