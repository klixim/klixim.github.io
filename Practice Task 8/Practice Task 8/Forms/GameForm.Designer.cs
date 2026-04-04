namespace PracticeTask8
{
    partial class GameForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionLabel.Location = new System.Drawing.Point(30, 30);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(300, 30);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Подберите синоним к слову:";
            // 
            // wordLabel
            // 
            this.wordLabel.BackColor = System.Drawing.Color.LightYellow;
            this.wordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.wordLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.wordLabel.Location = new System.Drawing.Point(30, 70);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(300, 40);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.answerTextBox.Location = new System.Drawing.Point(30, 130);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(300, 28);
            this.answerTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightGreen;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitButton.Location = new System.Drawing.Point(30, 170);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(140, 40);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Проверить";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.LightBlue;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextButton.Location = new System.Drawing.Point(190, 170);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(140, 40);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Следующее слово";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scoreLabel.Location = new System.Drawing.Point(30, 230);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(200, 25);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Правильно: 0/0";
            // 
            // progressLabel
            // 
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.progressLabel.Location = new System.Drawing.Point(30, 260);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(200, 25);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "Вопрос: 0/10";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(370, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра - Подбери синоним";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}