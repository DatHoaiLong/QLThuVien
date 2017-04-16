using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestThuVien.HeThong
{
    public class ChiTietMuonSach
    {
        private string _mahoivien;

        public string Mahoivien
        {
            get { return _mahoivien; }
            set { _mahoivien = value; }
        }
        private string _masach;

        public string Masach
        {
            get { return _masach; }
            set { _masach = value; }
        }
        private string _soluongmuon;

        public string Soluongmuon
        {
            get { return _soluongmuon; }
            set { _soluongmuon = value; }
        }
        private string _ngaymuon;

        public string Ngaymuon
        {
            get { return _ngaymuon; }
            set { _ngaymuon = value; }
        }
        private string _ngayhentra;

        public string Ngayhentra
        {
            get { return _ngayhentra; }
            set { _ngayhentra = value; }
        }
    }
}
