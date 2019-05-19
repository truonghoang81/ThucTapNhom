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
    public partial class DuLieuRieng : Form
    {
        public DuLieuRieng()
        {
            InitializeComponent();
        }
        private string Query = "";

        private void DuLieuRieng_Load(object sender, EventArgs e)
        {
            Load_BoMon();
            Load_ChucVu();
            Load_HanhKiem();
            Load_HocLuc();
            ConTrollButtonBM(1);
            ConTrollButtonCV(1);
            ConTrollButtonHK(1);
            ConTrollButtonHL(1);
            this.KeyPreview = true;
        }
        private void Load_ChucVu()
        {
            ChucVuBLL chucvubll = new ChucVuBLL();
            dgvChucVu.DataSource = chucvubll.GetData();
        }
        private void Load_BoMon()
        {
            BoMonBLL bomonbll = new BoMonBLL();
            dgvBoMon.DataSource = bomonbll.GetData();
        }
        private void Load_HanhKiem()
        {
            HanhKiemBLL hanhkiembll = new HanhKiemBLL();
            dgvHanhKiem.DataSource = hanhkiembll.GetData();
        }
        private void Load_HocLuc()
        {
            HocLucBLL hoclucbll = new HocLucBLL();
            dgvHocLuc.DataSource = hoclucbll.GetData();
        }
        private void ConTrollButtonCV(int type)
        {
            btThemCV.Visible = type == 1 ? true : false;
            btSuaCV.Visible = type == 1 ? true : false;
            btXoaCV.Visible = type == 1 ? true : false;
            btLuuCV.Visible = type == 2 ? true : false;
            btHuyCV.Visible = type == 2 ? true : false;
        }
        private void ConTrollButtonBM(int type)
        {
            btThemBM.Visible = type == 1 ? true : false;
            btSuaBM.Visible = type == 1 ? true : false;
            btXoaBM.Visible = type == 1 ? true : false;
            btLuuBM.Visible = type == 2 ? true : false;
            btHuyBM.Visible = type == 2 ? true : false;
        }
        private void ConTrollButtonHK(int type)
        {
            btThemHK.Visible = type == 1 ? true : false;
            btSuaHK.Visible = type == 1 ? true : false;
            btXoaHK.Visible = type == 1 ? true : false;
            btLuuHK.Visible = type == 2 ? true : false;
            btHuyHK.Visible = type == 2 ? true : false;
        }
        private void ConTrollButtonHL(int type)
        {
            btThemKL.Visible = type == 1 ? true : false;
            btSuaHL.Visible = type == 1 ? true : false;
            btXoaHL.Visible = type == 1 ? true : false;
            btLuuHL.Visible = type == 2 ? true : false;
            btHuyHL.Visible = type == 2 ? true : false;
        }

        private void btThemCV_Click(object sender, EventArgs e)
        {
            Query = "them";
            ConTrollButtonCV(2);
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }
        private void Excute_chucvu(string query)
        {
            if (query == "them")
            {
                try
                {
                    ChucVuEntities chucvuenti = new ChucVuEntities();
                    chucvuenti.Machucvu = txtMaCV.Text.Trim();
                    chucvuenti.Tenchucvu = txtTenCV.Text.Trim();
                    ChucVuBLL chucvubll = new ChucVuBLL();
                    if (!(chucvubll.checkchucvu(txtMaCV.Text.Trim())))
                    {
                        chucvubll.insert(chucvuenti);
                        Load_ChucVu();
                    }
                    else
                        MessageBox.Show("ma" + txtMaCV + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    ChucVuEntities chucvuenti = new ChucVuEntities();
                    chucvuenti.Machucvu = txtMaCV.Text.Trim();
                    chucvuenti.Tenchucvu = txtTenCV.Text.Trim();
                    ChucVuBLL chucvubll = new ChucVuBLL();
                    chucvubll.update(chucvuenti);
                    Load_ChucVu();
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
                    string machucvu = txtMaCV.Text.Trim();
                    ChucVuBLL chucvubll = new ChucVuBLL();
                    chucvubll.delete(machucvu);
                    Load_ChucVu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaCV_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ConTrollButtonCV(2); 
        }

        private void btXoaCV_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ConTrollButtonCV(2);
        }

        private void btLuuCV_Click(object sender, EventArgs e)
        {
            Excute_chucvu(Query);
            ConTrollButtonCV(1);
        }

        private void btHuyCV_Click(object sender, EventArgs e)
        {
            ConTrollButtonCV(1);
        }

        private void dgvChucVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaCV.Text = dgvChucVu["MaCV", index].Value.ToString();
            txtTenCV.Text = dgvChucVu["TenCV", index].Value.ToString();
        }

        private void btThemBM_Click(object sender, EventArgs e)
        {
            Query = "them";
            ConTrollButtonBM(2);
            txtMaBM.Text = "";
            txtTenBM.Text = "";
        }
        private void Excute_bomon(string query)
        {
            if (query == "them")
            {
                try
                {
                    BoMonEntities bomonenti = new BoMonEntities();
                    bomonenti.Mabomon = txtMaBM.Text.Trim();
                    bomonenti.Tenbomon = txtTenBM.Text.Trim();
                    BoMonBLL bomonbll = new BoMonBLL();
                    if (!(bomonbll.checkbomon(txtMaBM.Text.Trim())))
                    {
                        bomonbll.insert(bomonenti);
                        Load_BoMon();
                    }
                    else
                        MessageBox.Show("ma" + txtMaBM + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    BoMonEntities bomonenti = new BoMonEntities();
                    bomonenti.Mabomon = txtMaBM.Text.Trim();
                    bomonenti.Tenbomon = txtTenBM.Text.Trim();
                    BoMonBLL bomonbll = new BoMonBLL();
                    bomonbll.update(bomonenti);
                    Load_BoMon();
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
                    string mabomon = txtMaBM.Text.Trim();
                    BoMonBLL bomonbll = new BoMonBLL();
                    bomonbll.delete(mabomon);
                    Load_BoMon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaBM_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ConTrollButtonBM(2);
        }

        private void btXoaBM_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ConTrollButtonBM(2);
        }

        private void btLuuBM_Click(object sender, EventArgs e)
        {
            Excute_bomon(Query);
            ConTrollButtonBM(1);
        }

        private void btHuyBM_Click(object sender, EventArgs e)
        {
            ConTrollButtonBM(1);
        }

        private void dgvBoMon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaBM.Text = dgvBoMon["MaBM", index].Value.ToString();
            txtTenBM.Text = dgvBoMon["TenBM", index].Value.ToString();
        }

        private void btThemHK_Click(object sender, EventArgs e)
        {
            Query = "them";
            ConTrollButtonHK(2);
            txtMaHK.Text = "";
            txtTenHK.Text = "";
        }
        private void Excute_hanhkiem(string query)
        {
            if (query == "them")
            {
                try
                {
                    HanhKiemEntities hanhkiementi = new HanhKiemEntities();
                    hanhkiementi.Mahanhkiem = txtMaHK.Text.Trim();
                    hanhkiementi.Tenhanhkiem=txtTenHK.Text.Trim();
                    HanhKiemBLL hanhkiembll=new HanhKiemBLL();
                    if (!(hanhkiembll.checkhanhiem(txtMaHK.Text.Trim())))
                    {
                        hanhkiembll.insert(hanhkiementi);
                        Load_HanhKiem();
                    }
                    else
                        MessageBox.Show("ma" + txtMaHK + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    HanhKiemEntities hanhkiementi = new HanhKiemEntities();
                    hanhkiementi.Mahanhkiem = txtMaHK.Text.Trim();
                    hanhkiementi.Tenhanhkiem = txtTenHK.Text.Trim();
                    HanhKiemBLL hanhkiembll = new HanhKiemBLL();
                    hanhkiembll.update(hanhkiementi);
                    Load_HanhKiem();
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
                    string mahanhkiem = txtMaHK.Text.Trim();
                    HanhKiemBLL hanhkiembll = new HanhKiemBLL();
                    hanhkiembll.delete(mahanhkiem);
                    Load_HanhKiem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaHK_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ConTrollButtonHK(2);
        }

        private void btXoaHK_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ConTrollButtonHK(2);
        }

        private void btLuuHK_Click(object sender, EventArgs e)
        {
            Excute_hanhkiem(Query);
            ConTrollButtonHK(1);
        }

        private void btHuyHK_Click(object sender, EventArgs e)
        {
            ConTrollButtonHK(1);
        }

        private void dgvHanhKiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaHK.Text = dgvHanhKiem["MaHK", index].Value.ToString();
            txtTenHK.Text = dgvHanhKiem["TenHK", index].Value.ToString();
        }

        private void btThemKL_Click(object sender, EventArgs e)
        {
            Query = "them";
            ConTrollButtonHL(2);
            txtTenHL.Text = "";
            txtMaHL.Text = "";
        }
        private void Excute_hocluc(string query)
        {
            if (query == "them")
            {
                try
                {
                    HocLucEntities hoclucenti = new HocLucEntities();
                    hoclucenti.Mahocluc = txtMaHL.Text.Trim();
                    hoclucenti.Tenhocluc = txtTenHL.Text.Trim();
                    HocLucBLL hoclucbll = new HocLucBLL();
                    if (!(hoclucbll.checkhocluc(txtMaHL.Text.Trim())))
                    {
                        hoclucbll.insert(hoclucenti);
                        Load_HocLuc();
                    }
                    else
                        MessageBox.Show("ma" + txtMaHL + "da ton tai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    HocLucEntities hoclucenti = new HocLucEntities();
                    hoclucenti.Mahocluc = txtMaHL.Text.Trim();
                    hoclucenti.Tenhocluc = txtTenHL.Text.Trim();
                    HocLucBLL hoclucbll = new HocLucBLL();
                    hoclucbll.update(hoclucenti);
                    Load_HocLuc();
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
                    string mahocluc = txtMaHL.Text.Trim();
                    HocLucBLL hoclucbll = new HocLucBLL();
                    hoclucbll.delete(mahocluc);
                    Load_HocLuc();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xoa bi loi" + ex.Message.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btSuaHL_Click(object sender, EventArgs e)
        {
            Query = "sua";
            ConTrollButtonHL(2);
        }

        private void btXoaHL_Click(object sender, EventArgs e)
        {
            Query = "xoa";
            ConTrollButtonHL(2);
        }

        private void btLuuHL_Click(object sender, EventArgs e)
        {
            Excute_hocluc(Query);
            ConTrollButtonHL(1);
        }

        private void btHuyHL_Click(object sender, EventArgs e)
        {
            ConTrollButtonHL(1);

        }

        private void dgvHocLuc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaHL.Text = dgvHocLuc["MaHL", index].Value.ToString();
            txtTenHL.Text = dgvHocLuc["TenHL", index].Value.ToString();
        }

        private void btThoatDLRieng_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void DuLieuRieng_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    btLuuBM_Click(null, null);
                    btLuuHK_Click(null, null);
                    btLuuHL_Click(null, null);
                    btLuuCV_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    btHuyBM_Click(null, null);
                    btHuyCV_Click(null, null);
                    btHuyHK_Click(null, null);
                    btHuyHL_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.E))
                {
                    btThoatDLRieng_Click(null, null);
                }
            }
        }


    }
}
