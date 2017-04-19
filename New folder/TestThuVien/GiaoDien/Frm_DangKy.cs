using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestThuVien.QLThuVienDTO;
using System.Data.SqlClient;
namespace TestThuVien.GiaoDien
{
    public partial class Frm_DangKy : Form
    {
        KetNoiDT kd = new KetNoiDT();
        public Frm_DangKy()
        {
            InitializeComponent();
        }


        private void txt_TaiKhoanDK_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoanDK.Text == "")
            {
                txt_TaiKhoanDK.Clear();
            }
        }

        private void txt_MatKhauDK_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauDK.Text == "")
            {
                txt_MatKhauDK.Clear();
            }
        }

        private void txt_NhapLaiMK_Click(object sender, EventArgs e)
        {
            if (txt_NhapLaiMK.Text == "")
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

        private void but_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TaiKhoanDK.Text != "" && txt_MatKhauDK.Text != "" && txt_NhapLaiMK.Text != "")
                {
                    if (txt_MatKhauDK.Text != txt_NhapLaiMK.Text)
                    {
                        MessageBox.Show("Mật Khẩu Không Trùng Khớp .");
                        txt_NhapLaiMK.Clear();
                        txt_MatKhauDK.Clear();
                        txt_MatKhauDK.Focus();
                    }
                    else
                    {
                        SqlParameter pr = new SqlParameter("@tennguoidung", txt_TaiKhoanDK.Text);
                        SqlParameter pr2 = new SqlParameter("@matkhau", txt_MatKhauDK.Text);
                        kd.sqlThucThi("dangky", pr, pr2);
                        MessageBox.Show("Đăng ký thành công.");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin.");
                    if (txt_TaiKhoanDK.Text == "")
                        txt_TaiKhoanDK.Focus();
                    if (txt_MatKhauDK.Text == "")
                        txt_MatKhauDK.Focus();
                    if (txt_NhapLaiMK.Text == "")
                        txt_NhapLaiMK.Focus();

                }
            }catch
            {
                MessageBox.Show("Tên người dùng đã tồn tại");
            }



        }

    }
}
