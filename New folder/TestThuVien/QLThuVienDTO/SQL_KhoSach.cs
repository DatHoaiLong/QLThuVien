using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
namespace TestThuVien.QLThuVienDTO
{
    public class SQL_KhoSach
    {
        KetNoiDT cn = new KetNoiDT();

        public void ThemDuLieu(KhoSach et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO KHOSACH (MaSach,SoLuongTrongKho) VALUES     ('" + et.Masach + "',N'"  + "',N'" + et.Soluongtrongkho + "')");
        }
        public void SuaDuLieu(KhoSach et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    KHOSACH SET  SoLuongTrongKho='" + et.Soluongtrongkho + "' where MaSach='" + et.Masach + "'");
        }
        public void XoaDuLieu(KhoSach et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE  from  KHOSACH where MaSach='" + et.Masach + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("dbo.sp_ThongKeKho" + DieuKien);
        }
        public DataTable LayThongTinHoiVien(string DieuKien)
        {
            return cn.GetDataTable("Select MaSach from Sach " + DieuKien);
        }
    }
}
