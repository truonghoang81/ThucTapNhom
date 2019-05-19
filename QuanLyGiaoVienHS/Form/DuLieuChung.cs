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
    public partial class DuLieuChung : Form
    {
        public DuLieuChung()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string Query = "";
        private void DuLieuChung_Load(object sender, EventArgs e)
        {
            Load_Lop();
            Load_KhenThuong();
            Load_KyLuat();
            ControllButton(1);
            ControllButtonKL(1);
            ControllButtonKT(1);
            this.KeyPreview = true;
        }
        private void Load_Lop()
        {
            LopBLL lopbll = new LopBLL();
            dgvLop.DataSource = lopbll.GetData();
        }
        private void Load_KhenThuong()
        {
            KhenThuongBLL khenthuongbll = new KhenThuongBLL();
            dgvKhenThuong.DataSource = khenthuongbll.GetData();
        }
        private void Load_KyLuat()
        {
            KyLuatBLL kyluatbll = new KyLuatBLL();
            dgvKyLuat.DataSource = kyluatbll.GetData();
        }
        private void btThemLop_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButton(2);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoaHoc.Text = "";
        }
        private void Excute_lop(string query)
        {
            if (query == "them")
            {
                try
                {
                    LopEntities lopenti = new LopEntities();
                    lopenti.Malop = txtMaLop.Text.Trim();
                    lopenti.Tenlop = txtTenLop.Text.Trim();
                    lopenti.Khoahoc = txtKhoaHoc.Text.Trim();
                    LopBLL lopbll = new LopBLL();
                    if(!(lopbll.checklop(txtMaLop.Text.Trim()))){
                        lopbll.insert(lopenti);
                        Load_Lop();
                    }
                    else
                        MessageBox.Show("ma lop"+txtMaLop+"da ton tai","thong bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                catch(Exception ex){
                    MessageBox.Show("them bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if(query=="sua")
            {
                try
                {
                    LopEntities lopenti = new LopEntities();
                    lopenti.Malop = txtMaLop.Text.Trim();
                    lopenti.Tenlop = txtTenLop.Text.Trim();
                    lopenti.Khoahoc = txtKhoaHoc.Text.Trim();
                    LopBLL lopbll = new LopBLL();
                    lopbll.update(lopenti);
                    Load_Lop();
                }
                 catch (Exception ex)
                {
                    MessageBox.Show("sua bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if(query=="xoa"){
                try{
                    string malop=txtMaLop.Text.Trim();
                    LopBLL lopbll=new LopBLL();
                    lopbll.delete(malop);
                    Load_Lop();
                }
                 catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void btSuaLop_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButton(2);
        }

        private void btHuyLop_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButton(2);
        }

        private void btLuuChung_Click(object sender, EventArgs e)
        {
            
        }

        private void btHuyChung_Click(object sender, EventArgs e)
        {
            ControllButton(1);
        }
        private void ControllButton(int type)
        {
            btThemLop.Visible = type == 1 ? true : false;
            btSuaLop.Visible = type == 1 ? true : false;
            btXoaLop.Visible = type == 1 ? true : false;
            btLuuLop.Visible = type == 2 ? true : false;
            btHuyLop.Visible = type == 2 ? true : false;
        }
        private void ControllButtonKL(int type)
        {
            btSuaKL.Visible = type == 1 ? true : false;
            btXoaKL.Visible = type == 1 ? true : false;
            btThemKL.Visible = type == 1 ? true : false;
            btLuuLop.Visible = type == 2 ? true : false;
            btHuyLop.Visible = type == 2 ? true : false;
        }
        private void ControllButtonKT(int type)
        {
            btThemKT.Visible = type == 1 ? true : false;
            btSuaKT.Visible = type == 1 ? true : false;
            btXoaKT.Visible = type == 1 ? true : false;
            btLuuLop.Visible = type == 2 ? true : false;
            btHuyLop.Visible = type == 2 ? true : false;
        }
        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaLop.Text = dgvLop["MaLop", index].Value.ToString();
            txtTenLop.Text = dgvLop["TenLop", index].Value.ToString();
            txtKhoaHoc.Text = dgvLop["KhoaHoc", index].Value.ToString();
        }

        private void btThemKT_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButtonKT(2);
            txtMaKhenThuong.Text = "";
            txtTenKhenThuong.Text = "";
        }
        private void Excute_khenthuong(string query)
        {
            if (query == "them")
            {
                try
                {
                    KhenThuongEntities khenthuongenti = new KhenThuongEntities();
                    khenthuongenti.Makhenthuong = txtMaKhenThuong.Text.Trim();
                    khenthuongenti.Tenkhenthuong = txtTenKhenThuong.Text.Trim();
                    KhenThuongBLL khenthuongbll = new KhenThuongBLL();
                    if (!(khenthuongbll.checkkhenthuog(txtMaKhenThuong.Text.Trim())))
                    {
                        khenthuongbll.insert(khenthuongenti);
                        Load_KhenThuong();
                    }
                    else
                        MessageBox.Show("ma " + txtMaKhenThuong + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    KhenThuongEntities khenthuongenti = new KhenThuongEntities();
                    khenthuongenti.Makhenthuong = txtMaKhenThuong.Text.Trim();
                    khenthuongenti.Tenkhenthuong = txtTenKhenThuong.Text.Trim();
                    KhenThuongBLL khenthuongbll = new KhenThuongBLL();
                    khenthuongbll.update(khenthuongenti);
                    Load_KhenThuong();
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
                    string makhenthuong = txtMaKhenThuong.Text.Trim();
                    KhenThuongBLL khenthuogbll = new KhenThuongBLL();
                    khenthuogbll.delete(makhenthuong);
                    Load_KhenThuong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btSuaKT_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButtonKT(2);
        }

        private void btXoaKT_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButtonKT(2);
        }

        private void dgvKhenThuong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKhenThuong.Text = dgvKhenThuong["MaKT", index].Value.ToString();
            txtTenKhenThuong.Text = dgvKhenThuong["TenKT", index].Value.ToString();
        }

        private void btThemKL_Click(object sender, EventArgs e)
        {
            Query = "them";
            ControllButtonKL(2);
            txtTenKyLuat.Text = "";
            txtMaKyLuat.Text = "";
        }
        private void Excute_kyluat(string query)
        {
            if (query == "them")
            {
                try
                {
                    KyLuatEntities kyluatenti = new KyLuatEntities();
                    kyluatenti.Makyluat = txtMaKyLuat.Text.Trim();
                    kyluatenti.Tenkyluat = txtTenKyLuat.Text.Trim();
                    KyLuatBLL kyluatbll = new KyLuatBLL();
                    if (!(kyluatbll.checkkyluat(txtMaKyLuat.Text.Trim())))
                    {
                        kyluatbll.insert(kyluatenti);
                        Load_KyLuat();
                    }
                    else
                        MessageBox.Show("ma" + txtMaKyLuat + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    KyLuatEntities kyluatenti = new KyLuatEntities();
                    kyluatenti.Makyluat = txtMaKyLuat.Text.Trim();
                    kyluatenti.Tenkyluat = txtTenKyLuat.Text.Trim();
                    KyLuatBLL kyluatbll = new KyLuatBLL();
                    kyluatbll.update(kyluatenti);
                    Load_KyLuat();
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
                    string makyluat = txtMaKyLuat.Text.Trim();
                    KyLuatBLL kyluatbll = new KyLuatBLL();
                    kyluatbll.delete(makyluat);
                    Load_KyLuat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaKL_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ControllButtonKL(2);
        }

        private void btXoaKL_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ControllButtonKL(2);
        }

        private void dgvKyLuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKyLuat.Text = dgvKyLuat["MaKL", index].Value.ToString();
            txtTenKyLuat.Text = dgvKyLuat["TenKL", index].Value.ToString();
        }

        private void btLuuKT_Click(object sender, EventArgs e)
        {
            Excute_khenthuong(Query);
            ControllButtonKT(1);
        }

        private void btHuyKT_Click(object sender, EventArgs e)
        {
            ControllButtonKT(1);
        }

        private void btLuuKL_Click(object sender, EventArgs e)
        {
            Excute_kyluat(Query);
            ControllButtonKL(1);
        }

        private void btHuyKL_Click(object sender, EventArgs e)
        {
            ControllButtonKL(1);
        }

        private void btLuuLop_Click(object sender, EventArgs e)
        {
            Excute_lop(Query);
            ControllButton(1);
        }

        private void btXoaLop_Click(object sender, EventArgs e)
        {
            ControllButton(1);
        }

        private void btThoatChung_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void DuLieuChung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    btLuuKL_Click(null, null);
                    btLuuKT_Click(null, null);
                    btLuuLop_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    btHuyKL_Click(null, null);
                    btHuyKT_Click(null, null);
                    btHuyLop_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.E))
                {
                    btThoatChung_Click(null, null);
                }
            }
        }
    }
}