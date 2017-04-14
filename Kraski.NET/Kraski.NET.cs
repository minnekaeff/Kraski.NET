using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kraski.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isPressed = false; // нажата ли кнопка мыши
        Pen brush = new Pen(Color.Black, 1); // кисть
        int tool = 1; // инструмент
        float X1, Y1, X2, Y2; // текущее положение (X1, Y1) и конечное положение (X2, Y2)
        Graphics G; // поверхность рисования

        private void Form1_Load(object sender, EventArgs e)
        {
            G = pictureBox2.CreateGraphics();
        }

        // параметры кисти
        private void pictureBox1_Click(object sender, EventArgs e) // изменение цвета
        {
            colorDialog1.ShowDialog();
            brush = new Pen(colorDialog1.Color, brush.Width);
            pbColor.BackColor = colorDialog1.Color;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // ращмер 
        {
            brush = new Pen(brush.Color, Convert.ToInt32(numericUpDown1.Value));
        }

        // управление мышью
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
            isPressed = true;
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            switch(tool)
            {
                case 1:
                    if (isPressed)
                    {
                        myLine(X1, Y1, e.X, e.Y);
                        X1 = e.X;
                        Y1 = e.Y;
                    }
                    break;
                default:
                    break;
            }
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            X2 = e.X;
            Y2 = e.Y;
            switch (tool)
            {
                case 2:
                    myLine(X1, Y1, X2, Y2);
                    break;
                case 3:
                    myTriangle(X1, Y1, X2, Y2);
                    break;
                case 4:
                    myRectangle(X1, Y1, X2, Y2);
                    break;
                case 5:
                    myСircle(X1, Y1, X2, Y2);
                    break;
                case 6:
                    myEllipse(X1, Y1, Math.Abs(e.X - X1), Math.Abs(e.Y - Y1));
                    break;
                default:
                    break;
            }
            isPressed = false;
        }
        
        // инструменты
        private void button1_Click(object sender, EventArgs e) // очистить
        {
            G.Clear(Color.White);
        }
        private void btnPencil_Click(object sender, EventArgs e) // карандаш
        {
            tool = 1;
        }
        private void btnLine_Click(object sender, EventArgs e) // прямая
        {
            tool = 2;
        }
        private void btnTriangle_Click(object sender, EventArgs e) // треугольник
        {
            tool = 3;
        }
        private void btnRectangle_Click(object sender, EventArgs e) // прямоугольник
        {
            tool = 4;
        }
        private void btnCircle_Click(object sender, EventArgs e) // окружность
        {
            tool = 5;
        }
        private void btnEllipse_Click(object sender, EventArgs e) // эллипс
        {
            tool = 6;
        }
        private void btnFractal_Click(object sender, EventArgs e) // кнопка для рисования фрактала
        {
            myFractal(780, 374, G, brush);
        }


        // фигуры 
        public void myPoint(float x, float y) // точка
        {
            G.DrawEllipse(brush, x, y, brush.Width, brush.Width);
        }
        public void myLine(float x1, float y1, float x2, float y2) // линия
        {
            float deltaX = Math.Abs(x2 - x1);
            float deltaY = Math.Abs(y2 - y1);
            float signX = x1 < x2 ? 1 : -1;
            float signY = y1 < y2 ? 1 : -1;
            
            float error = deltaX - deltaY;
            myPoint(x1, y1);
            while (x1 != x2 || y1 != y2)
            {
                myPoint(x1, y1);
                float error2 = error * 2;

                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x1 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y1 += signY;
                }
            }
        }
        public void myTriangle(float x1, float y1, float x2, float y2) // треугольник
        {
            myLine(X1, Y1, X2, Y2);
            myLine(X1, Y1, X1 - (X2 - X1), Y2); 
            myLine(X1 - (X2 - X1), Y2, X2, Y2);

        }
        public void myRectangle(float x1, float y1, float x2, float y2) // прямоугольник
        {
            myLine(X1, Y1, X1, Y2);
            myLine(X1, Y1, X2, Y1);
            myLine(X2, Y2, X1, Y2);
            myLine(X2, Y2, X2, Y1);
        }
        public void myСircle(float x1, float y1, float x2, float y2) // окружность
        {
            double R = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            for (int i = 0; i < 2880; i++)
            {
                myPoint(x1 + (float)(R * Math.Cos(2 * Math.PI / 2880 * i)), y1 + (float)(R * Math.Sin(2 * Math.PI / 2880 * i)));
            }

        }
        public void myEllipse(float x, float y, float a, float b) // эллипс
        {
            int col, row;
            long S_a, S_b, two_S_a, two_S_b, four_S_a, four_S_b, d;

            S_b = (int)(b * b);
            S_a = (int)(a * a);
            row = (int)b;
            col = 0;
            two_S_a = S_a << 1;
            four_S_a = S_a << 2;
            four_S_b = S_b << 2;
            two_S_b = S_b << 1;
            d = two_S_a * ((row - 1) * (row)) + S_a + two_S_b * (1 - S_a);
            while (S_a * (row) > S_b * (col))
            {
                myPoint(col + x, row + y);
                myPoint(col + x, y - row);
                myPoint(x - col, row + y);
                myPoint(x - col, y - row);
                if (d >= 0)
                {
                    row--;
                    d -= four_S_a * (row);
                }
                d += two_S_b * (3 + (col << 1));
                col++;
            }
            d = two_S_b * (col + 1) * col + two_S_a * (row * (row - 2) + 1) + (1 - two_S_a) * S_b;
            while (row + 1 > 0)
            {
                myPoint(col + x, row + y);
                myPoint(col + x, y - row);
                myPoint(x - col, row + y);
                myPoint(x - col, y - row);
                if (d <= 0)
                {
                    col++;
                    d += four_S_b * col;
                }
                row--;
                d += two_S_a * (3 - (row << 1));
            }
        }

        // фрактал
        public void myFractal(int w, int h, Graphics g, Pen pen) // код фрактала
        {
            double cRe, cIm;
            double newRe, newIm, oldRe, oldIm;
            double zoom = (double)nudZoom.Value;
            double moveX = (double)nudX.Value;
            double moveY = (double)nudY.Value;
            int maxIterations = 300;

            // это определяет форму фрактала 
            cRe = -0.70176;
            cIm = -0.3842;
            
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;
                    
                    int i;
                    
                    for (i = 0; i < maxIterations; i++)
                    {
                        oldRe = newRe;
                        oldIm = newIm;
                        
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        if ((newRe * newRe + newIm * newIm) > 4) break;
                    }

                    pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    myPoint(x, y);
                }
        }
    }
}
