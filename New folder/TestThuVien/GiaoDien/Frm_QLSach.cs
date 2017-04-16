using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestThuVien.HeThong;
using TestThuVien.QLThuVienBus;
using TestThuVien.QLThuVienDTO;
using System.Data.SqlClient;
using System.IO;
namespace TestThuVien.GiaoDien
{
    public partial class Frm_QLSach : Form
    {
        string linkanh = "",linkfull="";
        //-----------------------------
        KetNoiDT kn = new KetNoiDT();
        //----------------------------
        bool themmoi=true;
           BUSS_Sach bus = new BUSS_Sach();
           BUSS_KhoSach busks = new BUSS_KhoSach();
           BUSS_PhanLoaiSach busspl = new BUSS_PhanLoaiSach();
        Sach ec = new Sach();
        PhanLoaiSach pl =new PhanLoaiSach();
        KhoSach ks =new KhoSach();
        public Frm_QLSach()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        } 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackgroundImage = Image.FromFile(open.FileName);
            }
            string linkAnh = open.FileName;
            linkfull = open.FileName;
            linkAnh = "Sach/" +linkAnh.Substring(linkAnh.LastIndexOf("\\")+1);
            linkanh = linkAnh;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("icon/plus-flata.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("icon/plus-flat.png");
        }

        void KhoaDieuKien()
        {
            txt_MaSach.Enabled = false;
            txt_TenSach.Enabled = false;
            txt_TenTacGia.Enabled = false;
            combo_loaisach.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_NgayXuatBan.Enabled = false;
            txt_MaLoaiSach.Enabled = false;
            btnthemmoi.Enabled = true;
            btnluu.Enabled = false;
            buttomsua.Enabled = false;
            btnxoa.Enabled = true;
            but_XoaLS.Enabled = false;
            butThemLS.Enabled = false;
        }
        void MoDieuKien()
        {
            txt_MaSach.Enabled = false;
            txt_TenSach.Enabled = true;
            txt_TenTacGia.Enabled = true;
            combo_loaisach.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_NgayXuatBan.Enabled = true;
            txt_MaLoaiSach.Enabled = false;
            btnthemmoi.Enabled = false;
            btnluu.Enabled = true;
            buttomsua.Enabled = true;
            btnxoa.Enabled = true;
            but_XoaLS.Enabled = true;
            butThemLS.Enabled = true;
        }
        private void Frm_QLSach_Load(object sender, EventArgs e)
        {
           
            KhoaDieuKien();
            HienThi("");
            combo_loaisach.Text = "----Chọn Loại Sách----";
            DataTable datapls = new DataTable();
            datapls = bus.LayDuLieuBang("select tenloai from phanloaisach");
            for (int i = 0; i < datapls.Rows.Count; i++)
            {
                combo_loaisach.Items.Add(datapls.Rows[i]["TenLoai"].ToString());
            }
     
        }
      
      
        void SetNull()
        {
            
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_TenTacGia.Text = "";
            combo_loaisach.Text = "";
            txt_SoLuong.Text="";
            txt_NgayXuatBan.Text = "";
        }
        void HienThi(string where)
        {
           dataGridView_Sach.DataSource = bus.LayDuLieu(where);
        }
        private void btnthemmoi_Click_1(object sender, EventArgs e)
        {
             MoDieuKien();
             SetNull();
             combo_loaisach.Text = "----Chọn Loại Sách----";
            //----------------------------------------
             DataTable datams = new DataTable();
             datams = bus.LayDuLieuBang("select masach from sach");
             string macuoicung = datams.Rows[datams.Rows.Count - 1]["MaSach"].ToString();
             int n = int.Parse(macuoicung.Substring(2));
             n++;
             string masach = "MS" + string.Format("{0:000000}", n);
             txt_MaSach.Text = masach;
            //------------------------------------------
            //------------------------------------------
             txt_MaLoaiSach.Enabled = false;
             buttomsua.Enabled = false;
             btnxoa.Enabled = false;
             txt_MaLoaiSach.Clear();  
            themmoi = true;
        }

        private void buttomsua_Click_1(object sender, EventArgs e)
        {
            MoDieuKien();
          txt_MaSach.Enabled = false;
            themmoi = false;
            //------------------------------------------------
            SqlParameter para1 = new SqlParameter("@masach", txt_MaSach.Text);
            SqlParameter para2 = new SqlParameter("@tensach", txt_TenSach.Text);
            SqlParameter para3 = new SqlParameter("@MaLoaiSach", txt_MaLoaiSach.Text);
            SqlParameter para4 = new SqlParameter("@tenloaisach", combo_loaisach.Text);
            SqlParameter para5 = new SqlParameter("@TenTacGia", txt_TenTacGia.Text);
            SqlParameter para6 = new SqlParameter("@NgayXuatBan", txt_NgayXuatBan.Text);
            SqlParameter para7 = new SqlParameter("@hinh", linkanh);
            SqlParameter para8 = new SqlParameter("@soluong", txt_SoLuong.Text);
            kn.sqlThucThi("suathongtinsach", para1, para2, para3, para4, para5, para6, para7, para8);
            HienThi(""); 
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
        
                 try
            {
                ec.Masach= txt_MaSach.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Đã xóa thành công");
                pictureBox3.BackgroundImage = null;
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(dataGridView_Sach.Rows[dataGridView_Sach.CurrentCell.RowIndex].Cells[7].Value.ToString());
                KhoaDieuKien();
                SetNull();
                HienThi("");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                txt_MaSach.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_SoLuong.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_TenSach.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_TenTacGia.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[3].Value.ToString();
                combo_loaisach.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_MaLoaiSach.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_NgayXuatBan.Text = dataGridView_Sach.Rows[e.RowIndex].Cells[6].Value.ToString();
                pictureBox3.BackgroundImage = Image.FromFile(dataGridView_Sach.Rows[e.RowIndex].Cells[7].Value.ToString());
                pictureBox3.Show();
                linkanh = dataGridView_Sach.Rows[e.RowIndex].Cells[7].Value.ToString();
                MoDieuKien();
                  btnthemmoi.Enabled = true;
                btnluu.Enabled = false;
                /*-----------------------------------------------------*/
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
                
        }

        private void combo_loaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_loaisach.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                DataTable datamls = new DataTable();
                datamls = bus.LayDuLieuBang("select maloaisach from phanloaisach");
                txt_MaLoaiSach.Text = datamls.Rows[combo_loaisach.SelectedIndex]["MaLoaiSach"].ToString();
            }
        }

        private void btnThemLS_Click(object sender, EventArgs e)
        {

        }

        private void butThemLS_Click(object sender, EventArgs e)
        {
            Frm_LoaiSach loaisach=new Frm_LoaiSach();
            string pls = null;
            loaisach.ShowDialog();
            pls=loaisach.Phanloaisach;
            if (pls.Length == 0)
            {
                return;
            }
            else
            {
                DataTable datamls = new DataTable();
                datamls = bus.LayDuLieuBang("select maloaisach from phanloaisach");
                string macuoicung = datamls.Rows[datamls.Rows.Count - 1]["MaLoaiSach"].ToString();
                int n = int.Parse(macuoicung.Substring(3));
                n++;
                string maloaisach = "MLS" + string.Format("{00}", n);
                //--------------------------------------------------------
                SqlParameter pr1 = new SqlParameter("@mals",maloaisach);
                SqlParameter pr2 = new SqlParameter("@tenls",pls);
                kn.sqlThucThi("ThemPLS",pr1,pr2);
                if (combo_loaisach.Enabled)
                {
                    combo_loaisach.Items.Add(pls);
                }
                MessageBox.Show("Thêm thành công thể loại: "+pls);
            }

        }

        private void but_XoaLS_Click(object sender, EventArgs e)
        {
            
            if (combo_loaisach.SelectedIndex != -1)
            {
                string tls = combo_loaisach.SelectedItem.ToString();
                if (MessageBox.Show("Bạn có thật sự muốn xóa thể loại: " + tls, "Cảnh Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlParameter pr1 = new SqlParameter("@tenls", tls);
                    kn.sqlThucThi("xoaPLS", pr1);
                    combo_loaisach.Items.RemoveAt(combo_loaisach.SelectedIndex);
                    MessageBox.Show("Đã Xóa Thành Công Thể Loại: " + tls);
                    txt_MaLoaiSach.Clear();
                }
            }
        }

        private void combo_loaisach_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
             
            if(themmoi==true)
            {
                try
                {
                    //------------------------------------------------
                    if (linkanh == "")
                    {
                        MessageBox.Show("Chua co Anh !!");
                        return;
                    }
                    //------------------------------------------------
                    SqlParameter para1 = new SqlParameter("@masach",txt_MaSach.Text);
                    SqlParameter para2 =new SqlParameter("@tensach",txt_TenSach.Text);
                    SqlParameter para3 =new SqlParameter("@MaLoaiSach",txt_MaLoaiSach.Text);
                     SqlParameter para4=new SqlParameter("@tenloaisach",combo_loaisach.Text);
                     SqlParameter para5 =new SqlParameter("@TenTacGia",txt_TenTacGia.Text); 
                     SqlParameter para6=new SqlParameter("@NgayXuatBan",txt_NgayXuatBan.Text);
                     SqlParameter para7=new SqlParameter("@hinh",linkanh); 
                    SqlParameter para8 =new SqlParameter("@soluong",txt_SoLuong.Text);
                    kn.sqlThucThi("luuthongtinsach",para1,para2,para3,para4,para5,para6,para7,para8);
                    File.Copy(linkfull, linkanh);
                    MessageBox.Show("Đã Lưu Thành công");
                    HienThi("");
                    
                    //------------------------------------------------
                    

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }else
            {
                try
                {
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
             SetNull();
            KhoaDieuKien();
            HienThi("");

        }

        private void dataGridView_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

