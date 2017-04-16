using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.QLThuVienBus
{
    public class BUSS_HoiVien
    {
        SQL_HoiVien sql = new SQL_HoiVien();
        public void ThemDuLieu(HoiVien et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(HoiVien et)
        {
            sql.SuaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
        public DataTable LayDuLieuBang(string CauLenh)
        {
            return sql.LayDuLieuBang(CauLenh);
        }
       
    }
}
