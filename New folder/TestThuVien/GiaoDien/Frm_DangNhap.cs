using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestThuVien.GiaoDien
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
        }
        
        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoanDN.Text == "Tài Khoản")
            {
                txt_TaiKhoanDN.Clear();
               
            }
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauDN.Text == "Mật Khẩu")
            {
                txt_MatKhauDN.Clear();
                txt_MatKhauDN.PasswordChar = '*';
            }
        }

        private void but_Dangky_Click(object sender, EventArgs e)
        {
            Frm_DangKy Dangky = new Frm_DangKy();
            Dangky.Show();
        }

        private void but_Thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không","Chú Ý",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            this.Close();
        }

        private void but_Dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoanDN.Text == "admin" && txt_MatKhauDN.Text == "admin")
            {
                Frm_Chinh trangchu = new Frm_Chinh();
                trangchu.ShowDialog();
            }
        }
       }
}
