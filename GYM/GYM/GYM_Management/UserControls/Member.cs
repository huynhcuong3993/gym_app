using GYM.Member;
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

namespace GYM.UserControls
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
            Update up1 = new Update();
            addUserControl(up1);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        // đưa thông tin vào datagridview
        private void Button_Click(object sender, EventArgs e)
        {
            
        }

        private void txtmaHD_TextChanged(object sender, EventArgs e)
        {
            
        }
        // tìm sản phẩm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        // load dữ liệu
        private void home_Load(object sender, EventArgs e)
        {
            
        }
        // tính tổng tiền
        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            
        }
        // click đẻ hủy thực đơn
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSothutu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel_sp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            addUserControl(up);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Ds danhsach = new Ds();
            addUserControl(danhsach);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Giahan gh = new Giahan();
            addUserControl(gh);
        }
    }
}
