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
    public partial class Resolution : Form
    {
        public Resolution()
        {
            InitializeComponent();
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            if (tbX.Text == "")
            {
                tbX.Text = "100";
            }
            else if (Convert.ToInt16(tbX.Text) <= 2000)
            {

            }
            else
            {
                tbX.Text = "100";
                MessageBox.Show("[BŁĄD] Podana wartość jest błędna.");
            }
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            if (tbY.Text == "")
            {
                tbY.Text = "100";
            }
            else if (Convert.ToInt16(tbY.Text) <= 2000)
            {

            }
            else
            {
                tbY.Text = "100";
                MessageBox.Show("[BŁĄD] Podana wartość jest błędna.");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resolution_Load(object sender, EventArgs e)
        {
        }
    }
}
