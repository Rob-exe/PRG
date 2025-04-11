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
        Pen tmpPen = new Pen(Color.Black,5);
        Brush brush = new SolidBrush(Color.Black);
        Point start,end;
        Size rectSize;
        bool rectTool = false;
        Color curColor = Color.Black;
        List<Point> curPoints = new List<Point>();
        Dictionary<List<Point>, Color> allPoints = new Dictionary<List<Point>, Color>();
        Dictionary<Rectangle, Color> rectanglesOutline = new Dictionary<Rectangle, Color>();
        Dictionary<Rectangle, Brush> rectanglesFill = new Dictionary<Rectangle, Brush>();

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
                curColor = pen.Color;
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
                pen = tmpPen;  
                // ToList creates a copy
                allPoints.Add(curPoints.ToList(),curColor);
                curPoints.Clear();
            }
            else if (rectTool)
            {
                end = e.Location;
                rectSize.Width = start.X - end.X;
                rectSize.Height = start.Y - end.Y;
                Rectangle rectangleTmp = new Rectangle(start,rectSize);
                rectanglesOutline.Add(rectangleTmp, curColor);
                rectanglesFill.Add(rectangleTmp, brush);
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
            allPoints.Clear();
            rectanglesFill.Clear();
            rectanglesOutline.Clear(); 
            rectTool = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {  
            if (curPoints.Count > 1) e.Graphics.DrawCurve(pen, curPoints.ToArray());
            // other lines or curves
            foreach (var item in allPoints)
            {
                if (item.Key.Count > 1)
                {
                    pen.Color = item.Value;
                    e.Graphics.DrawCurve(pen, item.Key.ToArray());
                }
            }

            foreach (var rect in rectanglesOutline) {
                pen.Color = rect.Value;
                e.Graphics.DrawRectangle(pen, rect.Key); }
            foreach (var rect in rectanglesFill)
                e.Graphics.FillRectangle(rect.Value, rect.Key);
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
            curColor = pen.Color;
            tmpPen = pen;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            if (!rectTool)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    brush = new SolidBrush(colorDialog1.Color);
                    rectTool = true;
                }
            } else {
                rectTool = false;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
            rectTool = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)numericUpDown1.Value;
        }


    }
}
