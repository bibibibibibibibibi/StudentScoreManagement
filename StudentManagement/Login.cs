using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using StudentManagement.BS_Layer;

namespace StudentManagement
{
    public partial class Login : Form
    {
        BS_DangNhap loginService = new BS_DangNhap();
        private bool login;

        public bool LoginStatus { get => login; }

        public Login()
        {
            InitializeComponent();

            login = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = loginService.AuthenticateUser(txtUsername.Text, txtPassword.Text);
            if (role != null)
            {
                MessageBox.Show("Login successful! Role: " + role);

                // Điều hướng người dùng dựa trên role
                if (role == "AdminRole")
                {
                    // Mở form cho Admin
                    Main adminForm = new Main();
                    adminForm.Show();
                }
                else if (role == "GiangVienRole")
                {
                    // Mở form cho Giảng viên
                    GiangViennForm giangVienForm = new GiangViennForm();
                    giangVienForm.Show();
                }
                else if (role == "HocSinhRole")
                {
                    // Mở form cho Học sinh
                    HocsinhForm hocSinhForm = new HocsinhForm();
                    hocSinhForm.Show();
                }

                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
