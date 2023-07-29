using QuanLyNha.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNha
{
    public partial class fMain : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        public fMain()
        {
            InitializeComponent();
            LoadComboboxStatus(txtAreaStatus);
            LoadComboboxStatus(txtHomeStatus);
            LoadComboboxStatus(txtCustomerStatus);
            LoadComboboxStatus(txtAccountStatus);
            //LoadComboboxHomeStatus();
            LoadComboboxHomeDirection();
            LoadComboboxArea();
            LoadArea();
            LoadHome();
            LoadCustomer();
            LoadAccount();
        }
        private List<Select> GetSatus()
        {
            return new List<Select>()
            {
                new Select(){ Id = 1 , Name = "Đang hoạt động" },
                new Select(){ Id = 2, Name = "Ngừng hoạt động" }
            };
        }
        private List<Select> GetStatusHome()
        {
            return new List<Select>()
            {
                new Select(){ Id = 1 , Name = "Đã cho thuê" },
                new Select(){ Id = 2, Name = "Chưa cho thuê" }
            };
        }
        private List<Select> GetDirectionHome()
        {
            return new List<Select>()
            {
                new Select(){ Id = 0, Name = "Hướng Bắc" },
                new Select(){ Id = 1, Name = "Hướng Đông" },
                new Select(){ Id = 2, Name = "Hướng Nam" },
                new Select(){ Id = 3, Name = "Hướng Tây" },
                new Select(){ Id = 4, Name = "Hướng Đông Bắc" },
                new Select(){ Id = 5, Name = "Hướng Đông Nam" },
                new Select(){ Id = 6, Name = "Hướng Tây Bắc" },
                new Select(){ Id = 7, Name = "Hướng Tây Nam" },
            };
        }
        private void LoadArea()
        {
            var list = _dbContext.Areas.ToList();
            dgvArea.DataSource = list;
            dgvArea.Columns["Id"].HeaderText = "Mã";
            dgvArea.Columns["Name"].HeaderText = "Tên";
            dgvArea.Columns["Price"].HeaderText = "Giá";
            dgvArea.Columns["Status"].HeaderText = "Trạng thái";
            if (dgvArea.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvArea.Columns.Insert(4, btnDelete);
            }
            dgvArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingArea();
        }
        private void LoadHome()
        {
            var list = _dbContext.Homes.ToList();
            dgvHome.DataSource = list;
            dgvHome.Columns["Id"].HeaderText = "Mã";
            dgvHome.Columns["Name"].HeaderText = "Tên";
            dgvHome.Columns["ResidentialArea"].HeaderText = "Diện tích";
            dgvHome.Columns["Direction"].HeaderText = "Hướng nhà";
            dgvHome.Columns["Storey"].HeaderText = "Số tần";
            dgvHome.Columns["Address"].HeaderText = "Địa chỉ";
            dgvHome.Columns["Status"].HeaderText = "Trạng thái";
            dgvHome.Columns["StatusHome"].HeaderText = "Tình trạng";
            dgvHome.Columns["AreaId"].HeaderText = "Khu vực";
            dgvHome.Columns["Area"].Visible = false;
            if (dgvHome.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvHome.Columns.Insert(9, btnDelete);
            }
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingHome();
        }
        private void LoadCustomer()
        {
            var list = _dbContext.Customers.ToList();
            dgvCustomer.DataSource = list;
            dgvCustomer.Columns["Id"].HeaderText = "Mã";
            dgvCustomer.Columns["Name"].HeaderText = "Tên";
            dgvCustomer.Columns["BrithDay"].HeaderText = "Ngày sinh";
            dgvCustomer.Columns["CMND"].HeaderText = "CMND";
            dgvCustomer.Columns["Phone"].HeaderText = "Số điện thoại";
            dgvCustomer.Columns["Address"].HeaderText = "Địa chỉ";
            dgvCustomer.Columns["Status"].HeaderText = "Trạng thái";
            if (dgvCustomer.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvCustomer.Columns.Insert(7, btnDelete);
            }
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingCustomer();
        }
        private void LoadAccount()
        {
            var list = _dbContext.Accounts.ToList();
            dgvAccount.DataSource = list;
            dgvAccount.Columns["Id"].HeaderText = "Mã";
            dgvAccount.Columns["UserName"].HeaderText = "Tên đăng nhập";
            dgvAccount.Columns["Password"].HeaderText = "Mật khẩu";
            dgvAccount.Columns["DislayName"].HeaderText = "Tên hiển thị";
            if (dgvAccount.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvAccount.Columns.Insert(5, btnDelete);
            }
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingAccount();
        }
        private void BindingArea()
        {
            txtAreaId.DataBindings.Clear();
            txtAreaName.DataBindings.Clear();
            txtAreaPrice.DataBindings.Clear();

            txtAreaId.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtAreaName.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtAreaPrice.DataBindings.Add(new Binding("Value", dgvArea.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        private void BindingHome()
        {
            txtHomeId.DataBindings.Clear();
            txtHomeName.DataBindings.Clear();
            txtHomeResidentialArea.DataBindings.Clear();
            txtHomeStorey.DataBindings.Clear();
            txtHomeAddress.DataBindings.Clear();

            txtHomeId.DataBindings.Add(new Binding("Text", dgvHome.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtHomeName.DataBindings.Add(new Binding("Text", dgvHome.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtHomeResidentialArea.DataBindings.Add(new Binding("Text", dgvHome.DataSource, "ResidentialArea", true, DataSourceUpdateMode.Never));
            txtHomeStorey.DataBindings.Add(new Binding("Value", dgvHome.DataSource, "Storey", true, DataSourceUpdateMode.Never));
            txtHomeAddress.DataBindings.Add(new Binding("Text", dgvHome.DataSource, "Address", true, DataSourceUpdateMode.Never));
        }
        private void BindingCustomer()
        {
            txtCustomerId.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtCustomerBrithDay.DataBindings.Clear();
            txtCustomerCMND.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerAddress.DataBindings.Clear();

            txtCustomerId.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtCustomerName.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtCustomerBrithDay.DataBindings.Add(new Binding("Value", dgvCustomer.DataSource, "BrithDay", true, DataSourceUpdateMode.Never));
            txtCustomerCMND.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtCustomerPhone.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            txtCustomerAddress.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Address", true, DataSourceUpdateMode.Never));
        }
        private void BindingAccount()
        {
            txtAccountId.DataBindings.Clear();
            txtAccountUserName.DataBindings.Clear();
            txtAccountPassword.DataBindings.Clear();
            txtAccountDisplayName.DataBindings.Clear();

            txtAccountId.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtAccountUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtAccountPassword.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
            txtAccountDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DislayName", true, DataSourceUpdateMode.Never));
        }
        private void LoadComboboxStatus(ComboBox comboBox)
        {
            comboBox.DataSource = GetSatus();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
        //private void LoadComboboxHomeStatus()
        //{
        //    txtHomeStatusHome.DataSource = GetStatusHome();
        //    txtHomeStatusHome.DisplayMember = "Name";
        //    txtHomeStatusHome.ValueMember = "Id";
        //}
        private void LoadComboboxHomeDirection()
        {
            txtHomeDirection.DataSource = GetDirectionHome();
            txtHomeDirection.DisplayMember = "Name";
            txtHomeDirection.ValueMember = "Id";
        }
        private void LoadComboboxArea()
        {
            var list = _dbContext.Areas.ToList();
            txtHomeAreaId.DataSource = list;
            txtHomeAreaId.DisplayMember = "Name";
            txtHomeAreaId.ValueMember = "Id";
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            var name = txtAreaName.Text;
            var price = txtAreaPrice.Value;
            var status = (Status)txtAreaStatus.SelectedValue;
            _dbContext.Areas.Add(new Area() { Name = name, Price = price, Status = status });
            _dbContext.SaveChanges();
            MessageBox.Show("Thêm thành công khu vực !", "Thông báo", MessageBoxButtons.OK);
            LoadArea();
            LoadComboboxArea();
        }

        private void btnUpdateArea_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtAreaId.Text);
            var name = txtAreaName.Text;
            var price = txtAreaPrice.Value;
            var status = (Status)txtAreaStatus.SelectedValue;

            var model = _dbContext.Areas.FirstOrDefault(f => f.Id == id);
            model.Name = name;
            model.Price = price;
            model.Status = status;

            _dbContext.SaveChanges();
            MessageBox.Show("Cập nhật thành công khu vực !", "Thông báo", MessageBoxButtons.OK);
            LoadArea();
            LoadComboboxArea();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            var userName = txtAccountUserName.Text;
            var password = txtAccountPassword.Text;
            var displayName = txtAccountDisplayName.Text;
            var status = (Status)txtAccountStatus.SelectedValue;
            _dbContext.Accounts.Add(new Account() { UserName = userName, Password = password, DislayName = displayName, Status = status });
            _dbContext.SaveChanges();
            MessageBox.Show("Thêm thành công nhân viên!", "Thông báo", MessageBoxButtons.OK);
            LoadAccount();
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtAccountId.Text);
            var userName = txtAccountUserName.Text;
            var password = txtAccountPassword.Text;
            var displayName = txtAccountDisplayName.Text;
            var status = (Status)txtAccountStatus.SelectedValue;

            var accountModel = _dbContext.Accounts.FirstOrDefault(f => f.Id == id);
            accountModel.UserName = userName;
            accountModel.Password = password;
            accountModel.DislayName = displayName;
            accountModel.Status = status;

            _dbContext.SaveChanges();
            MessageBox.Show("Cập nhật thành công tài khoản!", "Thông báo", MessageBoxButtons.OK);
            LoadAccount();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            var name = txtCustomerName.Text;
            var brithDay = txtCustomerBrithDay.Value;
            var cmnd = txtCustomerCMND.Text;
            var phone = txtCustomerPhone.Text;
            var address = txtCustomerAddress.Text;
            var status = (Status)txtCustomerStatus.SelectedValue;

            _dbContext.Customers.Add(new Customer() { Name = name, BrithDay = brithDay, CMND = cmnd, Phone = phone, Address = address, Status = status });
            _dbContext.SaveChanges();
            MessageBox.Show("Thêm thành công khách hàng!", "Thông báo", MessageBoxButtons.OK);
            LoadCustomer();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtCustomerId.Text);
            var name = txtCustomerName.Text;
            var brithDay = txtCustomerBrithDay.Value;
            var cmnd = txtCustomerCMND.Text;
            var phone = txtCustomerPhone.Text;
            var address = txtCustomerAddress.Text;
            var status = (Status)txtCustomerStatus.SelectedValue;

            var customerModel = _dbContext.Customers.FirstOrDefault(f => f.Id == id);
            customerModel.Name = name;
            customerModel.BrithDay = brithDay;
            customerModel.CMND = cmnd;
            customerModel.Phone = phone;
            customerModel.Address = address;
            customerModel.Status = status;

            _dbContext.SaveChanges();
            MessageBox.Show("Cập nhật thành công kháchh hàng!", "Thông báo", MessageBoxButtons.OK);
            LoadCustomer();
        }

        private void btnHomeAdd_Click(object sender, EventArgs e)
        {
            var name = txtHomeName.Text;
            var residentialArea = txtHomeResidentialArea.Text;
            var direction = (Direction)txtHomeDirection.SelectedValue;
            var storey = int.Parse(txtHomeStorey.Value.ToString());
            var address = txtHomeAddress.Text;
            var status = (Status)txtHomeStatus.SelectedValue;
            var statusHome = StatusHome.DeActive;
            var areaId = (int)txtHomeAreaId.SelectedValue;

            _dbContext.Homes.Add(new Home() { Name = name, ResidentialArea = residentialArea, Direction = direction, Storey = storey, Address = address, Status = status, StatusHome = statusHome, AreaId = areaId });
            _dbContext.SaveChanges();
            MessageBox.Show("Thêm thành công nhà thuê!", "Thông báo", MessageBoxButtons.OK);
            LoadHome();
        }

        private void btnHomeUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtHomeId.Text);
            var name = txtHomeName.Text;
            var residentialArea = txtHomeResidentialArea.Text;
            var direction = (Direction)txtHomeDirection.SelectedValue;
            var storey = int.Parse(txtHomeStorey.Value.ToString());
            var address = txtHomeAddress.Text;
            var status = (Status)txtHomeStatus.SelectedValue;
            var statusHome = StatusHome.DeActive;
            var areaId = (int)txtHomeAreaId.SelectedValue;

            var homeModel = _dbContext.Homes.FirstOrDefault(f => f.Id == id);
            homeModel.Name = name;
            homeModel.ResidentialArea = residentialArea;
            homeModel.Direction = direction;
            homeModel.Storey = storey;
            homeModel.Address = address;
            homeModel.Status = status;
            homeModel.StatusHome = statusHome;
            homeModel.AreaId = areaId;

            _dbContext.SaveChanges();
            MessageBox.Show("Cập nhật thành công nhà thuê!", "Thông báo", MessageBoxButtons.OK);
            LoadHome();
        }

        private void txtAreaId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArea.SelectedCells.Count > 0)
                {
                    int id = (int)dgvArea.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    txtAreaStatus.SelectedIndex = index;
                }
            }
            catch (Exception exception) { }
        }

        private void txtHomeId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvHome.SelectedCells.Count > 0)
                {
                    int id = (int)dgvHome.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    txtHomeStatus.SelectedIndex = index;

                    var idHomeDirection = (int)dgvHome.SelectedCells[0].OwningRow.Cells["Direction"].Value;
                    var indexHomeDirection = GetDirectionHome().FindIndex(x => x.Id == idHomeDirection);
                    txtHomeDirection.SelectedIndex = indexHomeDirection;

                    var areaId = (int)dgvHome.SelectedCells[0].OwningRow.Cells["AreaId"].Value;
                    var areaIndex = _dbContext.Areas.ToList().FindIndex(f => f.Id == areaId);
                    txtHomeAreaId.SelectedIndex = areaIndex;
                }
            }
            catch (Exception exception) { }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomer.SelectedCells.Count > 0)
                {
                    int id = (int)dgvCustomer.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    txtCustomerStatus.SelectedIndex = index;
                }
            }
            catch (Exception exception) { }
        }

        private void txtAccountId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccount.SelectedCells.Count > 0)
                {
                    int id = (int)dgvAccount.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    txtAccountStatus.SelectedIndex = index;
                }
            }
            catch (Exception exception) { }
        }

        private void dgvArea_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvArea.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }

        private void dgvHome_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHome.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
            if (dgvHome.Columns[e.ColumnIndex].Name == "StatusHome")
            {
                var enumdata = (StatusHome)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
            if (dgvHome.Columns[e.ColumnIndex].Name == "Direction")
            {
                var enumdata = (Direction)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
            if (dgvHome.Columns[e.ColumnIndex].Name == "AreaId")
            {
                var id = (int)e.Value;
                e.Value = _dbContext.Areas.FirstOrDefault(f => f.Id == id).Name;
            }
        }

        private void dgvCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCustomer.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }

        private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dgvArea.DataSource as List<Area>)[e.RowIndex];
            if (dgvArea.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                _dbContext.Areas.Remove(data);
                _dbContext.SaveChanges();
                MessageBox.Show("Xóa thành công khu vực!", "Thông báo", MessageBoxButtons.OK);
                LoadArea();
            }
        }

        private void dgvHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dgvHome.DataSource as List<Home>)[e.RowIndex];
            if (dgvHome.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                _dbContext.Homes.Remove(data);
                _dbContext.SaveChanges();
                MessageBox.Show("Xóa thành công nhà cho thuê!", "Thông báo", MessageBoxButtons.OK);
                LoadHome();
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dgvCustomer.DataSource as List<Customer>)[e.RowIndex];
            if (dgvCustomer.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                _dbContext.Customers.Remove(data);
                _dbContext.SaveChanges();
                MessageBox.Show("Xóa thành công khách hàng!", "Thông báo", MessageBoxButtons.OK);
                LoadCustomer();
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dgvAccount.DataSource as List<Account>)[e.RowIndex];
            if (dgvAccount.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                _dbContext.Accounts.Remove(data);
                _dbContext.SaveChanges();
                MessageBox.Show("Xóa thành công tài khoản!", "Thông báo", MessageBoxButtons.OK);
                LoadAccount();
            }
        }

        private void tMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAccountId_TextChanged(txtAccountId, EventArgs.Empty);
            txtHomeId_TextChanged(txtHomeId, EventArgs.Empty);
            txtCustomerId_TextChanged(txtCustomerId, EventArgs.Empty);
            txtAreaId_TextChanged(txtAreaId, EventArgs.Empty);
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            var fManager = new fManager();
            fManager.ShowDialog();
        }
    }
}
