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
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void btThoatTroGiup_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }
    }
}
