using Guna.UI.WinForms;
using GYM.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GYM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void gunaButton1_Click(object sender, EventArgs e)
        {
            panel2.Height = btnHv.Height;
            panel2.Top = btnHv.Top;
            UserControls.home uc = new UserControls.home();
            addUserControl(uc);
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            panel2.Height = btnHt.Height;
            panel2.Top = btnHt.Top;
            UserControls.Employee ac = new UserControls.Employee();
            addUserControl(ac);
        }

        public void gunaButton3_Click(object sender, EventArgs e)
        {
            panel2.Height = btnHd.Height;
            panel2.Top = btnHd.Top;
            UserControls.Hoa_don hd = new UserControls.Hoa_don();
            addUserControl(hd);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            panel2.Height = btnTk.Height;
            panel2.Top = btnTk.Top;
            Thongke tk = new Thongke();
            addUserControl(tk);
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                gunaButton3.Image = global::GYM.Properties.Resources.icons8_resize_64;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                gunaButton3.Image = global::GYM.Properties.Resources.icons8_resize_64__1_;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
