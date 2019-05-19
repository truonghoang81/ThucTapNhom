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
    public partial class DangNhap : Form
    {
        private NguoiDungBLL nguoidungbll;
        NguoiDungEntities nguoidungenti;
        public DangNhap()
        {
            InitializeComponent();
            nguoidungbll = new NguoiDungBLL();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDungBLL nguoidungbll = new NguoiDungBLL();
            string username = txtTenDN.Text.ToString();
            string password = txtMatKhauDN.Text.ToString();
            if (nguoidungbll.DangNhap(username, password))
            {
                Form1 form = new Form1();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("loi dang nhap hay dien day du thong tin", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Text = "";
                txtMatKhauDN.Text = "";
            }
        }

        private void btThoatDN_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau formquenmk = new QuenMatKhau();
            formquenmk.Show();
            Hide();
        }
    }
}
