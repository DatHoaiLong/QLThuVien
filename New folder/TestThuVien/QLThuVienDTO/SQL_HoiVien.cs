using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestThuVien.HeThong;
using System.Data;
using System.Data.SqlClient;
namespace TestThuVien.QLThuVienDTO
{
    public class SQL_HoiVien
    {
        KetNoiDT cn = new KetNoiDT();

        public void ThemDuLieu(HoiVien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO HOIVIEN (MaHoiVien,DiaChi,GioiTinh,Ho,Ten,SoDT,Email) VALUES     ('" + et.Mahoivien + "',N'" + et.Diachi + "',N'" + et.Gioitinh + "',N'" + et.Ho + "',N'" + et.Ten + "','" + et.Sodt + "','" + et.Email + "')");
        }
        public void SuaDuLieu(HoiVien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    HOIVIEN SET   DiaChi =N'" + et.Diachi + "',GioiTinh=N'" + et.Gioitinh + "', Ho =N'" + et.Ho + "', Ten =N'" + et.Ten + "' where MaHoiVien='" + et.Mahoivien + "'");
        }
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("Select * from HOIVIEN " + DieuKien);
        }
        public DataTable LayThongTinHoiVien(string DieuKien)
        {
            return cn.GetDataTable("Select MaHoiVien from HOIVIEN " + DieuKien);
        }
        public DataTable LayDuLieuBang(string CauLenh)
        {
            return cn.GetDataTable2(CauLenh);
        }

    }
}
