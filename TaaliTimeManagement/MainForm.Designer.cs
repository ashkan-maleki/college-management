namespace TaaliTimeManagement
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeTableReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.baseInformationToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "پرونده";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // baseInformationToolStripMenuItem
            // 
            this.baseInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.majorToolStripMenuItem1,
            this.groupToolStripMenuItem1,
            this.classToolStripMenuItem1,
            this.subjectTypeToolStripMenuItem1,
            this.subjectToolStripMenuItem1,
            this.timeToolStripMenuItem1,
            this.teacherToolStripMenuItem1});
            this.baseInformationToolStripMenuItem.Name = "baseInformationToolStripMenuItem";
            this.baseInformationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.baseInformationToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // majorToolStripMenuItem1
            // 
            this.majorToolStripMenuItem1.Name = "majorToolStripMenuItem1";
            this.majorToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.majorToolStripMenuItem1.Text = "رشته";
            this.majorToolStripMenuItem1.Click += new System.EventHandler(this.majorToolStripMenuItem1_Click);
            // 
            // groupToolStripMenuItem1
            // 
            this.groupToolStripMenuItem1.Name = "groupToolStripMenuItem1";
            this.groupToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.groupToolStripMenuItem1.Text = "گروه";
            this.groupToolStripMenuItem1.Click += new System.EventHandler(this.groupToolStripMenuItem1_Click);
            // 
            // classToolStripMenuItem1
            // 
            this.classToolStripMenuItem1.Name = "classToolStripMenuItem1";
            this.classToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.classToolStripMenuItem1.Text = "کلاس";
            this.classToolStripMenuItem1.Click += new System.EventHandler(this.classToolStripMenuItem1_Click);
            // 
            // subjectTypeToolStripMenuItem1
            // 
            this.subjectTypeToolStripMenuItem1.Name = "subjectTypeToolStripMenuItem1";
            this.subjectTypeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.subjectTypeToolStripMenuItem1.Text = "نوع درس";
            this.subjectTypeToolStripMenuItem1.Click += new System.EventHandler(this.subjectTypeToolStripMenuItem1_Click);
            // 
            // subjectToolStripMenuItem1
            // 
            this.subjectToolStripMenuItem1.Name = "subjectToolStripMenuItem1";
            this.subjectToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.subjectToolStripMenuItem1.Text = "درس";
            this.subjectToolStripMenuItem1.Click += new System.EventHandler(this.subjectToolStripMenuItem1_Click);
            // 
            // timeToolStripMenuItem1
            // 
            this.timeToolStripMenuItem1.Name = "timeToolStripMenuItem1";
            this.timeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.timeToolStripMenuItem1.Text = "زمان";
            this.timeToolStripMenuItem1.Click += new System.EventHandler(this.timeToolStripMenuItem1_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.teacherToolStripMenuItem1.Text = "استاد";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmingToolStripMenuItem,
            this.timeTableToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.managementToolStripMenuItem.Text = "مدیریت زمانبندی";
            // 
            // programmingToolStripMenuItem
            // 
            this.programmingToolStripMenuItem.Name = "programmingToolStripMenuItem";
            this.programmingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.programmingToolStripMenuItem.Text = "برنامه ریزی";
            this.programmingToolStripMenuItem.Click += new System.EventHandler(this.programmingToolStripMenuItem_Click);
            // 
            // timeTableToolStripMenuItem
            // 
            this.timeTableToolStripMenuItem.Name = "timeTableToolStripMenuItem";
            this.timeTableToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.timeTableToolStripMenuItem.Text = "برنامه";
            this.timeTableToolStripMenuItem.Click += new System.EventHandler(this.timeTableToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeTableReportsToolStripMenuItem,
            this.todayReportToolStripMenuItem,
            this.dailyReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.reportsToolStripMenuItem.Text = "گزارش";
            // 
            // timeTableReportsToolStripMenuItem
            // 
            this.timeTableReportsToolStripMenuItem.Name = "timeTableReportsToolStripMenuItem";
            this.timeTableReportsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.timeTableReportsToolStripMenuItem.Text = "برنامه هفتگی";
            this.timeTableReportsToolStripMenuItem.Click += new System.EventHandler(this.timeTableReportsToolStripMenuItem_Click);
            // 
            // todayReportToolStripMenuItem
            // 
            this.todayReportToolStripMenuItem.Name = "todayReportToolStripMenuItem";
            this.todayReportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.todayReportToolStripMenuItem.Text = "برنامه امروز";
            this.todayReportToolStripMenuItem.Click += new System.EventHandler(this.todayReportToolStripMenuItem_Click);
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dailyReportToolStripMenuItem.Text = "برنامه روزانه";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.windowsToolStripMenuItem.Text = "پنجره ها";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 411);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سیستم مدیریت زمانبندی کلاس ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem majorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subjectTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeTableReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;

    }
}

