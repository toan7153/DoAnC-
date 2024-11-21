using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class Taikhoan : Form
    {
        BindingSource accountList = new BindingSource();
       
        public Taikhoan()
        {
           
            InitializeComponent();
            loadAccountLisr();
            dgvAccount.DataSource = accountList;
            addAcountBinding();
            loadAccount();
           
        }


        void addAcountBinding()
        {
            txtUserName.DataBindings.Add("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            txtDisplayName.DataBindings.Add("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never);

            cbxType.DataBindings.Add("SelectedIndex", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Add("Text", dgvAccount.DataSource, "PassWord", true, DataSourceUpdateMode.Never);
        }


        void loadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getListAccount();
        }


        void loadAccountLisr()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            
            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"phuc"});
        }

        private void iBtnDSBxem_Click(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
        this.Close();
        }



        void addAccount(string userName, string displayName, int type, string password)
        {
            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AccountDAO.Instance.CheckAccountExists(userName))
            {
                MessageBox.Show("Tài khoản này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            type = cbxType.SelectedIndex; 

            // Thực hiện thêm tài khoản
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type, password))
            {
                MessageBox.Show("Thêm tài khoản thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            loadAccount();
        }



        void EditAccount(string userName, string displayName, int type, string password)
        {
            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            type = cbxType.SelectedIndex; 

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type, password))
            {
                MessageBox.Show("Cập nhập tài khoản thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhập tài khoản thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            loadAccount();
        }



        void DeleteAccount(string userName)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra nếu người dùng chọn "Có"
            if (result == DialogResult.Yes)
            {
                if (AccountDAO.Instance.DeleteAccount(userName))
                {
                    MessageBox.Show("Xoá tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá tài khoản thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                loadAccount();
            }
            else
            {
                MessageBox.Show("Hành động xóa đã bị hủy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void iBtnDSBthem_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = cbxType.SelectedIndex; // Lấy giá trị từ ComboBox (0 cho Employee, 1 cho Admin)
            string password = txtMatKhau.Text;

            addAccount(userName, displayName, type, password);
        }


        private void iBtnDSBxoa_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            DeleteAccount(userName);
        }

        private void iBtnDSBsua_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = cbxType.SelectedIndex; // Lấy giá trị từ ComboBox (0 cho Employee, 1 cho Admin)
            string password = txtMatKhau.Text;

            EditAccount(userName, displayName, type, password);
        }


        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string passWord = txtMatKhau.Text;
            string userName = txtUserName.Text;
        }   
    }
}
