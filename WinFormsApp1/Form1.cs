using Microsoft.Web.WebView2.WinForms;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void maviToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Blue;
		}

		private void yeþilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Green;
		}

		private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Orange;
		}

		private void hakkýmýzdaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bu Proje Þefik Köse Tarafýndan Yapýlmýþtýr.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webView21.Source = new Uri("https://www.youtube.com/watch?v=hEJnMQG9ev8&pp=ygUPbWFkIG1heCBmcmFnbWFu");
			label1.Text = "Mad Max Fury Road";
		}

		private void yýldýzlararasýToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webView21.Source = new Uri("https://www.youtube.com/watch?v=LY19rHKAaAg&pp=ygUUaW50ZXJzdGVsbGFyIGZyYWdtYW4%3D");
			label1.Text = "Interstellar";
		}

		private void sýcakKalplerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			webView21.Source = new Uri("https://www.youtube.com/watch?v=07s-cNFffDM&pp=ygUTV2FybSBCb2RpZXMgZnJhZ21hbg%3D%3D");
			label1.Text = "Warm Bodies";
		}

		private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Black;
		}

		private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}
	}
}
