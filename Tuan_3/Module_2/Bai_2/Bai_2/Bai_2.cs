using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK ban da click button");
        }

        private void Bai_2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chao ban den voi C#");
        }

        private void Bai_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK ban da click form");
        }
    }
}
