
namespace QuanLyNha
{
    partial class fManager
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
            this.tMain = new System.Windows.Forms.TabControl();
            this.pInfo = new System.Windows.Forms.Panel();
            this.pAction = new System.Windows.Forms.Panel();
            this.btnCreateContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnCreatePayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pAction.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pfilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tMain
            // 
            this.tMain.Location = new System.Drawing.Point(12, 86);
            this.tMain.Name = "tMain";
            this.tMain.SelectedIndex = 0;
            this.tMain.Size = new System.Drawing.Size(630, 463);
            this.tMain.TabIndex = 0;
            // 
            // pInfo
            // 
            this.pInfo.Location = new System.Drawing.Point(648, 86);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(324, 350);
            this.pInfo.TabIndex = 1;
            // 
            // pAction
            // 
            this.pAction.Controls.Add(this.btnReport);
            this.pAction.Controls.Add(this.btnCreatePayment);
            this.pAction.Controls.Add(this.btnDeleteContact);
            this.pAction.Controls.Add(this.btnCreateContact);
            this.pAction.Location = new System.Drawing.Point(648, 449);
            this.pAction.Name = "pAction";
            this.pAction.Size = new System.Drawing.Size(324, 100);
            this.pAction.TabIndex = 2;
            // 
            // btnCreateContact
            // 
            this.btnCreateContact.Location = new System.Drawing.Point(3, 3);
            this.btnCreateContact.Name = "btnCreateContact";
            this.btnCreateContact.Size = new System.Drawing.Size(135, 42);
            this.btnCreateContact.TabIndex = 0;
            this.btnCreateContact.Text = "Tạo HĐ";
            this.btnCreateContact.UseVisualStyleBackColor = true;
            this.btnCreateContact.Click += new System.EventHandler(this.btnCreateContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(3, 51);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(135, 42);
            this.btnDeleteContact.TabIndex = 1;
            this.btnDeleteContact.Text = "Xoá HĐ";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnCreatePayment
            // 
            this.btnCreatePayment.Location = new System.Drawing.Point(144, 3);
            this.btnCreatePayment.Name = "btnCreatePayment";
            this.btnCreatePayment.Size = new System.Drawing.Size(135, 42);
            this.btnCreatePayment.TabIndex = 2;
            this.btnCreatePayment.Text = "Thanh Toán";
            this.btnCreatePayment.UseVisualStyleBackColor = true;
            this.btnCreatePayment.Click += new System.EventHandler(this.btnCreatePayment_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(144, 51);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 42);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Báo Cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pfilter
            // 
            this.pfilter.Controls.Add(this.numericUpDown1);
            this.pfilter.Controls.Add(this.comboBox4);
            this.pfilter.Controls.Add(this.comboBox3);
            this.pfilter.Controls.Add(this.comboBox2);
            this.pfilter.Controls.Add(this.textBox1);
            this.pfilter.Controls.Add(this.btnFilter);
            this.pfilter.Location = new System.Drawing.Point(12, 27);
            this.pfilter.Name = "pfilter";
            this.pfilter.Size = new System.Drawing.Size(960, 53);
            this.pfilter.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(833, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(124, 21);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(368, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(524, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(680, 14);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(150, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(212, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pfilter);
            this.Controls.Add(this.pAction);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.tMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManager";
            this.Text = "fAdmin";
            this.pAction.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pfilter.ResumeLayout(false);
            this.pfilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tMain;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Panel pAction;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCreatePayment;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnCreateContact;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pfilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}