using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class AdminForm : Form
    {
        private GameData gameData;

        public AdminForm(GameData data)
        {
            gameData = data;
            InitializeComponent();
            LoadWordsToList();
            UpdateCategoryFilter();
            SetupDataGridViewColumns();
        }

        private void SetupDataGridViewColumns()
        {
            dgvWords.Columns.Clear();

            DataGridViewTextBoxColumn colWord = new DataGridViewTextBoxColumn();
            colWord.Name = "Word";
            colWord.HeaderText = "Слово";
            colWord.Width = 150;

            DataGridViewTextBoxColumn colSynonyms = new DataGridViewTextBoxColumn();
            colSynonyms.Name = "Synonyms";
            colSynonyms.HeaderText = "Синонимы";
            colSynonyms.Width = 350;

            DataGridViewTextBoxColumn colCategory = new DataGridViewTextBoxColumn();
            colCategory.Name = "Category";
            colCategory.HeaderText = "Категория";
            colCategory.Width = 150;

            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colWord, colSynonyms, colCategory });
        }

        private void LoadWordsToList()
        {
            LoadWordsToGrid(null);
        }

        private void LoadWordsToGrid(string categoryFilter)
        {
            dgvWords.Rows.Clear();

            var words = gameData.Words;
            if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "Все категории")
            {
                words = words.Where(w => w.Category == categoryFilter).ToList();
            }

            foreach (var word in words)
            {
                dgvWords.Rows.Add(word.Term, word.GetSynonymsDisplay(), word.Category);
            }

            lblInfo.Text = $"Всего слов в словаре: {words.Count}";

            bool hasSelection = dgvWords.SelectedRows.Count > 0;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        private void UpdateCategoryFilter()
        {
            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("Все категории");

            var categories = gameData.GetCategories();
            foreach (var cat in categories)
            {
                cmbCategoryFilter.Items.Add(cat);
            }

            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filter = cmbCategoryFilter.SelectedItem.ToString();
            if (filter == "Все категории")
            {
                LoadWordsToGrid(null);
            }
            else
            {
                LoadWordsToGrid(filter);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gameData.LoadData();
            LoadWordsToList();
            UpdateCategoryFilter();
            MessageBox.Show("Список слов обновлён!", "Обновление",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите слово для редактирования!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oldWord = dgvWords.SelectedRows[0].Cells["Word"].Value.ToString();
            var wordToEdit = gameData.Words.FirstOrDefault(w => w.Term == oldWord);

            if (wordToEdit != null)
            {
                EditWordForm editForm = new EditWordForm(wordToEdit);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    gameData.SaveData();
                    LoadWordsToList();
                    UpdateCategoryFilter();
                    MessageBox.Show("Слово успешно обновлено!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите слово для удаления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string wordToDelete = dgvWords.SelectedRows[0].Cells["Word"].Value.ToString();

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить слово \"{wordToDelete}\"?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (gameData.RemoveWord(wordToDelete))
                {
                    LoadWordsToList();
                    UpdateCategoryFilter();
                    MessageBox.Show("Слово успешно удалено!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении слова!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim();
            string synonymsText = txtSynonyms.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введите слово!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWord.Focus();
                return;
            }

            if (string.IsNullOrEmpty(synonymsText))
            {
                MessageBox.Show("Введите синонимы!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSynonyms.Focus();
                return;
            }

            if (gameData.Words.Any(w => w.Term == word.ToLower()))
            {
                MessageBox.Show("Такое слово уже существует в словаре!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                category = "Общая";
            }

            gameData.AddWord(word, synonyms, category);

            txtWord.Clear();
            txtSynonyms.Clear();
            txtCategory.Text = "Общая";

            LoadWordsToList();
            UpdateCategoryFilter();

            MessageBox.Show($"Слово \"{word}\" успешно добавлено в словарь!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtWord.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}