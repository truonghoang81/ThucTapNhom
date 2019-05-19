using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoVienHS.Business;
using QuanLyGiaoVienHS.Entities;

namespace QuanLyGiaoVienHS
{
    public partial class TongHop : Form
    {
        public TongHop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVienBLL giaovienbll=new GiaoVienBLL();
            
            if (rdbSXTiet.Checked == true)
            {
                dgvTongHop.DataSource = giaovienbll.SapXepTiet();
            }
            if (rdbSXLuong.Checked == true)
            {
                dgvTongHop.DataSource = giaovienbll.SapXepLuong();
            }
            if (rdbThongKeLuong.Checked == true)
            {
                dgvTongHop.DataSource = giaovienbll.TongHopLuong();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocSinhBLL hocsinhbll = new HocSinhBLL();
            if (rdbSXDiem.Checked == true)
            {
                dgvTongHop.DataSource = hocsinhbll.SapXepDiem();
            }
            if (rdbTopDiem.Checked == true)
            {
                dgvTongHop.DataSource = hocsinhbll.TopHocSinhDiemCao();
            }
            if (rdbThongKeDiem.Checked == true)
            {
                dgvTongHop.DataSource = hocsinhbll.TongHopDiem();
            }
        }

        private void btThoatTongHop_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void btTruyCapChung_Click(object sender, EventArgs e)
        {
            ChucVuBLL chucvubll = new ChucVuBLL();
            BoMonBLL bomonbll = new BoMonBLL();
            HocLucBLL hoclucbll = new HocLucBLL();
            HanhKiemBLL hanhkiembll = new HanhKiemBLL();
            KhenThuongBLL khenthuongbll = new KhenThuongBLL();
            KyLuatBLL kyluatbll = new KyLuatBLL();
            if (rdbBoMon.Checked == true)
            {
                dgvTongHop.DataSource = bomonbll.GetData();
            }
            if (rdbChucVu.Checked == true)
            {
                dgvTongHop.DataSource = chucvubll.GetData();
            }
            if (rdbHocLuc.Checked == true)
            {
                dgvTongHop.DataSource = hoclucbll.GetData();
            }
            if (rdbHanhKiem.Checked == true)
            {
                dgvTongHop.DataSource = hanhkiembll.GetData();
            }
            if (rdbKhenThuong.Checked == true)
            {
                dgvTongHop.DataSource = khenthuongbll.GetData();
            }
            if (rdbKyLuat.Checked == true)
            {
                dgvTongHop.DataSource = kyluatbll.GetData();
            }
        }
    }
}
