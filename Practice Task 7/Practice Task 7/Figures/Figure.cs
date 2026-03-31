using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Practice_Task_7.Figures
{
    /// <summary>
    /// Базовый класс для всех фигур
    /// </summary>
    [Serializable]
    public abstract class Figure
    {
        protected Rectangle _bounds;
        protected bool _isSelected;
        protected Stroke _stroke;

        public Figure()
        {
            _stroke = new Stroke();
            _bounds = new Rectangle(100, 100, 100, 100);
            _isSelected = false;
        }

        /// <summary>
        /// Прямоугольная область фигуры
        /// </summary>
        public Rectangle Bounds
        {
            get { return _bounds; }
            set { _bounds = value; }
        }

        /// <summary>
        /// Выделена ли фигура
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }

        /// <summary>
        /// Контур фигуры
        /// </summary>
        public Stroke Stroke
        {
            get { return _stroke; }
            set { _stroke = value; }
        }

        /// <summary>
        /// Отрисовка фигуры
        /// </summary>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// Проверка попадания точки в фигуру
        /// </summary>
        public abstract bool HitTest(Point point);

        /// <summary>
        /// Сдвиг фигуры
        /// </summary>
        public virtual void Move(int dx, int dy)
        {
            _bounds.Offset(dx, dy);
        }

        /// <summary>
        /// Перемещение в заданную точку
        /// </summary>
        public virtual void MoveTo(Point location)
        {
            _bounds.Location = location;
        }

        /// <summary>
        /// Создание копии фигуры
        /// </summary>
        public abstract Figure Clone();

        /// <summary>
        /// Получение ограничивающего прямоугольника
        /// </summary>
        public virtual Rectangle GetBounds()
        {
            return _bounds;
        }
    }
}