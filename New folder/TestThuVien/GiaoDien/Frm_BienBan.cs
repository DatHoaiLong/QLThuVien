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
    public partial class Frm_BienBan : Form
    {
        public string tenhoivien, mahoivien;
        public Frm_BienBan()
        {
            InitializeComponent();
        }
        public void truyendulieu(string thv,string mhv)
        {
            tenhoivien = thv;
            mahoivien = mhv;
            txt_TenHV.Text = tenhoivien;
            txt_MaHV.Text = mahoivien;
        }

        private void but_Tim_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
                this.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            /*tieu de*/
            /*e.Graphics.DrawString("Biên Bản Vi Phạm",new Font("Arial",18,FontStyle.Bold),Brushes.Black,250,50);*/
            e.Graphics.DrawString("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 220, 50);
            e.Graphics.DrawString("Độc Lập - Tự Do - Hạnh Phúc", new Font("Arial", 12), Brushes.Black, 330, 80);
            e.Graphics.DrawString("***************************", new Font("Arial", 11), Brushes.Black, 360, 110);
            e.Graphics.DrawString("Biên Bản Vi Phạm", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 310, 160);
            /*ngay thang nam*/
            e.Graphics.DrawString("Thư viện .............................. Ngày........Tháng........Năm..........", new Font("Arial", 12), Brushes.Black,200,230);
            /*ma hoi vien */
            e.Graphics.DrawString("Mã hội viên :", new Font("Arial", 12), Brushes.Black, 200, 270);
            e.Graphics.DrawString(txt_MaHV.Text, new Font("Arial", 12), Brushes.Black, 350, 270);
            /*ten hoi vien*/
            e.Graphics.DrawString("Tên hội viên :", new Font("Arial", 12), Brushes.Black, 200, 310);
            e.Graphics.DrawString(txt_TenHV.Text, new Font("Arial", 12), Brushes.Black, 350, 310);
            /*vi pham*/
            e.Graphics.DrawString("Vi phạm :", new Font("Arial", 12), Brushes.Black, 200, 350);
            e.Graphics.DrawString(comb_ViPham.Text, new Font("Arial", 12), Brushes.Black, 350, 350);
            /*Hình thuc xu phat*/
            e.Graphics.DrawString("Hình thức xử phạt :", new Font("Arial", 12), Brushes.Black, 200, 390);
            e.Graphics.DrawString(txt_HinhThucXuLy.Text, new Font("Arial", 12), Brushes.Black, 350, 390);
            /*ket thuc*/
            e.Graphics.DrawString("Người vi phạm", new Font("Arial", 12,FontStyle.Bold), Brushes.Black, 100, 500);
            e.Graphics.DrawString("Người lập biên bản", new Font("Arial", 12,FontStyle.Bold), Brushes.Black, 600,500);


        }

        private void comb_ViPham_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

      
    }
}
