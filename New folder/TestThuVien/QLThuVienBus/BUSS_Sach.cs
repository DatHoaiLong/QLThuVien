using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.QLThuVienBus
{
    public class BUSS_Sach
    {
        SQL_Sach sql = new SQL_Sach();
        public void ThemDuLieu(Sach et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(Sach et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(Sach et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
        /*---------------------------------------------*/
        public DataTable LayDuLieuBang(string CauLenh)
        {
            return sql.LayDuLieuBang(CauLenh);
        }
    }
}
