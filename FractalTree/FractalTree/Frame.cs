using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Size = new Size(500, 500);
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Fractal Tree";
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            paintFractalTree(pen, 240, 460, 13, 90, g);
        }

        private void paintFractalTree(Pen pen, float xo, float yo, int depth, double angle, Graphics line)
        {
            if (depth > -1)
            {   
                float yf = yo - (sin(degreeToRadian(angle)) * depth * 3);
                float xf = xo - (cos(degreeToRadian(angle)) * depth * 3);
                line.DrawLine(pen, xo, yo, xf, yf);
                paintFractalTree(pen, xf, yf, depth - 1, angle + 20, line);
                paintFractalTree(pen, xf, yf, depth - 1, angle - 20, line);
            }
        }

        private float cos(double angle)
        {
            return (float)Math.Cos(angle);
        }

        private float sin(double angle)
        {
            return (float)Math.Sin(angle);
        }

        private double degreeToRadian(double angle)
        {
            return (Math.PI * angle) / 180;
        }
    }
}
