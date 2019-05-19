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
    public partial class QuenMatKhau : Form
    {
        private NguoiDungBLL nguoidungbll;
        NguoiDungEntities nguoidungenti;
        public QuenMatKhau()
        {
            InitializeComponent();
            nguoidungbll = new NguoiDungBLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiDungBLL nguoidungbll = new NguoiDungBLL();
            string username = txtTenDN.Text.Trim();
             string thongtin = txtThongTin.Text.Trim();
            if (nguoidungbll.QuenMatKhau(username,thongtin))
            {
                MessageBox.Show("mat khau la", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("loi dang nhap hay dien day du thong tin", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Text = "";
                txtThongTin.Text = "";
            }
        }
    }
}
