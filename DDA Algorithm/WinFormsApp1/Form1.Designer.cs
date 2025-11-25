namespace WinFormsApp1
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonDraw;
		private System.Windows.Forms.Button buttonClear;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.buttonDraw = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonDraw
			// 
			this.buttonDraw.Location = new System.Drawing.Point(20, 20);
			this.buttonDraw.Name = "buttonDraw";
			this.buttonDraw.Size = new System.Drawing.Size(100, 30);
			this.buttonDraw.TabIndex = 0;
			this.buttonDraw.Text = "Draw Line";
			this.buttonDraw.UseVisualStyleBackColor = true;
			this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(140, 20);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(100, 30);
			this.buttonClear.TabIndex = 1;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonDraw);
			this.Controls.Add(this.buttonClear);
			this.Name = "Form1";
			this.Text = "DDA Line Drawing";
			this.ResumeLayout(false);
		}
	}
}
