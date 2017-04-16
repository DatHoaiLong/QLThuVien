using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
namespace TestThuVien.QLThuVienDTO
{
    public class SQL_TraSach
    {
        KetNoiDT cn = new KetNoiDT();

        public void ThemDuLieu(ChiTietTraSach et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO CHITIETTRASACH (MaHoiVien,MaSach,SoLuongTra,NgayTra) VALUES     ('" + et.Mahoivien + "','" + et.Masach + "','" + et.Soluongtra + "','" + et.Ngaytra+ "')");
        }
        public void SuaDuLieu(ChiTietTraSach et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    CHITIETTRASACH SET   MaSach ='" + et.Masach + "',SoLuongTra='" + et.Soluongtra + "', NgayTra ='" + et.Ngaytra + "' where MaHoiVien='" + et.Mahoivien + "'");
        }
        public void XoaDuLieu(ChiTietTraSach et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE  from  CHITIETTRASACH where MaHoiVien='" + et.Mahoivien + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("dbo.laythongtinmuonsach" + DieuKien);
        }
        public DataTable LayThongTinHoiVien(string DieuKien)
        {
            return cn.GetDataTable("Select MaHoiVien from HOIVIEN " + DieuKien);
        }
        public DataTable LayThongTinSach(string DieuKien)
        {
            return cn.GetDataTable("Select MaSach from SACH " + DieuKien);
        }
    }
}
