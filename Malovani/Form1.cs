using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        Point start,end;
        Size rectSize;
        bool rectTool = false;
        List<Point> curPoints = new List<Point>();
        List<List<Point>> allPoints = new List<List<Point>>();
        List<Rectangle> rectangles = new List<System.Drawing.Rectangle>();

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
            if (curPoints.Count > 1 && !rectTool)
            {
                // begin fresh line or curve
                curPoints.Clear();
                // startpoint
                curPoints.Add(e.Location);
            } else if (rectTool) {
                start = e.Location;
            }
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!rectTool)
            {
                if (e.Button != MouseButtons.Left) return;
                // here we should check if the distance is more than a minimum!
                curPoints.Add(e.Location);
                // let it show
                pictureBox1.Invalidate(); 
            }
            else if (rectTool)
            {
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (curPoints.Count > 1)
            {
                // ToList creates a copy
                allPoints.Add(curPoints.ToList());
                curPoints.Clear();
            }
            else if (rectTool)
            {
                end = e.Location;
                rectSize.Width = start.X - end.X;
                rectSize.Height = start.Y - end.Y;
                Rectangle rectangleTmp = new Rectangle(start,rectSize);
                rectangles.Add(rectangleTmp);
            }
        }

        private void customColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                customColour.BackColor = colorDialog1.Color;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            rectTool = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (curPoints.Count > 1) e.Graphics.DrawCurve(pen, curPoints.ToArray());
            // other lines or curves
            foreach (List<Point> points in allPoints)
                if (points.Count > 1) e.Graphics.DrawCurve(pen, points.ToArray());
            foreach (Rectangle rect in rectangles)
                e.Graphics.DrawRectangle(pen,rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"u:\test.bmp";
            Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
            bmp.Save(fileName, ImageFormat.Bmp);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void RedPen_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
            rectTool = false;
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
