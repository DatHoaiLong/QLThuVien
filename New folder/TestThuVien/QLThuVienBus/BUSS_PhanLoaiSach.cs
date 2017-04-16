using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.QLThuVienBus
{
    public  class BUSS_PhanLoaiSach
    {
        SQL_Phanloaisach sql = new SQL_Phanloaisach();
        public void ThemDuLieu(PhanLoaiSach et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(PhanLoaiSach et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(PhanLoaiSach et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
    }
}
