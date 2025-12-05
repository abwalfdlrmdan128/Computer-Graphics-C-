using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void drow(Bitmap b,int cx, int cy, int ra)
        {

            int r = ra;
            int x_centre = cx;
            int y_centre = cy;
            int x = r, y = 0;
            b.SetPixel(x + x_centre, y + y_centre, Color.Red);
            b.SetPixel(-x + x_centre, y + y_centre, Color.Red);
            b.SetPixel(x + x_centre, -y + y_centre, Color.Red);
            b.SetPixel(-x + x_centre, -y + y_centre, Color.Red);
            int P = 1 - r;
            while (x > y)
            {
                y++;
                if (P <= 0)
                    P = P + 2 * y + 1;
                else
                {
                    x--;
                    P = P + 2 * y - 2 * x + 1;
                }
                if (x < y)
                    break;

                b.SetPixel(x + x_centre, y + y_centre, Color.Red);
                b.SetPixel(-x + x_centre, y + y_centre, Color.Red);
                b.SetPixel(x + x_centre, -y + y_centre, Color.Red);
                b.SetPixel(-x + x_centre, -y + y_centre, Color.Red);
                if (x != y)
                {

                    b.SetPixel(y + x_centre, x + y_centre, Color.Red);
                    b.SetPixel(-y + x_centre, x + y_centre, Color.Red);
                    b.SetPixel(y + x_centre, -x + y_centre, Color.Red);
                    b.SetPixel(-y + x_centre, -x + y_centre, Color.Red);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap b = new Bitmap(1000, 1000);
            drow(b, 350, 200, 50);
            //drow(b, 150, 200, 50);
            pictureBox1.Image = b;
        }
}
}
