using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DictionaryLibrary;

namespace Practice_Task_5
{
    public partial class Form1 : Form
    {
        private Slovar currentSlovar;
        private string currentPath;

        public Form1()
        {
            InitializeComponent();

            // Инициализация начального состояния
            UpdateUIState();
        }

        private void UpdateUIState()
        {
            // Включаем/отключаем кнопки в зависимости от того, загружен ли словарь
            bool isDictionaryLoaded = (currentSlovar != null);

            btnAddWord.Enabled = isDictionaryLoaded;
            btnRemoveWord.Enabled = isDictionaryLoaded;
            btnSearchConsonants.Enabled = isDictionaryLoaded;
            btnFuzzySearch.Enabled = isDictionaryLoaded;
            btnSaveDictionary.Enabled = isDictionaryLoaded;
            txtNewWord.Enabled = isDictionaryLoaded;
            txtFuzzy.Enabled = isDictionaryLoaded;
            numConsonantCount.Enabled = isDictionaryLoaded;
            radioStart.Enabled = isDictionaryLoaded;
            radioEnd.Enabled = isDictionaryLoaded;

            if (!isDictionaryLoaded)
            {
                lblCount.Text = "Слов: 0 (словарь не загружен)";
                if (listBoxWords.DataSource != null)
                {
                    listBoxWords.DataSource = null;
                }
            }
        }

        private void btnLoadDictionary_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
                ofd.Title = "Выберите файл словаря";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentPath = ofd.FileName;
                        currentSlovar = new Slovar(currentPath);
                        RefreshWordList();
                        UpdateUIState();

                        MessageBox.Show($"Словарь успешно загружен.\nНайдено слов: {currentSlovar.Count}",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки словаря:\n{ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        currentSlovar = null;
                        UpdateUIState();
                    }
                }
            }
        }

        private void RefreshWordList()
        {
            if (currentSlovar != null)
            {
                try
                {
                    List<string> words = currentSlovar.GetAllWords();
                    listBoxWords.DataSource = null;
                    listBoxWords.DataSource = words;
                    lblCount.Text = $"Слов: {currentSlovar.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления списка: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (currentSlovar == null)
            {
                MessageBox.Show("Сначала загрузите словарь", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string word = txtNewWord.Text.Trim();
            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введите слово для добавления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (currentSlovar.AddWord(word))
                {
                    RefreshWordList();
                    MessageBox.Show($"Слово \"{word}\" добавлено", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewWord.Clear();
                }
                else
                {
                    MessageBox.Show($"Слово \"{word}\" уже существует в словаре", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении слова: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            if (currentSlovar == null)
            {
                MessageBox.Show("Сначала загрузите словарь", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxWords.SelectedItem == null)
            {
                MessageBox.Show("Выберите слово для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string word = listBoxWords.SelectedItem.ToString();

            DialogResult result = MessageBox.Show($"Удалить слово \"{word}\"?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (currentSlovar.RemoveWord(word))
                    {
                        RefreshWordList();
                        MessageBox.Show($"Слово \"{word}\" удалено", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось удалить слово \"{word}\"",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении слова: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchConsonants_Click(object sender, EventArgs e)
        {
            if (currentSlovar == null)
            {
                MessageBox.Show("Сначала загрузите словарь", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int count = (int)numConsonantCount.Value;
                bool atStart = radioStart.Checked;

                if (count <= 0)
                {
                    MessageBox.Show("Количество согласных должно быть больше 0",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var results = currentSlovar.SearchByConsonantsAtStartOrEnd(count, atStart);
                ShowResults(results, $"Слова с {count} согласными в {(atStart ? "начале" : "конце")}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFuzzySearch_Click(object sender, EventArgs e)
        {
            if (currentSlovar == null)
            {
                MessageBox.Show("Сначала загрузите словарь", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pattern = txtFuzzy.Text.Trim();
            if (string.IsNullOrEmpty(pattern))
            {
                MessageBox.Show("Введите образец для нечёткого поиска", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var results = currentSlovar.FuzzySearch(pattern, 3);
                ShowResults(results, $"Нечёткий поиск: '{pattern}' (расстояние Левенштейна ≤ 3)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при нечётком поиске: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowResults(List<string> results, string searchType)
        {
            if (results == null)
            {
                results = new List<string>();
            }

            if (results.Count == 0)
            {
                MessageBox.Show($"По запросу \"{searchType}\"\nНичего не найдено.",
                    "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxResults.DataSource = null;
                btnSaveResults.Enabled = false;
            }
            else
            {
                listBoxResults.DataSource = results;
                btnSaveResults.Enabled = true;
                MessageBox.Show($"Найдено слов: {results.Count}\n{searchType}",
                    "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            if (listBoxResults.DataSource == null)
            {
                MessageBox.Show("Нет результатов для сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = listBoxResults.DataSource as List<string>;
            if (results == null || results.Count == 0)
            {
                MessageBox.Show("Нет результатов для сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы|*.txt";
                sfd.DefaultExt = "txt";
                sfd.Title = "Сохранить результаты поиска";
                sfd.FileName = $"результаты_поиска_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllLines(sfd.FileName, results);
                        MessageBox.Show($"Результаты успешно сохранены в файл:\n{sfd.FileName}",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveDictionary_Click(object sender, EventArgs e)
        {
            if (currentSlovar == null)
            {
                MessageBox.Show("Нет загруженного словаря", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Сохранить текущий словарь?\n\n" +
                "При сохранении будет создан новый файл.\n" +
                "Исходный словарь не будет изменён.",
                "Подтверждение сохранения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Текстовые файлы|*.txt";
                    sfd.DefaultExt = "txt";
                    sfd.Title = "Сохранить словарь";
                    sfd.FileName = System.IO.Path.GetFileNameWithoutExtension(currentPath) + "_modified.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            currentSlovar.SaveToFile(sfd.FileName);
                            MessageBox.Show($"Словарь успешно сохранён в файл:\n{sfd.FileName}",
                                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Опционально: показывать выбранное слово
            if (listBoxWords.SelectedItem != null)
            {
                // Можно добавить отображение выбранного слова в статусной строке
                // или для предварительного просмотра
            }
        }
    }
}