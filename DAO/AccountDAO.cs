using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            // Câu lệnh SQL gọi thủ tục lưu trữ với tham số là userName và password
            string query = "USP_Login @userName, @password";

            // Thực thi câu lệnh và lấy kết quả về
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            // Kiểm tra nếu có ít nhất một dòng trong kết quả
            if (result.Rows.Count > 0)
            {
                // Lấy mật khẩu lưu trữ trong cơ sở dữ liệu (giả sử cột "Password" là nơi lưu trữ mật khẩu)
                string storedPassword = result.Rows[0]["Password"].ToString();

                // So sánh mật khẩu nhập vào với mật khẩu trong cơ sở dữ liệu (phân biệt chữ hoa chữ thường)
                if (string.Equals(passWord, storedPassword, StringComparison.Ordinal))
                {
                    return true;  // Đăng nhập thành công
                }
            }

            // Nếu không có dòng nào hoặc mật khẩu không khớp, trả về false
            return false;
        }


        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where userName = '" + userName + "'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public DataTable getListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("Select UserName, DisplayName, Type, Password from Account");
        }

        public bool CheckAccountExists(string userName)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE UserName = @userName";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
            return count > 0; // Nếu count > 0, tài khoản đã tồn tại
        }


        // them sua xoa
        public bool InsertAccount(string name, string displayName, int type, string password)
        {
            string query = string.Format("INSERT Account(UserName, DisplayName, Type, Password) VALUES (N'{0}', N'{1}', {2}, N'{3}')", name, displayName, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type,string password)
        {
            string query = string.Format("UPDATE Account SET DisplayName = N'{1}', Type = {2}, Password = N'{3}' WHERE UserName = N'{0}'", name, displayName, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            

            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    
    }
}
