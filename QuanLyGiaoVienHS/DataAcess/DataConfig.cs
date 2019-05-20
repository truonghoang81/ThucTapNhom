using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyGiaoVienHS.DataAcess
{
    class DataConfig
    {
         private SqlConnection conn;
        public string strConnec = @"Data Source=DESKTOP-B0FB2OS\SQLEXPRESS;Initial Catalog=QuanLyGVHS;Integrated Security=True";

        public DataConfig()
        {
          connect();
        }
        public void connect()
        {
            try
            {
                conn = new SqlConnection(strConnec);//khoi tao connect
                conn.Open();
                if (conn.State == ConnectionState.Open)//neu ket noi dang mo thi dong
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ket noi loi" + ex.Message.ToString());
            }
        }
        public DataTable GetData(string strSql)
        {
            DataTable result = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql,conn);
            da.Fill(result);
            return result;
        }
        //them sua xoa
        public int excuteNonquery(string sql)
        {
            int result = 0;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;//lenh truy van
            result = cmd.ExecuteNonQuery();
            return result;
        }
        //tra ve doi tuong
        public object excuteScalarQuery(string sql)
        {
            object result = 0;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            result = cmd.ExecuteScalar();
            return result;//chuyen kieu khi su dung object
        }
    }
    }

