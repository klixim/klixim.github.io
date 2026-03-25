using Practice_Task_4;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practice_Task_4
{
    public partial class Form1 : Form
    {
        private GroupCollection data = new GroupCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализируем область диаграммы, если её нет
            if (chart.ChartAreas.Count == 0)
            {
                chart.ChartAreas.Add(new ChartArea());
            }
            UpdateTable();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(txtDiscipline.Text))
                {
                    MessageBox.Show("Введите название дисциплины.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGroup.Text))
                {
                    MessageBox.Show("Введите номер группы.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Проверка корректности ввода чисел
                if (!int.TryParse(txtFive.Text, out int five) || five < 0)
                {
                    MessageBox.Show("Количество '5' должно быть целым неотрицательным числом.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtFour.Text, out int four) || four < 0)
                {
                    MessageBox.Show("Количество '4' должно быть целым неотрицательным числом.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtThree.Text, out int three) || three < 0)
                {
                    MessageBox.Show("Количество '3' должно быть целым неотрицательным числом.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtTwo.Text, out int two) || two < 0)
                {
                    MessageBox.Show("Количество '2' должно быть целым неотрицательным числом.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNotAtt.Text, out int notAtt) || notAtt < 0)
                {
                    MessageBox.Show("Количество неаттестованных должно быть целым неотрицательным числом.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Устанавливаем название дисциплины
                data.DisciplineName = txtDiscipline.Text;

                var group = new StudentGroup
                {
                    GroupNumber = txtGroup.Text,
                    FiveCount = five,
                    FourCount = four,
                    ThreeCount = three,
                    TwoCount = two,
                    NotAttestedCount = notAtt
                };

                data.AddGroup(group);
                UpdateTable();
                UpdateDisciplineList();
                DrawChart(); // Обновляем диаграмму после добавления
                ClearInputFields();

                MessageBox.Show("Данные успешно добавлены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTable()
        {
            dataGridView.Rows.Clear();
            foreach (var g in data.Groups)
            {
                dataGridView.Rows.Add(
                    g.GroupNumber,
                    g.FiveCount,
                    g.FourCount,
                    g.ThreeCount,
                    g.TwoCount,
                    g.NotAttestedCount,
                    g.AverageScore.ToString("F2")
                );
            }
        }

        private void UpdateDisciplineList()
        {
            cmbDisciplineForChart.Items.Clear();
            if (!string.IsNullOrEmpty(data.DisciplineName))
            {
                cmbDisciplineForChart.Items.Add(data.DisciplineName);
                cmbDisciplineForChart.SelectedItem = data.DisciplineName;
            }
        }

        private void CmbDisciplineForChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
            try
            {
                // Очищаем серии
                chart.Series.Clear();

                // Убеждаемся, что область диаграммы существует
                if (chart.ChartAreas.Count == 0)
                {
                    chart.ChartAreas.Add(new ChartArea());
                }

                // Проверка на наличие данных
                if (data.Groups == null || data.Groups.Count == 0)
                {
                    chart.Titles.Clear();
                    chart.Titles.Add("Нет данных для отображения");
                    return;
                }

                // Создаем серию для столбчатой диаграммы
                var series = new Series("Средний балл")
                {
                    ChartType = SeriesChartType.Column,
                    BorderWidth = 2,
                    ShadowOffset = 2
                };

                // Добавляем точки данных
                foreach (var g in data.Groups)
                {
                    series.Points.AddXY(g.GroupNumber, g.AverageScore);
                }

                // Настраиваем внешний вид серии
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "F2";
                series.Color = System.Drawing.Color.SteelBlue;
                series.Font = new System.Drawing.Font("Arial", 9);

                chart.Series.Add(series);

                // Настраиваем оси
                chart.ChartAreas[0].AxisX.Title = "Группа";
                chart.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
                chart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8);

                chart.ChartAreas[0].AxisY.Title = "Средний балл";
                chart.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Maximum = 5;
                chart.ChartAreas[0].AxisY.Interval = 1;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

                // Настраиваем заголовок
                chart.Titles.Clear();
                var title = new Title($"Успеваемость по дисциплине: {data.DisciplineName}")
                {
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.DarkBlue,
                    Docking = Docking.Top
                };
                chart.Titles.Add(title);

                // Настраиваем внешний вид области диаграммы
                chart.ChartAreas[0].BackColor = System.Drawing.Color.White;
                chart.ChartAreas[0].BorderColor = System.Drawing.Color.Gray;
                chart.ChartAreas[0].BorderWidth = 1;
                chart.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;

                chart.BackColor = System.Drawing.Color.WhiteSmoke;
                chart.BackGradientStyle = GradientStyle.TopBottom;
                chart.BackSecondaryColor = System.Drawing.Color.White;

                // Настраиваем легенду
                if (chart.Legends.Count == 0)
                {
                    chart.Legends.Add(new Legend());
                }
                chart.Legends[0].Docking = Docking.Bottom;
                chart.Legends[0].Font = new System.Drawing.Font("Arial", 9);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при построении диаграммы: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtGroup.Clear();
            txtFive.Clear();
            txtFour.Clear();
            txtThree.Clear();
            txtTwo.Clear();
            txtNotAtt.Clear();
            txtGroup.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.Groups.Count == 0)
                {
                    MessageBox.Show("Нет данных для сохранения.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Текстовые файлы|*.txt",
                    DefaultExt = "txt",
                    Title = "Сохранить данные"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    data.SaveToFile(sfd.FileName);
                    MessageBox.Show("Данные успешно сохранены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Текстовые файлы|*.txt",
                    Title = "Загрузить данные"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    data.LoadFromFile(ofd.FileName);
                    UpdateTable();
                    UpdateDisciplineList();
                    DrawChart();
                    MessageBox.Show("Данные успешно загружены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFindBest_Click(object sender, EventArgs e)
        {
            try
            {
                var best = data.GetBestGroup();
                if (best != null)
                {
                    lblBestResult.Text = $"Лучшая группа: {best.GroupNumber} (ср. балл = {best.AverageScore:F2})";
                    MessageBox.Show($"Лучшая группа: {best.GroupNumber}\nСредний балл: {best.AverageScore:F2}\n\nОценки:\n5: {best.FiveCount}\n4: {best.FourCount}\n3: {best.ThreeCount}\n2: {best.TwoCount}\nНе атт.: {best.NotAttestedCount}",
                        "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblBestResult.Text = "Нет данных для поиска.";
                    MessageBox.Show("Нет данных для поиска лучшей группы.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}