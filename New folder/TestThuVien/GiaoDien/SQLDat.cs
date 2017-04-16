using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace TestThuVien.GiaoDien
{
    class SQLDat
    {
        SqlConnection sqlcon;
        string cs;
        public SQLDat(string connectString)
        {
            sqlInit(connectString);
        }
        //--------Khoi tao sql----------------
        public void sqlInit(string connectString)
        {
            sqlcon = new SqlConnection(connectString);
        }
        //----Dong mo Sql---------
        void sqlOpen()
        {
            sqlcon.Open();
        }
        void sqlClose()
        {
            sqlcon.Close();
        }
        //---Lay du lieu ve datatable---------
       public DataTable sqlLayDuLieu (string nameSP,params SqlParameter[] para)
        {
            DataTable res=new DataTable();
            SqlDataReader reader=null;
            try
		    {
                SqlCommand cmd=new SqlCommand(nameSP,sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcon;
                sqlcon.Open();

                foreach (SqlParameter items in para)
                {
                    cmd.Parameters.Add(para);
                }
                reader = cmd.ExecuteReader();
            }
            finally
		    {
			    if (sqlcon != null)
			    {
                    sqlClose();
			    }
                if (reader != null)
                {
                    res.Load(reader);//lay du lieu ben trong sqlreader ve datatable de don gian hoa
                    reader.Close();
                }
		    }
            return res;
        }
        //chuyen cvt tu datatable to list view
       public void datatable2Listview(DataTable dt, ref ListView lv)
       {
           foreach (DataRow row in dt.Rows)
           {
               ListViewItem item = new ListViewItem(row[0].ToString());
               for (int i = 1; i < dt.Columns.Count; i++)
               {
                   item.SubItems.Add(row[i].ToString());
               }
               lv.Items.Add(item);
           }
       }
    }
}
