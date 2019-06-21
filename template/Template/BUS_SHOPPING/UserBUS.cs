using DAL_PROJECT;
using DTL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUS_PROJECT
{
    public class UserBUS
    {
        public bool Login(TextBox user, TextBox pass)
        {
            User u = UserDAL.Login(user.Text, pass.Text);
            if (u != null)
            {
                MessageBox.Show("Đăng nhập thành công. Chào bạn đến với chương trình", "Chào mừng đến với chương trình", MessageBoxButtons.OK);
                return true;
            } 
            else
            {
                MessageBox.Show("Bạn nhập sai tên truy cập hoặc mật khẩu. Xin vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
