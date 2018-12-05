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
    public partial class frmreports : Form
    {
        DataTable dt = new DataTable();
        MDIParent1 md;

        public frmreports()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow dr = dt.Rows[e.RowIndex];

                frmdetails fr = new frmdetails();
                fr.dr = dr;
                fr.Report = this;
                fr.MdiParent = this.MdiParent;
                fr.Show();
            }
            catch (Exception e1) { }
        }

        private void frmreports_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            db DB = new db("");
            dt.Clear();
            dt = DB.getRow("SELECT * FROM tbl_data");

            foreach (DataRow dr in dt.Rows)
            {
                string price;
                try
                {
                    double db = Convert.ToDouble(dr["sPrice"].ToString());
                    price = db.ToString("N0") + " تومان";
                }
                catch (Exception e1) { price = dr["sPrice"].ToString() + " تومان"; }

                try
                {
                    dataGridView1.Rows.Add(dr["sType"].ToString(), dr["sBargain"].ToString(), dr["sOwnerName"].ToString(), dr["sMobile"].ToString(), dr["sPhone"].ToString(), dr["sDateFa"].ToString(), dr["sBuildingYear"].ToString() + " سال", dr["sFoundation"].ToString(), price);
                }
                catch (Exception e2) { }
            }
        }

        public void ReloadData()
        {
            frmreports_Activated(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {

            if (txtcode.Text.Length == 0) return;
            try { dt.Clear(); }
            catch (Exception e1) { }

            dataGridView1.Rows.Clear();

            db DB = new db("");
            dt = DB.getRow("SELECT * FROM tbl_data WHERE sID = " + txtcode.Text);

            if (dt == null) return;

            foreach (DataRow dr in dt.Rows)
            {
                string price;
                try
                {
                    double db = Convert.ToDouble(dr["sPrice"].ToString());
                    price = db.ToString("N0") + " تومان";
                }
                catch (Exception e1) { price = dr["sPrice"].ToString() + " تومان"; }

                try
                {
                    dataGridView1.Rows.Add(dr["sType"].ToString(), dr["sBargain"].ToString(), dr["sOwnerName"].ToString(), dr["sMobile"].ToString(), dr["sPhone"].ToString(), dr["sDateFa"].ToString(), dr["sBuildingYear"].ToString() + " سال", dr["sFoundation"].ToString(), price);
                }
                catch (Exception e2) { }
            }

        }

    }
}
