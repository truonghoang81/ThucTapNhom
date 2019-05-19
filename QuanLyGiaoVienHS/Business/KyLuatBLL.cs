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
    class KyLuatBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.KyLuat";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(KyLuatEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.KyLuat(MaKL,TenKL)values('" + obj.Makyluat + "','" + obj.Tenkyluat+ "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkkyluat(string makyluat)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.KyLuat where MaKL='" + makyluat + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(KyLuatEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.KyLuat set TenKL='" + obj.Tenkyluat + "'where MaKL='" + obj.Makyluat + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string makyluat)
        {
            int result = 0;
            string strQuery = "delete from dbo.KyLuat where MaKL='" + makyluat + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
    }

