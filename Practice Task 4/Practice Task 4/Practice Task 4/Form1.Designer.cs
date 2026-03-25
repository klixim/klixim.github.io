namespace Practice_Task_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.panelInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.txtDiscipline = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblFive = new System.Windows.Forms.Label();
            this.txtFive = new System.Windows.Forms.TextBox();
            this.lblFour = new System.Windows.Forms.Label();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.lblThree = new System.Windows.Forms.Label();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.lblTwo = new System.Windows.Forms.Label();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.lblNotAtt = new System.Windows.Forms.Label();
            this.txtNotAtt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNotAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTableButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFindBest = new System.Windows.Forms.Button();
            this.lblBestResult = new System.Windows.Forms.Label();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.chartPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSelectDiscipline = new System.Windows.Forms.Label();
            this.cmbDisciplineForChart = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.tabTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelTableButtons.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.chartPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInput);
            this.tabControl.Controls.Add(this.tabTable);
            this.tabControl.Controls.Add(this.tabChart);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 600);
            this.tabControl.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.panelInput);
            this.tabInput.Location = new System.Drawing.Point(4, 29);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(892, 567);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Ввод данных";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // panelInput
            // 
            this.panelInput.ColumnCount = 2;
            this.panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelInput.Controls.Add(this.lblDiscipline, 0, 0);
            this.panelInput.Controls.Add(this.txtDiscipline, 1, 0);
            this.panelInput.Controls.Add(this.lblGroup, 0, 1);
            this.panelInput.Controls.Add(this.txtGroup, 1, 1);
            this.panelInput.Controls.Add(this.lblFive, 0, 2);
            this.panelInput.Controls.Add(this.txtFive, 1, 2);
            this.panelInput.Controls.Add(this.lblFour, 0, 3);
            this.panelInput.Controls.Add(this.txtFour, 1, 3);
            this.panelInput.Controls.Add(this.lblThree, 0, 4);
            this.panelInput.Controls.Add(this.txtThree, 1, 4);
            this.panelInput.Controls.Add(this.lblTwo, 0, 5);
            this.panelInput.Controls.Add(this.txtTwo, 1, 5);
            this.panelInput.Controls.Add(this.lblNotAtt, 0, 6);
            this.panelInput.Controls.Add(this.txtNotAtt, 1, 6);
            this.panelInput.Controls.Add(this.btnAdd, 1, 7);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelInput.RowCount = 9;
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelInput.Size = new System.Drawing.Size(886, 561);
            this.panelInput.TabIndex = 0;
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(13, 10);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(158, 20);
            this.lblDiscipline.TabIndex = 0;
            this.lblDiscipline.Text = "Название дисциплины:";
            // 
            // txtDiscipline
            // 
            this.txtDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscipline.Location = new System.Drawing.Point(278, 13);
            this.txtDiscipline.Name = "txtDiscipline";
            this.txtDiscipline.Size = new System.Drawing.Size(595, 26);
            this.txtDiscipline.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(13, 45);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(118, 20);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Номер группы:";
            // 
            // txtGroup
            // 
            this.txtGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroup.Location = new System.Drawing.Point(278, 48);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(595, 26);
            this.txtGroup.TabIndex = 3;
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.Location = new System.Drawing.Point(13, 80);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(99, 20);
            this.lblFive.TabIndex = 4;
            this.lblFive.Text = "Кол-во \"5\":";
            // 
            // txtFive
            // 
            this.txtFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFive.Location = new System.Drawing.Point(278, 83);
            this.txtFive.Name = "txtFive";
            this.txtFive.Size = new System.Drawing.Size(595, 26);
            this.txtFive.TabIndex = 5;
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Location = new System.Drawing.Point(13, 115);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(99, 20);
            this.lblFour.TabIndex = 6;
            this.lblFour.Text = "Кол-во \"4\":";
            // 
            // txtFour
            // 
            this.txtFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFour.Location = new System.Drawing.Point(278, 118);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(595, 26);
            this.txtFour.TabIndex = 7;
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Location = new System.Drawing.Point(13, 150);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(99, 20);
            this.lblThree.TabIndex = 8;
            this.lblThree.Text = "Кол-во \"3\":";
            // 
            // txtThree
            // 
            this.txtThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThree.Location = new System.Drawing.Point(278, 153);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(595, 26);
            this.txtThree.TabIndex = 9;
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(13, 185);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(99, 20);
            this.lblTwo.TabIndex = 10;
            this.lblTwo.Text = "Кол-во \"2\":";
            // 
            // txtTwo
            // 
            this.txtTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTwo.Location = new System.Drawing.Point(278, 188);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(595, 26);
            this.txtTwo.TabIndex = 11;
            // 
            // lblNotAtt
            // 
            this.lblNotAtt.AutoSize = true;
            this.lblNotAtt.Location = new System.Drawing.Point(13, 220);
            this.lblNotAtt.Name = "lblNotAtt";
            this.lblNotAtt.Size = new System.Drawing.Size(127, 20);
            this.lblNotAtt.TabIndex = 12;
            this.lblNotAtt.Text = "Не аттестовано:";
            // 
            // txtNotAtt
            // 
            this.txtNotAtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotAtt.Location = new System.Drawing.Point(278, 223);
            this.txtNotAtt.Name = "txtNotAtt";
            this.txtNotAtt.Size = new System.Drawing.Size(595, 26);
            this.txtNotAtt.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(278, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(595, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить группу";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.dataGridView);
            this.tabTable.Controls.Add(this.panelTableButtons);
            this.tabTable.Location = new System.Drawing.Point(4, 29);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(892, 567);
            this.tabTable.TabIndex = 1;
            this.tabTable.Text = "Таблица данных";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGroup,
            this.ColFive,
            this.ColFour,
            this.ColThree,
            this.ColTwo,
            this.ColNotAtt,
            this.ColAvg});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(886, 521);
            this.dataGridView.TabIndex = 0;
            // 
            // ColGroup
            // 
            this.ColGroup.HeaderText = "Группа";
            this.ColGroup.MinimumWidth = 8;
            this.ColGroup.Name = "ColGroup";
            this.ColGroup.Width = 120;
            // 
            // ColFive
            // 
            this.ColFive.HeaderText = "5";
            this.ColFive.MinimumWidth = 8;
            this.ColFive.Name = "ColFive";
            this.ColFive.Width = 80;
            // 
            // ColFour
            // 
            this.ColFour.HeaderText = "4";
            this.ColFour.MinimumWidth = 8;
            this.ColFour.Name = "ColFour";
            this.ColFour.Width = 80;
            // 
            // ColThree
            // 
            this.ColThree.HeaderText = "3";
            this.ColThree.MinimumWidth = 8;
            this.ColThree.Name = "ColThree";
            this.ColThree.Width = 80;
            // 
            // ColTwo
            // 
            this.ColTwo.HeaderText = "2";
            this.ColTwo.MinimumWidth = 8;
            this.ColTwo.Name = "ColTwo";
            this.ColTwo.Width = 80;
            // 
            // ColNotAtt
            // 
            this.ColNotAtt.HeaderText = "Не атт.";
            this.ColNotAtt.MinimumWidth = 8;
            this.ColNotAtt.Name = "ColNotAtt";
            this.ColNotAtt.Width = 80;
            // 
            // ColAvg
            // 
            this.ColAvg.HeaderText = "Ср. балл";
            this.ColAvg.MinimumWidth = 8;
            this.ColAvg.Name = "ColAvg";
            this.ColAvg.Width = 120;
            // 
            // panelTableButtons
            // 
            this.panelTableButtons.Controls.Add(this.btnSave);
            this.panelTableButtons.Controls.Add(this.btnLoad);
            this.panelTableButtons.Controls.Add(this.btnFindBest);
            this.panelTableButtons.Controls.Add(this.lblBestResult);
            this.panelTableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTableButtons.Location = new System.Drawing.Point(3, 524);
            this.panelTableButtons.Name = "panelTableButtons";
            this.panelTableButtons.Size = new System.Drawing.Size(886, 40);
            this.panelTableButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить в файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(159, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить из файла";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnFindBest
            // 
            this.btnFindBest.Location = new System.Drawing.Point(315, 3);
            this.btnFindBest.Name = "btnFindBest";
            this.btnFindBest.Size = new System.Drawing.Size(150, 34);
            this.btnFindBest.TabIndex = 2;
            this.btnFindBest.Text = "Найти лучшую группу";
            this.btnFindBest.UseVisualStyleBackColor = true;
            this.btnFindBest.Click += new System.EventHandler(this.BtnFindBest_Click);
            // 
            // lblBestResult
            // 
            this.lblBestResult.AutoSize = true;
            this.lblBestResult.Location = new System.Drawing.Point(471, 3);
            this.lblBestResult.Name = "lblBestResult";
            this.lblBestResult.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblBestResult.Size = new System.Drawing.Size(10, 20);
            this.lblBestResult.TabIndex = 3;
            this.lblBestResult.Text = " ";
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.chartPanel);
            this.tabChart.Location = new System.Drawing.Point(4, 29);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(892, 567);
            this.tabChart.TabIndex = 2;
            this.tabChart.Text = "Диаграмма успеваемости";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // chartPanel
            // 
            this.chartPanel.ColumnCount = 1;
            this.chartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartPanel.Controls.Add(this.topPanel, 0, 0);
            this.chartPanel.Controls.Add(this.chart, 0, 1);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(3, 3);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.RowCount = 2;
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartPanel.Size = new System.Drawing.Size(886, 561);
            this.chartPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblSelectDiscipline);
            this.topPanel.Controls.Add(this.cmbDisciplineForChart);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(880, 34);
            this.topPanel.TabIndex = 0;
            // 
            // lblSelectDiscipline
            // 
            this.lblSelectDiscipline.AutoSize = true;
            this.lblSelectDiscipline.Location = new System.Drawing.Point(3, 0);
            this.lblSelectDiscipline.Name = "lblSelectDiscipline";
            this.lblSelectDiscipline.Size = new System.Drawing.Size(171, 20);
            this.lblSelectDiscipline.TabIndex = 0;
            this.lblSelectDiscipline.Text = "Выберите дисциплину:";
            // 
            // cmbDisciplineForChart
            // 
            this.cmbDisciplineForChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplineForChart.FormattingEnabled = true;
            this.cmbDisciplineForChart.Location = new System.Drawing.Point(180, 3);
            this.cmbDisciplineForChart.Name = "cmbDisciplineForChart";
            this.cmbDisciplineForChart.Size = new System.Drawing.Size(200, 28);
            this.cmbDisciplineForChart.TabIndex = 1;
            this.cmbDisciplineForChart.SelectedIndexChanged += new System.EventHandler(this.CmbDisciplineForChart_SelectedIndexChanged);
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(3, 43);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(880, 515);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Успеваемость студентов (Вариант 13)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.tabTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelTableButtons.ResumeLayout(false);
            this.panelTableButtons.PerformLayout();
            this.tabChart.ResumeLayout(false);
            this.chartPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.TableLayoutPanel panelInput;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.TextBox txtDiscipline;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.TextBox txtFive;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Label lblNotAtt;
        private System.Windows.Forms.TextBox txtNotAtt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel panelTableButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnFindBest;
        private System.Windows.Forms.Label lblBestResult;
        private System.Windows.Forms.TableLayoutPanel chartPanel;
        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.Label lblSelectDiscipline;
        private System.Windows.Forms.ComboBox cmbDisciplineForChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNotAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvg;
    }
}