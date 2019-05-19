using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoVienHS.DataAcess;
using QuanLyGiaoVienHS.Entities;
using System.Data;

namespace QuanLyGiaoVienHS.Business
{
    class LopBLL
    {
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.Lop";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(LopEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.Lop(MaLop,TenLop,KhoaHoc)values('" + obj.Malop + "','" + obj.Tenlop + "','" + obj.Khoahoc + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checklop(string malop)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.Lop where MaLop='" + malop + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(LopEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.Lop set TenLop='" + obj.Tenlop + "',KhoaHoc='" + obj.Khoahoc + "' where MaLop='" + obj.Malop + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string malop)
        {
            int result = 0;
            string strQuery = "delete from dbo.Lop where MaLop='" + malop + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
}
