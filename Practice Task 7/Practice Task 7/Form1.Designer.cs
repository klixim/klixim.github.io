namespace Practice_Task_7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equilateralTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isoscelesTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapezoidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalDistributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalDistributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strokeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strokeWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashStyleToolStripMenuItem;

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addEquilateralTriangleBtn;
        private System.Windows.Forms.ToolStripButton addRightTriangleBtn;
        private System.Windows.Forms.ToolStripButton addIsoscelesTriangleBtn;
        private System.Windows.Forms.ToolStripButton addTrapezoidBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton strokeColorButton;
        private System.Windows.Forms.ToolStripTextBox txtStrokeWidth;
        private System.Windows.Forms.ToolStripComboBox cmbDashStyle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

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
            this.canvas = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equilateralTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isoscelesTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapezoidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalDistributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalDistributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strokeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strokeWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addEquilateralTriangleBtn = new System.Windows.Forms.ToolStripButton();
            this.addRightTriangleBtn = new System.Windows.Forms.ToolStripButton();
            this.addIsoscelesTriangleBtn = new System.Windows.Forms.ToolStripButton();
            this.addTrapezoidBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.strokeColorButton = new System.Windows.Forms.ToolStripButton();
            this.txtStrokeWidth = new System.Windows.Forms.ToolStripTextBox();
            this.cmbDashStyle = new System.Windows.Forms.ToolStripComboBox();

            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();

            this.SuspendLayout();

            // canvas
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 56);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(984, 561);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileToolStripMenuItem,
                this.editToolStripMenuItem,
                this.figuresToolStripMenuItem,
                this.alignToolStripMenuItem,
                this.strokeColorToolStripMenuItem,
                this.strokeWidthToolStripMenuItem,
                this.dashStyleToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 1;

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.saveToolStripMenuItem,
                this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Text = "Файл";

            // saveToolStripMenuItem
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);

            // loadToolStripMenuItem
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);

            // editToolStripMenuItem
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.undoToolStripMenuItem,
                this.redoToolStripMenuItem,
                this.toolStripSeparator5,
                this.copyToolStripMenuItem,
                this.cutToolStripMenuItem,
                this.pasteToolStripMenuItem,
                this.toolStripSeparator6,
                this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Text = "Правка";

            // undoToolStripMenuItem
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undo_Click);

            // redoToolStripMenuItem
            this.redoToolStripMenuItem.Text = "Повторить";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redo_Click);

            // copyToolStripMenuItem
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copy_Click);

            // cutToolStripMenuItem
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cut_Click);

            // pasteToolStripMenuItem
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.paste_Click);

            // deleteToolStripMenuItem
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteFigure_Click);

            // figuresToolStripMenuItem
            this.figuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.equilateralTriangleToolStripMenuItem,
                this.rightTriangleToolStripMenuItem,
                this.isoscelesTriangleToolStripMenuItem,
                this.trapezoidToolStripMenuItem});
            this.figuresToolStripMenuItem.Text = "Фигуры";

            // equilateralTriangleToolStripMenuItem
            this.equilateralTriangleToolStripMenuItem.Text = "Равносторонний треугольник";
            this.equilateralTriangleToolStripMenuItem.Click += new System.EventHandler(this.addEquilateralTriangle_Click);

            // rightTriangleToolStripMenuItem
            this.rightTriangleToolStripMenuItem.Text = "Прямоугольный треугольник";
            this.rightTriangleToolStripMenuItem.Click += new System.EventHandler(this.addRightTriangle_Click);

            // isoscelesTriangleToolStripMenuItem
            this.isoscelesTriangleToolStripMenuItem.Text = "Равнобедренный треугольник";
            this.isoscelesTriangleToolStripMenuItem.Click += new System.EventHandler(this.addIsoscelesTriangle_Click);

            // trapezoidToolStripMenuItem
            this.trapezoidToolStripMenuItem.Text = "Равнобедренная трапеция";
            this.trapezoidToolStripMenuItem.Click += new System.EventHandler(this.addTrapezoid_Click);

            // alignToolStripMenuItem
            this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.verticalDistributeToolStripMenuItem,
                this.horizontalDistributeToolStripMenuItem});
            this.alignToolStripMenuItem.Text = "Выравнивание";

            // verticalDistributeToolStripMenuItem
            this.verticalDistributeToolStripMenuItem.Text = "Выровнять расстояние по вертикали";
            this.verticalDistributeToolStripMenuItem.Click += new System.EventHandler(this.alignVerticalDistribute_Click);

            // horizontalDistributeToolStripMenuItem
            this.horizontalDistributeToolStripMenuItem.Text = "Выровнять расстояние по горизонтали";
            this.horizontalDistributeToolStripMenuItem.Click += new System.EventHandler(this.alignHorizontalDistribute_Click);

            // strokeColorToolStripMenuItem
            this.strokeColorToolStripMenuItem.Text = "Цвет контура";
            this.strokeColorToolStripMenuItem.Click += new System.EventHandler(this.changeStrokeColor_Click);

            // strokeWidthToolStripMenuItem
            this.strokeWidthToolStripMenuItem.Text = "Толщина контура";

            // dashStyleToolStripMenuItem
            this.dashStyleToolStripMenuItem.Text = "Стиль линии";

            // toolStrip
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.addEquilateralTriangleBtn,
                this.addRightTriangleBtn,
                this.addIsoscelesTriangleBtn,
                this.addTrapezoidBtn,
                this.toolStripSeparator1,
                this.deleteButton,
                this.toolStripSeparator2,
                this.undoButton,
                this.redoButton,
                this.toolStripSeparator3,
                this.copyButton,
                this.cutButton,
                this.pasteButton,
                this.toolStripSeparator4,
                this.strokeColorButton,
                this.txtStrokeWidth,
                this.cmbDashStyle});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(984, 32);
            this.toolStrip.TabIndex = 2;

            // addEquilateralTriangleBtn
            this.addEquilateralTriangleBtn.Text = "△ Равностор.";
            this.addEquilateralTriangleBtn.Click += new System.EventHandler(this.addEquilateralTriangle_Click);

            // addRightTriangleBtn
            this.addRightTriangleBtn.Text = "⊿ Прямоуг.";
            this.addRightTriangleBtn.Click += new System.EventHandler(this.addRightTriangle_Click);

            // addIsoscelesTriangleBtn
            this.addIsoscelesTriangleBtn.Text = "▲ Равнобедр.";
            this.addIsoscelesTriangleBtn.Click += new System.EventHandler(this.addIsoscelesTriangle_Click);

            // addTrapezoidBtn
            this.addTrapezoidBtn.Text = "⏢ Трапеция";
            this.addTrapezoidBtn.Click += new System.EventHandler(this.addTrapezoid_Click);

            // deleteButton
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteFigure_Click);

            // undoButton
            this.undoButton.Text = "Отменить";
            this.undoButton.Click += new System.EventHandler(this.undo_Click);

            // redoButton
            this.redoButton.Text = "Повторить";
            this.redoButton.Click += new System.EventHandler(this.redo_Click);

            // copyButton
            this.copyButton.Text = "Копировать";
            this.copyButton.Click += new System.EventHandler(this.copy_Click);

            // cutButton
            this.cutButton.Text = "Вырезать";
            this.cutButton.Click += new System.EventHandler(this.cut_Click);

            // pasteButton
            this.pasteButton.Text = "Вставить";
            this.pasteButton.Click += new System.EventHandler(this.paste_Click);

            // strokeColorButton
            this.strokeColorButton.Text = "Цвет";
            this.strokeColorButton.Click += new System.EventHandler(this.changeStrokeColor_Click);

            // txtStrokeWidth
            this.txtStrokeWidth.Size = new System.Drawing.Size(50, 28);
            this.txtStrokeWidth.Text = "2";
            this.txtStrokeWidth.Leave += new System.EventHandler(this.changeStrokeWidth_Click);

            // cmbDashStyle
            this.cmbDashStyle.Items.AddRange(new object[] {
                "Сплошная",
                "Пунктирная",
                "Точечная"});
            this.cmbDashStyle.Size = new System.Drawing.Size(100, 28);
            this.cmbDashStyle.SelectedIndex = 0;
            this.cmbDashStyle.SelectedIndexChanged += new System.EventHandler(this.changeDashStyle_Click);

            // saveFileDialog
            this.saveFileDialog.Filter = "Vector Editor Files (*.vec)|*.vec|All Files (*.*)|*.*";
            this.saveFileDialog.DefaultExt = "vec";

            // openFileDialog
            this.openFileDialog.Filter = "Vector Editor Files (*.vec)|*.vec|All Files (*.*)|*.*";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 617);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Векторный редактор - Вариант 13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}