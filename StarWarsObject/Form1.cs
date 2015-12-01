using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            g = this.CreateGraphics();
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Xwing(0, 0, 200, 200);
        }
        public void Xwing(float x, float y, float pixelsx, float pixelsy)
        {
            float multx = pixelsx / 100;
            float multy = pixelsy / 100;
            Pen xwingPen = new Pen(Color.White, 1);
            Pen colorPen = new Pen(Color.GreenYellow, 1);
            SolidBrush colorBrush2 = new SolidBrush(Color.DeepSkyBlue);
            SolidBrush colorBrush3 = new SolidBrush(Color.SkyBlue);
            SolidBrush colorBrush4 = new SolidBrush(Color.PaleTurquoise);
            SolidBrush fadeBrush = new SolidBrush(Color.Black);
            SolidBrush fadeBrush2 = new SolidBrush(Color.Black);
            SolidBrush fadeBrush3 = new SolidBrush(Color.Black);
            SolidBrush colorBrush = new SolidBrush(Color.White);

            fadeBrush.Color = Color.FromArgb(100, 0, 0, 0);
            fadeBrush2.Color = Color.FromArgb(50, 0, 0, 0);
            fadeBrush3.Color = Color.FromArgb(255, 0, 0, 0);

            PointF point1 = new PointF(0 * multx + x, 50 * multy + y);
            PointF point2 = new PointF(50 * multx + x, 35 * multy + y);
            PointF point3 = new PointF(100 * multx + x, 50 * multy + y);
            PointF point4 = new PointF(0 * multx + x, 50 * multy + y);
            PointF point5 = new PointF(50 * multx + x, 65 * multy + y);
            PointF point6 = new PointF(100 * multx + x, 50 * multy + y);

            PointF[] curvePoints = { point1, point2, point3 };
            PointF[] curvePoints2 = { point4, point5, point6 };
            //body
            g.DrawCurve(xwingPen, curvePoints2);
            g.DrawCurve(xwingPen, curvePoints);

            //bubble
            g.DrawArc(xwingPen, x + 27 * multx, y + 15 * multy, 142 / 3 * multx, 142 / 3 * multy, 175, 190);

            //ship lights
            g.DrawEllipse(xwingPen, x + 20 * multx, y + 47 * multy, 7 * multx, 7 * multy);
            g.DrawEllipse(xwingPen, x + 45 * multx, y + 45 * multy, 9 * multx, 9 * multy);
            g.DrawEllipse(xwingPen, x + 70 * multx, y + 47 * multy, 7 * multx, 7 * multy);
            g.FillEllipse(colorBrush, x + 20 * multx, y + 47 * multy, 7 * multx, 7 * multy);
            g.FillEllipse(colorBrush, x + 45 * multx, y + 45 * multy, 9 * multx, 9 * multy);
            g.FillEllipse(colorBrush, x + 70 * multx, y + 47 * multy, 7 * multx, 7 * multy);

            //landing gear
            g.DrawLine(xwingPen, x + 25 * multx, y + 59 * multy, x + 10 * multx, y + 70 * multy);
            g.DrawLine(xwingPen, x + 75 * multx, y + 59 * multy, x + 90 * multx, y + 70 * multy);
            g.DrawLine(xwingPen, x + 5 * multx, y + 70 * multy, x + 15 * multx, y + 70 * multy);
            g.DrawLine(xwingPen, x + 85 * multx, y + 70 * multy, x + 95 * multx, y + 70 * multy);

            //alien
            g.DrawArc(colorPen, x + 43 * multx, y + 28 * multy, 142 / 10 * multx, 142 / 10 * multy, 180, 180);
            g.DrawLine(colorPen, x + 40 * multx, y + 25 * multy, x + 45 * multx, y + 30 * multy);
            g.DrawLine(colorPen, x + 60 * multx, y + 25 * multy, x + 55 * multx, y + 30 * multy);

            //blaster module
            g.FillRectangle(colorBrush2, 34 * multx + x, 66 * multy + y, 32 * multx + x, 34 * multy + y);
            g.FillRectangle(colorBrush3, 35 * multx + x, 66 * multy + y, 30 * multx + x, 34 * multy + y);
            g.FillRectangle(colorBrush4, 36 * multx + x, 66 * multy + y, 28 * multx + x, 34 * multy + y);
            g.FillRectangle(colorBrush, 40 * multx + x, 66 * multy + y, 20 * multx + x, 34 * multy + y);
            g.DrawLine(xwingPen, 33 * multx + x, 62 * multy + y, 33 * multx + x, 66 * multy + y);
            g.DrawLine(xwingPen, 67 * multx + x, 62 * multy + y, 67 * multx + x, 66 * multy + y);
            g.DrawLine(xwingPen, 33 * multx + x, 66 * multy + y, 67 * multx + x, 66 * multy + y);

            //fading blaster
            g.FillRectangle(fadeBrush2, 0 * multx + x, 80 * multy + y, 100 * multx + x, 20 * multy + y);
            g.FillRectangle(fadeBrush2, 0 * multx + x, 75 * multy + y, 40 * multx + x, 25 * multy + y);
            g.FillRectangle(fadeBrush2, 60 * multx + x, 75 * multy + y, 40 * multx + x, 25 * multy + y);
            g.FillRectangle(fadeBrush, 0 * multx + x, 90 * multy + y, 100 * multx + x, 20 * multy + y);
            g.FillRectangle(fadeBrush3, 0 * multx + x, 90 * multy + y, 40 * multx + x, 10 * multy + y);
            g.FillRectangle(fadeBrush3, 60 * multx + x, 90 * multy + y, 40 * multx + x, 10 * multy + y);
            g.FillRectangle(fadeBrush, 0 * multx + x, 85 * multy + y, 40 * multx + x, 15 * multy + y);
            g.FillRectangle(fadeBrush, 60 * multx + x, 85 * multy + y, 40 * multx + x, 15 * multy + y);
            g.FillRectangle(fadeBrush2, 0 * multx + x, 95 * multy + y, 45 * multx + x, 5 * multy + y);
            g.FillRectangle(fadeBrush2, 55 * multx + x, 95 * multy + y, 45 * multx + x, 5 * multy + y);
        }
    }

}
