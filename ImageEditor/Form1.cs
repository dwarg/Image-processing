using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIP;


namespace ImageEditor
{
    public partial class Form1 : Form
    {

        FIP.FIP fip = new FIP.FIP();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("[BŁĄD] Brak obrazka do zapisania.");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Image Files (*.png, *.jpg, *.bmp)| *.png; *.jpg; *.bmp";
                if (DialogResult.OK == saveFile.ShowDialog())
                    this.pictureBox2.Image.Save(saveFile.FileName);
            }
        }

        private static int truncate(int x)
        {
            if (x > 255) x = 255;
            else if (x < 0) x = 0;
            return x;
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.png, *.jpg, *.bmp)|*.png; *.jpg; *.bmp";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(dlg.FileName);
                toolStripStatusLabel1.Text = dlg.FileName + " | " + pictureBox1.Image.Width + "x" + pictureBox1.Image.Height;
                pictureBox2.Image = null;
            }
        }

        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("[BŁĄD] Nie ma obrazu do przetworzenia!");

            }else
            {
                BrightnessContrast bc = new BrightnessContrast();
                if (bc.ShowDialog() == DialogResult.OK)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                    int valueB = Convert.ToInt16(bc.tbBrightness.Text);

                    int valueC = Convert.ToInt16(bc.tbContrast.Text);
                    double a = (259 * (valueC + 255)) / (255 * (259 - valueC));
                    for(int i = 0; i < b.Width; i++)
                    {
                        for(int j = 0; j < b.Height; j++)
                        {
                            Color c1 = b.GetPixel(i, j);
                            int r1 = truncate((c1.R + valueB) + (Convert.ToInt16(a) * (c1.R - 128) + 128));
                            int g1 = truncate((c1.G + valueB) + (Convert.ToInt16(a) * (c1.G - 128) + 128));
                            int b1 = truncate((c1.B + valueB) + (Convert.ToInt16(a) * (c1.B - 128) + 128));
                            b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                        }
                    }
                    this.pictureBox2.Image = b;
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("[Błąd] Wgraj najpierw obrazek!");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                for(int i = 0; i < b.Width; i++)
                {
                    for(int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int grayAvg = (c1.R+c1.G+c1.B)/3;
                        b.SetPixel(i, j, Color.FromArgb(grayAvg, grayAvg, grayAvg));
                    }
                }
                this.pictureBox2.Image = b;
            }
        }

        private void luminanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("[Błąd] Wgraj najpierw obrazek!");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int gLum = Convert.ToInt16(0.21 * c1.R + 0.72 * c1.G + 0.07 * c1.B);
                        b.SetPixel(i, j, Color.FromArgb(gLum, gLum, gLum));
                    }
                }
                this.pictureBox2.Image = b;
            }
        }

        private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("[Błąd] Wgraj najpierw obrazek!");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int max = Math.Max(c1.R, Math.Max(c1.G, c1.B));
                        int min = Math.Min(c1.R, Math.Min(c1.G, c1.B));
                        int gLight = (max + min) / 2;
                        b.SetPixel(i, j, Color.FromArgb(gLight, gLight, gLight));
                    }
                }
                this.pictureBox2.Image = b;
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BitDepth(int bit)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("[Błąd] Wgraj najpierw obrazek!");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                double level = 255 - Math.Pow(2, bit) - 1;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int R = Convert.ToInt16(Math.Round(c1.R / level) * level);
                        int G = Convert.ToInt16(Math.Round(c1.G / level) * level);
                        int B = Convert.ToInt16(Math.Round(c1.B / level) * level);
                        b.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
                this.pictureBox2.Image = b;
            }
        }

        private void bitToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            BitDepth(1);
        }

        private void bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitDepth(2);
        }

        private void bitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BitDepth(3);
        }

        private void bitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BitDepth(4);
        }

        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gammaCorrectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("[Błąd] Wgraj najpierw obrazek!");
            }
            else
            {
                gamma gammaCor = new gamma();
                if (gammaCor.ShowDialog() == DialogResult.Cancel)
                {
                    Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                    double valueG = Convert.ToDouble(gammaCor.tbGamma.Text);
                    double r1, g1, b1;

                    double red, green, blue;
                    for (int i = 0; i < b.Width; i++)
                    {
                        for (int j = 0; j < b.Height; j++)
                        {
                            red = b.GetPixel(i, j).R;
                            green = b.GetPixel(i, j).G;
                            blue = b.GetPixel(i, j).B;

                            r1 = 255 * Math.Pow((red / 255), valueG);
                            g1 = 255 * Math.Pow((green / 255), valueG);
                            b1 = 255 * Math.Pow((blue / 255), valueG);
                            b.SetPixel(i, j, Color.FromArgb(Convert.ToInt16(r1), Convert.ToInt16(g1), Convert.ToInt16(b1)));
                        }
                    }
                    this.pictureBox2.Image = b;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poPrzetworzeniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
                MessageBox.Show("[BłĄD] Musisz najpierw przetworzyć obrazek, aby wygenerować histogram.");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pictureBox2.Image);
                Histogram histogram = new Histogram();
                HistogramRGB histogramRGB = new HistogramRGB();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int red = c1.R;
                        int green = c1.G;
                        int blue = c1.B;
                        HistoR[red]++;
                        HistoG[green]++;
                        HistoB[blue]++;
                    }
                }

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    histogram.chart1.Series["Series1"].Color = Color.Gray;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogram.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    histogram.ShowDialog();
                }
                else
                {
                    histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }
                    histogramRGB.ShowDialog();
                }
            }
        }

        private void przedPrzetworzeniemToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            if (pictureBox1.Image == null)
                MessageBox.Show("[Błąd] Musisz najpierw wgrać obrazek, aby wygenerować histogram.");
            else
            {
                double[] HistoR = new double[256];
                double[] HistoG = new double[256];
                double[] HistoB = new double[256];
                Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                Histogram histogram = new Histogram();
                HistogramRGB histogramRGB = new HistogramRGB();

                for (int i = 0; i < 255; i++)
                {
                    HistoR[i] = 0;
                    HistoG[i] = 0;
                    HistoB[i] = 0;
                }

                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        Color c1 = b.GetPixel(i, j);
                        int red = c1.R;
                        int green = c1.G;
                        int blue = c1.B;
                        HistoR[red]++;
                        HistoG[green]++;
                        HistoB[blue]++;
                    }
                }

                Double sumR = 0;
                for (int i = 0; i < 255; i++)
                {
                    if (HistoG[i] == HistoB[i])
                    {
                        sumR++;
                    }
                }

                if (sumR == 255)
                {
                    histogram.chart1.Series["Series1"].Color = Color.Gray;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogram.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogram.chart1.Series["Series1"].Points.AddXY(i, (HistoR[i] + HistoG[i] + HistoB[i]) / 3);
                        }
                    }
                    histogram.ShowDialog();
                }
                else
                {
                    histogramRGB.chart1.Series["Series1"].Color = Color.Red;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstR in HistoR)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart1.Series["Series1"].Points.AddXY(i, HistoR[i]);
                        }
                    }

                    histogramRGB.chart2.Series["Series1"].Color = Color.Green;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstG in HistoG)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart2.Series["Series1"].Points.AddXY(i, HistoG[i]);
                        }
                    }

                    histogramRGB.chart3.Series["Series1"].Color = Color.Blue;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                    histogramRGB.chart3.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                    foreach (Double HstB in HistoB)
                    {
                        for (int i = 0; i <= 255; i++)
                        {
                            histogramRGB.chart3.Series["Series1"].Points.AddXY(i, HistoB[i]);
                        }
                    }

                    histogramRGB.ShowDialog();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap brotate = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap rotate = fip.Rotate(brotate, hScrollBar1.Value);
                Bitmap b = (Bitmap)rotate.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void cartoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bcartoon = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap cartoon = fip.Cartoon(bcartoon, 7, 10, 40, fip.LaplaceF1());
                Bitmap b = (Bitmap)cartoon.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void oilPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap boil = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap oil = fip.OilPaint(boil, 7, 20);
                Bitmap b = (Bitmap)oil.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bsepia = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap sepia = fip.Sepia(bsepia, 30);
                Bitmap b = (Bitmap)sepia.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void penSketchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bpen = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap sketch = fip.Sketch(bpen);
                Bitmap b = (Bitmap)sketch.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void detekcjaKrawędziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bpen = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap sketch = fip.ImagePrewittFilterColor(bpen);
                Bitmap b = (Bitmap)sketch.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void inwersjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap negative = fip.NegativeImageColor(bn);
                Bitmap b = (Bitmap)negative.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void negatywToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap inv = fip.InverseImage(bn, 190);
                Bitmap b = (Bitmap)inv.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void magentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap filterred = fip.ColorFiltration(bn, "Magenta");
                Bitmap b = (Bitmap)filterred.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void żółtyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap filteryellow = fip.ColorFiltration(bn, "Yellow");
                Bitmap b = (Bitmap)filteryellow.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap filtercyan = fip.ColorFiltration(bn, "Cyan");
                Bitmap b = (Bitmap)filtercyan.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void magentaYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap filtermagyel= fip.ColorFiltration(bn, "Magenta-Yellow");
                Bitmap b = (Bitmap)filtermagyel.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void cyanMagentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap filtermagyel = fip.ColorFiltration(bn, "Cyan-Magenta");
                Bitmap b = (Bitmap)filtermagyel.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void żółtyCyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap filteryecy = fip.ColorFiltration(bn, "Yellow-Cyan");
                Bitmap b = (Bitmap)filteryecy.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void czarnobiałyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap bw = fip.ToBlackwhite(bn, 128);
                Bitmap b = (Bitmap)bw.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void erozjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap erosion = fip.ImageErosionFilterGS(bn, 3);
                Bitmap b = (Bitmap)erosion.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void rozdzielczośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Resolution res = new Resolution();
                if (res.ShowDialog() == DialogResult.Cancel)
                {
                    int valueX = Convert.ToInt16(res.tbX.Text);
                    int valueY = Convert.ToInt16(res.tbY.Text);
                    Bitmap b2 = new Bitmap((Bitmap)this.pictureBox1.Image);
                    Bitmap img2 = fip.Resize(b2, valueX, valueY);
                    Bitmap b = (Bitmap)img2.Clone();
                    this.pictureBox2.Image = b;
                }
            }
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                Bitmap bn = new Bitmap((Bitmap)this.pictureBox1.Image);
                Bitmap erosion = fip.HistoramEqualization(bn);
                Bitmap b = (Bitmap)erosion.Clone();
                this.pictureBox2.Image = b;
            }
        }

        private void shiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("[BŁĄD] Wgraj najpierw obrazek.");
            }
            else
            {
                try
                {
                    Shifting shift = new Shifting();
                    if (shift.ShowDialog() == DialogResult.Cancel)
                    {
                        int value = Convert.ToInt16(shift.tbShift.Text);
                        Bitmap b2 = new Bitmap((Bitmap)this.pictureBox1.Image);
                        Bitmap histshift = fip.HistogramShift(b2, value);
                        Bitmap b = (Bitmap)histshift.Clone();
                        this.pictureBox2.Image = b;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        private void cofnijZmianyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((pictureBox2.Image == null) && (pictureBox1.Image==null))
            {
                MessageBox.Show("Nie ma czego cofać!");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pictureBox1.Image);
                this.pictureBox2.Image = b;
            }
        }
    }
}
