namespace PracticeTask8
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtSynonyms = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblSynonyms = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabView);
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 580);
            this.tabControl.TabIndex = 0;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.White;
            this.tabView.Controls.Add(this.dgvWords);
            this.tabView.Controls.Add(this.btnRefresh);
            this.tabView.Controls.Add(this.btnEdit);
            this.tabView.Controls.Add(this.btnDelete);
            this.tabView.Controls.Add(this.cmbCategoryFilter);
            this.tabView.Controls.Add(this.btnFilter);
            this.tabView.Controls.Add(this.lblInfo);
            this.tabView.Controls.Add(this.btnClose);
            this.tabView.Location = new System.Drawing.Point(4, 27);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(792, 549);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "Просмотр и управление словами";
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWords.BackgroundColor = System.Drawing.Color.White;
            this.dgvWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWords.Location = new System.Drawing.Point(20, 60);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.ReadOnly = true;
            this.dgvWords.RowHeadersVisible = false;
            this.dgvWords.RowTemplate.Height = 24;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWords.Size = new System.Drawing.Size(740, 380);
            this.dgvWords.TabIndex = 0;
            this.dgvWords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightGray;
            this.btnRefresh.Location = new System.Drawing.Point(650, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGreen;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(20, 450);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(150, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(350, 20);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(180, 28);
            this.cmbCategoryFilter.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightBlue;
            this.btnFilter.Location = new System.Drawing.Point(540, 18);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 30);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Всего слов в словаре: 0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(640, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.txtWord);
            this.tabAdd.Controls.Add(this.txtSynonyms);
            this.tabAdd.Controls.Add(this.txtCategory);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.lblWord);
            this.tabAdd.Controls.Add(this.lblSynonyms);
            this.tabAdd.Controls.Add(this.lblCategory);
            this.tabAdd.Location = new System.Drawing.Point(4, 27);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(792, 549);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Добавление нового слова";
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtWord.Location = new System.Drawing.Point(50, 85);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(350, 26);
            this.txtWord.TabIndex = 0;
            // 
            // txtSynonyms
            // 
            this.txtSynonyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSynonyms.Location = new System.Drawing.Point(50, 165);
            this.txtSynonyms.Multiline = true;
            this.txtSynonyms.Name = "txtSynonyms";
            this.txtSynonyms.Size = new System.Drawing.Size(550, 80);
            this.txtSynonyms.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCategory.Location = new System.Drawing.Point(50, 305);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(350, 26);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.Text = "Общая";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(200, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить слово";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWord.Location = new System.Drawing.Point(50, 50);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(150, 30);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "Слово:*";
            // 
            // lblSynonyms
            // 
            this.lblSynonyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSynonyms.Location = new System.Drawing.Point(50, 130);
            this.lblSynonyms.Name = "lblSynonyms";
            this.lblSynonyms.Size = new System.Drawing.Size(250, 30);
            this.lblSynonyms.TabIndex = 5;
            this.lblSynonyms.Text = "Синонимы (через запятую):*";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategory.Location = new System.Drawing.Point(50, 270);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(150, 30);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Категория:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора - Управление словарём";
            this.tabControl.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblSynonyms;
        private System.Windows.Forms.Label lblCategory;
    }
}