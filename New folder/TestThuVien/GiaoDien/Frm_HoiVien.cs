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
namespace TestThuVien.GiaoDien
{
    public partial class Frm_HoiVien : Form
    {
        public Frm_HoiVien()
        {
            InitializeComponent();
        }
        BUSS_HoiVien bus = new BUSS_HoiVien();
        HoiVien ec = new HoiVien();
        bool themmoi;
        KetNoiDT dt = new KetNoiDT();
        void KhoaDieuKien()
        {
            txtmahoivien.Enabled = false;
            txtdiachi.Enabled = false;
            comboxgioitinh.Enabled = false;
            txtho.Enabled = false;
            txtten.Enabled = false;
            txtsodienthoai.Enabled = false;
            txtemail.Enabled = false;

            btnthemmoi.Enabled = true;
            btnluu.Enabled = false;
            buttomsua.Enabled = false;
            btnxoa.Enabled = false;
            but_TheHV.Enabled = false;
        }
        void MoDieuKien()
        {
            but_TheHV.Enabled = false;
            txtmahoivien.Enabled = true;
            txtdiachi.Enabled = true;
            comboxgioitinh.Enabled = true;
            txtho.Enabled = true;
            txtten.Enabled = true;
            txtsodienthoai.Enabled = true;
            txtemail.Enabled = true;

            btnthemmoi.Enabled = false;
            btnluu.Enabled = true;
            buttomsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        private void Frm_HoiVien_Load(object sender, EventArgs e)
        {
            if (Frm_DangNhap.quyen.ToString() == "1")
            {

            }
            if (Frm_DangNhap.quyen.ToString() == "2")
            {
                btnxoa.Enabled = false;
            }
            KhoaDieuKien();
            HienThi("");
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            DataTable datams = new DataTable();
            datams = bus.LayDuLieuBang("select mahoivien from hoivien");
            string macuoicung = datams.Rows[datams.Rows.Count - 1]["MaHoiVien"].ToString();
            int n = int.Parse(macuoicung.Substring(3));
            n++;
            string mahoivien = "MHV" + string.Format("{0:000000}",n);
            txtmahoivien.Text = mahoivien;
            btnxoa.Enabled = false;
            MoDieuKien();
            txtmahoivien.Enabled = false;
            themmoi = true;

        }
        void SetNull()
        {
            txtmahoivien.Text="";
            comboxgioitinh.Text="Nam";
            txtdiachi.Text="";
            txtho.Text="";
            txtten.Text="";
            txtsodienthoai.Text = "";
            txtemail.Text="";
        }
        void HienThi(string where)
        {
            dataGiVHoiVien.DataSource = bus.LayDuLieu(where);
        }

        private void buttomsua_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            txtmahoivien.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter para1 = new SqlParameter("@mahoivien",txtmahoivien.Text);
                DataTable dulieu= dt.sqlLayDuLieu("tontai",para1);
                if(dulieu.Rows.Count>=1)
                {
                    MessageBox.Show("Người này đang mượn sách không thể xóa");
                    return;
                }
                SqlParameter para2 = new SqlParameter("@mahoivien",txtmahoivien.Text);
                dt.sqlThucThi("sp_XoaHoiVien", para2);
                MessageBox.Show("Đã xóa thành công");
                KhoaDieuKien();
                SetNull();
                HienThi("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmahoivien.Text == "" || comboxgioitinh.Text=="" || txtdiachi.Text == "" || txtho.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            if (themmoi == true)
            {
                try
                {
                    SqlParameter para1 = new SqlParameter("@mahoivien",txtmahoivien.Text);
                    SqlParameter para2 = new SqlParameter("@diachi",txtdiachi.Text);
                    SqlParameter para3 = new SqlParameter("@gioitinh",comboxgioitinh.Text);
                    SqlParameter para4 = new SqlParameter("@HO", txtho.Text);
                    SqlParameter para5 = new SqlParameter("@ten", txtten.Text);
                    SqlParameter para6 = new SqlParameter("@sodt", txtsodienthoai.Text);
                    SqlParameter para7 = new SqlParameter("@email", txtemail.Text);
                    dt.sqlThucThi("sp_HoiVienInsert", para1, para2, para3, para4, para5, para6, para7);
                    HienThi("");
                    MessageBox.Show("Đã thêm dữ liệu thành công");
                }
                catch
                {
                    MessageBox.Show("lỗi");
                    return;
                }
            }
            else
            {
                try
                {
                    SqlParameter para1 = new SqlParameter("@mahoivien", txtmahoivien.Text);
                    SqlParameter para2 = new SqlParameter("@diachi", txtdiachi.Text);
                    SqlParameter para3 = new SqlParameter("@gioitinh", comboxgioitinh.Text);
                    SqlParameter para4 = new SqlParameter("@HO", txtho.Text);
                    SqlParameter para5 = new SqlParameter("@ten", txtten.Text);
                    SqlParameter para6 = new SqlParameter("@sodt", txtsodienthoai.Text);
                    SqlParameter para7 = new SqlParameter("@email", txtemail.Text);
                    dt.sqlThucThi("sp_SuaHoiVien", para1, para2, para3, para4, para5, para6, para7);
                    HienThi("");
                    MessageBox.Show("Đã sửa dữ liệu thành công");
                 
                }
                catch
                {
                    MessageBox.Show("lỗi");
                    return;
                }
            }
            SetNull();
            KhoaDieuKien();
            HienThi("");
        }

        private void dataGiVHoiVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Frm_DangNhap.quyen.ToString() == "1")
            {
            try
            {
                
                txtmahoivien.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtdiachi.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboxgioitinh.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtho.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtten.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtsodienthoai.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtemail.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                btnxoa.Enabled = true;
                buttomsua.Enabled = true;
                but_TheHV.Enabled = true;
            }
            catch
            {
            }

        }else  if (Frm_DangNhap.quyen.ToString() == "2")
                {
                    txtmahoivien.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtdiachi.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    comboxgioitinh.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtho.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtten.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtsodienthoai.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtemail.Text = dataGiVHoiVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                    buttomsua.Enabled = true; 
                    btnxoa.Enabled = false;
                    but_TheHV.Enabled = true;
                }      
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Bạn Có muốn thoát ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
           {
            this.Close();
           }
        }

