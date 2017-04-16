using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestThuVien.HeThong;
using TestThuVien.QLThuVienBus;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.GiaoDien
{
    public partial class Frm_QLKho : Form
    {
        public Frm_QLKho()
        {
            InitializeComponent();
        }
        BUSS_KhoSach bus = new BUSS_KhoSach();
        private void Frm_QLKho_Load(object sender, EventArgs e)
        {
            HienThi("");
        }
        void HienThi(string where)
        {
            dataGridView_ThongKe.DataSource = bus.LayDuLieu(where);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát ","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
