using System;
using System.Drawing;
using System.Windows.Forms;
using Task_3_Practice;

namespace Task_3_Practice
{
    public partial class Form1 : Form
    {
        // Параметры треугольника
        private int baseWidth = 40;
        private int currentHeight = 35;
        private int minHeight = 35;
        private int maxHeight = 70;

        private int x = 50;
        private int y = 100;

        private int directionX = 5;
        private int heightDirection = 1;

        private Color triangleColor = Color.Blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Движение вправо-влево
            x += directionX;

            // Проверка границ формы
            if (x + baseWidth / 2 > this.ClientSize.Width)
            {
                x = this.ClientSize.Width - baseWidth / 2;
                directionX = -directionX;
            }
            else if (x - baseWidth / 2 < 0)
            {
                x = baseWidth / 2;
                directionX = -directionX;
            }

            // Изменение высоты
            currentHeight += heightDirection;

            if (currentHeight > maxHeight)
            {
                currentHeight = maxHeight;
                heightDirection = -heightDirection;
            }
            else if (currentHeight < minHeight)
            {
                currentHeight = minHeight;
                heightDirection = -heightDirection;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawTriangle(e.Graphics);
        }

        private void DrawTriangle(Graphics g)
        {
            PointF top = new PointF(x, y);
            PointF left = new PointF(x - baseWidth / 2, y + currentHeight);
            PointF right = new PointF(x + baseWidth / 2, y + currentHeight);

            PointF[] points = { top, right, left };

            using (SolidBrush brush = new SolidBrush(triangleColor))
            {
                g.FillPolygon(brush, points);
            }

            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPolygon(pen, points);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2(triangleColor, animationTimer.Interval);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                triangleColor = settingsForm.SelectedColor;
                animationTimer.Interval = settingsForm.TimerInterval;
            }
        }
    }
}