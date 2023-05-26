namespace GYM.UserControls
{
    partial class Thongke
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.dataGridView_HD = new System.Windows.Forms.DataGridView();
            this.datagrid_maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_Ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_Sothutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_HTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doanh Thu:";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Controls.Add(this.dataGridView_HD);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(924, 760);
            this.gunaPanel1.TabIndex = 1;
            // 
            // dataGridView_HD
            // 
            this.dataGridView_HD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagrid_maHD,
            this.datagrid_Ngaylap,
            this.datagrid_Sothutu,
            this.datagrid_Thanhtien,
            this.datagrid_HTTT,
            this.datagrid_Tinhtrang,
            this.datagrid_Ghichu});
            this.dataGridView_HD.Location = new System.Drawing.Point(70, 108);
            this.dataGridView_HD.Name = "dataGridView_HD";
            this.dataGridView_HD.RowHeadersWidth = 51;
            this.dataGridView_HD.Size = new System.Drawing.Size(777, 230);
            this.dataGridView_HD.TabIndex = 70;
            // 
            // datagrid_maHD
            // 
            this.datagrid_maHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_maHD.HeaderText = "Mã hóa đơn";
            this.datagrid_maHD.MinimumWidth = 6;
            this.datagrid_maHD.Name = "datagrid_maHD";
            // 
            // datagrid_Ngaylap
            // 
            this.datagrid_Ngaylap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_Ngaylap.HeaderText = "Ngày lập";
            this.datagrid_Ngaylap.MinimumWidth = 6;
            this.datagrid_Ngaylap.Name = "datagrid_Ngaylap";
            // 
            // datagrid_Sothutu
            // 
            this.datagrid_Sothutu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_Sothutu.HeaderText = "Thứ tự";
            this.datagrid_Sothutu.MinimumWidth = 6;
            this.datagrid_Sothutu.Name = "datagrid_Sothutu";
            // 
            // datagrid_Thanhtien
            // 
            this.datagrid_Thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_Thanhtien.HeaderText = "Thành tiền";
            this.datagrid_Thanhtien.MinimumWidth = 6;
            this.datagrid_Thanhtien.Name = "datagrid_Thanhtien";
            // 
            // datagrid_HTTT
            // 
            this.datagrid_HTTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_HTTT.HeaderText = "Phương thức";
            this.datagrid_HTTT.MinimumWidth = 6;
            this.datagrid_HTTT.Name = "datagrid_HTTT";
            // 
            // datagrid_Tinhtrang
            // 
            this.datagrid_Tinhtrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_Tinhtrang.HeaderText = "Tình trạng";
            this.datagrid_Tinhtrang.MinimumWidth = 6;
            this.datagrid_Tinhtrang.Name = "datagrid_Tinhtrang";
            // 
            // datagrid_Ghichu
            // 
            this.datagrid_Ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_Ghichu.HeaderText = "Ghi chú";
            this.datagrid_Ghichu.MinimumWidth = 6;
            this.datagrid_Ghichu.Name = "datagrid_Ghichu";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Thongke";
            this.Size = new System.Drawing.Size(924, 751);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.DataGridView dataGridView_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_Ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_Sothutu;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_HTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_Tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_Ghichu;
    }
}
