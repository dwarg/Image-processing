namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inwersjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatywToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czarnobiałyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.żółtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaYellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanMagentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.żółtyCyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penSketchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detekcjaKrawędziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozdzielczośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przedPrzetworzeniemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poPrzetworzeniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cofnijZmianyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(841, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = " ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "Plik";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.ShowShortcutKeys = false;
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "Otwórz plik";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.ShowShortcutKeys = false;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Zapisz do pliku";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem1,
            this.greyScaleToolStripMenuItem,
            this.bitDepthToolStripMenuItem,
            this.filtryToolStripMenuItem1,
            this.koloryToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.gammaCorrectionToolStripMenuItem,
            this.detekcjaKrawędziToolStripMenuItem,
            this.rozdzielczośćToolStripMenuItem,
            this.cofnijZmianyToolStripMenuItem});
            this.colorsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Edycja";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem1
            // 
            this.brightnessToolStripMenuItem1.Name = "brightnessToolStripMenuItem1";
            this.brightnessToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.brightnessToolStripMenuItem1.Text = "Jasność oraz kontrast";
            this.brightnessToolStripMenuItem1.Click += new System.EventHandler(this.brightnessToolStripMenuItem1_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.greyScaleToolStripMenuItem.Text = "Odcienie szarości";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.averageToolStripMenuItem.Text = "&Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lightnessToolStripMenuItem.Text = "&Lightness";
            this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.luminanceToolStripMenuItem.Text = "Luminance";
            this.luminanceToolStripMenuItem.Click += new System.EventHandler(this.luminanceToolStripMenuItem_Click);
            // 
            // bitDepthToolStripMenuItem
            // 
            this.bitDepthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem6,
            this.bitToolStripMenuItem,
            this.bitToolStripMenuItem1,
            this.bitToolStripMenuItem2});
            this.bitDepthToolStripMenuItem.Name = "bitDepthToolStripMenuItem";
            this.bitDepthToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.bitDepthToolStripMenuItem.Text = "Głębia bitowa";
            // 
            // bitToolStripMenuItem6
            // 
            this.bitToolStripMenuItem6.Name = "bitToolStripMenuItem6";
            this.bitToolStripMenuItem6.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem6.Text = "1 bit";
            this.bitToolStripMenuItem6.Click += new System.EventHandler(this.bitToolStripMenuItem6_Click);
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem.Text = "2 bit";
            this.bitToolStripMenuItem.Click += new System.EventHandler(this.bitToolStripMenuItem_Click);
            // 
            // bitToolStripMenuItem1
            // 
            this.bitToolStripMenuItem1.Name = "bitToolStripMenuItem1";
            this.bitToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem1.Text = "3 bit";
            this.bitToolStripMenuItem1.Click += new System.EventHandler(this.bitToolStripMenuItem1_Click);
            // 
            // bitToolStripMenuItem2
            // 
            this.bitToolStripMenuItem2.Name = "bitToolStripMenuItem2";
            this.bitToolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem2.Text = "4 bit";
            this.bitToolStripMenuItem2.Click += new System.EventHandler(this.bitToolStripMenuItem2_Click);
            // 
            // filtryToolStripMenuItem1
            // 
            this.filtryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inwersjaToolStripMenuItem,
            this.negatywToolStripMenuItem,
            this.czarnobiałyToolStripMenuItem,
            this.erozjaToolStripMenuItem});
            this.filtryToolStripMenuItem1.Name = "filtryToolStripMenuItem1";
            this.filtryToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.filtryToolStripMenuItem1.Text = "Filtry";
            // 
            // inwersjaToolStripMenuItem
            // 
            this.inwersjaToolStripMenuItem.Name = "inwersjaToolStripMenuItem";
            this.inwersjaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.inwersjaToolStripMenuItem.Text = "Inwersja";
            this.inwersjaToolStripMenuItem.Click += new System.EventHandler(this.inwersjaToolStripMenuItem_Click);
            // 
            // negatywToolStripMenuItem
            // 
            this.negatywToolStripMenuItem.Name = "negatywToolStripMenuItem";
            this.negatywToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.negatywToolStripMenuItem.Text = "Negatyw";
            this.negatywToolStripMenuItem.Click += new System.EventHandler(this.negatywToolStripMenuItem_Click);
            // 
            // czarnobiałyToolStripMenuItem
            // 
            this.czarnobiałyToolStripMenuItem.Name = "czarnobiałyToolStripMenuItem";
            this.czarnobiałyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.czarnobiałyToolStripMenuItem.Text = "Czarno-biały";
            this.czarnobiałyToolStripMenuItem.Click += new System.EventHandler(this.czarnobiałyToolStripMenuItem_Click);
            // 
            // erozjaToolStripMenuItem
            // 
            this.erozjaToolStripMenuItem.Name = "erozjaToolStripMenuItem";
            this.erozjaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.erozjaToolStripMenuItem.Text = "Erozja";
            this.erozjaToolStripMenuItem.Click += new System.EventHandler(this.erozjaToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magentaToolStripMenuItem,
            this.żółtyToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.magentaYellowToolStripMenuItem,
            this.cyanMagentaToolStripMenuItem,
            this.żółtyCyanToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // magentaToolStripMenuItem
            // 
            this.magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            this.magentaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.magentaToolStripMenuItem.Text = "Magenta";
            this.magentaToolStripMenuItem.Click += new System.EventHandler(this.magentaToolStripMenuItem_Click_1);
            // 
            // żółtyToolStripMenuItem
            // 
            this.żółtyToolStripMenuItem.Name = "żółtyToolStripMenuItem";
            this.żółtyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.żółtyToolStripMenuItem.Text = "Żółty";
            this.żółtyToolStripMenuItem.Click += new System.EventHandler(this.żółtyToolStripMenuItem_Click_1);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // magentaYellowToolStripMenuItem
            // 
            this.magentaYellowToolStripMenuItem.Name = "magentaYellowToolStripMenuItem";
            this.magentaYellowToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.magentaYellowToolStripMenuItem.Text = "Magenta-Żółty";
            this.magentaYellowToolStripMenuItem.Click += new System.EventHandler(this.magentaYellowToolStripMenuItem_Click);
            // 
            // cyanMagentaToolStripMenuItem
            // 
            this.cyanMagentaToolStripMenuItem.Name = "cyanMagentaToolStripMenuItem";
            this.cyanMagentaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cyanMagentaToolStripMenuItem.Text = "Cyan-Magenta";
            this.cyanMagentaToolStripMenuItem.Click += new System.EventHandler(this.cyanMagentaToolStripMenuItem_Click);
            // 
            // żółtyCyanToolStripMenuItem
            // 
            this.żółtyCyanToolStripMenuItem.Name = "żółtyCyanToolStripMenuItem";
            this.żółtyCyanToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.żółtyCyanToolStripMenuItem.Text = "Żółty-Cyan";
            this.żółtyCyanToolStripMenuItem.Click += new System.EventHandler(this.żółtyCyanToolStripMenuItem_Click);
            // 
            // filtryToolStripMenuItem
            // 
            this.filtryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartoonToolStripMenuItem,
            this.oilPaintToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.penSketchToolStripMenuItem});
            this.filtryToolStripMenuItem.Name = "filtryToolStripMenuItem";
            this.filtryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.filtryToolStripMenuItem.Text = "Efekty";
            // 
            // cartoonToolStripMenuItem
            // 
            this.cartoonToolStripMenuItem.Name = "cartoonToolStripMenuItem";
            this.cartoonToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cartoonToolStripMenuItem.Text = "Cartoon";
            this.cartoonToolStripMenuItem.Click += new System.EventHandler(this.cartoonToolStripMenuItem_Click);
            // 
            // oilPaintToolStripMenuItem
            // 
            this.oilPaintToolStripMenuItem.Name = "oilPaintToolStripMenuItem";
            this.oilPaintToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.oilPaintToolStripMenuItem.Text = "Oil paint";
            this.oilPaintToolStripMenuItem.Click += new System.EventHandler(this.oilPaintToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // penSketchToolStripMenuItem
            // 
            this.penSketchToolStripMenuItem.Name = "penSketchToolStripMenuItem";
            this.penSketchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.penSketchToolStripMenuItem.Text = "Pen sketch";
            this.penSketchToolStripMenuItem.Click += new System.EventHandler(this.penSketchToolStripMenuItem_Click);
            // 
            // gammaCorrectionToolStripMenuItem
            // 
            this.gammaCorrectionToolStripMenuItem.Name = "gammaCorrectionToolStripMenuItem";
            this.gammaCorrectionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gammaCorrectionToolStripMenuItem.Text = "&Gamma";
            this.gammaCorrectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorrectionToolStripMenuItem_Click_1);
            // 
            // detekcjaKrawędziToolStripMenuItem
            // 
            this.detekcjaKrawędziToolStripMenuItem.Name = "detekcjaKrawędziToolStripMenuItem";
            this.detekcjaKrawędziToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.detekcjaKrawędziToolStripMenuItem.Text = "Detekcja krawędzi";
            this.detekcjaKrawędziToolStripMenuItem.Click += new System.EventHandler(this.detekcjaKrawędziToolStripMenuItem_Click);
            // 
            // rozdzielczośćToolStripMenuItem
            // 
            this.rozdzielczośćToolStripMenuItem.Name = "rozdzielczośćToolStripMenuItem";
            this.rozdzielczośćToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rozdzielczośćToolStripMenuItem.Text = "Rozmiar obrazu";
            this.rozdzielczośćToolStripMenuItem.Click += new System.EventHandler(this.rozdzielczośćToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przedPrzetworzeniemToolStripMenuItem,
            this.poPrzetworzeniuToolStripMenuItem,
            this.equalizationToolStripMenuItem,
            this.shiftingToolStripMenuItem});
            this.histogramToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // przedPrzetworzeniemToolStripMenuItem
            // 
            this.przedPrzetworzeniemToolStripMenuItem.Name = "przedPrzetworzeniemToolStripMenuItem";
            this.przedPrzetworzeniemToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.przedPrzetworzeniemToolStripMenuItem.Text = "Przed przetworzeniem";
            this.przedPrzetworzeniemToolStripMenuItem.Click += new System.EventHandler(this.przedPrzetworzeniemToolStripMenuItem_Click);
            // 
            // poPrzetworzeniuToolStripMenuItem
            // 
            this.poPrzetworzeniuToolStripMenuItem.Name = "poPrzetworzeniuToolStripMenuItem";
            this.poPrzetworzeniuToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.poPrzetworzeniuToolStripMenuItem.Text = "Po przetworzeniu";
            this.poPrzetworzeniuToolStripMenuItem.Click += new System.EventHandler(this.poPrzetworzeniuToolStripMenuItem_Click);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // shiftingToolStripMenuItem
            // 
            this.shiftingToolStripMenuItem.Name = "shiftingToolStripMenuItem";
            this.shiftingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shiftingToolStripMenuItem.Text = "Shifting";
            this.shiftingToolStripMenuItem.Click += new System.EventHandler(this.shiftingToolStripMenuItem_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(323, 351);
            this.hScrollBar1.Maximum = 360;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(187, 19);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(438, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(366, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(35, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Przed przetworzeniem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Po przetworzeniu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(400, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Obrót";
            // 
            // cofnijZmianyToolStripMenuItem
            // 
            this.cofnijZmianyToolStripMenuItem.Name = "cofnijZmianyToolStripMenuItem";
            this.cofnijZmianyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cofnijZmianyToolStripMenuItem.Text = "Cofnij zmiany";
            this.cofnijZmianyToolStripMenuItem.Click += new System.EventHandler(this.cofnijZmianyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(857, 453);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Przetwarzanie obrazów";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitDepthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gammaCorrectionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przedPrzetworzeniemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poPrzetworzeniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oilPaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penSketchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem detekcjaKrawędziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inwersjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatywToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem żółtyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaYellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanMagentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem żółtyCyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czarnobiałyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozdzielczośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijZmianyToolStripMenuItem;
    }
}

