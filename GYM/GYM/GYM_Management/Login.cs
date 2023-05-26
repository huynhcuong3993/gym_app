using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CrystalDecisions.Windows.Forms;

namespace GYM
{
    public partial class Login : Form
    {
        DataModel dm;
        public Login()
        {
            InitializeComponent();
            LoadDataModel();
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashed = Util.SaltedHash(txtPassword.Text);
            //MessageBox.Show(hashed+" "+ txtUsername.Text);
            List<Dictionary<string, string>> rows = dm.FetchAllRowUr();
            foreach (Dictionary<string, string> row in rows)
            {
                if (row["Username"] == txtUsername.Text)
                {
                    if (row["Pass"] == hashed)
                    {
                        if (row["Role"] == "Quản lý")
                        {
                            if(comeBox.Text == "Quản lý")
                            {
                                dm.AddDateWorked(row["E_ID"]);
                                MessageBox.Show("Đăng nhập thành công");
                                this.Hide();
                                Main ma = new Main();
                                ma.ShowDialog();
                                break;
                            }
                            else MessageBox.Show("Role không phù hợp");
                        }
                    }
                    else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
                }
                else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void Showpd_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpd.Checked == false)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
