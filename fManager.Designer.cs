
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
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.pAction = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCreatePayment = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnCreateContact = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfilter = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.cbbAreaId = new System.Windows.Forms.ComboBox();
            this.cbbStatusHome = new System.Windows.Forms.ComboBox();
            this.cbbDirection = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pInfo.SuspendLayout();
            this.pAction.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pfilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
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
            this.pInfo.Controls.Add(this.listViewInfo);
            this.pInfo.Location = new System.Drawing.Point(648, 86);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(324, 327);
            this.pInfo.TabIndex = 1;
            // 
            // listViewInfo
            // 
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInfo.GridLines = true;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(0, 0);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(324, 327);
            this.listViewInfo.TabIndex = 0;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
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
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(167, 51);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(154, 42);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Báo Cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCreatePayment
            // 
            this.btnCreatePayment.Location = new System.Drawing.Point(167, 3);
            this.btnCreatePayment.Name = "btnCreatePayment";
            this.btnCreatePayment.Size = new System.Drawing.Size(154, 42);
            this.btnCreatePayment.TabIndex = 2;
            this.btnCreatePayment.Text = "Thanh Toán";
            this.btnCreatePayment.UseVisualStyleBackColor = true;
            this.btnCreatePayment.Click += new System.EventHandler(this.btnCreatePayment_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(3, 51);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(158, 42);
            this.btnDeleteContact.TabIndex = 1;
            this.btnDeleteContact.Text = "Xoá HĐ";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnCreateContact
            // 
            this.btnCreateContact.Location = new System.Drawing.Point(3, 3);
            this.btnCreateContact.Name = "btnCreateContact";
            this.btnCreateContact.Size = new System.Drawing.Size(158, 42);
            this.btnCreateContact.TabIndex = 0;
            this.btnCreateContact.Text = "Tạo HĐ";
            this.btnCreateContact.UseVisualStyleBackColor = true;
            this.btnCreateContact.Click += new System.EventHandler(this.btnCreateContact_Click);
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
            this.pfilter.Controls.Add(this.btnClear);
            this.pfilter.Controls.Add(this.txtPrice);
            this.pfilter.Controls.Add(this.cbbAreaId);
            this.pfilter.Controls.Add(this.cbbStatusHome);
            this.pfilter.Controls.Add(this.cbbDirection);
            this.pfilter.Controls.Add(this.txtSearch);
            this.pfilter.Controls.Add(this.btnFilter);
            this.pfilter.Location = new System.Drawing.Point(12, 27);
            this.pfilter.Name = "pfilter";
            this.pfilter.Size = new System.Drawing.Size(960, 53);
            this.pfilter.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(836, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 21);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(212, 14);
            this.txtPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbAreaId
            // 
            this.cbbAreaId.FormattingEnabled = true;
            this.cbbAreaId.Location = new System.Drawing.Point(680, 14);
            this.cbbAreaId.Name = "cbbAreaId";
            this.cbbAreaId.Size = new System.Drawing.Size(150, 21);
            this.cbbAreaId.TabIndex = 5;
            // 
            // cbbStatusHome
            // 
            this.cbbStatusHome.FormattingEnabled = true;
            this.cbbStatusHome.Location = new System.Drawing.Point(524, 14);
            this.cbbStatusHome.Name = "cbbStatusHome";
            this.cbbStatusHome.Size = new System.Drawing.Size(150, 21);
            this.cbbStatusHome.TabIndex = 4;
            // 
            // cbbDirection
            // 
            this.cbbDirection.FormattingEnabled = true;
            this.cbbDirection.Location = new System.Drawing.Point(368, 14);
            this.cbbDirection.Name = "cbbDirection";
            this.cbbDirection.Size = new System.Drawing.Size(150, 21);
            this.cbbDirection.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(885, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(72, 21);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(648, 422);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(324, 21);
            this.cbbCustomer.TabIndex = 5;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 320;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.pfilter);
            this.Controls.Add(this.pAction);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.tMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.pInfo.ResumeLayout(false);
            this.pAction.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pfilter.ResumeLayout(false);
            this.pfilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
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
        private System.Windows.Forms.ComboBox cbbAreaId;
        private System.Windows.Forms.ComboBox cbbStatusHome;
        private System.Windows.Forms.ComboBox cbbDirection;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}