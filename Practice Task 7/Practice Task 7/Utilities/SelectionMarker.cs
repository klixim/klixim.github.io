using System.Drawing;

namespace Practice_Task_7.Utilities
{
    /// <summary>
    /// Класс для отрисовки маркеров выделения фигуры
    /// </summary>
    public static class SelectionMarker
    {
        private const int MarkerSize = 8;

        /// <summary>
        /// Отрисовка маркеров выделения
        /// </summary>
        public static void DrawMarkers(Graphics g, Rectangle bounds)
        {
            using (var pen = new Pen(Color.Blue, 2))
            using (var brush = new SolidBrush(Color.White))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, bounds);

                // Рисуем маркеры по углам
                Point[] markers = new Point[]
                {
                    new Point(bounds.Left - MarkerSize/2, bounds.Top - MarkerSize/2),
                    new Point(bounds.Right - MarkerSize/2, bounds.Top - MarkerSize/2),
                    new Point(bounds.Left - MarkerSize/2, bounds.Bottom - MarkerSize/2),
                    new Point(bounds.Right - MarkerSize/2, bounds.Bottom - MarkerSize/2)
                };

                foreach (var marker in markers)
                {
                    g.FillRectangle(brush, marker.X, marker.Y, MarkerSize, MarkerSize);
                    g.DrawRectangle(pen, marker.X, marker.Y, MarkerSize, MarkerSize);
                }
            }
        }

        /// <summary>
        /// Проверка попадания в маркер
        /// </summary>
        public static bool HitTestMarker(Point point, Rectangle bounds, out int markerIndex)
        {
            markerIndex = -1;
            Point[] markers = new Point[]
            {
                new Point(bounds.Left - MarkerSize/2, bounds.Top - MarkerSize/2),
                new Point(bounds.Right - MarkerSize/2, bounds.Top - MarkerSize/2),
                new Point(bounds.Left - MarkerSize/2, bounds.Bottom - MarkerSize/2),
                new Point(bounds.Right - MarkerSize/2, bounds.Bottom - MarkerSize/2)
            };

            for (int i = 0; i < markers.Length; i++)
            {
                Rectangle markerRect = new Rectangle(markers[i].X, markers[i].Y, MarkerSize, MarkerSize);
                if (markerRect.Contains(point))
                {
                    markerIndex = i;
                    return true;
                }
            }
            return false;
        }
    }
}