using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVienHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap formdangnhap = new DangNhap();
            formdangnhap.Show();
            Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đổi_Mật_Khẩu formdoimk = new Đổi_Mật_Khẩu();
            formdoimk.Show();
            Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoVien formgiaovien = new GiaoVien();
            formgiaovien.Show();
            Hide();
        }

        private void hócinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HocSinh formhocsinh = new HocSinh();
            formhocsinh.Show();
            Hide();
        }

        private void dữLiệuChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuLieuChung formdulieuchung = new DuLieuChung();
            formdulieuchung.Show();
            Hide();
        }

        private void dữLiệuRiêngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuLieuRieng formdulieurieng = new DuLieuRieng();
            formdulieurieng.Show();
            Hide();
        }

        private void tổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHop formtonghop = new TongHop();
            formtonghop.Show(); 
            Hide();
        }

        private void huoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan formhuongdan = new HuongDan();
            formhuongdan.Show();
            Hide();
        }
    }
}
