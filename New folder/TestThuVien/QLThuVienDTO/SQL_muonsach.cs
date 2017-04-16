using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
namespace TestThuVien.QLThuVienDTO
{
    public class SQL_muonsach
    {
        KetNoiDT cn = new KetNoiDT();

        public void ThemDuLieu(ChiTietMuonSach et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO CHITIETMUONSACH (MaHoiVien,MaSach,SoLuongMuon,NgayMuon,NgayHenTra) VALUES     ('" + et.Mahoivien + "','" + et.Masach + "','" + et.Soluongmuon + "','" + et.Ngaymuon + "','" + et.Ngayhentra + "')");
        }
        public void SuaDuLieu(ChiTietMuonSach et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    CHITIETMUONSACH SET   MaSach ='" + et.Masach + "',SoLuongMuon='" + et.Soluongmuon + "', NgayMuon ='" + et.Ngaymuon + "', NgayHenTra ='" + et.Ngayhentra + "' where MaHoiVien='" + et.Mahoivien + "'");
        }
        public void XoaDuLieu(ChiTietMuonSach et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE  from  CHITIETMUONSACH where MaHoiVien='"+et.Mahoivien+"'");
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
