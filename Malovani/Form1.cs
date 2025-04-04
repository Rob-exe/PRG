using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Black,5);
        Brush brush = new SolidBrush(Color.Black);
        int x = -1
        , y = -1,
        xStart,yStart;
        bool rectTool = false;
        bool moving = false;
        
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            colorDialog1.AllowFullOpen = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = xStart = e.X; 
            y = yStart = e.Y;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1 && rectTool == false)
            {
                g.DrawLine(pen,new Point(x,y),e.Location);
                x = e.X;
                y = e.Y;
            } else if (moving && x != -1 && y != -1 && rectTool == true)
            {
                g.DrawRectangle(pen, xStart, yStart,x,y);
                x = e.X;
                y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1; y = -1;
        }

        private void RedPen_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush = new SolidBrush(colorDialog1.Color);
                rectTool = true;
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)numericUpDown1.Value;
        }


    }
}
