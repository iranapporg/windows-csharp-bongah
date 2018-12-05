namespace WindowsFormsApplication1
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuadd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufilter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnureports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnurestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnusetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuadd,
            this.mnufilter1,
            this.mnureports,
            this.mnubackup,
            this.mnurestore,
            this.toolStripSeparator1,
            this.mnusetting,
            this.mnuexit2});
            this.asdasdToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.asdasdToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Hamburger_icon1;
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.asdasdToolStripMenuItem.Text = "منوی اصلی";
            // 
            // mnuadd
            // 
            this.mnuadd.Image = global::WindowsFormsApplication1.Properties.Resources.Hamburger_icon2;
            this.mnuadd.Name = "mnuadd";
            this.mnuadd.Size = new System.Drawing.Size(203, 22);
            this.mnuadd.Text = "اضافه کردن فایل جدید";
            this.mnuadd.Click += new System.EventHandler(this.mnuadd_Click_1);
            // 
            // mnufilter1
            // 
            this.mnufilter1.Image = ((System.Drawing.Image)(resources.GetObject("mnufilter1.Image")));
            this.mnufilter1.Name = "mnufilter1";
            this.mnufilter1.Size = new System.Drawing.Size(203, 22);
            this.mnufilter1.Text = "فیلتر کردن املاک";
            this.mnufilter1.Click += new System.EventHandler(this.mnufilter_Click);
            // 
            // mnureports
            // 
            this.mnureports.Image = ((System.Drawing.Image)(resources.GetObject("mnureports.Image")));
            this.mnureports.Name = "mnureports";
            this.mnureports.Size = new System.Drawing.Size(203, 22);
            this.mnureports.Text = "کل املاک موجود";
            this.mnureports.Click += new System.EventHandler(this.mnuall_Click);
            // 
            // mnubackup
            // 
            this.mnubackup.Image = ((System.Drawing.Image)(resources.GetObject("mnubackup.Image")));
            this.mnubackup.Name = "mnubackup";
            this.mnubackup.Size = new System.Drawing.Size(203, 22);
            this.mnubackup.Text = "گرفتن پشتیبان از اطلاعات";
            this.mnubackup.Click += new System.EventHandler(this.mnubackup_Click);
            // 
            // mnurestore
            // 
            this.mnurestore.Image = ((System.Drawing.Image)(resources.GetObject("mnurestore.Image")));
            this.mnurestore.Name = "mnurestore";
            this.mnurestore.Size = new System.Drawing.Size(203, 22);
            this.mnurestore.Text = "بازیابی اطلاعات از پشتیبان";
            this.mnurestore.Click += new System.EventHandler(this.mnurestore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // mnusetting
            // 
            this.mnusetting.Name = "mnusetting";
            this.mnusetting.Size = new System.Drawing.Size(203, 22);
            this.mnusetting.Text = "تنظیمات نرم افزار";
            this.mnusetting.Click += new System.EventHandler(this.mnusetting_Click);
            // 
            // mnuexit2
            // 
            this.mnuexit2.Name = "mnuexit2";
            this.mnuexit2.Size = new System.Drawing.Size(203, 22);
            this.mnuexit2.Text = "خروج از نرم افزار";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lbldate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(575, 1);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(176, 23);
            this.lbldate.TabIndex = 26;
            this.lbldate.Text = "1394/5/6";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(204, 1);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(347, 23);
            this.lblname.TabIndex = 27;
            this.lblname.Text = "مشاور املاک قیاسی";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(759, 453);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MDIParent1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پرتال بنگاه قیاسی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnufilter1;
        private System.Windows.Forms.ToolStripMenuItem mnureports;
        private System.Windows.Forms.ToolStripMenuItem mnubackup;
        private System.Windows.Forms.ToolStripMenuItem mnurestore;
        private System.Windows.Forms.ToolStripMenuItem mnuexit2;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ToolStripMenuItem mnusetting;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem mnuadd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}



