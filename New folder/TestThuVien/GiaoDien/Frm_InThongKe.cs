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
    public partial class Frm_InThongKe : Form
    {
        public Frm_InThongKe()
        {
            InitializeComponent();
        }

        private void Frm_InThongKe_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            reportViewer1.Reset();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;


            DataSet1 dataset = new DataSet1();
            dataset.BeginInit();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataset.Tables["dtKho"]));
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.LocalReport.ReportPath = "../../In.rdlc";


            dataset.EndInit();
            string connect = "Data Source=DESKTOP-E8DMDAE\\SQLEXPRESS;Initial Catalog=ThuVienSo;Integrated Security=true";


            DataSet1TableAdapters.dtKhoTableAdapter takho = new DataSet1TableAdapters.dtKhoTableAdapter();
            takho.Connection.ConnectionString = connect;
            takho.ClearBeforeFill = true;
            takho.Fill(dataset.dtKho);
            this.reportViewer1.RefreshReport();
        }
    }
}
