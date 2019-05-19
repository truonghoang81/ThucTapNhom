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
    class HanhKiemBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HanhKiem";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(HanhKiemEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.HanhKiem(MaHK,TenHK)values('" + obj.Mahanhkiem + "','" + obj.Tenhanhkiem + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkhanhiem(string mahanhkiem)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HanhKiem where MaHK='" + mahanhkiem + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(HanhKiemEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.HanhKiem set TenHK='" + obj.Tenhanhkiem + "' where MaHK='" + obj.Mahanhkiem + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string mahanhkiem)
        {
            int result = 0;
            string strQuery = "delete from dbo.HanhKiem where MaHK='" + mahanhkiem + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
    }

