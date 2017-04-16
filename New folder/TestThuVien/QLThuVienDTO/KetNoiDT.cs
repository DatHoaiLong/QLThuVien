using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace TestThuVien.QLThuVienDTO
{
    public class KetNoiDT
    {
        public static SqlConnection connect;
        public void MoKetNoi()
        {
            if(KetNoiDT.connect ==null)
                {
                    KetNoiDT.connect = new SqlConnection("Data Source=DESKTOP-E8DMDAE\\SQLEXPRESS;Initial Catalog=ThuVienSo;Integrated Security=SSPI;");
                }
            if (KetNoiDT.connect.State != ConnectionState.Open)
            {
                KetNoiDT.connect.Open();
            }
        }
        public void DongKetNoi()
        {
            if (KetNoiDT.connect != null)
            {
                if (KetNoiDT.connect.State == ConnectionState.Open)
                    KetNoiDT.connect.Close();
            }
        }
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {

            }

        }
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDataTable2(string cmd)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(cmd,connect);
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string strSQL)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {
                temp = sqldr[0].ToString();
                DongKetNoi();
                return temp;
            }
            return temp;
        }

        public DataTable sqlLayDuLieu(string nameSP, params SqlParameter[] para)
        {
            DataTable res = new DataTable();
            SqlDataReader reader = null;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(nameSP, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connect;
                foreach (SqlParameter items in para)
                {
                    cmd.Parameters.Add(items);
                }
                reader = cmd.ExecuteReader();
            }
            finally
            {
                if (reader != null)
                {
                    res.Load(reader);//lay du lieu ben trong sqlreader ve datatable de don gian hoa
                    reader.Close();
                }
                DongKetNoi();
               
            }
            return res;
        }
        public void sqlThucThi(string nameSP, params SqlParameter[] para)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(nameSP, connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connect;
                foreach (SqlParameter items in para)
                {
                    cmd.Parameters.Add(items);
                }
                cmd.ExecuteNonQuery();
            }
            finally
            {
      
                DongKetNoi();
            }
        }

    }

}
