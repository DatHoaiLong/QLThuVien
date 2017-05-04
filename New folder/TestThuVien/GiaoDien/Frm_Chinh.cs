using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
            if(Frm_DangNhap.quyen.ToString()=="1")
            {
                
            }
            if (Frm_DangNhap.quyen.ToString() == "2")
            {
                but_QLKho.Enabled = false;
                but_Backup.Enabled = false;
                butlinbk.Enabled = false;
                butlinkrestore.Enabled = false;
                txt_Backup.Enabled = false;
                txtresote.Enabled = false;
                but_Restore.Enabled = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning )== DialogResult.OK)
            {
                this.Close();
            }
        }

        private void but_Bower_Backup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                txt_Backup.Text = file.SelectedPath;
                but_Backup.Enabled = true;
            }
        }

        private void but_Backup_Click(object sender, EventArgs e)
        {
            if(txt_Backup.Text=="")
            {
                MessageBox.Show("Chưa chọn đường dẫn");

            }else
            {
                try
                {
                    //thuc hien backup
                    if (!Directory.Exists(Path.GetDirectoryName(txt_Backup.Text)))
                    {
                        MessageBox.Show("Thư mục không tồn tại");
                    }
                    else
                    {
                        data.MoKetNoi();
                        SqlCommand cmdbackup = new SqlCommand();
                        cmdbackup.CommandType = CommandType.Text;
                        cmdbackup.Connection = KetNoiDT.connect;
                        cmdbackup.CommandText =
                       "BACKUP DATABASE ThuVienSo TO DISK='" + txt_Backup.Text + "'WITH FORMAT";
                        cmdbackup.ExecuteNonQuery();
                        MessageBox.Show("Backup thành  công");
                        txt_Backup.Text = "";

                    }
                }
                catch(Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                    }
                }

            }
        }
        FileDialog dl;

        private void butlinbk_Click(object sender, EventArgs e)
        {
            if (txt_Backup.Text == "")
            {
                dl = new SaveFileDialog();
            }
            dl.Filter = "File  type (*.bak)|*.bak";
            dl.DefaultExt = "bak";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                txt_Backup.Text = dl.FileName;
            }
        }

        private void bulinrestore_Click(object sender, EventArgs e)
        {
            if (txtresote.Text == "")
            {
                dl = new OpenFileDialog();
            }
            dl.Filter = "File  type (*.bak)|*.bak";
            dl.DefaultExt = "bak";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                txtresote.Text= dl.FileName;
            }
        }

        private void but_Restore_Click(object sender, EventArgs e)
        {
            //thuc hien restore
            try
            {
                if (!File.Exists(txtresote.Text))
                {
                    MessageBox.Show("File không tồn tại");
                }
                else
                {
                    data.MoKetNoi();
                    SqlCommand cmdrestore = new SqlCommand();
                    cmdrestore.Connection = KetNoiDT.connect;
                    cmdrestore.CommandType = CommandType.Text;
                    cmdrestore.CommandText = "ALTER DATABASE ThuVienSo SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE ThuVienSo FROM DISK='" + txtresote.Text + "' WITH REPLACE ALTER DATABASE ThuVienSo SET ONLINE";
                    cmdrestore.ExecuteNonQuery();
                    if (MessageBox.Show("Restore thành công hãy khởi động lại ứng dụng để cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        txtresote.Text = "";
                        this.Close();                              
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
       
    }
}
