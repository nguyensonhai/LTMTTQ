using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class Bai_5 : Form
    {
        int tongSL = 0;
        int tongTien = 0;
        public Bai_5()
        {
            InitializeComponent();
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTB.Clear();
            txtThanhTien.Clear();
            txtTongSL.Clear();
            txtTongTien.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text)).ToString();
            tongSL += int.Parse(txtSoLuong.Text);
            tongTien += int.Parse(txtThanhTien.Text);
            txtTongTien.Text = tongTien.ToString();
            txtTongSL.Text = tongSL.ToString();
            txtTB.Text = (tongTien/tongSL).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
