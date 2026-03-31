using Practice_Task_7.Figures;
using Practice_Task_7.Utilities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Practice_Task_7.Figures
{
    /// <summary>
    /// Равносторонний треугольник
    /// </summary>
    [Serializable]
    public class EquilateralTriangle : Figure
    {
        public EquilateralTriangle()
        {
            _bounds = new Rectangle(100, 100, 100, 100);
        }

        public override void Draw(Graphics g)
        {
            Point[] points = GetTrianglePoints();
            using (var pen = _stroke.CreatePen())
            {
                g.DrawPolygon(pen, points);
            }
        }

        public override bool HitTest(Point point)
        {
            Point[] points = GetTrianglePoints();
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(points);
                return path.IsVisible(point);
            }
        }

        private Point[] GetTrianglePoints()
        {
            int height = (int)(_bounds.Height * Math.Sqrt(3) / 2);
            Point[] points = new Point[3];
            points[0] = new Point(_bounds.Left + _bounds.Width / 2, _bounds.Top);
            points[1] = new Point(_bounds.Left, _bounds.Top + height);
            points[2] = new Point(_bounds.Right, _bounds.Top + height);
            return points;
        }

        public override Figure Clone()
        {
            return new EquilateralTriangle
            {
                Bounds = new Rectangle(_bounds.X, _bounds.Y, _bounds.Width, _bounds.Height),
                Stroke = new Stroke
                {
                    Color = _stroke.Color,
                    Width = _stroke.Width,
                    DashStyle = _stroke.DashStyle,
                    Alpha = _stroke.Alpha
                }
            };
        }
    }
}