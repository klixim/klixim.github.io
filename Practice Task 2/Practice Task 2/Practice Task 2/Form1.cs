using Practice_Task_2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice_Task_2
{
    public partial class Form1 : Form
    {
        // Элементы управления
        private TextBox txtNumber;
        private Button btnCalculate;
        private Label lblSingleResult;
        private GroupBox grpSingleInput;

        private Button btnLoadFile;
        private ListBox listBoxResults;
        private Label lblFileResult;
        private GroupBox grpFileInput;

        private Button btnClear;
        private Button btnExit;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        /// <summary>
        /// Инициализация компонентов формы
        /// </summary>
        private void SetupForm()
        {
            // Настройка формы
            this.Text = "Калькулятор цифрового корня";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Группа для ввода одного числа
            grpSingleInput = new GroupBox
            {
                Text = "Ввод одного числа",
                Location = new Point(12, 12),
                Size = new Size(560, 100)
            };

            Label lblNumber = new Label
            {
                Text = "Введите натуральное число:",
                Location = new Point(10, 25),
                Size = new Size(150, 20)
            };

            txtNumber = new TextBox
            {
                Location = new Point(170, 23),
                Size = new Size(200, 20)
            };

            btnCalculate = new Button
            {
                Text = "Вычислить",
                Location = new Point(380, 22),
                Size = new Size(100, 23),
                BackColor = Color.LightGreen
            };
            btnCalculate.Click += BtnCalculate_Click;

            lblSingleResult = new Label
            {
                Text = "Цифровой корень: —",
                Location = new Point(10, 60),
                Size = new Size(300, 20),
                Font = new Font(this.Font, FontStyle.Bold)
            };

            grpSingleInput.Controls.AddRange(new Control[] { lblNumber, txtNumber, btnCalculate, lblSingleResult });

            // Группа для загрузки файла
            grpFileInput = new GroupBox
            {
                Text = "Обработка файла",
                Location = new Point(12, 120),
                Size = new Size(560, 280)
            };

            btnLoadFile = new Button
            {
                Text = "Загрузить файл...",
                Location = new Point(10, 25),
                Size = new Size(120, 30)
            };
            btnLoadFile.Click += BtnLoadFile_Click;

            listBoxResults = new ListBox
            {
                Location = new Point(10, 65),
                Size = new Size(540, 175),
                Font = new Font("Consolas", 10)
            };

            lblFileResult = new Label
            {
                Text = "Готов к работе",
                Location = new Point(10, 245),
                Size = new Size(300, 20)
            };

            grpFileInput.Controls.AddRange(new Control[] { btnLoadFile, listBoxResults, lblFileResult });

            // Кнопки управления
            btnClear = new Button
            {
                Text = "Очистить",
                Location = new Point(12, 410),
                Size = new Size(100, 30)
            };
            btnClear.Click += BtnClear_Click;

            btnExit = new Button
            {
                Text = "Выход",
                Location = new Point(472, 410),
                Size = new Size(100, 30),
                BackColor = Color.LightCoral
            };
            btnExit.Click += (s, e) => Application.Exit();

            // Статусная строка
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel("Программа запущена");
            statusStrip.Items.Add(statusLabel);

            // Добавляем все элементы на форму
            this.Controls.AddRange(new Control[] {
                grpSingleInput,
                grpFileInput,
                btnClear,
                btnExit,
                statusStrip
            });
        }

        /// <summary>
        /// Обработчик кнопки "Вычислить"
        /// </summary>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtNumber.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Введите число", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumber.Focus();
                    return;
                }

                statusLabel.Text = "Вычисление...";

                int root = DigitalRootCalculator.Calculate(input);
                lblSingleResult.Text = $"Цифровой корень: {root}";

                statusLabel.Text = "Готово";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка ввода: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Ошибка ввода";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Ошибка";
            }
        }

        /// <summary>
        /// Обработчик кнопки "Загрузить файл"
        /// </summary>
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл с числами";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        statusLabel.Text = "Обработка файла...";
                        listBoxResults.Items.Clear();

                        var results = DigitalRootCalculator.CalculateFromFile(openFileDialog.FileName);

                        int successCount = 0;
                        int errorCount = 0;

                        foreach (var item in results)
                        {
                            if (item.IsSuccess)
                            {
                                listBoxResults.Items.Add($"✓ {item.Number} -> {item.Root}");
                                successCount++;
                            }
                            else
                            {
                                listBoxResults.Items.Add($"✗ {item.Number} -> Ошибка: {item.Error}");
                                errorCount++;
                            }
                        }

                        lblFileResult.Text = $"Обработано: {results.Count} (успешно: {successCount}, ошибок: {errorCount})";
                        statusLabel.Text = $"Файл обработан: {openFileDialog.FileName}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        statusLabel.Text = "Ошибка при чтении файла";
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик кнопки "Очистить"
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            lblSingleResult.Text = "Цифровой корень: —";
            listBoxResults.Items.Clear();
            lblFileResult.Text = "Готов к работе";
            statusLabel.Text = "Поля очищены";
            txtNumber.Focus();
        }
    }
}