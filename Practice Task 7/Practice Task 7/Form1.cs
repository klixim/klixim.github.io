using Practice_Task_7.Figures;
using Practice_Task_7.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Practice_Task_7
{
    public partial class Form1 : Form
    {
        private List<Figure> _figures;
        private Figure _selectedFigure;
        private Point _mouseDownPoint;
        private bool _isDragging;
        private Point _dragStartPoint;
        private Figure _dragFigure;
        private StackMemory _undoStack;
        private StackMemory _redoStack;
        private Color _currentStrokeColor = Color.Black;
        private float _currentStrokeWidth = 2f;
        private DashStyle _currentDashStyle = DashStyle.Solid;

        public Form1()
        {
            InitializeComponent();
            _figures = new List<Figure>();
            _undoStack = new StackMemory(20);
            _redoStack = new StackMemory(20);
            SaveState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            UpdateUI();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Отрисовка всех фигур
            foreach (var figure in _figures)
            {
                figure.Draw(e.Graphics);
                if (figure.IsSelected)
                {
                    SelectionMarker.DrawMarkers(e.Graphics, figure.GetBounds());
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownPoint = e.Location;
            _isDragging = false;

            if (e.Button == MouseButtons.Left)
            {
                // Проверка попадания в фигуру
                Figure clickedFigure = null;
                for (int i = _figures.Count - 1; i >= 0; i--)
                {
                    if (_figures[i].HitTest(e.Location))
                    {
                        clickedFigure = _figures[i];
                        break;
                    }
                }

                if (clickedFigure != null)
                {
                    if (!clickedFigure.IsSelected)
                    {
                        // Снимаем выделение со всех фигур
                        foreach (var fig in _figures)
                            fig.IsSelected = false;
                        clickedFigure.IsSelected = true;
                        _selectedFigure = clickedFigure;
                        _dragFigure = clickedFigure;
                        _dragStartPoint = e.Location;
                        UpdateUI();
                        canvas.Invalidate();
                    }
                    else
                    {
                        _dragFigure = clickedFigure;
                        _dragStartPoint = e.Location;
                    }
                }
                else
                {
                    // Снимаем выделение
                    foreach (var fig in _figures)
                        fig.IsSelected = false;
                    _selectedFigure = null;
                    UpdateUI();
                    canvas.Invalidate();
                }
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _dragFigure != null)
            {
                int dx = e.X - _dragStartPoint.X;
                int dy = e.Y - _dragStartPoint.Y;

                if (Math.Abs(dx) > 2 || Math.Abs(dy) > 2)
                {
                    _isDragging = true;
                }

                if (_isDragging)
                {
                    _dragFigure.Move(dx, dy);
                    _dragStartPoint = e.Location;
                    canvas.Invalidate();
                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                SaveState();
            }
            _dragFigure = null;
            _isDragging = false;
        }

        #region Фигуры

        private void addEquilateralTriangle_Click(object sender, EventArgs e)
        {
            var triangle = new EquilateralTriangle();
            triangle.Bounds = new Rectangle(200, 200, 80, 80);
            triangle.Stroke.Color = _currentStrokeColor;
            triangle.Stroke.Width = _currentStrokeWidth;
            triangle.Stroke.DashStyle = _currentDashStyle;
            _figures.Add(triangle);
            SaveState();
            canvas.Invalidate();
        }

        private void addRightTriangle_Click(object sender, EventArgs e)
        {
            var triangle = new RightTriangle();
            triangle.Bounds = new Rectangle(200, 200, 80, 80);
            triangle.Stroke.Color = _currentStrokeColor;
            triangle.Stroke.Width = _currentStrokeWidth;
            triangle.Stroke.DashStyle = _currentDashStyle;
            _figures.Add(triangle);
            SaveState();
            canvas.Invalidate();
        }

        private void addIsoscelesTriangle_Click(object sender, EventArgs e)
        {
            var triangle = new IsoscelesTriangle();
            triangle.Bounds = new Rectangle(200, 200, 80, 80);
            triangle.Stroke.Color = _currentStrokeColor;
            triangle.Stroke.Width = _currentStrokeWidth;
            triangle.Stroke.DashStyle = _currentDashStyle;
            _figures.Add(triangle);
            SaveState();
            canvas.Invalidate();
        }

        private void addTrapezoid_Click(object sender, EventArgs e)
        {
            var trapezoid = new IsoscelesTrapezoid();
            trapezoid.Bounds = new Rectangle(200, 200, 100, 80);
            trapezoid.Stroke.Color = _currentStrokeColor;
            trapezoid.Stroke.Width = _currentStrokeWidth;
            trapezoid.Stroke.DashStyle = _currentDashStyle;
            _figures.Add(trapezoid);
            SaveState();
            canvas.Invalidate();
        }

        #endregion

        #region Редактирование

        private void deleteFigure_Click(object sender, EventArgs e)
        {
            if (_selectedFigure != null)
            {
                _figures.Remove(_selectedFigure);
                _selectedFigure = null;
                SaveState();
                canvas.Invalidate();
                UpdateUI();
            }
        }

        private void changeStrokeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _currentStrokeColor = colorDialog.Color;
                if (_selectedFigure != null)
                {
                    _selectedFigure.Stroke.Color = _currentStrokeColor;
                    SaveState();
                    canvas.Invalidate();
                }
            }
        }

        private void changeStrokeWidth_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtStrokeWidth.Text, out float width))
            {
                _currentStrokeWidth = width;
                if (_selectedFigure != null)
                {
                    _selectedFigure.Stroke.Width = _currentStrokeWidth;
                    SaveState();
                    canvas.Invalidate();
                }
            }
        }

        private void changeDashStyle_Click(object sender, EventArgs e)
        {
            if (cmbDashStyle.SelectedItem != null)
            {
                string style = cmbDashStyle.SelectedItem.ToString();
                _currentDashStyle = style switch
                {
                    "Сплошная" => DashStyle.Solid,
                    "Пунктирная" => DashStyle.Dash,
                    "Точечная" => DashStyle.Dot,
                    _ => DashStyle.Solid
                };

                if (_selectedFigure != null)
                {
                    _selectedFigure.Stroke.DashStyle = _currentDashStyle;
                    SaveState();
                    canvas.Invalidate();
                }
            }
        }

        #endregion

        #region Выравнивание (дополнительная функция по варианту 13)

        private void alignVerticalDistribute_Click(object sender, EventArgs e)
        {
            var selectedFigures = _figures.Where(f => f.IsSelected).ToList();
            if (selectedFigures.Count < 3)
            {
                MessageBox.Show("Выберите минимум 3 фигуры для выравнивания расстояний по вертикали",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Сортируем по Y координате
            selectedFigures = selectedFigures.OrderBy(f => f.Bounds.Y).ToList();

            float totalHeight = selectedFigures.Last().Bounds.Bottom - selectedFigures.First().Bounds.Top;
            float totalSpacing = totalHeight - selectedFigures.Sum(f => f.Bounds.Height);
            float spacing = totalSpacing / (selectedFigures.Count - 1);

            float currentY = selectedFigures.First().Bounds.Y;
            for (int i = 1; i < selectedFigures.Count - 1; i++)
            {
                currentY += selectedFigures[i - 1].Bounds.Height + spacing;
                selectedFigures[i].MoveTo(new Point(selectedFigures[i].Bounds.X, (int)currentY));
            }

            SaveState();
            canvas.Invalidate();
        }

        private void alignHorizontalDistribute_Click(object sender, EventArgs e)
        {
            var selectedFigures = _figures.Where(f => f.IsSelected).ToList();
            if (selectedFigures.Count < 3)
            {
                MessageBox.Show("Выберите минимум 3 фигуры для выравнивания расстояний по горизонтали",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Сортируем по X координате
            selectedFigures = selectedFigures.OrderBy(f => f.Bounds.X).ToList();

            float totalWidth = selectedFigures.Last().Bounds.Right - selectedFigures.First().Bounds.Left;
            float totalSpacing = totalWidth - selectedFigures.Sum(f => f.Bounds.Width);
            float spacing = totalSpacing / (selectedFigures.Count - 1);

            float currentX = selectedFigures.First().Bounds.X;
            for (int i = 1; i < selectedFigures.Count - 1; i++)
            {
                currentX += selectedFigures[i - 1].Bounds.Width + spacing;
                selectedFigures[i].MoveTo(new Point((int)currentX, selectedFigures[i].Bounds.Y));
            }

            SaveState();
            canvas.Invalidate();
        }

        #endregion

        #region Отмена/Повтор

        private void undo_Click(object sender, EventArgs e)
        {
            if (_undoStack.Count > 0)
            {
                var memoryStream = new MemoryStream();
                SaveToStream(memoryStream, _figures);
                _redoStack.Push(memoryStream);

                var undoStream = new MemoryStream();
                _undoStack.Pop(undoStream);
                LoadFromStream(undoStream);
                canvas.Invalidate();
                UpdateUI();
            }
        }

        private void redo_Click(object sender, EventArgs e)
        {
            if (_redoStack.Count > 0)
            {
                var memoryStream = new MemoryStream();
                SaveToStream(memoryStream, _figures);
                _undoStack.Push(memoryStream);

                var redoStream = new MemoryStream();
                _redoStack.Pop(redoStream);
                LoadFromStream(redoStream);
                canvas.Invalidate();
                UpdateUI();
            }
        }

        private void SaveState()
        {
            var memoryStream = new MemoryStream();
            SaveToStream(memoryStream, _figures);
            _undoStack.Push(memoryStream);
            _redoStack.Clear();
        }

        #endregion

        #region Копирование/Вырезание/Вставка

        private Figure _clipboardFigure;

        private void copy_Click(object sender, EventArgs e)
        {
            if (_selectedFigure != null)
            {
                _clipboardFigure = _selectedFigure.Clone();
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (_selectedFigure != null)
            {
                _clipboardFigure = _selectedFigure.Clone();
                _figures.Remove(_selectedFigure);
                _selectedFigure = null;
                SaveState();
                canvas.Invalidate();
                UpdateUI();
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            if (_clipboardFigure != null)
            {
                var newFigure = _clipboardFigure.Clone();
                newFigure.Move(20, 20);
                _figures.Add(newFigure);
                SaveState();
                canvas.Invalidate();
            }
        }

        #endregion

        #region Сохранение/Загрузка

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    SaveToStream(stream, _figures);
                }
                MessageBox.Show("Рисунок сохранен успешно!", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    LoadFromStream(stream);
                }
                canvas.Invalidate();
                UpdateUI();
                MessageBox.Show("Рисунок загружен успешно!", "Загрузка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Сохранить все фигуры в поток
        /// </summary>
        private void SaveToStream(Stream stream, List<Figure> listToSave = null)
        {
            var formatter = new BinaryFormatter();
            var list = (listToSave ?? _figures).ToList();
            formatter.Serialize(stream, list);
            stream.Position = 0;
        }

        /// <summary>
        /// Восстановить фигуры из потока в памяти
        /// </summary>
        private void LoadFromStream(Stream stream)
        {
            try
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                _figures = (List<Figure>)formatter.Deserialize(stream);
                _selectedFigure = null;
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Failed to deserialize. {ex.Message}", "Ошибка загрузки",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Клавиатурные команды

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (_selectedFigure != null)
            {
                int step = (Control.ModifierKeys == Keys.Shift) ? 1 : 5;

                switch (keyData)
                {
                    case Keys.Left:
                        _selectedFigure.Move(-step, 0);
                        SaveState();
                        canvas.Invalidate();
                        return true;
                    case Keys.Right:
                        _selectedFigure.Move(step, 0);
                        SaveState();
                        canvas.Invalidate();
                        return true;
                    case Keys.Up:
                        _selectedFigure.Move(0, -step);
                        SaveState();
                        canvas.Invalidate();
                        return true;
                    case Keys.Down:
                        _selectedFigure.Move(0, step);
                        SaveState();
                        canvas.Invalidate();
                        return true;
                    case Keys.Delete:
                        deleteFigure_Click(null, null);
                        return true;
                }
            }

            if (keyData == (Keys.Control | Keys.Z))
            {
                undo_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.Y))
            {
                redo_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.C))
            {
                copy_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.X))
            {
                cut_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.V))
            {
                paste_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        private void UpdateUI()
        {
            bool hasSelection = _selectedFigure != null;
            deleteToolStripMenuItem.Enabled = hasSelection;
            deleteButton.Enabled = hasSelection;
            cutToolStripMenuItem.Enabled = hasSelection;
            cutButton.Enabled = hasSelection;
            copyToolStripMenuItem.Enabled = hasSelection;
            copyButton.Enabled = hasSelection;

            pasteToolStripMenuItem.Enabled = _clipboardFigure != null;
            pasteButton.Enabled = _clipboardFigure != null;

            undoButton.Enabled = _undoStack.Count > 0;
            redoButton.Enabled = _redoStack.Count > 0;
        }
    }
}