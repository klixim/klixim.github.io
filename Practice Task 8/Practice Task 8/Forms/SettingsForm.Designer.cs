namespace PracticeTask8
{
    partial class SettingsForm
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
            this.numQuestions = new System.Windows.Forms.NumericUpDown();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.lblColorPreview = new System.Windows.Forms.Label();
            this.chkShowAnimation = new System.Windows.Forms.CheckBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // numQuestions
            // 
            this.numQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numQuestions.Location = new System.Drawing.Point(250, 28);
            this.numQuestions.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQuestions.Name = "numQuestions";
            this.numQuestions.Size = new System.Drawing.Size(80, 26);
            this.numQuestions.TabIndex = 0;
            this.numQuestions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbTheme
            // 
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTheme.Items.AddRange(new object[] {
            "Стандартная",
            "Прилагательные",
            "Глаголы",
            "Существительные"});
            this.cmbTheme.Location = new System.Drawing.Point(250, 68);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(150, 28);
            this.cmbTheme.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(100, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(230, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(310, 146);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(90, 30);
            this.btnColorPicker.TabIndex = 4;
            this.btnColorPicker.Text = "Выбрать цвет";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // lblColorPreview
            // 
            this.lblColorPreview.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorPreview.Location = new System.Drawing.Point(250, 148);
            this.lblColorPreview.Name = "lblColorPreview";
            this.lblColorPreview.Size = new System.Drawing.Size(50, 25);
            this.lblColorPreview.TabIndex = 5;
            this.lblColorPreview.Text = "     ";
            // 
            // chkShowAnimation
            // 
            this.chkShowAnimation.Checked = true;
            this.chkShowAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkShowAnimation.Location = new System.Drawing.Point(30, 110);
            this.chkShowAnimation.Name = "chkShowAnimation";
            this.chkShowAnimation.Size = new System.Drawing.Size(250, 25);
            this.chkShowAnimation.TabIndex = 6;
            this.chkShowAnimation.Text = "Показывать анимацию при ответах";
            this.chkShowAnimation.UseVisualStyleBackColor = true;
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestions.Location = new System.Drawing.Point(30, 30);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(200, 25);
            this.lblQuestions.TabIndex = 7;
            this.lblQuestions.Text = "Количество вопросов в игре:";
            // 
            // lblTheme
            // 
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTheme.Location = new System.Drawing.Point(30, 70);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(200, 25);
            this.lblTheme.TabIndex = 8;
            this.lblTheme.Text = "Тематика слов:";
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblColor.Location = new System.Drawing.Point(30, 150);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(150, 25);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Цвет интерфейса:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.chkShowAnimation);
            this.Controls.Add(this.lblColorPreview);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.numQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки игры";
            ((System.ComponentModel.ISupportInitialize)(this.numQuestions)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numQuestions;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Label lblColorPreview;
        private System.Windows.Forms.CheckBox chkShowAnimation;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblColor;
    }
}