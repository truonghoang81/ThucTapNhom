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
    class BoMonBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.BoMon";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(BoMonEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.BoMon(MaBM,TenBM)values('" + obj.Mabomon + "','" + obj.Tenbomon + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkbomon(string mabomon)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.BoMon where MaBM='" + mabomon + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(BoMonEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.BoMon set TenBM='" + obj.Tenbomon + "' where MaBM='" + obj.Mabomon + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string mabomon)
        {
            int result = 0;
            string strQuery = "delete from dbo.BoMon where MaBM='" + mabomon + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
    }

