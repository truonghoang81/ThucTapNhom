using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoVienHS.Entities;
using QuanLyGiaoVienHS.DataAcess;
using System.Data;

namespace QuanLyGiaoVienHS.Business
{
    class NguoiDungBLL
    {
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.NguoiDung";
            result = config.GetData(strQuery);
            return result;
        }
        // public DataTable Finditem_matkhau(string username,string thongtin)
        public DataTable quenmatkhau(string username)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.NguoiDung where username='" + username + "'";
            result = config.GetData(strQuery);
            return result;
        }
        public bool DangNhap(string username, string pass)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from NguoiDung where username='" + username + "'and pass='" +pass + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }
        public int update(NguoiDungEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.NguoiDung set pass='" + obj.Pass + "' where username='" + obj.Username + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }

        internal bool QuenMatKhau(string username,string xacnhan)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.NguoiDung where username='" + username + "' and xacnhan='"+xacnhan+"'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
