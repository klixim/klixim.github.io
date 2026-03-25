namespace Practice_Task_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpDictionary;
        private System.Windows.Forms.Button btnLoadDictionary;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnSaveDictionary;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpFuzzySearch;
        private System.Windows.Forms.Button btnFuzzySearch;
        private System.Windows.Forms.TextBox txtFuzzy;
        private System.Windows.Forms.Label lblFuzzyPattern;
        private System.Windows.Forms.GroupBox grpConsonantSearch;
        private System.Windows.Forms.RadioButton radioEnd;
        private System.Windows.Forms.RadioButton radioStart;
        private System.Windows.Forms.NumericUpDown numConsonantCount;
        private System.Windows.Forms.Label lblConsonantCount;
        private System.Windows.Forms.Button btnSearchConsonants;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.ListBox listBoxResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpDictionary = new System.Windows.Forms.GroupBox();
            this.btnSaveDictionary = new System.Windows.Forms.Button();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.btnLoadDictionary = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpConsonantSearch = new System.Windows.Forms.GroupBox();
            this.radioEnd = new System.Windows.Forms.RadioButton();
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.numConsonantCount = new System.Windows.Forms.NumericUpDown();
            this.lblConsonantCount = new System.Windows.Forms.Label();
            this.btnSearchConsonants = new System.Windows.Forms.Button();
            this.grpFuzzySearch = new System.Windows.Forms.GroupBox();
            this.btnFuzzySearch = new System.Windows.Forms.Button();
            this.txtFuzzy = new System.Windows.Forms.TextBox();
            this.lblFuzzyPattern = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.grpDictionary.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpConsonantSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConsonantCount)).BeginInit();
            this.grpFuzzySearch.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDictionary
            // 
            this.grpDictionary.Controls.Add(this.btnSaveDictionary);
            this.grpDictionary.Controls.Add(this.btnRemoveWord);
            this.grpDictionary.Controls.Add(this.btnAddWord);
            this.grpDictionary.Controls.Add(this.txtNewWord);
            this.grpDictionary.Controls.Add(this.lblCount);
            this.grpDictionary.Controls.Add(this.listBoxWords);
            this.grpDictionary.Controls.Add(this.btnLoadDictionary);
            this.grpDictionary.Location = new System.Drawing.Point(12, 12);
            this.grpDictionary.Name = "grpDictionary";
            this.grpDictionary.Size = new System.Drawing.Size(350, 500);
            this.grpDictionary.TabIndex = 0;
            this.grpDictionary.TabStop = false;
            this.grpDictionary.Text = "Словарь";
            // 
            // btnSaveDictionary
            // 
            this.btnSaveDictionary.Location = new System.Drawing.Point(6, 460);
            this.btnSaveDictionary.Name = "btnSaveDictionary";
            this.btnSaveDictionary.Size = new System.Drawing.Size(338, 30);
            this.btnSaveDictionary.TabIndex = 6;
            this.btnSaveDictionary.Text = "Сохранить словарь";
            this.btnSaveDictionary.UseVisualStyleBackColor = true;
            this.btnSaveDictionary.Click += new System.EventHandler(this.btnSaveDictionary_Click);
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Location = new System.Drawing.Point(260, 410);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(84, 30);
            this.btnRemoveWord.TabIndex = 5;
            this.btnRemoveWord.Text = "Удалить";
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(170, 410);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(84, 30);
            this.btnAddWord.TabIndex = 4;
            this.btnAddWord.Text = "Добавить";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(6, 412);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(158, 20);
            this.txtNewWord.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(6, 385);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Слов: 0";
            // 
            // listBoxWords
            // 
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.Location = new System.Drawing.Point(6, 62);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(338, 303);
            this.listBoxWords.TabIndex = 1;
            this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.listBoxWords_SelectedIndexChanged);
            // 
            // btnLoadDictionary
            // 
            this.btnLoadDictionary.Location = new System.Drawing.Point(6, 25);
            this.btnLoadDictionary.Name = "btnLoadDictionary";
            this.btnLoadDictionary.Size = new System.Drawing.Size(338, 30);
            this.btnLoadDictionary.TabIndex = 0;
            this.btnLoadDictionary.Text = "Загрузить словарь";
            this.btnLoadDictionary.UseVisualStyleBackColor = true;
            this.btnLoadDictionary.Click += new System.EventHandler(this.btnLoadDictionary_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grpConsonantSearch);
            this.grpSearch.Controls.Add(this.grpFuzzySearch);
            this.grpSearch.Location = new System.Drawing.Point(368, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(420, 300);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Поиск";
            // 
            // grpConsonantSearch
            // 
            this.grpConsonantSearch.Controls.Add(this.radioEnd);
            this.grpConsonantSearch.Controls.Add(this.radioStart);
            this.grpConsonantSearch.Controls.Add(this.numConsonantCount);
            this.grpConsonantSearch.Controls.Add(this.lblConsonantCount);
            this.grpConsonantSearch.Controls.Add(this.btnSearchConsonants);
            this.grpConsonantSearch.Location = new System.Drawing.Point(6, 20);
            this.grpConsonantSearch.Name = "grpConsonantSearch";
            this.grpConsonantSearch.Size = new System.Drawing.Size(408, 120);
            this.grpConsonantSearch.TabIndex = 1;
            this.grpConsonantSearch.TabStop = false;
            this.grpConsonantSearch.Text = "Поиск по количеству согласных";
            // 
            // radioEnd
            // 
            this.radioEnd.AutoSize = true;
            this.radioEnd.Location = new System.Drawing.Point(215, 55);
            this.radioEnd.Name = "radioEnd";
            this.radioEnd.Size = new System.Drawing.Size(99, 17);
            this.radioEnd.TabIndex = 4;
            this.radioEnd.Text = "в конце слова";
            this.radioEnd.UseVisualStyleBackColor = true;
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Checked = true;
            this.radioStart.Location = new System.Drawing.Point(85, 55);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(96, 17);
            this.radioStart.TabIndex = 3;
            this.radioStart.TabStop = true;
            this.radioStart.Text = "в начале слова";
            this.radioStart.UseVisualStyleBackColor = true;
            // 
            // numConsonantCount
            // 
            this.numConsonantCount.Location = new System.Drawing.Point(145, 25);
            this.numConsonantCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numConsonantCount.Name = "numConsonantCount";
            this.numConsonantCount.Size = new System.Drawing.Size(50, 20);
            this.numConsonantCount.TabIndex = 2;
            this.numConsonantCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblConsonantCount
            // 
            this.lblConsonantCount.AutoSize = true;
            this.lblConsonantCount.Location = new System.Drawing.Point(6, 27);
            this.lblConsonantCount.Name = "lblConsonantCount";
            this.lblConsonantCount.Size = new System.Drawing.Size(115, 13);
            this.lblConsonantCount.TabIndex = 1;
            this.lblConsonantCount.Text = "Количество согласных:";
            // 
            // btnSearchConsonants
            // 
            this.btnSearchConsonants.Location = new System.Drawing.Point(6, 85);
            this.btnSearchConsonants.Name = "btnSearchConsonants";
            this.btnSearchConsonants.Size = new System.Drawing.Size(396, 30);
            this.btnSearchConsonants.TabIndex = 0;
            this.btnSearchConsonants.Text = "Найти";
            this.btnSearchConsonants.UseVisualStyleBackColor = true;
            this.btnSearchConsonants.Click += new System.EventHandler(this.btnSearchConsonants_Click);
            // 
            // grpFuzzySearch
            // 
            this.grpFuzzySearch.Controls.Add(this.btnFuzzySearch);
            this.grpFuzzySearch.Controls.Add(this.txtFuzzy);
            this.grpFuzzySearch.Controls.Add(this.lblFuzzyPattern);
            this.grpFuzzySearch.Location = new System.Drawing.Point(6, 150);
            this.grpFuzzySearch.Name = "grpFuzzySearch";
            this.grpFuzzySearch.Size = new System.Drawing.Size(408, 130);
            this.grpFuzzySearch.TabIndex = 0;
            this.grpFuzzySearch.TabStop = false;
            this.grpFuzzySearch.Text = "Нечёткий поиск (расстояние Левенштейна ≤ 3)";
            // 
            // btnFuzzySearch
            // 
            this.btnFuzzySearch.Location = new System.Drawing.Point(6, 85);
            this.btnFuzzySearch.Name = "btnFuzzySearch";
            this.btnFuzzySearch.Size = new System.Drawing.Size(396, 30);
            this.btnFuzzySearch.TabIndex = 2;
            this.btnFuzzySearch.Text = "Найти";
            this.btnFuzzySearch.UseVisualStyleBackColor = true;
            this.btnFuzzySearch.Click += new System.EventHandler(this.btnFuzzySearch_Click);
            // 
            // txtFuzzy
            // 
            this.txtFuzzy.Location = new System.Drawing.Point(85, 45);
            this.txtFuzzy.Name = "txtFuzzy";
            this.txtFuzzy.Size = new System.Drawing.Size(317, 20);
            this.txtFuzzy.TabIndex = 1;
            // 
            // lblFuzzyPattern
            // 
            this.lblFuzzyPattern.AutoSize = true;
            this.lblFuzzyPattern.Location = new System.Drawing.Point(6, 48);
            this.lblFuzzyPattern.Name = "lblFuzzyPattern";
            this.lblFuzzyPattern.Size = new System.Drawing.Size(54, 13);
            this.lblFuzzyPattern.TabIndex = 0;
            this.lblFuzzyPattern.Text = "Образец:";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.btnSaveResults);
            this.grpResults.Controls.Add(this.listBoxResults);
            this.grpResults.Location = new System.Drawing.Point(368, 318);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(420, 194);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Результаты поиска";
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Enabled = false;
            this.btnSaveResults.Location = new System.Drawing.Point(6, 155);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(408, 30);
            this.btnSaveResults.TabIndex = 1;
            this.btnSaveResults.Text = "Сохранить результаты в файл";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(6, 25);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(408, 121);
            this.listBoxResults.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpDictionary);
            this.Name = "Form1";
            this.Text = "Работа со словарём - Вариант 13";
            this.grpDictionary.ResumeLayout(false);
            this.grpDictionary.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpConsonantSearch.ResumeLayout(false);
            this.grpConsonantSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConsonantCount)).EndInit();
            this.grpFuzzySearch.ResumeLayout(false);
            this.grpFuzzySearch.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}