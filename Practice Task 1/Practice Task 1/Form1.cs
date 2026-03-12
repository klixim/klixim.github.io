using System;
using System.Windows.Forms;

namespace Practice_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double eps = double.Parse(txtEps.Text);

                // Проверка области сходимости (x > 1)
                if (x <= 1)
                {
                    MessageBox.Show("Для данного разложения должно выполняться условие x > 1",
                        "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Вычисление суммы ряда
                double sum = Math.PI / 2; // Начальное значение (π/2)
                double term = -1.0 / x;   // Первый член ряда (n=0)
                int n = 0;                 // Счетчик членов ряда
                int iterations = 0;        // Количество итераций

                // Цикл с неизвестным числом повторений
                while (Math.Abs(term) > eps)
                {
                    sum += term;
                    iterations++;

                    // Рекуррентная формула: a(n+1) = -a(n) * (2n+1) / ((2n+3) * x^2)
                    term = -term * (2 * n + 1) / ((2 * n + 3) * x * x);
                    n++;

                    // ТОЧКА ОСТАНОВА для отладчика (поставьте breakpoint здесь)
                }

                // Вывод результатов
                lblFunctionValue.Text = Math.Atan(x).ToString("F10");
                lblSeriesSum.Text = sum.ToString("F10");
                lblIterations.Text = iterations.ToString();
                lblDifference.Text = Math.Abs(Math.Atan(x) - sum).ToString("E2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка ввода в поле X (только цифры, точка, минус)
        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем: цифры, точку, минус, управляющие символы (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Минус можно ввести только в начале
            if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart != 0)
            {
                e.Handled = true;
            }

            // Точку можно ввести только одну
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // Проверка ввода в поле точности (только цифры и точка, без минуса)
        private void txtEps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Точку можно ввести только одну
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // Валидация при изменении текста
        private void txtX_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtEps_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Проверка корректности введенных данных
        private void ValidateInputs()
        {
            bool isValidX = double.TryParse(txtX.Text, out double x);
            bool isValidEps = double.TryParse(txtEps.Text, out double eps);

            btnCalculate.Enabled = isValidX && isValidEps &&
                                   !string.IsNullOrWhiteSpace(txtX.Text) &&
                                   !string.IsNullOrWhiteSpace(txtEps.Text) &&
                                   eps > 0;
        }

        // Пример обработки исключения (для задания 3.2)
        private void btnTestException_Click(object sender, EventArgs e)
        {
            try
            {
                // Искусственное исключение для демонстрации работы отладчика
                throw new InvalidOperationException("Тестовое исключение для отладки");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Перехвачено исключение: {ex.Message}",
                    "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}