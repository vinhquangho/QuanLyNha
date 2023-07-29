using QuanLyNha.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNha
{
    public partial class fManager : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        private CultureInfo culture = new CultureInfo("vi-VN");
        private int? HomeId = null;
        public fManager()
        {
            InitializeComponent();
            LoadComboboxHomeStatus();
            LoadComboboxHomeDirection();
            LoadComboboxCustomer();
            LoadArea();
            LoadTable(string.Empty, null, null, null, null);
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
        private void LoadComboboxHomeStatus()
        {
            cbbStatusHome.DataSource = GetStatusHome();
            cbbStatusHome.DisplayMember = "Name";
            cbbStatusHome.ValueMember = "Id";
        }
        private void LoadComboboxHomeDirection()
        {
            cbbDirection.DataSource = GetDirectionHome();
            cbbDirection.DisplayMember = "Name";
            cbbDirection.ValueMember = "Id";
        }
        private void LoadComboboxCustomer()
        {
            var list = _dbContext.Customers.Where(f => f.Status == Status.Active).ToList();
            cbbCustomer.DataSource = list;
            cbbCustomer.DisplayMember = "Name";
            cbbCustomer.ValueMember = "Id";
        }
        private void LoadArea()
        {
            var list = _dbContext.Areas.Where(f => f.Status == Status.Active).ToList();
            cbbAreaId.DataSource = list;
            cbbAreaId.DisplayMember = "Name";
            cbbAreaId.ValueMember = "Id";
        }
        private void LoadTable(string search, decimal? price, Direction? direction, StatusHome? statusHome, int? areaId)
        {
            tMain.Controls.Clear();
            listViewInfo.Items.Clear();
            _dbContext = new AppDbContext();

            var listArea = _dbContext.Areas.Where(f => f.Status == Status.Active).ToList();
            if (price.HasValue)
                listArea = listArea.Where(f => f.Price == price.Value).ToList();

            var areas = listArea;
            foreach (var area in areas)
            {
                var tabPanel = new TabPage() { Name = $@"tab-${area.Id}", Text = area.Name, Width = 600, Height = 400 };
                var flowLayoutControl = new FlowLayoutPanel() { Name = $@"fp-${area.Id}", Height = 525, Width = 525 };
                tabPanel.Controls.Add(flowLayoutControl);

                var listHome = _dbContext.Homes.Where(f => f.AreaId == area.Id).Where(f => f.Status == Status.Active).ToList();
                if (!string.IsNullOrEmpty(search))
                    listHome = listHome.Where(f => f.Name.ToLower().Contains(search.ToLower()) || f.ResidentialArea.ToLower().Contains(search.ToLower()) || f.Address.ToLower().Contains(search.ToLower())).ToList();
                if (direction.HasValue)
                    listHome = listHome.Where(f => f.Direction == direction.Value).ToList();
                if (statusHome.HasValue)
                    listHome = listHome.Where(f => f.StatusHome == statusHome).ToList();
                if (areaId.HasValue)
                    listHome = listHome.Where(f => f.AreaId == areaId.Value).ToList();

                var homes = listHome;
                foreach (var t in homes)
                {
                    var btn = new Button() { Name = $"btn-${t.Id}", Text = t.Name, Width = 120, Height = 50, TextAlign = ContentAlignment.MiddleCenter, Tag = t.Id };
                    btn.Click += btnHome_Click;
                    var tableExsitBill = _dbContext.Contracts.Any(b => b.HomeId == t.Id && b.Status == Status.Active);
                    if (tableExsitBill)
                    {
                        btn.BackColor = Color.GreenYellow;
                    }
                    flowLayoutControl.Controls.Add(btn);
                    if (HomeId.HasValue && t.Id == HomeId.Value)
                    {
                        btn.PerformClick();
                    }
                }
                tMain.Controls.Add(tabPanel);
            }
        }
        private void ReloadTable()
        {
            foreach (Control t in tMain.Controls)
            {
                foreach (Control p in t.Controls)
                {
                    foreach (Control b in p.Controls)
                    {
                        b.BackColor = Color.FromArgb(255, 240, 240, 240);
                        b.ForeColor = Color.Black;

                        var tableExsitBill = _dbContext.Contracts.Any(f => f.HomeId == (int)b.Tag && f.Status == Status.Active);
                        if (tableExsitBill)
                        {
                            b.BackColor = Color.GreenYellow;
                        }
                        if (HomeId.HasValue && HomeId.Value == (int)b.Tag)
                        {
                            var button = (Button)b;
                            button.PerformClick();
                        }
                    }
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Control t in tMain.Controls)
            {
                foreach (Control p in t.Controls)
                {
                    foreach (Control b in p.Controls)
                    {
                        b.BackColor = Color.FromArgb(255, 240, 240, 240);
                        b.ForeColor = Color.Black;

                        var tableExsitBill = _dbContext.Contracts.Any(f => f.HomeId == (int)b.Tag && f.Status == Status.Active);
                        if (tableExsitBill)
                        {
                            b.BackColor = Color.GreenYellow;
                        }
                    }
                }
            }
            var btn = (Button)sender;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            HomeId = (int)btn.Tag;
            listViewInfo.Items.Clear();

            var infoContact = _dbContext.Contracts.Include("Customer").Include("Home").FirstOrDefault(f => f.HomeId == HomeId.Value && f.Home.Status == Status.Active && f.Status == Status.Active);
            if (infoContact != null)
            {
                var area = _dbContext.Areas.FirstOrDefault(f => f.Id == infoContact.Home.AreaId);
                var payment = _dbContext.Payments.Count(f => f.ContactId == infoContact.Id);
                var listview0 = new ListViewItem("Thông tin nhà cho thuê:");
                var listView1 = new ListViewItem(new string[] { $"Tên nhà: {infoContact.Home.Name}" });
                var listView2 = new ListViewItem(new string[] { $"Diện tích: {infoContact.Home.ResidentialArea}" });
                var listView3 = new ListViewItem(new string[] { $"Hướng nhà: {EnumExtensions.GetDisplayName(infoContact.Home.Direction)}" });
                var listView4 = new ListViewItem(new string[] { $"Số tần: {infoContact.Home.Storey}", });
                var listView5 = new ListViewItem(new string[] { $"Địa chỉ: {infoContact.Home.Address}", });
                var listView6 = new ListViewItem(new string[] { $"Khu vực: {area.Name}" });
                var listView7 = new ListViewItem(new string[] { $"Số tiền cho thuê: {area.Price.ToString("c", culture)}" });
                var listView8 = new ListViewItem(new string[] { $"Số lần thu tiền: {payment}" });
                var listview8v5 = new ListViewItem("--------------------------------------------------------------------------------------------------");
                var listview9 = new ListViewItem("Thông tin khách hàng:");
                var listView10 = new ListViewItem(new string[] { $"Tên khách hàng: {infoContact.Customer.Name}" });
                var listView11 = new ListViewItem(new string[] { $"Ngày sinh: {infoContact.Customer.BrithDay.ToString("dd/MM/yyyy")}" });
                var listView12 = new ListViewItem(new string[] { $"CMND: {infoContact.Customer.CMND}" });
                var listView13 = new ListViewItem(new string[] { $"Số điện thoại: {infoContact.Customer.Phone}" });
                var listView14 = new ListViewItem(new string[] { $"Địa chỉ: {infoContact.Customer.Address}" });
                listViewInfo.Items.AddRange(new ListViewItem[] { listview0, listView1, listView2, listView3, listView4, listView5, listView6, listView7, listView8, listview8v5, listview9, listView10, listView11, listView12, listView13, listView14 });
            }
            else
            {
                var home = _dbContext.Homes.Include("Area").FirstOrDefault(f => f.Id == HomeId.Value);
                var listview0 = new ListViewItem("Thông tin nhà cho thuê");
                var listView1 = new ListViewItem(new string[] { $"Tên nhà: {home.Name}" });
                var listView2 = new ListViewItem(new string[] { $"Diện tích: {home.ResidentialArea}" });
                var listView3 = new ListViewItem(new string[] { $"Hướng nhà: {EnumExtensions.GetDisplayName(home.Direction)}" });
                var listView4 = new ListViewItem(new string[] { $"Số tần: {home.Storey}" });
                var listView5 = new ListViewItem(new string[] { $"Địa chỉ: {home.Address}" });
                var listView6 = new ListViewItem(new string[] { $"Khu vực: {home.Area.Name}" });
                var listView7 = new ListViewItem(new string[] { $"Số tiền cho thuê {home.Area.Price.ToString("c", culture)}" });
                var listView8 = new ListViewItem(new string[] { $"Số lần thu tiền: 0" });
                listViewInfo.Items.AddRange(new ListViewItem[] { listview0, listView1, listView2, listView3, listView4, listView5, listView6, listView7, listView8 });
            }
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fmain = new fMain();
            fmain.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (HomeId.HasValue)
                {
                    var home = _dbContext.Homes.FirstOrDefault(f => f.Id == HomeId.Value);
                    if (home.StatusHome == StatusHome.DeActive)
                    {
                        home.StatusHome = StatusHome.Active;

                        var customer = (int)cbbCustomer.SelectedValue;
                        var contact = new Contract() { AccountId = Global.AccountId, HomeId = home.Id, CustomerId = customer, Status = Status.Active };
                        _dbContext.Contracts.Add(contact);
                        _dbContext.SaveChanges();
                        MessageBox.Show("Tạo thành công hợp đồng cho thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nhà bạn đang chọn đã được cho thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ReloadTable();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhà cho thuê cần thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (HomeId.HasValue)
                {
                    var home = _dbContext.Homes.FirstOrDefault(f => f.Id == HomeId.Value);
                    if (home.StatusHome == StatusHome.Active)
                    {
                        var infoContact = _dbContext.Contracts.Include("Customer").Include("Home").FirstOrDefault(f => f.HomeId == HomeId.Value && f.Home.StatusHome == StatusHome.Active && f.Status == Status.Active);
                        infoContact.Status = Status.DeActive;
                        home.StatusHome = StatusHome.DeActive;
                        _dbContext.SaveChanges();
                        MessageBox.Show("Xóa thành công hợp đồng cho thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nhà bạn đang chọn chưa được cho thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ReloadTable();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhà cho thuê cần thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { }
        }

        private void btnCreatePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (HomeId.HasValue)
                {
                    var home = _dbContext.Homes.FirstOrDefault(f => f.Id == HomeId.Value);
                    if (home.StatusHome == StatusHome.Active)
                    {
                        var infoContact = _dbContext.Contracts.Include("Customer").Include("Home").FirstOrDefault(f => f.HomeId == HomeId.Value && f.Home.StatusHome == StatusHome.Active && f.Status == Status.Active);
                        var area = _dbContext.Areas.FirstOrDefault(f => f.Id == infoContact.Home.AreaId);

                        _dbContext.Payments.Add(new Payment() { Price = area.Price, CreationTime = DateTime.Now, ContactId = infoContact.Id, AccountId = Global.AccountId });
                        _dbContext.SaveChanges();

                        MessageBox.Show("Thanh toán thành công hợp đồng cho thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nhà bạn đang chọn chưa được cho thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ReloadTable();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhà cho thuê cần thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                var freport = new fReport();
                var listReport = new List<Report>();

                var list = _dbContext.Payments.Include("Account").ToList();
                foreach (var item in list)
                {
                    var contract = _dbContext.Contracts.Include("Customer").Include("Home").FirstOrDefault(f => f.Id == item.ContactId);
                    var dto = new Report()
                    {
                        Account = item.Account.DislayName,
                        Area = contract.Home.Area.Name,
                        Home = contract.Home.Name,
                        Customer = contract.Customer.Name,
                        Date = item.CreationTime.ToString("dd/MM/yyyy HH:mm"),
                        Price = item.Price.ToString("c", culture)
                    };
                    listReport.Add(dto);
                }
                
                CrystalReport report = new CrystalReport();
                report.SetDataSource(listReport);

                freport.crystalReportViewer.ReportSource = report;
                freport.ShowDialog();
            }
            catch (Exception ex) { }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTable(txtSearch.Text, txtPrice.Value, (Direction)cbbDirection.SelectedValue, (StatusHome)cbbStatusHome.SelectedValue, (int)cbbAreaId.SelectedValue);
            }
            catch (Exception ex) { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTable(string.Empty, null, null, null, null);
            }
            catch (Exception ex) { }
        }
    }
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
