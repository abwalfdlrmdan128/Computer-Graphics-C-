using System;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.DirectoryServices;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonDraw_Click(object sender, EventArgs e)
		{
			Graphics g = this.CreateGraphics();
			DDA.DrawLine(g, 50, 50, 300, 300, Color.Red);
		}
		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.Invalidate();   // to delete all drawing
		}

	}
}
