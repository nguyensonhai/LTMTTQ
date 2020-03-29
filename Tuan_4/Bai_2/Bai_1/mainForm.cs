using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double dam, gallon, nl;
                dam = Double.Parse(txtDam.Text.Trim(), CultureInfo.InvariantCulture);
                gallon = Double.Parse(txtGallon.Text.Trim(), CultureInfo.InvariantCulture);

                if (dam < 0)
                {
                    errorProvider.SetError(txtDam, "Dặm phải > 0!");

                }
                else if (gallon < 0)
                {
                    errorProvider.SetError(txtGallon, "Gallon phải > 0!");
                }
                else
                {
                    if (gallon == 0)
                    {
                        MessageBox.Show("Không chia được cho 0.");
                    }
                    else
                    {
                        nl = dam / gallon;
                        txtNhienLieu.Text = Math.Round(nl, 2).ToString();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sai định dạng đầu vào!");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Không chia được cho 0.");
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
