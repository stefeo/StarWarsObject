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
            xwingPen(0,0,200);
        }
        public void xwingPen(float x, float y, float pixels)
        {
            float mult = pixels / 100;
            float mult2 = pixels / 142;
            Pen xwingPen = new Pen(Color.White, 1);
            SolidBrush colorBrush2 = new SolidBrush(Color.DeepSkyBlue);
            SolidBrush colorBrush3 = new SolidBrush(Color.SkyBlue);
            SolidBrush colorBrush4 = new SolidBrush(Color.PaleTurquoise);
            SolidBrush fadeBrush = new SolidBrush(Color.Black);
            SolidBrush fadeBrush2 = new SolidBrush(Color.Black);
            SolidBrush fadeBrush3 = new SolidBrush(Color.Black);
            fadeBrush.Color = Color.FromArgb(100,0,0,0);
            fadeBrush2.Color = Color.FromArgb(50, 0, 0, 0);
            fadeBrush3.Color = Color.FromArgb(255, 0, 0, 0);
            Pen colorPen = new Pen(Color.GreenYellow, 1);
            SolidBrush colorBrush = new SolidBrush(Color.White);
            //g.DrawRectangle(xwingPen, x, y, 100 * mult, 100 * mult);

            PointF point1 = new PointF(0 *mult + x, 50*mult + y);
            PointF point2 = new PointF(50 * mult + x, 35*mult + y);
            PointF point3 = new PointF(100*mult + x, 50* mult + y);
            PointF point4 = new PointF(0 * mult + x, 50 * mult + y);
            PointF point5 = new PointF(50 * mult + x, 65 * mult + y);
            PointF point6 = new PointF(100 * mult + x, 50 * mult + y);

            PointF[] curvePoints = { point1, point2, point3 };
            PointF[] curvePoints2 = { point4, point5, point6 };
            //body
            g.DrawCurve(xwingPen, curvePoints2);
            g.DrawCurve(xwingPen, curvePoints);

            //bubble
            g.DrawArc(xwingPen, x + 27 * mult, y + 15 * mult, 142 / 3 * mult, 142 / 3 * mult, 175, 190);

            //ship lights
            g.DrawEllipse(xwingPen, x + 20 * mult, y + 47 * mult, 7 * mult, 7 * mult);
            g.DrawEllipse(xwingPen, x + 45 * mult, y + 45 * mult, 9 * mult, 9 * mult);
            g.DrawEllipse(xwingPen, x + 70 * mult, y + 47 * mult, 7 * mult, 7 * mult);
            g.FillEllipse(colorBrush, x + 20 * mult, y + 47 * mult, 7 * mult, 7 * mult);
            g.FillEllipse(colorBrush, x + 45 * mult, y + 45 * mult, 9 * mult, 9 * mult);
            g.FillEllipse(colorBrush, x + 70 * mult, y + 47 * mult, 7 * mult, 7 * mult);

            //landing gear
            g.DrawLine(xwingPen, x+ 25* mult, y  + 59 * mult, x + 10 * mult, y + 70 * mult);
            g.DrawLine(xwingPen, x+ 75 * mult, y + 59 * mult, x + 90 * mult, y + 70 * mult);
            g.DrawLine(xwingPen, x + 5 * mult, y + 70 * mult, x + 15 * mult, y + 70 * mult);
            g.DrawLine(xwingPen, x + 85 * mult, y + 70 * mult, x + 95 * mult, y + 70 * mult);

            //alien
            g.DrawArc(colorPen, x + 43 * mult, y +28 * mult, 142 / 10 * mult, 142 / 10 * mult, 180, 180 );
            g.DrawLine(colorPen, x + 40 * mult, y + 25 * mult, x + 45 * mult, y + 30 * mult);
            g.DrawLine(colorPen, x + 60 * mult, y + 25 * mult, x + 55 * mult, y + 30 * mult);

            //blaster module
            g.FillRectangle(colorBrush2, 34 * mult + x, 66 * mult + y, 32 * mult + x, 34 * mult + y);
            g.FillRectangle(colorBrush3, 35 * mult + x, 66 * mult + y, 30 * mult + x, 34 * mult + y);
            g.FillRectangle(colorBrush4, 36 * mult + x, 66 * mult + y, 28 * mult + x, 34 * mult + y);
            g.FillRectangle(colorBrush, 40 * mult + x, 66 * mult + y, 20 * mult + x, 34 * mult + y);
            g.DrawLine(xwingPen, 33 * mult + x, 62 * mult + y, 33 * mult + x, 66 * mult + y);
            g.DrawLine(xwingPen, 67 * mult + x, 62 * mult + y, 67 * mult + x, 66 * mult + y);
            g.DrawLine(xwingPen, 33 * mult + x, 66 * mult + y, 67 * mult + x, 66 * mult + y);

            //fading blaster
            g.FillRectangle(fadeBrush2, 0 * mult + x, 80 * mult + y, 100 * mult + x, 20 * mult + y);
            g.FillRectangle(fadeBrush2, 0 * mult + x, 75 * mult + y, 40 * mult + x, 25 * mult + y);
            g.FillRectangle(fadeBrush2, 60 * mult + x, 75 * mult + y, 40 * mult + x, 25 * mult + y);
            g.FillRectangle(fadeBrush, 0 * mult + x, 90 * mult + y, 100 * mult + x, 20 * mult + y);
            g.FillRectangle(fadeBrush3, 0 * mult + x, 90 * mult + y, 40 * mult + x, 10 * mult + y);
            g.FillRectangle(fadeBrush3, 60 * mult + x, 90 * mult + y, 40 * mult + x, 10 * mult + y);
            g.FillRectangle(fadeBrush, 0 * mult + x, 85 * mult + y, 40 * mult + x, 15 * mult + y);
            g.FillRectangle(fadeBrush, 60 * mult + x, 85 * mult + y, 40 * mult + x, 15 * mult + y);
            g.FillRectangle(fadeBrush2, 0 * mult + x, 95 * mult + y, 45 * mult + x, 5 * mult + y);
            g.FillRectangle(fadeBrush2, 55 * mult + x, 95 * mult + y, 45 * mult + x, 5 * mult + y);
        }
    }

}
