namespace WindowsFormsApplication1
{
    partial class frmreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkhab = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtrahnto = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtrahnfrom = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtejarehto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtejarehfrom = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ckt3 = new System.Windows.Forms.CheckBox();
            this.ckt2 = new System.Windows.Forms.CheckBox();
            this.ckt1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ck6 = new System.Windows.Forms.CheckBox();
            this.ck5 = new System.Windows.Forms.CheckBox();
            this.ck4 = new System.Windows.Forms.CheckBox();
            this.ck3 = new System.Windows.Forms.CheckBox();
            this.ck2 = new System.Windows.Forms.CheckBox();
            this.ck1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ckvam = new System.Windows.Forms.CheckBox();
            this.ckasansor = new System.Windows.Forms.CheckBox();
            this.ckanbari = new System.Windows.Forms.CheckBox();
            this.ckparking = new System.Windows.Forms.CheckBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtyearbuilding = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnou = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnof = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfoundationto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfoundationfrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpriceto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpricefrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(1, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 130F;
            this.Column1.HeaderText = "نوع ساختمان";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "معامله";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "نام مالک";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 153;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "موبایل";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 85;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "تلفن";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "تاریخ ثبت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "قیمت";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 144;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtkhab);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtrahnto);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtrahnfrom);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtejarehto);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtejarehfrom);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.ckt3);
            this.groupBox1.Controls.Add(this.ckt2);
            this.groupBox1.Controls.Add(this.ckt1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.ck6);
            this.groupBox1.Controls.Add(this.ck5);
            this.groupBox1.Controls.Add(this.ck4);
            this.groupBox1.Controls.Add(this.ck3);
            this.groupBox1.Controls.Add(this.ck2);
            this.groupBox1.Controls.Add(this.ck1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ckvam);
            this.groupBox1.Controls.Add(this.ckasansor);
            this.groupBox1.Controls.Add(this.ckanbari);
            this.groupBox1.Controls.Add(this.ckparking);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.txtyearbuilding);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtnou);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnof);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnfilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtfoundationto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtfoundationfrom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpriceto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpricefrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtkhab
            // 
            this.txtkhab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkhab.FormattingEnabled = true;
            this.txtkhab.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txtkhab.Location = new System.Drawing.Point(34, 231);
            this.txtkhab.Name = "txtkhab";
            this.txtkhab.Size = new System.Drawing.Size(103, 21);
            this.txtkhab.TabIndex = 58;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(143, 235);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "تعداد خواب :";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(694, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "فیلتر با قیمت رهن :";
            // 
            // txtrahnto
            // 
            this.txtrahnto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrahnto.Location = new System.Drawing.Point(32, 150);
            this.txtrahnto.Name = "txtrahnto";
            this.txtrahnto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtrahnto.Size = new System.Drawing.Size(242, 21);
            this.txtrahnto.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "تا";
            // 
            // txtrahnfrom
            // 
            this.txtrahnfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrahnfrom.Location = new System.Drawing.Point(339, 150);
            this.txtrahnfrom.Name = "txtrahnfrom";
            this.txtrahnfrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtrahnfrom.Size = new System.Drawing.Size(242, 21);
            this.txtrahnfrom.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(587, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "از مبلغ :";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(693, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "فیلتر با قیمت اجاره :";
            // 
            // txtejarehto
            // 
            this.txtejarehto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtejarehto.Location = new System.Drawing.Point(32, 119);
            this.txtejarehto.Name = "txtejarehto";
            this.txtejarehto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtejarehto.Size = new System.Drawing.Size(242, 21);
            this.txtejarehto.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "تا";
            // 
            // txtejarehfrom
            // 
            this.txtejarehfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtejarehfrom.Location = new System.Drawing.Point(339, 119);
            this.txtejarehfrom.Name = "txtejarehfrom";
            this.txtejarehfrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtejarehfrom.Size = new System.Drawing.Size(242, 21);
            this.txtejarehfrom.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(587, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "از مبلغ :";
            // 
            // ckt3
            // 
            this.ckt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckt3.AutoSize = true;
            this.ckt3.Location = new System.Drawing.Point(386, 23);
            this.ckt3.Name = "ckt3";
            this.ckt3.Size = new System.Drawing.Size(46, 17);
            this.ckt3.TabIndex = 46;
            this.ckt3.Text = "رهن";
            this.ckt3.UseVisualStyleBackColor = true;
            // 
            // ckt2
            // 
            this.ckt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckt2.AutoSize = true;
            this.ckt2.Location = new System.Drawing.Point(477, 23);
            this.ckt2.Name = "ckt2";
            this.ckt2.Size = new System.Drawing.Size(48, 17);
            this.ckt2.TabIndex = 45;
            this.ckt2.Text = "اجاره";
            this.ckt2.UseVisualStyleBackColor = true;
            // 
            // ckt1
            // 
            this.ckt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckt1.AutoSize = true;
            this.ckt1.Location = new System.Drawing.Point(565, 23);
            this.ckt1.Name = "ckt1";
            this.ckt1.Size = new System.Drawing.Size(63, 17);
            this.ckt1.TabIndex = 44;
            this.ckt1.Text = "فروشی";
            this.ckt1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(695, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "فیلتر با نوع معامله :";
            // 
            // ck6
            // 
            this.ck6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck6.AutoSize = true;
            this.ck6.Location = new System.Drawing.Point(94, 56);
            this.ck6.Name = "ck6";
            this.ck6.Size = new System.Drawing.Size(43, 17);
            this.ck6.TabIndex = 5;
            this.ck6.Text = "انبار";
            this.ck6.UseVisualStyleBackColor = true;
            // 
            // ck5
            // 
            this.ck5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck5.AutoSize = true;
            this.ck5.Location = new System.Drawing.Point(183, 55);
            this.ck5.Name = "ck5";
            this.ck5.Size = new System.Drawing.Size(60, 17);
            this.ck5.TabIndex = 4;
            this.ck5.Text = "پارکینگ";
            this.ck5.UseVisualStyleBackColor = true;
            // 
            // ck4
            // 
            this.ck4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck4.AutoSize = true;
            this.ck4.Location = new System.Drawing.Point(295, 54);
            this.ck4.Name = "ck4";
            this.ck4.Size = new System.Drawing.Size(42, 17);
            this.ck4.TabIndex = 3;
            this.ck4.Text = "ویلا";
            this.ck4.UseVisualStyleBackColor = true;
            // 
            // ck3
            // 
            this.ck3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck3.AutoSize = true;
            this.ck3.Location = new System.Drawing.Point(382, 55);
            this.ck3.Name = "ck3";
            this.ck3.Size = new System.Drawing.Size(50, 17);
            this.ck3.TabIndex = 2;
            this.ck3.Text = "مغازه";
            this.ck3.UseVisualStyleBackColor = true;
            // 
            // ck2
            // 
            this.ck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck2.AutoSize = true;
            this.ck2.Location = new System.Drawing.Point(469, 55);
            this.ck2.Name = "ck2";
            this.ck2.Size = new System.Drawing.Size(56, 17);
            this.ck2.TabIndex = 1;
            this.ck2.Text = "کلنگی";
            this.ck2.UseVisualStyleBackColor = true;
            // 
            // ck1
            // 
            this.ck1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ck1.AutoSize = true;
            this.ck1.Location = new System.Drawing.Point(569, 55);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(59, 17);
            this.ck1.TabIndex = 0;
            this.ck1.Text = "آپارتمان";
            this.ck1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(703, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "شرایط ساختمان :";
            // 
            // ckvam
            // 
            this.ckvam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckvam.AutoSize = true;
            this.ckvam.Location = new System.Drawing.Point(268, 275);
            this.ckvam.Name = "ckvam";
            this.ckvam.Size = new System.Drawing.Size(69, 17);
            this.ckvam.TabIndex = 16;
            this.ckvam.Text = "دارای وام";
            this.ckvam.UseVisualStyleBackColor = true;
            // 
            // ckasansor
            // 
            this.ckasansor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckasansor.AutoSize = true;
            this.ckasansor.Location = new System.Drawing.Point(561, 276);
            this.ckasansor.Name = "ckasansor";
            this.ckasansor.Size = new System.Drawing.Size(67, 17);
            this.ckasansor.TabIndex = 13;
            this.ckasansor.Text = "آسانسور";
            this.ckasansor.UseVisualStyleBackColor = true;
            // 
            // ckanbari
            // 
            this.ckanbari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckanbari.AutoSize = true;
            this.ckanbari.Location = new System.Drawing.Point(379, 275);
            this.ckanbari.Name = "ckanbari";
            this.ckanbari.Size = new System.Drawing.Size(53, 17);
            this.ckanbari.TabIndex = 15;
            this.ckanbari.Text = "انباری";
            this.ckanbari.UseVisualStyleBackColor = true;
            // 
            // ckparking
            // 
            this.ckparking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckparking.AutoSize = true;
            this.ckparking.Location = new System.Drawing.Point(465, 275);
            this.ckparking.Name = "ckparking";
            this.ckparking.Size = new System.Drawing.Size(60, 17);
            this.ckparking.TabIndex = 14;
            this.ckparking.Text = "پارکینگ";
            this.ckparking.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreset.Location = new System.Drawing.Point(148, 322);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(101, 27);
            this.btnreset.TabIndex = 18;
            this.btnreset.Text = "بازنشانی";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtyearbuilding
            // 
            this.txtyearbuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtyearbuilding.FormattingEnabled = true;
            this.txtyearbuilding.Items.AddRange(new object[] {
            "1 سال",
            "2 سال",
            "3 سال",
            "4 سال",
            "5 سال",
            "6 سال",
            "7 سال",
            "8 سال",
            "9 سال",
            "10 سال",
            "11 سال",
            "12 سال",
            "13 سال",
            "14 سال",
            "15 سال",
            "16 سال",
            "17 سال",
            "18 سال",
            "19 سال",
            "20 سال",
            "21 سال",
            "22 سال",
            "23 سال",
            "24 سال",
            "25 سال",
            "26 سال",
            "27 سال",
            "28 سال",
            "29 سال",
            "30 سال"});
            this.txtyearbuilding.Location = new System.Drawing.Point(234, 231);
            this.txtyearbuilding.Name = "txtyearbuilding";
            this.txtyearbuilding.Size = new System.Drawing.Size(103, 21);
            this.txtyearbuilding.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "ساخت :";
            // 
            // txtnou
            // 
            this.txtnou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnou.FormattingEnabled = true;
            this.txtnou.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.txtnou.Location = new System.Drawing.Point(429, 231);
            this.txtnou.Name = "txtnou";
            this.txtnou.Size = new System.Drawing.Size(103, 21);
            this.txtnou.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "تعداد واحد :";
            // 
            // txtnof
            // 
            this.txtnof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnof.FormattingEnabled = true;
            this.txtnof.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.txtnof.Location = new System.Drawing.Point(633, 231);
            this.txtnof.Name = "txtnof";
            this.txtnof.Size = new System.Drawing.Size(103, 21);
            this.txtnof.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(741, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "طبقه ی :";
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfilter.Location = new System.Drawing.Point(32, 322);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(101, 27);
            this.btnfilter.TabIndex = 17;
            this.btnfilter.Text = "فیلتر کن";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "فیلتر با متراژ :";
            // 
            // txtfoundationto
            // 
            this.txtfoundationto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfoundationto.Location = new System.Drawing.Point(32, 181);
            this.txtfoundationto.Name = "txtfoundationto";
            this.txtfoundationto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfoundationto.Size = new System.Drawing.Size(242, 21);
            this.txtfoundationto.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "تا";
            // 
            // txtfoundationfrom
            // 
            this.txtfoundationfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfoundationfrom.Location = new System.Drawing.Point(339, 181);
            this.txtfoundationfrom.Name = "txtfoundationfrom";
            this.txtfoundationfrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfoundationfrom.Size = new System.Drawing.Size(242, 21);
            this.txtfoundationfrom.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "از متر :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "فیلتر با قیمت :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "فیلتر با نوع ساختمان :";
            // 
            // txtpriceto
            // 
            this.txtpriceto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpriceto.Location = new System.Drawing.Point(32, 89);
            this.txtpriceto.Name = "txtpriceto";
            this.txtpriceto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpriceto.Size = new System.Drawing.Size(242, 21);
            this.txtpriceto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا";
            // 
            // txtpricefrom
            // 
            this.txtpricefrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpricefrom.Location = new System.Drawing.Point(339, 89);
            this.txtpricefrom.Name = "txtpricefrom";
            this.txtpricefrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpricefrom.Size = new System.Drawing.Size(242, 21);
            this.txtpricefrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "از مبلغ :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(32, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(759, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "__________________________________\'______________________________________________" +
                "_____________________________________________";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(32, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(759, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "__________________________________\'______________________________________________" +
                "_____________________________________________";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(203, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(336, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "برای اطلاعات بیشتر در مورد هر ملک کافیست روی آن کلیک کنید";
            // 
            // frmreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 650);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmreport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فیلترگذاری";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpriceto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpricefrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfoundationto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfoundationfrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtyearbuilding;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtnou;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtnof;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.CheckBox ckvam;
        private System.Windows.Forms.CheckBox ckasansor;
        private System.Windows.Forms.CheckBox ckanbari;
        private System.Windows.Forms.CheckBox ckparking;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ck6;
        private System.Windows.Forms.CheckBox ck5;
        private System.Windows.Forms.CheckBox ck4;
        private System.Windows.Forms.CheckBox ck3;
        private System.Windows.Forms.CheckBox ck2;
        private System.Windows.Forms.CheckBox ck1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ckt3;
        private System.Windows.Forms.CheckBox ckt2;
        private System.Windows.Forms.CheckBox ckt1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtejarehto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtejarehfrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtrahnto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtrahnfrom;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox txtkhab;
        private System.Windows.Forms.Label label22;
    }
}