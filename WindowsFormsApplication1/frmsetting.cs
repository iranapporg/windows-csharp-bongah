using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmsetting : Form
    {
        string font_name = "";

        public frmsetting()
        {
            InitializeComponent();

            try
            {
                txtname.Text = @File.ReadAllText(Application.StartupPath + "\\name");
            }
            catch (Exception e1)
            {
            }
            try
            {
                txtmobile.Text = @File.ReadAllText(Application.StartupPath + "\\mobile");
            }
            catch (Exception e1) { }

            try
            {
                txtmanager.Text = @File.ReadAllText(Application.StartupPath + "\\manager");
            }
            catch (Exception e1) { }

            try
            {
                Font ft = new Font(File.ReadAllText(Application.StartupPath + "\\font"),label5.Font.Size);
                label5.Font = ft;
            }
            catch (Exception e1) { }
            

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtname.Text.Length > 0)
                File.WriteAllText(Application.StartupPath + "\\name", txtname.Text);

            if (txtmobile.Text.Length > 0)
                File.WriteAllText(Application.StartupPath + "\\mobile", txtmobile.Text);

            if (txtmanager.Text.Length > 0)
                File.WriteAllText(Application.StartupPath + "\\manager", txtmanager.Text);

            if (font_name.Length > 0)
                File.WriteAllText(Application.StartupPath + "\\font", font_name);

            MessageBox.Show("اطلاعات با موفقیت ذخیره شد","توجه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();

        }

        private void frmsetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            FontDialog ft = new FontDialog();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                label5.Font = ft.Font;
                font_name = ft.Font.Name;
            }
        }
    }
}
