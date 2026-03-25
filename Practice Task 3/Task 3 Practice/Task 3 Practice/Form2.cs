using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_3_Practice
{
    public partial class Form2 : Form
    {
        public Color SelectedColor { get; private set; }
        public int TimerInterval { get; private set; }

        public Form2(Color currentColor, int currentInterval)
        {
            InitializeComponent();
            SelectedColor = currentColor;
            TimerInterval = currentInterval;

            btnColor.BackColor = currentColor;
            txtSpeed.Text = currentInterval.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog.Color;
                btnColor.BackColor = SelectedColor;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSpeed.Text, out int speed))
            {
                TimerInterval = speed;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректное число (интервал таймера в мс)");
            }
        }
    }
}