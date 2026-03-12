namespace Practice_Task_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblFunctionValue;
        private System.Windows.Forms.Label lblSeriesSum;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label lblFuncValCaption;
        private System.Windows.Forms.Label lblSumCaption;
        private System.Windows.Forms.Label lblIterCaption;
        private System.Windows.Forms.Label lblDiffCaption;
        private System.Windows.Forms.Button btnTestException;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblX = new Label();
            txtX = new TextBox();
            lblEps = new Label();
            txtEps = new TextBox();
            btnCalculate = new Button();
            grpResults = new GroupBox();
            lblDifference = new Label();
            lblDiffCaption = new Label();
            lblIterations = new Label();
            lblIterCaption = new Label();
            lblSeriesSum = new Label();
            lblSumCaption = new Label();
            lblFunctionValue = new Label();
            lblFuncValCaption = new Label();
            btnTestException = new Button();
            pictureBox1 = new PictureBox();
            grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Enabled = false;
            lblX.Location = new Point(531, 141);
            lblX.Margin = new Padding(4, 0, 4, 0);
            lblX.Name = "lblX";
            lblX.Size = new Size(21, 20);
            lblX.TabIndex = 6;
            lblX.Text = "X:";
            lblX.Click += lblX_Click;
            // 
            // txtX
            // 
            txtX.Location = new Point(570, 138);
            txtX.Margin = new Padding(4, 5, 4, 5);
            txtX.Name = "txtX";
            txtX.Size = new Size(199, 27);
            txtX.TabIndex = 5;
            txtX.TextChanged += txtX_TextChanged;
            txtX.KeyPress += txtX_KeyPress;
            // 
            // lblEps
            // 
            lblEps.AutoSize = true;
            lblEps.Enabled = false;
            lblEps.Location = new Point(18, 142);
            lblEps.Margin = new Padding(4, 0, 4, 0);
            lblEps.Name = "lblEps";
            lblEps.Size = new Size(35, 20);
            lblEps.TabIndex = 4;
            lblEps.Text = "Eps:";
            // 
            // txtEps
            // 
            txtEps.Location = new Point(69, 138);
            txtEps.Margin = new Padding(4, 5, 4, 5);
            txtEps.Name = "txtEps";
            txtEps.Size = new Size(199, 27);
            txtEps.TabIndex = 3;
            txtEps.TextChanged += txtEps_TextChanged;
            txtEps.KeyPress += txtEps_KeyPress;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(298, 184);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 46);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblDifference);
            grpResults.Controls.Add(lblDiffCaption);
            grpResults.Controls.Add(lblIterations);
            grpResults.Controls.Add(lblIterCaption);
            grpResults.Controls.Add(lblSeriesSum);
            grpResults.Controls.Add(lblSumCaption);
            grpResults.Controls.Add(lblFunctionValue);
            grpResults.Controls.Add(lblFuncValCaption);
            grpResults.Location = new Point(20, 274);
            grpResults.Margin = new Padding(4, 5, 4, 5);
            grpResults.Name = "grpResults";
            grpResults.Padding = new Padding(4, 5, 4, 5);
            grpResults.Size = new Size(737, 203);
            grpResults.TabIndex = 1;
            grpResults.TabStop = false;
            grpResults.Text = "Результаты";
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Enabled = false;
            lblDifference.Location = new Point(200, 177);
            lblDifference.Margin = new Padding(4, 0, 4, 0);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(0, 20);
            lblDifference.TabIndex = 0;
            // 
            // lblDiffCaption
            // 
            lblDiffCaption.AutoSize = true;
            lblDiffCaption.Enabled = false;
            lblDiffCaption.Location = new Point(13, 177);
            lblDiffCaption.Margin = new Padding(4, 0, 4, 0);
            lblDiffCaption.Name = "lblDiffCaption";
            lblDiffCaption.Size = new Size(74, 20);
            lblDiffCaption.TabIndex = 1;
            lblDiffCaption.Text = "Разность:";
            // 
            // lblIterations
            // 
            lblIterations.AutoSize = true;
            lblIterations.Enabled = false;
            lblIterations.Location = new Point(200, 131);
            lblIterations.Margin = new Padding(4, 0, 4, 0);
            lblIterations.Name = "lblIterations";
            lblIterations.Size = new Size(0, 20);
            lblIterations.TabIndex = 2;
            // 
            // lblIterCaption
            // 
            lblIterCaption.AutoSize = true;
            lblIterCaption.Enabled = false;
            lblIterCaption.Location = new Point(13, 131);
            lblIterCaption.Margin = new Padding(4, 0, 4, 0);
            lblIterCaption.Name = "lblIterCaption";
            lblIterCaption.Size = new Size(164, 20);
            lblIterCaption.TabIndex = 3;
            lblIterCaption.Text = "Количество итераций:";
            // 
            // lblSeriesSum
            // 
            lblSeriesSum.AutoSize = true;
            lblSeriesSum.Enabled = false;
            lblSeriesSum.Location = new Point(200, 85);
            lblSeriesSum.Margin = new Padding(4, 0, 4, 0);
            lblSeriesSum.Name = "lblSeriesSum";
            lblSeriesSum.Size = new Size(0, 20);
            lblSeriesSum.TabIndex = 4;
            // 
            // lblSumCaption
            // 
            lblSumCaption.AutoSize = true;
            lblSumCaption.Enabled = false;
            lblSumCaption.Location = new Point(13, 85);
            lblSumCaption.Margin = new Padding(4, 0, 4, 0);
            lblSumCaption.Name = "lblSumCaption";
            lblSumCaption.Size = new Size(200, 20);
            lblSumCaption.TabIndex = 5;
            lblSumCaption.Text = "Сумма ряда (правая часть):";
            // 
            // lblFunctionValue
            // 
            lblFunctionValue.AutoSize = true;
            lblFunctionValue.Enabled = false;
            lblFunctionValue.Location = new Point(200, 38);
            lblFunctionValue.Margin = new Padding(4, 0, 4, 0);
            lblFunctionValue.Name = "lblFunctionValue";
            lblFunctionValue.Size = new Size(0, 20);
            lblFunctionValue.TabIndex = 6;
            // 
            // lblFuncValCaption
            // 
            lblFuncValCaption.AutoSize = true;
            lblFuncValCaption.Enabled = false;
            lblFuncValCaption.Location = new Point(13, 38);
            lblFuncValCaption.Margin = new Padding(4, 0, 4, 0);
            lblFuncValCaption.Name = "lblFuncValCaption";
            lblFuncValCaption.Size = new Size(192, 20);
            lblFuncValCaption.TabIndex = 7;
            lblFuncValCaption.Text = "Math.Atan(x) (левая часть):";
            // 
            // btnTestException
            // 
            btnTestException.Location = new Point(298, 487);
            btnTestException.Margin = new Padding(4, 5, 4, 5);
            btnTestException.Name = "btnTestException";
            btnTestException.Size = new Size(200, 46);
            btnTestException.TabIndex = 0;
            btnTestException.Text = "Тест исключения";
            btnTestException.UseVisualStyleBackColor = true;
            btnTestException.Click += btnTestException_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(688, 100);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 569);
            Controls.Add(pictureBox1);
            Controls.Add(btnTestException);
            Controls.Add(grpResults);
            Controls.Add(btnCalculate);
            Controls.Add(txtEps);
            Controls.Add(lblEps);
            Controls.Add(txtX);
            Controls.Add(lblX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вычисление arctg(x) через ряд (Вариант 13)";
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            #endregion
        }
        private PictureBox pictureBox1;
    }
}

