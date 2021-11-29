namespace ImageEditor
{
    partial class gamma
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
            this.scrollGamma = new System.Windows.Forms.HScrollBar();
            this.tbGamma = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scrollGamma
            // 
            this.scrollGamma.Location = new System.Drawing.Point(22, 27);
            this.scrollGamma.Maximum = 20;
            this.scrollGamma.Name = "scrollGamma";
            this.scrollGamma.Size = new System.Drawing.Size(322, 21);
            this.scrollGamma.TabIndex = 0;
            this.scrollGamma.ValueChanged += new System.EventHandler(this.scrollGamma_ValueChanged);
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(396, 28);
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(44, 20);
            this.tbGamma.TabIndex = 1;
            this.tbGamma.Text = "0";
            this.tbGamma.TextChanged += new System.EventHandler(this.tbGamma_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(190, 84);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 117);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbGamma);
            this.Controls.Add(this.scrollGamma);
            this.Name = "gamma";
            this.Text = "gammaCorrect";
            this.Load += new System.EventHandler(this.gammaCorrect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrollGamma;
        public System.Windows.Forms.TextBox tbGamma;
        private System.Windows.Forms.Button btnOk;
    }
}