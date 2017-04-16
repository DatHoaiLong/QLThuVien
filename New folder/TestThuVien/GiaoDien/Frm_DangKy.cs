using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestThuVien.GiaoDien
{
    public partial class Frm_DangKy : Form
    {
        public Frm_DangKy()
        {
            InitializeComponent();
        }

        private void txt_TaiKhoanDK_Click(object sender, EventArgs e)
        {
            if(txt_TaiKhoanDK.Text=="Tài Khoản")    
            {
                txt_TaiKhoanDK.Clear();
            }
        }

        private void txt_MatKhauDK_Click(object sender, EventArgs e)
        {
            if(txt_MatKhauDK.Text=="Mật Khẩu")
            {
                txt_MatKhauDK.Clear();
            }
        }

        private void txt_NhapLaiMK_Click(object sender, EventArgs e)
        {
            if(txt_NhapLaiMK.Text=="Nhập Lại MK")
            {
                txt_NhapLaiMK.Clear();
            }
        }

        private void Frm_DangKy_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
