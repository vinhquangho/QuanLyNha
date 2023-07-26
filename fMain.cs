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
            LoadComboboxHomeStatus();
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
        private void LoadArea()
        {
            BindingArea();
        }
        private void LoadHome()
        {
            BindingHome();
        }
        private void LoadCustomer()
        {
            BindingCustomer();
        }
        private void LoadAccount()
        {
            BindingAccount();
        }
        private void BindingArea()
        {

        }
        private void BindingHome()
        {

        }
        private void BindingCustomer()
        {

        }
        private void BindingAccount()
        {

        }
        private void LoadComboboxStatus(ComboBox comboBox)
        {
            comboBox.DataSource = GetSatus();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
        private void LoadComboboxHomeStatus()
        {
            txtHomeStatusHome.DataSource = GetStatusHome();
            txtHomeStatusHome.DisplayMember = "Name";
            txtHomeStatusHome.ValueMember = "Id";
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

        }

        private void btnUpdateArea_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeUpdate_Click(object sender, EventArgs e)
        {

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
            if (dgvArea.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                _dbContext.Homes.Remove(data);
                _dbContext.SaveChanges();
                MessageBox.Show("Xóa thành công nhà cho thuê!", "Thông báo", MessageBoxButtons.OK);
                LoadArea();
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
