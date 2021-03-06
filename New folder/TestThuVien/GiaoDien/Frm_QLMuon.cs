﻿using System;
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
    public partial class Frm_QLMuon : Form
    {
        KetNoiDT dt = new KetNoiDT();
        bool themmoi;
        public Frm_QLMuon()
        {
            InitializeComponent();
        }
        BUSS_Muonsach bus = new BUSS_Muonsach();
        void khoadieukhien()
        {
            txt_MaHoiVien.Enabled = false;
            txt_MaSach.Enabled = true;
            time_NgayHenTra.Enabled = false;
            time_NgayMuon.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_TenHoiVien.Enabled = false;
            txt_TenSach.Enabled =false;
            but_kiemtratinhtrang.Enabled = true;
            butluu.Enabled = false;
            but_Xoa.Enabled = false;
            but_Sua.Enabled = false;
            but_Them.Enabled = false;
        }
        void modieukhien()
        {
            txt_MaHoiVien.Enabled = true;
            txt_MaSach.Enabled = true;
            time_NgayHenTra.Enabled = true;
            time_NgayMuon.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_TenHoiVien.Enabled = false;
            txt_TenSach.Enabled = false;
            but_kiemtratinhtrang.Enabled = true;
            butluu.Enabled = true;
            but_Xoa.Enabled = false;
            but_Sua.Enabled = false;
            but_Them.Enabled = true;
        }
        private void Frm_QLMuon_Load(object sender, EventArgs e)
        {

            txt_MaSach.Text = "MS";
            txt_MaHoiVien.Text = "MHV";
            khoadieukhien();
            HienThi("");
        }
        /*-----------------------------------------*/

        /*-----------------------------------------*/
        void HienThi(string where)
        {
            dataGridView_QLMuonSach.DataSource = bus.LayDuLieu(where);
        }

        private void dataGridView_QLMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaHoiVien.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenHoiVien.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_MaSach.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_TenSach.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_SoLuong.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                time_NgayMuon.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                time_NgayHenTra.Text = dataGridView_QLMuonSach.Rows[e.RowIndex].Cells[6].Value.ToString();
                modieukhien();
                but_kiemtratinhtrang.Enabled = false;
                butluu.Enabled = false;
                but_Xoa.Enabled = true;
                but_Sua.Enabled = true;
                txt_MaSach.Enabled = false;
                txt_MaHoiVien.Enabled = false;
                txt_TenHoiVien.Enabled = false;
                /*******************/
                txt_SoLuong.Enabled = false;
                time_NgayMuon.Enabled = false;
                time_NgayHenTra.Enabled = false;
                

                if (Frm_DangNhap.quyen.ToString() == "1")
                {

                }
                if (Frm_DangNhap.quyen.ToString() == "2")
                {
                    but_Xoa.Enabled = false;
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
                
        }

        private void but_kiemtratinhtrang_Click(object sender, EventArgs e)
        {
            themmoi = true;
            if (txt_MaSach.Text == "MS")
            {
                MessageBox.Show("Chưa nhập mã sách.");
            }
            else
            {
                SqlParameter prr = new SqlParameter("@masach", txt_MaSach.Text);
                DataTable showsls = dt.sqlLayDuLieu("sp_SachConLai", prr);
                MessageBox.Show("Số lượng sách còn lại trong kho :" + showsls.Rows[0][1].ToString());
                if (Convert.ToInt32(showsls.Rows[0][1].ToString()) == 0)
                {
                    MessageBox.Show("Sách này đã hết hãy tìm sách khác.");
                    txt_MaSach.Clear();
                    txt_MaSach.Text = "MS";
                    txt_TenSach.Clear();
                }
                else
                {
                    modieukhien();
                    txt_TenHoiVien.Enabled = false;
                }
            }
        }


        private void txt_MaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    SqlParameter para1 = new SqlParameter("@masach", txt_MaSach.Text);
                    DataTable dulieu = dt.sqlLayDuLieu("sp_LayTenSach", para1);
                    txt_TenSach.Text = dulieu.Rows[dulieu.Rows.Count - 1]["TenSach"].ToString();
                }
                catch
                {
                    MessageBox.Show("Mã Sách Không Tồn Tại");
                }
            }

        }

        private void butluu_Click(object sender, EventArgs e)
        {
             SqlParameter prr = new SqlParameter("@masach", txt_MaSach.Text);
                DataTable showsls = dt.sqlLayDuLieu("sp_SachConLai", prr);
               
            if(Convert.ToInt32(txt_SoLuong.Text)> Convert.ToInt32(showsls.Rows[0][1].ToString()))
            {
                MessageBox.Show("Quá số lượng trong kho nhập lại số lượng");
                txt_SoLuong.Clear();
                txt_SoLuong.Focus();

            }else
            {
                if (txt_MaHoiVien.Text == "" || txt_SoLuong.Text == "" || time_NgayMuon.Text == "" || time_NgayHenTra.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
                if (themmoi == true)
                {
                    try
                    {
                        SqlParameter para1 = new SqlParameter("@masach", txt_MaSach.Text);
                        SqlParameter para2 = new SqlParameter("@mahoivien", txt_MaHoiVien.Text);
                        SqlParameter para3 = new SqlParameter("@soluongmuon", txt_SoLuong.Text);
                        SqlParameter para4 = new SqlParameter("@ngaymuon", Convert.ToDateTime(time_NgayMuon.Text));
                        SqlParameter para5 = new SqlParameter("@ngaytra", Convert.ToDateTime(time_NgayHenTra.Text));
                        dt.sqlThucThi("themnguoimuonsach", para1, para2, para3, para4, para5);
                        HienThi("");
                        MessageBox.Show("Đã thêm dữ liệu thành công");
                        txt_MaHoiVien.Clear();
                        txt_MaSach.Clear();
                        txt_SoLuong.Clear();
                        txt_TenSach.Clear();
                        txt_TenHoiVien.Clear();
                        txt_MaSach.Text = "MS";
                        txt_MaHoiVien.Text = "MHV";
                    }
                    catch
                    {
                        MessageBox.Show("Bạn đang mượn sách này nên không thể mượn thêm.");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        SqlParameter para1 = new SqlParameter("@masach", txt_MaSach.Text);
                        SqlParameter para2 = new SqlParameter("@mahv", txt_MaHoiVien.Text);
                        SqlParameter para3 = new SqlParameter("@soluongmuon", txt_SoLuong.Text);
                        SqlParameter para4 = new SqlParameter("@ngaymuon", Convert.ToDateTime(time_NgayMuon.Text));
                        SqlParameter para5 = new SqlParameter("@ngayhentra", Convert.ToDateTime(time_NgayHenTra.Text));
                        dt.sqlThucThi("Sua_QLMS", para1, para2, para3, para4, para5);
                        HienThi("");
                        MessageBox.Show("Sửa Thành Công");
                        txt_MaHoiVien.Clear();
                        txt_MaSach.Clear();
                        txt_SoLuong.Clear();
                        txt_TenSach.Clear();
                        txt_TenHoiVien.Clear();
                        txt_MaSach.Text = "MS";
                        txt_MaHoiVien.Text = "MHV";
                    }
                    catch
                    {
                        MessageBox.Show("Không lưu được.");
                        return;
                    }
                }      
            }
          
        }

        private void txt_MaHoiVien_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    SqlParameter para7 = new SqlParameter("@mahv", txt_MaHoiVien.Text);
                    DataTable dulieu = dt.sqlLayDuLieu("LaytenHV", para7);
                    txt_TenHoiVien.Text = dulieu.Rows[dulieu.Rows.Count - 1]["hoten"].ToString();
                }
                catch
                {
                    MessageBox.Show("Mã HV Không Tồn Tại");
                }
            }
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {

            modieukhien();
            txt_MaSach.Enabled = false;
            txt_MaHoiVien.Enabled = false;
            themmoi = false;
        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter para1 = new SqlParameter("@masach", txt_MaSach.Text);
                SqlParameter para2 = new SqlParameter("@mahv", txt_MaHoiVien.Text);
                dt.sqlThucThi("Xoa_QLMS", para1, para2);
                HienThi("");
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không xóa được.");
                return;
            }

        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            txt_MaSach.Enabled = true;
            txt_MaSach.Clear();
            txt_MaHoiVien.Clear();
            txt_SoLuong.Clear();
            txt_TenHoiVien.Clear();
            txt_TenSach.Clear();
            txt_TenSach.Clear();
            khoadieukhien();
            txt_MaHoiVien.Text = "MHV";
            txt_MaSach.Text = "MS";
            themmoi = true;
        }

        private void txt_MaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
             */
        }

        private void txt_MaHoiVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /*
          e.Handled = !(e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == 8);

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
         */
    }
}
