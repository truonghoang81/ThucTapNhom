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
    class HocSinhBLL
    {
        public DataTable GetData()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HocSinh";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable Find_hocsinh(string item)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HocSinh where TenHS like'%" + item + "%'";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable SapXepDiem()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select TenHS,DiemTB,DiaChi,TenBo,TenMe from dbo.HocSinh order by DiemTB desc,TenHS,DiaChi,TenBo,TenMe";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable TopHocSinhDiemCao()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select Top 5* from dbo.HocSinh order by DiemTB desc";
            result = config.GetData(strQuery);
            return result;
        }
        public DataTable TongHopDiem()
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();
            string strQuery = "select sum(DiemTB)as TongDiem,max(DiemTB) DiemCaoNhat,min(DiemTB)DiemThapNhat,avg(DiemTB)DiemTrungBinh from dbo.HocSinh";
            result = config.GetData(strQuery);
            return result;
        }
        public int insert(HocSinhEntities obj)
        {
            int result = 0;
            string strQuery = "insert into dbo.HocSinh(MaHS,TenHS,NgaySinh,GioiTinh,DiaChi,DienThoai,TenBo,TenMe,DiemTB,LopHocMa,HocLucMa,HanhKiemMa,KyLuatMa,KhenThuongMa)values('" + obj.Mahocsinh + "','" + obj.Tenhocsinh + "','" + obj.Ngaysinh + "','" + obj.Gioitinh + "','" + obj.Diachi + "','" + obj.Sodienthoai + "','" + obj.Tenbo + "','" + obj.Tenme + "','" + obj.Diem + "','" + obj.Malop + "','" + obj.Hocluc + "','" + obj.Hanhkiem + "','" + obj.Kyluat + "','" + obj.Khenthuong + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public bool checkhocsinh(string mahocsinh)
        {
            bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select *from dbo.HocSinh where MaHS='" + mahocsinh + "'";
            DataTable dt = new DataTable();
            dt = config.GetData(strQuery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public int update(HocSinhEntities obj)
        {
            int result = 0;
            string strQuery = "update dbo.HocSinh set TenHS='" + obj.Tenhocsinh + "',NgaySinh='" + obj.Ngaysinh + "',GioiTinh='" + obj.Gioitinh + "',DiaChi='" + obj.Diachi + "',DienThoai='" + obj.Sodienthoai + "',TenBo='" + obj.Tenbo + "',TenMe='" + obj.Tenme + "',DiemTB='" + obj.Diem + "',LopHocMa='" + obj.Malop + "',HocLucMa='" + obj.Hocluc + "',HanhKiemMa='"+obj.Hanhkiem+"',KyLuatMa='" + obj.Kyluat + "',KhenThuongMa='" + obj.Khenthuong + "' where MaHS='" + obj.Mahocsinh + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
        public int delete(string mahocsinh)
        {
            int result = 0;
            string strQuery = "delete from dbo.HocSinh where MaHS='" + mahocsinh + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNonquery(strQuery);
            return result;
        }
    }
}
