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
    public partial class HocSinh : Form
    {
        public HocSinh()
        {
            InitializeComponent();
        }
        private string Query = "";
        private void Load_HocSinh()
        {
            HocSinhBLL hocsinhbll = new HocSinhBLL();
            dgvHocSinh.DataSource = hocsinhbll.GetData();
            HanhKiemBLL hanhkiembll = new HanhKiemBLL();
            cbbHanhKiem.DataSource = hanhkiembll.GetData();
            cbbHanhKiem.DisplayMember = "TenHK";
            cbbHanhKiem.ValueMember = "MaHK";
            HocLucBLL hoclucbll = new HocLucBLL();
            cbbHocLuc.DataSource = hoclucbll.GetData();
            cbbHocLuc.DisplayMember = "TenHK";
            cbbHocLuc.ValueMember = "MaHL";
            KhenThuongBLL khenthuongbll = new KhenThuongBLL();
            cbbKhenThuongHS.DataSource = khenthuongbll.GetData();
            cbbKhenThuongHS.DisplayMember = "TenKT";
            cbbKhenThuongHS.ValueMember = "MaKT";
            KyLuatBLL kyluatbll = new KyLuatBLL();
            cbbKyLuatHS.DataSource = kyluatbll.GetData();
            cbbKyLuatHS.DisplayMember = "TenKL";
            cbbKyLuatHS.ValueMember = "MaKL";
            LopBLL lopbll = new LopBLL();
            cbbTenLop.DataSource = lopbll.GetData();
            cbbTenLop.DisplayMember = "TenLop";
            cbbTenLop.ValueMember = "MaLop";
        }
        private void btThemHS_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButtonHS(2);
            txtMaHS.Text = "";
            txtHoTenHS.Text = "";
            dtpNgaySinhHS.Text = "";
            rdbNamHS.Text = "";
            rdbNuHS.Text = "";
            txtDiaChiHS.Text = "";
            txtDienThoai.Text = "";
            txtTenBoHS.Text = "";
            txtTenMeHS.Text = "";
            txtDiem.Text = "";
            cbbTenLop.SelectedValue = "";
            cbbHocLuc.SelectedValue = "";
            cbbHanhKiem.SelectedValue = "";
            cbbKyLuatHS.SelectedValue = "";
            cbbKhenThuongHS.SelectedValue = "";
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            Load_HocSinh();
            ControllButtonHS(1);
            this.KeyPreview = true;
        }
        private void ControllButtonHS(int type)
        {
            btThemHS.Visible = type == 1 ? true : false;
            btSuaHS.Visible = type == 1 ? true : false;
            btXoaHS.Visible = type == 1 ? true : false;
            btLuuHS.Visible = type == 2 ? true : false;
            btHuyHS.Visible = type == 2 ? true : false;
        }
        private void Excute_hocsinh(string query)
        {
            if (query == "them")
            {
                try
                {
                    HocSinhEntities hocsinhenti = new HocSinhEntities();
                    hocsinhenti.Mahocsinh = txtMaHS.Text.Trim();
                    hocsinhenti.Tenhocsinh = txtHoTenHS.Text.Trim();
                    hocsinhenti.Ngaysinh = dtpNgaySinhHS.Text.Trim();
                    if (rdbNamHS.Checked == true)
                    {
                        hocsinhenti.Gioitinh = true;
                    }
                    else if(rdbNuHS.Checked==true)
                    {
                        hocsinhenti.Gioitinh = false;
                    }
                    hocsinhenti.Diachi = txtDiaChiHS.Text.Trim();
                    hocsinhenti.Sodienthoai = txtDienThoai.Text.Trim();
                    hocsinhenti.Tenbo = txtTenBoHS.Text.Trim();
                    hocsinhenti.Tenme = txtTenMeHS.Text.Trim();
                    hocsinhenti.Diem = float.Parse(txtDiem.Text);
                    hocsinhenti.Malop = cbbTenLop.SelectedValue.ToString();
                    hocsinhenti.Hocluc = cbbHocLuc.SelectedValue.ToString();
                    hocsinhenti.Hanhkiem = cbbHanhKiem.SelectedValue.ToString();
                    hocsinhenti.Kyluat = cbbKyLuatHS.SelectedValue.ToString();
                    hocsinhenti.Khenthuong = cbbKhenThuongHS.SelectedValue.ToString();
                    HocSinhBLL hocsinhbll = new HocSinhBLL();
                    if (!(hocsinhbll.checkhocsinh(txtMaHS.Text.Trim())))
                    {
                        hocsinhbll.insert(hocsinhenti);
                        Load_HocSinh();
                    }
                    else
                        MessageBox.Show("ma " + txtMaHS + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    HocSinhEntities hocsinhenti = new HocSinhEntities();
                    hocsinhenti.Mahocsinh = txtMaHS.Text.Trim();
                    hocsinhenti.Tenhocsinh = txtHoTenHS.Text.Trim();
                    hocsinhenti.Ngaysinh = dtpNgaySinhHS.Text.Trim();
                    //if (rdbNam.Checked == true)
                    //{
                    //    giaovienenti.Gioitinh = "Nam";
                    //}
                    //else
                    //{
                    //    giaovienenti.Gioitinh = false;
                    //}
                    if (hocsinhenti.Gioitinh == true)
                    {
                        rdbNamHS.Checked = true;
                    }
                    else
                    {
                        rdbNuHS.Checked = true;
                    }
                    hocsinhenti.Diachi = txtDiaChiHS.Text.Trim();
                    hocsinhenti.Sodienthoai = txtDienThoai.Text.Trim();
                    hocsinhenti.Tenbo = txtTenBoHS.Text.Trim();
                    hocsinhenti.Tenme = txtTenMeHS.Text.Trim();
                    hocsinhenti.Diem = float.Parse(txtDiem.Text);
                    hocsinhenti.Malop = cbbTenLop.SelectedValue.ToString();
                    hocsinhenti.Hocluc = cbbHocLuc.SelectedValue.ToString();
                    hocsinhenti.Hanhkiem = cbbHanhKiem.SelectedValue.ToString();
                    hocsinhenti.Kyluat = cbbKyLuatHS.SelectedValue.ToString();
                    hocsinhenti.Khenthuong = cbbKhenThuongHS.SelectedValue.ToString();
                    HocSinhBLL hocsinhbll = new HocSinhBLL();
                    hocsinhbll.update(hocsinhenti);
                    Load_HocSinh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (query == "xoa")
            {
                try
                {
                    string mahocsinh = txtMaHS.Text.Trim();
                    HocSinhBLL hocsinhbll = new HocSinhBLL();
                    hocsinhbll.delete(mahocsinh);
                    Load_HocSinh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaHS_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButtonHS(2);
        }

        private void btXoaHS_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButtonHS(2);
        }

        private void btLuuHS_Click(object sender, EventArgs e)
        {
            Excute_hocsinh(Query);
            ControllButtonHS(1);
        }

        private void btHuyHS_Click(object sender, EventArgs e)
        {
            ControllButtonHS(1);
        }

        private void dgvHocSinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaHS.Text = dgvHocSinh["MaHS", index].Value.ToString();
            txtHoTenHS.Text = dgvHocSinh["TenHS", index].Value.ToString();
            dtpNgaySinhHS.Text = dgvHocSinh["NgaySinh", index].Value.ToString();
            rdbNamHS.Text = dgvHocSinh["GioiTinh", index].Value.ToString();
            rdbNuHS.Text = dgvHocSinh["GioiTinh", index].Value.ToString();
            txtDiaChiHS.Text= dgvHocSinh["DiaChi", index].Value.ToString();
            txtDienThoai.Text= dgvHocSinh["SDT", index].Value.ToString();
            txtTenBoHS.Text= dgvHocSinh["TenBo", index].Value.ToString();
            txtTenMeHS.Text= dgvHocSinh["TenMe", index].Value.ToString();
            txtDiem.Text= dgvHocSinh["DiemTB", index].Value.ToString();
            cbbTenLop.SelectedValue= dgvHocSinh["LopHocMa", index].Value.ToString();
            cbbHocLuc.SelectedValue= dgvHocSinh["HocLucMa", index].Value.ToString();
            cbbHanhKiem.SelectedValue= dgvHocSinh["HanhKiemMa", index].Value.ToString();
            cbbKyLuatHS.SelectedValue= dgvHocSinh["KyLuatMa", index].Value.ToString();
            cbbKhenThuongHS.SelectedValue = dgvHocSinh["KhenThuongMa", index].Value.ToString();
        }

        private void btTimKiemHS_Click(object sender, EventArgs e)
        {
            string _item = txtTimKiemHS.Text.Trim();
            HocSinhBLL hocsinhbll = new HocSinhBLL();
            dgvHocSinh.DataSource = hocsinhbll.Find_hocsinh(_item);
        }

        private void HocSinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    btThemHS_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    btHuyHS_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.E))
                {
                    btThoatHS_Click(null, null);
                }
            }
        }

        private void btThoatHS_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

    }
}
