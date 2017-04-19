using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.GiaoDien
{
    public partial class Frm_DangNhap : Form
    {
        public  static string quyen;
        KetNoiDT kd = new KetNoiDT();
        DataTable tb = new DataTable();
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
            if (txt_TaiKhoanDN.Text == "")
            {
                txt_TaiKhoanDN.Clear();
               
            }
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauDN.Text == "")
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
            try
            {
                SqlParameter pr1 = new SqlParameter("@tendn", txt_TaiKhoanDN.Text);
                //SqlParameter pr2 = new SqlParameter("@mkdn", txt_MatKhauDN.Text);
                tb = kd.sqlLayDuLieu("dangnhap", pr1);
                string taikhoan = tb.Rows[tb.Rows.Count - 1]["TenNguoiDung"].ToString();
                string matkhau = tb.Rows[tb.Rows.Count - 1][tb.Rows.Count].ToString();
                quyen = tb.Rows[tb.Rows.Count - 1][tb.Rows.Count + 1].ToString();
                if (txt_MatKhauDN.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                }
                else  if(txt_MatKhauDN.Text==matkhau)
               {
                       Frm_Chinh chinh = new Frm_Chinh();
                       chinh.ShowDialog();
                       txt_TaiKhoanDN.Clear();
                       txt_MatKhauDN.Clear();
               }
                else
               {
                   MessageBox.Show("Sai Mật Khẩu");
                   txt_MatKhauDN.Clear();
                   txt_MatKhauDN.Focus();
               }
            }catch
            {
                MessageBox.Show("Tài khoản chưa đăng ký");
            }
            //if (taikhoan!=txt_TaiKhoanDN.Text)
            //{
            //    MessageBox.Show("Tên tài khoản chưa đăng ký.");
            //}
            //else if (taikhoan == txt_TaiKhoanDN.Text)
            //{
            //    string matkhau = tb.Rows[tb.Rows.Count]["MatKhau"].ToString();
            //    MessageBox.Show(matkhau);

            //}
            
            //if (txt_TaiKhoanDN.Text == "" && txt_MatKhauDN.Text == "")
            //{
            //    Frm_Chinh trangchu = new Frm_Chinh();
            //    trangchu.ShowDialog();
            //}
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_MatKhauDN.PasswordChar = '\0';
        }
       }
}
