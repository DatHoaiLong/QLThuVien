using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestThuVien.HeThong
{
    public class PhanLoaiSach
    {
        private string _maloaisach;

        public string Maloaisach
        {
            get { return _maloaisach; }
            set { _maloaisach = value; }
        }
        private string _tenloai;

        public string Tenloai
        {
            get { return _tenloai; }
            set { _tenloai = value; }
        }
    }
}
