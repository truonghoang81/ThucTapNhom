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
    class ChucVuBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.ChucVu";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(ChucVuEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.ChucVu(MaCV,TenCV)values('" + obj.Machucvu + "','" + obj.Tenchucvu + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkchucvu(string machucvu)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.ChucVu where MaCV='" + machucvu + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(ChucVuEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.ChucVu set TenCV='" + obj.Tenchucvu + "'where MaCV='" + obj.Machucvu + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string machucvu)
        {
            int result = 0;
            string strQuery = "delete from dbo.ChucVu where MaCV='" + machucvu + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
    }

