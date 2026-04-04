using System;
using System.Drawing;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class SettingsForm : Form
    {
        public static int QuestionsPerGame { get; set; } = 10;
        public static string SelectedTheme { get; set; } = "Стандартная";
        public static Color InterfaceColor { get; set; } = Color.LightSteelBlue;
        public static bool ShowAnimation { get; set; } = true;

        public SettingsForm()
        {
            InitializeComponent();
            LoadCurrentSettings();
        }

        private void LoadCurrentSettings()
        {
            numQuestions.Value = QuestionsPerGame;
            cmbTheme.SelectedItem = SelectedTheme;
            chkShowAnimation.Checked = ShowAnimation;
            lblColorPreview.BackColor = InterfaceColor;
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblColorPreview.BackColor = colorDialog.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QuestionsPerGame = (int)numQuestions.Value;
            SelectedTheme = cmbTheme.SelectedItem.ToString();
            ShowAnimation = chkShowAnimation.Checked;
            InterfaceColor = lblColorPreview.BackColor;

            MessageBox.Show("Настройки сохранены!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}