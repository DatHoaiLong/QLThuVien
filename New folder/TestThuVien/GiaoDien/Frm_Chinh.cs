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
   
    public partial class Frm_Chinh : Form
    {
        KetNoiDT data = new KetNoiDT();
        public Frm_Chinh()
        {
            InitializeComponent();
        }

       /* private void but_HoiVien_Click(object sender, EventArgs e)
        {
            Frm_HoiVien hoivien = new Frm_HoiVien();
            hoivien.Show();
        }
        */
        private void but_QLSach_Click(object sender, EventArgs e)
        {
            Frm_QLSach qlsach = new Frm_QLSach();
            qlsach.ShowDialog();
            DataTable duLieuAnh = data.sqlLayDuLieu("showanh");
            //------Dua hinh anh vao image list
            listView1.Clear();
            imgSach.Images.Clear();
            for (int i = 0; i < duLieuAnh.Rows.Count; i++)
            {
                Image img = Image.FromFile(duLieuAnh.Rows[i]["Hinh"].ToString());
                imgSach.Images.Add(img);
                listView1.Items.Add(duLieuAnh.Rows[i]["TenSach"].ToString());//them ten sach vao lv
                listView1.Items[i].ImageIndex = i;
            }
           
        }

        private void but_QLMuon_Click(object sender, EventArgs e)
        {
            Frm_QLMuon qlmuon = new Frm_QLMuon();
            qlmuon.ShowDialog();
        }

        private void but_QLTra_Click(object sender, EventArgs e)
        {
            Frm_QLTra qltra = new Frm_QLTra();
            qltra.ShowDialog();
        }

        private void but_QLKho_Click(object sender, EventArgs e)
        {
            Frm_QLKho qlkho = new Frm_QLKho();
            qlkho.ShowDialog();
        }

        private void buy_GioiThieu_Click(object sender, EventArgs e)
        {
            Frm_GioThieu gioithieu = new Frm_GioThieu();
            gioithieu.ShowDialog();
        }

        private void but_LienHe_Click(object sender, EventArgs e)
        {
            Frm_LienHe lienhe = new Frm_LienHe();
            lienhe.ShowDialog();
        }

        private void Frm_Chinh_Load(object sender, EventArgs e)
        {
            cob_TimKiem.Text = "----Tìm Kiếm----";
            DataTable duLieuAnh = data.sqlLayDuLieu("dbo.showanh");
          //------Dua hinh anh vao image list
            for (int i = 0; i < duLieuAnh.Rows.Count; i++)
            {
                Image img = Image.FromFile(duLieuAnh.Rows[i]["Hinh"].ToString());
                imgSach.Images.Add(img);
                listView1.Items.Add(duLieuAnh.Rows[i]["TenSach"].ToString());//them ten sach vao lv
                listView1.Items[i].ImageIndex = i;
                
            }
          
        }

        private void but_HoiVien_Click(object sender, EventArgs e)
        {
            Frm_HoiVien hoivien = new Frm_HoiVien();
           {
               hoivien.ShowDialog();
           }
        }

        private void but_TiemKiem_Click(object sender, EventArgs e)
        {
            if (cob_TimKiem.SelectedIndex == -1)
            {
                return;
            }
            if (cob_TimKiem.Text == "Thể Loại")
            {
                SqlParameter para = new SqlParameter("@theloai",TXT_TimKiem.Text);
                DataTable duLieuAnh = data.sqlLayDuLieu("dbo.TimTheoTheLoai", para);
                //------Dua hinh anh vao image list
                listView1.Clear();
                imgSach.Images.Clear();
                for (int i = 0; i < duLieuAnh.Rows.Count; i++)
                {
                    Image img = Image.FromFile(duLieuAnh.Rows[i]["Hinh"].ToString());
                    imgSach.Images.Add(img);
                    listView1.Items.Add(duLieuAnh.Rows[i]["TenSach"].ToString());//them ten sach vao lv
                    listView1.Items[i].ImageIndex = i;
                }
            }

                //Tên Sách
            if (cob_TimKiem.Text == "Tên Sách")
            {
                SqlParameter para = new SqlParameter("@tensach", TXT_TimKiem.Text);
                DataTable duLieuAnh = data.sqlLayDuLieu("dbo.TimTheoTen", para);
                //------Dua hinh anh vao image list
                listView1.Clear();
                imgSach.Images.Clear();
                for (int i = 0; i < duLieuAnh.Rows.Count; i++)
                {
                    Image img = Image.FromFile(duLieuAnh.Rows[i]["Hinh"].ToString());
                    imgSach.Images.Add(img);
                    listView1.Items.Add(duLieuAnh.Rows[i]["TenSach"].ToString());//them ten sach vao lv
                    listView1.Items[i].ImageIndex = i;
                }
            }
                //Tên Tác Giả
            if (cob_TimKiem.Text == "Tên Tác Giả")
            {
                SqlParameter para = new SqlParameter("@tentacgia", TXT_TimKiem.Text);
                DataTable duLieuAnh = data.sqlLayDuLieu("dbo.TimTheoTenTacGia", para);
                //------Dua hinh anh vao image list
                listView1.Clear();
                imgSach.Images.Clear();
                for (int i = 0; i < duLieuAnh.Rows.Count; i++)
                {
                    Image img = Image.FromFile(duLieuAnh.Rows[i]["Hinh"].ToString());
                    imgSach.Images.Add(img);
                    listView1.Items.Add(duLieuAnh.Rows[i]["TenSach"].ToString());//them ten sach vao lv
                    listView1.Items[i].ImageIndex = i;
                }
            }
        }

        private void but_TrangChu_Click(object sender, EventArgs e)
        {

            DataTable duLieuAnh = data.sqlLayDuLieu("dbo.showanh");
            listView1.Clear();
            imgSach.Images.Clear();
            //------Dua hinh anh vao image list
            for (int i = 0; i < duLieuAnh.Rows.Count; i++)
            {
                Image img = Image.FromFile(duLieuAnh.Rows[i]["Hinh"].ToString());
                imgSach.Images.Add(img);
                listView1.Items.Add(duLieuAnh.Rows[i]["TenSach"].ToString());//them ten sach vao lv
                listView1.Items[i].ImageIndex = i;
            }
            TXT_TimKiem.Clear();
            TXT_TimKiem.Focus();
        }

        private void cob_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("icon/012_power-512.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("icon/012_power512.png");
        }
    }
}
