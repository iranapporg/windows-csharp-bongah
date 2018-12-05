namespace WindowsFormsApplication1
{
    partial class alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alarm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldownload = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgdownload = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdownload)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbldownload);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imgdownload);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(378, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbldownload
            // 
            this.lbldownload.AutoSize = true;
            this.lbldownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldownload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldownload.ForeColor = System.Drawing.Color.Black;
            this.lbldownload.Location = new System.Drawing.Point(139, 220);
            this.lbldownload.Name = "lbldownload";
            this.lbldownload.Size = new System.Drawing.Size(96, 14);
            this.lbldownload.TabIndex = 23;
            this.lbldownload.Text = "در حال دانلود...";
            this.lbldownload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbldownload.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(90, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "نسخه جدید نرم افزار ارایه  شده است\r\nبرای دانلود کلیک کنید و منتظر باشید";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // imgdownload
            // 
            this.imgdownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgdownload.Image = global::WindowsFormsApplication1.Properties.Resources.download2;
            this.imgdownload.Location = new System.Drawing.Point(140, 78);
            this.imgdownload.Name = "imgdownload";
            this.imgdownload.Size = new System.Drawing.Size(95, 95);
            this.imgdownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgdownload.TabIndex = 22;
            this.imgdownload.TabStop = false;
            this.imgdownload.Click += new System.EventHandler(this.imgdownload_Click);
            // 
            // alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 320);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "alarm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نسخه جدید نرم افزار";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdownload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgdownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldownload;
    }
}