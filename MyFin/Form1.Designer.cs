namespace MyFin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.Income = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeYear = new System.Windows.Forms.ToolStripMenuItem();
            this.Costs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostsAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostsDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostsWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostsMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostsYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Balanсe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.доходыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportIncomeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportIncomeDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportIncomeWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportIncomeMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportIncomeYear = new System.Windows.Forms.ToolStripMenuItem();
            this.расходыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportCostsAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportCostsDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportCostsWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportCostsMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportCostsYear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectoryUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectoryIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectoryIncomeCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectoryCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectoryCostsCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.LabelToolBar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAll = new System.Windows.Forms.ToolStripButton();
            this.btnDay = new System.Windows.Forms.ToolStripButton();
            this.btnMonth = new System.Windows.Forms.ToolStripButton();
            this.btnWeek = new System.Windows.Forms.ToolStripButton();
            this.btnYear = new System.Windows.Forms.ToolStripButton();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStatistics,
            this.menuReports,
            this.menuDirectory,
            this.menuSettings,
            this.menuAboutUs});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(584, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuStatistics
            // 
            this.menuStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Income,
            this.Costs,
            this.toolStripMenuItem1,
            this.Balanсe});
            this.menuStatistics.Name = "menuStatistics";
            this.menuStatistics.Size = new System.Drawing.Size(80, 20);
            this.menuStatistics.Text = "Статистика";
            // 
            // Income
            // 
            this.Income.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIncomeAll,
            this.menuIncomeDay,
            this.menuIncomeWeek,
            this.menuIncomeMonth,
            this.menuIncomeYear});
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(180, 22);
            this.Income.Text = "Доходы";
            // 
            // menuIncomeAll
            // 
            this.menuIncomeAll.Name = "menuIncomeAll";
            this.menuIncomeAll.Size = new System.Drawing.Size(180, 22);
            this.menuIncomeAll.Text = "За всё время";
            // 
            // menuIncomeDay
            // 
            this.menuIncomeDay.Name = "menuIncomeDay";
            this.menuIncomeDay.Size = new System.Drawing.Size(180, 22);
            this.menuIncomeDay.Text = "За день";
            // 
            // menuIncomeWeek
            // 
            this.menuIncomeWeek.Name = "menuIncomeWeek";
            this.menuIncomeWeek.Size = new System.Drawing.Size(180, 22);
            this.menuIncomeWeek.Text = "За неделю";
            // 
            // menuIncomeMonth
            // 
            this.menuIncomeMonth.Name = "menuIncomeMonth";
            this.menuIncomeMonth.Size = new System.Drawing.Size(180, 22);
            this.menuIncomeMonth.Text = "За месяц";
            // 
            // menuIncomeYear
            // 
            this.menuIncomeYear.Name = "menuIncomeYear";
            this.menuIncomeYear.Size = new System.Drawing.Size(180, 22);
            this.menuIncomeYear.Text = "За год";
            // 
            // Costs
            // 
            this.Costs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCostsAll,
            this.menuCostsDay,
            this.menuCostsWeek,
            this.menuCostsMonth,
            this.menuCostsYear});
            this.Costs.Name = "Costs";
            this.Costs.Size = new System.Drawing.Size(180, 22);
            this.Costs.Text = "Расходы";
            // 
            // menuCostsAll
            // 
            this.menuCostsAll.Name = "menuCostsAll";
            this.menuCostsAll.Size = new System.Drawing.Size(180, 22);
            this.menuCostsAll.Text = "За всё время";
            // 
            // menuCostsDay
            // 
            this.menuCostsDay.Name = "menuCostsDay";
            this.menuCostsDay.Size = new System.Drawing.Size(180, 22);
            this.menuCostsDay.Text = "За день";
            // 
            // menuCostsWeek
            // 
            this.menuCostsWeek.Name = "menuCostsWeek";
            this.menuCostsWeek.Size = new System.Drawing.Size(180, 22);
            this.menuCostsWeek.Text = "За неделю";
            // 
            // menuCostsMonth
            // 
            this.menuCostsMonth.Name = "menuCostsMonth";
            this.menuCostsMonth.Size = new System.Drawing.Size(180, 22);
            this.menuCostsMonth.Text = "За месяц";
            // 
            // menuCostsYear
            // 
            this.menuCostsYear.Name = "menuCostsYear";
            this.menuCostsYear.Size = new System.Drawing.Size(180, 22);
            this.menuCostsYear.Text = "За год";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // Balanсe
            // 
            this.Balanсe.Name = "Balanсe";
            this.Balanсe.Size = new System.Drawing.Size(180, 22);
            this.Balanсe.Text = "Баланс";
            // 
            // menuReports
            // 
            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доходыToolStripMenuItem1,
            this.расходыToolStripMenuItem1});
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(60, 20);
            this.menuReports.Text = "Отчеты";
            // 
            // доходыToolStripMenuItem1
            // 
            this.доходыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportIncomeAll,
            this.menuReportIncomeDay,
            this.menuReportIncomeWeek,
            this.menuReportIncomeMonth,
            this.menuReportIncomeYear});
            this.доходыToolStripMenuItem1.Name = "доходыToolStripMenuItem1";
            this.доходыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.доходыToolStripMenuItem1.Text = "Доходы";
            // 
            // menuReportIncomeAll
            // 
            this.menuReportIncomeAll.Name = "menuReportIncomeAll";
            this.menuReportIncomeAll.Size = new System.Drawing.Size(180, 22);
            this.menuReportIncomeAll.Text = "За всё время";
            // 
            // menuReportIncomeDay
            // 
            this.menuReportIncomeDay.Name = "menuReportIncomeDay";
            this.menuReportIncomeDay.Size = new System.Drawing.Size(180, 22);
            this.menuReportIncomeDay.Text = "За день";
            // 
            // menuReportIncomeWeek
            // 
            this.menuReportIncomeWeek.Name = "menuReportIncomeWeek";
            this.menuReportIncomeWeek.Size = new System.Drawing.Size(180, 22);
            this.menuReportIncomeWeek.Text = "За неделю";
            // 
            // menuReportIncomeMonth
            // 
            this.menuReportIncomeMonth.Name = "menuReportIncomeMonth";
            this.menuReportIncomeMonth.Size = new System.Drawing.Size(180, 22);
            this.menuReportIncomeMonth.Text = "За месяц";
            // 
            // menuReportIncomeYear
            // 
            this.menuReportIncomeYear.Name = "menuReportIncomeYear";
            this.menuReportIncomeYear.Size = new System.Drawing.Size(180, 22);
            this.menuReportIncomeYear.Text = "За год";
            // 
            // расходыToolStripMenuItem1
            // 
            this.расходыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportCostsAll,
            this.menuReportCostsDay,
            this.menuReportCostsWeek,
            this.menuReportCostsMonth,
            this.menuReportCostsYear});
            this.расходыToolStripMenuItem1.Name = "расходыToolStripMenuItem1";
            this.расходыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.расходыToolStripMenuItem1.Text = "Расходы";
            // 
            // menuReportCostsAll
            // 
            this.menuReportCostsAll.Name = "menuReportCostsAll";
            this.menuReportCostsAll.Size = new System.Drawing.Size(180, 22);
            this.menuReportCostsAll.Text = "За всё время";
            // 
            // menuReportCostsDay
            // 
            this.menuReportCostsDay.Name = "menuReportCostsDay";
            this.menuReportCostsDay.Size = new System.Drawing.Size(180, 22);
            this.menuReportCostsDay.Text = "За день";
            // 
            // menuReportCostsWeek
            // 
            this.menuReportCostsWeek.Name = "menuReportCostsWeek";
            this.menuReportCostsWeek.Size = new System.Drawing.Size(180, 22);
            this.menuReportCostsWeek.Text = "За неделю";
            // 
            // menuReportCostsMonth
            // 
            this.menuReportCostsMonth.Name = "menuReportCostsMonth";
            this.menuReportCostsMonth.Size = new System.Drawing.Size(180, 22);
            this.menuReportCostsMonth.Text = "За месяц";
            // 
            // menuReportCostsYear
            // 
            this.menuReportCostsYear.Name = "menuReportCostsYear";
            this.menuReportCostsYear.Size = new System.Drawing.Size(180, 22);
            this.menuReportCostsYear.Text = "За год";
            // 
            // menuDirectory
            // 
            this.menuDirectory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDirectoryUsers,
            this.menuDirectoryIncome,
            this.menuDirectoryIncomeCategory,
            this.menuDirectoryCosts,
            this.menuDirectoryCostsCategory});
            this.menuDirectory.Name = "menuDirectory";
            this.menuDirectory.Size = new System.Drawing.Size(94, 20);
            this.menuDirectory.Text = "Справочники";
            // 
            // menuDirectoryUsers
            // 
            this.menuDirectoryUsers.Name = "menuDirectoryUsers";
            this.menuDirectoryUsers.Size = new System.Drawing.Size(184, 22);
            this.menuDirectoryUsers.Text = "Пользователи";
            // 
            // menuDirectoryIncome
            // 
            this.menuDirectoryIncome.Name = "menuDirectoryIncome";
            this.menuDirectoryIncome.Size = new System.Drawing.Size(184, 22);
            this.menuDirectoryIncome.Text = "Доходы";
            // 
            // menuDirectoryIncomeCategory
            // 
            this.menuDirectoryIncomeCategory.Name = "menuDirectoryIncomeCategory";
            this.menuDirectoryIncomeCategory.Size = new System.Drawing.Size(184, 22);
            this.menuDirectoryIncomeCategory.Text = "Категории доходов";
            // 
            // menuDirectoryCosts
            // 
            this.menuDirectoryCosts.Name = "menuDirectoryCosts";
            this.menuDirectoryCosts.Size = new System.Drawing.Size(184, 22);
            this.menuDirectoryCosts.Text = "Расходы";
            // 
            // menuDirectoryCostsCategory
            // 
            this.menuDirectoryCostsCategory.Name = "menuDirectoryCostsCategory";
            this.menuDirectoryCostsCategory.Size = new System.Drawing.Size(184, 22);
            this.menuDirectoryCostsCategory.Text = "Категории расходов";
            // 
            // menuSettings
            // 
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemes,
            this.toolStripMenuItem2,
            this.menuToolStrip});
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(79, 20);
            this.menuSettings.Text = "Настройки";
            // 
            // menuThemes
            // 
            this.menuThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.светлаяToolStripMenuItem,
            this.темнаяToolStripMenuItem});
            this.menuThemes.Name = "menuThemes";
            this.menuThemes.Size = new System.Drawing.Size(196, 22);
            this.menuThemes.Text = "Выбрать тему";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(196, 22);
            this.menuToolStrip.Text = "Панель инструментов";
            // 
            // menuAboutUs
            // 
            this.menuAboutUs.Name = "menuAboutUs";
            this.menuAboutUs.Size = new System.Drawing.Size(94, 20);
            this.menuAboutUs.Text = "О программе";
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelToolBar,
            this.toolStripSeparator1,
            this.btnAll,
            this.btnDay,
            this.btnWeek,
            this.btnMonth,
            this.btnYear});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(584, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // LabelToolBar
            // 
            this.LabelToolBar.Name = "LabelToolBar";
            this.LabelToolBar.Size = new System.Drawing.Size(75, 22);
            this.LabelToolBar.Text = "LabelToolBar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAll
            // 
            this.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 22);
            this.btnAll.Text = "За всё время";
            // 
            // btnDay
            // 
            this.btnDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDay.Image = ((System.Drawing.Image)(resources.GetObject("btnDay.Image")));
            this.btnDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(52, 22);
            this.btnDay.Text = "За день";
            // 
            // btnMonth
            // 
            this.btnMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnMonth.Image")));
            this.btnMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(61, 22);
            this.btnMonth.Text = "За месяц";
            // 
            // btnWeek
            // 
            this.btnWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWeek.Image = ((System.Drawing.Image)(resources.GetObject("btnWeek.Image")));
            this.btnWeek.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(69, 22);
            this.btnWeek.Text = "За неделю";
            // 
            // btnYear
            // 
            this.btnYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnYear.Image = ((System.Drawing.Image)(resources.GetObject("btnYear.Image")));
            this.btnYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(45, 22);
            this.btnYear.Text = "За год";
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            // 
            // темнаяToolStripMenuItem
            // 
            this.темнаяToolStripMenuItem.Name = "темнаяToolStripMenuItem";
            this.темнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.темнаяToolStripMenuItem.Text = "Темная";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "MyFin";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStatistics;
        private System.Windows.Forms.ToolStripMenuItem Income;
        private System.Windows.Forms.ToolStripMenuItem menuIncomeAll;
        private System.Windows.Forms.ToolStripMenuItem menuIncomeDay;
        private System.Windows.Forms.ToolStripMenuItem menuIncomeWeek;
        private System.Windows.Forms.ToolStripMenuItem menuIncomeMonth;
        private System.Windows.Forms.ToolStripMenuItem menuIncomeYear;
        private System.Windows.Forms.ToolStripMenuItem Costs;
        private System.Windows.Forms.ToolStripMenuItem menuCostsAll;
        private System.Windows.Forms.ToolStripMenuItem menuCostsDay;
        private System.Windows.Forms.ToolStripMenuItem menuCostsWeek;
        private System.Windows.Forms.ToolStripMenuItem menuCostsMonth;
        private System.Windows.Forms.ToolStripMenuItem menuCostsYear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Balanсe;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem доходыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuReportIncomeAll;
        private System.Windows.Forms.ToolStripMenuItem menuReportIncomeDay;
        private System.Windows.Forms.ToolStripMenuItem menuReportIncomeWeek;
        private System.Windows.Forms.ToolStripMenuItem menuReportIncomeMonth;
        private System.Windows.Forms.ToolStripMenuItem menuReportIncomeYear;
        private System.Windows.Forms.ToolStripMenuItem расходыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuReportCostsAll;
        private System.Windows.Forms.ToolStripMenuItem menuReportCostsDay;
        private System.Windows.Forms.ToolStripMenuItem menuReportCostsWeek;
        private System.Windows.Forms.ToolStripMenuItem menuReportCostsMonth;
        private System.Windows.Forms.ToolStripMenuItem menuReportCostsYear;
        private System.Windows.Forms.ToolStripMenuItem menuDirectory;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuThemes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuAboutUs;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripLabel LabelToolBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAll;
        private System.Windows.Forms.ToolStripButton btnDay;
        private System.Windows.Forms.ToolStripButton btnMonth;
        private System.Windows.Forms.ToolStripButton btnWeek;
        private System.Windows.Forms.ToolStripButton btnYear;
        private System.Windows.Forms.ToolStripMenuItem menuDirectoryUsers;
        private System.Windows.Forms.ToolStripMenuItem menuDirectoryIncome;
        private System.Windows.Forms.ToolStripMenuItem menuDirectoryIncomeCategory;
        private System.Windows.Forms.ToolStripMenuItem menuDirectoryCosts;
        private System.Windows.Forms.ToolStripMenuItem menuDirectoryCostsCategory;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem;
    }
}

