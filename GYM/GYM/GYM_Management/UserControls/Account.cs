using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYM.UserControls
{
    public partial class Account : UserControl
    {
        DataModel dm;
        public Account()
        {
            InitializeComponent();
            LoadDataModel();
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        public void ResetForm()
        {
            datagridView_NV.Rows.Clear();
            datagridView_AC.Rows.Clear();
            dm = new DataModel();
        }

        private void LoadStaffData()
        {
            
            List<Dictionary<string, string>> rows = dm.FetchAllRow();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = datagridView_NV.Rows.Add();
                datagridView_NV.Rows[index].Cells[0].Value = row["E_ID"];
                datagridView_NV.Rows[index].Cells[1].Value = row["Name"];
                datagridView_NV.Rows[index].Cells[2].Value = row["Gender"];
                datagridView_NV.Rows[index].Cells[3].Value = row["Dob"];
                datagridView_NV.Rows[index].Cells[4].Value = row["Address"];
                datagridView_NV.Rows[index].Cells[5].Value = row["Phone"];
                datagridView_NV.Rows[index].Cells[7].Value = row["Role"];
                datagridView_NV.Rows[index].Cells[9].Value = row["IDS"];

                int index2 = datagridView_AC.Rows.Add();
                datagridView_AC.Rows[index2].Cells[0].Value = row["E_ID"];
                datagridView_AC.Rows[index2].Cells[1].Value = row["Role"];
                datagridView_AC.Rows[index2].Cells[2].Value = row["Username"];
                datagridView_AC.Rows[index2].Cells[3].Value = row["Pass"];
            }
        }

        private void Initialize()
        {
            datagridView_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //txt_idNV.Enabled = false;
            //txt_nameNV.Enabled = false;
            //comBox_Gender.Enabled = false;
            //dateTime_NV.Enabled = false;
            //txt_Email.Enabled = false;
            //txt_Phone.Enabled = false;
            //comBox_Role.Enabled = false;
            //txt_Username.Enabled = false;
            //txt_PassWord.Enabled = false;
            txt_Degrees.Enabled = false;
            txt_CCCD.Enabled = false;
            //combox_Shift.Enabled = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Your code to run on load goes here 
            Initialize();
            LoadStaffData();
            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string dob = dateTime_NV.Value.ToString("yyyy-MM-dd HH:mm:ss");
            if (!dm.AddNewRow(txt_idNV.Text, combox_Shift.SelectedValue.ToString(), txt_nameNV.Text, txt_Email.Text, txt_Phone.Text, dob, comBox_Gender.Text, txt_Username.Text, txt_PassWord.Text, comBox_Role.Text))
            {
                MessageBox.Show("Failed"); 
            }
            ResetForm();
            LoadStaffData();
        }
        private void comBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void LoadDataNV()
        {
            
        }
        private void LoadDataAC()
        {

        }

        private void txt_idNV_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string searchValue = txt_FindNV.Text.ToLower();
            datagridView_NV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in datagridView_NV.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            if (row.Cells[i].Value.ToString().ToLower().Equals(searchValue))
                            {
                                int rowIndex = row.Index;
                                datagridView_NV.Rows[rowIndex].Selected = true;
                                valueResult = true;
                                break;
                            }
                        }
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txt_FindNV.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            /*txt_idNV_TextChanged(sender, e);*/
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string dob = dateTime_NV.Value.ToString("yyyy-MM-dd HH:mm:ss");
            if (!dm.UpdateRow(txt_idNV.Text, combox_Shift.SelectedValue.ToString(), txt_nameNV.Text, txt_Email.Text, txt_Phone.Text,
                    dob, comBox_Gender.Text, txt_Username.Text, txt_PassWord.Text, comBox_Role.Text))
            {
                MessageBox.Show("Failed");
            }
            ResetForm();
            LoadStaffData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRow(datagridView_NV.Rows[datagridView_NV.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Failed");
                    }

                    ResetForm();
                    LoadStaffData();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comBox_Gender_Click(object sender, EventArgs e)
        {
            comBox_Gender.DisplayMember = "Text";
            comBox_Gender.ValueMember = "Value";

            var items = new[] {
            new { Text = "Nam", Value = "Nam" },
            new { Text = "Nữ", Value = "Nữ" },
            };
            comBox_Gender.DataSource = items;
        }

        private void comBox_Role_Click(object sender, EventArgs e)
        {
            comBox_Role.DisplayMember = "Text";
            comBox_Role.ValueMember = "Value";

            var items = new[] {
            new { Text = "Quản lý", Value = "Quản lý" }, 
            new { Text = "Thu ngân", Value = "Thu ngân" },
            new { Text = "Pha chế", Value = "Pha chế" },
            new { Text = "Phục vụ", Value = "Phục vụ" },
            new { Text = "Bảo vệ", Value = "Bảo vệ" },
            };
            comBox_Role.DataSource = items; 
        }

        private void combox_Shift_Click(object sender, EventArgs e)
        {
            combox_Shift.DisplayMember = "Text";
            combox_Shift.ValueMember = "Value";

            var items = new[] {
            new { Text = "S0001", Value = "S0001" },
            new { Text = "S0002", Value = "S0002" },
            new { Text = "S0003", Value = "S0003" },
            };
            combox_Shift.DataSource = items;
        }

        private void datagridView_AC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idNV.Text = datagridView_AC.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void datagridView_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idNV.Text = datagridView_NV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nameNV.Text = datagridView_NV.Rows[e.RowIndex].Cells[1].Value.ToString();
            comBox_Gender.Text = datagridView_NV.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTime_NV.Text = datagridView_NV.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Email.Text = datagridView_NV.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Phone.Text = datagridView_NV.Rows[e.RowIndex].Cells[5].Value.ToString();
            comBox_Role.Text = datagridView_NV.Rows[e.RowIndex].Cells[7].Value.ToString();
            combox_Shift.Text = datagridView_NV.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
    }
}
