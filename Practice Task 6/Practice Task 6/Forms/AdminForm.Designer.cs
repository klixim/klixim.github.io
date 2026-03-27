namespace Practice_Task_6.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstThemes;
        private System.Windows.Forms.ListBox lstLevels;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtInvention;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox chkCorrect1;
        private System.Windows.Forms.CheckBox chkCorrect2;
        private System.Windows.Forms.CheckBox chkCorrect3;
        private System.Windows.Forms.CheckBox chkCorrect4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnCreateTheme;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblInvention;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblAnswers;

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
            this.lstThemes = new System.Windows.Forms.ListBox();
            this.lstLevels = new System.Windows.Forms.ListBox();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtInvention = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.chkCorrect1 = new System.Windows.Forms.CheckBox();
            this.chkCorrect2 = new System.Windows.Forms.CheckBox();
            this.chkCorrect3 = new System.Windows.Forms.CheckBox();
            this.chkCorrect4 = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnCreateTheme = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblInvention = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lstThemes
            // 
            this.lstThemes.ItemHeight = 16;
            this.lstThemes.Location = new System.Drawing.Point(12, 40);
            this.lstThemes.Name = "lstThemes";
            this.lstThemes.Size = new System.Drawing.Size(180, 148);
            this.lstThemes.TabIndex = 0;
            this.lstThemes.SelectedIndexChanged += new System.EventHandler(this.lstThemes_SelectedIndexChanged);
            // 
            // lstLevels
            // 
            this.lstLevels.ItemHeight = 16;
            this.lstLevels.Location = new System.Drawing.Point(200, 40);
            this.lstLevels.Name = "lstLevels";
            this.lstLevels.Size = new System.Drawing.Size(150, 148);
            this.lstLevels.TabIndex = 1;
            this.lstLevels.SelectedIndexChanged += new System.EventHandler(this.lstLevels_SelectedIndexChanged);
            // 
            // lstQuestions
            // 
            this.lstQuestions.ItemHeight = 16;
            this.lstQuestions.Location = new System.Drawing.Point(360, 40);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(250, 148);
            this.lstQuestions.TabIndex = 2;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // lblTheme
            // 
            this.lblTheme.Location = new System.Drawing.Point(12, 20);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(100, 20);
            this.lblTheme.TabIndex = 24;
            this.lblTheme.Text = "Темы (века)";
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(200, 20);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(150, 20);
            this.lblLevel.TabIndex = 23;
            this.lblLevel.Text = "Уровни сложности";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(360, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(100, 20);
            this.lblQuestion.TabIndex = 22;
            this.lblQuestion.Text = "Вопросы";
            // 
            // txtInvention
            // 
            this.txtInvention.Location = new System.Drawing.Point(120, 207);
            this.txtInvention.Name = "txtInvention";
            this.txtInvention.Size = new System.Drawing.Size(300, 22);
            this.txtInvention.TabIndex = 20;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(160, 237);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(350, 22);
            this.txtImagePath.TabIndex = 18;
            // 
            // txtHint
            // 
            this.txtHint.Location = new System.Drawing.Point(120, 267);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(480, 22);
            this.txtHint.TabIndex = 14;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(120, 330);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(350, 22);
            this.txtAnswer1.TabIndex = 12;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(120, 360);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(350, 22);
            this.txtAnswer2.TabIndex = 11;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(120, 390);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(350, 22);
            this.txtAnswer3.TabIndex = 10;
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Location = new System.Drawing.Point(120, 420);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(350, 22);
            this.txtAnswer4.TabIndex = 9;
            // 
            // chkCorrect1
            // 
            this.chkCorrect1.Location = new System.Drawing.Point(480, 332);
            this.chkCorrect1.Name = "chkCorrect1";
            this.chkCorrect1.Size = new System.Drawing.Size(100, 20);
            this.chkCorrect1.TabIndex = 8;
            this.chkCorrect1.Text = "Правильный";
            // 
            // chkCorrect2
            // 
            this.chkCorrect2.Location = new System.Drawing.Point(480, 362);
            this.chkCorrect2.Name = "chkCorrect2";
            this.chkCorrect2.Size = new System.Drawing.Size(100, 20);
            this.chkCorrect2.TabIndex = 7;
            this.chkCorrect2.Text = "Правильный";
            // 
            // chkCorrect3
            // 
            this.chkCorrect3.Location = new System.Drawing.Point(480, 392);
            this.chkCorrect3.Name = "chkCorrect3";
            this.chkCorrect3.Size = new System.Drawing.Size(100, 20);
            this.chkCorrect3.TabIndex = 6;
            this.chkCorrect3.Text = "Правильный";
            // 
            // chkCorrect4
            // 
            this.chkCorrect4.Location = new System.Drawing.Point(480, 422);
            this.chkCorrect4.Name = "chkCorrect4";
            this.chkCorrect4.Size = new System.Drawing.Size(100, 20);
            this.chkCorrect4.TabIndex = 5;
            this.chkCorrect4.Text = "Правильный";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(230, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(520, 236);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(80, 25);
            this.btnBrowseImage.TabIndex = 17;
            this.btnBrowseImage.Text = "Обзор...";
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnCreateTheme
            // 
            this.btnCreateTheme.Location = new System.Drawing.Point(620, 210);
            this.btnCreateTheme.Name = "btnCreateTheme";
            this.btnCreateTheme.Size = new System.Drawing.Size(150, 30);
            this.btnCreateTheme.TabIndex = 1;
            this.btnCreateTheme.Text = "Создать тему";
            this.btnCreateTheme.Click += new System.EventHandler(this.btnCreateTheme_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(620, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // lblInvention
            // 
            this.lblInvention.Location = new System.Drawing.Point(12, 210);
            this.lblInvention.Name = "lblInvention";
            this.lblInvention.Size = new System.Drawing.Size(100, 20);
            this.lblInvention.TabIndex = 21;
            this.lblInvention.Text = "Изобретение:";
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(12, 240);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(150, 20);
            this.lblImage.TabIndex = 19;
            this.lblImage.Text = "Путь к изображению:";
            // 
            // lblHint
            // 
            this.lblHint.Location = new System.Drawing.Point(12, 270);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(100, 20);
            this.lblHint.TabIndex = 15;
            this.lblHint.Text = "Подсказка:";
            // 
            // lblAnswers
            // 
            this.lblAnswers.Location = new System.Drawing.Point(12, 300);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(150, 20);
            this.lblAnswers.TabIndex = 13;
            this.lblAnswers.Text = "Варианты ответов:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateTheme);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkCorrect4);
            this.Controls.Add(this.chkCorrect3);
            this.Controls.Add(this.chkCorrect2);
            this.Controls.Add(this.chkCorrect1);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtInvention);
            this.Controls.Add(this.lblInvention);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.lstLevels);
            this.Controls.Add(this.lstThemes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}