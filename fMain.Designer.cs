
namespace QuanLyNha
{
    partial class fMain
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
            this.tArea = new System.Windows.Forms.TabPage();
            this.btnUpdateArea = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.txtAreaStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAreaPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAreaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pArea = new System.Windows.Forms.Panel();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.tHome = new System.Windows.Forms.TabPage();
            this.txtHomeDirection = new System.Windows.Forms.ComboBox();
            this.txtHomeStorey = new System.Windows.Forms.NumericUpDown();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.btnHomeUpdate = new System.Windows.Forms.Button();
            this.btnHomeAdd = new System.Windows.Forms.Button();
            this.txtHomeAreaId = new System.Windows.Forms.ComboBox();
            this.txtHomeStatus = new System.Windows.Forms.ComboBox();
            this.txtHomeResidentialArea = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHomeName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHomeId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.Panel();
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.tCustomer = new System.Windows.Forms.TabPage();
            this.txtCustomerStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomerBrithDay = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustomerCMND = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.pCustomer = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tAccount = new System.Windows.Forms.TabPage();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountUserName = new System.Windows.Forms.TextBox();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.txtAccountStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountDisplayName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pAccount = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tMain.SuspendLayout();
            this.tArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaPrice)).BeginInit();
            this.pArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.tHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeStorey)).BeginInit();
            this.pHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            this.tCustomer.SuspendLayout();
            this.pCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tAccount.SuspendLayout();
            this.pAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tMain
            // 
            this.tMain.Controls.Add(this.tArea);
            this.tMain.Controls.Add(this.tHome);
            this.tMain.Controls.Add(this.tCustomer);
            this.tMain.Controls.Add(this.tAccount);
            this.tMain.Location = new System.Drawing.Point(12, 12);
            this.tMain.Name = "tMain";
            this.tMain.SelectedIndex = 0;
            this.tMain.Size = new System.Drawing.Size(1160, 537);
            this.tMain.TabIndex = 0;
            this.tMain.SelectedIndexChanged += new System.EventHandler(this.tMain_SelectedIndexChanged);
            // 
            // tArea
            // 
            this.tArea.Controls.Add(this.btnUpdateArea);
            this.tArea.Controls.Add(this.btnAddArea);
            this.tArea.Controls.Add(this.txtAreaStatus);
            this.tArea.Controls.Add(this.label4);
            this.tArea.Controls.Add(this.txtAreaPrice);
            this.tArea.Controls.Add(this.label3);
            this.tArea.Controls.Add(this.txtAreaName);
            this.tArea.Controls.Add(this.label2);
            this.tArea.Controls.Add(this.txtAreaId);
            this.tArea.Controls.Add(this.label1);
            this.tArea.Controls.Add(this.pArea);
            this.tArea.Location = new System.Drawing.Point(4, 22);
            this.tArea.Name = "tArea";
            this.tArea.Padding = new System.Windows.Forms.Padding(3);
            this.tArea.Size = new System.Drawing.Size(1152, 511);
            this.tArea.TabIndex = 0;
            this.tArea.Text = "Khu vực";
            this.tArea.UseVisualStyleBackColor = true;
            // 
            // btnUpdateArea
            // 
            this.btnUpdateArea.Location = new System.Drawing.Point(882, 18);
            this.btnUpdateArea.Name = "btnUpdateArea";
            this.btnUpdateArea.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateArea.TabIndex = 11;
            this.btnUpdateArea.Text = "Sửa";
            this.btnUpdateArea.UseVisualStyleBackColor = true;
            this.btnUpdateArea.Click += new System.EventHandler(this.btnUpdateArea_Click);
            // 
            // btnAddArea
            // 
            this.btnAddArea.Location = new System.Drawing.Point(764, 19);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(100, 50);
            this.btnAddArea.TabIndex = 10;
            this.btnAddArea.Text = "Thêm";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // txtAreaStatus
            // 
            this.txtAreaStatus.FormattingEnabled = true;
            this.txtAreaStatus.Location = new System.Drawing.Point(510, 80);
            this.txtAreaStatus.Name = "txtAreaStatus";
            this.txtAreaStatus.Size = new System.Drawing.Size(184, 21);
            this.txtAreaStatus.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái:";
            // 
            // txtAreaPrice
            // 
            this.txtAreaPrice.Location = new System.Drawing.Point(510, 30);
            this.txtAreaPrice.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtAreaPrice.Name = "txtAreaPrice";
            this.txtAreaPrice.Size = new System.Drawing.Size(184, 20);
            this.txtAreaPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá tiền:";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(130, 80);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(184, 20);
            this.txtAreaName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // txtAreaId
            // 
            this.txtAreaId.Location = new System.Drawing.Point(130, 30);
            this.txtAreaId.Name = "txtAreaId";
            this.txtAreaId.ReadOnly = true;
            this.txtAreaId.Size = new System.Drawing.Size(184, 20);
            this.txtAreaId.TabIndex = 2;
            this.txtAreaId.TextChanged += new System.EventHandler(this.txtAreaId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã:";
            // 
            // pArea
            // 
            this.pArea.Controls.Add(this.dgvArea);
            this.pArea.Location = new System.Drawing.Point(6, 185);
            this.pArea.Name = "pArea";
            this.pArea.Size = new System.Drawing.Size(1140, 320);
            this.pArea.TabIndex = 0;
            // 
            // dgvArea
            // 
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArea.Location = new System.Drawing.Point(0, 0);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.Size = new System.Drawing.Size(1140, 320);
            this.dgvArea.TabIndex = 1;
            this.dgvArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellContentClick);
            this.dgvArea.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArea_CellFormatting);
            // 
            // tHome
            // 
            this.tHome.Controls.Add(this.txtHomeDirection);
            this.tHome.Controls.Add(this.txtHomeStorey);
            this.tHome.Controls.Add(this.txtHomeAddress);
            this.tHome.Controls.Add(this.btnHomeUpdate);
            this.tHome.Controls.Add(this.btnHomeAdd);
            this.tHome.Controls.Add(this.txtHomeAreaId);
            this.tHome.Controls.Add(this.txtHomeStatus);
            this.tHome.Controls.Add(this.txtHomeResidentialArea);
            this.tHome.Controls.Add(this.label25);
            this.tHome.Controls.Add(this.label21);
            this.tHome.Controls.Add(this.label22);
            this.tHome.Controls.Add(this.label23);
            this.tHome.Controls.Add(this.label24);
            this.tHome.Controls.Add(this.label18);
            this.tHome.Controls.Add(this.txtHomeName);
            this.tHome.Controls.Add(this.label19);
            this.tHome.Controls.Add(this.txtHomeId);
            this.tHome.Controls.Add(this.label20);
            this.tHome.Controls.Add(this.pHome);
            this.tHome.Location = new System.Drawing.Point(4, 22);
            this.tHome.Name = "tHome";
            this.tHome.Padding = new System.Windows.Forms.Padding(3);
            this.tHome.Size = new System.Drawing.Size(1152, 511);
            this.tHome.TabIndex = 1;
            this.tHome.Text = "Nhà";
            this.tHome.UseVisualStyleBackColor = true;
            // 
            // txtHomeDirection
            // 
            this.txtHomeDirection.FormattingEnabled = true;
            this.txtHomeDirection.Location = new System.Drawing.Point(509, 79);
            this.txtHomeDirection.Name = "txtHomeDirection";
            this.txtHomeDirection.Size = new System.Drawing.Size(184, 21);
            this.txtHomeDirection.TabIndex = 69;
            // 
            // txtHomeStorey
            // 
            this.txtHomeStorey.Location = new System.Drawing.Point(509, 30);
            this.txtHomeStorey.Name = "txtHomeStorey";
            this.txtHomeStorey.Size = new System.Drawing.Size(184, 20);
            this.txtHomeStorey.TabIndex = 68;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(509, 130);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(184, 20);
            this.txtHomeAddress.TabIndex = 67;
            // 
            // btnHomeUpdate
            // 
            this.btnHomeUpdate.Location = new System.Drawing.Point(1046, 101);
            this.btnHomeUpdate.Name = "btnHomeUpdate";
            this.btnHomeUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnHomeUpdate.TabIndex = 65;
            this.btnHomeUpdate.Text = "Sửa";
            this.btnHomeUpdate.UseVisualStyleBackColor = true;
            this.btnHomeUpdate.Click += new System.EventHandler(this.btnHomeUpdate_Click);
            // 
            // btnHomeAdd
            // 
            this.btnHomeAdd.Location = new System.Drawing.Point(1046, 30);
            this.btnHomeAdd.Name = "btnHomeAdd";
            this.btnHomeAdd.Size = new System.Drawing.Size(100, 50);
            this.btnHomeAdd.TabIndex = 64;
            this.btnHomeAdd.Text = "Thêm";
            this.btnHomeAdd.UseVisualStyleBackColor = true;
            this.btnHomeAdd.Click += new System.EventHandler(this.btnHomeAdd_Click);
            // 
            // txtHomeAreaId
            // 
            this.txtHomeAreaId.FormattingEnabled = true;
            this.txtHomeAreaId.Location = new System.Drawing.Point(814, 80);
            this.txtHomeAreaId.Name = "txtHomeAreaId";
            this.txtHomeAreaId.Size = new System.Drawing.Size(184, 21);
            this.txtHomeAreaId.TabIndex = 63;
            // 
            // txtHomeStatus
            // 
            this.txtHomeStatus.FormattingEnabled = true;
            this.txtHomeStatus.Location = new System.Drawing.Point(814, 30);
            this.txtHomeStatus.Name = "txtHomeStatus";
            this.txtHomeStatus.Size = new System.Drawing.Size(184, 21);
            this.txtHomeStatus.TabIndex = 61;
            // 
            // txtHomeResidentialArea
            // 
            this.txtHomeResidentialArea.Location = new System.Drawing.Point(143, 130);
            this.txtHomeResidentialArea.Name = "txtHomeResidentialArea";
            this.txtHomeResidentialArea.Size = new System.Drawing.Size(184, 20);
            this.txtHomeResidentialArea.TabIndex = 60;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(731, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 16);
            this.label25.TabIndex = 58;
            this.label25.Text = "Trạng thái:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(731, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 16);
            this.label21.TabIndex = 55;
            this.label21.Text = "Khu vực:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(389, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 16);
            this.label22.TabIndex = 54;
            this.label22.Text = "Địa chỉ:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(389, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 16);
            this.label23.TabIndex = 52;
            this.label23.Text = "Hướng nhà:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(389, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 16);
            this.label24.TabIndex = 50;
            this.label24.Text = "Số tần nhà:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 46;
            this.label18.Text = "Diện tích:";
            // 
            // txtHomeName
            // 
            this.txtHomeName.Location = new System.Drawing.Point(143, 80);
            this.txtHomeName.Name = "txtHomeName";
            this.txtHomeName.Size = new System.Drawing.Size(184, 20);
            this.txtHomeName.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "Tên nhà:";
            // 
            // txtHomeId
            // 
            this.txtHomeId.Location = new System.Drawing.Point(143, 30);
            this.txtHomeId.Name = "txtHomeId";
            this.txtHomeId.ReadOnly = true;
            this.txtHomeId.Size = new System.Drawing.Size(184, 20);
            this.txtHomeId.TabIndex = 43;
            this.txtHomeId.TextChanged += new System.EventHandler(this.txtHomeId_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "Mã nhà:";
            // 
            // pHome
            // 
            this.pHome.Controls.Add(this.dgvHome);
            this.pHome.Location = new System.Drawing.Point(6, 185);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1140, 320);
            this.pHome.TabIndex = 1;
            // 
            // dgvHome
            // 
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHome.Location = new System.Drawing.Point(0, 0);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.Size = new System.Drawing.Size(1140, 320);
            this.dgvHome.TabIndex = 1;
            this.dgvHome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHome_CellContentClick);
            this.dgvHome.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHome_CellFormatting);
            // 
            // tCustomer
            // 
            this.tCustomer.Controls.Add(this.txtCustomerStatus);
            this.tCustomer.Controls.Add(this.txtCustomerBrithDay);
            this.tCustomer.Controls.Add(this.label15);
            this.tCustomer.Controls.Add(this.txtCustomerAddress);
            this.tCustomer.Controls.Add(this.label16);
            this.tCustomer.Controls.Add(this.txtCustomerPhone);
            this.tCustomer.Controls.Add(this.label14);
            this.tCustomer.Controls.Add(this.txtCustomerCMND);
            this.tCustomer.Controls.Add(this.label13);
            this.tCustomer.Controls.Add(this.label10);
            this.tCustomer.Controls.Add(this.txtCustomerName);
            this.tCustomer.Controls.Add(this.label11);
            this.tCustomer.Controls.Add(this.txtCustomerId);
            this.tCustomer.Controls.Add(this.label12);
            this.tCustomer.Controls.Add(this.btnCustomerUpdate);
            this.tCustomer.Controls.Add(this.btnCustomerAdd);
            this.tCustomer.Controls.Add(this.pCustomer);
            this.tCustomer.Location = new System.Drawing.Point(4, 22);
            this.tCustomer.Name = "tCustomer";
            this.tCustomer.Size = new System.Drawing.Size(1152, 511);
            this.tCustomer.TabIndex = 2;
            this.tCustomer.Text = "Khách hàng";
            this.tCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerStatus
            // 
            this.txtCustomerStatus.FormattingEnabled = true;
            this.txtCustomerStatus.Location = new System.Drawing.Point(798, 80);
            this.txtCustomerStatus.Name = "txtCustomerStatus";
            this.txtCustomerStatus.Size = new System.Drawing.Size(184, 21);
            this.txtCustomerStatus.TabIndex = 76;
            // 
            // txtCustomerBrithDay
            // 
            this.txtCustomerBrithDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCustomerBrithDay.Location = new System.Drawing.Point(143, 130);
            this.txtCustomerBrithDay.Name = "txtCustomerBrithDay";
            this.txtCustomerBrithDay.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerBrithDay.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(708, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 73;
            this.label15.Text = "Trạng thái:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(798, 30);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerAddress.TabIndex = 72;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(708, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 71;
            this.label16.Text = "Địa chỉ:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(496, 80);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerPhone.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(359, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 69;
            this.label14.Text = "Số điện thoại";
            // 
            // txtCustomerCMND
            // 
            this.txtCustomerCMND.Location = new System.Drawing.Point(496, 30);
            this.txtCustomerCMND.Name = "txtCustomerCMND";
            this.txtCustomerCMND.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerCMND.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(359, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 67;
            this.label13.Text = "CMND:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Ngày sinh:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(143, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerName.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Tên khách hàng:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(143, 30);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerId.TabIndex = 62;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Mã khách hàng:";
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(1046, 96);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnCustomerUpdate.TabIndex = 33;
            this.btnCustomerUpdate.Text = "Sửa";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(1046, 30);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(100, 50);
            this.btnCustomerAdd.TabIndex = 32;
            this.btnCustomerAdd.Text = "Thêm";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // pCustomer
            // 
            this.pCustomer.Controls.Add(this.dgvCustomer);
            this.pCustomer.Location = new System.Drawing.Point(6, 185);
            this.pCustomer.Name = "pCustomer";
            this.pCustomer.Size = new System.Drawing.Size(1140, 320);
            this.pCustomer.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(1140, 320);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCustomer_CellFormatting);
            // 
            // tAccount
            // 
            this.tAccount.Controls.Add(this.txtAccountPassword);
            this.tAccount.Controls.Add(this.label9);
            this.tAccount.Controls.Add(this.txtAccountUserName);
            this.tAccount.Controls.Add(this.btnAccountUpdate);
            this.tAccount.Controls.Add(this.btnAccountAdd);
            this.tAccount.Controls.Add(this.txtAccountStatus);
            this.tAccount.Controls.Add(this.label5);
            this.tAccount.Controls.Add(this.label6);
            this.tAccount.Controls.Add(this.txtAccountDisplayName);
            this.tAccount.Controls.Add(this.label7);
            this.tAccount.Controls.Add(this.txtAccountId);
            this.tAccount.Controls.Add(this.label8);
            this.tAccount.Controls.Add(this.pAccount);
            this.tAccount.Location = new System.Drawing.Point(4, 22);
            this.tAccount.Name = "tAccount";
            this.tAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tAccount.Size = new System.Drawing.Size(1152, 511);
            this.tAccount.TabIndex = 3;
            this.tAccount.Text = "Tài khoản";
            this.tAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(548, 82);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(184, 20);
            this.txtAccountPassword.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mật khẩu:";
            // 
            // txtAccountUserName
            // 
            this.txtAccountUserName.Location = new System.Drawing.Point(548, 31);
            this.txtAccountUserName.Name = "txtAccountUserName";
            this.txtAccountUserName.Size = new System.Drawing.Size(184, 20);
            this.txtAccountUserName.TabIndex = 22;
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.Location = new System.Drawing.Point(920, 20);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnAccountUpdate.TabIndex = 21;
            this.btnAccountUpdate.Text = "Sửa";
            this.btnAccountUpdate.UseVisualStyleBackColor = true;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(802, 21);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAccountAdd.TabIndex = 20;
            this.btnAccountAdd.Text = "Thêm";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // txtAccountStatus
            // 
            this.txtAccountStatus.FormattingEnabled = true;
            this.txtAccountStatus.Location = new System.Drawing.Point(548, 131);
            this.txtAccountStatus.Name = "txtAccountStatus";
            this.txtAccountStatus.Size = new System.Drawing.Size(184, 21);
            this.txtAccountStatus.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên đăng nhập:";
            // 
            // txtAccountDisplayName
            // 
            this.txtAccountDisplayName.Location = new System.Drawing.Point(168, 82);
            this.txtAccountDisplayName.Name = "txtAccountDisplayName";
            this.txtAccountDisplayName.Size = new System.Drawing.Size(184, 20);
            this.txtAccountDisplayName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên:";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(168, 32);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.ReadOnly = true;
            this.txtAccountId.Size = new System.Drawing.Size(184, 20);
            this.txtAccountId.TabIndex = 13;
            this.txtAccountId.TextChanged += new System.EventHandler(this.txtAccountId_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã:";
            // 
            // pAccount
            // 
            this.pAccount.Controls.Add(this.dgvAccount);
            this.pAccount.Location = new System.Drawing.Point(6, 185);
            this.pAccount.Name = "pAccount";
            this.pAccount.Size = new System.Drawing.Size(1140, 320);
            this.pAccount.TabIndex = 3;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(1140, 320);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            this.dgvAccount.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccount_CellFormatting);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.tMain.ResumeLayout(false);
            this.tArea.ResumeLayout(false);
            this.tArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaPrice)).EndInit();
            this.pArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.tHome.ResumeLayout(false);
            this.tHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeStorey)).EndInit();
            this.pHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            this.tCustomer.ResumeLayout(false);
            this.tCustomer.PerformLayout();
            this.pCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tAccount.ResumeLayout(false);
            this.tAccount.PerformLayout();
            this.pAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tMain;
        private System.Windows.Forms.TabPage tArea;
        private System.Windows.Forms.TabPage tHome;
        private System.Windows.Forms.TabPage tCustomer;
        private System.Windows.Forms.TabPage tAccount;
        private System.Windows.Forms.Panel pArea;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Panel pAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAreaId;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtAreaStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAreaPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateArea;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.ComboBox txtAccountStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountDisplayName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAccountUserName;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHomeName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHomeId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtHomeResidentialArea;
        private System.Windows.Forms.Button btnHomeUpdate;
        private System.Windows.Forms.Button btnHomeAdd;
        private System.Windows.Forms.ComboBox txtHomeAreaId;
        private System.Windows.Forms.ComboBox txtHomeStatus;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Panel pCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustomerCMND;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtHomeStorey;
        private System.Windows.Forms.ComboBox txtHomeDirection;
        private System.Windows.Forms.DateTimePicker txtCustomerBrithDay;
        private System.Windows.Forms.ComboBox txtCustomerStatus;
    }
}