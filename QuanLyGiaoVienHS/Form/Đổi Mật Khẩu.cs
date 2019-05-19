using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoVienHS.Entities;
using QuanLyGiaoVienHS.Business;

namespace QuanLyGiaoVienHS
{
    public partial class Đổi_Mật_Khẩu : Form
    {
        public Đổi_Mật_Khẩu()
        {
            InitializeComponent();
        }

        private void btXacNhanMK_Click(object sender, EventArgs e)
        {
            NguoiDungBLL nguoidungbll = new NguoiDungBLL();
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhauCu.Text.Trim();
            string passwordnew = txtMatKhauMoi.Text.Trim();
            string xacnhanpass = txtXacNhanMK.Text.Trim();
            NguoiDungEntities nguoidungenti = new NguoiDungEntities();
            nguoidungenti.Username = txtTenDangNhap.Text.Trim();
            nguoidungenti.Pass = txtMatKhauCu.Text.Trim();
            nguoidungenti.Pass= txtMatKhauMoi.Text.Trim();
            nguoidungenti.Pass = txtXacNhanMK.Text.Trim();
            if (nguoidungbll.DangNhap(username, password))
            {
                nguoidungbll.update(nguoidungenti);
                MessageBox.Show("thay doi thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("thay doi that bai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Text = "";
                txtMatKhauCu.Text = "";
                txtMatKhauMoi.Text = "";
                txtXacNhanMK.Text = "";
            }
        }

        private void btThoatDoiMK_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }
    }
}
