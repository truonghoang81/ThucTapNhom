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
    class HocLucBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HocLuc";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(HocLucEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.HocLuc(MaHL,TenHL)values('" + obj.Mahocluc + "','" + obj.Tenhocluc + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkhocluc(string mahocluc)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HocLuc where MaHL='" +mahocluc + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(HocLucEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.HocLuc set TenHL='" + obj.Tenhocluc + "' where MaHL='" + obj.Mahocluc + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string mahocluc)
        {
            int result = 0;
            string strQuery = "delete from dbo.HocLuc where MaHL='" + mahocluc + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
    }

