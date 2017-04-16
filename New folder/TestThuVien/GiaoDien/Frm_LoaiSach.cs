using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestThuVien.GiaoDien
{
    public partial class Frm_LoaiSach : Form
    {
        string phanloaisach="";

        public string Phanloaisach
        {
            get { return phanloaisach; }
            set { phanloaisach = value; }
        }

        public Frm_LoaiSach()
        {
            InitializeComponent();
        }

        private void but_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            phanloaisach = txt_TenLoaiSach.Text;
            if (txt_TenLoaiSach.TextLength == 0)
                phanloaisach = "";
            this.Close();
        }
    }
}
