namespace Practice_Task_6.Forms
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestionCounter;
        private System.Windows.Forms.Label lblHint;

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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // lblQuestion
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(12, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(760, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pictureBox
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 90);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 200);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;

            // radioButton1
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(330, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(440, 30);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Вариант 1";

            // radioButton2
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton2.Location = new System.Drawing.Point(330, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(440, 30);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Вариант 2";

            // radioButton3
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton3.Location = new System.Drawing.Point(330, 180);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(440, 30);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Вариант 3";

            // radioButton4
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton4.Location = new System.Drawing.Point(330, 220);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(440, 30);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Вариант 4";

            // btnAnswer
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnswer.Location = new System.Drawing.Point(330, 270);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(150, 40);
            this.btnAnswer.TabIndex = 6;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);

            // btnHint
            this.btnHint.Location = new System.Drawing.Point(500, 270);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(120, 40);
            this.btnHint.TabIndex = 7;
            this.btnHint.Text = "Подсказка";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(640, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выйти в меню";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // lblScore
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(12, 300);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(150, 30);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Счёт: 0";

            // lblTimer
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(180, 300);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(150, 30);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Время: 30 сек";

            // lblQuestionCounter
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionCounter.Location = new System.Drawing.Point(640, 20);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(120, 30);
            this.lblQuestionCounter.TabIndex = 11;
            this.lblQuestionCounter.Text = "Вопрос 1 из 5";
            this.lblQuestionCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblHint
            this.lblHint.BackColor = System.Drawing.Color.LightYellow;
            this.lblHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHint.Location = new System.Drawing.Point(12, 340);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(760, 50);
            this.lblHint.TabIndex = 12;
            this.lblHint.Text = "Подсказка";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHint.Visible = false;

            // GameForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Викторина";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}