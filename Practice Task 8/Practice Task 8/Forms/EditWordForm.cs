using Practice_Task_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class EditWordForm : Form
    {
        private Word word;

        public EditWordForm(Word wordToEdit)
        {
            word = wordToEdit;
            InitializeComponent();
            LoadWordData();
        }

        private void LoadWordData()
        {
            txtWord.Text = word.Term;
            txtSynonyms.Text = word.GetSynonymsDisplay();
            txtCategory.Text = word.Category;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string synonymsText = txtSynonyms.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrEmpty(synonymsText))
            {
                MessageBox.Show("Введите синонимы!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            List<string> synonyms = synonymsText
                .Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim().ToLower())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();

            if (synonyms.Count == 0)
            {
                MessageBox.Show("Введите хотя бы один синоним!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                category = "Общая";
            }

            word.Synonyms = synonyms;
            word.Category = category;
        }
    }
}