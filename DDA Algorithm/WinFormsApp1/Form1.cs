using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		Bitmap canvas;

		public Form1()
		{
			InitializeComponent();
			canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
		}

		private void buttonDraw_Click(object sender, EventArgs e)
		{
			DDA.DrawLine(canvas, 50, 50, 300, 300, Color.Red);
			this.Invalidate();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.DrawImage(canvas, 0, 0);
			base.OnPaint(e);
		}
	}
}
