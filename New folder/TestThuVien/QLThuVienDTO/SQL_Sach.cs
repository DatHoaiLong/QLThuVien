using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using System.Data.SqlClient;
namespace TestThuVien.QLThuVienDTO
{
   public  class SQL_Sach
    {
        KetNoiDT cn = new KetNoiDT();

        //public void ThemDuLieu(Sach et)
        //{
        //    cn.ThucThiCauLenhSQL(@"INSERT INTO SACH (MaSach,TenTacGia,MaLoaiSach,TenSach,NgayXuatBan,Hinh) VALUES     ('" + et.Masach + "','" + et.Tentacgia + "','" + et.Maloaisach + "',N'" + et.Tensach + "','" + et.Ngayxuatban + "','" + et.Hinh + "')");
        //}
        public void ThemDuLieu(Sach et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO SACH (MaSach,TenTacGia,MaLoaiSach,TenSach,NgayXuatBan,Hinh) VALUES     ('" + et.Masach + "','" + et.Tentacgia + "','" + et.Maloaisach + "',N'" + et.Tensach + "','" + et.Ngayxuatban + "','" + et.Hinh + "')");
        }
        public void SuaDuLieu(Sach et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    SACH SET   TenTacGia ='" + et.Tentacgia + "',MaLoaiSach='" + et.Maloaisach + "', TenSach =N'" + et.Tensach + "', NgayXuatBan ='" + et.Ngayxuatban + "', Hinh ='" + et.Hinh + "' where MaSach='" + et.Masach + "'");
        }
        public void XoaDuLieu(Sach et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE  from  SACH where MaSach='" + et.Masach + "'");
            cn.ThucThiCauLenhSQL(@"DELETE from KHOSACH where MaSach='" + et.Masach + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("dbo.laysoluong" + DieuKien);
        }
        public DataTable LayThongTinSach(string DieuKien)
        {
            return cn.GetDataTable("Select MaLoaiSach from PHANLOAISACH " + DieuKien);
        }
       /*---------------------------------------------*/
        public DataTable LayDuLieuBang(string CauLenh)
        {
            return cn.GetDataTable2(CauLenh);
        }

    }
}
