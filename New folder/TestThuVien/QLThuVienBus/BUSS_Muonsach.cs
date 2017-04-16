using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using TestThuVien.QLThuVienDTO;
namespace TestThuVien.QLThuVienBus
{
    public class BUSS_Muonsach
    {
        SQL_muonsach sql = new SQL_muonsach();
        public void ThemDuLieu(ChiTietMuonSach et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(ChiTietMuonSach et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(ChiTietMuonSach et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
    }
}