        private void but_TheHV_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("THẺ THƯ VIỆN", new Font("Arial", 16, FontStyle.Bold), Brushes.Black,350,50);
            /*ma hoi vien*/
            e.Graphics.DrawString("Mã hội viên :", new Font("Arial", 12), Brushes.Black, 300, 100);
            e.Graphics.DrawString(txtmahoivien.Text, new Font("Arial", 12), Brushes.Black,430, 100);
            /*ho ten*/
            e.Graphics.DrawString("Tên hội viên :", new Font("Arial", 12), Brushes.Black, 300, 130);
            e.Graphics.DrawString(txtho.Text+" "+txtten.Text, new Font("Arial", 12), Brushes.Black, 430, 130);
            /*gioi tinh & sdt*/
            e.Graphics.DrawString("Giới tính :", new Font("Arial", 12), Brushes.Black, 300, 160);
            e.Graphics.DrawString(comboxgioitinh.Text+" / ", new Font("Arial", 12), Brushes.Black, 400, 160);
            e.Graphics.DrawString("SĐT : ", new Font("Arial", 12), Brushes.Black,450, 160);
            e.Graphics.DrawString(txtsodienthoai.Text, new Font("Arial", 12), Brushes.Black,490, 160);
            /*dia chi*/
            e.Graphics.DrawString("Địa chỉ :", new Font("Arial", 12), Brushes.Black, 300, 190);
            e.Graphics.DrawString(txtdiachi.Text, new Font("Arial", 12), Brushes.Black, 430, 190);
            /*ngay thang nam */
            e.Graphics.DrawString("Ngày ___ Tháng ___ Năm ______", new Font("Arial", 10), Brushes.Black, 350, 230);
            e.Graphics.DrawString("Giám đốc", new Font("Arial", 12,FontStyle.Bold), Brushes.Black, 450, 260);
            /*anh*/
            e.Graphics.DrawString("Ảnh(6x4)", new Font("Arial", 10), Brushes.Black,200, 150);
            /*ngay het han*/
            e.Graphics.DrawString("Ngày hết hạn", new Font("Arial", 10), Brushes.Black, 200, 230);
            e.Graphics.DrawString("___/___/______", new Font("Arial", 10), Brushes.Black, 200, 260);

        }
        private void txtho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == 8);
            /*chi cho nhap vao ky tu*/
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            /*chi cho nhapn vao so*/
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == 8);
        }
    }
}
