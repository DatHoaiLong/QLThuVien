using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.QLThuVienBus
{
    public class BUSS_KhoSach
    {
        SQL_KhoSach sql = new SQL_KhoSach();
        public void ThemDuLieu(KhoSach et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(KhoSach et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(KhoSach et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
    }
}
