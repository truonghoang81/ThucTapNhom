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
    class KhenThuongBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.KhenThuong";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(KhenThuongEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.KhenThuong(MaKT,TenKT)values('" + obj.Makhenthuong + "','" + obj.Tenkhenthuong + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkkhenthuog(string makhenthuong)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.KhenThuong where MaKT='" + makhenthuong + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(KhenThuongEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.KhenThuong set TenKT='" + obj.Tenkhenthuong + "' where MaKT='" + obj.Makhenthuong+ "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string makhenthuong)
        {
            int result = 0;
            string strQuery = "delete from dbo.KhenThuong where MaKT='" + makhenthuong + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
    }

