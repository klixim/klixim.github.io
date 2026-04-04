namespace PracticeTask8
{
    partial class EditWordForm
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblSynonyms = new System.Windows.Forms.Label();
            this.txtSynonyms = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWord.Location = new System.Drawing.Point(30, 30);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(100, 25);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Слово:";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.LightGray;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtWord.Location = new System.Drawing.Point(140, 28);
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(300, 26);
            this.txtWord.TabIndex = 1;
            // 
            // lblSynonyms
            // 
            this.lblSynonyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSynonyms.Location = new System.Drawing.Point(30, 80);
            this.lblSynonyms.Name = "lblSynonyms";
            this.lblSynonyms.Size = new System.Drawing.Size(180, 25);
            this.lblSynonyms.TabIndex = 2;
            this.lblSynonyms.Text = "Синонимы (через запятую):";
            // 
            // txtSynonyms
            // 
            this.txtSynonyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSynonyms.Location = new System.Drawing.Point(30, 110);
            this.txtSynonyms.Multiline = true;
            this.txtSynonyms.Name = "txtSynonyms";
            this.txtSynonyms.Size = new System.Drawing.Size(420, 80);
            this.txtSynonyms.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategory.Location = new System.Drawing.Point(30, 210);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 25);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Категория:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCategory.Location = new System.Drawing.Point(140, 208);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(300, 26);
            this.txtCategory.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(120, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(260, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // EditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtSynonyms);
            this.Controls.Add(this.lblSynonyms);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование слова";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblSynonyms;
        private System.Windows.Forms.TextBox txtSynonyms;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}