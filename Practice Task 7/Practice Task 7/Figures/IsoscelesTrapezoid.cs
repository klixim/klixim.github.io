using Practice_Task_7.Figures;
using Practice_Task_7.Utilities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Practice_Task_7.Figures
{
    /// <summary>
    /// Равнобедренная трапеция
    /// </summary>
    [Serializable]
    public class IsoscelesTrapezoid : Figure
    {
        public IsoscelesTrapezoid()
        {
            _bounds = new Rectangle(100, 100, 100, 100);
        }

        public override void Draw(Graphics g)
        {
            Point[] points = GetTrapezoidPoints();
            using (var pen = _stroke.CreatePen())
            {
                g.DrawPolygon(pen, points);
            }
        }

        public override bool HitTest(Point point)
        {
            Point[] points = GetTrapezoidPoints();
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(points);
                return path.IsVisible(point);
            }
        }

        private Point[] GetTrapezoidPoints()
        {
            int topWidth = _bounds.Width / 2;
            int topOffset = (_bounds.Width - topWidth) / 2;

            Point[] points = new Point[4];
            points[0] = new Point(_bounds.Left + topOffset, _bounds.Top);
            points[1] = new Point(_bounds.Right - topOffset, _bounds.Top);
            points[2] = new Point(_bounds.Right, _bounds.Bottom);
            points[3] = new Point(_bounds.Left, _bounds.Bottom);
            return points;
        }

        public override Figure Clone()
        {
            return new IsoscelesTrapezoid
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