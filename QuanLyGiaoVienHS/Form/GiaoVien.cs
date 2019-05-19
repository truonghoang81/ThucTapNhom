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
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }
        private string Query = "";

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            Load_giaovien();
            ControllButtonGV(1);
            this.KeyPreview = true;
        }
        private void Load_giaovien()
        {
            GiaoVienBLL giaovienbll = new GiaoVienBLL();
            dgvGiaoVien.DataSource = giaovienbll.GetData();
            ChucVuBLL chucvubll = new ChucVuBLL();
            cbbChucVuGV.DataSource=chucvubll.GetData();
            cbbChucVuGV.DisplayMember="TenCV";
            cbbChucVuGV.ValueMember = "MaCV";
            BoMonBLL bomonbll = new BoMonBLL();
            cbbBoMon.DataSource=bomonbll.GetData();
            cbbBoMon.DisplayMember = "TenBM";
            cbbBoMon.ValueMember = "MaBM";
            KhenThuongBLL khenthuongbll = new KhenThuongBLL();
            cbbKhenThuongGV.DataSource = khenthuongbll.GetData();
            cbbKhenThuongGV.DisplayMember = "TenKT";
            cbbKhenThuongGV.ValueMember = "MaKT";
            KyLuatBLL kyluatbll = new KyLuatBLL();
            cbbKyLuatGV.DataSource = kyluatbll.GetData();
            cbbKyLuatGV.DisplayMember = "TenKL";
            cbbKyLuatGV.ValueMember = "MaKL";
            LopBLL lopbll = new LopBLL();
            cbbLopGiangDay.DataSource = lopbll.GetData();
            cbbLopGiangDay.DisplayMember = "TenLop";
            cbbLopGiangDay.ValueMember = "MaLop";
        }
        private void ControllButtonGV(int type)
        {
            bttThemGV.Visible = type == 1 ? true : false;
            btSuaGV.Visible = type == 1 ? true : false;
            btXoaGV.Visible = type == 1 ? true : false;
            btHuyGV.Visible = type == 2 ? true : false;
            btLuuGV.Visible = type == 2 ? true : false;
        }
        private void bttThemGV_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButtonGV(2);
            txtMaGV.Text = "";
            txtHoTenGV.Text = "";
            dtpGiaoVien.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txtDiaChiGV.Text = "";
            txtSDTGV.Text = "";
            txtLuong.Text = "";
            txtSoTietDay.Text = "";
            rtbGhuChuGV.Text = "";
            cbbLopGiangDay.SelectedValue = "";
            cbbChucVuGV.SelectedValue = "";
            cbbBoMon.SelectedValue = "";
            cbbKhenThuongGV.SelectedValue = "";
            cbbKyLuatGV.SelectedValue = "";
        }
        private void Excute_giaovien(string query)
        {
            if (query == "them")
            {
                try
                {
                    GiaoVienEntities giaovienenti = new GiaoVienEntities();
                    giaovienenti.Magiaovien = txtMaGV.Text.Trim();
                    giaovienenti.Tengiaovien = txtHoTenGV.Text.Trim();
                    giaovienenti.Ngaysinh = dtpGiaoVien.Text.Trim();
                    //if (rdbNam.Checked == true)
                    //{
                    //    giaovienenti.Gioitinh = "Nam";
                    //}
                    //else
                    //{
                    //    giaovienenti.Gioitinh = false;
                    //}
                    if (giaovienenti.Gioitinh ==true)
                    {
                        rdbNam.Checked = true;
                    }
                    else
                    {
                        rdbNu.Checked = true;
                    }
                    giaovienenti.Diachi = txtDiaChiGV.Text.Trim();
                    giaovienenti.Sodienthoai = txtSDTGV.Text.Trim();
                    giaovienenti.Luong = int.Parse(txtLuong.Text);
                    giaovienenti.Sotietday = int.Parse(txtSoTietDay.Text);
                    giaovienenti.Ghichu = rtbGhuChuGV.Text.Trim();
                    giaovienenti.Malop = cbbLopGiangDay.SelectedValue.ToString();
                    giaovienenti.Chucvu = cbbChucVuGV.SelectedValue.ToString();
                    giaovienenti.Bomon = cbbBoMon.SelectedValue.ToString();
                    giaovienenti.Khenthuong = cbbKhenThuongGV.SelectedValue.ToString();
                    giaovienenti.Kyluat = cbbKyLuatGV.SelectedValue.ToString();
                    GiaoVienBLL giaovienbll = new GiaoVienBLL();
                    if (!(giaovienbll.checkgiaovien(txtMaGV.Text.Trim())))
                    {
                       giaovienbll.insert(giaovienenti);
                        Load_giaovien();
                    }
                      else
                        MessageBox.Show("ma " + txtMaGV + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("them bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (query == "sua")
            {
                try
                {
                    GiaoVienEntities giaovienenti = new GiaoVienEntities();
                    giaovienenti.Magiaovien = txtMaGV.Text.ToString();
                    giaovienenti.Tengiaovien = txtHoTenGV.Text.ToString();
                    giaovienenti.Ngaysinh = dtpGiaoVien.Text.ToString();
                    if (rdbNam.Checked == true)
                    {
                        giaovienenti.Gioitinh = true;
                    }
                    else
                    {
                        giaovienenti.Gioitinh = false;
                    }
                    giaovienenti.Diachi = txtDiaChiGV.Text.Trim();
                    giaovienenti.Sodienthoai = txtSDTGV.Text.Trim();
                    giaovienenti.Luong = int.Parse(txtLuong.Text);
                    giaovienenti.Sotietday = int.Parse(txtSoTietDay.Text);
                    giaovienenti.Ghichu = rtbGhuChuGV.Text.Trim();
                    giaovienenti.Malop = cbbLopGiangDay.SelectedValue.ToString();
                    giaovienenti.Chucvu = cbbChucVuGV.SelectedValue.ToString();
                    giaovienenti.Bomon = cbbBoMon.SelectedValue.ToString();
                    giaovienenti.Khenthuong = cbbKhenThuongGV.SelectedValue.ToString();
                    giaovienenti.Kyluat = cbbKyLuatGV.SelectedValue.ToString();
                    GiaoVienBLL giaovienbll = new GiaoVienBLL();
                    giaovienbll.update(giaovienenti);
                    Load_giaovien();
                     }
                 catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                }
            if(query=="xoa"){
                try{
                string magiaovien=txtMaGV.Text.Trim();
                GiaoVienBLL giaovienbll=new GiaoVienBLL();
                    giaovienbll.delete(magiaovien);
                    Load_giaovien();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void btSuaGV_Click(object sender, EventArgs e)
        {
            Query="sua";
            ControllButtonGV(2);
        }

        private void btXoaGV_Click(object sender, EventArgs e)
        {
           Query="xoa";
            ControllButtonGV(2);
        }

        private void btLuuGV_Click(object sender, EventArgs e)
        {
            Excute_giaovien(Query);
            ControllButtonGV(1);
        
        }

        private void btHuyGV_Click(object sender, EventArgs e)
        {
        ControllButtonGV(1);
        }

        private void dgvGiaoVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaGV.Text = dgvGiaoVien["MaGV", index].Value.ToString();
            txtHoTenGV.Text = dgvGiaoVien["TenGV", index].Value.ToString();
            dtpGiaoVien.Text = dgvGiaoVien["NgaySinh", index].Value.ToString();
           // dtpGiaoVien.Text = dgvGiaoVien["NamSinh", index].Value.ToString();
            rdbNam.Checked = dgvGiaoVien["GioiTinh", index].Value.Equals(rdbNam);
            rdbNu.Text = dgvGiaoVien["GioiTinh", index].Value.ToString();
            txtDiaChiGV.Text = dgvGiaoVien["DiaChi", index].Value.ToString();
            txtSDTGV.Text = dgvGiaoVien["SDT", index].Value.ToString();
            txtLuong.Text = dgvGiaoVien["Luong", index].Value.ToString();
            txtSoTietDay.Text = dgvGiaoVien["SoTietDay", index].Value.ToString();
            rtbGhuChuGV.Text = dgvGiaoVien["ghichu", index].Value.ToString();
            cbbLopGiangDay.SelectedValue = dgvGiaoVien["LopMa", index].Value.ToString();
            cbbChucVuGV.SelectedValue = dgvGiaoVien["ChucVuMa", index].Value.ToString();
            cbbBoMon.SelectedValue = dgvGiaoVien["BoMonMa", index].Value.ToString();
            cbbKyLuatGV.SelectedValue = dgvGiaoVien["KLMa", index].Value.ToString();
            cbbKhenThuongGV.SelectedValue = dgvGiaoVien["KTMa", index].Value.ToString();

        }

        private void btTimKiemGV_Click(object sender, EventArgs e)
        {
            //string item=txtHoTenGV.Text.Trim();
            string _item = txtTimKiemGV.Text.Trim();
            GiaoVienBLL giaovienbll = new GiaoVienBLL();
            dgvGiaoVien.DataSource = giaovienbll.Find_giaovien(_item);
        }

        private void txtTongSoGV_TextChanged(object sender, EventArgs e)
        {
            GiaoVienBLL giaovienbll = new GiaoVienBLL();
          ////  txtTongSoGV.Text = txtTongSoGV["MaGV"].ToString();
        }
        private void btThoatGV_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void GiaoVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    btLuuGV_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    btHuyGV_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.E))
                {
                    btThoatGV_Click(null, null);
                }
            }
        }
     }
 }

