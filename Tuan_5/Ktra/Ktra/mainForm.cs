using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktra
{
    public partial class mainForm : Form
    {
        DataClasses1DataContext ps = new DataClasses1DataContext();
        public mainForm()
        {
            InitializeComponent();
            var psn = (from p in ps.persons
                       select new
                       {
                           p.name,
                           p.age
                       }).ToList();
            dgvMain.DataSource = psn;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.ToString();
            int age = Int32.Parse(txtAge.Text.ToString());
            ps.addPerson(name, age);
        }
    }
}
