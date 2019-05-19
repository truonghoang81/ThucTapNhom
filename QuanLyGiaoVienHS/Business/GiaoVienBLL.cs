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
    class GiaoVienBLL
    {
         public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.GiaoVien";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable Find_giaovien(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.GiaoVien where MaGV like'%" + item + "%'";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable soluonggv()
        {
            DataTable result = new DataTable();
            DataConfig config=new DataConfig();
            string strQuery = "select count(MaGV)from dbo.GiaoVien ";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable SapXepTiet()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select TenGV,DiaChi,Luong,SoTietDay from dbo.GiaoVien order by SoTietDay desc,TenGV,Luong,DiaChi";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable SapXepLuong()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select TenGV,DiaChi,Luong,SDT from dbo.GiaoVien order by Luong desc,TenGV,DiaChi,SDT";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable TongHopLuong()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select sum(Luong)as TongLuong,max(Luong) LuongCaoNhat,min(Luong)LuongThapNhat,avg(Luong)LuongTrungBinh from GiaoVien";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(GiaoVienEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.GiaoVien(MaGV,TenGV,NgaySinh,GioiTinh,DiaChi,SDT,Luong,SoTietDay,ghichu,LopMa,ChucVuMa,BoMonMa,KTMa,KLMa)values('" +obj.Magiaovien+"','"+obj.Tengiaovien+"','"+obj.Ngaysinh+"','"+obj.Gioitinh+"','"+obj.Diachi+"','"+obj.Sodienthoai+"','"+obj.Luong+"','"+obj.Sotietday+"','"+obj.Ghichu+"','"+obj.Malop+"','"+obj.Chucvu+"','"+obj.Bomon+"','"+obj.Khenthuong+"','"+obj.Kyluat+"')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkgiaovien(string magiaovien)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.GiaoVien where MaGV='" + magiaovien + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(GiaoVienEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.GiaoVien set TenGV='" + obj.Tengiaovien + "',NgaySinh='" + obj.Ngaysinh + "',GioiTinh='"+obj.Gioitinh+"',DiaChi='"+obj.Diachi+"',SDT='"+obj.Sodienthoai+"',Luong='"+obj.Luong+"',SoTietDay='"+obj.Sotietday+"',ghichu='"+obj.Ghichu+"',LopMa='"+obj.Malop+"',ChucVuMa='"+obj.Chucvu+"',BoMonMa='"+obj.Bomon+"',KTMa='"+obj.Khenthuong+"',KLMa='"+obj.Kyluat+"' where MaGV='" + obj.Magiaovien + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string magiaovien)
        {
            int result = 0;
            string strQuery = "delete from dbo.GiaoVien where MaGV='" + magiaovien + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
}
