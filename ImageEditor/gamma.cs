using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class gamma : Form
    {
        public gamma()
        {
            InitializeComponent();
        }

        private void scrollGamma_ValueChanged(object sender, EventArgs e)
        {
            tbGamma.Text = Convert.ToString(scrollGamma.Value);
        }

        private void tbGamma_TextChanged(object sender, EventArgs e)
        {
            if ((tbGamma.Text == "") || (tbGamma.Text == "-"))
            {
                scrollGamma.Value = 0;
                tbGamma.Text = "0";
            }
            else if ((Convert.ToInt16(tbGamma.Text) <= 20) && (Convert.ToInt16(tbGamma.Text) >= 0.04))
            {
                scrollGamma.Value = Convert.ToInt16(tbGamma.Text);
            }
            else
            { 
                tbGamma.Text = "0";
                MessageBox.Show("[BŁĄD] Podana wartość jest błędna.");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gammaCorrect_Load(object sender, EventArgs e)
        {
            tbGamma.Text = scrollGamma.Value.ToString();
        }
    }
}
