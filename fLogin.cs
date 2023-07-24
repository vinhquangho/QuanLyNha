using QuanLyNha.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNha
{
    public partial class fLogin : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        public fLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_dbContext.Accounts.Any(f => f.UserName == txbUserName.Text && f.Password == txbPassWord.Text) == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                return;
            }
            var account = _dbContext.Accounts.FirstOrDefault(f => f.UserName == txbUserName.Text && f.Password == txbPassWord.Text);
            Global.AccountId = account.Id;
            this.Hide();
            var fmain = new fMain();
            fmain.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
