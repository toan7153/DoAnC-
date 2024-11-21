using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System.Windows.Forms;
using System;
//ghdhjdghdgdghddgdgghdh
namespace QuanLyQuanCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Đăng ký sự kiện KeyDown cho các điều khiển
            this.KeyPreview = true; // Đảm bảo form nhận sự kiện phím trước các điều khiển khác
            this.KeyDown += FrmLogin_KeyDown; // Sự kiện KeyDown cho toàn bộ form
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím Enter được nhấn
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi phương thức xử lý nút đăng nhập
                btnLogin.PerformClick(); // Thực hiện click vào nút Đăng nhập
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);

                frmTableManager f = new frmTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
