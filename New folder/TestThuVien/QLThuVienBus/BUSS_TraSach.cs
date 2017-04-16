using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.QLThuVienBus
{
    public class BUSS_TraSach
    {
        SQL_TraSach sql = new SQL_TraSach();
        public void ThemDuLieu(ChiTietTraSach et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(ChiTietTraSach et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(ChiTietTraSach et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
    }
}
