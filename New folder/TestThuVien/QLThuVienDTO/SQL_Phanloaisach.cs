using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
namespace TestThuVien.QLThuVienDTO
{
    public class SQL_Phanloaisach
    {
        KetNoiDT cn = new KetNoiDT();

        public void ThemDuLieu(PhanLoaiSach et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO PHANLOAISACH (MaLoaiSach,TenLoai) VALUES     ('" + et.Maloaisach + "',N'" + et.Tenloai + "')");
        }
        public void SuaDuLieu(PhanLoaiSach et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    PHANLOAISACH SET   TenLoai =N'" + et.Tenloai + "' where MaLoaiSach='" + et.Maloaisach + "'");
        }
        public void XoaDuLieu(PhanLoaiSach et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE  from  PHANLOAISACH where MaLoaiSach='" + et.Maloaisach + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("Select * from PHANLOAISACH " + DieuKien);
        }
      
    }
}
