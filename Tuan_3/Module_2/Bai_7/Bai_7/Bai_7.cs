using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class Bai_7 : Form
    {
        public Bai_7()
        {
            InitializeComponent();
        }

        private void frmLightSwitcher_Load(object sender, EventArgs e)
        {
            txtName.Text = "Nero";
            lblHienThi.Text = txtName.Text.Trim() + " Turn Off the Light, please!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                picTurnOff.Visible = false;
                picTurnOn.Visible = true;
                lblHienThi.Text = txtName.Text + " Turn Off the Light, please!";
            }
            else
            {
                MessageBox.Show("Nhập tên của bạn!");
            }
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                picTurnOff.Visible = true;
                picTurnOn.Visible = false;
                lblHienThi.Text = txtName.Text + " Turn On the Light, please!";
            }
            else
            {
                MessageBox.Show("Nhập tên của bạn!");
            }
        }
    }
}
