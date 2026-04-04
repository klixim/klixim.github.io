namespace PracticeTask8
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.resultsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.settingsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(600, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameMenuItem,
            this.resultsMenuItem,
            this.adminMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(59, 24);
            this.fileMenu.Text = "Файл";
            // 
            // startGameMenuItem
            // 
            this.startGameMenuItem.Name = "startGameMenuItem";
            this.startGameMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startGameMenuItem.Text = "Начать игру";
            this.startGameMenuItem.Click += new System.EventHandler(this.startGameMenuItem_Click);
            // 
            // resultsMenuItem
            // 
            this.resultsMenuItem.Name = "resultsMenuItem";
            this.resultsMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resultsMenuItem.Text = "Мои результаты";
            this.resultsMenuItem.Click += new System.EventHandler(this.resultsMenuItem_Click);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminMenuItem.Text = "Администрирование";
            this.adminMenuItem.Click += new System.EventHandler(this.adminMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(99, 24);
            this.settingsMenu.Text = "Настройки";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(210, 26);
            this.settingsMenuItem.Text = "Параметры игры";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(79, 24);
            this.helpMenu.Text = "Справка";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(187, 26);
            this.aboutMenuItem.Text = "О программе";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.Controls.Add(this.settingsButton);
            this.mainPanel.Controls.Add(this.resultsButton);
            this.mainPanel.Controls.Add(this.adminButton);
            this.mainPanel.Controls.Add(this.startButton);
            this.mainPanel.Controls.Add(this.userLabel);
            this.mainPanel.Controls.Add(this.welcomeLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 472);
            this.mainPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(400, 140);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.LightGray;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settingsButton.Location = new System.Drawing.Point(150, 350);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 50);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // resultsButton
            // 
            this.resultsButton.BackColor = System.Drawing.Color.LightBlue;
            this.resultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultsButton.Location = new System.Drawing.Point(150, 280);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(200, 50);
            this.resultsButton.TabIndex = 4;
            this.resultsButton.Text = "Мои результаты";
            this.resultsButton.UseVisualStyleBackColor = false;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminButton.Location = new System.Drawing.Point(150, 210);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(200, 50);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Режим администратора";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(150, 140);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 50);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userLabel.Location = new System.Drawing.Point(50, 80);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(400, 30);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Игрок:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(50, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(400, 40);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Добро пожаловать в игру";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Словарный запас";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem startGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}