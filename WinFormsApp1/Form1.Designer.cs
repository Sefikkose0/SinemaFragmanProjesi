namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			kategoriToolStripMenuItem = new ToolStripMenuItem();
			aksiyonToolStripMenuItem = new ToolStripMenuItem();
			madMaxToolStripMenuItem = new ToolStripMenuItem();
			bilimKurguToolStripMenuItem = new ToolStripMenuItem();
			yıldızlararasıToolStripMenuItem = new ToolStripMenuItem();
			romantikToolStripMenuItem = new ToolStripMenuItem();
			sıcakKalplerToolStripMenuItem = new ToolStripMenuItem();
			arkaplanRengiToolStripMenuItem = new ToolStripMenuItem();
			maviToolStripMenuItem = new ToolStripMenuItem();
			yeşilToolStripMenuItem = new ToolStripMenuItem();
			turuncuToolStripMenuItem = new ToolStripMenuItem();
			siyahToolStripMenuItem = new ToolStripMenuItem();
			beyazToolStripMenuItem = new ToolStripMenuItem();
			hızlıErişimToolStripMenuItem = new ToolStripMenuItem();
			hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
			çıkışToolStripMenuItem = new ToolStripMenuItem();
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			label1 = new Label();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { kategoriToolStripMenuItem, arkaplanRengiToolStripMenuItem, hızlıErişimToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(787, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// kategoriToolStripMenuItem
			// 
			kategoriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aksiyonToolStripMenuItem, bilimKurguToolStripMenuItem, romantikToolStripMenuItem });
			kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
			kategoriToolStripMenuItem.Size = new Size(80, 24);
			kategoriToolStripMenuItem.Text = "Kategori";
			// 
			// aksiyonToolStripMenuItem
			// 
			aksiyonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { madMaxToolStripMenuItem });
			aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
			aksiyonToolStripMenuItem.Size = new Size(169, 26);
			aksiyonToolStripMenuItem.Text = "Aksiyon";
			// 
			// madMaxToolStripMenuItem
			// 
			madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
			madMaxToolStripMenuItem.Size = new Size(154, 26);
			madMaxToolStripMenuItem.Text = "Mad Max";
			madMaxToolStripMenuItem.Click += madMaxToolStripMenuItem_Click;
			// 
			// bilimKurguToolStripMenuItem
			// 
			bilimKurguToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yıldızlararasıToolStripMenuItem });
			bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
			bilimKurguToolStripMenuItem.Size = new Size(169, 26);
			bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
			// 
			// yıldızlararasıToolStripMenuItem
			// 
			yıldızlararasıToolStripMenuItem.Name = "yıldızlararasıToolStripMenuItem";
			yıldızlararasıToolStripMenuItem.Size = new Size(176, 26);
			yıldızlararasıToolStripMenuItem.Text = "Yıldızlararası";
			yıldızlararasıToolStripMenuItem.Click += yıldızlararasıToolStripMenuItem_Click;
			// 
			// romantikToolStripMenuItem
			// 
			romantikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sıcakKalplerToolStripMenuItem });
			romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
			romantikToolStripMenuItem.Size = new Size(169, 26);
			romantikToolStripMenuItem.Text = "Romantik";
			// 
			// sıcakKalplerToolStripMenuItem
			// 
			sıcakKalplerToolStripMenuItem.Name = "sıcakKalplerToolStripMenuItem";
			sıcakKalplerToolStripMenuItem.Size = new Size(177, 26);
			sıcakKalplerToolStripMenuItem.Text = "Sıcak Kalpler";
			sıcakKalplerToolStripMenuItem.Click += sıcakKalplerToolStripMenuItem_Click;
			// 
			// arkaplanRengiToolStripMenuItem
			// 
			arkaplanRengiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maviToolStripMenuItem, yeşilToolStripMenuItem, turuncuToolStripMenuItem, siyahToolStripMenuItem, beyazToolStripMenuItem });
			arkaplanRengiToolStripMenuItem.Name = "arkaplanRengiToolStripMenuItem";
			arkaplanRengiToolStripMenuItem.Size = new Size(124, 24);
			arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
			// 
			// maviToolStripMenuItem
			// 
			maviToolStripMenuItem.Name = "maviToolStripMenuItem";
			maviToolStripMenuItem.Size = new Size(224, 26);
			maviToolStripMenuItem.Text = "Mavi";
			maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
			// 
			// yeşilToolStripMenuItem
			// 
			yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
			yeşilToolStripMenuItem.Size = new Size(224, 26);
			yeşilToolStripMenuItem.Text = "Yeşil";
			yeşilToolStripMenuItem.Click += yeşilToolStripMenuItem_Click;
			// 
			// turuncuToolStripMenuItem
			// 
			turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
			turuncuToolStripMenuItem.Size = new Size(224, 26);
			turuncuToolStripMenuItem.Text = "Turuncu";
			turuncuToolStripMenuItem.Click += turuncuToolStripMenuItem_Click;
			// 
			// siyahToolStripMenuItem
			// 
			siyahToolStripMenuItem.Name = "siyahToolStripMenuItem";
			siyahToolStripMenuItem.Size = new Size(224, 26);
			siyahToolStripMenuItem.Text = "Siyah";
			siyahToolStripMenuItem.Click += siyahToolStripMenuItem_Click;
			// 
			// beyazToolStripMenuItem
			// 
			beyazToolStripMenuItem.Name = "beyazToolStripMenuItem";
			beyazToolStripMenuItem.Size = new Size(224, 26);
			beyazToolStripMenuItem.Text = "Beyaz";
			beyazToolStripMenuItem.Click += beyazToolStripMenuItem_Click;
			// 
			// hızlıErişimToolStripMenuItem
			// 
			hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
			hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
			hızlıErişimToolStripMenuItem.Size = new Size(97, 24);
			hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
			// 
			// hakkımızdaToolStripMenuItem
			// 
			hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
			hakkımızdaToolStripMenuItem.Size = new Size(170, 26);
			hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
			hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
			// 
			// çıkışToolStripMenuItem
			// 
			çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
			çıkışToolStripMenuItem.Size = new Size(170, 26);
			çıkışToolStripMenuItem.Text = "Çıkış";
			çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(29, 105);
			webView21.Name = "webView21";
			webView21.Size = new Size(723, 359);
			webView21.TabIndex = 1;
			webView21.ZoomFactor = 1D;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(325, 55);
			label1.Name = "label1";
			label1.Size = new Size(0, 31);
			label1.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(787, 501);
			Controls.Add(label1);
			Controls.Add(webView21);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem kategoriToolStripMenuItem;
		private ToolStripMenuItem aksiyonToolStripMenuItem;
		private ToolStripMenuItem madMaxToolStripMenuItem;
		private ToolStripMenuItem bilimKurguToolStripMenuItem;
		private ToolStripMenuItem yıldızlararasıToolStripMenuItem;
		private ToolStripMenuItem romantikToolStripMenuItem;
		private ToolStripMenuItem sıcakKalplerToolStripMenuItem;
		private ToolStripMenuItem arkaplanRengiToolStripMenuItem;
		private ToolStripMenuItem maviToolStripMenuItem;
		private ToolStripMenuItem yeşilToolStripMenuItem;
		private ToolStripMenuItem turuncuToolStripMenuItem;
		private ToolStripMenuItem hızlıErişimToolStripMenuItem;
		private ToolStripMenuItem hakkımızdaToolStripMenuItem;
		private ToolStripMenuItem çıkışToolStripMenuItem;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private Label label1;
		private ToolStripMenuItem siyahToolStripMenuItem;
		private ToolStripMenuItem beyazToolStripMenuItem;
	}
}
