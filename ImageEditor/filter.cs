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
    public partial class BrightnessContrast : Form
    {
        public BrightnessContrast()
        {
            InitializeComponent();
        }

        private void scrollBrightness_ValueChanged(object sender, EventArgs e)
        {
            tbBrightness.Text = scrollBrightness.Value.ToString();
        }

        private void tbBrightness_TextChanged(object sender, EventArgs e)
        {
            if((tbBrightness.Text=="")|| (tbBrightness.Text == "-"))
            {
                scrollBrightness.Value = 0;
                tbBrightness.Text = "0";
            } 
            else if ((Convert.ToInt16(tbBrightness.Text) <= 127) && (Convert.ToInt16(tbBrightness.Text) >= -127))
            {
                scrollBrightness.Value = Convert.ToInt16(tbBrightness.Text);
            } 
            else
            {
                tbBrightness.Text = "0";
                MessageBox.Show("[BŁĄD] Podana wartość jest błędna.");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrightnessContrast_Load(object sender, EventArgs e)
        {
            tbBrightness.Text = scrollBrightness.Value.ToString();
            
        }

        private void scrollContrast_ValueChanged(object sender, EventArgs e)
        {
            tbContrast.Text = scrollContrast.Value.ToString();
        }
    }
}
