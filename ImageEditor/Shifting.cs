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
    public partial class Shifting : Form
    {
        public Shifting()
        {
            InitializeComponent();
        }

        private void tbShift_TextChanged(object sender, EventArgs e)
        {
            if (tbShift.Text == "")
            {
                tbShift.Text = "100";
            }
            else if (Convert.ToInt16(tbShift.Text) <= 10)
            {

            }
            else
            {
                tbShift.Text = "1";
                MessageBox.Show("[BŁĄD] Podana wartość jest błędna.");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
