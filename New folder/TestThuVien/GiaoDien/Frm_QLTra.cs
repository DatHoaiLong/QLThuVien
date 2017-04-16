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
    public partial class Frm_QLTra : Form
    {
        
        public Frm_QLTra()
        {
            InitializeComponent();
        }
        int soluong;
        String masach;
        BUSS_TraSach bus = new BUSS_TraSach();
        BUSS_Muonsach bus2 = new BUSS_Muonsach();
        KetNoiDT kn = new KetNoiDT();
        void dongdukien()
        {
            but_TraSach.Enabled = false;
            but_ThoiHan.Enabled = false;
            but_Tim.Enabled = true;
            txt_MaHV.Enabled = true;
            txt_NgayHenTra.Enabled = false;
            txt_NgayHienTai.Enabled = false;
            txt_NgayMuon.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_TenHV.Enabled = false;
            txt_TenSach.Enabled = false;
        }
        void modukien()
        {
            but_TraSach.Enabled = true;
            but_ThoiHan.Enabled = true;
            txt_SoLuong.Enabled =true;
            but_Tim.Enabled = true;
            txt_MaHV.Enabled = true;
        }
        private void Frm_QLTra_Load(object sender, EventArgs e)
        {
            txt_MaHV.Text = "MHV";
            dongdukien();
            HienThi("");
        }
        void HienThi(string where)
        {
            dataGridView_QLTraSach.DataSource = bus.LayDuLieu(where);
        }

        private void dataGridView_QLTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                txt_MaHV.Text = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenHV.Text = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_TenSach.Text = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_SoLuong.Text = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_NgayMuon.Text = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_NgayHenTra.Text = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_NgayHienTai.Text = DateTime.Now.ToString();

                masach = dataGridView_QLTraSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                soluong = Convert.ToInt32(dataGridView_QLTraSach.Rows[e.RowIndex].Cells[4].Value.ToString());
                modukien();
             

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void but_Tim_Click(object sender, EventArgs e)
        {
            if(txt_MaHV.Text=="MHV")
            {
                MessageBox.Show("Hãy nhập mã hội viên muốn tìm");
            }else
            {
                SqlParameter para = new SqlParameter("@mahoivien",txt_MaHV.Text);
                dataGridView_QLTraSach.DataSource = kn.sqlLayDuLieu("timthongtintrasach", para);

            }
        }

        private void but_TraSach_Click(object sender, EventArgs e)
        {



          
                if (soluong <(Convert.ToInt32(txt_SoLuong.Text)))
                {
                    MessageBox.Show("Số Lượng trả phải nhỏ hơn hoặc bằng số lượng mượn", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    {
                        txt_SoLuong.Clear();
                        txt_SoLuong.Focus();
                    }

                }
                else if (soluong > Convert.ToInt32(txt_SoLuong.Text))
                {
                    try
                    {

                        SqlParameter para1 = new SqlParameter("@masach", masach);
                        SqlParameter para2 = new SqlParameter("@mahv", txt_MaHV.Text);
                        SqlParameter para3 = new SqlParameter("@soluongtra", txt_SoLuong.Text);
                        kn.sqlThucThi("sp_Tra", para1, para2, para3);
                        HienThi("");
                        MessageBox.Show("Bạn đã trả  " + txt_SoLuong.Text + " quyển " + txt_TenSach.Text + " Bạn còn " + (soluong - Convert.ToInt32(txt_SoLuong.Text)) + " quyển chưa trả");
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (soluong == Convert.ToInt32(txt_SoLuong.Text))
                {
                    if (MessageBox.Show("Bạn muốn trả " + txt_SoLuong.Text + " quyển sách " + txt_TenSach.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {

                        try
                        {
                            SqlParameter para1 = new SqlParameter("@masach", masach);
                            SqlParameter para2 = new SqlParameter("@mahv", txt_MaHV.Text);
                            kn.sqlThucThi("Xoa_QLMS", para1, para2);
                            HienThi("");

                            MessageBox.Show("Bạn đã trả hết sách "+txt_TenSach.Text );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                    }
                }
       
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void but_ThoiHan_Click(object sender, EventArgs e)
        {


            try
            {
                SqlParameter para1 = new SqlParameter("@ngayhentra", txt_NgayHenTra.Text);
                SqlParameter para2 = new SqlParameter("@ngayhientai", txt_NgayHienTai.Text);
           DataTable ngay= kn.sqlLayDuLieu("sp_kiemtradate", para1,para2);
           if (Convert.ToInt32(ngay.Rows[0][0].ToString()) >=0)
           {
               MessageBox.Show("Bạn đã trả đúng hạn.");
 
           }
           else
           {
               MessageBox.Show("Bạn đã trả quá thời hạn.");
           }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
